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
	public partial class CannonProjectile
	{
        /// <summary>
        /// Initialization logic which is execute only one time for this Entity (unless the Entity is pooled).
        /// This method is called when the Entity is added to managers. Entities which are instantiated but not
        /// added to managers will not have this method called.
        /// </summary>
		private void CustomInitialize()
		{
		    HitTargetSound = CannonHit.CreateInstance();

		    const int maxSoundIndex = 3;
		    var soundIndex = FlatRedBallServices.Random.Next(1, maxSoundIndex);
		    var targetHitSoundName = $"CannonImpact{soundIndex}";

		    var hitSound = GetFile(targetHitSoundName) as SoundEffect;
		    HitGroundSound = hitSound.CreateInstance();

            GravityDrag = -75f;
            DamageType = DamageTypes.Bombarding;
		    RotationZVelocity = FlatRedBallServices.Random.Between(20, 50);
		}

	    protected  override void CustomHandleImpact(BaseEnemy enemy = null)
	    {
            //This happens when hitting the ground
	        if (enemy == null)
	        {
	            RotationZVelocity = 0;
	            RotationZ = 0;
	            SpriteInstance.TextureScale = 1f;
	            CircleInstance.Radius *= 2;
	            RotationX = 0;
	            RotationY = 0;
	            RotationZ = 0;
	            LightOrShadowSprite.Visible = false;

	            var duration = SpriteInstance.AnimationChains["Impact"].TotalLength / 2;

	            this.Call(FadeOut).After(duration);
	        }
	    }

	    private void HandleShrinkUpdate(float newPosition)
	    {
	        SpriteInstance.Alpha = newPosition;
        }

	    private void FadeOut()
	    {
            var duration = SpriteInstance.AnimationChains["Impact"].TotalLength / 2;

	        this.Tween(HandleShrinkUpdate, 1, 0.25f, duration,
	            InterpolationType.Exponential, Easing.InOut);
	    }

	    public void HandleEnemiesInImpactZone(List<BaseEnemy> enemies)
	    {
	        CanStillDoDamage = false;

            var totalEnemies = enemies.Count;

	        if (totalEnemies == 0) return;

	        for (var i = totalEnemies-1; i >= 0; i--)
	        {
	            var enemy = enemies[i];
	            var distanceToImpact = enemy.Position - Position;
	            var angle = (float)Math.Atan2(Position.Y - enemy.Position.Y, Position.X - enemy.Position.X);
	            var direction = new Vector3(
	                (float)-Math.Cos(angle),
	                (float)-Math.Sin(angle), 0);
	            direction.Normalize();

	            var amplitude = 1f;

	            if (distanceToImpact != Vector3.Zero)
	            {
	                amplitude = (float)(Math.Sqrt(MathHelper.Clamp(1 - distanceToImpact.Length() / (CircleInstance.Radius + enemy.SpriteInstance.Width), 0, 1)));
	            }

	            if (amplitude > 0)
	            {
	                enemy.ReactToExplosion(this, amplitude,
	                    direction * 400 * amplitude * (1-enemy.Mass),
	                    800 * amplitude * (1-enemy.Mass));
	            }
            }
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
