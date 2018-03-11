using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection;
using AbbatoirIntergrade.Entities.BaseEntities;
using AbbatoirIntergrade.Factories;
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
using Microsoft.Xna.Framework.Input;
using RenderingLibrary.Graphics;


namespace AbbatoirIntergrade.Screens
{
	public partial class MapScreen
	{

		void CustomInitialize()
		{
		    GameStateManager.LoadIfNecessary();

#if WINDOWS || DESKTOP_GL
            FlatRedBallServices.IsWindowsCursorVisible = true;
#endif

            AssignClickEventsAndStatusToButtons();
            MapScreenGumInstance.CurrentFadingState = MapScreenGumRuntime.Fading.Faded;
		    FillChatHistory();

		    OfferStructureChoiceIfAvailable();

		    ShowIntroMessageIfNecessary();
		}

	    private void ShowIntroMessageIfNecessary()
	    {
	        if (!PlayerDataManager.PlayerHasSeenIntro)
	        {
	            OkMessageInstance.ShowMessage(Messages["Intro"].MessageText);
	            PlayerDataManager.MarkSeenIntro();
	        }
	    }

	    private void OfferStructureChoiceIfAvailable()
	    {
	        var potentialTowers = PlayerDataManager.GetPossibleNewTowers();
	        var numberOfChoices = potentialTowers.Count;

            if (numberOfChoices > 0)
	        {
	            var structure1 = StructureFactories.GetFactory(potentialTowers[0].Name).CreateNew(StructureLayer) as BaseStructure;

                if (numberOfChoices == 1)
	            {
	                TowerSelectionBoxInstance.SetOnlyChoice(structure1);
                }
	            else
	            {
                    var structure2 = StructureFactories.GetFactory(potentialTowers[1].Name).CreateNew(StructureLayer) as BaseStructure;

	                TowerSelectionBoxInstance.SetChoices(structure1, structure2);
                }

	            TowerSelectionBoxInstance.Visible = true;
	            
	            TowerSelectionBoxInstance.ConfirmTowerSelection += ConfirmTowerSelection;
	        }
	        else
	        {
	            TowerSelectionBoxInstance.Visible = false;
	        }
	    }

	    private void ConfirmTowerSelection(IWindow window)
	    {
	        if (window is TowerSelectionBoxRuntime towerSelectionBox)
	        {
	            var selectedTower = towerSelectionBox.StructureTypeChosen;

                PlayerDataManager.AddTowerAvailability(selectedTower);
                PlayerDataManager.SaveData();

	            for (var i = StructureList.Count - 1; i >= 0; i--)
	            {
	                StructureList[i].Destroy();
	            }

	            towerSelectionBox.Visible = false;
	        }
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
            if (firstTimeCalled) MapScreenGumInstance.FadeInAnimation.Play();
#if DEBUG
            FlatRedBall.Debugging.Debugger.Write(GuiManager.Cursor.WindowOver);
#endif
            SoundManager.Update();
		    HandleKeyboardInput();
		}

	    private void HandleKeyboardInput()
	    {
	        if (InputManager.Keyboard.KeyPushed(Keys.Escape))
	        {
	            if (MenuWindowInstance.Visible)
	            {
	                MenuWindowInstance.SimulateCloseButtonClick();
	            }
	            else
	            {
	                ShowMenu(null);
	            }
	        }
	    }

        void CustomDestroy()
		{


		}

        static void CustomLoadStaticContent(string contentManagerName)
        {


        }

	    private void AssignClickEventsAndStatusToButtons()
	    {
	        var nextLevel = PlayerDataManager.LastLevelNumberCompleted+1;
	        var results = PlayerDataManager.LevelResults;

            foreach (var element in MapScreenGumInstance.ContainedElements)
	        {
	            if (element is LevelButtonRuntime levelButton)
	            {
	                if (results.Any(lr => lr.LevelName+"Level" == levelButton.LevelName))
	                {
                        //TODO:  Show level as completed
	                    levelButton.Visible = true;
	                    levelButton.Disable();

                    }
	                else if (levelButton.LevelAsNumber == nextLevel)
	                {
	                    levelButton.Click += LoadLevel;
	                    levelButton.Visible = true;
                    }
	                else
	                {
	                    levelButton.Visible = false;
	                    levelButton.Disable();
	                }
	            }
	            if (element is ButtonFrameRuntime optionsButton)
	            {
	                optionsButton.Click += ShowMenu;
	            }
	            if (element is MenuWindowRuntime menuWindow)
	            {
	                menuWindow.AssignEventToCloseButton(window => MapScreenGumInstance.HideMenuAnimation.Play(this));
                    menuWindow.AssignEventToButton0(window => FlatRedBallServices.Game.Exit());
                    menuWindow.AssignEventToButton3(window => OkMessageInstance.ShowMessage(Messages["Intro"].MessageText));
	            }
	        }
	    }

	    private void ShowMenu(IWindow window)
	    {
	        MenuWindowInstance.RefreshOptions();

            MapScreenGumInstance.ShowMenuAnimation.Play(this);
	        //this.Call(() =>MenuWindowInstance.RefreshOptions()).After(MapScreenGumInstance.ShowMenuAnimation.Length + 0.001f);
	    }

	    private void LoadLevel(IWindow window)
	    {
            //Don't react to level button presses if menu is open
	        if (MapScreenGumInstance.CurrentMenuDisplayState != MapScreenGumRuntime.MenuDisplay.MenuHidden) return;

	        var windowAsLevelButton = window as LevelButtonRuntime;

            //Don't do anything if level is disabled
	        if (windowAsLevelButton == null || !windowAsLevelButton.IsEnabled) return;

	        var levelName = windowAsLevelButton.LevelName;
	        var assembly = Assembly.GetExecutingAssembly();

	        var type = assembly.GetTypes()
	            .First(t => t.Name == levelName);

	        var level = (BaseLevel) Activator.CreateInstance(type);

	        GameStateManager.CurrentLevel = level;

            MapScreenGumInstance.FadeOutAnimation.Play();
	        this.Call(() =>
	            LoadingScreen.TransitionToScreen(typeof(GameScreen))).After(MapScreenGumInstance.FadeOutAnimation.Length);
	    }
	}
}
