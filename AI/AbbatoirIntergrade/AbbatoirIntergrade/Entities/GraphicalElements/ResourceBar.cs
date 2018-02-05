using System;
using System.Collections.Generic;
using System.Text;
using Accord.Math;
using FlatRedBall;
using FlatRedBall.Input;
using FlatRedBall.Instructions;
using FlatRedBall.AI.Pathfinding;
using FlatRedBall.Graphics;
using FlatRedBall.Graphics.Animation;
using FlatRedBall.Graphics.Particle;
using FlatRedBall.Math.Geometry;

namespace AbbatoirIntergrade.Entities.GraphicalElements
{
	public partial class ResourceBar
	{

	    public float Height => FrameSprite.Height;

        /// <summary>
        /// Initialization logic which is execute only one time for this Entity (unless the Entity is pooled).
        /// This method is called when the Entity is added to managers. Entities which are instantiated but not
        /// added to managers will not have this method called.
        /// </summary>
		private void CustomInitialize()
		{


		}

	    public void SetWidth(float newWidth)
	    {
	        BackgroundSprite.Width = newWidth;
	        FrameSprite.Width = newWidth+6;
	        BarSprite.Width = newWidth;

	        var newHeight = newWidth / 5;
	        BackgroundSprite.Height = newHeight;
	        FrameSprite.Height = newHeight + 6;
	        BarSprite.Height = newHeight;
	    }

	    public void Update(double newPct)
	    {
	        if (!FrameSprite.Visible) Show();
	        BarSprite.Green = (float)Math.Min(1, newPct * 2);
            BarSprite.Red = (float)Math.Min(1, 2 - newPct * 2);
            BarSprite.Width = (float)Math.Max(0.001,BackgroundSprite.Width * newPct);
	        BarSprite.RelativeX = (BarSprite.Width - BackgroundSprite.Width)/2;
	    }

	    public void Show()
	    {
	        BackgroundSprite.Visible = true;
	        FrameSprite.Visible = true;
	        BarSprite.Visible = true;
        }

	    public void Hide()
	    {
            if (!FrameSprite.Visible) return;
            
            BackgroundSprite.Visible = false;
	        FrameSprite.Visible = false;
	        BarSprite.Visible = false;
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
