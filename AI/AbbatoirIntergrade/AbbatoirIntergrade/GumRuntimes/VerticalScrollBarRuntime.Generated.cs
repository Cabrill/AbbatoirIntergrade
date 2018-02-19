    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes
    {
        public partial class VerticalScrollBarRuntime : AbbatoirIntergrade.GumRuntimes.ContainerRuntime
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            public enum ScrollBarCategory
            {
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            ScrollBarCategory mCurrentScrollBarCategoryState;
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
                            Height = 100f;
                            HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            Width = 5f;
                            WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            BarSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            SetProperty("BarSprite.SourceFile", "AllUIAssets.png");
                            BarSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            BarSprite.TextureHeight = 600;
                            BarSprite.TextureLeft = 2435;
                            BarSprite.TextureTop = 0;
                            BarSprite.TextureWidth = 205;
                            BarSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ThumbInstance.Height = 150f;
                            ThumbInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            ThumbInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ScrollTrack");
                            ThumbInstance.Width = 100f;
                            ThumbInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            UpButtonInstance.Height = 5f;
                            UpButtonInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            UpButtonInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ContainerInstance");
                            UpButtonInstance.Width = 113f;
                            UpButtonInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                            UpButtonInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            UpButtonInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            UpButtonInstance.Y = 8f;
                            ScrollTrack.Height = 88.88889f;
                            ScrollTrack.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ScrollTrack.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ContainerInstance");
                            ScrollTrack.Width = 100f;
                            ScrollTrack.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            DownButtonInstance.Height = 5f;
                            DownButtonInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            DownButtonInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ContainerInstance");
                            DownButtonInstance.CurrentUpDownState = AbbatoirIntergrade.GumRuntimes.UpDownButtonRuntime.UpDown.Down;
                            DownButtonInstance.Width = 113f;
                            DownButtonInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                            DownButtonInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            DownButtonInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            DownButtonInstance.Y = -8f;
                            DownButtonInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                            DownButtonInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            ContainerInstance.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                            ContainerInstance.Height = 100f;
                            ContainerInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ContainerInstance.Width = 100f;
                            ContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            break;
                    }
                }
            }
            public ScrollBarCategory CurrentScrollBarCategoryState
            {
                get
                {
                    return mCurrentScrollBarCategoryState;
                }
                set
                {
                    mCurrentScrollBarCategoryState = value;
                    switch(mCurrentScrollBarCategoryState)
                    {
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
                bool setBarSpriteTextureHeightFirstValue = false;
                bool setBarSpriteTextureHeightSecondValue = false;
                int BarSpriteTextureHeightFirstValue= 0;
                int BarSpriteTextureHeightSecondValue= 0;
                bool setBarSpriteTextureLeftFirstValue = false;
                bool setBarSpriteTextureLeftSecondValue = false;
                int BarSpriteTextureLeftFirstValue= 0;
                int BarSpriteTextureLeftSecondValue= 0;
                bool setBarSpriteTextureTopFirstValue = false;
                bool setBarSpriteTextureTopSecondValue = false;
                int BarSpriteTextureTopFirstValue= 0;
                int BarSpriteTextureTopSecondValue= 0;
                bool setBarSpriteTextureWidthFirstValue = false;
                bool setBarSpriteTextureWidthSecondValue = false;
                int BarSpriteTextureWidthFirstValue= 0;
                int BarSpriteTextureWidthSecondValue= 0;
                bool setContainerInstanceHeightFirstValue = false;
                bool setContainerInstanceHeightSecondValue = false;
                float ContainerInstanceHeightFirstValue= 0;
                float ContainerInstanceHeightSecondValue= 0;
                bool setContainerInstanceWidthFirstValue = false;
                bool setContainerInstanceWidthSecondValue = false;
                float ContainerInstanceWidthFirstValue= 0;
                float ContainerInstanceWidthSecondValue= 0;
                bool setDownButtonInstanceHeightFirstValue = false;
                bool setDownButtonInstanceHeightSecondValue = false;
                float DownButtonInstanceHeightFirstValue= 0;
                float DownButtonInstanceHeightSecondValue= 0;
                bool setDownButtonInstanceCurrentUpDownStateFirstValue = false;
                bool setDownButtonInstanceCurrentUpDownStateSecondValue = false;
                UpDownButtonRuntime.UpDown DownButtonInstanceCurrentUpDownStateFirstValue= UpDownButtonRuntime.UpDown.Up;
                UpDownButtonRuntime.UpDown DownButtonInstanceCurrentUpDownStateSecondValue= UpDownButtonRuntime.UpDown.Up;
                bool setDownButtonInstanceWidthFirstValue = false;
                bool setDownButtonInstanceWidthSecondValue = false;
                float DownButtonInstanceWidthFirstValue= 0;
                float DownButtonInstanceWidthSecondValue= 0;
                bool setDownButtonInstanceYFirstValue = false;
                bool setDownButtonInstanceYSecondValue = false;
                float DownButtonInstanceYFirstValue= 0;
                float DownButtonInstanceYSecondValue= 0;
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setScrollTrackHeightFirstValue = false;
                bool setScrollTrackHeightSecondValue = false;
                float ScrollTrackHeightFirstValue= 0;
                float ScrollTrackHeightSecondValue= 0;
                bool setScrollTrackWidthFirstValue = false;
                bool setScrollTrackWidthSecondValue = false;
                float ScrollTrackWidthFirstValue= 0;
                float ScrollTrackWidthSecondValue= 0;
                bool setThumbInstanceHeightFirstValue = false;
                bool setThumbInstanceHeightSecondValue = false;
                float ThumbInstanceHeightFirstValue= 0;
                float ThumbInstanceHeightSecondValue= 0;
                bool setThumbInstanceWidthFirstValue = false;
                bool setThumbInstanceWidthSecondValue = false;
                float ThumbInstanceWidthFirstValue= 0;
                float ThumbInstanceWidthSecondValue= 0;
                bool setUpButtonInstanceHeightFirstValue = false;
                bool setUpButtonInstanceHeightSecondValue = false;
                float UpButtonInstanceHeightFirstValue= 0;
                float UpButtonInstanceHeightSecondValue= 0;
                bool setUpButtonInstanceWidthFirstValue = false;
                bool setUpButtonInstanceWidthSecondValue = false;
                float UpButtonInstanceWidthFirstValue= 0;
                float UpButtonInstanceWidthSecondValue= 0;
                bool setUpButtonInstanceYFirstValue = false;
                bool setUpButtonInstanceYSecondValue = false;
                float UpButtonInstanceYFirstValue= 0;
                float UpButtonInstanceYSecondValue= 0;
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        if (interpolationValue < 1)
                        {
                            this.BarSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("BarSprite.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.BarSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setBarSpriteTextureHeightFirstValue = true;
                        BarSpriteTextureHeightFirstValue = 600;
                        setBarSpriteTextureLeftFirstValue = true;
                        BarSpriteTextureLeftFirstValue = 2435;
                        setBarSpriteTextureTopFirstValue = true;
                        BarSpriteTextureTopFirstValue = 0;
                        setBarSpriteTextureWidthFirstValue = true;
                        BarSpriteTextureWidthFirstValue = 205;
                        if (interpolationValue < 1)
                        {
                            this.BarSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ChildrenLayout = Gum.Managers.ChildrenLayout.Regular;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ContainerInstance.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setContainerInstanceHeightFirstValue = true;
                        ContainerInstanceHeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.ContainerInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setContainerInstanceWidthFirstValue = true;
                        ContainerInstanceWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.ContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setDownButtonInstanceHeightFirstValue = true;
                        DownButtonInstanceHeightFirstValue = 5f;
                        if (interpolationValue < 1)
                        {
                            this.DownButtonInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.DownButtonInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ContainerInstance");
                        }
                        setDownButtonInstanceCurrentUpDownStateFirstValue = true;
                        DownButtonInstanceCurrentUpDownStateFirstValue = AbbatoirIntergrade.GumRuntimes.UpDownButtonRuntime.UpDown.Down;
                        setDownButtonInstanceWidthFirstValue = true;
                        DownButtonInstanceWidthFirstValue = 113f;
                        if (interpolationValue < 1)
                        {
                            this.DownButtonInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        if (interpolationValue < 1)
                        {
                            this.DownButtonInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.DownButtonInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setDownButtonInstanceYFirstValue = true;
                        DownButtonInstanceYFirstValue = -8f;
                        if (interpolationValue < 1)
                        {
                            this.DownButtonInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue < 1)
                        {
                            this.DownButtonInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setHeightFirstValue = true;
                        HeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setScrollTrackHeightFirstValue = true;
                        ScrollTrackHeightFirstValue = 88.88889f;
                        if (interpolationValue < 1)
                        {
                            this.ScrollTrack.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ScrollTrack.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ContainerInstance");
                        }
                        setScrollTrackWidthFirstValue = true;
                        ScrollTrackWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.ScrollTrack.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setThumbInstanceHeightFirstValue = true;
                        ThumbInstanceHeightFirstValue = 150f;
                        if (interpolationValue < 1)
                        {
                            this.ThumbInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ThumbInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ScrollTrack");
                        }
                        setThumbInstanceWidthFirstValue = true;
                        ThumbInstanceWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.ThumbInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setUpButtonInstanceHeightFirstValue = true;
                        UpButtonInstanceHeightFirstValue = 5f;
                        if (interpolationValue < 1)
                        {
                            this.UpButtonInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.UpButtonInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ContainerInstance");
                        }
                        setUpButtonInstanceWidthFirstValue = true;
                        UpButtonInstanceWidthFirstValue = 113f;
                        if (interpolationValue < 1)
                        {
                            this.UpButtonInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        if (interpolationValue < 1)
                        {
                            this.UpButtonInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.UpButtonInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setUpButtonInstanceYFirstValue = true;
                        UpButtonInstanceYFirstValue = 8f;
                        setWidthFirstValue = true;
                        WidthFirstValue = 5f;
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
                        if (interpolationValue >= 1)
                        {
                            this.BarSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("BarSprite.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.BarSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setBarSpriteTextureHeightSecondValue = true;
                        BarSpriteTextureHeightSecondValue = 600;
                        setBarSpriteTextureLeftSecondValue = true;
                        BarSpriteTextureLeftSecondValue = 2435;
                        setBarSpriteTextureTopSecondValue = true;
                        BarSpriteTextureTopSecondValue = 0;
                        setBarSpriteTextureWidthSecondValue = true;
                        BarSpriteTextureWidthSecondValue = 205;
                        if (interpolationValue >= 1)
                        {
                            this.BarSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ChildrenLayout = Gum.Managers.ChildrenLayout.Regular;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ContainerInstance.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setContainerInstanceHeightSecondValue = true;
                        ContainerInstanceHeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.ContainerInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setContainerInstanceWidthSecondValue = true;
                        ContainerInstanceWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.ContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setDownButtonInstanceHeightSecondValue = true;
                        DownButtonInstanceHeightSecondValue = 5f;
                        if (interpolationValue >= 1)
                        {
                            this.DownButtonInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.DownButtonInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ContainerInstance");
                        }
                        setDownButtonInstanceCurrentUpDownStateSecondValue = true;
                        DownButtonInstanceCurrentUpDownStateSecondValue = AbbatoirIntergrade.GumRuntimes.UpDownButtonRuntime.UpDown.Down;
                        setDownButtonInstanceWidthSecondValue = true;
                        DownButtonInstanceWidthSecondValue = 113f;
                        if (interpolationValue >= 1)
                        {
                            this.DownButtonInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.DownButtonInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.DownButtonInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setDownButtonInstanceYSecondValue = true;
                        DownButtonInstanceYSecondValue = -8f;
                        if (interpolationValue >= 1)
                        {
                            this.DownButtonInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.DownButtonInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setHeightSecondValue = true;
                        HeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setScrollTrackHeightSecondValue = true;
                        ScrollTrackHeightSecondValue = 88.88889f;
                        if (interpolationValue >= 1)
                        {
                            this.ScrollTrack.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ScrollTrack.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ContainerInstance");
                        }
                        setScrollTrackWidthSecondValue = true;
                        ScrollTrackWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.ScrollTrack.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setThumbInstanceHeightSecondValue = true;
                        ThumbInstanceHeightSecondValue = 150f;
                        if (interpolationValue >= 1)
                        {
                            this.ThumbInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ThumbInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ScrollTrack");
                        }
                        setThumbInstanceWidthSecondValue = true;
                        ThumbInstanceWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.ThumbInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setUpButtonInstanceHeightSecondValue = true;
                        UpButtonInstanceHeightSecondValue = 5f;
                        if (interpolationValue >= 1)
                        {
                            this.UpButtonInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.UpButtonInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ContainerInstance");
                        }
                        setUpButtonInstanceWidthSecondValue = true;
                        UpButtonInstanceWidthSecondValue = 113f;
                        if (interpolationValue >= 1)
                        {
                            this.UpButtonInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.UpButtonInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.UpButtonInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setUpButtonInstanceYSecondValue = true;
                        UpButtonInstanceYSecondValue = 8f;
                        setWidthSecondValue = true;
                        WidthSecondValue = 5f;
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
                if (setBarSpriteTextureHeightFirstValue && setBarSpriteTextureHeightSecondValue)
                {
                    BarSprite.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(BarSpriteTextureHeightFirstValue* (1 - interpolationValue) + BarSpriteTextureHeightSecondValue * interpolationValue);
                }
                if (setBarSpriteTextureLeftFirstValue && setBarSpriteTextureLeftSecondValue)
                {
                    BarSprite.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(BarSpriteTextureLeftFirstValue* (1 - interpolationValue) + BarSpriteTextureLeftSecondValue * interpolationValue);
                }
                if (setBarSpriteTextureTopFirstValue && setBarSpriteTextureTopSecondValue)
                {
                    BarSprite.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(BarSpriteTextureTopFirstValue* (1 - interpolationValue) + BarSpriteTextureTopSecondValue * interpolationValue);
                }
                if (setBarSpriteTextureWidthFirstValue && setBarSpriteTextureWidthSecondValue)
                {
                    BarSprite.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(BarSpriteTextureWidthFirstValue* (1 - interpolationValue) + BarSpriteTextureWidthSecondValue * interpolationValue);
                }
                if (setContainerInstanceHeightFirstValue && setContainerInstanceHeightSecondValue)
                {
                    ContainerInstance.Height = ContainerInstanceHeightFirstValue * (1 - interpolationValue) + ContainerInstanceHeightSecondValue * interpolationValue;
                }
                if (setContainerInstanceWidthFirstValue && setContainerInstanceWidthSecondValue)
                {
                    ContainerInstance.Width = ContainerInstanceWidthFirstValue * (1 - interpolationValue) + ContainerInstanceWidthSecondValue * interpolationValue;
                }
                if (setDownButtonInstanceHeightFirstValue && setDownButtonInstanceHeightSecondValue)
                {
                    DownButtonInstance.Height = DownButtonInstanceHeightFirstValue * (1 - interpolationValue) + DownButtonInstanceHeightSecondValue * interpolationValue;
                }
                if (setDownButtonInstanceCurrentUpDownStateFirstValue && setDownButtonInstanceCurrentUpDownStateSecondValue)
                {
                    DownButtonInstance.InterpolateBetween(DownButtonInstanceCurrentUpDownStateFirstValue, DownButtonInstanceCurrentUpDownStateSecondValue, interpolationValue);
                }
                if (setDownButtonInstanceWidthFirstValue && setDownButtonInstanceWidthSecondValue)
                {
                    DownButtonInstance.Width = DownButtonInstanceWidthFirstValue * (1 - interpolationValue) + DownButtonInstanceWidthSecondValue * interpolationValue;
                }
                if (setDownButtonInstanceYFirstValue && setDownButtonInstanceYSecondValue)
                {
                    DownButtonInstance.Y = DownButtonInstanceYFirstValue * (1 - interpolationValue) + DownButtonInstanceYSecondValue * interpolationValue;
                }
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
                }
                if (setScrollTrackHeightFirstValue && setScrollTrackHeightSecondValue)
                {
                    ScrollTrack.Height = ScrollTrackHeightFirstValue * (1 - interpolationValue) + ScrollTrackHeightSecondValue * interpolationValue;
                }
                if (setScrollTrackWidthFirstValue && setScrollTrackWidthSecondValue)
                {
                    ScrollTrack.Width = ScrollTrackWidthFirstValue * (1 - interpolationValue) + ScrollTrackWidthSecondValue * interpolationValue;
                }
                if (setThumbInstanceHeightFirstValue && setThumbInstanceHeightSecondValue)
                {
                    ThumbInstance.Height = ThumbInstanceHeightFirstValue * (1 - interpolationValue) + ThumbInstanceHeightSecondValue * interpolationValue;
                }
                if (setThumbInstanceWidthFirstValue && setThumbInstanceWidthSecondValue)
                {
                    ThumbInstance.Width = ThumbInstanceWidthFirstValue * (1 - interpolationValue) + ThumbInstanceWidthSecondValue * interpolationValue;
                }
                if (setUpButtonInstanceHeightFirstValue && setUpButtonInstanceHeightSecondValue)
                {
                    UpButtonInstance.Height = UpButtonInstanceHeightFirstValue * (1 - interpolationValue) + UpButtonInstanceHeightSecondValue * interpolationValue;
                }
                if (setUpButtonInstanceWidthFirstValue && setUpButtonInstanceWidthSecondValue)
                {
                    UpButtonInstance.Width = UpButtonInstanceWidthFirstValue * (1 - interpolationValue) + UpButtonInstanceWidthSecondValue * interpolationValue;
                }
                if (setUpButtonInstanceYFirstValue && setUpButtonInstanceYSecondValue)
                {
                    UpButtonInstance.Y = UpButtonInstanceYFirstValue * (1 - interpolationValue) + UpButtonInstanceYSecondValue * interpolationValue;
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
            public void InterpolateBetween (ScrollBarCategory firstState, ScrollBarCategory secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                switch(firstState)
                {
                }
                switch(secondState)
                {
                }
                if (interpolationValue < 1)
                {
                    mCurrentScrollBarCategoryState = firstState;
                }
                else
                {
                    mCurrentScrollBarCategoryState = secondState;
                }
            }
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.VerticalScrollBarRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.VerticalScrollBarRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.VerticalScrollBarRuntime.ScrollBarCategory fromState,AbbatoirIntergrade.GumRuntimes.VerticalScrollBarRuntime.ScrollBarCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (ScrollBarCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "ScrollBarCategory").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentScrollBarCategoryState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (ScrollBarCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentScrollBarCategoryState = toState;
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
                ThumbInstance.StopAnimations();
                UpButtonInstance.StopAnimations();
                DownButtonInstance.StopAnimations();
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
                            Name = "BarSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = BarSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BarSprite.SourceFile",
                            Type = "string",
                            Value = BarSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BarSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = BarSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BarSprite.Texture Height",
                            Type = "int",
                            Value = BarSprite.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BarSprite.Texture Left",
                            Type = "int",
                            Value = BarSprite.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BarSprite.Texture Top",
                            Type = "int",
                            Value = BarSprite.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BarSprite.Texture Width",
                            Type = "int",
                            Value = BarSprite.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BarSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = BarSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbInstance.Height",
                            Type = "float",
                            Value = ThumbInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = ThumbInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbInstance.Parent",
                            Type = "string",
                            Value = ThumbInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbInstance.Width",
                            Type = "float",
                            Value = ThumbInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = ThumbInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpButtonInstance.Height",
                            Type = "float",
                            Value = UpButtonInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpButtonInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = UpButtonInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpButtonInstance.Parent",
                            Type = "string",
                            Value = UpButtonInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpButtonInstance.Width",
                            Type = "float",
                            Value = UpButtonInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpButtonInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = UpButtonInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpButtonInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = UpButtonInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpButtonInstance.X Units",
                            Type = "PositionUnitType",
                            Value = UpButtonInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpButtonInstance.Y",
                            Type = "float",
                            Value = UpButtonInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScrollTrack.Height",
                            Type = "float",
                            Value = ScrollTrack.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScrollTrack.Height Units",
                            Type = "DimensionUnitType",
                            Value = ScrollTrack.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScrollTrack.Parent",
                            Type = "string",
                            Value = ScrollTrack.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScrollTrack.Width",
                            Type = "float",
                            Value = ScrollTrack.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScrollTrack.Width Units",
                            Type = "DimensionUnitType",
                            Value = ScrollTrack.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DownButtonInstance.Height",
                            Type = "float",
                            Value = DownButtonInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DownButtonInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = DownButtonInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DownButtonInstance.Parent",
                            Type = "string",
                            Value = DownButtonInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DownButtonInstance.UpDownState",
                            Type = "UpDownState",
                            Value = DownButtonInstance.CurrentUpDownState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DownButtonInstance.Width",
                            Type = "float",
                            Value = DownButtonInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DownButtonInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = DownButtonInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DownButtonInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = DownButtonInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DownButtonInstance.X Units",
                            Type = "PositionUnitType",
                            Value = DownButtonInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DownButtonInstance.Y",
                            Type = "float",
                            Value = DownButtonInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DownButtonInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = DownButtonInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DownButtonInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = DownButtonInstance.YUnits
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
                            Name = "Width",
                            Type = "float",
                            Value = Width + 5f
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
                            Name = "BarSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = BarSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BarSprite.SourceFile",
                            Type = "string",
                            Value = BarSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BarSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = BarSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BarSprite.Texture Height",
                            Type = "int",
                            Value = BarSprite.TextureHeight + 600
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BarSprite.Texture Left",
                            Type = "int",
                            Value = BarSprite.TextureLeft + 2435
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BarSprite.Texture Top",
                            Type = "int",
                            Value = BarSprite.TextureTop + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BarSprite.Texture Width",
                            Type = "int",
                            Value = BarSprite.TextureWidth + 205
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BarSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = BarSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbInstance.Height",
                            Type = "float",
                            Value = ThumbInstance.Height + 150f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = ThumbInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbInstance.Parent",
                            Type = "string",
                            Value = ThumbInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbInstance.Width",
                            Type = "float",
                            Value = ThumbInstance.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ThumbInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = ThumbInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpButtonInstance.Height",
                            Type = "float",
                            Value = UpButtonInstance.Height + 5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpButtonInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = UpButtonInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpButtonInstance.Parent",
                            Type = "string",
                            Value = UpButtonInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpButtonInstance.Width",
                            Type = "float",
                            Value = UpButtonInstance.Width + 113f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpButtonInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = UpButtonInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpButtonInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = UpButtonInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpButtonInstance.X Units",
                            Type = "PositionUnitType",
                            Value = UpButtonInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "UpButtonInstance.Y",
                            Type = "float",
                            Value = UpButtonInstance.Y + 8f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScrollTrack.Height",
                            Type = "float",
                            Value = ScrollTrack.Height + 88.88889f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScrollTrack.Height Units",
                            Type = "DimensionUnitType",
                            Value = ScrollTrack.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScrollTrack.Parent",
                            Type = "string",
                            Value = ScrollTrack.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScrollTrack.Width",
                            Type = "float",
                            Value = ScrollTrack.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScrollTrack.Width Units",
                            Type = "DimensionUnitType",
                            Value = ScrollTrack.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DownButtonInstance.Height",
                            Type = "float",
                            Value = DownButtonInstance.Height + 5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DownButtonInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = DownButtonInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DownButtonInstance.Parent",
                            Type = "string",
                            Value = DownButtonInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DownButtonInstance.UpDownState",
                            Type = "UpDownState",
                            Value = DownButtonInstance.CurrentUpDownState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DownButtonInstance.Width",
                            Type = "float",
                            Value = DownButtonInstance.Width + 113f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DownButtonInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = DownButtonInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DownButtonInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = DownButtonInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DownButtonInstance.X Units",
                            Type = "PositionUnitType",
                            Value = DownButtonInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DownButtonInstance.Y",
                            Type = "float",
                            Value = DownButtonInstance.Y + -8f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DownButtonInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = DownButtonInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DownButtonInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = DownButtonInstance.YUnits
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
                            Value = ContainerInstance.Height + 100f
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
                            Value = ContainerInstance.Width + 100f
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
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (ScrollBarCategory state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (ScrollBarCategory state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
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
                    else if (category.Name == "ScrollBarCategory")
                    {
                    }
                }
                base.ApplyState(state);
            }
            private bool tryCreateFormsObject;
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime BarSprite { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ScrollThumbRuntime ThumbInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.UpDownButtonRuntime UpButtonInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime ScrollTrack { get; set; }
            private AbbatoirIntergrade.GumRuntimes.UpDownButtonRuntime DownButtonInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime ContainerInstance { get; set; }
            public VerticalScrollBarRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                this.tryCreateFormsObject = tryCreateFormsObject;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "VerticalScrollBar");
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
                BarSprite = this.GetGraphicalUiElementByName("BarSprite") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                ThumbInstance = this.GetGraphicalUiElementByName("ThumbInstance") as AbbatoirIntergrade.GumRuntimes.ScrollThumbRuntime;
                UpButtonInstance = this.GetGraphicalUiElementByName("UpButtonInstance") as AbbatoirIntergrade.GumRuntimes.UpDownButtonRuntime;
                ScrollTrack = this.GetGraphicalUiElementByName("ScrollTrack") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
                DownButtonInstance = this.GetGraphicalUiElementByName("DownButtonInstance") as AbbatoirIntergrade.GumRuntimes.UpDownButtonRuntime;
                ContainerInstance = this.GetGraphicalUiElementByName("ContainerInstance") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
                if (tryCreateFormsObject)
                {
                    FormsControl = new FlatRedBall.Forms.Controls.ScrollBar(this);
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
            public FlatRedBall.Forms.Controls.ScrollBar FormsControl {get; private set;}
            public override object FormsControlAsObject { get { return FormsControl; } }
        }
    }
