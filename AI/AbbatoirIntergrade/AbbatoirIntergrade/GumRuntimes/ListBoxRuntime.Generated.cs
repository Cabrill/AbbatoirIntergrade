    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes
    {
        public partial class ListBoxRuntime : AbbatoirIntergrade.GumRuntimes.ContainerRuntime
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
                            ColoredRectangleInstance.Blue = 0;
                            ColoredRectangleInstance.Green = 0;
                            ColoredRectangleInstance.Height = 100f;
                            ColoredRectangleInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ColoredRectangleInstance.Red = 0;
                            ColoredRectangleInstance.Width = 100f;
                            ColoredRectangleInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            VerticalScrollBarInstance.Height = 100f;
                            VerticalScrollBarInstance.Width = 8f;
                            VerticalScrollBarInstance.X = 0f;
                            VerticalScrollBarInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            VerticalScrollBarInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            VerticalScrollBarInstance.Y = 0f;
                            VerticalScrollBarInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            ClipContainerInstance.ClipsChildren = true;
                            ClipContainerInstance.Height = -4f;
                            ClipContainerInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            ClipContainerInstance.Width = 90f;
                            ClipContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ClipContainerInstance.X = 2f;
                            ClipContainerInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            ClipContainerInstance.Y = 2f;
                            ClipContainerInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            InnerPanelInstance.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                            InnerPanelInstance.Height = 0f;
                            InnerPanelInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            InnerPanelInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ClipContainerInstance") ?? this;
                            InnerPanelInstance.Width = 0f;
                            InnerPanelInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
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
                bool setClipContainerInstanceHeightFirstValue = false;
                bool setClipContainerInstanceHeightSecondValue = false;
                float ClipContainerInstanceHeightFirstValue= 0;
                float ClipContainerInstanceHeightSecondValue= 0;
                bool setClipContainerInstanceWidthFirstValue = false;
                bool setClipContainerInstanceWidthSecondValue = false;
                float ClipContainerInstanceWidthFirstValue= 0;
                float ClipContainerInstanceWidthSecondValue= 0;
                bool setClipContainerInstanceXFirstValue = false;
                bool setClipContainerInstanceXSecondValue = false;
                float ClipContainerInstanceXFirstValue= 0;
                float ClipContainerInstanceXSecondValue= 0;
                bool setClipContainerInstanceYFirstValue = false;
                bool setClipContainerInstanceYSecondValue = false;
                float ClipContainerInstanceYFirstValue= 0;
                float ClipContainerInstanceYSecondValue= 0;
                bool setColoredRectangleInstanceBlueFirstValue = false;
                bool setColoredRectangleInstanceBlueSecondValue = false;
                int ColoredRectangleInstanceBlueFirstValue= 0;
                int ColoredRectangleInstanceBlueSecondValue= 0;
                bool setColoredRectangleInstanceGreenFirstValue = false;
                bool setColoredRectangleInstanceGreenSecondValue = false;
                int ColoredRectangleInstanceGreenFirstValue= 0;
                int ColoredRectangleInstanceGreenSecondValue= 0;
                bool setColoredRectangleInstanceHeightFirstValue = false;
                bool setColoredRectangleInstanceHeightSecondValue = false;
                float ColoredRectangleInstanceHeightFirstValue= 0;
                float ColoredRectangleInstanceHeightSecondValue= 0;
                bool setColoredRectangleInstanceRedFirstValue = false;
                bool setColoredRectangleInstanceRedSecondValue = false;
                int ColoredRectangleInstanceRedFirstValue= 0;
                int ColoredRectangleInstanceRedSecondValue= 0;
                bool setColoredRectangleInstanceWidthFirstValue = false;
                bool setColoredRectangleInstanceWidthSecondValue = false;
                float ColoredRectangleInstanceWidthFirstValue= 0;
                float ColoredRectangleInstanceWidthSecondValue= 0;
                bool setInnerPanelInstanceHeightFirstValue = false;
                bool setInnerPanelInstanceHeightSecondValue = false;
                float InnerPanelInstanceHeightFirstValue= 0;
                float InnerPanelInstanceHeightSecondValue= 0;
                bool setInnerPanelInstanceWidthFirstValue = false;
                bool setInnerPanelInstanceWidthSecondValue = false;
                float InnerPanelInstanceWidthFirstValue= 0;
                float InnerPanelInstanceWidthSecondValue= 0;
                bool setVerticalScrollBarInstanceHeightFirstValue = false;
                bool setVerticalScrollBarInstanceHeightSecondValue = false;
                float VerticalScrollBarInstanceHeightFirstValue= 0;
                float VerticalScrollBarInstanceHeightSecondValue= 0;
                bool setVerticalScrollBarInstanceWidthFirstValue = false;
                bool setVerticalScrollBarInstanceWidthSecondValue = false;
                float VerticalScrollBarInstanceWidthFirstValue= 0;
                float VerticalScrollBarInstanceWidthSecondValue= 0;
                bool setVerticalScrollBarInstanceXFirstValue = false;
                bool setVerticalScrollBarInstanceXSecondValue = false;
                float VerticalScrollBarInstanceXFirstValue= 0;
                float VerticalScrollBarInstanceXSecondValue= 0;
                bool setVerticalScrollBarInstanceYFirstValue = false;
                bool setVerticalScrollBarInstanceYSecondValue = false;
                float VerticalScrollBarInstanceYFirstValue= 0;
                float VerticalScrollBarInstanceYSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        if (interpolationValue < 1)
                        {
                            this.ClipContainerInstance.ClipsChildren = true;
                        }
                        setClipContainerInstanceHeightFirstValue = true;
                        ClipContainerInstanceHeightFirstValue = -4f;
                        if (interpolationValue < 1)
                        {
                            this.ClipContainerInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setClipContainerInstanceWidthFirstValue = true;
                        ClipContainerInstanceWidthFirstValue = 90f;
                        if (interpolationValue < 1)
                        {
                            this.ClipContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setClipContainerInstanceXFirstValue = true;
                        ClipContainerInstanceXFirstValue = 2f;
                        if (interpolationValue < 1)
                        {
                            this.ClipContainerInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setClipContainerInstanceYFirstValue = true;
                        ClipContainerInstanceYFirstValue = 2f;
                        if (interpolationValue < 1)
                        {
                            this.ClipContainerInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setColoredRectangleInstanceBlueFirstValue = true;
                        ColoredRectangleInstanceBlueFirstValue = 0;
                        setColoredRectangleInstanceGreenFirstValue = true;
                        ColoredRectangleInstanceGreenFirstValue = 0;
                        setColoredRectangleInstanceHeightFirstValue = true;
                        ColoredRectangleInstanceHeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setColoredRectangleInstanceRedFirstValue = true;
                        ColoredRectangleInstanceRedFirstValue = 0;
                        setColoredRectangleInstanceWidthFirstValue = true;
                        ColoredRectangleInstanceWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.InnerPanelInstance.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setInnerPanelInstanceHeightFirstValue = true;
                        InnerPanelInstanceHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.InnerPanelInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.InnerPanelInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ClipContainerInstance") ?? this;
                        }
                        setInnerPanelInstanceWidthFirstValue = true;
                        InnerPanelInstanceWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.InnerPanelInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setVerticalScrollBarInstanceHeightFirstValue = true;
                        VerticalScrollBarInstanceHeightFirstValue = 100f;
                        setVerticalScrollBarInstanceWidthFirstValue = true;
                        VerticalScrollBarInstanceWidthFirstValue = 8f;
                        setVerticalScrollBarInstanceXFirstValue = true;
                        VerticalScrollBarInstanceXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.VerticalScrollBarInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.VerticalScrollBarInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setVerticalScrollBarInstanceYFirstValue = true;
                        VerticalScrollBarInstanceYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.VerticalScrollBarInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        if (interpolationValue >= 1)
                        {
                            this.ClipContainerInstance.ClipsChildren = true;
                        }
                        setClipContainerInstanceHeightSecondValue = true;
                        ClipContainerInstanceHeightSecondValue = -4f;
                        if (interpolationValue >= 1)
                        {
                            this.ClipContainerInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setClipContainerInstanceWidthSecondValue = true;
                        ClipContainerInstanceWidthSecondValue = 90f;
                        if (interpolationValue >= 1)
                        {
                            this.ClipContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setClipContainerInstanceXSecondValue = true;
                        ClipContainerInstanceXSecondValue = 2f;
                        if (interpolationValue >= 1)
                        {
                            this.ClipContainerInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setClipContainerInstanceYSecondValue = true;
                        ClipContainerInstanceYSecondValue = 2f;
                        if (interpolationValue >= 1)
                        {
                            this.ClipContainerInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setColoredRectangleInstanceBlueSecondValue = true;
                        ColoredRectangleInstanceBlueSecondValue = 0;
                        setColoredRectangleInstanceGreenSecondValue = true;
                        ColoredRectangleInstanceGreenSecondValue = 0;
                        setColoredRectangleInstanceHeightSecondValue = true;
                        ColoredRectangleInstanceHeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setColoredRectangleInstanceRedSecondValue = true;
                        ColoredRectangleInstanceRedSecondValue = 0;
                        setColoredRectangleInstanceWidthSecondValue = true;
                        ColoredRectangleInstanceWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.InnerPanelInstance.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setInnerPanelInstanceHeightSecondValue = true;
                        InnerPanelInstanceHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.InnerPanelInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.InnerPanelInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ClipContainerInstance") ?? this;
                        }
                        setInnerPanelInstanceWidthSecondValue = true;
                        InnerPanelInstanceWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.InnerPanelInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setVerticalScrollBarInstanceHeightSecondValue = true;
                        VerticalScrollBarInstanceHeightSecondValue = 100f;
                        setVerticalScrollBarInstanceWidthSecondValue = true;
                        VerticalScrollBarInstanceWidthSecondValue = 8f;
                        setVerticalScrollBarInstanceXSecondValue = true;
                        VerticalScrollBarInstanceXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.VerticalScrollBarInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.VerticalScrollBarInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setVerticalScrollBarInstanceYSecondValue = true;
                        VerticalScrollBarInstanceYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.VerticalScrollBarInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        break;
                }
                if (setClipContainerInstanceHeightFirstValue && setClipContainerInstanceHeightSecondValue)
                {
                    ClipContainerInstance.Height = ClipContainerInstanceHeightFirstValue * (1 - interpolationValue) + ClipContainerInstanceHeightSecondValue * interpolationValue;
                }
                if (setClipContainerInstanceWidthFirstValue && setClipContainerInstanceWidthSecondValue)
                {
                    ClipContainerInstance.Width = ClipContainerInstanceWidthFirstValue * (1 - interpolationValue) + ClipContainerInstanceWidthSecondValue * interpolationValue;
                }
                if (setClipContainerInstanceXFirstValue && setClipContainerInstanceXSecondValue)
                {
                    ClipContainerInstance.X = ClipContainerInstanceXFirstValue * (1 - interpolationValue) + ClipContainerInstanceXSecondValue * interpolationValue;
                }
                if (setClipContainerInstanceYFirstValue && setClipContainerInstanceYSecondValue)
                {
                    ClipContainerInstance.Y = ClipContainerInstanceYFirstValue * (1 - interpolationValue) + ClipContainerInstanceYSecondValue * interpolationValue;
                }
                if (setColoredRectangleInstanceBlueFirstValue && setColoredRectangleInstanceBlueSecondValue)
                {
                    ColoredRectangleInstance.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(ColoredRectangleInstanceBlueFirstValue* (1 - interpolationValue) + ColoredRectangleInstanceBlueSecondValue * interpolationValue);
                }
                if (setColoredRectangleInstanceGreenFirstValue && setColoredRectangleInstanceGreenSecondValue)
                {
                    ColoredRectangleInstance.Green = FlatRedBall.Math.MathFunctions.RoundToInt(ColoredRectangleInstanceGreenFirstValue* (1 - interpolationValue) + ColoredRectangleInstanceGreenSecondValue * interpolationValue);
                }
                if (setColoredRectangleInstanceHeightFirstValue && setColoredRectangleInstanceHeightSecondValue)
                {
                    ColoredRectangleInstance.Height = ColoredRectangleInstanceHeightFirstValue * (1 - interpolationValue) + ColoredRectangleInstanceHeightSecondValue * interpolationValue;
                }
                if (setColoredRectangleInstanceRedFirstValue && setColoredRectangleInstanceRedSecondValue)
                {
                    ColoredRectangleInstance.Red = FlatRedBall.Math.MathFunctions.RoundToInt(ColoredRectangleInstanceRedFirstValue* (1 - interpolationValue) + ColoredRectangleInstanceRedSecondValue * interpolationValue);
                }
                if (setColoredRectangleInstanceWidthFirstValue && setColoredRectangleInstanceWidthSecondValue)
                {
                    ColoredRectangleInstance.Width = ColoredRectangleInstanceWidthFirstValue * (1 - interpolationValue) + ColoredRectangleInstanceWidthSecondValue * interpolationValue;
                }
                if (setInnerPanelInstanceHeightFirstValue && setInnerPanelInstanceHeightSecondValue)
                {
                    InnerPanelInstance.Height = InnerPanelInstanceHeightFirstValue * (1 - interpolationValue) + InnerPanelInstanceHeightSecondValue * interpolationValue;
                }
                if (setInnerPanelInstanceWidthFirstValue && setInnerPanelInstanceWidthSecondValue)
                {
                    InnerPanelInstance.Width = InnerPanelInstanceWidthFirstValue * (1 - interpolationValue) + InnerPanelInstanceWidthSecondValue * interpolationValue;
                }
                if (setVerticalScrollBarInstanceHeightFirstValue && setVerticalScrollBarInstanceHeightSecondValue)
                {
                    VerticalScrollBarInstance.Height = VerticalScrollBarInstanceHeightFirstValue * (1 - interpolationValue) + VerticalScrollBarInstanceHeightSecondValue * interpolationValue;
                }
                if (setVerticalScrollBarInstanceWidthFirstValue && setVerticalScrollBarInstanceWidthSecondValue)
                {
                    VerticalScrollBarInstance.Width = VerticalScrollBarInstanceWidthFirstValue * (1 - interpolationValue) + VerticalScrollBarInstanceWidthSecondValue * interpolationValue;
                }
                if (setVerticalScrollBarInstanceXFirstValue && setVerticalScrollBarInstanceXSecondValue)
                {
                    VerticalScrollBarInstance.X = VerticalScrollBarInstanceXFirstValue * (1 - interpolationValue) + VerticalScrollBarInstanceXSecondValue * interpolationValue;
                }
                if (setVerticalScrollBarInstanceYFirstValue && setVerticalScrollBarInstanceYSecondValue)
                {
                    VerticalScrollBarInstance.Y = VerticalScrollBarInstanceYFirstValue * (1 - interpolationValue) + VerticalScrollBarInstanceYSecondValue * interpolationValue;
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.ListBoxRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.ListBoxRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
                VerticalScrollBarInstance.StopAnimations();
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
                            Name = "ColoredRectangleInstance.Blue",
                            Type = "int",
                            Value = ColoredRectangleInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Green",
                            Type = "int",
                            Value = ColoredRectangleInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Height",
                            Type = "float",
                            Value = ColoredRectangleInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = ColoredRectangleInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Red",
                            Type = "int",
                            Value = ColoredRectangleInstance.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Width",
                            Type = "float",
                            Value = ColoredRectangleInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = ColoredRectangleInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VerticalScrollBarInstance.Height",
                            Type = "float",
                            Value = VerticalScrollBarInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VerticalScrollBarInstance.Width",
                            Type = "float",
                            Value = VerticalScrollBarInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VerticalScrollBarInstance.X",
                            Type = "float",
                            Value = VerticalScrollBarInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VerticalScrollBarInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = VerticalScrollBarInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VerticalScrollBarInstance.X Units",
                            Type = "PositionUnitType",
                            Value = VerticalScrollBarInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VerticalScrollBarInstance.Y",
                            Type = "float",
                            Value = VerticalScrollBarInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VerticalScrollBarInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = VerticalScrollBarInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.Clips Children",
                            Type = "bool",
                            Value = ClipContainerInstance.ClipsChildren
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.Height",
                            Type = "float",
                            Value = ClipContainerInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = ClipContainerInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.Width",
                            Type = "float",
                            Value = ClipContainerInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = ClipContainerInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.X",
                            Type = "float",
                            Value = ClipContainerInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.X Units",
                            Type = "PositionUnitType",
                            Value = ClipContainerInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.Y",
                            Type = "float",
                            Value = ClipContainerInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = ClipContainerInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InnerPanelInstance.Children Layout",
                            Type = "ChildrenLayout",
                            Value = InnerPanelInstance.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InnerPanelInstance.Height",
                            Type = "float",
                            Value = InnerPanelInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InnerPanelInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = InnerPanelInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InnerPanelInstance.Parent",
                            Type = "string",
                            Value = InnerPanelInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InnerPanelInstance.Width",
                            Type = "float",
                            Value = InnerPanelInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InnerPanelInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = InnerPanelInstance.WidthUnits
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
                            Name = "ColoredRectangleInstance.Blue",
                            Type = "int",
                            Value = ColoredRectangleInstance.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Green",
                            Type = "int",
                            Value = ColoredRectangleInstance.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Height",
                            Type = "float",
                            Value = ColoredRectangleInstance.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = ColoredRectangleInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Red",
                            Type = "int",
                            Value = ColoredRectangleInstance.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Width",
                            Type = "float",
                            Value = ColoredRectangleInstance.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = ColoredRectangleInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VerticalScrollBarInstance.Height",
                            Type = "float",
                            Value = VerticalScrollBarInstance.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VerticalScrollBarInstance.Width",
                            Type = "float",
                            Value = VerticalScrollBarInstance.Width + 8f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VerticalScrollBarInstance.X",
                            Type = "float",
                            Value = VerticalScrollBarInstance.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VerticalScrollBarInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = VerticalScrollBarInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VerticalScrollBarInstance.X Units",
                            Type = "PositionUnitType",
                            Value = VerticalScrollBarInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VerticalScrollBarInstance.Y",
                            Type = "float",
                            Value = VerticalScrollBarInstance.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VerticalScrollBarInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = VerticalScrollBarInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.Clips Children",
                            Type = "bool",
                            Value = ClipContainerInstance.ClipsChildren
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.Height",
                            Type = "float",
                            Value = ClipContainerInstance.Height + -4f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = ClipContainerInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.Width",
                            Type = "float",
                            Value = ClipContainerInstance.Width + 90f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = ClipContainerInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.X",
                            Type = "float",
                            Value = ClipContainerInstance.X + 2f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.X Units",
                            Type = "PositionUnitType",
                            Value = ClipContainerInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.Y",
                            Type = "float",
                            Value = ClipContainerInstance.Y + 2f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = ClipContainerInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InnerPanelInstance.Children Layout",
                            Type = "ChildrenLayout",
                            Value = InnerPanelInstance.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InnerPanelInstance.Height",
                            Type = "float",
                            Value = InnerPanelInstance.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InnerPanelInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = InnerPanelInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InnerPanelInstance.Parent",
                            Type = "string",
                            Value = InnerPanelInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InnerPanelInstance.Width",
                            Type = "float",
                            Value = InnerPanelInstance.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InnerPanelInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = InnerPanelInstance.WidthUnits
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
            private bool tryCreateFormsObject;
            private AbbatoirIntergrade.GumRuntimes.ColoredRectangleRuntime ColoredRectangleInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.VerticalScrollBarRuntime VerticalScrollBarInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime ClipContainerInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime InnerPanelInstance { get; set; }
            public ListBoxRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                this.tryCreateFormsObject = tryCreateFormsObject;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "ListBox");
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
                ColoredRectangleInstance = this.GetGraphicalUiElementByName("ColoredRectangleInstance") as AbbatoirIntergrade.GumRuntimes.ColoredRectangleRuntime;
                VerticalScrollBarInstance = this.GetGraphicalUiElementByName("VerticalScrollBarInstance") as AbbatoirIntergrade.GumRuntimes.VerticalScrollBarRuntime;
                ClipContainerInstance = this.GetGraphicalUiElementByName("ClipContainerInstance") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
                InnerPanelInstance = this.GetGraphicalUiElementByName("InnerPanelInstance") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
                if (tryCreateFormsObject)
                {
                    FormsControl = new FlatRedBall.Forms.Controls.ListBox(this);
                }
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
            public FlatRedBall.Forms.Controls.ListBox FormsControl {get; private set;}
            public override object FormsControlAsObject { get { return FormsControl; } }
        }
    }
