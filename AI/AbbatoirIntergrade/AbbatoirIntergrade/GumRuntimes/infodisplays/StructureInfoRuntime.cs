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
        private const int FirstUpgradeCost = 5;
        private const int SecondUpgradeCost = 8;
        private const int FinalUpgradeCost = 12;

        public Action<BaseStructure, UpgradeTypes, int> OnUpgradeAction;

        partial void CustomInitialize()
        {

        }
        
        public void Show(BaseStructure structure, int currentSatoshis, bool allowUpgrade)
        {
            if (structure == structureShown)
            {
                Visible = true;
                structure.RangePreviewSprite.Visible = true;
            }
            else
            {
                Hide();
                SetDisplayFor(structure, currentSatoshis, allowUpgrade);
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

            CurrentUpgradeAvailabilityState = UpgradeAvailability.NotAvailable;

            MaxRange.CurrentUpgradedState = AttributeDisplayRuntime.Upgraded.NotUpgraded;
            AttackSpeed.CurrentUpgradedState = AttributeDisplayRuntime.Upgraded.NotUpgraded;
            AttackDamageType.CurrentUpgradedState = ResistanceDisplayRuntime.Upgraded.NotUpgraded;
            CurrentCostInfoState = CostInfo.Shown;
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

            CurrentUpgradeAvailabilityState = UpgradeAvailability.NotAvailable;

            CurrentCostInfoState = CostInfo.Shown;
        }

        private void SetDisplayFor(BaseStructure structure, int currentSatoshis, bool allowUpgrades)
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
            AttackSpeed.AttributeText = structure.SecondsBetweenFiring + " sec";
            PointOrSplash.AttributeText = structure.HasSplashDamage ? "Group" : "Single";
            SetIcon(structure.GetType());

            var structureUpgrades = structure.GetCurrentlyAppliedUpgrades();

            MaxRange.CurrentUpgradedState = structureUpgrades.Contains(UpgradeTypes.Range)
                ? AttributeDisplayRuntime.Upgraded.IsUpgraded
                : AttributeDisplayRuntime.Upgraded.NotUpgraded;

            MinRange.CurrentUpgradedState = structureUpgrades.Contains(UpgradeTypes.Range)
                ? AttributeDisplayRuntime.Upgraded.IsUpgradedNoArrow
                : AttributeDisplayRuntime.Upgraded.NotUpgraded;

            AttackSpeed.CurrentUpgradedState = structureUpgrades.Contains(UpgradeTypes.Speed)
                ? AttributeDisplayRuntime.Upgraded.IsUpgraded
                : AttributeDisplayRuntime.Upgraded.NotUpgraded;

            AttackDamageType.CurrentUpgradedState = structureUpgrades.Contains(UpgradeTypes.Damage)
                ? ResistanceDisplayRuntime.Upgraded.IsUpgraded
                : ResistanceDisplayRuntime.Upgraded.NotUpgraded;

            var upgradeCount = structureUpgrades.Count;

            var upgradeCost = upgradeCount == 0
                ? FirstUpgradeCost
                : upgradeCount == 1
                    ? SecondUpgradeCost
                    : FinalUpgradeCost;

            if (upgradeCount == 3)
            {
                    if (UpgradeInfoInstance.PulseAnimation.IsPlaying()) UpgradeInfoInstance.PulseAnimation.Stop();
                    CurrentUpgradeAvailabilityState = UpgradeAvailability.NotAvailable;
            }
            else
            {
                var canAffordUpgrade = currentSatoshis >= upgradeCost;
                
                var hasSpeedUpgrade = structureUpgrades.Contains(UpgradeTypes.Speed);
                var hasRangeUpgrade = structureUpgrades.Contains(UpgradeTypes.Range);
                var hasDamageUpgrade = structureUpgrades.Contains(UpgradeTypes.Damage);

                UpgradeInfoInstance.SatoshiCostText = upgradeCost.ToString();
                UpgradeInfoInstance.CurrentOptionsAvailabilityState = upgradeCount == 2
                    ? UpgradeInfoRuntime.OptionsAvailability.OneOption
                    : UpgradeInfoRuntime.OptionsAvailability.TwoOptions;

                if (upgradeCount == 0)
                {
                    SetBothUpgradeButtonsFor(UpgradeTypes.Range, UpgradeTypes.Speed, upgradeCost, canAffordUpgrade);
                }
                else if (upgradeCount == 2)
                {
                    UpgradeTypes upgradeRemaining;

                    if (hasDamageUpgrade && hasSpeedUpgrade) upgradeRemaining = UpgradeTypes.Range;
                    else if (hasDamageUpgrade && hasRangeUpgrade) upgradeRemaining = UpgradeTypes.Speed;
                    else upgradeRemaining = UpgradeTypes.Damage;

                    SetSingleUpgradeButtonFor(upgradeRemaining, upgradeCost, canAffordUpgrade);
                }
                else
                {
                    var upgradeRemaining = hasSpeedUpgrade ? UpgradeTypes.Range : UpgradeTypes.Speed;

                    SetBothUpgradeButtonsFor(UpgradeTypes.Damage, upgradeRemaining, upgradeCost, canAffordUpgrade);
                }

                if (canAffordUpgrade)
                {
                    CurrentUpgradeAvailabilityState = UpgradeAvailability.Available;

                    UpgradeInfoInstance.CurrentAffordabilityState = UpgradeInfoRuntime.Affordability.CanAfford;
                    UpgradeInfoInstance.PulseAnimation.Play();
                }
                else
                {
                    CurrentUpgradeAvailabilityState = UpgradeAvailability.AvailableCantAfford;

                    if (UpgradeInfoInstance.PulseAnimation.IsPlaying()) UpgradeInfoInstance.PulseAnimation.Stop();
                    UpgradeInfoInstance.CurrentAffordabilityState = UpgradeInfoRuntime.Affordability.CantAfford;
                    UpgradeInfoInstance.OnUpgradeButton1Click = null;
                    UpgradeInfoInstance.OnUpgradeButton2Click = null;
                }
            }

            if (!allowUpgrades)
            {
                if (UpgradeInfoInstance.PulseAnimation.IsPlaying()) UpgradeInfoInstance.PulseAnimation.Stop();
                CurrentUpgradeAvailabilityState = UpgradeAvailability.NotAvailable;
            }

            CurrentCostInfoState = CostInfo.NotShown;
        }

        private void SetSingleUpgradeButtonFor(UpgradeTypes upgrade1, int upgradeCost, bool canAffordUpgrade)
        {
            UpgradeInfoInstance.OnUpgradeButton1Click = canAffordUpgrade ? CreateUpgradeButtonAction(upgrade1, upgradeCost) : null;

            switch (upgrade1)
            {
                case UpgradeTypes.Range:
                    UpgradeInfoInstance.CurrentOptionOneChoiceState = UpgradeInfoRuntime.OptionOneChoice.UpgradeRange;
                    break;
                case UpgradeTypes.Speed:
                    UpgradeInfoInstance.CurrentOptionOneChoiceState = UpgradeInfoRuntime.OptionOneChoice.UpgradeSpeed;
                    break;
                case UpgradeTypes.Damage:
                    UpgradeInfoInstance.CurrentOptionOneChoiceState = UpgradeInfoRuntime.OptionOneChoice.UpgradeDamage;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(upgrade1), upgrade1, null);
            }
        }

        private void SetBothUpgradeButtonsFor(UpgradeTypes upgrade1, UpgradeTypes upgrade2, int upgradeCost, bool canAffordUpgrade)
        {
            SetSingleUpgradeButtonFor(upgrade1, upgradeCost, canAffordUpgrade);

            UpgradeInfoInstance.OnUpgradeButton2Click = canAffordUpgrade ? CreateUpgradeButtonAction(upgrade2, upgradeCost) : null;
            switch (upgrade2)
            {
                case UpgradeTypes.Range:
                    UpgradeInfoInstance.CurrentOptionTwoChoiceState = UpgradeInfoRuntime.OptionTwoChoice.UpgradeRange;
                    break;
                case UpgradeTypes.Speed:
                    UpgradeInfoInstance.CurrentOptionTwoChoiceState = UpgradeInfoRuntime.OptionTwoChoice.UpgradeSpeed;
                    break;
                case UpgradeTypes.Damage:
                    UpgradeInfoInstance.CurrentOptionTwoChoiceState = UpgradeInfoRuntime.OptionTwoChoice.UpgradeDamage;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(upgrade2), upgrade2, null);
            }
        }

        private Action CreateUpgradeButtonAction(UpgradeTypes upgradeType, int upgradeCost)
        {
            Action buttonAction = () =>
            {
                if (UpgradeInfoInstance.PulseAnimation.IsPlaying()) UpgradeInfoInstance.PulseAnimation.Stop();
                OnUpgradeAction(structureShown, upgradeType, upgradeCost);
            };

            return buttonAction;
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
            if (UpgradeInfoInstance.PulseAnimation.IsPlaying()) UpgradeInfoInstance.PulseAnimation.Stop();

            if (structureShown != null) structureShown.RangePreviewSprite.Visible = false;
            structureSaveShown = null;
            structureShown = null;
            Visible = false;
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

        public void UpdateAffordability(int currentSatoshis, bool allowUpgrade)
        {
            if (structureShown == null) return;

            var upgradeCount = structureShown.GetCurrentlyAppliedUpgrades().Count;
            var upgradesAvailable = upgradeCount < Enum.GetNames(typeof(UpgradeTypes)).Length;

            if (allowUpgrade && upgradesAvailable)
            {
                var upgradeCost = upgradeCount == 0
                    ? FirstUpgradeCost
                    : upgradeCount == 1
                        ? SecondUpgradeCost
                        : FinalUpgradeCost;

                if (currentSatoshis >= upgradeCost)
                {
                    CurrentUpgradeAvailabilityState = UpgradeAvailability.Available;
                    UpgradeInfoInstance.PulseAnimation.Play();
                }
                else
                {
                    if (UpgradeInfoInstance.PulseAnimation.IsPlaying()) UpgradeInfoInstance.PulseAnimation.Stop();
                    CurrentUpgradeAvailabilityState = UpgradeAvailability.AvailableCantAfford;
                }
            }
            else
            {
                if (UpgradeInfoInstance.PulseAnimation.IsPlaying()) UpgradeInfoInstance.PulseAnimation.Stop();
                CurrentUpgradeAvailabilityState = UpgradeAvailability.NotAvailable;
            }
        }
    }
}

