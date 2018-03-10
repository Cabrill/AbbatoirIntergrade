using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AbbatoirIntergrade.GumRuntimes;
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
	public partial class EndingScreen
	{
	    private int endingReached;

		void CustomInitialize()
		{
		    endingReached = PlayerDataManager.PlayerEndingReached;

            var endingText = endingReached > 0 ? "Positive" : endingReached < 0 ? "Negative" : "Neutral";
		    EndingTextRuntimeInstance.Text = EndingText[endingText].EndingWords;

            ButtonInstance.Click += HandleButtonClick;
            
            EndingScreenGumInstance.CurrentFadingState = EndingScreenGumRuntime.Fading.Faded;
		}

        void CustomActivity(bool firstTimeCalled)
		{
            if(firstTimeCalled) EndingScreenGumInstance.FadeInAnimation.Play();

		}

        private void HandleButtonClick(FlatRedBall.Gui.IWindow window)
        {
            EndingScreenGumInstance.FadeOutAnimation.Play();
            this.Call(() => LoadingScreen.TransitionToScreen(typeof(MainMenu)))
                .After(EndingScreenGumInstance.FadeOutAnimation.Length);
        }


		void CustomDestroy()
		{


		}

        static void CustomLoadStaticContent(string contentManagerName)
        {


        }

	}
}
