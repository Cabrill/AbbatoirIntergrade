    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes
    {
        public partial class CheckBoxRuntime : AbbatoirIntergrade.GumRuntimes.ContainerRuntime
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            public enum CheckBoxCategory
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
            CheckBoxCategory mCurrentCheckBoxCategoryState;
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
                            Height = 50f;
                            ColoredRectangleInstance.Blue = 0;
                            ColoredRectangleInstance.Green = 0;
                            ColoredRectangleInstance.Height = -8f;
                            ColoredRectangleInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            ColoredRectangleInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ColoredRectangleInstance1") ?? this;
                            ColoredRectangleInstance.Red = 0;
                            ColoredRectangleInstance.Width = -8f;
                            ColoredRectangleInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            ColoredRectangleInstance.X = 4f;
                            ColoredRectangleInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            ColoredRectangleInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            ColoredRectangleInstance.Y = 4f;
                            ColoredRectangleInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            SpriteInstance.Blue = 255;
                            SpriteInstance.Green = 255;
                            SpriteInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            SpriteInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ColoredRectangleInstance") ?? this;
                            SpriteInstance.Red = 0;
                            SetProperty("SpriteInstance.SourceFile", "AllUIAssets.png");
                            SpriteInstance.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            SpriteInstance.TextureHeight = 128;
                            SpriteInstance.TextureLeft = 3585;
                            SpriteInstance.TextureTop = 1728;
                            SpriteInstance.TextureWidth = 128;
                            SpriteInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ColoredRectangleInstance1.Blue = 255;
                            ColoredRectangleInstance1.Green = 255;
                            ColoredRectangleInstance1.Height = 80f;
                            ColoredRectangleInstance1.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ColoredRectangleInstance1.Red = 0;
                            ColoredRectangleInstance1.Width = 100f;
                            ColoredRectangleInstance1.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                            ColoredRectangleInstance1.X = 3f;
                            ColoredRectangleInstance1.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            ColoredRectangleInstance1.Y = 10f;
                            ColoredRectangleInstance1.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            SetProperty("TextInstance.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                            TextInstance.FontScale = 0.5f;
                            TextInstance.Height = 0f;
                            TextInstance.UseCustomFont = true;
                            TextInstance.Width = 0f;
                            TextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            TextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            break;
                    }
                }
            }
            public CheckBoxCategory CurrentCheckBoxCategoryState
            {
                get
                {
                    return mCurrentCheckBoxCategoryState;
                }
                set
                {
                    mCurrentCheckBoxCategoryState = value;
                    switch(mCurrentCheckBoxCategoryState)
                    {
                        case  CheckBoxCategory.EnabledOn:
                            ColoredRectangleInstance.Blue = 0;
                            ColoredRectangleInstance.Green = 0;
                            ColoredRectangleInstance.Red = 0;
                            SpriteInstance.Blue = 255;
                            SpriteInstance.Green = 255;
                            SpriteInstance.Red = 0;
                            SpriteInstance.Visible = true;
                            TextInstance.Blue = 255;
                            TextInstance.Green = 255;
                            TextInstance.Red = 255;
                            break;
                        case  CheckBoxCategory.EnabledOff:
                            ColoredRectangleInstance.Blue = 0;
                            ColoredRectangleInstance.Green = 0;
                            ColoredRectangleInstance.Red = 0;
                            SpriteInstance.Blue = 255;
                            SpriteInstance.Green = 255;
                            SpriteInstance.Red = 0;
                            SpriteInstance.Visible = false;
                            TextInstance.Blue = 255;
                            TextInstance.Green = 255;
                            TextInstance.Red = 255;
                            break;
                        case  CheckBoxCategory.DisabledOn:
                            ColoredRectangleInstance.Blue = 169;
                            ColoredRectangleInstance.Green = 169;
                            ColoredRectangleInstance.Red = 169;
                            SpriteInstance.Blue = 220;
                            SpriteInstance.Green = 220;
                            SpriteInstance.Red = 220;
                            SpriteInstance.Visible = true;
                            TextInstance.Blue = 169;
                            TextInstance.Green = 169;
                            TextInstance.Red = 169;
                            break;
                        case  CheckBoxCategory.DisabledOff:
                            ColoredRectangleInstance.Blue = 169;
                            ColoredRectangleInstance.Green = 169;
                            ColoredRectangleInstance.Red = 169;
                            SpriteInstance.Blue = 255;
                            SpriteInstance.Green = 255;
                            SpriteInstance.Red = 0;
                            SpriteInstance.Visible = false;
                            TextInstance.Blue = 169;
                            TextInstance.Green = 169;
                            TextInstance.Red = 169;
                            break;
                        case  CheckBoxCategory.HighlightedOn:
                            ColoredRectangleInstance.Blue = 100;
                            ColoredRectangleInstance.Green = 100;
                            ColoredRectangleInstance.Red = 0;
                            SpriteInstance.Blue = 212;
                            SpriteInstance.Green = 255;
                            SpriteInstance.Red = 127;
                            SpriteInstance.Visible = true;
                            TextInstance.Blue = 212;
                            TextInstance.Green = 255;
                            TextInstance.Red = 127;
                            break;
                        case  CheckBoxCategory.HighlightedOff:
                            ColoredRectangleInstance.Blue = 100;
                            ColoredRectangleInstance.Green = 100;
                            ColoredRectangleInstance.Red = 0;
                            SpriteInstance.Blue = 255;
                            SpriteInstance.Green = 255;
                            SpriteInstance.Red = 0;
                            SpriteInstance.Visible = false;
                            TextInstance.Blue = 212;
                            TextInstance.Green = 255;
                            TextInstance.Red = 127;
                            break;
                        case  CheckBoxCategory.PushedOn:
                            ColoredRectangleInstance.Blue = 255;
                            ColoredRectangleInstance.Green = 144;
                            ColoredRectangleInstance.Red = 30;
                            SpriteInstance.Blue = 255;
                            SpriteInstance.Green = 255;
                            SpriteInstance.Red = 0;
                            SpriteInstance.Visible = true;
                            TextInstance.Blue = 230;
                            TextInstance.Green = 230;
                            TextInstance.Red = 230;
                            break;
                        case  CheckBoxCategory.PushedOff:
                            ColoredRectangleInstance.Blue = 255;
                            ColoredRectangleInstance.Green = 144;
                            ColoredRectangleInstance.Red = 30;
                            SpriteInstance.Blue = 139;
                            SpriteInstance.Green = 0;
                            SpriteInstance.Red = 0;
                            SpriteInstance.Visible = false;
                            TextInstance.Blue = 250;
                            TextInstance.Green = 230;
                            TextInstance.Red = 230;
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
                bool setColoredRectangleInstanceXFirstValue = false;
                bool setColoredRectangleInstanceXSecondValue = false;
                float ColoredRectangleInstanceXFirstValue= 0;
                float ColoredRectangleInstanceXSecondValue= 0;
                bool setColoredRectangleInstanceYFirstValue = false;
                bool setColoredRectangleInstanceYSecondValue = false;
                float ColoredRectangleInstanceYFirstValue= 0;
                float ColoredRectangleInstanceYSecondValue= 0;
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
                bool setSpriteInstanceBlueFirstValue = false;
                bool setSpriteInstanceBlueSecondValue = false;
                int SpriteInstanceBlueFirstValue= 0;
                int SpriteInstanceBlueSecondValue= 0;
                bool setSpriteInstanceGreenFirstValue = false;
                bool setSpriteInstanceGreenSecondValue = false;
                int SpriteInstanceGreenFirstValue= 0;
                int SpriteInstanceGreenSecondValue= 0;
                bool setSpriteInstanceRedFirstValue = false;
                bool setSpriteInstanceRedSecondValue = false;
                int SpriteInstanceRedFirstValue= 0;
                int SpriteInstanceRedSecondValue= 0;
                bool setSpriteInstanceTextureHeightFirstValue = false;
                bool setSpriteInstanceTextureHeightSecondValue = false;
                int SpriteInstanceTextureHeightFirstValue= 0;
                int SpriteInstanceTextureHeightSecondValue= 0;
                bool setSpriteInstanceTextureLeftFirstValue = false;
                bool setSpriteInstanceTextureLeftSecondValue = false;
                int SpriteInstanceTextureLeftFirstValue= 0;
                int SpriteInstanceTextureLeftSecondValue= 0;
                bool setSpriteInstanceTextureTopFirstValue = false;
                bool setSpriteInstanceTextureTopSecondValue = false;
                int SpriteInstanceTextureTopFirstValue= 0;
                int SpriteInstanceTextureTopSecondValue= 0;
                bool setSpriteInstanceTextureWidthFirstValue = false;
                bool setSpriteInstanceTextureWidthSecondValue = false;
                int SpriteInstanceTextureWidthFirstValue= 0;
                int SpriteInstanceTextureWidthSecondValue= 0;
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
                        setColoredRectangleInstanceHeightFirstValue = true;
                        ColoredRectangleInstanceHeightFirstValue = -8f;
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ColoredRectangleInstance1") ?? this;
                        }
                        setColoredRectangleInstanceRedFirstValue = true;
                        ColoredRectangleInstanceRedFirstValue = 0;
                        setColoredRectangleInstanceWidthFirstValue = true;
                        ColoredRectangleInstanceWidthFirstValue = -8f;
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setColoredRectangleInstanceXFirstValue = true;
                        ColoredRectangleInstanceXFirstValue = 4f;
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setColoredRectangleInstanceYFirstValue = true;
                        ColoredRectangleInstanceYFirstValue = 4f;
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
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
                        setColoredRectangleInstance1RedFirstValue = true;
                        ColoredRectangleInstance1RedFirstValue = 0;
                        setColoredRectangleInstance1WidthFirstValue = true;
                        ColoredRectangleInstance1WidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance1.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        setColoredRectangleInstance1XFirstValue = true;
                        ColoredRectangleInstance1XFirstValue = 3f;
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
                        HeightFirstValue = 50f;
                        setSpriteInstanceBlueFirstValue = true;
                        SpriteInstanceBlueFirstValue = 255;
                        setSpriteInstanceGreenFirstValue = true;
                        SpriteInstanceGreenFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ColoredRectangleInstance") ?? this;
                        }
                        setSpriteInstanceRedFirstValue = true;
                        SpriteInstanceRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            SetProperty("SpriteInstance.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setSpriteInstanceTextureHeightFirstValue = true;
                        SpriteInstanceTextureHeightFirstValue = 128;
                        setSpriteInstanceTextureLeftFirstValue = true;
                        SpriteInstanceTextureLeftFirstValue = 3585;
                        setSpriteInstanceTextureTopFirstValue = true;
                        SpriteInstanceTextureTopFirstValue = 1728;
                        setSpriteInstanceTextureWidthFirstValue = true;
                        SpriteInstanceTextureWidthFirstValue = 128;
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("TextInstance.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setTextInstanceFontScaleFirstValue = true;
                        TextInstanceFontScaleFirstValue = 0.5f;
                        setTextInstanceHeightFirstValue = true;
                        TextInstanceHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.UseCustomFont = true;
                        }
                        setTextInstanceWidthFirstValue = true;
                        TextInstanceWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
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
                        setColoredRectangleInstanceHeightSecondValue = true;
                        ColoredRectangleInstanceHeightSecondValue = -8f;
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ColoredRectangleInstance1") ?? this;
                        }
                        setColoredRectangleInstanceRedSecondValue = true;
                        ColoredRectangleInstanceRedSecondValue = 0;
                        setColoredRectangleInstanceWidthSecondValue = true;
                        ColoredRectangleInstanceWidthSecondValue = -8f;
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setColoredRectangleInstanceXSecondValue = true;
                        ColoredRectangleInstanceXSecondValue = 4f;
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setColoredRectangleInstanceYSecondValue = true;
                        ColoredRectangleInstanceYSecondValue = 4f;
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
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
                        setColoredRectangleInstance1RedSecondValue = true;
                        ColoredRectangleInstance1RedSecondValue = 0;
                        setColoredRectangleInstance1WidthSecondValue = true;
                        ColoredRectangleInstance1WidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance1.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        setColoredRectangleInstance1XSecondValue = true;
                        ColoredRectangleInstance1XSecondValue = 3f;
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
                        HeightSecondValue = 50f;
                        setSpriteInstanceBlueSecondValue = true;
                        SpriteInstanceBlueSecondValue = 255;
                        setSpriteInstanceGreenSecondValue = true;
                        SpriteInstanceGreenSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ColoredRectangleInstance") ?? this;
                        }
                        setSpriteInstanceRedSecondValue = true;
                        SpriteInstanceRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("SpriteInstance.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setSpriteInstanceTextureHeightSecondValue = true;
                        SpriteInstanceTextureHeightSecondValue = 128;
                        setSpriteInstanceTextureLeftSecondValue = true;
                        SpriteInstanceTextureLeftSecondValue = 3585;
                        setSpriteInstanceTextureTopSecondValue = true;
                        SpriteInstanceTextureTopSecondValue = 1728;
                        setSpriteInstanceTextureWidthSecondValue = true;
                        SpriteInstanceTextureWidthSecondValue = 128;
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("TextInstance.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setTextInstanceFontScaleSecondValue = true;
                        TextInstanceFontScaleSecondValue = 0.5f;
                        setTextInstanceHeightSecondValue = true;
                        TextInstanceHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.UseCustomFont = true;
                        }
                        setTextInstanceWidthSecondValue = true;
                        TextInstanceWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
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
                if (setColoredRectangleInstanceXFirstValue && setColoredRectangleInstanceXSecondValue)
                {
                    ColoredRectangleInstance.X = ColoredRectangleInstanceXFirstValue * (1 - interpolationValue) + ColoredRectangleInstanceXSecondValue * interpolationValue;
                }
                if (setColoredRectangleInstanceYFirstValue && setColoredRectangleInstanceYSecondValue)
                {
                    ColoredRectangleInstance.Y = ColoredRectangleInstanceYFirstValue * (1 - interpolationValue) + ColoredRectangleInstanceYSecondValue * interpolationValue;
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
                if (setSpriteInstanceBlueFirstValue && setSpriteInstanceBlueSecondValue)
                {
                    SpriteInstance.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(SpriteInstanceBlueFirstValue* (1 - interpolationValue) + SpriteInstanceBlueSecondValue * interpolationValue);
                }
                if (setSpriteInstanceGreenFirstValue && setSpriteInstanceGreenSecondValue)
                {
                    SpriteInstance.Green = FlatRedBall.Math.MathFunctions.RoundToInt(SpriteInstanceGreenFirstValue* (1 - interpolationValue) + SpriteInstanceGreenSecondValue * interpolationValue);
                }
                if (setSpriteInstanceRedFirstValue && setSpriteInstanceRedSecondValue)
                {
                    SpriteInstance.Red = FlatRedBall.Math.MathFunctions.RoundToInt(SpriteInstanceRedFirstValue* (1 - interpolationValue) + SpriteInstanceRedSecondValue * interpolationValue);
                }
                if (setSpriteInstanceTextureHeightFirstValue && setSpriteInstanceTextureHeightSecondValue)
                {
                    SpriteInstance.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(SpriteInstanceTextureHeightFirstValue* (1 - interpolationValue) + SpriteInstanceTextureHeightSecondValue * interpolationValue);
                }
                if (setSpriteInstanceTextureLeftFirstValue && setSpriteInstanceTextureLeftSecondValue)
                {
                    SpriteInstance.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(SpriteInstanceTextureLeftFirstValue* (1 - interpolationValue) + SpriteInstanceTextureLeftSecondValue * interpolationValue);
                }
                if (setSpriteInstanceTextureTopFirstValue && setSpriteInstanceTextureTopSecondValue)
                {
                    SpriteInstance.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(SpriteInstanceTextureTopFirstValue* (1 - interpolationValue) + SpriteInstanceTextureTopSecondValue * interpolationValue);
                }
                if (setSpriteInstanceTextureWidthFirstValue && setSpriteInstanceTextureWidthSecondValue)
                {
                    SpriteInstance.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(SpriteInstanceTextureWidthFirstValue* (1 - interpolationValue) + SpriteInstanceTextureWidthSecondValue * interpolationValue);
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
                if (interpolationValue < 1)
                {
                    mCurrentVariableState = firstState;
                }
                else
                {
                    mCurrentVariableState = secondState;
                }
            }
            public void InterpolateBetween (CheckBoxCategory firstState, CheckBoxCategory secondState, float interpolationValue) 
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
                bool setSpriteInstanceBlueFirstValue = false;
                bool setSpriteInstanceBlueSecondValue = false;
                int SpriteInstanceBlueFirstValue= 0;
                int SpriteInstanceBlueSecondValue= 0;
                bool setSpriteInstanceGreenFirstValue = false;
                bool setSpriteInstanceGreenSecondValue = false;
                int SpriteInstanceGreenFirstValue= 0;
                int SpriteInstanceGreenSecondValue= 0;
                bool setSpriteInstanceRedFirstValue = false;
                bool setSpriteInstanceRedSecondValue = false;
                int SpriteInstanceRedFirstValue= 0;
                int SpriteInstanceRedSecondValue= 0;
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
                    case  CheckBoxCategory.EnabledOn:
                        setColoredRectangleInstanceBlueFirstValue = true;
                        ColoredRectangleInstanceBlueFirstValue = 0;
                        setColoredRectangleInstanceGreenFirstValue = true;
                        ColoredRectangleInstanceGreenFirstValue = 0;
                        setColoredRectangleInstanceRedFirstValue = true;
                        ColoredRectangleInstanceRedFirstValue = 0;
                        setSpriteInstanceBlueFirstValue = true;
                        SpriteInstanceBlueFirstValue = 255;
                        setSpriteInstanceGreenFirstValue = true;
                        SpriteInstanceGreenFirstValue = 255;
                        setSpriteInstanceRedFirstValue = true;
                        SpriteInstanceRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.Visible = true;
                        }
                        setTextInstanceBlueFirstValue = true;
                        TextInstanceBlueFirstValue = 255;
                        setTextInstanceGreenFirstValue = true;
                        TextInstanceGreenFirstValue = 255;
                        setTextInstanceRedFirstValue = true;
                        TextInstanceRedFirstValue = 255;
                        break;
                    case  CheckBoxCategory.EnabledOff:
                        setColoredRectangleInstanceBlueFirstValue = true;
                        ColoredRectangleInstanceBlueFirstValue = 0;
                        setColoredRectangleInstanceGreenFirstValue = true;
                        ColoredRectangleInstanceGreenFirstValue = 0;
                        setColoredRectangleInstanceRedFirstValue = true;
                        ColoredRectangleInstanceRedFirstValue = 0;
                        setSpriteInstanceBlueFirstValue = true;
                        SpriteInstanceBlueFirstValue = 255;
                        setSpriteInstanceGreenFirstValue = true;
                        SpriteInstanceGreenFirstValue = 255;
                        setSpriteInstanceRedFirstValue = true;
                        SpriteInstanceRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.Visible = false;
                        }
                        setTextInstanceBlueFirstValue = true;
                        TextInstanceBlueFirstValue = 255;
                        setTextInstanceGreenFirstValue = true;
                        TextInstanceGreenFirstValue = 255;
                        setTextInstanceRedFirstValue = true;
                        TextInstanceRedFirstValue = 255;
                        break;
                    case  CheckBoxCategory.DisabledOn:
                        setColoredRectangleInstanceBlueFirstValue = true;
                        ColoredRectangleInstanceBlueFirstValue = 169;
                        setColoredRectangleInstanceGreenFirstValue = true;
                        ColoredRectangleInstanceGreenFirstValue = 169;
                        setColoredRectangleInstanceRedFirstValue = true;
                        ColoredRectangleInstanceRedFirstValue = 169;
                        setSpriteInstanceBlueFirstValue = true;
                        SpriteInstanceBlueFirstValue = 220;
                        setSpriteInstanceGreenFirstValue = true;
                        SpriteInstanceGreenFirstValue = 220;
                        setSpriteInstanceRedFirstValue = true;
                        SpriteInstanceRedFirstValue = 220;
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.Visible = true;
                        }
                        setTextInstanceBlueFirstValue = true;
                        TextInstanceBlueFirstValue = 169;
                        setTextInstanceGreenFirstValue = true;
                        TextInstanceGreenFirstValue = 169;
                        setTextInstanceRedFirstValue = true;
                        TextInstanceRedFirstValue = 169;
                        break;
                    case  CheckBoxCategory.DisabledOff:
                        setColoredRectangleInstanceBlueFirstValue = true;
                        ColoredRectangleInstanceBlueFirstValue = 169;
                        setColoredRectangleInstanceGreenFirstValue = true;
                        ColoredRectangleInstanceGreenFirstValue = 169;
                        setColoredRectangleInstanceRedFirstValue = true;
                        ColoredRectangleInstanceRedFirstValue = 169;
                        setSpriteInstanceBlueFirstValue = true;
                        SpriteInstanceBlueFirstValue = 255;
                        setSpriteInstanceGreenFirstValue = true;
                        SpriteInstanceGreenFirstValue = 255;
                        setSpriteInstanceRedFirstValue = true;
                        SpriteInstanceRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.Visible = false;
                        }
                        setTextInstanceBlueFirstValue = true;
                        TextInstanceBlueFirstValue = 169;
                        setTextInstanceGreenFirstValue = true;
                        TextInstanceGreenFirstValue = 169;
                        setTextInstanceRedFirstValue = true;
                        TextInstanceRedFirstValue = 169;
                        break;
                    case  CheckBoxCategory.HighlightedOn:
                        setColoredRectangleInstanceBlueFirstValue = true;
                        ColoredRectangleInstanceBlueFirstValue = 100;
                        setColoredRectangleInstanceGreenFirstValue = true;
                        ColoredRectangleInstanceGreenFirstValue = 100;
                        setColoredRectangleInstanceRedFirstValue = true;
                        ColoredRectangleInstanceRedFirstValue = 0;
                        setSpriteInstanceBlueFirstValue = true;
                        SpriteInstanceBlueFirstValue = 212;
                        setSpriteInstanceGreenFirstValue = true;
                        SpriteInstanceGreenFirstValue = 255;
                        setSpriteInstanceRedFirstValue = true;
                        SpriteInstanceRedFirstValue = 127;
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.Visible = true;
                        }
                        setTextInstanceBlueFirstValue = true;
                        TextInstanceBlueFirstValue = 212;
                        setTextInstanceGreenFirstValue = true;
                        TextInstanceGreenFirstValue = 255;
                        setTextInstanceRedFirstValue = true;
                        TextInstanceRedFirstValue = 127;
                        break;
                    case  CheckBoxCategory.HighlightedOff:
                        setColoredRectangleInstanceBlueFirstValue = true;
                        ColoredRectangleInstanceBlueFirstValue = 100;
                        setColoredRectangleInstanceGreenFirstValue = true;
                        ColoredRectangleInstanceGreenFirstValue = 100;
                        setColoredRectangleInstanceRedFirstValue = true;
                        ColoredRectangleInstanceRedFirstValue = 0;
                        setSpriteInstanceBlueFirstValue = true;
                        SpriteInstanceBlueFirstValue = 255;
                        setSpriteInstanceGreenFirstValue = true;
                        SpriteInstanceGreenFirstValue = 255;
                        setSpriteInstanceRedFirstValue = true;
                        SpriteInstanceRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.Visible = false;
                        }
                        setTextInstanceBlueFirstValue = true;
                        TextInstanceBlueFirstValue = 212;
                        setTextInstanceGreenFirstValue = true;
                        TextInstanceGreenFirstValue = 255;
                        setTextInstanceRedFirstValue = true;
                        TextInstanceRedFirstValue = 127;
                        break;
                    case  CheckBoxCategory.PushedOn:
                        setColoredRectangleInstanceBlueFirstValue = true;
                        ColoredRectangleInstanceBlueFirstValue = 255;
                        setColoredRectangleInstanceGreenFirstValue = true;
                        ColoredRectangleInstanceGreenFirstValue = 144;
                        setColoredRectangleInstanceRedFirstValue = true;
                        ColoredRectangleInstanceRedFirstValue = 30;
                        setSpriteInstanceBlueFirstValue = true;
                        SpriteInstanceBlueFirstValue = 255;
                        setSpriteInstanceGreenFirstValue = true;
                        SpriteInstanceGreenFirstValue = 255;
                        setSpriteInstanceRedFirstValue = true;
                        SpriteInstanceRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.Visible = true;
                        }
                        setTextInstanceBlueFirstValue = true;
                        TextInstanceBlueFirstValue = 230;
                        setTextInstanceGreenFirstValue = true;
                        TextInstanceGreenFirstValue = 230;
                        setTextInstanceRedFirstValue = true;
                        TextInstanceRedFirstValue = 230;
                        break;
                    case  CheckBoxCategory.PushedOff:
                        setColoredRectangleInstanceBlueFirstValue = true;
                        ColoredRectangleInstanceBlueFirstValue = 255;
                        setColoredRectangleInstanceGreenFirstValue = true;
                        ColoredRectangleInstanceGreenFirstValue = 144;
                        setColoredRectangleInstanceRedFirstValue = true;
                        ColoredRectangleInstanceRedFirstValue = 30;
                        setSpriteInstanceBlueFirstValue = true;
                        SpriteInstanceBlueFirstValue = 139;
                        setSpriteInstanceGreenFirstValue = true;
                        SpriteInstanceGreenFirstValue = 0;
                        setSpriteInstanceRedFirstValue = true;
                        SpriteInstanceRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.Visible = false;
                        }
                        setTextInstanceBlueFirstValue = true;
                        TextInstanceBlueFirstValue = 250;
                        setTextInstanceGreenFirstValue = true;
                        TextInstanceGreenFirstValue = 230;
                        setTextInstanceRedFirstValue = true;
                        TextInstanceRedFirstValue = 230;
                        break;
                }
                switch(secondState)
                {
                    case  CheckBoxCategory.EnabledOn:
                        setColoredRectangleInstanceBlueSecondValue = true;
                        ColoredRectangleInstanceBlueSecondValue = 0;
                        setColoredRectangleInstanceGreenSecondValue = true;
                        ColoredRectangleInstanceGreenSecondValue = 0;
                        setColoredRectangleInstanceRedSecondValue = true;
                        ColoredRectangleInstanceRedSecondValue = 0;
                        setSpriteInstanceBlueSecondValue = true;
                        SpriteInstanceBlueSecondValue = 255;
                        setSpriteInstanceGreenSecondValue = true;
                        SpriteInstanceGreenSecondValue = 255;
                        setSpriteInstanceRedSecondValue = true;
                        SpriteInstanceRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.Visible = true;
                        }
                        setTextInstanceBlueSecondValue = true;
                        TextInstanceBlueSecondValue = 255;
                        setTextInstanceGreenSecondValue = true;
                        TextInstanceGreenSecondValue = 255;
                        setTextInstanceRedSecondValue = true;
                        TextInstanceRedSecondValue = 255;
                        break;
                    case  CheckBoxCategory.EnabledOff:
                        setColoredRectangleInstanceBlueSecondValue = true;
                        ColoredRectangleInstanceBlueSecondValue = 0;
                        setColoredRectangleInstanceGreenSecondValue = true;
                        ColoredRectangleInstanceGreenSecondValue = 0;
                        setColoredRectangleInstanceRedSecondValue = true;
                        ColoredRectangleInstanceRedSecondValue = 0;
                        setSpriteInstanceBlueSecondValue = true;
                        SpriteInstanceBlueSecondValue = 255;
                        setSpriteInstanceGreenSecondValue = true;
                        SpriteInstanceGreenSecondValue = 255;
                        setSpriteInstanceRedSecondValue = true;
                        SpriteInstanceRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.Visible = false;
                        }
                        setTextInstanceBlueSecondValue = true;
                        TextInstanceBlueSecondValue = 255;
                        setTextInstanceGreenSecondValue = true;
                        TextInstanceGreenSecondValue = 255;
                        setTextInstanceRedSecondValue = true;
                        TextInstanceRedSecondValue = 255;
                        break;
                    case  CheckBoxCategory.DisabledOn:
                        setColoredRectangleInstanceBlueSecondValue = true;
                        ColoredRectangleInstanceBlueSecondValue = 169;
                        setColoredRectangleInstanceGreenSecondValue = true;
                        ColoredRectangleInstanceGreenSecondValue = 169;
                        setColoredRectangleInstanceRedSecondValue = true;
                        ColoredRectangleInstanceRedSecondValue = 169;
                        setSpriteInstanceBlueSecondValue = true;
                        SpriteInstanceBlueSecondValue = 220;
                        setSpriteInstanceGreenSecondValue = true;
                        SpriteInstanceGreenSecondValue = 220;
                        setSpriteInstanceRedSecondValue = true;
                        SpriteInstanceRedSecondValue = 220;
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.Visible = true;
                        }
                        setTextInstanceBlueSecondValue = true;
                        TextInstanceBlueSecondValue = 169;
                        setTextInstanceGreenSecondValue = true;
                        TextInstanceGreenSecondValue = 169;
                        setTextInstanceRedSecondValue = true;
                        TextInstanceRedSecondValue = 169;
                        break;
                    case  CheckBoxCategory.DisabledOff:
                        setColoredRectangleInstanceBlueSecondValue = true;
                        ColoredRectangleInstanceBlueSecondValue = 169;
                        setColoredRectangleInstanceGreenSecondValue = true;
                        ColoredRectangleInstanceGreenSecondValue = 169;
                        setColoredRectangleInstanceRedSecondValue = true;
                        ColoredRectangleInstanceRedSecondValue = 169;
                        setSpriteInstanceBlueSecondValue = true;
                        SpriteInstanceBlueSecondValue = 255;
                        setSpriteInstanceGreenSecondValue = true;
                        SpriteInstanceGreenSecondValue = 255;
                        setSpriteInstanceRedSecondValue = true;
                        SpriteInstanceRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.Visible = false;
                        }
                        setTextInstanceBlueSecondValue = true;
                        TextInstanceBlueSecondValue = 169;
                        setTextInstanceGreenSecondValue = true;
                        TextInstanceGreenSecondValue = 169;
                        setTextInstanceRedSecondValue = true;
                        TextInstanceRedSecondValue = 169;
                        break;
                    case  CheckBoxCategory.HighlightedOn:
                        setColoredRectangleInstanceBlueSecondValue = true;
                        ColoredRectangleInstanceBlueSecondValue = 100;
                        setColoredRectangleInstanceGreenSecondValue = true;
                        ColoredRectangleInstanceGreenSecondValue = 100;
                        setColoredRectangleInstanceRedSecondValue = true;
                        ColoredRectangleInstanceRedSecondValue = 0;
                        setSpriteInstanceBlueSecondValue = true;
                        SpriteInstanceBlueSecondValue = 212;
                        setSpriteInstanceGreenSecondValue = true;
                        SpriteInstanceGreenSecondValue = 255;
                        setSpriteInstanceRedSecondValue = true;
                        SpriteInstanceRedSecondValue = 127;
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.Visible = true;
                        }
                        setTextInstanceBlueSecondValue = true;
                        TextInstanceBlueSecondValue = 212;
                        setTextInstanceGreenSecondValue = true;
                        TextInstanceGreenSecondValue = 255;
                        setTextInstanceRedSecondValue = true;
                        TextInstanceRedSecondValue = 127;
                        break;
                    case  CheckBoxCategory.HighlightedOff:
                        setColoredRectangleInstanceBlueSecondValue = true;
                        ColoredRectangleInstanceBlueSecondValue = 100;
                        setColoredRectangleInstanceGreenSecondValue = true;
                        ColoredRectangleInstanceGreenSecondValue = 100;
                        setColoredRectangleInstanceRedSecondValue = true;
                        ColoredRectangleInstanceRedSecondValue = 0;
                        setSpriteInstanceBlueSecondValue = true;
                        SpriteInstanceBlueSecondValue = 255;
                        setSpriteInstanceGreenSecondValue = true;
                        SpriteInstanceGreenSecondValue = 255;
                        setSpriteInstanceRedSecondValue = true;
                        SpriteInstanceRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.Visible = false;
                        }
                        setTextInstanceBlueSecondValue = true;
                        TextInstanceBlueSecondValue = 212;
                        setTextInstanceGreenSecondValue = true;
                        TextInstanceGreenSecondValue = 255;
                        setTextInstanceRedSecondValue = true;
                        TextInstanceRedSecondValue = 127;
                        break;
                    case  CheckBoxCategory.PushedOn:
                        setColoredRectangleInstanceBlueSecondValue = true;
                        ColoredRectangleInstanceBlueSecondValue = 255;
                        setColoredRectangleInstanceGreenSecondValue = true;
                        ColoredRectangleInstanceGreenSecondValue = 144;
                        setColoredRectangleInstanceRedSecondValue = true;
                        ColoredRectangleInstanceRedSecondValue = 30;
                        setSpriteInstanceBlueSecondValue = true;
                        SpriteInstanceBlueSecondValue = 255;
                        setSpriteInstanceGreenSecondValue = true;
                        SpriteInstanceGreenSecondValue = 255;
                        setSpriteInstanceRedSecondValue = true;
                        SpriteInstanceRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.Visible = true;
                        }
                        setTextInstanceBlueSecondValue = true;
                        TextInstanceBlueSecondValue = 230;
                        setTextInstanceGreenSecondValue = true;
                        TextInstanceGreenSecondValue = 230;
                        setTextInstanceRedSecondValue = true;
                        TextInstanceRedSecondValue = 230;
                        break;
                    case  CheckBoxCategory.PushedOff:
                        setColoredRectangleInstanceBlueSecondValue = true;
                        ColoredRectangleInstanceBlueSecondValue = 255;
                        setColoredRectangleInstanceGreenSecondValue = true;
                        ColoredRectangleInstanceGreenSecondValue = 144;
                        setColoredRectangleInstanceRedSecondValue = true;
                        ColoredRectangleInstanceRedSecondValue = 30;
                        setSpriteInstanceBlueSecondValue = true;
                        SpriteInstanceBlueSecondValue = 139;
                        setSpriteInstanceGreenSecondValue = true;
                        SpriteInstanceGreenSecondValue = 0;
                        setSpriteInstanceRedSecondValue = true;
                        SpriteInstanceRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.Visible = false;
                        }
                        setTextInstanceBlueSecondValue = true;
                        TextInstanceBlueSecondValue = 250;
                        setTextInstanceGreenSecondValue = true;
                        TextInstanceGreenSecondValue = 230;
                        setTextInstanceRedSecondValue = true;
                        TextInstanceRedSecondValue = 230;
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
                if (setSpriteInstanceBlueFirstValue && setSpriteInstanceBlueSecondValue)
                {
                    SpriteInstance.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(SpriteInstanceBlueFirstValue* (1 - interpolationValue) + SpriteInstanceBlueSecondValue * interpolationValue);
                }
                if (setSpriteInstanceGreenFirstValue && setSpriteInstanceGreenSecondValue)
                {
                    SpriteInstance.Green = FlatRedBall.Math.MathFunctions.RoundToInt(SpriteInstanceGreenFirstValue* (1 - interpolationValue) + SpriteInstanceGreenSecondValue * interpolationValue);
                }
                if (setSpriteInstanceRedFirstValue && setSpriteInstanceRedSecondValue)
                {
                    SpriteInstance.Red = FlatRedBall.Math.MathFunctions.RoundToInt(SpriteInstanceRedFirstValue* (1 - interpolationValue) + SpriteInstanceRedSecondValue * interpolationValue);
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
                    mCurrentCheckBoxCategoryState = firstState;
                }
                else
                {
                    mCurrentCheckBoxCategoryState = secondState;
                }
            }
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.CheckBoxRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.CheckBoxRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.CheckBoxRuntime.CheckBoxCategory fromState,AbbatoirIntergrade.GumRuntimes.CheckBoxRuntime.CheckBoxCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (CheckBoxCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "CheckBoxCategory").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentCheckBoxCategoryState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (CheckBoxCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentCheckBoxCategoryState = toState;
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
                            Name = "ColoredRectangleInstance.X",
                            Type = "float",
                            Value = ColoredRectangleInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ColoredRectangleInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.X Units",
                            Type = "PositionUnitType",
                            Value = ColoredRectangleInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Y",
                            Type = "float",
                            Value = ColoredRectangleInstance.Y
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
                            Name = "SpriteInstance.Blue",
                            Type = "int",
                            Value = SpriteInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Green",
                            Type = "int",
                            Value = SpriteInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = SpriteInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Parent",
                            Type = "string",
                            Value = SpriteInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Red",
                            Type = "int",
                            Value = SpriteInstance.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.SourceFile",
                            Type = "string",
                            Value = SpriteInstance.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Address",
                            Type = "TextureAddress",
                            Value = SpriteInstance.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Height",
                            Type = "int",
                            Value = SpriteInstance.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Left",
                            Type = "int",
                            Value = SpriteInstance.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Top",
                            Type = "int",
                            Value = SpriteInstance.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Width",
                            Type = "int",
                            Value = SpriteInstance.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = SpriteInstance.WidthUnits
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
                            Name = "TextInstance.UseCustomFont",
                            Type = "bool",
                            Value = TextInstance.UseCustomFont
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
                            Value = Height + 50f
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
                            Value = ColoredRectangleInstance.Height + -8f
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
                            Value = ColoredRectangleInstance.Width + -8f
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
                            Name = "ColoredRectangleInstance.X",
                            Type = "float",
                            Value = ColoredRectangleInstance.X + 4f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ColoredRectangleInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.X Units",
                            Type = "PositionUnitType",
                            Value = ColoredRectangleInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Y",
                            Type = "float",
                            Value = ColoredRectangleInstance.Y + 4f
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
                            Name = "SpriteInstance.Blue",
                            Type = "int",
                            Value = SpriteInstance.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Green",
                            Type = "int",
                            Value = SpriteInstance.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = SpriteInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Parent",
                            Type = "string",
                            Value = SpriteInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Red",
                            Type = "int",
                            Value = SpriteInstance.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.SourceFile",
                            Type = "string",
                            Value = SpriteInstance.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Address",
                            Type = "TextureAddress",
                            Value = SpriteInstance.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Height",
                            Type = "int",
                            Value = SpriteInstance.TextureHeight + 128
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Left",
                            Type = "int",
                            Value = SpriteInstance.TextureLeft + 3585
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Top",
                            Type = "int",
                            Value = SpriteInstance.TextureTop + 1728
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Texture Width",
                            Type = "int",
                            Value = SpriteInstance.TextureWidth + 128
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = SpriteInstance.WidthUnits
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
                            Value = ColoredRectangleInstance1.Width + 100f
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
                            Value = ColoredRectangleInstance1.X + 3f
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
                            Value = TextInstance.FontScale + 0.5f
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
                            Name = "TextInstance.UseCustomFont",
                            Type = "bool",
                            Value = TextInstance.UseCustomFont
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
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (CheckBoxCategory state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  CheckBoxCategory.EnabledOn:
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
                            Name = "SpriteInstance.Blue",
                            Type = "int",
                            Value = SpriteInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Green",
                            Type = "int",
                            Value = SpriteInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Red",
                            Type = "int",
                            Value = SpriteInstance.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Visible",
                            Type = "bool",
                            Value = SpriteInstance.Visible
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
                    case  CheckBoxCategory.EnabledOff:
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
                            Name = "SpriteInstance.Blue",
                            Type = "int",
                            Value = SpriteInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Green",
                            Type = "int",
                            Value = SpriteInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Red",
                            Type = "int",
                            Value = SpriteInstance.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Visible",
                            Type = "bool",
                            Value = SpriteInstance.Visible
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
                    case  CheckBoxCategory.DisabledOn:
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
                            Name = "SpriteInstance.Blue",
                            Type = "int",
                            Value = SpriteInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Green",
                            Type = "int",
                            Value = SpriteInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Red",
                            Type = "int",
                            Value = SpriteInstance.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Visible",
                            Type = "bool",
                            Value = SpriteInstance.Visible
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
                    case  CheckBoxCategory.DisabledOff:
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
                            Name = "SpriteInstance.Blue",
                            Type = "int",
                            Value = SpriteInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Green",
                            Type = "int",
                            Value = SpriteInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Red",
                            Type = "int",
                            Value = SpriteInstance.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Visible",
                            Type = "bool",
                            Value = SpriteInstance.Visible
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
                    case  CheckBoxCategory.HighlightedOn:
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
                            Name = "SpriteInstance.Blue",
                            Type = "int",
                            Value = SpriteInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Green",
                            Type = "int",
                            Value = SpriteInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Red",
                            Type = "int",
                            Value = SpriteInstance.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Visible",
                            Type = "bool",
                            Value = SpriteInstance.Visible
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
                    case  CheckBoxCategory.HighlightedOff:
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
                            Name = "SpriteInstance.Blue",
                            Type = "int",
                            Value = SpriteInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Green",
                            Type = "int",
                            Value = SpriteInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Red",
                            Type = "int",
                            Value = SpriteInstance.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Visible",
                            Type = "bool",
                            Value = SpriteInstance.Visible
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
                    case  CheckBoxCategory.PushedOn:
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
                            Name = "SpriteInstance.Blue",
                            Type = "int",
                            Value = SpriteInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Green",
                            Type = "int",
                            Value = SpriteInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Red",
                            Type = "int",
                            Value = SpriteInstance.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Visible",
                            Type = "bool",
                            Value = SpriteInstance.Visible
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
                    case  CheckBoxCategory.PushedOff:
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
                            Name = "SpriteInstance.Blue",
                            Type = "int",
                            Value = SpriteInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Green",
                            Type = "int",
                            Value = SpriteInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Red",
                            Type = "int",
                            Value = SpriteInstance.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Visible",
                            Type = "bool",
                            Value = SpriteInstance.Visible
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
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (CheckBoxCategory state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  CheckBoxCategory.EnabledOn:
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
                            Name = "SpriteInstance.Blue",
                            Type = "int",
                            Value = SpriteInstance.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Green",
                            Type = "int",
                            Value = SpriteInstance.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Red",
                            Type = "int",
                            Value = SpriteInstance.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Visible",
                            Type = "bool",
                            Value = SpriteInstance.Visible
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
                    case  CheckBoxCategory.EnabledOff:
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
                            Name = "SpriteInstance.Blue",
                            Type = "int",
                            Value = SpriteInstance.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Green",
                            Type = "int",
                            Value = SpriteInstance.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Red",
                            Type = "int",
                            Value = SpriteInstance.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Visible",
                            Type = "bool",
                            Value = SpriteInstance.Visible
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
                    case  CheckBoxCategory.DisabledOn:
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
                            Name = "SpriteInstance.Blue",
                            Type = "int",
                            Value = SpriteInstance.Blue + 220
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Green",
                            Type = "int",
                            Value = SpriteInstance.Green + 220
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Red",
                            Type = "int",
                            Value = SpriteInstance.Red + 220
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Visible",
                            Type = "bool",
                            Value = SpriteInstance.Visible
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
                    case  CheckBoxCategory.DisabledOff:
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
                            Name = "SpriteInstance.Blue",
                            Type = "int",
                            Value = SpriteInstance.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Green",
                            Type = "int",
                            Value = SpriteInstance.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Red",
                            Type = "int",
                            Value = SpriteInstance.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Visible",
                            Type = "bool",
                            Value = SpriteInstance.Visible
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
                    case  CheckBoxCategory.HighlightedOn:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Blue",
                            Type = "int",
                            Value = ColoredRectangleInstance.Blue + 100
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Green",
                            Type = "int",
                            Value = ColoredRectangleInstance.Green + 100
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
                            Name = "SpriteInstance.Blue",
                            Type = "int",
                            Value = SpriteInstance.Blue + 212
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Green",
                            Type = "int",
                            Value = SpriteInstance.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Red",
                            Type = "int",
                            Value = SpriteInstance.Red + 127
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Visible",
                            Type = "bool",
                            Value = SpriteInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Blue",
                            Type = "int",
                            Value = TextInstance.Blue + 212
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
                            Value = TextInstance.Red + 127
                        }
                        );
                        break;
                    case  CheckBoxCategory.HighlightedOff:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Blue",
                            Type = "int",
                            Value = ColoredRectangleInstance.Blue + 100
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Green",
                            Type = "int",
                            Value = ColoredRectangleInstance.Green + 100
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
                            Name = "SpriteInstance.Blue",
                            Type = "int",
                            Value = SpriteInstance.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Green",
                            Type = "int",
                            Value = SpriteInstance.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Red",
                            Type = "int",
                            Value = SpriteInstance.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Visible",
                            Type = "bool",
                            Value = SpriteInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Blue",
                            Type = "int",
                            Value = TextInstance.Blue + 212
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
                            Value = TextInstance.Red + 127
                        }
                        );
                        break;
                    case  CheckBoxCategory.PushedOn:
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
                            Value = ColoredRectangleInstance.Green + 144
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Red",
                            Type = "int",
                            Value = ColoredRectangleInstance.Red + 30
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Blue",
                            Type = "int",
                            Value = SpriteInstance.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Green",
                            Type = "int",
                            Value = SpriteInstance.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Red",
                            Type = "int",
                            Value = SpriteInstance.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Visible",
                            Type = "bool",
                            Value = SpriteInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Blue",
                            Type = "int",
                            Value = TextInstance.Blue + 230
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Green",
                            Type = "int",
                            Value = TextInstance.Green + 230
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Red",
                            Type = "int",
                            Value = TextInstance.Red + 230
                        }
                        );
                        break;
                    case  CheckBoxCategory.PushedOff:
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
                            Value = ColoredRectangleInstance.Green + 144
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Red",
                            Type = "int",
                            Value = ColoredRectangleInstance.Red + 30
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Blue",
                            Type = "int",
                            Value = SpriteInstance.Blue + 139
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Green",
                            Type = "int",
                            Value = SpriteInstance.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Red",
                            Type = "int",
                            Value = SpriteInstance.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Visible",
                            Type = "bool",
                            Value = SpriteInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Blue",
                            Type = "int",
                            Value = TextInstance.Blue + 250
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Green",
                            Type = "int",
                            Value = TextInstance.Green + 230
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Red",
                            Type = "int",
                            Value = TextInstance.Red + 230
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
                    else if (category.Name == "CheckBoxCategory")
                    {
                        if(state.Name == "EnabledOn") this.mCurrentCheckBoxCategoryState = CheckBoxCategory.EnabledOn;
                        if(state.Name == "EnabledOff") this.mCurrentCheckBoxCategoryState = CheckBoxCategory.EnabledOff;
                        if(state.Name == "DisabledOn") this.mCurrentCheckBoxCategoryState = CheckBoxCategory.DisabledOn;
                        if(state.Name == "DisabledOff") this.mCurrentCheckBoxCategoryState = CheckBoxCategory.DisabledOff;
                        if(state.Name == "HighlightedOn") this.mCurrentCheckBoxCategoryState = CheckBoxCategory.HighlightedOn;
                        if(state.Name == "HighlightedOff") this.mCurrentCheckBoxCategoryState = CheckBoxCategory.HighlightedOff;
                        if(state.Name == "PushedOn") this.mCurrentCheckBoxCategoryState = CheckBoxCategory.PushedOn;
                        if(state.Name == "PushedOff") this.mCurrentCheckBoxCategoryState = CheckBoxCategory.PushedOff;
                    }
                }
                base.ApplyState(state);
            }
            private bool tryCreateFormsObject;
            private AbbatoirIntergrade.GumRuntimes.ColoredRectangleRuntime ColoredRectangleInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime SpriteInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ColoredRectangleRuntime ColoredRectangleInstance1 { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime TextInstance { get; set; }
            public string CheckBoxText
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
                        CheckBoxTextChanged?.Invoke(this, null);
                    }
                }
            }
            public event System.EventHandler CheckBoxTextChanged;
            public CheckBoxRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                this.tryCreateFormsObject = tryCreateFormsObject;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "CheckBox");
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
                SpriteInstance = this.GetGraphicalUiElementByName("SpriteInstance") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                ColoredRectangleInstance1 = this.GetGraphicalUiElementByName("ColoredRectangleInstance1") as AbbatoirIntergrade.GumRuntimes.ColoredRectangleRuntime;
                TextInstance = this.GetGraphicalUiElementByName("TextInstance") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
                if (tryCreateFormsObject)
                {
                    FormsControl = new FlatRedBall.Forms.Controls.CheckBox(this);
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
            public FlatRedBall.Forms.Controls.CheckBox FormsControl {get; private set;}
            public override object FormsControlAsObject { get { return FormsControl; } }
        }
    }
