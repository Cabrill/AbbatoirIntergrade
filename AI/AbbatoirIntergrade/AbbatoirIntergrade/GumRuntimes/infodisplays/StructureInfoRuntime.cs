using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlatRedBall;
using FlatRedBall.Gui;
using AbbatoirIntergrade.Entities.BaseEntities;
using AbbatoirIntergrade.Entities.Structures;
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
                structure.RangePreviewSprite.Visible = true;
            }
            else
            {
                Hide();
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
            AttackDamageType.ResistanceText = structure.AttackDamage.ToString();
            MinRange.AttributeText = structure.MinimumRangeRadius.ToString();
            MaxRange.AttributeText = structure.RangedRadius.ToString();
            AttackSpeed.AttributeText = structure.SecondsBetweenFiring.ToString() + " sec";
            PointOrSplash.AttributeText = structure.HasSplashDamage ? "Group" : "Single";
            SetIcon(structure.GetType());
        }

        private void SetIcon(Type tower)
        {
            if (tower == typeof(PiercingTower))
            {
                AttackDamageType.DamageTypeIconState = DamageTypeIconRuntime.DamageType.Piercing;
            }
            else if (tower == typeof(BombardingTower))
            {
                AttackDamageType.DamageTypeIconState = DamageTypeIconRuntime.DamageType.Bombarding;
            }
            else if (tower == typeof(ChemicalTower))
            {
                AttackDamageType.DamageTypeIconState = DamageTypeIconRuntime.DamageType.Chemical;
            }
            else if (tower == typeof(FireTower))
            {
                AttackDamageType.DamageTypeIconState = DamageTypeIconRuntime.DamageType.Fire;
            }
            else if (tower == typeof(FrostTower))
            {
                AttackDamageType.DamageTypeIconState = DamageTypeIconRuntime.DamageType.Frost;
            }
            else if (tower == typeof(ElectricTower))
            {
                AttackDamageType.DamageTypeIconState = DamageTypeIconRuntime.DamageType.Electric;
            }
        }

        public void Hide()
        {
            Visible = false;
            if (structureShown != null) structureShown.RangePreviewSprite.Visible = false;
        }
    }
}
