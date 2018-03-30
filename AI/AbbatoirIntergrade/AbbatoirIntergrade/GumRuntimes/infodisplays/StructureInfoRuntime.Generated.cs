    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes
    {
        public partial class StructureInfoRuntime : AbbatoirIntergrade.GumRuntimes.ContainerRuntime
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            public enum UpgradeAvailability
            {
                Available,
                NotAvailable
            }
            public enum Selection
            {
                Selected,
                NotSelected
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            UpgradeAvailability mCurrentUpgradeAvailabilityState;
            Selection mCurrentSelectionState;
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
                            ClipsChildren = false;
                            Height = 45f;
                            HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            Visible = true;
                            Width = 20f;
                            WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            WrapsChildren = false;
                            XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddleInverted;
                            GlowSprite.Height = 120f;
                            GlowSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            SetProperty("GlowSprite.SourceFile", "AllUIAssets.png");
                            GlowSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            GlowSprite.TextureHeight = 160;
                            GlowSprite.TextureLeft = 2435;
                            GlowSprite.TextureTop = 601;
                            GlowSprite.TextureWidth = 160;
                            GlowSprite.Visible = false;
                            GlowSprite.Width = 120f;
                            GlowSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            GlowSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            GlowSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            GlowSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            GlowSprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            NameContainer.Height = 10f;
                            NameContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            NameContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "InfoContainer");
                            NameContainer.Width = 100f;
                            NameContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            NameContainer.Y = 3f;
                            NameContainer.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            NameText.Blue = 0;
                            SetProperty("NameText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                            NameText.Font = "Moire ExtraBold";
                            NameText.FontScale = 0.8f;
                            NameText.FontSize = 50;
                            NameText.Green = 215;
                            NameText.Height = 100f;
                            NameText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            NameText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            NameText.OutlineThickness = 2;
                            NameText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "NameContainer");
                            NameText.Red = 255;
                            NameText.Text = "Structure";
                            NameText.UseCustomFont = true;
                            NameText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            NameText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            TallInfoFrameInstance.Height = 100f;
                            TallInfoFrameInstance.Width = 100f;
                            StatsContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                            StatsContainer.Height = 60.5f;
                            StatsContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            StatsContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "InfoContainer");
                            StatsContainer.Width = 69.21875f;
                            StatsContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            StatsContainer.WrapsChildren = true;
                            StatsContainer.X = 79f;
                            StatsContainer.Y = 0f;
                            UpgradeText.Blue = 140;
                            SetProperty("UpgradeText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                            UpgradeText.Font = "Moire ExtraBold";
                            UpgradeText.FontScale = 0.8f;
                            UpgradeText.FontSize = 50;
                            UpgradeText.Green = 230;
                            UpgradeText.Height = 10f;
                            UpgradeText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            UpgradeText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            UpgradeText.OutlineThickness = 2;
                            UpgradeText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "InfoContainer");
                            UpgradeText.Red = 240;
                            UpgradeText.Text = "Upgrade:";
                            UpgradeText.UseCustomFont = true;
                            UpgradeText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Top;
                            UpgradeText.Visible = false;
                            UpgradeText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ButtonContainers.Height = 18f;
                            ButtonContainers.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ButtonContainers.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "InfoContainer");
                            ButtonContainers.Visible = false;
                            ButtonContainers.Width = 72.8125f;
                            ButtonContainers.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ButtonContainers.X = 70f;
                            ButtonContainers.Y = 0f;
                            ButtonContainers.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                            ButtonContainers.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            InfoContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                            InfoContainer.Height = 96.66668f;
                            InfoContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            InfoContainer.Width = 100f;
                            InfoContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            InfoContainer.WrapsChildren = false;
                            ColoredRectangleInstance.Height = 4f;
                            ColoredRectangleInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "NameContainer");
                            ColoredRectangleInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ColoredRectangleInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            ColoredRectangleInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            ColoredRectangleInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                            ColoredRectangleInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            AttackDamageType.DamageTypeIconState = AbbatoirIntergrade.GumRuntimes.DamageTypeIconRuntime.DamageType.Piercing;
                            AttackDamageType.Height = 100f;
                            AttackDamageType.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            AttackDamageType.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "AttackCostContainer");
                            AttackDamageType.ResistanceText = "50";
                            AttackDamageType.TextFontScale = 1f;
                            AttackDamageType.TextHorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            AttackDamageType.Width = 55f;
                            AttackDamageType.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            AttackDamageType.X = 0f;
                            AttackDamageType.Y = 0f;
                            MinRange.AttributeIconTypeState = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.MinRange;
                            MinRange.AttributeText = "100";
                            MinRange.Height = 75f;
                            MinRange.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            MinRange.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "RangeContainer");
                            MinRange.TextInstanceFontScale = 0.5f;
                            MinRange.TextInstanceHorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            MinRange.Width = 50f;
                            MinRange.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            MinRange.Y = 12.5f;
                            MinRange.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            MaxRange.AttributeIconTypeState = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.MaxRange;
                            MaxRange.AttributeText = "50";
                            MaxRange.Height = 75f;
                            MaxRange.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            MaxRange.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "RangeContainer");
                            MaxRange.TextInstanceFontScale = 0.5f;
                            MaxRange.TextInstanceHorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            MaxRange.Width = 50f;
                            MaxRange.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            MaxRange.Y = 12.5f;
                            MaxRange.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            AttackCostContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                            AttackCostContainer.Height = 25f;
                            AttackCostContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            AttackCostContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "StatsContainer");
                            AttackCostContainer.Width = 100f;
                            AttackCostContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            RangeContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                            RangeContainer.Height = 25f;
                            RangeContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            RangeContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "StatsContainer");
                            RangeContainer.Width = 0f;
                            RangeContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            AttackSpeed.AttributeIconTypeState = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.AttackSpeed;
                            AttackSpeed.AttributeText = "3 sec";
                            AttackSpeed.Height = 25f;
                            AttackSpeed.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            AttackSpeed.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "StatsContainer");
                            AttackSpeed.TextInstanceFontScale = 0.5f;
                            AttackSpeed.TextInstanceHorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            AttackSpeed.Width = 0f;
                            AttackSpeed.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            PointOrSplash.AttributeIconTypeState = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.PointOrSplash;
                            PointOrSplash.AttributeText = "Single";
                            PointOrSplash.Height = 25f;
                            PointOrSplash.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            PointOrSplash.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "StatsContainer");
                            PointOrSplash.TextInstanceFontScale = 0.5f;
                            PointOrSplash.TextInstanceHorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            PointOrSplash.Width = 0f;
                            PointOrSplash.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            ButtonFrameInstance.Height = 100f;
                            ButtonFrameInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ButtonContainers");
                            ButtonFrameInstance.Width = 34.03326f;
                            ButtonFrameInstance.X = 25f;
                            ButtonFrameInstance1.Height = 100f;
                            ButtonFrameInstance1.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ButtonContainers");
                            ButtonFrameInstance1.Width = 34.03326f;
                            ButtonFrameInstance1.X = -25f;
                            ButtonFrameInstance1.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            ButtonFrameInstance1.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            OrTextInstance.Blue = 140;
                            SetProperty("OrTextInstance.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                            OrTextInstance.FontScale = 0.6f;
                            OrTextInstance.Green = 230;
                            OrTextInstance.Height = 0f;
                            OrTextInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ButtonContainers");
                            OrTextInstance.Red = 240;
                            OrTextInstance.Text = "Or";
                            OrTextInstance.UseCustomFont = true;
                            OrTextInstance.Width = 0f;
                            OrTextInstance.X = 164f;
                            OrTextInstance.Y = 42f;
                            PointsSprite.Height = 50f;
                            PointsSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            PointsSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "AttackCostContainer");
                            SetProperty("PointsSprite.SourceFile", "AllUIAssets.png");
                            PointsSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            PointsSprite.TextureHeight = 122;
                            PointsSprite.TextureLeft = 2435;
                            PointsSprite.TextureTop = 910;
                            PointsSprite.TextureWidth = 128;
                            PointsSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                            PointsSprite.X = 15f;
                            PointsSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            PointsSprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            CostText.Blue = 0;
                            SetProperty("CostText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                            CostText.Green = 252;
                            CostText.Height = 0f;
                            CostText.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            CostText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            CostText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "AttackCostContainer");
                            CostText.Red = 124;
                            CostText.Text = "20";
                            CostText.UseCustomFont = true;
                            CostText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            CostText.Width = 0f;
                            CostText.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            CostText.X = 1f;
                            CostText.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            break;
                    }
                }
            }
            public UpgradeAvailability CurrentUpgradeAvailabilityState
            {
                get
                {
                    return mCurrentUpgradeAvailabilityState;
                }
                set
                {
                    mCurrentUpgradeAvailabilityState = value;
                    switch(mCurrentUpgradeAvailabilityState)
                    {
                        case  UpgradeAvailability.Available:
                            UpgradeText.Visible = true;
                            ButtonContainers.Visible = true;
                            break;
                        case  UpgradeAvailability.NotAvailable:
                            UpgradeText.Visible = false;
                            ButtonContainers.Visible = false;
                            break;
                    }
                }
            }
            public Selection CurrentSelectionState
            {
                get
                {
                    return mCurrentSelectionState;
                }
                set
                {
                    mCurrentSelectionState = value;
                    switch(mCurrentSelectionState)
                    {
                        case  Selection.Selected:
                            GlowSprite.Blue = 0;
                            GlowSprite.Red = 0;
                            GlowSprite.Visible = true;
                            NameText.Alpha = 255;
                            NameText.Blue = 47;
                            NameText.Green = 255;
                            NameText.Red = 173;
                            ColoredRectangleInstance.Alpha = 255;
                            ColoredRectangleInstance.Blue = 0;
                            ColoredRectangleInstance.Green = 252;
                            ColoredRectangleInstance.Red = 124;
                            break;
                        case  Selection.NotSelected:
                            GlowSprite.Blue = 255;
                            GlowSprite.Red = 255;
                            GlowSprite.Visible = false;
                            NameText.Alpha = 150;
                            NameText.Blue = 0;
                            NameText.Green = 165;
                            NameText.Red = 255;
                            ColoredRectangleInstance.Alpha = 150;
                            ColoredRectangleInstance.Blue = 0;
                            ColoredRectangleInstance.Green = 165;
                            ColoredRectangleInstance.Red = 255;
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
                bool setAttackCostContainerHeightFirstValue = false;
                bool setAttackCostContainerHeightSecondValue = false;
                float AttackCostContainerHeightFirstValue= 0;
                float AttackCostContainerHeightSecondValue= 0;
                bool setAttackCostContainerWidthFirstValue = false;
                bool setAttackCostContainerWidthSecondValue = false;
                float AttackCostContainerWidthFirstValue= 0;
                float AttackCostContainerWidthSecondValue= 0;
                bool setAttackDamageTypeHeightFirstValue = false;
                bool setAttackDamageTypeHeightSecondValue = false;
                float AttackDamageTypeHeightFirstValue= 0;
                float AttackDamageTypeHeightSecondValue= 0;
                bool setAttackDamageTypeTextFontScaleFirstValue = false;
                bool setAttackDamageTypeTextFontScaleSecondValue = false;
                float AttackDamageTypeTextFontScaleFirstValue= 0;
                float AttackDamageTypeTextFontScaleSecondValue= 0;
                bool setAttackDamageTypeWidthFirstValue = false;
                bool setAttackDamageTypeWidthSecondValue = false;
                float AttackDamageTypeWidthFirstValue= 0;
                float AttackDamageTypeWidthSecondValue= 0;
                bool setAttackDamageTypeXFirstValue = false;
                bool setAttackDamageTypeXSecondValue = false;
                float AttackDamageTypeXFirstValue= 0;
                float AttackDamageTypeXSecondValue= 0;
                bool setAttackDamageTypeYFirstValue = false;
                bool setAttackDamageTypeYSecondValue = false;
                float AttackDamageTypeYFirstValue= 0;
                float AttackDamageTypeYSecondValue= 0;
                bool setAttackSpeedHeightFirstValue = false;
                bool setAttackSpeedHeightSecondValue = false;
                float AttackSpeedHeightFirstValue= 0;
                float AttackSpeedHeightSecondValue= 0;
                bool setAttackSpeedTextInstanceFontScaleFirstValue = false;
                bool setAttackSpeedTextInstanceFontScaleSecondValue = false;
                float AttackSpeedTextInstanceFontScaleFirstValue= 0;
                float AttackSpeedTextInstanceFontScaleSecondValue= 0;
                bool setAttackSpeedWidthFirstValue = false;
                bool setAttackSpeedWidthSecondValue = false;
                float AttackSpeedWidthFirstValue= 0;
                float AttackSpeedWidthSecondValue= 0;
                bool setButtonContainersHeightFirstValue = false;
                bool setButtonContainersHeightSecondValue = false;
                float ButtonContainersHeightFirstValue= 0;
                float ButtonContainersHeightSecondValue= 0;
                bool setButtonContainersWidthFirstValue = false;
                bool setButtonContainersWidthSecondValue = false;
                float ButtonContainersWidthFirstValue= 0;
                float ButtonContainersWidthSecondValue= 0;
                bool setButtonContainersXFirstValue = false;
                bool setButtonContainersXSecondValue = false;
                float ButtonContainersXFirstValue= 0;
                float ButtonContainersXSecondValue= 0;
                bool setButtonContainersYFirstValue = false;
                bool setButtonContainersYSecondValue = false;
                float ButtonContainersYFirstValue= 0;
                float ButtonContainersYSecondValue= 0;
                bool setButtonFrameInstanceHeightFirstValue = false;
                bool setButtonFrameInstanceHeightSecondValue = false;
                float ButtonFrameInstanceHeightFirstValue= 0;
                float ButtonFrameInstanceHeightSecondValue= 0;
                bool setButtonFrameInstanceWidthFirstValue = false;
                bool setButtonFrameInstanceWidthSecondValue = false;
                float ButtonFrameInstanceWidthFirstValue= 0;
                float ButtonFrameInstanceWidthSecondValue= 0;
                bool setButtonFrameInstanceXFirstValue = false;
                bool setButtonFrameInstanceXSecondValue = false;
                float ButtonFrameInstanceXFirstValue= 0;
                float ButtonFrameInstanceXSecondValue= 0;
                bool setButtonFrameInstance1HeightFirstValue = false;
                bool setButtonFrameInstance1HeightSecondValue = false;
                float ButtonFrameInstance1HeightFirstValue= 0;
                float ButtonFrameInstance1HeightSecondValue= 0;
                bool setButtonFrameInstance1WidthFirstValue = false;
                bool setButtonFrameInstance1WidthSecondValue = false;
                float ButtonFrameInstance1WidthFirstValue= 0;
                float ButtonFrameInstance1WidthSecondValue= 0;
                bool setButtonFrameInstance1XFirstValue = false;
                bool setButtonFrameInstance1XSecondValue = false;
                float ButtonFrameInstance1XFirstValue= 0;
                float ButtonFrameInstance1XSecondValue= 0;
                bool setColoredRectangleInstanceHeightFirstValue = false;
                bool setColoredRectangleInstanceHeightSecondValue = false;
                float ColoredRectangleInstanceHeightFirstValue= 0;
                float ColoredRectangleInstanceHeightSecondValue= 0;
                bool setCostTextBlueFirstValue = false;
                bool setCostTextBlueSecondValue = false;
                int CostTextBlueFirstValue= 0;
                int CostTextBlueSecondValue= 0;
                bool setCostTextGreenFirstValue = false;
                bool setCostTextGreenSecondValue = false;
                int CostTextGreenFirstValue= 0;
                int CostTextGreenSecondValue= 0;
                bool setCostTextHeightFirstValue = false;
                bool setCostTextHeightSecondValue = false;
                float CostTextHeightFirstValue= 0;
                float CostTextHeightSecondValue= 0;
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
                bool setGlowSpriteHeightFirstValue = false;
                bool setGlowSpriteHeightSecondValue = false;
                float GlowSpriteHeightFirstValue= 0;
                float GlowSpriteHeightSecondValue= 0;
                bool setGlowSpriteTextureHeightFirstValue = false;
                bool setGlowSpriteTextureHeightSecondValue = false;
                int GlowSpriteTextureHeightFirstValue= 0;
                int GlowSpriteTextureHeightSecondValue= 0;
                bool setGlowSpriteTextureLeftFirstValue = false;
                bool setGlowSpriteTextureLeftSecondValue = false;
                int GlowSpriteTextureLeftFirstValue= 0;
                int GlowSpriteTextureLeftSecondValue= 0;
                bool setGlowSpriteTextureTopFirstValue = false;
                bool setGlowSpriteTextureTopSecondValue = false;
                int GlowSpriteTextureTopFirstValue= 0;
                int GlowSpriteTextureTopSecondValue= 0;
                bool setGlowSpriteTextureWidthFirstValue = false;
                bool setGlowSpriteTextureWidthSecondValue = false;
                int GlowSpriteTextureWidthFirstValue= 0;
                int GlowSpriteTextureWidthSecondValue= 0;
                bool setGlowSpriteWidthFirstValue = false;
                bool setGlowSpriteWidthSecondValue = false;
                float GlowSpriteWidthFirstValue= 0;
                float GlowSpriteWidthSecondValue= 0;
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setInfoContainerHeightFirstValue = false;
                bool setInfoContainerHeightSecondValue = false;
                float InfoContainerHeightFirstValue= 0;
                float InfoContainerHeightSecondValue= 0;
                bool setInfoContainerWidthFirstValue = false;
                bool setInfoContainerWidthSecondValue = false;
                float InfoContainerWidthFirstValue= 0;
                float InfoContainerWidthSecondValue= 0;
                bool setMaxRangeHeightFirstValue = false;
                bool setMaxRangeHeightSecondValue = false;
                float MaxRangeHeightFirstValue= 0;
                float MaxRangeHeightSecondValue= 0;
                bool setMaxRangeTextInstanceFontScaleFirstValue = false;
                bool setMaxRangeTextInstanceFontScaleSecondValue = false;
                float MaxRangeTextInstanceFontScaleFirstValue= 0;
                float MaxRangeTextInstanceFontScaleSecondValue= 0;
                bool setMaxRangeWidthFirstValue = false;
                bool setMaxRangeWidthSecondValue = false;
                float MaxRangeWidthFirstValue= 0;
                float MaxRangeWidthSecondValue= 0;
                bool setMaxRangeYFirstValue = false;
                bool setMaxRangeYSecondValue = false;
                float MaxRangeYFirstValue= 0;
                float MaxRangeYSecondValue= 0;
                bool setMinRangeHeightFirstValue = false;
                bool setMinRangeHeightSecondValue = false;
                float MinRangeHeightFirstValue= 0;
                float MinRangeHeightSecondValue= 0;
                bool setMinRangeTextInstanceFontScaleFirstValue = false;
                bool setMinRangeTextInstanceFontScaleSecondValue = false;
                float MinRangeTextInstanceFontScaleFirstValue= 0;
                float MinRangeTextInstanceFontScaleSecondValue= 0;
                bool setMinRangeWidthFirstValue = false;
                bool setMinRangeWidthSecondValue = false;
                float MinRangeWidthFirstValue= 0;
                float MinRangeWidthSecondValue= 0;
                bool setMinRangeYFirstValue = false;
                bool setMinRangeYSecondValue = false;
                float MinRangeYFirstValue= 0;
                float MinRangeYSecondValue= 0;
                bool setNameContainerHeightFirstValue = false;
                bool setNameContainerHeightSecondValue = false;
                float NameContainerHeightFirstValue= 0;
                float NameContainerHeightSecondValue= 0;
                bool setNameContainerWidthFirstValue = false;
                bool setNameContainerWidthSecondValue = false;
                float NameContainerWidthFirstValue= 0;
                float NameContainerWidthSecondValue= 0;
                bool setNameContainerYFirstValue = false;
                bool setNameContainerYSecondValue = false;
                float NameContainerYFirstValue= 0;
                float NameContainerYSecondValue= 0;
                bool setNameTextBlueFirstValue = false;
                bool setNameTextBlueSecondValue = false;
                int NameTextBlueFirstValue= 0;
                int NameTextBlueSecondValue= 0;
                bool setNameTextFontScaleFirstValue = false;
                bool setNameTextFontScaleSecondValue = false;
                float NameTextFontScaleFirstValue= 0;
                float NameTextFontScaleSecondValue= 0;
                bool setNameTextFontSizeFirstValue = false;
                bool setNameTextFontSizeSecondValue = false;
                int NameTextFontSizeFirstValue= 0;
                int NameTextFontSizeSecondValue= 0;
                bool setNameTextGreenFirstValue = false;
                bool setNameTextGreenSecondValue = false;
                int NameTextGreenFirstValue= 0;
                int NameTextGreenSecondValue= 0;
                bool setNameTextHeightFirstValue = false;
                bool setNameTextHeightSecondValue = false;
                float NameTextHeightFirstValue= 0;
                float NameTextHeightSecondValue= 0;
                bool setNameTextOutlineThicknessFirstValue = false;
                bool setNameTextOutlineThicknessSecondValue = false;
                int NameTextOutlineThicknessFirstValue= 0;
                int NameTextOutlineThicknessSecondValue= 0;
                bool setNameTextRedFirstValue = false;
                bool setNameTextRedSecondValue = false;
                int NameTextRedFirstValue= 0;
                int NameTextRedSecondValue= 0;
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
                bool setPointOrSplashHeightFirstValue = false;
                bool setPointOrSplashHeightSecondValue = false;
                float PointOrSplashHeightFirstValue= 0;
                float PointOrSplashHeightSecondValue= 0;
                bool setPointOrSplashTextInstanceFontScaleFirstValue = false;
                bool setPointOrSplashTextInstanceFontScaleSecondValue = false;
                float PointOrSplashTextInstanceFontScaleFirstValue= 0;
                float PointOrSplashTextInstanceFontScaleSecondValue= 0;
                bool setPointOrSplashWidthFirstValue = false;
                bool setPointOrSplashWidthSecondValue = false;
                float PointOrSplashWidthFirstValue= 0;
                float PointOrSplashWidthSecondValue= 0;
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
                bool setRangeContainerHeightFirstValue = false;
                bool setRangeContainerHeightSecondValue = false;
                float RangeContainerHeightFirstValue= 0;
                float RangeContainerHeightSecondValue= 0;
                bool setRangeContainerWidthFirstValue = false;
                bool setRangeContainerWidthSecondValue = false;
                float RangeContainerWidthFirstValue= 0;
                float RangeContainerWidthSecondValue= 0;
                bool setStatsContainerHeightFirstValue = false;
                bool setStatsContainerHeightSecondValue = false;
                float StatsContainerHeightFirstValue= 0;
                float StatsContainerHeightSecondValue= 0;
                bool setStatsContainerWidthFirstValue = false;
                bool setStatsContainerWidthSecondValue = false;
                float StatsContainerWidthFirstValue= 0;
                float StatsContainerWidthSecondValue= 0;
                bool setStatsContainerXFirstValue = false;
                bool setStatsContainerXSecondValue = false;
                float StatsContainerXFirstValue= 0;
                float StatsContainerXSecondValue= 0;
                bool setStatsContainerYFirstValue = false;
                bool setStatsContainerYSecondValue = false;
                float StatsContainerYFirstValue= 0;
                float StatsContainerYSecondValue= 0;
                bool setTallInfoFrameInstanceHeightFirstValue = false;
                bool setTallInfoFrameInstanceHeightSecondValue = false;
                float TallInfoFrameInstanceHeightFirstValue= 0;
                float TallInfoFrameInstanceHeightSecondValue= 0;
                bool setTallInfoFrameInstanceWidthFirstValue = false;
                bool setTallInfoFrameInstanceWidthSecondValue = false;
                float TallInfoFrameInstanceWidthFirstValue= 0;
                float TallInfoFrameInstanceWidthSecondValue= 0;
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
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        if (interpolationValue < 1)
                        {
                            this.AttackCostContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setAttackCostContainerHeightFirstValue = true;
                        AttackCostContainerHeightFirstValue = 25f;
                        if (interpolationValue < 1)
                        {
                            this.AttackCostContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.AttackCostContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "StatsContainer");
                        }
                        setAttackCostContainerWidthFirstValue = true;
                        AttackCostContainerWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.AttackCostContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.AttackDamageType.DamageTypeIconState = AbbatoirIntergrade.GumRuntimes.DamageTypeIconRuntime.DamageType.Piercing;
                        }
                        setAttackDamageTypeHeightFirstValue = true;
                        AttackDamageTypeHeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.AttackDamageType.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.AttackDamageType.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "AttackCostContainer");
                        }
                        if (interpolationValue < 1)
                        {
                            this.AttackDamageType.ResistanceText = "50";
                        }
                        setAttackDamageTypeTextFontScaleFirstValue = true;
                        AttackDamageTypeTextFontScaleFirstValue = 1f;
                        if (interpolationValue < 1)
                        {
                            this.AttackDamageType.TextHorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        setAttackDamageTypeWidthFirstValue = true;
                        AttackDamageTypeWidthFirstValue = 55f;
                        if (interpolationValue < 1)
                        {
                            this.AttackDamageType.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setAttackDamageTypeXFirstValue = true;
                        AttackDamageTypeXFirstValue = 0f;
                        setAttackDamageTypeYFirstValue = true;
                        AttackDamageTypeYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.AttackSpeed.AttributeIconTypeState = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.AttackSpeed;
                        }
                        if (interpolationValue < 1)
                        {
                            this.AttackSpeed.AttributeText = "3 sec";
                        }
                        setAttackSpeedHeightFirstValue = true;
                        AttackSpeedHeightFirstValue = 25f;
                        if (interpolationValue < 1)
                        {
                            this.AttackSpeed.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.AttackSpeed.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "StatsContainer");
                        }
                        setAttackSpeedTextInstanceFontScaleFirstValue = true;
                        AttackSpeedTextInstanceFontScaleFirstValue = 0.5f;
                        if (interpolationValue < 1)
                        {
                            this.AttackSpeed.TextInstanceHorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        setAttackSpeedWidthFirstValue = true;
                        AttackSpeedWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.AttackSpeed.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setButtonContainersHeightFirstValue = true;
                        ButtonContainersHeightFirstValue = 18f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonContainers.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ButtonContainers.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "InfoContainer");
                        }
                        if (interpolationValue < 1)
                        {
                            this.ButtonContainers.Visible = false;
                        }
                        setButtonContainersWidthFirstValue = true;
                        ButtonContainersWidthFirstValue = 72.8125f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonContainers.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setButtonContainersXFirstValue = true;
                        ButtonContainersXFirstValue = 70f;
                        setButtonContainersYFirstValue = true;
                        ButtonContainersYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonContainers.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ButtonContainers.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setButtonFrameInstanceHeightFirstValue = true;
                        ButtonFrameInstanceHeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ButtonContainers");
                        }
                        setButtonFrameInstanceWidthFirstValue = true;
                        ButtonFrameInstanceWidthFirstValue = 34.03326f;
                        setButtonFrameInstanceXFirstValue = true;
                        ButtonFrameInstanceXFirstValue = 25f;
                        setButtonFrameInstance1HeightFirstValue = true;
                        ButtonFrameInstance1HeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance1.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ButtonContainers");
                        }
                        setButtonFrameInstance1WidthFirstValue = true;
                        ButtonFrameInstance1WidthFirstValue = 34.03326f;
                        setButtonFrameInstance1XFirstValue = true;
                        ButtonFrameInstance1XFirstValue = -25f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance1.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance1.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ChildrenLayout = Gum.Managers.ChildrenLayout.Regular;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ClipsChildren = false;
                        }
                        setColoredRectangleInstanceHeightFirstValue = true;
                        ColoredRectangleInstanceHeightFirstValue = 4f;
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "NameContainer");
                        }
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setCostTextBlueFirstValue = true;
                        CostTextBlueFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            SetProperty("CostText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setCostTextGreenFirstValue = true;
                        CostTextGreenFirstValue = 252;
                        setCostTextHeightFirstValue = true;
                        CostTextHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.CostText.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CostText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CostText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "AttackCostContainer");
                        }
                        setCostTextRedFirstValue = true;
                        CostTextRedFirstValue = 124;
                        if (interpolationValue < 1)
                        {
                            this.CostText.Text = "20";
                        }
                        if (interpolationValue < 1)
                        {
                            this.CostText.UseCustomFont = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CostText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setCostTextWidthFirstValue = true;
                        CostTextWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.CostText.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setCostTextXFirstValue = true;
                        CostTextXFirstValue = 1f;
                        if (interpolationValue < 1)
                        {
                            this.CostText.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setGlowSpriteHeightFirstValue = true;
                        GlowSpriteHeightFirstValue = 120f;
                        if (interpolationValue < 1)
                        {
                            this.GlowSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("GlowSprite.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.GlowSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setGlowSpriteTextureHeightFirstValue = true;
                        GlowSpriteTextureHeightFirstValue = 160;
                        setGlowSpriteTextureLeftFirstValue = true;
                        GlowSpriteTextureLeftFirstValue = 2435;
                        setGlowSpriteTextureTopFirstValue = true;
                        GlowSpriteTextureTopFirstValue = 601;
                        setGlowSpriteTextureWidthFirstValue = true;
                        GlowSpriteTextureWidthFirstValue = 160;
                        if (interpolationValue < 1)
                        {
                            this.GlowSprite.Visible = false;
                        }
                        setGlowSpriteWidthFirstValue = true;
                        GlowSpriteWidthFirstValue = 120f;
                        if (interpolationValue < 1)
                        {
                            this.GlowSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.GlowSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.GlowSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue < 1)
                        {
                            this.GlowSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.GlowSprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setHeightFirstValue = true;
                        HeightFirstValue = 45f;
                        if (interpolationValue < 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.InfoContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setInfoContainerHeightFirstValue = true;
                        InfoContainerHeightFirstValue = 96.66668f;
                        if (interpolationValue < 1)
                        {
                            this.InfoContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setInfoContainerWidthFirstValue = true;
                        InfoContainerWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.InfoContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.InfoContainer.WrapsChildren = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MaxRange.AttributeIconTypeState = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.MaxRange;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MaxRange.AttributeText = "50";
                        }
                        setMaxRangeHeightFirstValue = true;
                        MaxRangeHeightFirstValue = 75f;
                        if (interpolationValue < 1)
                        {
                            this.MaxRange.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MaxRange.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "RangeContainer");
                        }
                        setMaxRangeTextInstanceFontScaleFirstValue = true;
                        MaxRangeTextInstanceFontScaleFirstValue = 0.5f;
                        if (interpolationValue < 1)
                        {
                            this.MaxRange.TextInstanceHorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        setMaxRangeWidthFirstValue = true;
                        MaxRangeWidthFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.MaxRange.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setMaxRangeYFirstValue = true;
                        MaxRangeYFirstValue = 12.5f;
                        if (interpolationValue < 1)
                        {
                            this.MaxRange.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MinRange.AttributeIconTypeState = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.MinRange;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MinRange.AttributeText = "100";
                        }
                        setMinRangeHeightFirstValue = true;
                        MinRangeHeightFirstValue = 75f;
                        if (interpolationValue < 1)
                        {
                            this.MinRange.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MinRange.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "RangeContainer");
                        }
                        setMinRangeTextInstanceFontScaleFirstValue = true;
                        MinRangeTextInstanceFontScaleFirstValue = 0.5f;
                        if (interpolationValue < 1)
                        {
                            this.MinRange.TextInstanceHorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        setMinRangeWidthFirstValue = true;
                        MinRangeWidthFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.MinRange.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setMinRangeYFirstValue = true;
                        MinRangeYFirstValue = 12.5f;
                        if (interpolationValue < 1)
                        {
                            this.MinRange.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setNameContainerHeightFirstValue = true;
                        NameContainerHeightFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.NameContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.NameContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "InfoContainer");
                        }
                        setNameContainerWidthFirstValue = true;
                        NameContainerWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.NameContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setNameContainerYFirstValue = true;
                        NameContainerYFirstValue = 3f;
                        if (interpolationValue < 1)
                        {
                            this.NameContainer.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setNameTextBlueFirstValue = true;
                        NameTextBlueFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            SetProperty("NameText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        if (interpolationValue < 1)
                        {
                            this.NameText.Font = "Moire ExtraBold";
                        }
                        setNameTextFontScaleFirstValue = true;
                        NameTextFontScaleFirstValue = 0.8f;
                        setNameTextFontSizeFirstValue = true;
                        NameTextFontSizeFirstValue = 50;
                        setNameTextGreenFirstValue = true;
                        NameTextGreenFirstValue = 215;
                        setNameTextHeightFirstValue = true;
                        NameTextHeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.NameText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.NameText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setNameTextOutlineThicknessFirstValue = true;
                        NameTextOutlineThicknessFirstValue = 2;
                        if (interpolationValue < 1)
                        {
                            this.NameText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "NameContainer");
                        }
                        setNameTextRedFirstValue = true;
                        NameTextRedFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            this.NameText.Text = "Structure";
                        }
                        if (interpolationValue < 1)
                        {
                            this.NameText.UseCustomFont = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.NameText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.NameText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setOrTextInstanceBlueFirstValue = true;
                        OrTextInstanceBlueFirstValue = 140;
                        if (interpolationValue < 1)
                        {
                            SetProperty("OrTextInstance.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setOrTextInstanceFontScaleFirstValue = true;
                        OrTextInstanceFontScaleFirstValue = 0.6f;
                        setOrTextInstanceGreenFirstValue = true;
                        OrTextInstanceGreenFirstValue = 230;
                        setOrTextInstanceHeightFirstValue = true;
                        OrTextInstanceHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.OrTextInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ButtonContainers");
                        }
                        setOrTextInstanceRedFirstValue = true;
                        OrTextInstanceRedFirstValue = 240;
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
                        OrTextInstanceXFirstValue = 164f;
                        setOrTextInstanceYFirstValue = true;
                        OrTextInstanceYFirstValue = 42f;
                        if (interpolationValue < 1)
                        {
                            this.PointOrSplash.AttributeIconTypeState = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.PointOrSplash;
                        }
                        if (interpolationValue < 1)
                        {
                            this.PointOrSplash.AttributeText = "Single";
                        }
                        setPointOrSplashHeightFirstValue = true;
                        PointOrSplashHeightFirstValue = 25f;
                        if (interpolationValue < 1)
                        {
                            this.PointOrSplash.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.PointOrSplash.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "StatsContainer");
                        }
                        setPointOrSplashTextInstanceFontScaleFirstValue = true;
                        PointOrSplashTextInstanceFontScaleFirstValue = 0.5f;
                        if (interpolationValue < 1)
                        {
                            this.PointOrSplash.TextInstanceHorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        setPointOrSplashWidthFirstValue = true;
                        PointOrSplashWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.PointOrSplash.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setPointsSpriteHeightFirstValue = true;
                        PointsSpriteHeightFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.PointsSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.PointsSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "AttackCostContainer");
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
                        PointsSpriteXFirstValue = 15f;
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
                            this.RangeContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setRangeContainerHeightFirstValue = true;
                        RangeContainerHeightFirstValue = 25f;
                        if (interpolationValue < 1)
                        {
                            this.RangeContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.RangeContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "StatsContainer");
                        }
                        setRangeContainerWidthFirstValue = true;
                        RangeContainerWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.RangeContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.StatsContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setStatsContainerHeightFirstValue = true;
                        StatsContainerHeightFirstValue = 60.5f;
                        if (interpolationValue < 1)
                        {
                            this.StatsContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.StatsContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "InfoContainer");
                        }
                        setStatsContainerWidthFirstValue = true;
                        StatsContainerWidthFirstValue = 69.21875f;
                        if (interpolationValue < 1)
                        {
                            this.StatsContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.StatsContainer.WrapsChildren = true;
                        }
                        setStatsContainerXFirstValue = true;
                        StatsContainerXFirstValue = 79f;
                        setStatsContainerYFirstValue = true;
                        StatsContainerYFirstValue = 0f;
                        setTallInfoFrameInstanceHeightFirstValue = true;
                        TallInfoFrameInstanceHeightFirstValue = 100f;
                        setTallInfoFrameInstanceWidthFirstValue = true;
                        TallInfoFrameInstanceWidthFirstValue = 100f;
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
                        UpgradeTextFontScaleFirstValue = 0.8f;
                        setUpgradeTextFontSizeFirstValue = true;
                        UpgradeTextFontSizeFirstValue = 50;
                        setUpgradeTextGreenFirstValue = true;
                        UpgradeTextGreenFirstValue = 230;
                        setUpgradeTextHeightFirstValue = true;
                        UpgradeTextHeightFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.UpgradeText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.UpgradeText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setUpgradeTextOutlineThicknessFirstValue = true;
                        UpgradeTextOutlineThicknessFirstValue = 2;
                        if (interpolationValue < 1)
                        {
                            this.UpgradeText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "InfoContainer");
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
                            this.UpgradeText.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.UpgradeText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Visible = true;
                        }
                        setWidthFirstValue = true;
                        WidthFirstValue = 20f;
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
                            this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue < 1)
                        {
                            this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddleInverted;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        if (interpolationValue >= 1)
                        {
                            this.AttackCostContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setAttackCostContainerHeightSecondValue = true;
                        AttackCostContainerHeightSecondValue = 25f;
                        if (interpolationValue >= 1)
                        {
                            this.AttackCostContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.AttackCostContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "StatsContainer");
                        }
                        setAttackCostContainerWidthSecondValue = true;
                        AttackCostContainerWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.AttackCostContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.AttackDamageType.DamageTypeIconState = AbbatoirIntergrade.GumRuntimes.DamageTypeIconRuntime.DamageType.Piercing;
                        }
                        setAttackDamageTypeHeightSecondValue = true;
                        AttackDamageTypeHeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.AttackDamageType.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.AttackDamageType.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "AttackCostContainer");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.AttackDamageType.ResistanceText = "50";
                        }
                        setAttackDamageTypeTextFontScaleSecondValue = true;
                        AttackDamageTypeTextFontScaleSecondValue = 1f;
                        if (interpolationValue >= 1)
                        {
                            this.AttackDamageType.TextHorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        setAttackDamageTypeWidthSecondValue = true;
                        AttackDamageTypeWidthSecondValue = 55f;
                        if (interpolationValue >= 1)
                        {
                            this.AttackDamageType.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setAttackDamageTypeXSecondValue = true;
                        AttackDamageTypeXSecondValue = 0f;
                        setAttackDamageTypeYSecondValue = true;
                        AttackDamageTypeYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.AttackSpeed.AttributeIconTypeState = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.AttackSpeed;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.AttackSpeed.AttributeText = "3 sec";
                        }
                        setAttackSpeedHeightSecondValue = true;
                        AttackSpeedHeightSecondValue = 25f;
                        if (interpolationValue >= 1)
                        {
                            this.AttackSpeed.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.AttackSpeed.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "StatsContainer");
                        }
                        setAttackSpeedTextInstanceFontScaleSecondValue = true;
                        AttackSpeedTextInstanceFontScaleSecondValue = 0.5f;
                        if (interpolationValue >= 1)
                        {
                            this.AttackSpeed.TextInstanceHorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        setAttackSpeedWidthSecondValue = true;
                        AttackSpeedWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.AttackSpeed.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setButtonContainersHeightSecondValue = true;
                        ButtonContainersHeightSecondValue = 18f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonContainers.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ButtonContainers.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "InfoContainer");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ButtonContainers.Visible = false;
                        }
                        setButtonContainersWidthSecondValue = true;
                        ButtonContainersWidthSecondValue = 72.8125f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonContainers.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setButtonContainersXSecondValue = true;
                        ButtonContainersXSecondValue = 70f;
                        setButtonContainersYSecondValue = true;
                        ButtonContainersYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonContainers.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ButtonContainers.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setButtonFrameInstanceHeightSecondValue = true;
                        ButtonFrameInstanceHeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ButtonContainers");
                        }
                        setButtonFrameInstanceWidthSecondValue = true;
                        ButtonFrameInstanceWidthSecondValue = 34.03326f;
                        setButtonFrameInstanceXSecondValue = true;
                        ButtonFrameInstanceXSecondValue = 25f;
                        setButtonFrameInstance1HeightSecondValue = true;
                        ButtonFrameInstance1HeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance1.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ButtonContainers");
                        }
                        setButtonFrameInstance1WidthSecondValue = true;
                        ButtonFrameInstance1WidthSecondValue = 34.03326f;
                        setButtonFrameInstance1XSecondValue = true;
                        ButtonFrameInstance1XSecondValue = -25f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance1.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance1.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ChildrenLayout = Gum.Managers.ChildrenLayout.Regular;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ClipsChildren = false;
                        }
                        setColoredRectangleInstanceHeightSecondValue = true;
                        ColoredRectangleInstanceHeightSecondValue = 4f;
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "NameContainer");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setCostTextBlueSecondValue = true;
                        CostTextBlueSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("CostText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setCostTextGreenSecondValue = true;
                        CostTextGreenSecondValue = 252;
                        setCostTextHeightSecondValue = true;
                        CostTextHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.CostText.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CostText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CostText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "AttackCostContainer");
                        }
                        setCostTextRedSecondValue = true;
                        CostTextRedSecondValue = 124;
                        if (interpolationValue >= 1)
                        {
                            this.CostText.Text = "20";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CostText.UseCustomFont = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CostText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setCostTextWidthSecondValue = true;
                        CostTextWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.CostText.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setCostTextXSecondValue = true;
                        CostTextXSecondValue = 1f;
                        if (interpolationValue >= 1)
                        {
                            this.CostText.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setGlowSpriteHeightSecondValue = true;
                        GlowSpriteHeightSecondValue = 120f;
                        if (interpolationValue >= 1)
                        {
                            this.GlowSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("GlowSprite.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.GlowSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setGlowSpriteTextureHeightSecondValue = true;
                        GlowSpriteTextureHeightSecondValue = 160;
                        setGlowSpriteTextureLeftSecondValue = true;
                        GlowSpriteTextureLeftSecondValue = 2435;
                        setGlowSpriteTextureTopSecondValue = true;
                        GlowSpriteTextureTopSecondValue = 601;
                        setGlowSpriteTextureWidthSecondValue = true;
                        GlowSpriteTextureWidthSecondValue = 160;
                        if (interpolationValue >= 1)
                        {
                            this.GlowSprite.Visible = false;
                        }
                        setGlowSpriteWidthSecondValue = true;
                        GlowSpriteWidthSecondValue = 120f;
                        if (interpolationValue >= 1)
                        {
                            this.GlowSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.GlowSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.GlowSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.GlowSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.GlowSprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setHeightSecondValue = true;
                        HeightSecondValue = 45f;
                        if (interpolationValue >= 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.InfoContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setInfoContainerHeightSecondValue = true;
                        InfoContainerHeightSecondValue = 96.66668f;
                        if (interpolationValue >= 1)
                        {
                            this.InfoContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setInfoContainerWidthSecondValue = true;
                        InfoContainerWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.InfoContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.InfoContainer.WrapsChildren = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MaxRange.AttributeIconTypeState = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.MaxRange;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MaxRange.AttributeText = "50";
                        }
                        setMaxRangeHeightSecondValue = true;
                        MaxRangeHeightSecondValue = 75f;
                        if (interpolationValue >= 1)
                        {
                            this.MaxRange.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MaxRange.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "RangeContainer");
                        }
                        setMaxRangeTextInstanceFontScaleSecondValue = true;
                        MaxRangeTextInstanceFontScaleSecondValue = 0.5f;
                        if (interpolationValue >= 1)
                        {
                            this.MaxRange.TextInstanceHorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        setMaxRangeWidthSecondValue = true;
                        MaxRangeWidthSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.MaxRange.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setMaxRangeYSecondValue = true;
                        MaxRangeYSecondValue = 12.5f;
                        if (interpolationValue >= 1)
                        {
                            this.MaxRange.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MinRange.AttributeIconTypeState = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.MinRange;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MinRange.AttributeText = "100";
                        }
                        setMinRangeHeightSecondValue = true;
                        MinRangeHeightSecondValue = 75f;
                        if (interpolationValue >= 1)
                        {
                            this.MinRange.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MinRange.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "RangeContainer");
                        }
                        setMinRangeTextInstanceFontScaleSecondValue = true;
                        MinRangeTextInstanceFontScaleSecondValue = 0.5f;
                        if (interpolationValue >= 1)
                        {
                            this.MinRange.TextInstanceHorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        setMinRangeWidthSecondValue = true;
                        MinRangeWidthSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.MinRange.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setMinRangeYSecondValue = true;
                        MinRangeYSecondValue = 12.5f;
                        if (interpolationValue >= 1)
                        {
                            this.MinRange.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setNameContainerHeightSecondValue = true;
                        NameContainerHeightSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.NameContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.NameContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "InfoContainer");
                        }
                        setNameContainerWidthSecondValue = true;
                        NameContainerWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.NameContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setNameContainerYSecondValue = true;
                        NameContainerYSecondValue = 3f;
                        if (interpolationValue >= 1)
                        {
                            this.NameContainer.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setNameTextBlueSecondValue = true;
                        NameTextBlueSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("NameText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.NameText.Font = "Moire ExtraBold";
                        }
                        setNameTextFontScaleSecondValue = true;
                        NameTextFontScaleSecondValue = 0.8f;
                        setNameTextFontSizeSecondValue = true;
                        NameTextFontSizeSecondValue = 50;
                        setNameTextGreenSecondValue = true;
                        NameTextGreenSecondValue = 215;
                        setNameTextHeightSecondValue = true;
                        NameTextHeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.NameText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.NameText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setNameTextOutlineThicknessSecondValue = true;
                        NameTextOutlineThicknessSecondValue = 2;
                        if (interpolationValue >= 1)
                        {
                            this.NameText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "NameContainer");
                        }
                        setNameTextRedSecondValue = true;
                        NameTextRedSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            this.NameText.Text = "Structure";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.NameText.UseCustomFont = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.NameText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.NameText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setOrTextInstanceBlueSecondValue = true;
                        OrTextInstanceBlueSecondValue = 140;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("OrTextInstance.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setOrTextInstanceFontScaleSecondValue = true;
                        OrTextInstanceFontScaleSecondValue = 0.6f;
                        setOrTextInstanceGreenSecondValue = true;
                        OrTextInstanceGreenSecondValue = 230;
                        setOrTextInstanceHeightSecondValue = true;
                        OrTextInstanceHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.OrTextInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ButtonContainers");
                        }
                        setOrTextInstanceRedSecondValue = true;
                        OrTextInstanceRedSecondValue = 240;
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
                        OrTextInstanceXSecondValue = 164f;
                        setOrTextInstanceYSecondValue = true;
                        OrTextInstanceYSecondValue = 42f;
                        if (interpolationValue >= 1)
                        {
                            this.PointOrSplash.AttributeIconTypeState = AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime.AttributeType.PointOrSplash;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PointOrSplash.AttributeText = "Single";
                        }
                        setPointOrSplashHeightSecondValue = true;
                        PointOrSplashHeightSecondValue = 25f;
                        if (interpolationValue >= 1)
                        {
                            this.PointOrSplash.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PointOrSplash.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "StatsContainer");
                        }
                        setPointOrSplashTextInstanceFontScaleSecondValue = true;
                        PointOrSplashTextInstanceFontScaleSecondValue = 0.5f;
                        if (interpolationValue >= 1)
                        {
                            this.PointOrSplash.TextInstanceHorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        setPointOrSplashWidthSecondValue = true;
                        PointOrSplashWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.PointOrSplash.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setPointsSpriteHeightSecondValue = true;
                        PointsSpriteHeightSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.PointsSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PointsSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "AttackCostContainer");
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
                        PointsSpriteXSecondValue = 15f;
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
                            this.RangeContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setRangeContainerHeightSecondValue = true;
                        RangeContainerHeightSecondValue = 25f;
                        if (interpolationValue >= 1)
                        {
                            this.RangeContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.RangeContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "StatsContainer");
                        }
                        setRangeContainerWidthSecondValue = true;
                        RangeContainerWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.RangeContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.StatsContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setStatsContainerHeightSecondValue = true;
                        StatsContainerHeightSecondValue = 60.5f;
                        if (interpolationValue >= 1)
                        {
                            this.StatsContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.StatsContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "InfoContainer");
                        }
                        setStatsContainerWidthSecondValue = true;
                        StatsContainerWidthSecondValue = 69.21875f;
                        if (interpolationValue >= 1)
                        {
                            this.StatsContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.StatsContainer.WrapsChildren = true;
                        }
                        setStatsContainerXSecondValue = true;
                        StatsContainerXSecondValue = 79f;
                        setStatsContainerYSecondValue = true;
                        StatsContainerYSecondValue = 0f;
                        setTallInfoFrameInstanceHeightSecondValue = true;
                        TallInfoFrameInstanceHeightSecondValue = 100f;
                        setTallInfoFrameInstanceWidthSecondValue = true;
                        TallInfoFrameInstanceWidthSecondValue = 100f;
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
                        UpgradeTextFontScaleSecondValue = 0.8f;
                        setUpgradeTextFontSizeSecondValue = true;
                        UpgradeTextFontSizeSecondValue = 50;
                        setUpgradeTextGreenSecondValue = true;
                        UpgradeTextGreenSecondValue = 230;
                        setUpgradeTextHeightSecondValue = true;
                        UpgradeTextHeightSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.UpgradeText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.UpgradeText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setUpgradeTextOutlineThicknessSecondValue = true;
                        UpgradeTextOutlineThicknessSecondValue = 2;
                        if (interpolationValue >= 1)
                        {
                            this.UpgradeText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "InfoContainer");
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
                            this.UpgradeText.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.UpgradeText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Visible = true;
                        }
                        setWidthSecondValue = true;
                        WidthSecondValue = 20f;
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
                            this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddleInverted;
                        }
                        break;
                }
                if (setAttackCostContainerHeightFirstValue && setAttackCostContainerHeightSecondValue)
                {
                    AttackCostContainer.Height = AttackCostContainerHeightFirstValue * (1 - interpolationValue) + AttackCostContainerHeightSecondValue * interpolationValue;
                }
                if (setAttackCostContainerWidthFirstValue && setAttackCostContainerWidthSecondValue)
                {
                    AttackCostContainer.Width = AttackCostContainerWidthFirstValue * (1 - interpolationValue) + AttackCostContainerWidthSecondValue * interpolationValue;
                }
                if (setAttackDamageTypeHeightFirstValue && setAttackDamageTypeHeightSecondValue)
                {
                    AttackDamageType.Height = AttackDamageTypeHeightFirstValue * (1 - interpolationValue) + AttackDamageTypeHeightSecondValue * interpolationValue;
                }
                if (setAttackDamageTypeTextFontScaleFirstValue && setAttackDamageTypeTextFontScaleSecondValue)
                {
                    AttackDamageType.TextFontScale = AttackDamageTypeTextFontScaleFirstValue * (1 - interpolationValue) + AttackDamageTypeTextFontScaleSecondValue * interpolationValue;
                }
                if (setAttackDamageTypeWidthFirstValue && setAttackDamageTypeWidthSecondValue)
                {
                    AttackDamageType.Width = AttackDamageTypeWidthFirstValue * (1 - interpolationValue) + AttackDamageTypeWidthSecondValue * interpolationValue;
                }
                if (setAttackDamageTypeXFirstValue && setAttackDamageTypeXSecondValue)
                {
                    AttackDamageType.X = AttackDamageTypeXFirstValue * (1 - interpolationValue) + AttackDamageTypeXSecondValue * interpolationValue;
                }
                if (setAttackDamageTypeYFirstValue && setAttackDamageTypeYSecondValue)
                {
                    AttackDamageType.Y = AttackDamageTypeYFirstValue * (1 - interpolationValue) + AttackDamageTypeYSecondValue * interpolationValue;
                }
                if (setAttackSpeedHeightFirstValue && setAttackSpeedHeightSecondValue)
                {
                    AttackSpeed.Height = AttackSpeedHeightFirstValue * (1 - interpolationValue) + AttackSpeedHeightSecondValue * interpolationValue;
                }
                if (setAttackSpeedTextInstanceFontScaleFirstValue && setAttackSpeedTextInstanceFontScaleSecondValue)
                {
                    AttackSpeed.TextInstanceFontScale = AttackSpeedTextInstanceFontScaleFirstValue * (1 - interpolationValue) + AttackSpeedTextInstanceFontScaleSecondValue * interpolationValue;
                }
                if (setAttackSpeedWidthFirstValue && setAttackSpeedWidthSecondValue)
                {
                    AttackSpeed.Width = AttackSpeedWidthFirstValue * (1 - interpolationValue) + AttackSpeedWidthSecondValue * interpolationValue;
                }
                if (setButtonContainersHeightFirstValue && setButtonContainersHeightSecondValue)
                {
                    ButtonContainers.Height = ButtonContainersHeightFirstValue * (1 - interpolationValue) + ButtonContainersHeightSecondValue * interpolationValue;
                }
                if (setButtonContainersWidthFirstValue && setButtonContainersWidthSecondValue)
                {
                    ButtonContainers.Width = ButtonContainersWidthFirstValue * (1 - interpolationValue) + ButtonContainersWidthSecondValue * interpolationValue;
                }
                if (setButtonContainersXFirstValue && setButtonContainersXSecondValue)
                {
                    ButtonContainers.X = ButtonContainersXFirstValue * (1 - interpolationValue) + ButtonContainersXSecondValue * interpolationValue;
                }
                if (setButtonContainersYFirstValue && setButtonContainersYSecondValue)
                {
                    ButtonContainers.Y = ButtonContainersYFirstValue * (1 - interpolationValue) + ButtonContainersYSecondValue * interpolationValue;
                }
                if (setButtonFrameInstanceHeightFirstValue && setButtonFrameInstanceHeightSecondValue)
                {
                    ButtonFrameInstance.Height = ButtonFrameInstanceHeightFirstValue * (1 - interpolationValue) + ButtonFrameInstanceHeightSecondValue * interpolationValue;
                }
                if (setButtonFrameInstanceWidthFirstValue && setButtonFrameInstanceWidthSecondValue)
                {
                    ButtonFrameInstance.Width = ButtonFrameInstanceWidthFirstValue * (1 - interpolationValue) + ButtonFrameInstanceWidthSecondValue * interpolationValue;
                }
                if (setButtonFrameInstanceXFirstValue && setButtonFrameInstanceXSecondValue)
                {
                    ButtonFrameInstance.X = ButtonFrameInstanceXFirstValue * (1 - interpolationValue) + ButtonFrameInstanceXSecondValue * interpolationValue;
                }
                if (setButtonFrameInstance1HeightFirstValue && setButtonFrameInstance1HeightSecondValue)
                {
                    ButtonFrameInstance1.Height = ButtonFrameInstance1HeightFirstValue * (1 - interpolationValue) + ButtonFrameInstance1HeightSecondValue * interpolationValue;
                }
                if (setButtonFrameInstance1WidthFirstValue && setButtonFrameInstance1WidthSecondValue)
                {
                    ButtonFrameInstance1.Width = ButtonFrameInstance1WidthFirstValue * (1 - interpolationValue) + ButtonFrameInstance1WidthSecondValue * interpolationValue;
                }
                if (setButtonFrameInstance1XFirstValue && setButtonFrameInstance1XSecondValue)
                {
                    ButtonFrameInstance1.X = ButtonFrameInstance1XFirstValue * (1 - interpolationValue) + ButtonFrameInstance1XSecondValue * interpolationValue;
                }
                if (setColoredRectangleInstanceHeightFirstValue && setColoredRectangleInstanceHeightSecondValue)
                {
                    ColoredRectangleInstance.Height = ColoredRectangleInstanceHeightFirstValue * (1 - interpolationValue) + ColoredRectangleInstanceHeightSecondValue * interpolationValue;
                }
                if (setCostTextBlueFirstValue && setCostTextBlueSecondValue)
                {
                    CostText.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(CostTextBlueFirstValue* (1 - interpolationValue) + CostTextBlueSecondValue * interpolationValue);
                }
                if (setCostTextGreenFirstValue && setCostTextGreenSecondValue)
                {
                    CostText.Green = FlatRedBall.Math.MathFunctions.RoundToInt(CostTextGreenFirstValue* (1 - interpolationValue) + CostTextGreenSecondValue * interpolationValue);
                }
                if (setCostTextHeightFirstValue && setCostTextHeightSecondValue)
                {
                    CostText.Height = CostTextHeightFirstValue * (1 - interpolationValue) + CostTextHeightSecondValue * interpolationValue;
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
                if (setGlowSpriteHeightFirstValue && setGlowSpriteHeightSecondValue)
                {
                    GlowSprite.Height = GlowSpriteHeightFirstValue * (1 - interpolationValue) + GlowSpriteHeightSecondValue * interpolationValue;
                }
                if (setGlowSpriteTextureHeightFirstValue && setGlowSpriteTextureHeightSecondValue)
                {
                    GlowSprite.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(GlowSpriteTextureHeightFirstValue* (1 - interpolationValue) + GlowSpriteTextureHeightSecondValue * interpolationValue);
                }
                if (setGlowSpriteTextureLeftFirstValue && setGlowSpriteTextureLeftSecondValue)
                {
                    GlowSprite.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(GlowSpriteTextureLeftFirstValue* (1 - interpolationValue) + GlowSpriteTextureLeftSecondValue * interpolationValue);
                }
                if (setGlowSpriteTextureTopFirstValue && setGlowSpriteTextureTopSecondValue)
                {
                    GlowSprite.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(GlowSpriteTextureTopFirstValue* (1 - interpolationValue) + GlowSpriteTextureTopSecondValue * interpolationValue);
                }
                if (setGlowSpriteTextureWidthFirstValue && setGlowSpriteTextureWidthSecondValue)
                {
                    GlowSprite.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(GlowSpriteTextureWidthFirstValue* (1 - interpolationValue) + GlowSpriteTextureWidthSecondValue * interpolationValue);
                }
                if (setGlowSpriteWidthFirstValue && setGlowSpriteWidthSecondValue)
                {
                    GlowSprite.Width = GlowSpriteWidthFirstValue * (1 - interpolationValue) + GlowSpriteWidthSecondValue * interpolationValue;
                }
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
                }
                if (setInfoContainerHeightFirstValue && setInfoContainerHeightSecondValue)
                {
                    InfoContainer.Height = InfoContainerHeightFirstValue * (1 - interpolationValue) + InfoContainerHeightSecondValue * interpolationValue;
                }
                if (setInfoContainerWidthFirstValue && setInfoContainerWidthSecondValue)
                {
                    InfoContainer.Width = InfoContainerWidthFirstValue * (1 - interpolationValue) + InfoContainerWidthSecondValue * interpolationValue;
                }
                if (setMaxRangeHeightFirstValue && setMaxRangeHeightSecondValue)
                {
                    MaxRange.Height = MaxRangeHeightFirstValue * (1 - interpolationValue) + MaxRangeHeightSecondValue * interpolationValue;
                }
                if (setMaxRangeTextInstanceFontScaleFirstValue && setMaxRangeTextInstanceFontScaleSecondValue)
                {
                    MaxRange.TextInstanceFontScale = MaxRangeTextInstanceFontScaleFirstValue * (1 - interpolationValue) + MaxRangeTextInstanceFontScaleSecondValue * interpolationValue;
                }
                if (setMaxRangeWidthFirstValue && setMaxRangeWidthSecondValue)
                {
                    MaxRange.Width = MaxRangeWidthFirstValue * (1 - interpolationValue) + MaxRangeWidthSecondValue * interpolationValue;
                }
                if (setMaxRangeYFirstValue && setMaxRangeYSecondValue)
                {
                    MaxRange.Y = MaxRangeYFirstValue * (1 - interpolationValue) + MaxRangeYSecondValue * interpolationValue;
                }
                if (setMinRangeHeightFirstValue && setMinRangeHeightSecondValue)
                {
                    MinRange.Height = MinRangeHeightFirstValue * (1 - interpolationValue) + MinRangeHeightSecondValue * interpolationValue;
                }
                if (setMinRangeTextInstanceFontScaleFirstValue && setMinRangeTextInstanceFontScaleSecondValue)
                {
                    MinRange.TextInstanceFontScale = MinRangeTextInstanceFontScaleFirstValue * (1 - interpolationValue) + MinRangeTextInstanceFontScaleSecondValue * interpolationValue;
                }
                if (setMinRangeWidthFirstValue && setMinRangeWidthSecondValue)
                {
                    MinRange.Width = MinRangeWidthFirstValue * (1 - interpolationValue) + MinRangeWidthSecondValue * interpolationValue;
                }
                if (setMinRangeYFirstValue && setMinRangeYSecondValue)
                {
                    MinRange.Y = MinRangeYFirstValue * (1 - interpolationValue) + MinRangeYSecondValue * interpolationValue;
                }
                if (setNameContainerHeightFirstValue && setNameContainerHeightSecondValue)
                {
                    NameContainer.Height = NameContainerHeightFirstValue * (1 - interpolationValue) + NameContainerHeightSecondValue * interpolationValue;
                }
                if (setNameContainerWidthFirstValue && setNameContainerWidthSecondValue)
                {
                    NameContainer.Width = NameContainerWidthFirstValue * (1 - interpolationValue) + NameContainerWidthSecondValue * interpolationValue;
                }
                if (setNameContainerYFirstValue && setNameContainerYSecondValue)
                {
                    NameContainer.Y = NameContainerYFirstValue * (1 - interpolationValue) + NameContainerYSecondValue * interpolationValue;
                }
                if (setNameTextBlueFirstValue && setNameTextBlueSecondValue)
                {
                    NameText.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(NameTextBlueFirstValue* (1 - interpolationValue) + NameTextBlueSecondValue * interpolationValue);
                }
                if (setNameTextFontScaleFirstValue && setNameTextFontScaleSecondValue)
                {
                    NameText.FontScale = NameTextFontScaleFirstValue * (1 - interpolationValue) + NameTextFontScaleSecondValue * interpolationValue;
                }
                if (setNameTextFontSizeFirstValue && setNameTextFontSizeSecondValue)
                {
                    NameText.FontSize = FlatRedBall.Math.MathFunctions.RoundToInt(NameTextFontSizeFirstValue* (1 - interpolationValue) + NameTextFontSizeSecondValue * interpolationValue);
                }
                if (setNameTextGreenFirstValue && setNameTextGreenSecondValue)
                {
                    NameText.Green = FlatRedBall.Math.MathFunctions.RoundToInt(NameTextGreenFirstValue* (1 - interpolationValue) + NameTextGreenSecondValue * interpolationValue);
                }
                if (setNameTextHeightFirstValue && setNameTextHeightSecondValue)
                {
                    NameText.Height = NameTextHeightFirstValue * (1 - interpolationValue) + NameTextHeightSecondValue * interpolationValue;
                }
                if (setNameTextOutlineThicknessFirstValue && setNameTextOutlineThicknessSecondValue)
                {
                    NameText.OutlineThickness = FlatRedBall.Math.MathFunctions.RoundToInt(NameTextOutlineThicknessFirstValue* (1 - interpolationValue) + NameTextOutlineThicknessSecondValue * interpolationValue);
                }
                if (setNameTextRedFirstValue && setNameTextRedSecondValue)
                {
                    NameText.Red = FlatRedBall.Math.MathFunctions.RoundToInt(NameTextRedFirstValue* (1 - interpolationValue) + NameTextRedSecondValue * interpolationValue);
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
                if (setPointOrSplashHeightFirstValue && setPointOrSplashHeightSecondValue)
                {
                    PointOrSplash.Height = PointOrSplashHeightFirstValue * (1 - interpolationValue) + PointOrSplashHeightSecondValue * interpolationValue;
                }
                if (setPointOrSplashTextInstanceFontScaleFirstValue && setPointOrSplashTextInstanceFontScaleSecondValue)
                {
                    PointOrSplash.TextInstanceFontScale = PointOrSplashTextInstanceFontScaleFirstValue * (1 - interpolationValue) + PointOrSplashTextInstanceFontScaleSecondValue * interpolationValue;
                }
                if (setPointOrSplashWidthFirstValue && setPointOrSplashWidthSecondValue)
                {
                    PointOrSplash.Width = PointOrSplashWidthFirstValue * (1 - interpolationValue) + PointOrSplashWidthSecondValue * interpolationValue;
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
                if (setRangeContainerHeightFirstValue && setRangeContainerHeightSecondValue)
                {
                    RangeContainer.Height = RangeContainerHeightFirstValue * (1 - interpolationValue) + RangeContainerHeightSecondValue * interpolationValue;
                }
                if (setRangeContainerWidthFirstValue && setRangeContainerWidthSecondValue)
                {
                    RangeContainer.Width = RangeContainerWidthFirstValue * (1 - interpolationValue) + RangeContainerWidthSecondValue * interpolationValue;
                }
                if (setStatsContainerHeightFirstValue && setStatsContainerHeightSecondValue)
                {
                    StatsContainer.Height = StatsContainerHeightFirstValue * (1 - interpolationValue) + StatsContainerHeightSecondValue * interpolationValue;
                }
                if (setStatsContainerWidthFirstValue && setStatsContainerWidthSecondValue)
                {
                    StatsContainer.Width = StatsContainerWidthFirstValue * (1 - interpolationValue) + StatsContainerWidthSecondValue * interpolationValue;
                }
                if (setStatsContainerXFirstValue && setStatsContainerXSecondValue)
                {
                    StatsContainer.X = StatsContainerXFirstValue * (1 - interpolationValue) + StatsContainerXSecondValue * interpolationValue;
                }
                if (setStatsContainerYFirstValue && setStatsContainerYSecondValue)
                {
                    StatsContainer.Y = StatsContainerYFirstValue * (1 - interpolationValue) + StatsContainerYSecondValue * interpolationValue;
                }
                if (setTallInfoFrameInstanceHeightFirstValue && setTallInfoFrameInstanceHeightSecondValue)
                {
                    TallInfoFrameInstance.Height = TallInfoFrameInstanceHeightFirstValue * (1 - interpolationValue) + TallInfoFrameInstanceHeightSecondValue * interpolationValue;
                }
                if (setTallInfoFrameInstanceWidthFirstValue && setTallInfoFrameInstanceWidthSecondValue)
                {
                    TallInfoFrameInstance.Width = TallInfoFrameInstanceWidthFirstValue * (1 - interpolationValue) + TallInfoFrameInstanceWidthSecondValue * interpolationValue;
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
            public void InterpolateBetween (UpgradeAvailability firstState, UpgradeAvailability secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                switch(firstState)
                {
                    case  UpgradeAvailability.Available:
                        if (interpolationValue < 1)
                        {
                            this.ButtonContainers.Visible = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.UpgradeText.Visible = true;
                        }
                        break;
                    case  UpgradeAvailability.NotAvailable:
                        if (interpolationValue < 1)
                        {
                            this.ButtonContainers.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.UpgradeText.Visible = false;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  UpgradeAvailability.Available:
                        if (interpolationValue >= 1)
                        {
                            this.ButtonContainers.Visible = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.UpgradeText.Visible = true;
                        }
                        break;
                    case  UpgradeAvailability.NotAvailable:
                        if (interpolationValue >= 1)
                        {
                            this.ButtonContainers.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.UpgradeText.Visible = false;
                        }
                        break;
                }
                if (interpolationValue < 1)
                {
                    mCurrentUpgradeAvailabilityState = firstState;
                }
                else
                {
                    mCurrentUpgradeAvailabilityState = secondState;
                }
            }
            public void InterpolateBetween (Selection firstState, Selection secondState, float interpolationValue) 
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
                bool setColoredRectangleInstanceRedFirstValue = false;
                bool setColoredRectangleInstanceRedSecondValue = false;
                int ColoredRectangleInstanceRedFirstValue= 0;
                int ColoredRectangleInstanceRedSecondValue= 0;
                bool setGlowSpriteBlueFirstValue = false;
                bool setGlowSpriteBlueSecondValue = false;
                int GlowSpriteBlueFirstValue= 0;
                int GlowSpriteBlueSecondValue= 0;
                bool setGlowSpriteRedFirstValue = false;
                bool setGlowSpriteRedSecondValue = false;
                int GlowSpriteRedFirstValue= 0;
                int GlowSpriteRedSecondValue= 0;
                bool setNameTextAlphaFirstValue = false;
                bool setNameTextAlphaSecondValue = false;
                int NameTextAlphaFirstValue= 0;
                int NameTextAlphaSecondValue= 0;
                bool setNameTextBlueFirstValue = false;
                bool setNameTextBlueSecondValue = false;
                int NameTextBlueFirstValue= 0;
                int NameTextBlueSecondValue= 0;
                bool setNameTextGreenFirstValue = false;
                bool setNameTextGreenSecondValue = false;
                int NameTextGreenFirstValue= 0;
                int NameTextGreenSecondValue= 0;
                bool setNameTextRedFirstValue = false;
                bool setNameTextRedSecondValue = false;
                int NameTextRedFirstValue= 0;
                int NameTextRedSecondValue= 0;
                switch(firstState)
                {
                    case  Selection.Selected:
                        setColoredRectangleInstanceAlphaFirstValue = true;
                        ColoredRectangleInstanceAlphaFirstValue = 255;
                        setColoredRectangleInstanceBlueFirstValue = true;
                        ColoredRectangleInstanceBlueFirstValue = 0;
                        setColoredRectangleInstanceGreenFirstValue = true;
                        ColoredRectangleInstanceGreenFirstValue = 252;
                        setColoredRectangleInstanceRedFirstValue = true;
                        ColoredRectangleInstanceRedFirstValue = 124;
                        setGlowSpriteBlueFirstValue = true;
                        GlowSpriteBlueFirstValue = 0;
                        setGlowSpriteRedFirstValue = true;
                        GlowSpriteRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.GlowSprite.Visible = true;
                        }
                        setNameTextAlphaFirstValue = true;
                        NameTextAlphaFirstValue = 255;
                        setNameTextBlueFirstValue = true;
                        NameTextBlueFirstValue = 47;
                        setNameTextGreenFirstValue = true;
                        NameTextGreenFirstValue = 255;
                        setNameTextRedFirstValue = true;
                        NameTextRedFirstValue = 173;
                        break;
                    case  Selection.NotSelected:
                        setColoredRectangleInstanceAlphaFirstValue = true;
                        ColoredRectangleInstanceAlphaFirstValue = 150;
                        setColoredRectangleInstanceBlueFirstValue = true;
                        ColoredRectangleInstanceBlueFirstValue = 0;
                        setColoredRectangleInstanceGreenFirstValue = true;
                        ColoredRectangleInstanceGreenFirstValue = 165;
                        setColoredRectangleInstanceRedFirstValue = true;
                        ColoredRectangleInstanceRedFirstValue = 255;
                        setGlowSpriteBlueFirstValue = true;
                        GlowSpriteBlueFirstValue = 255;
                        setGlowSpriteRedFirstValue = true;
                        GlowSpriteRedFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            this.GlowSprite.Visible = false;
                        }
                        setNameTextAlphaFirstValue = true;
                        NameTextAlphaFirstValue = 150;
                        setNameTextBlueFirstValue = true;
                        NameTextBlueFirstValue = 0;
                        setNameTextGreenFirstValue = true;
                        NameTextGreenFirstValue = 165;
                        setNameTextRedFirstValue = true;
                        NameTextRedFirstValue = 255;
                        break;
                }
                switch(secondState)
                {
                    case  Selection.Selected:
                        setColoredRectangleInstanceAlphaSecondValue = true;
                        ColoredRectangleInstanceAlphaSecondValue = 255;
                        setColoredRectangleInstanceBlueSecondValue = true;
                        ColoredRectangleInstanceBlueSecondValue = 0;
                        setColoredRectangleInstanceGreenSecondValue = true;
                        ColoredRectangleInstanceGreenSecondValue = 252;
                        setColoredRectangleInstanceRedSecondValue = true;
                        ColoredRectangleInstanceRedSecondValue = 124;
                        setGlowSpriteBlueSecondValue = true;
                        GlowSpriteBlueSecondValue = 0;
                        setGlowSpriteRedSecondValue = true;
                        GlowSpriteRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.GlowSprite.Visible = true;
                        }
                        setNameTextAlphaSecondValue = true;
                        NameTextAlphaSecondValue = 255;
                        setNameTextBlueSecondValue = true;
                        NameTextBlueSecondValue = 47;
                        setNameTextGreenSecondValue = true;
                        NameTextGreenSecondValue = 255;
                        setNameTextRedSecondValue = true;
                        NameTextRedSecondValue = 173;
                        break;
                    case  Selection.NotSelected:
                        setColoredRectangleInstanceAlphaSecondValue = true;
                        ColoredRectangleInstanceAlphaSecondValue = 150;
                        setColoredRectangleInstanceBlueSecondValue = true;
                        ColoredRectangleInstanceBlueSecondValue = 0;
                        setColoredRectangleInstanceGreenSecondValue = true;
                        ColoredRectangleInstanceGreenSecondValue = 165;
                        setColoredRectangleInstanceRedSecondValue = true;
                        ColoredRectangleInstanceRedSecondValue = 255;
                        setGlowSpriteBlueSecondValue = true;
                        GlowSpriteBlueSecondValue = 255;
                        setGlowSpriteRedSecondValue = true;
                        GlowSpriteRedSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            this.GlowSprite.Visible = false;
                        }
                        setNameTextAlphaSecondValue = true;
                        NameTextAlphaSecondValue = 150;
                        setNameTextBlueSecondValue = true;
                        NameTextBlueSecondValue = 0;
                        setNameTextGreenSecondValue = true;
                        NameTextGreenSecondValue = 165;
                        setNameTextRedSecondValue = true;
                        NameTextRedSecondValue = 255;
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
                if (setColoredRectangleInstanceRedFirstValue && setColoredRectangleInstanceRedSecondValue)
                {
                    ColoredRectangleInstance.Red = FlatRedBall.Math.MathFunctions.RoundToInt(ColoredRectangleInstanceRedFirstValue* (1 - interpolationValue) + ColoredRectangleInstanceRedSecondValue * interpolationValue);
                }
                if (setGlowSpriteBlueFirstValue && setGlowSpriteBlueSecondValue)
                {
                    GlowSprite.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(GlowSpriteBlueFirstValue* (1 - interpolationValue) + GlowSpriteBlueSecondValue * interpolationValue);
                }
                if (setGlowSpriteRedFirstValue && setGlowSpriteRedSecondValue)
                {
                    GlowSprite.Red = FlatRedBall.Math.MathFunctions.RoundToInt(GlowSpriteRedFirstValue* (1 - interpolationValue) + GlowSpriteRedSecondValue * interpolationValue);
                }
                if (setNameTextAlphaFirstValue && setNameTextAlphaSecondValue)
                {
                    NameText.Alpha = FlatRedBall.Math.MathFunctions.RoundToInt(NameTextAlphaFirstValue* (1 - interpolationValue) + NameTextAlphaSecondValue * interpolationValue);
                }
                if (setNameTextBlueFirstValue && setNameTextBlueSecondValue)
                {
                    NameText.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(NameTextBlueFirstValue* (1 - interpolationValue) + NameTextBlueSecondValue * interpolationValue);
                }
                if (setNameTextGreenFirstValue && setNameTextGreenSecondValue)
                {
                    NameText.Green = FlatRedBall.Math.MathFunctions.RoundToInt(NameTextGreenFirstValue* (1 - interpolationValue) + NameTextGreenSecondValue * interpolationValue);
                }
                if (setNameTextRedFirstValue && setNameTextRedSecondValue)
                {
                    NameText.Red = FlatRedBall.Math.MathFunctions.RoundToInt(NameTextRedFirstValue* (1 - interpolationValue) + NameTextRedSecondValue * interpolationValue);
                }
                if (interpolationValue < 1)
                {
                    mCurrentSelectionState = firstState;
                }
                else
                {
                    mCurrentSelectionState = secondState;
                }
            }
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.StructureInfoRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.StructureInfoRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.StructureInfoRuntime.UpgradeAvailability fromState,AbbatoirIntergrade.GumRuntimes.StructureInfoRuntime.UpgradeAvailability toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (UpgradeAvailability toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "UpgradeAvailability").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentUpgradeAvailabilityState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (UpgradeAvailability toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentUpgradeAvailabilityState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.StructureInfoRuntime.Selection fromState,AbbatoirIntergrade.GumRuntimes.StructureInfoRuntime.Selection toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Selection toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "Selection").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentSelectionState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (Selection toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentSelectionState = toState;
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
                TallInfoFrameInstance.StopAnimations();
                AttackDamageType.StopAnimations();
                MinRange.StopAnimations();
                MaxRange.StopAnimations();
                AttackSpeed.StopAnimations();
                PointOrSplash.StopAnimations();
                ButtonFrameInstance.StopAnimations();
                ButtonFrameInstance1.StopAnimations();
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
                            Name = "GlowSprite.Height",
                            Type = "float",
                            Value = GlowSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlowSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = GlowSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlowSprite.SourceFile",
                            Type = "string",
                            Value = GlowSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlowSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = GlowSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlowSprite.Texture Height",
                            Type = "int",
                            Value = GlowSprite.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlowSprite.Texture Left",
                            Type = "int",
                            Value = GlowSprite.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlowSprite.Texture Top",
                            Type = "int",
                            Value = GlowSprite.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlowSprite.Texture Width",
                            Type = "int",
                            Value = GlowSprite.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlowSprite.Visible",
                            Type = "bool",
                            Value = GlowSprite.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlowSprite.Width",
                            Type = "float",
                            Value = GlowSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlowSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = GlowSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlowSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = GlowSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlowSprite.X Units",
                            Type = "PositionUnitType",
                            Value = GlowSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlowSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = GlowSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlowSprite.Y Units",
                            Type = "PositionUnitType",
                            Value = GlowSprite.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameContainer.Height",
                            Type = "float",
                            Value = NameContainer.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = NameContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameContainer.Parent",
                            Type = "string",
                            Value = NameContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameContainer.Width",
                            Type = "float",
                            Value = NameContainer.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = NameContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameContainer.Y",
                            Type = "float",
                            Value = NameContainer.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameContainer.Y Units",
                            Type = "PositionUnitType",
                            Value = NameContainer.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Blue",
                            Type = "int",
                            Value = NameText.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.CustomFontFile",
                            Type = "string",
                            Value = NameText.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Font",
                            Type = "string",
                            Value = NameText.Font
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Font Scale",
                            Type = "float",
                            Value = NameText.FontScale
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.FontSize",
                            Type = "int",
                            Value = NameText.FontSize
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Green",
                            Type = "int",
                            Value = NameText.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Height",
                            Type = "float",
                            Value = NameText.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Height Units",
                            Type = "DimensionUnitType",
                            Value = NameText.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = NameText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.OutlineThickness",
                            Type = "int",
                            Value = NameText.OutlineThickness
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Parent",
                            Type = "string",
                            Value = NameText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Red",
                            Type = "int",
                            Value = NameText.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Text",
                            Type = "string",
                            Value = NameText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.UseCustomFont",
                            Type = "bool",
                            Value = NameText.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = NameText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Width Units",
                            Type = "DimensionUnitType",
                            Value = NameText.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TallInfoFrameInstance.Height",
                            Type = "float",
                            Value = TallInfoFrameInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TallInfoFrameInstance.Width",
                            Type = "float",
                            Value = TallInfoFrameInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StatsContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = StatsContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StatsContainer.Height",
                            Type = "float",
                            Value = StatsContainer.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StatsContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = StatsContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StatsContainer.Parent",
                            Type = "string",
                            Value = StatsContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StatsContainer.Width",
                            Type = "float",
                            Value = StatsContainer.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StatsContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = StatsContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StatsContainer.Wraps Children",
                            Type = "bool",
                            Value = StatsContainer.WrapsChildren
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StatsContainer.X",
                            Type = "float",
                            Value = StatsContainer.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StatsContainer.Y",
                            Type = "float",
                            Value = StatsContainer.Y
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
                            Name = "UpgradeText.Width Units",
                            Type = "DimensionUnitType",
                            Value = UpgradeText.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonContainers.Height",
                            Type = "float",
                            Value = ButtonContainers.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonContainers.Height Units",
                            Type = "DimensionUnitType",
                            Value = ButtonContainers.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonContainers.Parent",
                            Type = "string",
                            Value = ButtonContainers.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonContainers.Visible",
                            Type = "bool",
                            Value = ButtonContainers.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonContainers.Width",
                            Type = "float",
                            Value = ButtonContainers.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonContainers.Width Units",
                            Type = "DimensionUnitType",
                            Value = ButtonContainers.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonContainers.X",
                            Type = "float",
                            Value = ButtonContainers.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonContainers.Y",
                            Type = "float",
                            Value = ButtonContainers.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonContainers.Y Origin",
                            Type = "VerticalAlignment",
                            Value = ButtonContainers.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonContainers.Y Units",
                            Type = "PositionUnitType",
                            Value = ButtonContainers.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InfoContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = InfoContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InfoContainer.Height",
                            Type = "float",
                            Value = InfoContainer.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InfoContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = InfoContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InfoContainer.Width",
                            Type = "float",
                            Value = InfoContainer.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InfoContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = InfoContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InfoContainer.Wraps Children",
                            Type = "bool",
                            Value = InfoContainer.WrapsChildren
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
                            Name = "ColoredRectangleInstance.Parent",
                            Type = "string",
                            Value = ColoredRectangleInstance.Parent
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
                            Name = "AttackDamageType.DamageTypeIconState",
                            Type = "DamageTypeState",
                            Value = AttackDamageType.DamageTypeIconState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttackDamageType.Height",
                            Type = "float",
                            Value = AttackDamageType.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttackDamageType.Height Units",
                            Type = "DimensionUnitType",
                            Value = AttackDamageType.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttackDamageType.Parent",
                            Type = "string",
                            Value = AttackDamageType.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttackDamageType.ResistanceText",
                            Type = "string",
                            Value = AttackDamageType.ResistanceText
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttackDamageType.TextFontScale",
                            Type = "float",
                            Value = AttackDamageType.TextFontScale
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttackDamageType.TextHorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = AttackDamageType.TextHorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttackDamageType.Width",
                            Type = "float",
                            Value = AttackDamageType.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttackDamageType.Width Units",
                            Type = "DimensionUnitType",
                            Value = AttackDamageType.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttackDamageType.X",
                            Type = "float",
                            Value = AttackDamageType.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttackDamageType.Y",
                            Type = "float",
                            Value = AttackDamageType.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MinRange.AttributeIconTypeState",
                            Type = "AttributeTypeState",
                            Value = MinRange.AttributeIconTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MinRange.AttributeText",
                            Type = "string",
                            Value = MinRange.AttributeText
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MinRange.Height",
                            Type = "float",
                            Value = MinRange.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MinRange.Height Units",
                            Type = "DimensionUnitType",
                            Value = MinRange.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MinRange.Parent",
                            Type = "string",
                            Value = MinRange.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MinRange.TextInstanceFontScale",
                            Type = "float",
                            Value = MinRange.TextInstanceFontScale
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MinRange.TextInstanceHorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = MinRange.TextInstanceHorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MinRange.Width",
                            Type = "float",
                            Value = MinRange.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MinRange.Width Units",
                            Type = "DimensionUnitType",
                            Value = MinRange.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MinRange.Y",
                            Type = "float",
                            Value = MinRange.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MinRange.Y Units",
                            Type = "PositionUnitType",
                            Value = MinRange.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MaxRange.AttributeIconTypeState",
                            Type = "AttributeTypeState",
                            Value = MaxRange.AttributeIconTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MaxRange.AttributeText",
                            Type = "string",
                            Value = MaxRange.AttributeText
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MaxRange.Height",
                            Type = "float",
                            Value = MaxRange.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MaxRange.Height Units",
                            Type = "DimensionUnitType",
                            Value = MaxRange.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MaxRange.Parent",
                            Type = "string",
                            Value = MaxRange.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MaxRange.TextInstanceFontScale",
                            Type = "float",
                            Value = MaxRange.TextInstanceFontScale
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MaxRange.TextInstanceHorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = MaxRange.TextInstanceHorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MaxRange.Width",
                            Type = "float",
                            Value = MaxRange.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MaxRange.Width Units",
                            Type = "DimensionUnitType",
                            Value = MaxRange.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MaxRange.Y",
                            Type = "float",
                            Value = MaxRange.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MaxRange.Y Units",
                            Type = "PositionUnitType",
                            Value = MaxRange.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttackCostContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = AttackCostContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttackCostContainer.Height",
                            Type = "float",
                            Value = AttackCostContainer.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttackCostContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = AttackCostContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttackCostContainer.Parent",
                            Type = "string",
                            Value = AttackCostContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttackCostContainer.Width",
                            Type = "float",
                            Value = AttackCostContainer.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttackCostContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = AttackCostContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangeContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = RangeContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangeContainer.Height",
                            Type = "float",
                            Value = RangeContainer.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangeContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = RangeContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangeContainer.Parent",
                            Type = "string",
                            Value = RangeContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangeContainer.Width",
                            Type = "float",
                            Value = RangeContainer.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangeContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = RangeContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttackSpeed.AttributeIconTypeState",
                            Type = "AttributeTypeState",
                            Value = AttackSpeed.AttributeIconTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttackSpeed.AttributeText",
                            Type = "string",
                            Value = AttackSpeed.AttributeText
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttackSpeed.Height",
                            Type = "float",
                            Value = AttackSpeed.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttackSpeed.Height Units",
                            Type = "DimensionUnitType",
                            Value = AttackSpeed.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttackSpeed.Parent",
                            Type = "string",
                            Value = AttackSpeed.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttackSpeed.TextInstanceFontScale",
                            Type = "float",
                            Value = AttackSpeed.TextInstanceFontScale
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttackSpeed.TextInstanceHorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = AttackSpeed.TextInstanceHorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttackSpeed.Width",
                            Type = "float",
                            Value = AttackSpeed.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttackSpeed.Width Units",
                            Type = "DimensionUnitType",
                            Value = AttackSpeed.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointOrSplash.AttributeIconTypeState",
                            Type = "AttributeTypeState",
                            Value = PointOrSplash.AttributeIconTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointOrSplash.AttributeText",
                            Type = "string",
                            Value = PointOrSplash.AttributeText
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointOrSplash.Height",
                            Type = "float",
                            Value = PointOrSplash.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointOrSplash.Height Units",
                            Type = "DimensionUnitType",
                            Value = PointOrSplash.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointOrSplash.Parent",
                            Type = "string",
                            Value = PointOrSplash.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointOrSplash.TextInstanceFontScale",
                            Type = "float",
                            Value = PointOrSplash.TextInstanceFontScale
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointOrSplash.TextInstanceHorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = PointOrSplash.TextInstanceHorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointOrSplash.Width",
                            Type = "float",
                            Value = PointOrSplash.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointOrSplash.Width Units",
                            Type = "DimensionUnitType",
                            Value = PointOrSplash.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance.Height",
                            Type = "float",
                            Value = ButtonFrameInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance.Parent",
                            Type = "string",
                            Value = ButtonFrameInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance.Width",
                            Type = "float",
                            Value = ButtonFrameInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance.X",
                            Type = "float",
                            Value = ButtonFrameInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance1.Height",
                            Type = "float",
                            Value = ButtonFrameInstance1.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance1.Parent",
                            Type = "string",
                            Value = ButtonFrameInstance1.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance1.Width",
                            Type = "float",
                            Value = ButtonFrameInstance1.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance1.X",
                            Type = "float",
                            Value = ButtonFrameInstance1.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance1.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ButtonFrameInstance1.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance1.X Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance1.XUnits
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
                            Name = "OrTextInstance.Y",
                            Type = "float",
                            Value = OrTextInstance.Y
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
                            Name = "CostText.X Units",
                            Type = "PositionUnitType",
                            Value = CostText.XUnits
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
                            Value = Height + 45f
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
                            Value = Width + 20f
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
                            Name = "GlowSprite.Height",
                            Type = "float",
                            Value = GlowSprite.Height + 120f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlowSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = GlowSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlowSprite.SourceFile",
                            Type = "string",
                            Value = GlowSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlowSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = GlowSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlowSprite.Texture Height",
                            Type = "int",
                            Value = GlowSprite.TextureHeight + 160
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlowSprite.Texture Left",
                            Type = "int",
                            Value = GlowSprite.TextureLeft + 2435
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlowSprite.Texture Top",
                            Type = "int",
                            Value = GlowSprite.TextureTop + 601
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlowSprite.Texture Width",
                            Type = "int",
                            Value = GlowSprite.TextureWidth + 160
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlowSprite.Visible",
                            Type = "bool",
                            Value = GlowSprite.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlowSprite.Width",
                            Type = "float",
                            Value = GlowSprite.Width + 120f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlowSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = GlowSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlowSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = GlowSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlowSprite.X Units",
                            Type = "PositionUnitType",
                            Value = GlowSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlowSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = GlowSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlowSprite.Y Units",
                            Type = "PositionUnitType",
                            Value = GlowSprite.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameContainer.Height",
                            Type = "float",
                            Value = NameContainer.Height + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = NameContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameContainer.Parent",
                            Type = "string",
                            Value = NameContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameContainer.Width",
                            Type = "float",
                            Value = NameContainer.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = NameContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameContainer.Y",
                            Type = "float",
                            Value = NameContainer.Y + 3f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameContainer.Y Units",
                            Type = "PositionUnitType",
                            Value = NameContainer.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Blue",
                            Type = "int",
                            Value = NameText.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.CustomFontFile",
                            Type = "string",
                            Value = NameText.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Font",
                            Type = "string",
                            Value = NameText.Font
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Font Scale",
                            Type = "float",
                            Value = NameText.FontScale + 0.8f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.FontSize",
                            Type = "int",
                            Value = NameText.FontSize + 50
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Green",
                            Type = "int",
                            Value = NameText.Green + 215
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Height",
                            Type = "float",
                            Value = NameText.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Height Units",
                            Type = "DimensionUnitType",
                            Value = NameText.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = NameText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.OutlineThickness",
                            Type = "int",
                            Value = NameText.OutlineThickness + 2
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Parent",
                            Type = "string",
                            Value = NameText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Red",
                            Type = "int",
                            Value = NameText.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Text",
                            Type = "string",
                            Value = NameText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.UseCustomFont",
                            Type = "bool",
                            Value = NameText.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = NameText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Width Units",
                            Type = "DimensionUnitType",
                            Value = NameText.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TallInfoFrameInstance.Height",
                            Type = "float",
                            Value = TallInfoFrameInstance.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TallInfoFrameInstance.Width",
                            Type = "float",
                            Value = TallInfoFrameInstance.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StatsContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = StatsContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StatsContainer.Height",
                            Type = "float",
                            Value = StatsContainer.Height + 60.5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StatsContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = StatsContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StatsContainer.Parent",
                            Type = "string",
                            Value = StatsContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StatsContainer.Width",
                            Type = "float",
                            Value = StatsContainer.Width + 69.21875f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StatsContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = StatsContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StatsContainer.Wraps Children",
                            Type = "bool",
                            Value = StatsContainer.WrapsChildren
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StatsContainer.X",
                            Type = "float",
                            Value = StatsContainer.X + 79f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StatsContainer.Y",
                            Type = "float",
                            Value = StatsContainer.Y + 0f
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
                            Value = UpgradeText.FontScale + 0.8f
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
                            Value = UpgradeText.Height + 10f
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
                            Name = "UpgradeText.Width Units",
                            Type = "DimensionUnitType",
                            Value = UpgradeText.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonContainers.Height",
                            Type = "float",
                            Value = ButtonContainers.Height + 18f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonContainers.Height Units",
                            Type = "DimensionUnitType",
                            Value = ButtonContainers.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonContainers.Parent",
                            Type = "string",
                            Value = ButtonContainers.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonContainers.Visible",
                            Type = "bool",
                            Value = ButtonContainers.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonContainers.Width",
                            Type = "float",
                            Value = ButtonContainers.Width + 72.8125f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonContainers.Width Units",
                            Type = "DimensionUnitType",
                            Value = ButtonContainers.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonContainers.X",
                            Type = "float",
                            Value = ButtonContainers.X + 70f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonContainers.Y",
                            Type = "float",
                            Value = ButtonContainers.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonContainers.Y Origin",
                            Type = "VerticalAlignment",
                            Value = ButtonContainers.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonContainers.Y Units",
                            Type = "PositionUnitType",
                            Value = ButtonContainers.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InfoContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = InfoContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InfoContainer.Height",
                            Type = "float",
                            Value = InfoContainer.Height + 96.66668f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InfoContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = InfoContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InfoContainer.Width",
                            Type = "float",
                            Value = InfoContainer.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InfoContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = InfoContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InfoContainer.Wraps Children",
                            Type = "bool",
                            Value = InfoContainer.WrapsChildren
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Height",
                            Type = "float",
                            Value = ColoredRectangleInstance.Height + 4f
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
                            Name = "ColoredRectangleInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = ColoredRectangleInstance.WidthUnits
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
                            Name = "AttackDamageType.DamageTypeIconState",
                            Type = "DamageTypeState",
                            Value = AttackDamageType.DamageTypeIconState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttackDamageType.Height",
                            Type = "float",
                            Value = AttackDamageType.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttackDamageType.Height Units",
                            Type = "DimensionUnitType",
                            Value = AttackDamageType.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttackDamageType.Parent",
                            Type = "string",
                            Value = AttackDamageType.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttackDamageType.ResistanceText",
                            Type = "string",
                            Value = AttackDamageType.ResistanceText
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttackDamageType.TextFontScale",
                            Type = "float",
                            Value = AttackDamageType.TextFontScale + 1f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttackDamageType.TextHorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = AttackDamageType.TextHorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttackDamageType.Width",
                            Type = "float",
                            Value = AttackDamageType.Width + 55f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttackDamageType.Width Units",
                            Type = "DimensionUnitType",
                            Value = AttackDamageType.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttackDamageType.X",
                            Type = "float",
                            Value = AttackDamageType.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttackDamageType.Y",
                            Type = "float",
                            Value = AttackDamageType.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MinRange.AttributeIconTypeState",
                            Type = "AttributeTypeState",
                            Value = MinRange.AttributeIconTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MinRange.AttributeText",
                            Type = "string",
                            Value = MinRange.AttributeText
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MinRange.Height",
                            Type = "float",
                            Value = MinRange.Height + 75f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MinRange.Height Units",
                            Type = "DimensionUnitType",
                            Value = MinRange.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MinRange.Parent",
                            Type = "string",
                            Value = MinRange.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MinRange.TextInstanceFontScale",
                            Type = "float",
                            Value = MinRange.TextInstanceFontScale + 0.5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MinRange.TextInstanceHorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = MinRange.TextInstanceHorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MinRange.Width",
                            Type = "float",
                            Value = MinRange.Width + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MinRange.Width Units",
                            Type = "DimensionUnitType",
                            Value = MinRange.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MinRange.Y",
                            Type = "float",
                            Value = MinRange.Y + 12.5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MinRange.Y Units",
                            Type = "PositionUnitType",
                            Value = MinRange.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MaxRange.AttributeIconTypeState",
                            Type = "AttributeTypeState",
                            Value = MaxRange.AttributeIconTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MaxRange.AttributeText",
                            Type = "string",
                            Value = MaxRange.AttributeText
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MaxRange.Height",
                            Type = "float",
                            Value = MaxRange.Height + 75f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MaxRange.Height Units",
                            Type = "DimensionUnitType",
                            Value = MaxRange.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MaxRange.Parent",
                            Type = "string",
                            Value = MaxRange.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MaxRange.TextInstanceFontScale",
                            Type = "float",
                            Value = MaxRange.TextInstanceFontScale + 0.5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MaxRange.TextInstanceHorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = MaxRange.TextInstanceHorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MaxRange.Width",
                            Type = "float",
                            Value = MaxRange.Width + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MaxRange.Width Units",
                            Type = "DimensionUnitType",
                            Value = MaxRange.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MaxRange.Y",
                            Type = "float",
                            Value = MaxRange.Y + 12.5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MaxRange.Y Units",
                            Type = "PositionUnitType",
                            Value = MaxRange.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttackCostContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = AttackCostContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttackCostContainer.Height",
                            Type = "float",
                            Value = AttackCostContainer.Height + 25f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttackCostContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = AttackCostContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttackCostContainer.Parent",
                            Type = "string",
                            Value = AttackCostContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttackCostContainer.Width",
                            Type = "float",
                            Value = AttackCostContainer.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttackCostContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = AttackCostContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangeContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = RangeContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangeContainer.Height",
                            Type = "float",
                            Value = RangeContainer.Height + 25f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangeContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = RangeContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangeContainer.Parent",
                            Type = "string",
                            Value = RangeContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangeContainer.Width",
                            Type = "float",
                            Value = RangeContainer.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RangeContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = RangeContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttackSpeed.AttributeIconTypeState",
                            Type = "AttributeTypeState",
                            Value = AttackSpeed.AttributeIconTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttackSpeed.AttributeText",
                            Type = "string",
                            Value = AttackSpeed.AttributeText
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttackSpeed.Height",
                            Type = "float",
                            Value = AttackSpeed.Height + 25f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttackSpeed.Height Units",
                            Type = "DimensionUnitType",
                            Value = AttackSpeed.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttackSpeed.Parent",
                            Type = "string",
                            Value = AttackSpeed.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttackSpeed.TextInstanceFontScale",
                            Type = "float",
                            Value = AttackSpeed.TextInstanceFontScale + 0.5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttackSpeed.TextInstanceHorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = AttackSpeed.TextInstanceHorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttackSpeed.Width",
                            Type = "float",
                            Value = AttackSpeed.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttackSpeed.Width Units",
                            Type = "DimensionUnitType",
                            Value = AttackSpeed.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointOrSplash.AttributeIconTypeState",
                            Type = "AttributeTypeState",
                            Value = PointOrSplash.AttributeIconTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointOrSplash.AttributeText",
                            Type = "string",
                            Value = PointOrSplash.AttributeText
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointOrSplash.Height",
                            Type = "float",
                            Value = PointOrSplash.Height + 25f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointOrSplash.Height Units",
                            Type = "DimensionUnitType",
                            Value = PointOrSplash.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointOrSplash.Parent",
                            Type = "string",
                            Value = PointOrSplash.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointOrSplash.TextInstanceFontScale",
                            Type = "float",
                            Value = PointOrSplash.TextInstanceFontScale + 0.5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointOrSplash.TextInstanceHorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = PointOrSplash.TextInstanceHorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointOrSplash.Width",
                            Type = "float",
                            Value = PointOrSplash.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointOrSplash.Width Units",
                            Type = "DimensionUnitType",
                            Value = PointOrSplash.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance.Height",
                            Type = "float",
                            Value = ButtonFrameInstance.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance.Parent",
                            Type = "string",
                            Value = ButtonFrameInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance.Width",
                            Type = "float",
                            Value = ButtonFrameInstance.Width + 34.03326f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance.X",
                            Type = "float",
                            Value = ButtonFrameInstance.X + 25f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance1.Height",
                            Type = "float",
                            Value = ButtonFrameInstance1.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance1.Parent",
                            Type = "string",
                            Value = ButtonFrameInstance1.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance1.Width",
                            Type = "float",
                            Value = ButtonFrameInstance1.Width + 34.03326f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance1.X",
                            Type = "float",
                            Value = ButtonFrameInstance1.X + -25f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance1.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ButtonFrameInstance1.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance1.X Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance1.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OrTextInstance.Blue",
                            Type = "int",
                            Value = OrTextInstance.Blue + 140
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
                            Value = OrTextInstance.Green + 230
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
                            Value = OrTextInstance.Red + 240
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
                            Value = OrTextInstance.X + 164f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OrTextInstance.Y",
                            Type = "float",
                            Value = OrTextInstance.Y + 42f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsSprite.Height",
                            Type = "float",
                            Value = PointsSprite.Height + 50f
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
                            Value = PointsSprite.X + 15f
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
                            Name = "CostText.Blue",
                            Type = "int",
                            Value = CostText.Blue + 0
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
                            Name = "CostText.Green",
                            Type = "int",
                            Value = CostText.Green + 252
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
                            Value = CostText.Red + 124
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
                            Value = CostText.X + 1f
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
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (UpgradeAvailability state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  UpgradeAvailability.Available:
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
                            Name = "ButtonContainers.Visible",
                            Type = "bool",
                            Value = ButtonContainers.Visible
                        }
                        );
                        break;
                    case  UpgradeAvailability.NotAvailable:
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
                            Name = "ButtonContainers.Visible",
                            Type = "bool",
                            Value = ButtonContainers.Visible
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (UpgradeAvailability state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  UpgradeAvailability.Available:
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
                            Name = "ButtonContainers.Visible",
                            Type = "bool",
                            Value = ButtonContainers.Visible
                        }
                        );
                        break;
                    case  UpgradeAvailability.NotAvailable:
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
                            Name = "ButtonContainers.Visible",
                            Type = "bool",
                            Value = ButtonContainers.Visible
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (Selection state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  Selection.Selected:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlowSprite.Blue",
                            Type = "int",
                            Value = GlowSprite.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlowSprite.Red",
                            Type = "int",
                            Value = GlowSprite.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlowSprite.Visible",
                            Type = "bool",
                            Value = GlowSprite.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Alpha",
                            Type = "int",
                            Value = NameText.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Blue",
                            Type = "int",
                            Value = NameText.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Green",
                            Type = "int",
                            Value = NameText.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Red",
                            Type = "int",
                            Value = NameText.Red
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
                            Name = "ColoredRectangleInstance.Red",
                            Type = "int",
                            Value = ColoredRectangleInstance.Red
                        }
                        );
                        break;
                    case  Selection.NotSelected:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlowSprite.Blue",
                            Type = "int",
                            Value = GlowSprite.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlowSprite.Red",
                            Type = "int",
                            Value = GlowSprite.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlowSprite.Visible",
                            Type = "bool",
                            Value = GlowSprite.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Alpha",
                            Type = "int",
                            Value = NameText.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Blue",
                            Type = "int",
                            Value = NameText.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Green",
                            Type = "int",
                            Value = NameText.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Red",
                            Type = "int",
                            Value = NameText.Red
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
                            Name = "ColoredRectangleInstance.Red",
                            Type = "int",
                            Value = ColoredRectangleInstance.Red
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (Selection state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  Selection.Selected:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlowSprite.Blue",
                            Type = "int",
                            Value = GlowSprite.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlowSprite.Red",
                            Type = "int",
                            Value = GlowSprite.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlowSprite.Visible",
                            Type = "bool",
                            Value = GlowSprite.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Alpha",
                            Type = "int",
                            Value = NameText.Alpha + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Blue",
                            Type = "int",
                            Value = NameText.Blue + 47
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Green",
                            Type = "int",
                            Value = NameText.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Red",
                            Type = "int",
                            Value = NameText.Red + 173
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Alpha",
                            Type = "int",
                            Value = ColoredRectangleInstance.Alpha + 255
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
                            Value = ColoredRectangleInstance.Green + 252
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Red",
                            Type = "int",
                            Value = ColoredRectangleInstance.Red + 124
                        }
                        );
                        break;
                    case  Selection.NotSelected:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlowSprite.Blue",
                            Type = "int",
                            Value = GlowSprite.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlowSprite.Red",
                            Type = "int",
                            Value = GlowSprite.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlowSprite.Visible",
                            Type = "bool",
                            Value = GlowSprite.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Alpha",
                            Type = "int",
                            Value = NameText.Alpha + 150
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Blue",
                            Type = "int",
                            Value = NameText.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Green",
                            Type = "int",
                            Value = NameText.Green + 165
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Red",
                            Type = "int",
                            Value = NameText.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Alpha",
                            Type = "int",
                            Value = ColoredRectangleInstance.Alpha + 150
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
                            Value = ColoredRectangleInstance.Green + 165
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Red",
                            Type = "int",
                            Value = ColoredRectangleInstance.Red + 255
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
                    else if (category.Name == "UpgradeAvailability")
                    {
                        if(state.Name == "Available") this.mCurrentUpgradeAvailabilityState = UpgradeAvailability.Available;
                        if(state.Name == "NotAvailable") this.mCurrentUpgradeAvailabilityState = UpgradeAvailability.NotAvailable;
                    }
                    else if (category.Name == "Selection")
                    {
                        if(state.Name == "Selected") this.mCurrentSelectionState = Selection.Selected;
                        if(state.Name == "NotSelected") this.mCurrentSelectionState = Selection.NotSelected;
                    }
                }
                base.ApplyState(state);
            }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime GlowSprite { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime NameContainer { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime NameText { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TallInfoFrameRuntime TallInfoFrameInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime StatsContainer { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime UpgradeText { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime ButtonContainers { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime InfoContainer { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ColoredRectangleRuntime ColoredRectangleInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ResistanceDisplayRuntime AttackDamageType { get; set; }
            private AbbatoirIntergrade.GumRuntimes.AttributeDisplayRuntime MinRange { get; set; }
            private AbbatoirIntergrade.GumRuntimes.AttributeDisplayRuntime MaxRange { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime AttackCostContainer { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime RangeContainer { get; set; }
            private AbbatoirIntergrade.GumRuntimes.AttributeDisplayRuntime AttackSpeed { get; set; }
            private AbbatoirIntergrade.GumRuntimes.AttributeDisplayRuntime PointOrSplash { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime ButtonFrameInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime ButtonFrameInstance1 { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime OrTextInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime PointsSprite { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime CostText { get; set; }
            public string SatoshiCost
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
                        SatoshiCostChanged?.Invoke(this, null);
                    }
                }
            }
            public string StructureName
            {
                get
                {
                    return NameText.Text;
                }
                set
                {
                    if (NameText.Text != value)
                    {
                        NameText.Text = value;
                        StructureNameChanged?.Invoke(this, null);
                    }
                }
            }
            public event FlatRedBall.Gui.WindowEvent NameContainerClick;
            public event FlatRedBall.Gui.WindowEvent StatsContainerClick;
            public event FlatRedBall.Gui.WindowEvent ButtonContainersClick;
            public event FlatRedBall.Gui.WindowEvent InfoContainerClick;
            public event FlatRedBall.Gui.WindowEvent AttackCostContainerClick;
            public event FlatRedBall.Gui.WindowEvent RangeContainerClick;
            public event FlatRedBall.Gui.WindowEvent ButtonFrameInstanceClick;
            public event FlatRedBall.Gui.WindowEvent ButtonFrameInstance1Click;
            public event System.EventHandler SatoshiCostChanged;
            public event System.EventHandler StructureNameChanged;
            public StructureInfoRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                this.HasEvents = false;
                this.ExposeChildrenEvents = true;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "infodisplays/StructureInfo");
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
                GlowSprite = this.GetGraphicalUiElementByName("GlowSprite") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                NameContainer = this.GetGraphicalUiElementByName("NameContainer") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
                NameText = this.GetGraphicalUiElementByName("NameText") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
                TallInfoFrameInstance = this.GetGraphicalUiElementByName("TallInfoFrameInstance") as AbbatoirIntergrade.GumRuntimes.TallInfoFrameRuntime;
                StatsContainer = this.GetGraphicalUiElementByName("StatsContainer") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
                UpgradeText = this.GetGraphicalUiElementByName("UpgradeText") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
                ButtonContainers = this.GetGraphicalUiElementByName("ButtonContainers") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
                InfoContainer = this.GetGraphicalUiElementByName("InfoContainer") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
                ColoredRectangleInstance = this.GetGraphicalUiElementByName("ColoredRectangleInstance") as AbbatoirIntergrade.GumRuntimes.ColoredRectangleRuntime;
                AttackDamageType = this.GetGraphicalUiElementByName("AttackDamageType") as AbbatoirIntergrade.GumRuntimes.ResistanceDisplayRuntime;
                MinRange = this.GetGraphicalUiElementByName("MinRange") as AbbatoirIntergrade.GumRuntimes.AttributeDisplayRuntime;
                MaxRange = this.GetGraphicalUiElementByName("MaxRange") as AbbatoirIntergrade.GumRuntimes.AttributeDisplayRuntime;
                AttackCostContainer = this.GetGraphicalUiElementByName("AttackCostContainer") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
                RangeContainer = this.GetGraphicalUiElementByName("RangeContainer") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
                AttackSpeed = this.GetGraphicalUiElementByName("AttackSpeed") as AbbatoirIntergrade.GumRuntimes.AttributeDisplayRuntime;
                PointOrSplash = this.GetGraphicalUiElementByName("PointOrSplash") as AbbatoirIntergrade.GumRuntimes.AttributeDisplayRuntime;
                ButtonFrameInstance = this.GetGraphicalUiElementByName("ButtonFrameInstance") as AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime;
                ButtonFrameInstance1 = this.GetGraphicalUiElementByName("ButtonFrameInstance1") as AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime;
                OrTextInstance = this.GetGraphicalUiElementByName("OrTextInstance") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
                PointsSprite = this.GetGraphicalUiElementByName("PointsSprite") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                CostText = this.GetGraphicalUiElementByName("CostText") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
                NameContainer.Click += (unused) => NameContainerClick?.Invoke(this);
                StatsContainer.Click += (unused) => StatsContainerClick?.Invoke(this);
                ButtonContainers.Click += (unused) => ButtonContainersClick?.Invoke(this);
                InfoContainer.Click += (unused) => InfoContainerClick?.Invoke(this);
                AttackCostContainer.Click += (unused) => AttackCostContainerClick?.Invoke(this);
                RangeContainer.Click += (unused) => RangeContainerClick?.Invoke(this);
                ButtonFrameInstance.Click += (unused) => ButtonFrameInstanceClick?.Invoke(this);
                ButtonFrameInstance1.Click += (unused) => ButtonFrameInstance1Click?.Invoke(this);
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
