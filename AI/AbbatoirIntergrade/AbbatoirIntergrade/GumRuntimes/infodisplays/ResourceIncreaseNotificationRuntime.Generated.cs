    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes
    {
        public partial class ResourceIncreaseNotificationRuntime : AbbatoirIntergrade.GumRuntimes.ContainerRuntime
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            public enum FloatAnimationStates
            {
                FloatAnimationEnd,
                FloatAnimationStart
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            FloatAnimationStates mCurrentFloatAnimationStatesState;
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
                            ClipsChildren = false;
                            Height = 10f;
                            HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            Visible = true;
                            Width = 10f;
                            WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            WrapsChildren = false;
                            X = 0f;
                            XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                            YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddleInverted;
                            IncreaseAmount.Blue = 226;
                            SetProperty("IncreaseAmount.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                            IncreaseAmount.Font = "Moire ExtraBold";
                            IncreaseAmount.FontScale = 1f;
                            IncreaseAmount.FontSize = 50;
                            IncreaseAmount.Green = 43;
                            IncreaseAmount.Height = 100f;
                            IncreaseAmount.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            IncreaseAmount.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            IncreaseAmount.OutlineThickness = 2;
                            IncreaseAmount.Red = 138;
                            IncreaseAmount.Text = "+1";
                            IncreaseAmount.UseCustomFont = true;
                            IncreaseAmount.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            IncreaseAmount.Width = 60f;
                            IncreaseAmount.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            MineralsSprite.Height = 35f;
                            MineralsSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            MineralsSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ContainerInstance");
                            SetProperty("MineralsSprite.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                            MineralsSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            MineralsSprite.TextureHeight = 12;
                            MineralsSprite.TextureLeft = 99;
                            MineralsSprite.TextureTop = 0;
                            MineralsSprite.TextureWidth = 7;
                            MineralsSprite.Visible = true;
                            MineralsSprite.Width = 10f;
                            MineralsSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            MineralsSprite.X = 5f;
                            MineralsSprite.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            MineralsSprite.Y = 50f;
                            MineralsSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            MineralsSprite.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            break;
                    }
                }
            }
            public FloatAnimationStates CurrentFloatAnimationStatesState
            {
                get
                {
                    return mCurrentFloatAnimationStatesState;
                }
                set
                {
                    mCurrentFloatAnimationStatesState = value;
                    switch(mCurrentFloatAnimationStatesState)
                    {
                        case  FloatAnimationStates.FloatAnimationEnd:
                            Y = 100f;
                            IncreaseAmount.Alpha = 0;
                            MineralsSprite.Alpha = 0;
                            break;
                        case  FloatAnimationStates.FloatAnimationStart:
                            IncreaseAmount.Alpha = 255;
                            MineralsSprite.Alpha = 255;
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
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setIncreaseAmountBlueFirstValue = false;
                bool setIncreaseAmountBlueSecondValue = false;
                int IncreaseAmountBlueFirstValue= 0;
                int IncreaseAmountBlueSecondValue= 0;
                bool setIncreaseAmountFontScaleFirstValue = false;
                bool setIncreaseAmountFontScaleSecondValue = false;
                float IncreaseAmountFontScaleFirstValue= 0;
                float IncreaseAmountFontScaleSecondValue= 0;
                bool setIncreaseAmountFontSizeFirstValue = false;
                bool setIncreaseAmountFontSizeSecondValue = false;
                int IncreaseAmountFontSizeFirstValue= 0;
                int IncreaseAmountFontSizeSecondValue= 0;
                bool setIncreaseAmountGreenFirstValue = false;
                bool setIncreaseAmountGreenSecondValue = false;
                int IncreaseAmountGreenFirstValue= 0;
                int IncreaseAmountGreenSecondValue= 0;
                bool setIncreaseAmountHeightFirstValue = false;
                bool setIncreaseAmountHeightSecondValue = false;
                float IncreaseAmountHeightFirstValue= 0;
                float IncreaseAmountHeightSecondValue= 0;
                bool setIncreaseAmountOutlineThicknessFirstValue = false;
                bool setIncreaseAmountOutlineThicknessSecondValue = false;
                int IncreaseAmountOutlineThicknessFirstValue= 0;
                int IncreaseAmountOutlineThicknessSecondValue= 0;
                bool setIncreaseAmountRedFirstValue = false;
                bool setIncreaseAmountRedSecondValue = false;
                int IncreaseAmountRedFirstValue= 0;
                int IncreaseAmountRedSecondValue= 0;
                bool setIncreaseAmountWidthFirstValue = false;
                bool setIncreaseAmountWidthSecondValue = false;
                float IncreaseAmountWidthFirstValue= 0;
                float IncreaseAmountWidthSecondValue= 0;
                bool setMineralsSpriteHeightFirstValue = false;
                bool setMineralsSpriteHeightSecondValue = false;
                float MineralsSpriteHeightFirstValue= 0;
                float MineralsSpriteHeightSecondValue= 0;
                bool setMineralsSpriteTextureHeightFirstValue = false;
                bool setMineralsSpriteTextureHeightSecondValue = false;
                int MineralsSpriteTextureHeightFirstValue= 0;
                int MineralsSpriteTextureHeightSecondValue= 0;
                bool setMineralsSpriteTextureLeftFirstValue = false;
                bool setMineralsSpriteTextureLeftSecondValue = false;
                int MineralsSpriteTextureLeftFirstValue= 0;
                int MineralsSpriteTextureLeftSecondValue= 0;
                bool setMineralsSpriteTextureTopFirstValue = false;
                bool setMineralsSpriteTextureTopSecondValue = false;
                int MineralsSpriteTextureTopFirstValue= 0;
                int MineralsSpriteTextureTopSecondValue= 0;
                bool setMineralsSpriteTextureWidthFirstValue = false;
                bool setMineralsSpriteTextureWidthSecondValue = false;
                int MineralsSpriteTextureWidthFirstValue= 0;
                int MineralsSpriteTextureWidthSecondValue= 0;
                bool setMineralsSpriteWidthFirstValue = false;
                bool setMineralsSpriteWidthSecondValue = false;
                float MineralsSpriteWidthFirstValue= 0;
                float MineralsSpriteWidthSecondValue= 0;
                bool setMineralsSpriteXFirstValue = false;
                bool setMineralsSpriteXSecondValue = false;
                float MineralsSpriteXFirstValue= 0;
                float MineralsSpriteXSecondValue= 0;
                bool setMineralsSpriteYFirstValue = false;
                bool setMineralsSpriteYSecondValue = false;
                float MineralsSpriteYFirstValue= 0;
                float MineralsSpriteYSecondValue= 0;
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
                        if (interpolationValue < 1)
                        {
                            this.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ClipsChildren = false;
                        }
                        setHeightFirstValue = true;
                        HeightFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setIncreaseAmountBlueFirstValue = true;
                        IncreaseAmountBlueFirstValue = 226;
                        if (interpolationValue < 1)
                        {
                            SetProperty("IncreaseAmount.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        if (interpolationValue < 1)
                        {
                            this.IncreaseAmount.Font = "Moire ExtraBold";
                        }
                        setIncreaseAmountFontScaleFirstValue = true;
                        IncreaseAmountFontScaleFirstValue = 1f;
                        setIncreaseAmountFontSizeFirstValue = true;
                        IncreaseAmountFontSizeFirstValue = 50;
                        setIncreaseAmountGreenFirstValue = true;
                        IncreaseAmountGreenFirstValue = 43;
                        setIncreaseAmountHeightFirstValue = true;
                        IncreaseAmountHeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.IncreaseAmount.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.IncreaseAmount.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        setIncreaseAmountOutlineThicknessFirstValue = true;
                        IncreaseAmountOutlineThicknessFirstValue = 2;
                        setIncreaseAmountRedFirstValue = true;
                        IncreaseAmountRedFirstValue = 138;
                        if (interpolationValue < 1)
                        {
                            this.IncreaseAmount.Text = "+1";
                        }
                        if (interpolationValue < 1)
                        {
                            this.IncreaseAmount.UseCustomFont = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.IncreaseAmount.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setIncreaseAmountWidthFirstValue = true;
                        IncreaseAmountWidthFirstValue = 60f;
                        if (interpolationValue < 1)
                        {
                            this.IncreaseAmount.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setMineralsSpriteHeightFirstValue = true;
                        MineralsSpriteHeightFirstValue = 35f;
                        if (interpolationValue < 1)
                        {
                            this.MineralsSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MineralsSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ContainerInstance");
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("MineralsSprite.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.MineralsSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setMineralsSpriteTextureHeightFirstValue = true;
                        MineralsSpriteTextureHeightFirstValue = 12;
                        setMineralsSpriteTextureLeftFirstValue = true;
                        MineralsSpriteTextureLeftFirstValue = 99;
                        setMineralsSpriteTextureTopFirstValue = true;
                        MineralsSpriteTextureTopFirstValue = 0;
                        setMineralsSpriteTextureWidthFirstValue = true;
                        MineralsSpriteTextureWidthFirstValue = 7;
                        if (interpolationValue < 1)
                        {
                            this.MineralsSprite.Visible = true;
                        }
                        setMineralsSpriteWidthFirstValue = true;
                        MineralsSpriteWidthFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.MineralsSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setMineralsSpriteXFirstValue = true;
                        MineralsSpriteXFirstValue = 5f;
                        if (interpolationValue < 1)
                        {
                            this.MineralsSprite.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setMineralsSpriteYFirstValue = true;
                        MineralsSpriteYFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.MineralsSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MineralsSprite.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Visible = true;
                        }
                        setWidthFirstValue = true;
                        WidthFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.WrapsChildren = false;
                        }
                        setXFirstValue = true;
                        XFirstValue = 0f;
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
                            this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
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
                            this.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ClipsChildren = false;
                        }
                        setHeightSecondValue = true;
                        HeightSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setIncreaseAmountBlueSecondValue = true;
                        IncreaseAmountBlueSecondValue = 226;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("IncreaseAmount.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.IncreaseAmount.Font = "Moire ExtraBold";
                        }
                        setIncreaseAmountFontScaleSecondValue = true;
                        IncreaseAmountFontScaleSecondValue = 1f;
                        setIncreaseAmountFontSizeSecondValue = true;
                        IncreaseAmountFontSizeSecondValue = 50;
                        setIncreaseAmountGreenSecondValue = true;
                        IncreaseAmountGreenSecondValue = 43;
                        setIncreaseAmountHeightSecondValue = true;
                        IncreaseAmountHeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.IncreaseAmount.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.IncreaseAmount.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        setIncreaseAmountOutlineThicknessSecondValue = true;
                        IncreaseAmountOutlineThicknessSecondValue = 2;
                        setIncreaseAmountRedSecondValue = true;
                        IncreaseAmountRedSecondValue = 138;
                        if (interpolationValue >= 1)
                        {
                            this.IncreaseAmount.Text = "+1";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.IncreaseAmount.UseCustomFont = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.IncreaseAmount.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setIncreaseAmountWidthSecondValue = true;
                        IncreaseAmountWidthSecondValue = 60f;
                        if (interpolationValue >= 1)
                        {
                            this.IncreaseAmount.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setMineralsSpriteHeightSecondValue = true;
                        MineralsSpriteHeightSecondValue = 35f;
                        if (interpolationValue >= 1)
                        {
                            this.MineralsSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MineralsSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ContainerInstance");
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("MineralsSprite.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MineralsSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setMineralsSpriteTextureHeightSecondValue = true;
                        MineralsSpriteTextureHeightSecondValue = 12;
                        setMineralsSpriteTextureLeftSecondValue = true;
                        MineralsSpriteTextureLeftSecondValue = 99;
                        setMineralsSpriteTextureTopSecondValue = true;
                        MineralsSpriteTextureTopSecondValue = 0;
                        setMineralsSpriteTextureWidthSecondValue = true;
                        MineralsSpriteTextureWidthSecondValue = 7;
                        if (interpolationValue >= 1)
                        {
                            this.MineralsSprite.Visible = true;
                        }
                        setMineralsSpriteWidthSecondValue = true;
                        MineralsSpriteWidthSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.MineralsSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setMineralsSpriteXSecondValue = true;
                        MineralsSpriteXSecondValue = 5f;
                        if (interpolationValue >= 1)
                        {
                            this.MineralsSprite.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setMineralsSpriteYSecondValue = true;
                        MineralsSpriteYSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.MineralsSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MineralsSprite.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Visible = true;
                        }
                        setWidthSecondValue = true;
                        WidthSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.WrapsChildren = false;
                        }
                        setXSecondValue = true;
                        XSecondValue = 0f;
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
                            this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddleInverted;
                        }
                        break;
                }
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
                }
                if (setIncreaseAmountBlueFirstValue && setIncreaseAmountBlueSecondValue)
                {
                    IncreaseAmount.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(IncreaseAmountBlueFirstValue* (1 - interpolationValue) + IncreaseAmountBlueSecondValue * interpolationValue);
                }
                if (setIncreaseAmountFontScaleFirstValue && setIncreaseAmountFontScaleSecondValue)
                {
                    IncreaseAmount.FontScale = IncreaseAmountFontScaleFirstValue * (1 - interpolationValue) + IncreaseAmountFontScaleSecondValue * interpolationValue;
                }
                if (setIncreaseAmountFontSizeFirstValue && setIncreaseAmountFontSizeSecondValue)
                {
                    IncreaseAmount.FontSize = FlatRedBall.Math.MathFunctions.RoundToInt(IncreaseAmountFontSizeFirstValue* (1 - interpolationValue) + IncreaseAmountFontSizeSecondValue * interpolationValue);
                }
                if (setIncreaseAmountGreenFirstValue && setIncreaseAmountGreenSecondValue)
                {
                    IncreaseAmount.Green = FlatRedBall.Math.MathFunctions.RoundToInt(IncreaseAmountGreenFirstValue* (1 - interpolationValue) + IncreaseAmountGreenSecondValue * interpolationValue);
                }
                if (setIncreaseAmountHeightFirstValue && setIncreaseAmountHeightSecondValue)
                {
                    IncreaseAmount.Height = IncreaseAmountHeightFirstValue * (1 - interpolationValue) + IncreaseAmountHeightSecondValue * interpolationValue;
                }
                if (setIncreaseAmountOutlineThicknessFirstValue && setIncreaseAmountOutlineThicknessSecondValue)
                {
                    IncreaseAmount.OutlineThickness = FlatRedBall.Math.MathFunctions.RoundToInt(IncreaseAmountOutlineThicknessFirstValue* (1 - interpolationValue) + IncreaseAmountOutlineThicknessSecondValue * interpolationValue);
                }
                if (setIncreaseAmountRedFirstValue && setIncreaseAmountRedSecondValue)
                {
                    IncreaseAmount.Red = FlatRedBall.Math.MathFunctions.RoundToInt(IncreaseAmountRedFirstValue* (1 - interpolationValue) + IncreaseAmountRedSecondValue * interpolationValue);
                }
                if (setIncreaseAmountWidthFirstValue && setIncreaseAmountWidthSecondValue)
                {
                    IncreaseAmount.Width = IncreaseAmountWidthFirstValue * (1 - interpolationValue) + IncreaseAmountWidthSecondValue * interpolationValue;
                }
                if (setMineralsSpriteHeightFirstValue && setMineralsSpriteHeightSecondValue)
                {
                    MineralsSprite.Height = MineralsSpriteHeightFirstValue * (1 - interpolationValue) + MineralsSpriteHeightSecondValue * interpolationValue;
                }
                if (setMineralsSpriteTextureHeightFirstValue && setMineralsSpriteTextureHeightSecondValue)
                {
                    MineralsSprite.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(MineralsSpriteTextureHeightFirstValue* (1 - interpolationValue) + MineralsSpriteTextureHeightSecondValue * interpolationValue);
                }
                if (setMineralsSpriteTextureLeftFirstValue && setMineralsSpriteTextureLeftSecondValue)
                {
                    MineralsSprite.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(MineralsSpriteTextureLeftFirstValue* (1 - interpolationValue) + MineralsSpriteTextureLeftSecondValue * interpolationValue);
                }
                if (setMineralsSpriteTextureTopFirstValue && setMineralsSpriteTextureTopSecondValue)
                {
                    MineralsSprite.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(MineralsSpriteTextureTopFirstValue* (1 - interpolationValue) + MineralsSpriteTextureTopSecondValue * interpolationValue);
                }
                if (setMineralsSpriteTextureWidthFirstValue && setMineralsSpriteTextureWidthSecondValue)
                {
                    MineralsSprite.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(MineralsSpriteTextureWidthFirstValue* (1 - interpolationValue) + MineralsSpriteTextureWidthSecondValue * interpolationValue);
                }
                if (setMineralsSpriteWidthFirstValue && setMineralsSpriteWidthSecondValue)
                {
                    MineralsSprite.Width = MineralsSpriteWidthFirstValue * (1 - interpolationValue) + MineralsSpriteWidthSecondValue * interpolationValue;
                }
                if (setMineralsSpriteXFirstValue && setMineralsSpriteXSecondValue)
                {
                    MineralsSprite.X = MineralsSpriteXFirstValue * (1 - interpolationValue) + MineralsSpriteXSecondValue * interpolationValue;
                }
                if (setMineralsSpriteYFirstValue && setMineralsSpriteYSecondValue)
                {
                    MineralsSprite.Y = MineralsSpriteYFirstValue * (1 - interpolationValue) + MineralsSpriteYSecondValue * interpolationValue;
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
            public void InterpolateBetween (FloatAnimationStates firstState, FloatAnimationStates secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setIncreaseAmountAlphaFirstValue = false;
                bool setIncreaseAmountAlphaSecondValue = false;
                int IncreaseAmountAlphaFirstValue= 0;
                int IncreaseAmountAlphaSecondValue= 0;
                bool setMineralsSpriteAlphaFirstValue = false;
                bool setMineralsSpriteAlphaSecondValue = false;
                int MineralsSpriteAlphaFirstValue= 0;
                int MineralsSpriteAlphaSecondValue= 0;
                bool setYFirstValue = false;
                bool setYSecondValue = false;
                float YFirstValue= 0;
                float YSecondValue= 0;
                switch(firstState)
                {
                    case  FloatAnimationStates.FloatAnimationEnd:
                        setIncreaseAmountAlphaFirstValue = true;
                        IncreaseAmountAlphaFirstValue = 0;
                        setMineralsSpriteAlphaFirstValue = true;
                        MineralsSpriteAlphaFirstValue = 0;
                        setYFirstValue = true;
                        YFirstValue = 100f;
                        break;
                    case  FloatAnimationStates.FloatAnimationStart:
                        setIncreaseAmountAlphaFirstValue = true;
                        IncreaseAmountAlphaFirstValue = 255;
                        setMineralsSpriteAlphaFirstValue = true;
                        MineralsSpriteAlphaFirstValue = 255;
                        break;
                }
                switch(secondState)
                {
                    case  FloatAnimationStates.FloatAnimationEnd:
                        setIncreaseAmountAlphaSecondValue = true;
                        IncreaseAmountAlphaSecondValue = 0;
                        setMineralsSpriteAlphaSecondValue = true;
                        MineralsSpriteAlphaSecondValue = 0;
                        setYSecondValue = true;
                        YSecondValue = 100f;
                        break;
                    case  FloatAnimationStates.FloatAnimationStart:
                        setIncreaseAmountAlphaSecondValue = true;
                        IncreaseAmountAlphaSecondValue = 255;
                        setMineralsSpriteAlphaSecondValue = true;
                        MineralsSpriteAlphaSecondValue = 255;
                        break;
                }
                if (setIncreaseAmountAlphaFirstValue && setIncreaseAmountAlphaSecondValue)
                {
                    IncreaseAmount.Alpha = FlatRedBall.Math.MathFunctions.RoundToInt(IncreaseAmountAlphaFirstValue* (1 - interpolationValue) + IncreaseAmountAlphaSecondValue * interpolationValue);
                }
                if (setMineralsSpriteAlphaFirstValue && setMineralsSpriteAlphaSecondValue)
                {
                    MineralsSprite.Alpha = FlatRedBall.Math.MathFunctions.RoundToInt(MineralsSpriteAlphaFirstValue* (1 - interpolationValue) + MineralsSpriteAlphaSecondValue * interpolationValue);
                }
                if (setYFirstValue && setYSecondValue)
                {
                    Y = YFirstValue * (1 - interpolationValue) + YSecondValue * interpolationValue;
                }
                if (interpolationValue < 1)
                {
                    mCurrentFloatAnimationStatesState = firstState;
                }
                else
                {
                    mCurrentFloatAnimationStatesState = secondState;
                }
            }
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.ResourceIncreaseNotificationRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.ResourceIncreaseNotificationRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.ResourceIncreaseNotificationRuntime.FloatAnimationStates fromState,AbbatoirIntergrade.GumRuntimes.ResourceIncreaseNotificationRuntime.FloatAnimationStates toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (FloatAnimationStates toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "FloatAnimationStates").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentFloatAnimationStatesState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (FloatAnimationStates toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentFloatAnimationStatesState = toState;
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
                            Name = "IncreaseAmount.Blue",
                            Type = "int",
                            Value = IncreaseAmount.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IncreaseAmount.CustomFontFile",
                            Type = "string",
                            Value = IncreaseAmount.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IncreaseAmount.Font",
                            Type = "string",
                            Value = IncreaseAmount.Font
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IncreaseAmount.Font Scale",
                            Type = "float",
                            Value = IncreaseAmount.FontScale
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IncreaseAmount.FontSize",
                            Type = "int",
                            Value = IncreaseAmount.FontSize
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IncreaseAmount.Green",
                            Type = "int",
                            Value = IncreaseAmount.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IncreaseAmount.Height",
                            Type = "float",
                            Value = IncreaseAmount.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IncreaseAmount.Height Units",
                            Type = "DimensionUnitType",
                            Value = IncreaseAmount.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IncreaseAmount.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = IncreaseAmount.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IncreaseAmount.OutlineThickness",
                            Type = "int",
                            Value = IncreaseAmount.OutlineThickness
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IncreaseAmount.Red",
                            Type = "int",
                            Value = IncreaseAmount.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IncreaseAmount.Text",
                            Type = "string",
                            Value = IncreaseAmount.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IncreaseAmount.UseCustomFont",
                            Type = "bool",
                            Value = IncreaseAmount.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IncreaseAmount.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = IncreaseAmount.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IncreaseAmount.Width",
                            Type = "float",
                            Value = IncreaseAmount.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IncreaseAmount.Width Units",
                            Type = "DimensionUnitType",
                            Value = IncreaseAmount.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsSprite.Height",
                            Type = "float",
                            Value = MineralsSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = MineralsSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsSprite.Parent",
                            Type = "string",
                            Value = MineralsSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsSprite.SourceFile",
                            Type = "string",
                            Value = MineralsSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = MineralsSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsSprite.Texture Height",
                            Type = "int",
                            Value = MineralsSprite.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsSprite.Texture Left",
                            Type = "int",
                            Value = MineralsSprite.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsSprite.Texture Top",
                            Type = "int",
                            Value = MineralsSprite.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsSprite.Texture Width",
                            Type = "int",
                            Value = MineralsSprite.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsSprite.Visible",
                            Type = "bool",
                            Value = MineralsSprite.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsSprite.Width",
                            Type = "float",
                            Value = MineralsSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = MineralsSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsSprite.X",
                            Type = "float",
                            Value = MineralsSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsSprite.X Units",
                            Type = "PositionUnitType",
                            Value = MineralsSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsSprite.Y",
                            Type = "float",
                            Value = MineralsSprite.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = MineralsSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsSprite.Y Units",
                            Type = "PositionUnitType",
                            Value = MineralsSprite.YUnits
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
                            Value = Width + 10f
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
                            Value = X + 0f
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
                            Name = "IncreaseAmount.Blue",
                            Type = "int",
                            Value = IncreaseAmount.Blue + 226
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IncreaseAmount.CustomFontFile",
                            Type = "string",
                            Value = IncreaseAmount.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IncreaseAmount.Font",
                            Type = "string",
                            Value = IncreaseAmount.Font
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IncreaseAmount.Font Scale",
                            Type = "float",
                            Value = IncreaseAmount.FontScale + 1f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IncreaseAmount.FontSize",
                            Type = "int",
                            Value = IncreaseAmount.FontSize + 50
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IncreaseAmount.Green",
                            Type = "int",
                            Value = IncreaseAmount.Green + 43
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IncreaseAmount.Height",
                            Type = "float",
                            Value = IncreaseAmount.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IncreaseAmount.Height Units",
                            Type = "DimensionUnitType",
                            Value = IncreaseAmount.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IncreaseAmount.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = IncreaseAmount.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IncreaseAmount.OutlineThickness",
                            Type = "int",
                            Value = IncreaseAmount.OutlineThickness + 2
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IncreaseAmount.Red",
                            Type = "int",
                            Value = IncreaseAmount.Red + 138
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IncreaseAmount.Text",
                            Type = "string",
                            Value = IncreaseAmount.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IncreaseAmount.UseCustomFont",
                            Type = "bool",
                            Value = IncreaseAmount.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IncreaseAmount.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = IncreaseAmount.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IncreaseAmount.Width",
                            Type = "float",
                            Value = IncreaseAmount.Width + 60f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IncreaseAmount.Width Units",
                            Type = "DimensionUnitType",
                            Value = IncreaseAmount.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsSprite.Height",
                            Type = "float",
                            Value = MineralsSprite.Height + 35f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = MineralsSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsSprite.Parent",
                            Type = "string",
                            Value = MineralsSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsSprite.SourceFile",
                            Type = "string",
                            Value = MineralsSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = MineralsSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsSprite.Texture Height",
                            Type = "int",
                            Value = MineralsSprite.TextureHeight + 12
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsSprite.Texture Left",
                            Type = "int",
                            Value = MineralsSprite.TextureLeft + 99
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsSprite.Texture Top",
                            Type = "int",
                            Value = MineralsSprite.TextureTop + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsSprite.Texture Width",
                            Type = "int",
                            Value = MineralsSprite.TextureWidth + 7
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsSprite.Visible",
                            Type = "bool",
                            Value = MineralsSprite.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsSprite.Width",
                            Type = "float",
                            Value = MineralsSprite.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = MineralsSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsSprite.X",
                            Type = "float",
                            Value = MineralsSprite.X + 5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsSprite.X Units",
                            Type = "PositionUnitType",
                            Value = MineralsSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsSprite.Y",
                            Type = "float",
                            Value = MineralsSprite.Y + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = MineralsSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsSprite.Y Units",
                            Type = "PositionUnitType",
                            Value = MineralsSprite.YUnits
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (FloatAnimationStates state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  FloatAnimationStates.FloatAnimationEnd:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Y",
                            Type = "float",
                            Value = Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IncreaseAmount.Alpha",
                            Type = "int",
                            Value = IncreaseAmount.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsSprite.Alpha",
                            Type = "int",
                            Value = MineralsSprite.Alpha
                        }
                        );
                        break;
                    case  FloatAnimationStates.FloatAnimationStart:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IncreaseAmount.Alpha",
                            Type = "int",
                            Value = IncreaseAmount.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsSprite.Alpha",
                            Type = "int",
                            Value = MineralsSprite.Alpha
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (FloatAnimationStates state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  FloatAnimationStates.FloatAnimationEnd:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Y",
                            Type = "float",
                            Value = Y + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IncreaseAmount.Alpha",
                            Type = "int",
                            Value = IncreaseAmount.Alpha + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsSprite.Alpha",
                            Type = "int",
                            Value = MineralsSprite.Alpha + 0
                        }
                        );
                        break;
                    case  FloatAnimationStates.FloatAnimationStart:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IncreaseAmount.Alpha",
                            Type = "int",
                            Value = IncreaseAmount.Alpha + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MineralsSprite.Alpha",
                            Type = "int",
                            Value = MineralsSprite.Alpha + 255
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
                    else if (category.Name == "FloatAnimationStates")
                    {
                        if(state.Name == "FloatAnimationEnd") this.mCurrentFloatAnimationStatesState = FloatAnimationStates.FloatAnimationEnd;
                        if(state.Name == "FloatAnimationStart") this.mCurrentFloatAnimationStatesState = FloatAnimationStates.FloatAnimationStart;
                    }
                }
                base.ApplyState(state);
            }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime IncreaseAmount { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime MineralsSprite { get; set; }
            public string AmountOfIncrease
            {
                get
                {
                    return IncreaseAmount.Text;
                }
                set
                {
                    if (IncreaseAmount.Text != value)
                    {
                        IncreaseAmount.Text = value;
                        AmountOfIncreaseChanged?.Invoke(this, null);
                    }
                }
            }
            public event System.EventHandler AmountOfIncreaseChanged;
            public ResourceIncreaseNotificationRuntime (bool fullInstantiation = true) 
            	: base(false)
            {
                this.HasEvents = true;
                this.ExposeChildrenEvents = true;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "infodisplays/ResourceIncreaseNotification");
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
                IncreaseAmount = this.GetGraphicalUiElementByName("IncreaseAmount") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
                MineralsSprite = this.GetGraphicalUiElementByName("MineralsSprite") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
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
