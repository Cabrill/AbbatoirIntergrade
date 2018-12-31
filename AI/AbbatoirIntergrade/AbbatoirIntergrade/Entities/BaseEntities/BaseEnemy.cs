using System;
using System.Threading;
using AbbatoirIntergrade.Entities.Projectiles;
using AbbatoirIntergrade.StaticManagers;
using AbbatoirIntergrade.UtilityClasses;
using Accord.Genetic;
using FlatRedBall;
using FlatRedBall.AI.Pathfinding;
using FlatRedBall.Graphics.Animation;
using FlatRedBall.Instructions;
using FlatRedBall.Math;
using FlatRedBall.Math.Geometry;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using StateInterpolationPlugin;

namespace AbbatoirIntergrade.Entities.BaseEntities
{
	public partial class BaseEnemy
	{
        private bool _AddedToLayers = false;

        public event Action<BaseEnemy> OnDeath;
	    public float Altitude { get; protected set; }
	    protected float AltitudeVelocity { get; set; }
	    protected virtual float GravityDrag { get; set; } = -650f;

        public double HealthRemaining { get; set; }

        public bool IsDead => HealthRemaining <= 0;
	    protected bool IsHurt => CurrentActionState == Action.Hurt;
	    protected bool IsPoisoned => _poisonedDurationSeconds > 0;
	    protected bool IsFrozen => _frostDurationSeconds > 0;
	    protected bool IsStunned => _stunnedDurationSeconds > 0;
	    protected bool IsBurning => _burnDurationSeconds > 0;
	    private double _frostDurationSeconds;
	    private double _poisonedDurationSeconds;
	    private double _stunnedDurationSeconds;
	    private double _burnDurationSeconds;

	    private double _poisonDamagePerSecond;
	    private double _frostDamagePerSecond;
	    private double _burnDamagePerSecond;

	    private bool IsOnFinalFrameOfAnimation => SpriteInstance.CurrentFrameIndex == SpriteInstance.CurrentChain.Count - 1;

        private float? _startingShadowWidth;
	    private float _startingShadowHeight;
	    private float _startingShadowAlpha;
	    private AnimationChainList spriteAnimationChainList;
	    private bool IsDrowning => CurrentActionState == Action.Drowning;

        protected float _spriteRelativeY;
	    private float maxFrameHeight;

        protected SoundEffectInstance DeathSound;
	    protected SoundEffectInstance drowningSound;

	    private bool isHorde;

	    private int flyingFinalDeathAnimationFrameIndex = 15;

	    private bool deathAnimationFinished;


        /// <summary>
        /// Initialization logic which is execute only one time for this Entity (unless the Entity is pooled).
        /// This method is called when the Entity is added to managers. Entities which are instantiated but not
        /// added to managers will not have this method called.
        /// </summary>
		private void CustomInitialize()
		{
#if DEBUG
		    if (DebugVariables.ShowDebugShapes)
		    {
		        SelfCollisionCircle.Visible = true;

                if (CircleInstance != null) CircleInstance.Visible = true;
                if (AxisAlignedRectangleInstance != null) AxisAlignedRectangleInstance.Visible = true;
		    }
		    else
#endif
		    {
		        SelfCollisionCircle.Visible = false;
                if (CircleInstance != null) CircleInstance.Visible = false;
		        if (AxisAlignedRectangleInstance != null) AxisAlignedRectangleInstance.Visible = false;
            }

		    if (!_startingShadowWidth.HasValue)
		    {
		        _startingShadowWidth = ShadowSprite.Width;
		        _startingShadowHeight = ShadowSprite.Height;
		        _startingShadowAlpha = ShadowSprite.Alpha;

		        _spriteRelativeY = SpriteInstance.Height / 2;
		        spriteAnimationChainList = SpriteInstance.AnimationChains;

		        PoisonedParticles.ScaleX = SpriteInstance.Width / 2;
		        PoisonedParticles.ScaleY = SpriteInstance.Height / 2;
		        PoisonedParticles.RelativeY = SpriteInstance.Height / 2;

		        FrozenParticles.ScaleX = SpriteInstance.Width / 2;
		        FrozenParticles.ScaleY = SpriteInstance.Height / 2;
		        FrozenParticles.RelativeY = SpriteInstance.Height / 2;

		        SmokeParticles.ScaleX = SpriteInstance.Width / 2;
		        SmokeParticles.ScaleY = SpriteInstance.Height / 2;
		        SmokeParticles.RelativeY = SpriteInstance.Height / 2;

		        StunParticles.ScaleX = SpriteInstance.Width / 2;
		        StunParticles.ScaleY = SpriteInstance.Height / 2;
		        StunParticles.RelativeY = SpriteInstance.Height / 2;

		        //var healthbarWidth = (SpriteInstance.AnimationChains[0][0].RightCoordinate -
		        //                      SpriteInstance.AnimationChains[0][0].LeftCoordinate) * SpriteInstance.AnimationChains[0][0].Texture.Width;


		        maxFrameHeight = GetMaxFrameHeight();
            }

            HealthBar.SetWidth(150f);

		    if (drowningSound == null || drowningSound.IsDisposed)
		    {
		        drowningSound = DrowningSound.CreateInstance();
		    }

		    deathAnimationFinished = false;

            //HealthBar.AttachTo(SpriteInstance, true);
            HealthBar.RelativeY = HealthBar.Height + maxFrameHeight + Altitude;

            SpriteInstance.AnimationChains = spriteAnimationChainList;

		    ShadowSprite.Visible = true;
		    ShadowSprite.RelativeY = 0;
            
            HasReachedGoal = false;

            HealthBar.Hide();

            HealthRemaining = MaximumHealth;
		    Altitude = 0f;
		    AltitudeVelocity = 0f;

		    _poisonedDurationSeconds = 0;
		    _frostDurationSeconds = 0;
		    _burnDurationSeconds = 0;
		    _stunnedDurationSeconds = 0;

		    EffectiveSpeed = BaseSpeed;

            CurrentStatusState = Status.Normal;

            SetBaseAttributes();

		    SetGenetics();

            UpdateSpritesRelativeY();
		}

	    private void SetBaseAttributes()
	    {
	        var enemyName = GetType().Name.Replace("Enemy", "");
	        var csvEntry = GlobalContent.Enemy_Attributes[enemyName];

	        BaseHealth = csvEntry.Health;
	        BaseSpeed = csvEntry.Speed;

	        BaseBombardResist = csvEntry.BombardResist;
	        BasePiercingResist = csvEntry.PiercingResist;
	        BaseChemicalResist = csvEntry.ChemicalResist;
	        BaseFrostResist = csvEntry.FrostResist;
	        BaseFireResist = csvEntry.FireResist;
	        BaseElectricResist = csvEntry.ElectricResist;
	        IsFlying = csvEntry.IsFlying;
	    }

	    private float GetMaxFrameHeight()
	    {
	        if (!SpriteInstanceAnimate || SpriteInstance.CurrentChain.Count == 1) return SpriteInstance.Height;
	        else
	        {
	            var largestHeight = 0f;
	            for (var i = 0; i < SpriteInstance.CurrentChain.Count - 1; i++)
	            {
	                var frame = SpriteInstance.CurrentChain[i];
	                largestHeight = Math.Max(largestHeight, (frame.BottomCoordinate - frame.TopCoordinate) * frame.Texture.Height);
	            }
	            return largestHeight;
	        }
	    }

	    private void CustomActivity()
		{
		    UpdateStatusEffect();

            if (!IsFlying || IsDead || IsStunned || IsHurt)
		    {
                AltitudeVelocity += GravityDrag * TimeManager.SecondDifference;

		        if (IsFlying && IsHurt && !IsStunned && IsOnFinalFrameOfAnimation)
		        {
		            CurrentActionState = Action.Standing;
                    SpriteInstance.Animate = true;
		        }
            }
            else if (IsFlying)
            {
                if (Altitude < 300) AltitudeVelocity += 10;
                else AltitudeVelocity = 0;
            }

		    var isFallingOrAscending = AltitudeVelocity > 0 || (Altitude > 0 && AltitudeVelocity < 0);
            if (isFallingOrAscending)
		    {
                //Remove drag in the air
		        Drag = 0.1f;
		        Altitude = Math.Max(0, Altitude + AltitudeVelocity * TimeManager.SecondDifference);

                //Just hit the ground.  take some damage?
		        if (!IsFlying && !IsDead && Altitude <= 0)
		        {
		            var dmg = (AltitudeVelocity / (10* GravityDrag)) * MaximumHealth;
                    TakeDamage(dmg);
		        }

		        if (IsFlying && IsDead && SpriteInstance.CurrentFrameIndex == flyingFinalDeathAnimationFrameIndex)
		            SpriteInstance.Animate = false;
		        if (IsHurt && IsOnFinalFrameOfAnimation && !IsFlying) SpriteInstance.Animate = false;
		    }

		    var isOnGround = Math.Abs(Altitude) <= 0.001f && AltitudeVelocity < 0;
            if (isOnGround)
            {
                //Reset drag by setting state
                CurrentActionState = CurrentActionState;
                Altitude = 0;
		        AltitudeVelocity = 0;
                if (!IsStunned || IsFlying) SpriteInstance.Animate = true;
            }

            if (IsDead)
		    {
                PerformDeath();
		    }
		    else if (IsHurt && SpriteInstance.JustCycled)
		    {
		        CurrentActionState = Action.Standing;
		    }

		    if (!IsDead)
		    {
		        UpdateNavigationTargetProgress();

		        if (!IsHurt)
		        {
		            NavigateToTarget();
		            SetDirection();
                }
            }

		    UpdateSpritesRelativeY();
		    UpdateHealthBar();
		}

        internal static void Initialize(Polygon pathing, TileNodeNetwork pathingNodeNetwork)
        {
            PathingLine = pathing;
            NodeNetwork = pathingNodeNetwork;

            if (PathingLine != null)
            {
                UpdatePathingValues();
            }
        }

        public void UpdateSpritesRelativeY()
	    {
	        if (IsStunned)
	        {
	            SpriteInstance.RelativeY = Altitude + _spriteRelativeY +
	                                       SpriteInstance.CurrentChain[SpriteInstance.CurrentFrameIndex].RelativeY + FlatRedBallServices.Random.Next(-5, 5);
	            SpriteInstance.RelativeX = SpriteInstance.CurrentChain[SpriteInstance.CurrentFrameIndex].RelativeX +
	                                       FlatRedBallServices.Random.Next(-5, 5);
	        }
	        else
	        {
	            SpriteInstance.RelativeY = Altitude + _spriteRelativeY +
	                                       SpriteInstance.CurrentChain[SpriteInstance.CurrentFrameIndex].RelativeY;
	        }

	        var pctLightShadow = MathHelper.Clamp(1 - (Altitude / (800)), 0, 1);

	        ShadowSprite.Width = _startingShadowWidth.Value * pctLightShadow;
	        ShadowSprite.Height = _startingShadowHeight * pctLightShadow;
	        ShadowSprite.Alpha = _startingShadowAlpha * pctLightShadow;
        }

	    private void SetDirection()
	    {
	        CurrentDirectionState =
	            (Velocity.X < 0 ? Direction.MovingLeft : Direction.MovingRight);
	        SpriteInstance.IgnoreAnimationChainTextureFlip = true;
	    }

        private void UpdateHealthBar()
	    {
	        if (IsDead || HealthRemaining >= MaximumHealth)
	        {
	            HealthBar.Hide();
	        }
	        else
	        {
	            HealthBar.RelativeX = 0;
	            HealthBar.RelativeY = HealthBar.Height + maxFrameHeight + Altitude;
                HealthBar.Update(HealthRemaining/MaximumHealth);
            }
        }

	    private void TakeDamage(double dmgAmount)
	    {
	        HealthRemaining -= dmgAmount;

	        if (HealthRemaining <= 0)
	        {
	            PerformDeath();
	        }
        }

        public void GetHitBy(BasePlayerProjectile projectile, float dmgMultiplier = 1)
        {
            if (isHorde) return;

            var effectiveMultiplier = GetEffectiveMultiplier(projectile.DamageType);
            var dmgInflicted = effectiveMultiplier * projectile.DamageInflicted * dmgMultiplier;
            TakeDamage(dmgInflicted);

            var shouldBeHurt = true;

	        switch (projectile.DamageType)
	        {
	            case DamageTypes.Frost:
	                _frostDurationSeconds = projectile.StatusEffectSeconds * effectiveMultiplier;
	                _frostDamagePerSecond = dmgInflicted * projectile.StatusDamageMultiplier;
	                _burnDurationSeconds = 0;
	                shouldBeHurt = false;
                    break;
	            case DamageTypes.Chemical:
	                _poisonedDurationSeconds = projectile.StatusEffectSeconds * effectiveMultiplier;
	                _poisonDamagePerSecond = dmgInflicted * projectile.StatusDamageMultiplier;
	                shouldBeHurt = false;
                    break;
	            case DamageTypes.Electrical:
	                _stunnedDurationSeconds = projectile.StatusEffectSeconds * effectiveMultiplier;
                    break;
	            case DamageTypes.Fire:
	                _burnDurationSeconds = projectile.StatusEffectSeconds * effectiveMultiplier;
	                _burnDamagePerSecond = dmgInflicted * projectile.StatusDamageMultiplier;
	                _frostDurationSeconds = 0;
                    break;
            }
	        UpdateStatusEffect(justApplied: true);

	        if (!IsDead && shouldBeHurt)
	        {
                CurrentActionState = Action.Hurt;
                SpriteInstance.UpdateToCurrentAnimationFrame();
	            UpdateSpritesRelativeY();
	        }
	    }

	    private double GetEffectiveMultiplier(DamageTypes damageType)
	    {
	        switch (damageType)
	        {
	            case DamageTypes.Frost: return (1f - EffectiveFrostResist);
	            case DamageTypes.Chemical: return (1f - EffectiveChemicalResist);
	            case DamageTypes.Electrical: return (1f - BaseElectricResist);
	            case DamageTypes.Piercing: return (1f -EffectivePiercingResist);
                case DamageTypes.Bombarding: return (1f - EffectiveBombardResist);
                case DamageTypes.Fire: return (1f - EffectiveFireResist);
                default: return 1;
            }
        }

	    private void UpdateStatusEffect(bool justApplied = false)
	    {
	        if (!justApplied)
	        {
	            if (IsPoisoned)
	            {
	                _poisonedDurationSeconds -= TimeManager.SecondDifference;
	            }
	            if (IsFrozen)
	            {
	                _frostDurationSeconds -= TimeManager.SecondDifference;
	            }
	            if (IsStunned)
	            {
	                _stunnedDurationSeconds -= TimeManager.SecondDifference;
	            }
	            if (IsBurning)
	            {
	                _burnDurationSeconds -= TimeManager.SecondDifference;
	            }
	        }

	        if (IsFrozen && IsPoisoned)
	        {
	            CurrentStatusState = Status.FrozenAndPoisoned;
	            EffectiveSpeed = BaseSpeed * (1 - (float)(GetEffectiveMultiplier(DamageTypes.Frost) * 0.8 +
	                                     GetEffectiveMultiplier(DamageTypes.Chemical) * 0.2));

                PoisonedParticles.RelativeY = Altitude + SpriteInstance.Height / 2;
	            FrozenParticles.RelativeY = Altitude + SpriteInstance.Height / 2;
            }
            else if (IsBurning && IsPoisoned)
	        {
	            CurrentStatusState = Status.BurningAndPoisoned;
	            EffectiveSpeed = BaseSpeed * (1 - (float)(GetEffectiveMultiplier(DamageTypes.Chemical) * 0.2));

	            SmokeParticles.RelativeY = Altitude + SpriteInstance.Height / 2;
	            PoisonedParticles.RelativeY = Altitude + SpriteInstance.Height / 2;
            }
            else if (IsBurning)
	        {
	            CurrentStatusState = Status.Burning;
	            SmokeParticles.RelativeY = Altitude + SpriteInstance.Height / 2;
            }
            else if (IsFrozen)
	        {
	            CurrentStatusState = Status.Frozen;
	            EffectiveSpeed = BaseSpeed * (1 - (float)(GetEffectiveMultiplier(DamageTypes.Frost) * 0.8));
	            FrozenParticles.RelativeY = Altitude + SpriteInstance.Height / 2;
            }
            else if (IsPoisoned)
	        {
	            CurrentStatusState = Status.Poisoned;
	            EffectiveSpeed = BaseSpeed * (1 - (float)(GetEffectiveMultiplier(DamageTypes.Chemical) * 0.2));
	            PoisonedParticles.RelativeY = Altitude + SpriteInstance.Height / 2;
            }
            else if (IsStunned)
	        {
	            EffectiveSpeed = 0f;
	            StunParticles.RelativeY = Altitude + SpriteInstance.Height / 2;
            }
	        else
	        {
	            CurrentStatusState = Status.Normal;
	            EffectiveSpeed = BaseSpeed;
	        }

            if (!IsFlying && (EffectiveSpeed <= 0.01f || IsStunned))
	        {
	            SpriteInstanceAnimate = false;
	        }
	        else
	        {
	            SpriteInstanceAnimate = true;
	            SpriteInstance.AnimationSpeed = EffectiveSpeed / BaseSpeed;
	        }

	        if (!justApplied)
	        {
	            if (IsPoisoned) TakeDamage(_poisonDamagePerSecond * TimeManager.SecondDifference);
                if (IsFrozen) TakeDamage(_frostDamagePerSecond * TimeManager.SecondDifference);
                if (IsBurning) TakeDamage(_burnDamagePerSecond * TimeManager.SecondDifference);
            }
        }

	    private void PerformDeath()
	    {
	        if (deathAnimationFinished) return;

            if (!IsDrowning && CurrentActionState != Action.Dying)
	        {
	            OnDeath?.Invoke(this);
	            OnDeath -= OnDeath;
                CurrentActionState = Action.Dying;
	            PlayDeathSound();
            }

	        if (SpriteInstanceAnimate && IsOnFinalFrameOfAnimation)
	        {
	            SpriteInstanceAnimate = false;
	        }

            if (Altitude <=0f && IsOnFinalFrameOfAnimation)
            {
                if (IsDrowning)
                {
                    OnDeath?.Invoke(this);
                    OnDeath -= OnDeath;
                }
                deathAnimationFinished = true;
                this.Call(() =>
                {
                    RemoveArrows();
                    Destroy();
                }).After(2f);
            }
	    }

	    private void PlayDeathSound()
	    {
	        var pan = Position.X / Camera.Main.OrthogonalWidth;
            DeathSound.Pan = pan;
	        SoundManager.PlaySoundEffect(DeathSound);
	    }

	    private void RemoveArrows()
	    {
	        for (var i = SpriteInstance.Children.Count-1; i >= 0; i--)
	        {
	            var child = SpriteInstance.Children[i];

	            if (child is PiercingProjectile projectile)
	            {
                    projectile.Instructions.Clear();
	                TweenerManager.Self.StopAllTweenersOwnedBy(projectile);
                    projectile.Destroy();
	            }
	        }
	    }

	    private void CustomDestroy()
		{
		    if (drowningSound != null && !drowningSound.IsDisposed)
		    {
                drowningSound.Stop(true);
                drowningSound.Dispose();
		    }

		    if (DeathSound != null && !DeathSound.IsDisposed) 
		    {
		        DeathSound.Stop(true);
		        DeathSound.Dispose();
            }

		    OnDeath = null;
		}

        private static void CustomLoadStaticContent(string contentManagerName)
        {


        }

	    public void ReactToExplosion(BasePlayerProjectile projectile, float amplitude, Vector3 velocity, float altitudeVelocity)
	    {
	        GetHitBy(projectile, amplitude);

            AltitudeVelocity += altitudeVelocity;

	        Velocity = velocity;
	    }

	    protected void AddSpritesToLayers(FlatRedBall.Graphics.Layer worldLayer, FlatRedBall.Graphics.Layer darknessLayer, FlatRedBall.Graphics.Layer hudLayer)
	    {
	        if (_AddedToLayers)
	        {
	            darknessLayer.Remove(LightSprite);
	            if (CircleInstance != null) hudLayer.Remove(CircleInstance);
	            if (AxisAlignedRectangleInstance != null) hudLayer.Remove(AxisAlignedRectangleInstance);
	        }

	        StunParticles.LayerToEmitOn = worldLayer;
	        PoisonedParticles.LayerToEmitOn = worldLayer;
	        FrozenParticles.LayerToEmitOn = worldLayer;
            SmokeParticles.LayerToEmitOn = worldLayer;

            HealthBar.MoveToLayer(hudLayer);
            SpriteManager.AddToLayer(SpriteInstance, worldLayer);
            SpriteManager.AddToLayer(LightSprite, darknessLayer);
	        SpriteManager.AddToLayer(ShadowSprite, worldLayer);
            if (CircleInstance != null) ShapeManager.AddToLayer(CircleInstance, hudLayer);
	        if (AxisAlignedRectangleInstance != null) ShapeManager.AddToLayer(AxisAlignedRectangleInstance, hudLayer);

            _AddedToLayers = true;
	    }

	    public void HandleDrowning()
	    {
	        if (IsDrowning) return;

	        _frostDurationSeconds = 0;
	        _burnDurationSeconds = 0;
	        _poisonedDurationSeconds = 0;
	        _stunnedDurationSeconds = 0;

            RemoveArrows();

	        PlayDrowningSound();
	        SpriteInstance.AnimationChains = ParticleAnimationsChainList;
	        ShadowSprite.Visible = false;
	        CurrentActionState = Action.Drowning;
	        SpriteInstance.RelativeY = 0;
            HealthRemaining = 0;
	        Velocity = Vector3.Zero;
	    }

	    private void PlayDrowningSound()
	    {
	        var pan = Position.X / Camera.Main.OrthogonalWidth;
	        drowningSound.Pan = pan;
	        SoundManager.PlaySoundEffect(drowningSound);
	    }

	    public EnemyTypes GetEnemyType()
	    {
	        var enemyName = GetType().Name.Replace("Enemy", "");
	        var enemyType = (EnemyTypes)Enum.Parse(typeof(EnemyTypes), enemyName);

	        return enemyType;
	    }
	}
}
