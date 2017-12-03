    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes
    {
        public partial class InfoBarRuntime : AbbatoirIntergrade.GumRuntimes.ContainerRuntime
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            public enum SettingsButtonState
            {
                Highlighted,
                NotHighlighted
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            SettingsButtonState mCurrentSettingsButtonStateState;
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
                            ClipsChildren = false;
                            Height = 10f;
                            HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            Visible = true;
                            Width = 100f;
                            WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            WrapsChildren = false;
                            XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                            YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            ConditionsForecastInstance.Height = 165f;
                            ConditionsForecastInstance.Width = 40f;
                            MineralsDisplayInstance.Width = 12.5f;
                            MineralsDisplayInstance.X = -1.5f;
                            MineralsDisplayInstance.Y = 10f;
                            MineralsDisplayInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            EnergyDisplayInstance.Width = 33f;
                            EnergyDisplayInstance.X = 2.5f;
                            EnergyDisplayInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            SettingsButtonInstance.Height = 120f;
                            SettingsButtonInstance.Width = 6.0018f;
                            SettingsButtonInstance.X = 4f;
                            SettingsButtonInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            SettingsButtonInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            SettingsButtonInstance.Y = -15f;
                            SettingsButtonInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            break;
                    }
                }
            }
            public SettingsButtonState CurrentSettingsButtonStateState
            {
                get
                {
                    return mCurrentSettingsButtonStateState;
                }
                set
                {
                    mCurrentSettingsButtonStateState = value;
                    switch(mCurrentSettingsButtonStateState)
                    {
                        case  SettingsButtonState.Highlighted:
                            SettingsButtonInstance.CurrentHighlightState = AbbatoirIntergrade.GumRuntimes.SettingsButtonRuntime.Highlight.Highlighted;
                            break;
                        case  SettingsButtonState.NotHighlighted:
                            SettingsButtonInstance.CurrentHighlightState = AbbatoirIntergrade.GumRuntimes.SettingsButtonRuntime.Highlight.NotHighlighted;
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
                bool setConditionsForecastInstanceHeightFirstValue = false;
                bool setConditionsForecastInstanceHeightSecondValue = false;
                float ConditionsForecastInstanceHeightFirstValue= 0;
                float ConditionsForecastInstanceHeightSecondValue= 0;
                bool setConditionsForecastInstanceWidthFirstValue = false;
                bool setConditionsForecastInstanceWidthSecondValue = false;
                float ConditionsForecastInstanceWidthFirstValue= 0;
                float ConditionsForecastInstanceWidthSecondValue= 0;
                bool setEnergyDisplayInstanceWidthFirstValue = false;
                bool setEnergyDisplayInstanceWidthSecondValue = false;
                float EnergyDisplayInstanceWidthFirstValue= 0;
                float EnergyDisplayInstanceWidthSecondValue= 0;
                bool setEnergyDisplayInstanceXFirstValue = false;
                bool setEnergyDisplayInstanceXSecondValue = false;
                float EnergyDisplayInstanceXFirstValue= 0;
                float EnergyDisplayInstanceXSecondValue= 0;
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setMineralsDisplayInstanceWidthFirstValue = false;
                bool setMineralsDisplayInstanceWidthSecondValue = false;
                float MineralsDisplayInstanceWidthFirstValue= 0;
                float MineralsDisplayInstanceWidthSecondValue= 0;
                bool setMineralsDisplayInstanceXFirstValue = false;
                bool setMineralsDisplayInstanceXSecondValue = false;
                float MineralsDisplayInstanceXFirstValue= 0;
                float MineralsDisplayInstanceXSecondValue= 0;
                bool setMineralsDisplayInstanceYFirstValue = false;
                bool setMineralsDisplayInstanceYSecondValue = false;
                float MineralsDisplayInstanceYFirstValue= 0;
                float MineralsDisplayInstanceYSecondValue= 0;
                bool setSettingsButtonInstanceHeightFirstValue = false;
                bool setSettingsButtonInstanceHeightSecondValue = false;
                float SettingsButtonInstanceHeightFirstValue= 0;
                float SettingsButtonInstanceHeightSecondValue= 0;
                bool setSettingsButtonInstanceWidthFirstValue = false;
                bool setSettingsButtonInstanceWidthSecondValue = false;
                float SettingsButtonInstanceWidthFirstValue= 0;
                float SettingsButtonInstanceWidthSecondValue= 0;
                bool setSettingsButtonInstanceXFirstValue = false;
                bool setSettingsButtonInstanceXSecondValue = false;
                float SettingsButtonInstanceXFirstValue= 0;
                float SettingsButtonInstanceXSecondValue= 0;
                bool setSettingsButtonInstanceYFirstValue = false;
                bool setSettingsButtonInstanceYSecondValue = false;
                float SettingsButtonInstanceYFirstValue= 0;
                float SettingsButtonInstanceYSecondValue= 0;
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        if (interpolationValue < 1)
                        {
                            this.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ClipsChildren = false;
                        }
                        setConditionsForecastInstanceHeightFirstValue = true;
                        ConditionsForecastInstanceHeightFirstValue = 165f;
                        setConditionsForecastInstanceWidthFirstValue = true;
                        ConditionsForecastInstanceWidthFirstValue = 40f;
                        setEnergyDisplayInstanceWidthFirstValue = true;
                        EnergyDisplayInstanceWidthFirstValue = 33f;
                        setEnergyDisplayInstanceXFirstValue = true;
                        EnergyDisplayInstanceXFirstValue = 2.5f;
                        if (interpolationValue < 1)
                        {
                            this.EnergyDisplayInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setHeightFirstValue = true;
                        HeightFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setMineralsDisplayInstanceWidthFirstValue = true;
                        MineralsDisplayInstanceWidthFirstValue = 12.5f;
                        setMineralsDisplayInstanceXFirstValue = true;
                        MineralsDisplayInstanceXFirstValue = -1.5f;
                        setMineralsDisplayInstanceYFirstValue = true;
                        MineralsDisplayInstanceYFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.MineralsDisplayInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setSettingsButtonInstanceHeightFirstValue = true;
                        SettingsButtonInstanceHeightFirstValue = 120f;
                        setSettingsButtonInstanceWidthFirstValue = true;
                        SettingsButtonInstanceWidthFirstValue = 6.0018f;
                        setSettingsButtonInstanceXFirstValue = true;
                        SettingsButtonInstanceXFirstValue = 4f;
                        if (interpolationValue < 1)
                        {
                            this.SettingsButtonInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SettingsButtonInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setSettingsButtonInstanceYFirstValue = true;
                        SettingsButtonInstanceYFirstValue = -15f;
                        if (interpolationValue < 1)
                        {
                            this.SettingsButtonInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
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
                        if (interpolationValue < 1)
                        {
                            this.WrapsChildren = false;
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
                            this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue < 1)
                        {
                            this.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        if (interpolationValue >= 1)
                        {
                            this.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ClipsChildren = false;
                        }
                        setConditionsForecastInstanceHeightSecondValue = true;
                        ConditionsForecastInstanceHeightSecondValue = 165f;
                        setConditionsForecastInstanceWidthSecondValue = true;
                        ConditionsForecastInstanceWidthSecondValue = 40f;
                        setEnergyDisplayInstanceWidthSecondValue = true;
                        EnergyDisplayInstanceWidthSecondValue = 33f;
                        setEnergyDisplayInstanceXSecondValue = true;
                        EnergyDisplayInstanceXSecondValue = 2.5f;
                        if (interpolationValue >= 1)
                        {
                            this.EnergyDisplayInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setHeightSecondValue = true;
                        HeightSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setMineralsDisplayInstanceWidthSecondValue = true;
                        MineralsDisplayInstanceWidthSecondValue = 12.5f;
                        setMineralsDisplayInstanceXSecondValue = true;
                        MineralsDisplayInstanceXSecondValue = -1.5f;
                        setMineralsDisplayInstanceYSecondValue = true;
                        MineralsDisplayInstanceYSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.MineralsDisplayInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setSettingsButtonInstanceHeightSecondValue = true;
                        SettingsButtonInstanceHeightSecondValue = 120f;
                        setSettingsButtonInstanceWidthSecondValue = true;
                        SettingsButtonInstanceWidthSecondValue = 6.0018f;
                        setSettingsButtonInstanceXSecondValue = true;
                        SettingsButtonInstanceXSecondValue = 4f;
                        if (interpolationValue >= 1)
                        {
                            this.SettingsButtonInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SettingsButtonInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setSettingsButtonInstanceYSecondValue = true;
                        SettingsButtonInstanceYSecondValue = -15f;
                        if (interpolationValue >= 1)
                        {
                            this.SettingsButtonInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
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
                        if (interpolationValue >= 1)
                        {
                            this.WrapsChildren = false;
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
                            this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        break;
                }
                if (setConditionsForecastInstanceHeightFirstValue && setConditionsForecastInstanceHeightSecondValue)
                {
                    ConditionsForecastInstance.Height = ConditionsForecastInstanceHeightFirstValue * (1 - interpolationValue) + ConditionsForecastInstanceHeightSecondValue * interpolationValue;
                }
                if (setConditionsForecastInstanceWidthFirstValue && setConditionsForecastInstanceWidthSecondValue)
                {
                    ConditionsForecastInstance.Width = ConditionsForecastInstanceWidthFirstValue * (1 - interpolationValue) + ConditionsForecastInstanceWidthSecondValue * interpolationValue;
                }
                if (setEnergyDisplayInstanceWidthFirstValue && setEnergyDisplayInstanceWidthSecondValue)
                {
                    EnergyDisplayInstance.Width = EnergyDisplayInstanceWidthFirstValue * (1 - interpolationValue) + EnergyDisplayInstanceWidthSecondValue * interpolationValue;
                }
                if (setEnergyDisplayInstanceXFirstValue && setEnergyDisplayInstanceXSecondValue)
                {
                    EnergyDisplayInstance.X = EnergyDisplayInstanceXFirstValue * (1 - interpolationValue) + EnergyDisplayInstanceXSecondValue * interpolationValue;
                }
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
                }
                if (setMineralsDisplayInstanceWidthFirstValue && setMineralsDisplayInstanceWidthSecondValue)
                {
                    MineralsDisplayInstance.Width = MineralsDisplayInstanceWidthFirstValue * (1 - interpolationValue) + MineralsDisplayInstanceWidthSecondValue * interpolationValue;
                }
                if (setMineralsDisplayInstanceXFirstValue && setMineralsDisplayInstanceXSecondValue)
                {
                    MineralsDisplayInstance.X = MineralsDisplayInstanceXFirstValue * (1 - interpolationValue) + MineralsDisplayInstanceXSecondValue * interpolationValue;
                }
                if (setMineralsDisplayInstanceYFirstValue && setMineralsDisplayInstanceYSecondValue)
                {
                    MineralsDisplayInstance.Y = MineralsDisplayInstanceYFirstValue * (1 - interpolationValue) + MineralsDisplayInstanceYSecondValue * interpolationValue;
                }
                if (setSettingsButtonInstanceHeightFirstValue && setSettingsButtonInstanceHeightSecondValue)
                {
                    SettingsButtonInstance.Height = SettingsButtonInstanceHeightFirstValue * (1 - interpolationValue) + SettingsButtonInstanceHeightSecondValue * interpolationValue;
                }
                if (setSettingsButtonInstanceWidthFirstValue && setSettingsButtonInstanceWidthSecondValue)
                {
                    SettingsButtonInstance.Width = SettingsButtonInstanceWidthFirstValue * (1 - interpolationValue) + SettingsButtonInstanceWidthSecondValue * interpolationValue;
                }
                if (setSettingsButtonInstanceXFirstValue && setSettingsButtonInstanceXSecondValue)
                {
                    SettingsButtonInstance.X = SettingsButtonInstanceXFirstValue * (1 - interpolationValue) + SettingsButtonInstanceXSecondValue * interpolationValue;
                }
                if (setSettingsButtonInstanceYFirstValue && setSettingsButtonInstanceYSecondValue)
                {
                    SettingsButtonInstance.Y = SettingsButtonInstanceYFirstValue * (1 - interpolationValue) + SettingsButtonInstanceYSecondValue * interpolationValue;
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
            public void InterpolateBetween (SettingsButtonState firstState, SettingsButtonState secondState, float interpolationValue)
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setSettingsButtonInstanceCurrentHighlightStateFirstValue = false;
                bool setSettingsButtonInstanceCurrentHighlightStateSecondValue = false;
                SettingsButtonRuntime.Highlight SettingsButtonInstanceCurrentHighlightStateFirstValue= SettingsButtonRuntime.Highlight.Highlighted;
                SettingsButtonRuntime.Highlight SettingsButtonInstanceCurrentHighlightStateSecondValue= SettingsButtonRuntime.Highlight.Highlighted;
                switch(firstState)
                {
                    case  SettingsButtonState.Highlighted:
                        setSettingsButtonInstanceCurrentHighlightStateFirstValue = true;
                        SettingsButtonInstanceCurrentHighlightStateFirstValue = AbbatoirIntergrade.GumRuntimes.SettingsButtonRuntime.Highlight.Highlighted;
                        break;
                    case  SettingsButtonState.NotHighlighted:
                        setSettingsButtonInstanceCurrentHighlightStateFirstValue = true;
                        SettingsButtonInstanceCurrentHighlightStateFirstValue = AbbatoirIntergrade.GumRuntimes.SettingsButtonRuntime.Highlight.NotHighlighted;
                        break;
                }
                switch(secondState)
                {
                    case  SettingsButtonState.Highlighted:
                        setSettingsButtonInstanceCurrentHighlightStateSecondValue = true;
                        SettingsButtonInstanceCurrentHighlightStateSecondValue = AbbatoirIntergrade.GumRuntimes.SettingsButtonRuntime.Highlight.Highlighted;
                        break;
                    case  SettingsButtonState.NotHighlighted:
                        setSettingsButtonInstanceCurrentHighlightStateSecondValue = true;
                        SettingsButtonInstanceCurrentHighlightStateSecondValue = AbbatoirIntergrade.GumRuntimes.SettingsButtonRuntime.Highlight.NotHighlighted;
                        break;
                }
                if (setSettingsButtonInstanceCurrentHighlightStateFirstValue && setSettingsButtonInstanceCurrentHighlightStateSecondValue)
                {
                    SettingsButtonInstance.InterpolateBetween(SettingsButtonInstanceCurrentHighlightStateFirstValue, SettingsButtonInstanceCurrentHighlightStateSecondValue, interpolationValue);
                }
                if (interpolationValue < 1)
                {
                    mCurrentSettingsButtonStateState = firstState;
                }
                else
                {
                    mCurrentSettingsButtonStateState = secondState;
                }
            }
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.InfoBarRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.InfoBarRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null)
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.InfoBarRuntime.SettingsButtonState fromState,AbbatoirIntergrade.GumRuntimes.InfoBarRuntime.SettingsButtonState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null)
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (SettingsButtonState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null )
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "SettingsButtonState").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentSettingsButtonStateState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (SettingsButtonState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null )
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
                tweener.Ended += ()=> this.CurrentSettingsButtonStateState = toState;
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
                ConditionsForecastInstance.StopAnimations();
                MineralsDisplayInstance.StopAnimations();
                EnergyDisplayInstance.StopAnimations();
                SettingsButtonInstance.StopAnimations();
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
                            Name = "ConditionsForecastInstance.Height",
                            Type = "float",
                            Value = ConditionsForecastInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConditionsForecastInstance.Width",
                            Type = "float",
                            Value = ConditionsForecastInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsDisplayInstance.Width",
                            Type = "float",
                            Value = MineralsDisplayInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsDisplayInstance.X",
                            Type = "float",
                            Value = MineralsDisplayInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsDisplayInstance.Y",
                            Type = "float",
                            Value = MineralsDisplayInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsDisplayInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = MineralsDisplayInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyDisplayInstance.Width",
                            Type = "float",
                            Value = EnergyDisplayInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyDisplayInstance.X",
                            Type = "float",
                            Value = EnergyDisplayInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyDisplayInstance.X Units",
                            Type = "PositionUnitType",
                            Value = EnergyDisplayInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsButtonInstance.Height",
                            Type = "float",
                            Value = SettingsButtonInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsButtonInstance.Width",
                            Type = "float",
                            Value = SettingsButtonInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsButtonInstance.X",
                            Type = "float",
                            Value = SettingsButtonInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsButtonInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = SettingsButtonInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsButtonInstance.X Units",
                            Type = "PositionUnitType",
                            Value = SettingsButtonInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsButtonInstance.Y",
                            Type = "float",
                            Value = SettingsButtonInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsButtonInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = SettingsButtonInstance.YUnits
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
                            Value = Height + 10f
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
                            Name = "ConditionsForecastInstance.Height",
                            Type = "float",
                            Value = ConditionsForecastInstance.Height + 165f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConditionsForecastInstance.Width",
                            Type = "float",
                            Value = ConditionsForecastInstance.Width + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsDisplayInstance.Width",
                            Type = "float",
                            Value = MineralsDisplayInstance.Width + 12.5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsDisplayInstance.X",
                            Type = "float",
                            Value = MineralsDisplayInstance.X + -1.5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsDisplayInstance.Y",
                            Type = "float",
                            Value = MineralsDisplayInstance.Y + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsDisplayInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = MineralsDisplayInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyDisplayInstance.Width",
                            Type = "float",
                            Value = EnergyDisplayInstance.Width + 33f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyDisplayInstance.X",
                            Type = "float",
                            Value = EnergyDisplayInstance.X + 2.5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnergyDisplayInstance.X Units",
                            Type = "PositionUnitType",
                            Value = EnergyDisplayInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsButtonInstance.Height",
                            Type = "float",
                            Value = SettingsButtonInstance.Height + 120f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsButtonInstance.Width",
                            Type = "float",
                            Value = SettingsButtonInstance.Width + 6.0018f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsButtonInstance.X",
                            Type = "float",
                            Value = SettingsButtonInstance.X + 4f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsButtonInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = SettingsButtonInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsButtonInstance.X Units",
                            Type = "PositionUnitType",
                            Value = SettingsButtonInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsButtonInstance.Y",
                            Type = "float",
                            Value = SettingsButtonInstance.Y + -15f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsButtonInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = SettingsButtonInstance.YUnits
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (SettingsButtonState state)
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  SettingsButtonState.Highlighted:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsButtonInstance.HighlightState",
                            Type = "HighlightState",
                            Value = SettingsButtonInstance.CurrentHighlightState
                        }
                        );
                        break;
                    case  SettingsButtonState.NotHighlighted:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsButtonInstance.HighlightState",
                            Type = "HighlightState",
                            Value = SettingsButtonInstance.CurrentHighlightState
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (SettingsButtonState state)
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  SettingsButtonState.Highlighted:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsButtonInstance.HighlightState",
                            Type = "HighlightState",
                            Value = SettingsButtonInstance.CurrentHighlightState
                        }
                        );
                        break;
                    case  SettingsButtonState.NotHighlighted:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SettingsButtonInstance.HighlightState",
                            Type = "HighlightState",
                            Value = SettingsButtonInstance.CurrentHighlightState
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
                    else if (category.Name == "SettingsButtonState")
                    {
                        if(state.Name == "Highlighted") this.mCurrentSettingsButtonStateState = SettingsButtonState.Highlighted;
                        if(state.Name == "NotHighlighted") this.mCurrentSettingsButtonStateState = SettingsButtonState.NotHighlighted;
                    }
                }
                base.ApplyState(state);
            }
            private AbbatoirIntergrade.GumRuntimes.ConditionsForecastRuntime ConditionsForecastInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.MineralsDisplayRuntime MineralsDisplayInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.EnergyDisplayRuntime EnergyDisplayInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SettingsButtonRuntime SettingsButtonInstance { get; set; }
            public event FlatRedBall.Gui.WindowEvent SettingsButtonInstanceClick;
            public InfoBarRuntime (bool fullInstantiation = true)
            	: base(false)
            {
                this.HasEvents = false;
                this.ExposeChildrenEvents = true;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "InfoBar");
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
                ConditionsForecastInstance = this.GetGraphicalUiElementByName("ConditionsForecastInstance") as AbbatoirIntergrade.GumRuntimes.ConditionsForecastRuntime;
                MineralsDisplayInstance = this.GetGraphicalUiElementByName("MineralsDisplayInstance") as AbbatoirIntergrade.GumRuntimes.MineralsDisplayRuntime;
                EnergyDisplayInstance = this.GetGraphicalUiElementByName("EnergyDisplayInstance") as AbbatoirIntergrade.GumRuntimes.EnergyDisplayRuntime;
                SettingsButtonInstance = this.GetGraphicalUiElementByName("SettingsButtonInstance") as AbbatoirIntergrade.GumRuntimes.SettingsButtonRuntime;
                SettingsButtonInstance.Click += (unused) => SettingsButtonInstanceClick?.Invoke(this);
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
