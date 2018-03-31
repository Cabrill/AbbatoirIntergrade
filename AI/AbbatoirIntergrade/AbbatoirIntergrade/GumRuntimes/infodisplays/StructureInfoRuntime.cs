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
        private StructureInfoSaveState structureSaveShown;

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

        public void Show(StructureInfoSaveState structureInfo, float xPos, float yPos)
        {
            X = xPos;
            Y = yPos;

            StructureName = structureInfo.StructureName;
            AttackDamageType.ResistanceText = structureInfo.AttackDamageType;
            SatoshiCost = structureInfo.SatoshiCostString;
            MinRange.AttributeText = structureInfo.MinRange;
            MaxRange.AttributeText = structureInfo.MaxRange;
            AttackSpeed.AttributeText = structureInfo.AttackSpeed;
            PointOrSplash.AttributeText = structureInfo.PointOrSplash;
            SatoshiCost = structureInfo.SatoshiCostString;
            SetIcon(structureInfo.TowerType);
            structureSaveShown = structureInfo;
            Visible = true;
        }

        public void DisplayChoice(BaseStructure structure)
        {
            structureShown = structure;

            structureShown.RangePreviewSprite.Visible = false;
            StructureName = structureShown.DisplayName;
            SatoshiCost = structureShown.SatoshiCost.ToString();
            AttackDamageType.ResistanceText = structure.AttackDamage.ToString();
            MinRange.AttributeText = structure.MinimumRangeRadius.ToString();
            MaxRange.AttributeText = structure.RangedRadius.ToString();
            AttackSpeed.AttributeText = structure.SecondsBetweenFiring.ToString() + " sec";
            PointOrSplash.AttributeText = structure.HasSplashDamage ? "Group" : "Single";
            SetIcon(structure.GetType());
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
            SatoshiCost = structure.SatoshiCost.ToString();
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

        public void Hide(bool clearStructureSave = false)
        {
            if (clearStructureSave) structureSaveShown = null;
            if (structureSaveShown == null) Visible = false;
            if (structureShown != null) structureShown.RangePreviewSprite.Visible = false;
        }

        public class StructureInfoSaveState
        {
            public string StructureName;
            public string AttackDamageType;
            public string MinRange;
            public string MaxRange;
            public string AttackSpeed;
            public string PointOrSplash;
            public string SatoshiCostString;
            public int SatoshiCost;
            public Type TowerType;

            public StructureInfoSaveState(BaseStructure structure)
            {
                this.StructureName = structure.DisplayName;
                this.AttackDamageType = structure.AttackDamage.ToString();
                this.MinRange = structure.MinimumRangeRadius.ToString();
                this.MaxRange = structure.RangedRadius.ToString();
                this.AttackSpeed = structure.SecondsBetweenFiring.ToString() + " sec";
                this.PointOrSplash = structure.HasSplashDamage ? "Group" : "Single";
                SatoshiCost = structure.SatoshiCost;
                SatoshiCostString = structure.SatoshiCost.ToString();
                this.TowerType = structure.GetType();
            }
        }
    }
}
