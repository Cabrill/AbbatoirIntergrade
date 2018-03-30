using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbbatoirIntergrade.Entities.BaseEntities;
using AbbatoirIntergrade.Entities.GraphicalElements;
using AbbatoirIntergrade.Performance;
using RenderingLibrary;
using Camera = FlatRedBall.Camera;

namespace AbbatoirIntergrade.GumRuntimes
{
    public partial class BuildMenuRuntime
    {
        public StructurePlacement CurrentPlacement { get; private set; }
        private bool MoreThanFour = false;

        private StructureInfoRuntime structureInfoDisplay;

        private List<BuildButtonRuntime> allButtons;

        partial void CustomInitialize()
        {
            allButtons = new List<BuildButtonRuntime>
            {
                BuildButtonInstance0,
                BuildButtonInstance1,
                BuildButtonInstance2,
                BuildButtonInstance3,
                BuildButtonInstance4,
                BuildButtonInstance5,
                BuildButtonInstance6
            };
        }

        public void UpdateAffordability(int currentSatoshis)
        {
            foreach (var button in allButtons)
            {
                button.UpdateAffordability(currentSatoshis);
            }
        }

        public void DisplayForPlacement(StructurePlacement placement)
        {
            CurrentPlacement = placement;

            X = CurrentPlacement.X;
            Y = CurrentPlacement.Y;

            if (MoreThanFour)
            {
                CurrentCapacityState = Capacity.Seven;

                if (BuildButtonInstance6.AbsoluteY < 0 || X > 0.9f*Camera.Main.OrthogonalWidth/2 || X < -0.9f*Camera.Main.OrthogonalWidth/2)
                {
                    CurrentCapacityState = X < 0 ? Capacity.SevenRight : Capacity.SevenLeft;
                }
            }
            else
            {
                CurrentCapacityState = Capacity.Four;

                if (BuildButtonInstance3.AbsoluteY < 0 || X > 0.9f * Camera.Main.OrthogonalWidth / 2 || X < -0.9f * Camera.Main.OrthogonalWidth / 2)
                {
                    CurrentCapacityState = X < 0 ? Capacity.FourRight : Capacity.FourLeft;
                }
            }
            Visible = true;
        }

        public void AssociateTowers(List<BaseStructure> listOfTowers, List<IEntityFactory> listOfFactories, StructureInfoRuntime structureInfoRuntime, int currentSatoshis)
        {
            structureInfoDisplay = structureInfoRuntime;
            for (var i = 0; i < 7; i++)
            {
                var button = GetButtonNumber(i);
                if (button == null) continue;

                if (i < listOfTowers.Count)
                {
                    var tower = listOfTowers[i];
                    var factory = listOfFactories[i];

                    button.UpdateFromStructure(tower, factory, currentSatoshis);
                    button.RangeDisplayAction = ShowRangePreview;
                    button.InfoDisplayAction = ShowStructureInfoPreview;
                    button.HideRangePreviewAction = HideRangePreview;
                    button.HideStructurePreviewAction = HideStructureInfoPreview;
                    MoreThanFour = (i > 3);
                }
                else
                {
                    button?.Disable();
                }
            }

        }

        private BuildButtonRuntime GetButtonNumber(int buttonNumber)
        {
            switch (buttonNumber)
            {
                case 0: return BuildButtonInstance0;
                case 1: return BuildButtonInstance1;
                case 2: return BuildButtonInstance2;
                case 3: return BuildButtonInstance3;
                case 4: return BuildButtonInstance4;
                case 5: return BuildButtonInstance5;
                case 6: return BuildButtonInstance6;
            }
            return null;
        }

        public void Hide(bool didBuild = false)
        {
            HideRangePreview();
            if (didBuild)
            {
                CurrentPlacement.Visible = false;
            }

            CurrentPlacement = null;
            Visible = false;            
        }

        private void ShowRangePreview(Tuple<int, int> rangeTuple, float xOffset, float yOffset)
        {
            if (CurrentPlacement == null) return;

            var rangeTexture = BaseStructure.GetRangeTexture(rangeTuple);

            CurrentPlacement.RangePreviewSprite.Texture = rangeTexture;
            CurrentPlacement.RangePreviewSprite.RelativeX = xOffset;
            CurrentPlacement.RangePreviewSprite.RelativeY = yOffset;
            CurrentPlacement.RangePreviewSprite.Visible = true;
        }

        private void HideRangePreview()
        {
            if (CurrentPlacement == null) return;

            CurrentPlacement.RangePreviewSprite.Visible = false;
        }

        private void ShowStructureInfoPreview(StructureInfoRuntime.StructureInfoSaveState structureInfo)
        {
            float xPos, yPos;

            if (CurrentCapacityState == Capacity.Four || CurrentCapacityState == Capacity.Seven)
            {
                xPos = X + (X > 0 ? -structureInfoDisplay.GetAbsoluteWidth() : structureInfoDisplay.GetAbsoluteWidth());
                if (CurrentCapacityState == Capacity.Seven)
                {
                    yPos = Y + (Y > 0
                               ? -structureInfoDisplay.GetAbsoluteHeight()
                               : structureInfoDisplay.GetAbsoluteHeight() / 2);
                }
                else
                {
                    yPos = Y + structureInfoDisplay.GetAbsoluteHeight() / 3;
                }
            }
            else if (CurrentCapacityState == Capacity.FourRight || CurrentCapacityState == Capacity.SevenRight)
            {
                xPos = X + GetAbsoluteHeight() / 2;
                if (Y > 0)
                {
                    yPos = Y - structureInfoDisplay.GetAbsoluteWidth();
                }
                else
                {
                    yPos = Y + structureInfoDisplay.GetAbsoluteWidth();
                }
            }
            else
            {
                xPos = X - GetAbsoluteHeight() / 2;
                if (Y > 0)
                {
                    yPos = Y - structureInfoDisplay.GetAbsoluteWidth();
                }
                else
                {
                    yPos = Y + structureInfoDisplay.GetAbsoluteWidth();
                }
            }

            structureInfoDisplay.Show(structureInfo, xPos, yPos);
        }

        private void HideStructureInfoPreview()
        {
            structureInfoDisplay.Hide(true);
        }
    }
}
