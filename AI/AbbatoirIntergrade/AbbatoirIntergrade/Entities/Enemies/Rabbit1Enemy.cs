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
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;

namespace AbbatoirIntergrade.Entities.Enemies
{
	public partial class Rabbit1Enemy
	{
	    private const float maxJumpVelocity = 200f;

	    private const float _lightPulseDuration = 2;
	    private const float _lightPulseAmount = 0.5f;
	    private float _currentLightPulse = 0;
	    private int _pulseMod = 1;


	    private SoundEffectInstance _jumpStart;
	    private SoundEffectInstance _jumpLand;

        /// <summary>
        /// Initialization logic which is execute only one time for this Entity (unless the Entity is pooled).
        /// This method is called when the Entity is added to managers. Entities which are instantiated but not
        /// added to managers will not have this method called.
        /// </summary>
		private void CustomInitialize()
        {
            Altitude = 0;
            CurrentJumpState = Jump.NotJumping;

            if (DeathSound == null || DeathSound.IsDisposed)
            {
                const int maxSoundIndex = 3;
                var soundIndex = FlatRedBallServices.Random.Next(1, maxSoundIndex);
                var targetDeathSoundName = $"Rabbit1Death{soundIndex}";

                var deathSound = GetFile(targetDeathSoundName) as SoundEffect;
                DeathSound = deathSound.CreateInstance();
            }

            //_jumpStart = Slime_Jump.CreateInstance();
            //_jumpLand = Slime_Land.CreateInstance();
        }

	    public void AddSpritesToLayers(Layer worldLayer, Layer darknessLayer, Layer hudLayer)
	    {
	        base.AddSpritesToLayers(worldLayer, darknessLayer, hudLayer);

	        if (HasLightSource)
	        {
	            //LayerProvidedByContainer.Remove(LightSpriteInstance);
	            //SpriteManager.AddToLayer(LightSpriteInstance, darknessLayer);
	        }
	    }

        private void CustomActivity()
		{

        }

	    //protected override void NavigateToTarget()
	    //{
	    //    if (CurrentJumpState == Jump.InAir && AltitudeVelocity < 0)
	    //    {
	    //        CurrentJumpState = Jump.Landing;
     //       }

	    //    if (CurrentJumpState == Jump.Landing && Altitude < 1 && Velocity.Length() > Speed * _currentScale * 0.3)
	    //    {
	    //        var angle = (float)Math.Atan2(Y - _targetPointForNavigation.Y,
	    //            X - _targetPointForNavigation.X);
	    //        var direction = new Vector3(
	    //            (float)-Math.Cos(angle),
	    //            (float)-Math.Sin(angle), 0);
	    //        direction.Normalize();
	    //        Velocity = direction * Speed * 0.3f * _currentScale;
     //       }

     //       if (CurrentJumpState == Jump.NotJumping || (CurrentJumpState == Jump.Landing && SpriteInstance.JustCycled))
	    //    {
	    //        CurrentJumpState = Jump.PreparingJump;
	    //        var angle = (float)Math.Atan2(Y - _targetPointForNavigation.Y,
	    //            X - _targetPointForNavigation.X);
	    //        var direction = new Vector3(
	    //            (float)-Math.Cos(angle),
	    //            (float)-Math.Sin(angle), 0);
	    //        direction.Normalize();
     //           Velocity = direction * Speed * 0.6f * _currentScale;
     //       }
	    //    else if (CurrentJumpState == Jump.PreparingJump && SpriteInstance.JustCycled)
	    //    {
	    //        var angle = (float)Math.Atan2(Y - _targetPointForNavigation.Y,
	    //            X - _targetPointForNavigation.X);
	    //        var direction = new Vector3(
	    //            (float)-Math.Cos(angle),
	    //            (float)-Math.Sin(angle), 0);
	    //        direction.Normalize();

	    //        var neededAltitudeVelocity = CalculateJumpAltitudeVelocity();

	    //        AltitudeVelocity = Math.Min(maxJumpVelocity, neededAltitudeVelocity);
	    //        Altitude = AltitudeVelocity * TimeManager.SecondDifference;

     //           Velocity = direction * Speed * _currentScale;

     //           CurrentJumpState = Jump.InAir;
	    //        SpriteInstance.Animate = false;
	    //        //try
	    //        //{
	    //        //    _jumpStart.Play();
	    //        //}
	    //        //catch (Exception) { };


	    //    }
     //   }

        private void CustomDestroy()
        {
            if (_jumpStart != null && !_jumpStart.IsDisposed)
            {
                _jumpStart.Stop(true);
            }
            if (_jumpLand != null && !_jumpLand.IsDisposed)
            {
                _jumpLand.Stop(true);
            }
        }

        private static void CustomLoadStaticContent(string contentManagerName)
        {


        }
	}
}
