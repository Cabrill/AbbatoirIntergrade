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
using StateInterpolationPlugin;

namespace AbbatoirIntergrade.Entities.Projectiles
{
	public partial class CannonProjectile
	{
	    private float circleRadius;
	    public bool IsOnlySmoke;

        /// <summary>
        /// Initialization logic which is execute only one time for this Entity (unless the Entity is pooled).
        /// This method is called when the Entity is added to managers. Entities which are instantiated but not
        /// added to managers will not have this method called.
        /// </summary>
		private void CustomInitialize()
		{
		    if (HitGroundSound == null || HitGroundSound.IsDisposed) HitGroundSound = Cannon_Hit.CreateInstance();
		    HitTargetSound = HitGroundSound;
		    circleRadius = CircleInstance.Radius;
            GravityDrag = -75f;
		    IsOnlySmoke = false;
		}

	    protected  override void CustomHandleImpact(BaseEnemy enemy = null)
	    {
            //This happens when hitting the ground
	        if (enemy == null)
	        {
	            CircleInstance.Radius *= 2;
	            RotationX = 0;
	            RotationY = 0;
	            RotationZ = 0;
	            LightOrShadowSprite.Visible = false;

	            var duration = SpriteInstance.AnimationChains["Impact"].TotalLength * 3 / 4;

	            this.Call(FadeOut).After(duration);
	        }
	    }

	    private void HandleShrinkUpdate(float newPosition)
	    {
	        SpriteInstance.Alpha = newPosition;
        }

	    private void FadeOut()
	    {
            var duration = SpriteInstance.AnimationChains["Impact"].TotalLength / 4;

	        this.Tween(HandleShrinkUpdate, 1, 0.25f, duration,
	            InterpolationType.Exponential, Easing.Out);
	    }

	    public void HandleEnemiesInImpactZone(List<BaseEnemy> enemies)
	    {
	        IsOnlySmoke = true;

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
	                amplitude = (float)(Math.Sqrt(MathHelper.Clamp(1 - distanceToImpact.Length() / (CircleInstance.Radius + enemy.CircleInstance.Radius), 0, 1)));
	            }

	            if (amplitude > 0)
	            {
	                enemy.ReactToExplosion(DamageInflicted * amplitude,
	                    direction * 800 * amplitude,
	                    1000 * amplitude);
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
