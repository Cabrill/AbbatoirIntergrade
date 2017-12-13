    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes
    {
        public partial class HorizonBoxRuntime : AbbatoirIntergrade.GumRuntimes.ContainerRuntime
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            public enum Scenery
            {
                Swamp,
                DeadTrees,
                ForestedHills,
                RedMountains,
                Plains,
                SparseTrees
            }
            public enum CloudCover
            {
                CloudStart,
                CloudEnd
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            Scenery mCurrentSceneryState;
            CloudCover mCurrentCloudCoverState;
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
                            Height = 100f;
                            HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            Visible = true;
                            Width = 100f;
                            WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            WrapsChildren = false;
                            XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            Y = 0f;
                            YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddleInverted;
                            StarContainer.Height = 1000f;
                            StarContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            StarContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "VisibleHorizonContainer");
                            StarContainer.Width = 112.5f;
                            StarContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            StarContainer.X = 50f;
                            StarContainer.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            StarContainer.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            StarContainer.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            SkyRectangle.Alpha = 255;
                            SkyRectangle.Blue = 255;
                            SkyRectangle.Green = 222;
                            SkyRectangle.Height = 100f;
                            SkyRectangle.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            SkyRectangle.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "VisibleHorizonContainer");
                            SkyRectangle.Red = 152;
                            SkyRectangle.Visible = true;
                            SkyRectangle.Width = 100f;
                            SkyRectangle.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            SkyRectangle.X = 0f;
                            SkyRectangle.Y = 0f;
                            SunMoonContainer.Height = 200f;
                            SunMoonContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            SunMoonContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "VisibleHorizonContainer");
                            SunMoonContainer.Width = 100f;
                            SunMoonContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            VisibleHorizonContainer.ClipsChildren = true;
                            VisibleHorizonContainer.Height = 20f;
                            VisibleHorizonContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            VisibleHorizonContainer.Width = 100f;
                            VisibleHorizonContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            StarrySkySprite.Animate = false;
                            StarrySkySprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            StarrySkySprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "StarContainer");
                            StarrySkySprite.Rotation = -45f;
                            SetProperty("StarrySkySprite.SourceFile", "../Screens/GameScreen/starry_sky.png");
                            StarrySkySprite.Visible = true;
                            StarrySkySprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            StarrySkySprite.X = 50f;
                            StarrySkySprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            StarrySkySprite.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            StarrySkySprite.Y = 50f;
                            StarrySkySprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            StarrySkySprite.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            SunSprite.Height = 22.222f;
                            SunSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            SunSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "SunMoonContainer");
                            SetProperty("SunSprite.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                            SunSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            SunSprite.TextureHeight = 256;
                            SunSprite.TextureLeft = 1792;
                            SunSprite.TextureTop = 0;
                            SunSprite.TextureWidth = 256;
                            SunSprite.Visible = true;
                            SunSprite.Width = 5f;
                            SunSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            SunSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            SunSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            SunSprite.Y = 0f;
                            SunSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                            SunSprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddleInverted;
                            MoonSprite.Height = 13.3332f;
                            MoonSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            MoonSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "SunMoonContainer");
                            SetProperty("MoonSprite.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                            MoonSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            MoonSprite.TextureHeight = 256;
                            MoonSprite.TextureLeft = 1536;
                            MoonSprite.TextureTop = 0;
                            MoonSprite.TextureWidth = 256;
                            MoonSprite.Visible = true;
                            MoonSprite.Width = 3f;
                            MoonSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            MoonSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            MoonSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            MoonSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                            MoonSprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddleInverted;
                            SkyHazeSprite.Alpha = 200;
                            SkyHazeSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            SkyHazeSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "VisibleHorizonContainer");
                            SetProperty("SkyHazeSprite.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                            SkyHazeSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            SkyHazeSprite.TextureHeight = 144;
                            SkyHazeSprite.TextureLeft = 2048;
                            SkyHazeSprite.TextureTop = 256;
                            SkyHazeSprite.TextureWidth = 1;
                            SkyHazeSprite.Visible = true;
                            SkyHazeSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            DawnDuskSprite.Blue = 0;
                            DawnDuskSprite.FlipHorizontal = false;
                            DawnDuskSprite.FlipVertical = false;
                            DawnDuskSprite.Green = 140;
                            DawnDuskSprite.Height = 25f;
                            DawnDuskSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            DawnDuskSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "VisibleHorizonContainer");
                            DawnDuskSprite.Red = 255;
                            DawnDuskSprite.Rotation = 0f;
                            SetProperty("DawnDuskSprite.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                            DawnDuskSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            DawnDuskSprite.TextureHeight = 144;
                            DawnDuskSprite.TextureLeft = 2047;
                            DawnDuskSprite.TextureTop = 256;
                            DawnDuskSprite.TextureWidth = 1;
                            DawnDuskSprite.Visible = true;
                            DawnDuskSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            DawnDuskSprite.Wrap = true;
                            DawnDuskSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                            DawnDuskSprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            CloudCoverSprite.Alpha = 150;
                            CloudCoverSprite.Animate = false;
                            CloudCoverSprite.Blue = 255;
                            CloudCoverSprite.Green = 255;
                            CloudCoverSprite.Height = 20f;
                            CloudCoverSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            CloudCoverSprite.Red = 255;
                            SetProperty("CloudCoverSprite.SourceFile", "../Screens/GameScreen/Backgrounds/BGmountains-clouds.png");
                            CloudCoverSprite.TextureAddress = Gum.Managers.TextureAddress.DimensionsBased;
                            CloudCoverSprite.TextureHeight = 288;
                            CloudCoverSprite.TextureHeightScale = 1f;
                            CloudCoverSprite.TextureLeft = 0;
                            CloudCoverSprite.TextureTop = 0;
                            CloudCoverSprite.TextureWidth = 381;
                            CloudCoverSprite.TextureWidthScale = 1f;
                            CloudCoverSprite.Visible = true;
                            CloudCoverSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            CloudCoverSprite.Wrap = true;
                            CloudCoverSprite.X = 0f;
                            CloudCoverSprite.Y = 0f;
                            ForegroundSprite.Animate = false;
                            ForegroundSprite.Blue = 255;
                            ForegroundSprite.Green = 255;
                            ForegroundSprite.Height = 20f;
                            ForegroundSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ForegroundSprite.Red = 255;
                            SetProperty("ForegroundSprite.SourceFile", "../Screens/GameScreen/Backgrounds/BGmountains.png");
                            ForegroundSprite.TextureAddress = Gum.Managers.TextureAddress.DimensionsBased;
                            ForegroundSprite.TextureHeight = 288;
                            ForegroundSprite.TextureHeightScale = 1f;
                            ForegroundSprite.TextureLeft = 0;
                            ForegroundSprite.TextureTop = 0;
                            ForegroundSprite.TextureWidth = 381;
                            ForegroundSprite.TextureWidthScale = 1f;
                            ForegroundSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ForegroundSprite.Wrap = true;
                            ForegroundSprite.X = 0f;
                            ForegroundSprite.Y = 0f;
                            break;
                    }
                }
            }
            public Scenery CurrentSceneryState
            {
                get
                {
                    return mCurrentSceneryState;
                }
                set
                {
                    mCurrentSceneryState = value;
                    switch(mCurrentSceneryState)
                    {
                        case  Scenery.Swamp:
                            SetProperty("CloudCoverSprite.SourceFile", "Mangrove.png");
                            CloudCoverSprite.Visible = false;
                            SetProperty("ForegroundSprite.SourceFile", "../Screens/GameScreen/Backgrounds/BGswamp.png");
                            break;
                        case  Scenery.DeadTrees:
                            SetProperty("CloudCoverSprite.SourceFile", "Mangrove.png");
                            CloudCoverSprite.Visible = false;
                            SetProperty("ForegroundSprite.SourceFile", "../Screens/GameScreen/Backgrounds/BGDeadtrees.png");
                            break;
                        case  Scenery.ForestedHills:
                            SetProperty("CloudCoverSprite.SourceFile", "Mangrove.png");
                            CloudCoverSprite.Visible = false;
                            SetProperty("ForegroundSprite.SourceFile", "../Screens/GameScreen/Backgrounds/BGforesthills.png");
                            break;
                        case  Scenery.RedMountains:
                            SetProperty("CloudCoverSprite.SourceFile", "../Screens/GameScreen/Backgrounds/BGmountains-clouds.png");
                            CloudCoverSprite.Visible = true;
                            SetProperty("ForegroundSprite.SourceFile", "../Screens/GameScreen/Backgrounds/BGmountains.png");
                            break;
                        case  Scenery.Plains:
                            SetProperty("CloudCoverSprite.SourceFile", "Mangrove.png");
                            CloudCoverSprite.Visible = false;
                            SetProperty("ForegroundSprite.SourceFile", "../Screens/GameScreen/Backgrounds/BGPlains.png");
                            break;
                        case  Scenery.SparseTrees:
                            SetProperty("CloudCoverSprite.SourceFile", "Mangrove.png");
                            CloudCoverSprite.Visible = false;
                            SetProperty("ForegroundSprite.SourceFile", "../Screens/GameScreen/Backgrounds/BGTreeplains.png");
                            break;
                    }
                }
            }
            public CloudCover CurrentCloudCoverState
            {
                get
                {
                    return mCurrentCloudCoverState;
                }
                set
                {
                    mCurrentCloudCoverState = value;
                    switch(mCurrentCloudCoverState)
                    {
                        case  CloudCover.CloudStart:
                            CloudCoverSprite.Width = 150f;
                            CloudCoverSprite.X = 0f;
                            break;
                        case  CloudCover.CloudEnd:
                            CloudCoverSprite.Width = 150f;
                            CloudCoverSprite.X = -512f;
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
                bool setCloudCoverSpriteAlphaFirstValue = false;
                bool setCloudCoverSpriteAlphaSecondValue = false;
                int CloudCoverSpriteAlphaFirstValue= 0;
                int CloudCoverSpriteAlphaSecondValue= 0;
                bool setCloudCoverSpriteBlueFirstValue = false;
                bool setCloudCoverSpriteBlueSecondValue = false;
                int CloudCoverSpriteBlueFirstValue= 0;
                int CloudCoverSpriteBlueSecondValue= 0;
                bool setCloudCoverSpriteGreenFirstValue = false;
                bool setCloudCoverSpriteGreenSecondValue = false;
                int CloudCoverSpriteGreenFirstValue= 0;
                int CloudCoverSpriteGreenSecondValue= 0;
                bool setCloudCoverSpriteHeightFirstValue = false;
                bool setCloudCoverSpriteHeightSecondValue = false;
                float CloudCoverSpriteHeightFirstValue= 0;
                float CloudCoverSpriteHeightSecondValue= 0;
                bool setCloudCoverSpriteRedFirstValue = false;
                bool setCloudCoverSpriteRedSecondValue = false;
                int CloudCoverSpriteRedFirstValue= 0;
                int CloudCoverSpriteRedSecondValue= 0;
                bool setCloudCoverSpriteTextureHeightFirstValue = false;
                bool setCloudCoverSpriteTextureHeightSecondValue = false;
                int CloudCoverSpriteTextureHeightFirstValue= 0;
                int CloudCoverSpriteTextureHeightSecondValue= 0;
                bool setCloudCoverSpriteTextureHeightScaleFirstValue = false;
                bool setCloudCoverSpriteTextureHeightScaleSecondValue = false;
                float CloudCoverSpriteTextureHeightScaleFirstValue= 0;
                float CloudCoverSpriteTextureHeightScaleSecondValue= 0;
                bool setCloudCoverSpriteTextureLeftFirstValue = false;
                bool setCloudCoverSpriteTextureLeftSecondValue = false;
                int CloudCoverSpriteTextureLeftFirstValue= 0;
                int CloudCoverSpriteTextureLeftSecondValue= 0;
                bool setCloudCoverSpriteTextureTopFirstValue = false;
                bool setCloudCoverSpriteTextureTopSecondValue = false;
                int CloudCoverSpriteTextureTopFirstValue= 0;
                int CloudCoverSpriteTextureTopSecondValue= 0;
                bool setCloudCoverSpriteTextureWidthFirstValue = false;
                bool setCloudCoverSpriteTextureWidthSecondValue = false;
                int CloudCoverSpriteTextureWidthFirstValue= 0;
                int CloudCoverSpriteTextureWidthSecondValue= 0;
                bool setCloudCoverSpriteTextureWidthScaleFirstValue = false;
                bool setCloudCoverSpriteTextureWidthScaleSecondValue = false;
                float CloudCoverSpriteTextureWidthScaleFirstValue= 0;
                float CloudCoverSpriteTextureWidthScaleSecondValue= 0;
                bool setCloudCoverSpriteXFirstValue = false;
                bool setCloudCoverSpriteXSecondValue = false;
                float CloudCoverSpriteXFirstValue= 0;
                float CloudCoverSpriteXSecondValue= 0;
                bool setCloudCoverSpriteYFirstValue = false;
                bool setCloudCoverSpriteYSecondValue = false;
                float CloudCoverSpriteYFirstValue= 0;
                float CloudCoverSpriteYSecondValue= 0;
                bool setDawnDuskSpriteBlueFirstValue = false;
                bool setDawnDuskSpriteBlueSecondValue = false;
                int DawnDuskSpriteBlueFirstValue= 0;
                int DawnDuskSpriteBlueSecondValue= 0;
                bool setDawnDuskSpriteGreenFirstValue = false;
                bool setDawnDuskSpriteGreenSecondValue = false;
                int DawnDuskSpriteGreenFirstValue= 0;
                int DawnDuskSpriteGreenSecondValue= 0;
                bool setDawnDuskSpriteHeightFirstValue = false;
                bool setDawnDuskSpriteHeightSecondValue = false;
                float DawnDuskSpriteHeightFirstValue= 0;
                float DawnDuskSpriteHeightSecondValue= 0;
                bool setDawnDuskSpriteRedFirstValue = false;
                bool setDawnDuskSpriteRedSecondValue = false;
                int DawnDuskSpriteRedFirstValue= 0;
                int DawnDuskSpriteRedSecondValue= 0;
                bool setDawnDuskSpriteRotationFirstValue = false;
                bool setDawnDuskSpriteRotationSecondValue = false;
                float DawnDuskSpriteRotationFirstValue= 0;
                float DawnDuskSpriteRotationSecondValue= 0;
                bool setDawnDuskSpriteTextureHeightFirstValue = false;
                bool setDawnDuskSpriteTextureHeightSecondValue = false;
                int DawnDuskSpriteTextureHeightFirstValue= 0;
                int DawnDuskSpriteTextureHeightSecondValue= 0;
                bool setDawnDuskSpriteTextureLeftFirstValue = false;
                bool setDawnDuskSpriteTextureLeftSecondValue = false;
                int DawnDuskSpriteTextureLeftFirstValue= 0;
                int DawnDuskSpriteTextureLeftSecondValue= 0;
                bool setDawnDuskSpriteTextureTopFirstValue = false;
                bool setDawnDuskSpriteTextureTopSecondValue = false;
                int DawnDuskSpriteTextureTopFirstValue= 0;
                int DawnDuskSpriteTextureTopSecondValue= 0;
                bool setDawnDuskSpriteTextureWidthFirstValue = false;
                bool setDawnDuskSpriteTextureWidthSecondValue = false;
                int DawnDuskSpriteTextureWidthFirstValue= 0;
                int DawnDuskSpriteTextureWidthSecondValue= 0;
                bool setForegroundSpriteBlueFirstValue = false;
                bool setForegroundSpriteBlueSecondValue = false;
                int ForegroundSpriteBlueFirstValue= 0;
                int ForegroundSpriteBlueSecondValue= 0;
                bool setForegroundSpriteGreenFirstValue = false;
                bool setForegroundSpriteGreenSecondValue = false;
                int ForegroundSpriteGreenFirstValue= 0;
                int ForegroundSpriteGreenSecondValue= 0;
                bool setForegroundSpriteHeightFirstValue = false;
                bool setForegroundSpriteHeightSecondValue = false;
                float ForegroundSpriteHeightFirstValue= 0;
                float ForegroundSpriteHeightSecondValue= 0;
                bool setForegroundSpriteRedFirstValue = false;
                bool setForegroundSpriteRedSecondValue = false;
                int ForegroundSpriteRedFirstValue= 0;
                int ForegroundSpriteRedSecondValue= 0;
                bool setForegroundSpriteTextureHeightFirstValue = false;
                bool setForegroundSpriteTextureHeightSecondValue = false;
                int ForegroundSpriteTextureHeightFirstValue= 0;
                int ForegroundSpriteTextureHeightSecondValue= 0;
                bool setForegroundSpriteTextureHeightScaleFirstValue = false;
                bool setForegroundSpriteTextureHeightScaleSecondValue = false;
                float ForegroundSpriteTextureHeightScaleFirstValue= 0;
                float ForegroundSpriteTextureHeightScaleSecondValue= 0;
                bool setForegroundSpriteTextureLeftFirstValue = false;
                bool setForegroundSpriteTextureLeftSecondValue = false;
                int ForegroundSpriteTextureLeftFirstValue= 0;
                int ForegroundSpriteTextureLeftSecondValue= 0;
                bool setForegroundSpriteTextureTopFirstValue = false;
                bool setForegroundSpriteTextureTopSecondValue = false;
                int ForegroundSpriteTextureTopFirstValue= 0;
                int ForegroundSpriteTextureTopSecondValue= 0;
                bool setForegroundSpriteTextureWidthFirstValue = false;
                bool setForegroundSpriteTextureWidthSecondValue = false;
                int ForegroundSpriteTextureWidthFirstValue= 0;
                int ForegroundSpriteTextureWidthSecondValue= 0;
                bool setForegroundSpriteTextureWidthScaleFirstValue = false;
                bool setForegroundSpriteTextureWidthScaleSecondValue = false;
                float ForegroundSpriteTextureWidthScaleFirstValue= 0;
                float ForegroundSpriteTextureWidthScaleSecondValue= 0;
                bool setForegroundSpriteXFirstValue = false;
                bool setForegroundSpriteXSecondValue = false;
                float ForegroundSpriteXFirstValue= 0;
                float ForegroundSpriteXSecondValue= 0;
                bool setForegroundSpriteYFirstValue = false;
                bool setForegroundSpriteYSecondValue = false;
                float ForegroundSpriteYFirstValue= 0;
                float ForegroundSpriteYSecondValue= 0;
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setMoonSpriteHeightFirstValue = false;
                bool setMoonSpriteHeightSecondValue = false;
                float MoonSpriteHeightFirstValue= 0;
                float MoonSpriteHeightSecondValue= 0;
                bool setMoonSpriteTextureHeightFirstValue = false;
                bool setMoonSpriteTextureHeightSecondValue = false;
                int MoonSpriteTextureHeightFirstValue= 0;
                int MoonSpriteTextureHeightSecondValue= 0;
                bool setMoonSpriteTextureLeftFirstValue = false;
                bool setMoonSpriteTextureLeftSecondValue = false;
                int MoonSpriteTextureLeftFirstValue= 0;
                int MoonSpriteTextureLeftSecondValue= 0;
                bool setMoonSpriteTextureTopFirstValue = false;
                bool setMoonSpriteTextureTopSecondValue = false;
                int MoonSpriteTextureTopFirstValue= 0;
                int MoonSpriteTextureTopSecondValue= 0;
                bool setMoonSpriteTextureWidthFirstValue = false;
                bool setMoonSpriteTextureWidthSecondValue = false;
                int MoonSpriteTextureWidthFirstValue= 0;
                int MoonSpriteTextureWidthSecondValue= 0;
                bool setMoonSpriteWidthFirstValue = false;
                bool setMoonSpriteWidthSecondValue = false;
                float MoonSpriteWidthFirstValue= 0;
                float MoonSpriteWidthSecondValue= 0;
                bool setSkyHazeSpriteAlphaFirstValue = false;
                bool setSkyHazeSpriteAlphaSecondValue = false;
                int SkyHazeSpriteAlphaFirstValue= 0;
                int SkyHazeSpriteAlphaSecondValue= 0;
                bool setSkyHazeSpriteTextureHeightFirstValue = false;
                bool setSkyHazeSpriteTextureHeightSecondValue = false;
                int SkyHazeSpriteTextureHeightFirstValue= 0;
                int SkyHazeSpriteTextureHeightSecondValue= 0;
                bool setSkyHazeSpriteTextureLeftFirstValue = false;
                bool setSkyHazeSpriteTextureLeftSecondValue = false;
                int SkyHazeSpriteTextureLeftFirstValue= 0;
                int SkyHazeSpriteTextureLeftSecondValue= 0;
                bool setSkyHazeSpriteTextureTopFirstValue = false;
                bool setSkyHazeSpriteTextureTopSecondValue = false;
                int SkyHazeSpriteTextureTopFirstValue= 0;
                int SkyHazeSpriteTextureTopSecondValue= 0;
                bool setSkyHazeSpriteTextureWidthFirstValue = false;
                bool setSkyHazeSpriteTextureWidthSecondValue = false;
                int SkyHazeSpriteTextureWidthFirstValue= 0;
                int SkyHazeSpriteTextureWidthSecondValue= 0;
                bool setSkyRectangleAlphaFirstValue = false;
                bool setSkyRectangleAlphaSecondValue = false;
                int SkyRectangleAlphaFirstValue= 0;
                int SkyRectangleAlphaSecondValue= 0;
                bool setSkyRectangleBlueFirstValue = false;
                bool setSkyRectangleBlueSecondValue = false;
                int SkyRectangleBlueFirstValue= 0;
                int SkyRectangleBlueSecondValue= 0;
                bool setSkyRectangleGreenFirstValue = false;
                bool setSkyRectangleGreenSecondValue = false;
                int SkyRectangleGreenFirstValue= 0;
                int SkyRectangleGreenSecondValue= 0;
                bool setSkyRectangleHeightFirstValue = false;
                bool setSkyRectangleHeightSecondValue = false;
                float SkyRectangleHeightFirstValue= 0;
                float SkyRectangleHeightSecondValue= 0;
                bool setSkyRectangleRedFirstValue = false;
                bool setSkyRectangleRedSecondValue = false;
                int SkyRectangleRedFirstValue= 0;
                int SkyRectangleRedSecondValue= 0;
                bool setSkyRectangleWidthFirstValue = false;
                bool setSkyRectangleWidthSecondValue = false;
                float SkyRectangleWidthFirstValue= 0;
                float SkyRectangleWidthSecondValue= 0;
                bool setSkyRectangleXFirstValue = false;
                bool setSkyRectangleXSecondValue = false;
                float SkyRectangleXFirstValue= 0;
                float SkyRectangleXSecondValue= 0;
                bool setSkyRectangleYFirstValue = false;
                bool setSkyRectangleYSecondValue = false;
                float SkyRectangleYFirstValue= 0;
                float SkyRectangleYSecondValue= 0;
                bool setStarContainerHeightFirstValue = false;
                bool setStarContainerHeightSecondValue = false;
                float StarContainerHeightFirstValue= 0;
                float StarContainerHeightSecondValue= 0;
                bool setStarContainerWidthFirstValue = false;
                bool setStarContainerWidthSecondValue = false;
                float StarContainerWidthFirstValue= 0;
                float StarContainerWidthSecondValue= 0;
                bool setStarContainerXFirstValue = false;
                bool setStarContainerXSecondValue = false;
                float StarContainerXFirstValue= 0;
                float StarContainerXSecondValue= 0;
                bool setStarrySkySpriteRotationFirstValue = false;
                bool setStarrySkySpriteRotationSecondValue = false;
                float StarrySkySpriteRotationFirstValue= 0;
                float StarrySkySpriteRotationSecondValue= 0;
                bool setStarrySkySpriteXFirstValue = false;
                bool setStarrySkySpriteXSecondValue = false;
                float StarrySkySpriteXFirstValue= 0;
                float StarrySkySpriteXSecondValue= 0;
                bool setStarrySkySpriteYFirstValue = false;
                bool setStarrySkySpriteYSecondValue = false;
                float StarrySkySpriteYFirstValue= 0;
                float StarrySkySpriteYSecondValue= 0;
                bool setSunMoonContainerHeightFirstValue = false;
                bool setSunMoonContainerHeightSecondValue = false;
                float SunMoonContainerHeightFirstValue= 0;
                float SunMoonContainerHeightSecondValue= 0;
                bool setSunMoonContainerWidthFirstValue = false;
                bool setSunMoonContainerWidthSecondValue = false;
                float SunMoonContainerWidthFirstValue= 0;
                float SunMoonContainerWidthSecondValue= 0;
                bool setSunSpriteHeightFirstValue = false;
                bool setSunSpriteHeightSecondValue = false;
                float SunSpriteHeightFirstValue= 0;
                float SunSpriteHeightSecondValue= 0;
                bool setSunSpriteTextureHeightFirstValue = false;
                bool setSunSpriteTextureHeightSecondValue = false;
                int SunSpriteTextureHeightFirstValue= 0;
                int SunSpriteTextureHeightSecondValue= 0;
                bool setSunSpriteTextureLeftFirstValue = false;
                bool setSunSpriteTextureLeftSecondValue = false;
                int SunSpriteTextureLeftFirstValue= 0;
                int SunSpriteTextureLeftSecondValue= 0;
                bool setSunSpriteTextureTopFirstValue = false;
                bool setSunSpriteTextureTopSecondValue = false;
                int SunSpriteTextureTopFirstValue= 0;
                int SunSpriteTextureTopSecondValue= 0;
                bool setSunSpriteTextureWidthFirstValue = false;
                bool setSunSpriteTextureWidthSecondValue = false;
                int SunSpriteTextureWidthFirstValue= 0;
                int SunSpriteTextureWidthSecondValue= 0;
                bool setSunSpriteWidthFirstValue = false;
                bool setSunSpriteWidthSecondValue = false;
                float SunSpriteWidthFirstValue= 0;
                float SunSpriteWidthSecondValue= 0;
                bool setSunSpriteYFirstValue = false;
                bool setSunSpriteYSecondValue = false;
                float SunSpriteYFirstValue= 0;
                float SunSpriteYSecondValue= 0;
                bool setVisibleHorizonContainerHeightFirstValue = false;
                bool setVisibleHorizonContainerHeightSecondValue = false;
                float VisibleHorizonContainerHeightFirstValue= 0;
                float VisibleHorizonContainerHeightSecondValue= 0;
                bool setVisibleHorizonContainerWidthFirstValue = false;
                bool setVisibleHorizonContainerWidthSecondValue = false;
                float VisibleHorizonContainerWidthFirstValue= 0;
                float VisibleHorizonContainerWidthSecondValue= 0;
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                bool setYFirstValue = false;
                bool setYSecondValue = false;
                float YFirstValue= 0;
                float YSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        if (interpolationValue < 1)
                        {
                            this.ChildrenLayout = Gum.Managers.ChildrenLayout.Regular;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ClipsChildren = false;
                        }
                        setCloudCoverSpriteAlphaFirstValue = true;
                        CloudCoverSpriteAlphaFirstValue = 150;
                        if (interpolationValue < 1)
                        {
                            this.CloudCoverSprite.Animate = false;
                        }
                        setCloudCoverSpriteBlueFirstValue = true;
                        CloudCoverSpriteBlueFirstValue = 255;
                        setCloudCoverSpriteGreenFirstValue = true;
                        CloudCoverSpriteGreenFirstValue = 255;
                        setCloudCoverSpriteHeightFirstValue = true;
                        CloudCoverSpriteHeightFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.CloudCoverSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setCloudCoverSpriteRedFirstValue = true;
                        CloudCoverSpriteRedFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            SetProperty("CloudCoverSprite.SourceFile", "../Screens/GameScreen/Backgrounds/BGmountains-clouds.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.CloudCoverSprite.TextureAddress = Gum.Managers.TextureAddress.DimensionsBased;
                        }
                        setCloudCoverSpriteTextureHeightFirstValue = true;
                        CloudCoverSpriteTextureHeightFirstValue = 288;
                        setCloudCoverSpriteTextureHeightScaleFirstValue = true;
                        CloudCoverSpriteTextureHeightScaleFirstValue = 1f;
                        setCloudCoverSpriteTextureLeftFirstValue = true;
                        CloudCoverSpriteTextureLeftFirstValue = 0;
                        setCloudCoverSpriteTextureTopFirstValue = true;
                        CloudCoverSpriteTextureTopFirstValue = 0;
                        setCloudCoverSpriteTextureWidthFirstValue = true;
                        CloudCoverSpriteTextureWidthFirstValue = 381;
                        setCloudCoverSpriteTextureWidthScaleFirstValue = true;
                        CloudCoverSpriteTextureWidthScaleFirstValue = 1f;
                        if (interpolationValue < 1)
                        {
                            this.CloudCoverSprite.Visible = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CloudCoverSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CloudCoverSprite.Wrap = true;
                        }
                        setCloudCoverSpriteXFirstValue = true;
                        CloudCoverSpriteXFirstValue = 0f;
                        setCloudCoverSpriteYFirstValue = true;
                        CloudCoverSpriteYFirstValue = 0f;
                        setDawnDuskSpriteBlueFirstValue = true;
                        DawnDuskSpriteBlueFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.DawnDuskSprite.FlipHorizontal = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.DawnDuskSprite.FlipVertical = false;
                        }
                        setDawnDuskSpriteGreenFirstValue = true;
                        DawnDuskSpriteGreenFirstValue = 140;
                        setDawnDuskSpriteHeightFirstValue = true;
                        DawnDuskSpriteHeightFirstValue = 25f;
                        if (interpolationValue < 1)
                        {
                            this.DawnDuskSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.DawnDuskSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "VisibleHorizonContainer");
                        }
                        setDawnDuskSpriteRedFirstValue = true;
                        DawnDuskSpriteRedFirstValue = 255;
                        setDawnDuskSpriteRotationFirstValue = true;
                        DawnDuskSpriteRotationFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            SetProperty("DawnDuskSprite.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.DawnDuskSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setDawnDuskSpriteTextureHeightFirstValue = true;
                        DawnDuskSpriteTextureHeightFirstValue = 144;
                        setDawnDuskSpriteTextureLeftFirstValue = true;
                        DawnDuskSpriteTextureLeftFirstValue = 2047;
                        setDawnDuskSpriteTextureTopFirstValue = true;
                        DawnDuskSpriteTextureTopFirstValue = 256;
                        setDawnDuskSpriteTextureWidthFirstValue = true;
                        DawnDuskSpriteTextureWidthFirstValue = 1;
                        if (interpolationValue < 1)
                        {
                            this.DawnDuskSprite.Visible = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.DawnDuskSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.DawnDuskSprite.Wrap = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.DawnDuskSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue < 1)
                        {
                            this.DawnDuskSprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ForegroundSprite.Animate = false;
                        }
                        setForegroundSpriteBlueFirstValue = true;
                        ForegroundSpriteBlueFirstValue = 255;
                        setForegroundSpriteGreenFirstValue = true;
                        ForegroundSpriteGreenFirstValue = 255;
                        setForegroundSpriteHeightFirstValue = true;
                        ForegroundSpriteHeightFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.ForegroundSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setForegroundSpriteRedFirstValue = true;
                        ForegroundSpriteRedFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            SetProperty("ForegroundSprite.SourceFile", "../Screens/GameScreen/Backgrounds/BGmountains.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.ForegroundSprite.TextureAddress = Gum.Managers.TextureAddress.DimensionsBased;
                        }
                        setForegroundSpriteTextureHeightFirstValue = true;
                        ForegroundSpriteTextureHeightFirstValue = 288;
                        setForegroundSpriteTextureHeightScaleFirstValue = true;
                        ForegroundSpriteTextureHeightScaleFirstValue = 1f;
                        setForegroundSpriteTextureLeftFirstValue = true;
                        ForegroundSpriteTextureLeftFirstValue = 0;
                        setForegroundSpriteTextureTopFirstValue = true;
                        ForegroundSpriteTextureTopFirstValue = 0;
                        setForegroundSpriteTextureWidthFirstValue = true;
                        ForegroundSpriteTextureWidthFirstValue = 381;
                        setForegroundSpriteTextureWidthScaleFirstValue = true;
                        ForegroundSpriteTextureWidthScaleFirstValue = 1f;
                        if (interpolationValue < 1)
                        {
                            this.ForegroundSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ForegroundSprite.Wrap = true;
                        }
                        setForegroundSpriteXFirstValue = true;
                        ForegroundSpriteXFirstValue = 0f;
                        setForegroundSpriteYFirstValue = true;
                        ForegroundSpriteYFirstValue = 0f;
                        setHeightFirstValue = true;
                        HeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setMoonSpriteHeightFirstValue = true;
                        MoonSpriteHeightFirstValue = 13.3332f;
                        if (interpolationValue < 1)
                        {
                            this.MoonSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MoonSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "SunMoonContainer");
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("MoonSprite.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.MoonSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setMoonSpriteTextureHeightFirstValue = true;
                        MoonSpriteTextureHeightFirstValue = 256;
                        setMoonSpriteTextureLeftFirstValue = true;
                        MoonSpriteTextureLeftFirstValue = 1536;
                        setMoonSpriteTextureTopFirstValue = true;
                        MoonSpriteTextureTopFirstValue = 0;
                        setMoonSpriteTextureWidthFirstValue = true;
                        MoonSpriteTextureWidthFirstValue = 256;
                        if (interpolationValue < 1)
                        {
                            this.MoonSprite.Visible = true;
                        }
                        setMoonSpriteWidthFirstValue = true;
                        MoonSpriteWidthFirstValue = 3f;
                        if (interpolationValue < 1)
                        {
                            this.MoonSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MoonSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MoonSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MoonSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MoonSprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddleInverted;
                        }
                        setSkyHazeSpriteAlphaFirstValue = true;
                        SkyHazeSpriteAlphaFirstValue = 200;
                        if (interpolationValue < 1)
                        {
                            this.SkyHazeSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SkyHazeSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "VisibleHorizonContainer");
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("SkyHazeSprite.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.SkyHazeSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setSkyHazeSpriteTextureHeightFirstValue = true;
                        SkyHazeSpriteTextureHeightFirstValue = 144;
                        setSkyHazeSpriteTextureLeftFirstValue = true;
                        SkyHazeSpriteTextureLeftFirstValue = 2048;
                        setSkyHazeSpriteTextureTopFirstValue = true;
                        SkyHazeSpriteTextureTopFirstValue = 256;
                        setSkyHazeSpriteTextureWidthFirstValue = true;
                        SkyHazeSpriteTextureWidthFirstValue = 1;
                        if (interpolationValue < 1)
                        {
                            this.SkyHazeSprite.Visible = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SkyHazeSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setSkyRectangleAlphaFirstValue = true;
                        SkyRectangleAlphaFirstValue = 255;
                        setSkyRectangleBlueFirstValue = true;
                        SkyRectangleBlueFirstValue = 255;
                        setSkyRectangleGreenFirstValue = true;
                        SkyRectangleGreenFirstValue = 222;
                        setSkyRectangleHeightFirstValue = true;
                        SkyRectangleHeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.SkyRectangle.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SkyRectangle.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "VisibleHorizonContainer");
                        }
                        setSkyRectangleRedFirstValue = true;
                        SkyRectangleRedFirstValue = 152;
                        if (interpolationValue < 1)
                        {
                            this.SkyRectangle.Visible = true;
                        }
                        setSkyRectangleWidthFirstValue = true;
                        SkyRectangleWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.SkyRectangle.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setSkyRectangleXFirstValue = true;
                        SkyRectangleXFirstValue = 0f;
                        setSkyRectangleYFirstValue = true;
                        SkyRectangleYFirstValue = 0f;
                        setStarContainerHeightFirstValue = true;
                        StarContainerHeightFirstValue = 1000f;
                        if (interpolationValue < 1)
                        {
                            this.StarContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.StarContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "VisibleHorizonContainer");
                        }
                        setStarContainerWidthFirstValue = true;
                        StarContainerWidthFirstValue = 112.5f;
                        if (interpolationValue < 1)
                        {
                            this.StarContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setStarContainerXFirstValue = true;
                        StarContainerXFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.StarContainer.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.StarContainer.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.StarContainer.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.StarrySkySprite.Animate = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.StarrySkySprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.StarrySkySprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "StarContainer");
                        }
                        setStarrySkySpriteRotationFirstValue = true;
                        StarrySkySpriteRotationFirstValue = -45f;
                        if (interpolationValue < 1)
                        {
                            SetProperty("StarrySkySprite.SourceFile", "../Screens/GameScreen/starry_sky.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.StarrySkySprite.Visible = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.StarrySkySprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setStarrySkySpriteXFirstValue = true;
                        StarrySkySpriteXFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.StarrySkySprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.StarrySkySprite.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setStarrySkySpriteYFirstValue = true;
                        StarrySkySpriteYFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.StarrySkySprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.StarrySkySprite.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setSunMoonContainerHeightFirstValue = true;
                        SunMoonContainerHeightFirstValue = 200f;
                        if (interpolationValue < 1)
                        {
                            this.SunMoonContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SunMoonContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "VisibleHorizonContainer");
                        }
                        setSunMoonContainerWidthFirstValue = true;
                        SunMoonContainerWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.SunMoonContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setSunSpriteHeightFirstValue = true;
                        SunSpriteHeightFirstValue = 22.222f;
                        if (interpolationValue < 1)
                        {
                            this.SunSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SunSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "SunMoonContainer");
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("SunSprite.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.SunSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setSunSpriteTextureHeightFirstValue = true;
                        SunSpriteTextureHeightFirstValue = 256;
                        setSunSpriteTextureLeftFirstValue = true;
                        SunSpriteTextureLeftFirstValue = 1792;
                        setSunSpriteTextureTopFirstValue = true;
                        SunSpriteTextureTopFirstValue = 0;
                        setSunSpriteTextureWidthFirstValue = true;
                        SunSpriteTextureWidthFirstValue = 256;
                        if (interpolationValue < 1)
                        {
                            this.SunSprite.Visible = true;
                        }
                        setSunSpriteWidthFirstValue = true;
                        SunSpriteWidthFirstValue = 5f;
                        if (interpolationValue < 1)
                        {
                            this.SunSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SunSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SunSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setSunSpriteYFirstValue = true;
                        SunSpriteYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.SunSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SunSprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddleInverted;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Visible = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.VisibleHorizonContainer.ClipsChildren = true;
                        }
                        setVisibleHorizonContainerHeightFirstValue = true;
                        VisibleHorizonContainerHeightFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.VisibleHorizonContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setVisibleHorizonContainerWidthFirstValue = true;
                        VisibleHorizonContainerWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.VisibleHorizonContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setWidthFirstValue = true;
                        WidthFirstValue = 100f;
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
                        setYFirstValue = true;
                        YFirstValue = 0f;
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
                            this.ChildrenLayout = Gum.Managers.ChildrenLayout.Regular;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ClipsChildren = false;
                        }
                        setCloudCoverSpriteAlphaSecondValue = true;
                        CloudCoverSpriteAlphaSecondValue = 150;
                        if (interpolationValue >= 1)
                        {
                            this.CloudCoverSprite.Animate = false;
                        }
                        setCloudCoverSpriteBlueSecondValue = true;
                        CloudCoverSpriteBlueSecondValue = 255;
                        setCloudCoverSpriteGreenSecondValue = true;
                        CloudCoverSpriteGreenSecondValue = 255;
                        setCloudCoverSpriteHeightSecondValue = true;
                        CloudCoverSpriteHeightSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.CloudCoverSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setCloudCoverSpriteRedSecondValue = true;
                        CloudCoverSpriteRedSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("CloudCoverSprite.SourceFile", "../Screens/GameScreen/Backgrounds/BGmountains-clouds.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CloudCoverSprite.TextureAddress = Gum.Managers.TextureAddress.DimensionsBased;
                        }
                        setCloudCoverSpriteTextureHeightSecondValue = true;
                        CloudCoverSpriteTextureHeightSecondValue = 288;
                        setCloudCoverSpriteTextureHeightScaleSecondValue = true;
                        CloudCoverSpriteTextureHeightScaleSecondValue = 1f;
                        setCloudCoverSpriteTextureLeftSecondValue = true;
                        CloudCoverSpriteTextureLeftSecondValue = 0;
                        setCloudCoverSpriteTextureTopSecondValue = true;
                        CloudCoverSpriteTextureTopSecondValue = 0;
                        setCloudCoverSpriteTextureWidthSecondValue = true;
                        CloudCoverSpriteTextureWidthSecondValue = 381;
                        setCloudCoverSpriteTextureWidthScaleSecondValue = true;
                        CloudCoverSpriteTextureWidthScaleSecondValue = 1f;
                        if (interpolationValue >= 1)
                        {
                            this.CloudCoverSprite.Visible = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CloudCoverSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CloudCoverSprite.Wrap = true;
                        }
                        setCloudCoverSpriteXSecondValue = true;
                        CloudCoverSpriteXSecondValue = 0f;
                        setCloudCoverSpriteYSecondValue = true;
                        CloudCoverSpriteYSecondValue = 0f;
                        setDawnDuskSpriteBlueSecondValue = true;
                        DawnDuskSpriteBlueSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.DawnDuskSprite.FlipHorizontal = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.DawnDuskSprite.FlipVertical = false;
                        }
                        setDawnDuskSpriteGreenSecondValue = true;
                        DawnDuskSpriteGreenSecondValue = 140;
                        setDawnDuskSpriteHeightSecondValue = true;
                        DawnDuskSpriteHeightSecondValue = 25f;
                        if (interpolationValue >= 1)
                        {
                            this.DawnDuskSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.DawnDuskSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "VisibleHorizonContainer");
                        }
                        setDawnDuskSpriteRedSecondValue = true;
                        DawnDuskSpriteRedSecondValue = 255;
                        setDawnDuskSpriteRotationSecondValue = true;
                        DawnDuskSpriteRotationSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("DawnDuskSprite.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.DawnDuskSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setDawnDuskSpriteTextureHeightSecondValue = true;
                        DawnDuskSpriteTextureHeightSecondValue = 144;
                        setDawnDuskSpriteTextureLeftSecondValue = true;
                        DawnDuskSpriteTextureLeftSecondValue = 2047;
                        setDawnDuskSpriteTextureTopSecondValue = true;
                        DawnDuskSpriteTextureTopSecondValue = 256;
                        setDawnDuskSpriteTextureWidthSecondValue = true;
                        DawnDuskSpriteTextureWidthSecondValue = 1;
                        if (interpolationValue >= 1)
                        {
                            this.DawnDuskSprite.Visible = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.DawnDuskSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.DawnDuskSprite.Wrap = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.DawnDuskSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.DawnDuskSprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ForegroundSprite.Animate = false;
                        }
                        setForegroundSpriteBlueSecondValue = true;
                        ForegroundSpriteBlueSecondValue = 255;
                        setForegroundSpriteGreenSecondValue = true;
                        ForegroundSpriteGreenSecondValue = 255;
                        setForegroundSpriteHeightSecondValue = true;
                        ForegroundSpriteHeightSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.ForegroundSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setForegroundSpriteRedSecondValue = true;
                        ForegroundSpriteRedSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("ForegroundSprite.SourceFile", "../Screens/GameScreen/Backgrounds/BGmountains.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ForegroundSprite.TextureAddress = Gum.Managers.TextureAddress.DimensionsBased;
                        }
                        setForegroundSpriteTextureHeightSecondValue = true;
                        ForegroundSpriteTextureHeightSecondValue = 288;
                        setForegroundSpriteTextureHeightScaleSecondValue = true;
                        ForegroundSpriteTextureHeightScaleSecondValue = 1f;
                        setForegroundSpriteTextureLeftSecondValue = true;
                        ForegroundSpriteTextureLeftSecondValue = 0;
                        setForegroundSpriteTextureTopSecondValue = true;
                        ForegroundSpriteTextureTopSecondValue = 0;
                        setForegroundSpriteTextureWidthSecondValue = true;
                        ForegroundSpriteTextureWidthSecondValue = 381;
                        setForegroundSpriteTextureWidthScaleSecondValue = true;
                        ForegroundSpriteTextureWidthScaleSecondValue = 1f;
                        if (interpolationValue >= 1)
                        {
                            this.ForegroundSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ForegroundSprite.Wrap = true;
                        }
                        setForegroundSpriteXSecondValue = true;
                        ForegroundSpriteXSecondValue = 0f;
                        setForegroundSpriteYSecondValue = true;
                        ForegroundSpriteYSecondValue = 0f;
                        setHeightSecondValue = true;
                        HeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setMoonSpriteHeightSecondValue = true;
                        MoonSpriteHeightSecondValue = 13.3332f;
                        if (interpolationValue >= 1)
                        {
                            this.MoonSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MoonSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "SunMoonContainer");
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("MoonSprite.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MoonSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setMoonSpriteTextureHeightSecondValue = true;
                        MoonSpriteTextureHeightSecondValue = 256;
                        setMoonSpriteTextureLeftSecondValue = true;
                        MoonSpriteTextureLeftSecondValue = 1536;
                        setMoonSpriteTextureTopSecondValue = true;
                        MoonSpriteTextureTopSecondValue = 0;
                        setMoonSpriteTextureWidthSecondValue = true;
                        MoonSpriteTextureWidthSecondValue = 256;
                        if (interpolationValue >= 1)
                        {
                            this.MoonSprite.Visible = true;
                        }
                        setMoonSpriteWidthSecondValue = true;
                        MoonSpriteWidthSecondValue = 3f;
                        if (interpolationValue >= 1)
                        {
                            this.MoonSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MoonSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MoonSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MoonSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MoonSprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddleInverted;
                        }
                        setSkyHazeSpriteAlphaSecondValue = true;
                        SkyHazeSpriteAlphaSecondValue = 200;
                        if (interpolationValue >= 1)
                        {
                            this.SkyHazeSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SkyHazeSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "VisibleHorizonContainer");
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("SkyHazeSprite.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SkyHazeSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setSkyHazeSpriteTextureHeightSecondValue = true;
                        SkyHazeSpriteTextureHeightSecondValue = 144;
                        setSkyHazeSpriteTextureLeftSecondValue = true;
                        SkyHazeSpriteTextureLeftSecondValue = 2048;
                        setSkyHazeSpriteTextureTopSecondValue = true;
                        SkyHazeSpriteTextureTopSecondValue = 256;
                        setSkyHazeSpriteTextureWidthSecondValue = true;
                        SkyHazeSpriteTextureWidthSecondValue = 1;
                        if (interpolationValue >= 1)
                        {
                            this.SkyHazeSprite.Visible = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SkyHazeSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setSkyRectangleAlphaSecondValue = true;
                        SkyRectangleAlphaSecondValue = 255;
                        setSkyRectangleBlueSecondValue = true;
                        SkyRectangleBlueSecondValue = 255;
                        setSkyRectangleGreenSecondValue = true;
                        SkyRectangleGreenSecondValue = 222;
                        setSkyRectangleHeightSecondValue = true;
                        SkyRectangleHeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.SkyRectangle.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SkyRectangle.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "VisibleHorizonContainer");
                        }
                        setSkyRectangleRedSecondValue = true;
                        SkyRectangleRedSecondValue = 152;
                        if (interpolationValue >= 1)
                        {
                            this.SkyRectangle.Visible = true;
                        }
                        setSkyRectangleWidthSecondValue = true;
                        SkyRectangleWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.SkyRectangle.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setSkyRectangleXSecondValue = true;
                        SkyRectangleXSecondValue = 0f;
                        setSkyRectangleYSecondValue = true;
                        SkyRectangleYSecondValue = 0f;
                        setStarContainerHeightSecondValue = true;
                        StarContainerHeightSecondValue = 1000f;
                        if (interpolationValue >= 1)
                        {
                            this.StarContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.StarContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "VisibleHorizonContainer");
                        }
                        setStarContainerWidthSecondValue = true;
                        StarContainerWidthSecondValue = 112.5f;
                        if (interpolationValue >= 1)
                        {
                            this.StarContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setStarContainerXSecondValue = true;
                        StarContainerXSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.StarContainer.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.StarContainer.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.StarContainer.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.StarrySkySprite.Animate = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.StarrySkySprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.StarrySkySprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "StarContainer");
                        }
                        setStarrySkySpriteRotationSecondValue = true;
                        StarrySkySpriteRotationSecondValue = -45f;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("StarrySkySprite.SourceFile", "../Screens/GameScreen/starry_sky.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.StarrySkySprite.Visible = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.StarrySkySprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setStarrySkySpriteXSecondValue = true;
                        StarrySkySpriteXSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.StarrySkySprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.StarrySkySprite.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setStarrySkySpriteYSecondValue = true;
                        StarrySkySpriteYSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.StarrySkySprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.StarrySkySprite.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setSunMoonContainerHeightSecondValue = true;
                        SunMoonContainerHeightSecondValue = 200f;
                        if (interpolationValue >= 1)
                        {
                            this.SunMoonContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SunMoonContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "VisibleHorizonContainer");
                        }
                        setSunMoonContainerWidthSecondValue = true;
                        SunMoonContainerWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.SunMoonContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setSunSpriteHeightSecondValue = true;
                        SunSpriteHeightSecondValue = 22.222f;
                        if (interpolationValue >= 1)
                        {
                            this.SunSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SunSprite.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "SunMoonContainer");
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("SunSprite.SourceFile", "../Screens/GameScreen/AllAssetsSheet.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SunSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setSunSpriteTextureHeightSecondValue = true;
                        SunSpriteTextureHeightSecondValue = 256;
                        setSunSpriteTextureLeftSecondValue = true;
                        SunSpriteTextureLeftSecondValue = 1792;
                        setSunSpriteTextureTopSecondValue = true;
                        SunSpriteTextureTopSecondValue = 0;
                        setSunSpriteTextureWidthSecondValue = true;
                        SunSpriteTextureWidthSecondValue = 256;
                        if (interpolationValue >= 1)
                        {
                            this.SunSprite.Visible = true;
                        }
                        setSunSpriteWidthSecondValue = true;
                        SunSpriteWidthSecondValue = 5f;
                        if (interpolationValue >= 1)
                        {
                            this.SunSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SunSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SunSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setSunSpriteYSecondValue = true;
                        SunSpriteYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.SunSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SunSprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddleInverted;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Visible = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.VisibleHorizonContainer.ClipsChildren = true;
                        }
                        setVisibleHorizonContainerHeightSecondValue = true;
                        VisibleHorizonContainerHeightSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.VisibleHorizonContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setVisibleHorizonContainerWidthSecondValue = true;
                        VisibleHorizonContainerWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.VisibleHorizonContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setWidthSecondValue = true;
                        WidthSecondValue = 100f;
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
                        setYSecondValue = true;
                        YSecondValue = 0f;
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
                if (setCloudCoverSpriteAlphaFirstValue && setCloudCoverSpriteAlphaSecondValue)
                {
                    CloudCoverSprite.Alpha = FlatRedBall.Math.MathFunctions.RoundToInt(CloudCoverSpriteAlphaFirstValue* (1 - interpolationValue) + CloudCoverSpriteAlphaSecondValue * interpolationValue);
                }
                if (setCloudCoverSpriteBlueFirstValue && setCloudCoverSpriteBlueSecondValue)
                {
                    CloudCoverSprite.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(CloudCoverSpriteBlueFirstValue* (1 - interpolationValue) + CloudCoverSpriteBlueSecondValue * interpolationValue);
                }
                if (setCloudCoverSpriteGreenFirstValue && setCloudCoverSpriteGreenSecondValue)
                {
                    CloudCoverSprite.Green = FlatRedBall.Math.MathFunctions.RoundToInt(CloudCoverSpriteGreenFirstValue* (1 - interpolationValue) + CloudCoverSpriteGreenSecondValue * interpolationValue);
                }
                if (setCloudCoverSpriteHeightFirstValue && setCloudCoverSpriteHeightSecondValue)
                {
                    CloudCoverSprite.Height = CloudCoverSpriteHeightFirstValue * (1 - interpolationValue) + CloudCoverSpriteHeightSecondValue * interpolationValue;
                }
                if (setCloudCoverSpriteRedFirstValue && setCloudCoverSpriteRedSecondValue)
                {
                    CloudCoverSprite.Red = FlatRedBall.Math.MathFunctions.RoundToInt(CloudCoverSpriteRedFirstValue* (1 - interpolationValue) + CloudCoverSpriteRedSecondValue * interpolationValue);
                }
                if (setCloudCoverSpriteTextureHeightFirstValue && setCloudCoverSpriteTextureHeightSecondValue)
                {
                    CloudCoverSprite.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(CloudCoverSpriteTextureHeightFirstValue* (1 - interpolationValue) + CloudCoverSpriteTextureHeightSecondValue * interpolationValue);
                }
                if (setCloudCoverSpriteTextureHeightScaleFirstValue && setCloudCoverSpriteTextureHeightScaleSecondValue)
                {
                    CloudCoverSprite.TextureHeightScale = CloudCoverSpriteTextureHeightScaleFirstValue * (1 - interpolationValue) + CloudCoverSpriteTextureHeightScaleSecondValue * interpolationValue;
                }
                if (setCloudCoverSpriteTextureLeftFirstValue && setCloudCoverSpriteTextureLeftSecondValue)
                {
                    CloudCoverSprite.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(CloudCoverSpriteTextureLeftFirstValue* (1 - interpolationValue) + CloudCoverSpriteTextureLeftSecondValue * interpolationValue);
                }
                if (setCloudCoverSpriteTextureTopFirstValue && setCloudCoverSpriteTextureTopSecondValue)
                {
                    CloudCoverSprite.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(CloudCoverSpriteTextureTopFirstValue* (1 - interpolationValue) + CloudCoverSpriteTextureTopSecondValue * interpolationValue);
                }
                if (setCloudCoverSpriteTextureWidthFirstValue && setCloudCoverSpriteTextureWidthSecondValue)
                {
                    CloudCoverSprite.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(CloudCoverSpriteTextureWidthFirstValue* (1 - interpolationValue) + CloudCoverSpriteTextureWidthSecondValue * interpolationValue);
                }
                if (setCloudCoverSpriteTextureWidthScaleFirstValue && setCloudCoverSpriteTextureWidthScaleSecondValue)
                {
                    CloudCoverSprite.TextureWidthScale = CloudCoverSpriteTextureWidthScaleFirstValue * (1 - interpolationValue) + CloudCoverSpriteTextureWidthScaleSecondValue * interpolationValue;
                }
                if (setCloudCoverSpriteXFirstValue && setCloudCoverSpriteXSecondValue)
                {
                    CloudCoverSprite.X = CloudCoverSpriteXFirstValue * (1 - interpolationValue) + CloudCoverSpriteXSecondValue * interpolationValue;
                }
                if (setCloudCoverSpriteYFirstValue && setCloudCoverSpriteYSecondValue)
                {
                    CloudCoverSprite.Y = CloudCoverSpriteYFirstValue * (1 - interpolationValue) + CloudCoverSpriteYSecondValue * interpolationValue;
                }
                if (setDawnDuskSpriteBlueFirstValue && setDawnDuskSpriteBlueSecondValue)
                {
                    DawnDuskSprite.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(DawnDuskSpriteBlueFirstValue* (1 - interpolationValue) + DawnDuskSpriteBlueSecondValue * interpolationValue);
                }
                if (setDawnDuskSpriteGreenFirstValue && setDawnDuskSpriteGreenSecondValue)
                {
                    DawnDuskSprite.Green = FlatRedBall.Math.MathFunctions.RoundToInt(DawnDuskSpriteGreenFirstValue* (1 - interpolationValue) + DawnDuskSpriteGreenSecondValue * interpolationValue);
                }
                if (setDawnDuskSpriteHeightFirstValue && setDawnDuskSpriteHeightSecondValue)
                {
                    DawnDuskSprite.Height = DawnDuskSpriteHeightFirstValue * (1 - interpolationValue) + DawnDuskSpriteHeightSecondValue * interpolationValue;
                }
                if (setDawnDuskSpriteRedFirstValue && setDawnDuskSpriteRedSecondValue)
                {
                    DawnDuskSprite.Red = FlatRedBall.Math.MathFunctions.RoundToInt(DawnDuskSpriteRedFirstValue* (1 - interpolationValue) + DawnDuskSpriteRedSecondValue * interpolationValue);
                }
                if (setDawnDuskSpriteRotationFirstValue && setDawnDuskSpriteRotationSecondValue)
                {
                    DawnDuskSprite.Rotation = DawnDuskSpriteRotationFirstValue * (1 - interpolationValue) + DawnDuskSpriteRotationSecondValue * interpolationValue;
                }
                if (setDawnDuskSpriteTextureHeightFirstValue && setDawnDuskSpriteTextureHeightSecondValue)
                {
                    DawnDuskSprite.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(DawnDuskSpriteTextureHeightFirstValue* (1 - interpolationValue) + DawnDuskSpriteTextureHeightSecondValue * interpolationValue);
                }
                if (setDawnDuskSpriteTextureLeftFirstValue && setDawnDuskSpriteTextureLeftSecondValue)
                {
                    DawnDuskSprite.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(DawnDuskSpriteTextureLeftFirstValue* (1 - interpolationValue) + DawnDuskSpriteTextureLeftSecondValue * interpolationValue);
                }
                if (setDawnDuskSpriteTextureTopFirstValue && setDawnDuskSpriteTextureTopSecondValue)
                {
                    DawnDuskSprite.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(DawnDuskSpriteTextureTopFirstValue* (1 - interpolationValue) + DawnDuskSpriteTextureTopSecondValue * interpolationValue);
                }
                if (setDawnDuskSpriteTextureWidthFirstValue && setDawnDuskSpriteTextureWidthSecondValue)
                {
                    DawnDuskSprite.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(DawnDuskSpriteTextureWidthFirstValue* (1 - interpolationValue) + DawnDuskSpriteTextureWidthSecondValue * interpolationValue);
                }
                if (setForegroundSpriteBlueFirstValue && setForegroundSpriteBlueSecondValue)
                {
                    ForegroundSprite.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(ForegroundSpriteBlueFirstValue* (1 - interpolationValue) + ForegroundSpriteBlueSecondValue * interpolationValue);
                }
                if (setForegroundSpriteGreenFirstValue && setForegroundSpriteGreenSecondValue)
                {
                    ForegroundSprite.Green = FlatRedBall.Math.MathFunctions.RoundToInt(ForegroundSpriteGreenFirstValue* (1 - interpolationValue) + ForegroundSpriteGreenSecondValue * interpolationValue);
                }
                if (setForegroundSpriteHeightFirstValue && setForegroundSpriteHeightSecondValue)
                {
                    ForegroundSprite.Height = ForegroundSpriteHeightFirstValue * (1 - interpolationValue) + ForegroundSpriteHeightSecondValue * interpolationValue;
                }
                if (setForegroundSpriteRedFirstValue && setForegroundSpriteRedSecondValue)
                {
                    ForegroundSprite.Red = FlatRedBall.Math.MathFunctions.RoundToInt(ForegroundSpriteRedFirstValue* (1 - interpolationValue) + ForegroundSpriteRedSecondValue * interpolationValue);
                }
                if (setForegroundSpriteTextureHeightFirstValue && setForegroundSpriteTextureHeightSecondValue)
                {
                    ForegroundSprite.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(ForegroundSpriteTextureHeightFirstValue* (1 - interpolationValue) + ForegroundSpriteTextureHeightSecondValue * interpolationValue);
                }
                if (setForegroundSpriteTextureHeightScaleFirstValue && setForegroundSpriteTextureHeightScaleSecondValue)
                {
                    ForegroundSprite.TextureHeightScale = ForegroundSpriteTextureHeightScaleFirstValue * (1 - interpolationValue) + ForegroundSpriteTextureHeightScaleSecondValue * interpolationValue;
                }
                if (setForegroundSpriteTextureLeftFirstValue && setForegroundSpriteTextureLeftSecondValue)
                {
                    ForegroundSprite.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(ForegroundSpriteTextureLeftFirstValue* (1 - interpolationValue) + ForegroundSpriteTextureLeftSecondValue * interpolationValue);
                }
                if (setForegroundSpriteTextureTopFirstValue && setForegroundSpriteTextureTopSecondValue)
                {
                    ForegroundSprite.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(ForegroundSpriteTextureTopFirstValue* (1 - interpolationValue) + ForegroundSpriteTextureTopSecondValue * interpolationValue);
                }
                if (setForegroundSpriteTextureWidthFirstValue && setForegroundSpriteTextureWidthSecondValue)
                {
                    ForegroundSprite.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(ForegroundSpriteTextureWidthFirstValue* (1 - interpolationValue) + ForegroundSpriteTextureWidthSecondValue * interpolationValue);
                }
                if (setForegroundSpriteTextureWidthScaleFirstValue && setForegroundSpriteTextureWidthScaleSecondValue)
                {
                    ForegroundSprite.TextureWidthScale = ForegroundSpriteTextureWidthScaleFirstValue * (1 - interpolationValue) + ForegroundSpriteTextureWidthScaleSecondValue * interpolationValue;
                }
                if (setForegroundSpriteXFirstValue && setForegroundSpriteXSecondValue)
                {
                    ForegroundSprite.X = ForegroundSpriteXFirstValue * (1 - interpolationValue) + ForegroundSpriteXSecondValue * interpolationValue;
                }
                if (setForegroundSpriteYFirstValue && setForegroundSpriteYSecondValue)
                {
                    ForegroundSprite.Y = ForegroundSpriteYFirstValue * (1 - interpolationValue) + ForegroundSpriteYSecondValue * interpolationValue;
                }
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
                }
                if (setMoonSpriteHeightFirstValue && setMoonSpriteHeightSecondValue)
                {
                    MoonSprite.Height = MoonSpriteHeightFirstValue * (1 - interpolationValue) + MoonSpriteHeightSecondValue * interpolationValue;
                }
                if (setMoonSpriteTextureHeightFirstValue && setMoonSpriteTextureHeightSecondValue)
                {
                    MoonSprite.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(MoonSpriteTextureHeightFirstValue* (1 - interpolationValue) + MoonSpriteTextureHeightSecondValue * interpolationValue);
                }
                if (setMoonSpriteTextureLeftFirstValue && setMoonSpriteTextureLeftSecondValue)
                {
                    MoonSprite.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(MoonSpriteTextureLeftFirstValue* (1 - interpolationValue) + MoonSpriteTextureLeftSecondValue * interpolationValue);
                }
                if (setMoonSpriteTextureTopFirstValue && setMoonSpriteTextureTopSecondValue)
                {
                    MoonSprite.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(MoonSpriteTextureTopFirstValue* (1 - interpolationValue) + MoonSpriteTextureTopSecondValue * interpolationValue);
                }
                if (setMoonSpriteTextureWidthFirstValue && setMoonSpriteTextureWidthSecondValue)
                {
                    MoonSprite.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(MoonSpriteTextureWidthFirstValue* (1 - interpolationValue) + MoonSpriteTextureWidthSecondValue * interpolationValue);
                }
                if (setMoonSpriteWidthFirstValue && setMoonSpriteWidthSecondValue)
                {
                    MoonSprite.Width = MoonSpriteWidthFirstValue * (1 - interpolationValue) + MoonSpriteWidthSecondValue * interpolationValue;
                }
                if (setSkyHazeSpriteAlphaFirstValue && setSkyHazeSpriteAlphaSecondValue)
                {
                    SkyHazeSprite.Alpha = FlatRedBall.Math.MathFunctions.RoundToInt(SkyHazeSpriteAlphaFirstValue* (1 - interpolationValue) + SkyHazeSpriteAlphaSecondValue * interpolationValue);
                }
                if (setSkyHazeSpriteTextureHeightFirstValue && setSkyHazeSpriteTextureHeightSecondValue)
                {
                    SkyHazeSprite.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(SkyHazeSpriteTextureHeightFirstValue* (1 - interpolationValue) + SkyHazeSpriteTextureHeightSecondValue * interpolationValue);
                }
                if (setSkyHazeSpriteTextureLeftFirstValue && setSkyHazeSpriteTextureLeftSecondValue)
                {
                    SkyHazeSprite.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(SkyHazeSpriteTextureLeftFirstValue* (1 - interpolationValue) + SkyHazeSpriteTextureLeftSecondValue * interpolationValue);
                }
                if (setSkyHazeSpriteTextureTopFirstValue && setSkyHazeSpriteTextureTopSecondValue)
                {
                    SkyHazeSprite.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(SkyHazeSpriteTextureTopFirstValue* (1 - interpolationValue) + SkyHazeSpriteTextureTopSecondValue * interpolationValue);
                }
                if (setSkyHazeSpriteTextureWidthFirstValue && setSkyHazeSpriteTextureWidthSecondValue)
                {
                    SkyHazeSprite.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(SkyHazeSpriteTextureWidthFirstValue* (1 - interpolationValue) + SkyHazeSpriteTextureWidthSecondValue * interpolationValue);
                }
                if (setSkyRectangleAlphaFirstValue && setSkyRectangleAlphaSecondValue)
                {
                    SkyRectangle.Alpha = FlatRedBall.Math.MathFunctions.RoundToInt(SkyRectangleAlphaFirstValue* (1 - interpolationValue) + SkyRectangleAlphaSecondValue * interpolationValue);
                }
                if (setSkyRectangleBlueFirstValue && setSkyRectangleBlueSecondValue)
                {
                    SkyRectangle.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(SkyRectangleBlueFirstValue* (1 - interpolationValue) + SkyRectangleBlueSecondValue * interpolationValue);
                }
                if (setSkyRectangleGreenFirstValue && setSkyRectangleGreenSecondValue)
                {
                    SkyRectangle.Green = FlatRedBall.Math.MathFunctions.RoundToInt(SkyRectangleGreenFirstValue* (1 - interpolationValue) + SkyRectangleGreenSecondValue * interpolationValue);
                }
                if (setSkyRectangleHeightFirstValue && setSkyRectangleHeightSecondValue)
                {
                    SkyRectangle.Height = SkyRectangleHeightFirstValue * (1 - interpolationValue) + SkyRectangleHeightSecondValue * interpolationValue;
                }
                if (setSkyRectangleRedFirstValue && setSkyRectangleRedSecondValue)
                {
                    SkyRectangle.Red = FlatRedBall.Math.MathFunctions.RoundToInt(SkyRectangleRedFirstValue* (1 - interpolationValue) + SkyRectangleRedSecondValue * interpolationValue);
                }
                if (setSkyRectangleWidthFirstValue && setSkyRectangleWidthSecondValue)
                {
                    SkyRectangle.Width = SkyRectangleWidthFirstValue * (1 - interpolationValue) + SkyRectangleWidthSecondValue * interpolationValue;
                }
                if (setSkyRectangleXFirstValue && setSkyRectangleXSecondValue)
                {
                    SkyRectangle.X = SkyRectangleXFirstValue * (1 - interpolationValue) + SkyRectangleXSecondValue * interpolationValue;
                }
                if (setSkyRectangleYFirstValue && setSkyRectangleYSecondValue)
                {
                    SkyRectangle.Y = SkyRectangleYFirstValue * (1 - interpolationValue) + SkyRectangleYSecondValue * interpolationValue;
                }
                if (setStarContainerHeightFirstValue && setStarContainerHeightSecondValue)
                {
                    StarContainer.Height = StarContainerHeightFirstValue * (1 - interpolationValue) + StarContainerHeightSecondValue * interpolationValue;
                }
                if (setStarContainerWidthFirstValue && setStarContainerWidthSecondValue)
                {
                    StarContainer.Width = StarContainerWidthFirstValue * (1 - interpolationValue) + StarContainerWidthSecondValue * interpolationValue;
                }
                if (setStarContainerXFirstValue && setStarContainerXSecondValue)
                {
                    StarContainer.X = StarContainerXFirstValue * (1 - interpolationValue) + StarContainerXSecondValue * interpolationValue;
                }
                if (setStarrySkySpriteRotationFirstValue && setStarrySkySpriteRotationSecondValue)
                {
                    StarrySkySprite.Rotation = StarrySkySpriteRotationFirstValue * (1 - interpolationValue) + StarrySkySpriteRotationSecondValue * interpolationValue;
                }
                if (setStarrySkySpriteXFirstValue && setStarrySkySpriteXSecondValue)
                {
                    StarrySkySprite.X = StarrySkySpriteXFirstValue * (1 - interpolationValue) + StarrySkySpriteXSecondValue * interpolationValue;
                }
                if (setStarrySkySpriteYFirstValue && setStarrySkySpriteYSecondValue)
                {
                    StarrySkySprite.Y = StarrySkySpriteYFirstValue * (1 - interpolationValue) + StarrySkySpriteYSecondValue * interpolationValue;
                }
                if (setSunMoonContainerHeightFirstValue && setSunMoonContainerHeightSecondValue)
                {
                    SunMoonContainer.Height = SunMoonContainerHeightFirstValue * (1 - interpolationValue) + SunMoonContainerHeightSecondValue * interpolationValue;
                }
                if (setSunMoonContainerWidthFirstValue && setSunMoonContainerWidthSecondValue)
                {
                    SunMoonContainer.Width = SunMoonContainerWidthFirstValue * (1 - interpolationValue) + SunMoonContainerWidthSecondValue * interpolationValue;
                }
                if (setSunSpriteHeightFirstValue && setSunSpriteHeightSecondValue)
                {
                    SunSprite.Height = SunSpriteHeightFirstValue * (1 - interpolationValue) + SunSpriteHeightSecondValue * interpolationValue;
                }
                if (setSunSpriteTextureHeightFirstValue && setSunSpriteTextureHeightSecondValue)
                {
                    SunSprite.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(SunSpriteTextureHeightFirstValue* (1 - interpolationValue) + SunSpriteTextureHeightSecondValue * interpolationValue);
                }
                if (setSunSpriteTextureLeftFirstValue && setSunSpriteTextureLeftSecondValue)
                {
                    SunSprite.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(SunSpriteTextureLeftFirstValue* (1 - interpolationValue) + SunSpriteTextureLeftSecondValue * interpolationValue);
                }
                if (setSunSpriteTextureTopFirstValue && setSunSpriteTextureTopSecondValue)
                {
                    SunSprite.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(SunSpriteTextureTopFirstValue* (1 - interpolationValue) + SunSpriteTextureTopSecondValue * interpolationValue);
                }
                if (setSunSpriteTextureWidthFirstValue && setSunSpriteTextureWidthSecondValue)
                {
                    SunSprite.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(SunSpriteTextureWidthFirstValue* (1 - interpolationValue) + SunSpriteTextureWidthSecondValue * interpolationValue);
                }
                if (setSunSpriteWidthFirstValue && setSunSpriteWidthSecondValue)
                {
                    SunSprite.Width = SunSpriteWidthFirstValue * (1 - interpolationValue) + SunSpriteWidthSecondValue * interpolationValue;
                }
                if (setSunSpriteYFirstValue && setSunSpriteYSecondValue)
                {
                    SunSprite.Y = SunSpriteYFirstValue * (1 - interpolationValue) + SunSpriteYSecondValue * interpolationValue;
                }
                if (setVisibleHorizonContainerHeightFirstValue && setVisibleHorizonContainerHeightSecondValue)
                {
                    VisibleHorizonContainer.Height = VisibleHorizonContainerHeightFirstValue * (1 - interpolationValue) + VisibleHorizonContainerHeightSecondValue * interpolationValue;
                }
                if (setVisibleHorizonContainerWidthFirstValue && setVisibleHorizonContainerWidthSecondValue)
                {
                    VisibleHorizonContainer.Width = VisibleHorizonContainerWidthFirstValue * (1 - interpolationValue) + VisibleHorizonContainerWidthSecondValue * interpolationValue;
                }
                if (setWidthFirstValue && setWidthSecondValue)
                {
                    Width = WidthFirstValue * (1 - interpolationValue) + WidthSecondValue * interpolationValue;
                }
                if (setYFirstValue && setYSecondValue)
                {
                    Y = YFirstValue * (1 - interpolationValue) + YSecondValue * interpolationValue;
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
            public void InterpolateBetween (Scenery firstState, Scenery secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                switch(firstState)
                {
                    case  Scenery.Swamp:
                        if (interpolationValue < 1)
                        {
                            SetProperty("CloudCoverSprite.SourceFile", "Mangrove.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.CloudCoverSprite.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("ForegroundSprite.SourceFile", "../Screens/GameScreen/Backgrounds/BGswamp.png");
                        }
                        break;
                    case  Scenery.DeadTrees:
                        if (interpolationValue < 1)
                        {
                            SetProperty("CloudCoverSprite.SourceFile", "Mangrove.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.CloudCoverSprite.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("ForegroundSprite.SourceFile", "../Screens/GameScreen/Backgrounds/BGDeadtrees.png");
                        }
                        break;
                    case  Scenery.ForestedHills:
                        if (interpolationValue < 1)
                        {
                            SetProperty("CloudCoverSprite.SourceFile", "Mangrove.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.CloudCoverSprite.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("ForegroundSprite.SourceFile", "../Screens/GameScreen/Backgrounds/BGforesthills.png");
                        }
                        break;
                    case  Scenery.RedMountains:
                        if (interpolationValue < 1)
                        {
                            SetProperty("CloudCoverSprite.SourceFile", "../Screens/GameScreen/Backgrounds/BGmountains-clouds.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.CloudCoverSprite.Visible = true;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("ForegroundSprite.SourceFile", "../Screens/GameScreen/Backgrounds/BGmountains.png");
                        }
                        break;
                    case  Scenery.Plains:
                        if (interpolationValue < 1)
                        {
                            SetProperty("CloudCoverSprite.SourceFile", "Mangrove.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.CloudCoverSprite.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("ForegroundSprite.SourceFile", "../Screens/GameScreen/Backgrounds/BGPlains.png");
                        }
                        break;
                    case  Scenery.SparseTrees:
                        if (interpolationValue < 1)
                        {
                            SetProperty("CloudCoverSprite.SourceFile", "Mangrove.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.CloudCoverSprite.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("ForegroundSprite.SourceFile", "../Screens/GameScreen/Backgrounds/BGTreeplains.png");
                        }
                        break;
                }
                switch(secondState)
                {
                    case  Scenery.Swamp:
                        if (interpolationValue >= 1)
                        {
                            SetProperty("CloudCoverSprite.SourceFile", "Mangrove.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CloudCoverSprite.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("ForegroundSprite.SourceFile", "../Screens/GameScreen/Backgrounds/BGswamp.png");
                        }
                        break;
                    case  Scenery.DeadTrees:
                        if (interpolationValue >= 1)
                        {
                            SetProperty("CloudCoverSprite.SourceFile", "Mangrove.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CloudCoverSprite.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("ForegroundSprite.SourceFile", "../Screens/GameScreen/Backgrounds/BGDeadtrees.png");
                        }
                        break;
                    case  Scenery.ForestedHills:
                        if (interpolationValue >= 1)
                        {
                            SetProperty("CloudCoverSprite.SourceFile", "Mangrove.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CloudCoverSprite.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("ForegroundSprite.SourceFile", "../Screens/GameScreen/Backgrounds/BGforesthills.png");
                        }
                        break;
                    case  Scenery.RedMountains:
                        if (interpolationValue >= 1)
                        {
                            SetProperty("CloudCoverSprite.SourceFile", "../Screens/GameScreen/Backgrounds/BGmountains-clouds.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CloudCoverSprite.Visible = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("ForegroundSprite.SourceFile", "../Screens/GameScreen/Backgrounds/BGmountains.png");
                        }
                        break;
                    case  Scenery.Plains:
                        if (interpolationValue >= 1)
                        {
                            SetProperty("CloudCoverSprite.SourceFile", "Mangrove.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CloudCoverSprite.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("ForegroundSprite.SourceFile", "../Screens/GameScreen/Backgrounds/BGPlains.png");
                        }
                        break;
                    case  Scenery.SparseTrees:
                        if (interpolationValue >= 1)
                        {
                            SetProperty("CloudCoverSprite.SourceFile", "Mangrove.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CloudCoverSprite.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("ForegroundSprite.SourceFile", "../Screens/GameScreen/Backgrounds/BGTreeplains.png");
                        }
                        break;
                }
                if (interpolationValue < 1)
                {
                    mCurrentSceneryState = firstState;
                }
                else
                {
                    mCurrentSceneryState = secondState;
                }
            }
            public void InterpolateBetween (CloudCover firstState, CloudCover secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setCloudCoverSpriteWidthFirstValue = false;
                bool setCloudCoverSpriteWidthSecondValue = false;
                float CloudCoverSpriteWidthFirstValue= 0;
                float CloudCoverSpriteWidthSecondValue= 0;
                bool setCloudCoverSpriteXFirstValue = false;
                bool setCloudCoverSpriteXSecondValue = false;
                float CloudCoverSpriteXFirstValue= 0;
                float CloudCoverSpriteXSecondValue= 0;
                switch(firstState)
                {
                    case  CloudCover.CloudStart:
                        setCloudCoverSpriteWidthFirstValue = true;
                        CloudCoverSpriteWidthFirstValue = 150f;
                        setCloudCoverSpriteXFirstValue = true;
                        CloudCoverSpriteXFirstValue = 0f;
                        break;
                    case  CloudCover.CloudEnd:
                        setCloudCoverSpriteWidthFirstValue = true;
                        CloudCoverSpriteWidthFirstValue = 150f;
                        setCloudCoverSpriteXFirstValue = true;
                        CloudCoverSpriteXFirstValue = -512f;
                        break;
                }
                switch(secondState)
                {
                    case  CloudCover.CloudStart:
                        setCloudCoverSpriteWidthSecondValue = true;
                        CloudCoverSpriteWidthSecondValue = 150f;
                        setCloudCoverSpriteXSecondValue = true;
                        CloudCoverSpriteXSecondValue = 0f;
                        break;
                    case  CloudCover.CloudEnd:
                        setCloudCoverSpriteWidthSecondValue = true;
                        CloudCoverSpriteWidthSecondValue = 150f;
                        setCloudCoverSpriteXSecondValue = true;
                        CloudCoverSpriteXSecondValue = -512f;
                        break;
                }
                if (setCloudCoverSpriteWidthFirstValue && setCloudCoverSpriteWidthSecondValue)
                {
                    CloudCoverSprite.Width = CloudCoverSpriteWidthFirstValue * (1 - interpolationValue) + CloudCoverSpriteWidthSecondValue * interpolationValue;
                }
                if (setCloudCoverSpriteXFirstValue && setCloudCoverSpriteXSecondValue)
                {
                    CloudCoverSprite.X = CloudCoverSpriteXFirstValue * (1 - interpolationValue) + CloudCoverSpriteXSecondValue * interpolationValue;
                }
                if (interpolationValue < 1)
                {
                    mCurrentCloudCoverState = firstState;
                }
                else
                {
                    mCurrentCloudCoverState = secondState;
                }
            }
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.HorizonBoxRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.HorizonBoxRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.HorizonBoxRuntime.Scenery fromState,AbbatoirIntergrade.GumRuntimes.HorizonBoxRuntime.Scenery toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Scenery toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "Scenery").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentSceneryState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (Scenery toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentSceneryState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.HorizonBoxRuntime.CloudCover fromState,AbbatoirIntergrade.GumRuntimes.HorizonBoxRuntime.CloudCover toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (CloudCover toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "CloudCover").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentCloudCoverState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (CloudCover toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentCloudCoverState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            #endregion
            #region State Animations
            private System.Collections.Generic.IEnumerable<FlatRedBall.Instructions.Instruction> MoveStaticCloudsAnimationInstructions (object target) 
            {
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction( ()=> this.CurrentCloudCoverState = CloudCover.CloudStart);
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime;
                    toReturn.Target = target;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(CloudCover.CloudEnd, 10, FlatRedBall.Glue.StateInterpolation.InterpolationType.Linear, FlatRedBall.Glue.StateInterpolation.Easing.Out, MoveStaticCloudsAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => FlatRedBall.Instructions.InstructionManager.Instructions.AddRange(this.MoveStaticCloudsAnimationInstructions(target)));
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 10;
                    toReturn.Target = target;
                    yield return toReturn;
                }
            }
            private System.Collections.Generic.IEnumerable<FlatRedBall.Instructions.Instruction> MoveStaticCloudsAnimationRelativeInstructions (object target) 
            {
                {
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(() =>
                    {
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "CloudCover/CloudStart").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "CloudCover/CloudEnd").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(CloudCover.CloudEnd);
                        Gum.DataTypes.Variables.StateSave second = first.Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.AddIntoThis(second, difference);
                        FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: 10, type: FlatRedBall.Glue.StateInterpolation.InterpolationType.Linear, easing: FlatRedBall.Glue.StateInterpolation.Easing.Out);
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
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => FlatRedBall.Instructions.InstructionManager.Instructions.AddRange(this.MoveStaticCloudsAnimationRelativeInstructions(target)));
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 10;
                    toReturn.Target = target;
                    yield return toReturn;
                }
            }
            private FlatRedBall.Gum.Animation.GumAnimation moveStaticCloudsAnimation;
            public FlatRedBall.Gum.Animation.GumAnimation MoveStaticCloudsAnimation
            {
                get
                {
                    if (moveStaticCloudsAnimation == null)
                    {
                        moveStaticCloudsAnimation = new FlatRedBall.Gum.Animation.GumAnimation(10, MoveStaticCloudsAnimationInstructions);
                    }
                    return moveStaticCloudsAnimation;
                }
            }
            private FlatRedBall.Gum.Animation.GumAnimation moveStaticCloudsAnimationRelative;
            public FlatRedBall.Gum.Animation.GumAnimation MoveStaticCloudsAnimationRelative
            {
                get
                {
                    if (moveStaticCloudsAnimationRelative == null)
                    {
                        moveStaticCloudsAnimationRelative = new FlatRedBall.Gum.Animation.GumAnimation(10, MoveStaticCloudsAnimationRelativeInstructions);
                    }
                    return moveStaticCloudsAnimationRelative;
                }
            }
            #endregion
            public override void StopAnimations () 
            {
                base.StopAnimations();
                MoveStaticCloudsAnimation.Stop();
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
                            Name = "Y",
                            Type = "float",
                            Value = Y
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
                            Name = "StarContainer.Height",
                            Type = "float",
                            Value = StarContainer.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StarContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = StarContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StarContainer.Parent",
                            Type = "string",
                            Value = StarContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StarContainer.Width",
                            Type = "float",
                            Value = StarContainer.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StarContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = StarContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StarContainer.X",
                            Type = "float",
                            Value = StarContainer.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StarContainer.X Origin",
                            Type = "HorizontalAlignment",
                            Value = StarContainer.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StarContainer.X Units",
                            Type = "PositionUnitType",
                            Value = StarContainer.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StarContainer.Y Origin",
                            Type = "VerticalAlignment",
                            Value = StarContainer.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkyRectangle.Alpha",
                            Type = "int",
                            Value = SkyRectangle.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkyRectangle.Blue",
                            Type = "int",
                            Value = SkyRectangle.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkyRectangle.Green",
                            Type = "int",
                            Value = SkyRectangle.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkyRectangle.Height",
                            Type = "float",
                            Value = SkyRectangle.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkyRectangle.Height Units",
                            Type = "DimensionUnitType",
                            Value = SkyRectangle.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkyRectangle.Parent",
                            Type = "string",
                            Value = SkyRectangle.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkyRectangle.Red",
                            Type = "int",
                            Value = SkyRectangle.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkyRectangle.Visible",
                            Type = "bool",
                            Value = SkyRectangle.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkyRectangle.Width",
                            Type = "float",
                            Value = SkyRectangle.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkyRectangle.Width Units",
                            Type = "DimensionUnitType",
                            Value = SkyRectangle.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkyRectangle.X",
                            Type = "float",
                            Value = SkyRectangle.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkyRectangle.Y",
                            Type = "float",
                            Value = SkyRectangle.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SunMoonContainer.Height",
                            Type = "float",
                            Value = SunMoonContainer.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SunMoonContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = SunMoonContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SunMoonContainer.Parent",
                            Type = "string",
                            Value = SunMoonContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SunMoonContainer.Width",
                            Type = "float",
                            Value = SunMoonContainer.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SunMoonContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = SunMoonContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VisibleHorizonContainer.Clips Children",
                            Type = "bool",
                            Value = VisibleHorizonContainer.ClipsChildren
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VisibleHorizonContainer.Height",
                            Type = "float",
                            Value = VisibleHorizonContainer.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VisibleHorizonContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = VisibleHorizonContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VisibleHorizonContainer.Width",
                            Type = "float",
                            Value = VisibleHorizonContainer.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VisibleHorizonContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = VisibleHorizonContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StarrySkySprite.Animate",
                            Type = "bool",
                            Value = StarrySkySprite.Animate
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StarrySkySprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = StarrySkySprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StarrySkySprite.Parent",
                            Type = "string",
                            Value = StarrySkySprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StarrySkySprite.Rotation",
                            Type = "float",
                            Value = StarrySkySprite.Rotation
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StarrySkySprite.SourceFile",
                            Type = "string",
                            Value = StarrySkySprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StarrySkySprite.Visible",
                            Type = "bool",
                            Value = StarrySkySprite.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StarrySkySprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = StarrySkySprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StarrySkySprite.X",
                            Type = "float",
                            Value = StarrySkySprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StarrySkySprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = StarrySkySprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StarrySkySprite.X Units",
                            Type = "PositionUnitType",
                            Value = StarrySkySprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StarrySkySprite.Y",
                            Type = "float",
                            Value = StarrySkySprite.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StarrySkySprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = StarrySkySprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StarrySkySprite.Y Units",
                            Type = "PositionUnitType",
                            Value = StarrySkySprite.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SunSprite.Height",
                            Type = "float",
                            Value = SunSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SunSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = SunSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SunSprite.Parent",
                            Type = "string",
                            Value = SunSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SunSprite.SourceFile",
                            Type = "string",
                            Value = SunSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SunSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = SunSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SunSprite.Texture Height",
                            Type = "int",
                            Value = SunSprite.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SunSprite.Texture Left",
                            Type = "int",
                            Value = SunSprite.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SunSprite.Texture Top",
                            Type = "int",
                            Value = SunSprite.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SunSprite.Texture Width",
                            Type = "int",
                            Value = SunSprite.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SunSprite.Visible",
                            Type = "bool",
                            Value = SunSprite.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SunSprite.Width",
                            Type = "float",
                            Value = SunSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SunSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = SunSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SunSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = SunSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SunSprite.X Units",
                            Type = "PositionUnitType",
                            Value = SunSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SunSprite.Y",
                            Type = "float",
                            Value = SunSprite.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SunSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = SunSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SunSprite.Y Units",
                            Type = "PositionUnitType",
                            Value = SunSprite.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MoonSprite.Height",
                            Type = "float",
                            Value = MoonSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MoonSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = MoonSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MoonSprite.Parent",
                            Type = "string",
                            Value = MoonSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MoonSprite.SourceFile",
                            Type = "string",
                            Value = MoonSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MoonSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = MoonSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MoonSprite.Texture Height",
                            Type = "int",
                            Value = MoonSprite.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MoonSprite.Texture Left",
                            Type = "int",
                            Value = MoonSprite.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MoonSprite.Texture Top",
                            Type = "int",
                            Value = MoonSprite.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MoonSprite.Texture Width",
                            Type = "int",
                            Value = MoonSprite.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MoonSprite.Visible",
                            Type = "bool",
                            Value = MoonSprite.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MoonSprite.Width",
                            Type = "float",
                            Value = MoonSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MoonSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = MoonSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MoonSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = MoonSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MoonSprite.X Units",
                            Type = "PositionUnitType",
                            Value = MoonSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MoonSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = MoonSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MoonSprite.Y Units",
                            Type = "PositionUnitType",
                            Value = MoonSprite.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkyHazeSprite.Alpha",
                            Type = "int",
                            Value = SkyHazeSprite.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkyHazeSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = SkyHazeSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkyHazeSprite.Parent",
                            Type = "string",
                            Value = SkyHazeSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkyHazeSprite.SourceFile",
                            Type = "string",
                            Value = SkyHazeSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkyHazeSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = SkyHazeSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkyHazeSprite.Texture Height",
                            Type = "int",
                            Value = SkyHazeSprite.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkyHazeSprite.Texture Left",
                            Type = "int",
                            Value = SkyHazeSprite.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkyHazeSprite.Texture Top",
                            Type = "int",
                            Value = SkyHazeSprite.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkyHazeSprite.Texture Width",
                            Type = "int",
                            Value = SkyHazeSprite.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkyHazeSprite.Visible",
                            Type = "bool",
                            Value = SkyHazeSprite.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkyHazeSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = SkyHazeSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DawnDuskSprite.Blue",
                            Type = "int",
                            Value = DawnDuskSprite.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DawnDuskSprite.FlipHorizontal",
                            Type = "bool",
                            Value = DawnDuskSprite.FlipHorizontal
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DawnDuskSprite.FlipVertical",
                            Type = "bool",
                            Value = DawnDuskSprite.FlipVertical
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DawnDuskSprite.Green",
                            Type = "int",
                            Value = DawnDuskSprite.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DawnDuskSprite.Height",
                            Type = "float",
                            Value = DawnDuskSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DawnDuskSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = DawnDuskSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DawnDuskSprite.Parent",
                            Type = "string",
                            Value = DawnDuskSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DawnDuskSprite.Red",
                            Type = "int",
                            Value = DawnDuskSprite.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DawnDuskSprite.Rotation",
                            Type = "float",
                            Value = DawnDuskSprite.Rotation
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DawnDuskSprite.SourceFile",
                            Type = "string",
                            Value = DawnDuskSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DawnDuskSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = DawnDuskSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DawnDuskSprite.Texture Height",
                            Type = "int",
                            Value = DawnDuskSprite.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DawnDuskSprite.Texture Left",
                            Type = "int",
                            Value = DawnDuskSprite.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DawnDuskSprite.Texture Top",
                            Type = "int",
                            Value = DawnDuskSprite.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DawnDuskSprite.Texture Width",
                            Type = "int",
                            Value = DawnDuskSprite.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DawnDuskSprite.Visible",
                            Type = "bool",
                            Value = DawnDuskSprite.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DawnDuskSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = DawnDuskSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DawnDuskSprite.Wrap",
                            Type = "bool",
                            Value = DawnDuskSprite.Wrap
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DawnDuskSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = DawnDuskSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DawnDuskSprite.Y Units",
                            Type = "PositionUnitType",
                            Value = DawnDuskSprite.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.Alpha",
                            Type = "int",
                            Value = CloudCoverSprite.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.Animate",
                            Type = "bool",
                            Value = CloudCoverSprite.Animate
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.Blue",
                            Type = "int",
                            Value = CloudCoverSprite.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.Green",
                            Type = "int",
                            Value = CloudCoverSprite.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.Height",
                            Type = "float",
                            Value = CloudCoverSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = CloudCoverSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.Red",
                            Type = "int",
                            Value = CloudCoverSprite.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.SourceFile",
                            Type = "string",
                            Value = CloudCoverSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = CloudCoverSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.Texture Height",
                            Type = "int",
                            Value = CloudCoverSprite.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.Texture Height Scale",
                            Type = "float",
                            Value = CloudCoverSprite.TextureHeightScale
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.Texture Left",
                            Type = "int",
                            Value = CloudCoverSprite.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.Texture Top",
                            Type = "int",
                            Value = CloudCoverSprite.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.Texture Width",
                            Type = "int",
                            Value = CloudCoverSprite.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.Texture Width Scale",
                            Type = "float",
                            Value = CloudCoverSprite.TextureWidthScale
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.Visible",
                            Type = "bool",
                            Value = CloudCoverSprite.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = CloudCoverSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.Wrap",
                            Type = "bool",
                            Value = CloudCoverSprite.Wrap
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.X",
                            Type = "float",
                            Value = CloudCoverSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.Y",
                            Type = "float",
                            Value = CloudCoverSprite.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForegroundSprite.Animate",
                            Type = "bool",
                            Value = ForegroundSprite.Animate
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForegroundSprite.Blue",
                            Type = "int",
                            Value = ForegroundSprite.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForegroundSprite.Green",
                            Type = "int",
                            Value = ForegroundSprite.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForegroundSprite.Height",
                            Type = "float",
                            Value = ForegroundSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForegroundSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = ForegroundSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForegroundSprite.Red",
                            Type = "int",
                            Value = ForegroundSprite.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForegroundSprite.SourceFile",
                            Type = "string",
                            Value = ForegroundSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForegroundSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = ForegroundSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForegroundSprite.Texture Height",
                            Type = "int",
                            Value = ForegroundSprite.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForegroundSprite.Texture Height Scale",
                            Type = "float",
                            Value = ForegroundSprite.TextureHeightScale
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForegroundSprite.Texture Left",
                            Type = "int",
                            Value = ForegroundSprite.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForegroundSprite.Texture Top",
                            Type = "int",
                            Value = ForegroundSprite.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForegroundSprite.Texture Width",
                            Type = "int",
                            Value = ForegroundSprite.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForegroundSprite.Texture Width Scale",
                            Type = "float",
                            Value = ForegroundSprite.TextureWidthScale
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForegroundSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = ForegroundSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForegroundSprite.Wrap",
                            Type = "bool",
                            Value = ForegroundSprite.Wrap
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForegroundSprite.X",
                            Type = "float",
                            Value = ForegroundSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForegroundSprite.Y",
                            Type = "float",
                            Value = ForegroundSprite.Y
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
                            Name = "Y",
                            Type = "float",
                            Value = Y + 0f
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
                            Name = "StarContainer.Height",
                            Type = "float",
                            Value = StarContainer.Height + 1000f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StarContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = StarContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StarContainer.Parent",
                            Type = "string",
                            Value = StarContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StarContainer.Width",
                            Type = "float",
                            Value = StarContainer.Width + 112.5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StarContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = StarContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StarContainer.X",
                            Type = "float",
                            Value = StarContainer.X + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StarContainer.X Origin",
                            Type = "HorizontalAlignment",
                            Value = StarContainer.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StarContainer.X Units",
                            Type = "PositionUnitType",
                            Value = StarContainer.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StarContainer.Y Origin",
                            Type = "VerticalAlignment",
                            Value = StarContainer.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkyRectangle.Alpha",
                            Type = "int",
                            Value = SkyRectangle.Alpha + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkyRectangle.Blue",
                            Type = "int",
                            Value = SkyRectangle.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkyRectangle.Green",
                            Type = "int",
                            Value = SkyRectangle.Green + 222
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkyRectangle.Height",
                            Type = "float",
                            Value = SkyRectangle.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkyRectangle.Height Units",
                            Type = "DimensionUnitType",
                            Value = SkyRectangle.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkyRectangle.Parent",
                            Type = "string",
                            Value = SkyRectangle.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkyRectangle.Red",
                            Type = "int",
                            Value = SkyRectangle.Red + 152
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkyRectangle.Visible",
                            Type = "bool",
                            Value = SkyRectangle.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkyRectangle.Width",
                            Type = "float",
                            Value = SkyRectangle.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkyRectangle.Width Units",
                            Type = "DimensionUnitType",
                            Value = SkyRectangle.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkyRectangle.X",
                            Type = "float",
                            Value = SkyRectangle.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkyRectangle.Y",
                            Type = "float",
                            Value = SkyRectangle.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SunMoonContainer.Height",
                            Type = "float",
                            Value = SunMoonContainer.Height + 200f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SunMoonContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = SunMoonContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SunMoonContainer.Parent",
                            Type = "string",
                            Value = SunMoonContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SunMoonContainer.Width",
                            Type = "float",
                            Value = SunMoonContainer.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SunMoonContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = SunMoonContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VisibleHorizonContainer.Clips Children",
                            Type = "bool",
                            Value = VisibleHorizonContainer.ClipsChildren
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VisibleHorizonContainer.Height",
                            Type = "float",
                            Value = VisibleHorizonContainer.Height + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VisibleHorizonContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = VisibleHorizonContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VisibleHorizonContainer.Width",
                            Type = "float",
                            Value = VisibleHorizonContainer.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VisibleHorizonContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = VisibleHorizonContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StarrySkySprite.Animate",
                            Type = "bool",
                            Value = StarrySkySprite.Animate
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StarrySkySprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = StarrySkySprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StarrySkySprite.Parent",
                            Type = "string",
                            Value = StarrySkySprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StarrySkySprite.Rotation",
                            Type = "float",
                            Value = StarrySkySprite.Rotation + -45f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StarrySkySprite.SourceFile",
                            Type = "string",
                            Value = StarrySkySprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StarrySkySprite.Visible",
                            Type = "bool",
                            Value = StarrySkySprite.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StarrySkySprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = StarrySkySprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StarrySkySprite.X",
                            Type = "float",
                            Value = StarrySkySprite.X + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StarrySkySprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = StarrySkySprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StarrySkySprite.X Units",
                            Type = "PositionUnitType",
                            Value = StarrySkySprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StarrySkySprite.Y",
                            Type = "float",
                            Value = StarrySkySprite.Y + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StarrySkySprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = StarrySkySprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StarrySkySprite.Y Units",
                            Type = "PositionUnitType",
                            Value = StarrySkySprite.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SunSprite.Height",
                            Type = "float",
                            Value = SunSprite.Height + 22.222f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SunSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = SunSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SunSprite.Parent",
                            Type = "string",
                            Value = SunSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SunSprite.SourceFile",
                            Type = "string",
                            Value = SunSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SunSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = SunSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SunSprite.Texture Height",
                            Type = "int",
                            Value = SunSprite.TextureHeight + 256
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SunSprite.Texture Left",
                            Type = "int",
                            Value = SunSprite.TextureLeft + 1792
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SunSprite.Texture Top",
                            Type = "int",
                            Value = SunSprite.TextureTop + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SunSprite.Texture Width",
                            Type = "int",
                            Value = SunSprite.TextureWidth + 256
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SunSprite.Visible",
                            Type = "bool",
                            Value = SunSprite.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SunSprite.Width",
                            Type = "float",
                            Value = SunSprite.Width + 5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SunSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = SunSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SunSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = SunSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SunSprite.X Units",
                            Type = "PositionUnitType",
                            Value = SunSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SunSprite.Y",
                            Type = "float",
                            Value = SunSprite.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SunSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = SunSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SunSprite.Y Units",
                            Type = "PositionUnitType",
                            Value = SunSprite.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MoonSprite.Height",
                            Type = "float",
                            Value = MoonSprite.Height + 13.3332f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MoonSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = MoonSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MoonSprite.Parent",
                            Type = "string",
                            Value = MoonSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MoonSprite.SourceFile",
                            Type = "string",
                            Value = MoonSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MoonSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = MoonSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MoonSprite.Texture Height",
                            Type = "int",
                            Value = MoonSprite.TextureHeight + 256
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MoonSprite.Texture Left",
                            Type = "int",
                            Value = MoonSprite.TextureLeft + 1536
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MoonSprite.Texture Top",
                            Type = "int",
                            Value = MoonSprite.TextureTop + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MoonSprite.Texture Width",
                            Type = "int",
                            Value = MoonSprite.TextureWidth + 256
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MoonSprite.Visible",
                            Type = "bool",
                            Value = MoonSprite.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MoonSprite.Width",
                            Type = "float",
                            Value = MoonSprite.Width + 3f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MoonSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = MoonSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MoonSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = MoonSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MoonSprite.X Units",
                            Type = "PositionUnitType",
                            Value = MoonSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MoonSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = MoonSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MoonSprite.Y Units",
                            Type = "PositionUnitType",
                            Value = MoonSprite.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkyHazeSprite.Alpha",
                            Type = "int",
                            Value = SkyHazeSprite.Alpha + 200
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkyHazeSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = SkyHazeSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkyHazeSprite.Parent",
                            Type = "string",
                            Value = SkyHazeSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkyHazeSprite.SourceFile",
                            Type = "string",
                            Value = SkyHazeSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkyHazeSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = SkyHazeSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkyHazeSprite.Texture Height",
                            Type = "int",
                            Value = SkyHazeSprite.TextureHeight + 144
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkyHazeSprite.Texture Left",
                            Type = "int",
                            Value = SkyHazeSprite.TextureLeft + 2048
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkyHazeSprite.Texture Top",
                            Type = "int",
                            Value = SkyHazeSprite.TextureTop + 256
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkyHazeSprite.Texture Width",
                            Type = "int",
                            Value = SkyHazeSprite.TextureWidth + 1
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkyHazeSprite.Visible",
                            Type = "bool",
                            Value = SkyHazeSprite.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkyHazeSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = SkyHazeSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DawnDuskSprite.Blue",
                            Type = "int",
                            Value = DawnDuskSprite.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DawnDuskSprite.FlipHorizontal",
                            Type = "bool",
                            Value = DawnDuskSprite.FlipHorizontal
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DawnDuskSprite.FlipVertical",
                            Type = "bool",
                            Value = DawnDuskSprite.FlipVertical
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DawnDuskSprite.Green",
                            Type = "int",
                            Value = DawnDuskSprite.Green + 140
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DawnDuskSprite.Height",
                            Type = "float",
                            Value = DawnDuskSprite.Height + 25f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DawnDuskSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = DawnDuskSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DawnDuskSprite.Parent",
                            Type = "string",
                            Value = DawnDuskSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DawnDuskSprite.Red",
                            Type = "int",
                            Value = DawnDuskSprite.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DawnDuskSprite.Rotation",
                            Type = "float",
                            Value = DawnDuskSprite.Rotation + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DawnDuskSprite.SourceFile",
                            Type = "string",
                            Value = DawnDuskSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DawnDuskSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = DawnDuskSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DawnDuskSprite.Texture Height",
                            Type = "int",
                            Value = DawnDuskSprite.TextureHeight + 144
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DawnDuskSprite.Texture Left",
                            Type = "int",
                            Value = DawnDuskSprite.TextureLeft + 2047
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DawnDuskSprite.Texture Top",
                            Type = "int",
                            Value = DawnDuskSprite.TextureTop + 256
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DawnDuskSprite.Texture Width",
                            Type = "int",
                            Value = DawnDuskSprite.TextureWidth + 1
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DawnDuskSprite.Visible",
                            Type = "bool",
                            Value = DawnDuskSprite.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DawnDuskSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = DawnDuskSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DawnDuskSprite.Wrap",
                            Type = "bool",
                            Value = DawnDuskSprite.Wrap
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DawnDuskSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = DawnDuskSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DawnDuskSprite.Y Units",
                            Type = "PositionUnitType",
                            Value = DawnDuskSprite.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.Alpha",
                            Type = "int",
                            Value = CloudCoverSprite.Alpha + 150
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.Animate",
                            Type = "bool",
                            Value = CloudCoverSprite.Animate
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.Blue",
                            Type = "int",
                            Value = CloudCoverSprite.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.Green",
                            Type = "int",
                            Value = CloudCoverSprite.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.Height",
                            Type = "float",
                            Value = CloudCoverSprite.Height + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = CloudCoverSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.Red",
                            Type = "int",
                            Value = CloudCoverSprite.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.SourceFile",
                            Type = "string",
                            Value = CloudCoverSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = CloudCoverSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.Texture Height",
                            Type = "int",
                            Value = CloudCoverSprite.TextureHeight + 288
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.Texture Height Scale",
                            Type = "float",
                            Value = CloudCoverSprite.TextureHeightScale + 1f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.Texture Left",
                            Type = "int",
                            Value = CloudCoverSprite.TextureLeft + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.Texture Top",
                            Type = "int",
                            Value = CloudCoverSprite.TextureTop + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.Texture Width",
                            Type = "int",
                            Value = CloudCoverSprite.TextureWidth + 381
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.Texture Width Scale",
                            Type = "float",
                            Value = CloudCoverSprite.TextureWidthScale + 1f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.Visible",
                            Type = "bool",
                            Value = CloudCoverSprite.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = CloudCoverSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.Wrap",
                            Type = "bool",
                            Value = CloudCoverSprite.Wrap
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.X",
                            Type = "float",
                            Value = CloudCoverSprite.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.Y",
                            Type = "float",
                            Value = CloudCoverSprite.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForegroundSprite.Animate",
                            Type = "bool",
                            Value = ForegroundSprite.Animate
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForegroundSprite.Blue",
                            Type = "int",
                            Value = ForegroundSprite.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForegroundSprite.Green",
                            Type = "int",
                            Value = ForegroundSprite.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForegroundSprite.Height",
                            Type = "float",
                            Value = ForegroundSprite.Height + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForegroundSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = ForegroundSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForegroundSprite.Red",
                            Type = "int",
                            Value = ForegroundSprite.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForegroundSprite.SourceFile",
                            Type = "string",
                            Value = ForegroundSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForegroundSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = ForegroundSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForegroundSprite.Texture Height",
                            Type = "int",
                            Value = ForegroundSprite.TextureHeight + 288
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForegroundSprite.Texture Height Scale",
                            Type = "float",
                            Value = ForegroundSprite.TextureHeightScale + 1f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForegroundSprite.Texture Left",
                            Type = "int",
                            Value = ForegroundSprite.TextureLeft + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForegroundSprite.Texture Top",
                            Type = "int",
                            Value = ForegroundSprite.TextureTop + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForegroundSprite.Texture Width",
                            Type = "int",
                            Value = ForegroundSprite.TextureWidth + 381
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForegroundSprite.Texture Width Scale",
                            Type = "float",
                            Value = ForegroundSprite.TextureWidthScale + 1f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForegroundSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = ForegroundSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForegroundSprite.Wrap",
                            Type = "bool",
                            Value = ForegroundSprite.Wrap
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForegroundSprite.X",
                            Type = "float",
                            Value = ForegroundSprite.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForegroundSprite.Y",
                            Type = "float",
                            Value = ForegroundSprite.Y + 0f
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (Scenery state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  Scenery.Swamp:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.SourceFile",
                            Type = "string",
                            Value = CloudCoverSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.Visible",
                            Type = "bool",
                            Value = CloudCoverSprite.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForegroundSprite.SourceFile",
                            Type = "string",
                            Value = ForegroundSprite.SourceFile
                        }
                        );
                        break;
                    case  Scenery.DeadTrees:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.SourceFile",
                            Type = "string",
                            Value = CloudCoverSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.Visible",
                            Type = "bool",
                            Value = CloudCoverSprite.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForegroundSprite.SourceFile",
                            Type = "string",
                            Value = ForegroundSprite.SourceFile
                        }
                        );
                        break;
                    case  Scenery.ForestedHills:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.SourceFile",
                            Type = "string",
                            Value = CloudCoverSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.Visible",
                            Type = "bool",
                            Value = CloudCoverSprite.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForegroundSprite.SourceFile",
                            Type = "string",
                            Value = ForegroundSprite.SourceFile
                        }
                        );
                        break;
                    case  Scenery.RedMountains:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.SourceFile",
                            Type = "string",
                            Value = CloudCoverSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.Visible",
                            Type = "bool",
                            Value = CloudCoverSprite.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForegroundSprite.SourceFile",
                            Type = "string",
                            Value = ForegroundSprite.SourceFile
                        }
                        );
                        break;
                    case  Scenery.Plains:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.SourceFile",
                            Type = "string",
                            Value = CloudCoverSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.Visible",
                            Type = "bool",
                            Value = CloudCoverSprite.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForegroundSprite.SourceFile",
                            Type = "string",
                            Value = ForegroundSprite.SourceFile
                        }
                        );
                        break;
                    case  Scenery.SparseTrees:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.SourceFile",
                            Type = "string",
                            Value = CloudCoverSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.Visible",
                            Type = "bool",
                            Value = CloudCoverSprite.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForegroundSprite.SourceFile",
                            Type = "string",
                            Value = ForegroundSprite.SourceFile
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (Scenery state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  Scenery.Swamp:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.SourceFile",
                            Type = "string",
                            Value = CloudCoverSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.Visible",
                            Type = "bool",
                            Value = CloudCoverSprite.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForegroundSprite.SourceFile",
                            Type = "string",
                            Value = ForegroundSprite.SourceFile
                        }
                        );
                        break;
                    case  Scenery.DeadTrees:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.SourceFile",
                            Type = "string",
                            Value = CloudCoverSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.Visible",
                            Type = "bool",
                            Value = CloudCoverSprite.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForegroundSprite.SourceFile",
                            Type = "string",
                            Value = ForegroundSprite.SourceFile
                        }
                        );
                        break;
                    case  Scenery.ForestedHills:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.SourceFile",
                            Type = "string",
                            Value = CloudCoverSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.Visible",
                            Type = "bool",
                            Value = CloudCoverSprite.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForegroundSprite.SourceFile",
                            Type = "string",
                            Value = ForegroundSprite.SourceFile
                        }
                        );
                        break;
                    case  Scenery.RedMountains:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.SourceFile",
                            Type = "string",
                            Value = CloudCoverSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.Visible",
                            Type = "bool",
                            Value = CloudCoverSprite.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForegroundSprite.SourceFile",
                            Type = "string",
                            Value = ForegroundSprite.SourceFile
                        }
                        );
                        break;
                    case  Scenery.Plains:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.SourceFile",
                            Type = "string",
                            Value = CloudCoverSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.Visible",
                            Type = "bool",
                            Value = CloudCoverSprite.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForegroundSprite.SourceFile",
                            Type = "string",
                            Value = ForegroundSprite.SourceFile
                        }
                        );
                        break;
                    case  Scenery.SparseTrees:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.SourceFile",
                            Type = "string",
                            Value = CloudCoverSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.Visible",
                            Type = "bool",
                            Value = CloudCoverSprite.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForegroundSprite.SourceFile",
                            Type = "string",
                            Value = ForegroundSprite.SourceFile
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (CloudCover state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  CloudCover.CloudStart:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.Width",
                            Type = "float",
                            Value = CloudCoverSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.X",
                            Type = "float",
                            Value = CloudCoverSprite.X
                        }
                        );
                        break;
                    case  CloudCover.CloudEnd:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.Width",
                            Type = "float",
                            Value = CloudCoverSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.X",
                            Type = "float",
                            Value = CloudCoverSprite.X
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (CloudCover state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  CloudCover.CloudStart:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.Width",
                            Type = "float",
                            Value = CloudCoverSprite.Width + 150f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.X",
                            Type = "float",
                            Value = CloudCoverSprite.X + 0f
                        }
                        );
                        break;
                    case  CloudCover.CloudEnd:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.Width",
                            Type = "float",
                            Value = CloudCoverSprite.Width + 150f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloudCoverSprite.X",
                            Type = "float",
                            Value = CloudCoverSprite.X + -512f
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
                    else if (category.Name == "Scenery")
                    {
                        if(state.Name == "Swamp") this.mCurrentSceneryState = Scenery.Swamp;
                        if(state.Name == "DeadTrees") this.mCurrentSceneryState = Scenery.DeadTrees;
                        if(state.Name == "ForestedHills") this.mCurrentSceneryState = Scenery.ForestedHills;
                        if(state.Name == "RedMountains") this.mCurrentSceneryState = Scenery.RedMountains;
                        if(state.Name == "Plains") this.mCurrentSceneryState = Scenery.Plains;
                        if(state.Name == "SparseTrees") this.mCurrentSceneryState = Scenery.SparseTrees;
                    }
                    else if (category.Name == "CloudCover")
                    {
                        if(state.Name == "CloudStart") this.mCurrentCloudCoverState = CloudCover.CloudStart;
                        if(state.Name == "CloudEnd") this.mCurrentCloudCoverState = CloudCover.CloudEnd;
                    }
                }
                base.ApplyState(state);
            }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime StarContainer { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ColoredRectangleRuntime SkyRectangle { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime SunMoonContainer { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime VisibleHorizonContainer { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime StarrySkySprite { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime SunSprite { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime MoonSprite { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime SkyHazeSprite { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime DawnDuskSprite { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime CloudCoverSprite { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime ForegroundSprite { get; set; }
            public HorizonBoxRuntime (bool fullInstantiation = true) 
            	: base(false)
            {
                this.HasEvents = false;
                this.ExposeChildrenEvents = false;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "HorizonBox");
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
                StarContainer = this.GetGraphicalUiElementByName("StarContainer") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
                SkyRectangle = this.GetGraphicalUiElementByName("SkyRectangle") as AbbatoirIntergrade.GumRuntimes.ColoredRectangleRuntime;
                SunMoonContainer = this.GetGraphicalUiElementByName("SunMoonContainer") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
                VisibleHorizonContainer = this.GetGraphicalUiElementByName("VisibleHorizonContainer") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
                StarrySkySprite = this.GetGraphicalUiElementByName("StarrySkySprite") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                SunSprite = this.GetGraphicalUiElementByName("SunSprite") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                MoonSprite = this.GetGraphicalUiElementByName("MoonSprite") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                SkyHazeSprite = this.GetGraphicalUiElementByName("SkyHazeSprite") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                DawnDuskSprite = this.GetGraphicalUiElementByName("DawnDuskSprite") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                CloudCoverSprite = this.GetGraphicalUiElementByName("CloudCoverSprite") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                ForegroundSprite = this.GetGraphicalUiElementByName("ForegroundSprite") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
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
