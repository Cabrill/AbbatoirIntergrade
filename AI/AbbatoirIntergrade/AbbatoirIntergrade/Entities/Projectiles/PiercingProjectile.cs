using System;
using System.Collections.Generic;
using System.Text;
using AbbatoirIntergrade.Entities.BaseEntities;
using FlatRedBall;
using FlatRedBall.Input;
using FlatRedBall.Instructions;
using FlatRedBall.AI.Pathfinding;
using FlatRedBall.Glue.StateInterpolation;
using FlatRedBall.Graphics;
using FlatRedBall.Graphics.Animation;
using FlatRedBall.Graphics.Particle;
using FlatRedBall.Math.Geometry;
using FlatRedBall.Math.Statistics;
using StateInterpolationPlugin;

namespace AbbatoirIntergrade.Entities.Projectiles
{
	public partial class PiercingProjectile
	{
        /// <summary>
        /// Initialization logic which is execute only one time for this Entity (unless the Entity is pooled).
        /// This method is called when the Entity is added to managers. Entities which are instantiated but not
        /// added to managers will not have this method called.
        /// </summary>
		private void CustomInitialize()
        {
            //if (HitGroundSound == null || HitGroundSound.IsDisposed) HitGroundSound = Laser_Ground.CreateInstance();
            //if (HitTargetSound == null || HitTargetSound.IsDisposed) HitTargetSound = Laser_Hit.CreateInstance();
        }

	    public new void AddSpritesToLayers(Layer darknessLayer, Layer hudLayer)
	    {
	        base.AddSpritesToLayers(darknessLayer, hudLayer);

	        if (HasLightSource)
	        {
	            //LayerProvidedByContainer.Remove(LightSpriteInstance);
	            //SpriteManager.AddToLayer(LightSpriteInstance, darknessLayer);
	        }
	    }

	    protected override void CustomHandleImpact(BaseEnemy enemy = null)
	    {
	        if (enemy != null)
	        {
	            var impactOffset = FlatRedBallServices.Random.NextFloat(enemy.SpriteInstance.Width * 0.1f);
                var impactOrigin = enemy.X;
	            var impactSite = 0f;

	            if (enemy.X > X)
	            {
	                impactSite = impactOrigin - impactOffset;
	            }
	            else
	            {
	                impactSite = impactOrigin + impactOffset;
                }

	            X = impactSite;
	        }

	        var duration = SpriteInstance.AnimationChains["Impact"].TotalLength;

	        this.Tween(FadeOut, 1, 0f, duration,
	            InterpolationType.Exponential, Easing.Out);
        }


	    private void FadeOut(float newPosition)
        {
	        SpriteInstance.Alpha = newPosition;
	        LightOrShadowSprite.Alpha = newPosition;
        }

        private void CustomActivity()
		{


		}

		private void CustomDestroy()
		{

        }

        private static void CustomLoadStaticContent(string contentManagerName)
        {


        }
	}
}
