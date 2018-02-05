using System;
using System.Collections.Generic;
using System.Text;
using AbbatoirIntergrade.Entities.BaseEntities;
using FlatRedBall;
using FlatRedBall.Input;
using FlatRedBall.Instructions;
using FlatRedBall.AI.Pathfinding;
using FlatRedBall.Glue.StateInterpolation;
using FlatRedBall.Graphics.Animation;
using FlatRedBall.Graphics.Particle;
using FlatRedBall.Math.Geometry;
using Microsoft.Xna.Framework.Audio;
using StateInterpolationPlugin;

namespace AbbatoirIntergrade.Entities.Projectiles
{
	public partial class FrostProjectile
	{
        /// <summary>
        /// Initialization logic which is execute only one time for this Entity (unless the Entity is pooled).
        /// This method is called when the Entity is added to managers. Entities which are instantiated but not
        /// added to managers will not have this method called.
        /// </summary>
		private void CustomInitialize()
		{
		    if (HitGroundSound == null || HitGroundSound.IsDisposed)
		    {
		        const int maxSoundIndex = 2;
		        var soundIndex = FlatRedBallServices.Random.Next(1, maxSoundIndex);
		        var targetGroundSound = $"FrostGroundImpact{soundIndex}";

		        var groundSound = GetFile(targetGroundSound) as SoundEffect;
		        HitGroundSound = groundSound.CreateInstance();

		    }
		    if (HitTargetSound == null || HitTargetSound.IsDisposed)
		    {
		        const int maxSoundIndex = 3;
		        var soundIndex = FlatRedBallServices.Random.Next(1, maxSoundIndex);
		        var targetImpactSound = $"FrostImpact{soundIndex}";

		        var impactSound = GetFile(targetImpactSound) as SoundEffect;
		        HitTargetSound = impactSound.CreateInstance();
		    }
            DamageType = DamageTypes.Frost;
		    var randomRotation = FlatRedBallServices.Random.Between(2, 3);
		    var randomDirection = FlatRedBallServices.Random.Between(0, 1);

            RotationZVelocity = randomRotation * (randomDirection > 0 ? 1 : -1);
        }

		private void CustomActivity()
		{

		}

	    protected override void CustomHandleImpact(BaseEnemy enemy = null)
	    {
	        SpriteInstance.TextureScale = 1;
	        if (enemy != null)
	        {
	            LightOrShadowSprite.AttachTo(enemy);
	        }
	        LightOrShadowSprite.Tween(HandleTweenerUpdate, 1, 2, SpriteInstance.AnimationChains["Impact"].TotalLength, InterpolationType.Exponential, Easing.InOut).Start();
	    }

	    private void HandleTweenerUpdate(float newPosition)
	    {
	        LightOrShadowSprite.TextureScale = _startingLightScale * newPosition;
	        LightOrShadowSprite.Alpha = _startingShadowAlpha/2 * (2 - newPosition);
	    }

        private void CustomDestroy()
		{


		}

        private static void CustomLoadStaticContent(string contentManagerName)
        {


        }
	}
}
