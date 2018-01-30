using System;
using System.Collections.Generic;
using System.Text;
using FlatRedBall;
using FlatRedBall.Input;
using FlatRedBall.Instructions;
using FlatRedBall.AI.Pathfinding;
using FlatRedBall.Graphics;
using FlatRedBall.Graphics.Animation;
using FlatRedBall.Graphics.Particle;
using FlatRedBall.Math.Geometry;
using AbbatoirIntergrade.Entities.Projectiles;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;

namespace AbbatoirIntergrade.Entities.BaseEntities
{
	public partial class BasePlayerProjectile
	{
	    public float Altitude { get; set; }
	    public float AltitudeVelocity { get; set; }
        public DamageTypes DamageType { get; protected set; }
	    public bool CanStillDoDamage = true;
	    public double StatusEffectSeconds;

	    protected float _startingSpriteScale;
	    protected float _startingLightScale;
	    private float _startingCircleRadius;
	    private float? _startingShadowWidth;
	    private float _startingShadowHeight;
	    protected float _startingShadowAlpha;

        public float GravityDrag { get; set; } = -100f;

	    protected SoundEffectInstance HitGroundSound;
	    protected SoundEffectInstance HitTargetSound;
	    private bool _AddedToLayers = false;
	    public bool ShouldBeDestroyed;


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
		    }

            //These have to be set here, because the object is pooled (reused)
		    if (!_startingShadowWidth.HasValue)
		    {
		        _startingSpriteScale = SpriteInstance.TextureScale;
		        _startingLightScale = LightOrShadowSprite.TextureScale;
                _startingShadowWidth = LightOrShadowSprite.Width;
		        _startingShadowHeight = LightOrShadowSprite.Height;
		        _startingShadowAlpha = LightOrShadowSprite.Alpha;
		        _startingCircleRadius = CircleInstance.Radius;
		    }
		    else
		    {
		        SpriteInstance.TextureScale = _startingSpriteScale;
		        LightOrShadowSprite.TextureScale = _startingLightScale;
                LightOrShadowSprite.Width = _startingShadowWidth.Value;
		        LightOrShadowSprite.Height = _startingShadowHeight;
		        LightOrShadowSprite.Alpha = _startingShadowAlpha;
		        CircleInstance.Radius = _startingCircleRadius;
		    }

		    ShouldBeDestroyed = false;
		    CanStillDoDamage = true;
            Visible = true;

            CurrentState = VariableState.Flying;
            Detach();
		}

	    private void CustomActivity()
	    {
	        if (CurrentState == VariableState.Impact && SpriteInstance.JustCycled)
	        {
	            Visible = false;
	            SpriteInstance.Animate = false;
	            ShouldBeDestroyed = true;
	        }

            if (ShouldBeDestroyed)
		    {
		        //if (HitGroundSound.State == SoundState.Stopped && HitTargetSound.State == SoundState.Stopped)
		        //{
		            Destroy();
		        //}
		    }
            else
            {
                UpdateAnimation();
                if (CurrentState != VariableState.Impact)
                {
                    var distanceAtWhichToGrow = HasLightSource ? 200 : 400;
                    var pctLightShadow = MathHelper.Clamp(1 - (SpriteInstance.RelativeY / distanceAtWhichToGrow ), 0, 1);

                    LightOrShadowSprite.Width = _startingShadowWidth.Value * pctLightShadow;
                    LightOrShadowSprite.Height = _startingShadowHeight * pctLightShadow;
                    LightOrShadowSprite.Alpha = _startingShadowAlpha * pctLightShadow;

                    var _hitTheGround = Altitude <= 0;

                    if (_hitTheGround)
                    {
                        HandleImpact();
                        PlayHitGroundSound();
                    }
                }
            }
		}

	    private void UpdateAnimation()
	    {
	        if (CurrentState == VariableState.Flying)
	        {
	            AltitudeVelocity += GravityDrag * TimeManager.SecondDifference;
	            Altitude += AltitudeVelocity * TimeManager.SecondDifference;
	            if (RotationZVelocity == 0) RotationZ = (float)Math.Atan2(-XVelocity, YVelocity + AltitudeVelocity);
            }
	        //float _spriteRelativeY = 0;

         //   if (!(this is CannonProjectile) || CurrentState == VariableState.Flying)
	        //{
	        //    _spriteRelativeY = SpriteInstance.Height / 2;
         //   }

	        SpriteInstance.RelativeX = SpriteInstance.CurrentChain[SpriteInstance.CurrentFrameIndex].RelativeX;
	        SpriteInstance.RelativeY = SpriteInstance.CurrentChain[SpriteInstance.CurrentFrameIndex].RelativeY;

	        SpriteInstance.RelativeY += Altitude;// + _spriteRelativeY;
        }

	    public void HandleImpact(BaseEnemy enemy = null)
	    {
#if DEBUG
            if (DebugVariables.SlowTimeForShots) FlatRedBall.TimeManager.TimeFactor = 1;
#endif
            CurrentState = VariableState.Impact;
            UpdateAnimation();
	        CustomHandleImpact(enemy);
	        CanStillDoDamage = false;
            Velocity = Vector3.Zero;
        }

	    protected virtual void CustomHandleImpact(BaseEnemy enemy = null)
	    {

	    }

        private void PlayHitGroundSound()
	    {
	        try
	        {
	            HitGroundSound.Play();
            }
	        catch (Exception){}
        }

	    public void PlayHitTargetSound()
	    {
	        try
	        {
	            HitTargetSound.Play();
	        }
	        catch (Exception) { }
        }


	    public void AddSpritesToLayers(Layer darknessLayer, Layer hudLayer)
	    {
	        if (LayerProvidedByContainer != null)
	        {
	            if (HasLightSource) LayerProvidedByContainer.Remove(LightOrShadowSprite);
	            LayerProvidedByContainer.Remove(CircleInstance);
	        }

	        if (_AddedToLayers)
	        {
	            darknessLayer.Remove(LightOrShadowSprite);
	            hudLayer.Remove(CircleInstance);
	            if (HasLightSource) darknessLayer.Remove(SpriteInstance);
	        }

	        if (HasLightSource) SpriteManager.AddToLayer(LightOrShadowSprite, darknessLayer);
	        ShapeManager.AddToLayer(CircleInstance, hudLayer);

	        _AddedToLayers = true;
        }

        private void CustomDestroy()
		{
		    if (HitGroundSound != null && !HitGroundSound.IsDisposed)
		    {
                if (HitGroundSound.State != SoundState.Stopped) HitGroundSound.Stop(true);
		        HitGroundSound.Dispose();
		    }

		    if (HitTargetSound != null && !HitTargetSound.IsDisposed)
		    {
		        if (HitTargetSound.State != SoundState.Stopped) HitTargetSound.Stop(true);
                HitTargetSound.Dispose();
		    }
        }

        private static void CustomLoadStaticContent(string contentManagerName)
        {


        }
	}
}
