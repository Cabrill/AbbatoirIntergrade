    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes
    {
        public partial class RadioButtonRuntime : AbbatoirIntergrade.GumRuntimes.ContainerRuntime
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            public enum RadioButtonCategory
            {
                EnabledOn,
                EnabledOff,
                DisabledOn,
                DisabledOff,
                HighlightedOn,
                HighlightedOff,
                PushedOn,
                PushedOff
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            RadioButtonCategory? mCurrentRadioButtonCategoryState;
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
                            Height = 0f;
                            HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            Width = 200f;
                            WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            ColoredRectangleInstance.Blue = 0;
                            ColoredRectangleInstance.Green = 0;
                            ColoredRectangleInstance.Red = 0;
                            ColoredRectangleInstance1.Blue = 255;
                            ColoredRectangleInstance1.Green = 255;
                            ColoredRectangleInstance1.Height = 80f;
                            ColoredRectangleInstance1.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ColoredRectangleInstance1.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ColoredRectangleInstance") ?? this;
                            ColoredRectangleInstance1.Red = 0;
                            ColoredRectangleInstance1.Width = 80f;
                            ColoredRectangleInstance1.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ColoredRectangleInstance1.X = 10f;
                            ColoredRectangleInstance1.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            ColoredRectangleInstance1.Y = 10f;
                            ColoredRectangleInstance1.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            SetProperty("TextInstance.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                            TextInstance.FontScale = 0.3f;
                            TextInstance.Height = 0f;
                            TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            TextInstance.UseCustomFont = true;
                            TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            TextInstance.Width = 0f;
                            TextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            TextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            TextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            break;
                    }
                }
            }
            public RadioButtonCategory? CurrentRadioButtonCategoryState
            {
                get
                {
                    return mCurrentRadioButtonCategoryState;
                }
                set
                {
                    if (value != null)
                    {
                        mCurrentRadioButtonCategoryState = value;
                        switch(mCurrentRadioButtonCategoryState)
                        {
                            case  RadioButtonCategory.EnabledOn:
                                ColoredRectangleInstance.Blue = 0;
                                ColoredRectangleInstance.Green = 0;
                                ColoredRectangleInstance.Red = 0;
                                ColoredRectangleInstance1.Blue = 255;
                                ColoredRectangleInstance1.Green = 255;
                                ColoredRectangleInstance1.Red = 0;
                                ColoredRectangleInstance1.Visible = true;
                                TextInstance.Blue = 255;
                                TextInstance.Green = 255;
                                TextInstance.Red = 0;
                                break;
                            case  RadioButtonCategory.EnabledOff:
                                ColoredRectangleInstance.Blue = 0;
                                ColoredRectangleInstance.Green = 0;
                                ColoredRectangleInstance.Red = 0;
                                ColoredRectangleInstance1.Blue = 255;
                                ColoredRectangleInstance1.Green = 255;
                                ColoredRectangleInstance1.Red = 0;
                                ColoredRectangleInstance1.Visible = false;
                                TextInstance.Blue = 255;
                                TextInstance.Green = 255;
                                TextInstance.Red = 255;
                                break;
                            case  RadioButtonCategory.DisabledOn:
                                ColoredRectangleInstance.Blue = 169;
                                ColoredRectangleInstance.Green = 169;
                                ColoredRectangleInstance.Red = 169;
                                ColoredRectangleInstance1.Blue = 220;
                                ColoredRectangleInstance1.Green = 220;
                                ColoredRectangleInstance1.Red = 220;
                                ColoredRectangleInstance1.Visible = true;
                                TextInstance.Blue = 169;
                                TextInstance.Green = 169;
                                TextInstance.Red = 169;
                                break;
                            case  RadioButtonCategory.DisabledOff:
                                ColoredRectangleInstance.Blue = 169;
                                ColoredRectangleInstance.Green = 169;
                                ColoredRectangleInstance.Red = 169;
                                ColoredRectangleInstance1.Blue = 255;
                                ColoredRectangleInstance1.Green = 255;
                                ColoredRectangleInstance1.Red = 0;
                                ColoredRectangleInstance1.Visible = false;
                                TextInstance.Blue = 169;
                                TextInstance.Green = 169;
                                TextInstance.Red = 169;
                                break;
                            case  RadioButtonCategory.HighlightedOn:
                                ColoredRectangleInstance.Blue = 0;
                                ColoredRectangleInstance.Green = 128;
                                ColoredRectangleInstance.Red = 0;
                                ColoredRectangleInstance1.Blue = 212;
                                ColoredRectangleInstance1.Green = 255;
                                ColoredRectangleInstance1.Red = 127;
                                ColoredRectangleInstance1.Visible = true;
                                TextInstance.Blue = 47;
                                TextInstance.Green = 255;
                                TextInstance.Red = 173;
                                break;
                            case  RadioButtonCategory.HighlightedOff:
                                ColoredRectangleInstance.Blue = 0;
                                ColoredRectangleInstance.Green = 128;
                                ColoredRectangleInstance.Red = 0;
                                ColoredRectangleInstance1.Blue = 255;
                                ColoredRectangleInstance1.Green = 255;
                                ColoredRectangleInstance1.Red = 0;
                                ColoredRectangleInstance1.Visible = false;
                                TextInstance.Blue = 47;
                                TextInstance.Green = 255;
                                TextInstance.Red = 173;
                                break;
                            case  RadioButtonCategory.PushedOn:
                                ColoredRectangleInstance.Blue = 50;
                                ColoredRectangleInstance.Green = 205;
                                ColoredRectangleInstance.Red = 154;
                                ColoredRectangleInstance1.Blue = 0;
                                ColoredRectangleInstance1.Green = 255;
                                ColoredRectangleInstance1.Red = 0;
                                ColoredRectangleInstance1.Visible = true;
                                TextInstance.Blue = 0;
                                TextInstance.Green = 255;
                                TextInstance.Red = 0;
                                break;
                            case  RadioButtonCategory.PushedOff:
                                ColoredRectangleInstance.Blue = 87;
                                ColoredRectangleInstance.Green = 139;
                                ColoredRectangleInstance.Red = 46;
                                ColoredRectangleInstance1.Blue = 0;
                                ColoredRectangleInstance1.Green = 255;
                                ColoredRectangleInstance1.Red = 0;
                                ColoredRectangleInstance1.Visible = false;
                                TextInstance.Blue = 0;
                                TextInstance.Green = 255;
                                TextInstance.Red = 0;
                                break;
                        }
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
                bool setColoredRectangleInstanceBlueFirstValue = false;
                bool setColoredRectangleInstanceBlueSecondValue = false;
                int ColoredRectangleInstanceBlueFirstValue= 0;
                int ColoredRectangleInstanceBlueSecondValue= 0;
                bool setColoredRectangleInstanceGreenFirstValue = false;
                bool setColoredRectangleInstanceGreenSecondValue = false;
                int ColoredRectangleInstanceGreenFirstValue= 0;
                int ColoredRectangleInstanceGreenSecondValue= 0;
                bool setColoredRectangleInstanceRedFirstValue = false;
                bool setColoredRectangleInstanceRedSecondValue = false;
                int ColoredRectangleInstanceRedFirstValue= 0;
                int ColoredRectangleInstanceRedSecondValue= 0;
                bool setColoredRectangleInstance1BlueFirstValue = false;
                bool setColoredRectangleInstance1BlueSecondValue = false;
                int ColoredRectangleInstance1BlueFirstValue= 0;
                int ColoredRectangleInstance1BlueSecondValue= 0;
                bool setColoredRectangleInstance1GreenFirstValue = false;
                bool setColoredRectangleInstance1GreenSecondValue = false;
                int ColoredRectangleInstance1GreenFirstValue= 0;
                int ColoredRectangleInstance1GreenSecondValue= 0;
                bool setColoredRectangleInstance1HeightFirstValue = false;
                bool setColoredRectangleInstance1HeightSecondValue = false;
                float ColoredRectangleInstance1HeightFirstValue= 0;
                float ColoredRectangleInstance1HeightSecondValue= 0;
                bool setColoredRectangleInstance1RedFirstValue = false;
                bool setColoredRectangleInstance1RedSecondValue = false;
                int ColoredRectangleInstance1RedFirstValue= 0;
                int ColoredRectangleInstance1RedSecondValue= 0;
                bool setColoredRectangleInstance1WidthFirstValue = false;
                bool setColoredRectangleInstance1WidthSecondValue = false;
                float ColoredRectangleInstance1WidthFirstValue= 0;
                float ColoredRectangleInstance1WidthSecondValue= 0;
                bool setColoredRectangleInstance1XFirstValue = false;
                bool setColoredRectangleInstance1XSecondValue = false;
                float ColoredRectangleInstance1XFirstValue= 0;
                float ColoredRectangleInstance1XSecondValue= 0;
                bool setColoredRectangleInstance1YFirstValue = false;
                bool setColoredRectangleInstance1YSecondValue = false;
                float ColoredRectangleInstance1YFirstValue= 0;
                float ColoredRectangleInstance1YSecondValue= 0;
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setTextInstanceFontScaleFirstValue = false;
                bool setTextInstanceFontScaleSecondValue = false;
                float TextInstanceFontScaleFirstValue= 0;
                float TextInstanceFontScaleSecondValue= 0;
                bool setTextInstanceHeightFirstValue = false;
                bool setTextInstanceHeightSecondValue = false;
                float TextInstanceHeightFirstValue= 0;
                float TextInstanceHeightSecondValue= 0;
                bool setTextInstanceWidthFirstValue = false;
                bool setTextInstanceWidthSecondValue = false;
                float TextInstanceWidthFirstValue= 0;
                float TextInstanceWidthSecondValue= 0;
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
                        setColoredRectangleInstanceBlueFirstValue = true;
                        ColoredRectangleInstanceBlueFirstValue = 0;
                        setColoredRectangleInstanceGreenFirstValue = true;
                        ColoredRectangleInstanceGreenFirstValue = 0;
                        setColoredRectangleInstanceRedFirstValue = true;
                        ColoredRectangleInstanceRedFirstValue = 0;
                        setColoredRectangleInstance1BlueFirstValue = true;
                        ColoredRectangleInstance1BlueFirstValue = 255;
                        setColoredRectangleInstance1GreenFirstValue = true;
                        ColoredRectangleInstance1GreenFirstValue = 255;
                        setColoredRectangleInstance1HeightFirstValue = true;
                        ColoredRectangleInstance1HeightFirstValue = 80f;
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance1.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance1.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ColoredRectangleInstance") ?? this;
                        }
                        setColoredRectangleInstance1RedFirstValue = true;
                        ColoredRectangleInstance1RedFirstValue = 0;
                        setColoredRectangleInstance1WidthFirstValue = true;
                        ColoredRectangleInstance1WidthFirstValue = 80f;
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance1.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setColoredRectangleInstance1XFirstValue = true;
                        ColoredRectangleInstance1XFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance1.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setColoredRectangleInstance1YFirstValue = true;
                        ColoredRectangleInstance1YFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance1.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setHeightFirstValue = true;
                        HeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("TextInstance.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setTextInstanceFontScaleFirstValue = true;
                        TextInstanceFontScaleFirstValue = 0.3f;
                        setTextInstanceHeightFirstValue = true;
                        TextInstanceHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.UseCustomFont = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setTextInstanceWidthFirstValue = true;
                        TextInstanceWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setWidthFirstValue = true;
                        WidthFirstValue = 200f;
                        if (interpolationValue < 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
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
                        setColoredRectangleInstanceBlueSecondValue = true;
                        ColoredRectangleInstanceBlueSecondValue = 0;
                        setColoredRectangleInstanceGreenSecondValue = true;
                        ColoredRectangleInstanceGreenSecondValue = 0;
                        setColoredRectangleInstanceRedSecondValue = true;
                        ColoredRectangleInstanceRedSecondValue = 0;
                        setColoredRectangleInstance1BlueSecondValue = true;
                        ColoredRectangleInstance1BlueSecondValue = 255;
                        setColoredRectangleInstance1GreenSecondValue = true;
                        ColoredRectangleInstance1GreenSecondValue = 255;
                        setColoredRectangleInstance1HeightSecondValue = true;
                        ColoredRectangleInstance1HeightSecondValue = 80f;
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance1.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance1.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ColoredRectangleInstance") ?? this;
                        }
                        setColoredRectangleInstance1RedSecondValue = true;
                        ColoredRectangleInstance1RedSecondValue = 0;
                        setColoredRectangleInstance1WidthSecondValue = true;
                        ColoredRectangleInstance1WidthSecondValue = 80f;
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance1.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setColoredRectangleInstance1XSecondValue = true;
                        ColoredRectangleInstance1XSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance1.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setColoredRectangleInstance1YSecondValue = true;
                        ColoredRectangleInstance1YSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance1.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setHeightSecondValue = true;
                        HeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("TextInstance.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setTextInstanceFontScaleSecondValue = true;
                        TextInstanceFontScaleSecondValue = 0.3f;
                        setTextInstanceHeightSecondValue = true;
                        TextInstanceHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.UseCustomFont = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setTextInstanceWidthSecondValue = true;
                        TextInstanceWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setWidthSecondValue = true;
                        WidthSecondValue = 200f;
                        if (interpolationValue >= 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        break;
                }
                if (setColoredRectangleInstanceBlueFirstValue && setColoredRectangleInstanceBlueSecondValue)
                {
                    ColoredRectangleInstance.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(ColoredRectangleInstanceBlueFirstValue* (1 - interpolationValue) + ColoredRectangleInstanceBlueSecondValue * interpolationValue);
                }
                if (setColoredRectangleInstanceGreenFirstValue && setColoredRectangleInstanceGreenSecondValue)
                {
                    ColoredRectangleInstance.Green = FlatRedBall.Math.MathFunctions.RoundToInt(ColoredRectangleInstanceGreenFirstValue* (1 - interpolationValue) + ColoredRectangleInstanceGreenSecondValue * interpolationValue);
                }
                if (setColoredRectangleInstanceRedFirstValue && setColoredRectangleInstanceRedSecondValue)
                {
                    ColoredRectangleInstance.Red = FlatRedBall.Math.MathFunctions.RoundToInt(ColoredRectangleInstanceRedFirstValue* (1 - interpolationValue) + ColoredRectangleInstanceRedSecondValue * interpolationValue);
                }
                if (setColoredRectangleInstance1BlueFirstValue && setColoredRectangleInstance1BlueSecondValue)
                {
                    ColoredRectangleInstance1.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(ColoredRectangleInstance1BlueFirstValue* (1 - interpolationValue) + ColoredRectangleInstance1BlueSecondValue * interpolationValue);
                }
                if (setColoredRectangleInstance1GreenFirstValue && setColoredRectangleInstance1GreenSecondValue)
                {
                    ColoredRectangleInstance1.Green = FlatRedBall.Math.MathFunctions.RoundToInt(ColoredRectangleInstance1GreenFirstValue* (1 - interpolationValue) + ColoredRectangleInstance1GreenSecondValue * interpolationValue);
                }
                if (setColoredRectangleInstance1HeightFirstValue && setColoredRectangleInstance1HeightSecondValue)
                {
                    ColoredRectangleInstance1.Height = ColoredRectangleInstance1HeightFirstValue * (1 - interpolationValue) + ColoredRectangleInstance1HeightSecondValue * interpolationValue;
                }
                if (setColoredRectangleInstance1RedFirstValue && setColoredRectangleInstance1RedSecondValue)
                {
                    ColoredRectangleInstance1.Red = FlatRedBall.Math.MathFunctions.RoundToInt(ColoredRectangleInstance1RedFirstValue* (1 - interpolationValue) + ColoredRectangleInstance1RedSecondValue * interpolationValue);
                }
                if (setColoredRectangleInstance1WidthFirstValue && setColoredRectangleInstance1WidthSecondValue)
                {
                    ColoredRectangleInstance1.Width = ColoredRectangleInstance1WidthFirstValue * (1 - interpolationValue) + ColoredRectangleInstance1WidthSecondValue * interpolationValue;
                }
                if (setColoredRectangleInstance1XFirstValue && setColoredRectangleInstance1XSecondValue)
                {
                    ColoredRectangleInstance1.X = ColoredRectangleInstance1XFirstValue * (1 - interpolationValue) + ColoredRectangleInstance1XSecondValue * interpolationValue;
                }
                if (setColoredRectangleInstance1YFirstValue && setColoredRectangleInstance1YSecondValue)
                {
                    ColoredRectangleInstance1.Y = ColoredRectangleInstance1YFirstValue * (1 - interpolationValue) + ColoredRectangleInstance1YSecondValue * interpolationValue;
                }
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
                }
                if (setTextInstanceFontScaleFirstValue && setTextInstanceFontScaleSecondValue)
                {
                    TextInstance.FontScale = TextInstanceFontScaleFirstValue * (1 - interpolationValue) + TextInstanceFontScaleSecondValue * interpolationValue;
                }
                if (setTextInstanceHeightFirstValue && setTextInstanceHeightSecondValue)
                {
                    TextInstance.Height = TextInstanceHeightFirstValue * (1 - interpolationValue) + TextInstanceHeightSecondValue * interpolationValue;
                }
                if (setTextInstanceWidthFirstValue && setTextInstanceWidthSecondValue)
                {
                    TextInstance.Width = TextInstanceWidthFirstValue * (1 - interpolationValue) + TextInstanceWidthSecondValue * interpolationValue;
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
            public void InterpolateBetween (RadioButtonCategory firstState, RadioButtonCategory secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setColoredRectangleInstanceBlueFirstValue = false;
                bool setColoredRectangleInstanceBlueSecondValue = false;
                int ColoredRectangleInstanceBlueFirstValue= 0;
                int ColoredRectangleInstanceBlueSecondValue= 0;
                bool setColoredRectangleInstanceGreenFirstValue = false;
                bool setColoredRectangleInstanceGreenSecondValue = false;
                int ColoredRectangleInstanceGreenFirstValue= 0;
                int ColoredRectangleInstanceGreenSecondValue= 0;
                bool setColoredRectangleInstanceRedFirstValue = false;
                bool setColoredRectangleInstanceRedSecondValue = false;
                int ColoredRectangleInstanceRedFirstValue= 0;
                int ColoredRectangleInstanceRedSecondValue= 0;
                bool setColoredRectangleInstance1BlueFirstValue = false;
                bool setColoredRectangleInstance1BlueSecondValue = false;
                int ColoredRectangleInstance1BlueFirstValue= 0;
                int ColoredRectangleInstance1BlueSecondValue= 0;
                bool setColoredRectangleInstance1GreenFirstValue = false;
                bool setColoredRectangleInstance1GreenSecondValue = false;
                int ColoredRectangleInstance1GreenFirstValue= 0;
                int ColoredRectangleInstance1GreenSecondValue= 0;
                bool setColoredRectangleInstance1RedFirstValue = false;
                bool setColoredRectangleInstance1RedSecondValue = false;
                int ColoredRectangleInstance1RedFirstValue= 0;
                int ColoredRectangleInstance1RedSecondValue= 0;
                bool setTextInstanceBlueFirstValue = false;
                bool setTextInstanceBlueSecondValue = false;
                int TextInstanceBlueFirstValue= 0;
                int TextInstanceBlueSecondValue= 0;
                bool setTextInstanceGreenFirstValue = false;
                bool setTextInstanceGreenSecondValue = false;
                int TextInstanceGreenFirstValue= 0;
                int TextInstanceGreenSecondValue= 0;
                bool setTextInstanceRedFirstValue = false;
                bool setTextInstanceRedSecondValue = false;
                int TextInstanceRedFirstValue= 0;
                int TextInstanceRedSecondValue= 0;
                switch(firstState)
                {
                    case  RadioButtonCategory.EnabledOn:
                        setColoredRectangleInstanceBlueFirstValue = true;
                        ColoredRectangleInstanceBlueFirstValue = 0;
                        setColoredRectangleInstanceGreenFirstValue = true;
                        ColoredRectangleInstanceGreenFirstValue = 0;
                        setColoredRectangleInstanceRedFirstValue = true;
                        ColoredRectangleInstanceRedFirstValue = 0;
                        setColoredRectangleInstance1BlueFirstValue = true;
                        ColoredRectangleInstance1BlueFirstValue = 255;
                        setColoredRectangleInstance1GreenFirstValue = true;
                        ColoredRectangleInstance1GreenFirstValue = 255;
                        setColoredRectangleInstance1RedFirstValue = true;
                        ColoredRectangleInstance1RedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance1.Visible = true;
                        }
                        setTextInstanceBlueFirstValue = true;
                        TextInstanceBlueFirstValue = 255;
                        setTextInstanceGreenFirstValue = true;
                        TextInstanceGreenFirstValue = 255;
                        setTextInstanceRedFirstValue = true;
                        TextInstanceRedFirstValue = 0;
                        break;
                    case  RadioButtonCategory.EnabledOff:
                        setColoredRectangleInstanceBlueFirstValue = true;
                        ColoredRectangleInstanceBlueFirstValue = 0;
                        setColoredRectangleInstanceGreenFirstValue = true;
                        ColoredRectangleInstanceGreenFirstValue = 0;
                        setColoredRectangleInstanceRedFirstValue = true;
                        ColoredRectangleInstanceRedFirstValue = 0;
                        setColoredRectangleInstance1BlueFirstValue = true;
                        ColoredRectangleInstance1BlueFirstValue = 255;
                        setColoredRectangleInstance1GreenFirstValue = true;
                        ColoredRectangleInstance1GreenFirstValue = 255;
                        setColoredRectangleInstance1RedFirstValue = true;
                        ColoredRectangleInstance1RedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance1.Visible = false;
                        }
                        setTextInstanceBlueFirstValue = true;
                        TextInstanceBlueFirstValue = 255;
                        setTextInstanceGreenFirstValue = true;
                        TextInstanceGreenFirstValue = 255;
                        setTextInstanceRedFirstValue = true;
                        TextInstanceRedFirstValue = 255;
                        break;
                    case  RadioButtonCategory.DisabledOn:
                        setColoredRectangleInstanceBlueFirstValue = true;
                        ColoredRectangleInstanceBlueFirstValue = 169;
                        setColoredRectangleInstanceGreenFirstValue = true;
                        ColoredRectangleInstanceGreenFirstValue = 169;
                        setColoredRectangleInstanceRedFirstValue = true;
                        ColoredRectangleInstanceRedFirstValue = 169;
                        setColoredRectangleInstance1BlueFirstValue = true;
                        ColoredRectangleInstance1BlueFirstValue = 220;
                        setColoredRectangleInstance1GreenFirstValue = true;
                        ColoredRectangleInstance1GreenFirstValue = 220;
                        setColoredRectangleInstance1RedFirstValue = true;
                        ColoredRectangleInstance1RedFirstValue = 220;
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance1.Visible = true;
                        }
                        setTextInstanceBlueFirstValue = true;
                        TextInstanceBlueFirstValue = 169;
                        setTextInstanceGreenFirstValue = true;
                        TextInstanceGreenFirstValue = 169;
                        setTextInstanceRedFirstValue = true;
                        TextInstanceRedFirstValue = 169;
                        break;
                    case  RadioButtonCategory.DisabledOff:
                        setColoredRectangleInstanceBlueFirstValue = true;
                        ColoredRectangleInstanceBlueFirstValue = 169;
                        setColoredRectangleInstanceGreenFirstValue = true;
                        ColoredRectangleInstanceGreenFirstValue = 169;
                        setColoredRectangleInstanceRedFirstValue = true;
                        ColoredRectangleInstanceRedFirstValue = 169;
                        setColoredRectangleInstance1BlueFirstValue = true;
                        ColoredRectangleInstance1BlueFirstValue = 255;
                        setColoredRectangleInstance1GreenFirstValue = true;
                        ColoredRectangleInstance1GreenFirstValue = 255;
                        setColoredRectangleInstance1RedFirstValue = true;
                        ColoredRectangleInstance1RedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance1.Visible = false;
                        }
                        setTextInstanceBlueFirstValue = true;
                        TextInstanceBlueFirstValue = 169;
                        setTextInstanceGreenFirstValue = true;
                        TextInstanceGreenFirstValue = 169;
                        setTextInstanceRedFirstValue = true;
                        TextInstanceRedFirstValue = 169;
                        break;
                    case  RadioButtonCategory.HighlightedOn:
                        setColoredRectangleInstanceBlueFirstValue = true;
                        ColoredRectangleInstanceBlueFirstValue = 0;
                        setColoredRectangleInstanceGreenFirstValue = true;
                        ColoredRectangleInstanceGreenFirstValue = 128;
                        setColoredRectangleInstanceRedFirstValue = true;
                        ColoredRectangleInstanceRedFirstValue = 0;
                        setColoredRectangleInstance1BlueFirstValue = true;
                        ColoredRectangleInstance1BlueFirstValue = 212;
                        setColoredRectangleInstance1GreenFirstValue = true;
                        ColoredRectangleInstance1GreenFirstValue = 255;
                        setColoredRectangleInstance1RedFirstValue = true;
                        ColoredRectangleInstance1RedFirstValue = 127;
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance1.Visible = true;
                        }
                        setTextInstanceBlueFirstValue = true;
                        TextInstanceBlueFirstValue = 47;
                        setTextInstanceGreenFirstValue = true;
                        TextInstanceGreenFirstValue = 255;
                        setTextInstanceRedFirstValue = true;
                        TextInstanceRedFirstValue = 173;
                        break;
                    case  RadioButtonCategory.HighlightedOff:
                        setColoredRectangleInstanceBlueFirstValue = true;
                        ColoredRectangleInstanceBlueFirstValue = 0;
                        setColoredRectangleInstanceGreenFirstValue = true;
                        ColoredRectangleInstanceGreenFirstValue = 128;
                        setColoredRectangleInstanceRedFirstValue = true;
                        ColoredRectangleInstanceRedFirstValue = 0;
                        setColoredRectangleInstance1BlueFirstValue = true;
                        ColoredRectangleInstance1BlueFirstValue = 255;
                        setColoredRectangleInstance1GreenFirstValue = true;
                        ColoredRectangleInstance1GreenFirstValue = 255;
                        setColoredRectangleInstance1RedFirstValue = true;
                        ColoredRectangleInstance1RedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance1.Visible = false;
                        }
                        setTextInstanceBlueFirstValue = true;
                        TextInstanceBlueFirstValue = 47;
                        setTextInstanceGreenFirstValue = true;
                        TextInstanceGreenFirstValue = 255;
                        setTextInstanceRedFirstValue = true;
                        TextInstanceRedFirstValue = 173;
                        break;
                    case  RadioButtonCategory.PushedOn:
                        setColoredRectangleInstanceBlueFirstValue = true;
                        ColoredRectangleInstanceBlueFirstValue = 50;
                        setColoredRectangleInstanceGreenFirstValue = true;
                        ColoredRectangleInstanceGreenFirstValue = 205;
                        setColoredRectangleInstanceRedFirstValue = true;
                        ColoredRectangleInstanceRedFirstValue = 154;
                        setColoredRectangleInstance1BlueFirstValue = true;
                        ColoredRectangleInstance1BlueFirstValue = 0;
                        setColoredRectangleInstance1GreenFirstValue = true;
                        ColoredRectangleInstance1GreenFirstValue = 255;
                        setColoredRectangleInstance1RedFirstValue = true;
                        ColoredRectangleInstance1RedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance1.Visible = true;
                        }
                        setTextInstanceBlueFirstValue = true;
                        TextInstanceBlueFirstValue = 0;
                        setTextInstanceGreenFirstValue = true;
                        TextInstanceGreenFirstValue = 255;
                        setTextInstanceRedFirstValue = true;
                        TextInstanceRedFirstValue = 0;
                        break;
                    case  RadioButtonCategory.PushedOff:
                        setColoredRectangleInstanceBlueFirstValue = true;
                        ColoredRectangleInstanceBlueFirstValue = 87;
                        setColoredRectangleInstanceGreenFirstValue = true;
                        ColoredRectangleInstanceGreenFirstValue = 139;
                        setColoredRectangleInstanceRedFirstValue = true;
                        ColoredRectangleInstanceRedFirstValue = 46;
                        setColoredRectangleInstance1BlueFirstValue = true;
                        ColoredRectangleInstance1BlueFirstValue = 0;
                        setColoredRectangleInstance1GreenFirstValue = true;
                        ColoredRectangleInstance1GreenFirstValue = 255;
                        setColoredRectangleInstance1RedFirstValue = true;
                        ColoredRectangleInstance1RedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance1.Visible = false;
                        }
                        setTextInstanceBlueFirstValue = true;
                        TextInstanceBlueFirstValue = 0;
                        setTextInstanceGreenFirstValue = true;
                        TextInstanceGreenFirstValue = 255;
                        setTextInstanceRedFirstValue = true;
                        TextInstanceRedFirstValue = 0;
                        break;
                }
                switch(secondState)
                {
                    case  RadioButtonCategory.EnabledOn:
                        setColoredRectangleInstanceBlueSecondValue = true;
                        ColoredRectangleInstanceBlueSecondValue = 0;
                        setColoredRectangleInstanceGreenSecondValue = true;
                        ColoredRectangleInstanceGreenSecondValue = 0;
                        setColoredRectangleInstanceRedSecondValue = true;
                        ColoredRectangleInstanceRedSecondValue = 0;
                        setColoredRectangleInstance1BlueSecondValue = true;
                        ColoredRectangleInstance1BlueSecondValue = 255;
                        setColoredRectangleInstance1GreenSecondValue = true;
                        ColoredRectangleInstance1GreenSecondValue = 255;
                        setColoredRectangleInstance1RedSecondValue = true;
                        ColoredRectangleInstance1RedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance1.Visible = true;
                        }
                        setTextInstanceBlueSecondValue = true;
                        TextInstanceBlueSecondValue = 255;
                        setTextInstanceGreenSecondValue = true;
                        TextInstanceGreenSecondValue = 255;
                        setTextInstanceRedSecondValue = true;
                        TextInstanceRedSecondValue = 0;
                        break;
                    case  RadioButtonCategory.EnabledOff:
                        setColoredRectangleInstanceBlueSecondValue = true;
                        ColoredRectangleInstanceBlueSecondValue = 0;
                        setColoredRectangleInstanceGreenSecondValue = true;
                        ColoredRectangleInstanceGreenSecondValue = 0;
                        setColoredRectangleInstanceRedSecondValue = true;
                        ColoredRectangleInstanceRedSecondValue = 0;
                        setColoredRectangleInstance1BlueSecondValue = true;
                        ColoredRectangleInstance1BlueSecondValue = 255;
                        setColoredRectangleInstance1GreenSecondValue = true;
                        ColoredRectangleInstance1GreenSecondValue = 255;
                        setColoredRectangleInstance1RedSecondValue = true;
                        ColoredRectangleInstance1RedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance1.Visible = false;
                        }
                        setTextInstanceBlueSecondValue = true;
                        TextInstanceBlueSecondValue = 255;
                        setTextInstanceGreenSecondValue = true;
                        TextInstanceGreenSecondValue = 255;
                        setTextInstanceRedSecondValue = true;
                        TextInstanceRedSecondValue = 255;
                        break;
                    case  RadioButtonCategory.DisabledOn:
                        setColoredRectangleInstanceBlueSecondValue = true;
                        ColoredRectangleInstanceBlueSecondValue = 169;
                        setColoredRectangleInstanceGreenSecondValue = true;
                        ColoredRectangleInstanceGreenSecondValue = 169;
                        setColoredRectangleInstanceRedSecondValue = true;
                        ColoredRectangleInstanceRedSecondValue = 169;
                        setColoredRectangleInstance1BlueSecondValue = true;
                        ColoredRectangleInstance1BlueSecondValue = 220;
                        setColoredRectangleInstance1GreenSecondValue = true;
                        ColoredRectangleInstance1GreenSecondValue = 220;
                        setColoredRectangleInstance1RedSecondValue = true;
                        ColoredRectangleInstance1RedSecondValue = 220;
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance1.Visible = true;
                        }
                        setTextInstanceBlueSecondValue = true;
                        TextInstanceBlueSecondValue = 169;
                        setTextInstanceGreenSecondValue = true;
                        TextInstanceGreenSecondValue = 169;
                        setTextInstanceRedSecondValue = true;
                        TextInstanceRedSecondValue = 169;
                        break;
                    case  RadioButtonCategory.DisabledOff:
                        setColoredRectangleInstanceBlueSecondValue = true;
                        ColoredRectangleInstanceBlueSecondValue = 169;
                        setColoredRectangleInstanceGreenSecondValue = true;
                        ColoredRectangleInstanceGreenSecondValue = 169;
                        setColoredRectangleInstanceRedSecondValue = true;
                        ColoredRectangleInstanceRedSecondValue = 169;
                        setColoredRectangleInstance1BlueSecondValue = true;
                        ColoredRectangleInstance1BlueSecondValue = 255;
                        setColoredRectangleInstance1GreenSecondValue = true;
                        ColoredRectangleInstance1GreenSecondValue = 255;
                        setColoredRectangleInstance1RedSecondValue = true;
                        ColoredRectangleInstance1RedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance1.Visible = false;
                        }
                        setTextInstanceBlueSecondValue = true;
                        TextInstanceBlueSecondValue = 169;
                        setTextInstanceGreenSecondValue = true;
                        TextInstanceGreenSecondValue = 169;
                        setTextInstanceRedSecondValue = true;
                        TextInstanceRedSecondValue = 169;
                        break;
                    case  RadioButtonCategory.HighlightedOn:
                        setColoredRectangleInstanceBlueSecondValue = true;
                        ColoredRectangleInstanceBlueSecondValue = 0;
                        setColoredRectangleInstanceGreenSecondValue = true;
                        ColoredRectangleInstanceGreenSecondValue = 128;
                        setColoredRectangleInstanceRedSecondValue = true;
                        ColoredRectangleInstanceRedSecondValue = 0;
                        setColoredRectangleInstance1BlueSecondValue = true;
                        ColoredRectangleInstance1BlueSecondValue = 212;
                        setColoredRectangleInstance1GreenSecondValue = true;
                        ColoredRectangleInstance1GreenSecondValue = 255;
                        setColoredRectangleInstance1RedSecondValue = true;
                        ColoredRectangleInstance1RedSecondValue = 127;
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance1.Visible = true;
                        }
                        setTextInstanceBlueSecondValue = true;
                        TextInstanceBlueSecondValue = 47;
                        setTextInstanceGreenSecondValue = true;
                        TextInstanceGreenSecondValue = 255;
                        setTextInstanceRedSecondValue = true;
                        TextInstanceRedSecondValue = 173;
                        break;
                    case  RadioButtonCategory.HighlightedOff:
                        setColoredRectangleInstanceBlueSecondValue = true;
                        ColoredRectangleInstanceBlueSecondValue = 0;
                        setColoredRectangleInstanceGreenSecondValue = true;
                        ColoredRectangleInstanceGreenSecondValue = 128;
                        setColoredRectangleInstanceRedSecondValue = true;
                        ColoredRectangleInstanceRedSecondValue = 0;
                        setColoredRectangleInstance1BlueSecondValue = true;
                        ColoredRectangleInstance1BlueSecondValue = 255;
                        setColoredRectangleInstance1GreenSecondValue = true;
                        ColoredRectangleInstance1GreenSecondValue = 255;
                        setColoredRectangleInstance1RedSecondValue = true;
                        ColoredRectangleInstance1RedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance1.Visible = false;
                        }
                        setTextInstanceBlueSecondValue = true;
                        TextInstanceBlueSecondValue = 47;
                        setTextInstanceGreenSecondValue = true;
                        TextInstanceGreenSecondValue = 255;
                        setTextInstanceRedSecondValue = true;
                        TextInstanceRedSecondValue = 173;
                        break;
                    case  RadioButtonCategory.PushedOn:
                        setColoredRectangleInstanceBlueSecondValue = true;
                        ColoredRectangleInstanceBlueSecondValue = 50;
                        setColoredRectangleInstanceGreenSecondValue = true;
                        ColoredRectangleInstanceGreenSecondValue = 205;
                        setColoredRectangleInstanceRedSecondValue = true;
                        ColoredRectangleInstanceRedSecondValue = 154;
                        setColoredRectangleInstance1BlueSecondValue = true;
                        ColoredRectangleInstance1BlueSecondValue = 0;
                        setColoredRectangleInstance1GreenSecondValue = true;
                        ColoredRectangleInstance1GreenSecondValue = 255;
                        setColoredRectangleInstance1RedSecondValue = true;
                        ColoredRectangleInstance1RedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance1.Visible = true;
                        }
                        setTextInstanceBlueSecondValue = true;
                        TextInstanceBlueSecondValue = 0;
                        setTextInstanceGreenSecondValue = true;
                        TextInstanceGreenSecondValue = 255;
                        setTextInstanceRedSecondValue = true;
                        TextInstanceRedSecondValue = 0;
                        break;
                    case  RadioButtonCategory.PushedOff:
                        setColoredRectangleInstanceBlueSecondValue = true;
                        ColoredRectangleInstanceBlueSecondValue = 87;
                        setColoredRectangleInstanceGreenSecondValue = true;
                        ColoredRectangleInstanceGreenSecondValue = 139;
                        setColoredRectangleInstanceRedSecondValue = true;
                        ColoredRectangleInstanceRedSecondValue = 46;
                        setColoredRectangleInstance1BlueSecondValue = true;
                        ColoredRectangleInstance1BlueSecondValue = 0;
                        setColoredRectangleInstance1GreenSecondValue = true;
                        ColoredRectangleInstance1GreenSecondValue = 255;
                        setColoredRectangleInstance1RedSecondValue = true;
                        ColoredRectangleInstance1RedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance1.Visible = false;
                        }
                        setTextInstanceBlueSecondValue = true;
                        TextInstanceBlueSecondValue = 0;
                        setTextInstanceGreenSecondValue = true;
                        TextInstanceGreenSecondValue = 255;
                        setTextInstanceRedSecondValue = true;
                        TextInstanceRedSecondValue = 0;
                        break;
                }
                if (setColoredRectangleInstanceBlueFirstValue && setColoredRectangleInstanceBlueSecondValue)
                {
                    ColoredRectangleInstance.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(ColoredRectangleInstanceBlueFirstValue* (1 - interpolationValue) + ColoredRectangleInstanceBlueSecondValue * interpolationValue);
                }
                if (setColoredRectangleInstanceGreenFirstValue && setColoredRectangleInstanceGreenSecondValue)
                {
                    ColoredRectangleInstance.Green = FlatRedBall.Math.MathFunctions.RoundToInt(ColoredRectangleInstanceGreenFirstValue* (1 - interpolationValue) + ColoredRectangleInstanceGreenSecondValue * interpolationValue);
                }
                if (setColoredRectangleInstanceRedFirstValue && setColoredRectangleInstanceRedSecondValue)
                {
                    ColoredRectangleInstance.Red = FlatRedBall.Math.MathFunctions.RoundToInt(ColoredRectangleInstanceRedFirstValue* (1 - interpolationValue) + ColoredRectangleInstanceRedSecondValue * interpolationValue);
                }
                if (setColoredRectangleInstance1BlueFirstValue && setColoredRectangleInstance1BlueSecondValue)
                {
                    ColoredRectangleInstance1.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(ColoredRectangleInstance1BlueFirstValue* (1 - interpolationValue) + ColoredRectangleInstance1BlueSecondValue * interpolationValue);
                }
                if (setColoredRectangleInstance1GreenFirstValue && setColoredRectangleInstance1GreenSecondValue)
                {
                    ColoredRectangleInstance1.Green = FlatRedBall.Math.MathFunctions.RoundToInt(ColoredRectangleInstance1GreenFirstValue* (1 - interpolationValue) + ColoredRectangleInstance1GreenSecondValue * interpolationValue);
                }
                if (setColoredRectangleInstance1RedFirstValue && setColoredRectangleInstance1RedSecondValue)
                {
                    ColoredRectangleInstance1.Red = FlatRedBall.Math.MathFunctions.RoundToInt(ColoredRectangleInstance1RedFirstValue* (1 - interpolationValue) + ColoredRectangleInstance1RedSecondValue * interpolationValue);
                }
                if (setTextInstanceBlueFirstValue && setTextInstanceBlueSecondValue)
                {
                    TextInstance.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(TextInstanceBlueFirstValue* (1 - interpolationValue) + TextInstanceBlueSecondValue * interpolationValue);
                }
                if (setTextInstanceGreenFirstValue && setTextInstanceGreenSecondValue)
                {
                    TextInstance.Green = FlatRedBall.Math.MathFunctions.RoundToInt(TextInstanceGreenFirstValue* (1 - interpolationValue) + TextInstanceGreenSecondValue * interpolationValue);
                }
                if (setTextInstanceRedFirstValue && setTextInstanceRedSecondValue)
                {
                    TextInstance.Red = FlatRedBall.Math.MathFunctions.RoundToInt(TextInstanceRedFirstValue* (1 - interpolationValue) + TextInstanceRedSecondValue * interpolationValue);
                }
                if (interpolationValue < 1)
                {
                    mCurrentRadioButtonCategoryState = firstState;
                }
                else
                {
                    mCurrentRadioButtonCategoryState = secondState;
                }
            }
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.RadioButtonRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.RadioButtonRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.RadioButtonRuntime.RadioButtonCategory fromState,AbbatoirIntergrade.GumRuntimes.RadioButtonRuntime.RadioButtonCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (RadioButtonCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "RadioButtonCategory").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentRadioButtonCategoryState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (RadioButtonCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentRadioButtonCategoryState = toState;
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
                            Name = "ColoredRectangleInstance.Red",
                            Type = "int",
                            Value = ColoredRectangleInstance.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Blue",
                            Type = "int",
                            Value = ColoredRectangleInstance1.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Green",
                            Type = "int",
                            Value = ColoredRectangleInstance1.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Height",
                            Type = "float",
                            Value = ColoredRectangleInstance1.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Height Units",
                            Type = "DimensionUnitType",
                            Value = ColoredRectangleInstance1.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Parent",
                            Type = "string",
                            Value = ColoredRectangleInstance1.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Red",
                            Type = "int",
                            Value = ColoredRectangleInstance1.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Width",
                            Type = "float",
                            Value = ColoredRectangleInstance1.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Width Units",
                            Type = "DimensionUnitType",
                            Value = ColoredRectangleInstance1.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.X",
                            Type = "float",
                            Value = ColoredRectangleInstance1.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.X Units",
                            Type = "PositionUnitType",
                            Value = ColoredRectangleInstance1.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Y",
                            Type = "float",
                            Value = ColoredRectangleInstance1.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Y Units",
                            Type = "PositionUnitType",
                            Value = ColoredRectangleInstance1.YUnits
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
                            Name = "TextInstance.Height",
                            Type = "float",
                            Value = TextInstance.Height
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
                            Name = "TextInstance.Width",
                            Type = "float",
                            Value = TextInstance.Width
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
                            Name = "TextInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = TextInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = TextInstance.YUnits
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
                            Value = Height + 0f
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
                            Value = Width + 200f
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
                            Name = "ColoredRectangleInstance.Red",
                            Type = "int",
                            Value = ColoredRectangleInstance.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Blue",
                            Type = "int",
                            Value = ColoredRectangleInstance1.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Green",
                            Type = "int",
                            Value = ColoredRectangleInstance1.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Height",
                            Type = "float",
                            Value = ColoredRectangleInstance1.Height + 80f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Height Units",
                            Type = "DimensionUnitType",
                            Value = ColoredRectangleInstance1.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Parent",
                            Type = "string",
                            Value = ColoredRectangleInstance1.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Red",
                            Type = "int",
                            Value = ColoredRectangleInstance1.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Width",
                            Type = "float",
                            Value = ColoredRectangleInstance1.Width + 80f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Width Units",
                            Type = "DimensionUnitType",
                            Value = ColoredRectangleInstance1.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.X",
                            Type = "float",
                            Value = ColoredRectangleInstance1.X + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.X Units",
                            Type = "PositionUnitType",
                            Value = ColoredRectangleInstance1.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Y",
                            Type = "float",
                            Value = ColoredRectangleInstance1.Y + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Y Units",
                            Type = "PositionUnitType",
                            Value = ColoredRectangleInstance1.YUnits
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
                            Value = TextInstance.FontScale + 0.3f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Height",
                            Type = "float",
                            Value = TextInstance.Height + 0f
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
                            Name = "TextInstance.Width",
                            Type = "float",
                            Value = TextInstance.Width + 0f
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
                            Name = "TextInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = TextInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = TextInstance.YUnits
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (RadioButtonCategory state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  RadioButtonCategory.EnabledOn:
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
                            Name = "ColoredRectangleInstance.Red",
                            Type = "int",
                            Value = ColoredRectangleInstance.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Blue",
                            Type = "int",
                            Value = ColoredRectangleInstance1.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Green",
                            Type = "int",
                            Value = ColoredRectangleInstance1.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Red",
                            Type = "int",
                            Value = ColoredRectangleInstance1.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Visible",
                            Type = "bool",
                            Value = ColoredRectangleInstance1.Visible
                        }
                        );
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
                            Name = "TextInstance.Green",
                            Type = "int",
                            Value = TextInstance.Green
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
                        break;
                    case  RadioButtonCategory.EnabledOff:
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
                            Name = "ColoredRectangleInstance.Red",
                            Type = "int",
                            Value = ColoredRectangleInstance.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Blue",
                            Type = "int",
                            Value = ColoredRectangleInstance1.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Green",
                            Type = "int",
                            Value = ColoredRectangleInstance1.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Red",
                            Type = "int",
                            Value = ColoredRectangleInstance1.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Visible",
                            Type = "bool",
                            Value = ColoredRectangleInstance1.Visible
                        }
                        );
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
                            Name = "TextInstance.Green",
                            Type = "int",
                            Value = TextInstance.Green
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
                        break;
                    case  RadioButtonCategory.DisabledOn:
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
                            Name = "ColoredRectangleInstance.Red",
                            Type = "int",
                            Value = ColoredRectangleInstance.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Blue",
                            Type = "int",
                            Value = ColoredRectangleInstance1.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Green",
                            Type = "int",
                            Value = ColoredRectangleInstance1.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Red",
                            Type = "int",
                            Value = ColoredRectangleInstance1.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Visible",
                            Type = "bool",
                            Value = ColoredRectangleInstance1.Visible
                        }
                        );
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
                            Name = "TextInstance.Green",
                            Type = "int",
                            Value = TextInstance.Green
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
                        break;
                    case  RadioButtonCategory.DisabledOff:
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
                            Name = "ColoredRectangleInstance.Red",
                            Type = "int",
                            Value = ColoredRectangleInstance.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Blue",
                            Type = "int",
                            Value = ColoredRectangleInstance1.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Green",
                            Type = "int",
                            Value = ColoredRectangleInstance1.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Red",
                            Type = "int",
                            Value = ColoredRectangleInstance1.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Visible",
                            Type = "bool",
                            Value = ColoredRectangleInstance1.Visible
                        }
                        );
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
                            Name = "TextInstance.Green",
                            Type = "int",
                            Value = TextInstance.Green
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
                        break;
                    case  RadioButtonCategory.HighlightedOn:
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
                            Name = "ColoredRectangleInstance.Red",
                            Type = "int",
                            Value = ColoredRectangleInstance.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Blue",
                            Type = "int",
                            Value = ColoredRectangleInstance1.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Green",
                            Type = "int",
                            Value = ColoredRectangleInstance1.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Red",
                            Type = "int",
                            Value = ColoredRectangleInstance1.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Visible",
                            Type = "bool",
                            Value = ColoredRectangleInstance1.Visible
                        }
                        );
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
                            Name = "TextInstance.Green",
                            Type = "int",
                            Value = TextInstance.Green
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
                        break;
                    case  RadioButtonCategory.HighlightedOff:
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
                            Name = "ColoredRectangleInstance.Red",
                            Type = "int",
                            Value = ColoredRectangleInstance.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Blue",
                            Type = "int",
                            Value = ColoredRectangleInstance1.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Green",
                            Type = "int",
                            Value = ColoredRectangleInstance1.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Red",
                            Type = "int",
                            Value = ColoredRectangleInstance1.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Visible",
                            Type = "bool",
                            Value = ColoredRectangleInstance1.Visible
                        }
                        );
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
                            Name = "TextInstance.Green",
                            Type = "int",
                            Value = TextInstance.Green
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
                        break;
                    case  RadioButtonCategory.PushedOn:
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
                            Name = "ColoredRectangleInstance.Red",
                            Type = "int",
                            Value = ColoredRectangleInstance.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Blue",
                            Type = "int",
                            Value = ColoredRectangleInstance1.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Green",
                            Type = "int",
                            Value = ColoredRectangleInstance1.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Red",
                            Type = "int",
                            Value = ColoredRectangleInstance1.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Visible",
                            Type = "bool",
                            Value = ColoredRectangleInstance1.Visible
                        }
                        );
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
                            Name = "TextInstance.Green",
                            Type = "int",
                            Value = TextInstance.Green
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
                        break;
                    case  RadioButtonCategory.PushedOff:
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
                            Name = "ColoredRectangleInstance.Red",
                            Type = "int",
                            Value = ColoredRectangleInstance.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Blue",
                            Type = "int",
                            Value = ColoredRectangleInstance1.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Green",
                            Type = "int",
                            Value = ColoredRectangleInstance1.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Red",
                            Type = "int",
                            Value = ColoredRectangleInstance1.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Visible",
                            Type = "bool",
                            Value = ColoredRectangleInstance1.Visible
                        }
                        );
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
                            Name = "TextInstance.Green",
                            Type = "int",
                            Value = TextInstance.Green
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
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (RadioButtonCategory state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  RadioButtonCategory.EnabledOn:
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
                            Name = "ColoredRectangleInstance.Red",
                            Type = "int",
                            Value = ColoredRectangleInstance.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Blue",
                            Type = "int",
                            Value = ColoredRectangleInstance1.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Green",
                            Type = "int",
                            Value = ColoredRectangleInstance1.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Red",
                            Type = "int",
                            Value = ColoredRectangleInstance1.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Visible",
                            Type = "bool",
                            Value = ColoredRectangleInstance1.Visible
                        }
                        );
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
                            Name = "TextInstance.Green",
                            Type = "int",
                            Value = TextInstance.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Red",
                            Type = "int",
                            Value = TextInstance.Red + 0
                        }
                        );
                        break;
                    case  RadioButtonCategory.EnabledOff:
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
                            Name = "ColoredRectangleInstance.Red",
                            Type = "int",
                            Value = ColoredRectangleInstance.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Blue",
                            Type = "int",
                            Value = ColoredRectangleInstance1.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Green",
                            Type = "int",
                            Value = ColoredRectangleInstance1.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Red",
                            Type = "int",
                            Value = ColoredRectangleInstance1.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Visible",
                            Type = "bool",
                            Value = ColoredRectangleInstance1.Visible
                        }
                        );
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
                            Name = "TextInstance.Green",
                            Type = "int",
                            Value = TextInstance.Green + 255
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
                        break;
                    case  RadioButtonCategory.DisabledOn:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Blue",
                            Type = "int",
                            Value = ColoredRectangleInstance.Blue + 169
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Green",
                            Type = "int",
                            Value = ColoredRectangleInstance.Green + 169
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Red",
                            Type = "int",
                            Value = ColoredRectangleInstance.Red + 169
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Blue",
                            Type = "int",
                            Value = ColoredRectangleInstance1.Blue + 220
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Green",
                            Type = "int",
                            Value = ColoredRectangleInstance1.Green + 220
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Red",
                            Type = "int",
                            Value = ColoredRectangleInstance1.Red + 220
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Visible",
                            Type = "bool",
                            Value = ColoredRectangleInstance1.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Blue",
                            Type = "int",
                            Value = TextInstance.Blue + 169
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Green",
                            Type = "int",
                            Value = TextInstance.Green + 169
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Red",
                            Type = "int",
                            Value = TextInstance.Red + 169
                        }
                        );
                        break;
                    case  RadioButtonCategory.DisabledOff:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Blue",
                            Type = "int",
                            Value = ColoredRectangleInstance.Blue + 169
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Green",
                            Type = "int",
                            Value = ColoredRectangleInstance.Green + 169
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Red",
                            Type = "int",
                            Value = ColoredRectangleInstance.Red + 169
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Blue",
                            Type = "int",
                            Value = ColoredRectangleInstance1.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Green",
                            Type = "int",
                            Value = ColoredRectangleInstance1.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Red",
                            Type = "int",
                            Value = ColoredRectangleInstance1.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Visible",
                            Type = "bool",
                            Value = ColoredRectangleInstance1.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Blue",
                            Type = "int",
                            Value = TextInstance.Blue + 169
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Green",
                            Type = "int",
                            Value = TextInstance.Green + 169
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Red",
                            Type = "int",
                            Value = TextInstance.Red + 169
                        }
                        );
                        break;
                    case  RadioButtonCategory.HighlightedOn:
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
                            Value = ColoredRectangleInstance.Green + 128
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
                            Name = "ColoredRectangleInstance1.Blue",
                            Type = "int",
                            Value = ColoredRectangleInstance1.Blue + 212
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Green",
                            Type = "int",
                            Value = ColoredRectangleInstance1.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Red",
                            Type = "int",
                            Value = ColoredRectangleInstance1.Red + 127
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Visible",
                            Type = "bool",
                            Value = ColoredRectangleInstance1.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Blue",
                            Type = "int",
                            Value = TextInstance.Blue + 47
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
                            Name = "TextInstance.Red",
                            Type = "int",
                            Value = TextInstance.Red + 173
                        }
                        );
                        break;
                    case  RadioButtonCategory.HighlightedOff:
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
                            Value = ColoredRectangleInstance.Green + 128
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
                            Name = "ColoredRectangleInstance1.Blue",
                            Type = "int",
                            Value = ColoredRectangleInstance1.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Green",
                            Type = "int",
                            Value = ColoredRectangleInstance1.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Red",
                            Type = "int",
                            Value = ColoredRectangleInstance1.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Visible",
                            Type = "bool",
                            Value = ColoredRectangleInstance1.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Blue",
                            Type = "int",
                            Value = TextInstance.Blue + 47
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
                            Name = "TextInstance.Red",
                            Type = "int",
                            Value = TextInstance.Red + 173
                        }
                        );
                        break;
                    case  RadioButtonCategory.PushedOn:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Blue",
                            Type = "int",
                            Value = ColoredRectangleInstance.Blue + 50
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Green",
                            Type = "int",
                            Value = ColoredRectangleInstance.Green + 205
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Red",
                            Type = "int",
                            Value = ColoredRectangleInstance.Red + 154
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Blue",
                            Type = "int",
                            Value = ColoredRectangleInstance1.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Green",
                            Type = "int",
                            Value = ColoredRectangleInstance1.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Red",
                            Type = "int",
                            Value = ColoredRectangleInstance1.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Visible",
                            Type = "bool",
                            Value = ColoredRectangleInstance1.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Blue",
                            Type = "int",
                            Value = TextInstance.Blue + 0
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
                            Name = "TextInstance.Red",
                            Type = "int",
                            Value = TextInstance.Red + 0
                        }
                        );
                        break;
                    case  RadioButtonCategory.PushedOff:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Blue",
                            Type = "int",
                            Value = ColoredRectangleInstance.Blue + 87
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Green",
                            Type = "int",
                            Value = ColoredRectangleInstance.Green + 139
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Red",
                            Type = "int",
                            Value = ColoredRectangleInstance.Red + 46
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Blue",
                            Type = "int",
                            Value = ColoredRectangleInstance1.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Green",
                            Type = "int",
                            Value = ColoredRectangleInstance1.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Red",
                            Type = "int",
                            Value = ColoredRectangleInstance1.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance1.Visible",
                            Type = "bool",
                            Value = ColoredRectangleInstance1.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Blue",
                            Type = "int",
                            Value = TextInstance.Blue + 0
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
                            Name = "TextInstance.Red",
                            Type = "int",
                            Value = TextInstance.Red + 0
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
                    else if (category.Name == "RadioButtonCategory")
                    {
                        if(state.Name == "EnabledOn") this.mCurrentRadioButtonCategoryState = RadioButtonCategory.EnabledOn;
                        if(state.Name == "EnabledOff") this.mCurrentRadioButtonCategoryState = RadioButtonCategory.EnabledOff;
                        if(state.Name == "DisabledOn") this.mCurrentRadioButtonCategoryState = RadioButtonCategory.DisabledOn;
                        if(state.Name == "DisabledOff") this.mCurrentRadioButtonCategoryState = RadioButtonCategory.DisabledOff;
                        if(state.Name == "HighlightedOn") this.mCurrentRadioButtonCategoryState = RadioButtonCategory.HighlightedOn;
                        if(state.Name == "HighlightedOff") this.mCurrentRadioButtonCategoryState = RadioButtonCategory.HighlightedOff;
                        if(state.Name == "PushedOn") this.mCurrentRadioButtonCategoryState = RadioButtonCategory.PushedOn;
                        if(state.Name == "PushedOff") this.mCurrentRadioButtonCategoryState = RadioButtonCategory.PushedOff;
                    }
                }
                base.ApplyState(state);
            }
            private bool tryCreateFormsObject;
            private AbbatoirIntergrade.GumRuntimes.ColoredRectangleRuntime ColoredRectangleInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ColoredRectangleRuntime ColoredRectangleInstance1 { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime TextInstance { get; set; }
            public string RadioText
            {
                get
                {
                    return TextInstance.Text;
                }
                set
                {
                    if (TextInstance.Text != value)
                    {
                        TextInstance.Text = value;
                        RadioTextChanged?.Invoke(this, null);
                    }
                }
            }
            public event System.EventHandler RadioTextChanged;
            public RadioButtonRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                this.tryCreateFormsObject = tryCreateFormsObject;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "RadioButton");
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
                ColoredRectangleInstance1 = this.GetGraphicalUiElementByName("ColoredRectangleInstance1") as AbbatoirIntergrade.GumRuntimes.ColoredRectangleRuntime;
                TextInstance = this.GetGraphicalUiElementByName("TextInstance") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
                if (tryCreateFormsObject)
                {
                    FormsControl = new FlatRedBall.Forms.Controls.RadioButton(this);
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
            public FlatRedBall.Forms.Controls.RadioButton FormsControl {get; private set;}
            public override object FormsControlAsObject { get { return FormsControl; } }
        }
    }
