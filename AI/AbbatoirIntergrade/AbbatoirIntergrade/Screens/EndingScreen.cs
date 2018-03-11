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
#if WINDOWS || DESKTOP_GL
		    FlatRedBallServices.IsWindowsCursorVisible = true;
#endif
            GameStateManager.LoadIfNecessary();

            endingReached = PlayerDataManager.PlayerEndingReached;

            var endingText = endingReached > 0 ? "Positive" : endingReached < 0 ? "Negative" : "Neutral";
            EndingTextContainer.EndingTextText = EndingText[endingText].EndingWords;

            ButtonInstance.Click += HandleButtonClick;

		    if (endingReached > 0)
		    {
		        SoundManager.PlaySong(GlobalContent.Brallit_Robotic_Chaotic, true, true);
            }
            else if (endingReached < 0)
		    {
		        SoundManager.PlaySong(GlobalContent.Brallit_One_Accord, true, true);
            }
		    else
		    {
		        SoundManager.PlaySong(GlobalContent.anttisinstrumentals_glitchthis, true, true);
            }
            
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
