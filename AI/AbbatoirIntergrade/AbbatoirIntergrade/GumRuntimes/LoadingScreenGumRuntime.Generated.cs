    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes
    {
        public partial class LoadingScreenGumRuntime : Gum.Wireframe.GraphicalUiElement
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
                            TextInstance.Blue = 255;
                            SetProperty("TextInstance.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                            TextInstance.FontScale = 2.5f;
                            TextInstance.FontSize = 22;
                            TextInstance.Green = 255;
                            TextInstance.Height = 20f;
                            TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            TextInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ColoredRectangleInstance");
                            TextInstance.Red = 255;
                            TextInstance.Text = "Loading...";
                            TextInstance.UseCustomFont = true;
                            TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            TextInstance.X = -9f;
                            TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            TextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            TextInstance.Y = 1151f;
                            TextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                            LeftEye.CurrentEyeOpeningState = AbbatoirIntergrade.GumRuntimes.MainMenuEyeRuntime.EyeOpening.Open;
                            LeftEye.CurrentEyePositionState = AbbatoirIntergrade.GumRuntimes.MainMenuEyeRuntime.EyePosition.Left;
                            LeftEye.Y = -150f;
                            LeftEye.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            LeftEye.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            RightEye.CurrentEyeOpeningState = AbbatoirIntergrade.GumRuntimes.MainMenuEyeRuntime.EyeOpening.Open;
                            RightEye.CurrentEyePositionState = AbbatoirIntergrade.GumRuntimes.MainMenuEyeRuntime.EyePosition.Right;
                            RightEye.X = 0f;
                            RightEye.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            RightEye.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            RightEye.Y = -150f;
                            RightEye.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            RightEye.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
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
                bool setLeftEyeCurrentEyeOpeningStateFirstValue = false;
                bool setLeftEyeCurrentEyeOpeningStateSecondValue = false;
                MainMenuEyeRuntime.EyeOpening LeftEyeCurrentEyeOpeningStateFirstValue= MainMenuEyeRuntime.EyeOpening.Closed;
                MainMenuEyeRuntime.EyeOpening LeftEyeCurrentEyeOpeningStateSecondValue= MainMenuEyeRuntime.EyeOpening.Closed;
                bool setLeftEyeCurrentEyePositionStateFirstValue = false;
                bool setLeftEyeCurrentEyePositionStateSecondValue = false;
                MainMenuEyeRuntime.EyePosition LeftEyeCurrentEyePositionStateFirstValue= MainMenuEyeRuntime.EyePosition.Left;
                MainMenuEyeRuntime.EyePosition LeftEyeCurrentEyePositionStateSecondValue= MainMenuEyeRuntime.EyePosition.Left;
                bool setLeftEyeYFirstValue = false;
                bool setLeftEyeYSecondValue = false;
                float LeftEyeYFirstValue= 0;
                float LeftEyeYSecondValue= 0;
                bool setRightEyeCurrentEyeOpeningStateFirstValue = false;
                bool setRightEyeCurrentEyeOpeningStateSecondValue = false;
                MainMenuEyeRuntime.EyeOpening RightEyeCurrentEyeOpeningStateFirstValue= MainMenuEyeRuntime.EyeOpening.Closed;
                MainMenuEyeRuntime.EyeOpening RightEyeCurrentEyeOpeningStateSecondValue= MainMenuEyeRuntime.EyeOpening.Closed;
                bool setRightEyeCurrentEyePositionStateFirstValue = false;
                bool setRightEyeCurrentEyePositionStateSecondValue = false;
                MainMenuEyeRuntime.EyePosition RightEyeCurrentEyePositionStateFirstValue= MainMenuEyeRuntime.EyePosition.Left;
                MainMenuEyeRuntime.EyePosition RightEyeCurrentEyePositionStateSecondValue= MainMenuEyeRuntime.EyePosition.Left;
                bool setRightEyeXFirstValue = false;
                bool setRightEyeXSecondValue = false;
                float RightEyeXFirstValue= 0;
                float RightEyeXSecondValue= 0;
                bool setRightEyeYFirstValue = false;
                bool setRightEyeYSecondValue = false;
                float RightEyeYFirstValue= 0;
                float RightEyeYSecondValue= 0;
                bool setTextInstanceBlueFirstValue = false;
                bool setTextInstanceBlueSecondValue = false;
                int TextInstanceBlueFirstValue= 0;
                int TextInstanceBlueSecondValue= 0;
                bool setTextInstanceFontScaleFirstValue = false;
                bool setTextInstanceFontScaleSecondValue = false;
                float TextInstanceFontScaleFirstValue= 0;
                float TextInstanceFontScaleSecondValue= 0;
                bool setTextInstanceFontSizeFirstValue = false;
                bool setTextInstanceFontSizeSecondValue = false;
                int TextInstanceFontSizeFirstValue= 0;
                int TextInstanceFontSizeSecondValue= 0;
                bool setTextInstanceGreenFirstValue = false;
                bool setTextInstanceGreenSecondValue = false;
                int TextInstanceGreenFirstValue= 0;
                int TextInstanceGreenSecondValue= 0;
                bool setTextInstanceHeightFirstValue = false;
                bool setTextInstanceHeightSecondValue = false;
                float TextInstanceHeightFirstValue= 0;
                float TextInstanceHeightSecondValue= 0;
                bool setTextInstanceRedFirstValue = false;
                bool setTextInstanceRedSecondValue = false;
                int TextInstanceRedFirstValue= 0;
                int TextInstanceRedSecondValue= 0;
                bool setTextInstanceXFirstValue = false;
                bool setTextInstanceXSecondValue = false;
                float TextInstanceXFirstValue= 0;
                float TextInstanceXSecondValue= 0;
                bool setTextInstanceYFirstValue = false;
                bool setTextInstanceYSecondValue = false;
                float TextInstanceYFirstValue= 0;
                float TextInstanceYSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setLeftEyeCurrentEyeOpeningStateFirstValue = true;
                        LeftEyeCurrentEyeOpeningStateFirstValue = AbbatoirIntergrade.GumRuntimes.MainMenuEyeRuntime.EyeOpening.Open;
                        setLeftEyeCurrentEyePositionStateFirstValue = true;
                        LeftEyeCurrentEyePositionStateFirstValue = AbbatoirIntergrade.GumRuntimes.MainMenuEyeRuntime.EyePosition.Left;
                        setLeftEyeYFirstValue = true;
                        LeftEyeYFirstValue = -150f;
                        if (interpolationValue < 1)
                        {
                            this.LeftEye.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.LeftEye.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setRightEyeCurrentEyeOpeningStateFirstValue = true;
                        RightEyeCurrentEyeOpeningStateFirstValue = AbbatoirIntergrade.GumRuntimes.MainMenuEyeRuntime.EyeOpening.Open;
                        setRightEyeCurrentEyePositionStateFirstValue = true;
                        RightEyeCurrentEyePositionStateFirstValue = AbbatoirIntergrade.GumRuntimes.MainMenuEyeRuntime.EyePosition.Right;
                        setRightEyeXFirstValue = true;
                        RightEyeXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.RightEye.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.RightEye.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setRightEyeYFirstValue = true;
                        RightEyeYFirstValue = -150f;
                        if (interpolationValue < 1)
                        {
                            this.RightEye.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.RightEye.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setTextInstanceBlueFirstValue = true;
                        TextInstanceBlueFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            SetProperty("TextInstance.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setTextInstanceFontScaleFirstValue = true;
                        TextInstanceFontScaleFirstValue = 2.5f;
                        setTextInstanceFontSizeFirstValue = true;
                        TextInstanceFontSizeFirstValue = 22;
                        setTextInstanceGreenFirstValue = true;
                        TextInstanceGreenFirstValue = 255;
                        setTextInstanceHeightFirstValue = true;
                        TextInstanceHeightFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ColoredRectangleInstance");
                        }
                        setTextInstanceRedFirstValue = true;
                        TextInstanceRedFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.Text = "Loading...";
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.UseCustomFont = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setTextInstanceXFirstValue = true;
                        TextInstanceXFirstValue = -9f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setTextInstanceYFirstValue = true;
                        TextInstanceYFirstValue = 1151f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setLeftEyeCurrentEyeOpeningStateSecondValue = true;
                        LeftEyeCurrentEyeOpeningStateSecondValue = AbbatoirIntergrade.GumRuntimes.MainMenuEyeRuntime.EyeOpening.Open;
                        setLeftEyeCurrentEyePositionStateSecondValue = true;
                        LeftEyeCurrentEyePositionStateSecondValue = AbbatoirIntergrade.GumRuntimes.MainMenuEyeRuntime.EyePosition.Left;
                        setLeftEyeYSecondValue = true;
                        LeftEyeYSecondValue = -150f;
                        if (interpolationValue >= 1)
                        {
                            this.LeftEye.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.LeftEye.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setRightEyeCurrentEyeOpeningStateSecondValue = true;
                        RightEyeCurrentEyeOpeningStateSecondValue = AbbatoirIntergrade.GumRuntimes.MainMenuEyeRuntime.EyeOpening.Open;
                        setRightEyeCurrentEyePositionStateSecondValue = true;
                        RightEyeCurrentEyePositionStateSecondValue = AbbatoirIntergrade.GumRuntimes.MainMenuEyeRuntime.EyePosition.Right;
                        setRightEyeXSecondValue = true;
                        RightEyeXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.RightEye.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.RightEye.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setRightEyeYSecondValue = true;
                        RightEyeYSecondValue = -150f;
                        if (interpolationValue >= 1)
                        {
                            this.RightEye.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.RightEye.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setTextInstanceBlueSecondValue = true;
                        TextInstanceBlueSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("TextInstance.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setTextInstanceFontScaleSecondValue = true;
                        TextInstanceFontScaleSecondValue = 2.5f;
                        setTextInstanceFontSizeSecondValue = true;
                        TextInstanceFontSizeSecondValue = 22;
                        setTextInstanceGreenSecondValue = true;
                        TextInstanceGreenSecondValue = 255;
                        setTextInstanceHeightSecondValue = true;
                        TextInstanceHeightSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ColoredRectangleInstance");
                        }
                        setTextInstanceRedSecondValue = true;
                        TextInstanceRedSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.Text = "Loading...";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.UseCustomFont = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setTextInstanceXSecondValue = true;
                        TextInstanceXSecondValue = -9f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setTextInstanceYSecondValue = true;
                        TextInstanceYSecondValue = 1151f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        break;
                }
                if (setLeftEyeCurrentEyeOpeningStateFirstValue && setLeftEyeCurrentEyeOpeningStateSecondValue)
                {
                    LeftEye.InterpolateBetween(LeftEyeCurrentEyeOpeningStateFirstValue, LeftEyeCurrentEyeOpeningStateSecondValue, interpolationValue);
                }
                if (setLeftEyeCurrentEyePositionStateFirstValue && setLeftEyeCurrentEyePositionStateSecondValue)
                {
                    LeftEye.InterpolateBetween(LeftEyeCurrentEyePositionStateFirstValue, LeftEyeCurrentEyePositionStateSecondValue, interpolationValue);
                }
                if (setLeftEyeYFirstValue && setLeftEyeYSecondValue)
                {
                    LeftEye.Y = LeftEyeYFirstValue * (1 - interpolationValue) + LeftEyeYSecondValue * interpolationValue;
                }
                if (setRightEyeCurrentEyeOpeningStateFirstValue && setRightEyeCurrentEyeOpeningStateSecondValue)
                {
                    RightEye.InterpolateBetween(RightEyeCurrentEyeOpeningStateFirstValue, RightEyeCurrentEyeOpeningStateSecondValue, interpolationValue);
                }
                if (setRightEyeCurrentEyePositionStateFirstValue && setRightEyeCurrentEyePositionStateSecondValue)
                {
                    RightEye.InterpolateBetween(RightEyeCurrentEyePositionStateFirstValue, RightEyeCurrentEyePositionStateSecondValue, interpolationValue);
                }
                if (setRightEyeXFirstValue && setRightEyeXSecondValue)
                {
                    RightEye.X = RightEyeXFirstValue * (1 - interpolationValue) + RightEyeXSecondValue * interpolationValue;
                }
                if (setRightEyeYFirstValue && setRightEyeYSecondValue)
                {
                    RightEye.Y = RightEyeYFirstValue * (1 - interpolationValue) + RightEyeYSecondValue * interpolationValue;
                }
                if (setTextInstanceBlueFirstValue && setTextInstanceBlueSecondValue)
                {
                    TextInstance.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(TextInstanceBlueFirstValue* (1 - interpolationValue) + TextInstanceBlueSecondValue * interpolationValue);
                }
                if (setTextInstanceFontScaleFirstValue && setTextInstanceFontScaleSecondValue)
                {
                    TextInstance.FontScale = TextInstanceFontScaleFirstValue * (1 - interpolationValue) + TextInstanceFontScaleSecondValue * interpolationValue;
                }
                if (setTextInstanceFontSizeFirstValue && setTextInstanceFontSizeSecondValue)
                {
                    TextInstance.FontSize = FlatRedBall.Math.MathFunctions.RoundToInt(TextInstanceFontSizeFirstValue* (1 - interpolationValue) + TextInstanceFontSizeSecondValue * interpolationValue);
                }
                if (setTextInstanceGreenFirstValue && setTextInstanceGreenSecondValue)
                {
                    TextInstance.Green = FlatRedBall.Math.MathFunctions.RoundToInt(TextInstanceGreenFirstValue* (1 - interpolationValue) + TextInstanceGreenSecondValue * interpolationValue);
                }
                if (setTextInstanceHeightFirstValue && setTextInstanceHeightSecondValue)
                {
                    TextInstance.Height = TextInstanceHeightFirstValue * (1 - interpolationValue) + TextInstanceHeightSecondValue * interpolationValue;
                }
                if (setTextInstanceRedFirstValue && setTextInstanceRedSecondValue)
                {
                    TextInstance.Red = FlatRedBall.Math.MathFunctions.RoundToInt(TextInstanceRedFirstValue* (1 - interpolationValue) + TextInstanceRedSecondValue * interpolationValue);
                }
                if (setTextInstanceXFirstValue && setTextInstanceXSecondValue)
                {
                    TextInstance.X = TextInstanceXFirstValue * (1 - interpolationValue) + TextInstanceXSecondValue * interpolationValue;
                }
                if (setTextInstanceYFirstValue && setTextInstanceYSecondValue)
                {
                    TextInstance.Y = TextInstanceYFirstValue * (1 - interpolationValue) + TextInstanceYSecondValue * interpolationValue;
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.LoadingScreenGumRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.LoadingScreenGumRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
                LeftEye.StopAnimations();
                RightEye.StopAnimations();
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
                            Name = "TextInstance.Blue",
                            Type = "int",
                            Value = TextInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.CustomFontFile",
                            Type = "string",
                            Value = TextInstance.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Font Scale",
                            Type = "float",
                            Value = TextInstance.FontScale
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.FontSize",
                            Type = "int",
                            Value = TextInstance.FontSize
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Green",
                            Type = "int",
                            Value = TextInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Height",
                            Type = "float",
                            Value = TextInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = TextInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = TextInstance.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Parent",
                            Type = "string",
                            Value = TextInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Red",
                            Type = "int",
                            Value = TextInstance.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Text",
                            Type = "string",
                            Value = TextInstance.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.UseCustomFont",
                            Type = "bool",
                            Value = TextInstance.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = TextInstance.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = TextInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.X",
                            Type = "float",
                            Value = TextInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = TextInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.X Units",
                            Type = "PositionUnitType",
                            Value = TextInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Y",
                            Type = "float",
                            Value = TextInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = TextInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LeftEye.EyeOpeningState",
                            Type = "EyeOpeningState",
                            Value = LeftEye.CurrentEyeOpeningState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LeftEye.EyePositionState",
                            Type = "EyePositionState",
                            Value = LeftEye.CurrentEyePositionState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LeftEye.Y",
                            Type = "float",
                            Value = LeftEye.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LeftEye.Y Origin",
                            Type = "VerticalAlignment",
                            Value = LeftEye.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LeftEye.Y Units",
                            Type = "PositionUnitType",
                            Value = LeftEye.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RightEye.EyeOpeningState",
                            Type = "EyeOpeningState",
                            Value = RightEye.CurrentEyeOpeningState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RightEye.EyePositionState",
                            Type = "EyePositionState",
                            Value = RightEye.CurrentEyePositionState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RightEye.X",
                            Type = "float",
                            Value = RightEye.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RightEye.X Origin",
                            Type = "HorizontalAlignment",
                            Value = RightEye.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RightEye.X Units",
                            Type = "PositionUnitType",
                            Value = RightEye.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RightEye.Y",
                            Type = "float",
                            Value = RightEye.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RightEye.Y Origin",
                            Type = "VerticalAlignment",
                            Value = RightEye.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RightEye.Y Units",
                            Type = "PositionUnitType",
                            Value = RightEye.YUnits
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
                            Name = "TextInstance.Blue",
                            Type = "int",
                            Value = TextInstance.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.CustomFontFile",
                            Type = "string",
                            Value = TextInstance.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Font Scale",
                            Type = "float",
                            Value = TextInstance.FontScale + 2.5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.FontSize",
                            Type = "int",
                            Value = TextInstance.FontSize + 22
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Green",
                            Type = "int",
                            Value = TextInstance.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Height",
                            Type = "float",
                            Value = TextInstance.Height + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = TextInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = TextInstance.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Parent",
                            Type = "string",
                            Value = TextInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Red",
                            Type = "int",
                            Value = TextInstance.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Text",
                            Type = "string",
                            Value = TextInstance.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.UseCustomFont",
                            Type = "bool",
                            Value = TextInstance.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = TextInstance.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = TextInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.X",
                            Type = "float",
                            Value = TextInstance.X + -9f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = TextInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.X Units",
                            Type = "PositionUnitType",
                            Value = TextInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Y",
                            Type = "float",
                            Value = TextInstance.Y + 1151f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = TextInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LeftEye.EyeOpeningState",
                            Type = "EyeOpeningState",
                            Value = LeftEye.CurrentEyeOpeningState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LeftEye.EyePositionState",
                            Type = "EyePositionState",
                            Value = LeftEye.CurrentEyePositionState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LeftEye.Y",
                            Type = "float",
                            Value = LeftEye.Y + -150f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LeftEye.Y Origin",
                            Type = "VerticalAlignment",
                            Value = LeftEye.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LeftEye.Y Units",
                            Type = "PositionUnitType",
                            Value = LeftEye.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RightEye.EyeOpeningState",
                            Type = "EyeOpeningState",
                            Value = RightEye.CurrentEyeOpeningState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RightEye.EyePositionState",
                            Type = "EyePositionState",
                            Value = RightEye.CurrentEyePositionState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RightEye.X",
                            Type = "float",
                            Value = RightEye.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RightEye.X Origin",
                            Type = "HorizontalAlignment",
                            Value = RightEye.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RightEye.X Units",
                            Type = "PositionUnitType",
                            Value = RightEye.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RightEye.Y",
                            Type = "float",
                            Value = RightEye.Y + -150f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RightEye.Y Origin",
                            Type = "VerticalAlignment",
                            Value = RightEye.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RightEye.Y Units",
                            Type = "PositionUnitType",
                            Value = RightEye.YUnits
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
            public AbbatoirIntergrade.GumRuntimes.TextRuntime TextInstance { get; set; }
            public AbbatoirIntergrade.GumRuntimes.MainMenuEyeRuntime LeftEye { get; set; }
            public AbbatoirIntergrade.GumRuntimes.MainMenuEyeRuntime RightEye { get; set; }
            public LoadingScreenGumRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            {
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Screens.First(item => item.Name == "LoadingScreenGum");
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
                TextInstance = this.GetGraphicalUiElementByName("TextInstance") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
                LeftEye = this.GetGraphicalUiElementByName("LeftEye") as AbbatoirIntergrade.GumRuntimes.MainMenuEyeRuntime;
                RightEye = this.GetGraphicalUiElementByName("RightEye") as AbbatoirIntergrade.GumRuntimes.MainMenuEyeRuntime;
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
