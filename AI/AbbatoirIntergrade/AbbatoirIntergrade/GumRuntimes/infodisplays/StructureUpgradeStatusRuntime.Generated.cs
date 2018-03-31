    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes
    {
        public partial class StructureUpgradeStatusRuntime : AbbatoirIntergrade.GumRuntimes.ContainerRuntime
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            public enum Upgrades
            {
                None,
                Range,
                Speed,
                RangeSpeed,
                RangeDamage,
                SpeedDamage,
                DamageRangeSpeed
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            Upgrades mCurrentUpgradesState;
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
                            ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                            Height = 32f;
                            Width = 100f;
                            XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddleInverted;
                            AttributeIconInstance.Height = 100f;
                            AttributeIconInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            AttributeIconInstance.Width = 100f;
                            AttributeIconInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                            AttributeIconInstance1.Height = 100f;
                            AttributeIconInstance1.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            AttributeIconInstance1.Width = 100f;
                            AttributeIconInstance1.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                            AttributeIconInstance2.Height = 100f;
                            AttributeIconInstance2.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            AttributeIconInstance2.Width = 100f;
                            AttributeIconInstance2.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                            break;
                    }
                }
            }
            public Upgrades CurrentUpgradesState
            {
                get
                {
                    return mCurrentUpgradesState;
                }
                set
                {
                    mCurrentUpgradesState = value;
                    switch(mCurrentUpgradesState)
                    {
                        case  Upgrades.None:
                            AttributeIconInstance.CurrentAttributeTypeState = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.Health;
                            AttributeIconInstance.Visible = false;
                            AttributeIconInstance1.CurrentAttributeTypeState = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.Health;
                            AttributeIconInstance1.Visible = false;
                            AttributeIconInstance2.CurrentAttributeTypeState = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.Health;
                            AttributeIconInstance2.Visible = false;
                            break;
                        case  Upgrades.Range:
                            AttributeIconInstance.CurrentAttributeTypeState = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.MaxRange;
                            AttributeIconInstance.Visible = true;
                            AttributeIconInstance1.CurrentAttributeTypeState = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.Health;
                            AttributeIconInstance1.Visible = false;
                            AttributeIconInstance2.CurrentAttributeTypeState = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.Health;
                            AttributeIconInstance2.Visible = false;
                            break;
                        case  Upgrades.Speed:
                            AttributeIconInstance.CurrentAttributeTypeState = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.AttackSpeed;
                            AttributeIconInstance.Visible = true;
                            AttributeIconInstance1.CurrentAttributeTypeState = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.Health;
                            AttributeIconInstance1.Visible = false;
                            AttributeIconInstance2.CurrentAttributeTypeState = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.Health;
                            AttributeIconInstance2.Visible = false;
                            break;
                        case  Upgrades.RangeSpeed:
                            AttributeIconInstance.CurrentAttributeTypeState = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.MaxRange;
                            AttributeIconInstance.Visible = true;
                            AttributeIconInstance1.CurrentAttributeTypeState = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.AttackSpeed;
                            AttributeIconInstance1.Visible = true;
                            AttributeIconInstance2.CurrentAttributeTypeState = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.Health;
                            AttributeIconInstance2.Visible = false;
                            break;
                        case  Upgrades.RangeDamage:
                            AttributeIconInstance.CurrentAttributeTypeState = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.MaxRange;
                            AttributeIconInstance.Visible = true;
                            AttributeIconInstance1.CurrentAttributeTypeState = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.Health;
                            AttributeIconInstance1.Visible = true;
                            AttributeIconInstance2.CurrentAttributeTypeState = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.Health;
                            AttributeIconInstance2.Visible = false;
                            break;
                        case  Upgrades.SpeedDamage:
                            AttributeIconInstance.CurrentAttributeTypeState = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.AttackSpeed;
                            AttributeIconInstance.Visible = true;
                            AttributeIconInstance1.CurrentAttributeTypeState = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.Health;
                            AttributeIconInstance1.Visible = true;
                            AttributeIconInstance2.CurrentAttributeTypeState = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.Health;
                            AttributeIconInstance2.Visible = false;
                            break;
                        case  Upgrades.DamageRangeSpeed:
                            AttributeIconInstance.CurrentAttributeTypeState = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.Health;
                            AttributeIconInstance.Visible = true;
                            AttributeIconInstance1.CurrentAttributeTypeState = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.MaxRange;
                            AttributeIconInstance1.Visible = true;
                            AttributeIconInstance2.CurrentAttributeTypeState = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.AttackSpeed;
                            AttributeIconInstance2.Visible = true;
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
                bool setAttributeIconInstanceHeightFirstValue = false;
                bool setAttributeIconInstanceHeightSecondValue = false;
                float AttributeIconInstanceHeightFirstValue= 0;
                float AttributeIconInstanceHeightSecondValue= 0;
                bool setAttributeIconInstanceWidthFirstValue = false;
                bool setAttributeIconInstanceWidthSecondValue = false;
                float AttributeIconInstanceWidthFirstValue= 0;
                float AttributeIconInstanceWidthSecondValue= 0;
                bool setAttributeIconInstance1HeightFirstValue = false;
                bool setAttributeIconInstance1HeightSecondValue = false;
                float AttributeIconInstance1HeightFirstValue= 0;
                float AttributeIconInstance1HeightSecondValue= 0;
                bool setAttributeIconInstance1WidthFirstValue = false;
                bool setAttributeIconInstance1WidthSecondValue = false;
                float AttributeIconInstance1WidthFirstValue= 0;
                float AttributeIconInstance1WidthSecondValue= 0;
                bool setAttributeIconInstance2HeightFirstValue = false;
                bool setAttributeIconInstance2HeightSecondValue = false;
                float AttributeIconInstance2HeightFirstValue= 0;
                float AttributeIconInstance2HeightSecondValue= 0;
                bool setAttributeIconInstance2WidthFirstValue = false;
                bool setAttributeIconInstance2WidthSecondValue = false;
                float AttributeIconInstance2WidthFirstValue= 0;
                float AttributeIconInstance2WidthSecondValue= 0;
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setAttributeIconInstanceHeightFirstValue = true;
                        AttributeIconInstanceHeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.AttributeIconInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setAttributeIconInstanceWidthFirstValue = true;
                        AttributeIconInstanceWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.AttributeIconInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        setAttributeIconInstance1HeightFirstValue = true;
                        AttributeIconInstance1HeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.AttributeIconInstance1.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setAttributeIconInstance1WidthFirstValue = true;
                        AttributeIconInstance1WidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.AttributeIconInstance1.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        setAttributeIconInstance2HeightFirstValue = true;
                        AttributeIconInstance2HeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.AttributeIconInstance2.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setAttributeIconInstance2WidthFirstValue = true;
                        AttributeIconInstance2WidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.AttributeIconInstance2.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setHeightFirstValue = true;
                        HeightFirstValue = 32f;
                        setWidthFirstValue = true;
                        WidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue < 1)
                        {
                            this.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddleInverted;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setAttributeIconInstanceHeightSecondValue = true;
                        AttributeIconInstanceHeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.AttributeIconInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setAttributeIconInstanceWidthSecondValue = true;
                        AttributeIconInstanceWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.AttributeIconInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        setAttributeIconInstance1HeightSecondValue = true;
                        AttributeIconInstance1HeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.AttributeIconInstance1.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setAttributeIconInstance1WidthSecondValue = true;
                        AttributeIconInstance1WidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.AttributeIconInstance1.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        setAttributeIconInstance2HeightSecondValue = true;
                        AttributeIconInstance2HeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.AttributeIconInstance2.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setAttributeIconInstance2WidthSecondValue = true;
                        AttributeIconInstance2WidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.AttributeIconInstance2.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setHeightSecondValue = true;
                        HeightSecondValue = 32f;
                        setWidthSecondValue = true;
                        WidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddleInverted;
                        }
                        break;
                }
                if (setAttributeIconInstanceHeightFirstValue && setAttributeIconInstanceHeightSecondValue)
                {
                    AttributeIconInstance.Height = AttributeIconInstanceHeightFirstValue * (1 - interpolationValue) + AttributeIconInstanceHeightSecondValue * interpolationValue;
                }
                if (setAttributeIconInstanceWidthFirstValue && setAttributeIconInstanceWidthSecondValue)
                {
                    AttributeIconInstance.Width = AttributeIconInstanceWidthFirstValue * (1 - interpolationValue) + AttributeIconInstanceWidthSecondValue * interpolationValue;
                }
                if (setAttributeIconInstance1HeightFirstValue && setAttributeIconInstance1HeightSecondValue)
                {
                    AttributeIconInstance1.Height = AttributeIconInstance1HeightFirstValue * (1 - interpolationValue) + AttributeIconInstance1HeightSecondValue * interpolationValue;
                }
                if (setAttributeIconInstance1WidthFirstValue && setAttributeIconInstance1WidthSecondValue)
                {
                    AttributeIconInstance1.Width = AttributeIconInstance1WidthFirstValue * (1 - interpolationValue) + AttributeIconInstance1WidthSecondValue * interpolationValue;
                }
                if (setAttributeIconInstance2HeightFirstValue && setAttributeIconInstance2HeightSecondValue)
                {
                    AttributeIconInstance2.Height = AttributeIconInstance2HeightFirstValue * (1 - interpolationValue) + AttributeIconInstance2HeightSecondValue * interpolationValue;
                }
                if (setAttributeIconInstance2WidthFirstValue && setAttributeIconInstance2WidthSecondValue)
                {
                    AttributeIconInstance2.Width = AttributeIconInstance2WidthFirstValue * (1 - interpolationValue) + AttributeIconInstance2WidthSecondValue * interpolationValue;
                }
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
                }
                if (setWidthFirstValue && setWidthSecondValue)
                {
                    Width = WidthFirstValue * (1 - interpolationValue) + WidthSecondValue * interpolationValue;
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
            public void InterpolateBetween (Upgrades firstState, Upgrades secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setAttributeIconInstanceCurrentAttributeTypeStateFirstValue = false;
                bool setAttributeIconInstanceCurrentAttributeTypeStateSecondValue = false;
                AttributeIconRuntime.AttributeType AttributeIconInstanceCurrentAttributeTypeStateFirstValue= AttributeIconRuntime.AttributeType.Health;
                AttributeIconRuntime.AttributeType AttributeIconInstanceCurrentAttributeTypeStateSecondValue= AttributeIconRuntime.AttributeType.Health;
                bool setAttributeIconInstance1CurrentAttributeTypeStateFirstValue = false;
                bool setAttributeIconInstance1CurrentAttributeTypeStateSecondValue = false;
                AttributeIconRuntime.AttributeType AttributeIconInstance1CurrentAttributeTypeStateFirstValue= AttributeIconRuntime.AttributeType.Health;
                AttributeIconRuntime.AttributeType AttributeIconInstance1CurrentAttributeTypeStateSecondValue= AttributeIconRuntime.AttributeType.Health;
                bool setAttributeIconInstance2CurrentAttributeTypeStateFirstValue = false;
                bool setAttributeIconInstance2CurrentAttributeTypeStateSecondValue = false;
                AttributeIconRuntime.AttributeType AttributeIconInstance2CurrentAttributeTypeStateFirstValue= AttributeIconRuntime.AttributeType.Health;
                AttributeIconRuntime.AttributeType AttributeIconInstance2CurrentAttributeTypeStateSecondValue= AttributeIconRuntime.AttributeType.Health;
                switch(firstState)
                {
                    case  Upgrades.None:
                        setAttributeIconInstanceCurrentAttributeTypeStateFirstValue = true;
                        AttributeIconInstanceCurrentAttributeTypeStateFirstValue = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.Health;
                        if (interpolationValue < 1)
                        {
                            this.AttributeIconInstance.Visible = false;
                        }
                        setAttributeIconInstance1CurrentAttributeTypeStateFirstValue = true;
                        AttributeIconInstance1CurrentAttributeTypeStateFirstValue = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.Health;
                        if (interpolationValue < 1)
                        {
                            this.AttributeIconInstance1.Visible = false;
                        }
                        setAttributeIconInstance2CurrentAttributeTypeStateFirstValue = true;
                        AttributeIconInstance2CurrentAttributeTypeStateFirstValue = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.Health;
                        if (interpolationValue < 1)
                        {
                            this.AttributeIconInstance2.Visible = false;
                        }
                        break;
                    case  Upgrades.Range:
                        setAttributeIconInstanceCurrentAttributeTypeStateFirstValue = true;
                        AttributeIconInstanceCurrentAttributeTypeStateFirstValue = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.MaxRange;
                        if (interpolationValue < 1)
                        {
                            this.AttributeIconInstance.Visible = true;
                        }
                        setAttributeIconInstance1CurrentAttributeTypeStateFirstValue = true;
                        AttributeIconInstance1CurrentAttributeTypeStateFirstValue = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.Health;
                        if (interpolationValue < 1)
                        {
                            this.AttributeIconInstance1.Visible = false;
                        }
                        setAttributeIconInstance2CurrentAttributeTypeStateFirstValue = true;
                        AttributeIconInstance2CurrentAttributeTypeStateFirstValue = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.Health;
                        if (interpolationValue < 1)
                        {
                            this.AttributeIconInstance2.Visible = false;
                        }
                        break;
                    case  Upgrades.Speed:
                        setAttributeIconInstanceCurrentAttributeTypeStateFirstValue = true;
                        AttributeIconInstanceCurrentAttributeTypeStateFirstValue = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.AttackSpeed;
                        if (interpolationValue < 1)
                        {
                            this.AttributeIconInstance.Visible = true;
                        }
                        setAttributeIconInstance1CurrentAttributeTypeStateFirstValue = true;
                        AttributeIconInstance1CurrentAttributeTypeStateFirstValue = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.Health;
                        if (interpolationValue < 1)
                        {
                            this.AttributeIconInstance1.Visible = false;
                        }
                        setAttributeIconInstance2CurrentAttributeTypeStateFirstValue = true;
                        AttributeIconInstance2CurrentAttributeTypeStateFirstValue = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.Health;
                        if (interpolationValue < 1)
                        {
                            this.AttributeIconInstance2.Visible = false;
                        }
                        break;
                    case  Upgrades.RangeSpeed:
                        setAttributeIconInstanceCurrentAttributeTypeStateFirstValue = true;
                        AttributeIconInstanceCurrentAttributeTypeStateFirstValue = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.MaxRange;
                        if (interpolationValue < 1)
                        {
                            this.AttributeIconInstance.Visible = true;
                        }
                        setAttributeIconInstance1CurrentAttributeTypeStateFirstValue = true;
                        AttributeIconInstance1CurrentAttributeTypeStateFirstValue = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.AttackSpeed;
                        if (interpolationValue < 1)
                        {
                            this.AttributeIconInstance1.Visible = true;
                        }
                        setAttributeIconInstance2CurrentAttributeTypeStateFirstValue = true;
                        AttributeIconInstance2CurrentAttributeTypeStateFirstValue = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.Health;
                        if (interpolationValue < 1)
                        {
                            this.AttributeIconInstance2.Visible = false;
                        }
                        break;
                    case  Upgrades.RangeDamage:
                        setAttributeIconInstanceCurrentAttributeTypeStateFirstValue = true;
                        AttributeIconInstanceCurrentAttributeTypeStateFirstValue = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.MaxRange;
                        if (interpolationValue < 1)
                        {
                            this.AttributeIconInstance.Visible = true;
                        }
                        setAttributeIconInstance1CurrentAttributeTypeStateFirstValue = true;
                        AttributeIconInstance1CurrentAttributeTypeStateFirstValue = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.Health;
                        if (interpolationValue < 1)
                        {
                            this.AttributeIconInstance1.Visible = true;
                        }
                        setAttributeIconInstance2CurrentAttributeTypeStateFirstValue = true;
                        AttributeIconInstance2CurrentAttributeTypeStateFirstValue = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.Health;
                        if (interpolationValue < 1)
                        {
                            this.AttributeIconInstance2.Visible = false;
                        }
                        break;
                    case  Upgrades.SpeedDamage:
                        setAttributeIconInstanceCurrentAttributeTypeStateFirstValue = true;
                        AttributeIconInstanceCurrentAttributeTypeStateFirstValue = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.AttackSpeed;
                        if (interpolationValue < 1)
                        {
                            this.AttributeIconInstance.Visible = true;
                        }
                        setAttributeIconInstance1CurrentAttributeTypeStateFirstValue = true;
                        AttributeIconInstance1CurrentAttributeTypeStateFirstValue = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.Health;
                        if (interpolationValue < 1)
                        {
                            this.AttributeIconInstance1.Visible = true;
                        }
                        setAttributeIconInstance2CurrentAttributeTypeStateFirstValue = true;
                        AttributeIconInstance2CurrentAttributeTypeStateFirstValue = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.Health;
                        if (interpolationValue < 1)
                        {
                            this.AttributeIconInstance2.Visible = false;
                        }
                        break;
                    case  Upgrades.DamageRangeSpeed:
                        setAttributeIconInstanceCurrentAttributeTypeStateFirstValue = true;
                        AttributeIconInstanceCurrentAttributeTypeStateFirstValue = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.Health;
                        if (interpolationValue < 1)
                        {
                            this.AttributeIconInstance.Visible = true;
                        }
                        setAttributeIconInstance1CurrentAttributeTypeStateFirstValue = true;
                        AttributeIconInstance1CurrentAttributeTypeStateFirstValue = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.MaxRange;
                        if (interpolationValue < 1)
                        {
                            this.AttributeIconInstance1.Visible = true;
                        }
                        setAttributeIconInstance2CurrentAttributeTypeStateFirstValue = true;
                        AttributeIconInstance2CurrentAttributeTypeStateFirstValue = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.AttackSpeed;
                        if (interpolationValue < 1)
                        {
                            this.AttributeIconInstance2.Visible = true;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  Upgrades.None:
                        setAttributeIconInstanceCurrentAttributeTypeStateSecondValue = true;
                        AttributeIconInstanceCurrentAttributeTypeStateSecondValue = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.Health;
                        if (interpolationValue >= 1)
                        {
                            this.AttributeIconInstance.Visible = false;
                        }
                        setAttributeIconInstance1CurrentAttributeTypeStateSecondValue = true;
                        AttributeIconInstance1CurrentAttributeTypeStateSecondValue = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.Health;
                        if (interpolationValue >= 1)
                        {
                            this.AttributeIconInstance1.Visible = false;
                        }
                        setAttributeIconInstance2CurrentAttributeTypeStateSecondValue = true;
                        AttributeIconInstance2CurrentAttributeTypeStateSecondValue = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.Health;
                        if (interpolationValue >= 1)
                        {
                            this.AttributeIconInstance2.Visible = false;
                        }
                        break;
                    case  Upgrades.Range:
                        setAttributeIconInstanceCurrentAttributeTypeStateSecondValue = true;
                        AttributeIconInstanceCurrentAttributeTypeStateSecondValue = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.MaxRange;
                        if (interpolationValue >= 1)
                        {
                            this.AttributeIconInstance.Visible = true;
                        }
                        setAttributeIconInstance1CurrentAttributeTypeStateSecondValue = true;
                        AttributeIconInstance1CurrentAttributeTypeStateSecondValue = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.Health;
                        if (interpolationValue >= 1)
                        {
                            this.AttributeIconInstance1.Visible = false;
                        }
                        setAttributeIconInstance2CurrentAttributeTypeStateSecondValue = true;
                        AttributeIconInstance2CurrentAttributeTypeStateSecondValue = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.Health;
                        if (interpolationValue >= 1)
                        {
                            this.AttributeIconInstance2.Visible = false;
                        }
                        break;
                    case  Upgrades.Speed:
                        setAttributeIconInstanceCurrentAttributeTypeStateSecondValue = true;
                        AttributeIconInstanceCurrentAttributeTypeStateSecondValue = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.AttackSpeed;
                        if (interpolationValue >= 1)
                        {
                            this.AttributeIconInstance.Visible = true;
                        }
                        setAttributeIconInstance1CurrentAttributeTypeStateSecondValue = true;
                        AttributeIconInstance1CurrentAttributeTypeStateSecondValue = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.Health;
                        if (interpolationValue >= 1)
                        {
                            this.AttributeIconInstance1.Visible = false;
                        }
                        setAttributeIconInstance2CurrentAttributeTypeStateSecondValue = true;
                        AttributeIconInstance2CurrentAttributeTypeStateSecondValue = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.Health;
                        if (interpolationValue >= 1)
                        {
                            this.AttributeIconInstance2.Visible = false;
                        }
                        break;
                    case  Upgrades.RangeSpeed:
                        setAttributeIconInstanceCurrentAttributeTypeStateSecondValue = true;
                        AttributeIconInstanceCurrentAttributeTypeStateSecondValue = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.MaxRange;
                        if (interpolationValue >= 1)
                        {
                            this.AttributeIconInstance.Visible = true;
                        }
                        setAttributeIconInstance1CurrentAttributeTypeStateSecondValue = true;
                        AttributeIconInstance1CurrentAttributeTypeStateSecondValue = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.AttackSpeed;
                        if (interpolationValue >= 1)
                        {
                            this.AttributeIconInstance1.Visible = true;
                        }
                        setAttributeIconInstance2CurrentAttributeTypeStateSecondValue = true;
                        AttributeIconInstance2CurrentAttributeTypeStateSecondValue = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.Health;
                        if (interpolationValue >= 1)
                        {
                            this.AttributeIconInstance2.Visible = false;
                        }
                        break;
                    case  Upgrades.RangeDamage:
                        setAttributeIconInstanceCurrentAttributeTypeStateSecondValue = true;
                        AttributeIconInstanceCurrentAttributeTypeStateSecondValue = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.MaxRange;
                        if (interpolationValue >= 1)
                        {
                            this.AttributeIconInstance.Visible = true;
                        }
                        setAttributeIconInstance1CurrentAttributeTypeStateSecondValue = true;
                        AttributeIconInstance1CurrentAttributeTypeStateSecondValue = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.Health;
                        if (interpolationValue >= 1)
                        {
                            this.AttributeIconInstance1.Visible = true;
                        }
                        setAttributeIconInstance2CurrentAttributeTypeStateSecondValue = true;
                        AttributeIconInstance2CurrentAttributeTypeStateSecondValue = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.Health;
                        if (interpolationValue >= 1)
                        {
                            this.AttributeIconInstance2.Visible = false;
                        }
                        break;
                    case  Upgrades.SpeedDamage:
                        setAttributeIconInstanceCurrentAttributeTypeStateSecondValue = true;
                        AttributeIconInstanceCurrentAttributeTypeStateSecondValue = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.AttackSpeed;
                        if (interpolationValue >= 1)
                        {
                            this.AttributeIconInstance.Visible = true;
                        }
                        setAttributeIconInstance1CurrentAttributeTypeStateSecondValue = true;
                        AttributeIconInstance1CurrentAttributeTypeStateSecondValue = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.Health;
                        if (interpolationValue >= 1)
                        {
                            this.AttributeIconInstance1.Visible = true;
                        }
                        setAttributeIconInstance2CurrentAttributeTypeStateSecondValue = true;
                        AttributeIconInstance2CurrentAttributeTypeStateSecondValue = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.Health;
                        if (interpolationValue >= 1)
                        {
                            this.AttributeIconInstance2.Visible = false;
                        }
                        break;
                    case  Upgrades.DamageRangeSpeed:
                        setAttributeIconInstanceCurrentAttributeTypeStateSecondValue = true;
                        AttributeIconInstanceCurrentAttributeTypeStateSecondValue = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.Health;
                        if (interpolationValue >= 1)
                        {
                            this.AttributeIconInstance.Visible = true;
                        }
                        setAttributeIconInstance1CurrentAttributeTypeStateSecondValue = true;
                        AttributeIconInstance1CurrentAttributeTypeStateSecondValue = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.MaxRange;
                        if (interpolationValue >= 1)
                        {
                            this.AttributeIconInstance1.Visible = true;
                        }
                        setAttributeIconInstance2CurrentAttributeTypeStateSecondValue = true;
                        AttributeIconInstance2CurrentAttributeTypeStateSecondValue = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.AttackSpeed;
                        if (interpolationValue >= 1)
                        {
                            this.AttributeIconInstance2.Visible = true;
                        }
                        break;
                }
                if (setAttributeIconInstanceCurrentAttributeTypeStateFirstValue && setAttributeIconInstanceCurrentAttributeTypeStateSecondValue)
                {
                    AttributeIconInstance.InterpolateBetween(AttributeIconInstanceCurrentAttributeTypeStateFirstValue, AttributeIconInstanceCurrentAttributeTypeStateSecondValue, interpolationValue);
                }
                if (setAttributeIconInstance1CurrentAttributeTypeStateFirstValue && setAttributeIconInstance1CurrentAttributeTypeStateSecondValue)
                {
                    AttributeIconInstance1.InterpolateBetween(AttributeIconInstance1CurrentAttributeTypeStateFirstValue, AttributeIconInstance1CurrentAttributeTypeStateSecondValue, interpolationValue);
                }
                if (setAttributeIconInstance2CurrentAttributeTypeStateFirstValue && setAttributeIconInstance2CurrentAttributeTypeStateSecondValue)
                {
                    AttributeIconInstance2.InterpolateBetween(AttributeIconInstance2CurrentAttributeTypeStateFirstValue, AttributeIconInstance2CurrentAttributeTypeStateSecondValue, interpolationValue);
                }
                if (interpolationValue < 1)
                {
                    mCurrentUpgradesState = firstState;
                }
                else
                {
                    mCurrentUpgradesState = secondState;
                }
            }
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.StructureUpgradeStatusRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.StructureUpgradeStatusRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.StructureUpgradeStatusRuntime.Upgrades fromState,AbbatoirIntergrade.GumRuntimes.StructureUpgradeStatusRuntime.Upgrades toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Upgrades toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "Upgrades").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentUpgradesState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (Upgrades toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentUpgradesState = toState;
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
                AttributeIconInstance.StopAnimations();
                AttributeIconInstance1.StopAnimations();
                AttributeIconInstance2.StopAnimations();
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
                            Name = "Height",
                            Type = "float",
                            Value = Height
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
                            Name = "Y Units",
                            Type = "PositionUnitType",
                            Value = YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.Height",
                            Type = "float",
                            Value = AttributeIconInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = AttributeIconInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.Width",
                            Type = "float",
                            Value = AttributeIconInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = AttributeIconInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance1.Height",
                            Type = "float",
                            Value = AttributeIconInstance1.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance1.Height Units",
                            Type = "DimensionUnitType",
                            Value = AttributeIconInstance1.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance1.Width",
                            Type = "float",
                            Value = AttributeIconInstance1.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance1.Width Units",
                            Type = "DimensionUnitType",
                            Value = AttributeIconInstance1.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance2.Height",
                            Type = "float",
                            Value = AttributeIconInstance2.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance2.Height Units",
                            Type = "DimensionUnitType",
                            Value = AttributeIconInstance2.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance2.Width",
                            Type = "float",
                            Value = AttributeIconInstance2.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance2.Width Units",
                            Type = "DimensionUnitType",
                            Value = AttributeIconInstance2.WidthUnits
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
                            Name = "Height",
                            Type = "float",
                            Value = Height + 32f
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
                            Name = "Y Units",
                            Type = "PositionUnitType",
                            Value = YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.Height",
                            Type = "float",
                            Value = AttributeIconInstance.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = AttributeIconInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.Width",
                            Type = "float",
                            Value = AttributeIconInstance.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = AttributeIconInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance1.Height",
                            Type = "float",
                            Value = AttributeIconInstance1.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance1.Height Units",
                            Type = "DimensionUnitType",
                            Value = AttributeIconInstance1.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance1.Width",
                            Type = "float",
                            Value = AttributeIconInstance1.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance1.Width Units",
                            Type = "DimensionUnitType",
                            Value = AttributeIconInstance1.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance2.Height",
                            Type = "float",
                            Value = AttributeIconInstance2.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance2.Height Units",
                            Type = "DimensionUnitType",
                            Value = AttributeIconInstance2.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance2.Width",
                            Type = "float",
                            Value = AttributeIconInstance2.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance2.Width Units",
                            Type = "DimensionUnitType",
                            Value = AttributeIconInstance2.WidthUnits
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (Upgrades state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  Upgrades.None:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.AttributeTypeState",
                            Type = "AttributeTypeState",
                            Value = AttributeIconInstance.CurrentAttributeTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.Visible",
                            Type = "bool",
                            Value = AttributeIconInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance1.AttributeTypeState",
                            Type = "AttributeTypeState",
                            Value = AttributeIconInstance1.CurrentAttributeTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance1.Visible",
                            Type = "bool",
                            Value = AttributeIconInstance1.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance2.AttributeTypeState",
                            Type = "AttributeTypeState",
                            Value = AttributeIconInstance2.CurrentAttributeTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance2.Visible",
                            Type = "bool",
                            Value = AttributeIconInstance2.Visible
                        }
                        );
                        break;
                    case  Upgrades.Range:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.AttributeTypeState",
                            Type = "AttributeTypeState",
                            Value = AttributeIconInstance.CurrentAttributeTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.Visible",
                            Type = "bool",
                            Value = AttributeIconInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance1.AttributeTypeState",
                            Type = "AttributeTypeState",
                            Value = AttributeIconInstance1.CurrentAttributeTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance1.Visible",
                            Type = "bool",
                            Value = AttributeIconInstance1.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance2.AttributeTypeState",
                            Type = "AttributeTypeState",
                            Value = AttributeIconInstance2.CurrentAttributeTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance2.Visible",
                            Type = "bool",
                            Value = AttributeIconInstance2.Visible
                        }
                        );
                        break;
                    case  Upgrades.Speed:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.AttributeTypeState",
                            Type = "AttributeTypeState",
                            Value = AttributeIconInstance.CurrentAttributeTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.Visible",
                            Type = "bool",
                            Value = AttributeIconInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance1.AttributeTypeState",
                            Type = "AttributeTypeState",
                            Value = AttributeIconInstance1.CurrentAttributeTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance1.Visible",
                            Type = "bool",
                            Value = AttributeIconInstance1.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance2.AttributeTypeState",
                            Type = "AttributeTypeState",
                            Value = AttributeIconInstance2.CurrentAttributeTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance2.Visible",
                            Type = "bool",
                            Value = AttributeIconInstance2.Visible
                        }
                        );
                        break;
                    case  Upgrades.RangeSpeed:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.AttributeTypeState",
                            Type = "AttributeTypeState",
                            Value = AttributeIconInstance.CurrentAttributeTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.Visible",
                            Type = "bool",
                            Value = AttributeIconInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance1.AttributeTypeState",
                            Type = "AttributeTypeState",
                            Value = AttributeIconInstance1.CurrentAttributeTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance1.Visible",
                            Type = "bool",
                            Value = AttributeIconInstance1.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance2.AttributeTypeState",
                            Type = "AttributeTypeState",
                            Value = AttributeIconInstance2.CurrentAttributeTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance2.Visible",
                            Type = "bool",
                            Value = AttributeIconInstance2.Visible
                        }
                        );
                        break;
                    case  Upgrades.RangeDamage:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.AttributeTypeState",
                            Type = "AttributeTypeState",
                            Value = AttributeIconInstance.CurrentAttributeTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.Visible",
                            Type = "bool",
                            Value = AttributeIconInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance1.AttributeTypeState",
                            Type = "AttributeTypeState",
                            Value = AttributeIconInstance1.CurrentAttributeTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance1.Visible",
                            Type = "bool",
                            Value = AttributeIconInstance1.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance2.AttributeTypeState",
                            Type = "AttributeTypeState",
                            Value = AttributeIconInstance2.CurrentAttributeTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance2.Visible",
                            Type = "bool",
                            Value = AttributeIconInstance2.Visible
                        }
                        );
                        break;
                    case  Upgrades.SpeedDamage:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.AttributeTypeState",
                            Type = "AttributeTypeState",
                            Value = AttributeIconInstance.CurrentAttributeTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.Visible",
                            Type = "bool",
                            Value = AttributeIconInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance1.AttributeTypeState",
                            Type = "AttributeTypeState",
                            Value = AttributeIconInstance1.CurrentAttributeTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance1.Visible",
                            Type = "bool",
                            Value = AttributeIconInstance1.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance2.AttributeTypeState",
                            Type = "AttributeTypeState",
                            Value = AttributeIconInstance2.CurrentAttributeTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance2.Visible",
                            Type = "bool",
                            Value = AttributeIconInstance2.Visible
                        }
                        );
                        break;
                    case  Upgrades.DamageRangeSpeed:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.AttributeTypeState",
                            Type = "AttributeTypeState",
                            Value = AttributeIconInstance.CurrentAttributeTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.Visible",
                            Type = "bool",
                            Value = AttributeIconInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance1.AttributeTypeState",
                            Type = "AttributeTypeState",
                            Value = AttributeIconInstance1.CurrentAttributeTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance1.Visible",
                            Type = "bool",
                            Value = AttributeIconInstance1.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance2.AttributeTypeState",
                            Type = "AttributeTypeState",
                            Value = AttributeIconInstance2.CurrentAttributeTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance2.Visible",
                            Type = "bool",
                            Value = AttributeIconInstance2.Visible
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (Upgrades state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  Upgrades.None:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.AttributeTypeState",
                            Type = "AttributeTypeState",
                            Value = AttributeIconInstance.CurrentAttributeTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.Visible",
                            Type = "bool",
                            Value = AttributeIconInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance1.AttributeTypeState",
                            Type = "AttributeTypeState",
                            Value = AttributeIconInstance1.CurrentAttributeTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance1.Visible",
                            Type = "bool",
                            Value = AttributeIconInstance1.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance2.AttributeTypeState",
                            Type = "AttributeTypeState",
                            Value = AttributeIconInstance2.CurrentAttributeTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance2.Visible",
                            Type = "bool",
                            Value = AttributeIconInstance2.Visible
                        }
                        );
                        break;
                    case  Upgrades.Range:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.AttributeTypeState",
                            Type = "AttributeTypeState",
                            Value = AttributeIconInstance.CurrentAttributeTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.Visible",
                            Type = "bool",
                            Value = AttributeIconInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance1.AttributeTypeState",
                            Type = "AttributeTypeState",
                            Value = AttributeIconInstance1.CurrentAttributeTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance1.Visible",
                            Type = "bool",
                            Value = AttributeIconInstance1.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance2.AttributeTypeState",
                            Type = "AttributeTypeState",
                            Value = AttributeIconInstance2.CurrentAttributeTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance2.Visible",
                            Type = "bool",
                            Value = AttributeIconInstance2.Visible
                        }
                        );
                        break;
                    case  Upgrades.Speed:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.AttributeTypeState",
                            Type = "AttributeTypeState",
                            Value = AttributeIconInstance.CurrentAttributeTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.Visible",
                            Type = "bool",
                            Value = AttributeIconInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance1.AttributeTypeState",
                            Type = "AttributeTypeState",
                            Value = AttributeIconInstance1.CurrentAttributeTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance1.Visible",
                            Type = "bool",
                            Value = AttributeIconInstance1.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance2.AttributeTypeState",
                            Type = "AttributeTypeState",
                            Value = AttributeIconInstance2.CurrentAttributeTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance2.Visible",
                            Type = "bool",
                            Value = AttributeIconInstance2.Visible
                        }
                        );
                        break;
                    case  Upgrades.RangeSpeed:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.AttributeTypeState",
                            Type = "AttributeTypeState",
                            Value = AttributeIconInstance.CurrentAttributeTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.Visible",
                            Type = "bool",
                            Value = AttributeIconInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance1.AttributeTypeState",
                            Type = "AttributeTypeState",
                            Value = AttributeIconInstance1.CurrentAttributeTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance1.Visible",
                            Type = "bool",
                            Value = AttributeIconInstance1.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance2.AttributeTypeState",
                            Type = "AttributeTypeState",
                            Value = AttributeIconInstance2.CurrentAttributeTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance2.Visible",
                            Type = "bool",
                            Value = AttributeIconInstance2.Visible
                        }
                        );
                        break;
                    case  Upgrades.RangeDamage:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.AttributeTypeState",
                            Type = "AttributeTypeState",
                            Value = AttributeIconInstance.CurrentAttributeTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.Visible",
                            Type = "bool",
                            Value = AttributeIconInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance1.AttributeTypeState",
                            Type = "AttributeTypeState",
                            Value = AttributeIconInstance1.CurrentAttributeTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance1.Visible",
                            Type = "bool",
                            Value = AttributeIconInstance1.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance2.AttributeTypeState",
                            Type = "AttributeTypeState",
                            Value = AttributeIconInstance2.CurrentAttributeTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance2.Visible",
                            Type = "bool",
                            Value = AttributeIconInstance2.Visible
                        }
                        );
                        break;
                    case  Upgrades.SpeedDamage:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.AttributeTypeState",
                            Type = "AttributeTypeState",
                            Value = AttributeIconInstance.CurrentAttributeTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.Visible",
                            Type = "bool",
                            Value = AttributeIconInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance1.AttributeTypeState",
                            Type = "AttributeTypeState",
                            Value = AttributeIconInstance1.CurrentAttributeTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance1.Visible",
                            Type = "bool",
                            Value = AttributeIconInstance1.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance2.AttributeTypeState",
                            Type = "AttributeTypeState",
                            Value = AttributeIconInstance2.CurrentAttributeTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance2.Visible",
                            Type = "bool",
                            Value = AttributeIconInstance2.Visible
                        }
                        );
                        break;
                    case  Upgrades.DamageRangeSpeed:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.AttributeTypeState",
                            Type = "AttributeTypeState",
                            Value = AttributeIconInstance.CurrentAttributeTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.Visible",
                            Type = "bool",
                            Value = AttributeIconInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance1.AttributeTypeState",
                            Type = "AttributeTypeState",
                            Value = AttributeIconInstance1.CurrentAttributeTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance1.Visible",
                            Type = "bool",
                            Value = AttributeIconInstance1.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance2.AttributeTypeState",
                            Type = "AttributeTypeState",
                            Value = AttributeIconInstance2.CurrentAttributeTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance2.Visible",
                            Type = "bool",
                            Value = AttributeIconInstance2.Visible
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
                    else if (category.Name == "Upgrades")
                    {
                        if(state.Name == "None") this.mCurrentUpgradesState = Upgrades.None;
                        if(state.Name == "Range") this.mCurrentUpgradesState = Upgrades.Range;
                        if(state.Name == "Speed") this.mCurrentUpgradesState = Upgrades.Speed;
                        if(state.Name == "RangeSpeed") this.mCurrentUpgradesState = Upgrades.RangeSpeed;
                        if(state.Name == "RangeDamage") this.mCurrentUpgradesState = Upgrades.RangeDamage;
                        if(state.Name == "SpeedDamage") this.mCurrentUpgradesState = Upgrades.SpeedDamage;
                        if(state.Name == "DamageRangeSpeed") this.mCurrentUpgradesState = Upgrades.DamageRangeSpeed;
                    }
                }
                base.ApplyState(state);
            }
            private AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime AttributeIconInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime AttributeIconInstance1 { get; set; }
            private AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime AttributeIconInstance2 { get; set; }
            public StructureUpgradeStatusRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                this.HasEvents = false;
                this.ExposeChildrenEvents = false;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "infodisplays/StructureUpgradeStatus");
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
                AttributeIconInstance = this.GetGraphicalUiElementByName("AttributeIconInstance") as AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime;
                AttributeIconInstance1 = this.GetGraphicalUiElementByName("AttributeIconInstance1") as AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime;
                AttributeIconInstance2 = this.GetGraphicalUiElementByName("AttributeIconInstance2") as AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime;
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
