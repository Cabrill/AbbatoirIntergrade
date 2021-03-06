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
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using StateInterpolationPlugin;

namespace AbbatoirIntergrade.Entities.Projectiles
{
	public partial class FireProjectile
	{
	    private Vector3 impactVelocity;
        /// <summary>
        /// Initialization logic which is execute only one time for this Entity (unless the Entity is pooled).
        /// This method is called when the Entity is added to managers. Entities which are instantiated but not
        /// added to managers will not have this method called.
        /// </summary>
		private void CustomInitialize()
		{
            DamageType = DamageTypes.Fire;
		    if (HitGroundSound == null || HitGroundSound.IsDisposed)
		    {
		        const int maxSoundIndex = 2;
		        var soundIndex = FlatRedBallServices.Random.Next(1, maxSoundIndex);
		        var targetGroundSound = $"FireGroundImpact{soundIndex}";

		        var groundSound = GetFile(targetGroundSound) as SoundEffect;
		        HitGroundSound = groundSound.CreateInstance();

		    }
		    if (HitTargetSound == null || HitTargetSound.IsDisposed)
		    {
		        const int maxSoundIndex = 3;
		        var soundIndex = FlatRedBallServices.Random.Next(1, maxSoundIndex);
		        var targetImpactSound = $"FireImpact{soundIndex}";

		        var impactSound = GetFile(targetImpactSound) as SoundEffect;
		        HitTargetSound = impactSound.CreateInstance();
		    }
        }

		private void CustomActivity()
		{


		}

	    protected override void CustomHandleImpact(BaseEnemy enemy = null)
	    {
	        impactVelocity = Velocity;
            SpriteInstance.TextureScale = 2;
	        this.Tween(FadeOut, 1, 0f, 0.5f, InterpolationType.Exponential, Easing.InOut);
	    }


	    private void FadeOut(float newPosition)
	    {
	        Velocity = newPosition * impactVelocity;
	        SpriteInstance.TextureScale = _startingSpriteScale * (2 + (1-newPosition));
            SpriteInstance.Alpha = newPosition;
	        LightOrShadowSprite.Alpha = newPosition * _startingShadowAlpha;
	    }

        private void CustomDestroy()
		{


		}

        private static void CustomLoadStaticContent(string contentManagerName)
        {


        }
	}
}
