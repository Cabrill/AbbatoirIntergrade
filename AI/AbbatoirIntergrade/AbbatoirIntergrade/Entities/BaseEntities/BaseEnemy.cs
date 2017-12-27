using System;
using FlatRedBall;
using FlatRedBall.Math;
using FlatRedBall.Math.Geometry;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;

namespace AbbatoirIntergrade.Entities.BaseEntities
{
	public partial class BaseEnemy
	{
	    private static float _maximumY;
	    protected float _currentScale;

	    private bool _AddedToLayers = false;

        public event Action<BaseEnemy> OnDeath;
	    public float Altitude { get; protected set; }
	    protected float AltitudeVelocity { get; set; }
	    protected float GravityDrag { get; set; } = -650f;

        public float HealthRemaining { get; set; }
        public bool IsDead => HealthRemaining <= 0;
	    private bool IsHurt => CurrentActionState == Action.Hurt;

	    private bool IsOnFinalFrameOfAnimation => SpriteInstance.CurrentFrameIndex == SpriteInstance.CurrentChain.Count - 1;

        private float? _startingShadowWidth;
	    private float _startingShadowHeight;
	    private float _startingShadowAlpha;
	    private float _startingSpriteScale;
	    private float _startingLightScale;
	    private float _startingCircleRadius;

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
		        CircleInstance.Visible = true;
		    }
		    else
#endif
		    {
		        CircleInstance.Visible = false;
		        MeleeAttackRadiusCircleInstance.Visible = false;
		        RangedAttackRadiusCircleInstance.Visible = false;
            }

		    if (!_startingShadowWidth.HasValue)
		    {
		        _startingSpriteScale = SpriteInstance.TextureScale;
		        _startingLightScale = LightSprite.TextureScale;
		        _startingCircleRadius = CircleInstance.Radius;
		        _startingShadowWidth = ShadowSprite.Width;
		        _startingShadowHeight = ShadowSprite.Height;
		        _startingShadowAlpha = ShadowSprite.Alpha;

		        _spriteRelativeY = SpriteInstance.Height / 2;
            }

		    HasReachedGoal = false;

		    HealthBar.X = X;
		    HealthBar.Y = Y;
            HealthBar.SetRelativeY(SpriteInstance.Height);
            HealthBar.SetWidth(SpriteInstance.Width);
            HealthBar.Hide();

            HealthRemaining = MaximumHealth;
		    Altitude = 0f;
		    AltitudeVelocity = 0f;

            CalculateScale();
            UpdateScale();
            UpdateAnimation();
		}

	    public static void Initialize(float maximumY)
	    {
	        _maximumY = maximumY;
        }

		private void CustomActivity()
		{
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
		    }

            CalculateScale();
            UpdateScale();
		    UpdateAnimation();
            UpdateHealthBar();
		}

	    private void CalculateScale()
	    {
	        _currentScale = 0.3f + (0.4f * (1 - Y / _maximumY));
	    }

        protected virtual void UpdateScale()
	    {
	        SpriteInstance.UpdateToCurrentAnimationFrame();
            CircleInstance.Radius = _startingCircleRadius * _currentScale;
	        HealthBar.SetWidth(SpriteInstance.Width);

            if (HasLightSource) LightSprite.TextureScale = _startingLightScale * _currentScale;
	    }

        private void UpdateAnimation()
	    {
	        SpriteInstance.TextureScale = _startingSpriteScale * _currentScale;
            _spriteRelativeY = SpriteInstance.Height / 2;

            if (SpriteInstance.RelativePosition != Vector3.Zero)
	        {
	            SpriteInstance.RelativeX *= (SpriteInstance.FlipHorizontal ? -SpriteInstance.TextureScale : SpriteInstance.TextureScale);
	            SpriteInstance.RelativeY *= (SpriteInstance.FlipVertical ? -SpriteInstance.TextureScale : SpriteInstance.TextureScale);
	        }
	        SpriteInstance.RelativeY += Altitude * _currentScale + _spriteRelativeY;

	        var pctLightShadow = MathHelper.Clamp(1 - (SpriteInstance.RelativeY / (800*_currentScale)), 0, 1);

	        ShadowSprite.Width = _startingShadowWidth.Value * pctLightShadow * _currentScale;
	        ShadowSprite.Height = _startingShadowHeight * pctLightShadow * _currentScale;
	        ShadowSprite.Alpha = _startingShadowAlpha * pctLightShadow;

	        if (HasLightSource)
	        {
	            LightSprite.TextureScale = _startingLightScale * _currentScale;
	            LightSprite.RelativeY = SpriteInstance.RelativeY;
	        }
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

        public void GetHitBy(BasePlayerProjectile projectile)
	    {
	        HealthRemaining -= projectile.DamageInflicted;
            projectile?.PlayHitTargetSound();

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

	    protected void AddSpritesToLayers(FlatRedBall.Graphics.Layer darknessLayer, FlatRedBall.Graphics.Layer hudLayer)
	    {
	        if (LayerProvidedByContainer != null)
	        {
	            LayerProvidedByContainer.Remove(CircleInstance);
                LayerProvidedByContainer.Remove(LightSprite);
            }

	        if (_AddedToLayers)
	        {
	            darknessLayer.Remove(LightSprite);
	            hudLayer.Remove(CircleInstance);
	            HealthBar.Position = Vector3.Zero;
                HealthBar.RelativePosition = Vector3.Zero;
	        }

	        HealthBar.MoveToLayer(hudLayer);
            FlatRedBall.SpriteManager.AddToLayer(LightSprite, darknessLayer);
	        ShapeManager.AddToLayer(CircleInstance, hudLayer);

            _AddedToLayers = true;
	    }

	    public void HandleDrowning()
	    {
	        HealthRemaining = 0;
            Velocity = Vector3.Zero;
	    }
	}
}
