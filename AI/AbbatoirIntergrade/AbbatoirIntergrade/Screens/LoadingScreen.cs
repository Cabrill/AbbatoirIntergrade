using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AbbatoirIntergrade.StaticManagers;
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
	public partial class LoadingScreen
	{

		void CustomInitialize()
		{
		    LocalLogManager.AddLine("Loading Screen Initialize");
        }

		void CustomActivity(bool firstTimeCalled)
		{
            //Currently MonoGame does not allow asynchronously loading :(  Have to directly load screen after showing this one for 1 frame
		    if (HasDrawBeenCalled)
		    {
		        LocalLogManager.AddLine("Loading screen - transition to GameScreen");
                MoveToScreen(typeof(GameScreen));
		    }
		    //if (this.AsyncLoadingState == FlatRedBall.Screens.AsyncLoadingState.NotStarted)
		    //{
		    //    StartAsyncLoad(typeof(GameScreen).FullName);
		    //}
		    //else if (this.AsyncLoadingState == FlatRedBall.Screens.AsyncLoadingState.Done)
		    //{
		    //    IsActivityFinished = true;
		    //}
        }

		void CustomDestroy()
		{


		}

        static void CustomLoadStaticContent(string contentManagerName)
        {


        }

	}
}
