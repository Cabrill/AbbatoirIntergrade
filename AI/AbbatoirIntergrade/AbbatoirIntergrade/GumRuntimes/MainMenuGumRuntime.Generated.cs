    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes
    {
        public partial class MainMenuGumRuntime : Gum.Wireframe.GraphicalUiElement
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            public enum Fade
            {
                FadedOut,
                NotFaded,
                TextGone
            }
            public enum AnyKey
            {
                Ready,
                NotReady
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            Fade mCurrentFadeState;
            AnyKey mCurrentAnyKeyState;
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
                            SetProperty("BackgroundSprite.SourceFile", "../Screens/MainMenu/empty_building.png");
                            LeftEye.CurrentEyeOpeningState = AbbatoirIntergrade.GumRuntimes.MainMenuEyeRuntime.EyeOpening.Closed;
                            LeftEye.CurrentEyePositionState = AbbatoirIntergrade.GumRuntimes.MainMenuEyeRuntime.EyePosition.Left;
                            LeftEye.Y = -150f;
                            LeftEye.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            LeftEye.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            RightEye.CurrentEyeOpeningState = AbbatoirIntergrade.GumRuntimes.MainMenuEyeRuntime.EyeOpening.Closed;
                            RightEye.CurrentEyePositionState = AbbatoirIntergrade.GumRuntimes.MainMenuEyeRuntime.EyePosition.Right;
                            RightEye.X = 0f;
                            RightEye.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            RightEye.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            RightEye.Y = -150f;
                            RightEye.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            RightEye.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            PressAnyKeyText.Alpha = 0;
                            PressAnyKeyText.Font = "Bahnschrift";
                            PressAnyKeyText.FontSize = 48;
                            PressAnyKeyText.Height = 0f;
                            PressAnyKeyText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            PressAnyKeyText.Text = "Press any key to begin...";
                            PressAnyKeyText.Width = 0f;
                            PressAnyKeyText.X = 0f;
                            PressAnyKeyText.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            PressAnyKeyText.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            PressAnyKeyText.Y = 1193f;
                            PressAnyKeyText.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            break;
                    }
                }
            }
            public Fade CurrentFadeState
            {
                get
                {
                    return mCurrentFadeState;
                }
                set
                {
                    mCurrentFadeState = value;
                    switch(mCurrentFadeState)
                    {
                        case  Fade.FadedOut:
                            DimmingInstance.DimmingAlpha = 255;
                            PressAnyKeyText.Alpha = 0;
                            break;
                        case  Fade.NotFaded:
                            DimmingInstance.DimmingAlpha = 0;
                            PressAnyKeyText.Alpha = 0;
                            break;
                        case  Fade.TextGone:
                            DimmingInstance.DimmingAlpha = 150;
                            PressAnyKeyText.Alpha = 0;
                            break;
                    }
                }
            }
            public AnyKey CurrentAnyKeyState
            {
                get
                {
                    return mCurrentAnyKeyState;
                }
                set
                {
                    mCurrentAnyKeyState = value;
                    switch(mCurrentAnyKeyState)
                    {
                        case  AnyKey.Ready:
                            PressAnyKeyText.Alpha = 255;
                            break;
                        case  AnyKey.NotReady:
                            PressAnyKeyText.Alpha = 0;
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
                bool setPressAnyKeyTextAlphaFirstValue = false;
                bool setPressAnyKeyTextAlphaSecondValue = false;
                int PressAnyKeyTextAlphaFirstValue= 0;
                int PressAnyKeyTextAlphaSecondValue= 0;
                bool setPressAnyKeyTextFontSizeFirstValue = false;
                bool setPressAnyKeyTextFontSizeSecondValue = false;
                int PressAnyKeyTextFontSizeFirstValue= 0;
                int PressAnyKeyTextFontSizeSecondValue= 0;
                bool setPressAnyKeyTextHeightFirstValue = false;
                bool setPressAnyKeyTextHeightSecondValue = false;
                float PressAnyKeyTextHeightFirstValue= 0;
                float PressAnyKeyTextHeightSecondValue= 0;
                bool setPressAnyKeyTextWidthFirstValue = false;
                bool setPressAnyKeyTextWidthSecondValue = false;
                float PressAnyKeyTextWidthFirstValue= 0;
                float PressAnyKeyTextWidthSecondValue= 0;
                bool setPressAnyKeyTextXFirstValue = false;
                bool setPressAnyKeyTextXSecondValue = false;
                float PressAnyKeyTextXFirstValue= 0;
                float PressAnyKeyTextXSecondValue= 0;
                bool setPressAnyKeyTextYFirstValue = false;
                bool setPressAnyKeyTextYSecondValue = false;
                float PressAnyKeyTextYFirstValue= 0;
                float PressAnyKeyTextYSecondValue= 0;
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
                switch(firstState)
                {
                    case  VariableState.Default:
                        if (interpolationValue < 1)
                        {
                            SetProperty("BackgroundSprite.SourceFile", "../Screens/MainMenu/empty_building.png");
                        }
                        setLeftEyeCurrentEyeOpeningStateFirstValue = true;
                        LeftEyeCurrentEyeOpeningStateFirstValue = AbbatoirIntergrade.GumRuntimes.MainMenuEyeRuntime.EyeOpening.Closed;
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
                        setPressAnyKeyTextAlphaFirstValue = true;
                        PressAnyKeyTextAlphaFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.PressAnyKeyText.Font = "Bahnschrift";
                        }
                        setPressAnyKeyTextFontSizeFirstValue = true;
                        PressAnyKeyTextFontSizeFirstValue = 48;
                        setPressAnyKeyTextHeightFirstValue = true;
                        PressAnyKeyTextHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.PressAnyKeyText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.PressAnyKeyText.Text = "Press any key to begin...";
                        }
                        setPressAnyKeyTextWidthFirstValue = true;
                        PressAnyKeyTextWidthFirstValue = 0f;
                        setPressAnyKeyTextXFirstValue = true;
                        PressAnyKeyTextXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.PressAnyKeyText.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.PressAnyKeyText.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setPressAnyKeyTextYFirstValue = true;
                        PressAnyKeyTextYFirstValue = 1193f;
                        if (interpolationValue < 1)
                        {
                            this.PressAnyKeyText.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setRightEyeCurrentEyeOpeningStateFirstValue = true;
                        RightEyeCurrentEyeOpeningStateFirstValue = AbbatoirIntergrade.GumRuntimes.MainMenuEyeRuntime.EyeOpening.Closed;
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
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        if (interpolationValue >= 1)
                        {
                            SetProperty("BackgroundSprite.SourceFile", "../Screens/MainMenu/empty_building.png");
                        }
                        setLeftEyeCurrentEyeOpeningStateSecondValue = true;
                        LeftEyeCurrentEyeOpeningStateSecondValue = AbbatoirIntergrade.GumRuntimes.MainMenuEyeRuntime.EyeOpening.Closed;
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
                        setPressAnyKeyTextAlphaSecondValue = true;
                        PressAnyKeyTextAlphaSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.PressAnyKeyText.Font = "Bahnschrift";
                        }
                        setPressAnyKeyTextFontSizeSecondValue = true;
                        PressAnyKeyTextFontSizeSecondValue = 48;
                        setPressAnyKeyTextHeightSecondValue = true;
                        PressAnyKeyTextHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.PressAnyKeyText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PressAnyKeyText.Text = "Press any key to begin...";
                        }
                        setPressAnyKeyTextWidthSecondValue = true;
                        PressAnyKeyTextWidthSecondValue = 0f;
                        setPressAnyKeyTextXSecondValue = true;
                        PressAnyKeyTextXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.PressAnyKeyText.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PressAnyKeyText.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setPressAnyKeyTextYSecondValue = true;
                        PressAnyKeyTextYSecondValue = 1193f;
                        if (interpolationValue >= 1)
                        {
                            this.PressAnyKeyText.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setRightEyeCurrentEyeOpeningStateSecondValue = true;
                        RightEyeCurrentEyeOpeningStateSecondValue = AbbatoirIntergrade.GumRuntimes.MainMenuEyeRuntime.EyeOpening.Closed;
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
                if (setPressAnyKeyTextAlphaFirstValue && setPressAnyKeyTextAlphaSecondValue)
                {
                    PressAnyKeyText.Alpha = FlatRedBall.Math.MathFunctions.RoundToInt(PressAnyKeyTextAlphaFirstValue* (1 - interpolationValue) + PressAnyKeyTextAlphaSecondValue * interpolationValue);
                }
                if (setPressAnyKeyTextFontSizeFirstValue && setPressAnyKeyTextFontSizeSecondValue)
                {
                    PressAnyKeyText.FontSize = FlatRedBall.Math.MathFunctions.RoundToInt(PressAnyKeyTextFontSizeFirstValue* (1 - interpolationValue) + PressAnyKeyTextFontSizeSecondValue * interpolationValue);
                }
                if (setPressAnyKeyTextHeightFirstValue && setPressAnyKeyTextHeightSecondValue)
                {
                    PressAnyKeyText.Height = PressAnyKeyTextHeightFirstValue * (1 - interpolationValue) + PressAnyKeyTextHeightSecondValue * interpolationValue;
                }
                if (setPressAnyKeyTextWidthFirstValue && setPressAnyKeyTextWidthSecondValue)
                {
                    PressAnyKeyText.Width = PressAnyKeyTextWidthFirstValue * (1 - interpolationValue) + PressAnyKeyTextWidthSecondValue * interpolationValue;
                }
                if (setPressAnyKeyTextXFirstValue && setPressAnyKeyTextXSecondValue)
                {
                    PressAnyKeyText.X = PressAnyKeyTextXFirstValue * (1 - interpolationValue) + PressAnyKeyTextXSecondValue * interpolationValue;
                }
                if (setPressAnyKeyTextYFirstValue && setPressAnyKeyTextYSecondValue)
                {
                    PressAnyKeyText.Y = PressAnyKeyTextYFirstValue * (1 - interpolationValue) + PressAnyKeyTextYSecondValue * interpolationValue;
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
                if (interpolationValue < 1)
                {
                    mCurrentVariableState = firstState;
                }
                else
                {
                    mCurrentVariableState = secondState;
                }
            }
            public void InterpolateBetween (Fade firstState, Fade secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setDimmingInstanceDimmingAlphaFirstValue = false;
                bool setDimmingInstanceDimmingAlphaSecondValue = false;
                int DimmingInstanceDimmingAlphaFirstValue= 0;
                int DimmingInstanceDimmingAlphaSecondValue= 0;
                bool setPressAnyKeyTextAlphaFirstValue = false;
                bool setPressAnyKeyTextAlphaSecondValue = false;
                int PressAnyKeyTextAlphaFirstValue= 0;
                int PressAnyKeyTextAlphaSecondValue= 0;
                switch(firstState)
                {
                    case  Fade.FadedOut:
                        setDimmingInstanceDimmingAlphaFirstValue = true;
                        DimmingInstanceDimmingAlphaFirstValue = 255;
                        setPressAnyKeyTextAlphaFirstValue = true;
                        PressAnyKeyTextAlphaFirstValue = 0;
                        break;
                    case  Fade.NotFaded:
                        setDimmingInstanceDimmingAlphaFirstValue = true;
                        DimmingInstanceDimmingAlphaFirstValue = 0;
                        setPressAnyKeyTextAlphaFirstValue = true;
                        PressAnyKeyTextAlphaFirstValue = 0;
                        break;
                    case  Fade.TextGone:
                        setDimmingInstanceDimmingAlphaFirstValue = true;
                        DimmingInstanceDimmingAlphaFirstValue = 150;
                        setPressAnyKeyTextAlphaFirstValue = true;
                        PressAnyKeyTextAlphaFirstValue = 0;
                        break;
                }
                switch(secondState)
                {
                    case  Fade.FadedOut:
                        setDimmingInstanceDimmingAlphaSecondValue = true;
                        DimmingInstanceDimmingAlphaSecondValue = 255;
                        setPressAnyKeyTextAlphaSecondValue = true;
                        PressAnyKeyTextAlphaSecondValue = 0;
                        break;
                    case  Fade.NotFaded:
                        setDimmingInstanceDimmingAlphaSecondValue = true;
                        DimmingInstanceDimmingAlphaSecondValue = 0;
                        setPressAnyKeyTextAlphaSecondValue = true;
                        PressAnyKeyTextAlphaSecondValue = 0;
                        break;
                    case  Fade.TextGone:
                        setDimmingInstanceDimmingAlphaSecondValue = true;
                        DimmingInstanceDimmingAlphaSecondValue = 150;
                        setPressAnyKeyTextAlphaSecondValue = true;
                        PressAnyKeyTextAlphaSecondValue = 0;
                        break;
                }
                if (setDimmingInstanceDimmingAlphaFirstValue && setDimmingInstanceDimmingAlphaSecondValue)
                {
                    DimmingInstance.DimmingAlpha = FlatRedBall.Math.MathFunctions.RoundToInt(DimmingInstanceDimmingAlphaFirstValue* (1 - interpolationValue) + DimmingInstanceDimmingAlphaSecondValue * interpolationValue);
                }
                if (setPressAnyKeyTextAlphaFirstValue && setPressAnyKeyTextAlphaSecondValue)
                {
                    PressAnyKeyText.Alpha = FlatRedBall.Math.MathFunctions.RoundToInt(PressAnyKeyTextAlphaFirstValue* (1 - interpolationValue) + PressAnyKeyTextAlphaSecondValue * interpolationValue);
                }
                if (interpolationValue < 1)
                {
                    mCurrentFadeState = firstState;
                }
                else
                {
                    mCurrentFadeState = secondState;
                }
            }
            public void InterpolateBetween (AnyKey firstState, AnyKey secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setPressAnyKeyTextAlphaFirstValue = false;
                bool setPressAnyKeyTextAlphaSecondValue = false;
                int PressAnyKeyTextAlphaFirstValue= 0;
                int PressAnyKeyTextAlphaSecondValue= 0;
                switch(firstState)
                {
                    case  AnyKey.Ready:
                        setPressAnyKeyTextAlphaFirstValue = true;
                        PressAnyKeyTextAlphaFirstValue = 255;
                        break;
                    case  AnyKey.NotReady:
                        setPressAnyKeyTextAlphaFirstValue = true;
                        PressAnyKeyTextAlphaFirstValue = 0;
                        break;
                }
                switch(secondState)
                {
                    case  AnyKey.Ready:
                        setPressAnyKeyTextAlphaSecondValue = true;
                        PressAnyKeyTextAlphaSecondValue = 255;
                        break;
                    case  AnyKey.NotReady:
                        setPressAnyKeyTextAlphaSecondValue = true;
                        PressAnyKeyTextAlphaSecondValue = 0;
                        break;
                }
                if (setPressAnyKeyTextAlphaFirstValue && setPressAnyKeyTextAlphaSecondValue)
                {
                    PressAnyKeyText.Alpha = FlatRedBall.Math.MathFunctions.RoundToInt(PressAnyKeyTextAlphaFirstValue* (1 - interpolationValue) + PressAnyKeyTextAlphaSecondValue * interpolationValue);
                }
                if (interpolationValue < 1)
                {
                    mCurrentAnyKeyState = firstState;
                }
                else
                {
                    mCurrentAnyKeyState = secondState;
                }
            }
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.MainMenuGumRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.MainMenuGumRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.MainMenuGumRuntime.Fade fromState,AbbatoirIntergrade.GumRuntimes.MainMenuGumRuntime.Fade toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Fade toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "Fade").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentFadeState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (Fade toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentFadeState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.MainMenuGumRuntime.AnyKey fromState,AbbatoirIntergrade.GumRuntimes.MainMenuGumRuntime.AnyKey toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AnyKey toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "AnyKey").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentAnyKeyState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (AnyKey toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentAnyKeyState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            #endregion
            #region State Animations
            private System.Collections.Generic.IEnumerable<FlatRedBall.Instructions.Instruction> OpenEyesAnimationInstructions (object target) 
            {
                {
                    var instruction = new FlatRedBall.Instructions.DelegateInstruction(()=>LeftEye.OpenEyeAnimation.Play(OpenEyesAnimation));
                    instruction.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0;
                    yield return instruction;
                }
                {
                    var instruction = new FlatRedBall.Instructions.DelegateInstruction(()=>RightEye.OpenEyeAnimation.Play(OpenEyesAnimation));
                    instruction.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0;
                    yield return instruction;
                }
            }
            private System.Collections.Generic.IEnumerable<FlatRedBall.Instructions.Instruction> OpenEyesAnimationRelativeInstructions (object target) 
            {
                {
                    var instruction = new FlatRedBall.Instructions.DelegateInstruction(()=>LeftEye.OpenEyeAnimationRelative.Play(OpenEyesAnimation));
                    instruction.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0;
                    yield return instruction;
                }
                {
                    var instruction = new FlatRedBall.Instructions.DelegateInstruction(()=>RightEye.OpenEyeAnimationRelative.Play(OpenEyesAnimation));
                    instruction.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0;
                    yield return instruction;
                }
            }
            private FlatRedBall.Gum.Animation.GumAnimation openEyesAnimation;
            public FlatRedBall.Gum.Animation.GumAnimation OpenEyesAnimation
            {
                get
                {
                    if (openEyesAnimation == null)
                    {
                        openEyesAnimation = new FlatRedBall.Gum.Animation.GumAnimation(1.8f, OpenEyesAnimationInstructions);
                        openEyesAnimation.SubAnimations.Add(LeftEye.OpenEyeAnimation);
                        openEyesAnimation.SubAnimations.Add(RightEye.OpenEyeAnimation);
                    }
                    return openEyesAnimation;
                }
            }
            private FlatRedBall.Gum.Animation.GumAnimation openEyesAnimationRelative;
            public FlatRedBall.Gum.Animation.GumAnimation OpenEyesAnimationRelative
            {
                get
                {
                    if (openEyesAnimationRelative == null)
                    {
                        openEyesAnimationRelative = new FlatRedBall.Gum.Animation.GumAnimation(1.8f, OpenEyesAnimationRelativeInstructions);
                        openEyesAnimationRelative.SubAnimations.Add(LeftEye.OpenEyeAnimation);
                        openEyesAnimationRelative.SubAnimations.Add(RightEye.OpenEyeAnimation);
                    }
                    return openEyesAnimationRelative;
                }
            }
            private System.Collections.Generic.IEnumerable<FlatRedBall.Instructions.Instruction> BlinkEyesAnimationInstructions (object target) 
            {
                {
                    var instruction = new FlatRedBall.Instructions.DelegateInstruction(()=>LeftEye.BlinkEyeAnimation.Play(BlinkEyesAnimation));
                    instruction.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0;
                    yield return instruction;
                }
                {
                    var instruction = new FlatRedBall.Instructions.DelegateInstruction(()=>RightEye.BlinkEyeAnimation.Play(BlinkEyesAnimation));
                    instruction.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0;
                    yield return instruction;
                }
            }
            private System.Collections.Generic.IEnumerable<FlatRedBall.Instructions.Instruction> BlinkEyesAnimationRelativeInstructions (object target) 
            {
                {
                    var instruction = new FlatRedBall.Instructions.DelegateInstruction(()=>LeftEye.BlinkEyeAnimationRelative.Play(BlinkEyesAnimation));
                    instruction.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0;
                    yield return instruction;
                }
                {
                    var instruction = new FlatRedBall.Instructions.DelegateInstruction(()=>RightEye.BlinkEyeAnimationRelative.Play(BlinkEyesAnimation));
                    instruction.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0;
                    yield return instruction;
                }
            }
            private FlatRedBall.Gum.Animation.GumAnimation blinkEyesAnimation;
            public FlatRedBall.Gum.Animation.GumAnimation BlinkEyesAnimation
            {
                get
                {
                    if (blinkEyesAnimation == null)
                    {
                        blinkEyesAnimation = new FlatRedBall.Gum.Animation.GumAnimation(0.2f, BlinkEyesAnimationInstructions);
                        blinkEyesAnimation.SubAnimations.Add(LeftEye.BlinkEyeAnimation);
                        blinkEyesAnimation.SubAnimations.Add(RightEye.BlinkEyeAnimation);
                    }
                    return blinkEyesAnimation;
                }
            }
            private FlatRedBall.Gum.Animation.GumAnimation blinkEyesAnimationRelative;
            public FlatRedBall.Gum.Animation.GumAnimation BlinkEyesAnimationRelative
            {
                get
                {
                    if (blinkEyesAnimationRelative == null)
                    {
                        blinkEyesAnimationRelative = new FlatRedBall.Gum.Animation.GumAnimation(0.2f, BlinkEyesAnimationRelativeInstructions);
                        blinkEyesAnimationRelative.SubAnimations.Add(LeftEye.BlinkEyeAnimation);
                        blinkEyesAnimationRelative.SubAnimations.Add(RightEye.BlinkEyeAnimation);
                    }
                    return blinkEyesAnimationRelative;
                }
            }
            private System.Collections.Generic.IEnumerable<FlatRedBall.Instructions.Instruction> FadeInAnimationInstructions (object target) 
            {
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction( ()=> this.CurrentFadeState = Fade.FadedOut);
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime;
                    toReturn.Target = target;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(Fade.NotFaded, 0.5f, FlatRedBall.Glue.StateInterpolation.InterpolationType.Quadratic, FlatRedBall.Glue.StateInterpolation.Easing.Out, FadeInAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0;
                    yield return toReturn;
                }
            }
            private System.Collections.Generic.IEnumerable<FlatRedBall.Instructions.Instruction> FadeInAnimationRelativeInstructions (object target) 
            {
                {
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(() =>
                    {
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "Fade/FadedOut").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "Fade/NotFaded").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(Fade.NotFaded);
                        Gum.DataTypes.Variables.StateSave second = first.Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.AddIntoThis(second, difference);
                        FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: 0.5f, type: FlatRedBall.Glue.StateInterpolation.InterpolationType.Quadratic, easing: FlatRedBall.Glue.StateInterpolation.Easing.Out);
                        tweener.Owner = this;
                        tweener.PositionChanged = newPosition => this.InterpolateBetween(first, second, newPosition);
                        tweener.Start();
                        StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                    }
                    );
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0;
                    toReturn.Target = target;
                    yield return toReturn;
                }
            }
            private FlatRedBall.Gum.Animation.GumAnimation fadeInAnimation;
            public FlatRedBall.Gum.Animation.GumAnimation FadeInAnimation
            {
                get
                {
                    if (fadeInAnimation == null)
                    {
                        fadeInAnimation = new FlatRedBall.Gum.Animation.GumAnimation(0.5f, FadeInAnimationInstructions);
                    }
                    return fadeInAnimation;
                }
            }
            private FlatRedBall.Gum.Animation.GumAnimation fadeInAnimationRelative;
            public FlatRedBall.Gum.Animation.GumAnimation FadeInAnimationRelative
            {
                get
                {
                    if (fadeInAnimationRelative == null)
                    {
                        fadeInAnimationRelative = new FlatRedBall.Gum.Animation.GumAnimation(0.5f, FadeInAnimationRelativeInstructions);
                    }
                    return fadeInAnimationRelative;
                }
            }
            private System.Collections.Generic.IEnumerable<FlatRedBall.Instructions.Instruction> ShowAnyKeyAnimationInstructions (object target) 
            {
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction( ()=> this.CurrentAnyKeyState = AnyKey.NotReady);
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime;
                    toReturn.Target = target;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(AnyKey.Ready, 1, FlatRedBall.Glue.StateInterpolation.InterpolationType.Linear, FlatRedBall.Glue.StateInterpolation.Easing.Out, ShowAnyKeyAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0;
                    yield return toReturn;
                }
            }
            private System.Collections.Generic.IEnumerable<FlatRedBall.Instructions.Instruction> ShowAnyKeyAnimationRelativeInstructions (object target) 
            {
                {
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(() =>
                    {
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "AnyKey/NotReady").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "AnyKey/Ready").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(AnyKey.Ready);
                        Gum.DataTypes.Variables.StateSave second = first.Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.AddIntoThis(second, difference);
                        FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: 1, type: FlatRedBall.Glue.StateInterpolation.InterpolationType.Linear, easing: FlatRedBall.Glue.StateInterpolation.Easing.Out);
                        tweener.Owner = this;
                        tweener.PositionChanged = newPosition => this.InterpolateBetween(first, second, newPosition);
                        tweener.Start();
                        StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                    }
                    );
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0;
                    toReturn.Target = target;
                    yield return toReturn;
                }
            }
            private FlatRedBall.Gum.Animation.GumAnimation showAnyKeyAnimation;
            public FlatRedBall.Gum.Animation.GumAnimation ShowAnyKeyAnimation
            {
                get
                {
                    if (showAnyKeyAnimation == null)
                    {
                        showAnyKeyAnimation = new FlatRedBall.Gum.Animation.GumAnimation(1, ShowAnyKeyAnimationInstructions);
                    }
                    return showAnyKeyAnimation;
                }
            }
            private FlatRedBall.Gum.Animation.GumAnimation showAnyKeyAnimationRelative;
            public FlatRedBall.Gum.Animation.GumAnimation ShowAnyKeyAnimationRelative
            {
                get
                {
                    if (showAnyKeyAnimationRelative == null)
                    {
                        showAnyKeyAnimationRelative = new FlatRedBall.Gum.Animation.GumAnimation(1, ShowAnyKeyAnimationRelativeInstructions);
                    }
                    return showAnyKeyAnimationRelative;
                }
            }
            private System.Collections.Generic.IEnumerable<FlatRedBall.Instructions.Instruction> FadeOutAnimationInstructions (object target) 
            {
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction( ()=> this.CurrentFadeState = Fade.NotFaded);
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime;
                    toReturn.Target = target;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(Fade.TextGone, 0.1f, FlatRedBall.Glue.StateInterpolation.InterpolationType.Linear, FlatRedBall.Glue.StateInterpolation.Easing.Out, FadeOutAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(Fade.FadedOut, 0.4f, FlatRedBall.Glue.StateInterpolation.InterpolationType.Linear, FlatRedBall.Glue.StateInterpolation.Easing.Out, FadeOutAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0.1f;
                    yield return toReturn;
                }
            }
            private System.Collections.Generic.IEnumerable<FlatRedBall.Instructions.Instruction> FadeOutAnimationRelativeInstructions (object target) 
            {
                {
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(() =>
                    {
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "Fade/NotFaded").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "Fade/TextGone").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(Fade.TextGone);
                        Gum.DataTypes.Variables.StateSave second = first.Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.AddIntoThis(second, difference);
                        FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: 0.1f, type: FlatRedBall.Glue.StateInterpolation.InterpolationType.Linear, easing: FlatRedBall.Glue.StateInterpolation.Easing.Out);
                        tweener.Owner = this;
                        tweener.PositionChanged = newPosition => this.InterpolateBetween(first, second, newPosition);
                        tweener.Start();
                        StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                    }
                    );
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0;
                    toReturn.Target = target;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(() =>
                    {
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "Fade/TextGone").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "Fade/FadedOut").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(Fade.FadedOut);
                        Gum.DataTypes.Variables.StateSave second = first.Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.AddIntoThis(second, difference);
                        FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: 0.4f, type: FlatRedBall.Glue.StateInterpolation.InterpolationType.Linear, easing: FlatRedBall.Glue.StateInterpolation.Easing.Out);
                        tweener.Owner = this;
                        tweener.PositionChanged = newPosition => this.InterpolateBetween(first, second, newPosition);
                        tweener.Start();
                        StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                    }
                    );
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0.1f;
                    toReturn.Target = target;
                    yield return toReturn;
                }
            }
            private FlatRedBall.Gum.Animation.GumAnimation fadeOutAnimation;
            public FlatRedBall.Gum.Animation.GumAnimation FadeOutAnimation
            {
                get
                {
                    if (fadeOutAnimation == null)
                    {
                        fadeOutAnimation = new FlatRedBall.Gum.Animation.GumAnimation(0.5f, FadeOutAnimationInstructions);
                    }
                    return fadeOutAnimation;
                }
            }
            private FlatRedBall.Gum.Animation.GumAnimation fadeOutAnimationRelative;
            public FlatRedBall.Gum.Animation.GumAnimation FadeOutAnimationRelative
            {
                get
                {
                    if (fadeOutAnimationRelative == null)
                    {
                        fadeOutAnimationRelative = new FlatRedBall.Gum.Animation.GumAnimation(0.5f, FadeOutAnimationRelativeInstructions);
                    }
                    return fadeOutAnimationRelative;
                }
            }
            #endregion
            public override void StopAnimations () 
            {
                base.StopAnimations();
                DimmingInstance.StopAnimations();
                LeftEye.StopAnimations();
                RightEye.StopAnimations();
                OpenEyesAnimation.Stop();
                BlinkEyesAnimation.Stop();
                FadeInAnimation.Stop();
                ShowAnyKeyAnimation.Stop();
                FadeOutAnimation.Stop();
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
                            Name = "BackgroundSprite.SourceFile",
                            Type = "string",
                            Value = BackgroundSprite.SourceFile
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
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PressAnyKeyText.Alpha",
                            Type = "int",
                            Value = PressAnyKeyText.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PressAnyKeyText.Font",
                            Type = "string",
                            Value = PressAnyKeyText.Font
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PressAnyKeyText.FontSize",
                            Type = "int",
                            Value = PressAnyKeyText.FontSize
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PressAnyKeyText.Height",
                            Type = "float",
                            Value = PressAnyKeyText.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PressAnyKeyText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = PressAnyKeyText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PressAnyKeyText.Text",
                            Type = "string",
                            Value = PressAnyKeyText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PressAnyKeyText.Width",
                            Type = "float",
                            Value = PressAnyKeyText.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PressAnyKeyText.X",
                            Type = "float",
                            Value = PressAnyKeyText.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PressAnyKeyText.X Origin",
                            Type = "HorizontalAlignment",
                            Value = PressAnyKeyText.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PressAnyKeyText.X Units",
                            Type = "PositionUnitType",
                            Value = PressAnyKeyText.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PressAnyKeyText.Y",
                            Type = "float",
                            Value = PressAnyKeyText.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PressAnyKeyText.Y Units",
                            Type = "PositionUnitType",
                            Value = PressAnyKeyText.YUnits
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
                            Name = "BackgroundSprite.SourceFile",
                            Type = "string",
                            Value = BackgroundSprite.SourceFile
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
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PressAnyKeyText.Alpha",
                            Type = "int",
                            Value = PressAnyKeyText.Alpha + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PressAnyKeyText.Font",
                            Type = "string",
                            Value = PressAnyKeyText.Font
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PressAnyKeyText.FontSize",
                            Type = "int",
                            Value = PressAnyKeyText.FontSize + 48
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PressAnyKeyText.Height",
                            Type = "float",
                            Value = PressAnyKeyText.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PressAnyKeyText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = PressAnyKeyText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PressAnyKeyText.Text",
                            Type = "string",
                            Value = PressAnyKeyText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PressAnyKeyText.Width",
                            Type = "float",
                            Value = PressAnyKeyText.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PressAnyKeyText.X",
                            Type = "float",
                            Value = PressAnyKeyText.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PressAnyKeyText.X Origin",
                            Type = "HorizontalAlignment",
                            Value = PressAnyKeyText.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PressAnyKeyText.X Units",
                            Type = "PositionUnitType",
                            Value = PressAnyKeyText.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PressAnyKeyText.Y",
                            Type = "float",
                            Value = PressAnyKeyText.Y + 1193f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PressAnyKeyText.Y Units",
                            Type = "PositionUnitType",
                            Value = PressAnyKeyText.YUnits
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (Fade state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  Fade.FadedOut:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DimmingInstance.DimmingAlpha",
                            Type = "int",
                            Value = DimmingInstance.DimmingAlpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PressAnyKeyText.Alpha",
                            Type = "int",
                            Value = PressAnyKeyText.Alpha
                        }
                        );
                        break;
                    case  Fade.NotFaded:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DimmingInstance.DimmingAlpha",
                            Type = "int",
                            Value = DimmingInstance.DimmingAlpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PressAnyKeyText.Alpha",
                            Type = "int",
                            Value = PressAnyKeyText.Alpha
                        }
                        );
                        break;
                    case  Fade.TextGone:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DimmingInstance.DimmingAlpha",
                            Type = "int",
                            Value = DimmingInstance.DimmingAlpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PressAnyKeyText.Alpha",
                            Type = "int",
                            Value = PressAnyKeyText.Alpha
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (Fade state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  Fade.FadedOut:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DimmingInstance.DimmingAlpha",
                            Type = "int",
                            Value = DimmingInstance.DimmingAlpha + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PressAnyKeyText.Alpha",
                            Type = "int",
                            Value = PressAnyKeyText.Alpha + 0
                        }
                        );
                        break;
                    case  Fade.NotFaded:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DimmingInstance.DimmingAlpha",
                            Type = "int",
                            Value = DimmingInstance.DimmingAlpha + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PressAnyKeyText.Alpha",
                            Type = "int",
                            Value = PressAnyKeyText.Alpha + 0
                        }
                        );
                        break;
                    case  Fade.TextGone:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DimmingInstance.DimmingAlpha",
                            Type = "int",
                            Value = DimmingInstance.DimmingAlpha + 150
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PressAnyKeyText.Alpha",
                            Type = "int",
                            Value = PressAnyKeyText.Alpha + 0
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (AnyKey state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  AnyKey.Ready:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PressAnyKeyText.Alpha",
                            Type = "int",
                            Value = PressAnyKeyText.Alpha
                        }
                        );
                        break;
                    case  AnyKey.NotReady:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PressAnyKeyText.Alpha",
                            Type = "int",
                            Value = PressAnyKeyText.Alpha
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (AnyKey state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  AnyKey.Ready:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PressAnyKeyText.Alpha",
                            Type = "int",
                            Value = PressAnyKeyText.Alpha + 255
                        }
                        );
                        break;
                    case  AnyKey.NotReady:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PressAnyKeyText.Alpha",
                            Type = "int",
                            Value = PressAnyKeyText.Alpha + 0
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
                    else if (category.Name == "Fade")
                    {
                        if(state.Name == "FadedOut") this.mCurrentFadeState = Fade.FadedOut;
                        if(state.Name == "NotFaded") this.mCurrentFadeState = Fade.NotFaded;
                        if(state.Name == "TextGone") this.mCurrentFadeState = Fade.TextGone;
                    }
                    else if (category.Name == "AnyKey")
                    {
                        if(state.Name == "Ready") this.mCurrentAnyKeyState = AnyKey.Ready;
                        if(state.Name == "NotReady") this.mCurrentAnyKeyState = AnyKey.NotReady;
                    }
                }
                base.ApplyState(state);
            }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime BackgroundSprite { get; set; }
            private AbbatoirIntergrade.GumRuntimes.DimmingRuntime DimmingInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.MainMenuEyeRuntime LeftEye { get; set; }
            private AbbatoirIntergrade.GumRuntimes.MainMenuEyeRuntime RightEye { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime PressAnyKeyText { get; set; }
            public MainMenuGumRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            {
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Screens.First(item => item.Name == "MainMenuGum");
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
                BackgroundSprite = this.GetGraphicalUiElementByName("BackgroundSprite") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                DimmingInstance = this.GetGraphicalUiElementByName("DimmingInstance") as AbbatoirIntergrade.GumRuntimes.DimmingRuntime;
                LeftEye = this.GetGraphicalUiElementByName("LeftEye") as AbbatoirIntergrade.GumRuntimes.MainMenuEyeRuntime;
                RightEye = this.GetGraphicalUiElementByName("RightEye") as AbbatoirIntergrade.GumRuntimes.MainMenuEyeRuntime;
                PressAnyKeyText = this.GetGraphicalUiElementByName("PressAnyKeyText") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
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
