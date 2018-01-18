using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AbbatoirIntergrade.GumRuntimes;
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
            MainMenuGumRuntime.OpenEyesAnimation.PlayAfter(3, this);
	    }

	    void CustomActivity(bool firstTimeCalled)
	    {
	        //FlatRedBall.Debugging.Debugger.Write(FlatRedBall.Gui.GuiManager.Cursor.WindowOver);

	        if (InputManager.Keyboard.AnyKeyPushed() || InputManager.Mouse.AnyButtonPushed())
	        {
	            LoadingScreen.TransitionToScreen(typeof(MapScreen));
	        }
            else if (LeftEye.CurrentEyeOpeningState == MainMenuEyeRuntime.EyeOpening.Open && !MainMenuGumRuntime.OpenEyesAnimation.IsPlaying() && !MainMenuGumRuntime.BlinkEyesAnimation.IsPlaying())
	        {
	            var random = FlatRedBallServices.Random.NextDouble();

	            if (random >= 0.995f)
	            {
	                MainMenuGumRuntime.BlinkEyesAnimation.Play(this);
	            }
	        }
	    }

        void CustomDestroy()
		{


		}

        static void CustomLoadStaticContent(string contentManagerName)
        {


        }

	}
}
