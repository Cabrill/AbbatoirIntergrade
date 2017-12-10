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
                selectedObject = null;

                //var existingBuilding = AllStructuresList.FirstOrDefault(s => s.IsBeingPlaced);

                //if (existingBuilding != null)
                //{
                //    if (existingBuilding.GetType() == buildButton.BuildingType)
                //    {
                //        existingBuilding.Position = new Vector3(GuiManager.Cursor.WorldXAt(existingBuilding.Z),
                //            GuiManager.Cursor.WorldYAt(existingBuilding.Z), existingBuilding.Z);
                //        GuiManager.Cursor.ObjectGrabbed = existingBuilding;
                //        return;
                //    }

                //    existingBuilding.Destroy();
                //}

                var newBuilding = buildButton.BuildingFactory.CreateNew(WorldLayer) as BaseStructure;

                newBuilding.Position = BuildMenuInstance.CurrentPlacement.Position;
                newBuilding.IsBeingPlaced = false;

                GuiManager.Cursor.WindowPushed = null;
                //CurrentGameMode = GameMode.Building;
                BuildMenuInstance.Hide(didBuild:true);
            }
        }

        private void AssignBuildButtons()
        {
            var listOfTowerTypes = PlayerDataManager.GetAvailableTowers();
            var listOfTowers = new List<BaseStructure>();
            var listOfFactories = new List<IEntityFactory>();

            foreach (var towerType in listOfTowerTypes)
            {
                listOfTowers.Add(GetNewObject(towerType) as BaseStructure);
                listOfFactories.Add(GetFactory(towerType.Name));
            }

            BuildMenuInstance.AssociateTowers(listOfTowers, listOfFactories);

            for (var i = listOfTowers.Count - 1; i >= 0; i--)
            {
                listOfTowers[i].Destroy();
            }
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
