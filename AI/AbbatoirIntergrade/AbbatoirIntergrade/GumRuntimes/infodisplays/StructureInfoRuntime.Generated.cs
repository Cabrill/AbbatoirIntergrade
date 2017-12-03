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
            public enum HasBattery
            {
                True,
                False
            }
            public enum EnergyUsage
            {
                Positive,
                Balanced,
                Negative
            }
            public enum ResourceUsage
            {
                True,
                False
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            HasBattery mCurrentHasBatteryState;
            EnergyUsage mCurrentEnergyUsageState;
            ResourceUsage mCurrentResourceUsageState;
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
                            TallInfoFrameInstance.Height = 100f;
                            TallInfoFrameInstance.Width = 100f;
                            StatsContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                            StatsContainer.Height = 80f;
                            StatsContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            StatsContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "InfoContainer");
                            StatsContainer.Width = 100f;
                            StatsContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            StatsContainer.WrapsChildren = true;
                            ButtonContainers.Height = 20f;
                            ButtonContainers.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ButtonContainers.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "InfoContainer");
                            ButtonContainers.Width = 100f;
                            ButtonContainers.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ButtonContainers.Y = -24f;
                            ButtonContainers.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                            ButtonContainers.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            NameContainer.Height = 20f;
                            NameContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            NameContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "StatsContainer");
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
                            InfoContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                            InfoContainer.Height = 100f;
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
                            break;
                    }
                }
            }
            public HasBattery CurrentHasBatteryState
            {
                get
                {
                    return mCurrentHasBatteryState;
                }
                set
                {
                    mCurrentHasBatteryState = value;
                    switch(mCurrentHasBatteryState)
                    {
                        case  HasBattery.True:
                            break;
                        case  HasBattery.False:
                            break;
                    }
                }
            }
            public EnergyUsage CurrentEnergyUsageState
            {
                get
                {
                    return mCurrentEnergyUsageState;
                }
                set
                {
                    mCurrentEnergyUsageState = value;
                    switch(mCurrentEnergyUsageState)
                    {
                        case  EnergyUsage.Positive:
                            break;
                        case  EnergyUsage.Balanced:
                            break;
                        case  EnergyUsage.Negative:
                            break;
                    }
                }
            }
            public ResourceUsage CurrentResourceUsageState
            {
                get
                {
                    return mCurrentResourceUsageState;
                }
                set
                {
                    mCurrentResourceUsageState = value;
                    switch(mCurrentResourceUsageState)
                    {
                        case  ResourceUsage.True:
                            break;
                        case  ResourceUsage.False:
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
                bool setButtonContainersHeightFirstValue = false;
                bool setButtonContainersHeightSecondValue = false;
                float ButtonContainersHeightFirstValue= 0;
                float ButtonContainersHeightSecondValue= 0;
                bool setButtonContainersWidthFirstValue = false;
                bool setButtonContainersWidthSecondValue = false;
                float ButtonContainersWidthFirstValue= 0;
                float ButtonContainersWidthSecondValue= 0;
                bool setButtonContainersYFirstValue = false;
                bool setButtonContainersYSecondValue = false;
                float ButtonContainersYFirstValue= 0;
                float ButtonContainersYSecondValue= 0;
                bool setColoredRectangleInstanceHeightFirstValue = false;
                bool setColoredRectangleInstanceHeightSecondValue = false;
                float ColoredRectangleInstanceHeightFirstValue= 0;
                float ColoredRectangleInstanceHeightSecondValue= 0;
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
                bool setStatsContainerHeightFirstValue = false;
                bool setStatsContainerHeightSecondValue = false;
                float StatsContainerHeightFirstValue= 0;
                float StatsContainerHeightSecondValue= 0;
                bool setStatsContainerWidthFirstValue = false;
                bool setStatsContainerWidthSecondValue = false;
                float StatsContainerWidthFirstValue= 0;
                float StatsContainerWidthSecondValue= 0;
                bool setTallInfoFrameInstanceHeightFirstValue = false;
                bool setTallInfoFrameInstanceHeightSecondValue = false;
                float TallInfoFrameInstanceHeightFirstValue= 0;
                float TallInfoFrameInstanceHeightSecondValue= 0;
                bool setTallInfoFrameInstanceWidthFirstValue = false;
                bool setTallInfoFrameInstanceWidthSecondValue = false;
                float TallInfoFrameInstanceWidthFirstValue= 0;
                float TallInfoFrameInstanceWidthSecondValue= 0;
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setButtonContainersHeightFirstValue = true;
                        ButtonContainersHeightFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonContainers.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ButtonContainers.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "InfoContainer");
                        }
                        setButtonContainersWidthFirstValue = true;
                        ButtonContainersWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonContainers.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setButtonContainersYFirstValue = true;
                        ButtonContainersYFirstValue = -24f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonContainers.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ButtonContainers.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
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
                        InfoContainerHeightFirstValue = 100f;
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
                        setNameContainerHeightFirstValue = true;
                        NameContainerHeightFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.NameContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.NameContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "StatsContainer");
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
                        if (interpolationValue < 1)
                        {
                            this.StatsContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setStatsContainerHeightFirstValue = true;
                        StatsContainerHeightFirstValue = 80f;
                        if (interpolationValue < 1)
                        {
                            this.StatsContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.StatsContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "InfoContainer");
                        }
                        setStatsContainerWidthFirstValue = true;
                        StatsContainerWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.StatsContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.StatsContainer.WrapsChildren = true;
                        }
                        setTallInfoFrameInstanceHeightFirstValue = true;
                        TallInfoFrameInstanceHeightFirstValue = 100f;
                        setTallInfoFrameInstanceWidthFirstValue = true;
                        TallInfoFrameInstanceWidthFirstValue = 100f;
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
                        setButtonContainersHeightSecondValue = true;
                        ButtonContainersHeightSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonContainers.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ButtonContainers.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "InfoContainer");
                        }
                        setButtonContainersWidthSecondValue = true;
                        ButtonContainersWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonContainers.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setButtonContainersYSecondValue = true;
                        ButtonContainersYSecondValue = -24f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonContainers.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ButtonContainers.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
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
                        InfoContainerHeightSecondValue = 100f;
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
                        setNameContainerHeightSecondValue = true;
                        NameContainerHeightSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.NameContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.NameContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "StatsContainer");
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
                        if (interpolationValue >= 1)
                        {
                            this.StatsContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setStatsContainerHeightSecondValue = true;
                        StatsContainerHeightSecondValue = 80f;
                        if (interpolationValue >= 1)
                        {
                            this.StatsContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.StatsContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "InfoContainer");
                        }
                        setStatsContainerWidthSecondValue = true;
                        StatsContainerWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.StatsContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.StatsContainer.WrapsChildren = true;
                        }
                        setTallInfoFrameInstanceHeightSecondValue = true;
                        TallInfoFrameInstanceHeightSecondValue = 100f;
                        setTallInfoFrameInstanceWidthSecondValue = true;
                        TallInfoFrameInstanceWidthSecondValue = 100f;
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
                if (setButtonContainersHeightFirstValue && setButtonContainersHeightSecondValue)
                {
                    ButtonContainers.Height = ButtonContainersHeightFirstValue * (1 - interpolationValue) + ButtonContainersHeightSecondValue * interpolationValue;
                }
                if (setButtonContainersWidthFirstValue && setButtonContainersWidthSecondValue)
                {
                    ButtonContainers.Width = ButtonContainersWidthFirstValue * (1 - interpolationValue) + ButtonContainersWidthSecondValue * interpolationValue;
                }
                if (setButtonContainersYFirstValue && setButtonContainersYSecondValue)
                {
                    ButtonContainers.Y = ButtonContainersYFirstValue * (1 - interpolationValue) + ButtonContainersYSecondValue * interpolationValue;
                }
                if (setColoredRectangleInstanceHeightFirstValue && setColoredRectangleInstanceHeightSecondValue)
                {
                    ColoredRectangleInstance.Height = ColoredRectangleInstanceHeightFirstValue * (1 - interpolationValue) + ColoredRectangleInstanceHeightSecondValue * interpolationValue;
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
                if (setStatsContainerHeightFirstValue && setStatsContainerHeightSecondValue)
                {
                    StatsContainer.Height = StatsContainerHeightFirstValue * (1 - interpolationValue) + StatsContainerHeightSecondValue * interpolationValue;
                }
                if (setStatsContainerWidthFirstValue && setStatsContainerWidthSecondValue)
                {
                    StatsContainer.Width = StatsContainerWidthFirstValue * (1 - interpolationValue) + StatsContainerWidthSecondValue * interpolationValue;
                }
                if (setTallInfoFrameInstanceHeightFirstValue && setTallInfoFrameInstanceHeightSecondValue)
                {
                    TallInfoFrameInstance.Height = TallInfoFrameInstanceHeightFirstValue * (1 - interpolationValue) + TallInfoFrameInstanceHeightSecondValue * interpolationValue;
                }
                if (setTallInfoFrameInstanceWidthFirstValue && setTallInfoFrameInstanceWidthSecondValue)
                {
                    TallInfoFrameInstance.Width = TallInfoFrameInstanceWidthFirstValue * (1 - interpolationValue) + TallInfoFrameInstanceWidthSecondValue * interpolationValue;
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
            public void InterpolateBetween (HasBattery firstState, HasBattery secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                switch(firstState)
                {
                    case  HasBattery.True:
                        break;
                    case  HasBattery.False:
                        break;
                }
                switch(secondState)
                {
                    case  HasBattery.True:
                        break;
                    case  HasBattery.False:
                        break;
                }
                if (interpolationValue < 1)
                {
                    mCurrentHasBatteryState = firstState;
                }
                else
                {
                    mCurrentHasBatteryState = secondState;
                }
            }
            public void InterpolateBetween (EnergyUsage firstState, EnergyUsage secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                switch(firstState)
                {
                    case  EnergyUsage.Positive:
                        break;
                    case  EnergyUsage.Balanced:
                        break;
                    case  EnergyUsage.Negative:
                        break;
                }
                switch(secondState)
                {
                    case  EnergyUsage.Positive:
                        break;
                    case  EnergyUsage.Balanced:
                        break;
                    case  EnergyUsage.Negative:
                        break;
                }
                if (interpolationValue < 1)
                {
                    mCurrentEnergyUsageState = firstState;
                }
                else
                {
                    mCurrentEnergyUsageState = secondState;
                }
            }
            public void InterpolateBetween (ResourceUsage firstState, ResourceUsage secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                switch(firstState)
                {
                    case  ResourceUsage.True:
                        break;
                    case  ResourceUsage.False:
                        break;
                }
                switch(secondState)
                {
                    case  ResourceUsage.True:
                        break;
                    case  ResourceUsage.False:
                        break;
                }
                if (interpolationValue < 1)
                {
                    mCurrentResourceUsageState = firstState;
                }
                else
                {
                    mCurrentResourceUsageState = secondState;
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.StructureInfoRuntime.HasBattery fromState,AbbatoirIntergrade.GumRuntimes.StructureInfoRuntime.HasBattery toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (HasBattery toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "HasBattery").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentHasBatteryState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (HasBattery toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentHasBatteryState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.StructureInfoRuntime.EnergyUsage fromState,AbbatoirIntergrade.GumRuntimes.StructureInfoRuntime.EnergyUsage toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (EnergyUsage toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "EnergyUsage").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentEnergyUsageState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (EnergyUsage toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentEnergyUsageState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.StructureInfoRuntime.ResourceUsage fromState,AbbatoirIntergrade.GumRuntimes.StructureInfoRuntime.ResourceUsage toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (ResourceUsage toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "ResourceUsage").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentResourceUsageState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (ResourceUsage toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentResourceUsageState = toState;
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
                            Value = StatsContainer.Height + 80f
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
                            Value = StatsContainer.Width + 100f
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
                            Name = "ButtonContainers.Height",
                            Type = "float",
                            Value = ButtonContainers.Height + 20f
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
                            Name = "ButtonContainers.Width",
                            Type = "float",
                            Value = ButtonContainers.Width + 100f
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
                            Name = "ButtonContainers.Y",
                            Type = "float",
                            Value = ButtonContainers.Y + -24f
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
                            Name = "NameContainer.Height",
                            Type = "float",
                            Value = NameContainer.Height + 20f
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
                            Value = InfoContainer.Height + 100f
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
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (HasBattery state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  HasBattery.True:
                        break;
                    case  HasBattery.False:
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (HasBattery state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  HasBattery.True:
                        break;
                    case  HasBattery.False:
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (EnergyUsage state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  EnergyUsage.Positive:
                        break;
                    case  EnergyUsage.Balanced:
                        break;
                    case  EnergyUsage.Negative:
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (EnergyUsage state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  EnergyUsage.Positive:
                        break;
                    case  EnergyUsage.Balanced:
                        break;
                    case  EnergyUsage.Negative:
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (ResourceUsage state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  ResourceUsage.True:
                        break;
                    case  ResourceUsage.False:
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (ResourceUsage state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  ResourceUsage.True:
                        break;
                    case  ResourceUsage.False:
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
                    else if (category.Name == "HasBattery")
                    {
                        if(state.Name == "True") this.mCurrentHasBatteryState = HasBattery.True;
                        if(state.Name == "False") this.mCurrentHasBatteryState = HasBattery.False;
                    }
                    else if (category.Name == "EnergyUsage")
                    {
                        if(state.Name == "Positive") this.mCurrentEnergyUsageState = EnergyUsage.Positive;
                        if(state.Name == "Balanced") this.mCurrentEnergyUsageState = EnergyUsage.Balanced;
                        if(state.Name == "Negative") this.mCurrentEnergyUsageState = EnergyUsage.Negative;
                    }
                    else if (category.Name == "ResourceUsage")
                    {
                        if(state.Name == "True") this.mCurrentResourceUsageState = ResourceUsage.True;
                        if(state.Name == "False") this.mCurrentResourceUsageState = ResourceUsage.False;
                    }
                }
                base.ApplyState(state);
            }
            private AbbatoirIntergrade.GumRuntimes.TallInfoFrameRuntime TallInfoFrameInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime StatsContainer { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime ButtonContainers { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime NameContainer { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime NameText { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime InfoContainer { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ColoredRectangleRuntime ColoredRectangleInstance { get; set; }
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
            public event FlatRedBall.Gui.WindowEvent TallInfoFrameInstanceClick;
            public event FlatRedBall.Gui.WindowEvent StatsContainerClick;
            public event FlatRedBall.Gui.WindowEvent ButtonContainersClick;
            public event FlatRedBall.Gui.WindowEvent NameContainerClick;
            public event FlatRedBall.Gui.WindowEvent InfoContainerClick;
            public event System.EventHandler StructureNameChanged;
            public StructureInfoRuntime (bool fullInstantiation = true) 
            	: base(false)
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
                TallInfoFrameInstance = this.GetGraphicalUiElementByName("TallInfoFrameInstance") as AbbatoirIntergrade.GumRuntimes.TallInfoFrameRuntime;
                StatsContainer = this.GetGraphicalUiElementByName("StatsContainer") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
                ButtonContainers = this.GetGraphicalUiElementByName("ButtonContainers") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
                NameContainer = this.GetGraphicalUiElementByName("NameContainer") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
                NameText = this.GetGraphicalUiElementByName("NameText") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
                InfoContainer = this.GetGraphicalUiElementByName("InfoContainer") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
                ColoredRectangleInstance = this.GetGraphicalUiElementByName("ColoredRectangleInstance") as AbbatoirIntergrade.GumRuntimes.ColoredRectangleRuntime;
                TallInfoFrameInstance.Click += (unused) => TallInfoFrameInstanceClick?.Invoke(this);
                StatsContainer.Click += (unused) => StatsContainerClick?.Invoke(this);
                ButtonContainers.Click += (unused) => ButtonContainersClick?.Invoke(this);
                NameContainer.Click += (unused) => NameContainerClick?.Invoke(this);
                InfoContainer.Click += (unused) => InfoContainerClick?.Invoke(this);
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
