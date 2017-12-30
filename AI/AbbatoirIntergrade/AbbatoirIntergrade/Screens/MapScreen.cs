using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection;
using AbbatoirIntergrade.GameClasses.BaseClasses;
using AbbatoirIntergrade.GumRuntimes;
using AbbatoirIntergrade.StaticManagers;
using FlatRedBall;
using FlatRedBall.Input;
using FlatRedBall.Instructions;
using FlatRedBall.AI.Pathfinding;
using FlatRedBall.Graphics.Animation;
using FlatRedBall.Graphics.Particle;
using FlatRedBall.Gui;
using FlatRedBall.Math.Geometry;
using FlatRedBall.Localization;
using Gum.Converters;
using RenderingLibrary.Graphics;


namespace AbbatoirIntergrade.Screens
{
	public partial class MapScreen
	{

		void CustomInitialize()
		{
#if WINDOWS || DESKTOP_GL
		    FlatRedBallServices.IsWindowsCursorVisible = true;
#endif
            
		    AssignClickEventsToButtons();

		    FillChatHistory();
		}

	    private void FillChatHistory()
	    {
	        for (int i = 0; i < 50; i++)
	        {
	            var chatOption = new ChatOptionRuntime(true);
	            chatOption.ChatText = "Hello to you and to me, this is message # " + i;
                if (i % 2 == 0)
                { 
	                chatOption.XOrigin = HorizontalAlignment.Left;
                    chatOption.XUnits = GeneralUnitType.PixelsFromSmall;
                }
                else
                {
                    chatOption.XOrigin = HorizontalAlignment.Right;
                    chatOption.XUnits = GeneralUnitType.PixelsFromLarge;
                }
	            //chatOption.HasEvents = false;
	            chatOption.Parent = ChatHistoryInstance.FormsControl.InnerPanel;
	        }
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

	    private void AssignClickEventsToButtons()
	    {
	        foreach (var element in MapScreenGumInstance.ContainedElements)
	        {
	            if (element is LevelButtonRuntime levelButton)
	            {
	                levelButton.Click += LoadLevel;
	            }
	            if (element is ButtonFrameRuntime optionsButton)
	            {
	                optionsButton.Click += ShowMenu;
	            }
	            if (element is MenuWindowRuntime menuWindow)
	            {
	                menuWindow.AssignEventToCloseButton(window => MapScreenGumInstance.HideMenuAnimation.Play(this));
	            }
	        }
	    }

	    private void ShowMenu(IWindow window)
	    {
            MenuWindowInstance.RefreshOptions();
	        MapScreenGumInstance.ShowMenuAnimation.Play(this);
	    }

	    private void LoadLevel(IWindow window)
	    {
            //Don't react to level button presses if menu is open
	        if (MapScreenGumInstance.CurrentMenuDisplayState != MapScreenGumRuntime.MenuDisplay.MenuHidden) return;

	        var windowAsLevelButton = window as LevelButtonRuntime;

            //Don't do anything if level is disabled
	        if (windowAsLevelButton == null || windowAsLevelButton.CurrentButtonCategoryState ==
	            LevelButtonRuntime.ButtonCategory.Disabled) return;

	        var levelName = windowAsLevelButton.LevelName;
	        var assembly = Assembly.GetExecutingAssembly();

	        var type = assembly.GetTypes()
	            .First(t => t.Name == levelName);

	        var level = (BaseLevel) Activator.CreateInstance(type);

	        GameStateManager.CurrentLevel = level;
            //LoadingScreen.TransitionToScreen(typeof(GameScreen));
            MoveToScreen(typeof(GameScreen));
	    }
	}
}
