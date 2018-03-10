    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes
    {
        public partial class TowerSelectionBoxRuntime : AbbatoirIntergrade.GumRuntimes.ContainerRuntime
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
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
                            Height = 100f;
                            HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            Width = 100f;
                            WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            LargeInfoFrameInstance.Height = 75f;
                            LargeInfoFrameInstance.Width = 75f;
                            LargeInfoFrameInstance.X = 0f;
                            LargeInfoFrameInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            LargeInfoFrameInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            LargeInfoFrameInstance.Y = 0f;
                            LargeInfoFrameInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            LargeInfoFrameInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            StructureInfoInstance.CurrentUpgradeAvailabilityState = AbbatoirIntergrade.GumRuntimes.StructureInfoRuntime.UpgradeAvailability.NotAvailable;
                            StructureInfoInstance.X = -487f;
                            StructureInfoInstance.Y = -109.6031f;
                            StructureInfoInstance1.CurrentUpgradeAvailabilityState = AbbatoirIntergrade.GumRuntimes.StructureInfoRuntime.UpgradeAvailability.NotAvailable;
                            StructureInfoInstance1.X = 480f;
                            StructureInfoInstance1.Y = -115.8889f;
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
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setLargeInfoFrameInstanceHeightFirstValue = false;
                bool setLargeInfoFrameInstanceHeightSecondValue = false;
                float LargeInfoFrameInstanceHeightFirstValue= 0;
                float LargeInfoFrameInstanceHeightSecondValue= 0;
                bool setLargeInfoFrameInstanceWidthFirstValue = false;
                bool setLargeInfoFrameInstanceWidthSecondValue = false;
                float LargeInfoFrameInstanceWidthFirstValue= 0;
                float LargeInfoFrameInstanceWidthSecondValue= 0;
                bool setLargeInfoFrameInstanceXFirstValue = false;
                bool setLargeInfoFrameInstanceXSecondValue = false;
                float LargeInfoFrameInstanceXFirstValue= 0;
                float LargeInfoFrameInstanceXSecondValue= 0;
                bool setLargeInfoFrameInstanceYFirstValue = false;
                bool setLargeInfoFrameInstanceYSecondValue = false;
                float LargeInfoFrameInstanceYFirstValue= 0;
                float LargeInfoFrameInstanceYSecondValue= 0;
                bool setStructureInfoInstanceCurrentUpgradeAvailabilityStateFirstValue = false;
                bool setStructureInfoInstanceCurrentUpgradeAvailabilityStateSecondValue = false;
                StructureInfoRuntime.UpgradeAvailability StructureInfoInstanceCurrentUpgradeAvailabilityStateFirstValue= StructureInfoRuntime.UpgradeAvailability.Available;
                StructureInfoRuntime.UpgradeAvailability StructureInfoInstanceCurrentUpgradeAvailabilityStateSecondValue= StructureInfoRuntime.UpgradeAvailability.Available;
                bool setStructureInfoInstanceXFirstValue = false;
                bool setStructureInfoInstanceXSecondValue = false;
                float StructureInfoInstanceXFirstValue= 0;
                float StructureInfoInstanceXSecondValue= 0;
                bool setStructureInfoInstanceYFirstValue = false;
                bool setStructureInfoInstanceYSecondValue = false;
                float StructureInfoInstanceYFirstValue= 0;
                float StructureInfoInstanceYSecondValue= 0;
                bool setStructureInfoInstance1CurrentUpgradeAvailabilityStateFirstValue = false;
                bool setStructureInfoInstance1CurrentUpgradeAvailabilityStateSecondValue = false;
                StructureInfoRuntime.UpgradeAvailability StructureInfoInstance1CurrentUpgradeAvailabilityStateFirstValue= StructureInfoRuntime.UpgradeAvailability.Available;
                StructureInfoRuntime.UpgradeAvailability StructureInfoInstance1CurrentUpgradeAvailabilityStateSecondValue= StructureInfoRuntime.UpgradeAvailability.Available;
                bool setStructureInfoInstance1XFirstValue = false;
                bool setStructureInfoInstance1XSecondValue = false;
                float StructureInfoInstance1XFirstValue= 0;
                float StructureInfoInstance1XSecondValue= 0;
                bool setStructureInfoInstance1YFirstValue = false;
                bool setStructureInfoInstance1YSecondValue = false;
                float StructureInfoInstance1YFirstValue= 0;
                float StructureInfoInstance1YSecondValue= 0;
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setHeightFirstValue = true;
                        HeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setLargeInfoFrameInstanceHeightFirstValue = true;
                        LargeInfoFrameInstanceHeightFirstValue = 75f;
                        setLargeInfoFrameInstanceWidthFirstValue = true;
                        LargeInfoFrameInstanceWidthFirstValue = 75f;
                        setLargeInfoFrameInstanceXFirstValue = true;
                        LargeInfoFrameInstanceXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.LargeInfoFrameInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.LargeInfoFrameInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setLargeInfoFrameInstanceYFirstValue = true;
                        LargeInfoFrameInstanceYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.LargeInfoFrameInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.LargeInfoFrameInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setStructureInfoInstanceCurrentUpgradeAvailabilityStateFirstValue = true;
                        StructureInfoInstanceCurrentUpgradeAvailabilityStateFirstValue = AbbatoirIntergrade.GumRuntimes.StructureInfoRuntime.UpgradeAvailability.NotAvailable;
                        setStructureInfoInstanceXFirstValue = true;
                        StructureInfoInstanceXFirstValue = -487f;
                        setStructureInfoInstanceYFirstValue = true;
                        StructureInfoInstanceYFirstValue = -109.6031f;
                        setStructureInfoInstance1CurrentUpgradeAvailabilityStateFirstValue = true;
                        StructureInfoInstance1CurrentUpgradeAvailabilityStateFirstValue = AbbatoirIntergrade.GumRuntimes.StructureInfoRuntime.UpgradeAvailability.NotAvailable;
                        setStructureInfoInstance1XFirstValue = true;
                        StructureInfoInstance1XFirstValue = 480f;
                        setStructureInfoInstance1YFirstValue = true;
                        StructureInfoInstance1YFirstValue = -115.8889f;
                        setWidthFirstValue = true;
                        WidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setHeightSecondValue = true;
                        HeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setLargeInfoFrameInstanceHeightSecondValue = true;
                        LargeInfoFrameInstanceHeightSecondValue = 75f;
                        setLargeInfoFrameInstanceWidthSecondValue = true;
                        LargeInfoFrameInstanceWidthSecondValue = 75f;
                        setLargeInfoFrameInstanceXSecondValue = true;
                        LargeInfoFrameInstanceXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.LargeInfoFrameInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.LargeInfoFrameInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setLargeInfoFrameInstanceYSecondValue = true;
                        LargeInfoFrameInstanceYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.LargeInfoFrameInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.LargeInfoFrameInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setStructureInfoInstanceCurrentUpgradeAvailabilityStateSecondValue = true;
                        StructureInfoInstanceCurrentUpgradeAvailabilityStateSecondValue = AbbatoirIntergrade.GumRuntimes.StructureInfoRuntime.UpgradeAvailability.NotAvailable;
                        setStructureInfoInstanceXSecondValue = true;
                        StructureInfoInstanceXSecondValue = -487f;
                        setStructureInfoInstanceYSecondValue = true;
                        StructureInfoInstanceYSecondValue = -109.6031f;
                        setStructureInfoInstance1CurrentUpgradeAvailabilityStateSecondValue = true;
                        StructureInfoInstance1CurrentUpgradeAvailabilityStateSecondValue = AbbatoirIntergrade.GumRuntimes.StructureInfoRuntime.UpgradeAvailability.NotAvailable;
                        setStructureInfoInstance1XSecondValue = true;
                        StructureInfoInstance1XSecondValue = 480f;
                        setStructureInfoInstance1YSecondValue = true;
                        StructureInfoInstance1YSecondValue = -115.8889f;
                        setWidthSecondValue = true;
                        WidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        break;
                }
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
                }
                if (setLargeInfoFrameInstanceHeightFirstValue && setLargeInfoFrameInstanceHeightSecondValue)
                {
                    LargeInfoFrameInstance.Height = LargeInfoFrameInstanceHeightFirstValue * (1 - interpolationValue) + LargeInfoFrameInstanceHeightSecondValue * interpolationValue;
                }
                if (setLargeInfoFrameInstanceWidthFirstValue && setLargeInfoFrameInstanceWidthSecondValue)
                {
                    LargeInfoFrameInstance.Width = LargeInfoFrameInstanceWidthFirstValue * (1 - interpolationValue) + LargeInfoFrameInstanceWidthSecondValue * interpolationValue;
                }
                if (setLargeInfoFrameInstanceXFirstValue && setLargeInfoFrameInstanceXSecondValue)
                {
                    LargeInfoFrameInstance.X = LargeInfoFrameInstanceXFirstValue * (1 - interpolationValue) + LargeInfoFrameInstanceXSecondValue * interpolationValue;
                }
                if (setLargeInfoFrameInstanceYFirstValue && setLargeInfoFrameInstanceYSecondValue)
                {
                    LargeInfoFrameInstance.Y = LargeInfoFrameInstanceYFirstValue * (1 - interpolationValue) + LargeInfoFrameInstanceYSecondValue * interpolationValue;
                }
                if (setStructureInfoInstanceCurrentUpgradeAvailabilityStateFirstValue && setStructureInfoInstanceCurrentUpgradeAvailabilityStateSecondValue)
                {
                    StructureInfoInstance.InterpolateBetween(StructureInfoInstanceCurrentUpgradeAvailabilityStateFirstValue, StructureInfoInstanceCurrentUpgradeAvailabilityStateSecondValue, interpolationValue);
                }
                if (setStructureInfoInstanceXFirstValue && setStructureInfoInstanceXSecondValue)
                {
                    StructureInfoInstance.X = StructureInfoInstanceXFirstValue * (1 - interpolationValue) + StructureInfoInstanceXSecondValue * interpolationValue;
                }
                if (setStructureInfoInstanceYFirstValue && setStructureInfoInstanceYSecondValue)
                {
                    StructureInfoInstance.Y = StructureInfoInstanceYFirstValue * (1 - interpolationValue) + StructureInfoInstanceYSecondValue * interpolationValue;
                }
                if (setStructureInfoInstance1CurrentUpgradeAvailabilityStateFirstValue && setStructureInfoInstance1CurrentUpgradeAvailabilityStateSecondValue)
                {
                    StructureInfoInstance1.InterpolateBetween(StructureInfoInstance1CurrentUpgradeAvailabilityStateFirstValue, StructureInfoInstance1CurrentUpgradeAvailabilityStateSecondValue, interpolationValue);
                }
                if (setStructureInfoInstance1XFirstValue && setStructureInfoInstance1XSecondValue)
                {
                    StructureInfoInstance1.X = StructureInfoInstance1XFirstValue * (1 - interpolationValue) + StructureInfoInstance1XSecondValue * interpolationValue;
                }
                if (setStructureInfoInstance1YFirstValue && setStructureInfoInstance1YSecondValue)
                {
                    StructureInfoInstance1.Y = StructureInfoInstance1YFirstValue * (1 - interpolationValue) + StructureInfoInstance1YSecondValue * interpolationValue;
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
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.TowerSelectionBoxRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.TowerSelectionBoxRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            #endregion
            #region State Animations
            #endregion
            public override void StopAnimations () 
            {
                base.StopAnimations();
                LargeInfoFrameInstance.StopAnimations();
                StructureInfoInstance.StopAnimations();
                StructureInfoInstance1.StopAnimations();
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
                            Name = "LargeInfoFrameInstance.Height",
                            Type = "float",
                            Value = LargeInfoFrameInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LargeInfoFrameInstance.Width",
                            Type = "float",
                            Value = LargeInfoFrameInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LargeInfoFrameInstance.X",
                            Type = "float",
                            Value = LargeInfoFrameInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LargeInfoFrameInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = LargeInfoFrameInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LargeInfoFrameInstance.X Units",
                            Type = "PositionUnitType",
                            Value = LargeInfoFrameInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LargeInfoFrameInstance.Y",
                            Type = "float",
                            Value = LargeInfoFrameInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LargeInfoFrameInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = LargeInfoFrameInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LargeInfoFrameInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = LargeInfoFrameInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureInfoInstance.UpgradeAvailabilityState",
                            Type = "UpgradeAvailabilityState",
                            Value = StructureInfoInstance.CurrentUpgradeAvailabilityState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureInfoInstance.X",
                            Type = "float",
                            Value = StructureInfoInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureInfoInstance.Y",
                            Type = "float",
                            Value = StructureInfoInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureInfoInstance1.UpgradeAvailabilityState",
                            Type = "UpgradeAvailabilityState",
                            Value = StructureInfoInstance1.CurrentUpgradeAvailabilityState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureInfoInstance1.X",
                            Type = "float",
                            Value = StructureInfoInstance1.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureInfoInstance1.Y",
                            Type = "float",
                            Value = StructureInfoInstance1.Y
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
                            Name = "Height",
                            Type = "float",
                            Value = Height + 100f
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
                            Name = "LargeInfoFrameInstance.Height",
                            Type = "float",
                            Value = LargeInfoFrameInstance.Height + 75f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LargeInfoFrameInstance.Width",
                            Type = "float",
                            Value = LargeInfoFrameInstance.Width + 75f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LargeInfoFrameInstance.X",
                            Type = "float",
                            Value = LargeInfoFrameInstance.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LargeInfoFrameInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = LargeInfoFrameInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LargeInfoFrameInstance.X Units",
                            Type = "PositionUnitType",
                            Value = LargeInfoFrameInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LargeInfoFrameInstance.Y",
                            Type = "float",
                            Value = LargeInfoFrameInstance.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LargeInfoFrameInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = LargeInfoFrameInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LargeInfoFrameInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = LargeInfoFrameInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureInfoInstance.UpgradeAvailabilityState",
                            Type = "UpgradeAvailabilityState",
                            Value = StructureInfoInstance.CurrentUpgradeAvailabilityState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureInfoInstance.X",
                            Type = "float",
                            Value = StructureInfoInstance.X + -487f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureInfoInstance.Y",
                            Type = "float",
                            Value = StructureInfoInstance.Y + -109.6031f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureInfoInstance1.UpgradeAvailabilityState",
                            Type = "UpgradeAvailabilityState",
                            Value = StructureInfoInstance1.CurrentUpgradeAvailabilityState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureInfoInstance1.X",
                            Type = "float",
                            Value = StructureInfoInstance1.X + 480f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureInfoInstance1.Y",
                            Type = "float",
                            Value = StructureInfoInstance1.Y + -115.8889f
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
                }
                base.ApplyState(state);
            }
            private AbbatoirIntergrade.GumRuntimes.LargeInfoFrameRuntime LargeInfoFrameInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.StructureInfoRuntime StructureInfoInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.StructureInfoRuntime StructureInfoInstance1 { get; set; }
            public TowerSelectionBoxRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "TowerSelectionBox");
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
                LargeInfoFrameInstance = this.GetGraphicalUiElementByName("LargeInfoFrameInstance") as AbbatoirIntergrade.GumRuntimes.LargeInfoFrameRuntime;
                StructureInfoInstance = this.GetGraphicalUiElementByName("StructureInfoInstance") as AbbatoirIntergrade.GumRuntimes.StructureInfoRuntime;
                StructureInfoInstance1 = this.GetGraphicalUiElementByName("StructureInfoInstance1") as AbbatoirIntergrade.GumRuntimes.StructureInfoRuntime;
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
