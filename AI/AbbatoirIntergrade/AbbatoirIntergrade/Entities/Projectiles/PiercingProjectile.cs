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
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
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
            if (HitGroundSound == null || HitGroundSound.IsDisposed)
            {
                const int maxSoundIndex = 2;
                var soundIndex = FlatRedBallServices.Random.Next(1, maxSoundIndex);
                var targetGroundSound = $"PiercingGroundImpact{soundIndex}";

                var groundSound = GetFile(targetGroundSound) as SoundEffect;
                HitGroundSound = groundSound.CreateInstance();

            }
            if (HitTargetSound == null || HitTargetSound.IsDisposed)
            {
                const int maxSoundIndex = 3;
                var soundIndex = FlatRedBallServices.Random.Next(1, maxSoundIndex);
                var targetImpactSound = $"PiercingImpact{soundIndex}";

                var impactSound = GetFile(targetImpactSound) as SoundEffect;
                HitTargetSound = impactSound.CreateInstance();
            }

            DamageType = DamageTypes.Piercing;
            GravityDrag = -10f;
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
                AttachProjectiledToEnemy(enemy);
	        }
            this.Call(() =>
            { 
	            this.Tween(FadeOut, 1, 0f, 2, InterpolationType.Exponential, Easing.Out);
            }).After(3);
	    }

	    private void AttachProjectiledToEnemy(BaseEnemy enemy)
	    {
	        var direction = new Vector3(
	            (float)-Math.Cos(RotationZ),
	            (float)-Math.Sin(RotationZ), 0);
	        direction.Normalize();

	        var fromAbove = enemy.Y < Y;
	        var fromLeft = enemy.X > X;

            AttachTo(enemy.SpriteInstance, true);

	        var impactOffsetX = FlatRedBallServices.Random.NextFloat(enemy.SpriteInstance.Width * 0.1f);
	        var impactOffsetY = FlatRedBallServices.Random.NextFloat(enemy.SpriteInstance.Height * 0.1f);

            var effectiveX = (impactOffsetX * (fromLeft ? -1 : 1)) - 
	                         (CircleInstance.RelativeY - 15f) * direction.Y;
	        var effectiveY = (impactOffsetY * (fromAbove ? -1 : 1)) +
	                         (CircleInstance.RelativeY - 15f) * direction.X;
	        
	        RelativeX = effectiveX;
	        RelativeY = effectiveY;
        }


	    private void FadeOut(float newPosition)
        {
	        SpriteInstance.Alpha = newPosition;
	        LightOrShadowSprite.Alpha = newPosition/2;
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
