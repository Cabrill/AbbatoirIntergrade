using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbbatoirIntergrade.Entities.BaseEntities;
using AbbatoirIntergrade.Entities.Structures;
using FlatRedBall.Gui;

namespace AbbatoirIntergrade.GumRuntimes
{
    public partial class TowerSelectionBoxRuntime
    {
        public WindowEvent ConfirmTowerSelection;
        public Type StructureTypeChosen;

        private Type towerType1;
        private Type towerType2;

        public void SetChoices(BaseStructure structure1, BaseStructure structure2)
        {
            CurrentSelectionModeState = SelectionMode.Double;

            towerType1 = structure1.GetType();
            towerType2 = structure2.GetType();

            StructureChoice1.DisplayChoice(structure1);
            StructureChoice2.DisplayChoice(structure2);

            StructureChoice1.HasEvents = true;
            StructureChoice1.ExposeChildrenEvents = false;

            StructureChoice2.HasEvents = true;
            StructureChoice2.ExposeChildrenEvents = false;

            structure1.X = StructureChoice1.X;
            structure1.Y = StructureChoice1.Y-260;
            structure1.Z = 2;
            structure1.IsBeingPlaced = false;

            structure2.X = StructureChoice2.X;
            structure2.Y = StructureChoice2.Y-260;
            structure2.Z = 2;
            structure2.IsBeingPlaced = false;

            StructureChoice1.Click += StructureChoice1_Click;
            StructureChoice2.Click += StructureChoice2_Click;

            ConfirmButton.Click += (unused) => ConfirmTowerSelection?.Invoke(this);
        }

        private void StructureChoice2_Click(FlatRedBall.Gui.IWindow window)
        {
            StructureChoice1.CurrentSelectionState = StructureInfoRuntime.Selection.NotSelected;
            StructureChoice2.CurrentSelectionState = StructureInfoRuntime.Selection.Selected;

            StructureTypeChosen = towerType2;
            ConfirmButton.Visible = true;
        }

        private void StructureChoice1_Click(FlatRedBall.Gui.IWindow window)
        {
            StructureChoice1.CurrentSelectionState = StructureInfoRuntime.Selection.Selected;
            StructureChoice2.CurrentSelectionState = StructureInfoRuntime.Selection.NotSelected;

            StructureTypeChosen = towerType1;

            ConfirmButton.Visible = true;
        }

        public void SetOnlyChoice(BaseStructure structure1)
        {
            CurrentSelectionModeState = SelectionMode.Single;

            towerType1 = structure1.GetType();
            StructureTypeChosen = towerType1;

            StructureChoice1.DisplayChoice(structure1);

            StructureChoice1.HasEvents = false;
            StructureChoice1.ExposeChildrenEvents = false;

            structure1.X = StructureChoice1.X;
            structure1.Y = StructureChoice1.Y - 260;
            structure1.Z = 2;
            structure1.IsBeingPlaced = false;
            
            ConfirmButton.Click += (unused) => ConfirmTowerSelection?.Invoke(this);
            ConfirmButton.Visible = true;
        }
    }
}
