    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes
    {
        public partial class SliderBarRuntime : AbbatoirIntergrade.GumRuntimes.ContainerRuntime
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            public enum SliderCategory
            {
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            SliderCategory mCurrentSliderCategoryState;
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
                            Height = 20f;
                            HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            Width = 100f;
                            WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            BackgroundRectangle.Blue = 0;
                            BackgroundRectangle.Green = 0;
                            BackgroundRectangle.Height = 54f;
                            BackgroundRectangle.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            BackgroundRectangle.Red = 0;
                            BackgroundRectangle.Width = 8f;
                            BackgroundRectangle.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            BackgroundRectangle.X = -4f;
                            BackgroundRectangle.Y = 50f;
                            BackgroundRectangle.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            BackgroundRectangle.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            ColoredRectangleInstance.Blue = 255;
                            ColoredRectangleInstance.Green = 255;
                            ColoredRectangleInstance.Height = 50f;
                            ColoredRectangleInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ColoredRectangleInstance.Red = 0;
                            ColoredRectangleInstance.Width = 100f;
                            ColoredRectangleInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ColoredRectangleInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            ColoredRectangleInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            ThumbInstance.Height = 40f;
                            ThumbInstance.Width = 115f;
                            ThumbInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                            ThumbInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            ThumbInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                            ThumbInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            break;
                    }
                }
            }
            public SliderCategory CurrentSliderCategoryState
            {
                get
                {
                    return mCurrentSliderCategoryState;
                }
                set
                {
                    mCurrentSliderCategoryState = value;
                    switch(mCurrentSliderCategoryState)
                    {
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
                bool setBackgroundRectangleBlueFirstValue = false;
                bool setBackgroundRectangleBlueSecondValue = false;
                int BackgroundRectangleBlueFirstValue= 0;
                int BackgroundRectangleBlueSecondValue= 0;
                bool setBackgroundRectangleGreenFirstValue = false;
                bool setBackgroundRectangleGreenSecondValue = false;
                int BackgroundRectangleGreenFirstValue= 0;
                int BackgroundRectangleGreenSecondValue= 0;
                bool setBackgroundRectangleHeightFirstValue = false;
                bool setBackgroundRectangleHeightSecondValue = false;
                float BackgroundRectangleHeightFirstValue= 0;
                float BackgroundRectangleHeightSecondValue= 0;
                bool setBackgroundRectangleRedFirstValue = false;
                bool setBackgroundRectangleRedSecondValue = false;
                int BackgroundRectangleRedFirstValue= 0;
                int BackgroundRectangleRedSecondValue= 0;
                bool setBackgroundRectangleWidthFirstValue = false;
                bool setBackgroundRectangleWidthSecondValue = false;
                float BackgroundRectangleWidthFirstValue= 0;
                float BackgroundRectangleWidthSecondValue= 0;
                bool setBackgroundRectangleXFirstValue = false;
                bool setBackgroundRectangleXSecondValue = false;
                float BackgroundRectangleXFirstValue= 0;
                float BackgroundRectangleXSecondValue= 0;
                bool setBackgroundRectangleYFirstValue = false;
                bool setBackgroundRectangleYSecondValue = false;
                float BackgroundRectangleYFirstValue= 0;
                float BackgroundRectangleYSecondValue= 0;
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
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setThumbInstanceHeightFirstValue = false;
                bool setThumbInstanceHeightSecondValue = false;
                float ThumbInstanceHeightFirstValue= 0;
                float ThumbInstanceHeightSecondValue= 0;
                bool setThumbInstanceWidthFirstValue = false;
                bool setThumbInstanceWidthSecondValue = false;
                float ThumbInstanceWidthFirstValue= 0;
                float ThumbInstanceWidthSecondValue= 0;
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setBackgroundRectangleBlueFirstValue = true;
                        BackgroundRectangleBlueFirstValue = 0;
                        setBackgroundRectangleGreenFirstValue = true;
                        BackgroundRectangleGreenFirstValue = 0;
                        setBackgroundRectangleHeightFirstValue = true;
                        BackgroundRectangleHeightFirstValue = 54f;
                        if (interpolationValue < 1)
                        {
                            this.BackgroundRectangle.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setBackgroundRectangleRedFirstValue = true;
                        BackgroundRectangleRedFirstValue = 0;
                        setBackgroundRectangleWidthFirstValue = true;
                        BackgroundRectangleWidthFirstValue = 8f;
                        if (interpolationValue < 1)
                        {
                            this.BackgroundRectangle.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setBackgroundRectangleXFirstValue = true;
                        BackgroundRectangleXFirstValue = -4f;
                        setBackgroundRectangleYFirstValue = true;
                        BackgroundRectangleYFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.BackgroundRectangle.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.BackgroundRectangle.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setColoredRectangleInstanceBlueFirstValue = true;
                        ColoredRectangleInstanceBlueFirstValue = 255;
                        setColoredRectangleInstanceGreenFirstValue = true;
                        ColoredRectangleInstanceGreenFirstValue = 255;
                        setColoredRectangleInstanceHeightFirstValue = true;
                        ColoredRectangleInstanceHeightFirstValue = 50f;
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
                            this.ColoredRectangleInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setHeightFirstValue = true;
                        HeightFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setThumbInstanceHeightFirstValue = true;
                        ThumbInstanceHeightFirstValue = 40f;
                        setThumbInstanceWidthFirstValue = true;
                        ThumbInstanceWidthFirstValue = 115f;
                        if (interpolationValue < 1)
                        {
                            this.ThumbInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ThumbInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ThumbInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ThumbInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
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
                        setBackgroundRectangleBlueSecondValue = true;
                        BackgroundRectangleBlueSecondValue = 0;
                        setBackgroundRectangleGreenSecondValue = true;
                        BackgroundRectangleGreenSecondValue = 0;
                        setBackgroundRectangleHeightSecondValue = true;
                        BackgroundRectangleHeightSecondValue = 54f;
                        if (interpolationValue >= 1)
                        {
                            this.BackgroundRectangle.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setBackgroundRectangleRedSecondValue = true;
                        BackgroundRectangleRedSecondValue = 0;
                        setBackgroundRectangleWidthSecondValue = true;
                        BackgroundRectangleWidthSecondValue = 8f;
                        if (interpolationValue >= 1)
                        {
                            this.BackgroundRectangle.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setBackgroundRectangleXSecondValue = true;
                        BackgroundRectangleXSecondValue = -4f;
                        setBackgroundRectangleYSecondValue = true;
                        BackgroundRectangleYSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.BackgroundRectangle.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.BackgroundRectangle.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setColoredRectangleInstanceBlueSecondValue = true;
                        ColoredRectangleInstanceBlueSecondValue = 255;
                        setColoredRectangleInstanceGreenSecondValue = true;
                        ColoredRectangleInstanceGreenSecondValue = 255;
                        setColoredRectangleInstanceHeightSecondValue = true;
                        ColoredRectangleInstanceHeightSecondValue = 50f;
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
                            this.ColoredRectangleInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setHeightSecondValue = true;
                        HeightSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setThumbInstanceHeightSecondValue = true;
                        ThumbInstanceHeightSecondValue = 40f;
                        setThumbInstanceWidthSecondValue = true;
                        ThumbInstanceWidthSecondValue = 115f;
                        if (interpolationValue >= 1)
                        {
                            this.ThumbInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ThumbInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ThumbInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ThumbInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setWidthSecondValue = true;
                        WidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        break;
                }
                if (setBackgroundRectangleBlueFirstValue && setBackgroundRectangleBlueSecondValue)
                {
                    BackgroundRectangle.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(BackgroundRectangleBlueFirstValue* (1 - interpolationValue) + BackgroundRectangleBlueSecondValue * interpolationValue);
                }
                if (setBackgroundRectangleGreenFirstValue && setBackgroundRectangleGreenSecondValue)
                {
                    BackgroundRectangle.Green = FlatRedBall.Math.MathFunctions.RoundToInt(BackgroundRectangleGreenFirstValue* (1 - interpolationValue) + BackgroundRectangleGreenSecondValue * interpolationValue);
                }
                if (setBackgroundRectangleHeightFirstValue && setBackgroundRectangleHeightSecondValue)
                {
                    BackgroundRectangle.Height = BackgroundRectangleHeightFirstValue * (1 - interpolationValue) + BackgroundRectangleHeightSecondValue * interpolationValue;
                }
                if (setBackgroundRectangleRedFirstValue && setBackgroundRectangleRedSecondValue)
                {
                    BackgroundRectangle.Red = FlatRedBall.Math.MathFunctions.RoundToInt(BackgroundRectangleRedFirstValue* (1 - interpolationValue) + BackgroundRectangleRedSecondValue * interpolationValue);
                }
                if (setBackgroundRectangleWidthFirstValue && setBackgroundRectangleWidthSecondValue)
                {
                    BackgroundRectangle.Width = BackgroundRectangleWidthFirstValue * (1 - interpolationValue) + BackgroundRectangleWidthSecondValue * interpolationValue;
                }
                if (setBackgroundRectangleXFirstValue && setBackgroundRectangleXSecondValue)
                {
                    BackgroundRectangle.X = BackgroundRectangleXFirstValue * (1 - interpolationValue) + BackgroundRectangleXSecondValue * interpolationValue;
                }
                if (setBackgroundRectangleYFirstValue && setBackgroundRectangleYSecondValue)
                {
                    BackgroundRectangle.Y = BackgroundRectangleYFirstValue * (1 - interpolationValue) + BackgroundRectangleYSecondValue * interpolationValue;
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
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
                }
                if (setThumbInstanceHeightFirstValue && setThumbInstanceHeightSecondValue)
                {
                    ThumbInstance.Height = ThumbInstanceHeightFirstValue * (1 - interpolationValue) + ThumbInstanceHeightSecondValue * interpolationValue;
                }
                if (setThumbInstanceWidthFirstValue && setThumbInstanceWidthSecondValue)
                {
                    ThumbInstance.Width = ThumbInstanceWidthFirstValue * (1 - interpolationValue) + ThumbInstanceWidthSecondValue * interpolationValue;
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
            public void InterpolateBetween (SliderCategory firstState, SliderCategory secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                switch(firstState)
                {
                }
                switch(secondState)
                {
                }
                if (interpolationValue < 1)
                {
                    mCurrentSliderCategoryState = firstState;
                }
                else
                {
                    mCurrentSliderCategoryState = secondState;
                }
            }
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.SliderBarRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.SliderBarRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.SliderBarRuntime.SliderCategory fromState,AbbatoirIntergrade.GumRuntimes.SliderBarRuntime.SliderCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (SliderCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "SliderCategory").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentSliderCategoryState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (SliderCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentSliderCategoryState = toState;
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
                ThumbInstance.StopAnimations();
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
                            Name = "BackgroundRectangle.Blue",
                            Type = "int",
                            Value = BackgroundRectangle.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundRectangle.Green",
                            Type = "int",
                            Value = BackgroundRectangle.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundRectangle.Height",
                            Type = "float",
                            Value = BackgroundRectangle.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundRectangle.Height Units",
                            Type = "DimensionUnitType",
                            Value = BackgroundRectangle.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundRectangle.Red",
                            Type = "int",
                            Value = BackgroundRectangle.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundRectangle.Width",
                            Type = "float",
                            Value = BackgroundRectangle.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundRectangle.Width Units",
                            Type = "DimensionUnitType",
                            Value = BackgroundRectangle.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundRectangle.X",
                            Type = "float",
                            Value = BackgroundRectangle.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundRectangle.Y",
                            Type = "float",
                            Value = BackgroundRectangle.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundRectangle.Y Origin",
                            Type = "VerticalAlignment",
                            Value = BackgroundRectangle.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundRectangle.Y Units",
                            Type = "PositionUnitType",
                            Value = BackgroundRectangle.YUnits
                        }
                        );
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
                            Name = "ColoredRectangleInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = ColoredRectangleInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = ColoredRectangleInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbInstance.Height",
                            Type = "float",
                            Value = ThumbInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbInstance.Width",
                            Type = "float",
                            Value = ThumbInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = ThumbInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ThumbInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = ThumbInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = ThumbInstance.YUnits
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
                            Value = Height + 20f
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
                            Name = "BackgroundRectangle.Blue",
                            Type = "int",
                            Value = BackgroundRectangle.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundRectangle.Green",
                            Type = "int",
                            Value = BackgroundRectangle.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundRectangle.Height",
                            Type = "float",
                            Value = BackgroundRectangle.Height + 54f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundRectangle.Height Units",
                            Type = "DimensionUnitType",
                            Value = BackgroundRectangle.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundRectangle.Red",
                            Type = "int",
                            Value = BackgroundRectangle.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundRectangle.Width",
                            Type = "float",
                            Value = BackgroundRectangle.Width + 8f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundRectangle.Width Units",
                            Type = "DimensionUnitType",
                            Value = BackgroundRectangle.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundRectangle.X",
                            Type = "float",
                            Value = BackgroundRectangle.X + -4f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundRectangle.Y",
                            Type = "float",
                            Value = BackgroundRectangle.Y + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundRectangle.Y Origin",
                            Type = "VerticalAlignment",
                            Value = BackgroundRectangle.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BackgroundRectangle.Y Units",
                            Type = "PositionUnitType",
                            Value = BackgroundRectangle.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Blue",
                            Type = "int",
                            Value = ColoredRectangleInstance.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Green",
                            Type = "int",
                            Value = ColoredRectangleInstance.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Height",
                            Type = "float",
                            Value = ColoredRectangleInstance.Height + 50f
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
                            Name = "ColoredRectangleInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = ColoredRectangleInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = ColoredRectangleInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbInstance.Height",
                            Type = "float",
                            Value = ThumbInstance.Height + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbInstance.Width",
                            Type = "float",
                            Value = ThumbInstance.Width + 115f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = ThumbInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ThumbInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = ThumbInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = ThumbInstance.YUnits
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (SliderCategory state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (SliderCategory state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
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
                    else if (category.Name == "SliderCategory")
                    {
                    }
                }
                base.ApplyState(state);
            }
            private AbbatoirIntergrade.GumRuntimes.ColoredRectangleRuntime BackgroundRectangle { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ColoredRectangleRuntime ColoredRectangleInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ThumbRuntime ThumbInstance { get; set; }
            public int ColoredRectangleBlue
            {
                get
                {
                    return ColoredRectangleInstance.Blue;
                }
                set
                {
                    if (ColoredRectangleInstance.Blue != value)
                    {
                        ColoredRectangleInstance.Blue = value;
                        ColoredRectangleBlueChanged?.Invoke(this, null);
                    }
                }
            }
            public int ColoredRectangleGreen
            {
                get
                {
                    return ColoredRectangleInstance.Green;
                }
                set
                {
                    if (ColoredRectangleInstance.Green != value)
                    {
                        ColoredRectangleInstance.Green = value;
                        ColoredRectangleGreenChanged?.Invoke(this, null);
                    }
                }
            }
            public event FlatRedBall.Gui.WindowEvent ThumbInstanceClick;
            public event System.EventHandler ColoredRectangleBlueChanged;
            public event System.EventHandler ColoredRectangleGreenChanged;
            public SliderBarRuntime (bool fullInstantiation = true) 
            	: base(false)
            {
                this.ExposeChildrenEvents = true;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "SliderBar");
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
                BackgroundRectangle = this.GetGraphicalUiElementByName("BackgroundRectangle") as AbbatoirIntergrade.GumRuntimes.ColoredRectangleRuntime;
                ColoredRectangleInstance = this.GetGraphicalUiElementByName("ColoredRectangleInstance") as AbbatoirIntergrade.GumRuntimes.ColoredRectangleRuntime;
                ThumbInstance = this.GetGraphicalUiElementByName("ThumbInstance") as AbbatoirIntergrade.GumRuntimes.ThumbRuntime;
                ThumbInstance.Click += (unused) => ThumbInstanceClick?.Invoke(this);
                FormsControl = new FlatRedBall.Forms.Controls.Slider();
                FormsControl.Visual = this;
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
            public FlatRedBall.Forms.Controls.Slider FormsControl {get; private set;}
            public override object FormsControlAsObject { get { return FormsControl; } }
        }
    }
