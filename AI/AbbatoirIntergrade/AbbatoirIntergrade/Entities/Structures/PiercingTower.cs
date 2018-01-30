using System;
using System.Collections.Generic;
using System.Text;
using AbbatoirIntergrade.Entities.BaseEntities;
using AbbatoirIntergrade.Factories;
using FlatRedBall;
using FlatRedBall.Input;
using FlatRedBall.Instructions;
using FlatRedBall.AI.Pathfinding;
using FlatRedBall.Graphics;
using FlatRedBall.Graphics.Animation;
using FlatRedBall.Graphics.Particle;
using FlatRedBall.Math.Geometry;
using Microsoft.Xna.Framework;

namespace AbbatoirIntergrade.Entities.Structures
{
	public partial class PiercingTower
	{
        /// <summary>
        /// Initialization logic which is execute only one time for this Entity (unless the Entity is pooled).
        /// This method is called when the Entity is added to managers. Entities which are instantiated but not
        /// added to managers will not have this method called.
        /// </summary>
		private void CustomInitialize()
		{
            DamageType = DamageTypes.Piercing;

		    var offset = ArrowSpriteInstance.RelativeY - AimSpriteInstance.RelativeY;
            ArrowSpriteInstance.AttachTo(AimSpriteInstance);
		    AimSpriteInstance.RelativeRotationZ = MathHelper.ToRadians(90);
		    ArrowSpriteInstance.RelativeY = offset;

		    OnFire = CustomOnFire;

		    ArrowSpriteInstance.Visible = false;

		    this.Call(() =>
		    {
		        ArrowSpriteInstance.Visible = true;
		    }).After(SecondsBetweenFiring - 1);
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
	        return PiercingProjectileFactory.CreateNew(LayerProvidedByContainer);
        }

	    private void CustomOnFire()
	    {
	        ArrowSpriteInstance.Visible = false;

	        this.Call(() =>
	        {
	            ArrowSpriteInstance.Visible = true;
	        }).After(SecondsBetweenFiring - 1);
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
