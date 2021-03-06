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
using Microsoft.Xna.Framework.Audio;

namespace AbbatoirIntergrade.Entities.Enemies
{
	public partial class Chicken2Enemy
	{
        /// <summary>
        /// Initialization logic which is execute only one time for this Entity (unless the Entity is pooled).
        /// This method is called when the Entity is added to managers. Entities which are instantiated but not
        /// added to managers will not have this method called.
        /// </summary>
		private void CustomInitialize()
		{
		    if (DeathSound == null || DeathSound.IsDisposed)
		    {
		        const int maxSoundIndex = 2;
		        var soundIndex = FlatRedBallServices.Random.Next(1, maxSoundIndex);
		        var targetDeathSoundName = $"Chicken2Death{soundIndex}";

		        var deathSound = GetFile(targetDeathSoundName) as SoundEffect;
		        DeathSound = deathSound.CreateInstance();
		    }

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

		private void CustomDestroy()
		{


		}

        private static void CustomLoadStaticContent(string contentManagerName)
        {


        }
	}
}
