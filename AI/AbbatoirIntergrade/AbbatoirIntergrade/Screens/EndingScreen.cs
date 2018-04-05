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
using Gum.Wireframe;
using RenderingLibrary;
using Camera = FlatRedBall.Camera;


namespace AbbatoirIntergrade.Screens
{
	public partial class EndingScreen
	{
	    private EndingTypes endingReached;
	    private bool isDisplayingCredits;

		void CustomInitialize()
		{
#if WINDOWS || DESKTOP_GL
		    FlatRedBallServices.IsWindowsCursorVisible = true;
#endif
            GameStateManager.LoadIfNecessary();

            endingReached = PlayerDataManager.PlayerEndingReached;

		    EndingTextContainer.EndingTextText = EndingText[endingReached.ToString()].EndingWords;

            switch (endingReached)
		    {
		        case EndingTypes.None:
		            break;
		        case EndingTypes.Positive:
		            SoundManager.PlaySong(GlobalContent.Brallit_Robotic_Chaotic, true, true);
		            EndingScreenGumInstance.CurrentEndingsState = EndingScreenGumRuntime.Endings.Positive;
                    break;
		        case EndingTypes.Neutral:
		            SoundManager.PlaySong(GlobalContent.anttisinstrumentals_glitchthis, true, true);
		            EndingScreenGumInstance.CurrentEndingsState = EndingScreenGumRuntime.Endings.Neutral;
                    break;
		        case EndingTypes.Negative:
		            SoundManager.PlaySong(GlobalContent.Brallit_One_Accord, true, true);
		            EndingScreenGumInstance.CurrentEndingsState = EndingScreenGumRuntime.Endings.Negative;
                    break;
		        case EndingTypes.Silent:
		            SoundManager.PlaySong(GlobalContent.Brallit_One_Accord, true, true);
		            EndingScreenGumInstance.CurrentEndingsState = EndingScreenGumRuntime.Endings.Negative;
                    break;
		        default:
		            throw new ArgumentOutOfRangeException();
		    }

            ButtonInstance.Click += HandleButtonClick;

            EndingScreenGumInstance.CurrentFadingState = EndingScreenGumRuntime.Fading.Faded;
		}

        void CustomActivity(bool firstTimeCalled)
		{
            if(firstTimeCalled) EndingScreenGumInstance.FadeInAnimation.Play();

		    if (isDisplayingCredits)
		    {
		        (CreditsContainer.Children[0] as GraphicalUiElement).Y -= (float)TimeManager.CurrentTime/3;

		        var lastItem = CreditsContainer.Children[CreditsContainer.Children.Count - 1];
		        var lastItemHeight = lastItem.Height;
		        var lastItemY = IPositionedSizedObjectExtensionMethods.GetAbsoluteY(lastItem);

		        if (lastItemY < -lastItemHeight)
		        {
		            ReturnToMenu();
		        }
		    }
		}

        private void HandleButtonClick(FlatRedBall.Gui.IWindow window)
        {
            EndingScreenGumInstance.FadeOutAnimation.Play();
            this.Call(RollCredits)
                .After(EndingScreenGumInstance.FadeOutAnimation.Length);
        }

	    private void RollCredits()
	    {
	        var setFirst = false;
	        foreach (var item in EndingCredits.Values)
	        {
	            var titleDisplay = new CreditDisplayRuntime
	                {
	                    CurrentCreditTypeState = CreditDisplayRuntime.CreditType.Header,
	                    Parent = CreditsContainer,
	                    DisplayText = item.Title
	                };
	            if (!setFirst)
	            {
	                titleDisplay.Y = Camera.Main.OrthogonalHeight;
	                setFirst = true;
	            }

	            foreach (var credit in item.Credit)
	            {
	                var creditDisplay =
	                    new CreditDisplayRuntime
	                    {
	                        CurrentCreditTypeState = CreditDisplayRuntime.CreditType.Detail,
	                        Parent = CreditsContainer,
	                        DisplayText = credit
	                    };
	            }
	        }
            isDisplayingCredits = true;
	    }

	    private void ReturnToMenu()
	    {
	        LoadingScreen.TransitionToScreen(typeof(MainMenu));
	    }


		void CustomDestroy()
		{


		}

        static void CustomLoadStaticContent(string contentManagerName)
        {


        }

	}
}
