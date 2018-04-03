using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection;
using AbbatoirIntergrade.Entities.BaseEntities;
using AbbatoirIntergrade.Factories;
using AbbatoirIntergrade.GameClasses;
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
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Input;
using RenderingLibrary.Graphics;


namespace AbbatoirIntergrade.Screens
{
	public partial class MapScreen
	{
	    private SoundEffectInstance StructureChoiceSound;

	    private bool hasPopulatedChat;

		void CustomInitialize()
		{
		    LocalLogManager.AddLine("Main Menu - Load GameState Data");
            GameStateManager.LoadIfNecessary();
		    LocalLogManager.AddLine("Main Menu - Load Player Data");
            PlayerDataManager.LoadData();

#if WINDOWS || DESKTOP_GL
            FlatRedBallServices.IsWindowsCursorVisible = true;
#endif

		    StructureChoiceSound = StructureSelection.CreateInstance();

            AssignClickEventsAndStatusToButtons();
            MapScreenGumInstance.CurrentFadingState = MapScreenGumRuntime.Fading.Faded;

		    OfferStructureChoiceIfAvailable();

		    ShowIntroMessageIfNecessary();
		    CurrentMusicDisplayInstance.TimedDisplay(true);
        }

	    private void ShowIntroMessageIfNecessary()
	    {
	        if (!PlayerDataManager.PlayerHasSeenIntro)
	        {
	            LocalLogManager.AddLine("Main Menu - Show Intro Message");
                OkMessageInstance.ShowMessage(Messages["Intro"].MessageText);
	            PlayerDataManager.MarkSeenIntro();
                PlayerDataManager.SaveData();
	        }
	    }

	    private void OfferStructureChoiceIfAvailable()
	    {
	        LocalLogManager.AddLine("Main Menu - Offer structure choice");
            var potentialTowers = PlayerDataManager.GetPossibleNewTowers();
	        var numberOfChoices = potentialTowers.Count;

            if (numberOfChoices > 0)
	        {
	            var structure1 = StructureFactories.GetFactory(potentialTowers[0].Name).CreateNew(StructureLayer) as BaseStructure;
	            structure1.LightSpriteInstance.Visible = false;
	            structure1.LightAimSpriteInstance.Visible = false;

                if (numberOfChoices == 1)
	            {
	                TowerSelectionBoxInstance.SetOnlyChoice(structure1);
                }
	            else
	            {
                    var structure2 = StructureFactories.GetFactory(potentialTowers[1].Name).CreateNew(StructureLayer) as BaseStructure;
	                structure2.LightSpriteInstance.Visible = false;
	                structure2.LightAimSpriteInstance.Visible = false;

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
	            LocalLogManager.AddLine("Main Menu - Add tower selection");
                var selectedTower = towerSelectionBox.StructureTypeChosen;

	            var towerSelectionEvent = new
	            {
                    TowerSelected = selectedTower.Name,
                    SelectionNumber = PlayerDataManager.GetAvailableTowers().Count - 1,
	            };
                AnalyticsManager.SendEventImmediately("TowerSelection", towerSelectionEvent);

                PlayerDataManager.AddTowerAvailability(selectedTower);
                PlayerDataManager.SaveData();


	            for (var i = StructureList.Count - 1; i >= 0; i--)
	            {
	                StructureList[i].Destroy();
	            }

	            towerSelectionBox.Visible = false;

                SoundManager.PlaySoundEffect(StructureChoiceSound);
	        }
	    }

	    void CustomActivity(bool firstTimeCalled)
		{
            if (firstTimeCalled) MapScreenGumInstance.FadeInAnimation.Play();
#if DEBUG
            FlatRedBall.Debugging.Debugger.Write(GuiManager.Cursor.WindowOver);
#endif
		    if (SoundManager.Update()) CurrentMusicDisplayInstance.TimedDisplay();
		    HandleKeyboardInput();
		}

	    private void HandleKeyboardInput()
	    {
	        if (TowerSelectionBoxInstance.Visible) return;

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

            foreach (var element in MapScreenGumInstance.ContainedElements)
		    {
		        if (element is LevelButtonRuntime levelButton)
		        {
		            levelButton.Click -= LoadLevel;
		        }
		        if (element is ButtonFrameRuntime optionsButton)
		        {
		            optionsButton.Click -= ShowMenu;
		        }
		    }

		    if (StructureChoiceSound != null && !StructureChoiceSound.IsDisposed) StructureChoiceSound.Dispose();
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
                    menuWindow.AssignEventToButton1(window =>
                    {
                        ConfirmationWindowInstance.Confirm("Exit and return to desktop?", () =>
                        {
                            LocalLogManager.AddLine("Main Menu - Exiting game");
                            PlayerDataManager.SaveData();
                            FlatRedBallServices.Game.Exit();
                        });
                    });
                    menuWindow.ButtonType3State = ButtonFrameRuntime.ButtonType.Disabled;
                    //menuWindow.AssignEventToButton3(window => {
                    //    LocalLogManager.AddLine("Main Menu - Show chat history");
                    //    if (!hasPopulatedChat)
                    //    {
                    //        ChatHistoryInstance.PopulateWithAllChatHistory();
                    //        hasPopulatedChat = true;
                    //    }
                    //    ChatHistoryInstance.Visible = true; });
                    menuWindow.AssignEventToButton4(window => OkMessageInstance.ShowMessage(Messages["Intro"].MessageText));
	            }
	        }
	        ChatHistoryInstance.CloseButtonClick += (sender, args) => ChatHistoryInstance.Visible = false;
	    }

	    private void ShowMenu(IWindow window)
	    {
	        if (TowerSelectionBoxInstance.Visible) return;

            MenuWindowInstance.RefreshOptions();

            MapScreenGumInstance.ShowMenuAnimation.Play(this);
	        //this.Call(() =>MenuWindowInstance.RefreshOptions()).After(MapScreenGumInstance.ShowMenuAnimation.Length + 0.001f);
	    }

	    private void LoadLevel(IWindow window)
	    {
            //Don't react to level button presses if menu is open
	        if (MapScreenGumInstance.CurrentMenuDisplayState != MapScreenGumRuntime.MenuDisplay.MenuHidden) return;
	        if (TowerSelectionBoxInstance.Visible) return;

            var windowAsLevelButton = window as LevelButtonRuntime;

            //Don't do anything if level is disabled
	        if (windowAsLevelButton == null || !windowAsLevelButton.IsEnabled) return;

	        var levelName = windowAsLevelButton.LevelName;
	        var assembly = Assembly.GetExecutingAssembly();

	        var type = assembly.GetTypes()
	            .First(t => t.Name == levelName);

	        var level = (BaseLevel) Activator.CreateInstance(type);

	        GameStateManager.CurrentLevel = level;

	        LocalLogManager.AddLine("Main Menu - Load Level " + level);

            MapScreenGumInstance.FadeOutAnimation.Play();
	        this.Call(() =>
	            LoadingScreen.TransitionToScreen(typeof(GameScreen))).After(MapScreenGumInstance.FadeOutAnimation.Length);
	    }
	}
}
