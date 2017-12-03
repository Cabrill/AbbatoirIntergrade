    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes
    {
        public partial class BuildButtonRuntime : AbbatoirIntergrade.GumRuntimes.ContainerRuntime
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            public enum StructureType
            {
                Energy,
                Combat,
                Utility
            }
            public enum EnabledStatus
            {
                Enabled,
                Disabled
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            StructureType mCurrentStructureTypeState;
            EnabledStatus mCurrentEnabledStatusState;
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
                            ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                            ClipsChildren = false;
                            Height = 100f;
                            HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            Visible = true;
                            Width = 100f;
                            WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                            WrapsChildren = false;
                            X = 1f;
                            XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                            YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            ButtonCircleSprite.Blue = 255;
                            ButtonCircleSprite.Green = 255;
                            ButtonCircleSprite.Height = 85f;
                            ButtonCircleSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ButtonCircleSprite.Red = 255;
                            SetProperty("ButtonCircleSprite.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                            ButtonCircleSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            ButtonCircleSprite.TextureHeight = 480;
                            ButtonCircleSprite.TextureLeft = 516;
                            ButtonCircleSprite.TextureTop = 1076;
                            ButtonCircleSprite.TextureWidth = 480;
                            ButtonCircleSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                            ButtonCircleSprite.X = 10f;
                            ButtonCircleSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            ButtonCircleSprite.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            ButtonCircleSprite.Y = 5f;
                            ButtonCircleSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                            ButtonCircleSprite.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            StructureSprite.Height = 102f;
                            StructureSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            StructureSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ButtonCircleSprite");
                            StructureSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            StructureSprite.Width = 100f;
                            StructureSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            StructureSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            StructureSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            StructureSprite.Y = 0f;
                            StructureSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            StructureSprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            MineralCostContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                            MineralCostContainer.Height = 55f;
                            MineralCostContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            MineralCostContainer.Width = 55f;
                            MineralCostContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            MineralCostContainer.X = 0f;
                            MineralCostContainer.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            MineralCostContainer.Y = 0f;
                            MineralCostContainer.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                            MineralCostContainer.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            CostCircleSprite.Blue = 158;
                            CostCircleSprite.Green = 75;
                            CostCircleSprite.Height = 100f;
                            CostCircleSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            CostCircleSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "MineralCostContainer");
                            CostCircleSprite.Red = 120;
                            SetProperty("CostCircleSprite.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                            CostCircleSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            CostCircleSprite.TextureHeight = 480;
                            CostCircleSprite.TextureLeft = 516;
                            CostCircleSprite.TextureTop = 1076;
                            CostCircleSprite.TextureWidth = 480;
                            CostCircleSprite.Visible = true;
                            CostCircleSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                            CostCircleSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            CostCircleSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            CostCircleSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            CostCircleSprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            SetProperty("MineralsText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                            MineralsText.Font = "Moire ExtraBold";
                            MineralsText.FontScale = 0.9f;
                            MineralsText.FontSize = 50;
                            MineralsText.Height = 100f;
                            MineralsText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            MineralsText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            MineralsText.OutlineThickness = 2;
                            MineralsText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "CostCircleSprite");
                            MineralsText.Text = "100";
                            MineralsText.UseCustomFont = true;
                            MineralsText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            MineralsText.Width = 100f;
                            MineralsText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            MineralsText.X = 1f;
                            MineralsText.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            MineralsText.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            MineralsText.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            break;
                    }
                }
            }
            public StructureType CurrentStructureTypeState
            {
                get
                {
                    return mCurrentStructureTypeState;
                }
                set
                {
                    mCurrentStructureTypeState = value;
                    switch(mCurrentStructureTypeState)
                    {
                        case  StructureType.Energy:
                            ButtonCircleSprite.Blue = 3;
                            ButtonCircleSprite.Green = 213;
                            ButtonCircleSprite.Red = 255;
                            break;
                        case  StructureType.Combat:
                            ButtonCircleSprite.Blue = 236;
                            ButtonCircleSprite.Green = 207;
                            ButtonCircleSprite.Red = 113;
                            break;
                        case  StructureType.Utility:
                            ButtonCircleSprite.Blue = 212;
                            ButtonCircleSprite.Green = 210;
                            ButtonCircleSprite.Red = 209;
                            break;
                    }
                }
            }
            public EnabledStatus CurrentEnabledStatusState
            {
                get
                {
                    return mCurrentEnabledStatusState;
                }
                set
                {
                    mCurrentEnabledStatusState = value;
                    switch(mCurrentEnabledStatusState)
                    {
                        case  EnabledStatus.Enabled:
                            StructureSprite.Alpha = 255;
                            break;
                        case  EnabledStatus.Disabled:
                            StructureSprite.Alpha = 50;
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
                bool setButtonCircleSpriteBlueFirstValue = false;
                bool setButtonCircleSpriteBlueSecondValue = false;
                int ButtonCircleSpriteBlueFirstValue= 0;
                int ButtonCircleSpriteBlueSecondValue= 0;
                bool setButtonCircleSpriteGreenFirstValue = false;
                bool setButtonCircleSpriteGreenSecondValue = false;
                int ButtonCircleSpriteGreenFirstValue= 0;
                int ButtonCircleSpriteGreenSecondValue= 0;
                bool setButtonCircleSpriteHeightFirstValue = false;
                bool setButtonCircleSpriteHeightSecondValue = false;
                float ButtonCircleSpriteHeightFirstValue= 0;
                float ButtonCircleSpriteHeightSecondValue= 0;
                bool setButtonCircleSpriteRedFirstValue = false;
                bool setButtonCircleSpriteRedSecondValue = false;
                int ButtonCircleSpriteRedFirstValue= 0;
                int ButtonCircleSpriteRedSecondValue= 0;
                bool setButtonCircleSpriteTextureHeightFirstValue = false;
                bool setButtonCircleSpriteTextureHeightSecondValue = false;
                int ButtonCircleSpriteTextureHeightFirstValue= 0;
                int ButtonCircleSpriteTextureHeightSecondValue= 0;
                bool setButtonCircleSpriteTextureLeftFirstValue = false;
                bool setButtonCircleSpriteTextureLeftSecondValue = false;
                int ButtonCircleSpriteTextureLeftFirstValue= 0;
                int ButtonCircleSpriteTextureLeftSecondValue= 0;
                bool setButtonCircleSpriteTextureTopFirstValue = false;
                bool setButtonCircleSpriteTextureTopSecondValue = false;
                int ButtonCircleSpriteTextureTopFirstValue= 0;
                int ButtonCircleSpriteTextureTopSecondValue= 0;
                bool setButtonCircleSpriteTextureWidthFirstValue = false;
                bool setButtonCircleSpriteTextureWidthSecondValue = false;
                int ButtonCircleSpriteTextureWidthFirstValue= 0;
                int ButtonCircleSpriteTextureWidthSecondValue= 0;
                bool setButtonCircleSpriteXFirstValue = false;
                bool setButtonCircleSpriteXSecondValue = false;
                float ButtonCircleSpriteXFirstValue= 0;
                float ButtonCircleSpriteXSecondValue= 0;
                bool setButtonCircleSpriteYFirstValue = false;
                bool setButtonCircleSpriteYSecondValue = false;
                float ButtonCircleSpriteYFirstValue= 0;
                float ButtonCircleSpriteYSecondValue= 0;
                bool setCostCircleSpriteBlueFirstValue = false;
                bool setCostCircleSpriteBlueSecondValue = false;
                int CostCircleSpriteBlueFirstValue= 0;
                int CostCircleSpriteBlueSecondValue= 0;
                bool setCostCircleSpriteGreenFirstValue = false;
                bool setCostCircleSpriteGreenSecondValue = false;
                int CostCircleSpriteGreenFirstValue= 0;
                int CostCircleSpriteGreenSecondValue= 0;
                bool setCostCircleSpriteHeightFirstValue = false;
                bool setCostCircleSpriteHeightSecondValue = false;
                float CostCircleSpriteHeightFirstValue= 0;
                float CostCircleSpriteHeightSecondValue= 0;
                bool setCostCircleSpriteRedFirstValue = false;
                bool setCostCircleSpriteRedSecondValue = false;
                int CostCircleSpriteRedFirstValue= 0;
                int CostCircleSpriteRedSecondValue= 0;
                bool setCostCircleSpriteTextureHeightFirstValue = false;
                bool setCostCircleSpriteTextureHeightSecondValue = false;
                int CostCircleSpriteTextureHeightFirstValue= 0;
                int CostCircleSpriteTextureHeightSecondValue= 0;
                bool setCostCircleSpriteTextureLeftFirstValue = false;
                bool setCostCircleSpriteTextureLeftSecondValue = false;
                int CostCircleSpriteTextureLeftFirstValue= 0;
                int CostCircleSpriteTextureLeftSecondValue= 0;
                bool setCostCircleSpriteTextureTopFirstValue = false;
                bool setCostCircleSpriteTextureTopSecondValue = false;
                int CostCircleSpriteTextureTopFirstValue= 0;
                int CostCircleSpriteTextureTopSecondValue= 0;
                bool setCostCircleSpriteTextureWidthFirstValue = false;
                bool setCostCircleSpriteTextureWidthSecondValue = false;
                int CostCircleSpriteTextureWidthFirstValue= 0;
                int CostCircleSpriteTextureWidthSecondValue= 0;
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setMineralCostContainerHeightFirstValue = false;
                bool setMineralCostContainerHeightSecondValue = false;
                float MineralCostContainerHeightFirstValue= 0;
                float MineralCostContainerHeightSecondValue= 0;
                bool setMineralCostContainerWidthFirstValue = false;
                bool setMineralCostContainerWidthSecondValue = false;
                float MineralCostContainerWidthFirstValue= 0;
                float MineralCostContainerWidthSecondValue= 0;
                bool setMineralCostContainerXFirstValue = false;
                bool setMineralCostContainerXSecondValue = false;
                float MineralCostContainerXFirstValue= 0;
                float MineralCostContainerXSecondValue= 0;
                bool setMineralCostContainerYFirstValue = false;
                bool setMineralCostContainerYSecondValue = false;
                float MineralCostContainerYFirstValue= 0;
                float MineralCostContainerYSecondValue= 0;
                bool setMineralsTextFontScaleFirstValue = false;
                bool setMineralsTextFontScaleSecondValue = false;
                float MineralsTextFontScaleFirstValue= 0;
                float MineralsTextFontScaleSecondValue= 0;
                bool setMineralsTextFontSizeFirstValue = false;
                bool setMineralsTextFontSizeSecondValue = false;
                int MineralsTextFontSizeFirstValue= 0;
                int MineralsTextFontSizeSecondValue= 0;
                bool setMineralsTextHeightFirstValue = false;
                bool setMineralsTextHeightSecondValue = false;
                float MineralsTextHeightFirstValue= 0;
                float MineralsTextHeightSecondValue= 0;
                bool setMineralsTextOutlineThicknessFirstValue = false;
                bool setMineralsTextOutlineThicknessSecondValue = false;
                int MineralsTextOutlineThicknessFirstValue= 0;
                int MineralsTextOutlineThicknessSecondValue= 0;
                bool setMineralsTextWidthFirstValue = false;
                bool setMineralsTextWidthSecondValue = false;
                float MineralsTextWidthFirstValue= 0;
                float MineralsTextWidthSecondValue= 0;
                bool setMineralsTextXFirstValue = false;
                bool setMineralsTextXSecondValue = false;
                float MineralsTextXFirstValue= 0;
                float MineralsTextXSecondValue= 0;
                bool setStructureSpriteHeightFirstValue = false;
                bool setStructureSpriteHeightSecondValue = false;
                float StructureSpriteHeightFirstValue= 0;
                float StructureSpriteHeightSecondValue= 0;
                bool setStructureSpriteWidthFirstValue = false;
                bool setStructureSpriteWidthSecondValue = false;
                float StructureSpriteWidthFirstValue= 0;
                float StructureSpriteWidthSecondValue= 0;
                bool setStructureSpriteYFirstValue = false;
                bool setStructureSpriteYSecondValue = false;
                float StructureSpriteYFirstValue= 0;
                float StructureSpriteYSecondValue= 0;
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                bool setXFirstValue = false;
                bool setXSecondValue = false;
                float XFirstValue= 0;
                float XSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setButtonCircleSpriteBlueFirstValue = true;
                        ButtonCircleSpriteBlueFirstValue = 255;
                        setButtonCircleSpriteGreenFirstValue = true;
                        ButtonCircleSpriteGreenFirstValue = 255;
                        setButtonCircleSpriteHeightFirstValue = true;
                        ButtonCircleSpriteHeightFirstValue = 85f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonCircleSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setButtonCircleSpriteRedFirstValue = true;
                        ButtonCircleSpriteRedFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            SetProperty("ButtonCircleSprite.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.ButtonCircleSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setButtonCircleSpriteTextureHeightFirstValue = true;
                        ButtonCircleSpriteTextureHeightFirstValue = 480;
                        setButtonCircleSpriteTextureLeftFirstValue = true;
                        ButtonCircleSpriteTextureLeftFirstValue = 516;
                        setButtonCircleSpriteTextureTopFirstValue = true;
                        ButtonCircleSpriteTextureTopFirstValue = 1076;
                        setButtonCircleSpriteTextureWidthFirstValue = true;
                        ButtonCircleSpriteTextureWidthFirstValue = 480;
                        if (interpolationValue < 1)
                        {
                            this.ButtonCircleSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        setButtonCircleSpriteXFirstValue = true;
                        ButtonCircleSpriteXFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonCircleSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ButtonCircleSprite.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonCircleSpriteYFirstValue = true;
                        ButtonCircleSpriteYFirstValue = 5f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonCircleSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ButtonCircleSprite.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ClipsChildren = false;
                        }
                        setCostCircleSpriteBlueFirstValue = true;
                        CostCircleSpriteBlueFirstValue = 158;
                        setCostCircleSpriteGreenFirstValue = true;
                        CostCircleSpriteGreenFirstValue = 75;
                        setCostCircleSpriteHeightFirstValue = true;
                        CostCircleSpriteHeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.CostCircleSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CostCircleSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "MineralCostContainer");
                        }
                        setCostCircleSpriteRedFirstValue = true;
                        CostCircleSpriteRedFirstValue = 120;
                        if (interpolationValue < 1)
                        {
                            SetProperty("CostCircleSprite.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.CostCircleSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setCostCircleSpriteTextureHeightFirstValue = true;
                        CostCircleSpriteTextureHeightFirstValue = 480;
                        setCostCircleSpriteTextureLeftFirstValue = true;
                        CostCircleSpriteTextureLeftFirstValue = 516;
                        setCostCircleSpriteTextureTopFirstValue = true;
                        CostCircleSpriteTextureTopFirstValue = 1076;
                        setCostCircleSpriteTextureWidthFirstValue = true;
                        CostCircleSpriteTextureWidthFirstValue = 480;
                        if (interpolationValue < 1)
                        {
                            this.CostCircleSprite.Visible = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CostCircleSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CostCircleSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CostCircleSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CostCircleSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CostCircleSprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setHeightFirstValue = true;
                        HeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MineralCostContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setMineralCostContainerHeightFirstValue = true;
                        MineralCostContainerHeightFirstValue = 55f;
                        if (interpolationValue < 1)
                        {
                            this.MineralCostContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setMineralCostContainerWidthFirstValue = true;
                        MineralCostContainerWidthFirstValue = 55f;
                        if (interpolationValue < 1)
                        {
                            this.MineralCostContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setMineralCostContainerXFirstValue = true;
                        MineralCostContainerXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.MineralCostContainer.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setMineralCostContainerYFirstValue = true;
                        MineralCostContainerYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.MineralCostContainer.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MineralCostContainer.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("MineralsText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        if (interpolationValue < 1)
                        {
                            this.MineralsText.Font = "Moire ExtraBold";
                        }
                        setMineralsTextFontScaleFirstValue = true;
                        MineralsTextFontScaleFirstValue = 0.9f;
                        setMineralsTextFontSizeFirstValue = true;
                        MineralsTextFontSizeFirstValue = 50;
                        setMineralsTextHeightFirstValue = true;
                        MineralsTextHeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.MineralsText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MineralsText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setMineralsTextOutlineThicknessFirstValue = true;
                        MineralsTextOutlineThicknessFirstValue = 2;
                        if (interpolationValue < 1)
                        {
                            this.MineralsText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "CostCircleSprite");
                        }
                        if (interpolationValue < 1)
                        {
                            this.MineralsText.Text = "100";
                        }
                        if (interpolationValue < 1)
                        {
                            this.MineralsText.UseCustomFont = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MineralsText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setMineralsTextWidthFirstValue = true;
                        MineralsTextWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.MineralsText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setMineralsTextXFirstValue = true;
                        MineralsTextXFirstValue = 1f;
                        if (interpolationValue < 1)
                        {
                            this.MineralsText.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MineralsText.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MineralsText.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setStructureSpriteHeightFirstValue = true;
                        StructureSpriteHeightFirstValue = 102f;
                        if (interpolationValue < 1)
                        {
                            this.StructureSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.StructureSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ButtonCircleSprite");
                        }
                        if (interpolationValue < 1)
                        {
                            this.StructureSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setStructureSpriteWidthFirstValue = true;
                        StructureSpriteWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.StructureSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.StructureSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.StructureSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setStructureSpriteYFirstValue = true;
                        StructureSpriteYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.StructureSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.StructureSprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Visible = true;
                        }
                        setWidthFirstValue = true;
                        WidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        if (interpolationValue < 1)
                        {
                            this.WrapsChildren = false;
                        }
                        setXFirstValue = true;
                        XFirstValue = 1f;
                        if (interpolationValue < 1)
                        {
                            this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue < 1)
                        {
                            this.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setButtonCircleSpriteBlueSecondValue = true;
                        ButtonCircleSpriteBlueSecondValue = 255;
                        setButtonCircleSpriteGreenSecondValue = true;
                        ButtonCircleSpriteGreenSecondValue = 255;
                        setButtonCircleSpriteHeightSecondValue = true;
                        ButtonCircleSpriteHeightSecondValue = 85f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonCircleSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setButtonCircleSpriteRedSecondValue = true;
                        ButtonCircleSpriteRedSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("ButtonCircleSprite.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ButtonCircleSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setButtonCircleSpriteTextureHeightSecondValue = true;
                        ButtonCircleSpriteTextureHeightSecondValue = 480;
                        setButtonCircleSpriteTextureLeftSecondValue = true;
                        ButtonCircleSpriteTextureLeftSecondValue = 516;
                        setButtonCircleSpriteTextureTopSecondValue = true;
                        ButtonCircleSpriteTextureTopSecondValue = 1076;
                        setButtonCircleSpriteTextureWidthSecondValue = true;
                        ButtonCircleSpriteTextureWidthSecondValue = 480;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonCircleSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        setButtonCircleSpriteXSecondValue = true;
                        ButtonCircleSpriteXSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonCircleSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ButtonCircleSprite.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonCircleSpriteYSecondValue = true;
                        ButtonCircleSpriteYSecondValue = 5f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonCircleSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ButtonCircleSprite.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ClipsChildren = false;
                        }
                        setCostCircleSpriteBlueSecondValue = true;
                        CostCircleSpriteBlueSecondValue = 158;
                        setCostCircleSpriteGreenSecondValue = true;
                        CostCircleSpriteGreenSecondValue = 75;
                        setCostCircleSpriteHeightSecondValue = true;
                        CostCircleSpriteHeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.CostCircleSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CostCircleSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "MineralCostContainer");
                        }
                        setCostCircleSpriteRedSecondValue = true;
                        CostCircleSpriteRedSecondValue = 120;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("CostCircleSprite.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CostCircleSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setCostCircleSpriteTextureHeightSecondValue = true;
                        CostCircleSpriteTextureHeightSecondValue = 480;
                        setCostCircleSpriteTextureLeftSecondValue = true;
                        CostCircleSpriteTextureLeftSecondValue = 516;
                        setCostCircleSpriteTextureTopSecondValue = true;
                        CostCircleSpriteTextureTopSecondValue = 1076;
                        setCostCircleSpriteTextureWidthSecondValue = true;
                        CostCircleSpriteTextureWidthSecondValue = 480;
                        if (interpolationValue >= 1)
                        {
                            this.CostCircleSprite.Visible = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CostCircleSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CostCircleSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CostCircleSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CostCircleSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CostCircleSprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setHeightSecondValue = true;
                        HeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MineralCostContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setMineralCostContainerHeightSecondValue = true;
                        MineralCostContainerHeightSecondValue = 55f;
                        if (interpolationValue >= 1)
                        {
                            this.MineralCostContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setMineralCostContainerWidthSecondValue = true;
                        MineralCostContainerWidthSecondValue = 55f;
                        if (interpolationValue >= 1)
                        {
                            this.MineralCostContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setMineralCostContainerXSecondValue = true;
                        MineralCostContainerXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.MineralCostContainer.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setMineralCostContainerYSecondValue = true;
                        MineralCostContainerYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.MineralCostContainer.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MineralCostContainer.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("MineralsText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MineralsText.Font = "Moire ExtraBold";
                        }
                        setMineralsTextFontScaleSecondValue = true;
                        MineralsTextFontScaleSecondValue = 0.9f;
                        setMineralsTextFontSizeSecondValue = true;
                        MineralsTextFontSizeSecondValue = 50;
                        setMineralsTextHeightSecondValue = true;
                        MineralsTextHeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.MineralsText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MineralsText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setMineralsTextOutlineThicknessSecondValue = true;
                        MineralsTextOutlineThicknessSecondValue = 2;
                        if (interpolationValue >= 1)
                        {
                            this.MineralsText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "CostCircleSprite");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MineralsText.Text = "100";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MineralsText.UseCustomFont = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MineralsText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setMineralsTextWidthSecondValue = true;
                        MineralsTextWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.MineralsText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setMineralsTextXSecondValue = true;
                        MineralsTextXSecondValue = 1f;
                        if (interpolationValue >= 1)
                        {
                            this.MineralsText.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MineralsText.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MineralsText.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setStructureSpriteHeightSecondValue = true;
                        StructureSpriteHeightSecondValue = 102f;
                        if (interpolationValue >= 1)
                        {
                            this.StructureSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.StructureSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ButtonCircleSprite");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.StructureSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setStructureSpriteWidthSecondValue = true;
                        StructureSpriteWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.StructureSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.StructureSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.StructureSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setStructureSpriteYSecondValue = true;
                        StructureSpriteYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.StructureSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.StructureSprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Visible = true;
                        }
                        setWidthSecondValue = true;
                        WidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.WrapsChildren = false;
                        }
                        setXSecondValue = true;
                        XSecondValue = 1f;
                        if (interpolationValue >= 1)
                        {
                            this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        break;
                }
                if (setButtonCircleSpriteBlueFirstValue && setButtonCircleSpriteBlueSecondValue)
                {
                    ButtonCircleSprite.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(ButtonCircleSpriteBlueFirstValue* (1 - interpolationValue) + ButtonCircleSpriteBlueSecondValue * interpolationValue);
                }
                if (setButtonCircleSpriteGreenFirstValue && setButtonCircleSpriteGreenSecondValue)
                {
                    ButtonCircleSprite.Green = FlatRedBall.Math.MathFunctions.RoundToInt(ButtonCircleSpriteGreenFirstValue* (1 - interpolationValue) + ButtonCircleSpriteGreenSecondValue * interpolationValue);
                }
                if (setButtonCircleSpriteHeightFirstValue && setButtonCircleSpriteHeightSecondValue)
                {
                    ButtonCircleSprite.Height = ButtonCircleSpriteHeightFirstValue * (1 - interpolationValue) + ButtonCircleSpriteHeightSecondValue * interpolationValue;
                }
                if (setButtonCircleSpriteRedFirstValue && setButtonCircleSpriteRedSecondValue)
                {
                    ButtonCircleSprite.Red = FlatRedBall.Math.MathFunctions.RoundToInt(ButtonCircleSpriteRedFirstValue* (1 - interpolationValue) + ButtonCircleSpriteRedSecondValue * interpolationValue);
                }
                if (setButtonCircleSpriteTextureHeightFirstValue && setButtonCircleSpriteTextureHeightSecondValue)
                {
                    ButtonCircleSprite.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(ButtonCircleSpriteTextureHeightFirstValue* (1 - interpolationValue) + ButtonCircleSpriteTextureHeightSecondValue * interpolationValue);
                }
                if (setButtonCircleSpriteTextureLeftFirstValue && setButtonCircleSpriteTextureLeftSecondValue)
                {
                    ButtonCircleSprite.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(ButtonCircleSpriteTextureLeftFirstValue* (1 - interpolationValue) + ButtonCircleSpriteTextureLeftSecondValue * interpolationValue);
                }
                if (setButtonCircleSpriteTextureTopFirstValue && setButtonCircleSpriteTextureTopSecondValue)
                {
                    ButtonCircleSprite.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(ButtonCircleSpriteTextureTopFirstValue* (1 - interpolationValue) + ButtonCircleSpriteTextureTopSecondValue * interpolationValue);
                }
                if (setButtonCircleSpriteTextureWidthFirstValue && setButtonCircleSpriteTextureWidthSecondValue)
                {
                    ButtonCircleSprite.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(ButtonCircleSpriteTextureWidthFirstValue* (1 - interpolationValue) + ButtonCircleSpriteTextureWidthSecondValue * interpolationValue);
                }
                if (setButtonCircleSpriteXFirstValue && setButtonCircleSpriteXSecondValue)
                {
                    ButtonCircleSprite.X = ButtonCircleSpriteXFirstValue * (1 - interpolationValue) + ButtonCircleSpriteXSecondValue * interpolationValue;
                }
                if (setButtonCircleSpriteYFirstValue && setButtonCircleSpriteYSecondValue)
                {
                    ButtonCircleSprite.Y = ButtonCircleSpriteYFirstValue * (1 - interpolationValue) + ButtonCircleSpriteYSecondValue * interpolationValue;
                }
                if (setCostCircleSpriteBlueFirstValue && setCostCircleSpriteBlueSecondValue)
                {
                    CostCircleSprite.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(CostCircleSpriteBlueFirstValue* (1 - interpolationValue) + CostCircleSpriteBlueSecondValue * interpolationValue);
                }
                if (setCostCircleSpriteGreenFirstValue && setCostCircleSpriteGreenSecondValue)
                {
                    CostCircleSprite.Green = FlatRedBall.Math.MathFunctions.RoundToInt(CostCircleSpriteGreenFirstValue* (1 - interpolationValue) + CostCircleSpriteGreenSecondValue * interpolationValue);
                }
                if (setCostCircleSpriteHeightFirstValue && setCostCircleSpriteHeightSecondValue)
                {
                    CostCircleSprite.Height = CostCircleSpriteHeightFirstValue * (1 - interpolationValue) + CostCircleSpriteHeightSecondValue * interpolationValue;
                }
                if (setCostCircleSpriteRedFirstValue && setCostCircleSpriteRedSecondValue)
                {
                    CostCircleSprite.Red = FlatRedBall.Math.MathFunctions.RoundToInt(CostCircleSpriteRedFirstValue* (1 - interpolationValue) + CostCircleSpriteRedSecondValue * interpolationValue);
                }
                if (setCostCircleSpriteTextureHeightFirstValue && setCostCircleSpriteTextureHeightSecondValue)
                {
                    CostCircleSprite.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(CostCircleSpriteTextureHeightFirstValue* (1 - interpolationValue) + CostCircleSpriteTextureHeightSecondValue * interpolationValue);
                }
                if (setCostCircleSpriteTextureLeftFirstValue && setCostCircleSpriteTextureLeftSecondValue)
                {
                    CostCircleSprite.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(CostCircleSpriteTextureLeftFirstValue* (1 - interpolationValue) + CostCircleSpriteTextureLeftSecondValue * interpolationValue);
                }
                if (setCostCircleSpriteTextureTopFirstValue && setCostCircleSpriteTextureTopSecondValue)
                {
                    CostCircleSprite.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(CostCircleSpriteTextureTopFirstValue* (1 - interpolationValue) + CostCircleSpriteTextureTopSecondValue * interpolationValue);
                }
                if (setCostCircleSpriteTextureWidthFirstValue && setCostCircleSpriteTextureWidthSecondValue)
                {
                    CostCircleSprite.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(CostCircleSpriteTextureWidthFirstValue* (1 - interpolationValue) + CostCircleSpriteTextureWidthSecondValue * interpolationValue);
                }
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
                }
                if (setMineralCostContainerHeightFirstValue && setMineralCostContainerHeightSecondValue)
                {
                    MineralCostContainer.Height = MineralCostContainerHeightFirstValue * (1 - interpolationValue) + MineralCostContainerHeightSecondValue * interpolationValue;
                }
                if (setMineralCostContainerWidthFirstValue && setMineralCostContainerWidthSecondValue)
                {
                    MineralCostContainer.Width = MineralCostContainerWidthFirstValue * (1 - interpolationValue) + MineralCostContainerWidthSecondValue * interpolationValue;
                }
                if (setMineralCostContainerXFirstValue && setMineralCostContainerXSecondValue)
                {
                    MineralCostContainer.X = MineralCostContainerXFirstValue * (1 - interpolationValue) + MineralCostContainerXSecondValue * interpolationValue;
                }
                if (setMineralCostContainerYFirstValue && setMineralCostContainerYSecondValue)
                {
                    MineralCostContainer.Y = MineralCostContainerYFirstValue * (1 - interpolationValue) + MineralCostContainerYSecondValue * interpolationValue;
                }
                if (setMineralsTextFontScaleFirstValue && setMineralsTextFontScaleSecondValue)
                {
                    MineralsText.FontScale = MineralsTextFontScaleFirstValue * (1 - interpolationValue) + MineralsTextFontScaleSecondValue * interpolationValue;
                }
                if (setMineralsTextFontSizeFirstValue && setMineralsTextFontSizeSecondValue)
                {
                    MineralsText.FontSize = FlatRedBall.Math.MathFunctions.RoundToInt(MineralsTextFontSizeFirstValue* (1 - interpolationValue) + MineralsTextFontSizeSecondValue * interpolationValue);
                }
                if (setMineralsTextHeightFirstValue && setMineralsTextHeightSecondValue)
                {
                    MineralsText.Height = MineralsTextHeightFirstValue * (1 - interpolationValue) + MineralsTextHeightSecondValue * interpolationValue;
                }
                if (setMineralsTextOutlineThicknessFirstValue && setMineralsTextOutlineThicknessSecondValue)
                {
                    MineralsText.OutlineThickness = FlatRedBall.Math.MathFunctions.RoundToInt(MineralsTextOutlineThicknessFirstValue* (1 - interpolationValue) + MineralsTextOutlineThicknessSecondValue * interpolationValue);
                }
                if (setMineralsTextWidthFirstValue && setMineralsTextWidthSecondValue)
                {
                    MineralsText.Width = MineralsTextWidthFirstValue * (1 - interpolationValue) + MineralsTextWidthSecondValue * interpolationValue;
                }
                if (setMineralsTextXFirstValue && setMineralsTextXSecondValue)
                {
                    MineralsText.X = MineralsTextXFirstValue * (1 - interpolationValue) + MineralsTextXSecondValue * interpolationValue;
                }
                if (setStructureSpriteHeightFirstValue && setStructureSpriteHeightSecondValue)
                {
                    StructureSprite.Height = StructureSpriteHeightFirstValue * (1 - interpolationValue) + StructureSpriteHeightSecondValue * interpolationValue;
                }
                if (setStructureSpriteWidthFirstValue && setStructureSpriteWidthSecondValue)
                {
                    StructureSprite.Width = StructureSpriteWidthFirstValue * (1 - interpolationValue) + StructureSpriteWidthSecondValue * interpolationValue;
                }
                if (setStructureSpriteYFirstValue && setStructureSpriteYSecondValue)
                {
                    StructureSprite.Y = StructureSpriteYFirstValue * (1 - interpolationValue) + StructureSpriteYSecondValue * interpolationValue;
                }
                if (setWidthFirstValue && setWidthSecondValue)
                {
                    Width = WidthFirstValue * (1 - interpolationValue) + WidthSecondValue * interpolationValue;
                }
                if (setXFirstValue && setXSecondValue)
                {
                    X = XFirstValue * (1 - interpolationValue) + XSecondValue * interpolationValue;
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
            public void InterpolateBetween (StructureType firstState, StructureType secondState, float interpolationValue)
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setButtonCircleSpriteBlueFirstValue = false;
                bool setButtonCircleSpriteBlueSecondValue = false;
                int ButtonCircleSpriteBlueFirstValue= 0;
                int ButtonCircleSpriteBlueSecondValue= 0;
                bool setButtonCircleSpriteGreenFirstValue = false;
                bool setButtonCircleSpriteGreenSecondValue = false;
                int ButtonCircleSpriteGreenFirstValue= 0;
                int ButtonCircleSpriteGreenSecondValue= 0;
                bool setButtonCircleSpriteRedFirstValue = false;
                bool setButtonCircleSpriteRedSecondValue = false;
                int ButtonCircleSpriteRedFirstValue= 0;
                int ButtonCircleSpriteRedSecondValue= 0;
                switch(firstState)
                {
                    case  StructureType.Energy:
                        setButtonCircleSpriteBlueFirstValue = true;
                        ButtonCircleSpriteBlueFirstValue = 3;
                        setButtonCircleSpriteGreenFirstValue = true;
                        ButtonCircleSpriteGreenFirstValue = 213;
                        setButtonCircleSpriteRedFirstValue = true;
                        ButtonCircleSpriteRedFirstValue = 255;
                        break;
                    case  StructureType.Combat:
                        setButtonCircleSpriteBlueFirstValue = true;
                        ButtonCircleSpriteBlueFirstValue = 236;
                        setButtonCircleSpriteGreenFirstValue = true;
                        ButtonCircleSpriteGreenFirstValue = 207;
                        setButtonCircleSpriteRedFirstValue = true;
                        ButtonCircleSpriteRedFirstValue = 113;
                        break;
                    case  StructureType.Utility:
                        setButtonCircleSpriteBlueFirstValue = true;
                        ButtonCircleSpriteBlueFirstValue = 212;
                        setButtonCircleSpriteGreenFirstValue = true;
                        ButtonCircleSpriteGreenFirstValue = 210;
                        setButtonCircleSpriteRedFirstValue = true;
                        ButtonCircleSpriteRedFirstValue = 209;
                        break;
                }
                switch(secondState)
                {
                    case  StructureType.Energy:
                        setButtonCircleSpriteBlueSecondValue = true;
                        ButtonCircleSpriteBlueSecondValue = 3;
                        setButtonCircleSpriteGreenSecondValue = true;
                        ButtonCircleSpriteGreenSecondValue = 213;
                        setButtonCircleSpriteRedSecondValue = true;
                        ButtonCircleSpriteRedSecondValue = 255;
                        break;
                    case  StructureType.Combat:
                        setButtonCircleSpriteBlueSecondValue = true;
                        ButtonCircleSpriteBlueSecondValue = 236;
                        setButtonCircleSpriteGreenSecondValue = true;
                        ButtonCircleSpriteGreenSecondValue = 207;
                        setButtonCircleSpriteRedSecondValue = true;
                        ButtonCircleSpriteRedSecondValue = 113;
                        break;
                    case  StructureType.Utility:
                        setButtonCircleSpriteBlueSecondValue = true;
                        ButtonCircleSpriteBlueSecondValue = 212;
                        setButtonCircleSpriteGreenSecondValue = true;
                        ButtonCircleSpriteGreenSecondValue = 210;
                        setButtonCircleSpriteRedSecondValue = true;
                        ButtonCircleSpriteRedSecondValue = 209;
                        break;
                }
                if (setButtonCircleSpriteBlueFirstValue && setButtonCircleSpriteBlueSecondValue)
                {
                    ButtonCircleSprite.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(ButtonCircleSpriteBlueFirstValue* (1 - interpolationValue) + ButtonCircleSpriteBlueSecondValue * interpolationValue);
                }
                if (setButtonCircleSpriteGreenFirstValue && setButtonCircleSpriteGreenSecondValue)
                {
                    ButtonCircleSprite.Green = FlatRedBall.Math.MathFunctions.RoundToInt(ButtonCircleSpriteGreenFirstValue* (1 - interpolationValue) + ButtonCircleSpriteGreenSecondValue * interpolationValue);
                }
                if (setButtonCircleSpriteRedFirstValue && setButtonCircleSpriteRedSecondValue)
                {
                    ButtonCircleSprite.Red = FlatRedBall.Math.MathFunctions.RoundToInt(ButtonCircleSpriteRedFirstValue* (1 - interpolationValue) + ButtonCircleSpriteRedSecondValue * interpolationValue);
                }
                if (interpolationValue < 1)
                {
                    mCurrentStructureTypeState = firstState;
                }
                else
                {
                    mCurrentStructureTypeState = secondState;
                }
            }
            public void InterpolateBetween (EnabledStatus firstState, EnabledStatus secondState, float interpolationValue)
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setStructureSpriteAlphaFirstValue = false;
                bool setStructureSpriteAlphaSecondValue = false;
                int StructureSpriteAlphaFirstValue= 0;
                int StructureSpriteAlphaSecondValue= 0;
                switch(firstState)
                {
                    case  EnabledStatus.Enabled:
                        setStructureSpriteAlphaFirstValue = true;
                        StructureSpriteAlphaFirstValue = 255;
                        break;
                    case  EnabledStatus.Disabled:
                        setStructureSpriteAlphaFirstValue = true;
                        StructureSpriteAlphaFirstValue = 50;
                        break;
                }
                switch(secondState)
                {
                    case  EnabledStatus.Enabled:
                        setStructureSpriteAlphaSecondValue = true;
                        StructureSpriteAlphaSecondValue = 255;
                        break;
                    case  EnabledStatus.Disabled:
                        setStructureSpriteAlphaSecondValue = true;
                        StructureSpriteAlphaSecondValue = 50;
                        break;
                }
                if (setStructureSpriteAlphaFirstValue && setStructureSpriteAlphaSecondValue)
                {
                    StructureSprite.Alpha = FlatRedBall.Math.MathFunctions.RoundToInt(StructureSpriteAlphaFirstValue* (1 - interpolationValue) + StructureSpriteAlphaSecondValue * interpolationValue);
                }
                if (interpolationValue < 1)
                {
                    mCurrentEnabledStatusState = firstState;
                }
                else
                {
                    mCurrentEnabledStatusState = secondState;
                }
            }
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null)
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime.StructureType fromState,AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime.StructureType toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null)
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (StructureType toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null )
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "StructureType").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentStructureTypeState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (StructureType toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null )
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
                tweener.Ended += ()=> this.CurrentStructureTypeState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime.EnabledStatus fromState,AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime.EnabledStatus toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null)
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (EnabledStatus toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null )
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "EnabledStatus").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentEnabledStatusState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (EnabledStatus toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null )
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
                tweener.Ended += ()=> this.CurrentEnabledStatusState = toState;
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
                            Name = "X",
                            Type = "float",
                            Value = X
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
                            Name = "ButtonCircleSprite.Blue",
                            Type = "int",
                            Value = ButtonCircleSprite.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonCircleSprite.Green",
                            Type = "int",
                            Value = ButtonCircleSprite.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonCircleSprite.Height",
                            Type = "float",
                            Value = ButtonCircleSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonCircleSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = ButtonCircleSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonCircleSprite.Red",
                            Type = "int",
                            Value = ButtonCircleSprite.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonCircleSprite.SourceFile",
                            Type = "string",
                            Value = ButtonCircleSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonCircleSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = ButtonCircleSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonCircleSprite.Texture Height",
                            Type = "int",
                            Value = ButtonCircleSprite.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonCircleSprite.Texture Left",
                            Type = "int",
                            Value = ButtonCircleSprite.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonCircleSprite.Texture Top",
                            Type = "int",
                            Value = ButtonCircleSprite.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonCircleSprite.Texture Width",
                            Type = "int",
                            Value = ButtonCircleSprite.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonCircleSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = ButtonCircleSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonCircleSprite.X",
                            Type = "float",
                            Value = ButtonCircleSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonCircleSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ButtonCircleSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonCircleSprite.X Units",
                            Type = "PositionUnitType",
                            Value = ButtonCircleSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonCircleSprite.Y",
                            Type = "float",
                            Value = ButtonCircleSprite.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonCircleSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = ButtonCircleSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonCircleSprite.Y Units",
                            Type = "PositionUnitType",
                            Value = ButtonCircleSprite.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureSprite.Height",
                            Type = "float",
                            Value = StructureSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = StructureSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureSprite.Parent",
                            Type = "string",
                            Value = StructureSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = StructureSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureSprite.Width",
                            Type = "float",
                            Value = StructureSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = StructureSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = StructureSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureSprite.X Units",
                            Type = "PositionUnitType",
                            Value = StructureSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureSprite.Y",
                            Type = "float",
                            Value = StructureSprite.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = StructureSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureSprite.Y Units",
                            Type = "PositionUnitType",
                            Value = StructureSprite.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralCostContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = MineralCostContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralCostContainer.Height",
                            Type = "float",
                            Value = MineralCostContainer.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralCostContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = MineralCostContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralCostContainer.Width",
                            Type = "float",
                            Value = MineralCostContainer.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralCostContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = MineralCostContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralCostContainer.X",
                            Type = "float",
                            Value = MineralCostContainer.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralCostContainer.X Units",
                            Type = "PositionUnitType",
                            Value = MineralCostContainer.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralCostContainer.Y",
                            Type = "float",
                            Value = MineralCostContainer.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralCostContainer.Y Origin",
                            Type = "VerticalAlignment",
                            Value = MineralCostContainer.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralCostContainer.Y Units",
                            Type = "PositionUnitType",
                            Value = MineralCostContainer.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostCircleSprite.Blue",
                            Type = "int",
                            Value = CostCircleSprite.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostCircleSprite.Green",
                            Type = "int",
                            Value = CostCircleSprite.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostCircleSprite.Height",
                            Type = "float",
                            Value = CostCircleSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostCircleSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = CostCircleSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostCircleSprite.Parent",
                            Type = "string",
                            Value = CostCircleSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostCircleSprite.Red",
                            Type = "int",
                            Value = CostCircleSprite.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostCircleSprite.SourceFile",
                            Type = "string",
                            Value = CostCircleSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostCircleSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = CostCircleSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostCircleSprite.Texture Height",
                            Type = "int",
                            Value = CostCircleSprite.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostCircleSprite.Texture Left",
                            Type = "int",
                            Value = CostCircleSprite.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostCircleSprite.Texture Top",
                            Type = "int",
                            Value = CostCircleSprite.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostCircleSprite.Texture Width",
                            Type = "int",
                            Value = CostCircleSprite.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostCircleSprite.Visible",
                            Type = "bool",
                            Value = CostCircleSprite.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostCircleSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = CostCircleSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostCircleSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = CostCircleSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostCircleSprite.X Units",
                            Type = "PositionUnitType",
                            Value = CostCircleSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostCircleSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = CostCircleSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostCircleSprite.Y Units",
                            Type = "PositionUnitType",
                            Value = CostCircleSprite.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsText.CustomFontFile",
                            Type = "string",
                            Value = MineralsText.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsText.Font",
                            Type = "string",
                            Value = MineralsText.Font
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsText.Font Scale",
                            Type = "float",
                            Value = MineralsText.FontScale
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsText.FontSize",
                            Type = "int",
                            Value = MineralsText.FontSize
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsText.Height",
                            Type = "float",
                            Value = MineralsText.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsText.Height Units",
                            Type = "DimensionUnitType",
                            Value = MineralsText.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = MineralsText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsText.OutlineThickness",
                            Type = "int",
                            Value = MineralsText.OutlineThickness
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsText.Parent",
                            Type = "string",
                            Value = MineralsText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsText.Text",
                            Type = "string",
                            Value = MineralsText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsText.UseCustomFont",
                            Type = "bool",
                            Value = MineralsText.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = MineralsText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsText.Width",
                            Type = "float",
                            Value = MineralsText.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsText.Width Units",
                            Type = "DimensionUnitType",
                            Value = MineralsText.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsText.X",
                            Type = "float",
                            Value = MineralsText.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsText.X Units",
                            Type = "PositionUnitType",
                            Value = MineralsText.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsText.Y Origin",
                            Type = "VerticalAlignment",
                            Value = MineralsText.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsText.Y Units",
                            Type = "PositionUnitType",
                            Value = MineralsText.YUnits
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
                            Value = Height + 100f
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
                            Name = "Wraps Children",
                            Type = "bool",
                            Value = WrapsChildren
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "X",
                            Type = "float",
                            Value = X + 1f
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
                            Name = "ButtonCircleSprite.Blue",
                            Type = "int",
                            Value = ButtonCircleSprite.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonCircleSprite.Green",
                            Type = "int",
                            Value = ButtonCircleSprite.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonCircleSprite.Height",
                            Type = "float",
                            Value = ButtonCircleSprite.Height + 85f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonCircleSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = ButtonCircleSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonCircleSprite.Red",
                            Type = "int",
                            Value = ButtonCircleSprite.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonCircleSprite.SourceFile",
                            Type = "string",
                            Value = ButtonCircleSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonCircleSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = ButtonCircleSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonCircleSprite.Texture Height",
                            Type = "int",
                            Value = ButtonCircleSprite.TextureHeight + 480
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonCircleSprite.Texture Left",
                            Type = "int",
                            Value = ButtonCircleSprite.TextureLeft + 516
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonCircleSprite.Texture Top",
                            Type = "int",
                            Value = ButtonCircleSprite.TextureTop + 1076
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonCircleSprite.Texture Width",
                            Type = "int",
                            Value = ButtonCircleSprite.TextureWidth + 480
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonCircleSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = ButtonCircleSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonCircleSprite.X",
                            Type = "float",
                            Value = ButtonCircleSprite.X + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonCircleSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ButtonCircleSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonCircleSprite.X Units",
                            Type = "PositionUnitType",
                            Value = ButtonCircleSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonCircleSprite.Y",
                            Type = "float",
                            Value = ButtonCircleSprite.Y + 5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonCircleSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = ButtonCircleSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonCircleSprite.Y Units",
                            Type = "PositionUnitType",
                            Value = ButtonCircleSprite.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureSprite.Height",
                            Type = "float",
                            Value = StructureSprite.Height + 102f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = StructureSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureSprite.Parent",
                            Type = "string",
                            Value = StructureSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = StructureSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureSprite.Width",
                            Type = "float",
                            Value = StructureSprite.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = StructureSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = StructureSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureSprite.X Units",
                            Type = "PositionUnitType",
                            Value = StructureSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureSprite.Y",
                            Type = "float",
                            Value = StructureSprite.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = StructureSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureSprite.Y Units",
                            Type = "PositionUnitType",
                            Value = StructureSprite.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralCostContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = MineralCostContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralCostContainer.Height",
                            Type = "float",
                            Value = MineralCostContainer.Height + 55f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralCostContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = MineralCostContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralCostContainer.Width",
                            Type = "float",
                            Value = MineralCostContainer.Width + 55f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralCostContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = MineralCostContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralCostContainer.X",
                            Type = "float",
                            Value = MineralCostContainer.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralCostContainer.X Units",
                            Type = "PositionUnitType",
                            Value = MineralCostContainer.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralCostContainer.Y",
                            Type = "float",
                            Value = MineralCostContainer.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralCostContainer.Y Origin",
                            Type = "VerticalAlignment",
                            Value = MineralCostContainer.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralCostContainer.Y Units",
                            Type = "PositionUnitType",
                            Value = MineralCostContainer.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostCircleSprite.Blue",
                            Type = "int",
                            Value = CostCircleSprite.Blue + 158
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostCircleSprite.Green",
                            Type = "int",
                            Value = CostCircleSprite.Green + 75
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostCircleSprite.Height",
                            Type = "float",
                            Value = CostCircleSprite.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostCircleSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = CostCircleSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostCircleSprite.Parent",
                            Type = "string",
                            Value = CostCircleSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostCircleSprite.Red",
                            Type = "int",
                            Value = CostCircleSprite.Red + 120
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostCircleSprite.SourceFile",
                            Type = "string",
                            Value = CostCircleSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostCircleSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = CostCircleSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostCircleSprite.Texture Height",
                            Type = "int",
                            Value = CostCircleSprite.TextureHeight + 480
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostCircleSprite.Texture Left",
                            Type = "int",
                            Value = CostCircleSprite.TextureLeft + 516
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostCircleSprite.Texture Top",
                            Type = "int",
                            Value = CostCircleSprite.TextureTop + 1076
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostCircleSprite.Texture Width",
                            Type = "int",
                            Value = CostCircleSprite.TextureWidth + 480
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostCircleSprite.Visible",
                            Type = "bool",
                            Value = CostCircleSprite.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostCircleSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = CostCircleSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostCircleSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = CostCircleSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostCircleSprite.X Units",
                            Type = "PositionUnitType",
                            Value = CostCircleSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostCircleSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = CostCircleSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CostCircleSprite.Y Units",
                            Type = "PositionUnitType",
                            Value = CostCircleSprite.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsText.CustomFontFile",
                            Type = "string",
                            Value = MineralsText.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsText.Font",
                            Type = "string",
                            Value = MineralsText.Font
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsText.Font Scale",
                            Type = "float",
                            Value = MineralsText.FontScale + 0.9f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsText.FontSize",
                            Type = "int",
                            Value = MineralsText.FontSize + 50
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsText.Height",
                            Type = "float",
                            Value = MineralsText.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsText.Height Units",
                            Type = "DimensionUnitType",
                            Value = MineralsText.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = MineralsText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsText.OutlineThickness",
                            Type = "int",
                            Value = MineralsText.OutlineThickness + 2
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsText.Parent",
                            Type = "string",
                            Value = MineralsText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsText.Text",
                            Type = "string",
                            Value = MineralsText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsText.UseCustomFont",
                            Type = "bool",
                            Value = MineralsText.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = MineralsText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsText.Width",
                            Type = "float",
                            Value = MineralsText.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsText.Width Units",
                            Type = "DimensionUnitType",
                            Value = MineralsText.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsText.X",
                            Type = "float",
                            Value = MineralsText.X + 1f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsText.X Units",
                            Type = "PositionUnitType",
                            Value = MineralsText.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsText.Y Origin",
                            Type = "VerticalAlignment",
                            Value = MineralsText.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsText.Y Units",
                            Type = "PositionUnitType",
                            Value = MineralsText.YUnits
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (StructureType state)
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  StructureType.Energy:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonCircleSprite.Blue",
                            Type = "int",
                            Value = ButtonCircleSprite.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonCircleSprite.Green",
                            Type = "int",
                            Value = ButtonCircleSprite.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonCircleSprite.Red",
                            Type = "int",
                            Value = ButtonCircleSprite.Red
                        }
                        );
                        break;
                    case  StructureType.Combat:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonCircleSprite.Blue",
                            Type = "int",
                            Value = ButtonCircleSprite.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonCircleSprite.Green",
                            Type = "int",
                            Value = ButtonCircleSprite.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonCircleSprite.Red",
                            Type = "int",
                            Value = ButtonCircleSprite.Red
                        }
                        );
                        break;
                    case  StructureType.Utility:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonCircleSprite.Blue",
                            Type = "int",
                            Value = ButtonCircleSprite.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonCircleSprite.Green",
                            Type = "int",
                            Value = ButtonCircleSprite.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonCircleSprite.Red",
                            Type = "int",
                            Value = ButtonCircleSprite.Red
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (StructureType state)
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  StructureType.Energy:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonCircleSprite.Blue",
                            Type = "int",
                            Value = ButtonCircleSprite.Blue + 3
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonCircleSprite.Green",
                            Type = "int",
                            Value = ButtonCircleSprite.Green + 213
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonCircleSprite.Red",
                            Type = "int",
                            Value = ButtonCircleSprite.Red + 255
                        }
                        );
                        break;
                    case  StructureType.Combat:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonCircleSprite.Blue",
                            Type = "int",
                            Value = ButtonCircleSprite.Blue + 236
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonCircleSprite.Green",
                            Type = "int",
                            Value = ButtonCircleSprite.Green + 207
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonCircleSprite.Red",
                            Type = "int",
                            Value = ButtonCircleSprite.Red + 113
                        }
                        );
                        break;
                    case  StructureType.Utility:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonCircleSprite.Blue",
                            Type = "int",
                            Value = ButtonCircleSprite.Blue + 212
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonCircleSprite.Green",
                            Type = "int",
                            Value = ButtonCircleSprite.Green + 210
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonCircleSprite.Red",
                            Type = "int",
                            Value = ButtonCircleSprite.Red + 209
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (EnabledStatus state)
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  EnabledStatus.Enabled:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureSprite.Alpha",
                            Type = "int",
                            Value = StructureSprite.Alpha
                        }
                        );
                        break;
                    case  EnabledStatus.Disabled:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureSprite.Alpha",
                            Type = "int",
                            Value = StructureSprite.Alpha
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (EnabledStatus state)
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  EnabledStatus.Enabled:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureSprite.Alpha",
                            Type = "int",
                            Value = StructureSprite.Alpha + 255
                        }
                        );
                        break;
                    case  EnabledStatus.Disabled:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureSprite.Alpha",
                            Type = "int",
                            Value = StructureSprite.Alpha + 50
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
                    else if (category.Name == "StructureType")
                    {
                        if(state.Name == "Energy") this.mCurrentStructureTypeState = StructureType.Energy;
                        if(state.Name == "Combat") this.mCurrentStructureTypeState = StructureType.Combat;
                        if(state.Name == "Utility") this.mCurrentStructureTypeState = StructureType.Utility;
                    }
                    else if (category.Name == "EnabledStatus")
                    {
                        if(state.Name == "Enabled") this.mCurrentEnabledStatusState = EnabledStatus.Enabled;
                        if(state.Name == "Disabled") this.mCurrentEnabledStatusState = EnabledStatus.Disabled;
                    }
                }
                base.ApplyState(state);
            }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime ButtonCircleSprite { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime StructureSprite { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime MineralCostContainer { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime CostCircleSprite { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime MineralsText { get; set; }
            public string MineralsCost
            {
                get
                {
                    return MineralsText.Text;
                }
                set
                {
                    if (MineralsText.Text != value)
                    {
                        MineralsText.Text = value;
                        MineralsCostChanged?.Invoke(this, null);
                    }
                }
            }
            public event System.EventHandler MineralsCostChanged;
            public BuildButtonRuntime (bool fullInstantiation = true)
            	: base(false)
            {
                this.HasEvents = true;
                this.ExposeChildrenEvents = false;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "BuildButton");
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
                ButtonCircleSprite = this.GetGraphicalUiElementByName("ButtonCircleSprite") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                StructureSprite = this.GetGraphicalUiElementByName("StructureSprite") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                MineralCostContainer = this.GetGraphicalUiElementByName("MineralCostContainer") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
                CostCircleSprite = this.GetGraphicalUiElementByName("CostCircleSprite") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                MineralsText = this.GetGraphicalUiElementByName("MineralsText") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
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
