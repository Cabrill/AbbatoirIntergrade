using System;
using System.Collections.Generic;
using System.Text;
using AbbatoirIntergrade.Entities.BaseEntities;
using AbbatoirIntergrade.Entities.Projectiles;
using AbbatoirIntergrade.Factories;
using FlatRedBall;
using FlatRedBall.Input;
using FlatRedBall.Instructions;
using FlatRedBall.AI.Pathfinding;
using FlatRedBall.Graphics;
using FlatRedBall.Graphics.Animation;
using FlatRedBall.Graphics.Particle;
using FlatRedBall.Math.Geometry;
using Microsoft.Xna.Framework.Audio;

namespace AbbatoirIntergrade.Entities.Structures
{
	public partial class BombardingTower
	{
        /// <summary>
        /// Initialization logic which is execute only one time for this Entity (unless the Entity is pooled).
        /// This method is called when the Entity is added to managers. Entities which are instantiated but not
        /// added to managers will not have this method called.
        /// </summary>
		private void CustomInitialize()
		{
            DamageType = DamageTypes.Bombarding;
		    LightAimSpriteInstance.Visible = true;
		    LightAimSpriteInstance.Visible = false;
            LightAimSpriteInstance.AlphaRate = -6f;

            OnFire = CustomOnFire;


            if (FiringSound == null || FiringSound.IsDisposed)
		    {
		        const int maxSoundIndex = 2;
		        var soundIndex = FlatRedBallServices.Random.Next(1, maxSoundIndex);
		        var targetFiringSound = $"CannonShot{soundIndex}";

		        var firingSound = GetFile(targetFiringSound) as SoundEffect;
		        FiringSound = firingSound.CreateInstance();
		    }
        }

	    private void CustomOnFire()
	    {
	        LightAimSpriteInstance.Visible = true;
	        LightAimSpriteInstance.Alpha = 1;
	    }

	    public void AddSpritesToLayers(FlatRedBall.Graphics.Layer darknessLayer, Layer hudLayer)
	    {
	        base.AddSpritesToLayers(darknessLayer, hudLayer);

	        if (HasLightSource)
	        {
	            //LayerProvidedByContainer.Remove(LightSpriteInstance);
	            //SpriteManager.AddToLayer(LightSpriteInstance, darknessLayer);
	        }
	    }

	    protected override BasePlayerProjectile CreateNewProjectile()
	    {
	        return CannonProjectileFactory.CreateNew(LayerProvidedByContainer); 
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
