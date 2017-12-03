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
using AbbatoirIntergrade.StaticManagers;
using Microsoft.Xna.Framework;

namespace AbbatoirIntergrade.Screens
{
    public partial class GameScreen
    {
        private void HandleBuildingButton()
        {
            if (GuiManager.Cursor.WindowPushed is IBuildButton buildButton && buildButton.IsEnabled &&
                GuiManager.Cursor.WindowOver != GuiManager.Cursor.WindowPushed)
            {
                selectedObject = null;


                var existingBuilding = AllStructuresList.FirstOrDefault(s => s.IsBeingPlaced);

                if (existingBuilding != null)
                {
                    if (existingBuilding.GetType() == buildButton.BuildingType)
                    {
                        existingBuilding.Position = new Vector3(GuiManager.Cursor.WorldXAt(existingBuilding.Z),
                            GuiManager.Cursor.WorldYAt(existingBuilding.Z), existingBuilding.Z);
                        GuiManager.Cursor.ObjectGrabbed = existingBuilding;
                        return;
                    }

                    existingBuilding.Destroy();
                }

                var newBuilding = buildButton.BuildingFactory.CreateNew(WorldLayer) as BaseStructure;

                    newBuilding.Position = new Vector3(GuiManager.Cursor.WorldXAt(newBuilding.Z),
                        GuiManager.Cursor.WorldYAt(newBuilding.Z), newBuilding.Z);
                    GuiManager.Cursor.ObjectGrabbed = newBuilding;
                GuiManager.Cursor.WindowPushed = null;
                CurrentGameMode = GameMode.Building;
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


    }
}
