using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using FlatRedBall;
using FlatRedBall.Input;
using FlatRedBall.Instructions;
using FlatRedBall.AI.Pathfinding;
using FlatRedBall.Graphics.Animation;
using FlatRedBall.Graphics.Particle;
using FlatRedBall.Math.Geometry;
using FlatRedBall.Localization;



namespace AbbatoirIntergrade.Screens
{
	public partial class MainMenu
	{

	    void CustomInitialize()
	    {
#if WINDOWS || DESKTOP_GL
	        FlatRedBallServices.IsWindowsCursorVisible = true;
#endif
	    }

	    void CustomActivity(bool firstTimeCalled)
	    {
	        FlatRedBall.Debugging.Debugger.Write(FlatRedBall.Gui.GuiManager.Cursor.WindowOver);

	    }

        void CustomDestroy()
		{


		}

        static void CustomLoadStaticContent(string contentManagerName)
        {


        }

	}
}
