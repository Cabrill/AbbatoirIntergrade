using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using FlatRedBall;
using FlatRedBall.Gui;
using FlatRedBall.Math.Geometry;
using AbbatoirIntergrade.Entities.BaseEntities;
using AbbatoirIntergrade.Entities.GraphicalElements;
using AbbatoirIntergrade.GameClasses.Interfaces;
using AbbatoirIntergrade.GumRuntimes;
using AbbatoirIntergrade.Performance;
using AbbatoirIntergrade.StaticManagers;
using FlatRedBall.Graphics;
using Microsoft.Xna.Framework;

namespace AbbatoirIntergrade.Screens
{
    public partial class GameScreen
    {
        private void HandleBuildingButton()
        {
            if (GuiManager.Cursor.WindowPushed is IBuildButton buildButton && buildButton.IsEnabled)
            {
                if (selectedObject is StructurePlacement placement)
                {
                    selectedObject = null;

                    var newBuilding = buildButton.BuildingFactory.CreateNew(WorldLayer) as BaseStructure;

                    newBuilding.Position = BuildMenuInstance.CurrentPlacement.Position;
                    newBuilding.Z = 1;
                    newBuilding.IsBeingPlaced = false;
                    newBuilding.PlacementOrder = placement.PlacementOrder;

                    GuiManager.Cursor.WindowPushed = null;
                    //CurrentGameMode = GameMode.Building;
                    BuildMenuInstance.Hide(didBuild: true);
                    ChangeGameModeToNormal();
                }
            }
        }

        private void ChangeGameModeToBuilding()
        {
            CurrentGameMode = GameMode.Building;

            foreach (var placement in StructurePlacementList)
            {
                placement.CurrentCurrentlyActiveState = StructurePlacement.CurrentlyActive.Active;
            }
        }

        private void ChangeGameModeToNormal()
        {
            CurrentGameMode = GameMode.Normal;
            CurrentLevel.IsReadyForNextWave = true;

            foreach (var placement in StructurePlacementList)
            {
                placement.CurrentCurrentlyActiveState = StructurePlacement.CurrentlyActive.Inactive;
            }
        }

        private void AssignGumButtonEvents()
        {
            SetInfoBarControls();

            //Assign buildings to build buttons
            var listOfAllTowerTypes = GameStateManager.GetAllTowers();
            var listOfAvailableTowerTypes = PlayerDataManager.GetAvailableTowers();

            var listOfAllInstantiatedTowers = new List<BaseStructure>();

            var listOfAvailableTowers = new List<BaseStructure>();
            var listOfAvailableTowerFactories = new List<IEntityFactory>();

            foreach (var towerType in listOfAllTowerTypes)
            {
                var towerInstantiation = StructureFactories.GetNewObject(towerType) as BaseStructure;
                MachineLearningManager.LearnMaxTowerValues(towerInstantiation);
                listOfAllInstantiatedTowers.Add(towerInstantiation);

                if (listOfAvailableTowerTypes.Contains(towerType))
                {
                    listOfAvailableTowers.Add(towerInstantiation);
                    listOfAvailableTowerFactories.Add(StructureFactories.GetFactory(towerType.Name));
                }
            }

            BuildMenuInstance.AssociateTowers(listOfAvailableTowers, listOfAvailableTowerFactories, StructureInfoInstance);

            for (var i = listOfAllInstantiatedTowers.Count - 1; i >= 0; i--)
            {
                listOfAllInstantiatedTowers[i].Destroy();
            }

            ChatBoxInstance.ChatHistoryButtonClick += delegate(object sender, EventArgs args)
            {
                ChatHistoryInstance.PopulateWithRecentChatHistory();
                GameScreenGumInstance.ShowChatHistoryAnimation.Play();
            };

            ChatHistoryInstance.CloseButtonClick += delegate(object sender, EventArgs args)
            {
                if (GameScreenGumInstance.CurrentChatHistoryShowingState == GameScreenGumRuntime.ChatHistoryShowing.ChatHistoryShown)
                    GameScreenGumInstance.HideChatHistoryAnimation.Play();
            };
            GameScreenGumInstance.HideChatHistoryAnimation.AddAction("SetupResponseAvailability", ChatBoxInstance.SetupResponseAvailability);

        }
    }
}
