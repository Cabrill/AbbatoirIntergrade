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


namespace AbbatoirIntergrade.Screens
{
	public partial class MainMenu
	{

	    void CustomInitialize()
	    {
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
	        BbatoirSpriteInstance.AlphaRate = 0.33f;

	        NtergradeSpriteInstance.Alpha = 0;
	        NtergradeSpriteInstance.AlphaRate = 0.33f;

	        MainMenuGumRuntime.OpenEyesAnimation.PlayAfter(3, this);

            MainMenuGumRuntime.FadeInAnimation.PlayAfter(3f, this);
	        MainMenuGumRuntime.ShowAnyKeyAnimation.PlayAfter(5f);
	    }

	    void CustomActivity(bool firstTimeCalled)
	    {
            SoundManager.Update();
	        if (MainMenuGumRuntime.CurrentAnyKeyState == MainMenuGumRuntime.AnyKey.Ready && (InputManager.Keyboard.AnyKeyPushed() || InputManager.Mouse.AnyButtonPushed()))
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
