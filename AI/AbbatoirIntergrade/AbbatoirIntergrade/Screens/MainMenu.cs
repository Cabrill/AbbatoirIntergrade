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
using StateInterpolationPlugin;
using AbbatoirIntergrade.GumRuntimes.unique;

namespace AbbatoirIntergrade.Screens
{
	public partial class MainMenu
	{

	    void CustomInitialize()
	    {
            LocalLogManager.AddLine("Main Menu");
	        GameStateManager.LoadIfNecessary();

#if WINDOWS || DESKTOP_GL
            FlatRedBallServices.IsWindowsCursorVisible = true;
#endif
	        OrchestrateIntroAnimation();
            
            SoundManager.PlaySong(GlobalContent.anttisinstrumentals_aluodetunefish, true,true );
	    }

	    void OrchestrateIntroAnimation()
	    {
	        MainMenuGumRuntime.CurrentAnyKeyState = MainMenuGumRuntime.AnyKey.NotReady;
            MainMenuGumRuntime.CurrentFadeState = MainMenuGumRuntime.Fade.FadedOut;

	        BbatoirSpriteInstance.Alpha = 0;
	        NtergradeSpriteInstance.Alpha = 0;

	        this.Call(() =>
	        {
	            BbatoirSpriteInstance.AlphaRate = 0.33f;
	            NtergradeSpriteInstance.AlphaRate = 0.33f;
	        }).After(1.5f);

	        MainMenuGumRuntime.OpenEyesAnimation.PlayAfter(4, this);

            MainMenuGumRuntime.FadeInAnimation.PlayAfter(4.5f, this);
	        MainMenuGumRuntime.ShowAnyKeyAnimation.PlayAfter(5f);
	    }

	    void CustomActivity(bool firstTimeCalled)
	    {
	        SoundManager.Update();
            if (MainMenuGumRuntime.CurrentAnyKeyState == MainMenuGumRuntime.AnyKey.Ready && (InputManager.Keyboard.AnyKeyPushed() || InputManager.Mouse.AnyButtonPushed()))
	        {
                MainMenuGumRuntime.FadeOutAnimation.Play();
	            LocalLogManager.AddLine("Transition to MapScreen");
                this.Call(()=>LoadingScreen.TransitionToScreen(typeof(MapScreen))).After(MainMenuGumRuntime.FadeOutAnimation.Length);
	        }
            else if (LeftEye.CurrentEyeOpeningState == MainMenuEyeRuntime.EyeOpening.Open && !MainMenuGumRuntime.OpenEyesAnimation.IsPlaying() && !MainMenuGumRuntime.BlinkEyesAnimation.IsPlaying())
	        {
	            var random = FlatRedBallServices.Random.NextDouble();

	            if (random >= 0.995f)
	            {
	                MainMenuGumRuntime.BlinkEyesAnimation.Play(this);
	            }
	        }

	        if (MainMenuGumRuntime.CurrentFadeState == MainMenuGumRuntime.Fade.NotFaded)
	        {
	            MainMenuGumRuntime.UpdateDimming();
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
