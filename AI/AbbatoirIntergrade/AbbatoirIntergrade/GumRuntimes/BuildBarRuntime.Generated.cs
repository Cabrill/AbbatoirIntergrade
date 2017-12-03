    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes
    {
        public partial class BuildBarRuntime : AbbatoirIntergrade.GumRuntimes.ContainerRuntime
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            public enum BuildMenu
            {
                BuildEnergy,
                BuildCombat,
                BuildUtility,
                None
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            BuildMenu mCurrentBuildMenuState;
            #endregion
            #region State Properties
            public VariableState CurrentVariableState
            {
                get
                {
                    return mCurrentVariableState;
                }
                set
                {
                    mCurrentVariableState = value;
                    switch(mCurrentVariableState)
                    {
                        case  VariableState.Default:
                            ChildrenLayout = Gum.Managers.ChildrenLayout.Regular;
                            ClipsChildren = false;
                            Height = 40f;
                            HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            Visible = true;
                            Width = 100f;
                            WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            WrapsChildren = true;
                            XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                            YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            SolarButton.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "EnergyButtons");
                            SolarButton.CurrentStructureTypeState = AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime.StructureType.Energy;
                            SolarButton.X = 3f;
                            SolarButton.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            EnergyButtons.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                            EnergyButtons.Height = 30f;
                            EnergyButtons.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            EnergyButtons.Width = 50f;
                            EnergyButtons.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            EnergyButtons.WrapsChildren = true;
                            EnergyButtons.X = 13.16335f;
                            EnergyButtons.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            EnergyButtons.Y = 51.3889f;
                            EnergyButtons.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            CombatButtons.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                            CombatButtons.Height = 30f;
                            CombatButtons.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            CombatButtons.Visible = true;
                            CombatButtons.Width = 50f;
                            CombatButtons.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            CombatButtons.WrapsChildren = true;
                            CombatButtons.X = 1690f;
                            CombatButtons.Y = 303f;
                            UtilityButtons.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                            UtilityButtons.Height = 30f;
                            UtilityButtons.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            UtilityButtons.Visible = true;
                            UtilityButtons.Width = 50f;
                            UtilityButtons.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            UtilityButtons.WrapsChildren = true;
                            UtilityButtons.X = 8.923834f;
                            UtilityButtons.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            UtilityButtons.Y = 10.26004f;
                            UtilityButtons.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            WindButton.CurrentEnabledStatusState = AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime.EnabledStatus.Enabled;
                            WindButton.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "EnergyButtons");
                            WindButton.CurrentStructureTypeState = AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime.StructureType.Energy;
                            WindButton.X = 0f;
                            WindButton.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            HydroButton.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "EnergyButtons");
                            HydroButton.CurrentStructureTypeState = AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime.StructureType.Energy;
                            HydroButton.X = 3f;
                            HydroButton.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            LaserTurretButton.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "CombatButtons");
                            LaserTurretButton.CurrentStructureTypeState = AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime.StructureType.Combat;
                            LaserTurretButton.X = 1f;
                            LaserTurretButton.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            BatteryButton.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "UtilityButtons");
                            BatteryButton.CurrentStructureTypeState = AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime.StructureType.Utility;
                            BatteryButton.X = 0f;
                            BatteryButton.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            ShieldGeneratorButton.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "UtilityButtons");
                            ShieldGeneratorButton.CurrentStructureTypeState = AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime.StructureType.Utility;
                            ShieldGeneratorButton.X = 3f;
                            ShieldGeneratorButton.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            CarbonTreeButton.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "UtilityButtons");
                            CarbonTreeButton.CurrentStructureTypeState = AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime.StructureType.Utility;
                            CarbonTreeButton.Width = 100f;
                            CarbonTreeButton.X = 3f;
                            CarbonTreeButton.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            CannonButton.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "CombatButtons");
                            CannonButton.CurrentStructureTypeState = AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime.StructureType.Combat;
                            CannonButton.X = 1f;
                            CannonButton.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            TallLaserButton.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "CombatButtons");
                            TallLaserButton.CurrentStructureTypeState = AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime.StructureType.Combat;
                            TallLaserButton.X = 1f;
                            TallLaserButton.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            UtilityStructureButton.CurrentCategoryState = AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime.Category.Utility;
                            UtilityStructureButton.Height = 35f;
                            UtilityStructureButton.Width = 8.607957f;
                            UtilityStructureButton.X = 0.2367424f;
                            UtilityStructureButton.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            UtilityStructureButton.Y = 10.52189f;
                            UtilityStructureButton.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            CombatStructureButton.CurrentCategoryState = AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime.Category.Combat;
                            CombatStructureButton.Height = 40f;
                            CombatStructureButton.Width = 10f;
                            CombatStructureButton.X = 87.83141f;
                            CombatStructureButton.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            CombatStructureButton.Y = 53.04403f;
                            CombatStructureButton.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            EnergyStructureButton.CurrentCategoryState = AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime.Category.Energy;
                            EnergyStructureButton.Height = 40f;
                            EnergyStructureButton.Width = 10f;
                            EnergyStructureButton.X = 2.843276f;
                            EnergyStructureButton.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            EnergyStructureButton.Y = 50.63406f;
                            EnergyStructureButton.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            break;
                    }
                }
            }
            public BuildMenu CurrentBuildMenuState
            {
                get
                {
                    return mCurrentBuildMenuState;
                }
                set
                {
                    mCurrentBuildMenuState = value;
                    switch(mCurrentBuildMenuState)
                    {
                        case  BuildMenu.BuildEnergy:
                            EnergyButtons.Visible = true;
                            CombatButtons.Visible = false;
                            UtilityButtons.Visible = false;
                            UtilityStructureButton.CurrentHighlightedState = AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime.Highlighted.False;
                            CombatStructureButton.CurrentHighlightedState = AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime.Highlighted.False;
                            EnergyStructureButton.CurrentHighlightedState = AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime.Highlighted.True;
                            EnergyStructureButton.Visible = true;
                            break;
                        case  BuildMenu.BuildCombat:
                            EnergyButtons.Visible = false;
                            CombatButtons.Visible = true;
                            UtilityButtons.Visible = false;
                            UtilityStructureButton.CurrentHighlightedState = AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime.Highlighted.False;
                            CombatStructureButton.CurrentHighlightedState = AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime.Highlighted.True;
                            EnergyStructureButton.CurrentHighlightedState = AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime.Highlighted.False;
                            EnergyStructureButton.Visible = true;
                            break;
                        case  BuildMenu.BuildUtility:
                            EnergyButtons.Visible = false;
                            CombatButtons.Visible = false;
                            UtilityButtons.Visible = true;
                            UtilityStructureButton.CurrentHighlightedState = AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime.Highlighted.True;
                            CombatStructureButton.CurrentHighlightedState = AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime.Highlighted.False;
                            EnergyStructureButton.CurrentHighlightedState = AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime.Highlighted.False;
                            EnergyStructureButton.Visible = true;
                            break;
                        case  BuildMenu.None:
                            EnergyButtons.Visible = false;
                            CombatButtons.Visible = false;
                            UtilityButtons.Visible = false;
                            UtilityStructureButton.CurrentHighlightedState = AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime.Highlighted.False;
                            CombatStructureButton.CurrentHighlightedState = AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime.Highlighted.False;
                            EnergyStructureButton.CurrentHighlightedState = AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime.Highlighted.False;
                            EnergyStructureButton.Visible = true;
                            break;
                    }
                }
            }
            #endregion
            #region State Interpolation
            public void InterpolateBetween (VariableState firstState, VariableState secondState, float interpolationValue)
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setBatteryButtonCurrentStructureTypeStateFirstValue = false;
                bool setBatteryButtonCurrentStructureTypeStateSecondValue = false;
                BuildButtonRuntime.StructureType BatteryButtonCurrentStructureTypeStateFirstValue= BuildButtonRuntime.StructureType.Energy;
                BuildButtonRuntime.StructureType BatteryButtonCurrentStructureTypeStateSecondValue= BuildButtonRuntime.StructureType.Energy;
                bool setBatteryButtonXFirstValue = false;
                bool setBatteryButtonXSecondValue = false;
                float BatteryButtonXFirstValue= 0;
                float BatteryButtonXSecondValue= 0;
                bool setCannonButtonCurrentStructureTypeStateFirstValue = false;
                bool setCannonButtonCurrentStructureTypeStateSecondValue = false;
                BuildButtonRuntime.StructureType CannonButtonCurrentStructureTypeStateFirstValue= BuildButtonRuntime.StructureType.Energy;
                BuildButtonRuntime.StructureType CannonButtonCurrentStructureTypeStateSecondValue= BuildButtonRuntime.StructureType.Energy;
                bool setCannonButtonXFirstValue = false;
                bool setCannonButtonXSecondValue = false;
                float CannonButtonXFirstValue= 0;
                float CannonButtonXSecondValue= 0;
                bool setCarbonTreeButtonCurrentStructureTypeStateFirstValue = false;
                bool setCarbonTreeButtonCurrentStructureTypeStateSecondValue = false;
                BuildButtonRuntime.StructureType CarbonTreeButtonCurrentStructureTypeStateFirstValue= BuildButtonRuntime.StructureType.Energy;
                BuildButtonRuntime.StructureType CarbonTreeButtonCurrentStructureTypeStateSecondValue= BuildButtonRuntime.StructureType.Energy;
                bool setCarbonTreeButtonWidthFirstValue = false;
                bool setCarbonTreeButtonWidthSecondValue = false;
                float CarbonTreeButtonWidthFirstValue= 0;
                float CarbonTreeButtonWidthSecondValue= 0;
                bool setCarbonTreeButtonXFirstValue = false;
                bool setCarbonTreeButtonXSecondValue = false;
                float CarbonTreeButtonXFirstValue= 0;
                float CarbonTreeButtonXSecondValue= 0;
                bool setCombatButtonsHeightFirstValue = false;
                bool setCombatButtonsHeightSecondValue = false;
                float CombatButtonsHeightFirstValue= 0;
                float CombatButtonsHeightSecondValue= 0;
                bool setCombatButtonsWidthFirstValue = false;
                bool setCombatButtonsWidthSecondValue = false;
                float CombatButtonsWidthFirstValue= 0;
                float CombatButtonsWidthSecondValue= 0;
                bool setCombatButtonsXFirstValue = false;
                bool setCombatButtonsXSecondValue = false;
                float CombatButtonsXFirstValue= 0;
                float CombatButtonsXSecondValue= 0;
                bool setCombatButtonsYFirstValue = false;
                bool setCombatButtonsYSecondValue = false;
                float CombatButtonsYFirstValue= 0;
                float CombatButtonsYSecondValue= 0;
                bool setCombatStructureButtonCurrentCategoryStateFirstValue = false;
                bool setCombatStructureButtonCurrentCategoryStateSecondValue = false;
                CategoryButtonRuntime.Category CombatStructureButtonCurrentCategoryStateFirstValue= CategoryButtonRuntime.Category.Utility;
                CategoryButtonRuntime.Category CombatStructureButtonCurrentCategoryStateSecondValue= CategoryButtonRuntime.Category.Utility;
                bool setCombatStructureButtonHeightFirstValue = false;
                bool setCombatStructureButtonHeightSecondValue = false;
                float CombatStructureButtonHeightFirstValue= 0;
                float CombatStructureButtonHeightSecondValue= 0;
                bool setCombatStructureButtonWidthFirstValue = false;
                bool setCombatStructureButtonWidthSecondValue = false;
                float CombatStructureButtonWidthFirstValue= 0;
                float CombatStructureButtonWidthSecondValue= 0;
                bool setCombatStructureButtonXFirstValue = false;
                bool setCombatStructureButtonXSecondValue = false;
                float CombatStructureButtonXFirstValue= 0;
                float CombatStructureButtonXSecondValue= 0;
                bool setCombatStructureButtonYFirstValue = false;
                bool setCombatStructureButtonYSecondValue = false;
                float CombatStructureButtonYFirstValue= 0;
                float CombatStructureButtonYSecondValue= 0;
                bool setEnergyButtonsHeightFirstValue = false;
                bool setEnergyButtonsHeightSecondValue = false;
                float EnergyButtonsHeightFirstValue= 0;
                float EnergyButtonsHeightSecondValue= 0;
                bool setEnergyButtonsWidthFirstValue = false;
                bool setEnergyButtonsWidthSecondValue = false;
                float EnergyButtonsWidthFirstValue= 0;
                float EnergyButtonsWidthSecondValue= 0;
                bool setEnergyButtonsXFirstValue = false;
                bool setEnergyButtonsXSecondValue = false;
                float EnergyButtonsXFirstValue= 0;
                float EnergyButtonsXSecondValue= 0;
                bool setEnergyButtonsYFirstValue = false;
                bool setEnergyButtonsYSecondValue = false;
                float EnergyButtonsYFirstValue= 0;
                float EnergyButtonsYSecondValue= 0;
                bool setEnergyStructureButtonCurrentCategoryStateFirstValue = false;
                bool setEnergyStructureButtonCurrentCategoryStateSecondValue = false;
                CategoryButtonRuntime.Category EnergyStructureButtonCurrentCategoryStateFirstValue= CategoryButtonRuntime.Category.Utility;
                CategoryButtonRuntime.Category EnergyStructureButtonCurrentCategoryStateSecondValue= CategoryButtonRuntime.Category.Utility;
                bool setEnergyStructureButtonHeightFirstValue = false;
                bool setEnergyStructureButtonHeightSecondValue = false;
                float EnergyStructureButtonHeightFirstValue= 0;
                float EnergyStructureButtonHeightSecondValue= 0;
                bool setEnergyStructureButtonWidthFirstValue = false;
                bool setEnergyStructureButtonWidthSecondValue = false;
                float EnergyStructureButtonWidthFirstValue= 0;
                float EnergyStructureButtonWidthSecondValue= 0;
                bool setEnergyStructureButtonXFirstValue = false;
                bool setEnergyStructureButtonXSecondValue = false;
                float EnergyStructureButtonXFirstValue= 0;
                float EnergyStructureButtonXSecondValue= 0;
                bool setEnergyStructureButtonYFirstValue = false;
                bool setEnergyStructureButtonYSecondValue = false;
                float EnergyStructureButtonYFirstValue= 0;
                float EnergyStructureButtonYSecondValue= 0;
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setHydroButtonCurrentStructureTypeStateFirstValue = false;
                bool setHydroButtonCurrentStructureTypeStateSecondValue = false;
                BuildButtonRuntime.StructureType HydroButtonCurrentStructureTypeStateFirstValue= BuildButtonRuntime.StructureType.Energy;
                BuildButtonRuntime.StructureType HydroButtonCurrentStructureTypeStateSecondValue= BuildButtonRuntime.StructureType.Energy;
                bool setHydroButtonXFirstValue = false;
                bool setHydroButtonXSecondValue = false;
                float HydroButtonXFirstValue= 0;
                float HydroButtonXSecondValue= 0;
                bool setLaserTurretButtonCurrentStructureTypeStateFirstValue = false;
                bool setLaserTurretButtonCurrentStructureTypeStateSecondValue = false;
                BuildButtonRuntime.StructureType LaserTurretButtonCurrentStructureTypeStateFirstValue= BuildButtonRuntime.StructureType.Energy;
                BuildButtonRuntime.StructureType LaserTurretButtonCurrentStructureTypeStateSecondValue= BuildButtonRuntime.StructureType.Energy;
                bool setLaserTurretButtonXFirstValue = false;
                bool setLaserTurretButtonXSecondValue = false;
                float LaserTurretButtonXFirstValue= 0;
                float LaserTurretButtonXSecondValue= 0;
                bool setShieldGeneratorButtonCurrentStructureTypeStateFirstValue = false;
                bool setShieldGeneratorButtonCurrentStructureTypeStateSecondValue = false;
                BuildButtonRuntime.StructureType ShieldGeneratorButtonCurrentStructureTypeStateFirstValue= BuildButtonRuntime.StructureType.Energy;
                BuildButtonRuntime.StructureType ShieldGeneratorButtonCurrentStructureTypeStateSecondValue= BuildButtonRuntime.StructureType.Energy;
                bool setShieldGeneratorButtonXFirstValue = false;
                bool setShieldGeneratorButtonXSecondValue = false;
                float ShieldGeneratorButtonXFirstValue= 0;
                float ShieldGeneratorButtonXSecondValue= 0;
                bool setSolarButtonCurrentStructureTypeStateFirstValue = false;
                bool setSolarButtonCurrentStructureTypeStateSecondValue = false;
                BuildButtonRuntime.StructureType SolarButtonCurrentStructureTypeStateFirstValue= BuildButtonRuntime.StructureType.Energy;
                BuildButtonRuntime.StructureType SolarButtonCurrentStructureTypeStateSecondValue= BuildButtonRuntime.StructureType.Energy;
                bool setSolarButtonXFirstValue = false;
                bool setSolarButtonXSecondValue = false;
                float SolarButtonXFirstValue= 0;
                float SolarButtonXSecondValue= 0;
                bool setTallLaserButtonCurrentStructureTypeStateFirstValue = false;
                bool setTallLaserButtonCurrentStructureTypeStateSecondValue = false;
                BuildButtonRuntime.StructureType TallLaserButtonCurrentStructureTypeStateFirstValue= BuildButtonRuntime.StructureType.Energy;
                BuildButtonRuntime.StructureType TallLaserButtonCurrentStructureTypeStateSecondValue= BuildButtonRuntime.StructureType.Energy;
                bool setTallLaserButtonXFirstValue = false;
                bool setTallLaserButtonXSecondValue = false;
                float TallLaserButtonXFirstValue= 0;
                float TallLaserButtonXSecondValue= 0;
                bool setUtilityButtonsHeightFirstValue = false;
                bool setUtilityButtonsHeightSecondValue = false;
                float UtilityButtonsHeightFirstValue= 0;
                float UtilityButtonsHeightSecondValue= 0;
                bool setUtilityButtonsWidthFirstValue = false;
                bool setUtilityButtonsWidthSecondValue = false;
                float UtilityButtonsWidthFirstValue= 0;
                float UtilityButtonsWidthSecondValue= 0;
                bool setUtilityButtonsXFirstValue = false;
                bool setUtilityButtonsXSecondValue = false;
                float UtilityButtonsXFirstValue= 0;
                float UtilityButtonsXSecondValue= 0;
                bool setUtilityButtonsYFirstValue = false;
                bool setUtilityButtonsYSecondValue = false;
                float UtilityButtonsYFirstValue= 0;
                float UtilityButtonsYSecondValue= 0;
                bool setUtilityStructureButtonCurrentCategoryStateFirstValue = false;
                bool setUtilityStructureButtonCurrentCategoryStateSecondValue = false;
                CategoryButtonRuntime.Category UtilityStructureButtonCurrentCategoryStateFirstValue= CategoryButtonRuntime.Category.Utility;
                CategoryButtonRuntime.Category UtilityStructureButtonCurrentCategoryStateSecondValue= CategoryButtonRuntime.Category.Utility;
                bool setUtilityStructureButtonHeightFirstValue = false;
                bool setUtilityStructureButtonHeightSecondValue = false;
                float UtilityStructureButtonHeightFirstValue= 0;
                float UtilityStructureButtonHeightSecondValue= 0;
                bool setUtilityStructureButtonWidthFirstValue = false;
                bool setUtilityStructureButtonWidthSecondValue = false;
                float UtilityStructureButtonWidthFirstValue= 0;
                float UtilityStructureButtonWidthSecondValue= 0;
                bool setUtilityStructureButtonXFirstValue = false;
                bool setUtilityStructureButtonXSecondValue = false;
                float UtilityStructureButtonXFirstValue= 0;
                float UtilityStructureButtonXSecondValue= 0;
                bool setUtilityStructureButtonYFirstValue = false;
                bool setUtilityStructureButtonYSecondValue = false;
                float UtilityStructureButtonYFirstValue= 0;
                float UtilityStructureButtonYSecondValue= 0;
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                bool setWindButtonCurrentEnabledStatusStateFirstValue = false;
                bool setWindButtonCurrentEnabledStatusStateSecondValue = false;
                BuildButtonRuntime.EnabledStatus WindButtonCurrentEnabledStatusStateFirstValue= BuildButtonRuntime.EnabledStatus.Enabled;
                BuildButtonRuntime.EnabledStatus WindButtonCurrentEnabledStatusStateSecondValue= BuildButtonRuntime.EnabledStatus.Enabled;
                bool setWindButtonCurrentStructureTypeStateFirstValue = false;
                bool setWindButtonCurrentStructureTypeStateSecondValue = false;
                BuildButtonRuntime.StructureType WindButtonCurrentStructureTypeStateFirstValue= BuildButtonRuntime.StructureType.Energy;
                BuildButtonRuntime.StructureType WindButtonCurrentStructureTypeStateSecondValue= BuildButtonRuntime.StructureType.Energy;
                bool setWindButtonXFirstValue = false;
                bool setWindButtonXSecondValue = false;
                float WindButtonXFirstValue= 0;
                float WindButtonXSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        if (interpolationValue < 1)
                        {
                            this.BatteryButton.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "UtilityButtons");
                        }
                        setBatteryButtonCurrentStructureTypeStateFirstValue = true;
                        BatteryButtonCurrentStructureTypeStateFirstValue = AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime.StructureType.Utility;
                        setBatteryButtonXFirstValue = true;
                        BatteryButtonXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.BatteryButton.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CannonButton.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "CombatButtons");
                        }
                        setCannonButtonCurrentStructureTypeStateFirstValue = true;
                        CannonButtonCurrentStructureTypeStateFirstValue = AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime.StructureType.Combat;
                        setCannonButtonXFirstValue = true;
                        CannonButtonXFirstValue = 1f;
                        if (interpolationValue < 1)
                        {
                            this.CannonButton.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CarbonTreeButton.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "UtilityButtons");
                        }
                        setCarbonTreeButtonCurrentStructureTypeStateFirstValue = true;
                        CarbonTreeButtonCurrentStructureTypeStateFirstValue = AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime.StructureType.Utility;
                        setCarbonTreeButtonWidthFirstValue = true;
                        CarbonTreeButtonWidthFirstValue = 100f;
                        setCarbonTreeButtonXFirstValue = true;
                        CarbonTreeButtonXFirstValue = 3f;
                        if (interpolationValue < 1)
                        {
                            this.CarbonTreeButton.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ChildrenLayout = Gum.Managers.ChildrenLayout.Regular;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ClipsChildren = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CombatButtons.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setCombatButtonsHeightFirstValue = true;
                        CombatButtonsHeightFirstValue = 30f;
                        if (interpolationValue < 1)
                        {
                            this.CombatButtons.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CombatButtons.Visible = true;
                        }
                        setCombatButtonsWidthFirstValue = true;
                        CombatButtonsWidthFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.CombatButtons.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CombatButtons.WrapsChildren = true;
                        }
                        setCombatButtonsXFirstValue = true;
                        CombatButtonsXFirstValue = 1690f;
                        setCombatButtonsYFirstValue = true;
                        CombatButtonsYFirstValue = 303f;
                        setCombatStructureButtonCurrentCategoryStateFirstValue = true;
                        CombatStructureButtonCurrentCategoryStateFirstValue = AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime.Category.Combat;
                        setCombatStructureButtonHeightFirstValue = true;
                        CombatStructureButtonHeightFirstValue = 40f;
                        setCombatStructureButtonWidthFirstValue = true;
                        CombatStructureButtonWidthFirstValue = 10f;
                        setCombatStructureButtonXFirstValue = true;
                        CombatStructureButtonXFirstValue = 87.83141f;
                        if (interpolationValue < 1)
                        {
                            this.CombatStructureButton.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setCombatStructureButtonYFirstValue = true;
                        CombatStructureButtonYFirstValue = 53.04403f;
                        if (interpolationValue < 1)
                        {
                            this.CombatStructureButton.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.EnergyButtons.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setEnergyButtonsHeightFirstValue = true;
                        EnergyButtonsHeightFirstValue = 30f;
                        if (interpolationValue < 1)
                        {
                            this.EnergyButtons.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setEnergyButtonsWidthFirstValue = true;
                        EnergyButtonsWidthFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.EnergyButtons.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.EnergyButtons.WrapsChildren = true;
                        }
                        setEnergyButtonsXFirstValue = true;
                        EnergyButtonsXFirstValue = 13.16335f;
                        if (interpolationValue < 1)
                        {
                            this.EnergyButtons.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setEnergyButtonsYFirstValue = true;
                        EnergyButtonsYFirstValue = 51.3889f;
                        if (interpolationValue < 1)
                        {
                            this.EnergyButtons.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setEnergyStructureButtonCurrentCategoryStateFirstValue = true;
                        EnergyStructureButtonCurrentCategoryStateFirstValue = AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime.Category.Energy;
                        setEnergyStructureButtonHeightFirstValue = true;
                        EnergyStructureButtonHeightFirstValue = 40f;
                        setEnergyStructureButtonWidthFirstValue = true;
                        EnergyStructureButtonWidthFirstValue = 10f;
                        setEnergyStructureButtonXFirstValue = true;
                        EnergyStructureButtonXFirstValue = 2.843276f;
                        if (interpolationValue < 1)
                        {
                            this.EnergyStructureButton.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setEnergyStructureButtonYFirstValue = true;
                        EnergyStructureButtonYFirstValue = 50.63406f;
                        if (interpolationValue < 1)
                        {
                            this.EnergyStructureButton.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setHeightFirstValue = true;
                        HeightFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.HydroButton.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "EnergyButtons");
                        }
                        setHydroButtonCurrentStructureTypeStateFirstValue = true;
                        HydroButtonCurrentStructureTypeStateFirstValue = AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime.StructureType.Energy;
                        setHydroButtonXFirstValue = true;
                        HydroButtonXFirstValue = 3f;
                        if (interpolationValue < 1)
                        {
                            this.HydroButton.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.LaserTurretButton.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "CombatButtons");
                        }
                        setLaserTurretButtonCurrentStructureTypeStateFirstValue = true;
                        LaserTurretButtonCurrentStructureTypeStateFirstValue = AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime.StructureType.Combat;
                        setLaserTurretButtonXFirstValue = true;
                        LaserTurretButtonXFirstValue = 1f;
                        if (interpolationValue < 1)
                        {
                            this.LaserTurretButton.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ShieldGeneratorButton.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "UtilityButtons");
                        }
                        setShieldGeneratorButtonCurrentStructureTypeStateFirstValue = true;
                        ShieldGeneratorButtonCurrentStructureTypeStateFirstValue = AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime.StructureType.Utility;
                        setShieldGeneratorButtonXFirstValue = true;
                        ShieldGeneratorButtonXFirstValue = 3f;
                        if (interpolationValue < 1)
                        {
                            this.ShieldGeneratorButton.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SolarButton.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "EnergyButtons");
                        }
                        setSolarButtonCurrentStructureTypeStateFirstValue = true;
                        SolarButtonCurrentStructureTypeStateFirstValue = AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime.StructureType.Energy;
                        setSolarButtonXFirstValue = true;
                        SolarButtonXFirstValue = 3f;
                        if (interpolationValue < 1)
                        {
                            this.SolarButton.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TallLaserButton.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "CombatButtons");
                        }
                        setTallLaserButtonCurrentStructureTypeStateFirstValue = true;
                        TallLaserButtonCurrentStructureTypeStateFirstValue = AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime.StructureType.Combat;
                        setTallLaserButtonXFirstValue = true;
                        TallLaserButtonXFirstValue = 1f;
                        if (interpolationValue < 1)
                        {
                            this.TallLaserButton.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.UtilityButtons.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setUtilityButtonsHeightFirstValue = true;
                        UtilityButtonsHeightFirstValue = 30f;
                        if (interpolationValue < 1)
                        {
                            this.UtilityButtons.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.UtilityButtons.Visible = true;
                        }
                        setUtilityButtonsWidthFirstValue = true;
                        UtilityButtonsWidthFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.UtilityButtons.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.UtilityButtons.WrapsChildren = true;
                        }
                        setUtilityButtonsXFirstValue = true;
                        UtilityButtonsXFirstValue = 8.923834f;
                        if (interpolationValue < 1)
                        {
                            this.UtilityButtons.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setUtilityButtonsYFirstValue = true;
                        UtilityButtonsYFirstValue = 10.26004f;
                        if (interpolationValue < 1)
                        {
                            this.UtilityButtons.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setUtilityStructureButtonCurrentCategoryStateFirstValue = true;
                        UtilityStructureButtonCurrentCategoryStateFirstValue = AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime.Category.Utility;
                        setUtilityStructureButtonHeightFirstValue = true;
                        UtilityStructureButtonHeightFirstValue = 35f;
                        setUtilityStructureButtonWidthFirstValue = true;
                        UtilityStructureButtonWidthFirstValue = 8.607957f;
                        setUtilityStructureButtonXFirstValue = true;
                        UtilityStructureButtonXFirstValue = 0.2367424f;
                        if (interpolationValue < 1)
                        {
                            this.UtilityStructureButton.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setUtilityStructureButtonYFirstValue = true;
                        UtilityStructureButtonYFirstValue = 10.52189f;
                        if (interpolationValue < 1)
                        {
                            this.UtilityStructureButton.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Visible = true;
                        }
                        setWidthFirstValue = true;
                        WidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setWindButtonCurrentEnabledStatusStateFirstValue = true;
                        WindButtonCurrentEnabledStatusStateFirstValue = AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime.EnabledStatus.Enabled;
                        if (interpolationValue < 1)
                        {
                            this.WindButton.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "EnergyButtons");
                        }
                        setWindButtonCurrentStructureTypeStateFirstValue = true;
                        WindButtonCurrentStructureTypeStateFirstValue = AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime.StructureType.Energy;
                        setWindButtonXFirstValue = true;
                        WindButtonXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.WindButton.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.WrapsChildren = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        if (interpolationValue < 1)
                        {
                            this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue < 1)
                        {
                            this.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        if (interpolationValue >= 1)
                        {
                            this.BatteryButton.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "UtilityButtons");
                        }
                        setBatteryButtonCurrentStructureTypeStateSecondValue = true;
                        BatteryButtonCurrentStructureTypeStateSecondValue = AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime.StructureType.Utility;
                        setBatteryButtonXSecondValue = true;
                        BatteryButtonXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.BatteryButton.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CannonButton.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "CombatButtons");
                        }
                        setCannonButtonCurrentStructureTypeStateSecondValue = true;
                        CannonButtonCurrentStructureTypeStateSecondValue = AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime.StructureType.Combat;
                        setCannonButtonXSecondValue = true;
                        CannonButtonXSecondValue = 1f;
                        if (interpolationValue >= 1)
                        {
                            this.CannonButton.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CarbonTreeButton.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "UtilityButtons");
                        }
                        setCarbonTreeButtonCurrentStructureTypeStateSecondValue = true;
                        CarbonTreeButtonCurrentStructureTypeStateSecondValue = AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime.StructureType.Utility;
                        setCarbonTreeButtonWidthSecondValue = true;
                        CarbonTreeButtonWidthSecondValue = 100f;
                        setCarbonTreeButtonXSecondValue = true;
                        CarbonTreeButtonXSecondValue = 3f;
                        if (interpolationValue >= 1)
                        {
                            this.CarbonTreeButton.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ChildrenLayout = Gum.Managers.ChildrenLayout.Regular;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ClipsChildren = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CombatButtons.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setCombatButtonsHeightSecondValue = true;
                        CombatButtonsHeightSecondValue = 30f;
                        if (interpolationValue >= 1)
                        {
                            this.CombatButtons.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CombatButtons.Visible = true;
                        }
                        setCombatButtonsWidthSecondValue = true;
                        CombatButtonsWidthSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.CombatButtons.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CombatButtons.WrapsChildren = true;
                        }
                        setCombatButtonsXSecondValue = true;
                        CombatButtonsXSecondValue = 1690f;
                        setCombatButtonsYSecondValue = true;
                        CombatButtonsYSecondValue = 303f;
                        setCombatStructureButtonCurrentCategoryStateSecondValue = true;
                        CombatStructureButtonCurrentCategoryStateSecondValue = AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime.Category.Combat;
                        setCombatStructureButtonHeightSecondValue = true;
                        CombatStructureButtonHeightSecondValue = 40f;
                        setCombatStructureButtonWidthSecondValue = true;
                        CombatStructureButtonWidthSecondValue = 10f;
                        setCombatStructureButtonXSecondValue = true;
                        CombatStructureButtonXSecondValue = 87.83141f;
                        if (interpolationValue >= 1)
                        {
                            this.CombatStructureButton.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setCombatStructureButtonYSecondValue = true;
                        CombatStructureButtonYSecondValue = 53.04403f;
                        if (interpolationValue >= 1)
                        {
                            this.CombatStructureButton.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.EnergyButtons.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setEnergyButtonsHeightSecondValue = true;
                        EnergyButtonsHeightSecondValue = 30f;
                        if (interpolationValue >= 1)
                        {
                            this.EnergyButtons.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setEnergyButtonsWidthSecondValue = true;
                        EnergyButtonsWidthSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.EnergyButtons.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.EnergyButtons.WrapsChildren = true;
                        }
                        setEnergyButtonsXSecondValue = true;
                        EnergyButtonsXSecondValue = 13.16335f;
                        if (interpolationValue >= 1)
                        {
                            this.EnergyButtons.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setEnergyButtonsYSecondValue = true;
                        EnergyButtonsYSecondValue = 51.3889f;
                        if (interpolationValue >= 1)
                        {
                            this.EnergyButtons.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setEnergyStructureButtonCurrentCategoryStateSecondValue = true;
                        EnergyStructureButtonCurrentCategoryStateSecondValue = AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime.Category.Energy;
                        setEnergyStructureButtonHeightSecondValue = true;
                        EnergyStructureButtonHeightSecondValue = 40f;
                        setEnergyStructureButtonWidthSecondValue = true;
                        EnergyStructureButtonWidthSecondValue = 10f;
                        setEnergyStructureButtonXSecondValue = true;
                        EnergyStructureButtonXSecondValue = 2.843276f;
                        if (interpolationValue >= 1)
                        {
                            this.EnergyStructureButton.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setEnergyStructureButtonYSecondValue = true;
                        EnergyStructureButtonYSecondValue = 50.63406f;
                        if (interpolationValue >= 1)
                        {
                            this.EnergyStructureButton.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setHeightSecondValue = true;
                        HeightSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HydroButton.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "EnergyButtons");
                        }
                        setHydroButtonCurrentStructureTypeStateSecondValue = true;
                        HydroButtonCurrentStructureTypeStateSecondValue = AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime.StructureType.Energy;
                        setHydroButtonXSecondValue = true;
                        HydroButtonXSecondValue = 3f;
                        if (interpolationValue >= 1)
                        {
                            this.HydroButton.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.LaserTurretButton.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "CombatButtons");
                        }
                        setLaserTurretButtonCurrentStructureTypeStateSecondValue = true;
                        LaserTurretButtonCurrentStructureTypeStateSecondValue = AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime.StructureType.Combat;
                        setLaserTurretButtonXSecondValue = true;
                        LaserTurretButtonXSecondValue = 1f;
                        if (interpolationValue >= 1)
                        {
                            this.LaserTurretButton.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ShieldGeneratorButton.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "UtilityButtons");
                        }
                        setShieldGeneratorButtonCurrentStructureTypeStateSecondValue = true;
                        ShieldGeneratorButtonCurrentStructureTypeStateSecondValue = AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime.StructureType.Utility;
                        setShieldGeneratorButtonXSecondValue = true;
                        ShieldGeneratorButtonXSecondValue = 3f;
                        if (interpolationValue >= 1)
                        {
                            this.ShieldGeneratorButton.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SolarButton.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "EnergyButtons");
                        }
                        setSolarButtonCurrentStructureTypeStateSecondValue = true;
                        SolarButtonCurrentStructureTypeStateSecondValue = AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime.StructureType.Energy;
                        setSolarButtonXSecondValue = true;
                        SolarButtonXSecondValue = 3f;
                        if (interpolationValue >= 1)
                        {
                            this.SolarButton.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TallLaserButton.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "CombatButtons");
                        }
                        setTallLaserButtonCurrentStructureTypeStateSecondValue = true;
                        TallLaserButtonCurrentStructureTypeStateSecondValue = AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime.StructureType.Combat;
                        setTallLaserButtonXSecondValue = true;
                        TallLaserButtonXSecondValue = 1f;
                        if (interpolationValue >= 1)
                        {
                            this.TallLaserButton.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.UtilityButtons.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setUtilityButtonsHeightSecondValue = true;
                        UtilityButtonsHeightSecondValue = 30f;
                        if (interpolationValue >= 1)
                        {
                            this.UtilityButtons.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.UtilityButtons.Visible = true;
                        }
                        setUtilityButtonsWidthSecondValue = true;
                        UtilityButtonsWidthSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.UtilityButtons.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.UtilityButtons.WrapsChildren = true;
                        }
                        setUtilityButtonsXSecondValue = true;
                        UtilityButtonsXSecondValue = 8.923834f;
                        if (interpolationValue >= 1)
                        {
                            this.UtilityButtons.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setUtilityButtonsYSecondValue = true;
                        UtilityButtonsYSecondValue = 10.26004f;
                        if (interpolationValue >= 1)
                        {
                            this.UtilityButtons.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setUtilityStructureButtonCurrentCategoryStateSecondValue = true;
                        UtilityStructureButtonCurrentCategoryStateSecondValue = AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime.Category.Utility;
                        setUtilityStructureButtonHeightSecondValue = true;
                        UtilityStructureButtonHeightSecondValue = 35f;
                        setUtilityStructureButtonWidthSecondValue = true;
                        UtilityStructureButtonWidthSecondValue = 8.607957f;
                        setUtilityStructureButtonXSecondValue = true;
                        UtilityStructureButtonXSecondValue = 0.2367424f;
                        if (interpolationValue >= 1)
                        {
                            this.UtilityStructureButton.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setUtilityStructureButtonYSecondValue = true;
                        UtilityStructureButtonYSecondValue = 10.52189f;
                        if (interpolationValue >= 1)
                        {
                            this.UtilityStructureButton.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Visible = true;
                        }
                        setWidthSecondValue = true;
                        WidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setWindButtonCurrentEnabledStatusStateSecondValue = true;
                        WindButtonCurrentEnabledStatusStateSecondValue = AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime.EnabledStatus.Enabled;
                        if (interpolationValue >= 1)
                        {
                            this.WindButton.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "EnergyButtons");
                        }
                        setWindButtonCurrentStructureTypeStateSecondValue = true;
                        WindButtonCurrentStructureTypeStateSecondValue = AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime.StructureType.Energy;
                        setWindButtonXSecondValue = true;
                        WindButtonXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.WindButton.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.WrapsChildren = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        break;
                }
                if (setBatteryButtonCurrentStructureTypeStateFirstValue && setBatteryButtonCurrentStructureTypeStateSecondValue)
                {
                    BatteryButton.InterpolateBetween(BatteryButtonCurrentStructureTypeStateFirstValue, BatteryButtonCurrentStructureTypeStateSecondValue, interpolationValue);
                }
                if (setBatteryButtonXFirstValue && setBatteryButtonXSecondValue)
                {
                    BatteryButton.X = BatteryButtonXFirstValue * (1 - interpolationValue) + BatteryButtonXSecondValue * interpolationValue;
                }
                if (setCannonButtonCurrentStructureTypeStateFirstValue && setCannonButtonCurrentStructureTypeStateSecondValue)
                {
                    CannonButton.InterpolateBetween(CannonButtonCurrentStructureTypeStateFirstValue, CannonButtonCurrentStructureTypeStateSecondValue, interpolationValue);
                }
                if (setCannonButtonXFirstValue && setCannonButtonXSecondValue)
                {
                    CannonButton.X = CannonButtonXFirstValue * (1 - interpolationValue) + CannonButtonXSecondValue * interpolationValue;
                }
                if (setCarbonTreeButtonCurrentStructureTypeStateFirstValue && setCarbonTreeButtonCurrentStructureTypeStateSecondValue)
                {
                    CarbonTreeButton.InterpolateBetween(CarbonTreeButtonCurrentStructureTypeStateFirstValue, CarbonTreeButtonCurrentStructureTypeStateSecondValue, interpolationValue);
                }
                if (setCarbonTreeButtonWidthFirstValue && setCarbonTreeButtonWidthSecondValue)
                {
                    CarbonTreeButton.Width = CarbonTreeButtonWidthFirstValue * (1 - interpolationValue) + CarbonTreeButtonWidthSecondValue * interpolationValue;
                }
                if (setCarbonTreeButtonXFirstValue && setCarbonTreeButtonXSecondValue)
                {
                    CarbonTreeButton.X = CarbonTreeButtonXFirstValue * (1 - interpolationValue) + CarbonTreeButtonXSecondValue * interpolationValue;
                }
                if (setCombatButtonsHeightFirstValue && setCombatButtonsHeightSecondValue)
                {
                    CombatButtons.Height = CombatButtonsHeightFirstValue * (1 - interpolationValue) + CombatButtonsHeightSecondValue * interpolationValue;
                }
                if (setCombatButtonsWidthFirstValue && setCombatButtonsWidthSecondValue)
                {
                    CombatButtons.Width = CombatButtonsWidthFirstValue * (1 - interpolationValue) + CombatButtonsWidthSecondValue * interpolationValue;
                }
                if (setCombatButtonsXFirstValue && setCombatButtonsXSecondValue)
                {
                    CombatButtons.X = CombatButtonsXFirstValue * (1 - interpolationValue) + CombatButtonsXSecondValue * interpolationValue;
                }
                if (setCombatButtonsYFirstValue && setCombatButtonsYSecondValue)
                {
                    CombatButtons.Y = CombatButtonsYFirstValue * (1 - interpolationValue) + CombatButtonsYSecondValue * interpolationValue;
                }
                if (setCombatStructureButtonCurrentCategoryStateFirstValue && setCombatStructureButtonCurrentCategoryStateSecondValue)
                {
                    CombatStructureButton.InterpolateBetween(CombatStructureButtonCurrentCategoryStateFirstValue, CombatStructureButtonCurrentCategoryStateSecondValue, interpolationValue);
                }
                if (setCombatStructureButtonHeightFirstValue && setCombatStructureButtonHeightSecondValue)
                {
                    CombatStructureButton.Height = CombatStructureButtonHeightFirstValue * (1 - interpolationValue) + CombatStructureButtonHeightSecondValue * interpolationValue;
                }
                if (setCombatStructureButtonWidthFirstValue && setCombatStructureButtonWidthSecondValue)
                {
                    CombatStructureButton.Width = CombatStructureButtonWidthFirstValue * (1 - interpolationValue) + CombatStructureButtonWidthSecondValue * interpolationValue;
                }
                if (setCombatStructureButtonXFirstValue && setCombatStructureButtonXSecondValue)
                {
                    CombatStructureButton.X = CombatStructureButtonXFirstValue * (1 - interpolationValue) + CombatStructureButtonXSecondValue * interpolationValue;
                }
                if (setCombatStructureButtonYFirstValue && setCombatStructureButtonYSecondValue)
                {
                    CombatStructureButton.Y = CombatStructureButtonYFirstValue * (1 - interpolationValue) + CombatStructureButtonYSecondValue * interpolationValue;
                }
                if (setEnergyButtonsHeightFirstValue && setEnergyButtonsHeightSecondValue)
                {
                    EnergyButtons.Height = EnergyButtonsHeightFirstValue * (1 - interpolationValue) + EnergyButtonsHeightSecondValue * interpolationValue;
                }
                if (setEnergyButtonsWidthFirstValue && setEnergyButtonsWidthSecondValue)
                {
                    EnergyButtons.Width = EnergyButtonsWidthFirstValue * (1 - interpolationValue) + EnergyButtonsWidthSecondValue * interpolationValue;
                }
                if (setEnergyButtonsXFirstValue && setEnergyButtonsXSecondValue)
                {
                    EnergyButtons.X = EnergyButtonsXFirstValue * (1 - interpolationValue) + EnergyButtonsXSecondValue * interpolationValue;
                }
                if (setEnergyButtonsYFirstValue && setEnergyButtonsYSecondValue)
                {
                    EnergyButtons.Y = EnergyButtonsYFirstValue * (1 - interpolationValue) + EnergyButtonsYSecondValue * interpolationValue;
                }
                if (setEnergyStructureButtonCurrentCategoryStateFirstValue && setEnergyStructureButtonCurrentCategoryStateSecondValue)
                {
                    EnergyStructureButton.InterpolateBetween(EnergyStructureButtonCurrentCategoryStateFirstValue, EnergyStructureButtonCurrentCategoryStateSecondValue, interpolationValue);
                }
                if (setEnergyStructureButtonHeightFirstValue && setEnergyStructureButtonHeightSecondValue)
                {
                    EnergyStructureButton.Height = EnergyStructureButtonHeightFirstValue * (1 - interpolationValue) + EnergyStructureButtonHeightSecondValue * interpolationValue;
                }
                if (setEnergyStructureButtonWidthFirstValue && setEnergyStructureButtonWidthSecondValue)
                {
                    EnergyStructureButton.Width = EnergyStructureButtonWidthFirstValue * (1 - interpolationValue) + EnergyStructureButtonWidthSecondValue * interpolationValue;
                }
                if (setEnergyStructureButtonXFirstValue && setEnergyStructureButtonXSecondValue)
                {
                    EnergyStructureButton.X = EnergyStructureButtonXFirstValue * (1 - interpolationValue) + EnergyStructureButtonXSecondValue * interpolationValue;
                }
                if (setEnergyStructureButtonYFirstValue && setEnergyStructureButtonYSecondValue)
                {
                    EnergyStructureButton.Y = EnergyStructureButtonYFirstValue * (1 - interpolationValue) + EnergyStructureButtonYSecondValue * interpolationValue;
                }
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
                }
                if (setHydroButtonCurrentStructureTypeStateFirstValue && setHydroButtonCurrentStructureTypeStateSecondValue)
                {
                    HydroButton.InterpolateBetween(HydroButtonCurrentStructureTypeStateFirstValue, HydroButtonCurrentStructureTypeStateSecondValue, interpolationValue);
                }
                if (setHydroButtonXFirstValue && setHydroButtonXSecondValue)
                {
                    HydroButton.X = HydroButtonXFirstValue * (1 - interpolationValue) + HydroButtonXSecondValue * interpolationValue;
                }
                if (setLaserTurretButtonCurrentStructureTypeStateFirstValue && setLaserTurretButtonCurrentStructureTypeStateSecondValue)
                {
                    LaserTurretButton.InterpolateBetween(LaserTurretButtonCurrentStructureTypeStateFirstValue, LaserTurretButtonCurrentStructureTypeStateSecondValue, interpolationValue);
                }
                if (setLaserTurretButtonXFirstValue && setLaserTurretButtonXSecondValue)
                {
                    LaserTurretButton.X = LaserTurretButtonXFirstValue * (1 - interpolationValue) + LaserTurretButtonXSecondValue * interpolationValue;
                }
                if (setShieldGeneratorButtonCurrentStructureTypeStateFirstValue && setShieldGeneratorButtonCurrentStructureTypeStateSecondValue)
                {
                    ShieldGeneratorButton.InterpolateBetween(ShieldGeneratorButtonCurrentStructureTypeStateFirstValue, ShieldGeneratorButtonCurrentStructureTypeStateSecondValue, interpolationValue);
                }
                if (setShieldGeneratorButtonXFirstValue && setShieldGeneratorButtonXSecondValue)
                {
                    ShieldGeneratorButton.X = ShieldGeneratorButtonXFirstValue * (1 - interpolationValue) + ShieldGeneratorButtonXSecondValue * interpolationValue;
                }
                if (setSolarButtonCurrentStructureTypeStateFirstValue && setSolarButtonCurrentStructureTypeStateSecondValue)
                {
                    SolarButton.InterpolateBetween(SolarButtonCurrentStructureTypeStateFirstValue, SolarButtonCurrentStructureTypeStateSecondValue, interpolationValue);
                }
                if (setSolarButtonXFirstValue && setSolarButtonXSecondValue)
                {
                    SolarButton.X = SolarButtonXFirstValue * (1 - interpolationValue) + SolarButtonXSecondValue * interpolationValue;
                }
                if (setTallLaserButtonCurrentStructureTypeStateFirstValue && setTallLaserButtonCurrentStructureTypeStateSecondValue)
                {
                    TallLaserButton.InterpolateBetween(TallLaserButtonCurrentStructureTypeStateFirstValue, TallLaserButtonCurrentStructureTypeStateSecondValue, interpolationValue);
                }
                if (setTallLaserButtonXFirstValue && setTallLaserButtonXSecondValue)
                {
                    TallLaserButton.X = TallLaserButtonXFirstValue * (1 - interpolationValue) + TallLaserButtonXSecondValue * interpolationValue;
                }
                if (setUtilityButtonsHeightFirstValue && setUtilityButtonsHeightSecondValue)
                {
                    UtilityButtons.Height = UtilityButtonsHeightFirstValue * (1 - interpolationValue) + UtilityButtonsHeightSecondValue * interpolationValue;
                }
                if (setUtilityButtonsWidthFirstValue && setUtilityButtonsWidthSecondValue)
                {
                    UtilityButtons.Width = UtilityButtonsWidthFirstValue * (1 - interpolationValue) + UtilityButtonsWidthSecondValue * interpolationValue;
                }
                if (setUtilityButtonsXFirstValue && setUtilityButtonsXSecondValue)
                {
                    UtilityButtons.X = UtilityButtonsXFirstValue * (1 - interpolationValue) + UtilityButtonsXSecondValue * interpolationValue;
                }
                if (setUtilityButtonsYFirstValue && setUtilityButtonsYSecondValue)
                {
                    UtilityButtons.Y = UtilityButtonsYFirstValue * (1 - interpolationValue) + UtilityButtonsYSecondValue * interpolationValue;
                }
                if (setUtilityStructureButtonCurrentCategoryStateFirstValue && setUtilityStructureButtonCurrentCategoryStateSecondValue)
                {
                    UtilityStructureButton.InterpolateBetween(UtilityStructureButtonCurrentCategoryStateFirstValue, UtilityStructureButtonCurrentCategoryStateSecondValue, interpolationValue);
                }
                if (setUtilityStructureButtonHeightFirstValue && setUtilityStructureButtonHeightSecondValue)
                {
                    UtilityStructureButton.Height = UtilityStructureButtonHeightFirstValue * (1 - interpolationValue) + UtilityStructureButtonHeightSecondValue * interpolationValue;
                }
                if (setUtilityStructureButtonWidthFirstValue && setUtilityStructureButtonWidthSecondValue)
                {
                    UtilityStructureButton.Width = UtilityStructureButtonWidthFirstValue * (1 - interpolationValue) + UtilityStructureButtonWidthSecondValue * interpolationValue;
                }
                if (setUtilityStructureButtonXFirstValue && setUtilityStructureButtonXSecondValue)
                {
                    UtilityStructureButton.X = UtilityStructureButtonXFirstValue * (1 - interpolationValue) + UtilityStructureButtonXSecondValue * interpolationValue;
                }
                if (setUtilityStructureButtonYFirstValue && setUtilityStructureButtonYSecondValue)
                {
                    UtilityStructureButton.Y = UtilityStructureButtonYFirstValue * (1 - interpolationValue) + UtilityStructureButtonYSecondValue * interpolationValue;
                }
                if (setWidthFirstValue && setWidthSecondValue)
                {
                    Width = WidthFirstValue * (1 - interpolationValue) + WidthSecondValue * interpolationValue;
                }
                if (setWindButtonCurrentEnabledStatusStateFirstValue && setWindButtonCurrentEnabledStatusStateSecondValue)
                {
                    WindButton.InterpolateBetween(WindButtonCurrentEnabledStatusStateFirstValue, WindButtonCurrentEnabledStatusStateSecondValue, interpolationValue);
                }
                if (setWindButtonCurrentStructureTypeStateFirstValue && setWindButtonCurrentStructureTypeStateSecondValue)
                {
                    WindButton.InterpolateBetween(WindButtonCurrentStructureTypeStateFirstValue, WindButtonCurrentStructureTypeStateSecondValue, interpolationValue);
                }
                if (setWindButtonXFirstValue && setWindButtonXSecondValue)
                {
                    WindButton.X = WindButtonXFirstValue * (1 - interpolationValue) + WindButtonXSecondValue * interpolationValue;
                }
                if (interpolationValue < 1)
                {
                    mCurrentVariableState = firstState;
                }
                else
                {
                    mCurrentVariableState = secondState;
                }
            }
            public void InterpolateBetween (BuildMenu firstState, BuildMenu secondState, float interpolationValue)
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setCombatStructureButtonCurrentHighlightedStateFirstValue = false;
                bool setCombatStructureButtonCurrentHighlightedStateSecondValue = false;
                CategoryButtonRuntime.Highlighted CombatStructureButtonCurrentHighlightedStateFirstValue= CategoryButtonRuntime.Highlighted.True;
                CategoryButtonRuntime.Highlighted CombatStructureButtonCurrentHighlightedStateSecondValue= CategoryButtonRuntime.Highlighted.True;
                bool setEnergyStructureButtonCurrentHighlightedStateFirstValue = false;
                bool setEnergyStructureButtonCurrentHighlightedStateSecondValue = false;
                CategoryButtonRuntime.Highlighted EnergyStructureButtonCurrentHighlightedStateFirstValue= CategoryButtonRuntime.Highlighted.True;
                CategoryButtonRuntime.Highlighted EnergyStructureButtonCurrentHighlightedStateSecondValue= CategoryButtonRuntime.Highlighted.True;
                bool setUtilityStructureButtonCurrentHighlightedStateFirstValue = false;
                bool setUtilityStructureButtonCurrentHighlightedStateSecondValue = false;
                CategoryButtonRuntime.Highlighted UtilityStructureButtonCurrentHighlightedStateFirstValue= CategoryButtonRuntime.Highlighted.True;
                CategoryButtonRuntime.Highlighted UtilityStructureButtonCurrentHighlightedStateSecondValue= CategoryButtonRuntime.Highlighted.True;
                switch(firstState)
                {
                    case  BuildMenu.BuildEnergy:
                        if (interpolationValue < 1)
                        {
                            this.CombatButtons.Visible = false;
                        }
                        setCombatStructureButtonCurrentHighlightedStateFirstValue = true;
                        CombatStructureButtonCurrentHighlightedStateFirstValue = AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime.Highlighted.False;
                        if (interpolationValue < 1)
                        {
                            this.EnergyButtons.Visible = true;
                        }
                        setEnergyStructureButtonCurrentHighlightedStateFirstValue = true;
                        EnergyStructureButtonCurrentHighlightedStateFirstValue = AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime.Highlighted.True;
                        if (interpolationValue < 1)
                        {
                            this.EnergyStructureButton.Visible = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.UtilityButtons.Visible = false;
                        }
                        setUtilityStructureButtonCurrentHighlightedStateFirstValue = true;
                        UtilityStructureButtonCurrentHighlightedStateFirstValue = AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime.Highlighted.False;
                        break;
                    case  BuildMenu.BuildCombat:
                        if (interpolationValue < 1)
                        {
                            this.CombatButtons.Visible = true;
                        }
                        setCombatStructureButtonCurrentHighlightedStateFirstValue = true;
                        CombatStructureButtonCurrentHighlightedStateFirstValue = AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime.Highlighted.True;
                        if (interpolationValue < 1)
                        {
                            this.EnergyButtons.Visible = false;
                        }
                        setEnergyStructureButtonCurrentHighlightedStateFirstValue = true;
                        EnergyStructureButtonCurrentHighlightedStateFirstValue = AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime.Highlighted.False;
                        if (interpolationValue < 1)
                        {
                            this.EnergyStructureButton.Visible = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.UtilityButtons.Visible = false;
                        }
                        setUtilityStructureButtonCurrentHighlightedStateFirstValue = true;
                        UtilityStructureButtonCurrentHighlightedStateFirstValue = AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime.Highlighted.False;
                        break;
                    case  BuildMenu.BuildUtility:
                        if (interpolationValue < 1)
                        {
                            this.CombatButtons.Visible = false;
                        }
                        setCombatStructureButtonCurrentHighlightedStateFirstValue = true;
                        CombatStructureButtonCurrentHighlightedStateFirstValue = AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime.Highlighted.False;
                        if (interpolationValue < 1)
                        {
                            this.EnergyButtons.Visible = false;
                        }
                        setEnergyStructureButtonCurrentHighlightedStateFirstValue = true;
                        EnergyStructureButtonCurrentHighlightedStateFirstValue = AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime.Highlighted.False;
                        if (interpolationValue < 1)
                        {
                            this.EnergyStructureButton.Visible = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.UtilityButtons.Visible = true;
                        }
                        setUtilityStructureButtonCurrentHighlightedStateFirstValue = true;
                        UtilityStructureButtonCurrentHighlightedStateFirstValue = AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime.Highlighted.True;
                        break;
                    case  BuildMenu.None:
                        if (interpolationValue < 1)
                        {
                            this.CombatButtons.Visible = false;
                        }
                        setCombatStructureButtonCurrentHighlightedStateFirstValue = true;
                        CombatStructureButtonCurrentHighlightedStateFirstValue = AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime.Highlighted.False;
                        if (interpolationValue < 1)
                        {
                            this.EnergyButtons.Visible = false;
                        }
                        setEnergyStructureButtonCurrentHighlightedStateFirstValue = true;
                        EnergyStructureButtonCurrentHighlightedStateFirstValue = AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime.Highlighted.False;
                        if (interpolationValue < 1)
                        {
                            this.EnergyStructureButton.Visible = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.UtilityButtons.Visible = false;
                        }
                        setUtilityStructureButtonCurrentHighlightedStateFirstValue = true;
                        UtilityStructureButtonCurrentHighlightedStateFirstValue = AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime.Highlighted.False;
                        break;
                }
                switch(secondState)
                {
                    case  BuildMenu.BuildEnergy:
                        if (interpolationValue >= 1)
                        {
                            this.CombatButtons.Visible = false;
                        }
                        setCombatStructureButtonCurrentHighlightedStateSecondValue = true;
                        CombatStructureButtonCurrentHighlightedStateSecondValue = AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime.Highlighted.False;
                        if (interpolationValue >= 1)
                        {
                            this.EnergyButtons.Visible = true;
                        }
                        setEnergyStructureButtonCurrentHighlightedStateSecondValue = true;
                        EnergyStructureButtonCurrentHighlightedStateSecondValue = AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime.Highlighted.True;
                        if (interpolationValue >= 1)
                        {
                            this.EnergyStructureButton.Visible = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.UtilityButtons.Visible = false;
                        }
                        setUtilityStructureButtonCurrentHighlightedStateSecondValue = true;
                        UtilityStructureButtonCurrentHighlightedStateSecondValue = AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime.Highlighted.False;
                        break;
                    case  BuildMenu.BuildCombat:
                        if (interpolationValue >= 1)
                        {
                            this.CombatButtons.Visible = true;
                        }
                        setCombatStructureButtonCurrentHighlightedStateSecondValue = true;
                        CombatStructureButtonCurrentHighlightedStateSecondValue = AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime.Highlighted.True;
                        if (interpolationValue >= 1)
                        {
                            this.EnergyButtons.Visible = false;
                        }
                        setEnergyStructureButtonCurrentHighlightedStateSecondValue = true;
                        EnergyStructureButtonCurrentHighlightedStateSecondValue = AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime.Highlighted.False;
                        if (interpolationValue >= 1)
                        {
                            this.EnergyStructureButton.Visible = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.UtilityButtons.Visible = false;
                        }
                        setUtilityStructureButtonCurrentHighlightedStateSecondValue = true;
                        UtilityStructureButtonCurrentHighlightedStateSecondValue = AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime.Highlighted.False;
                        break;
                    case  BuildMenu.BuildUtility:
                        if (interpolationValue >= 1)
                        {
                            this.CombatButtons.Visible = false;
                        }
                        setCombatStructureButtonCurrentHighlightedStateSecondValue = true;
                        CombatStructureButtonCurrentHighlightedStateSecondValue = AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime.Highlighted.False;
                        if (interpolationValue >= 1)
                        {
                            this.EnergyButtons.Visible = false;
                        }
                        setEnergyStructureButtonCurrentHighlightedStateSecondValue = true;
                        EnergyStructureButtonCurrentHighlightedStateSecondValue = AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime.Highlighted.False;
                        if (interpolationValue >= 1)
                        {
                            this.EnergyStructureButton.Visible = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.UtilityButtons.Visible = true;
                        }
                        setUtilityStructureButtonCurrentHighlightedStateSecondValue = true;
                        UtilityStructureButtonCurrentHighlightedStateSecondValue = AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime.Highlighted.True;
                        break;
                    case  BuildMenu.None:
                        if (interpolationValue >= 1)
                        {
                            this.CombatButtons.Visible = false;
                        }
                        setCombatStructureButtonCurrentHighlightedStateSecondValue = true;
                        CombatStructureButtonCurrentHighlightedStateSecondValue = AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime.Highlighted.False;
                        if (interpolationValue >= 1)
                        {
                            this.EnergyButtons.Visible = false;
                        }
                        setEnergyStructureButtonCurrentHighlightedStateSecondValue = true;
                        EnergyStructureButtonCurrentHighlightedStateSecondValue = AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime.Highlighted.False;
                        if (interpolationValue >= 1)
                        {
                            this.EnergyStructureButton.Visible = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.UtilityButtons.Visible = false;
                        }
                        setUtilityStructureButtonCurrentHighlightedStateSecondValue = true;
                        UtilityStructureButtonCurrentHighlightedStateSecondValue = AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime.Highlighted.False;
                        break;
                }
                if (setCombatStructureButtonCurrentHighlightedStateFirstValue && setCombatStructureButtonCurrentHighlightedStateSecondValue)
                {
                    CombatStructureButton.InterpolateBetween(CombatStructureButtonCurrentHighlightedStateFirstValue, CombatStructureButtonCurrentHighlightedStateSecondValue, interpolationValue);
                }
                if (setEnergyStructureButtonCurrentHighlightedStateFirstValue && setEnergyStructureButtonCurrentHighlightedStateSecondValue)
                {
                    EnergyStructureButton.InterpolateBetween(EnergyStructureButtonCurrentHighlightedStateFirstValue, EnergyStructureButtonCurrentHighlightedStateSecondValue, interpolationValue);
                }
                if (setUtilityStructureButtonCurrentHighlightedStateFirstValue && setUtilityStructureButtonCurrentHighlightedStateSecondValue)
                {
                    UtilityStructureButton.InterpolateBetween(UtilityStructureButtonCurrentHighlightedStateFirstValue, UtilityStructureButtonCurrentHighlightedStateSecondValue, interpolationValue);
                }
                if (interpolationValue < 1)
                {
                    mCurrentBuildMenuState = firstState;
                }
                else
                {
                    mCurrentBuildMenuState = secondState;
                }
            }
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.BuildBarRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.BuildBarRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null)
            {
                FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from:0, to:1, duration:(float)secondsToTake, type:interpolationType, easing:easing );
                if (owner == null)
                {
                    tweener.Owner = this;
                }
                else
                {
                    tweener.Owner = owner;
                }
                tweener.PositionChanged = newPosition => this.InterpolateBetween(fromState, toState, newPosition);
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null )
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.States.First(item => item.Name == toState.ToString());
                FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: (float)secondsToTake, type: interpolationType, easing: easing);
                if (owner == null)
                {
                    tweener.Owner = this;
                }
                else
                {
                    tweener.Owner = owner;
                }
                tweener.PositionChanged = newPosition => this.InterpolateBetween(current, toAsStateSave, newPosition);
                tweener.Ended += ()=> this.CurrentVariableState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null )
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = AddToCurrentValuesWithState(toState);
                FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: (float)secondsToTake, type: interpolationType, easing: easing);
                if (owner == null)
                {
                    tweener.Owner = this;
                }
                else
                {
                    tweener.Owner = owner;
                }
                tweener.PositionChanged = newPosition => this.InterpolateBetween(current, toAsStateSave, newPosition);
                tweener.Ended += ()=> this.CurrentVariableState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.BuildBarRuntime.BuildMenu fromState,AbbatoirIntergrade.GumRuntimes.BuildBarRuntime.BuildMenu toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null)
            {
                FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from:0, to:1, duration:(float)secondsToTake, type:interpolationType, easing:easing );
                if (owner == null)
                {
                    tweener.Owner = this;
                }
                else
                {
                    tweener.Owner = owner;
                }
                tweener.PositionChanged = newPosition => this.InterpolateBetween(fromState, toState, newPosition);
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (BuildMenu toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null )
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "BuildMenu").States.First(item => item.Name == toState.ToString());
                FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: (float)secondsToTake, type: interpolationType, easing: easing);
                if (owner == null)
                {
                    tweener.Owner = this;
                }
                else
                {
                    tweener.Owner = owner;
                }
                tweener.PositionChanged = newPosition => this.InterpolateBetween(current, toAsStateSave, newPosition);
                tweener.Ended += ()=> this.CurrentBuildMenuState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (BuildMenu toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null )
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = AddToCurrentValuesWithState(toState);
                FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: (float)secondsToTake, type: interpolationType, easing: easing);
                if (owner == null)
                {
                    tweener.Owner = this;
                }
                else
                {
                    tweener.Owner = owner;
                }
                tweener.PositionChanged = newPosition => this.InterpolateBetween(current, toAsStateSave, newPosition);
                tweener.Ended += ()=> this.CurrentBuildMenuState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            #endregion
            #region State Animations
            #endregion
            public override void StopAnimations ()
            {
                base.StopAnimations();
                SolarButton.StopAnimations();
                WindButton.StopAnimations();
                HydroButton.StopAnimations();
                LaserTurretButton.StopAnimations();
                BatteryButton.StopAnimations();
                ShieldGeneratorButton.StopAnimations();
                CarbonTreeButton.StopAnimations();
                CannonButton.StopAnimations();
                TallLaserButton.StopAnimations();
                UtilityStructureButton.StopAnimations();
                CombatStructureButton.StopAnimations();
                EnergyStructureButton.StopAnimations();
            }
            #region Get Current Values on State
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (VariableState state)
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  VariableState.Default:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Children Layout",
                            Type = "ChildrenLayout",
                            Value = ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Clips Children",
                            Type = "bool",
                            Value = ClipsChildren
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Height",
                            Type = "float",
                            Value = Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Height Units",
                            Type = "DimensionUnitType",
                            Value = HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Visible",
                            Type = "bool",
                            Value = Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Width",
                            Type = "float",
                            Value = Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Width Units",
                            Type = "DimensionUnitType",
                            Value = WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Wraps Children",
                            Type = "bool",
                            Value = WrapsChildren
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "X Origin",
                            Type = "HorizontalAlignment",
                            Value = XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "X Units",
                            Type = "PositionUnitType",
                            Value = XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Y Origin",
                            Type = "VerticalAlignment",
                            Value = YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Y Units",
                            Type = "PositionUnitType",
                            Value = YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SolarButton.Parent",
                            Type = "string",
                            Value = SolarButton.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SolarButton.StructureTypeState",
                            Type = "StructureTypeState",
                            Value = SolarButton.CurrentStructureTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SolarButton.X",
                            Type = "float",
                            Value = SolarButton.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SolarButton.X Units",
                            Type = "PositionUnitType",
                            Value = SolarButton.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyButtons.Children Layout",
                            Type = "ChildrenLayout",
                            Value = EnergyButtons.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyButtons.Height",
                            Type = "float",
                            Value = EnergyButtons.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyButtons.Height Units",
                            Type = "DimensionUnitType",
                            Value = EnergyButtons.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyButtons.Width",
                            Type = "float",
                            Value = EnergyButtons.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyButtons.Width Units",
                            Type = "DimensionUnitType",
                            Value = EnergyButtons.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyButtons.Wraps Children",
                            Type = "bool",
                            Value = EnergyButtons.WrapsChildren
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyButtons.X",
                            Type = "float",
                            Value = EnergyButtons.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyButtons.X Units",
                            Type = "PositionUnitType",
                            Value = EnergyButtons.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyButtons.Y",
                            Type = "float",
                            Value = EnergyButtons.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyButtons.Y Units",
                            Type = "PositionUnitType",
                            Value = EnergyButtons.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CombatButtons.Children Layout",
                            Type = "ChildrenLayout",
                            Value = CombatButtons.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CombatButtons.Height",
                            Type = "float",
                            Value = CombatButtons.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CombatButtons.Height Units",
                            Type = "DimensionUnitType",
                            Value = CombatButtons.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CombatButtons.Visible",
                            Type = "bool",
                            Value = CombatButtons.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CombatButtons.Width",
                            Type = "float",
                            Value = CombatButtons.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CombatButtons.Width Units",
                            Type = "DimensionUnitType",
                            Value = CombatButtons.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CombatButtons.Wraps Children",
                            Type = "bool",
                            Value = CombatButtons.WrapsChildren
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CombatButtons.X",
                            Type = "float",
                            Value = CombatButtons.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CombatButtons.Y",
                            Type = "float",
                            Value = CombatButtons.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UtilityButtons.Children Layout",
                            Type = "ChildrenLayout",
                            Value = UtilityButtons.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UtilityButtons.Height",
                            Type = "float",
                            Value = UtilityButtons.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UtilityButtons.Height Units",
                            Type = "DimensionUnitType",
                            Value = UtilityButtons.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UtilityButtons.Visible",
                            Type = "bool",
                            Value = UtilityButtons.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UtilityButtons.Width",
                            Type = "float",
                            Value = UtilityButtons.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UtilityButtons.Width Units",
                            Type = "DimensionUnitType",
                            Value = UtilityButtons.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UtilityButtons.Wraps Children",
                            Type = "bool",
                            Value = UtilityButtons.WrapsChildren
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UtilityButtons.X",
                            Type = "float",
                            Value = UtilityButtons.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UtilityButtons.X Units",
                            Type = "PositionUnitType",
                            Value = UtilityButtons.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UtilityButtons.Y",
                            Type = "float",
                            Value = UtilityButtons.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UtilityButtons.Y Units",
                            Type = "PositionUnitType",
                            Value = UtilityButtons.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindButton.EnabledStatusState",
                            Type = "EnabledStatusState",
                            Value = WindButton.CurrentEnabledStatusState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindButton.Parent",
                            Type = "string",
                            Value = WindButton.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindButton.StructureTypeState",
                            Type = "StructureTypeState",
                            Value = WindButton.CurrentStructureTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindButton.X",
                            Type = "float",
                            Value = WindButton.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindButton.X Units",
                            Type = "PositionUnitType",
                            Value = WindButton.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HydroButton.Parent",
                            Type = "string",
                            Value = HydroButton.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HydroButton.StructureTypeState",
                            Type = "StructureTypeState",
                            Value = HydroButton.CurrentStructureTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HydroButton.X",
                            Type = "float",
                            Value = HydroButton.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HydroButton.X Units",
                            Type = "PositionUnitType",
                            Value = HydroButton.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LaserTurretButton.Parent",
                            Type = "string",
                            Value = LaserTurretButton.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LaserTurretButton.StructureTypeState",
                            Type = "StructureTypeState",
                            Value = LaserTurretButton.CurrentStructureTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LaserTurretButton.X",
                            Type = "float",
                            Value = LaserTurretButton.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LaserTurretButton.X Units",
                            Type = "PositionUnitType",
                            Value = LaserTurretButton.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BatteryButton.Parent",
                            Type = "string",
                            Value = BatteryButton.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BatteryButton.StructureTypeState",
                            Type = "StructureTypeState",
                            Value = BatteryButton.CurrentStructureTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BatteryButton.X",
                            Type = "float",
                            Value = BatteryButton.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BatteryButton.X Units",
                            Type = "PositionUnitType",
                            Value = BatteryButton.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ShieldGeneratorButton.Parent",
                            Type = "string",
                            Value = ShieldGeneratorButton.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ShieldGeneratorButton.StructureTypeState",
                            Type = "StructureTypeState",
                            Value = ShieldGeneratorButton.CurrentStructureTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ShieldGeneratorButton.X",
                            Type = "float",
                            Value = ShieldGeneratorButton.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ShieldGeneratorButton.X Units",
                            Type = "PositionUnitType",
                            Value = ShieldGeneratorButton.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CarbonTreeButton.Parent",
                            Type = "string",
                            Value = CarbonTreeButton.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CarbonTreeButton.StructureTypeState",
                            Type = "StructureTypeState",
                            Value = CarbonTreeButton.CurrentStructureTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CarbonTreeButton.Width",
                            Type = "float",
                            Value = CarbonTreeButton.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CarbonTreeButton.X",
                            Type = "float",
                            Value = CarbonTreeButton.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CarbonTreeButton.X Units",
                            Type = "PositionUnitType",
                            Value = CarbonTreeButton.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CannonButton.Parent",
                            Type = "string",
                            Value = CannonButton.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CannonButton.StructureTypeState",
                            Type = "StructureTypeState",
                            Value = CannonButton.CurrentStructureTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CannonButton.X",
                            Type = "float",
                            Value = CannonButton.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CannonButton.X Units",
                            Type = "PositionUnitType",
                            Value = CannonButton.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TallLaserButton.Parent",
                            Type = "string",
                            Value = TallLaserButton.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TallLaserButton.StructureTypeState",
                            Type = "StructureTypeState",
                            Value = TallLaserButton.CurrentStructureTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TallLaserButton.X",
                            Type = "float",
                            Value = TallLaserButton.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TallLaserButton.X Units",
                            Type = "PositionUnitType",
                            Value = TallLaserButton.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UtilityStructureButton.CategoryState",
                            Type = "CategoryState",
                            Value = UtilityStructureButton.CurrentCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UtilityStructureButton.Height",
                            Type = "float",
                            Value = UtilityStructureButton.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UtilityStructureButton.Width",
                            Type = "float",
                            Value = UtilityStructureButton.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UtilityStructureButton.X",
                            Type = "float",
                            Value = UtilityStructureButton.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UtilityStructureButton.X Units",
                            Type = "PositionUnitType",
                            Value = UtilityStructureButton.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UtilityStructureButton.Y",
                            Type = "float",
                            Value = UtilityStructureButton.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UtilityStructureButton.Y Units",
                            Type = "PositionUnitType",
                            Value = UtilityStructureButton.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CombatStructureButton.CategoryState",
                            Type = "CategoryState",
                            Value = CombatStructureButton.CurrentCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CombatStructureButton.Height",
                            Type = "float",
                            Value = CombatStructureButton.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CombatStructureButton.Width",
                            Type = "float",
                            Value = CombatStructureButton.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CombatStructureButton.X",
                            Type = "float",
                            Value = CombatStructureButton.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CombatStructureButton.X Units",
                            Type = "PositionUnitType",
                            Value = CombatStructureButton.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CombatStructureButton.Y",
                            Type = "float",
                            Value = CombatStructureButton.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CombatStructureButton.Y Units",
                            Type = "PositionUnitType",
                            Value = CombatStructureButton.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyStructureButton.CategoryState",
                            Type = "CategoryState",
                            Value = EnergyStructureButton.CurrentCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyStructureButton.Height",
                            Type = "float",
                            Value = EnergyStructureButton.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyStructureButton.Width",
                            Type = "float",
                            Value = EnergyStructureButton.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyStructureButton.X",
                            Type = "float",
                            Value = EnergyStructureButton.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyStructureButton.X Units",
                            Type = "PositionUnitType",
                            Value = EnergyStructureButton.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyStructureButton.Y",
                            Type = "float",
                            Value = EnergyStructureButton.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyStructureButton.Y Units",
                            Type = "PositionUnitType",
                            Value = EnergyStructureButton.YUnits
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (VariableState state)
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  VariableState.Default:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Children Layout",
                            Type = "ChildrenLayout",
                            Value = ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Clips Children",
                            Type = "bool",
                            Value = ClipsChildren
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Height",
                            Type = "float",
                            Value = Height + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Height Units",
                            Type = "DimensionUnitType",
                            Value = HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Visible",
                            Type = "bool",
                            Value = Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Width",
                            Type = "float",
                            Value = Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Width Units",
                            Type = "DimensionUnitType",
                            Value = WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Wraps Children",
                            Type = "bool",
                            Value = WrapsChildren
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "X Origin",
                            Type = "HorizontalAlignment",
                            Value = XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "X Units",
                            Type = "PositionUnitType",
                            Value = XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Y Origin",
                            Type = "VerticalAlignment",
                            Value = YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Y Units",
                            Type = "PositionUnitType",
                            Value = YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SolarButton.Parent",
                            Type = "string",
                            Value = SolarButton.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SolarButton.StructureTypeState",
                            Type = "StructureTypeState",
                            Value = SolarButton.CurrentStructureTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SolarButton.X",
                            Type = "float",
                            Value = SolarButton.X + 3f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SolarButton.X Units",
                            Type = "PositionUnitType",
                            Value = SolarButton.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyButtons.Children Layout",
                            Type = "ChildrenLayout",
                            Value = EnergyButtons.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyButtons.Height",
                            Type = "float",
                            Value = EnergyButtons.Height + 30f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyButtons.Height Units",
                            Type = "DimensionUnitType",
                            Value = EnergyButtons.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyButtons.Width",
                            Type = "float",
                            Value = EnergyButtons.Width + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyButtons.Width Units",
                            Type = "DimensionUnitType",
                            Value = EnergyButtons.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyButtons.Wraps Children",
                            Type = "bool",
                            Value = EnergyButtons.WrapsChildren
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyButtons.X",
                            Type = "float",
                            Value = EnergyButtons.X + 13.16335f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyButtons.X Units",
                            Type = "PositionUnitType",
                            Value = EnergyButtons.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyButtons.Y",
                            Type = "float",
                            Value = EnergyButtons.Y + 51.3889f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyButtons.Y Units",
                            Type = "PositionUnitType",
                            Value = EnergyButtons.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CombatButtons.Children Layout",
                            Type = "ChildrenLayout",
                            Value = CombatButtons.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CombatButtons.Height",
                            Type = "float",
                            Value = CombatButtons.Height + 30f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CombatButtons.Height Units",
                            Type = "DimensionUnitType",
                            Value = CombatButtons.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CombatButtons.Visible",
                            Type = "bool",
                            Value = CombatButtons.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CombatButtons.Width",
                            Type = "float",
                            Value = CombatButtons.Width + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CombatButtons.Width Units",
                            Type = "DimensionUnitType",
                            Value = CombatButtons.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CombatButtons.Wraps Children",
                            Type = "bool",
                            Value = CombatButtons.WrapsChildren
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CombatButtons.X",
                            Type = "float",
                            Value = CombatButtons.X + 1690f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CombatButtons.Y",
                            Type = "float",
                            Value = CombatButtons.Y + 303f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UtilityButtons.Children Layout",
                            Type = "ChildrenLayout",
                            Value = UtilityButtons.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UtilityButtons.Height",
                            Type = "float",
                            Value = UtilityButtons.Height + 30f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UtilityButtons.Height Units",
                            Type = "DimensionUnitType",
                            Value = UtilityButtons.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UtilityButtons.Visible",
                            Type = "bool",
                            Value = UtilityButtons.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UtilityButtons.Width",
                            Type = "float",
                            Value = UtilityButtons.Width + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UtilityButtons.Width Units",
                            Type = "DimensionUnitType",
                            Value = UtilityButtons.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UtilityButtons.Wraps Children",
                            Type = "bool",
                            Value = UtilityButtons.WrapsChildren
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UtilityButtons.X",
                            Type = "float",
                            Value = UtilityButtons.X + 8.923834f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UtilityButtons.X Units",
                            Type = "PositionUnitType",
                            Value = UtilityButtons.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UtilityButtons.Y",
                            Type = "float",
                            Value = UtilityButtons.Y + 10.26004f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UtilityButtons.Y Units",
                            Type = "PositionUnitType",
                            Value = UtilityButtons.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindButton.EnabledStatusState",
                            Type = "EnabledStatusState",
                            Value = WindButton.CurrentEnabledStatusState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindButton.Parent",
                            Type = "string",
                            Value = WindButton.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindButton.StructureTypeState",
                            Type = "StructureTypeState",
                            Value = WindButton.CurrentStructureTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindButton.X",
                            Type = "float",
                            Value = WindButton.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WindButton.X Units",
                            Type = "PositionUnitType",
                            Value = WindButton.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HydroButton.Parent",
                            Type = "string",
                            Value = HydroButton.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HydroButton.StructureTypeState",
                            Type = "StructureTypeState",
                            Value = HydroButton.CurrentStructureTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HydroButton.X",
                            Type = "float",
                            Value = HydroButton.X + 3f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HydroButton.X Units",
                            Type = "PositionUnitType",
                            Value = HydroButton.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LaserTurretButton.Parent",
                            Type = "string",
                            Value = LaserTurretButton.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LaserTurretButton.StructureTypeState",
                            Type = "StructureTypeState",
                            Value = LaserTurretButton.CurrentStructureTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LaserTurretButton.X",
                            Type = "float",
                            Value = LaserTurretButton.X + 1f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LaserTurretButton.X Units",
                            Type = "PositionUnitType",
                            Value = LaserTurretButton.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BatteryButton.Parent",
                            Type = "string",
                            Value = BatteryButton.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BatteryButton.StructureTypeState",
                            Type = "StructureTypeState",
                            Value = BatteryButton.CurrentStructureTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BatteryButton.X",
                            Type = "float",
                            Value = BatteryButton.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BatteryButton.X Units",
                            Type = "PositionUnitType",
                            Value = BatteryButton.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ShieldGeneratorButton.Parent",
                            Type = "string",
                            Value = ShieldGeneratorButton.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ShieldGeneratorButton.StructureTypeState",
                            Type = "StructureTypeState",
                            Value = ShieldGeneratorButton.CurrentStructureTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ShieldGeneratorButton.X",
                            Type = "float",
                            Value = ShieldGeneratorButton.X + 3f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ShieldGeneratorButton.X Units",
                            Type = "PositionUnitType",
                            Value = ShieldGeneratorButton.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CarbonTreeButton.Parent",
                            Type = "string",
                            Value = CarbonTreeButton.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CarbonTreeButton.StructureTypeState",
                            Type = "StructureTypeState",
                            Value = CarbonTreeButton.CurrentStructureTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CarbonTreeButton.Width",
                            Type = "float",
                            Value = CarbonTreeButton.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CarbonTreeButton.X",
                            Type = "float",
                            Value = CarbonTreeButton.X + 3f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CarbonTreeButton.X Units",
                            Type = "PositionUnitType",
                            Value = CarbonTreeButton.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CannonButton.Parent",
                            Type = "string",
                            Value = CannonButton.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CannonButton.StructureTypeState",
                            Type = "StructureTypeState",
                            Value = CannonButton.CurrentStructureTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CannonButton.X",
                            Type = "float",
                            Value = CannonButton.X + 1f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CannonButton.X Units",
                            Type = "PositionUnitType",
                            Value = CannonButton.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TallLaserButton.Parent",
                            Type = "string",
                            Value = TallLaserButton.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TallLaserButton.StructureTypeState",
                            Type = "StructureTypeState",
                            Value = TallLaserButton.CurrentStructureTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TallLaserButton.X",
                            Type = "float",
                            Value = TallLaserButton.X + 1f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TallLaserButton.X Units",
                            Type = "PositionUnitType",
                            Value = TallLaserButton.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UtilityStructureButton.CategoryState",
                            Type = "CategoryState",
                            Value = UtilityStructureButton.CurrentCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UtilityStructureButton.Height",
                            Type = "float",
                            Value = UtilityStructureButton.Height + 35f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UtilityStructureButton.Width",
                            Type = "float",
                            Value = UtilityStructureButton.Width + 8.607957f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UtilityStructureButton.X",
                            Type = "float",
                            Value = UtilityStructureButton.X + 0.2367424f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UtilityStructureButton.X Units",
                            Type = "PositionUnitType",
                            Value = UtilityStructureButton.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UtilityStructureButton.Y",
                            Type = "float",
                            Value = UtilityStructureButton.Y + 10.52189f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UtilityStructureButton.Y Units",
                            Type = "PositionUnitType",
                            Value = UtilityStructureButton.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CombatStructureButton.CategoryState",
                            Type = "CategoryState",
                            Value = CombatStructureButton.CurrentCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CombatStructureButton.Height",
                            Type = "float",
                            Value = CombatStructureButton.Height + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CombatStructureButton.Width",
                            Type = "float",
                            Value = CombatStructureButton.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CombatStructureButton.X",
                            Type = "float",
                            Value = CombatStructureButton.X + 87.83141f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CombatStructureButton.X Units",
                            Type = "PositionUnitType",
                            Value = CombatStructureButton.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CombatStructureButton.Y",
                            Type = "float",
                            Value = CombatStructureButton.Y + 53.04403f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CombatStructureButton.Y Units",
                            Type = "PositionUnitType",
                            Value = CombatStructureButton.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyStructureButton.CategoryState",
                            Type = "CategoryState",
                            Value = EnergyStructureButton.CurrentCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyStructureButton.Height",
                            Type = "float",
                            Value = EnergyStructureButton.Height + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyStructureButton.Width",
                            Type = "float",
                            Value = EnergyStructureButton.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyStructureButton.X",
                            Type = "float",
                            Value = EnergyStructureButton.X + 2.843276f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyStructureButton.X Units",
                            Type = "PositionUnitType",
                            Value = EnergyStructureButton.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyStructureButton.Y",
                            Type = "float",
                            Value = EnergyStructureButton.Y + 50.63406f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyStructureButton.Y Units",
                            Type = "PositionUnitType",
                            Value = EnergyStructureButton.YUnits
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (BuildMenu state)
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  BuildMenu.BuildEnergy:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyButtons.Visible",
                            Type = "bool",
                            Value = EnergyButtons.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CombatButtons.Visible",
                            Type = "bool",
                            Value = CombatButtons.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UtilityButtons.Visible",
                            Type = "bool",
                            Value = UtilityButtons.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UtilityStructureButton.HighlightedState",
                            Type = "HighlightedState",
                            Value = UtilityStructureButton.CurrentHighlightedState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CombatStructureButton.HighlightedState",
                            Type = "HighlightedState",
                            Value = CombatStructureButton.CurrentHighlightedState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyStructureButton.HighlightedState",
                            Type = "HighlightedState",
                            Value = EnergyStructureButton.CurrentHighlightedState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyStructureButton.Visible",
                            Type = "bool",
                            Value = EnergyStructureButton.Visible
                        }
                        );
                        break;
                    case  BuildMenu.BuildCombat:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyButtons.Visible",
                            Type = "bool",
                            Value = EnergyButtons.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CombatButtons.Visible",
                            Type = "bool",
                            Value = CombatButtons.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UtilityButtons.Visible",
                            Type = "bool",
                            Value = UtilityButtons.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UtilityStructureButton.HighlightedState",
                            Type = "HighlightedState",
                            Value = UtilityStructureButton.CurrentHighlightedState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CombatStructureButton.HighlightedState",
                            Type = "HighlightedState",
                            Value = CombatStructureButton.CurrentHighlightedState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyStructureButton.HighlightedState",
                            Type = "HighlightedState",
                            Value = EnergyStructureButton.CurrentHighlightedState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyStructureButton.Visible",
                            Type = "bool",
                            Value = EnergyStructureButton.Visible
                        }
                        );
                        break;
                    case  BuildMenu.BuildUtility:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyButtons.Visible",
                            Type = "bool",
                            Value = EnergyButtons.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CombatButtons.Visible",
                            Type = "bool",
                            Value = CombatButtons.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UtilityButtons.Visible",
                            Type = "bool",
                            Value = UtilityButtons.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UtilityStructureButton.HighlightedState",
                            Type = "HighlightedState",
                            Value = UtilityStructureButton.CurrentHighlightedState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CombatStructureButton.HighlightedState",
                            Type = "HighlightedState",
                            Value = CombatStructureButton.CurrentHighlightedState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyStructureButton.HighlightedState",
                            Type = "HighlightedState",
                            Value = EnergyStructureButton.CurrentHighlightedState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyStructureButton.Visible",
                            Type = "bool",
                            Value = EnergyStructureButton.Visible
                        }
                        );
                        break;
                    case  BuildMenu.None:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyButtons.Visible",
                            Type = "bool",
                            Value = EnergyButtons.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CombatButtons.Visible",
                            Type = "bool",
                            Value = CombatButtons.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UtilityButtons.Visible",
                            Type = "bool",
                            Value = UtilityButtons.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UtilityStructureButton.HighlightedState",
                            Type = "HighlightedState",
                            Value = UtilityStructureButton.CurrentHighlightedState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CombatStructureButton.HighlightedState",
                            Type = "HighlightedState",
                            Value = CombatStructureButton.CurrentHighlightedState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyStructureButton.HighlightedState",
                            Type = "HighlightedState",
                            Value = EnergyStructureButton.CurrentHighlightedState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyStructureButton.Visible",
                            Type = "bool",
                            Value = EnergyStructureButton.Visible
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (BuildMenu state)
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  BuildMenu.BuildEnergy:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyButtons.Visible",
                            Type = "bool",
                            Value = EnergyButtons.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CombatButtons.Visible",
                            Type = "bool",
                            Value = CombatButtons.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UtilityButtons.Visible",
                            Type = "bool",
                            Value = UtilityButtons.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UtilityStructureButton.HighlightedState",
                            Type = "HighlightedState",
                            Value = UtilityStructureButton.CurrentHighlightedState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CombatStructureButton.HighlightedState",
                            Type = "HighlightedState",
                            Value = CombatStructureButton.CurrentHighlightedState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyStructureButton.HighlightedState",
                            Type = "HighlightedState",
                            Value = EnergyStructureButton.CurrentHighlightedState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyStructureButton.Visible",
                            Type = "bool",
                            Value = EnergyStructureButton.Visible
                        }
                        );
                        break;
                    case  BuildMenu.BuildCombat:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyButtons.Visible",
                            Type = "bool",
                            Value = EnergyButtons.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CombatButtons.Visible",
                            Type = "bool",
                            Value = CombatButtons.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UtilityButtons.Visible",
                            Type = "bool",
                            Value = UtilityButtons.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UtilityStructureButton.HighlightedState",
                            Type = "HighlightedState",
                            Value = UtilityStructureButton.CurrentHighlightedState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CombatStructureButton.HighlightedState",
                            Type = "HighlightedState",
                            Value = CombatStructureButton.CurrentHighlightedState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyStructureButton.HighlightedState",
                            Type = "HighlightedState",
                            Value = EnergyStructureButton.CurrentHighlightedState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyStructureButton.Visible",
                            Type = "bool",
                            Value = EnergyStructureButton.Visible
                        }
                        );
                        break;
                    case  BuildMenu.BuildUtility:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyButtons.Visible",
                            Type = "bool",
                            Value = EnergyButtons.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CombatButtons.Visible",
                            Type = "bool",
                            Value = CombatButtons.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UtilityButtons.Visible",
                            Type = "bool",
                            Value = UtilityButtons.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UtilityStructureButton.HighlightedState",
                            Type = "HighlightedState",
                            Value = UtilityStructureButton.CurrentHighlightedState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CombatStructureButton.HighlightedState",
                            Type = "HighlightedState",
                            Value = CombatStructureButton.CurrentHighlightedState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyStructureButton.HighlightedState",
                            Type = "HighlightedState",
                            Value = EnergyStructureButton.CurrentHighlightedState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyStructureButton.Visible",
                            Type = "bool",
                            Value = EnergyStructureButton.Visible
                        }
                        );
                        break;
                    case  BuildMenu.None:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyButtons.Visible",
                            Type = "bool",
                            Value = EnergyButtons.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CombatButtons.Visible",
                            Type = "bool",
                            Value = CombatButtons.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UtilityButtons.Visible",
                            Type = "bool",
                            Value = UtilityButtons.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UtilityStructureButton.HighlightedState",
                            Type = "HighlightedState",
                            Value = UtilityStructureButton.CurrentHighlightedState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CombatStructureButton.HighlightedState",
                            Type = "HighlightedState",
                            Value = CombatStructureButton.CurrentHighlightedState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyStructureButton.HighlightedState",
                            Type = "HighlightedState",
                            Value = EnergyStructureButton.CurrentHighlightedState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyStructureButton.Visible",
                            Type = "bool",
                            Value = EnergyStructureButton.Visible
                        }
                        );
                        break;
                }
                return newState;
            }
            #endregion
            public override void ApplyState (Gum.DataTypes.Variables.StateSave state)
            {
                bool matches = this.ElementSave.AllStates.Contains(state);
                if (matches)
                {
                    var category = this.ElementSave.Categories.FirstOrDefault(item => item.States.Contains(state));
                    if (category == null)
                    {
                        if (state.Name == "Default") this.mCurrentVariableState = VariableState.Default;
                    }
                    else if (category.Name == "BuildMenu")
                    {
                        if(state.Name == "BuildEnergy") this.mCurrentBuildMenuState = BuildMenu.BuildEnergy;
                        if(state.Name == "BuildCombat") this.mCurrentBuildMenuState = BuildMenu.BuildCombat;
                        if(state.Name == "BuildUtility") this.mCurrentBuildMenuState = BuildMenu.BuildUtility;
                        if(state.Name == "None") this.mCurrentBuildMenuState = BuildMenu.None;
                    }
                }
                base.ApplyState(state);
            }
            private AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime SolarButton { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime EnergyButtons { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime CombatButtons { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime UtilityButtons { get; set; }
            private AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime WindButton { get; set; }
            private AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime HydroButton { get; set; }
            private AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime LaserTurretButton { get; set; }
            private AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime BatteryButton { get; set; }
            private AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime ShieldGeneratorButton { get; set; }
            private AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime CarbonTreeButton { get; set; }
            private AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime CannonButton { get; set; }
            private AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime TallLaserButton { get; set; }
            private AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime UtilityStructureButton { get; set; }
            private AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime CombatStructureButton { get; set; }
            private AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime EnergyStructureButton { get; set; }
            public event FlatRedBall.Gui.WindowEvent SolarButtonClick;
            public event FlatRedBall.Gui.WindowEvent WindButtonClick;
            public event FlatRedBall.Gui.WindowEvent HydroButtonClick;
            public event FlatRedBall.Gui.WindowEvent LaserTurretButtonClick;
            public event FlatRedBall.Gui.WindowEvent BatteryButtonClick;
            public event FlatRedBall.Gui.WindowEvent ShieldGeneratorButtonClick;
            public event FlatRedBall.Gui.WindowEvent CarbonTreeButtonClick;
            public event FlatRedBall.Gui.WindowEvent CannonButtonClick;
            public event FlatRedBall.Gui.WindowEvent TallLaserButtonClick;
            public event FlatRedBall.Gui.WindowEvent UtilityStructureButtonClick;
            public event FlatRedBall.Gui.WindowEvent CombatStructureButtonClick;
            public event FlatRedBall.Gui.WindowEvent EnergyStructureButtonClick;
            public BuildBarRuntime (bool fullInstantiation = true)
            	: base(false)
            {
                this.HasEvents = false;
                this.ExposeChildrenEvents = true;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "BuildBar");
                    this.ElementSave = elementSave;
                    string oldDirectory = FlatRedBall.IO.FileManager.RelativeDirectory;
                    FlatRedBall.IO.FileManager.RelativeDirectory = FlatRedBall.IO.FileManager.GetDirectory(Gum.Managers.ObjectFinder.Self.GumProjectSave.FullFileName);
                    GumRuntime.ElementSaveExtensions.SetGraphicalUiElement(elementSave, this, RenderingLibrary.SystemManagers.Default);
                    FlatRedBall.IO.FileManager.RelativeDirectory = oldDirectory;
                }
            }
            public override void SetInitialState ()
            {
                base.SetInitialState();
                this.CurrentVariableState = VariableState.Default;
                CallCustomInitialize();
            }
            public override void CreateChildrenRecursively (Gum.DataTypes.ElementSave elementSave, RenderingLibrary.SystemManagers systemManagers)
            {
                base.CreateChildrenRecursively(elementSave, systemManagers);
                this.AssignReferences();
            }
            private void AssignReferences ()
            {
                SolarButton = this.GetGraphicalUiElementByName("SolarButton") as AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime;
                EnergyButtons = this.GetGraphicalUiElementByName("EnergyButtons") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
                CombatButtons = this.GetGraphicalUiElementByName("CombatButtons") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
                UtilityButtons = this.GetGraphicalUiElementByName("UtilityButtons") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
                WindButton = this.GetGraphicalUiElementByName("WindButton") as AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime;
                HydroButton = this.GetGraphicalUiElementByName("HydroButton") as AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime;
                LaserTurretButton = this.GetGraphicalUiElementByName("LaserTurretButton") as AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime;
                BatteryButton = this.GetGraphicalUiElementByName("BatteryButton") as AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime;
                ShieldGeneratorButton = this.GetGraphicalUiElementByName("ShieldGeneratorButton") as AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime;
                CarbonTreeButton = this.GetGraphicalUiElementByName("CarbonTreeButton") as AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime;
                CannonButton = this.GetGraphicalUiElementByName("CannonButton") as AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime;
                TallLaserButton = this.GetGraphicalUiElementByName("TallLaserButton") as AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime;
                UtilityStructureButton = this.GetGraphicalUiElementByName("UtilityStructureButton") as AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime;
                CombatStructureButton = this.GetGraphicalUiElementByName("CombatStructureButton") as AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime;
                EnergyStructureButton = this.GetGraphicalUiElementByName("EnergyStructureButton") as AbbatoirIntergrade.GumRuntimes.CategoryButtonRuntime;
                SolarButton.Click += (unused) => SolarButtonClick?.Invoke(this);
                WindButton.Click += (unused) => WindButtonClick?.Invoke(this);
                HydroButton.Click += (unused) => HydroButtonClick?.Invoke(this);
                LaserTurretButton.Click += (unused) => LaserTurretButtonClick?.Invoke(this);
                BatteryButton.Click += (unused) => BatteryButtonClick?.Invoke(this);
                ShieldGeneratorButton.Click += (unused) => ShieldGeneratorButtonClick?.Invoke(this);
                CarbonTreeButton.Click += (unused) => CarbonTreeButtonClick?.Invoke(this);
                CannonButton.Click += (unused) => CannonButtonClick?.Invoke(this);
                TallLaserButton.Click += (unused) => TallLaserButtonClick?.Invoke(this);
                UtilityStructureButton.Click += (unused) => UtilityStructureButtonClick?.Invoke(this);
                CombatStructureButton.Click += (unused) => CombatStructureButtonClick?.Invoke(this);
                EnergyStructureButton.Click += (unused) => EnergyStructureButtonClick?.Invoke(this);
            }
            public override void AddToManagers (RenderingLibrary.SystemManagers managers, RenderingLibrary.Graphics.Layer layer)
            {
                base.AddToManagers(managers, layer);
            }
            private void CallCustomInitialize ()
            {
                CustomInitialize();
            }
            partial void CustomInitialize();
        }
    }
