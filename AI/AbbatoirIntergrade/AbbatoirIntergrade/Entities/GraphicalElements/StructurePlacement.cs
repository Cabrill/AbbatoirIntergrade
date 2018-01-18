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
using FlatRedBall.Gui;
using FlatRedBall.Math.Geometry;

namespace AbbatoirIntergrade.Entities.GraphicalElements
{
	public partial class StructurePlacement
	{
	    public EventHandler OnClick;

        /// <summary>
        /// Initialization logic which is execute only one time for this Entity (unless the Entity is pooled).
        /// This method is called when the Entity is added to managers. Entities which are instantiated but not
        /// added to managers will not have this method called.
        /// </summary>
		private void CustomInitialize()
        {
            
            
        }

		private void CustomActivity()
		{
		    if (CurrentCurrentlyActiveState == CurrentlyActive.Active)
		    {
		        CurrentRollOverState =
		            this.HasCursorOver(GuiManager.Cursor) ? RollOver.CursorOver : RollOver.CursorOff;

		        if (WasClickedThisFrame(GuiManager.Cursor))
		        {
		            OnClick?.Invoke(this, null);
		        }
		    }
		}

	    public void AddSpritesToLayers(Layer darknessLayer, Layer hudLayer)
	    {
	        //LayerProvidedByContainer.Remove(SpriteInstance);
	        SpriteManager.AddToLayer(SpriteInstance, hudLayer);
	    }

        private void CustomDestroy()
		{


		}

        private static void CustomLoadStaticContent(string contentManagerName)
        {


        }
	}
}
