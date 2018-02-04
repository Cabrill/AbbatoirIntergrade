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
            //Assign buildings to build buttons
            var listOfAllTowerTypes = GameStateManager.GetAllTowers();
            var listOfAvailableTowerTypes = PlayerDataManager.GetAvailableTowers();

            var listOfAllInstantiatedTowers = new List<BaseStructure>();

            var listOfAvailableTowers = new List<BaseStructure>();
            var listOfAvailableTowerFactories = new List<IEntityFactory>();

            foreach (var towerType in listOfAllTowerTypes)
            {
                var towerInstantiation = GetNewObject(towerType) as BaseStructure;
                MachineLearningManager.LearnMaxTowerValues(towerInstantiation);
                listOfAllInstantiatedTowers.Add(towerInstantiation);

                if (listOfAvailableTowerTypes.Contains(towerType))
                {
                    listOfAvailableTowers.Add(towerInstantiation);
                    listOfAvailableTowerFactories.Add(GetFactory(towerType.Name));
                }
            }

            BuildMenuInstance.AssociateTowers(listOfAvailableTowers, listOfAvailableTowerFactories);

            for (var i = listOfAllInstantiatedTowers.Count - 1; i >= 0; i--)
            {
                listOfAllInstantiatedTowers[i].Destroy();
            }

            ChatBoxInstance.ChatHistoryButtonClick += delegate(object sender, EventArgs args)
            {
                ChatHistoryInstance.PopulateWithChatHistory();
                GameScreenGumInstance.ShowChatHistoryAnimation.Play();
            };

            ChatHistoryInstance.CloseButtonClick += delegate(object sender, EventArgs args)
            {
                if (GameScreenGumInstance.CurrentChatHistoryShowingState == GameScreenGumRuntime.ChatHistoryShowing.ChatHistoryShown)
                    GameScreenGumInstance.HideChatHistoryAnimation.Play();
            };
            GameScreenGumInstance.HideChatHistoryAnimation.AddAction("SetupResponseAvailability", ChatBoxInstance.SetupResponseAvailability);

        }

        private object GetNewObject(Type t)
        {
            try
            {
                return t.GetConstructor(new Type[] { })?.Invoke(new object[] { });
            }
            catch
            {
                return null;
            }
        }

        static IEnumerable<IEntityFactory> factoriesInThisAssembly;
        private static IEntityFactory GetFactory(string entityType)
        {
            if (factoriesInThisAssembly == null)
            {

#if WINDOWS_8 || UWP
                var assembly = typeof(TileEntityInstantiator).GetTypeInfo().Assembly;
                var typesInThisAssembly = assembly.DefinedTypes.Select(item=>item.AsType()).ToArray();

#else
                var assembly = Assembly.GetExecutingAssembly();
                var typesInThisAssembly = assembly.GetTypes();
#endif


#if WINDOWS_8 || UWP
                var filteredTypes = typesInThisAssembly.Where(t => t.GetInterfaces().Contains(typeof(IEntityFactory))
                            && t.GetConstructors().Any(c=>c.GetParameters().Count() == 0));
#else
                var filteredTypes = typesInThisAssembly.Where(t => t.GetInterfaces().Contains(typeof(IEntityFactory))
                                                   && t.GetConstructor(Type.EmptyTypes) != null);
#endif

                factoriesInThisAssembly = filteredTypes
                    .Select(
                        t =>
                        {
#if WINDOWS_8 || UWP
                        var propertyInfo = t.GetProperty("Self");
#else
                            var propertyInfo = t.GetProperty("Self");
#endif
                            var value = propertyInfo.GetValue(null, null);
                            return value as IEntityFactory;
                        }).ToList();

            }

            var factory = factoriesInThisAssembly.FirstOrDefault(item =>
            {
                var type = item.GetType();
                var methodInfo = type.GetMethod("CreateNew", new[] { typeof(Layer), typeof(float), typeof(float) });
                var returntypeString = methodInfo.ReturnType.Name;

                return entityType == returntypeString || entityType.EndsWith("\\" + returntypeString);
            });
            return factory;
        }
    }
}
