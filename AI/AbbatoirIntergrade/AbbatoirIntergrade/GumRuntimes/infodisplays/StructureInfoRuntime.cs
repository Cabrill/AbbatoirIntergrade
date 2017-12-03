using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlatRedBall;
using FlatRedBall.Gui;
using AbbatoirIntergrade.Entities.BaseEntities;
using AbbatoirIntergrade.StaticManagers;
using Microsoft.Xna.Framework;

namespace AbbatoirIntergrade.GumRuntimes
{
    public partial class StructureInfoRuntime
    {
        private BaseStructure structureShown;

        partial void CustomInitialize()
        {

        }
        
        public void Show(BaseStructure structure)
        {
            if (structure == structureShown)
            {
                Visible = true;
            }
            else
            {
                SetDisplayFor(structure);
            }
        }

        private void SetDisplayFor(BaseStructure structure)
        {
            Visible = true;
            structureShown = structure;

            var minMaxX = (CameraZoomManager.OriginalOrthogonalWidth - GetAbsoluteWidth()) / 2;
            var minMaxY = (CameraZoomManager.OriginalOrthogonalHeight - GetAbsoluteHeight()) / 2;

            var newX = (structureShown.X - Camera.Main.X) * CameraZoomManager.GumCoordOffset;
            var newY = (structureShown.Y - Camera.Main.Y) *
                       CameraZoomManager.GumCoordOffset + GetAbsoluteHeight() / 2;

            X = MathHelper.Clamp(newX, -minMaxX, minMaxX);
            Y = MathHelper.Clamp(newY, -minMaxY, minMaxY);

            StructureName = structureShown.DisplayName;

            CurrentHasBatteryState = HasBattery.False;

            CurrentResourceUsageState = ResourceUsage.True;
        }

        public void Hide()
        {
            Visible = false;
        }
    }
}
