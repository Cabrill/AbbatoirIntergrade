    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes
    {
        public partial class UpgradeInfoRuntime : AbbatoirIntergrade.GumRuntimes.ContainerRuntime
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            public enum OptionsAvailability
            {
                OneOption,
                TwoOptions
            }
            public enum OptionOneChoice
            {
                UpgradeRange,
                UpgradeSpeed,
                UpgradeDamage
            }
            public enum OptionTwoChoice
            {
                UpgradeRange,
                UpgradeSpeed,
                UpgradeDamage
            }
            public enum Affordability
            {
                CanAfford,
                CantAfford
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            OptionsAvailability mCurrentOptionsAvailabilityState;
            OptionOneChoice mCurrentOptionOneChoiceState;
            OptionTwoChoice mCurrentOptionTwoChoiceState;
            Affordability mCurrentAffordabilityState;
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
                            ChildrenLayout = Gum.Managers.ChildrenLayout.Regular;
                            Width = 300f;
                            WrapsChildren = false;
                            WhiteFrameInstance.CurrentColorState = AbbatoirIntergrade.GumRuntimes.WhiteFrameRuntime.Color.Green;
                            WhiteFrameInstance.Height = 100f;
                            WhiteFrameInstance.Width = 100f;
                            UpgradeText.Blue = 140;
                            SetProperty("UpgradeText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                            UpgradeText.Font = "Moire ExtraBold";
                            UpgradeText.FontScale = 0.7f;
                            UpgradeText.FontSize = 50;
                            UpgradeText.Green = 230;
                            UpgradeText.Height = 0f;
                            UpgradeText.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            UpgradeText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            UpgradeText.OutlineThickness = 2;
                            UpgradeText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "TitleContainer");
                            UpgradeText.Red = 240;
                            UpgradeText.Text = "Upgrade:";
                            UpgradeText.UseCustomFont = true;
                            UpgradeText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Top;
                            UpgradeText.Visible = true;
                            UpgradeText.Width = 0f;
                            UpgradeText.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            Upgrade1Text.Blue = 255;
                            SetProperty("Upgrade1Text.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                            Upgrade1Text.FontScale = 0.4f;
                            Upgrade1Text.Green = 255;
                            Upgrade1Text.Height = 0f;
                            Upgrade1Text.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            Upgrade1Text.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "UpgradeContainer");
                            Upgrade1Text.Red = 0;
                            Upgrade1Text.Text = "Type1";
                            Upgrade1Text.UseCustomFont = true;
                            Upgrade1Text.Width = 0f;
                            Upgrade1Text.X = 21.5f;
                            Upgrade1Text.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            Upgrade1Text.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            Upgrade1Text.Y = 0f;
                            Upgrade1Text.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                            Upgrade1Text.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            Upgrade1Type.Height = 75f;
                            Upgrade1Type.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            Upgrade1Type.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "UpgradeContainer");
                            Upgrade1Type.Width = 100f;
                            Upgrade1Type.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                            Upgrade1Type.X = 21.5f;
                            Upgrade1Type.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            Upgrade1Type.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            Upgrade1Type.Y = 25f;
                            Upgrade1Type.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                            Upgrade1Type.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            OrTextInstance.Blue = 220;
                            SetProperty("OrTextInstance.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                            OrTextInstance.FontScale = 0.6f;
                            OrTextInstance.Green = 220;
                            OrTextInstance.Height = 0f;
                            OrTextInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "UpgradeContainer");
                            OrTextInstance.Red = 220;
                            OrTextInstance.Text = "Or";
                            OrTextInstance.UseCustomFont = true;
                            OrTextInstance.Width = 0f;
                            OrTextInstance.X = 0f;
                            OrTextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            OrTextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            OrTextInstance.Y = 0f;
                            OrTextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            OrTextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            Upgrade2Text.Blue = 255;
                            SetProperty("Upgrade2Text.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                            Upgrade2Text.FontScale = 0.4f;
                            Upgrade2Text.Green = 255;
                            Upgrade2Text.Height = 0f;
                            Upgrade2Text.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            Upgrade2Text.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "UpgradeContainer");
                            Upgrade2Text.Red = 0;
                            Upgrade2Text.Text = "Type1";
                            Upgrade2Text.UseCustomFont = true;
                            Upgrade2Text.Width = 0f;
                            Upgrade2Text.X = 78.5f;
                            Upgrade2Text.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            Upgrade2Text.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            Upgrade2Text.Y = 0f;
                            Upgrade2Text.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                            Upgrade2Text.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            Upgrade2Type.Height = 75f;
                            Upgrade2Type.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            Upgrade2Type.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "UpgradeContainer");
                            Upgrade2Type.Width = 100f;
                            Upgrade2Type.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                            Upgrade2Type.X = 78.5f;
                            Upgrade2Type.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            Upgrade2Type.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            Upgrade2Type.Y = 25f;
                            Upgrade2Type.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                            Upgrade2Type.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            TitleContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                            TitleContainer.Height = 40f;
                            TitleContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            TitleContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ContainerInstance");
                            TitleContainer.Width = 100f;
                            TitleContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            TitleContainer.WrapsChildren = false;
                            UpgradeContainer.Height = -40f;
                            UpgradeContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            UpgradeContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ContainerInstance");
                            UpgradeContainer.Visible = true;
                            UpgradeContainer.Width = 100f;
                            UpgradeContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            UpgradeContainer.X = 0f;
                            UpgradeContainer.Y = 0f;
                            UpgradeContainer.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                            UpgradeContainer.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            CostText.Blue = 255;
                            SetProperty("CostText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                            CostText.Font = "Moire ExtraBold";
                            CostText.FontScale = 0.7f;
                            CostText.FontSize = 50;
                            CostText.Green = 255;
                            CostText.Height = 0f;
                            CostText.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            CostText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            CostText.OutlineThickness = 2;
                            CostText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "TitleContainer");
                            CostText.Red = 0;
                            CostText.Text = "5";
                            CostText.UseCustomFont = true;
                            CostText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Top;
                            CostText.Visible = true;
                            CostText.Width = 0f;
                            CostText.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            CostText.X = 10f;
                            CostText.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            CostText.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            PointsSprite.Height = 95f;
                            PointsSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            PointsSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "TitleContainer");
                            SetProperty("PointsSprite.SourceFile", "AllUIAssets.png");
                            PointsSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            PointsSprite.TextureHeight = 122;
                            PointsSprite.TextureLeft = 2435;
                            PointsSprite.TextureTop = 910;
                            PointsSprite.TextureWidth = 128;
                            PointsSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                            PointsSprite.X = 0f;
                            PointsSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            PointsSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            PointsSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            PointsSprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            ContainerInstance.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                            ContainerInstance.Height = -8f;
                            ContainerInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            ContainerInstance.Width = -8f;
                            ContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            ContainerInstance.X = 4f;
                            ContainerInstance.Y = 4f;
                            break;
                    }
                }
            }
            public OptionsAvailability CurrentOptionsAvailabilityState
            {
                get
                {
                    return mCurrentOptionsAvailabilityState;
                }
                set
                {
                    mCurrentOptionsAvailabilityState = value;
                    switch(mCurrentOptionsAvailabilityState)
                    {
                        case  OptionsAvailability.OneOption:
                            Upgrade1Text.X = 50f;
                            Upgrade1Type.X = 50f;
                            OrTextInstance.Visible = false;
                            Upgrade2Text.Visible = false;
                            Upgrade2Type.Visible = false;
                            break;
                        case  OptionsAvailability.TwoOptions:
                            Upgrade1Text.X = 21.5f;
                            Upgrade1Type.X = 21.5f;
                            OrTextInstance.Visible = true;
                            Upgrade2Text.Visible = true;
                            Upgrade2Type.Visible = true;
                            break;
                    }
                }
            }
            public OptionOneChoice CurrentOptionOneChoiceState
            {
                get
                {
                    return mCurrentOptionOneChoiceState;
                }
                set
                {
                    mCurrentOptionOneChoiceState = value;
                    switch(mCurrentOptionOneChoiceState)
                    {
                        case  OptionOneChoice.UpgradeRange:
                            Upgrade1Text.Text = "Range";
                            Upgrade1Type.CurrentAttributeTypeState = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.MaxRange;
                            break;
                        case  OptionOneChoice.UpgradeSpeed:
                            Upgrade1Text.Text = "Speed";
                            Upgrade1Type.CurrentAttributeTypeState = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.AttackSpeed;
                            break;
                        case  OptionOneChoice.UpgradeDamage:
                            Upgrade1Text.Text = "Damage";
                            Upgrade1Type.CurrentAttributeTypeState = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.Health;
                            break;
                    }
                }
            }
            public OptionTwoChoice CurrentOptionTwoChoiceState
            {
                get
                {
                    return mCurrentOptionTwoChoiceState;
                }
                set
                {
                    mCurrentOptionTwoChoiceState = value;
                    switch(mCurrentOptionTwoChoiceState)
                    {
                        case  OptionTwoChoice.UpgradeRange:
                            Upgrade2Text.Text = "Range";
                            Upgrade2Type.CurrentAttributeTypeState = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.MaxRange;
                            break;
                        case  OptionTwoChoice.UpgradeSpeed:
                            Upgrade2Text.Text = "Speed";
                            Upgrade2Type.CurrentAttributeTypeState = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.AttackSpeed;
                            break;
                        case  OptionTwoChoice.UpgradeDamage:
                            Upgrade2Text.Text = "Damage";
                            Upgrade2Type.CurrentAttributeTypeState = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.Health;
                            break;
                    }
                }
            }
            public Affordability CurrentAffordabilityState
            {
                get
                {
                    return mCurrentAffordabilityState;
                }
                set
                {
                    mCurrentAffordabilityState = value;
                    switch(mCurrentAffordabilityState)
                    {
                        case  Affordability.CanAfford:
                            WhiteFrameInstance.CurrentColorState = AbbatoirIntergrade.GumRuntimes.WhiteFrameRuntime.Color.Green;
                            UpgradeText.Alpha = 255;
                            Upgrade1Text.Alpha = 255;
                            OrTextInstance.Alpha = 255;
                            Upgrade2Text.Alpha = 255;
                            CostText.Blue = 255;
                            CostText.Green = 255;
                            CostText.Red = 0;
                            PointsSprite.Alpha = 255;
                            break;
                        case  Affordability.CantAfford:
                            WhiteFrameInstance.CurrentColorState = AbbatoirIntergrade.GumRuntimes.WhiteFrameRuntime.Color.Red;
                            UpgradeText.Alpha = 100;
                            Upgrade1Text.Alpha = 100;
                            Upgrade1Type.IconAlpha = 100;
                            OrTextInstance.Alpha = 50;
                            Upgrade2Text.Alpha = 100;
                            Upgrade2Type.IconAlpha = 100;
                            CostText.Blue = 0;
                            CostText.Green = 0;
                            CostText.Red = 255;
                            PointsSprite.Alpha = 150;
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
                bool setCostTextBlueFirstValue = false;
                bool setCostTextBlueSecondValue = false;
                int CostTextBlueFirstValue= 0;
                int CostTextBlueSecondValue= 0;
                bool setCostTextFontScaleFirstValue = false;
                bool setCostTextFontScaleSecondValue = false;
                float CostTextFontScaleFirstValue= 0;
                float CostTextFontScaleSecondValue= 0;
                bool setCostTextFontSizeFirstValue = false;
                bool setCostTextFontSizeSecondValue = false;
                int CostTextFontSizeFirstValue= 0;
                int CostTextFontSizeSecondValue= 0;
                bool setCostTextGreenFirstValue = false;
                bool setCostTextGreenSecondValue = false;
                int CostTextGreenFirstValue= 0;
                int CostTextGreenSecondValue= 0;
                bool setCostTextHeightFirstValue = false;
                bool setCostTextHeightSecondValue = false;
                float CostTextHeightFirstValue= 0;
                float CostTextHeightSecondValue= 0;
                bool setCostTextOutlineThicknessFirstValue = false;
                bool setCostTextOutlineThicknessSecondValue = false;
                int CostTextOutlineThicknessFirstValue= 0;
                int CostTextOutlineThicknessSecondValue= 0;
                bool setCostTextRedFirstValue = false;
                bool setCostTextRedSecondValue = false;
                int CostTextRedFirstValue= 0;
                int CostTextRedSecondValue= 0;
                bool setCostTextWidthFirstValue = false;
                bool setCostTextWidthSecondValue = false;
                float CostTextWidthFirstValue= 0;
                float CostTextWidthSecondValue= 0;
                bool setCostTextXFirstValue = false;
                bool setCostTextXSecondValue = false;
                float CostTextXFirstValue= 0;
                float CostTextXSecondValue= 0;
                bool setOrTextInstanceBlueFirstValue = false;
                bool setOrTextInstanceBlueSecondValue = false;
                int OrTextInstanceBlueFirstValue= 0;
                int OrTextInstanceBlueSecondValue= 0;
                bool setOrTextInstanceFontScaleFirstValue = false;
                bool setOrTextInstanceFontScaleSecondValue = false;
                float OrTextInstanceFontScaleFirstValue= 0;
                float OrTextInstanceFontScaleSecondValue= 0;
                bool setOrTextInstanceGreenFirstValue = false;
                bool setOrTextInstanceGreenSecondValue = false;
                int OrTextInstanceGreenFirstValue= 0;
                int OrTextInstanceGreenSecondValue= 0;
                bool setOrTextInstanceHeightFirstValue = false;
                bool setOrTextInstanceHeightSecondValue = false;
                float OrTextInstanceHeightFirstValue= 0;
                float OrTextInstanceHeightSecondValue= 0;
                bool setOrTextInstanceRedFirstValue = false;
                bool setOrTextInstanceRedSecondValue = false;
                int OrTextInstanceRedFirstValue= 0;
                int OrTextInstanceRedSecondValue= 0;
                bool setOrTextInstanceWidthFirstValue = false;
                bool setOrTextInstanceWidthSecondValue = false;
                float OrTextInstanceWidthFirstValue= 0;
                float OrTextInstanceWidthSecondValue= 0;
                bool setOrTextInstanceXFirstValue = false;
                bool setOrTextInstanceXSecondValue = false;
                float OrTextInstanceXFirstValue= 0;
                float OrTextInstanceXSecondValue= 0;
                bool setOrTextInstanceYFirstValue = false;
                bool setOrTextInstanceYSecondValue = false;
                float OrTextInstanceYFirstValue= 0;
                float OrTextInstanceYSecondValue= 0;
                bool setPointsSpriteHeightFirstValue = false;
                bool setPointsSpriteHeightSecondValue = false;
                float PointsSpriteHeightFirstValue= 0;
                float PointsSpriteHeightSecondValue= 0;
                bool setPointsSpriteTextureHeightFirstValue = false;
                bool setPointsSpriteTextureHeightSecondValue = false;
                int PointsSpriteTextureHeightFirstValue= 0;
                int PointsSpriteTextureHeightSecondValue= 0;
                bool setPointsSpriteTextureLeftFirstValue = false;
                bool setPointsSpriteTextureLeftSecondValue = false;
                int PointsSpriteTextureLeftFirstValue= 0;
                int PointsSpriteTextureLeftSecondValue= 0;
                bool setPointsSpriteTextureTopFirstValue = false;
                bool setPointsSpriteTextureTopSecondValue = false;
                int PointsSpriteTextureTopFirstValue= 0;
                int PointsSpriteTextureTopSecondValue= 0;
                bool setPointsSpriteTextureWidthFirstValue = false;
                bool setPointsSpriteTextureWidthSecondValue = false;
                int PointsSpriteTextureWidthFirstValue= 0;
                int PointsSpriteTextureWidthSecondValue= 0;
                bool setPointsSpriteXFirstValue = false;
                bool setPointsSpriteXSecondValue = false;
                float PointsSpriteXFirstValue= 0;
                float PointsSpriteXSecondValue= 0;
                bool setTitleContainerHeightFirstValue = false;
                bool setTitleContainerHeightSecondValue = false;
                float TitleContainerHeightFirstValue= 0;
                float TitleContainerHeightSecondValue= 0;
                bool setTitleContainerWidthFirstValue = false;
                bool setTitleContainerWidthSecondValue = false;
                float TitleContainerWidthFirstValue= 0;
                float TitleContainerWidthSecondValue= 0;
                bool setUpgrade1TextBlueFirstValue = false;
                bool setUpgrade1TextBlueSecondValue = false;
                int Upgrade1TextBlueFirstValue= 0;
                int Upgrade1TextBlueSecondValue= 0;
                bool setUpgrade1TextFontScaleFirstValue = false;
                bool setUpgrade1TextFontScaleSecondValue = false;
                float Upgrade1TextFontScaleFirstValue= 0;
                float Upgrade1TextFontScaleSecondValue= 0;
                bool setUpgrade1TextGreenFirstValue = false;
                bool setUpgrade1TextGreenSecondValue = false;
                int Upgrade1TextGreenFirstValue= 0;
                int Upgrade1TextGreenSecondValue= 0;
                bool setUpgrade1TextHeightFirstValue = false;
                bool setUpgrade1TextHeightSecondValue = false;
                float Upgrade1TextHeightFirstValue= 0;
                float Upgrade1TextHeightSecondValue= 0;
                bool setUpgrade1TextRedFirstValue = false;
                bool setUpgrade1TextRedSecondValue = false;
                int Upgrade1TextRedFirstValue= 0;
                int Upgrade1TextRedSecondValue= 0;
                bool setUpgrade1TextWidthFirstValue = false;
                bool setUpgrade1TextWidthSecondValue = false;
                float Upgrade1TextWidthFirstValue= 0;
                float Upgrade1TextWidthSecondValue= 0;
                bool setUpgrade1TextXFirstValue = false;
                bool setUpgrade1TextXSecondValue = false;
                float Upgrade1TextXFirstValue= 0;
                float Upgrade1TextXSecondValue= 0;
                bool setUpgrade1TextYFirstValue = false;
                bool setUpgrade1TextYSecondValue = false;
                float Upgrade1TextYFirstValue= 0;
                float Upgrade1TextYSecondValue= 0;
                bool setUpgrade1TypeHeightFirstValue = false;
                bool setUpgrade1TypeHeightSecondValue = false;
                float Upgrade1TypeHeightFirstValue= 0;
                float Upgrade1TypeHeightSecondValue= 0;
                bool setUpgrade1TypeWidthFirstValue = false;
                bool setUpgrade1TypeWidthSecondValue = false;
                float Upgrade1TypeWidthFirstValue= 0;
                float Upgrade1TypeWidthSecondValue= 0;
                bool setUpgrade1TypeXFirstValue = false;
                bool setUpgrade1TypeXSecondValue = false;
                float Upgrade1TypeXFirstValue= 0;
                float Upgrade1TypeXSecondValue= 0;
                bool setUpgrade1TypeYFirstValue = false;
                bool setUpgrade1TypeYSecondValue = false;
                float Upgrade1TypeYFirstValue= 0;
                float Upgrade1TypeYSecondValue= 0;
                bool setUpgrade2TextBlueFirstValue = false;
                bool setUpgrade2TextBlueSecondValue = false;
                int Upgrade2TextBlueFirstValue= 0;
                int Upgrade2TextBlueSecondValue= 0;
                bool setUpgrade2TextFontScaleFirstValue = false;
                bool setUpgrade2TextFontScaleSecondValue = false;
                float Upgrade2TextFontScaleFirstValue= 0;
                float Upgrade2TextFontScaleSecondValue= 0;
                bool setUpgrade2TextGreenFirstValue = false;
                bool setUpgrade2TextGreenSecondValue = false;
                int Upgrade2TextGreenFirstValue= 0;
                int Upgrade2TextGreenSecondValue= 0;
                bool setUpgrade2TextHeightFirstValue = false;
                bool setUpgrade2TextHeightSecondValue = false;
                float Upgrade2TextHeightFirstValue= 0;
                float Upgrade2TextHeightSecondValue= 0;
                bool setUpgrade2TextRedFirstValue = false;
                bool setUpgrade2TextRedSecondValue = false;
                int Upgrade2TextRedFirstValue= 0;
                int Upgrade2TextRedSecondValue= 0;
                bool setUpgrade2TextWidthFirstValue = false;
                bool setUpgrade2TextWidthSecondValue = false;
                float Upgrade2TextWidthFirstValue= 0;
                float Upgrade2TextWidthSecondValue= 0;
                bool setUpgrade2TextXFirstValue = false;
                bool setUpgrade2TextXSecondValue = false;
                float Upgrade2TextXFirstValue= 0;
                float Upgrade2TextXSecondValue= 0;
                bool setUpgrade2TextYFirstValue = false;
                bool setUpgrade2TextYSecondValue = false;
                float Upgrade2TextYFirstValue= 0;
                float Upgrade2TextYSecondValue= 0;
                bool setUpgrade2TypeHeightFirstValue = false;
                bool setUpgrade2TypeHeightSecondValue = false;
                float Upgrade2TypeHeightFirstValue= 0;
                float Upgrade2TypeHeightSecondValue= 0;
                bool setUpgrade2TypeWidthFirstValue = false;
                bool setUpgrade2TypeWidthSecondValue = false;
                float Upgrade2TypeWidthFirstValue= 0;
                float Upgrade2TypeWidthSecondValue= 0;
                bool setUpgrade2TypeXFirstValue = false;
                bool setUpgrade2TypeXSecondValue = false;
                float Upgrade2TypeXFirstValue= 0;
                float Upgrade2TypeXSecondValue= 0;
                bool setUpgrade2TypeYFirstValue = false;
                bool setUpgrade2TypeYSecondValue = false;
                float Upgrade2TypeYFirstValue= 0;
                float Upgrade2TypeYSecondValue= 0;
                bool setUpgradeContainerHeightFirstValue = false;
                bool setUpgradeContainerHeightSecondValue = false;
                float UpgradeContainerHeightFirstValue= 0;
                float UpgradeContainerHeightSecondValue= 0;
                bool setUpgradeContainerWidthFirstValue = false;
                bool setUpgradeContainerWidthSecondValue = false;
                float UpgradeContainerWidthFirstValue= 0;
                float UpgradeContainerWidthSecondValue= 0;
                bool setUpgradeContainerXFirstValue = false;
                bool setUpgradeContainerXSecondValue = false;
                float UpgradeContainerXFirstValue= 0;
                float UpgradeContainerXSecondValue= 0;
                bool setUpgradeContainerYFirstValue = false;
                bool setUpgradeContainerYSecondValue = false;
                float UpgradeContainerYFirstValue= 0;
                float UpgradeContainerYSecondValue= 0;
                bool setUpgradeTextBlueFirstValue = false;
                bool setUpgradeTextBlueSecondValue = false;
                int UpgradeTextBlueFirstValue= 0;
                int UpgradeTextBlueSecondValue= 0;
                bool setUpgradeTextFontScaleFirstValue = false;
                bool setUpgradeTextFontScaleSecondValue = false;
                float UpgradeTextFontScaleFirstValue= 0;
                float UpgradeTextFontScaleSecondValue= 0;
                bool setUpgradeTextFontSizeFirstValue = false;
                bool setUpgradeTextFontSizeSecondValue = false;
                int UpgradeTextFontSizeFirstValue= 0;
                int UpgradeTextFontSizeSecondValue= 0;
                bool setUpgradeTextGreenFirstValue = false;
                bool setUpgradeTextGreenSecondValue = false;
                int UpgradeTextGreenFirstValue= 0;
                int UpgradeTextGreenSecondValue= 0;
                bool setUpgradeTextHeightFirstValue = false;
                bool setUpgradeTextHeightSecondValue = false;
                float UpgradeTextHeightFirstValue= 0;
                float UpgradeTextHeightSecondValue= 0;
                bool setUpgradeTextOutlineThicknessFirstValue = false;
                bool setUpgradeTextOutlineThicknessSecondValue = false;
                int UpgradeTextOutlineThicknessFirstValue= 0;
                int UpgradeTextOutlineThicknessSecondValue= 0;
                bool setUpgradeTextRedFirstValue = false;
                bool setUpgradeTextRedSecondValue = false;
                int UpgradeTextRedFirstValue= 0;
                int UpgradeTextRedSecondValue= 0;
                bool setUpgradeTextWidthFirstValue = false;
                bool setUpgradeTextWidthSecondValue = false;
                float UpgradeTextWidthFirstValue= 0;
                float UpgradeTextWidthSecondValue= 0;
                bool setWhiteFrameInstanceCurrentColorStateFirstValue = false;
                bool setWhiteFrameInstanceCurrentColorStateSecondValue = false;
                WhiteFrameRuntime.Color WhiteFrameInstanceCurrentColorStateFirstValue= WhiteFrameRuntime.Color.Red;
                WhiteFrameRuntime.Color WhiteFrameInstanceCurrentColorStateSecondValue= WhiteFrameRuntime.Color.Red;
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
                        if (interpolationValue < 1)
                        {
                            this.ChildrenLayout = Gum.Managers.ChildrenLayout.Regular;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ContainerInstance.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setContainerInstanceHeightFirstValue = true;
                        ContainerInstanceHeightFirstValue = -8f;
                        if (interpolationValue < 1)
                        {
                            this.ContainerInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
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
                        setCostTextBlueFirstValue = true;
                        CostTextBlueFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            SetProperty("CostText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        if (interpolationValue < 1)
                        {
                            this.CostText.Font = "Moire ExtraBold";
                        }
                        setCostTextFontScaleFirstValue = true;
                        CostTextFontScaleFirstValue = 0.7f;
                        setCostTextFontSizeFirstValue = true;
                        CostTextFontSizeFirstValue = 50;
                        setCostTextGreenFirstValue = true;
                        CostTextGreenFirstValue = 255;
                        setCostTextHeightFirstValue = true;
                        CostTextHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.CostText.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CostText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setCostTextOutlineThicknessFirstValue = true;
                        CostTextOutlineThicknessFirstValue = 2;
                        if (interpolationValue < 1)
                        {
                            this.CostText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "TitleContainer");
                        }
                        setCostTextRedFirstValue = true;
                        CostTextRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.CostText.Text = "5";
                        }
                        if (interpolationValue < 1)
                        {
                            this.CostText.UseCustomFont = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CostText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CostText.Visible = true;
                        }
                        setCostTextWidthFirstValue = true;
                        CostTextWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.CostText.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setCostTextXFirstValue = true;
                        CostTextXFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.CostText.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CostText.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setOrTextInstanceBlueFirstValue = true;
                        OrTextInstanceBlueFirstValue = 220;
                        if (interpolationValue < 1)
                        {
                            SetProperty("OrTextInstance.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setOrTextInstanceFontScaleFirstValue = true;
                        OrTextInstanceFontScaleFirstValue = 0.6f;
                        setOrTextInstanceGreenFirstValue = true;
                        OrTextInstanceGreenFirstValue = 220;
                        setOrTextInstanceHeightFirstValue = true;
                        OrTextInstanceHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.OrTextInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "UpgradeContainer");
                        }
                        setOrTextInstanceRedFirstValue = true;
                        OrTextInstanceRedFirstValue = 220;
                        if (interpolationValue < 1)
                        {
                            this.OrTextInstance.Text = "Or";
                        }
                        if (interpolationValue < 1)
                        {
                            this.OrTextInstance.UseCustomFont = true;
                        }
                        setOrTextInstanceWidthFirstValue = true;
                        OrTextInstanceWidthFirstValue = 0f;
                        setOrTextInstanceXFirstValue = true;
                        OrTextInstanceXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.OrTextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.OrTextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setOrTextInstanceYFirstValue = true;
                        OrTextInstanceYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.OrTextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.OrTextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setPointsSpriteHeightFirstValue = true;
                        PointsSpriteHeightFirstValue = 95f;
                        if (interpolationValue < 1)
                        {
                            this.PointsSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.PointsSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "TitleContainer");
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("PointsSprite.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.PointsSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setPointsSpriteTextureHeightFirstValue = true;
                        PointsSpriteTextureHeightFirstValue = 122;
                        setPointsSpriteTextureLeftFirstValue = true;
                        PointsSpriteTextureLeftFirstValue = 2435;
                        setPointsSpriteTextureTopFirstValue = true;
                        PointsSpriteTextureTopFirstValue = 910;
                        setPointsSpriteTextureWidthFirstValue = true;
                        PointsSpriteTextureWidthFirstValue = 128;
                        if (interpolationValue < 1)
                        {
                            this.PointsSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        setPointsSpriteXFirstValue = true;
                        PointsSpriteXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.PointsSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.PointsSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        if (interpolationValue < 1)
                        {
                            this.PointsSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.PointsSprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TitleContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setTitleContainerHeightFirstValue = true;
                        TitleContainerHeightFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.TitleContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TitleContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ContainerInstance");
                        }
                        setTitleContainerWidthFirstValue = true;
                        TitleContainerWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.TitleContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TitleContainer.WrapsChildren = false;
                        }
                        setUpgrade1TextBlueFirstValue = true;
                        Upgrade1TextBlueFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            SetProperty("Upgrade1Text.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setUpgrade1TextFontScaleFirstValue = true;
                        Upgrade1TextFontScaleFirstValue = 0.4f;
                        setUpgrade1TextGreenFirstValue = true;
                        Upgrade1TextGreenFirstValue = 255;
                        setUpgrade1TextHeightFirstValue = true;
                        Upgrade1TextHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Upgrade1Text.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Upgrade1Text.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "UpgradeContainer");
                        }
                        setUpgrade1TextRedFirstValue = true;
                        Upgrade1TextRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.Upgrade1Text.Text = "Type1";
                        }
                        if (interpolationValue < 1)
                        {
                            this.Upgrade1Text.UseCustomFont = true;
                        }
                        setUpgrade1TextWidthFirstValue = true;
                        Upgrade1TextWidthFirstValue = 0f;
                        setUpgrade1TextXFirstValue = true;
                        Upgrade1TextXFirstValue = 21.5f;
                        if (interpolationValue < 1)
                        {
                            this.Upgrade1Text.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Upgrade1Text.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setUpgrade1TextYFirstValue = true;
                        Upgrade1TextYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Upgrade1Text.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Upgrade1Text.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setUpgrade1TypeHeightFirstValue = true;
                        Upgrade1TypeHeightFirstValue = 75f;
                        if (interpolationValue < 1)
                        {
                            this.Upgrade1Type.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Upgrade1Type.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "UpgradeContainer");
                        }
                        setUpgrade1TypeWidthFirstValue = true;
                        Upgrade1TypeWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.Upgrade1Type.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        setUpgrade1TypeXFirstValue = true;
                        Upgrade1TypeXFirstValue = 21.5f;
                        if (interpolationValue < 1)
                        {
                            this.Upgrade1Type.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Upgrade1Type.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setUpgrade1TypeYFirstValue = true;
                        Upgrade1TypeYFirstValue = 25f;
                        if (interpolationValue < 1)
                        {
                            this.Upgrade1Type.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Upgrade1Type.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setUpgrade2TextBlueFirstValue = true;
                        Upgrade2TextBlueFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            SetProperty("Upgrade2Text.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setUpgrade2TextFontScaleFirstValue = true;
                        Upgrade2TextFontScaleFirstValue = 0.4f;
                        setUpgrade2TextGreenFirstValue = true;
                        Upgrade2TextGreenFirstValue = 255;
                        setUpgrade2TextHeightFirstValue = true;
                        Upgrade2TextHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Upgrade2Text.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Upgrade2Text.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "UpgradeContainer");
                        }
                        setUpgrade2TextRedFirstValue = true;
                        Upgrade2TextRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.Upgrade2Text.Text = "Type1";
                        }
                        if (interpolationValue < 1)
                        {
                            this.Upgrade2Text.UseCustomFont = true;
                        }
                        setUpgrade2TextWidthFirstValue = true;
                        Upgrade2TextWidthFirstValue = 0f;
                        setUpgrade2TextXFirstValue = true;
                        Upgrade2TextXFirstValue = 78.5f;
                        if (interpolationValue < 1)
                        {
                            this.Upgrade2Text.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Upgrade2Text.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setUpgrade2TextYFirstValue = true;
                        Upgrade2TextYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Upgrade2Text.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Upgrade2Text.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setUpgrade2TypeHeightFirstValue = true;
                        Upgrade2TypeHeightFirstValue = 75f;
                        if (interpolationValue < 1)
                        {
                            this.Upgrade2Type.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Upgrade2Type.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "UpgradeContainer");
                        }
                        setUpgrade2TypeWidthFirstValue = true;
                        Upgrade2TypeWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.Upgrade2Type.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        setUpgrade2TypeXFirstValue = true;
                        Upgrade2TypeXFirstValue = 78.5f;
                        if (interpolationValue < 1)
                        {
                            this.Upgrade2Type.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Upgrade2Type.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setUpgrade2TypeYFirstValue = true;
                        Upgrade2TypeYFirstValue = 25f;
                        if (interpolationValue < 1)
                        {
                            this.Upgrade2Type.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Upgrade2Type.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setUpgradeContainerHeightFirstValue = true;
                        UpgradeContainerHeightFirstValue = -40f;
                        if (interpolationValue < 1)
                        {
                            this.UpgradeContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.UpgradeContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ContainerInstance");
                        }
                        if (interpolationValue < 1)
                        {
                            this.UpgradeContainer.Visible = true;
                        }
                        setUpgradeContainerWidthFirstValue = true;
                        UpgradeContainerWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.UpgradeContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setUpgradeContainerXFirstValue = true;
                        UpgradeContainerXFirstValue = 0f;
                        setUpgradeContainerYFirstValue = true;
                        UpgradeContainerYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.UpgradeContainer.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue < 1)
                        {
                            this.UpgradeContainer.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setUpgradeTextBlueFirstValue = true;
                        UpgradeTextBlueFirstValue = 140;
                        if (interpolationValue < 1)
                        {
                            SetProperty("UpgradeText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        if (interpolationValue < 1)
                        {
                            this.UpgradeText.Font = "Moire ExtraBold";
                        }
                        setUpgradeTextFontScaleFirstValue = true;
                        UpgradeTextFontScaleFirstValue = 0.7f;
                        setUpgradeTextFontSizeFirstValue = true;
                        UpgradeTextFontSizeFirstValue = 50;
                        setUpgradeTextGreenFirstValue = true;
                        UpgradeTextGreenFirstValue = 230;
                        setUpgradeTextHeightFirstValue = true;
                        UpgradeTextHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.UpgradeText.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            this.UpgradeText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setUpgradeTextOutlineThicknessFirstValue = true;
                        UpgradeTextOutlineThicknessFirstValue = 2;
                        if (interpolationValue < 1)
                        {
                            this.UpgradeText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "TitleContainer");
                        }
                        setUpgradeTextRedFirstValue = true;
                        UpgradeTextRedFirstValue = 240;
                        if (interpolationValue < 1)
                        {
                            this.UpgradeText.Text = "Upgrade:";
                        }
                        if (interpolationValue < 1)
                        {
                            this.UpgradeText.UseCustomFont = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.UpgradeText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue < 1)
                        {
                            this.UpgradeText.Visible = true;
                        }
                        setUpgradeTextWidthFirstValue = true;
                        UpgradeTextWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.UpgradeText.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setWhiteFrameInstanceCurrentColorStateFirstValue = true;
                        WhiteFrameInstanceCurrentColorStateFirstValue = AbbatoirIntergrade.GumRuntimes.WhiteFrameRuntime.Color.Green;
                        setWhiteFrameInstanceHeightFirstValue = true;
                        WhiteFrameInstanceHeightFirstValue = 100f;
                        setWhiteFrameInstanceWidthFirstValue = true;
                        WhiteFrameInstanceWidthFirstValue = 100f;
                        setWidthFirstValue = true;
                        WidthFirstValue = 300f;
                        if (interpolationValue < 1)
                        {
                            this.WrapsChildren = false;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        if (interpolationValue >= 1)
                        {
                            this.ChildrenLayout = Gum.Managers.ChildrenLayout.Regular;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ContainerInstance.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setContainerInstanceHeightSecondValue = true;
                        ContainerInstanceHeightSecondValue = -8f;
                        if (interpolationValue >= 1)
                        {
                            this.ContainerInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
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
                        setCostTextBlueSecondValue = true;
                        CostTextBlueSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("CostText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CostText.Font = "Moire ExtraBold";
                        }
                        setCostTextFontScaleSecondValue = true;
                        CostTextFontScaleSecondValue = 0.7f;
                        setCostTextFontSizeSecondValue = true;
                        CostTextFontSizeSecondValue = 50;
                        setCostTextGreenSecondValue = true;
                        CostTextGreenSecondValue = 255;
                        setCostTextHeightSecondValue = true;
                        CostTextHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.CostText.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CostText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setCostTextOutlineThicknessSecondValue = true;
                        CostTextOutlineThicknessSecondValue = 2;
                        if (interpolationValue >= 1)
                        {
                            this.CostText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "TitleContainer");
                        }
                        setCostTextRedSecondValue = true;
                        CostTextRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.CostText.Text = "5";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CostText.UseCustomFont = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CostText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CostText.Visible = true;
                        }
                        setCostTextWidthSecondValue = true;
                        CostTextWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.CostText.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setCostTextXSecondValue = true;
                        CostTextXSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.CostText.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CostText.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setOrTextInstanceBlueSecondValue = true;
                        OrTextInstanceBlueSecondValue = 220;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("OrTextInstance.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setOrTextInstanceFontScaleSecondValue = true;
                        OrTextInstanceFontScaleSecondValue = 0.6f;
                        setOrTextInstanceGreenSecondValue = true;
                        OrTextInstanceGreenSecondValue = 220;
                        setOrTextInstanceHeightSecondValue = true;
                        OrTextInstanceHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.OrTextInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "UpgradeContainer");
                        }
                        setOrTextInstanceRedSecondValue = true;
                        OrTextInstanceRedSecondValue = 220;
                        if (interpolationValue >= 1)
                        {
                            this.OrTextInstance.Text = "Or";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.OrTextInstance.UseCustomFont = true;
                        }
                        setOrTextInstanceWidthSecondValue = true;
                        OrTextInstanceWidthSecondValue = 0f;
                        setOrTextInstanceXSecondValue = true;
                        OrTextInstanceXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.OrTextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.OrTextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setOrTextInstanceYSecondValue = true;
                        OrTextInstanceYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.OrTextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.OrTextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setPointsSpriteHeightSecondValue = true;
                        PointsSpriteHeightSecondValue = 95f;
                        if (interpolationValue >= 1)
                        {
                            this.PointsSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PointsSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "TitleContainer");
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("PointsSprite.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PointsSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setPointsSpriteTextureHeightSecondValue = true;
                        PointsSpriteTextureHeightSecondValue = 122;
                        setPointsSpriteTextureLeftSecondValue = true;
                        PointsSpriteTextureLeftSecondValue = 2435;
                        setPointsSpriteTextureTopSecondValue = true;
                        PointsSpriteTextureTopSecondValue = 910;
                        setPointsSpriteTextureWidthSecondValue = true;
                        PointsSpriteTextureWidthSecondValue = 128;
                        if (interpolationValue >= 1)
                        {
                            this.PointsSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        setPointsSpriteXSecondValue = true;
                        PointsSpriteXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.PointsSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PointsSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PointsSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PointsSprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TitleContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setTitleContainerHeightSecondValue = true;
                        TitleContainerHeightSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.TitleContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TitleContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ContainerInstance");
                        }
                        setTitleContainerWidthSecondValue = true;
                        TitleContainerWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.TitleContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TitleContainer.WrapsChildren = false;
                        }
                        setUpgrade1TextBlueSecondValue = true;
                        Upgrade1TextBlueSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("Upgrade1Text.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setUpgrade1TextFontScaleSecondValue = true;
                        Upgrade1TextFontScaleSecondValue = 0.4f;
                        setUpgrade1TextGreenSecondValue = true;
                        Upgrade1TextGreenSecondValue = 255;
                        setUpgrade1TextHeightSecondValue = true;
                        Upgrade1TextHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Upgrade1Text.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Upgrade1Text.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "UpgradeContainer");
                        }
                        setUpgrade1TextRedSecondValue = true;
                        Upgrade1TextRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.Upgrade1Text.Text = "Type1";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Upgrade1Text.UseCustomFont = true;
                        }
                        setUpgrade1TextWidthSecondValue = true;
                        Upgrade1TextWidthSecondValue = 0f;
                        setUpgrade1TextXSecondValue = true;
                        Upgrade1TextXSecondValue = 21.5f;
                        if (interpolationValue >= 1)
                        {
                            this.Upgrade1Text.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Upgrade1Text.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setUpgrade1TextYSecondValue = true;
                        Upgrade1TextYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Upgrade1Text.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Upgrade1Text.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setUpgrade1TypeHeightSecondValue = true;
                        Upgrade1TypeHeightSecondValue = 75f;
                        if (interpolationValue >= 1)
                        {
                            this.Upgrade1Type.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Upgrade1Type.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "UpgradeContainer");
                        }
                        setUpgrade1TypeWidthSecondValue = true;
                        Upgrade1TypeWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.Upgrade1Type.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        setUpgrade1TypeXSecondValue = true;
                        Upgrade1TypeXSecondValue = 21.5f;
                        if (interpolationValue >= 1)
                        {
                            this.Upgrade1Type.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Upgrade1Type.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setUpgrade1TypeYSecondValue = true;
                        Upgrade1TypeYSecondValue = 25f;
                        if (interpolationValue >= 1)
                        {
                            this.Upgrade1Type.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Upgrade1Type.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setUpgrade2TextBlueSecondValue = true;
                        Upgrade2TextBlueSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("Upgrade2Text.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setUpgrade2TextFontScaleSecondValue = true;
                        Upgrade2TextFontScaleSecondValue = 0.4f;
                        setUpgrade2TextGreenSecondValue = true;
                        Upgrade2TextGreenSecondValue = 255;
                        setUpgrade2TextHeightSecondValue = true;
                        Upgrade2TextHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Upgrade2Text.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Upgrade2Text.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "UpgradeContainer");
                        }
                        setUpgrade2TextRedSecondValue = true;
                        Upgrade2TextRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.Upgrade2Text.Text = "Type1";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Upgrade2Text.UseCustomFont = true;
                        }
                        setUpgrade2TextWidthSecondValue = true;
                        Upgrade2TextWidthSecondValue = 0f;
                        setUpgrade2TextXSecondValue = true;
                        Upgrade2TextXSecondValue = 78.5f;
                        if (interpolationValue >= 1)
                        {
                            this.Upgrade2Text.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Upgrade2Text.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setUpgrade2TextYSecondValue = true;
                        Upgrade2TextYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Upgrade2Text.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Upgrade2Text.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setUpgrade2TypeHeightSecondValue = true;
                        Upgrade2TypeHeightSecondValue = 75f;
                        if (interpolationValue >= 1)
                        {
                            this.Upgrade2Type.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Upgrade2Type.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "UpgradeContainer");
                        }
                        setUpgrade2TypeWidthSecondValue = true;
                        Upgrade2TypeWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.Upgrade2Type.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        setUpgrade2TypeXSecondValue = true;
                        Upgrade2TypeXSecondValue = 78.5f;
                        if (interpolationValue >= 1)
                        {
                            this.Upgrade2Type.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Upgrade2Type.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setUpgrade2TypeYSecondValue = true;
                        Upgrade2TypeYSecondValue = 25f;
                        if (interpolationValue >= 1)
                        {
                            this.Upgrade2Type.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Upgrade2Type.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setUpgradeContainerHeightSecondValue = true;
                        UpgradeContainerHeightSecondValue = -40f;
                        if (interpolationValue >= 1)
                        {
                            this.UpgradeContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.UpgradeContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ContainerInstance");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.UpgradeContainer.Visible = true;
                        }
                        setUpgradeContainerWidthSecondValue = true;
                        UpgradeContainerWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.UpgradeContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setUpgradeContainerXSecondValue = true;
                        UpgradeContainerXSecondValue = 0f;
                        setUpgradeContainerYSecondValue = true;
                        UpgradeContainerYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.UpgradeContainer.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.UpgradeContainer.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setUpgradeTextBlueSecondValue = true;
                        UpgradeTextBlueSecondValue = 140;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("UpgradeText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.UpgradeText.Font = "Moire ExtraBold";
                        }
                        setUpgradeTextFontScaleSecondValue = true;
                        UpgradeTextFontScaleSecondValue = 0.7f;
                        setUpgradeTextFontSizeSecondValue = true;
                        UpgradeTextFontSizeSecondValue = 50;
                        setUpgradeTextGreenSecondValue = true;
                        UpgradeTextGreenSecondValue = 230;
                        setUpgradeTextHeightSecondValue = true;
                        UpgradeTextHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.UpgradeText.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.UpgradeText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setUpgradeTextOutlineThicknessSecondValue = true;
                        UpgradeTextOutlineThicknessSecondValue = 2;
                        if (interpolationValue >= 1)
                        {
                            this.UpgradeText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "TitleContainer");
                        }
                        setUpgradeTextRedSecondValue = true;
                        UpgradeTextRedSecondValue = 240;
                        if (interpolationValue >= 1)
                        {
                            this.UpgradeText.Text = "Upgrade:";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.UpgradeText.UseCustomFont = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.UpgradeText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.UpgradeText.Visible = true;
                        }
                        setUpgradeTextWidthSecondValue = true;
                        UpgradeTextWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.UpgradeText.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setWhiteFrameInstanceCurrentColorStateSecondValue = true;
                        WhiteFrameInstanceCurrentColorStateSecondValue = AbbatoirIntergrade.GumRuntimes.WhiteFrameRuntime.Color.Green;
                        setWhiteFrameInstanceHeightSecondValue = true;
                        WhiteFrameInstanceHeightSecondValue = 100f;
                        setWhiteFrameInstanceWidthSecondValue = true;
                        WhiteFrameInstanceWidthSecondValue = 100f;
                        setWidthSecondValue = true;
                        WidthSecondValue = 300f;
                        if (interpolationValue >= 1)
                        {
                            this.WrapsChildren = false;
                        }
                        break;
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
                if (setCostTextBlueFirstValue && setCostTextBlueSecondValue)
                {
                    CostText.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(CostTextBlueFirstValue* (1 - interpolationValue) + CostTextBlueSecondValue * interpolationValue);
                }
                if (setCostTextFontScaleFirstValue && setCostTextFontScaleSecondValue)
                {
                    CostText.FontScale = CostTextFontScaleFirstValue * (1 - interpolationValue) + CostTextFontScaleSecondValue * interpolationValue;
                }
                if (setCostTextFontSizeFirstValue && setCostTextFontSizeSecondValue)
                {
                    CostText.FontSize = FlatRedBall.Math.MathFunctions.RoundToInt(CostTextFontSizeFirstValue* (1 - interpolationValue) + CostTextFontSizeSecondValue * interpolationValue);
                }
                if (setCostTextGreenFirstValue && setCostTextGreenSecondValue)
                {
                    CostText.Green = FlatRedBall.Math.MathFunctions.RoundToInt(CostTextGreenFirstValue* (1 - interpolationValue) + CostTextGreenSecondValue * interpolationValue);
                }
                if (setCostTextHeightFirstValue && setCostTextHeightSecondValue)
                {
                    CostText.Height = CostTextHeightFirstValue * (1 - interpolationValue) + CostTextHeightSecondValue * interpolationValue;
                }
                if (setCostTextOutlineThicknessFirstValue && setCostTextOutlineThicknessSecondValue)
                {
                    CostText.OutlineThickness = FlatRedBall.Math.MathFunctions.RoundToInt(CostTextOutlineThicknessFirstValue* (1 - interpolationValue) + CostTextOutlineThicknessSecondValue * interpolationValue);
                }
                if (setCostTextRedFirstValue && setCostTextRedSecondValue)
                {
                    CostText.Red = FlatRedBall.Math.MathFunctions.RoundToInt(CostTextRedFirstValue* (1 - interpolationValue) + CostTextRedSecondValue * interpolationValue);
                }
                if (setCostTextWidthFirstValue && setCostTextWidthSecondValue)
                {
                    CostText.Width = CostTextWidthFirstValue * (1 - interpolationValue) + CostTextWidthSecondValue * interpolationValue;
                }
                if (setCostTextXFirstValue && setCostTextXSecondValue)
                {
                    CostText.X = CostTextXFirstValue * (1 - interpolationValue) + CostTextXSecondValue * interpolationValue;
                }
                if (setOrTextInstanceBlueFirstValue && setOrTextInstanceBlueSecondValue)
                {
                    OrTextInstance.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(OrTextInstanceBlueFirstValue* (1 - interpolationValue) + OrTextInstanceBlueSecondValue * interpolationValue);
                }
                if (setOrTextInstanceFontScaleFirstValue && setOrTextInstanceFontScaleSecondValue)
                {
                    OrTextInstance.FontScale = OrTextInstanceFontScaleFirstValue * (1 - interpolationValue) + OrTextInstanceFontScaleSecondValue * interpolationValue;
                }
                if (setOrTextInstanceGreenFirstValue && setOrTextInstanceGreenSecondValue)
                {
                    OrTextInstance.Green = FlatRedBall.Math.MathFunctions.RoundToInt(OrTextInstanceGreenFirstValue* (1 - interpolationValue) + OrTextInstanceGreenSecondValue * interpolationValue);
                }
                if (setOrTextInstanceHeightFirstValue && setOrTextInstanceHeightSecondValue)
                {
                    OrTextInstance.Height = OrTextInstanceHeightFirstValue * (1 - interpolationValue) + OrTextInstanceHeightSecondValue * interpolationValue;
                }
                if (setOrTextInstanceRedFirstValue && setOrTextInstanceRedSecondValue)
                {
                    OrTextInstance.Red = FlatRedBall.Math.MathFunctions.RoundToInt(OrTextInstanceRedFirstValue* (1 - interpolationValue) + OrTextInstanceRedSecondValue * interpolationValue);
                }
                if (setOrTextInstanceWidthFirstValue && setOrTextInstanceWidthSecondValue)
                {
                    OrTextInstance.Width = OrTextInstanceWidthFirstValue * (1 - interpolationValue) + OrTextInstanceWidthSecondValue * interpolationValue;
                }
                if (setOrTextInstanceXFirstValue && setOrTextInstanceXSecondValue)
                {
                    OrTextInstance.X = OrTextInstanceXFirstValue * (1 - interpolationValue) + OrTextInstanceXSecondValue * interpolationValue;
                }
                if (setOrTextInstanceYFirstValue && setOrTextInstanceYSecondValue)
                {
                    OrTextInstance.Y = OrTextInstanceYFirstValue * (1 - interpolationValue) + OrTextInstanceYSecondValue * interpolationValue;
                }
                if (setPointsSpriteHeightFirstValue && setPointsSpriteHeightSecondValue)
                {
                    PointsSprite.Height = PointsSpriteHeightFirstValue * (1 - interpolationValue) + PointsSpriteHeightSecondValue * interpolationValue;
                }
                if (setPointsSpriteTextureHeightFirstValue && setPointsSpriteTextureHeightSecondValue)
                {
                    PointsSprite.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(PointsSpriteTextureHeightFirstValue* (1 - interpolationValue) + PointsSpriteTextureHeightSecondValue * interpolationValue);
                }
                if (setPointsSpriteTextureLeftFirstValue && setPointsSpriteTextureLeftSecondValue)
                {
                    PointsSprite.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(PointsSpriteTextureLeftFirstValue* (1 - interpolationValue) + PointsSpriteTextureLeftSecondValue * interpolationValue);
                }
                if (setPointsSpriteTextureTopFirstValue && setPointsSpriteTextureTopSecondValue)
                {
                    PointsSprite.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(PointsSpriteTextureTopFirstValue* (1 - interpolationValue) + PointsSpriteTextureTopSecondValue * interpolationValue);
                }
                if (setPointsSpriteTextureWidthFirstValue && setPointsSpriteTextureWidthSecondValue)
                {
                    PointsSprite.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(PointsSpriteTextureWidthFirstValue* (1 - interpolationValue) + PointsSpriteTextureWidthSecondValue * interpolationValue);
                }
                if (setPointsSpriteXFirstValue && setPointsSpriteXSecondValue)
                {
                    PointsSprite.X = PointsSpriteXFirstValue * (1 - interpolationValue) + PointsSpriteXSecondValue * interpolationValue;
                }
                if (setTitleContainerHeightFirstValue && setTitleContainerHeightSecondValue)
                {
                    TitleContainer.Height = TitleContainerHeightFirstValue * (1 - interpolationValue) + TitleContainerHeightSecondValue * interpolationValue;
                }
                if (setTitleContainerWidthFirstValue && setTitleContainerWidthSecondValue)
                {
                    TitleContainer.Width = TitleContainerWidthFirstValue * (1 - interpolationValue) + TitleContainerWidthSecondValue * interpolationValue;
                }
                if (setUpgrade1TextBlueFirstValue && setUpgrade1TextBlueSecondValue)
                {
                    Upgrade1Text.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(Upgrade1TextBlueFirstValue* (1 - interpolationValue) + Upgrade1TextBlueSecondValue * interpolationValue);
                }
                if (setUpgrade1TextFontScaleFirstValue && setUpgrade1TextFontScaleSecondValue)
                {
                    Upgrade1Text.FontScale = Upgrade1TextFontScaleFirstValue * (1 - interpolationValue) + Upgrade1TextFontScaleSecondValue * interpolationValue;
                }
                if (setUpgrade1TextGreenFirstValue && setUpgrade1TextGreenSecondValue)
                {
                    Upgrade1Text.Green = FlatRedBall.Math.MathFunctions.RoundToInt(Upgrade1TextGreenFirstValue* (1 - interpolationValue) + Upgrade1TextGreenSecondValue * interpolationValue);
                }
                if (setUpgrade1TextHeightFirstValue && setUpgrade1TextHeightSecondValue)
                {
                    Upgrade1Text.Height = Upgrade1TextHeightFirstValue * (1 - interpolationValue) + Upgrade1TextHeightSecondValue * interpolationValue;
                }
                if (setUpgrade1TextRedFirstValue && setUpgrade1TextRedSecondValue)
                {
                    Upgrade1Text.Red = FlatRedBall.Math.MathFunctions.RoundToInt(Upgrade1TextRedFirstValue* (1 - interpolationValue) + Upgrade1TextRedSecondValue * interpolationValue);
                }
                if (setUpgrade1TextWidthFirstValue && setUpgrade1TextWidthSecondValue)
                {
                    Upgrade1Text.Width = Upgrade1TextWidthFirstValue * (1 - interpolationValue) + Upgrade1TextWidthSecondValue * interpolationValue;
                }
                if (setUpgrade1TextXFirstValue && setUpgrade1TextXSecondValue)
                {
                    Upgrade1Text.X = Upgrade1TextXFirstValue * (1 - interpolationValue) + Upgrade1TextXSecondValue * interpolationValue;
                }
                if (setUpgrade1TextYFirstValue && setUpgrade1TextYSecondValue)
                {
                    Upgrade1Text.Y = Upgrade1TextYFirstValue * (1 - interpolationValue) + Upgrade1TextYSecondValue * interpolationValue;
                }
                if (setUpgrade1TypeHeightFirstValue && setUpgrade1TypeHeightSecondValue)
                {
                    Upgrade1Type.Height = Upgrade1TypeHeightFirstValue * (1 - interpolationValue) + Upgrade1TypeHeightSecondValue * interpolationValue;
                }
                if (setUpgrade1TypeWidthFirstValue && setUpgrade1TypeWidthSecondValue)
                {
                    Upgrade1Type.Width = Upgrade1TypeWidthFirstValue * (1 - interpolationValue) + Upgrade1TypeWidthSecondValue * interpolationValue;
                }
                if (setUpgrade1TypeXFirstValue && setUpgrade1TypeXSecondValue)
                {
                    Upgrade1Type.X = Upgrade1TypeXFirstValue * (1 - interpolationValue) + Upgrade1TypeXSecondValue * interpolationValue;
                }
                if (setUpgrade1TypeYFirstValue && setUpgrade1TypeYSecondValue)
                {
                    Upgrade1Type.Y = Upgrade1TypeYFirstValue * (1 - interpolationValue) + Upgrade1TypeYSecondValue * interpolationValue;
                }
                if (setUpgrade2TextBlueFirstValue && setUpgrade2TextBlueSecondValue)
                {
                    Upgrade2Text.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(Upgrade2TextBlueFirstValue* (1 - interpolationValue) + Upgrade2TextBlueSecondValue * interpolationValue);
                }
                if (setUpgrade2TextFontScaleFirstValue && setUpgrade2TextFontScaleSecondValue)
                {
                    Upgrade2Text.FontScale = Upgrade2TextFontScaleFirstValue * (1 - interpolationValue) + Upgrade2TextFontScaleSecondValue * interpolationValue;
                }
                if (setUpgrade2TextGreenFirstValue && setUpgrade2TextGreenSecondValue)
                {
                    Upgrade2Text.Green = FlatRedBall.Math.MathFunctions.RoundToInt(Upgrade2TextGreenFirstValue* (1 - interpolationValue) + Upgrade2TextGreenSecondValue * interpolationValue);
                }
                if (setUpgrade2TextHeightFirstValue && setUpgrade2TextHeightSecondValue)
                {
                    Upgrade2Text.Height = Upgrade2TextHeightFirstValue * (1 - interpolationValue) + Upgrade2TextHeightSecondValue * interpolationValue;
                }
                if (setUpgrade2TextRedFirstValue && setUpgrade2TextRedSecondValue)
                {
                    Upgrade2Text.Red = FlatRedBall.Math.MathFunctions.RoundToInt(Upgrade2TextRedFirstValue* (1 - interpolationValue) + Upgrade2TextRedSecondValue * interpolationValue);
                }
                if (setUpgrade2TextWidthFirstValue && setUpgrade2TextWidthSecondValue)
                {
                    Upgrade2Text.Width = Upgrade2TextWidthFirstValue * (1 - interpolationValue) + Upgrade2TextWidthSecondValue * interpolationValue;
                }
                if (setUpgrade2TextXFirstValue && setUpgrade2TextXSecondValue)
                {
                    Upgrade2Text.X = Upgrade2TextXFirstValue * (1 - interpolationValue) + Upgrade2TextXSecondValue * interpolationValue;
                }
                if (setUpgrade2TextYFirstValue && setUpgrade2TextYSecondValue)
                {
                    Upgrade2Text.Y = Upgrade2TextYFirstValue * (1 - interpolationValue) + Upgrade2TextYSecondValue * interpolationValue;
                }
                if (setUpgrade2TypeHeightFirstValue && setUpgrade2TypeHeightSecondValue)
                {
                    Upgrade2Type.Height = Upgrade2TypeHeightFirstValue * (1 - interpolationValue) + Upgrade2TypeHeightSecondValue * interpolationValue;
                }
                if (setUpgrade2TypeWidthFirstValue && setUpgrade2TypeWidthSecondValue)
                {
                    Upgrade2Type.Width = Upgrade2TypeWidthFirstValue * (1 - interpolationValue) + Upgrade2TypeWidthSecondValue * interpolationValue;
                }
                if (setUpgrade2TypeXFirstValue && setUpgrade2TypeXSecondValue)
                {
                    Upgrade2Type.X = Upgrade2TypeXFirstValue * (1 - interpolationValue) + Upgrade2TypeXSecondValue * interpolationValue;
                }
                if (setUpgrade2TypeYFirstValue && setUpgrade2TypeYSecondValue)
                {
                    Upgrade2Type.Y = Upgrade2TypeYFirstValue * (1 - interpolationValue) + Upgrade2TypeYSecondValue * interpolationValue;
                }
                if (setUpgradeContainerHeightFirstValue && setUpgradeContainerHeightSecondValue)
                {
                    UpgradeContainer.Height = UpgradeContainerHeightFirstValue * (1 - interpolationValue) + UpgradeContainerHeightSecondValue * interpolationValue;
                }
                if (setUpgradeContainerWidthFirstValue && setUpgradeContainerWidthSecondValue)
                {
                    UpgradeContainer.Width = UpgradeContainerWidthFirstValue * (1 - interpolationValue) + UpgradeContainerWidthSecondValue * interpolationValue;
                }
                if (setUpgradeContainerXFirstValue && setUpgradeContainerXSecondValue)
                {
                    UpgradeContainer.X = UpgradeContainerXFirstValue * (1 - interpolationValue) + UpgradeContainerXSecondValue * interpolationValue;
                }
                if (setUpgradeContainerYFirstValue && setUpgradeContainerYSecondValue)
                {
                    UpgradeContainer.Y = UpgradeContainerYFirstValue * (1 - interpolationValue) + UpgradeContainerYSecondValue * interpolationValue;
                }
                if (setUpgradeTextBlueFirstValue && setUpgradeTextBlueSecondValue)
                {
                    UpgradeText.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(UpgradeTextBlueFirstValue* (1 - interpolationValue) + UpgradeTextBlueSecondValue * interpolationValue);
                }
                if (setUpgradeTextFontScaleFirstValue && setUpgradeTextFontScaleSecondValue)
                {
                    UpgradeText.FontScale = UpgradeTextFontScaleFirstValue * (1 - interpolationValue) + UpgradeTextFontScaleSecondValue * interpolationValue;
                }
                if (setUpgradeTextFontSizeFirstValue && setUpgradeTextFontSizeSecondValue)
                {
                    UpgradeText.FontSize = FlatRedBall.Math.MathFunctions.RoundToInt(UpgradeTextFontSizeFirstValue* (1 - interpolationValue) + UpgradeTextFontSizeSecondValue * interpolationValue);
                }
                if (setUpgradeTextGreenFirstValue && setUpgradeTextGreenSecondValue)
                {
                    UpgradeText.Green = FlatRedBall.Math.MathFunctions.RoundToInt(UpgradeTextGreenFirstValue* (1 - interpolationValue) + UpgradeTextGreenSecondValue * interpolationValue);
                }
                if (setUpgradeTextHeightFirstValue && setUpgradeTextHeightSecondValue)
                {
                    UpgradeText.Height = UpgradeTextHeightFirstValue * (1 - interpolationValue) + UpgradeTextHeightSecondValue * interpolationValue;
                }
                if (setUpgradeTextOutlineThicknessFirstValue && setUpgradeTextOutlineThicknessSecondValue)
                {
                    UpgradeText.OutlineThickness = FlatRedBall.Math.MathFunctions.RoundToInt(UpgradeTextOutlineThicknessFirstValue* (1 - interpolationValue) + UpgradeTextOutlineThicknessSecondValue * interpolationValue);
                }
                if (setUpgradeTextRedFirstValue && setUpgradeTextRedSecondValue)
                {
                    UpgradeText.Red = FlatRedBall.Math.MathFunctions.RoundToInt(UpgradeTextRedFirstValue* (1 - interpolationValue) + UpgradeTextRedSecondValue * interpolationValue);
                }
                if (setUpgradeTextWidthFirstValue && setUpgradeTextWidthSecondValue)
                {
                    UpgradeText.Width = UpgradeTextWidthFirstValue * (1 - interpolationValue) + UpgradeTextWidthSecondValue * interpolationValue;
                }
                if (setWhiteFrameInstanceCurrentColorStateFirstValue && setWhiteFrameInstanceCurrentColorStateSecondValue)
                {
                    WhiteFrameInstance.InterpolateBetween(WhiteFrameInstanceCurrentColorStateFirstValue, WhiteFrameInstanceCurrentColorStateSecondValue, interpolationValue);
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
            public void InterpolateBetween (OptionsAvailability firstState, OptionsAvailability secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setUpgrade1TextXFirstValue = false;
                bool setUpgrade1TextXSecondValue = false;
                float Upgrade1TextXFirstValue= 0;
                float Upgrade1TextXSecondValue= 0;
                bool setUpgrade1TypeXFirstValue = false;
                bool setUpgrade1TypeXSecondValue = false;
                float Upgrade1TypeXFirstValue= 0;
                float Upgrade1TypeXSecondValue= 0;
                switch(firstState)
                {
                    case  OptionsAvailability.OneOption:
                        if (interpolationValue < 1)
                        {
                            this.OrTextInstance.Visible = false;
                        }
                        setUpgrade1TextXFirstValue = true;
                        Upgrade1TextXFirstValue = 50f;
                        setUpgrade1TypeXFirstValue = true;
                        Upgrade1TypeXFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.Upgrade2Text.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Upgrade2Type.Visible = false;
                        }
                        break;
                    case  OptionsAvailability.TwoOptions:
                        if (interpolationValue < 1)
                        {
                            this.OrTextInstance.Visible = true;
                        }
                        setUpgrade1TextXFirstValue = true;
                        Upgrade1TextXFirstValue = 21.5f;
                        setUpgrade1TypeXFirstValue = true;
                        Upgrade1TypeXFirstValue = 21.5f;
                        if (interpolationValue < 1)
                        {
                            this.Upgrade2Text.Visible = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Upgrade2Type.Visible = true;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  OptionsAvailability.OneOption:
                        if (interpolationValue >= 1)
                        {
                            this.OrTextInstance.Visible = false;
                        }
                        setUpgrade1TextXSecondValue = true;
                        Upgrade1TextXSecondValue = 50f;
                        setUpgrade1TypeXSecondValue = true;
                        Upgrade1TypeXSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.Upgrade2Text.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Upgrade2Type.Visible = false;
                        }
                        break;
                    case  OptionsAvailability.TwoOptions:
                        if (interpolationValue >= 1)
                        {
                            this.OrTextInstance.Visible = true;
                        }
                        setUpgrade1TextXSecondValue = true;
                        Upgrade1TextXSecondValue = 21.5f;
                        setUpgrade1TypeXSecondValue = true;
                        Upgrade1TypeXSecondValue = 21.5f;
                        if (interpolationValue >= 1)
                        {
                            this.Upgrade2Text.Visible = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Upgrade2Type.Visible = true;
                        }
                        break;
                }
                if (setUpgrade1TextXFirstValue && setUpgrade1TextXSecondValue)
                {
                    Upgrade1Text.X = Upgrade1TextXFirstValue * (1 - interpolationValue) + Upgrade1TextXSecondValue * interpolationValue;
                }
                if (setUpgrade1TypeXFirstValue && setUpgrade1TypeXSecondValue)
                {
                    Upgrade1Type.X = Upgrade1TypeXFirstValue * (1 - interpolationValue) + Upgrade1TypeXSecondValue * interpolationValue;
                }
                if (interpolationValue < 1)
                {
                    mCurrentOptionsAvailabilityState = firstState;
                }
                else
                {
                    mCurrentOptionsAvailabilityState = secondState;
                }
            }
            public void InterpolateBetween (OptionOneChoice firstState, OptionOneChoice secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setUpgrade1TypeCurrentAttributeTypeStateFirstValue = false;
                bool setUpgrade1TypeCurrentAttributeTypeStateSecondValue = false;
                AttributeIconRuntime.AttributeType Upgrade1TypeCurrentAttributeTypeStateFirstValue= AttributeIconRuntime.AttributeType.Health;
                AttributeIconRuntime.AttributeType Upgrade1TypeCurrentAttributeTypeStateSecondValue= AttributeIconRuntime.AttributeType.Health;
                switch(firstState)
                {
                    case  OptionOneChoice.UpgradeRange:
                        if (interpolationValue < 1)
                        {
                            this.Upgrade1Text.Text = "Range";
                        }
                        setUpgrade1TypeCurrentAttributeTypeStateFirstValue = true;
                        Upgrade1TypeCurrentAttributeTypeStateFirstValue = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.MaxRange;
                        break;
                    case  OptionOneChoice.UpgradeSpeed:
                        if (interpolationValue < 1)
                        {
                            this.Upgrade1Text.Text = "Speed";
                        }
                        setUpgrade1TypeCurrentAttributeTypeStateFirstValue = true;
                        Upgrade1TypeCurrentAttributeTypeStateFirstValue = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.AttackSpeed;
                        break;
                    case  OptionOneChoice.UpgradeDamage:
                        if (interpolationValue < 1)
                        {
                            this.Upgrade1Text.Text = "Damage";
                        }
                        setUpgrade1TypeCurrentAttributeTypeStateFirstValue = true;
                        Upgrade1TypeCurrentAttributeTypeStateFirstValue = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.Health;
                        break;
                }
                switch(secondState)
                {
                    case  OptionOneChoice.UpgradeRange:
                        if (interpolationValue >= 1)
                        {
                            this.Upgrade1Text.Text = "Range";
                        }
                        setUpgrade1TypeCurrentAttributeTypeStateSecondValue = true;
                        Upgrade1TypeCurrentAttributeTypeStateSecondValue = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.MaxRange;
                        break;
                    case  OptionOneChoice.UpgradeSpeed:
                        if (interpolationValue >= 1)
                        {
                            this.Upgrade1Text.Text = "Speed";
                        }
                        setUpgrade1TypeCurrentAttributeTypeStateSecondValue = true;
                        Upgrade1TypeCurrentAttributeTypeStateSecondValue = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.AttackSpeed;
                        break;
                    case  OptionOneChoice.UpgradeDamage:
                        if (interpolationValue >= 1)
                        {
                            this.Upgrade1Text.Text = "Damage";
                        }
                        setUpgrade1TypeCurrentAttributeTypeStateSecondValue = true;
                        Upgrade1TypeCurrentAttributeTypeStateSecondValue = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.Health;
                        break;
                }
                if (setUpgrade1TypeCurrentAttributeTypeStateFirstValue && setUpgrade1TypeCurrentAttributeTypeStateSecondValue)
                {
                    Upgrade1Type.InterpolateBetween(Upgrade1TypeCurrentAttributeTypeStateFirstValue, Upgrade1TypeCurrentAttributeTypeStateSecondValue, interpolationValue);
                }
                if (interpolationValue < 1)
                {
                    mCurrentOptionOneChoiceState = firstState;
                }
                else
                {
                    mCurrentOptionOneChoiceState = secondState;
                }
            }
            public void InterpolateBetween (OptionTwoChoice firstState, OptionTwoChoice secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setUpgrade2TypeCurrentAttributeTypeStateFirstValue = false;
                bool setUpgrade2TypeCurrentAttributeTypeStateSecondValue = false;
                AttributeIconRuntime.AttributeType Upgrade2TypeCurrentAttributeTypeStateFirstValue= AttributeIconRuntime.AttributeType.Health;
                AttributeIconRuntime.AttributeType Upgrade2TypeCurrentAttributeTypeStateSecondValue= AttributeIconRuntime.AttributeType.Health;
                switch(firstState)
                {
                    case  OptionTwoChoice.UpgradeRange:
                        if (interpolationValue < 1)
                        {
                            this.Upgrade2Text.Text = "Range";
                        }
                        setUpgrade2TypeCurrentAttributeTypeStateFirstValue = true;
                        Upgrade2TypeCurrentAttributeTypeStateFirstValue = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.MaxRange;
                        break;
                    case  OptionTwoChoice.UpgradeSpeed:
                        if (interpolationValue < 1)
                        {
                            this.Upgrade2Text.Text = "Speed";
                        }
                        setUpgrade2TypeCurrentAttributeTypeStateFirstValue = true;
                        Upgrade2TypeCurrentAttributeTypeStateFirstValue = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.AttackSpeed;
                        break;
                    case  OptionTwoChoice.UpgradeDamage:
                        if (interpolationValue < 1)
                        {
                            this.Upgrade2Text.Text = "Damage";
                        }
                        setUpgrade2TypeCurrentAttributeTypeStateFirstValue = true;
                        Upgrade2TypeCurrentAttributeTypeStateFirstValue = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.Health;
                        break;
                }
                switch(secondState)
                {
                    case  OptionTwoChoice.UpgradeRange:
                        if (interpolationValue >= 1)
                        {
                            this.Upgrade2Text.Text = "Range";
                        }
                        setUpgrade2TypeCurrentAttributeTypeStateSecondValue = true;
                        Upgrade2TypeCurrentAttributeTypeStateSecondValue = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.MaxRange;
                        break;
                    case  OptionTwoChoice.UpgradeSpeed:
                        if (interpolationValue >= 1)
                        {
                            this.Upgrade2Text.Text = "Speed";
                        }
                        setUpgrade2TypeCurrentAttributeTypeStateSecondValue = true;
                        Upgrade2TypeCurrentAttributeTypeStateSecondValue = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.AttackSpeed;
                        break;
                    case  OptionTwoChoice.UpgradeDamage:
                        if (interpolationValue >= 1)
                        {
                            this.Upgrade2Text.Text = "Damage";
                        }
                        setUpgrade2TypeCurrentAttributeTypeStateSecondValue = true;
                        Upgrade2TypeCurrentAttributeTypeStateSecondValue = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.Health;
                        break;
                }
                if (setUpgrade2TypeCurrentAttributeTypeStateFirstValue && setUpgrade2TypeCurrentAttributeTypeStateSecondValue)
                {
                    Upgrade2Type.InterpolateBetween(Upgrade2TypeCurrentAttributeTypeStateFirstValue, Upgrade2TypeCurrentAttributeTypeStateSecondValue, interpolationValue);
                }
                if (interpolationValue < 1)
                {
                    mCurrentOptionTwoChoiceState = firstState;
                }
                else
                {
                    mCurrentOptionTwoChoiceState = secondState;
                }
            }
            public void InterpolateBetween (Affordability firstState, Affordability secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setCostTextBlueFirstValue = false;
                bool setCostTextBlueSecondValue = false;
                int CostTextBlueFirstValue= 0;
                int CostTextBlueSecondValue= 0;
                bool setCostTextGreenFirstValue = false;
                bool setCostTextGreenSecondValue = false;
                int CostTextGreenFirstValue= 0;
                int CostTextGreenSecondValue= 0;
                bool setCostTextRedFirstValue = false;
                bool setCostTextRedSecondValue = false;
                int CostTextRedFirstValue= 0;
                int CostTextRedSecondValue= 0;
                bool setOrTextInstanceAlphaFirstValue = false;
                bool setOrTextInstanceAlphaSecondValue = false;
                int OrTextInstanceAlphaFirstValue= 0;
                int OrTextInstanceAlphaSecondValue= 0;
                bool setPointsSpriteAlphaFirstValue = false;
                bool setPointsSpriteAlphaSecondValue = false;
                int PointsSpriteAlphaFirstValue= 0;
                int PointsSpriteAlphaSecondValue= 0;
                bool setUpgrade1TextAlphaFirstValue = false;
                bool setUpgrade1TextAlphaSecondValue = false;
                int Upgrade1TextAlphaFirstValue= 0;
                int Upgrade1TextAlphaSecondValue= 0;
                bool setUpgrade2TextAlphaFirstValue = false;
                bool setUpgrade2TextAlphaSecondValue = false;
                int Upgrade2TextAlphaFirstValue= 0;
                int Upgrade2TextAlphaSecondValue= 0;
                bool setUpgradeTextAlphaFirstValue = false;
                bool setUpgradeTextAlphaSecondValue = false;
                int UpgradeTextAlphaFirstValue= 0;
                int UpgradeTextAlphaSecondValue= 0;
                bool setWhiteFrameInstanceCurrentColorStateFirstValue = false;
                bool setWhiteFrameInstanceCurrentColorStateSecondValue = false;
                WhiteFrameRuntime.Color WhiteFrameInstanceCurrentColorStateFirstValue= WhiteFrameRuntime.Color.Red;
                WhiteFrameRuntime.Color WhiteFrameInstanceCurrentColorStateSecondValue= WhiteFrameRuntime.Color.Red;
                bool setUpgrade1TypeIconAlphaFirstValue = false;
                bool setUpgrade1TypeIconAlphaSecondValue = false;
                int Upgrade1TypeIconAlphaFirstValue= 0;
                int Upgrade1TypeIconAlphaSecondValue= 0;
                bool setUpgrade2TypeIconAlphaFirstValue = false;
                bool setUpgrade2TypeIconAlphaSecondValue = false;
                int Upgrade2TypeIconAlphaFirstValue= 0;
                int Upgrade2TypeIconAlphaSecondValue= 0;
                switch(firstState)
                {
                    case  Affordability.CanAfford:
                        setCostTextBlueFirstValue = true;
                        CostTextBlueFirstValue = 255;
                        setCostTextGreenFirstValue = true;
                        CostTextGreenFirstValue = 255;
                        setCostTextRedFirstValue = true;
                        CostTextRedFirstValue = 0;
                        setOrTextInstanceAlphaFirstValue = true;
                        OrTextInstanceAlphaFirstValue = 255;
                        setPointsSpriteAlphaFirstValue = true;
                        PointsSpriteAlphaFirstValue = 255;
                        setUpgrade1TextAlphaFirstValue = true;
                        Upgrade1TextAlphaFirstValue = 255;
                        setUpgrade2TextAlphaFirstValue = true;
                        Upgrade2TextAlphaFirstValue = 255;
                        setUpgradeTextAlphaFirstValue = true;
                        UpgradeTextAlphaFirstValue = 255;
                        setWhiteFrameInstanceCurrentColorStateFirstValue = true;
                        WhiteFrameInstanceCurrentColorStateFirstValue = AbbatoirIntergrade.GumRuntimes.WhiteFrameRuntime.Color.Green;
                        break;
                    case  Affordability.CantAfford:
                        setCostTextBlueFirstValue = true;
                        CostTextBlueFirstValue = 0;
                        setCostTextGreenFirstValue = true;
                        CostTextGreenFirstValue = 0;
                        setCostTextRedFirstValue = true;
                        CostTextRedFirstValue = 255;
                        setOrTextInstanceAlphaFirstValue = true;
                        OrTextInstanceAlphaFirstValue = 50;
                        setPointsSpriteAlphaFirstValue = true;
                        PointsSpriteAlphaFirstValue = 150;
                        setUpgrade1TextAlphaFirstValue = true;
                        Upgrade1TextAlphaFirstValue = 100;
                        setUpgrade1TypeIconAlphaFirstValue = true;
                        Upgrade1TypeIconAlphaFirstValue = 100;
                        setUpgrade2TextAlphaFirstValue = true;
                        Upgrade2TextAlphaFirstValue = 100;
                        setUpgrade2TypeIconAlphaFirstValue = true;
                        Upgrade2TypeIconAlphaFirstValue = 100;
                        setUpgradeTextAlphaFirstValue = true;
                        UpgradeTextAlphaFirstValue = 100;
                        setWhiteFrameInstanceCurrentColorStateFirstValue = true;
                        WhiteFrameInstanceCurrentColorStateFirstValue = AbbatoirIntergrade.GumRuntimes.WhiteFrameRuntime.Color.Red;
                        break;
                }
                switch(secondState)
                {
                    case  Affordability.CanAfford:
                        setCostTextBlueSecondValue = true;
                        CostTextBlueSecondValue = 255;
                        setCostTextGreenSecondValue = true;
                        CostTextGreenSecondValue = 255;
                        setCostTextRedSecondValue = true;
                        CostTextRedSecondValue = 0;
                        setOrTextInstanceAlphaSecondValue = true;
                        OrTextInstanceAlphaSecondValue = 255;
                        setPointsSpriteAlphaSecondValue = true;
                        PointsSpriteAlphaSecondValue = 255;
                        setUpgrade1TextAlphaSecondValue = true;
                        Upgrade1TextAlphaSecondValue = 255;
                        setUpgrade2TextAlphaSecondValue = true;
                        Upgrade2TextAlphaSecondValue = 255;
                        setUpgradeTextAlphaSecondValue = true;
                        UpgradeTextAlphaSecondValue = 255;
                        setWhiteFrameInstanceCurrentColorStateSecondValue = true;
                        WhiteFrameInstanceCurrentColorStateSecondValue = AbbatoirIntergrade.GumRuntimes.WhiteFrameRuntime.Color.Green;
                        break;
                    case  Affordability.CantAfford:
                        setCostTextBlueSecondValue = true;
                        CostTextBlueSecondValue = 0;
                        setCostTextGreenSecondValue = true;
                        CostTextGreenSecondValue = 0;
                        setCostTextRedSecondValue = true;
                        CostTextRedSecondValue = 255;
                        setOrTextInstanceAlphaSecondValue = true;
                        OrTextInstanceAlphaSecondValue = 50;
                        setPointsSpriteAlphaSecondValue = true;
                        PointsSpriteAlphaSecondValue = 150;
                        setUpgrade1TextAlphaSecondValue = true;
                        Upgrade1TextAlphaSecondValue = 100;
                        setUpgrade1TypeIconAlphaSecondValue = true;
                        Upgrade1TypeIconAlphaSecondValue = 100;
                        setUpgrade2TextAlphaSecondValue = true;
                        Upgrade2TextAlphaSecondValue = 100;
                        setUpgrade2TypeIconAlphaSecondValue = true;
                        Upgrade2TypeIconAlphaSecondValue = 100;
                        setUpgradeTextAlphaSecondValue = true;
                        UpgradeTextAlphaSecondValue = 100;
                        setWhiteFrameInstanceCurrentColorStateSecondValue = true;
                        WhiteFrameInstanceCurrentColorStateSecondValue = AbbatoirIntergrade.GumRuntimes.WhiteFrameRuntime.Color.Red;
                        break;
                }
                if (setCostTextBlueFirstValue && setCostTextBlueSecondValue)
                {
                    CostText.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(CostTextBlueFirstValue* (1 - interpolationValue) + CostTextBlueSecondValue * interpolationValue);
                }
                if (setCostTextGreenFirstValue && setCostTextGreenSecondValue)
                {
                    CostText.Green = FlatRedBall.Math.MathFunctions.RoundToInt(CostTextGreenFirstValue* (1 - interpolationValue) + CostTextGreenSecondValue * interpolationValue);
                }
                if (setCostTextRedFirstValue && setCostTextRedSecondValue)
                {
                    CostText.Red = FlatRedBall.Math.MathFunctions.RoundToInt(CostTextRedFirstValue* (1 - interpolationValue) + CostTextRedSecondValue * interpolationValue);
                }
                if (setOrTextInstanceAlphaFirstValue && setOrTextInstanceAlphaSecondValue)
                {
                    OrTextInstance.Alpha = FlatRedBall.Math.MathFunctions.RoundToInt(OrTextInstanceAlphaFirstValue* (1 - interpolationValue) + OrTextInstanceAlphaSecondValue * interpolationValue);
                }
                if (setPointsSpriteAlphaFirstValue && setPointsSpriteAlphaSecondValue)
                {
                    PointsSprite.Alpha = FlatRedBall.Math.MathFunctions.RoundToInt(PointsSpriteAlphaFirstValue* (1 - interpolationValue) + PointsSpriteAlphaSecondValue * interpolationValue);
                }
                if (setUpgrade1TextAlphaFirstValue && setUpgrade1TextAlphaSecondValue)
                {
                    Upgrade1Text.Alpha = FlatRedBall.Math.MathFunctions.RoundToInt(Upgrade1TextAlphaFirstValue* (1 - interpolationValue) + Upgrade1TextAlphaSecondValue * interpolationValue);
                }
                if (setUpgrade2TextAlphaFirstValue && setUpgrade2TextAlphaSecondValue)
                {
                    Upgrade2Text.Alpha = FlatRedBall.Math.MathFunctions.RoundToInt(Upgrade2TextAlphaFirstValue* (1 - interpolationValue) + Upgrade2TextAlphaSecondValue * interpolationValue);
                }
                if (setUpgradeTextAlphaFirstValue && setUpgradeTextAlphaSecondValue)
                {
                    UpgradeText.Alpha = FlatRedBall.Math.MathFunctions.RoundToInt(UpgradeTextAlphaFirstValue* (1 - interpolationValue) + UpgradeTextAlphaSecondValue * interpolationValue);
                }
                if (setWhiteFrameInstanceCurrentColorStateFirstValue && setWhiteFrameInstanceCurrentColorStateSecondValue)
                {
                    WhiteFrameInstance.InterpolateBetween(WhiteFrameInstanceCurrentColorStateFirstValue, WhiteFrameInstanceCurrentColorStateSecondValue, interpolationValue);
                }
                if (setUpgrade1TypeIconAlphaFirstValue && setUpgrade1TypeIconAlphaSecondValue)
                {
                    Upgrade1Type.IconAlpha = FlatRedBall.Math.MathFunctions.RoundToInt(Upgrade1TypeIconAlphaFirstValue* (1 - interpolationValue) + Upgrade1TypeIconAlphaSecondValue * interpolationValue);
                }
                if (setUpgrade2TypeIconAlphaFirstValue && setUpgrade2TypeIconAlphaSecondValue)
                {
                    Upgrade2Type.IconAlpha = FlatRedBall.Math.MathFunctions.RoundToInt(Upgrade2TypeIconAlphaFirstValue* (1 - interpolationValue) + Upgrade2TypeIconAlphaSecondValue * interpolationValue);
                }
                if (interpolationValue < 1)
                {
                    mCurrentAffordabilityState = firstState;
                }
                else
                {
                    mCurrentAffordabilityState = secondState;
                }
            }
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.UpgradeInfoRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.UpgradeInfoRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.UpgradeInfoRuntime.OptionsAvailability fromState,AbbatoirIntergrade.GumRuntimes.UpgradeInfoRuntime.OptionsAvailability toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (OptionsAvailability toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "OptionsAvailability").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentOptionsAvailabilityState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (OptionsAvailability toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentOptionsAvailabilityState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.UpgradeInfoRuntime.OptionOneChoice fromState,AbbatoirIntergrade.GumRuntimes.UpgradeInfoRuntime.OptionOneChoice toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (OptionOneChoice toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "OptionOneChoice").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentOptionOneChoiceState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (OptionOneChoice toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentOptionOneChoiceState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.UpgradeInfoRuntime.OptionTwoChoice fromState,AbbatoirIntergrade.GumRuntimes.UpgradeInfoRuntime.OptionTwoChoice toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (OptionTwoChoice toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "OptionTwoChoice").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentOptionTwoChoiceState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (OptionTwoChoice toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentOptionTwoChoiceState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.UpgradeInfoRuntime.Affordability fromState,AbbatoirIntergrade.GumRuntimes.UpgradeInfoRuntime.Affordability toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Affordability toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "Affordability").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentAffordabilityState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (Affordability toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentAffordabilityState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            #endregion
            #region State Animations
            private System.Collections.Generic.IEnumerable<FlatRedBall.Instructions.Instruction> PulseAnimationInstructions (object target) 
            {
                {
                    var instruction = new FlatRedBall.Instructions.DelegateInstruction(()=>WhiteFrameInstance.PulseGreenLightBlueAnimation.Play(PulseAnimation));
                    instruction.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0;
                    yield return instruction;
                }
            }
            private System.Collections.Generic.IEnumerable<FlatRedBall.Instructions.Instruction> PulseAnimationRelativeInstructions (object target) 
            {
                {
                    var instruction = new FlatRedBall.Instructions.DelegateInstruction(()=>WhiteFrameInstance.PulseGreenLightBlueAnimationRelative.Play(PulseAnimation));
                    instruction.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0;
                    yield return instruction;
                }
            }
            private FlatRedBall.Gum.Animation.GumAnimation pulseAnimation;
            public FlatRedBall.Gum.Animation.GumAnimation PulseAnimation
            {
                get
                {
                    if (pulseAnimation == null)
                    {
                        pulseAnimation = new FlatRedBall.Gum.Animation.GumAnimation(2, PulseAnimationInstructions);
                        pulseAnimation.SubAnimations.Add(WhiteFrameInstance.PulseGreenLightBlueAnimation);
                    }
                    return pulseAnimation;
                }
            }
            private FlatRedBall.Gum.Animation.GumAnimation pulseAnimationRelative;
            public FlatRedBall.Gum.Animation.GumAnimation PulseAnimationRelative
            {
                get
                {
                    if (pulseAnimationRelative == null)
                    {
                        pulseAnimationRelative = new FlatRedBall.Gum.Animation.GumAnimation(2, PulseAnimationRelativeInstructions);
                        pulseAnimationRelative.SubAnimations.Add(WhiteFrameInstance.PulseGreenLightBlueAnimation);
                    }
                    return pulseAnimationRelative;
                }
            }
            #endregion
            public override void StopAnimations () 
            {
                base.StopAnimations();
                WhiteFrameInstance.StopAnimations();
                Upgrade1Type.StopAnimations();
                Upgrade2Type.StopAnimations();
                PulseAnimation.Stop();
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
                            Name = "Width",
                            Type = "float",
                            Value = Width
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
                            Name = "WhiteFrameInstance.ColorState",
                            Type = "ColorState",
                            Value = WhiteFrameInstance.CurrentColorState
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
                            Name = "UpgradeText.Blue",
                            Type = "int",
                            Value = UpgradeText.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeText.CustomFontFile",
                            Type = "string",
                            Value = UpgradeText.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeText.Font",
                            Type = "string",
                            Value = UpgradeText.Font
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeText.Font Scale",
                            Type = "float",
                            Value = UpgradeText.FontScale
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeText.FontSize",
                            Type = "int",
                            Value = UpgradeText.FontSize
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeText.Green",
                            Type = "int",
                            Value = UpgradeText.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeText.Height",
                            Type = "float",
                            Value = UpgradeText.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeText.Height Units",
                            Type = "DimensionUnitType",
                            Value = UpgradeText.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = UpgradeText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeText.OutlineThickness",
                            Type = "int",
                            Value = UpgradeText.OutlineThickness
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeText.Parent",
                            Type = "string",
                            Value = UpgradeText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeText.Red",
                            Type = "int",
                            Value = UpgradeText.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeText.Text",
                            Type = "string",
                            Value = UpgradeText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeText.UseCustomFont",
                            Type = "bool",
                            Value = UpgradeText.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = UpgradeText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeText.Visible",
                            Type = "bool",
                            Value = UpgradeText.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeText.Width",
                            Type = "float",
                            Value = UpgradeText.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeText.Width Units",
                            Type = "DimensionUnitType",
                            Value = UpgradeText.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Text.Blue",
                            Type = "int",
                            Value = Upgrade1Text.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Text.CustomFontFile",
                            Type = "string",
                            Value = Upgrade1Text.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Text.Font Scale",
                            Type = "float",
                            Value = Upgrade1Text.FontScale
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Text.Green",
                            Type = "int",
                            Value = Upgrade1Text.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Text.Height",
                            Type = "float",
                            Value = Upgrade1Text.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Text.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = Upgrade1Text.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Text.Parent",
                            Type = "string",
                            Value = Upgrade1Text.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Text.Red",
                            Type = "int",
                            Value = Upgrade1Text.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Text.Text",
                            Type = "string",
                            Value = Upgrade1Text.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Text.UseCustomFont",
                            Type = "bool",
                            Value = Upgrade1Text.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Text.Width",
                            Type = "float",
                            Value = Upgrade1Text.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Text.X",
                            Type = "float",
                            Value = Upgrade1Text.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Text.X Origin",
                            Type = "HorizontalAlignment",
                            Value = Upgrade1Text.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Text.X Units",
                            Type = "PositionUnitType",
                            Value = Upgrade1Text.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Text.Y",
                            Type = "float",
                            Value = Upgrade1Text.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Text.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Upgrade1Text.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Text.Y Units",
                            Type = "PositionUnitType",
                            Value = Upgrade1Text.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Type.Height",
                            Type = "float",
                            Value = Upgrade1Type.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Type.Height Units",
                            Type = "DimensionUnitType",
                            Value = Upgrade1Type.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Type.Parent",
                            Type = "string",
                            Value = Upgrade1Type.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Type.Width",
                            Type = "float",
                            Value = Upgrade1Type.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Type.Width Units",
                            Type = "DimensionUnitType",
                            Value = Upgrade1Type.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Type.X",
                            Type = "float",
                            Value = Upgrade1Type.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Type.X Origin",
                            Type = "HorizontalAlignment",
                            Value = Upgrade1Type.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Type.X Units",
                            Type = "PositionUnitType",
                            Value = Upgrade1Type.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Type.Y",
                            Type = "float",
                            Value = Upgrade1Type.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Type.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Upgrade1Type.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Type.Y Units",
                            Type = "PositionUnitType",
                            Value = Upgrade1Type.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OrTextInstance.Blue",
                            Type = "int",
                            Value = OrTextInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OrTextInstance.CustomFontFile",
                            Type = "string",
                            Value = OrTextInstance.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OrTextInstance.Font Scale",
                            Type = "float",
                            Value = OrTextInstance.FontScale
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OrTextInstance.Green",
                            Type = "int",
                            Value = OrTextInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OrTextInstance.Height",
                            Type = "float",
                            Value = OrTextInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OrTextInstance.Parent",
                            Type = "string",
                            Value = OrTextInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OrTextInstance.Red",
                            Type = "int",
                            Value = OrTextInstance.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OrTextInstance.Text",
                            Type = "string",
                            Value = OrTextInstance.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OrTextInstance.UseCustomFont",
                            Type = "bool",
                            Value = OrTextInstance.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OrTextInstance.Width",
                            Type = "float",
                            Value = OrTextInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OrTextInstance.X",
                            Type = "float",
                            Value = OrTextInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OrTextInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = OrTextInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OrTextInstance.X Units",
                            Type = "PositionUnitType",
                            Value = OrTextInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OrTextInstance.Y",
                            Type = "float",
                            Value = OrTextInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OrTextInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = OrTextInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OrTextInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = OrTextInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Text.Blue",
                            Type = "int",
                            Value = Upgrade2Text.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Text.CustomFontFile",
                            Type = "string",
                            Value = Upgrade2Text.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Text.Font Scale",
                            Type = "float",
                            Value = Upgrade2Text.FontScale
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Text.Green",
                            Type = "int",
                            Value = Upgrade2Text.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Text.Height",
                            Type = "float",
                            Value = Upgrade2Text.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Text.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = Upgrade2Text.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Text.Parent",
                            Type = "string",
                            Value = Upgrade2Text.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Text.Red",
                            Type = "int",
                            Value = Upgrade2Text.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Text.Text",
                            Type = "string",
                            Value = Upgrade2Text.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Text.UseCustomFont",
                            Type = "bool",
                            Value = Upgrade2Text.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Text.Width",
                            Type = "float",
                            Value = Upgrade2Text.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Text.X",
                            Type = "float",
                            Value = Upgrade2Text.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Text.X Origin",
                            Type = "HorizontalAlignment",
                            Value = Upgrade2Text.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Text.X Units",
                            Type = "PositionUnitType",
                            Value = Upgrade2Text.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Text.Y",
                            Type = "float",
                            Value = Upgrade2Text.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Text.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Upgrade2Text.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Text.Y Units",
                            Type = "PositionUnitType",
                            Value = Upgrade2Text.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Type.Height",
                            Type = "float",
                            Value = Upgrade2Type.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Type.Height Units",
                            Type = "DimensionUnitType",
                            Value = Upgrade2Type.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Type.Parent",
                            Type = "string",
                            Value = Upgrade2Type.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Type.Width",
                            Type = "float",
                            Value = Upgrade2Type.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Type.Width Units",
                            Type = "DimensionUnitType",
                            Value = Upgrade2Type.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Type.X",
                            Type = "float",
                            Value = Upgrade2Type.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Type.X Origin",
                            Type = "HorizontalAlignment",
                            Value = Upgrade2Type.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Type.X Units",
                            Type = "PositionUnitType",
                            Value = Upgrade2Type.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Type.Y",
                            Type = "float",
                            Value = Upgrade2Type.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Type.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Upgrade2Type.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Type.Y Units",
                            Type = "PositionUnitType",
                            Value = Upgrade2Type.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TitleContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = TitleContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TitleContainer.Height",
                            Type = "float",
                            Value = TitleContainer.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TitleContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = TitleContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TitleContainer.Parent",
                            Type = "string",
                            Value = TitleContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TitleContainer.Width",
                            Type = "float",
                            Value = TitleContainer.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TitleContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = TitleContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TitleContainer.Wraps Children",
                            Type = "bool",
                            Value = TitleContainer.WrapsChildren
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeContainer.Height",
                            Type = "float",
                            Value = UpgradeContainer.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = UpgradeContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeContainer.Parent",
                            Type = "string",
                            Value = UpgradeContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeContainer.Visible",
                            Type = "bool",
                            Value = UpgradeContainer.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeContainer.Width",
                            Type = "float",
                            Value = UpgradeContainer.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = UpgradeContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeContainer.X",
                            Type = "float",
                            Value = UpgradeContainer.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeContainer.Y",
                            Type = "float",
                            Value = UpgradeContainer.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeContainer.Y Origin",
                            Type = "VerticalAlignment",
                            Value = UpgradeContainer.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeContainer.Y Units",
                            Type = "PositionUnitType",
                            Value = UpgradeContainer.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostText.Blue",
                            Type = "int",
                            Value = CostText.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostText.CustomFontFile",
                            Type = "string",
                            Value = CostText.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostText.Font",
                            Type = "string",
                            Value = CostText.Font
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostText.Font Scale",
                            Type = "float",
                            Value = CostText.FontScale
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostText.FontSize",
                            Type = "int",
                            Value = CostText.FontSize
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostText.Green",
                            Type = "int",
                            Value = CostText.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostText.Height",
                            Type = "float",
                            Value = CostText.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostText.Height Units",
                            Type = "DimensionUnitType",
                            Value = CostText.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = CostText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostText.OutlineThickness",
                            Type = "int",
                            Value = CostText.OutlineThickness
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostText.Parent",
                            Type = "string",
                            Value = CostText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostText.Red",
                            Type = "int",
                            Value = CostText.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostText.Text",
                            Type = "string",
                            Value = CostText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostText.UseCustomFont",
                            Type = "bool",
                            Value = CostText.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = CostText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostText.Visible",
                            Type = "bool",
                            Value = CostText.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostText.Width",
                            Type = "float",
                            Value = CostText.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostText.Width Units",
                            Type = "DimensionUnitType",
                            Value = CostText.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostText.X",
                            Type = "float",
                            Value = CostText.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostText.X Origin",
                            Type = "HorizontalAlignment",
                            Value = CostText.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostText.X Units",
                            Type = "PositionUnitType",
                            Value = CostText.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsSprite.Height",
                            Type = "float",
                            Value = PointsSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = PointsSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsSprite.Parent",
                            Type = "string",
                            Value = PointsSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsSprite.SourceFile",
                            Type = "string",
                            Value = PointsSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = PointsSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsSprite.Texture Height",
                            Type = "int",
                            Value = PointsSprite.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsSprite.Texture Left",
                            Type = "int",
                            Value = PointsSprite.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsSprite.Texture Top",
                            Type = "int",
                            Value = PointsSprite.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsSprite.Texture Width",
                            Type = "int",
                            Value = PointsSprite.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = PointsSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsSprite.X",
                            Type = "float",
                            Value = PointsSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = PointsSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsSprite.X Units",
                            Type = "PositionUnitType",
                            Value = PointsSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = PointsSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsSprite.Y Units",
                            Type = "PositionUnitType",
                            Value = PointsSprite.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Children Layout",
                            Type = "ChildrenLayout",
                            Value = ContainerInstance.ChildrenLayout
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
                            Name = "Width",
                            Type = "float",
                            Value = Width + 300f
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
                            Name = "WhiteFrameInstance.ColorState",
                            Type = "ColorState",
                            Value = WhiteFrameInstance.CurrentColorState
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
                            Name = "UpgradeText.Blue",
                            Type = "int",
                            Value = UpgradeText.Blue + 140
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeText.CustomFontFile",
                            Type = "string",
                            Value = UpgradeText.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeText.Font",
                            Type = "string",
                            Value = UpgradeText.Font
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeText.Font Scale",
                            Type = "float",
                            Value = UpgradeText.FontScale + 0.7f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeText.FontSize",
                            Type = "int",
                            Value = UpgradeText.FontSize + 50
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeText.Green",
                            Type = "int",
                            Value = UpgradeText.Green + 230
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeText.Height",
                            Type = "float",
                            Value = UpgradeText.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeText.Height Units",
                            Type = "DimensionUnitType",
                            Value = UpgradeText.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = UpgradeText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeText.OutlineThickness",
                            Type = "int",
                            Value = UpgradeText.OutlineThickness + 2
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeText.Parent",
                            Type = "string",
                            Value = UpgradeText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeText.Red",
                            Type = "int",
                            Value = UpgradeText.Red + 240
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeText.Text",
                            Type = "string",
                            Value = UpgradeText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeText.UseCustomFont",
                            Type = "bool",
                            Value = UpgradeText.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = UpgradeText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeText.Visible",
                            Type = "bool",
                            Value = UpgradeText.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeText.Width",
                            Type = "float",
                            Value = UpgradeText.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeText.Width Units",
                            Type = "DimensionUnitType",
                            Value = UpgradeText.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Text.Blue",
                            Type = "int",
                            Value = Upgrade1Text.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Text.CustomFontFile",
                            Type = "string",
                            Value = Upgrade1Text.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Text.Font Scale",
                            Type = "float",
                            Value = Upgrade1Text.FontScale + 0.4f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Text.Green",
                            Type = "int",
                            Value = Upgrade1Text.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Text.Height",
                            Type = "float",
                            Value = Upgrade1Text.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Text.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = Upgrade1Text.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Text.Parent",
                            Type = "string",
                            Value = Upgrade1Text.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Text.Red",
                            Type = "int",
                            Value = Upgrade1Text.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Text.Text",
                            Type = "string",
                            Value = Upgrade1Text.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Text.UseCustomFont",
                            Type = "bool",
                            Value = Upgrade1Text.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Text.Width",
                            Type = "float",
                            Value = Upgrade1Text.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Text.X",
                            Type = "float",
                            Value = Upgrade1Text.X + 21.5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Text.X Origin",
                            Type = "HorizontalAlignment",
                            Value = Upgrade1Text.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Text.X Units",
                            Type = "PositionUnitType",
                            Value = Upgrade1Text.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Text.Y",
                            Type = "float",
                            Value = Upgrade1Text.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Text.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Upgrade1Text.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Text.Y Units",
                            Type = "PositionUnitType",
                            Value = Upgrade1Text.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Type.Height",
                            Type = "float",
                            Value = Upgrade1Type.Height + 75f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Type.Height Units",
                            Type = "DimensionUnitType",
                            Value = Upgrade1Type.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Type.Parent",
                            Type = "string",
                            Value = Upgrade1Type.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Type.Width",
                            Type = "float",
                            Value = Upgrade1Type.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Type.Width Units",
                            Type = "DimensionUnitType",
                            Value = Upgrade1Type.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Type.X",
                            Type = "float",
                            Value = Upgrade1Type.X + 21.5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Type.X Origin",
                            Type = "HorizontalAlignment",
                            Value = Upgrade1Type.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Type.X Units",
                            Type = "PositionUnitType",
                            Value = Upgrade1Type.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Type.Y",
                            Type = "float",
                            Value = Upgrade1Type.Y + 25f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Type.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Upgrade1Type.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Type.Y Units",
                            Type = "PositionUnitType",
                            Value = Upgrade1Type.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OrTextInstance.Blue",
                            Type = "int",
                            Value = OrTextInstance.Blue + 220
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OrTextInstance.CustomFontFile",
                            Type = "string",
                            Value = OrTextInstance.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OrTextInstance.Font Scale",
                            Type = "float",
                            Value = OrTextInstance.FontScale + 0.6f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OrTextInstance.Green",
                            Type = "int",
                            Value = OrTextInstance.Green + 220
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OrTextInstance.Height",
                            Type = "float",
                            Value = OrTextInstance.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OrTextInstance.Parent",
                            Type = "string",
                            Value = OrTextInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OrTextInstance.Red",
                            Type = "int",
                            Value = OrTextInstance.Red + 220
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OrTextInstance.Text",
                            Type = "string",
                            Value = OrTextInstance.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OrTextInstance.UseCustomFont",
                            Type = "bool",
                            Value = OrTextInstance.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OrTextInstance.Width",
                            Type = "float",
                            Value = OrTextInstance.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OrTextInstance.X",
                            Type = "float",
                            Value = OrTextInstance.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OrTextInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = OrTextInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OrTextInstance.X Units",
                            Type = "PositionUnitType",
                            Value = OrTextInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OrTextInstance.Y",
                            Type = "float",
                            Value = OrTextInstance.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OrTextInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = OrTextInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OrTextInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = OrTextInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Text.Blue",
                            Type = "int",
                            Value = Upgrade2Text.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Text.CustomFontFile",
                            Type = "string",
                            Value = Upgrade2Text.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Text.Font Scale",
                            Type = "float",
                            Value = Upgrade2Text.FontScale + 0.4f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Text.Green",
                            Type = "int",
                            Value = Upgrade2Text.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Text.Height",
                            Type = "float",
                            Value = Upgrade2Text.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Text.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = Upgrade2Text.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Text.Parent",
                            Type = "string",
                            Value = Upgrade2Text.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Text.Red",
                            Type = "int",
                            Value = Upgrade2Text.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Text.Text",
                            Type = "string",
                            Value = Upgrade2Text.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Text.UseCustomFont",
                            Type = "bool",
                            Value = Upgrade2Text.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Text.Width",
                            Type = "float",
                            Value = Upgrade2Text.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Text.X",
                            Type = "float",
                            Value = Upgrade2Text.X + 78.5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Text.X Origin",
                            Type = "HorizontalAlignment",
                            Value = Upgrade2Text.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Text.X Units",
                            Type = "PositionUnitType",
                            Value = Upgrade2Text.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Text.Y",
                            Type = "float",
                            Value = Upgrade2Text.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Text.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Upgrade2Text.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Text.Y Units",
                            Type = "PositionUnitType",
                            Value = Upgrade2Text.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Type.Height",
                            Type = "float",
                            Value = Upgrade2Type.Height + 75f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Type.Height Units",
                            Type = "DimensionUnitType",
                            Value = Upgrade2Type.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Type.Parent",
                            Type = "string",
                            Value = Upgrade2Type.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Type.Width",
                            Type = "float",
                            Value = Upgrade2Type.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Type.Width Units",
                            Type = "DimensionUnitType",
                            Value = Upgrade2Type.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Type.X",
                            Type = "float",
                            Value = Upgrade2Type.X + 78.5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Type.X Origin",
                            Type = "HorizontalAlignment",
                            Value = Upgrade2Type.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Type.X Units",
                            Type = "PositionUnitType",
                            Value = Upgrade2Type.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Type.Y",
                            Type = "float",
                            Value = Upgrade2Type.Y + 25f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Type.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Upgrade2Type.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Type.Y Units",
                            Type = "PositionUnitType",
                            Value = Upgrade2Type.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TitleContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = TitleContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TitleContainer.Height",
                            Type = "float",
                            Value = TitleContainer.Height + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TitleContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = TitleContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TitleContainer.Parent",
                            Type = "string",
                            Value = TitleContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TitleContainer.Width",
                            Type = "float",
                            Value = TitleContainer.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TitleContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = TitleContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TitleContainer.Wraps Children",
                            Type = "bool",
                            Value = TitleContainer.WrapsChildren
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeContainer.Height",
                            Type = "float",
                            Value = UpgradeContainer.Height + -40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = UpgradeContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeContainer.Parent",
                            Type = "string",
                            Value = UpgradeContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeContainer.Visible",
                            Type = "bool",
                            Value = UpgradeContainer.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeContainer.Width",
                            Type = "float",
                            Value = UpgradeContainer.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = UpgradeContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeContainer.X",
                            Type = "float",
                            Value = UpgradeContainer.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeContainer.Y",
                            Type = "float",
                            Value = UpgradeContainer.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeContainer.Y Origin",
                            Type = "VerticalAlignment",
                            Value = UpgradeContainer.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeContainer.Y Units",
                            Type = "PositionUnitType",
                            Value = UpgradeContainer.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostText.Blue",
                            Type = "int",
                            Value = CostText.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostText.CustomFontFile",
                            Type = "string",
                            Value = CostText.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostText.Font",
                            Type = "string",
                            Value = CostText.Font
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostText.Font Scale",
                            Type = "float",
                            Value = CostText.FontScale + 0.7f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostText.FontSize",
                            Type = "int",
                            Value = CostText.FontSize + 50
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostText.Green",
                            Type = "int",
                            Value = CostText.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostText.Height",
                            Type = "float",
                            Value = CostText.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostText.Height Units",
                            Type = "DimensionUnitType",
                            Value = CostText.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = CostText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostText.OutlineThickness",
                            Type = "int",
                            Value = CostText.OutlineThickness + 2
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostText.Parent",
                            Type = "string",
                            Value = CostText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostText.Red",
                            Type = "int",
                            Value = CostText.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostText.Text",
                            Type = "string",
                            Value = CostText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostText.UseCustomFont",
                            Type = "bool",
                            Value = CostText.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = CostText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostText.Visible",
                            Type = "bool",
                            Value = CostText.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostText.Width",
                            Type = "float",
                            Value = CostText.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostText.Width Units",
                            Type = "DimensionUnitType",
                            Value = CostText.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostText.X",
                            Type = "float",
                            Value = CostText.X + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostText.X Origin",
                            Type = "HorizontalAlignment",
                            Value = CostText.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostText.X Units",
                            Type = "PositionUnitType",
                            Value = CostText.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsSprite.Height",
                            Type = "float",
                            Value = PointsSprite.Height + 95f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = PointsSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsSprite.Parent",
                            Type = "string",
                            Value = PointsSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsSprite.SourceFile",
                            Type = "string",
                            Value = PointsSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = PointsSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsSprite.Texture Height",
                            Type = "int",
                            Value = PointsSprite.TextureHeight + 122
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsSprite.Texture Left",
                            Type = "int",
                            Value = PointsSprite.TextureLeft + 2435
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsSprite.Texture Top",
                            Type = "int",
                            Value = PointsSprite.TextureTop + 910
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsSprite.Texture Width",
                            Type = "int",
                            Value = PointsSprite.TextureWidth + 128
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = PointsSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsSprite.X",
                            Type = "float",
                            Value = PointsSprite.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = PointsSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsSprite.X Units",
                            Type = "PositionUnitType",
                            Value = PointsSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = PointsSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsSprite.Y Units",
                            Type = "PositionUnitType",
                            Value = PointsSprite.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Children Layout",
                            Type = "ChildrenLayout",
                            Value = ContainerInstance.ChildrenLayout
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
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (OptionsAvailability state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  OptionsAvailability.OneOption:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Text.X",
                            Type = "float",
                            Value = Upgrade1Text.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Type.X",
                            Type = "float",
                            Value = Upgrade1Type.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OrTextInstance.Visible",
                            Type = "bool",
                            Value = OrTextInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Text.Visible",
                            Type = "bool",
                            Value = Upgrade2Text.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Type.Visible",
                            Type = "bool",
                            Value = Upgrade2Type.Visible
                        }
                        );
                        break;
                    case  OptionsAvailability.TwoOptions:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Text.X",
                            Type = "float",
                            Value = Upgrade1Text.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Type.X",
                            Type = "float",
                            Value = Upgrade1Type.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OrTextInstance.Visible",
                            Type = "bool",
                            Value = OrTextInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Text.Visible",
                            Type = "bool",
                            Value = Upgrade2Text.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Type.Visible",
                            Type = "bool",
                            Value = Upgrade2Type.Visible
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (OptionsAvailability state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  OptionsAvailability.OneOption:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Text.X",
                            Type = "float",
                            Value = Upgrade1Text.X + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Type.X",
                            Type = "float",
                            Value = Upgrade1Type.X + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OrTextInstance.Visible",
                            Type = "bool",
                            Value = OrTextInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Text.Visible",
                            Type = "bool",
                            Value = Upgrade2Text.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Type.Visible",
                            Type = "bool",
                            Value = Upgrade2Type.Visible
                        }
                        );
                        break;
                    case  OptionsAvailability.TwoOptions:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Text.X",
                            Type = "float",
                            Value = Upgrade1Text.X + 21.5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Type.X",
                            Type = "float",
                            Value = Upgrade1Type.X + 21.5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OrTextInstance.Visible",
                            Type = "bool",
                            Value = OrTextInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Text.Visible",
                            Type = "bool",
                            Value = Upgrade2Text.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Type.Visible",
                            Type = "bool",
                            Value = Upgrade2Type.Visible
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (OptionOneChoice state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  OptionOneChoice.UpgradeRange:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Text.Text",
                            Type = "string",
                            Value = Upgrade1Text.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Type.AttributeTypeState",
                            Type = "AttributeTypeState",
                            Value = Upgrade1Type.CurrentAttributeTypeState
                        }
                        );
                        break;
                    case  OptionOneChoice.UpgradeSpeed:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Text.Text",
                            Type = "string",
                            Value = Upgrade1Text.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Type.AttributeTypeState",
                            Type = "AttributeTypeState",
                            Value = Upgrade1Type.CurrentAttributeTypeState
                        }
                        );
                        break;
                    case  OptionOneChoice.UpgradeDamage:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Text.Text",
                            Type = "string",
                            Value = Upgrade1Text.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Type.AttributeTypeState",
                            Type = "AttributeTypeState",
                            Value = Upgrade1Type.CurrentAttributeTypeState
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (OptionOneChoice state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  OptionOneChoice.UpgradeRange:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Text.Text",
                            Type = "string",
                            Value = Upgrade1Text.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Type.AttributeTypeState",
                            Type = "AttributeTypeState",
                            Value = Upgrade1Type.CurrentAttributeTypeState
                        }
                        );
                        break;
                    case  OptionOneChoice.UpgradeSpeed:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Text.Text",
                            Type = "string",
                            Value = Upgrade1Text.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Type.AttributeTypeState",
                            Type = "AttributeTypeState",
                            Value = Upgrade1Type.CurrentAttributeTypeState
                        }
                        );
                        break;
                    case  OptionOneChoice.UpgradeDamage:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Text.Text",
                            Type = "string",
                            Value = Upgrade1Text.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Type.AttributeTypeState",
                            Type = "AttributeTypeState",
                            Value = Upgrade1Type.CurrentAttributeTypeState
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (OptionTwoChoice state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  OptionTwoChoice.UpgradeRange:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Text.Text",
                            Type = "string",
                            Value = Upgrade2Text.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Type.AttributeTypeState",
                            Type = "AttributeTypeState",
                            Value = Upgrade2Type.CurrentAttributeTypeState
                        }
                        );
                        break;
                    case  OptionTwoChoice.UpgradeSpeed:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Text.Text",
                            Type = "string",
                            Value = Upgrade2Text.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Type.AttributeTypeState",
                            Type = "AttributeTypeState",
                            Value = Upgrade2Type.CurrentAttributeTypeState
                        }
                        );
                        break;
                    case  OptionTwoChoice.UpgradeDamage:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Text.Text",
                            Type = "string",
                            Value = Upgrade2Text.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Type.AttributeTypeState",
                            Type = "AttributeTypeState",
                            Value = Upgrade2Type.CurrentAttributeTypeState
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (OptionTwoChoice state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  OptionTwoChoice.UpgradeRange:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Text.Text",
                            Type = "string",
                            Value = Upgrade2Text.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Type.AttributeTypeState",
                            Type = "AttributeTypeState",
                            Value = Upgrade2Type.CurrentAttributeTypeState
                        }
                        );
                        break;
                    case  OptionTwoChoice.UpgradeSpeed:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Text.Text",
                            Type = "string",
                            Value = Upgrade2Text.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Type.AttributeTypeState",
                            Type = "AttributeTypeState",
                            Value = Upgrade2Type.CurrentAttributeTypeState
                        }
                        );
                        break;
                    case  OptionTwoChoice.UpgradeDamage:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Text.Text",
                            Type = "string",
                            Value = Upgrade2Text.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Type.AttributeTypeState",
                            Type = "AttributeTypeState",
                            Value = Upgrade2Type.CurrentAttributeTypeState
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (Affordability state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  Affordability.CanAfford:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WhiteFrameInstance.ColorState",
                            Type = "ColorState",
                            Value = WhiteFrameInstance.CurrentColorState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeText.Alpha",
                            Type = "int",
                            Value = UpgradeText.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Text.Alpha",
                            Type = "int",
                            Value = Upgrade1Text.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OrTextInstance.Alpha",
                            Type = "int",
                            Value = OrTextInstance.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Text.Alpha",
                            Type = "int",
                            Value = Upgrade2Text.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostText.Blue",
                            Type = "int",
                            Value = CostText.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostText.Green",
                            Type = "int",
                            Value = CostText.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostText.Red",
                            Type = "int",
                            Value = CostText.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsSprite.Alpha",
                            Type = "int",
                            Value = PointsSprite.Alpha
                        }
                        );
                        break;
                    case  Affordability.CantAfford:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WhiteFrameInstance.ColorState",
                            Type = "ColorState",
                            Value = WhiteFrameInstance.CurrentColorState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeText.Alpha",
                            Type = "int",
                            Value = UpgradeText.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Text.Alpha",
                            Type = "int",
                            Value = Upgrade1Text.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Type.IconAlpha",
                            Type = "int",
                            Value = Upgrade1Type.IconAlpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OrTextInstance.Alpha",
                            Type = "int",
                            Value = OrTextInstance.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Text.Alpha",
                            Type = "int",
                            Value = Upgrade2Text.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Type.IconAlpha",
                            Type = "int",
                            Value = Upgrade2Type.IconAlpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostText.Blue",
                            Type = "int",
                            Value = CostText.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostText.Green",
                            Type = "int",
                            Value = CostText.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostText.Red",
                            Type = "int",
                            Value = CostText.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsSprite.Alpha",
                            Type = "int",
                            Value = PointsSprite.Alpha
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (Affordability state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  Affordability.CanAfford:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WhiteFrameInstance.ColorState",
                            Type = "ColorState",
                            Value = WhiteFrameInstance.CurrentColorState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeText.Alpha",
                            Type = "int",
                            Value = UpgradeText.Alpha + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Text.Alpha",
                            Type = "int",
                            Value = Upgrade1Text.Alpha + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OrTextInstance.Alpha",
                            Type = "int",
                            Value = OrTextInstance.Alpha + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Text.Alpha",
                            Type = "int",
                            Value = Upgrade2Text.Alpha + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostText.Blue",
                            Type = "int",
                            Value = CostText.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostText.Green",
                            Type = "int",
                            Value = CostText.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostText.Red",
                            Type = "int",
                            Value = CostText.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsSprite.Alpha",
                            Type = "int",
                            Value = PointsSprite.Alpha + 255
                        }
                        );
                        break;
                    case  Affordability.CantAfford:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WhiteFrameInstance.ColorState",
                            Type = "ColorState",
                            Value = WhiteFrameInstance.CurrentColorState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeText.Alpha",
                            Type = "int",
                            Value = UpgradeText.Alpha + 100
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Text.Alpha",
                            Type = "int",
                            Value = Upgrade1Text.Alpha + 100
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade1Type.IconAlpha",
                            Type = "int",
                            Value = Upgrade1Type.IconAlpha + 100
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OrTextInstance.Alpha",
                            Type = "int",
                            Value = OrTextInstance.Alpha + 50
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Text.Alpha",
                            Type = "int",
                            Value = Upgrade2Text.Alpha + 100
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Upgrade2Type.IconAlpha",
                            Type = "int",
                            Value = Upgrade2Type.IconAlpha + 100
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostText.Blue",
                            Type = "int",
                            Value = CostText.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostText.Green",
                            Type = "int",
                            Value = CostText.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostText.Red",
                            Type = "int",
                            Value = CostText.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsSprite.Alpha",
                            Type = "int",
                            Value = PointsSprite.Alpha + 150
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
                    else if (category.Name == "OptionsAvailability")
                    {
                        if(state.Name == "OneOption") this.mCurrentOptionsAvailabilityState = OptionsAvailability.OneOption;
                        if(state.Name == "TwoOptions") this.mCurrentOptionsAvailabilityState = OptionsAvailability.TwoOptions;
                    }
                    else if (category.Name == "OptionOneChoice")
                    {
                        if(state.Name == "UpgradeRange") this.mCurrentOptionOneChoiceState = OptionOneChoice.UpgradeRange;
                        if(state.Name == "UpgradeSpeed") this.mCurrentOptionOneChoiceState = OptionOneChoice.UpgradeSpeed;
                        if(state.Name == "UpgradeDamage") this.mCurrentOptionOneChoiceState = OptionOneChoice.UpgradeDamage;
                    }
                    else if (category.Name == "OptionTwoChoice")
                    {
                        if(state.Name == "UpgradeRange") this.mCurrentOptionTwoChoiceState = OptionTwoChoice.UpgradeRange;
                        if(state.Name == "UpgradeSpeed") this.mCurrentOptionTwoChoiceState = OptionTwoChoice.UpgradeSpeed;
                        if(state.Name == "UpgradeDamage") this.mCurrentOptionTwoChoiceState = OptionTwoChoice.UpgradeDamage;
                    }
                    else if (category.Name == "Affordability")
                    {
                        if(state.Name == "CanAfford") this.mCurrentAffordabilityState = Affordability.CanAfford;
                        if(state.Name == "CantAfford") this.mCurrentAffordabilityState = Affordability.CantAfford;
                    }
                }
                base.ApplyState(state);
            }
            private AbbatoirIntergrade.GumRuntimes.WhiteFrameRuntime WhiteFrameInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime UpgradeText { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime Upgrade1Text { get; set; }
            private AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime Upgrade1Type { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime OrTextInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime Upgrade2Text { get; set; }
            private AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime Upgrade2Type { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime TitleContainer { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime UpgradeContainer { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime CostText { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime PointsSprite { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime ContainerInstance { get; set; }
            public string SatoshiCostText
            {
                get
                {
                    return CostText.Text;
                }
                set
                {
                    if (CostText.Text != value)
                    {
                        CostText.Text = value;
                        SatoshiCostTextChanged?.Invoke(this, null);
                    }
                }
            }
            public event System.EventHandler SatoshiCostTextChanged;
            public UpgradeInfoRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                this.HasEvents = false;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "infodisplays/UpgradeInfo");
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
                WhiteFrameInstance = this.GetGraphicalUiElementByName("WhiteFrameInstance") as AbbatoirIntergrade.GumRuntimes.WhiteFrameRuntime;
                UpgradeText = this.GetGraphicalUiElementByName("UpgradeText") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
                Upgrade1Text = this.GetGraphicalUiElementByName("Upgrade1Text") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
                Upgrade1Type = this.GetGraphicalUiElementByName("Upgrade1Type") as AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime;
                OrTextInstance = this.GetGraphicalUiElementByName("OrTextInstance") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
                Upgrade2Text = this.GetGraphicalUiElementByName("Upgrade2Text") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
                Upgrade2Type = this.GetGraphicalUiElementByName("Upgrade2Type") as AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime;
                TitleContainer = this.GetGraphicalUiElementByName("TitleContainer") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
                UpgradeContainer = this.GetGraphicalUiElementByName("UpgradeContainer") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
                CostText = this.GetGraphicalUiElementByName("CostText") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
                PointsSprite = this.GetGraphicalUiElementByName("PointsSprite") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                ContainerInstance = this.GetGraphicalUiElementByName("ContainerInstance") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
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
