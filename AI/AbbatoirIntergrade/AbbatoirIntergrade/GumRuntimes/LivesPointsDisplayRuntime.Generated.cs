    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes
    {
        public partial class LivesPointsDisplayRuntime : AbbatoirIntergrade.GumRuntimes.ContainerRuntime
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            public enum LivesChange
            {
                StartReduce,
                Mid1Reduce,
                Mid2Reduce,
                Mid3Reduce,
                EndReduce
            }
            public enum PointsChange
            {
                PointsIncreaseStart,
                PointsIncreaseEnd,
                PointsDecreaseStart,
                PointsDecreaseEnd
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            LivesChange mCurrentLivesChangeState;
            PointsChange mCurrentPointsChangeState;
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
                            Height = 127f;
                            Width = 408f;
                            MessageFrameInstance.Height = 100f;
                            MessageFrameInstance.Width = 100f;
                            MessageFrameInstance.X = 0f;
                            MessageFrameInstance.Y = 0f;
                            LivesSprite.Height = 80f;
                            LivesSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            LivesSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "LivesContainer");
                            SetProperty("LivesSprite.SourceFile", "AllUIAssets.png");
                            LivesSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            LivesSprite.TextureHeight = 128;
                            LivesSprite.TextureLeft = 2443;
                            LivesSprite.TextureTop = 779;
                            LivesSprite.TextureWidth = 54;
                            LivesSprite.Width = 42.5196f;
                            LivesSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                            LivesSprite.X = 5f;
                            LivesSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            LivesSprite.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            LivesSprite.Y = 0f;
                            LivesSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            LivesSprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            SetProperty("LivesRemainingText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                            LivesRemainingText.Height = 112f;
                            LivesRemainingText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            LivesRemainingText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "LivesContainer");
                            LivesRemainingText.Text = "30";
                            LivesRemainingText.UseCustomFont = true;
                            LivesRemainingText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            LivesRemainingText.Width = 97f;
                            LivesRemainingText.X = 71f;
                            LivesRemainingText.Y = 7f;
                            LivesXSprite.Alpha = 0;
                            LivesXSprite.Height = 64f;
                            LivesXSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            LivesXSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "LivesContainer");
                            SetProperty("LivesXSprite.SourceFile", "AllUIAssets.png");
                            LivesXSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            LivesXSprite.TextureHeight = 114;
                            LivesXSprite.TextureLeft = 2505;
                            LivesXSprite.TextureTop = 792;
                            LivesXSprite.TextureWidth = 114;
                            LivesXSprite.Visible = true;
                            LivesXSprite.Width = 64f;
                            LivesXSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            LivesXSprite.X = 41f;
                            LivesXSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            LivesXSprite.Y = 61f;
                            LivesXSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            LivesContainer.Height = 100f;
                            LivesContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            LivesContainer.Width = 50f;
                            LivesContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            LivesContainer.X = 15f;
                            PointsContainer.Height = 100f;
                            PointsContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            PointsContainer.Width = 45f;
                            PointsContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            PointsContainer.X = 219f;
                            PointsContainer.Y = 0f;
                            PointsSprite.Height = 50f;
                            PointsSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            PointsSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "PointsContainer");
                            SetProperty("PointsSprite.SourceFile", "AllUIAssets.png");
                            PointsSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            PointsSprite.TextureHeight = 122;
                            PointsSprite.TextureLeft = 2435;
                            PointsSprite.TextureTop = 910;
                            PointsSprite.TextureWidth = 128;
                            PointsSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                            PointsSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            PointsSprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            PointsText.Alpha = 255;
                            SetProperty("PointsText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                            PointsText.Height = 112f;
                            PointsText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            PointsText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "PointsContainer");
                            PointsText.Text = "30";
                            PointsText.UseCustomFont = true;
                            PointsText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            PointsText.Width = 97f;
                            PointsText.X = 71f;
                            PointsText.Y = 7f;
                            PointsChangeText.Alpha = 0;
                            SetProperty("PointsChangeText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                            PointsChangeText.Height = 112f;
                            PointsChangeText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            PointsChangeText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "PointsContainer");
                            PointsChangeText.Text = "+1";
                            PointsChangeText.UseCustomFont = true;
                            PointsChangeText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            PointsChangeText.Width = 97f;
                            PointsChangeText.X = 71f;
                            PointsChangeText.Y = 7f;
                            break;
                    }
                }
            }
            public LivesChange CurrentLivesChangeState
            {
                get
                {
                    return mCurrentLivesChangeState;
                }
                set
                {
                    mCurrentLivesChangeState = value;
                    switch(mCurrentLivesChangeState)
                    {
                        case  LivesChange.StartReduce:
                            LivesSprite.Blue = 255;
                            LivesSprite.Green = 255;
                            LivesXSprite.Alpha = 0;
                            LivesXSprite.Height = 64f;
                            LivesXSprite.Width = 64f;
                            break;
                        case  LivesChange.Mid1Reduce:
                            LivesSprite.Blue = 100;
                            LivesSprite.Green = 100;
                            LivesXSprite.Alpha = 100;
                            LivesXSprite.Height = 64f;
                            LivesXSprite.Width = 64f;
                            break;
                        case  LivesChange.Mid2Reduce:
                            LivesSprite.Blue = 0;
                            LivesSprite.Green = 0;
                            LivesXSprite.Alpha = 255;
                            LivesXSprite.Height = 80f;
                            LivesXSprite.Width = 80f;
                            break;
                        case  LivesChange.Mid3Reduce:
                            LivesSprite.Blue = 150;
                            LivesSprite.Green = 150;
                            LivesXSprite.Alpha = 100;
                            LivesXSprite.Height = 64f;
                            LivesXSprite.Width = 64f;
                            break;
                        case  LivesChange.EndReduce:
                            LivesSprite.Blue = 255;
                            LivesSprite.Green = 255;
                            LivesXSprite.Alpha = 0;
                            LivesXSprite.Height = 64f;
                            LivesXSprite.Width = 64f;
                            break;
                    }
                }
            }
            public PointsChange CurrentPointsChangeState
            {
                get
                {
                    return mCurrentPointsChangeState;
                }
                set
                {
                    mCurrentPointsChangeState = value;
                    switch(mCurrentPointsChangeState)
                    {
                        case  PointsChange.PointsIncreaseStart:
                            PointsText.Blue = 100;
                            PointsText.Green = 255;
                            PointsText.Red = 100;
                            PointsChangeText.Alpha = 255;
                            PointsChangeText.Blue = 0;
                            PointsChangeText.Green = 255;
                            PointsChangeText.Red = 0;
                            PointsChangeText.Y = 7f;
                            break;
                        case  PointsChange.PointsIncreaseEnd:
                            PointsText.Blue = 255;
                            PointsText.Green = 255;
                            PointsText.Red = 255;
                            PointsChangeText.Alpha = 0;
                            PointsChangeText.Blue = 0;
                            PointsChangeText.Green = 255;
                            PointsChangeText.Red = 0;
                            PointsChangeText.Y = -100f;
                            break;
                        case  PointsChange.PointsDecreaseStart:
                            PointsText.Blue = 100;
                            PointsText.Green = 100;
                            PointsText.Red = 255;
                            PointsChangeText.Alpha = 255;
                            PointsChangeText.Blue = 0;
                            PointsChangeText.Green = 0;
                            PointsChangeText.Red = 255;
                            PointsChangeText.Y = 7f;
                            break;
                        case  PointsChange.PointsDecreaseEnd:
                            PointsText.Blue = 255;
                            PointsText.Green = 255;
                            PointsText.Red = 255;
                            PointsChangeText.Alpha = 0;
                            PointsChangeText.Blue = 255;
                            PointsChangeText.Green = 255;
                            PointsChangeText.Red = 255;
                            PointsChangeText.Y = 100f;
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
                bool setLivesContainerHeightFirstValue = false;
                bool setLivesContainerHeightSecondValue = false;
                float LivesContainerHeightFirstValue= 0;
                float LivesContainerHeightSecondValue= 0;
                bool setLivesContainerWidthFirstValue = false;
                bool setLivesContainerWidthSecondValue = false;
                float LivesContainerWidthFirstValue= 0;
                float LivesContainerWidthSecondValue= 0;
                bool setLivesContainerXFirstValue = false;
                bool setLivesContainerXSecondValue = false;
                float LivesContainerXFirstValue= 0;
                float LivesContainerXSecondValue= 0;
                bool setLivesRemainingTextHeightFirstValue = false;
                bool setLivesRemainingTextHeightSecondValue = false;
                float LivesRemainingTextHeightFirstValue= 0;
                float LivesRemainingTextHeightSecondValue= 0;
                bool setLivesRemainingTextWidthFirstValue = false;
                bool setLivesRemainingTextWidthSecondValue = false;
                float LivesRemainingTextWidthFirstValue= 0;
                float LivesRemainingTextWidthSecondValue= 0;
                bool setLivesRemainingTextXFirstValue = false;
                bool setLivesRemainingTextXSecondValue = false;
                float LivesRemainingTextXFirstValue= 0;
                float LivesRemainingTextXSecondValue= 0;
                bool setLivesRemainingTextYFirstValue = false;
                bool setLivesRemainingTextYSecondValue = false;
                float LivesRemainingTextYFirstValue= 0;
                float LivesRemainingTextYSecondValue= 0;
                bool setLivesSpriteHeightFirstValue = false;
                bool setLivesSpriteHeightSecondValue = false;
                float LivesSpriteHeightFirstValue= 0;
                float LivesSpriteHeightSecondValue= 0;
                bool setLivesSpriteTextureHeightFirstValue = false;
                bool setLivesSpriteTextureHeightSecondValue = false;
                int LivesSpriteTextureHeightFirstValue= 0;
                int LivesSpriteTextureHeightSecondValue= 0;
                bool setLivesSpriteTextureLeftFirstValue = false;
                bool setLivesSpriteTextureLeftSecondValue = false;
                int LivesSpriteTextureLeftFirstValue= 0;
                int LivesSpriteTextureLeftSecondValue= 0;
                bool setLivesSpriteTextureTopFirstValue = false;
                bool setLivesSpriteTextureTopSecondValue = false;
                int LivesSpriteTextureTopFirstValue= 0;
                int LivesSpriteTextureTopSecondValue= 0;
                bool setLivesSpriteTextureWidthFirstValue = false;
                bool setLivesSpriteTextureWidthSecondValue = false;
                int LivesSpriteTextureWidthFirstValue= 0;
                int LivesSpriteTextureWidthSecondValue= 0;
                bool setLivesSpriteWidthFirstValue = false;
                bool setLivesSpriteWidthSecondValue = false;
                float LivesSpriteWidthFirstValue= 0;
                float LivesSpriteWidthSecondValue= 0;
                bool setLivesSpriteXFirstValue = false;
                bool setLivesSpriteXSecondValue = false;
                float LivesSpriteXFirstValue= 0;
                float LivesSpriteXSecondValue= 0;
                bool setLivesSpriteYFirstValue = false;
                bool setLivesSpriteYSecondValue = false;
                float LivesSpriteYFirstValue= 0;
                float LivesSpriteYSecondValue= 0;
                bool setLivesXSpriteAlphaFirstValue = false;
                bool setLivesXSpriteAlphaSecondValue = false;
                int LivesXSpriteAlphaFirstValue= 0;
                int LivesXSpriteAlphaSecondValue= 0;
                bool setLivesXSpriteHeightFirstValue = false;
                bool setLivesXSpriteHeightSecondValue = false;
                float LivesXSpriteHeightFirstValue= 0;
                float LivesXSpriteHeightSecondValue= 0;
                bool setLivesXSpriteTextureHeightFirstValue = false;
                bool setLivesXSpriteTextureHeightSecondValue = false;
                int LivesXSpriteTextureHeightFirstValue= 0;
                int LivesXSpriteTextureHeightSecondValue= 0;
                bool setLivesXSpriteTextureLeftFirstValue = false;
                bool setLivesXSpriteTextureLeftSecondValue = false;
                int LivesXSpriteTextureLeftFirstValue= 0;
                int LivesXSpriteTextureLeftSecondValue= 0;
                bool setLivesXSpriteTextureTopFirstValue = false;
                bool setLivesXSpriteTextureTopSecondValue = false;
                int LivesXSpriteTextureTopFirstValue= 0;
                int LivesXSpriteTextureTopSecondValue= 0;
                bool setLivesXSpriteTextureWidthFirstValue = false;
                bool setLivesXSpriteTextureWidthSecondValue = false;
                int LivesXSpriteTextureWidthFirstValue= 0;
                int LivesXSpriteTextureWidthSecondValue= 0;
                bool setLivesXSpriteWidthFirstValue = false;
                bool setLivesXSpriteWidthSecondValue = false;
                float LivesXSpriteWidthFirstValue= 0;
                float LivesXSpriteWidthSecondValue= 0;
                bool setLivesXSpriteXFirstValue = false;
                bool setLivesXSpriteXSecondValue = false;
                float LivesXSpriteXFirstValue= 0;
                float LivesXSpriteXSecondValue= 0;
                bool setLivesXSpriteYFirstValue = false;
                bool setLivesXSpriteYSecondValue = false;
                float LivesXSpriteYFirstValue= 0;
                float LivesXSpriteYSecondValue= 0;
                bool setMessageFrameInstanceHeightFirstValue = false;
                bool setMessageFrameInstanceHeightSecondValue = false;
                float MessageFrameInstanceHeightFirstValue= 0;
                float MessageFrameInstanceHeightSecondValue= 0;
                bool setMessageFrameInstanceWidthFirstValue = false;
                bool setMessageFrameInstanceWidthSecondValue = false;
                float MessageFrameInstanceWidthFirstValue= 0;
                float MessageFrameInstanceWidthSecondValue= 0;
                bool setMessageFrameInstanceXFirstValue = false;
                bool setMessageFrameInstanceXSecondValue = false;
                float MessageFrameInstanceXFirstValue= 0;
                float MessageFrameInstanceXSecondValue= 0;
                bool setMessageFrameInstanceYFirstValue = false;
                bool setMessageFrameInstanceYSecondValue = false;
                float MessageFrameInstanceYFirstValue= 0;
                float MessageFrameInstanceYSecondValue= 0;
                bool setPointsChangeTextAlphaFirstValue = false;
                bool setPointsChangeTextAlphaSecondValue = false;
                int PointsChangeTextAlphaFirstValue= 0;
                int PointsChangeTextAlphaSecondValue= 0;
                bool setPointsChangeTextHeightFirstValue = false;
                bool setPointsChangeTextHeightSecondValue = false;
                float PointsChangeTextHeightFirstValue= 0;
                float PointsChangeTextHeightSecondValue= 0;
                bool setPointsChangeTextWidthFirstValue = false;
                bool setPointsChangeTextWidthSecondValue = false;
                float PointsChangeTextWidthFirstValue= 0;
                float PointsChangeTextWidthSecondValue= 0;
                bool setPointsChangeTextXFirstValue = false;
                bool setPointsChangeTextXSecondValue = false;
                float PointsChangeTextXFirstValue= 0;
                float PointsChangeTextXSecondValue= 0;
                bool setPointsChangeTextYFirstValue = false;
                bool setPointsChangeTextYSecondValue = false;
                float PointsChangeTextYFirstValue= 0;
                float PointsChangeTextYSecondValue= 0;
                bool setPointsContainerHeightFirstValue = false;
                bool setPointsContainerHeightSecondValue = false;
                float PointsContainerHeightFirstValue= 0;
                float PointsContainerHeightSecondValue= 0;
                bool setPointsContainerWidthFirstValue = false;
                bool setPointsContainerWidthSecondValue = false;
                float PointsContainerWidthFirstValue= 0;
                float PointsContainerWidthSecondValue= 0;
                bool setPointsContainerXFirstValue = false;
                bool setPointsContainerXSecondValue = false;
                float PointsContainerXFirstValue= 0;
                float PointsContainerXSecondValue= 0;
                bool setPointsContainerYFirstValue = false;
                bool setPointsContainerYSecondValue = false;
                float PointsContainerYFirstValue= 0;
                float PointsContainerYSecondValue= 0;
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
                bool setPointsTextAlphaFirstValue = false;
                bool setPointsTextAlphaSecondValue = false;
                int PointsTextAlphaFirstValue= 0;
                int PointsTextAlphaSecondValue= 0;
                bool setPointsTextHeightFirstValue = false;
                bool setPointsTextHeightSecondValue = false;
                float PointsTextHeightFirstValue= 0;
                float PointsTextHeightSecondValue= 0;
                bool setPointsTextWidthFirstValue = false;
                bool setPointsTextWidthSecondValue = false;
                float PointsTextWidthFirstValue= 0;
                float PointsTextWidthSecondValue= 0;
                bool setPointsTextXFirstValue = false;
                bool setPointsTextXSecondValue = false;
                float PointsTextXFirstValue= 0;
                float PointsTextXSecondValue= 0;
                bool setPointsTextYFirstValue = false;
                bool setPointsTextYSecondValue = false;
                float PointsTextYFirstValue= 0;
                float PointsTextYSecondValue= 0;
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setHeightFirstValue = true;
                        HeightFirstValue = 127f;
                        setLivesContainerHeightFirstValue = true;
                        LivesContainerHeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.LivesContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setLivesContainerWidthFirstValue = true;
                        LivesContainerWidthFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.LivesContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setLivesContainerXFirstValue = true;
                        LivesContainerXFirstValue = 15f;
                        if (interpolationValue < 1)
                        {
                            SetProperty("LivesRemainingText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setLivesRemainingTextHeightFirstValue = true;
                        LivesRemainingTextHeightFirstValue = 112f;
                        if (interpolationValue < 1)
                        {
                            this.LivesRemainingText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.LivesRemainingText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "LivesContainer");
                        }
                        if (interpolationValue < 1)
                        {
                            this.LivesRemainingText.Text = "30";
                        }
                        if (interpolationValue < 1)
                        {
                            this.LivesRemainingText.UseCustomFont = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.LivesRemainingText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setLivesRemainingTextWidthFirstValue = true;
                        LivesRemainingTextWidthFirstValue = 97f;
                        setLivesRemainingTextXFirstValue = true;
                        LivesRemainingTextXFirstValue = 71f;
                        setLivesRemainingTextYFirstValue = true;
                        LivesRemainingTextYFirstValue = 7f;
                        setLivesSpriteHeightFirstValue = true;
                        LivesSpriteHeightFirstValue = 80f;
                        if (interpolationValue < 1)
                        {
                            this.LivesSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.LivesSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "LivesContainer");
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("LivesSprite.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.LivesSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setLivesSpriteTextureHeightFirstValue = true;
                        LivesSpriteTextureHeightFirstValue = 128;
                        setLivesSpriteTextureLeftFirstValue = true;
                        LivesSpriteTextureLeftFirstValue = 2443;
                        setLivesSpriteTextureTopFirstValue = true;
                        LivesSpriteTextureTopFirstValue = 779;
                        setLivesSpriteTextureWidthFirstValue = true;
                        LivesSpriteTextureWidthFirstValue = 54;
                        setLivesSpriteWidthFirstValue = true;
                        LivesSpriteWidthFirstValue = 42.5196f;
                        if (interpolationValue < 1)
                        {
                            this.LivesSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        setLivesSpriteXFirstValue = true;
                        LivesSpriteXFirstValue = 5f;
                        if (interpolationValue < 1)
                        {
                            this.LivesSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.LivesSprite.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setLivesSpriteYFirstValue = true;
                        LivesSpriteYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.LivesSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.LivesSprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setLivesXSpriteAlphaFirstValue = true;
                        LivesXSpriteAlphaFirstValue = 0;
                        setLivesXSpriteHeightFirstValue = true;
                        LivesXSpriteHeightFirstValue = 64f;
                        if (interpolationValue < 1)
                        {
                            this.LivesXSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            this.LivesXSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "LivesContainer");
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("LivesXSprite.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.LivesXSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setLivesXSpriteTextureHeightFirstValue = true;
                        LivesXSpriteTextureHeightFirstValue = 114;
                        setLivesXSpriteTextureLeftFirstValue = true;
                        LivesXSpriteTextureLeftFirstValue = 2505;
                        setLivesXSpriteTextureTopFirstValue = true;
                        LivesXSpriteTextureTopFirstValue = 792;
                        setLivesXSpriteTextureWidthFirstValue = true;
                        LivesXSpriteTextureWidthFirstValue = 114;
                        if (interpolationValue < 1)
                        {
                            this.LivesXSprite.Visible = true;
                        }
                        setLivesXSpriteWidthFirstValue = true;
                        LivesXSpriteWidthFirstValue = 64f;
                        if (interpolationValue < 1)
                        {
                            this.LivesXSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setLivesXSpriteXFirstValue = true;
                        LivesXSpriteXFirstValue = 41f;
                        if (interpolationValue < 1)
                        {
                            this.LivesXSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setLivesXSpriteYFirstValue = true;
                        LivesXSpriteYFirstValue = 61f;
                        if (interpolationValue < 1)
                        {
                            this.LivesXSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setMessageFrameInstanceHeightFirstValue = true;
                        MessageFrameInstanceHeightFirstValue = 100f;
                        setMessageFrameInstanceWidthFirstValue = true;
                        MessageFrameInstanceWidthFirstValue = 100f;
                        setMessageFrameInstanceXFirstValue = true;
                        MessageFrameInstanceXFirstValue = 0f;
                        setMessageFrameInstanceYFirstValue = true;
                        MessageFrameInstanceYFirstValue = 0f;
                        setPointsChangeTextAlphaFirstValue = true;
                        PointsChangeTextAlphaFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            SetProperty("PointsChangeText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setPointsChangeTextHeightFirstValue = true;
                        PointsChangeTextHeightFirstValue = 112f;
                        if (interpolationValue < 1)
                        {
                            this.PointsChangeText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.PointsChangeText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "PointsContainer");
                        }
                        if (interpolationValue < 1)
                        {
                            this.PointsChangeText.Text = "+1";
                        }
                        if (interpolationValue < 1)
                        {
                            this.PointsChangeText.UseCustomFont = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.PointsChangeText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setPointsChangeTextWidthFirstValue = true;
                        PointsChangeTextWidthFirstValue = 97f;
                        setPointsChangeTextXFirstValue = true;
                        PointsChangeTextXFirstValue = 71f;
                        setPointsChangeTextYFirstValue = true;
                        PointsChangeTextYFirstValue = 7f;
                        setPointsContainerHeightFirstValue = true;
                        PointsContainerHeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.PointsContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setPointsContainerWidthFirstValue = true;
                        PointsContainerWidthFirstValue = 45f;
                        if (interpolationValue < 1)
                        {
                            this.PointsContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setPointsContainerXFirstValue = true;
                        PointsContainerXFirstValue = 219f;
                        setPointsContainerYFirstValue = true;
                        PointsContainerYFirstValue = 0f;
                        setPointsSpriteHeightFirstValue = true;
                        PointsSpriteHeightFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.PointsSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.PointsSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "PointsContainer");
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
                        if (interpolationValue < 1)
                        {
                            this.PointsSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.PointsSprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setPointsTextAlphaFirstValue = true;
                        PointsTextAlphaFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            SetProperty("PointsText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setPointsTextHeightFirstValue = true;
                        PointsTextHeightFirstValue = 112f;
                        if (interpolationValue < 1)
                        {
                            this.PointsText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.PointsText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "PointsContainer");
                        }
                        if (interpolationValue < 1)
                        {
                            this.PointsText.Text = "30";
                        }
                        if (interpolationValue < 1)
                        {
                            this.PointsText.UseCustomFont = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.PointsText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setPointsTextWidthFirstValue = true;
                        PointsTextWidthFirstValue = 97f;
                        setPointsTextXFirstValue = true;
                        PointsTextXFirstValue = 71f;
                        setPointsTextYFirstValue = true;
                        PointsTextYFirstValue = 7f;
                        setWidthFirstValue = true;
                        WidthFirstValue = 408f;
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setHeightSecondValue = true;
                        HeightSecondValue = 127f;
                        setLivesContainerHeightSecondValue = true;
                        LivesContainerHeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.LivesContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setLivesContainerWidthSecondValue = true;
                        LivesContainerWidthSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.LivesContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setLivesContainerXSecondValue = true;
                        LivesContainerXSecondValue = 15f;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("LivesRemainingText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setLivesRemainingTextHeightSecondValue = true;
                        LivesRemainingTextHeightSecondValue = 112f;
                        if (interpolationValue >= 1)
                        {
                            this.LivesRemainingText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.LivesRemainingText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "LivesContainer");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.LivesRemainingText.Text = "30";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.LivesRemainingText.UseCustomFont = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.LivesRemainingText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setLivesRemainingTextWidthSecondValue = true;
                        LivesRemainingTextWidthSecondValue = 97f;
                        setLivesRemainingTextXSecondValue = true;
                        LivesRemainingTextXSecondValue = 71f;
                        setLivesRemainingTextYSecondValue = true;
                        LivesRemainingTextYSecondValue = 7f;
                        setLivesSpriteHeightSecondValue = true;
                        LivesSpriteHeightSecondValue = 80f;
                        if (interpolationValue >= 1)
                        {
                            this.LivesSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.LivesSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "LivesContainer");
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("LivesSprite.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.LivesSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setLivesSpriteTextureHeightSecondValue = true;
                        LivesSpriteTextureHeightSecondValue = 128;
                        setLivesSpriteTextureLeftSecondValue = true;
                        LivesSpriteTextureLeftSecondValue = 2443;
                        setLivesSpriteTextureTopSecondValue = true;
                        LivesSpriteTextureTopSecondValue = 779;
                        setLivesSpriteTextureWidthSecondValue = true;
                        LivesSpriteTextureWidthSecondValue = 54;
                        setLivesSpriteWidthSecondValue = true;
                        LivesSpriteWidthSecondValue = 42.5196f;
                        if (interpolationValue >= 1)
                        {
                            this.LivesSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        setLivesSpriteXSecondValue = true;
                        LivesSpriteXSecondValue = 5f;
                        if (interpolationValue >= 1)
                        {
                            this.LivesSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.LivesSprite.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setLivesSpriteYSecondValue = true;
                        LivesSpriteYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.LivesSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.LivesSprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setLivesXSpriteAlphaSecondValue = true;
                        LivesXSpriteAlphaSecondValue = 0;
                        setLivesXSpriteHeightSecondValue = true;
                        LivesXSpriteHeightSecondValue = 64f;
                        if (interpolationValue >= 1)
                        {
                            this.LivesXSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.LivesXSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "LivesContainer");
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("LivesXSprite.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.LivesXSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setLivesXSpriteTextureHeightSecondValue = true;
                        LivesXSpriteTextureHeightSecondValue = 114;
                        setLivesXSpriteTextureLeftSecondValue = true;
                        LivesXSpriteTextureLeftSecondValue = 2505;
                        setLivesXSpriteTextureTopSecondValue = true;
                        LivesXSpriteTextureTopSecondValue = 792;
                        setLivesXSpriteTextureWidthSecondValue = true;
                        LivesXSpriteTextureWidthSecondValue = 114;
                        if (interpolationValue >= 1)
                        {
                            this.LivesXSprite.Visible = true;
                        }
                        setLivesXSpriteWidthSecondValue = true;
                        LivesXSpriteWidthSecondValue = 64f;
                        if (interpolationValue >= 1)
                        {
                            this.LivesXSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setLivesXSpriteXSecondValue = true;
                        LivesXSpriteXSecondValue = 41f;
                        if (interpolationValue >= 1)
                        {
                            this.LivesXSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setLivesXSpriteYSecondValue = true;
                        LivesXSpriteYSecondValue = 61f;
                        if (interpolationValue >= 1)
                        {
                            this.LivesXSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setMessageFrameInstanceHeightSecondValue = true;
                        MessageFrameInstanceHeightSecondValue = 100f;
                        setMessageFrameInstanceWidthSecondValue = true;
                        MessageFrameInstanceWidthSecondValue = 100f;
                        setMessageFrameInstanceXSecondValue = true;
                        MessageFrameInstanceXSecondValue = 0f;
                        setMessageFrameInstanceYSecondValue = true;
                        MessageFrameInstanceYSecondValue = 0f;
                        setPointsChangeTextAlphaSecondValue = true;
                        PointsChangeTextAlphaSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("PointsChangeText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setPointsChangeTextHeightSecondValue = true;
                        PointsChangeTextHeightSecondValue = 112f;
                        if (interpolationValue >= 1)
                        {
                            this.PointsChangeText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PointsChangeText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "PointsContainer");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PointsChangeText.Text = "+1";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PointsChangeText.UseCustomFont = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PointsChangeText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setPointsChangeTextWidthSecondValue = true;
                        PointsChangeTextWidthSecondValue = 97f;
                        setPointsChangeTextXSecondValue = true;
                        PointsChangeTextXSecondValue = 71f;
                        setPointsChangeTextYSecondValue = true;
                        PointsChangeTextYSecondValue = 7f;
                        setPointsContainerHeightSecondValue = true;
                        PointsContainerHeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.PointsContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setPointsContainerWidthSecondValue = true;
                        PointsContainerWidthSecondValue = 45f;
                        if (interpolationValue >= 1)
                        {
                            this.PointsContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setPointsContainerXSecondValue = true;
                        PointsContainerXSecondValue = 219f;
                        setPointsContainerYSecondValue = true;
                        PointsContainerYSecondValue = 0f;
                        setPointsSpriteHeightSecondValue = true;
                        PointsSpriteHeightSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.PointsSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PointsSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "PointsContainer");
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
                        if (interpolationValue >= 1)
                        {
                            this.PointsSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PointsSprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setPointsTextAlphaSecondValue = true;
                        PointsTextAlphaSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("PointsText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setPointsTextHeightSecondValue = true;
                        PointsTextHeightSecondValue = 112f;
                        if (interpolationValue >= 1)
                        {
                            this.PointsText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PointsText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "PointsContainer");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PointsText.Text = "30";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PointsText.UseCustomFont = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PointsText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setPointsTextWidthSecondValue = true;
                        PointsTextWidthSecondValue = 97f;
                        setPointsTextXSecondValue = true;
                        PointsTextXSecondValue = 71f;
                        setPointsTextYSecondValue = true;
                        PointsTextYSecondValue = 7f;
                        setWidthSecondValue = true;
                        WidthSecondValue = 408f;
                        break;
                }
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
                }
                if (setLivesContainerHeightFirstValue && setLivesContainerHeightSecondValue)
                {
                    LivesContainer.Height = LivesContainerHeightFirstValue * (1 - interpolationValue) + LivesContainerHeightSecondValue * interpolationValue;
                }
                if (setLivesContainerWidthFirstValue && setLivesContainerWidthSecondValue)
                {
                    LivesContainer.Width = LivesContainerWidthFirstValue * (1 - interpolationValue) + LivesContainerWidthSecondValue * interpolationValue;
                }
                if (setLivesContainerXFirstValue && setLivesContainerXSecondValue)
                {
                    LivesContainer.X = LivesContainerXFirstValue * (1 - interpolationValue) + LivesContainerXSecondValue * interpolationValue;
                }
                if (setLivesRemainingTextHeightFirstValue && setLivesRemainingTextHeightSecondValue)
                {
                    LivesRemainingText.Height = LivesRemainingTextHeightFirstValue * (1 - interpolationValue) + LivesRemainingTextHeightSecondValue * interpolationValue;
                }
                if (setLivesRemainingTextWidthFirstValue && setLivesRemainingTextWidthSecondValue)
                {
                    LivesRemainingText.Width = LivesRemainingTextWidthFirstValue * (1 - interpolationValue) + LivesRemainingTextWidthSecondValue * interpolationValue;
                }
                if (setLivesRemainingTextXFirstValue && setLivesRemainingTextXSecondValue)
                {
                    LivesRemainingText.X = LivesRemainingTextXFirstValue * (1 - interpolationValue) + LivesRemainingTextXSecondValue * interpolationValue;
                }
                if (setLivesRemainingTextYFirstValue && setLivesRemainingTextYSecondValue)
                {
                    LivesRemainingText.Y = LivesRemainingTextYFirstValue * (1 - interpolationValue) + LivesRemainingTextYSecondValue * interpolationValue;
                }
                if (setLivesSpriteHeightFirstValue && setLivesSpriteHeightSecondValue)
                {
                    LivesSprite.Height = LivesSpriteHeightFirstValue * (1 - interpolationValue) + LivesSpriteHeightSecondValue * interpolationValue;
                }
                if (setLivesSpriteTextureHeightFirstValue && setLivesSpriteTextureHeightSecondValue)
                {
                    LivesSprite.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(LivesSpriteTextureHeightFirstValue* (1 - interpolationValue) + LivesSpriteTextureHeightSecondValue * interpolationValue);
                }
                if (setLivesSpriteTextureLeftFirstValue && setLivesSpriteTextureLeftSecondValue)
                {
                    LivesSprite.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(LivesSpriteTextureLeftFirstValue* (1 - interpolationValue) + LivesSpriteTextureLeftSecondValue * interpolationValue);
                }
                if (setLivesSpriteTextureTopFirstValue && setLivesSpriteTextureTopSecondValue)
                {
                    LivesSprite.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(LivesSpriteTextureTopFirstValue* (1 - interpolationValue) + LivesSpriteTextureTopSecondValue * interpolationValue);
                }
                if (setLivesSpriteTextureWidthFirstValue && setLivesSpriteTextureWidthSecondValue)
                {
                    LivesSprite.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(LivesSpriteTextureWidthFirstValue* (1 - interpolationValue) + LivesSpriteTextureWidthSecondValue * interpolationValue);
                }
                if (setLivesSpriteWidthFirstValue && setLivesSpriteWidthSecondValue)
                {
                    LivesSprite.Width = LivesSpriteWidthFirstValue * (1 - interpolationValue) + LivesSpriteWidthSecondValue * interpolationValue;
                }
                if (setLivesSpriteXFirstValue && setLivesSpriteXSecondValue)
                {
                    LivesSprite.X = LivesSpriteXFirstValue * (1 - interpolationValue) + LivesSpriteXSecondValue * interpolationValue;
                }
                if (setLivesSpriteYFirstValue && setLivesSpriteYSecondValue)
                {
                    LivesSprite.Y = LivesSpriteYFirstValue * (1 - interpolationValue) + LivesSpriteYSecondValue * interpolationValue;
                }
                if (setLivesXSpriteAlphaFirstValue && setLivesXSpriteAlphaSecondValue)
                {
                    LivesXSprite.Alpha = FlatRedBall.Math.MathFunctions.RoundToInt(LivesXSpriteAlphaFirstValue* (1 - interpolationValue) + LivesXSpriteAlphaSecondValue * interpolationValue);
                }
                if (setLivesXSpriteHeightFirstValue && setLivesXSpriteHeightSecondValue)
                {
                    LivesXSprite.Height = LivesXSpriteHeightFirstValue * (1 - interpolationValue) + LivesXSpriteHeightSecondValue * interpolationValue;
                }
                if (setLivesXSpriteTextureHeightFirstValue && setLivesXSpriteTextureHeightSecondValue)
                {
                    LivesXSprite.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(LivesXSpriteTextureHeightFirstValue* (1 - interpolationValue) + LivesXSpriteTextureHeightSecondValue * interpolationValue);
                }
                if (setLivesXSpriteTextureLeftFirstValue && setLivesXSpriteTextureLeftSecondValue)
                {
                    LivesXSprite.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(LivesXSpriteTextureLeftFirstValue* (1 - interpolationValue) + LivesXSpriteTextureLeftSecondValue * interpolationValue);
                }
                if (setLivesXSpriteTextureTopFirstValue && setLivesXSpriteTextureTopSecondValue)
                {
                    LivesXSprite.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(LivesXSpriteTextureTopFirstValue* (1 - interpolationValue) + LivesXSpriteTextureTopSecondValue * interpolationValue);
                }
                if (setLivesXSpriteTextureWidthFirstValue && setLivesXSpriteTextureWidthSecondValue)
                {
                    LivesXSprite.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(LivesXSpriteTextureWidthFirstValue* (1 - interpolationValue) + LivesXSpriteTextureWidthSecondValue * interpolationValue);
                }
                if (setLivesXSpriteWidthFirstValue && setLivesXSpriteWidthSecondValue)
                {
                    LivesXSprite.Width = LivesXSpriteWidthFirstValue * (1 - interpolationValue) + LivesXSpriteWidthSecondValue * interpolationValue;
                }
                if (setLivesXSpriteXFirstValue && setLivesXSpriteXSecondValue)
                {
                    LivesXSprite.X = LivesXSpriteXFirstValue * (1 - interpolationValue) + LivesXSpriteXSecondValue * interpolationValue;
                }
                if (setLivesXSpriteYFirstValue && setLivesXSpriteYSecondValue)
                {
                    LivesXSprite.Y = LivesXSpriteYFirstValue * (1 - interpolationValue) + LivesXSpriteYSecondValue * interpolationValue;
                }
                if (setMessageFrameInstanceHeightFirstValue && setMessageFrameInstanceHeightSecondValue)
                {
                    MessageFrameInstance.Height = MessageFrameInstanceHeightFirstValue * (1 - interpolationValue) + MessageFrameInstanceHeightSecondValue * interpolationValue;
                }
                if (setMessageFrameInstanceWidthFirstValue && setMessageFrameInstanceWidthSecondValue)
                {
                    MessageFrameInstance.Width = MessageFrameInstanceWidthFirstValue * (1 - interpolationValue) + MessageFrameInstanceWidthSecondValue * interpolationValue;
                }
                if (setMessageFrameInstanceXFirstValue && setMessageFrameInstanceXSecondValue)
                {
                    MessageFrameInstance.X = MessageFrameInstanceXFirstValue * (1 - interpolationValue) + MessageFrameInstanceXSecondValue * interpolationValue;
                }
                if (setMessageFrameInstanceYFirstValue && setMessageFrameInstanceYSecondValue)
                {
                    MessageFrameInstance.Y = MessageFrameInstanceYFirstValue * (1 - interpolationValue) + MessageFrameInstanceYSecondValue * interpolationValue;
                }
                if (setPointsChangeTextAlphaFirstValue && setPointsChangeTextAlphaSecondValue)
                {
                    PointsChangeText.Alpha = FlatRedBall.Math.MathFunctions.RoundToInt(PointsChangeTextAlphaFirstValue* (1 - interpolationValue) + PointsChangeTextAlphaSecondValue * interpolationValue);
                }
                if (setPointsChangeTextHeightFirstValue && setPointsChangeTextHeightSecondValue)
                {
                    PointsChangeText.Height = PointsChangeTextHeightFirstValue * (1 - interpolationValue) + PointsChangeTextHeightSecondValue * interpolationValue;
                }
                if (setPointsChangeTextWidthFirstValue && setPointsChangeTextWidthSecondValue)
                {
                    PointsChangeText.Width = PointsChangeTextWidthFirstValue * (1 - interpolationValue) + PointsChangeTextWidthSecondValue * interpolationValue;
                }
                if (setPointsChangeTextXFirstValue && setPointsChangeTextXSecondValue)
                {
                    PointsChangeText.X = PointsChangeTextXFirstValue * (1 - interpolationValue) + PointsChangeTextXSecondValue * interpolationValue;
                }
                if (setPointsChangeTextYFirstValue && setPointsChangeTextYSecondValue)
                {
                    PointsChangeText.Y = PointsChangeTextYFirstValue * (1 - interpolationValue) + PointsChangeTextYSecondValue * interpolationValue;
                }
                if (setPointsContainerHeightFirstValue && setPointsContainerHeightSecondValue)
                {
                    PointsContainer.Height = PointsContainerHeightFirstValue * (1 - interpolationValue) + PointsContainerHeightSecondValue * interpolationValue;
                }
                if (setPointsContainerWidthFirstValue && setPointsContainerWidthSecondValue)
                {
                    PointsContainer.Width = PointsContainerWidthFirstValue * (1 - interpolationValue) + PointsContainerWidthSecondValue * interpolationValue;
                }
                if (setPointsContainerXFirstValue && setPointsContainerXSecondValue)
                {
                    PointsContainer.X = PointsContainerXFirstValue * (1 - interpolationValue) + PointsContainerXSecondValue * interpolationValue;
                }
                if (setPointsContainerYFirstValue && setPointsContainerYSecondValue)
                {
                    PointsContainer.Y = PointsContainerYFirstValue * (1 - interpolationValue) + PointsContainerYSecondValue * interpolationValue;
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
                if (setPointsTextAlphaFirstValue && setPointsTextAlphaSecondValue)
                {
                    PointsText.Alpha = FlatRedBall.Math.MathFunctions.RoundToInt(PointsTextAlphaFirstValue* (1 - interpolationValue) + PointsTextAlphaSecondValue * interpolationValue);
                }
                if (setPointsTextHeightFirstValue && setPointsTextHeightSecondValue)
                {
                    PointsText.Height = PointsTextHeightFirstValue * (1 - interpolationValue) + PointsTextHeightSecondValue * interpolationValue;
                }
                if (setPointsTextWidthFirstValue && setPointsTextWidthSecondValue)
                {
                    PointsText.Width = PointsTextWidthFirstValue * (1 - interpolationValue) + PointsTextWidthSecondValue * interpolationValue;
                }
                if (setPointsTextXFirstValue && setPointsTextXSecondValue)
                {
                    PointsText.X = PointsTextXFirstValue * (1 - interpolationValue) + PointsTextXSecondValue * interpolationValue;
                }
                if (setPointsTextYFirstValue && setPointsTextYSecondValue)
                {
                    PointsText.Y = PointsTextYFirstValue * (1 - interpolationValue) + PointsTextYSecondValue * interpolationValue;
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
            public void InterpolateBetween (LivesChange firstState, LivesChange secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setLivesSpriteBlueFirstValue = false;
                bool setLivesSpriteBlueSecondValue = false;
                int LivesSpriteBlueFirstValue= 0;
                int LivesSpriteBlueSecondValue= 0;
                bool setLivesSpriteGreenFirstValue = false;
                bool setLivesSpriteGreenSecondValue = false;
                int LivesSpriteGreenFirstValue= 0;
                int LivesSpriteGreenSecondValue= 0;
                bool setLivesXSpriteAlphaFirstValue = false;
                bool setLivesXSpriteAlphaSecondValue = false;
                int LivesXSpriteAlphaFirstValue= 0;
                int LivesXSpriteAlphaSecondValue= 0;
                bool setLivesXSpriteHeightFirstValue = false;
                bool setLivesXSpriteHeightSecondValue = false;
                float LivesXSpriteHeightFirstValue= 0;
                float LivesXSpriteHeightSecondValue= 0;
                bool setLivesXSpriteWidthFirstValue = false;
                bool setLivesXSpriteWidthSecondValue = false;
                float LivesXSpriteWidthFirstValue= 0;
                float LivesXSpriteWidthSecondValue= 0;
                switch(firstState)
                {
                    case  LivesChange.StartReduce:
                        setLivesSpriteBlueFirstValue = true;
                        LivesSpriteBlueFirstValue = 255;
                        setLivesSpriteGreenFirstValue = true;
                        LivesSpriteGreenFirstValue = 255;
                        setLivesXSpriteAlphaFirstValue = true;
                        LivesXSpriteAlphaFirstValue = 0;
                        setLivesXSpriteHeightFirstValue = true;
                        LivesXSpriteHeightFirstValue = 64f;
                        setLivesXSpriteWidthFirstValue = true;
                        LivesXSpriteWidthFirstValue = 64f;
                        break;
                    case  LivesChange.Mid1Reduce:
                        setLivesSpriteBlueFirstValue = true;
                        LivesSpriteBlueFirstValue = 100;
                        setLivesSpriteGreenFirstValue = true;
                        LivesSpriteGreenFirstValue = 100;
                        setLivesXSpriteAlphaFirstValue = true;
                        LivesXSpriteAlphaFirstValue = 100;
                        setLivesXSpriteHeightFirstValue = true;
                        LivesXSpriteHeightFirstValue = 64f;
                        setLivesXSpriteWidthFirstValue = true;
                        LivesXSpriteWidthFirstValue = 64f;
                        break;
                    case  LivesChange.Mid2Reduce:
                        setLivesSpriteBlueFirstValue = true;
                        LivesSpriteBlueFirstValue = 0;
                        setLivesSpriteGreenFirstValue = true;
                        LivesSpriteGreenFirstValue = 0;
                        setLivesXSpriteAlphaFirstValue = true;
                        LivesXSpriteAlphaFirstValue = 255;
                        setLivesXSpriteHeightFirstValue = true;
                        LivesXSpriteHeightFirstValue = 80f;
                        setLivesXSpriteWidthFirstValue = true;
                        LivesXSpriteWidthFirstValue = 80f;
                        break;
                    case  LivesChange.Mid3Reduce:
                        setLivesSpriteBlueFirstValue = true;
                        LivesSpriteBlueFirstValue = 150;
                        setLivesSpriteGreenFirstValue = true;
                        LivesSpriteGreenFirstValue = 150;
                        setLivesXSpriteAlphaFirstValue = true;
                        LivesXSpriteAlphaFirstValue = 100;
                        setLivesXSpriteHeightFirstValue = true;
                        LivesXSpriteHeightFirstValue = 64f;
                        setLivesXSpriteWidthFirstValue = true;
                        LivesXSpriteWidthFirstValue = 64f;
                        break;
                    case  LivesChange.EndReduce:
                        setLivesSpriteBlueFirstValue = true;
                        LivesSpriteBlueFirstValue = 255;
                        setLivesSpriteGreenFirstValue = true;
                        LivesSpriteGreenFirstValue = 255;
                        setLivesXSpriteAlphaFirstValue = true;
                        LivesXSpriteAlphaFirstValue = 0;
                        setLivesXSpriteHeightFirstValue = true;
                        LivesXSpriteHeightFirstValue = 64f;
                        setLivesXSpriteWidthFirstValue = true;
                        LivesXSpriteWidthFirstValue = 64f;
                        break;
                }
                switch(secondState)
                {
                    case  LivesChange.StartReduce:
                        setLivesSpriteBlueSecondValue = true;
                        LivesSpriteBlueSecondValue = 255;
                        setLivesSpriteGreenSecondValue = true;
                        LivesSpriteGreenSecondValue = 255;
                        setLivesXSpriteAlphaSecondValue = true;
                        LivesXSpriteAlphaSecondValue = 0;
                        setLivesXSpriteHeightSecondValue = true;
                        LivesXSpriteHeightSecondValue = 64f;
                        setLivesXSpriteWidthSecondValue = true;
                        LivesXSpriteWidthSecondValue = 64f;
                        break;
                    case  LivesChange.Mid1Reduce:
                        setLivesSpriteBlueSecondValue = true;
                        LivesSpriteBlueSecondValue = 100;
                        setLivesSpriteGreenSecondValue = true;
                        LivesSpriteGreenSecondValue = 100;
                        setLivesXSpriteAlphaSecondValue = true;
                        LivesXSpriteAlphaSecondValue = 100;
                        setLivesXSpriteHeightSecondValue = true;
                        LivesXSpriteHeightSecondValue = 64f;
                        setLivesXSpriteWidthSecondValue = true;
                        LivesXSpriteWidthSecondValue = 64f;
                        break;
                    case  LivesChange.Mid2Reduce:
                        setLivesSpriteBlueSecondValue = true;
                        LivesSpriteBlueSecondValue = 0;
                        setLivesSpriteGreenSecondValue = true;
                        LivesSpriteGreenSecondValue = 0;
                        setLivesXSpriteAlphaSecondValue = true;
                        LivesXSpriteAlphaSecondValue = 255;
                        setLivesXSpriteHeightSecondValue = true;
                        LivesXSpriteHeightSecondValue = 80f;
                        setLivesXSpriteWidthSecondValue = true;
                        LivesXSpriteWidthSecondValue = 80f;
                        break;
                    case  LivesChange.Mid3Reduce:
                        setLivesSpriteBlueSecondValue = true;
                        LivesSpriteBlueSecondValue = 150;
                        setLivesSpriteGreenSecondValue = true;
                        LivesSpriteGreenSecondValue = 150;
                        setLivesXSpriteAlphaSecondValue = true;
                        LivesXSpriteAlphaSecondValue = 100;
                        setLivesXSpriteHeightSecondValue = true;
                        LivesXSpriteHeightSecondValue = 64f;
                        setLivesXSpriteWidthSecondValue = true;
                        LivesXSpriteWidthSecondValue = 64f;
                        break;
                    case  LivesChange.EndReduce:
                        setLivesSpriteBlueSecondValue = true;
                        LivesSpriteBlueSecondValue = 255;
                        setLivesSpriteGreenSecondValue = true;
                        LivesSpriteGreenSecondValue = 255;
                        setLivesXSpriteAlphaSecondValue = true;
                        LivesXSpriteAlphaSecondValue = 0;
                        setLivesXSpriteHeightSecondValue = true;
                        LivesXSpriteHeightSecondValue = 64f;
                        setLivesXSpriteWidthSecondValue = true;
                        LivesXSpriteWidthSecondValue = 64f;
                        break;
                }
                if (setLivesSpriteBlueFirstValue && setLivesSpriteBlueSecondValue)
                {
                    LivesSprite.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(LivesSpriteBlueFirstValue* (1 - interpolationValue) + LivesSpriteBlueSecondValue * interpolationValue);
                }
                if (setLivesSpriteGreenFirstValue && setLivesSpriteGreenSecondValue)
                {
                    LivesSprite.Green = FlatRedBall.Math.MathFunctions.RoundToInt(LivesSpriteGreenFirstValue* (1 - interpolationValue) + LivesSpriteGreenSecondValue * interpolationValue);
                }
                if (setLivesXSpriteAlphaFirstValue && setLivesXSpriteAlphaSecondValue)
                {
                    LivesXSprite.Alpha = FlatRedBall.Math.MathFunctions.RoundToInt(LivesXSpriteAlphaFirstValue* (1 - interpolationValue) + LivesXSpriteAlphaSecondValue * interpolationValue);
                }
                if (setLivesXSpriteHeightFirstValue && setLivesXSpriteHeightSecondValue)
                {
                    LivesXSprite.Height = LivesXSpriteHeightFirstValue * (1 - interpolationValue) + LivesXSpriteHeightSecondValue * interpolationValue;
                }
                if (setLivesXSpriteWidthFirstValue && setLivesXSpriteWidthSecondValue)
                {
                    LivesXSprite.Width = LivesXSpriteWidthFirstValue * (1 - interpolationValue) + LivesXSpriteWidthSecondValue * interpolationValue;
                }
                if (interpolationValue < 1)
                {
                    mCurrentLivesChangeState = firstState;
                }
                else
                {
                    mCurrentLivesChangeState = secondState;
                }
            }
            public void InterpolateBetween (PointsChange firstState, PointsChange secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setPointsChangeTextAlphaFirstValue = false;
                bool setPointsChangeTextAlphaSecondValue = false;
                int PointsChangeTextAlphaFirstValue= 0;
                int PointsChangeTextAlphaSecondValue= 0;
                bool setPointsChangeTextBlueFirstValue = false;
                bool setPointsChangeTextBlueSecondValue = false;
                int PointsChangeTextBlueFirstValue= 0;
                int PointsChangeTextBlueSecondValue= 0;
                bool setPointsChangeTextGreenFirstValue = false;
                bool setPointsChangeTextGreenSecondValue = false;
                int PointsChangeTextGreenFirstValue= 0;
                int PointsChangeTextGreenSecondValue= 0;
                bool setPointsChangeTextRedFirstValue = false;
                bool setPointsChangeTextRedSecondValue = false;
                int PointsChangeTextRedFirstValue= 0;
                int PointsChangeTextRedSecondValue= 0;
                bool setPointsChangeTextYFirstValue = false;
                bool setPointsChangeTextYSecondValue = false;
                float PointsChangeTextYFirstValue= 0;
                float PointsChangeTextYSecondValue= 0;
                bool setPointsTextBlueFirstValue = false;
                bool setPointsTextBlueSecondValue = false;
                int PointsTextBlueFirstValue= 0;
                int PointsTextBlueSecondValue= 0;
                bool setPointsTextGreenFirstValue = false;
                bool setPointsTextGreenSecondValue = false;
                int PointsTextGreenFirstValue= 0;
                int PointsTextGreenSecondValue= 0;
                bool setPointsTextRedFirstValue = false;
                bool setPointsTextRedSecondValue = false;
                int PointsTextRedFirstValue= 0;
                int PointsTextRedSecondValue= 0;
                switch(firstState)
                {
                    case  PointsChange.PointsIncreaseStart:
                        setPointsChangeTextAlphaFirstValue = true;
                        PointsChangeTextAlphaFirstValue = 255;
                        setPointsChangeTextBlueFirstValue = true;
                        PointsChangeTextBlueFirstValue = 0;
                        setPointsChangeTextGreenFirstValue = true;
                        PointsChangeTextGreenFirstValue = 255;
                        setPointsChangeTextRedFirstValue = true;
                        PointsChangeTextRedFirstValue = 0;
                        setPointsChangeTextYFirstValue = true;
                        PointsChangeTextYFirstValue = 7f;
                        setPointsTextBlueFirstValue = true;
                        PointsTextBlueFirstValue = 100;
                        setPointsTextGreenFirstValue = true;
                        PointsTextGreenFirstValue = 255;
                        setPointsTextRedFirstValue = true;
                        PointsTextRedFirstValue = 100;
                        break;
                    case  PointsChange.PointsIncreaseEnd:
                        setPointsChangeTextAlphaFirstValue = true;
                        PointsChangeTextAlphaFirstValue = 0;
                        setPointsChangeTextBlueFirstValue = true;
                        PointsChangeTextBlueFirstValue = 0;
                        setPointsChangeTextGreenFirstValue = true;
                        PointsChangeTextGreenFirstValue = 255;
                        setPointsChangeTextRedFirstValue = true;
                        PointsChangeTextRedFirstValue = 0;
                        setPointsChangeTextYFirstValue = true;
                        PointsChangeTextYFirstValue = -100f;
                        setPointsTextBlueFirstValue = true;
                        PointsTextBlueFirstValue = 255;
                        setPointsTextGreenFirstValue = true;
                        PointsTextGreenFirstValue = 255;
                        setPointsTextRedFirstValue = true;
                        PointsTextRedFirstValue = 255;
                        break;
                    case  PointsChange.PointsDecreaseStart:
                        setPointsChangeTextAlphaFirstValue = true;
                        PointsChangeTextAlphaFirstValue = 255;
                        setPointsChangeTextBlueFirstValue = true;
                        PointsChangeTextBlueFirstValue = 0;
                        setPointsChangeTextGreenFirstValue = true;
                        PointsChangeTextGreenFirstValue = 0;
                        setPointsChangeTextRedFirstValue = true;
                        PointsChangeTextRedFirstValue = 255;
                        setPointsChangeTextYFirstValue = true;
                        PointsChangeTextYFirstValue = 7f;
                        setPointsTextBlueFirstValue = true;
                        PointsTextBlueFirstValue = 100;
                        setPointsTextGreenFirstValue = true;
                        PointsTextGreenFirstValue = 100;
                        setPointsTextRedFirstValue = true;
                        PointsTextRedFirstValue = 255;
                        break;
                    case  PointsChange.PointsDecreaseEnd:
                        setPointsChangeTextAlphaFirstValue = true;
                        PointsChangeTextAlphaFirstValue = 0;
                        setPointsChangeTextBlueFirstValue = true;
                        PointsChangeTextBlueFirstValue = 255;
                        setPointsChangeTextGreenFirstValue = true;
                        PointsChangeTextGreenFirstValue = 255;
                        setPointsChangeTextRedFirstValue = true;
                        PointsChangeTextRedFirstValue = 255;
                        setPointsChangeTextYFirstValue = true;
                        PointsChangeTextYFirstValue = 100f;
                        setPointsTextBlueFirstValue = true;
                        PointsTextBlueFirstValue = 255;
                        setPointsTextGreenFirstValue = true;
                        PointsTextGreenFirstValue = 255;
                        setPointsTextRedFirstValue = true;
                        PointsTextRedFirstValue = 255;
                        break;
                }
                switch(secondState)
                {
                    case  PointsChange.PointsIncreaseStart:
                        setPointsChangeTextAlphaSecondValue = true;
                        PointsChangeTextAlphaSecondValue = 255;
                        setPointsChangeTextBlueSecondValue = true;
                        PointsChangeTextBlueSecondValue = 0;
                        setPointsChangeTextGreenSecondValue = true;
                        PointsChangeTextGreenSecondValue = 255;
                        setPointsChangeTextRedSecondValue = true;
                        PointsChangeTextRedSecondValue = 0;
                        setPointsChangeTextYSecondValue = true;
                        PointsChangeTextYSecondValue = 7f;
                        setPointsTextBlueSecondValue = true;
                        PointsTextBlueSecondValue = 100;
                        setPointsTextGreenSecondValue = true;
                        PointsTextGreenSecondValue = 255;
                        setPointsTextRedSecondValue = true;
                        PointsTextRedSecondValue = 100;
                        break;
                    case  PointsChange.PointsIncreaseEnd:
                        setPointsChangeTextAlphaSecondValue = true;
                        PointsChangeTextAlphaSecondValue = 0;
                        setPointsChangeTextBlueSecondValue = true;
                        PointsChangeTextBlueSecondValue = 0;
                        setPointsChangeTextGreenSecondValue = true;
                        PointsChangeTextGreenSecondValue = 255;
                        setPointsChangeTextRedSecondValue = true;
                        PointsChangeTextRedSecondValue = 0;
                        setPointsChangeTextYSecondValue = true;
                        PointsChangeTextYSecondValue = -100f;
                        setPointsTextBlueSecondValue = true;
                        PointsTextBlueSecondValue = 255;
                        setPointsTextGreenSecondValue = true;
                        PointsTextGreenSecondValue = 255;
                        setPointsTextRedSecondValue = true;
                        PointsTextRedSecondValue = 255;
                        break;
                    case  PointsChange.PointsDecreaseStart:
                        setPointsChangeTextAlphaSecondValue = true;
                        PointsChangeTextAlphaSecondValue = 255;
                        setPointsChangeTextBlueSecondValue = true;
                        PointsChangeTextBlueSecondValue = 0;
                        setPointsChangeTextGreenSecondValue = true;
                        PointsChangeTextGreenSecondValue = 0;
                        setPointsChangeTextRedSecondValue = true;
                        PointsChangeTextRedSecondValue = 255;
                        setPointsChangeTextYSecondValue = true;
                        PointsChangeTextYSecondValue = 7f;
                        setPointsTextBlueSecondValue = true;
                        PointsTextBlueSecondValue = 100;
                        setPointsTextGreenSecondValue = true;
                        PointsTextGreenSecondValue = 100;
                        setPointsTextRedSecondValue = true;
                        PointsTextRedSecondValue = 255;
                        break;
                    case  PointsChange.PointsDecreaseEnd:
                        setPointsChangeTextAlphaSecondValue = true;
                        PointsChangeTextAlphaSecondValue = 0;
                        setPointsChangeTextBlueSecondValue = true;
                        PointsChangeTextBlueSecondValue = 255;
                        setPointsChangeTextGreenSecondValue = true;
                        PointsChangeTextGreenSecondValue = 255;
                        setPointsChangeTextRedSecondValue = true;
                        PointsChangeTextRedSecondValue = 255;
                        setPointsChangeTextYSecondValue = true;
                        PointsChangeTextYSecondValue = 100f;
                        setPointsTextBlueSecondValue = true;
                        PointsTextBlueSecondValue = 255;
                        setPointsTextGreenSecondValue = true;
                        PointsTextGreenSecondValue = 255;
                        setPointsTextRedSecondValue = true;
                        PointsTextRedSecondValue = 255;
                        break;
                }
                if (setPointsChangeTextAlphaFirstValue && setPointsChangeTextAlphaSecondValue)
                {
                    PointsChangeText.Alpha = FlatRedBall.Math.MathFunctions.RoundToInt(PointsChangeTextAlphaFirstValue* (1 - interpolationValue) + PointsChangeTextAlphaSecondValue * interpolationValue);
                }
                if (setPointsChangeTextBlueFirstValue && setPointsChangeTextBlueSecondValue)
                {
                    PointsChangeText.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(PointsChangeTextBlueFirstValue* (1 - interpolationValue) + PointsChangeTextBlueSecondValue * interpolationValue);
                }
                if (setPointsChangeTextGreenFirstValue && setPointsChangeTextGreenSecondValue)
                {
                    PointsChangeText.Green = FlatRedBall.Math.MathFunctions.RoundToInt(PointsChangeTextGreenFirstValue* (1 - interpolationValue) + PointsChangeTextGreenSecondValue * interpolationValue);
                }
                if (setPointsChangeTextRedFirstValue && setPointsChangeTextRedSecondValue)
                {
                    PointsChangeText.Red = FlatRedBall.Math.MathFunctions.RoundToInt(PointsChangeTextRedFirstValue* (1 - interpolationValue) + PointsChangeTextRedSecondValue * interpolationValue);
                }
                if (setPointsChangeTextYFirstValue && setPointsChangeTextYSecondValue)
                {
                    PointsChangeText.Y = PointsChangeTextYFirstValue * (1 - interpolationValue) + PointsChangeTextYSecondValue * interpolationValue;
                }
                if (setPointsTextBlueFirstValue && setPointsTextBlueSecondValue)
                {
                    PointsText.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(PointsTextBlueFirstValue* (1 - interpolationValue) + PointsTextBlueSecondValue * interpolationValue);
                }
                if (setPointsTextGreenFirstValue && setPointsTextGreenSecondValue)
                {
                    PointsText.Green = FlatRedBall.Math.MathFunctions.RoundToInt(PointsTextGreenFirstValue* (1 - interpolationValue) + PointsTextGreenSecondValue * interpolationValue);
                }
                if (setPointsTextRedFirstValue && setPointsTextRedSecondValue)
                {
                    PointsText.Red = FlatRedBall.Math.MathFunctions.RoundToInt(PointsTextRedFirstValue* (1 - interpolationValue) + PointsTextRedSecondValue * interpolationValue);
                }
                if (interpolationValue < 1)
                {
                    mCurrentPointsChangeState = firstState;
                }
                else
                {
                    mCurrentPointsChangeState = secondState;
                }
            }
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.LivesPointsDisplayRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.LivesPointsDisplayRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.LivesPointsDisplayRuntime.LivesChange fromState,AbbatoirIntergrade.GumRuntimes.LivesPointsDisplayRuntime.LivesChange toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (LivesChange toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "LivesChange").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentLivesChangeState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (LivesChange toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentLivesChangeState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.LivesPointsDisplayRuntime.PointsChange fromState,AbbatoirIntergrade.GumRuntimes.LivesPointsDisplayRuntime.PointsChange toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (PointsChange toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "PointsChange").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentPointsChangeState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (PointsChange toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentPointsChangeState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            #endregion
            #region State Animations
            private System.Collections.Generic.IEnumerable<FlatRedBall.Instructions.Instruction> LivesReducedAnimationInstructions (object target) 
            {
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction( ()=> this.CurrentLivesChangeState = LivesChange.StartReduce);
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime;
                    toReturn.Target = target;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(LivesChange.Mid1Reduce, 0.25f, FlatRedBall.Glue.StateInterpolation.InterpolationType.Linear, FlatRedBall.Glue.StateInterpolation.Easing.Out, LivesReducedAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(LivesChange.Mid2Reduce, 0.25f, FlatRedBall.Glue.StateInterpolation.InterpolationType.Quadratic, FlatRedBall.Glue.StateInterpolation.Easing.In, LivesReducedAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0.25f;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(LivesChange.Mid3Reduce, 0.25f, FlatRedBall.Glue.StateInterpolation.InterpolationType.Bounce, FlatRedBall.Glue.StateInterpolation.Easing.InOut, LivesReducedAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0.5f;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(LivesChange.EndReduce, 0.25f, FlatRedBall.Glue.StateInterpolation.InterpolationType.Quadratic, FlatRedBall.Glue.StateInterpolation.Easing.Out, LivesReducedAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0.75f;
                    yield return toReturn;
                }
            }
            private System.Collections.Generic.IEnumerable<FlatRedBall.Instructions.Instruction> LivesReducedAnimationRelativeInstructions (object target) 
            {
                {
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(() =>
                    {
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "LivesChange/StartReduce").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "LivesChange/Mid1Reduce").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(LivesChange.Mid1Reduce);
                        Gum.DataTypes.Variables.StateSave second = first.Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.AddIntoThis(second, difference);
                        FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: 0.25f, type: FlatRedBall.Glue.StateInterpolation.InterpolationType.Linear, easing: FlatRedBall.Glue.StateInterpolation.Easing.Out);
                        tweener.Owner = this;
                        tweener.PositionChanged = newPosition => this.InterpolateBetween(first, second, newPosition);
                        tweener.Start();
                        StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                    }
                    );
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0;
                    toReturn.Target = target;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(() =>
                    {
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "LivesChange/Mid1Reduce").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "LivesChange/Mid2Reduce").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(LivesChange.Mid2Reduce);
                        Gum.DataTypes.Variables.StateSave second = first.Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.AddIntoThis(second, difference);
                        FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: 0.25f, type: FlatRedBall.Glue.StateInterpolation.InterpolationType.Quadratic, easing: FlatRedBall.Glue.StateInterpolation.Easing.In);
                        tweener.Owner = this;
                        tweener.PositionChanged = newPosition => this.InterpolateBetween(first, second, newPosition);
                        tweener.Start();
                        StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                    }
                    );
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0.25f;
                    toReturn.Target = target;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(() =>
                    {
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "LivesChange/Mid2Reduce").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "LivesChange/Mid3Reduce").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(LivesChange.Mid3Reduce);
                        Gum.DataTypes.Variables.StateSave second = first.Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.AddIntoThis(second, difference);
                        FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: 0.25f, type: FlatRedBall.Glue.StateInterpolation.InterpolationType.Bounce, easing: FlatRedBall.Glue.StateInterpolation.Easing.InOut);
                        tweener.Owner = this;
                        tweener.PositionChanged = newPosition => this.InterpolateBetween(first, second, newPosition);
                        tweener.Start();
                        StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                    }
                    );
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0.5f;
                    toReturn.Target = target;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(() =>
                    {
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "LivesChange/Mid3Reduce").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "LivesChange/EndReduce").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(LivesChange.EndReduce);
                        Gum.DataTypes.Variables.StateSave second = first.Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.AddIntoThis(second, difference);
                        FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: 0.25f, type: FlatRedBall.Glue.StateInterpolation.InterpolationType.Quadratic, easing: FlatRedBall.Glue.StateInterpolation.Easing.Out);
                        tweener.Owner = this;
                        tweener.PositionChanged = newPosition => this.InterpolateBetween(first, second, newPosition);
                        tweener.Start();
                        StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                    }
                    );
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0.75f;
                    toReturn.Target = target;
                    yield return toReturn;
                }
            }
            private FlatRedBall.Gum.Animation.GumAnimation livesReducedAnimation;
            public FlatRedBall.Gum.Animation.GumAnimation LivesReducedAnimation
            {
                get
                {
                    if (livesReducedAnimation == null)
                    {
                        livesReducedAnimation = new FlatRedBall.Gum.Animation.GumAnimation(1, LivesReducedAnimationInstructions);
                    }
                    return livesReducedAnimation;
                }
            }
            private FlatRedBall.Gum.Animation.GumAnimation livesReducedAnimationRelative;
            public FlatRedBall.Gum.Animation.GumAnimation LivesReducedAnimationRelative
            {
                get
                {
                    if (livesReducedAnimationRelative == null)
                    {
                        livesReducedAnimationRelative = new FlatRedBall.Gum.Animation.GumAnimation(1, LivesReducedAnimationRelativeInstructions);
                    }
                    return livesReducedAnimationRelative;
                }
            }
            private System.Collections.Generic.IEnumerable<FlatRedBall.Instructions.Instruction> AddPointsAnimationInstructions (object target) 
            {
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction( ()=> this.CurrentPointsChangeState = PointsChange.PointsIncreaseStart);
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime;
                    toReturn.Target = target;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(PointsChange.PointsIncreaseEnd, 1, FlatRedBall.Glue.StateInterpolation.InterpolationType.Linear, FlatRedBall.Glue.StateInterpolation.Easing.Out, AddPointsAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0;
                    yield return toReturn;
                }
            }
            private System.Collections.Generic.IEnumerable<FlatRedBall.Instructions.Instruction> AddPointsAnimationRelativeInstructions (object target) 
            {
                {
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(() =>
                    {
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "PointsChange/PointsIncreaseStart").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "PointsChange/PointsIncreaseEnd").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(PointsChange.PointsIncreaseEnd);
                        Gum.DataTypes.Variables.StateSave second = first.Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.AddIntoThis(second, difference);
                        FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: 1, type: FlatRedBall.Glue.StateInterpolation.InterpolationType.Linear, easing: FlatRedBall.Glue.StateInterpolation.Easing.Out);
                        tweener.Owner = this;
                        tweener.PositionChanged = newPosition => this.InterpolateBetween(first, second, newPosition);
                        tweener.Start();
                        StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                    }
                    );
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0;
                    toReturn.Target = target;
                    yield return toReturn;
                }
            }
            private FlatRedBall.Gum.Animation.GumAnimation addPointsAnimation;
            public FlatRedBall.Gum.Animation.GumAnimation AddPointsAnimation
            {
                get
                {
                    if (addPointsAnimation == null)
                    {
                        addPointsAnimation = new FlatRedBall.Gum.Animation.GumAnimation(1, AddPointsAnimationInstructions);
                    }
                    return addPointsAnimation;
                }
            }
            private FlatRedBall.Gum.Animation.GumAnimation addPointsAnimationRelative;
            public FlatRedBall.Gum.Animation.GumAnimation AddPointsAnimationRelative
            {
                get
                {
                    if (addPointsAnimationRelative == null)
                    {
                        addPointsAnimationRelative = new FlatRedBall.Gum.Animation.GumAnimation(1, AddPointsAnimationRelativeInstructions);
                    }
                    return addPointsAnimationRelative;
                }
            }
            private System.Collections.Generic.IEnumerable<FlatRedBall.Instructions.Instruction> SubtractPointsAnimationInstructions (object target) 
            {
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction( ()=> this.CurrentPointsChangeState = PointsChange.PointsDecreaseStart);
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime;
                    toReturn.Target = target;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(PointsChange.PointsDecreaseEnd, 1, FlatRedBall.Glue.StateInterpolation.InterpolationType.Quadratic, FlatRedBall.Glue.StateInterpolation.Easing.Out, SubtractPointsAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0;
                    yield return toReturn;
                }
            }
            private System.Collections.Generic.IEnumerable<FlatRedBall.Instructions.Instruction> SubtractPointsAnimationRelativeInstructions (object target) 
            {
                {
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(() =>
                    {
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "PointsChange/PointsDecreaseStart").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "PointsChange/PointsDecreaseEnd").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(PointsChange.PointsDecreaseEnd);
                        Gum.DataTypes.Variables.StateSave second = first.Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.AddIntoThis(second, difference);
                        FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: 1, type: FlatRedBall.Glue.StateInterpolation.InterpolationType.Quadratic, easing: FlatRedBall.Glue.StateInterpolation.Easing.Out);
                        tweener.Owner = this;
                        tweener.PositionChanged = newPosition => this.InterpolateBetween(first, second, newPosition);
                        tweener.Start();
                        StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                    }
                    );
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0;
                    toReturn.Target = target;
                    yield return toReturn;
                }
            }
            private FlatRedBall.Gum.Animation.GumAnimation subtractPointsAnimation;
            public FlatRedBall.Gum.Animation.GumAnimation SubtractPointsAnimation
            {
                get
                {
                    if (subtractPointsAnimation == null)
                    {
                        subtractPointsAnimation = new FlatRedBall.Gum.Animation.GumAnimation(1, SubtractPointsAnimationInstructions);
                    }
                    return subtractPointsAnimation;
                }
            }
            private FlatRedBall.Gum.Animation.GumAnimation subtractPointsAnimationRelative;
            public FlatRedBall.Gum.Animation.GumAnimation SubtractPointsAnimationRelative
            {
                get
                {
                    if (subtractPointsAnimationRelative == null)
                    {
                        subtractPointsAnimationRelative = new FlatRedBall.Gum.Animation.GumAnimation(1, SubtractPointsAnimationRelativeInstructions);
                    }
                    return subtractPointsAnimationRelative;
                }
            }
            #endregion
            public override void StopAnimations () 
            {
                base.StopAnimations();
                MessageFrameInstance.StopAnimations();
                LivesReducedAnimation.Stop();
                AddPointsAnimation.Stop();
                SubtractPointsAnimation.Stop();
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
                            Name = "Width",
                            Type = "float",
                            Value = Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageFrameInstance.Height",
                            Type = "float",
                            Value = MessageFrameInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageFrameInstance.Width",
                            Type = "float",
                            Value = MessageFrameInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageFrameInstance.X",
                            Type = "float",
                            Value = MessageFrameInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageFrameInstance.Y",
                            Type = "float",
                            Value = MessageFrameInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesSprite.Height",
                            Type = "float",
                            Value = LivesSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = LivesSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesSprite.Parent",
                            Type = "string",
                            Value = LivesSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesSprite.SourceFile",
                            Type = "string",
                            Value = LivesSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = LivesSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesSprite.Texture Height",
                            Type = "int",
                            Value = LivesSprite.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesSprite.Texture Left",
                            Type = "int",
                            Value = LivesSprite.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesSprite.Texture Top",
                            Type = "int",
                            Value = LivesSprite.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesSprite.Texture Width",
                            Type = "int",
                            Value = LivesSprite.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesSprite.Width",
                            Type = "float",
                            Value = LivesSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = LivesSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesSprite.X",
                            Type = "float",
                            Value = LivesSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = LivesSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesSprite.X Units",
                            Type = "PositionUnitType",
                            Value = LivesSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesSprite.Y",
                            Type = "float",
                            Value = LivesSprite.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = LivesSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesSprite.Y Units",
                            Type = "PositionUnitType",
                            Value = LivesSprite.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesRemainingText.CustomFontFile",
                            Type = "string",
                            Value = LivesRemainingText.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesRemainingText.Height",
                            Type = "float",
                            Value = LivesRemainingText.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesRemainingText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = LivesRemainingText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesRemainingText.Parent",
                            Type = "string",
                            Value = LivesRemainingText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesRemainingText.Text",
                            Type = "string",
                            Value = LivesRemainingText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesRemainingText.UseCustomFont",
                            Type = "bool",
                            Value = LivesRemainingText.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesRemainingText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = LivesRemainingText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesRemainingText.Width",
                            Type = "float",
                            Value = LivesRemainingText.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesRemainingText.X",
                            Type = "float",
                            Value = LivesRemainingText.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesRemainingText.Y",
                            Type = "float",
                            Value = LivesRemainingText.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Alpha",
                            Type = "int",
                            Value = LivesXSprite.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Height",
                            Type = "float",
                            Value = LivesXSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = LivesXSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Parent",
                            Type = "string",
                            Value = LivesXSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.SourceFile",
                            Type = "string",
                            Value = LivesXSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = LivesXSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Texture Height",
                            Type = "int",
                            Value = LivesXSprite.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Texture Left",
                            Type = "int",
                            Value = LivesXSprite.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Texture Top",
                            Type = "int",
                            Value = LivesXSprite.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Texture Width",
                            Type = "int",
                            Value = LivesXSprite.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Visible",
                            Type = "bool",
                            Value = LivesXSprite.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Width",
                            Type = "float",
                            Value = LivesXSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = LivesXSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.X",
                            Type = "float",
                            Value = LivesXSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = LivesXSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Y",
                            Type = "float",
                            Value = LivesXSprite.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = LivesXSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesContainer.Height",
                            Type = "float",
                            Value = LivesContainer.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = LivesContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesContainer.Width",
                            Type = "float",
                            Value = LivesContainer.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = LivesContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesContainer.X",
                            Type = "float",
                            Value = LivesContainer.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsContainer.Height",
                            Type = "float",
                            Value = PointsContainer.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = PointsContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsContainer.Width",
                            Type = "float",
                            Value = PointsContainer.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = PointsContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsContainer.X",
                            Type = "float",
                            Value = PointsContainer.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsContainer.Y",
                            Type = "float",
                            Value = PointsContainer.Y
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
                            Name = "PointsText.Alpha",
                            Type = "int",
                            Value = PointsText.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsText.CustomFontFile",
                            Type = "string",
                            Value = PointsText.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsText.Height",
                            Type = "float",
                            Value = PointsText.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = PointsText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsText.Parent",
                            Type = "string",
                            Value = PointsText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsText.Text",
                            Type = "string",
                            Value = PointsText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsText.UseCustomFont",
                            Type = "bool",
                            Value = PointsText.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = PointsText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsText.Width",
                            Type = "float",
                            Value = PointsText.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsText.X",
                            Type = "float",
                            Value = PointsText.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsText.Y",
                            Type = "float",
                            Value = PointsText.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.Alpha",
                            Type = "int",
                            Value = PointsChangeText.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.CustomFontFile",
                            Type = "string",
                            Value = PointsChangeText.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.Height",
                            Type = "float",
                            Value = PointsChangeText.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = PointsChangeText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.Parent",
                            Type = "string",
                            Value = PointsChangeText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.Text",
                            Type = "string",
                            Value = PointsChangeText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.UseCustomFont",
                            Type = "bool",
                            Value = PointsChangeText.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = PointsChangeText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.Width",
                            Type = "float",
                            Value = PointsChangeText.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.X",
                            Type = "float",
                            Value = PointsChangeText.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.Y",
                            Type = "float",
                            Value = PointsChangeText.Y
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
                            Value = Height + 127f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Width",
                            Type = "float",
                            Value = Width + 408f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageFrameInstance.Height",
                            Type = "float",
                            Value = MessageFrameInstance.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageFrameInstance.Width",
                            Type = "float",
                            Value = MessageFrameInstance.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageFrameInstance.X",
                            Type = "float",
                            Value = MessageFrameInstance.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageFrameInstance.Y",
                            Type = "float",
                            Value = MessageFrameInstance.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesSprite.Height",
                            Type = "float",
                            Value = LivesSprite.Height + 80f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = LivesSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesSprite.Parent",
                            Type = "string",
                            Value = LivesSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesSprite.SourceFile",
                            Type = "string",
                            Value = LivesSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = LivesSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesSprite.Texture Height",
                            Type = "int",
                            Value = LivesSprite.TextureHeight + 128
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesSprite.Texture Left",
                            Type = "int",
                            Value = LivesSprite.TextureLeft + 2443
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesSprite.Texture Top",
                            Type = "int",
                            Value = LivesSprite.TextureTop + 779
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesSprite.Texture Width",
                            Type = "int",
                            Value = LivesSprite.TextureWidth + 54
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesSprite.Width",
                            Type = "float",
                            Value = LivesSprite.Width + 42.5196f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = LivesSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesSprite.X",
                            Type = "float",
                            Value = LivesSprite.X + 5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = LivesSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesSprite.X Units",
                            Type = "PositionUnitType",
                            Value = LivesSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesSprite.Y",
                            Type = "float",
                            Value = LivesSprite.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = LivesSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesSprite.Y Units",
                            Type = "PositionUnitType",
                            Value = LivesSprite.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesRemainingText.CustomFontFile",
                            Type = "string",
                            Value = LivesRemainingText.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesRemainingText.Height",
                            Type = "float",
                            Value = LivesRemainingText.Height + 112f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesRemainingText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = LivesRemainingText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesRemainingText.Parent",
                            Type = "string",
                            Value = LivesRemainingText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesRemainingText.Text",
                            Type = "string",
                            Value = LivesRemainingText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesRemainingText.UseCustomFont",
                            Type = "bool",
                            Value = LivesRemainingText.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesRemainingText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = LivesRemainingText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesRemainingText.Width",
                            Type = "float",
                            Value = LivesRemainingText.Width + 97f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesRemainingText.X",
                            Type = "float",
                            Value = LivesRemainingText.X + 71f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesRemainingText.Y",
                            Type = "float",
                            Value = LivesRemainingText.Y + 7f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Alpha",
                            Type = "int",
                            Value = LivesXSprite.Alpha + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Height",
                            Type = "float",
                            Value = LivesXSprite.Height + 64f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = LivesXSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Parent",
                            Type = "string",
                            Value = LivesXSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.SourceFile",
                            Type = "string",
                            Value = LivesXSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = LivesXSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Texture Height",
                            Type = "int",
                            Value = LivesXSprite.TextureHeight + 114
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Texture Left",
                            Type = "int",
                            Value = LivesXSprite.TextureLeft + 2505
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Texture Top",
                            Type = "int",
                            Value = LivesXSprite.TextureTop + 792
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Texture Width",
                            Type = "int",
                            Value = LivesXSprite.TextureWidth + 114
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Visible",
                            Type = "bool",
                            Value = LivesXSprite.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Width",
                            Type = "float",
                            Value = LivesXSprite.Width + 64f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = LivesXSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.X",
                            Type = "float",
                            Value = LivesXSprite.X + 41f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = LivesXSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Y",
                            Type = "float",
                            Value = LivesXSprite.Y + 61f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = LivesXSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesContainer.Height",
                            Type = "float",
                            Value = LivesContainer.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = LivesContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesContainer.Width",
                            Type = "float",
                            Value = LivesContainer.Width + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = LivesContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesContainer.X",
                            Type = "float",
                            Value = LivesContainer.X + 15f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsContainer.Height",
                            Type = "float",
                            Value = PointsContainer.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = PointsContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsContainer.Width",
                            Type = "float",
                            Value = PointsContainer.Width + 45f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = PointsContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsContainer.X",
                            Type = "float",
                            Value = PointsContainer.X + 219f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsContainer.Y",
                            Type = "float",
                            Value = PointsContainer.Y + 0f
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
                            Name = "PointsText.Alpha",
                            Type = "int",
                            Value = PointsText.Alpha + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsText.CustomFontFile",
                            Type = "string",
                            Value = PointsText.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsText.Height",
                            Type = "float",
                            Value = PointsText.Height + 112f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = PointsText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsText.Parent",
                            Type = "string",
                            Value = PointsText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsText.Text",
                            Type = "string",
                            Value = PointsText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsText.UseCustomFont",
                            Type = "bool",
                            Value = PointsText.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = PointsText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsText.Width",
                            Type = "float",
                            Value = PointsText.Width + 97f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsText.X",
                            Type = "float",
                            Value = PointsText.X + 71f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsText.Y",
                            Type = "float",
                            Value = PointsText.Y + 7f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.Alpha",
                            Type = "int",
                            Value = PointsChangeText.Alpha + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.CustomFontFile",
                            Type = "string",
                            Value = PointsChangeText.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.Height",
                            Type = "float",
                            Value = PointsChangeText.Height + 112f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = PointsChangeText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.Parent",
                            Type = "string",
                            Value = PointsChangeText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.Text",
                            Type = "string",
                            Value = PointsChangeText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.UseCustomFont",
                            Type = "bool",
                            Value = PointsChangeText.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = PointsChangeText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.Width",
                            Type = "float",
                            Value = PointsChangeText.Width + 97f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.X",
                            Type = "float",
                            Value = PointsChangeText.X + 71f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.Y",
                            Type = "float",
                            Value = PointsChangeText.Y + 7f
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (LivesChange state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  LivesChange.StartReduce:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesSprite.Blue",
                            Type = "int",
                            Value = LivesSprite.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesSprite.Green",
                            Type = "int",
                            Value = LivesSprite.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Alpha",
                            Type = "int",
                            Value = LivesXSprite.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Height",
                            Type = "float",
                            Value = LivesXSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Width",
                            Type = "float",
                            Value = LivesXSprite.Width
                        }
                        );
                        break;
                    case  LivesChange.Mid1Reduce:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesSprite.Blue",
                            Type = "int",
                            Value = LivesSprite.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesSprite.Green",
                            Type = "int",
                            Value = LivesSprite.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Alpha",
                            Type = "int",
                            Value = LivesXSprite.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Height",
                            Type = "float",
                            Value = LivesXSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Width",
                            Type = "float",
                            Value = LivesXSprite.Width
                        }
                        );
                        break;
                    case  LivesChange.Mid2Reduce:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesSprite.Blue",
                            Type = "int",
                            Value = LivesSprite.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesSprite.Green",
                            Type = "int",
                            Value = LivesSprite.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Alpha",
                            Type = "int",
                            Value = LivesXSprite.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Height",
                            Type = "float",
                            Value = LivesXSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Width",
                            Type = "float",
                            Value = LivesXSprite.Width
                        }
                        );
                        break;
                    case  LivesChange.Mid3Reduce:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesSprite.Blue",
                            Type = "int",
                            Value = LivesSprite.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesSprite.Green",
                            Type = "int",
                            Value = LivesSprite.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Alpha",
                            Type = "int",
                            Value = LivesXSprite.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Height",
                            Type = "float",
                            Value = LivesXSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Width",
                            Type = "float",
                            Value = LivesXSprite.Width
                        }
                        );
                        break;
                    case  LivesChange.EndReduce:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesSprite.Blue",
                            Type = "int",
                            Value = LivesSprite.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesSprite.Green",
                            Type = "int",
                            Value = LivesSprite.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Alpha",
                            Type = "int",
                            Value = LivesXSprite.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Height",
                            Type = "float",
                            Value = LivesXSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Width",
                            Type = "float",
                            Value = LivesXSprite.Width
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (LivesChange state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  LivesChange.StartReduce:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesSprite.Blue",
                            Type = "int",
                            Value = LivesSprite.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesSprite.Green",
                            Type = "int",
                            Value = LivesSprite.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Alpha",
                            Type = "int",
                            Value = LivesXSprite.Alpha + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Height",
                            Type = "float",
                            Value = LivesXSprite.Height + 64f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Width",
                            Type = "float",
                            Value = LivesXSprite.Width + 64f
                        }
                        );
                        break;
                    case  LivesChange.Mid1Reduce:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesSprite.Blue",
                            Type = "int",
                            Value = LivesSprite.Blue + 100
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesSprite.Green",
                            Type = "int",
                            Value = LivesSprite.Green + 100
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Alpha",
                            Type = "int",
                            Value = LivesXSprite.Alpha + 100
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Height",
                            Type = "float",
                            Value = LivesXSprite.Height + 64f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Width",
                            Type = "float",
                            Value = LivesXSprite.Width + 64f
                        }
                        );
                        break;
                    case  LivesChange.Mid2Reduce:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesSprite.Blue",
                            Type = "int",
                            Value = LivesSprite.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesSprite.Green",
                            Type = "int",
                            Value = LivesSprite.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Alpha",
                            Type = "int",
                            Value = LivesXSprite.Alpha + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Height",
                            Type = "float",
                            Value = LivesXSprite.Height + 80f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Width",
                            Type = "float",
                            Value = LivesXSprite.Width + 80f
                        }
                        );
                        break;
                    case  LivesChange.Mid3Reduce:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesSprite.Blue",
                            Type = "int",
                            Value = LivesSprite.Blue + 150
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesSprite.Green",
                            Type = "int",
                            Value = LivesSprite.Green + 150
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Alpha",
                            Type = "int",
                            Value = LivesXSprite.Alpha + 100
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Height",
                            Type = "float",
                            Value = LivesXSprite.Height + 64f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Width",
                            Type = "float",
                            Value = LivesXSprite.Width + 64f
                        }
                        );
                        break;
                    case  LivesChange.EndReduce:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesSprite.Blue",
                            Type = "int",
                            Value = LivesSprite.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesSprite.Green",
                            Type = "int",
                            Value = LivesSprite.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Alpha",
                            Type = "int",
                            Value = LivesXSprite.Alpha + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Height",
                            Type = "float",
                            Value = LivesXSprite.Height + 64f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesXSprite.Width",
                            Type = "float",
                            Value = LivesXSprite.Width + 64f
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (PointsChange state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  PointsChange.PointsIncreaseStart:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsText.Blue",
                            Type = "int",
                            Value = PointsText.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsText.Green",
                            Type = "int",
                            Value = PointsText.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsText.Red",
                            Type = "int",
                            Value = PointsText.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.Alpha",
                            Type = "int",
                            Value = PointsChangeText.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.Blue",
                            Type = "int",
                            Value = PointsChangeText.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.Green",
                            Type = "int",
                            Value = PointsChangeText.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.Red",
                            Type = "int",
                            Value = PointsChangeText.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.Y",
                            Type = "float",
                            Value = PointsChangeText.Y
                        }
                        );
                        break;
                    case  PointsChange.PointsIncreaseEnd:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsText.Blue",
                            Type = "int",
                            Value = PointsText.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsText.Green",
                            Type = "int",
                            Value = PointsText.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsText.Red",
                            Type = "int",
                            Value = PointsText.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.Alpha",
                            Type = "int",
                            Value = PointsChangeText.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.Blue",
                            Type = "int",
                            Value = PointsChangeText.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.Green",
                            Type = "int",
                            Value = PointsChangeText.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.Red",
                            Type = "int",
                            Value = PointsChangeText.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.Y",
                            Type = "float",
                            Value = PointsChangeText.Y
                        }
                        );
                        break;
                    case  PointsChange.PointsDecreaseStart:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsText.Blue",
                            Type = "int",
                            Value = PointsText.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsText.Green",
                            Type = "int",
                            Value = PointsText.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsText.Red",
                            Type = "int",
                            Value = PointsText.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.Alpha",
                            Type = "int",
                            Value = PointsChangeText.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.Blue",
                            Type = "int",
                            Value = PointsChangeText.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.Green",
                            Type = "int",
                            Value = PointsChangeText.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.Red",
                            Type = "int",
                            Value = PointsChangeText.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.Y",
                            Type = "float",
                            Value = PointsChangeText.Y
                        }
                        );
                        break;
                    case  PointsChange.PointsDecreaseEnd:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsText.Blue",
                            Type = "int",
                            Value = PointsText.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsText.Green",
                            Type = "int",
                            Value = PointsText.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsText.Red",
                            Type = "int",
                            Value = PointsText.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.Alpha",
                            Type = "int",
                            Value = PointsChangeText.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.Blue",
                            Type = "int",
                            Value = PointsChangeText.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.Green",
                            Type = "int",
                            Value = PointsChangeText.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.Red",
                            Type = "int",
                            Value = PointsChangeText.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.Y",
                            Type = "float",
                            Value = PointsChangeText.Y
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (PointsChange state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  PointsChange.PointsIncreaseStart:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsText.Blue",
                            Type = "int",
                            Value = PointsText.Blue + 100
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsText.Green",
                            Type = "int",
                            Value = PointsText.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsText.Red",
                            Type = "int",
                            Value = PointsText.Red + 100
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.Alpha",
                            Type = "int",
                            Value = PointsChangeText.Alpha + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.Blue",
                            Type = "int",
                            Value = PointsChangeText.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.Green",
                            Type = "int",
                            Value = PointsChangeText.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.Red",
                            Type = "int",
                            Value = PointsChangeText.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.Y",
                            Type = "float",
                            Value = PointsChangeText.Y + 7f
                        }
                        );
                        break;
                    case  PointsChange.PointsIncreaseEnd:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsText.Blue",
                            Type = "int",
                            Value = PointsText.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsText.Green",
                            Type = "int",
                            Value = PointsText.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsText.Red",
                            Type = "int",
                            Value = PointsText.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.Alpha",
                            Type = "int",
                            Value = PointsChangeText.Alpha + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.Blue",
                            Type = "int",
                            Value = PointsChangeText.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.Green",
                            Type = "int",
                            Value = PointsChangeText.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.Red",
                            Type = "int",
                            Value = PointsChangeText.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.Y",
                            Type = "float",
                            Value = PointsChangeText.Y + -100f
                        }
                        );
                        break;
                    case  PointsChange.PointsDecreaseStart:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsText.Blue",
                            Type = "int",
                            Value = PointsText.Blue + 100
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsText.Green",
                            Type = "int",
                            Value = PointsText.Green + 100
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsText.Red",
                            Type = "int",
                            Value = PointsText.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.Alpha",
                            Type = "int",
                            Value = PointsChangeText.Alpha + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.Blue",
                            Type = "int",
                            Value = PointsChangeText.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.Green",
                            Type = "int",
                            Value = PointsChangeText.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.Red",
                            Type = "int",
                            Value = PointsChangeText.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.Y",
                            Type = "float",
                            Value = PointsChangeText.Y + 7f
                        }
                        );
                        break;
                    case  PointsChange.PointsDecreaseEnd:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsText.Blue",
                            Type = "int",
                            Value = PointsText.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsText.Green",
                            Type = "int",
                            Value = PointsText.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsText.Red",
                            Type = "int",
                            Value = PointsText.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.Alpha",
                            Type = "int",
                            Value = PointsChangeText.Alpha + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.Blue",
                            Type = "int",
                            Value = PointsChangeText.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.Green",
                            Type = "int",
                            Value = PointsChangeText.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.Red",
                            Type = "int",
                            Value = PointsChangeText.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PointsChangeText.Y",
                            Type = "float",
                            Value = PointsChangeText.Y + 100f
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
                    else if (category.Name == "LivesChange")
                    {
                        if(state.Name == "StartReduce") this.mCurrentLivesChangeState = LivesChange.StartReduce;
                        if(state.Name == "Mid1Reduce") this.mCurrentLivesChangeState = LivesChange.Mid1Reduce;
                        if(state.Name == "Mid2Reduce") this.mCurrentLivesChangeState = LivesChange.Mid2Reduce;
                        if(state.Name == "Mid3Reduce") this.mCurrentLivesChangeState = LivesChange.Mid3Reduce;
                        if(state.Name == "EndReduce") this.mCurrentLivesChangeState = LivesChange.EndReduce;
                    }
                    else if (category.Name == "PointsChange")
                    {
                        if(state.Name == "PointsIncreaseStart") this.mCurrentPointsChangeState = PointsChange.PointsIncreaseStart;
                        if(state.Name == "PointsIncreaseEnd") this.mCurrentPointsChangeState = PointsChange.PointsIncreaseEnd;
                        if(state.Name == "PointsDecreaseStart") this.mCurrentPointsChangeState = PointsChange.PointsDecreaseStart;
                        if(state.Name == "PointsDecreaseEnd") this.mCurrentPointsChangeState = PointsChange.PointsDecreaseEnd;
                    }
                }
                base.ApplyState(state);
            }
            private AbbatoirIntergrade.GumRuntimes.MessageFrameRuntime MessageFrameInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime LivesSprite { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime LivesRemainingText { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime LivesXSprite { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime LivesContainer { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime PointsContainer { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime PointsSprite { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime PointsText { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime PointsChangeText { get; set; }
            public string LivesRemaining
            {
                get
                {
                    return LivesRemainingText.Text;
                }
                set
                {
                    if (LivesRemainingText.Text != value)
                    {
                        LivesRemainingText.Text = value;
                        LivesRemainingChanged?.Invoke(this, null);
                    }
                }
            }
            public string SatoshiChange
            {
                get
                {
                    return PointsChangeText.Text;
                }
                set
                {
                    if (PointsChangeText.Text != value)
                    {
                        PointsChangeText.Text = value;
                        SatoshiChangeChanged?.Invoke(this, null);
                    }
                }
            }
            public string SatoshiText
            {
                get
                {
                    return PointsText.Text;
                }
                set
                {
                    if (PointsText.Text != value)
                    {
                        PointsText.Text = value;
                        SatoshiTextChanged?.Invoke(this, null);
                    }
                }
            }
            public event System.EventHandler LivesRemainingChanged;
            public event System.EventHandler SatoshiChangeChanged;
            public event System.EventHandler SatoshiTextChanged;
            public LivesPointsDisplayRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "LivesPointsDisplay");
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
                MessageFrameInstance = this.GetGraphicalUiElementByName("MessageFrameInstance") as AbbatoirIntergrade.GumRuntimes.MessageFrameRuntime;
                LivesSprite = this.GetGraphicalUiElementByName("LivesSprite") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                LivesRemainingText = this.GetGraphicalUiElementByName("LivesRemainingText") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
                LivesXSprite = this.GetGraphicalUiElementByName("LivesXSprite") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                LivesContainer = this.GetGraphicalUiElementByName("LivesContainer") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
                PointsContainer = this.GetGraphicalUiElementByName("PointsContainer") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
                PointsSprite = this.GetGraphicalUiElementByName("PointsSprite") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                PointsText = this.GetGraphicalUiElementByName("PointsText") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
                PointsChangeText = this.GetGraphicalUiElementByName("PointsChangeText") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
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
