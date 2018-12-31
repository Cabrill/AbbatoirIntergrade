    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes.infodisplays
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
                NotAvailable,
                AvailableCantAfford
            }
            public enum Selection
            {
                Selected,
                NotSelected
            }
            public enum CostInfo
            {
                Shown,
                NotShown
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            UpgradeAvailability? mCurrentUpgradeAvailabilityState;
            Selection? mCurrentSelectionState;
            CostInfo? mCurrentCostInfoState;
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
                            NameContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "InfoContainer") ?? this;
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
                            NameText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "NameContainer") ?? this;
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
                            StatsContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "InfoContainer") ?? this;
                            StatsContainer.Width = 69.21875f;
                            StatsContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            StatsContainer.WrapsChildren = true;
                            StatsContainer.X = 79f;
                            StatsContainer.Y = 0f;
                            InfoContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                            InfoContainer.Height = 96.66668f;
                            InfoContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            InfoContainer.Width = 100f;
                            InfoContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            InfoContainer.WrapsChildren = false;
                            ColoredRectangleInstance.Height = 4f;
                            ColoredRectangleInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "NameContainer") ?? this;
                            ColoredRectangleInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ColoredRectangleInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            ColoredRectangleInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            ColoredRectangleInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                            ColoredRectangleInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            AttackDamageType.DamageTypeIconState = AbbatoirIntergrade.GumRuntimes.infodisplays.DamageTypeIconRuntime.DamageType.Piercing;
                            AttackDamageType.Height = 100f;
                            AttackDamageType.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            AttackDamageType.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "AttackCostContainer") ?? this;
                            AttackDamageType.ResistanceText = "50";
                            AttackDamageType.TextFontScale = 1f;
                            AttackDamageType.TextHorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            AttackDamageType.Width = 55f;
                            AttackDamageType.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            AttackDamageType.X = 0f;
                            AttackDamageType.Y = 0f;
                            MinRange.AttributeIconTypeState = AbbatoirIntergrade.GumRuntimes.infodisplays.AttributeIconRuntime.AttributeType.MinRange;
                            MinRange.AttributeText = "100";
                            MinRange.Height = 75f;
                            MinRange.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            MinRange.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "RangeContainer") ?? this;
                            MinRange.TextInstanceFontScale = 0.5f;
                            MinRange.TextInstanceHorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            MinRange.Width = 50f;
                            MinRange.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            MinRange.Y = 12.5f;
                            MinRange.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            MaxRange.AttributeIconTypeState = AbbatoirIntergrade.GumRuntimes.infodisplays.AttributeIconRuntime.AttributeType.MaxRange;
                            MaxRange.AttributeText = "50";
                            MaxRange.Height = 75f;
                            MaxRange.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            MaxRange.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "RangeContainer") ?? this;
                            MaxRange.TextInstanceFontScale = 0.5f;
                            MaxRange.TextInstanceHorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            MaxRange.Width = 50f;
                            MaxRange.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            MaxRange.Y = 12.5f;
                            MaxRange.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            AttackCostContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                            AttackCostContainer.Height = 24.9f;
                            AttackCostContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            AttackCostContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "StatsContainer") ?? this;
                            AttackCostContainer.Width = 100f;
                            AttackCostContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            RangeContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                            RangeContainer.Height = 24.9f;
                            RangeContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            RangeContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "StatsContainer") ?? this;
                            RangeContainer.Width = 0f;
                            RangeContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            AttackSpeed.AttributeIconTypeState = AbbatoirIntergrade.GumRuntimes.infodisplays.AttributeIconRuntime.AttributeType.AttackSpeed;
                            AttackSpeed.AttributeText = "3 sec";
                            AttackSpeed.Height = 24.9f;
                            AttackSpeed.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            AttackSpeed.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "StatsContainer") ?? this;
                            AttackSpeed.TextInstanceFontScale = 0.5f;
                            AttackSpeed.TextInstanceHorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            AttackSpeed.Width = 0f;
                            AttackSpeed.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            PointOrSplash.AttributeIconTypeState = AbbatoirIntergrade.GumRuntimes.infodisplays.AttributeIconRuntime.AttributeType.PointOrSplash;
                            PointOrSplash.AttributeText = "Single";
                            PointOrSplash.Height = 24.9f;
                            PointOrSplash.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            PointOrSplash.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "StatsContainer") ?? this;
                            PointOrSplash.TextInstanceFontScale = 0.5f;
                            PointOrSplash.TextInstanceHorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            PointOrSplash.Width = 0f;
                            PointOrSplash.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            PointsSprite.Height = 50f;
                            PointsSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            PointsSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "AttackCostContainer") ?? this;
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
                            CostText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "AttackCostContainer") ?? this;
                            CostText.Red = 124;
                            CostText.Text = "20";
                            CostText.UseCustomFont = true;
                            CostText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            CostText.Width = 0f;
                            CostText.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            CostText.X = 1f;
                            CostText.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            UpgradeInfoInstance.Height = 24f;
                            UpgradeInfoInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            UpgradeInfoInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "InfoContainer") ?? this;
                            UpgradeInfoInstance.Width = 354f;
                            UpgradeInfoInstance.X = 79f;
                            UpgradeInfoInstance.Y = 0f;
                            break;
                    }
                }
            }
            public UpgradeAvailability? CurrentUpgradeAvailabilityState
            {
                get
                {
                    return mCurrentUpgradeAvailabilityState;
                }
                set
                {
                    if (value != null)
                    {
                        mCurrentUpgradeAvailabilityState = value;
                        switch(mCurrentUpgradeAvailabilityState)
                        {
                            case  UpgradeAvailability.Available:
                                UpgradeInfoInstance.CurrentAffordabilityState = AbbatoirIntergrade.GumRuntimes.infodisplays.UpgradeInfoRuntime.Affordability.CanAfford;
                                UpgradeInfoInstance.Visible = true;
                                break;
                            case  UpgradeAvailability.NotAvailable:
                                UpgradeInfoInstance.CurrentAffordabilityState = AbbatoirIntergrade.GumRuntimes.infodisplays.UpgradeInfoRuntime.Affordability.CanAfford;
                                UpgradeInfoInstance.Visible = false;
                                break;
                            case  UpgradeAvailability.AvailableCantAfford:
                                UpgradeInfoInstance.CurrentAffordabilityState = AbbatoirIntergrade.GumRuntimes.infodisplays.UpgradeInfoRuntime.Affordability.CantAfford;
                                UpgradeInfoInstance.Visible = true;
                                break;
                        }
                    }
                }
            }
            public Selection? CurrentSelectionState
            {
                get
                {
                    return mCurrentSelectionState;
                }
                set
                {
                    if (value != null)
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
            }
            public CostInfo? CurrentCostInfoState
            {
                get
                {
                    return mCurrentCostInfoState;
                }
                set
                {
                    if (value != null)
                    {
                        mCurrentCostInfoState = value;
                        switch(mCurrentCostInfoState)
                        {
                            case  CostInfo.Shown:
                                PointsSprite.Visible = true;
                                CostText.Visible = true;
                                break;
                            case  CostInfo.NotShown:
                                PointsSprite.Visible = false;
                                CostText.Visible = false;
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
                bool setUpgradeInfoInstanceHeightFirstValue = false;
                bool setUpgradeInfoInstanceHeightSecondValue = false;
                float UpgradeInfoInstanceHeightFirstValue= 0;
                float UpgradeInfoInstanceHeightSecondValue= 0;
                bool setUpgradeInfoInstanceWidthFirstValue = false;
                bool setUpgradeInfoInstanceWidthSecondValue = false;
                float UpgradeInfoInstanceWidthFirstValue= 0;
                float UpgradeInfoInstanceWidthSecondValue= 0;
                bool setUpgradeInfoInstanceXFirstValue = false;
                bool setUpgradeInfoInstanceXSecondValue = false;
                float UpgradeInfoInstanceXFirstValue= 0;
                float UpgradeInfoInstanceXSecondValue= 0;
                bool setUpgradeInfoInstanceYFirstValue = false;
                bool setUpgradeInfoInstanceYSecondValue = false;
                float UpgradeInfoInstanceYFirstValue= 0;
                float UpgradeInfoInstanceYSecondValue= 0;
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
                        AttackCostContainerHeightFirstValue = 24.9f;
                        if (interpolationValue < 1)
                        {
                            this.AttackCostContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.AttackCostContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "StatsContainer") ?? this;
                        }
                        setAttackCostContainerWidthFirstValue = true;
                        AttackCostContainerWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.AttackCostContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.AttackDamageType.DamageTypeIconState = AbbatoirIntergrade.GumRuntimes.infodisplays.DamageTypeIconRuntime.DamageType.Piercing;
                        }
                        setAttackDamageTypeHeightFirstValue = true;
                        AttackDamageTypeHeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.AttackDamageType.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.AttackDamageType.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "AttackCostContainer") ?? this;
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
                            this.AttackSpeed.AttributeIconTypeState = AbbatoirIntergrade.GumRuntimes.infodisplays.AttributeIconRuntime.AttributeType.AttackSpeed;
                        }
                        if (interpolationValue < 1)
                        {
                            this.AttackSpeed.AttributeText = "3 sec";
                        }
                        setAttackSpeedHeightFirstValue = true;
                        AttackSpeedHeightFirstValue = 24.9f;
                        if (interpolationValue < 1)
                        {
                            this.AttackSpeed.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.AttackSpeed.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "StatsContainer") ?? this;
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
                            this.ColoredRectangleInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "NameContainer") ?? this;
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
                            this.CostText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "AttackCostContainer") ?? this;
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
                            this.MaxRange.AttributeIconTypeState = AbbatoirIntergrade.GumRuntimes.infodisplays.AttributeIconRuntime.AttributeType.MaxRange;
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
                            this.MaxRange.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "RangeContainer") ?? this;
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
                            this.MinRange.AttributeIconTypeState = AbbatoirIntergrade.GumRuntimes.infodisplays.AttributeIconRuntime.AttributeType.MinRange;
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
                            this.MinRange.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "RangeContainer") ?? this;
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
                            this.NameContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "InfoContainer") ?? this;
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
                            this.NameText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "NameContainer") ?? this;
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
                        if (interpolationValue < 1)
                        {
                            this.PointOrSplash.AttributeIconTypeState = AbbatoirIntergrade.GumRuntimes.infodisplays.AttributeIconRuntime.AttributeType.PointOrSplash;
                        }
                        if (interpolationValue < 1)
                        {
                            this.PointOrSplash.AttributeText = "Single";
                        }
                        setPointOrSplashHeightFirstValue = true;
                        PointOrSplashHeightFirstValue = 24.9f;
                        if (interpolationValue < 1)
                        {
                            this.PointOrSplash.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.PointOrSplash.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "StatsContainer") ?? this;
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
                            this.PointsSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "AttackCostContainer") ?? this;
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
                        RangeContainerHeightFirstValue = 24.9f;
                        if (interpolationValue < 1)
                        {
                            this.RangeContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.RangeContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "StatsContainer") ?? this;
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
                            this.StatsContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "InfoContainer") ?? this;
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
                        setUpgradeInfoInstanceHeightFirstValue = true;
                        UpgradeInfoInstanceHeightFirstValue = 24f;
                        if (interpolationValue < 1)
                        {
                            this.UpgradeInfoInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.UpgradeInfoInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "InfoContainer") ?? this;
                        }
                        setUpgradeInfoInstanceWidthFirstValue = true;
                        UpgradeInfoInstanceWidthFirstValue = 354f;
                        setUpgradeInfoInstanceXFirstValue = true;
                        UpgradeInfoInstanceXFirstValue = 79f;
                        setUpgradeInfoInstanceYFirstValue = true;
                        UpgradeInfoInstanceYFirstValue = 0f;
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
                        AttackCostContainerHeightSecondValue = 24.9f;
                        if (interpolationValue >= 1)
                        {
                            this.AttackCostContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.AttackCostContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "StatsContainer") ?? this;
                        }
                        setAttackCostContainerWidthSecondValue = true;
                        AttackCostContainerWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.AttackCostContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.AttackDamageType.DamageTypeIconState = AbbatoirIntergrade.GumRuntimes.infodisplays.DamageTypeIconRuntime.DamageType.Piercing;
                        }
                        setAttackDamageTypeHeightSecondValue = true;
                        AttackDamageTypeHeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.AttackDamageType.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.AttackDamageType.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "AttackCostContainer") ?? this;
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
                            this.AttackSpeed.AttributeIconTypeState = AbbatoirIntergrade.GumRuntimes.infodisplays.AttributeIconRuntime.AttributeType.AttackSpeed;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.AttackSpeed.AttributeText = "3 sec";
                        }
                        setAttackSpeedHeightSecondValue = true;
                        AttackSpeedHeightSecondValue = 24.9f;
                        if (interpolationValue >= 1)
                        {
                            this.AttackSpeed.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.AttackSpeed.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "StatsContainer") ?? this;
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
                            this.ColoredRectangleInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "NameContainer") ?? this;
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
                            this.CostText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "AttackCostContainer") ?? this;
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
                            this.MaxRange.AttributeIconTypeState = AbbatoirIntergrade.GumRuntimes.infodisplays.AttributeIconRuntime.AttributeType.MaxRange;
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
                            this.MaxRange.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "RangeContainer") ?? this;
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
                            this.MinRange.AttributeIconTypeState = AbbatoirIntergrade.GumRuntimes.infodisplays.AttributeIconRuntime.AttributeType.MinRange;
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
                            this.MinRange.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "RangeContainer") ?? this;
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
                            this.NameContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "InfoContainer") ?? this;
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
                            this.NameText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "NameContainer") ?? this;
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
                        if (interpolationValue >= 1)
                        {
                            this.PointOrSplash.AttributeIconTypeState = AbbatoirIntergrade.GumRuntimes.infodisplays.AttributeIconRuntime.AttributeType.PointOrSplash;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PointOrSplash.AttributeText = "Single";
                        }
                        setPointOrSplashHeightSecondValue = true;
                        PointOrSplashHeightSecondValue = 24.9f;
                        if (interpolationValue >= 1)
                        {
                            this.PointOrSplash.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PointOrSplash.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "StatsContainer") ?? this;
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
                            this.PointsSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "AttackCostContainer") ?? this;
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
                        RangeContainerHeightSecondValue = 24.9f;
                        if (interpolationValue >= 1)
                        {
                            this.RangeContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.RangeContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "StatsContainer") ?? this;
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
                            this.StatsContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "InfoContainer") ?? this;
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
                        setUpgradeInfoInstanceHeightSecondValue = true;
                        UpgradeInfoInstanceHeightSecondValue = 24f;
                        if (interpolationValue >= 1)
                        {
                            this.UpgradeInfoInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.UpgradeInfoInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "InfoContainer") ?? this;
                        }
                        setUpgradeInfoInstanceWidthSecondValue = true;
                        UpgradeInfoInstanceWidthSecondValue = 354f;
                        setUpgradeInfoInstanceXSecondValue = true;
                        UpgradeInfoInstanceXSecondValue = 79f;
                        setUpgradeInfoInstanceYSecondValue = true;
                        UpgradeInfoInstanceYSecondValue = 0f;
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
                if (setUpgradeInfoInstanceHeightFirstValue && setUpgradeInfoInstanceHeightSecondValue)
                {
                    UpgradeInfoInstance.Height = UpgradeInfoInstanceHeightFirstValue * (1 - interpolationValue) + UpgradeInfoInstanceHeightSecondValue * interpolationValue;
                }
                if (setUpgradeInfoInstanceWidthFirstValue && setUpgradeInfoInstanceWidthSecondValue)
                {
                    UpgradeInfoInstance.Width = UpgradeInfoInstanceWidthFirstValue * (1 - interpolationValue) + UpgradeInfoInstanceWidthSecondValue * interpolationValue;
                }
                if (setUpgradeInfoInstanceXFirstValue && setUpgradeInfoInstanceXSecondValue)
                {
                    UpgradeInfoInstance.X = UpgradeInfoInstanceXFirstValue * (1 - interpolationValue) + UpgradeInfoInstanceXSecondValue * interpolationValue;
                }
                if (setUpgradeInfoInstanceYFirstValue && setUpgradeInfoInstanceYSecondValue)
                {
                    UpgradeInfoInstance.Y = UpgradeInfoInstanceYFirstValue * (1 - interpolationValue) + UpgradeInfoInstanceYSecondValue * interpolationValue;
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
                bool setUpgradeInfoInstanceCurrentAffordabilityStateFirstValue = false;
                bool setUpgradeInfoInstanceCurrentAffordabilityStateSecondValue = false;
                AbbatoirIntergrade.GumRuntimes.infodisplays.UpgradeInfoRuntime.Affordability UpgradeInfoInstanceCurrentAffordabilityStateFirstValue= AbbatoirIntergrade.GumRuntimes.infodisplays.UpgradeInfoRuntime.Affordability.CanAfford;
                AbbatoirIntergrade.GumRuntimes.infodisplays.UpgradeInfoRuntime.Affordability UpgradeInfoInstanceCurrentAffordabilityStateSecondValue= AbbatoirIntergrade.GumRuntimes.infodisplays.UpgradeInfoRuntime.Affordability.CanAfford;
                switch(firstState)
                {
                    case  UpgradeAvailability.Available:
                        setUpgradeInfoInstanceCurrentAffordabilityStateFirstValue = true;
                        UpgradeInfoInstanceCurrentAffordabilityStateFirstValue = AbbatoirIntergrade.GumRuntimes.infodisplays.UpgradeInfoRuntime.Affordability.CanAfford;
                        if (interpolationValue < 1)
                        {
                            this.UpgradeInfoInstance.Visible = true;
                        }
                        break;
                    case  UpgradeAvailability.NotAvailable:
                        setUpgradeInfoInstanceCurrentAffordabilityStateFirstValue = true;
                        UpgradeInfoInstanceCurrentAffordabilityStateFirstValue = AbbatoirIntergrade.GumRuntimes.infodisplays.UpgradeInfoRuntime.Affordability.CanAfford;
                        if (interpolationValue < 1)
                        {
                            this.UpgradeInfoInstance.Visible = false;
                        }
                        break;
                    case  UpgradeAvailability.AvailableCantAfford:
                        setUpgradeInfoInstanceCurrentAffordabilityStateFirstValue = true;
                        UpgradeInfoInstanceCurrentAffordabilityStateFirstValue = AbbatoirIntergrade.GumRuntimes.infodisplays.UpgradeInfoRuntime.Affordability.CantAfford;
                        if (interpolationValue < 1)
                        {
                            this.UpgradeInfoInstance.Visible = true;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  UpgradeAvailability.Available:
                        setUpgradeInfoInstanceCurrentAffordabilityStateSecondValue = true;
                        UpgradeInfoInstanceCurrentAffordabilityStateSecondValue = AbbatoirIntergrade.GumRuntimes.infodisplays.UpgradeInfoRuntime.Affordability.CanAfford;
                        if (interpolationValue >= 1)
                        {
                            this.UpgradeInfoInstance.Visible = true;
                        }
                        break;
                    case  UpgradeAvailability.NotAvailable:
                        setUpgradeInfoInstanceCurrentAffordabilityStateSecondValue = true;
                        UpgradeInfoInstanceCurrentAffordabilityStateSecondValue = AbbatoirIntergrade.GumRuntimes.infodisplays.UpgradeInfoRuntime.Affordability.CanAfford;
                        if (interpolationValue >= 1)
                        {
                            this.UpgradeInfoInstance.Visible = false;
                        }
                        break;
                    case  UpgradeAvailability.AvailableCantAfford:
                        setUpgradeInfoInstanceCurrentAffordabilityStateSecondValue = true;
                        UpgradeInfoInstanceCurrentAffordabilityStateSecondValue = AbbatoirIntergrade.GumRuntimes.infodisplays.UpgradeInfoRuntime.Affordability.CantAfford;
                        if (interpolationValue >= 1)
                        {
                            this.UpgradeInfoInstance.Visible = true;
                        }
                        break;
                }
                if (setUpgradeInfoInstanceCurrentAffordabilityStateFirstValue && setUpgradeInfoInstanceCurrentAffordabilityStateSecondValue)
                {
                    UpgradeInfoInstance.InterpolateBetween(UpgradeInfoInstanceCurrentAffordabilityStateFirstValue, UpgradeInfoInstanceCurrentAffordabilityStateSecondValue, interpolationValue);
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
            public void InterpolateBetween (CostInfo firstState, CostInfo secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                switch(firstState)
                {
                    case  CostInfo.Shown:
                        if (interpolationValue < 1)
                        {
                            this.CostText.Visible = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.PointsSprite.Visible = true;
                        }
                        break;
                    case  CostInfo.NotShown:
                        if (interpolationValue < 1)
                        {
                            this.CostText.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.PointsSprite.Visible = false;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  CostInfo.Shown:
                        if (interpolationValue >= 1)
                        {
                            this.CostText.Visible = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PointsSprite.Visible = true;
                        }
                        break;
                    case  CostInfo.NotShown:
                        if (interpolationValue >= 1)
                        {
                            this.CostText.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PointsSprite.Visible = false;
                        }
                        break;
                }
                if (interpolationValue < 1)
                {
                    mCurrentCostInfoState = firstState;
                }
                else
                {
                    mCurrentCostInfoState = secondState;
                }
            }
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.infodisplays.StructureInfoRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.infodisplays.StructureInfoRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.infodisplays.StructureInfoRuntime.UpgradeAvailability fromState,AbbatoirIntergrade.GumRuntimes.infodisplays.StructureInfoRuntime.UpgradeAvailability toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.infodisplays.StructureInfoRuntime.Selection fromState,AbbatoirIntergrade.GumRuntimes.infodisplays.StructureInfoRuntime.Selection toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.infodisplays.StructureInfoRuntime.CostInfo fromState,AbbatoirIntergrade.GumRuntimes.infodisplays.StructureInfoRuntime.CostInfo toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (CostInfo toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "CostInfo").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentCostInfoState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (CostInfo toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentCostInfoState = toState;
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
                UpgradeInfoInstance.StopAnimations();
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
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeInfoInstance.Height",
                            Type = "float",
                            Value = UpgradeInfoInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeInfoInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = UpgradeInfoInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeInfoInstance.Parent",
                            Type = "string",
                            Value = UpgradeInfoInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeInfoInstance.Width",
                            Type = "float",
                            Value = UpgradeInfoInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeInfoInstance.X",
                            Type = "float",
                            Value = UpgradeInfoInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeInfoInstance.Y",
                            Type = "float",
                            Value = UpgradeInfoInstance.Y
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
                            Value = AttackCostContainer.Height + 24.9f
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
                            Value = RangeContainer.Height + 24.9f
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
                            Value = AttackSpeed.Height + 24.9f
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
                            Value = PointOrSplash.Height + 24.9f
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
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeInfoInstance.Height",
                            Type = "float",
                            Value = UpgradeInfoInstance.Height + 24f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeInfoInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = UpgradeInfoInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeInfoInstance.Parent",
                            Type = "string",
                            Value = UpgradeInfoInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeInfoInstance.Width",
                            Type = "float",
                            Value = UpgradeInfoInstance.Width + 354f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeInfoInstance.X",
                            Type = "float",
                            Value = UpgradeInfoInstance.X + 79f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeInfoInstance.Y",
                            Type = "float",
                            Value = UpgradeInfoInstance.Y + 0f
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
                            Name = "UpgradeInfoInstance.AffordabilityState",
                            Type = "AffordabilityState",
                            Value = UpgradeInfoInstance.CurrentAffordabilityState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeInfoInstance.Visible",
                            Type = "bool",
                            Value = UpgradeInfoInstance.Visible
                        }
                        );
                        break;
                    case  UpgradeAvailability.NotAvailable:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeInfoInstance.AffordabilityState",
                            Type = "AffordabilityState",
                            Value = UpgradeInfoInstance.CurrentAffordabilityState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeInfoInstance.Visible",
                            Type = "bool",
                            Value = UpgradeInfoInstance.Visible
                        }
                        );
                        break;
                    case  UpgradeAvailability.AvailableCantAfford:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeInfoInstance.AffordabilityState",
                            Type = "AffordabilityState",
                            Value = UpgradeInfoInstance.CurrentAffordabilityState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeInfoInstance.Visible",
                            Type = "bool",
                            Value = UpgradeInfoInstance.Visible
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
                            Name = "UpgradeInfoInstance.AffordabilityState",
                            Type = "AffordabilityState",
                            Value = UpgradeInfoInstance.CurrentAffordabilityState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeInfoInstance.Visible",
                            Type = "bool",
                            Value = UpgradeInfoInstance.Visible
                        }
                        );
                        break;
                    case  UpgradeAvailability.NotAvailable:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeInfoInstance.AffordabilityState",
                            Type = "AffordabilityState",
                            Value = UpgradeInfoInstance.CurrentAffordabilityState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeInfoInstance.Visible",
                            Type = "bool",
                            Value = UpgradeInfoInstance.Visible
                        }
                        );
                        break;
                    case  UpgradeAvailability.AvailableCantAfford:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeInfoInstance.AffordabilityState",
                            Type = "AffordabilityState",
                            Value = UpgradeInfoInstance.CurrentAffordabilityState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpgradeInfoInstance.Visible",
                            Type = "bool",
                            Value = UpgradeInfoInstance.Visible
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
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (CostInfo state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  CostInfo.Shown:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsSprite.Visible",
                            Type = "bool",
                            Value = PointsSprite.Visible
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
                        break;
                    case  CostInfo.NotShown:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsSprite.Visible",
                            Type = "bool",
                            Value = PointsSprite.Visible
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
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (CostInfo state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  CostInfo.Shown:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsSprite.Visible",
                            Type = "bool",
                            Value = PointsSprite.Visible
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
                        break;
                    case  CostInfo.NotShown:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsSprite.Visible",
                            Type = "bool",
                            Value = PointsSprite.Visible
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
                        if(state.Name == "AvailableCantAfford") this.mCurrentUpgradeAvailabilityState = UpgradeAvailability.AvailableCantAfford;
                    }
                    else if (category.Name == "Selection")
                    {
                        if(state.Name == "Selected") this.mCurrentSelectionState = Selection.Selected;
                        if(state.Name == "NotSelected") this.mCurrentSelectionState = Selection.NotSelected;
                    }
                    else if (category.Name == "CostInfo")
                    {
                        if(state.Name == "Shown") this.mCurrentCostInfoState = CostInfo.Shown;
                        if(state.Name == "NotShown") this.mCurrentCostInfoState = CostInfo.NotShown;
                    }
                }
                base.ApplyState(state);
            }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime GlowSprite { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime NameContainer { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime NameText { get; set; }
            private AbbatoirIntergrade.GumRuntimes.frames.TallInfoFrameRuntime TallInfoFrameInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime StatsContainer { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime InfoContainer { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ColoredRectangleRuntime ColoredRectangleInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.infodisplays.ResistanceDisplayRuntime AttackDamageType { get; set; }
            private AbbatoirIntergrade.GumRuntimes.infodisplays.AttributeDisplayRuntime MinRange { get; set; }
            private AbbatoirIntergrade.GumRuntimes.infodisplays.AttributeDisplayRuntime MaxRange { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime AttackCostContainer { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime RangeContainer { get; set; }
            private AbbatoirIntergrade.GumRuntimes.infodisplays.AttributeDisplayRuntime AttackSpeed { get; set; }
            private AbbatoirIntergrade.GumRuntimes.infodisplays.AttributeDisplayRuntime PointOrSplash { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime PointsSprite { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime CostText { get; set; }
            private AbbatoirIntergrade.GumRuntimes.infodisplays.UpgradeInfoRuntime UpgradeInfoInstance { get; set; }
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
            public event FlatRedBall.Gui.WindowEvent InfoContainerClick;
            public event FlatRedBall.Gui.WindowEvent AttackCostContainerClick;
            public event FlatRedBall.Gui.WindowEvent RangeContainerClick;
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
                TallInfoFrameInstance = this.GetGraphicalUiElementByName("TallInfoFrameInstance") as AbbatoirIntergrade.GumRuntimes.frames.TallInfoFrameRuntime;
                StatsContainer = this.GetGraphicalUiElementByName("StatsContainer") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
                InfoContainer = this.GetGraphicalUiElementByName("InfoContainer") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
                ColoredRectangleInstance = this.GetGraphicalUiElementByName("ColoredRectangleInstance") as AbbatoirIntergrade.GumRuntimes.ColoredRectangleRuntime;
                AttackDamageType = this.GetGraphicalUiElementByName("AttackDamageType") as AbbatoirIntergrade.GumRuntimes.infodisplays.ResistanceDisplayRuntime;
                MinRange = this.GetGraphicalUiElementByName("MinRange") as AbbatoirIntergrade.GumRuntimes.infodisplays.AttributeDisplayRuntime;
                MaxRange = this.GetGraphicalUiElementByName("MaxRange") as AbbatoirIntergrade.GumRuntimes.infodisplays.AttributeDisplayRuntime;
                AttackCostContainer = this.GetGraphicalUiElementByName("AttackCostContainer") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
                RangeContainer = this.GetGraphicalUiElementByName("RangeContainer") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
                AttackSpeed = this.GetGraphicalUiElementByName("AttackSpeed") as AbbatoirIntergrade.GumRuntimes.infodisplays.AttributeDisplayRuntime;
                PointOrSplash = this.GetGraphicalUiElementByName("PointOrSplash") as AbbatoirIntergrade.GumRuntimes.infodisplays.AttributeDisplayRuntime;
                PointsSprite = this.GetGraphicalUiElementByName("PointsSprite") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                CostText = this.GetGraphicalUiElementByName("CostText") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
                UpgradeInfoInstance = this.GetGraphicalUiElementByName("UpgradeInfoInstance") as AbbatoirIntergrade.GumRuntimes.infodisplays.UpgradeInfoRuntime;
                NameContainer.Click += (unused) => NameContainerClick?.Invoke(this);
                StatsContainer.Click += (unused) => StatsContainerClick?.Invoke(this);
                InfoContainer.Click += (unused) => InfoContainerClick?.Invoke(this);
                AttackCostContainer.Click += (unused) => AttackCostContainerClick?.Invoke(this);
                RangeContainer.Click += (unused) => RangeContainerClick?.Invoke(this);
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
