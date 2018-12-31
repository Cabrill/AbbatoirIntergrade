    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes.coloredbars
    {
        public partial class ResourceBarRuntime : AbbatoirIntergrade.GumRuntimes.ContainerRuntime
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            public enum BarType
            {
                Energy,
                Minerals,
                Health
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            BarType? mCurrentBarTypeState;
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
                            Height = 10f;
                            HeightUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                            Width = 100f;
                            WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            WhiteFrameInstance.Height = 100f;
                            WhiteFrameInstance.Width = 100f;
                            ColoredRectangleInstance.Alpha = 100;
                            ColoredRectangleInstance.Blue = 0;
                            ColoredRectangleInstance.Green = 0;
                            ColoredRectangleInstance.Height = 100f;
                            ColoredRectangleInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ColoredRectangleInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ContainerInstance") ?? this;
                            ColoredRectangleInstance.Red = 0;
                            ColoredRectangleInstance.Width = 100f;
                            ColoredRectangleInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            FillRectangle.Alpha = 200;
                            FillRectangle.Blue = 0;
                            FillRectangle.Green = 225;
                            FillRectangle.Height = 100f;
                            FillRectangle.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            FillRectangle.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ContainerInstance") ?? this;
                            FillRectangle.Red = 255;
                            FillRectangle.Width = 100f;
                            FillRectangle.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            FillRectangle.X = 0f;
                            FillRectangle.Y = 0f;
                            ContainerInstance.Height = -8f;
                            ContainerInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            ContainerInstance.Visible = true;
                            ContainerInstance.Width = -8f;
                            ContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            ContainerInstance.X = 4f;
                            ContainerInstance.Y = 4f;
                            TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            TextInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ContainerInstance") ?? this;
                            TextInstance.Text = "650/1000";
                            TextInstance.UseCustomFont = true;
                            TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            TextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            TextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            TextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            break;
                    }
                }
            }
            public BarType? CurrentBarTypeState
            {
                get
                {
                    return mCurrentBarTypeState;
                }
                set
                {
                    if (value != null)
                    {
                        mCurrentBarTypeState = value;
                        switch(mCurrentBarTypeState)
                        {
                            case  BarType.Energy:
                                FillRectangle.Blue = 0;
                                FillRectangle.Green = 225;
                                FillRectangle.Red = 255;
                                break;
                            case  BarType.Minerals:
                                FillRectangle.Blue = 158;
                                FillRectangle.Green = 75;
                                FillRectangle.Red = 120;
                                break;
                            case  BarType.Health:
                                FillRectangle.Blue = 72;
                                FillRectangle.Green = 90;
                                FillRectangle.Red = 210;
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
                bool setColoredRectangleInstanceAlphaFirstValue = false;
                bool setColoredRectangleInstanceAlphaSecondValue = false;
                int ColoredRectangleInstanceAlphaFirstValue= 0;
                int ColoredRectangleInstanceAlphaSecondValue= 0;
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
                bool setContainerInstanceHeightFirstValue = false;
                bool setContainerInstanceHeightSecondValue = false;
                float ContainerInstanceHeightFirstValue= 0;
                float ContainerInstanceHeightSecondValue= 0;
                bool setContainerInstanceWidthFirstValue = false;
                bool setContainerInstanceWidthSecondValue = false;
                float ContainerInstanceWidthFirstValue= 0;
                float ContainerInstanceWidthSecondValue= 0;
                bool setContainerInstanceXFirstValue = false;
                bool setContainerInstanceXSecondValue = false;
                float ContainerInstanceXFirstValue= 0;
                float ContainerInstanceXSecondValue= 0;
                bool setContainerInstanceYFirstValue = false;
                bool setContainerInstanceYSecondValue = false;
                float ContainerInstanceYFirstValue= 0;
                float ContainerInstanceYSecondValue= 0;
                bool setFillRectangleAlphaFirstValue = false;
                bool setFillRectangleAlphaSecondValue = false;
                int FillRectangleAlphaFirstValue= 0;
                int FillRectangleAlphaSecondValue= 0;
                bool setFillRectangleBlueFirstValue = false;
                bool setFillRectangleBlueSecondValue = false;
                int FillRectangleBlueFirstValue= 0;
                int FillRectangleBlueSecondValue= 0;
                bool setFillRectangleGreenFirstValue = false;
                bool setFillRectangleGreenSecondValue = false;
                int FillRectangleGreenFirstValue= 0;
                int FillRectangleGreenSecondValue= 0;
                bool setFillRectangleHeightFirstValue = false;
                bool setFillRectangleHeightSecondValue = false;
                float FillRectangleHeightFirstValue= 0;
                float FillRectangleHeightSecondValue= 0;
                bool setFillRectangleRedFirstValue = false;
                bool setFillRectangleRedSecondValue = false;
                int FillRectangleRedFirstValue= 0;
                int FillRectangleRedSecondValue= 0;
                bool setFillRectangleWidthFirstValue = false;
                bool setFillRectangleWidthSecondValue = false;
                float FillRectangleWidthFirstValue= 0;
                float FillRectangleWidthSecondValue= 0;
                bool setFillRectangleXFirstValue = false;
                bool setFillRectangleXSecondValue = false;
                float FillRectangleXFirstValue= 0;
                float FillRectangleXSecondValue= 0;
                bool setFillRectangleYFirstValue = false;
                bool setFillRectangleYSecondValue = false;
                float FillRectangleYFirstValue= 0;
                float FillRectangleYSecondValue= 0;
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setWhiteFrameInstanceHeightFirstValue = false;
                bool setWhiteFrameInstanceHeightSecondValue = false;
                float WhiteFrameInstanceHeightFirstValue= 0;
                float WhiteFrameInstanceHeightSecondValue= 0;
                bool setWhiteFrameInstanceWidthFirstValue = false;
                bool setWhiteFrameInstanceWidthSecondValue = false;
                float WhiteFrameInstanceWidthFirstValue= 0;
                float WhiteFrameInstanceWidthSecondValue= 0;
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setColoredRectangleInstanceAlphaFirstValue = true;
                        ColoredRectangleInstanceAlphaFirstValue = 100;
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
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ContainerInstance") ?? this;
                        }
                        setColoredRectangleInstanceRedFirstValue = true;
                        ColoredRectangleInstanceRedFirstValue = 0;
                        setColoredRectangleInstanceWidthFirstValue = true;
                        ColoredRectangleInstanceWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setContainerInstanceHeightFirstValue = true;
                        ContainerInstanceHeightFirstValue = -8f;
                        if (interpolationValue < 1)
                        {
                            this.ContainerInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ContainerInstance.Visible = true;
                        }
                        setContainerInstanceWidthFirstValue = true;
                        ContainerInstanceWidthFirstValue = -8f;
                        if (interpolationValue < 1)
                        {
                            this.ContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setContainerInstanceXFirstValue = true;
                        ContainerInstanceXFirstValue = 4f;
                        setContainerInstanceYFirstValue = true;
                        ContainerInstanceYFirstValue = 4f;
                        setFillRectangleAlphaFirstValue = true;
                        FillRectangleAlphaFirstValue = 200;
                        setFillRectangleBlueFirstValue = true;
                        FillRectangleBlueFirstValue = 0;
                        setFillRectangleGreenFirstValue = true;
                        FillRectangleGreenFirstValue = 225;
                        setFillRectangleHeightFirstValue = true;
                        FillRectangleHeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.FillRectangle.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.FillRectangle.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ContainerInstance") ?? this;
                        }
                        setFillRectangleRedFirstValue = true;
                        FillRectangleRedFirstValue = 255;
                        setFillRectangleWidthFirstValue = true;
                        FillRectangleWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.FillRectangle.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setFillRectangleXFirstValue = true;
                        FillRectangleXFirstValue = 0f;
                        setFillRectangleYFirstValue = true;
                        FillRectangleYFirstValue = 0f;
                        setHeightFirstValue = true;
                        HeightFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ContainerInstance") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.Text = "650/1000";
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
                            this.TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
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
                        setWhiteFrameInstanceHeightFirstValue = true;
                        WhiteFrameInstanceHeightFirstValue = 100f;
                        setWhiteFrameInstanceWidthFirstValue = true;
                        WhiteFrameInstanceWidthFirstValue = 100f;
                        setWidthFirstValue = true;
                        WidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setColoredRectangleInstanceAlphaSecondValue = true;
                        ColoredRectangleInstanceAlphaSecondValue = 100;
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
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ContainerInstance") ?? this;
                        }
                        setColoredRectangleInstanceRedSecondValue = true;
                        ColoredRectangleInstanceRedSecondValue = 0;
                        setColoredRectangleInstanceWidthSecondValue = true;
                        ColoredRectangleInstanceWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setContainerInstanceHeightSecondValue = true;
                        ContainerInstanceHeightSecondValue = -8f;
                        if (interpolationValue >= 1)
                        {
                            this.ContainerInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ContainerInstance.Visible = true;
                        }
                        setContainerInstanceWidthSecondValue = true;
                        ContainerInstanceWidthSecondValue = -8f;
                        if (interpolationValue >= 1)
                        {
                            this.ContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setContainerInstanceXSecondValue = true;
                        ContainerInstanceXSecondValue = 4f;
                        setContainerInstanceYSecondValue = true;
                        ContainerInstanceYSecondValue = 4f;
                        setFillRectangleAlphaSecondValue = true;
                        FillRectangleAlphaSecondValue = 200;
                        setFillRectangleBlueSecondValue = true;
                        FillRectangleBlueSecondValue = 0;
                        setFillRectangleGreenSecondValue = true;
                        FillRectangleGreenSecondValue = 225;
                        setFillRectangleHeightSecondValue = true;
                        FillRectangleHeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.FillRectangle.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.FillRectangle.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ContainerInstance") ?? this;
                        }
                        setFillRectangleRedSecondValue = true;
                        FillRectangleRedSecondValue = 255;
                        setFillRectangleWidthSecondValue = true;
                        FillRectangleWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.FillRectangle.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setFillRectangleXSecondValue = true;
                        FillRectangleXSecondValue = 0f;
                        setFillRectangleYSecondValue = true;
                        FillRectangleYSecondValue = 0f;
                        setHeightSecondValue = true;
                        HeightSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ContainerInstance") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.Text = "650/1000";
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
                            this.TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
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
                        setWhiteFrameInstanceHeightSecondValue = true;
                        WhiteFrameInstanceHeightSecondValue = 100f;
                        setWhiteFrameInstanceWidthSecondValue = true;
                        WhiteFrameInstanceWidthSecondValue = 100f;
                        setWidthSecondValue = true;
                        WidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        break;
                }
                if (setColoredRectangleInstanceAlphaFirstValue && setColoredRectangleInstanceAlphaSecondValue)
                {
                    ColoredRectangleInstance.Alpha = FlatRedBall.Math.MathFunctions.RoundToInt(ColoredRectangleInstanceAlphaFirstValue* (1 - interpolationValue) + ColoredRectangleInstanceAlphaSecondValue * interpolationValue);
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
                if (setContainerInstanceHeightFirstValue && setContainerInstanceHeightSecondValue)
                {
                    ContainerInstance.Height = ContainerInstanceHeightFirstValue * (1 - interpolationValue) + ContainerInstanceHeightSecondValue * interpolationValue;
                }
                if (setContainerInstanceWidthFirstValue && setContainerInstanceWidthSecondValue)
                {
                    ContainerInstance.Width = ContainerInstanceWidthFirstValue * (1 - interpolationValue) + ContainerInstanceWidthSecondValue * interpolationValue;
                }
                if (setContainerInstanceXFirstValue && setContainerInstanceXSecondValue)
                {
                    ContainerInstance.X = ContainerInstanceXFirstValue * (1 - interpolationValue) + ContainerInstanceXSecondValue * interpolationValue;
                }
                if (setContainerInstanceYFirstValue && setContainerInstanceYSecondValue)
                {
                    ContainerInstance.Y = ContainerInstanceYFirstValue * (1 - interpolationValue) + ContainerInstanceYSecondValue * interpolationValue;
                }
                if (setFillRectangleAlphaFirstValue && setFillRectangleAlphaSecondValue)
                {
                    FillRectangle.Alpha = FlatRedBall.Math.MathFunctions.RoundToInt(FillRectangleAlphaFirstValue* (1 - interpolationValue) + FillRectangleAlphaSecondValue * interpolationValue);
                }
                if (setFillRectangleBlueFirstValue && setFillRectangleBlueSecondValue)
                {
                    FillRectangle.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(FillRectangleBlueFirstValue* (1 - interpolationValue) + FillRectangleBlueSecondValue * interpolationValue);
                }
                if (setFillRectangleGreenFirstValue && setFillRectangleGreenSecondValue)
                {
                    FillRectangle.Green = FlatRedBall.Math.MathFunctions.RoundToInt(FillRectangleGreenFirstValue* (1 - interpolationValue) + FillRectangleGreenSecondValue * interpolationValue);
                }
                if (setFillRectangleHeightFirstValue && setFillRectangleHeightSecondValue)
                {
                    FillRectangle.Height = FillRectangleHeightFirstValue * (1 - interpolationValue) + FillRectangleHeightSecondValue * interpolationValue;
                }
                if (setFillRectangleRedFirstValue && setFillRectangleRedSecondValue)
                {
                    FillRectangle.Red = FlatRedBall.Math.MathFunctions.RoundToInt(FillRectangleRedFirstValue* (1 - interpolationValue) + FillRectangleRedSecondValue * interpolationValue);
                }
                if (setFillRectangleWidthFirstValue && setFillRectangleWidthSecondValue)
                {
                    FillRectangle.Width = FillRectangleWidthFirstValue * (1 - interpolationValue) + FillRectangleWidthSecondValue * interpolationValue;
                }
                if (setFillRectangleXFirstValue && setFillRectangleXSecondValue)
                {
                    FillRectangle.X = FillRectangleXFirstValue * (1 - interpolationValue) + FillRectangleXSecondValue * interpolationValue;
                }
                if (setFillRectangleYFirstValue && setFillRectangleYSecondValue)
                {
                    FillRectangle.Y = FillRectangleYFirstValue * (1 - interpolationValue) + FillRectangleYSecondValue * interpolationValue;
                }
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
                }
                if (setWhiteFrameInstanceHeightFirstValue && setWhiteFrameInstanceHeightSecondValue)
                {
                    WhiteFrameInstance.Height = WhiteFrameInstanceHeightFirstValue * (1 - interpolationValue) + WhiteFrameInstanceHeightSecondValue * interpolationValue;
                }
                if (setWhiteFrameInstanceWidthFirstValue && setWhiteFrameInstanceWidthSecondValue)
                {
                    WhiteFrameInstance.Width = WhiteFrameInstanceWidthFirstValue * (1 - interpolationValue) + WhiteFrameInstanceWidthSecondValue * interpolationValue;
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
            public void InterpolateBetween (BarType firstState, BarType secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setFillRectangleBlueFirstValue = false;
                bool setFillRectangleBlueSecondValue = false;
                int FillRectangleBlueFirstValue= 0;
                int FillRectangleBlueSecondValue= 0;
                bool setFillRectangleGreenFirstValue = false;
                bool setFillRectangleGreenSecondValue = false;
                int FillRectangleGreenFirstValue= 0;
                int FillRectangleGreenSecondValue= 0;
                bool setFillRectangleRedFirstValue = false;
                bool setFillRectangleRedSecondValue = false;
                int FillRectangleRedFirstValue= 0;
                int FillRectangleRedSecondValue= 0;
                switch(firstState)
                {
                    case  BarType.Energy:
                        setFillRectangleBlueFirstValue = true;
                        FillRectangleBlueFirstValue = 0;
                        setFillRectangleGreenFirstValue = true;
                        FillRectangleGreenFirstValue = 225;
                        setFillRectangleRedFirstValue = true;
                        FillRectangleRedFirstValue = 255;
                        break;
                    case  BarType.Minerals:
                        setFillRectangleBlueFirstValue = true;
                        FillRectangleBlueFirstValue = 158;
                        setFillRectangleGreenFirstValue = true;
                        FillRectangleGreenFirstValue = 75;
                        setFillRectangleRedFirstValue = true;
                        FillRectangleRedFirstValue = 120;
                        break;
                    case  BarType.Health:
                        setFillRectangleBlueFirstValue = true;
                        FillRectangleBlueFirstValue = 72;
                        setFillRectangleGreenFirstValue = true;
                        FillRectangleGreenFirstValue = 90;
                        setFillRectangleRedFirstValue = true;
                        FillRectangleRedFirstValue = 210;
                        break;
                }
                switch(secondState)
                {
                    case  BarType.Energy:
                        setFillRectangleBlueSecondValue = true;
                        FillRectangleBlueSecondValue = 0;
                        setFillRectangleGreenSecondValue = true;
                        FillRectangleGreenSecondValue = 225;
                        setFillRectangleRedSecondValue = true;
                        FillRectangleRedSecondValue = 255;
                        break;
                    case  BarType.Minerals:
                        setFillRectangleBlueSecondValue = true;
                        FillRectangleBlueSecondValue = 158;
                        setFillRectangleGreenSecondValue = true;
                        FillRectangleGreenSecondValue = 75;
                        setFillRectangleRedSecondValue = true;
                        FillRectangleRedSecondValue = 120;
                        break;
                    case  BarType.Health:
                        setFillRectangleBlueSecondValue = true;
                        FillRectangleBlueSecondValue = 72;
                        setFillRectangleGreenSecondValue = true;
                        FillRectangleGreenSecondValue = 90;
                        setFillRectangleRedSecondValue = true;
                        FillRectangleRedSecondValue = 210;
                        break;
                }
                if (setFillRectangleBlueFirstValue && setFillRectangleBlueSecondValue)
                {
                    FillRectangle.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(FillRectangleBlueFirstValue* (1 - interpolationValue) + FillRectangleBlueSecondValue * interpolationValue);
                }
                if (setFillRectangleGreenFirstValue && setFillRectangleGreenSecondValue)
                {
                    FillRectangle.Green = FlatRedBall.Math.MathFunctions.RoundToInt(FillRectangleGreenFirstValue* (1 - interpolationValue) + FillRectangleGreenSecondValue * interpolationValue);
                }
                if (setFillRectangleRedFirstValue && setFillRectangleRedSecondValue)
                {
                    FillRectangle.Red = FlatRedBall.Math.MathFunctions.RoundToInt(FillRectangleRedFirstValue* (1 - interpolationValue) + FillRectangleRedSecondValue * interpolationValue);
                }
                if (interpolationValue < 1)
                {
                    mCurrentBarTypeState = firstState;
                }
                else
                {
                    mCurrentBarTypeState = secondState;
                }
            }
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.coloredbars.ResourceBarRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.coloredbars.ResourceBarRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.coloredbars.ResourceBarRuntime.BarType fromState,AbbatoirIntergrade.GumRuntimes.coloredbars.ResourceBarRuntime.BarType toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (BarType toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "BarType").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentBarTypeState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (BarType toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentBarTypeState = toState;
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
                WhiteFrameInstance.StopAnimations();
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
                            Name = "WhiteFrameInstance.Height",
                            Type = "float",
                            Value = WhiteFrameInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WhiteFrameInstance.Width",
                            Type = "float",
                            Value = WhiteFrameInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Alpha",
                            Type = "int",
                            Value = ColoredRectangleInstance.Alpha
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
                            Name = "ColoredRectangleInstance.Parent",
                            Type = "string",
                            Value = ColoredRectangleInstance.Parent
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
                            Name = "FillRectangle.Alpha",
                            Type = "int",
                            Value = FillRectangle.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FillRectangle.Blue",
                            Type = "int",
                            Value = FillRectangle.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FillRectangle.Green",
                            Type = "int",
                            Value = FillRectangle.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FillRectangle.Height",
                            Type = "float",
                            Value = FillRectangle.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FillRectangle.Height Units",
                            Type = "DimensionUnitType",
                            Value = FillRectangle.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FillRectangle.Parent",
                            Type = "string",
                            Value = FillRectangle.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FillRectangle.Red",
                            Type = "int",
                            Value = FillRectangle.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FillRectangle.Width",
                            Type = "float",
                            Value = FillRectangle.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FillRectangle.Width Units",
                            Type = "DimensionUnitType",
                            Value = FillRectangle.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FillRectangle.X",
                            Type = "float",
                            Value = FillRectangle.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FillRectangle.Y",
                            Type = "float",
                            Value = FillRectangle.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Height",
                            Type = "float",
                            Value = ContainerInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = ContainerInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Visible",
                            Type = "bool",
                            Value = ContainerInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Width",
                            Type = "float",
                            Value = ContainerInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = ContainerInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.X",
                            Type = "float",
                            Value = ContainerInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Y",
                            Type = "float",
                            Value = ContainerInstance.Y
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
                            Name = "WhiteFrameInstance.Height",
                            Type = "float",
                            Value = WhiteFrameInstance.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WhiteFrameInstance.Width",
                            Type = "float",
                            Value = WhiteFrameInstance.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Alpha",
                            Type = "int",
                            Value = ColoredRectangleInstance.Alpha + 100
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
                            Name = "ColoredRectangleInstance.Parent",
                            Type = "string",
                            Value = ColoredRectangleInstance.Parent
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
                            Name = "FillRectangle.Alpha",
                            Type = "int",
                            Value = FillRectangle.Alpha + 200
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FillRectangle.Blue",
                            Type = "int",
                            Value = FillRectangle.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FillRectangle.Green",
                            Type = "int",
                            Value = FillRectangle.Green + 225
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FillRectangle.Height",
                            Type = "float",
                            Value = FillRectangle.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FillRectangle.Height Units",
                            Type = "DimensionUnitType",
                            Value = FillRectangle.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FillRectangle.Parent",
                            Type = "string",
                            Value = FillRectangle.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FillRectangle.Red",
                            Type = "int",
                            Value = FillRectangle.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FillRectangle.Width",
                            Type = "float",
                            Value = FillRectangle.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FillRectangle.Width Units",
                            Type = "DimensionUnitType",
                            Value = FillRectangle.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FillRectangle.X",
                            Type = "float",
                            Value = FillRectangle.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FillRectangle.Y",
                            Type = "float",
                            Value = FillRectangle.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Height",
                            Type = "float",
                            Value = ContainerInstance.Height + -8f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = ContainerInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Visible",
                            Type = "bool",
                            Value = ContainerInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Width",
                            Type = "float",
                            Value = ContainerInstance.Width + -8f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = ContainerInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.X",
                            Type = "float",
                            Value = ContainerInstance.X + 4f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Y",
                            Type = "float",
                            Value = ContainerInstance.Y + 4f
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
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (BarType state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  BarType.Energy:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FillRectangle.Blue",
                            Type = "int",
                            Value = FillRectangle.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FillRectangle.Green",
                            Type = "int",
                            Value = FillRectangle.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FillRectangle.Red",
                            Type = "int",
                            Value = FillRectangle.Red
                        }
                        );
                        break;
                    case  BarType.Minerals:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FillRectangle.Blue",
                            Type = "int",
                            Value = FillRectangle.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FillRectangle.Green",
                            Type = "int",
                            Value = FillRectangle.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FillRectangle.Red",
                            Type = "int",
                            Value = FillRectangle.Red
                        }
                        );
                        break;
                    case  BarType.Health:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FillRectangle.Blue",
                            Type = "int",
                            Value = FillRectangle.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FillRectangle.Green",
                            Type = "int",
                            Value = FillRectangle.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FillRectangle.Red",
                            Type = "int",
                            Value = FillRectangle.Red
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (BarType state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  BarType.Energy:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FillRectangle.Blue",
                            Type = "int",
                            Value = FillRectangle.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FillRectangle.Green",
                            Type = "int",
                            Value = FillRectangle.Green + 225
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FillRectangle.Red",
                            Type = "int",
                            Value = FillRectangle.Red + 255
                        }
                        );
                        break;
                    case  BarType.Minerals:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FillRectangle.Blue",
                            Type = "int",
                            Value = FillRectangle.Blue + 158
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FillRectangle.Green",
                            Type = "int",
                            Value = FillRectangle.Green + 75
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FillRectangle.Red",
                            Type = "int",
                            Value = FillRectangle.Red + 120
                        }
                        );
                        break;
                    case  BarType.Health:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FillRectangle.Blue",
                            Type = "int",
                            Value = FillRectangle.Blue + 72
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FillRectangle.Green",
                            Type = "int",
                            Value = FillRectangle.Green + 90
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FillRectangle.Red",
                            Type = "int",
                            Value = FillRectangle.Red + 210
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
                    else if (category.Name == "BarType")
                    {
                        if(state.Name == "Energy") this.mCurrentBarTypeState = BarType.Energy;
                        if(state.Name == "Minerals") this.mCurrentBarTypeState = BarType.Minerals;
                        if(state.Name == "Health") this.mCurrentBarTypeState = BarType.Health;
                    }
                }
                base.ApplyState(state);
            }
            private AbbatoirIntergrade.GumRuntimes.frames.WhiteFrameRuntime WhiteFrameInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ColoredRectangleRuntime ColoredRectangleInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ColoredRectangleRuntime FillRectangle { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime ContainerInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime TextInstance { get; set; }
            public float BarFillPercent
            {
                get
                {
                    return FillRectangle.Width;
                }
                set
                {
                    if (FillRectangle.Width != value)
                    {
                        FillRectangle.Width = value;
                        BarFillPercentChanged?.Invoke(this, null);
                    }
                }
            }
            public float TextFontScale
            {
                get
                {
                    return TextInstance.FontScale;
                }
                set
                {
                    if (TextInstance.FontScale != value)
                    {
                        TextInstance.FontScale = value;
                        TextFontScaleChanged?.Invoke(this, null);
                    }
                }
            }
            public string BarText
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
                        BarTextChanged?.Invoke(this, null);
                    }
                }
            }
            public event System.EventHandler BarFillPercentChanged;
            public event System.EventHandler TextFontScaleChanged;
            public event System.EventHandler BarTextChanged;
            public ResourceBarRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "coloredbars/ResourceBar");
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
                WhiteFrameInstance = this.GetGraphicalUiElementByName("WhiteFrameInstance") as AbbatoirIntergrade.GumRuntimes.frames.WhiteFrameRuntime;
                ColoredRectangleInstance = this.GetGraphicalUiElementByName("ColoredRectangleInstance") as AbbatoirIntergrade.GumRuntimes.ColoredRectangleRuntime;
                FillRectangle = this.GetGraphicalUiElementByName("FillRectangle") as AbbatoirIntergrade.GumRuntimes.ColoredRectangleRuntime;
                ContainerInstance = this.GetGraphicalUiElementByName("ContainerInstance") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
                TextInstance = this.GetGraphicalUiElementByName("TextInstance") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
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
