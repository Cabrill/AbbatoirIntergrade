using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AbbatoirIntergrade.GameClasses;
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
	public partial class FlatRedBallSplashScreen
	{
        private double startTime;
        private double displaySeconds = 3;

		void CustomInitialize()
		{
            startTime = FlatRedBall.TimeManager.CurrentTime;
        }

        void CustomActivity(bool firstTimeCalled)
		{
            if (FlatRedBall.TimeManager.CurrentTime - startTime > displaySeconds ||
                InputManager.Keyboard.AnyKeyPushed() ||
                (InputManager.NumberOfConnectedGamePads > 0 && InputManager.Xbox360GamePads[0].AnyButtonPushed()))
            {
                MoveToScreen(typeof(MainMenu));
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
