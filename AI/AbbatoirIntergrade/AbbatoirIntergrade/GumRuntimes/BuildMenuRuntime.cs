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

        public void DisplayForPlacement(StructurePlacement placement)
        {
            CurrentPlacement = placement;

            X = CurrentPlacement.X;
            Y = CurrentPlacement.Y;

            var screenHeight = Camera.Main.OrthogonalHeight;

            if (MoreThanFour)
            {
                CurrentCapacityState = Capacity.Seven;

                if (BuildButtonInstance6.AbsoluteY < 0)
                {
                    CurrentCapacityState = X < 0 ? Capacity.SevenRight : Capacity.SevenLeft;
                }
            }
            else
            {
                CurrentCapacityState = Capacity.Four;

                if (BuildButtonInstance3.AbsoluteY < 0)
                {
                    CurrentCapacityState = X < 0 ? Capacity.FourRight : Capacity.FourLeft;
                }
            }

            Visible = true;
        }

        public void AssociateTowers(List<BaseStructure> listOfTowers, List<IEntityFactory> listOfFactories)
        {
            for (var i = 0; i < listOfTowers.Count; i++)
            {
                var tower = listOfTowers[i];
                var factory = listOfFactories[i];
                var button = GetButtonNumber(i);

                button?.UpdateFromStructure(tower, factory);
                MoreThanFour = (i > 3);
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
            if (didBuild)
            {
                CurrentPlacement.Visible = false;
            }

            CurrentPlacement = null;
            Visible = false;            
        }
    }
}
