using System;
using System.Threading;
using FlatRedBall;
using FlatRedBall.Math;
using FlatRedBall.Math.Geometry;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;

namespace AbbatoirIntergrade.Entities.BaseEntities
{
	public partial class BaseEnemy
	{
        private bool _AddedToLayers = false;

        public event Action<BaseEnemy> OnDeath;
	    public float Altitude { get; protected set; }
	    protected float AltitudeVelocity { get; set; }
	    protected float GravityDrag { get; set; } = -650f;

        public double HealthRemaining { get; set; }

        public bool IsDead => HealthRemaining <= 0;
	    private bool IsHurt => CurrentActionState == Action.Hurt;
	    protected bool IsPoisoned => _poisonedDurationSeconds > 0;
	    protected bool IsFrozen => _frozenDurationSeconds > 0;
	    protected bool IsStunned => _stunnedDurationSeconds > 0;
	    private double _frozenDurationSeconds;
	    private double _poisonedDurationSeconds;
	    private double _stunnedDurationSeconds;

	    private double _poisonDamagePerSecond;
	    

	    private bool IsOnFinalFrameOfAnimation => SpriteInstance.CurrentFrameIndex == SpriteInstance.CurrentChain.Count - 1;

        private float? _startingShadowWidth;
	    private float _startingShadowHeight;
	    private float _startingShadowAlpha;
	    private float _startingLightScale;

        protected float _spriteRelativeY;

        protected SoundEffectInstance rangedChargeSound;
	    protected SoundEffectInstance rangedAttackSound;
	    protected SoundEffectInstance meleeAttackSound;


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
                if (CircleInstance != null) CircleInstance.Visible = true;
		        if (AxisAlignedRectangleInstance != null) AxisAlignedRectangleInstance.Visible = true;
		    }
		    else
#endif
		    {
		        if (CircleInstance != null) CircleInstance.Visible = false;
		        if (AxisAlignedRectangleInstance != null) AxisAlignedRectangleInstance.Visible = false;
            }

		    if (!_startingShadowWidth.HasValue)
		    {
		        _startingLightScale = LightSprite.TextureScale;
		        _startingShadowWidth = ShadowSprite.Width;
		        _startingShadowHeight = ShadowSprite.Height;
		        _startingShadowAlpha = ShadowSprite.Alpha;

		        _spriteRelativeY = SpriteInstance.Height / 2;
            }

		    ShadowSprite.RelativeY = 0;
            HasReachedGoal = false;

            HealthBar.X = X;
		    HealthBar.Y = Y;
            HealthBar.SetRelativeY(SpriteInstance.Height);
            HealthBar.SetWidth(SpriteInstance.Width);
            HealthBar.Hide();

            HealthRemaining = MaximumHealth;
		    Altitude = 0f;
		    AltitudeVelocity = 0f;
		    _poisonedDurationSeconds = 0;
		    _frozenDurationSeconds = 0;
		    Speed = BaseSpeed;

		    PoisonedParticles.ScaleX = SpriteInstance.Width/2;
		    PoisonedParticles.ScaleY = SpriteInstance.Height / 2;
		    PoisonedParticles.RelativeY = SpriteInstance.Height / 2;
		    PoisonedParticles.TimedEmission = false;

		    FrozenParticles.ScaleX = SpriteInstance.Width / 2;
		    FrozenParticles.ScaleY = SpriteInstance.Height / 2;
		    FrozenParticles.RelativeY = SpriteInstance.Height / 2;
		    FrozenParticles.TimedEmission = false;


            UpdateAnimation();
		}

		private void CustomActivity()
		{
            UpdateStatusEffect();

            if (!IsFlying || (IsFlying && IsDead))
		    {
                AltitudeVelocity += GravityDrag * TimeManager.SecondDifference;
            }

		    if (AltitudeVelocity > 0 || (Altitude > 0 && AltitudeVelocity < 0))
		    {
                //Remove drag in the air
		        Drag = 0.1f;
		        Altitude = Math.Max(0, Altitude + AltitudeVelocity * TimeManager.SecondDifference);
		        if (IsHurt && IsOnFinalFrameOfAnimation) SpriteInstance.Animate = false;
		    }

            if (Math.Abs(Altitude) <= 0.001f && AltitudeVelocity < 0)
            {
                //Reset drag by setting state
                CurrentActionState = CurrentActionState;
                Altitude = 0;
		        AltitudeVelocity = 0;
                SpriteInstance.Animate = true;
            }

            if (IsDead)
		    {
		        PerformDeath();
		    }
		    else if (IsHurt && SpriteInstance.JustCycled)
		    {
		        CurrentActionState = Action.Standing;
		    }

		    if (!IsDead && !IsHurt)
		    {
		        NavigationActivity();
		        SetDirection();
		    }

		    UpdateAnimation();
            UpdateHealthBar();
		}

        private void UpdateAnimation()
	    {
            //_spriteRelativeY = SpriteInstance.Height / 2;

	        SpriteInstance.RelativeY = Altitude + _spriteRelativeY + SpriteInstance.CurrentChain[SpriteInstance.CurrentFrameIndex].RelativeY;

	        var pctLightShadow = MathHelper.Clamp(1 - (Altitude / (800)), 0, 1);

	        ShadowSprite.Width = _startingShadowWidth.Value * pctLightShadow;
	        ShadowSprite.Height = _startingShadowHeight * pctLightShadow;
	        ShadowSprite.Alpha = _startingShadowAlpha * pctLightShadow;

	        if (HasLightSource)
	        {
	            LightSprite.TextureScale = _startingLightScale;
	            LightSprite.RelativeY = SpriteInstance.RelativeY;
	        }
        }

	    protected void SetDirection()
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
                HealthBar.Update(HealthRemaining/MaximumHealth);
	            HealthBar.SetRelativeY(SpriteInstance.Height/2 + Altitude);
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

        public void GetHitBy(BasePlayerProjectile projectile)
        {
            var effectiveMultiplier = GetEffectiveMultiplier(projectile.DamageType);
            var dmgInflicted = effectiveMultiplier * projectile.DamageInflicted;
            TakeDamage(dmgInflicted);

            projectile?.PlayHitTargetSound();

	        switch (projectile.DamageType)
	        {
	            case DamageTypes.Frost:
	                _frozenDurationSeconds = projectile.StatusEffectSeconds * effectiveMultiplier;
	                break;
	            case DamageTypes.Chemical:
	                _poisonedDurationSeconds = projectile.StatusEffectSeconds * effectiveMultiplier;
	                _poisonDamagePerSecond = projectile.DamageInflicted * 0.1 * effectiveMultiplier;
                    break;
	            case DamageTypes.Electrical:
	                _stunnedDurationSeconds = projectile.StatusEffectSeconds * effectiveMultiplier;
	                break;
	        }
	        UpdateStatusEffect(justApplied: true);

	        if (!IsDead)
	        {
                CurrentActionState = Action.Hurt;
                SpriteInstance.UpdateToCurrentAnimationFrame();
	            UpdateAnimation();
	        }
	    }

	    private double GetEffectiveMultiplier(DamageTypes damageType)
	    {
	        switch (damageType)
	        {
	            case DamageTypes.Frost: return (1 - EffectiveFrostResist);
	            case DamageTypes.Chemical: return (1 - EffectiveChemicalResist);
	            case DamageTypes.Electrical: return (1 - BaseElectricResist);
	            case DamageTypes.Piercing: return (1-EffectivePiercingResist);
                case DamageTypes.Concussive: return (1 - EffectiveBombardResist);
                case DamageTypes.Fire: return (1 - EffectiveFireResist);
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
	                _frozenDurationSeconds -= TimeManager.SecondDifference;
	            }
	            if (IsStunned)
	            {
	                _stunnedDurationSeconds -= TimeManager.SecondDifference;
	            }
	        }

	        if (IsFrozen && IsPoisoned)
	        {
	            CurrentStatusState = Status.FrozenAndPoisoned;
	            Speed = BaseSpeed * (1 - (float)(GetEffectiveMultiplier(DamageTypes.Frost) * 0.8 +
	                                     GetEffectiveMultiplier(DamageTypes.Chemical) * 0.2));
                
	        }
            else if (IsFrozen)
	        {
	            CurrentStatusState = Status.Frozen;
	            Speed = BaseSpeed * (1 - (float)(GetEffectiveMultiplier(DamageTypes.Frost) * 0.8));
            }
            else if (IsPoisoned)
	        {
	            CurrentStatusState = Status.Poisoned;
	            Speed = BaseSpeed * (1 - (float)(GetEffectiveMultiplier(DamageTypes.Chemical) * 0.2));
            }
            else if (IsStunned)
	        {
	            Speed = 0f;
	        }
	        else
	        {
	            CurrentStatusState = Status.Normal;
	            Speed = BaseSpeed;
	        }

	        FrozenParticles.TimedEmission = IsFrozen;
	        PoisonedParticles.TimedEmission = IsPoisoned;
            
	        if (IsPoisoned && !justApplied)
	        {
	            TakeDamage(_poisonDamagePerSecond * TimeManager.SecondDifference);
	        }
        }

	    private void PerformDeath()
	    {
            if (CurrentActionState != Action.Dying)
	        {
	            CurrentActionState = Action.Dying;
	        }

	        if (SpriteInstanceAnimate && IsOnFinalFrameOfAnimation)
	        {
	            SpriteInstanceAnimate = false;
	        }

            if (Altitude <=0f && IsOnFinalFrameOfAnimation)
            {
                OnDeath?.Invoke(this);
                OnDeath -= OnDeath;
                Destroy();
            }
	    }

        private void CustomDestroy()
		{
		    if (rangedAttackSound != null && !rangedAttackSound.IsDisposed)
		    {
                rangedAttackSound.Stop(true);
                rangedAttackSound.Dispose();
		    }

		    if (rangedChargeSound != null && !rangedChargeSound.IsDisposed) 
		    {
		        rangedChargeSound.Stop(true);
		        rangedChargeSound.Dispose();
            }

		    if (meleeAttackSound != null && !meleeAttackSound.IsDisposed)
		    {
		        meleeAttackSound.Stop(true);
		        meleeAttackSound.Dispose();
		    }
        }

        private static void CustomLoadStaticContent(string contentManagerName)
        {


        }

	    public void ReactToExplosion(float damageInflicted, Vector3 velocity, float altitudeVelocity)
	    {
	        HealthRemaining -= damageInflicted;

	        if (HealthRemaining <= 0)
	        {
	            PerformDeath();
	        }
	        else
	        {
	            CurrentActionState = Action.Hurt;
	            SpriteInstance.UpdateToCurrentAnimationFrame();
	            UpdateAnimation();
	        }

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
                HealthBar.Position = Vector3.Zero;
                HealthBar.RelativePosition = Vector3.Zero;
	        }

	        PoisonedParticles.LayerToEmitOn = worldLayer;
	        FrozenParticles.LayerToEmitOn = worldLayer;
            //MoveToLayer(worldLayer);
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
	        HealthRemaining = 0;
            Velocity = Vector3.Zero;
	    }
    }
}
