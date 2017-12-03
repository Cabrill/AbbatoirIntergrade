    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes
    {
        public partial class ChatOptionFrameRuntime : AbbatoirIntergrade.GumRuntimes.ContainerRuntime
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            public enum FlickerState
            {
                Flicker1,
                Flicker2,
                Flicker3,
                Flicker4,
                Flicker5,
                Flicker6,
                Flicker7,
                Flicker8,
                Flicker9
            }
            public enum ColorState
            {
                Red,
                Green,
                Black,
                Blue
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            FlickerState mCurrentFlickerStateState;
            ColorState mCurrentColorStateState;
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
                            Height = 12.99866f;
                            HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            Visible = true;
                            Width = 8.223843f;
                            WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            WrapsChildren = false;
                            X = -0.1339325f;
                            XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            Y = -0.008815452f;
                            YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                            YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            Middle.Alpha = 255;
                            Middle.Blue = 0;
                            Middle.Green = 30;
                            Middle.Height = -32f;
                            Middle.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            Middle.Red = 0;
                            SetProperty("Middle.SourceFile", "AllUIAssets.png");
                            Middle.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            Middle.TextureHeight = 1;
                            Middle.TextureLeft = 36;
                            Middle.TextureTop = 36;
                            Middle.TextureWidth = 1;
                            Middle.Width = -32f;
                            Middle.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            Middle.X = 0f;
                            Middle.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            Middle.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            Middle.Y = 0f;
                            Middle.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            Middle.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            TopLeft.Blue = 0;
                            TopLeft.Green = 175;
                            TopLeft.Height = 32f;
                            TopLeft.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            TopLeft.Red = 0;
                            SetProperty("TopLeft.SourceFile", "AllUIAssets.png");
                            TopLeft.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            TopLeft.TextureHeight = 64;
                            TopLeft.TextureLeft = 0;
                            TopLeft.TextureTop = 0;
                            TopLeft.TextureWidth = 64;
                            TopLeft.Width = 32f;
                            TopLeft.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            TopLeft.X = 0f;
                            TopLeft.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            TopLeft.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            TopLeft.Y = 0f;
                            TopLeft.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                            TopLeft.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            Top.Blue = 0;
                            Top.Green = 175;
                            Top.Height = 32f;
                            Top.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            Top.Red = 0;
                            SetProperty("Top.SourceFile", "AllUIAssets.png");
                            Top.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            Top.TextureHeight = 64;
                            Top.TextureLeft = 64;
                            Top.TextureTop = 0;
                            Top.TextureWidth = 128;
                            Top.Width = -64f;
                            Top.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            Top.X = 0f;
                            Top.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            Top.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            Top.Y = 0f;
                            Top.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                            Top.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            TopRight.Blue = 0;
                            TopRight.Green = 175;
                            TopRight.Height = 32f;
                            TopRight.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            TopRight.Red = 0;
                            SetProperty("TopRight.SourceFile", "AllUIAssets.png");
                            TopRight.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            TopRight.TextureHeight = 64;
                            TopRight.TextureLeft = 192;
                            TopRight.TextureTop = 0;
                            TopRight.TextureWidth = 64;
                            TopRight.Width = 32f;
                            TopRight.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            TopRight.X = 0f;
                            TopRight.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            TopRight.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            TopRight.Y = 0f;
                            TopRight.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                            TopRight.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            Right.Blue = 0;
                            Right.Green = 175;
                            Right.Height = -64f;
                            Right.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            Right.Red = 0;
                            SetProperty("Right.SourceFile", "AllUIAssets.png");
                            Right.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            Right.TextureHeight = 128;
                            Right.TextureLeft = 192;
                            Right.TextureTop = 64;
                            Right.TextureWidth = 64;
                            Right.Width = 32f;
                            Right.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            Right.X = 0f;
                            Right.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            Right.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            Right.Y = 0f;
                            Right.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            Right.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            BottomRight.Blue = 0;
                            BottomRight.Green = 175;
                            BottomRight.Height = 32f;
                            BottomRight.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            BottomRight.Red = 0;
                            SetProperty("BottomRight.SourceFile", "AllUIAssets.png");
                            BottomRight.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            BottomRight.TextureHeight = 64;
                            BottomRight.TextureLeft = 192;
                            BottomRight.TextureTop = 192;
                            BottomRight.TextureWidth = 64;
                            BottomRight.Width = 32f;
                            BottomRight.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            BottomRight.X = 0f;
                            BottomRight.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            BottomRight.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            BottomRight.Y = 0f;
                            BottomRight.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                            BottomRight.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            Bottom.Blue = 0;
                            Bottom.Green = 175;
                            Bottom.Height = 32f;
                            Bottom.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            Bottom.Red = 0;
                            SetProperty("Bottom.SourceFile", "AllUIAssets.png");
                            Bottom.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            Bottom.TextureHeight = 64;
                            Bottom.TextureLeft = 64;
                            Bottom.TextureTop = 192;
                            Bottom.TextureWidth = 128;
                            Bottom.Width = -64f;
                            Bottom.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            Bottom.X = 0f;
                            Bottom.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            Bottom.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            Bottom.Y = 0f;
                            Bottom.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                            Bottom.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            BottomLeft.Blue = 0;
                            BottomLeft.Green = 175;
                            BottomLeft.Height = 32f;
                            BottomLeft.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            BottomLeft.Red = 0;
                            SetProperty("BottomLeft.SourceFile", "AllUIAssets.png");
                            BottomLeft.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            BottomLeft.TextureHeight = 64;
                            BottomLeft.TextureLeft = 0;
                            BottomLeft.TextureTop = 192;
                            BottomLeft.TextureWidth = 64;
                            BottomLeft.Width = 32f;
                            BottomLeft.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            BottomLeft.X = 0f;
                            BottomLeft.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            BottomLeft.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            BottomLeft.Y = 0f;
                            BottomLeft.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                            BottomLeft.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            Left.Blue = 0;
                            Left.Green = 175;
                            Left.Height = -64f;
                            Left.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            Left.Red = 0;
                            SetProperty("Left.SourceFile", "AllUIAssets.png");
                            Left.TextureAddress = Gum.Managers.TextureAddress.Custom;
                            Left.TextureHeight = 128;
                            Left.TextureLeft = 0;
                            Left.TextureTop = 64;
                            Left.TextureWidth = 64;
                            Left.Width = 32f;
                            Left.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            Left.X = 0f;
                            Left.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            Left.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            Left.Y = 0f;
                            Left.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            Left.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            break;
                    }
                }
            }
            public FlickerState CurrentFlickerStateState
            {
                get
                {
                    return mCurrentFlickerStateState;
                }
                set
                {
                    mCurrentFlickerStateState = value;
                    switch(mCurrentFlickerStateState)
                    {
                        case  FlickerState.Flicker1:
                            TopLeft.TextureLeft = 0;
                            TopLeft.TextureTop = 0;
                            Top.TextureLeft = 64;
                            Top.TextureTop = 0;
                            TopRight.TextureLeft = 192;
                            TopRight.TextureTop = 0;
                            Right.TextureLeft = 192;
                            Right.TextureTop = 64;
                            BottomRight.TextureLeft = 192;
                            BottomRight.TextureTop = 192;
                            Bottom.TextureLeft = 64;
                            Bottom.TextureTop = 192;
                            BottomLeft.TextureLeft = 0;
                            BottomLeft.TextureTop = 192;
                            Left.TextureLeft = 0;
                            Left.TextureTop = 64;
                            break;
                        case  FlickerState.Flicker2:
                            TopLeft.TextureLeft = 256;
                            TopLeft.TextureTop = 0;
                            Top.TextureLeft = 320;
                            Top.TextureTop = 0;
                            TopRight.TextureLeft = 448;
                            TopRight.TextureTop = 0;
                            Right.TextureLeft = 448;
                            Right.TextureTop = 64;
                            BottomRight.TextureLeft = 448;
                            BottomRight.TextureTop = 192;
                            Bottom.TextureLeft = 320;
                            Bottom.TextureTop = 192;
                            BottomLeft.TextureLeft = 256;
                            BottomLeft.TextureTop = 192;
                            Left.TextureLeft = 256;
                            Left.TextureTop = 64;
                            break;
                        case  FlickerState.Flicker3:
                            TopLeft.TextureLeft = 512;
                            TopLeft.TextureTop = 0;
                            Top.TextureLeft = 576;
                            Top.TextureTop = 0;
                            TopRight.TextureLeft = 704;
                            TopRight.TextureTop = 0;
                            Right.TextureLeft = 704;
                            Right.TextureTop = 64;
                            BottomRight.TextureLeft = 704;
                            BottomRight.TextureTop = 192;
                            Bottom.TextureLeft = 576;
                            Bottom.TextureTop = 192;
                            BottomLeft.TextureLeft = 512;
                            BottomLeft.TextureTop = 192;
                            Left.TextureLeft = 512;
                            Left.TextureTop = 64;
                            break;
                        case  FlickerState.Flicker4:
                            TopLeft.TextureLeft = 0;
                            TopLeft.TextureTop = 256;
                            Top.TextureLeft = 64;
                            Top.TextureTop = 256;
                            TopRight.TextureLeft = 192;
                            TopRight.TextureTop = 256;
                            Right.TextureLeft = 192;
                            Right.TextureTop = 320;
                            BottomRight.TextureLeft = 192;
                            BottomRight.TextureTop = 448;
                            Bottom.TextureLeft = 64;
                            Bottom.TextureTop = 448;
                            BottomLeft.TextureLeft = 0;
                            BottomLeft.TextureTop = 448;
                            Left.TextureLeft = 0;
                            Left.TextureTop = 320;
                            break;
                        case  FlickerState.Flicker5:
                            TopLeft.TextureLeft = 256;
                            TopLeft.TextureTop = 256;
                            Top.TextureLeft = 320;
                            Top.TextureTop = 256;
                            TopRight.TextureLeft = 448;
                            TopRight.TextureTop = 256;
                            Right.TextureLeft = 448;
                            Right.TextureTop = 320;
                            BottomRight.TextureLeft = 448;
                            BottomRight.TextureTop = 448;
                            Bottom.TextureLeft = 320;
                            Bottom.TextureTop = 448;
                            BottomLeft.TextureLeft = 256;
                            BottomLeft.TextureTop = 448;
                            Left.TextureLeft = 256;
                            Left.TextureTop = 320;
                            break;
                        case  FlickerState.Flicker6:
                            TopLeft.TextureLeft = 512;
                            TopLeft.TextureTop = 256;
                            Top.TextureLeft = 576;
                            Top.TextureTop = 256;
                            TopRight.TextureLeft = 704;
                            TopRight.TextureTop = 256;
                            Right.TextureLeft = 704;
                            Right.TextureTop = 320;
                            BottomRight.TextureLeft = 704;
                            BottomRight.TextureTop = 448;
                            Bottom.TextureLeft = 576;
                            Bottom.TextureTop = 448;
                            BottomLeft.TextureLeft = 512;
                            BottomLeft.TextureTop = 448;
                            Left.TextureLeft = 512;
                            Left.TextureTop = 320;
                            break;
                        case  FlickerState.Flicker7:
                            TopLeft.TextureLeft = 0;
                            TopLeft.TextureTop = 512;
                            Top.TextureLeft = 64;
                            Top.TextureTop = 512;
                            TopRight.TextureLeft = 192;
                            TopRight.TextureTop = 512;
                            Right.TextureLeft = 192;
                            Right.TextureTop = 576;
                            BottomRight.TextureLeft = 192;
                            BottomRight.TextureTop = 704;
                            Bottom.TextureLeft = 64;
                            Bottom.TextureTop = 704;
                            BottomLeft.TextureLeft = 0;
                            BottomLeft.TextureTop = 704;
                            Left.TextureLeft = 0;
                            Left.TextureTop = 576;
                            break;
                        case  FlickerState.Flicker8:
                            TopLeft.TextureLeft = 256;
                            TopLeft.TextureTop = 512;
                            Top.TextureLeft = 320;
                            Top.TextureTop = 512;
                            TopRight.TextureLeft = 448;
                            TopRight.TextureTop = 512;
                            Right.TextureLeft = 448;
                            Right.TextureTop = 576;
                            BottomRight.TextureLeft = 448;
                            BottomRight.TextureTop = 704;
                            Bottom.TextureLeft = 320;
                            Bottom.TextureTop = 704;
                            BottomLeft.TextureLeft = 256;
                            BottomLeft.TextureTop = 704;
                            Left.TextureLeft = 256;
                            Left.TextureTop = 576;
                            break;
                        case  FlickerState.Flicker9:
                            TopLeft.TextureLeft = 512;
                            TopLeft.TextureTop = 512;
                            Top.TextureLeft = 576;
                            Top.TextureTop = 512;
                            TopRight.TextureLeft = 704;
                            TopRight.TextureTop = 512;
                            Right.TextureLeft = 704;
                            Right.TextureTop = 576;
                            BottomRight.TextureLeft = 704;
                            BottomRight.TextureTop = 704;
                            Bottom.TextureLeft = 576;
                            Bottom.TextureTop = 704;
                            BottomLeft.TextureLeft = 512;
                            BottomLeft.TextureTop = 704;
                            Left.TextureLeft = 512;
                            Left.TextureTop = 576;
                            break;
                    }
                }
            }
            public ColorState CurrentColorStateState
            {
                get
                {
                    return mCurrentColorStateState;
                }
                set
                {
                    mCurrentColorStateState = value;
                    switch(mCurrentColorStateState)
                    {
                        case  ColorState.Red:
                            Middle.Blue = 0;
                            Middle.Green = 0;
                            Middle.Red = 36;
                            TopLeft.Blue = 0;
                            TopLeft.Green = 0;
                            TopLeft.Red = 255;
                            Top.Blue = 0;
                            Top.Green = 0;
                            Top.Red = 255;
                            TopRight.Blue = 0;
                            TopRight.Green = 0;
                            TopRight.Red = 255;
                            Right.Blue = 0;
                            Right.Green = 0;
                            Right.Red = 255;
                            BottomRight.Blue = 0;
                            BottomRight.Green = 0;
                            BottomRight.Red = 255;
                            Bottom.Blue = 0;
                            Bottom.Green = 0;
                            Bottom.Red = 255;
                            BottomLeft.Blue = 0;
                            BottomLeft.Green = 0;
                            BottomLeft.Red = 255;
                            Left.Blue = 0;
                            Left.Green = 0;
                            Left.Red = 255;
                            break;
                        case  ColorState.Green:
                            Middle.Blue = 0;
                            Middle.Green = 48;
                            Middle.Red = 0;
                            TopLeft.Blue = 0;
                            TopLeft.Green = 255;
                            TopLeft.Red = 0;
                            Top.Blue = 0;
                            Top.Green = 255;
                            Top.Red = 0;
                            TopRight.Blue = 0;
                            TopRight.Green = 255;
                            TopRight.Red = 0;
                            Right.Blue = 0;
                            Right.Green = 255;
                            Right.Red = 0;
                            BottomRight.Blue = 0;
                            BottomRight.Green = 255;
                            BottomRight.Red = 0;
                            Bottom.Blue = 0;
                            Bottom.Green = 255;
                            Bottom.Red = 0;
                            BottomLeft.Blue = 0;
                            BottomLeft.Green = 255;
                            BottomLeft.Red = 0;
                            Left.Blue = 0;
                            Left.Green = 255;
                            Left.Red = 0;
                            break;
                        case  ColorState.Black:
                            Middle.Blue = 75;
                            Middle.Green = 75;
                            Middle.Red = 75;
                            TopLeft.Blue = 50;
                            TopLeft.Green = 50;
                            TopLeft.Red = 50;
                            Top.Blue = 50;
                            Top.Green = 50;
                            Top.Red = 50;
                            TopRight.Blue = 50;
                            TopRight.Green = 50;
                            TopRight.Red = 50;
                            Right.Blue = 50;
                            Right.Green = 50;
                            Right.Red = 50;
                            BottomRight.Blue = 50;
                            BottomRight.Green = 50;
                            BottomRight.Red = 50;
                            Bottom.Blue = 50;
                            Bottom.Green = 50;
                            Bottom.Red = 50;
                            BottomLeft.Blue = 50;
                            BottomLeft.Green = 50;
                            BottomLeft.Red = 50;
                            Left.Blue = 50;
                            Left.Green = 50;
                            Left.Red = 50;
                            break;
                        case  ColorState.Blue:
                            Middle.Blue = 255;
                            Middle.Green = 255;
                            Middle.Red = 224;
                            TopLeft.Blue = 235;
                            TopLeft.Green = 206;
                            TopLeft.Red = 135;
                            Top.Blue = 250;
                            Top.Green = 206;
                            Top.Red = 135;
                            TopRight.Blue = 250;
                            TopRight.Green = 206;
                            TopRight.Red = 135;
                            Right.Blue = 250;
                            Right.Green = 206;
                            Right.Red = 135;
                            BottomRight.Blue = 250;
                            BottomRight.Green = 206;
                            BottomRight.Red = 135;
                            Bottom.Blue = 250;
                            Bottom.Green = 206;
                            Bottom.Red = 135;
                            BottomLeft.Blue = 250;
                            BottomLeft.Green = 206;
                            BottomLeft.Red = 135;
                            Left.Blue = 250;
                            Left.Green = 206;
                            Left.Red = 135;
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
                bool setBottomBlueFirstValue = false;
                bool setBottomBlueSecondValue = false;
                int BottomBlueFirstValue= 0;
                int BottomBlueSecondValue= 0;
                bool setBottomGreenFirstValue = false;
                bool setBottomGreenSecondValue = false;
                int BottomGreenFirstValue= 0;
                int BottomGreenSecondValue= 0;
                bool setBottomHeightFirstValue = false;
                bool setBottomHeightSecondValue = false;
                float BottomHeightFirstValue= 0;
                float BottomHeightSecondValue= 0;
                bool setBottomRedFirstValue = false;
                bool setBottomRedSecondValue = false;
                int BottomRedFirstValue= 0;
                int BottomRedSecondValue= 0;
                bool setBottomTextureHeightFirstValue = false;
                bool setBottomTextureHeightSecondValue = false;
                int BottomTextureHeightFirstValue= 0;
                int BottomTextureHeightSecondValue= 0;
                bool setBottomTextureLeftFirstValue = false;
                bool setBottomTextureLeftSecondValue = false;
                int BottomTextureLeftFirstValue= 0;
                int BottomTextureLeftSecondValue= 0;
                bool setBottomTextureTopFirstValue = false;
                bool setBottomTextureTopSecondValue = false;
                int BottomTextureTopFirstValue= 0;
                int BottomTextureTopSecondValue= 0;
                bool setBottomTextureWidthFirstValue = false;
                bool setBottomTextureWidthSecondValue = false;
                int BottomTextureWidthFirstValue= 0;
                int BottomTextureWidthSecondValue= 0;
                bool setBottomWidthFirstValue = false;
                bool setBottomWidthSecondValue = false;
                float BottomWidthFirstValue= 0;
                float BottomWidthSecondValue= 0;
                bool setBottomXFirstValue = false;
                bool setBottomXSecondValue = false;
                float BottomXFirstValue= 0;
                float BottomXSecondValue= 0;
                bool setBottomYFirstValue = false;
                bool setBottomYSecondValue = false;
                float BottomYFirstValue= 0;
                float BottomYSecondValue= 0;
                bool setBottomLeftBlueFirstValue = false;
                bool setBottomLeftBlueSecondValue = false;
                int BottomLeftBlueFirstValue= 0;
                int BottomLeftBlueSecondValue= 0;
                bool setBottomLeftGreenFirstValue = false;
                bool setBottomLeftGreenSecondValue = false;
                int BottomLeftGreenFirstValue= 0;
                int BottomLeftGreenSecondValue= 0;
                bool setBottomLeftHeightFirstValue = false;
                bool setBottomLeftHeightSecondValue = false;
                float BottomLeftHeightFirstValue= 0;
                float BottomLeftHeightSecondValue= 0;
                bool setBottomLeftRedFirstValue = false;
                bool setBottomLeftRedSecondValue = false;
                int BottomLeftRedFirstValue= 0;
                int BottomLeftRedSecondValue= 0;
                bool setBottomLeftTextureHeightFirstValue = false;
                bool setBottomLeftTextureHeightSecondValue = false;
                int BottomLeftTextureHeightFirstValue= 0;
                int BottomLeftTextureHeightSecondValue= 0;
                bool setBottomLeftTextureLeftFirstValue = false;
                bool setBottomLeftTextureLeftSecondValue = false;
                int BottomLeftTextureLeftFirstValue= 0;
                int BottomLeftTextureLeftSecondValue= 0;
                bool setBottomLeftTextureTopFirstValue = false;
                bool setBottomLeftTextureTopSecondValue = false;
                int BottomLeftTextureTopFirstValue= 0;
                int BottomLeftTextureTopSecondValue= 0;
                bool setBottomLeftTextureWidthFirstValue = false;
                bool setBottomLeftTextureWidthSecondValue = false;
                int BottomLeftTextureWidthFirstValue= 0;
                int BottomLeftTextureWidthSecondValue= 0;
                bool setBottomLeftWidthFirstValue = false;
                bool setBottomLeftWidthSecondValue = false;
                float BottomLeftWidthFirstValue= 0;
                float BottomLeftWidthSecondValue= 0;
                bool setBottomLeftXFirstValue = false;
                bool setBottomLeftXSecondValue = false;
                float BottomLeftXFirstValue= 0;
                float BottomLeftXSecondValue= 0;
                bool setBottomLeftYFirstValue = false;
                bool setBottomLeftYSecondValue = false;
                float BottomLeftYFirstValue= 0;
                float BottomLeftYSecondValue= 0;
                bool setBottomRightBlueFirstValue = false;
                bool setBottomRightBlueSecondValue = false;
                int BottomRightBlueFirstValue= 0;
                int BottomRightBlueSecondValue= 0;
                bool setBottomRightGreenFirstValue = false;
                bool setBottomRightGreenSecondValue = false;
                int BottomRightGreenFirstValue= 0;
                int BottomRightGreenSecondValue= 0;
                bool setBottomRightHeightFirstValue = false;
                bool setBottomRightHeightSecondValue = false;
                float BottomRightHeightFirstValue= 0;
                float BottomRightHeightSecondValue= 0;
                bool setBottomRightRedFirstValue = false;
                bool setBottomRightRedSecondValue = false;
                int BottomRightRedFirstValue= 0;
                int BottomRightRedSecondValue= 0;
                bool setBottomRightTextureHeightFirstValue = false;
                bool setBottomRightTextureHeightSecondValue = false;
                int BottomRightTextureHeightFirstValue= 0;
                int BottomRightTextureHeightSecondValue= 0;
                bool setBottomRightTextureLeftFirstValue = false;
                bool setBottomRightTextureLeftSecondValue = false;
                int BottomRightTextureLeftFirstValue= 0;
                int BottomRightTextureLeftSecondValue= 0;
                bool setBottomRightTextureTopFirstValue = false;
                bool setBottomRightTextureTopSecondValue = false;
                int BottomRightTextureTopFirstValue= 0;
                int BottomRightTextureTopSecondValue= 0;
                bool setBottomRightTextureWidthFirstValue = false;
                bool setBottomRightTextureWidthSecondValue = false;
                int BottomRightTextureWidthFirstValue= 0;
                int BottomRightTextureWidthSecondValue= 0;
                bool setBottomRightWidthFirstValue = false;
                bool setBottomRightWidthSecondValue = false;
                float BottomRightWidthFirstValue= 0;
                float BottomRightWidthSecondValue= 0;
                bool setBottomRightXFirstValue = false;
                bool setBottomRightXSecondValue = false;
                float BottomRightXFirstValue= 0;
                float BottomRightXSecondValue= 0;
                bool setBottomRightYFirstValue = false;
                bool setBottomRightYSecondValue = false;
                float BottomRightYFirstValue= 0;
                float BottomRightYSecondValue= 0;
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setLeftBlueFirstValue = false;
                bool setLeftBlueSecondValue = false;
                int LeftBlueFirstValue= 0;
                int LeftBlueSecondValue= 0;
                bool setLeftGreenFirstValue = false;
                bool setLeftGreenSecondValue = false;
                int LeftGreenFirstValue= 0;
                int LeftGreenSecondValue= 0;
                bool setLeftHeightFirstValue = false;
                bool setLeftHeightSecondValue = false;
                float LeftHeightFirstValue= 0;
                float LeftHeightSecondValue= 0;
                bool setLeftRedFirstValue = false;
                bool setLeftRedSecondValue = false;
                int LeftRedFirstValue= 0;
                int LeftRedSecondValue= 0;
                bool setLeftTextureHeightFirstValue = false;
                bool setLeftTextureHeightSecondValue = false;
                int LeftTextureHeightFirstValue= 0;
                int LeftTextureHeightSecondValue= 0;
                bool setLeftTextureLeftFirstValue = false;
                bool setLeftTextureLeftSecondValue = false;
                int LeftTextureLeftFirstValue= 0;
                int LeftTextureLeftSecondValue= 0;
                bool setLeftTextureTopFirstValue = false;
                bool setLeftTextureTopSecondValue = false;
                int LeftTextureTopFirstValue= 0;
                int LeftTextureTopSecondValue= 0;
                bool setLeftTextureWidthFirstValue = false;
                bool setLeftTextureWidthSecondValue = false;
                int LeftTextureWidthFirstValue= 0;
                int LeftTextureWidthSecondValue= 0;
                bool setLeftWidthFirstValue = false;
                bool setLeftWidthSecondValue = false;
                float LeftWidthFirstValue= 0;
                float LeftWidthSecondValue= 0;
                bool setLeftXFirstValue = false;
                bool setLeftXSecondValue = false;
                float LeftXFirstValue= 0;
                float LeftXSecondValue= 0;
                bool setLeftYFirstValue = false;
                bool setLeftYSecondValue = false;
                float LeftYFirstValue= 0;
                float LeftYSecondValue= 0;
                bool setMiddleAlphaFirstValue = false;
                bool setMiddleAlphaSecondValue = false;
                int MiddleAlphaFirstValue= 0;
                int MiddleAlphaSecondValue= 0;
                bool setMiddleBlueFirstValue = false;
                bool setMiddleBlueSecondValue = false;
                int MiddleBlueFirstValue= 0;
                int MiddleBlueSecondValue= 0;
                bool setMiddleGreenFirstValue = false;
                bool setMiddleGreenSecondValue = false;
                int MiddleGreenFirstValue= 0;
                int MiddleGreenSecondValue= 0;
                bool setMiddleHeightFirstValue = false;
                bool setMiddleHeightSecondValue = false;
                float MiddleHeightFirstValue= 0;
                float MiddleHeightSecondValue= 0;
                bool setMiddleRedFirstValue = false;
                bool setMiddleRedSecondValue = false;
                int MiddleRedFirstValue= 0;
                int MiddleRedSecondValue= 0;
                bool setMiddleTextureHeightFirstValue = false;
                bool setMiddleTextureHeightSecondValue = false;
                int MiddleTextureHeightFirstValue= 0;
                int MiddleTextureHeightSecondValue= 0;
                bool setMiddleTextureLeftFirstValue = false;
                bool setMiddleTextureLeftSecondValue = false;
                int MiddleTextureLeftFirstValue= 0;
                int MiddleTextureLeftSecondValue= 0;
                bool setMiddleTextureTopFirstValue = false;
                bool setMiddleTextureTopSecondValue = false;
                int MiddleTextureTopFirstValue= 0;
                int MiddleTextureTopSecondValue= 0;
                bool setMiddleTextureWidthFirstValue = false;
                bool setMiddleTextureWidthSecondValue = false;
                int MiddleTextureWidthFirstValue= 0;
                int MiddleTextureWidthSecondValue= 0;
                bool setMiddleWidthFirstValue = false;
                bool setMiddleWidthSecondValue = false;
                float MiddleWidthFirstValue= 0;
                float MiddleWidthSecondValue= 0;
                bool setMiddleXFirstValue = false;
                bool setMiddleXSecondValue = false;
                float MiddleXFirstValue= 0;
                float MiddleXSecondValue= 0;
                bool setMiddleYFirstValue = false;
                bool setMiddleYSecondValue = false;
                float MiddleYFirstValue= 0;
                float MiddleYSecondValue= 0;
                bool setRightBlueFirstValue = false;
                bool setRightBlueSecondValue = false;
                int RightBlueFirstValue= 0;
                int RightBlueSecondValue= 0;
                bool setRightGreenFirstValue = false;
                bool setRightGreenSecondValue = false;
                int RightGreenFirstValue= 0;
                int RightGreenSecondValue= 0;
                bool setRightHeightFirstValue = false;
                bool setRightHeightSecondValue = false;
                float RightHeightFirstValue= 0;
                float RightHeightSecondValue= 0;
                bool setRightRedFirstValue = false;
                bool setRightRedSecondValue = false;
                int RightRedFirstValue= 0;
                int RightRedSecondValue= 0;
                bool setRightTextureHeightFirstValue = false;
                bool setRightTextureHeightSecondValue = false;
                int RightTextureHeightFirstValue= 0;
                int RightTextureHeightSecondValue= 0;
                bool setRightTextureLeftFirstValue = false;
                bool setRightTextureLeftSecondValue = false;
                int RightTextureLeftFirstValue= 0;
                int RightTextureLeftSecondValue= 0;
                bool setRightTextureTopFirstValue = false;
                bool setRightTextureTopSecondValue = false;
                int RightTextureTopFirstValue= 0;
                int RightTextureTopSecondValue= 0;
                bool setRightTextureWidthFirstValue = false;
                bool setRightTextureWidthSecondValue = false;
                int RightTextureWidthFirstValue= 0;
                int RightTextureWidthSecondValue= 0;
                bool setRightWidthFirstValue = false;
                bool setRightWidthSecondValue = false;
                float RightWidthFirstValue= 0;
                float RightWidthSecondValue= 0;
                bool setRightXFirstValue = false;
                bool setRightXSecondValue = false;
                float RightXFirstValue= 0;
                float RightXSecondValue= 0;
                bool setRightYFirstValue = false;
                bool setRightYSecondValue = false;
                float RightYFirstValue= 0;
                float RightYSecondValue= 0;
                bool setTopBlueFirstValue = false;
                bool setTopBlueSecondValue = false;
                int TopBlueFirstValue= 0;
                int TopBlueSecondValue= 0;
                bool setTopGreenFirstValue = false;
                bool setTopGreenSecondValue = false;
                int TopGreenFirstValue= 0;
                int TopGreenSecondValue= 0;
                bool setTopHeightFirstValue = false;
                bool setTopHeightSecondValue = false;
                float TopHeightFirstValue= 0;
                float TopHeightSecondValue= 0;
                bool setTopRedFirstValue = false;
                bool setTopRedSecondValue = false;
                int TopRedFirstValue= 0;
                int TopRedSecondValue= 0;
                bool setTopTextureHeightFirstValue = false;
                bool setTopTextureHeightSecondValue = false;
                int TopTextureHeightFirstValue= 0;
                int TopTextureHeightSecondValue= 0;
                bool setTopTextureLeftFirstValue = false;
                bool setTopTextureLeftSecondValue = false;
                int TopTextureLeftFirstValue= 0;
                int TopTextureLeftSecondValue= 0;
                bool setTopTextureTopFirstValue = false;
                bool setTopTextureTopSecondValue = false;
                int TopTextureTopFirstValue= 0;
                int TopTextureTopSecondValue= 0;
                bool setTopTextureWidthFirstValue = false;
                bool setTopTextureWidthSecondValue = false;
                int TopTextureWidthFirstValue= 0;
                int TopTextureWidthSecondValue= 0;
                bool setTopWidthFirstValue = false;
                bool setTopWidthSecondValue = false;
                float TopWidthFirstValue= 0;
                float TopWidthSecondValue= 0;
                bool setTopXFirstValue = false;
                bool setTopXSecondValue = false;
                float TopXFirstValue= 0;
                float TopXSecondValue= 0;
                bool setTopYFirstValue = false;
                bool setTopYSecondValue = false;
                float TopYFirstValue= 0;
                float TopYSecondValue= 0;
                bool setTopLeftBlueFirstValue = false;
                bool setTopLeftBlueSecondValue = false;
                int TopLeftBlueFirstValue= 0;
                int TopLeftBlueSecondValue= 0;
                bool setTopLeftGreenFirstValue = false;
                bool setTopLeftGreenSecondValue = false;
                int TopLeftGreenFirstValue= 0;
                int TopLeftGreenSecondValue= 0;
                bool setTopLeftHeightFirstValue = false;
                bool setTopLeftHeightSecondValue = false;
                float TopLeftHeightFirstValue= 0;
                float TopLeftHeightSecondValue= 0;
                bool setTopLeftRedFirstValue = false;
                bool setTopLeftRedSecondValue = false;
                int TopLeftRedFirstValue= 0;
                int TopLeftRedSecondValue= 0;
                bool setTopLeftTextureHeightFirstValue = false;
                bool setTopLeftTextureHeightSecondValue = false;
                int TopLeftTextureHeightFirstValue= 0;
                int TopLeftTextureHeightSecondValue= 0;
                bool setTopLeftTextureLeftFirstValue = false;
                bool setTopLeftTextureLeftSecondValue = false;
                int TopLeftTextureLeftFirstValue= 0;
                int TopLeftTextureLeftSecondValue= 0;
                bool setTopLeftTextureTopFirstValue = false;
                bool setTopLeftTextureTopSecondValue = false;
                int TopLeftTextureTopFirstValue= 0;
                int TopLeftTextureTopSecondValue= 0;
                bool setTopLeftTextureWidthFirstValue = false;
                bool setTopLeftTextureWidthSecondValue = false;
                int TopLeftTextureWidthFirstValue= 0;
                int TopLeftTextureWidthSecondValue= 0;
                bool setTopLeftWidthFirstValue = false;
                bool setTopLeftWidthSecondValue = false;
                float TopLeftWidthFirstValue= 0;
                float TopLeftWidthSecondValue= 0;
                bool setTopLeftXFirstValue = false;
                bool setTopLeftXSecondValue = false;
                float TopLeftXFirstValue= 0;
                float TopLeftXSecondValue= 0;
                bool setTopLeftYFirstValue = false;
                bool setTopLeftYSecondValue = false;
                float TopLeftYFirstValue= 0;
                float TopLeftYSecondValue= 0;
                bool setTopRightBlueFirstValue = false;
                bool setTopRightBlueSecondValue = false;
                int TopRightBlueFirstValue= 0;
                int TopRightBlueSecondValue= 0;
                bool setTopRightGreenFirstValue = false;
                bool setTopRightGreenSecondValue = false;
                int TopRightGreenFirstValue= 0;
                int TopRightGreenSecondValue= 0;
                bool setTopRightHeightFirstValue = false;
                bool setTopRightHeightSecondValue = false;
                float TopRightHeightFirstValue= 0;
                float TopRightHeightSecondValue= 0;
                bool setTopRightRedFirstValue = false;
                bool setTopRightRedSecondValue = false;
                int TopRightRedFirstValue= 0;
                int TopRightRedSecondValue= 0;
                bool setTopRightTextureHeightFirstValue = false;
                bool setTopRightTextureHeightSecondValue = false;
                int TopRightTextureHeightFirstValue= 0;
                int TopRightTextureHeightSecondValue= 0;
                bool setTopRightTextureLeftFirstValue = false;
                bool setTopRightTextureLeftSecondValue = false;
                int TopRightTextureLeftFirstValue= 0;
                int TopRightTextureLeftSecondValue= 0;
                bool setTopRightTextureTopFirstValue = false;
                bool setTopRightTextureTopSecondValue = false;
                int TopRightTextureTopFirstValue= 0;
                int TopRightTextureTopSecondValue= 0;
                bool setTopRightTextureWidthFirstValue = false;
                bool setTopRightTextureWidthSecondValue = false;
                int TopRightTextureWidthFirstValue= 0;
                int TopRightTextureWidthSecondValue= 0;
                bool setTopRightWidthFirstValue = false;
                bool setTopRightWidthSecondValue = false;
                float TopRightWidthFirstValue= 0;
                float TopRightWidthSecondValue= 0;
                bool setTopRightXFirstValue = false;
                bool setTopRightXSecondValue = false;
                float TopRightXFirstValue= 0;
                float TopRightXSecondValue= 0;
                bool setTopRightYFirstValue = false;
                bool setTopRightYSecondValue = false;
                float TopRightYFirstValue= 0;
                float TopRightYSecondValue= 0;
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                bool setXFirstValue = false;
                bool setXSecondValue = false;
                float XFirstValue= 0;
                float XSecondValue= 0;
                bool setYFirstValue = false;
                bool setYSecondValue = false;
                float YFirstValue= 0;
                float YSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setBottomBlueFirstValue = true;
                        BottomBlueFirstValue = 0;
                        setBottomGreenFirstValue = true;
                        BottomGreenFirstValue = 175;
                        setBottomHeightFirstValue = true;
                        BottomHeightFirstValue = 32f;
                        if (interpolationValue < 1)
                        {
                            this.Bottom.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setBottomRedFirstValue = true;
                        BottomRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            SetProperty("Bottom.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.Bottom.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setBottomTextureHeightFirstValue = true;
                        BottomTextureHeightFirstValue = 64;
                        setBottomTextureLeftFirstValue = true;
                        BottomTextureLeftFirstValue = 64;
                        setBottomTextureTopFirstValue = true;
                        BottomTextureTopFirstValue = 192;
                        setBottomTextureWidthFirstValue = true;
                        BottomTextureWidthFirstValue = 128;
                        setBottomWidthFirstValue = true;
                        BottomWidthFirstValue = -64f;
                        if (interpolationValue < 1)
                        {
                            this.Bottom.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setBottomXFirstValue = true;
                        BottomXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Bottom.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Bottom.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setBottomYFirstValue = true;
                        BottomYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Bottom.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Bottom.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setBottomLeftBlueFirstValue = true;
                        BottomLeftBlueFirstValue = 0;
                        setBottomLeftGreenFirstValue = true;
                        BottomLeftGreenFirstValue = 175;
                        setBottomLeftHeightFirstValue = true;
                        BottomLeftHeightFirstValue = 32f;
                        if (interpolationValue < 1)
                        {
                            this.BottomLeft.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setBottomLeftRedFirstValue = true;
                        BottomLeftRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            SetProperty("BottomLeft.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.BottomLeft.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setBottomLeftTextureHeightFirstValue = true;
                        BottomLeftTextureHeightFirstValue = 64;
                        setBottomLeftTextureLeftFirstValue = true;
                        BottomLeftTextureLeftFirstValue = 0;
                        setBottomLeftTextureTopFirstValue = true;
                        BottomLeftTextureTopFirstValue = 192;
                        setBottomLeftTextureWidthFirstValue = true;
                        BottomLeftTextureWidthFirstValue = 64;
                        setBottomLeftWidthFirstValue = true;
                        BottomLeftWidthFirstValue = 32f;
                        if (interpolationValue < 1)
                        {
                            this.BottomLeft.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setBottomLeftXFirstValue = true;
                        BottomLeftXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.BottomLeft.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.BottomLeft.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setBottomLeftYFirstValue = true;
                        BottomLeftYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.BottomLeft.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue < 1)
                        {
                            this.BottomLeft.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setBottomRightBlueFirstValue = true;
                        BottomRightBlueFirstValue = 0;
                        setBottomRightGreenFirstValue = true;
                        BottomRightGreenFirstValue = 175;
                        setBottomRightHeightFirstValue = true;
                        BottomRightHeightFirstValue = 32f;
                        if (interpolationValue < 1)
                        {
                            this.BottomRight.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setBottomRightRedFirstValue = true;
                        BottomRightRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            SetProperty("BottomRight.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.BottomRight.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setBottomRightTextureHeightFirstValue = true;
                        BottomRightTextureHeightFirstValue = 64;
                        setBottomRightTextureLeftFirstValue = true;
                        BottomRightTextureLeftFirstValue = 192;
                        setBottomRightTextureTopFirstValue = true;
                        BottomRightTextureTopFirstValue = 192;
                        setBottomRightTextureWidthFirstValue = true;
                        BottomRightTextureWidthFirstValue = 64;
                        setBottomRightWidthFirstValue = true;
                        BottomRightWidthFirstValue = 32f;
                        if (interpolationValue < 1)
                        {
                            this.BottomRight.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setBottomRightXFirstValue = true;
                        BottomRightXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.BottomRight.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.BottomRight.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setBottomRightYFirstValue = true;
                        BottomRightYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.BottomRight.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue < 1)
                        {
                            this.BottomRight.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ChildrenLayout = Gum.Managers.ChildrenLayout.Regular;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ClipsChildren = false;
                        }
                        setHeightFirstValue = true;
                        HeightFirstValue = 12.99866f;
                        if (interpolationValue < 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setLeftBlueFirstValue = true;
                        LeftBlueFirstValue = 0;
                        setLeftGreenFirstValue = true;
                        LeftGreenFirstValue = 175;
                        setLeftHeightFirstValue = true;
                        LeftHeightFirstValue = -64f;
                        if (interpolationValue < 1)
                        {
                            this.Left.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setLeftRedFirstValue = true;
                        LeftRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            SetProperty("Left.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.Left.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setLeftTextureHeightFirstValue = true;
                        LeftTextureHeightFirstValue = 128;
                        setLeftTextureLeftFirstValue = true;
                        LeftTextureLeftFirstValue = 0;
                        setLeftTextureTopFirstValue = true;
                        LeftTextureTopFirstValue = 64;
                        setLeftTextureWidthFirstValue = true;
                        LeftTextureWidthFirstValue = 64;
                        setLeftWidthFirstValue = true;
                        LeftWidthFirstValue = 32f;
                        if (interpolationValue < 1)
                        {
                            this.Left.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setLeftXFirstValue = true;
                        LeftXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Left.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Left.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setLeftYFirstValue = true;
                        LeftYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Left.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Left.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setMiddleAlphaFirstValue = true;
                        MiddleAlphaFirstValue = 255;
                        setMiddleBlueFirstValue = true;
                        MiddleBlueFirstValue = 0;
                        setMiddleGreenFirstValue = true;
                        MiddleGreenFirstValue = 30;
                        setMiddleHeightFirstValue = true;
                        MiddleHeightFirstValue = -32f;
                        if (interpolationValue < 1)
                        {
                            this.Middle.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setMiddleRedFirstValue = true;
                        MiddleRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            SetProperty("Middle.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.Middle.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setMiddleTextureHeightFirstValue = true;
                        MiddleTextureHeightFirstValue = 1;
                        setMiddleTextureLeftFirstValue = true;
                        MiddleTextureLeftFirstValue = 36;
                        setMiddleTextureTopFirstValue = true;
                        MiddleTextureTopFirstValue = 36;
                        setMiddleTextureWidthFirstValue = true;
                        MiddleTextureWidthFirstValue = 1;
                        setMiddleWidthFirstValue = true;
                        MiddleWidthFirstValue = -32f;
                        if (interpolationValue < 1)
                        {
                            this.Middle.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setMiddleXFirstValue = true;
                        MiddleXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Middle.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Middle.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setMiddleYFirstValue = true;
                        MiddleYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Middle.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Middle.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setRightBlueFirstValue = true;
                        RightBlueFirstValue = 0;
                        setRightGreenFirstValue = true;
                        RightGreenFirstValue = 175;
                        setRightHeightFirstValue = true;
                        RightHeightFirstValue = -64f;
                        if (interpolationValue < 1)
                        {
                            this.Right.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setRightRedFirstValue = true;
                        RightRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            SetProperty("Right.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.Right.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setRightTextureHeightFirstValue = true;
                        RightTextureHeightFirstValue = 128;
                        setRightTextureLeftFirstValue = true;
                        RightTextureLeftFirstValue = 192;
                        setRightTextureTopFirstValue = true;
                        RightTextureTopFirstValue = 64;
                        setRightTextureWidthFirstValue = true;
                        RightTextureWidthFirstValue = 64;
                        setRightWidthFirstValue = true;
                        RightWidthFirstValue = 32f;
                        if (interpolationValue < 1)
                        {
                            this.Right.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setRightXFirstValue = true;
                        RightXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Right.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Right.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setRightYFirstValue = true;
                        RightYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Right.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Right.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setTopBlueFirstValue = true;
                        TopBlueFirstValue = 0;
                        setTopGreenFirstValue = true;
                        TopGreenFirstValue = 175;
                        setTopHeightFirstValue = true;
                        TopHeightFirstValue = 32f;
                        if (interpolationValue < 1)
                        {
                            this.Top.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setTopRedFirstValue = true;
                        TopRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            SetProperty("Top.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.Top.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setTopTextureHeightFirstValue = true;
                        TopTextureHeightFirstValue = 64;
                        setTopTextureLeftFirstValue = true;
                        TopTextureLeftFirstValue = 64;
                        setTopTextureTopFirstValue = true;
                        TopTextureTopFirstValue = 0;
                        setTopTextureWidthFirstValue = true;
                        TopTextureWidthFirstValue = 128;
                        setTopWidthFirstValue = true;
                        TopWidthFirstValue = -64f;
                        if (interpolationValue < 1)
                        {
                            this.Top.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setTopXFirstValue = true;
                        TopXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Top.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Top.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setTopYFirstValue = true;
                        TopYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.Top.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Top.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setTopLeftBlueFirstValue = true;
                        TopLeftBlueFirstValue = 0;
                        setTopLeftGreenFirstValue = true;
                        TopLeftGreenFirstValue = 175;
                        setTopLeftHeightFirstValue = true;
                        TopLeftHeightFirstValue = 32f;
                        if (interpolationValue < 1)
                        {
                            this.TopLeft.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setTopLeftRedFirstValue = true;
                        TopLeftRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            SetProperty("TopLeft.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.TopLeft.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setTopLeftTextureHeightFirstValue = true;
                        TopLeftTextureHeightFirstValue = 64;
                        setTopLeftTextureLeftFirstValue = true;
                        TopLeftTextureLeftFirstValue = 0;
                        setTopLeftTextureTopFirstValue = true;
                        TopLeftTextureTopFirstValue = 0;
                        setTopLeftTextureWidthFirstValue = true;
                        TopLeftTextureWidthFirstValue = 64;
                        setTopLeftWidthFirstValue = true;
                        TopLeftWidthFirstValue = 32f;
                        if (interpolationValue < 1)
                        {
                            this.TopLeft.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setTopLeftXFirstValue = true;
                        TopLeftXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TopLeft.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TopLeft.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setTopLeftYFirstValue = true;
                        TopLeftYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TopLeft.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TopLeft.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setTopRightBlueFirstValue = true;
                        TopRightBlueFirstValue = 0;
                        setTopRightGreenFirstValue = true;
                        TopRightGreenFirstValue = 175;
                        setTopRightHeightFirstValue = true;
                        TopRightHeightFirstValue = 32f;
                        if (interpolationValue < 1)
                        {
                            this.TopRight.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setTopRightRedFirstValue = true;
                        TopRightRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            SetProperty("TopRight.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.TopRight.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setTopRightTextureHeightFirstValue = true;
                        TopRightTextureHeightFirstValue = 64;
                        setTopRightTextureLeftFirstValue = true;
                        TopRightTextureLeftFirstValue = 192;
                        setTopRightTextureTopFirstValue = true;
                        TopRightTextureTopFirstValue = 0;
                        setTopRightTextureWidthFirstValue = true;
                        TopRightTextureWidthFirstValue = 64;
                        setTopRightWidthFirstValue = true;
                        TopRightWidthFirstValue = 32f;
                        if (interpolationValue < 1)
                        {
                            this.TopRight.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setTopRightXFirstValue = true;
                        TopRightXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TopRight.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TopRight.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setTopRightYFirstValue = true;
                        TopRightYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TopRight.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TopRight.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Visible = true;
                        }
                        setWidthFirstValue = true;
                        WidthFirstValue = 8.223843f;
                        if (interpolationValue < 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.WrapsChildren = false;
                        }
                        setXFirstValue = true;
                        XFirstValue = -0.1339325f;
                        if (interpolationValue < 1)
                        {
                            this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setYFirstValue = true;
                        YFirstValue = -0.008815452f;
                        if (interpolationValue < 1)
                        {
                            this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
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
                        setBottomBlueSecondValue = true;
                        BottomBlueSecondValue = 0;
                        setBottomGreenSecondValue = true;
                        BottomGreenSecondValue = 175;
                        setBottomHeightSecondValue = true;
                        BottomHeightSecondValue = 32f;
                        if (interpolationValue >= 1)
                        {
                            this.Bottom.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setBottomRedSecondValue = true;
                        BottomRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("Bottom.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Bottom.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setBottomTextureHeightSecondValue = true;
                        BottomTextureHeightSecondValue = 64;
                        setBottomTextureLeftSecondValue = true;
                        BottomTextureLeftSecondValue = 64;
                        setBottomTextureTopSecondValue = true;
                        BottomTextureTopSecondValue = 192;
                        setBottomTextureWidthSecondValue = true;
                        BottomTextureWidthSecondValue = 128;
                        setBottomWidthSecondValue = true;
                        BottomWidthSecondValue = -64f;
                        if (interpolationValue >= 1)
                        {
                            this.Bottom.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setBottomXSecondValue = true;
                        BottomXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Bottom.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Bottom.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setBottomYSecondValue = true;
                        BottomYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Bottom.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Bottom.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setBottomLeftBlueSecondValue = true;
                        BottomLeftBlueSecondValue = 0;
                        setBottomLeftGreenSecondValue = true;
                        BottomLeftGreenSecondValue = 175;
                        setBottomLeftHeightSecondValue = true;
                        BottomLeftHeightSecondValue = 32f;
                        if (interpolationValue >= 1)
                        {
                            this.BottomLeft.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setBottomLeftRedSecondValue = true;
                        BottomLeftRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("BottomLeft.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.BottomLeft.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setBottomLeftTextureHeightSecondValue = true;
                        BottomLeftTextureHeightSecondValue = 64;
                        setBottomLeftTextureLeftSecondValue = true;
                        BottomLeftTextureLeftSecondValue = 0;
                        setBottomLeftTextureTopSecondValue = true;
                        BottomLeftTextureTopSecondValue = 192;
                        setBottomLeftTextureWidthSecondValue = true;
                        BottomLeftTextureWidthSecondValue = 64;
                        setBottomLeftWidthSecondValue = true;
                        BottomLeftWidthSecondValue = 32f;
                        if (interpolationValue >= 1)
                        {
                            this.BottomLeft.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setBottomLeftXSecondValue = true;
                        BottomLeftXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.BottomLeft.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.BottomLeft.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setBottomLeftYSecondValue = true;
                        BottomLeftYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.BottomLeft.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.BottomLeft.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setBottomRightBlueSecondValue = true;
                        BottomRightBlueSecondValue = 0;
                        setBottomRightGreenSecondValue = true;
                        BottomRightGreenSecondValue = 175;
                        setBottomRightHeightSecondValue = true;
                        BottomRightHeightSecondValue = 32f;
                        if (interpolationValue >= 1)
                        {
                            this.BottomRight.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setBottomRightRedSecondValue = true;
                        BottomRightRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("BottomRight.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.BottomRight.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setBottomRightTextureHeightSecondValue = true;
                        BottomRightTextureHeightSecondValue = 64;
                        setBottomRightTextureLeftSecondValue = true;
                        BottomRightTextureLeftSecondValue = 192;
                        setBottomRightTextureTopSecondValue = true;
                        BottomRightTextureTopSecondValue = 192;
                        setBottomRightTextureWidthSecondValue = true;
                        BottomRightTextureWidthSecondValue = 64;
                        setBottomRightWidthSecondValue = true;
                        BottomRightWidthSecondValue = 32f;
                        if (interpolationValue >= 1)
                        {
                            this.BottomRight.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setBottomRightXSecondValue = true;
                        BottomRightXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.BottomRight.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.BottomRight.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setBottomRightYSecondValue = true;
                        BottomRightYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.BottomRight.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.BottomRight.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ChildrenLayout = Gum.Managers.ChildrenLayout.Regular;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ClipsChildren = false;
                        }
                        setHeightSecondValue = true;
                        HeightSecondValue = 12.99866f;
                        if (interpolationValue >= 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setLeftBlueSecondValue = true;
                        LeftBlueSecondValue = 0;
                        setLeftGreenSecondValue = true;
                        LeftGreenSecondValue = 175;
                        setLeftHeightSecondValue = true;
                        LeftHeightSecondValue = -64f;
                        if (interpolationValue >= 1)
                        {
                            this.Left.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setLeftRedSecondValue = true;
                        LeftRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("Left.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Left.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setLeftTextureHeightSecondValue = true;
                        LeftTextureHeightSecondValue = 128;
                        setLeftTextureLeftSecondValue = true;
                        LeftTextureLeftSecondValue = 0;
                        setLeftTextureTopSecondValue = true;
                        LeftTextureTopSecondValue = 64;
                        setLeftTextureWidthSecondValue = true;
                        LeftTextureWidthSecondValue = 64;
                        setLeftWidthSecondValue = true;
                        LeftWidthSecondValue = 32f;
                        if (interpolationValue >= 1)
                        {
                            this.Left.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setLeftXSecondValue = true;
                        LeftXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Left.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Left.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setLeftYSecondValue = true;
                        LeftYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Left.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Left.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setMiddleAlphaSecondValue = true;
                        MiddleAlphaSecondValue = 255;
                        setMiddleBlueSecondValue = true;
                        MiddleBlueSecondValue = 0;
                        setMiddleGreenSecondValue = true;
                        MiddleGreenSecondValue = 30;
                        setMiddleHeightSecondValue = true;
                        MiddleHeightSecondValue = -32f;
                        if (interpolationValue >= 1)
                        {
                            this.Middle.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setMiddleRedSecondValue = true;
                        MiddleRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("Middle.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Middle.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setMiddleTextureHeightSecondValue = true;
                        MiddleTextureHeightSecondValue = 1;
                        setMiddleTextureLeftSecondValue = true;
                        MiddleTextureLeftSecondValue = 36;
                        setMiddleTextureTopSecondValue = true;
                        MiddleTextureTopSecondValue = 36;
                        setMiddleTextureWidthSecondValue = true;
                        MiddleTextureWidthSecondValue = 1;
                        setMiddleWidthSecondValue = true;
                        MiddleWidthSecondValue = -32f;
                        if (interpolationValue >= 1)
                        {
                            this.Middle.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setMiddleXSecondValue = true;
                        MiddleXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Middle.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Middle.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setMiddleYSecondValue = true;
                        MiddleYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Middle.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Middle.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setRightBlueSecondValue = true;
                        RightBlueSecondValue = 0;
                        setRightGreenSecondValue = true;
                        RightGreenSecondValue = 175;
                        setRightHeightSecondValue = true;
                        RightHeightSecondValue = -64f;
                        if (interpolationValue >= 1)
                        {
                            this.Right.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setRightRedSecondValue = true;
                        RightRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("Right.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Right.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setRightTextureHeightSecondValue = true;
                        RightTextureHeightSecondValue = 128;
                        setRightTextureLeftSecondValue = true;
                        RightTextureLeftSecondValue = 192;
                        setRightTextureTopSecondValue = true;
                        RightTextureTopSecondValue = 64;
                        setRightTextureWidthSecondValue = true;
                        RightTextureWidthSecondValue = 64;
                        setRightWidthSecondValue = true;
                        RightWidthSecondValue = 32f;
                        if (interpolationValue >= 1)
                        {
                            this.Right.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setRightXSecondValue = true;
                        RightXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Right.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Right.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setRightYSecondValue = true;
                        RightYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Right.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Right.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setTopBlueSecondValue = true;
                        TopBlueSecondValue = 0;
                        setTopGreenSecondValue = true;
                        TopGreenSecondValue = 175;
                        setTopHeightSecondValue = true;
                        TopHeightSecondValue = 32f;
                        if (interpolationValue >= 1)
                        {
                            this.Top.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setTopRedSecondValue = true;
                        TopRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("Top.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Top.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setTopTextureHeightSecondValue = true;
                        TopTextureHeightSecondValue = 64;
                        setTopTextureLeftSecondValue = true;
                        TopTextureLeftSecondValue = 64;
                        setTopTextureTopSecondValue = true;
                        TopTextureTopSecondValue = 0;
                        setTopTextureWidthSecondValue = true;
                        TopTextureWidthSecondValue = 128;
                        setTopWidthSecondValue = true;
                        TopWidthSecondValue = -64f;
                        if (interpolationValue >= 1)
                        {
                            this.Top.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setTopXSecondValue = true;
                        TopXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Top.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Top.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setTopYSecondValue = true;
                        TopYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.Top.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Top.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setTopLeftBlueSecondValue = true;
                        TopLeftBlueSecondValue = 0;
                        setTopLeftGreenSecondValue = true;
                        TopLeftGreenSecondValue = 175;
                        setTopLeftHeightSecondValue = true;
                        TopLeftHeightSecondValue = 32f;
                        if (interpolationValue >= 1)
                        {
                            this.TopLeft.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setTopLeftRedSecondValue = true;
                        TopLeftRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("TopLeft.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TopLeft.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setTopLeftTextureHeightSecondValue = true;
                        TopLeftTextureHeightSecondValue = 64;
                        setTopLeftTextureLeftSecondValue = true;
                        TopLeftTextureLeftSecondValue = 0;
                        setTopLeftTextureTopSecondValue = true;
                        TopLeftTextureTopSecondValue = 0;
                        setTopLeftTextureWidthSecondValue = true;
                        TopLeftTextureWidthSecondValue = 64;
                        setTopLeftWidthSecondValue = true;
                        TopLeftWidthSecondValue = 32f;
                        if (interpolationValue >= 1)
                        {
                            this.TopLeft.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setTopLeftXSecondValue = true;
                        TopLeftXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TopLeft.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TopLeft.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setTopLeftYSecondValue = true;
                        TopLeftYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TopLeft.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TopLeft.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setTopRightBlueSecondValue = true;
                        TopRightBlueSecondValue = 0;
                        setTopRightGreenSecondValue = true;
                        TopRightGreenSecondValue = 175;
                        setTopRightHeightSecondValue = true;
                        TopRightHeightSecondValue = 32f;
                        if (interpolationValue >= 1)
                        {
                            this.TopRight.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setTopRightRedSecondValue = true;
                        TopRightRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("TopRight.SourceFile", "AllUIAssets.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TopRight.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        }
                        setTopRightTextureHeightSecondValue = true;
                        TopRightTextureHeightSecondValue = 64;
                        setTopRightTextureLeftSecondValue = true;
                        TopRightTextureLeftSecondValue = 192;
                        setTopRightTextureTopSecondValue = true;
                        TopRightTextureTopSecondValue = 0;
                        setTopRightTextureWidthSecondValue = true;
                        TopRightTextureWidthSecondValue = 64;
                        setTopRightWidthSecondValue = true;
                        TopRightWidthSecondValue = 32f;
                        if (interpolationValue >= 1)
                        {
                            this.TopRight.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setTopRightXSecondValue = true;
                        TopRightXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TopRight.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TopRight.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setTopRightYSecondValue = true;
                        TopRightYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TopRight.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TopRight.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Visible = true;
                        }
                        setWidthSecondValue = true;
                        WidthSecondValue = 8.223843f;
                        if (interpolationValue >= 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.WrapsChildren = false;
                        }
                        setXSecondValue = true;
                        XSecondValue = -0.1339325f;
                        if (interpolationValue >= 1)
                        {
                            this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setYSecondValue = true;
                        YSecondValue = -0.008815452f;
                        if (interpolationValue >= 1)
                        {
                            this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        break;
                }
                if (setBottomBlueFirstValue && setBottomBlueSecondValue)
                {
                    Bottom.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(BottomBlueFirstValue* (1 - interpolationValue) + BottomBlueSecondValue * interpolationValue);
                }
                if (setBottomGreenFirstValue && setBottomGreenSecondValue)
                {
                    Bottom.Green = FlatRedBall.Math.MathFunctions.RoundToInt(BottomGreenFirstValue* (1 - interpolationValue) + BottomGreenSecondValue * interpolationValue);
                }
                if (setBottomHeightFirstValue && setBottomHeightSecondValue)
                {
                    Bottom.Height = BottomHeightFirstValue * (1 - interpolationValue) + BottomHeightSecondValue * interpolationValue;
                }
                if (setBottomRedFirstValue && setBottomRedSecondValue)
                {
                    Bottom.Red = FlatRedBall.Math.MathFunctions.RoundToInt(BottomRedFirstValue* (1 - interpolationValue) + BottomRedSecondValue * interpolationValue);
                }
                if (setBottomTextureHeightFirstValue && setBottomTextureHeightSecondValue)
                {
                    Bottom.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(BottomTextureHeightFirstValue* (1 - interpolationValue) + BottomTextureHeightSecondValue * interpolationValue);
                }
                if (setBottomTextureLeftFirstValue && setBottomTextureLeftSecondValue)
                {
                    Bottom.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(BottomTextureLeftFirstValue* (1 - interpolationValue) + BottomTextureLeftSecondValue * interpolationValue);
                }
                if (setBottomTextureTopFirstValue && setBottomTextureTopSecondValue)
                {
                    Bottom.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(BottomTextureTopFirstValue* (1 - interpolationValue) + BottomTextureTopSecondValue * interpolationValue);
                }
                if (setBottomTextureWidthFirstValue && setBottomTextureWidthSecondValue)
                {
                    Bottom.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(BottomTextureWidthFirstValue* (1 - interpolationValue) + BottomTextureWidthSecondValue * interpolationValue);
                }
                if (setBottomWidthFirstValue && setBottomWidthSecondValue)
                {
                    Bottom.Width = BottomWidthFirstValue * (1 - interpolationValue) + BottomWidthSecondValue * interpolationValue;
                }
                if (setBottomXFirstValue && setBottomXSecondValue)
                {
                    Bottom.X = BottomXFirstValue * (1 - interpolationValue) + BottomXSecondValue * interpolationValue;
                }
                if (setBottomYFirstValue && setBottomYSecondValue)
                {
                    Bottom.Y = BottomYFirstValue * (1 - interpolationValue) + BottomYSecondValue * interpolationValue;
                }
                if (setBottomLeftBlueFirstValue && setBottomLeftBlueSecondValue)
                {
                    BottomLeft.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(BottomLeftBlueFirstValue* (1 - interpolationValue) + BottomLeftBlueSecondValue * interpolationValue);
                }
                if (setBottomLeftGreenFirstValue && setBottomLeftGreenSecondValue)
                {
                    BottomLeft.Green = FlatRedBall.Math.MathFunctions.RoundToInt(BottomLeftGreenFirstValue* (1 - interpolationValue) + BottomLeftGreenSecondValue * interpolationValue);
                }
                if (setBottomLeftHeightFirstValue && setBottomLeftHeightSecondValue)
                {
                    BottomLeft.Height = BottomLeftHeightFirstValue * (1 - interpolationValue) + BottomLeftHeightSecondValue * interpolationValue;
                }
                if (setBottomLeftRedFirstValue && setBottomLeftRedSecondValue)
                {
                    BottomLeft.Red = FlatRedBall.Math.MathFunctions.RoundToInt(BottomLeftRedFirstValue* (1 - interpolationValue) + BottomLeftRedSecondValue * interpolationValue);
                }
                if (setBottomLeftTextureHeightFirstValue && setBottomLeftTextureHeightSecondValue)
                {
                    BottomLeft.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(BottomLeftTextureHeightFirstValue* (1 - interpolationValue) + BottomLeftTextureHeightSecondValue * interpolationValue);
                }
                if (setBottomLeftTextureLeftFirstValue && setBottomLeftTextureLeftSecondValue)
                {
                    BottomLeft.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(BottomLeftTextureLeftFirstValue* (1 - interpolationValue) + BottomLeftTextureLeftSecondValue * interpolationValue);
                }
                if (setBottomLeftTextureTopFirstValue && setBottomLeftTextureTopSecondValue)
                {
                    BottomLeft.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(BottomLeftTextureTopFirstValue* (1 - interpolationValue) + BottomLeftTextureTopSecondValue * interpolationValue);
                }
                if (setBottomLeftTextureWidthFirstValue && setBottomLeftTextureWidthSecondValue)
                {
                    BottomLeft.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(BottomLeftTextureWidthFirstValue* (1 - interpolationValue) + BottomLeftTextureWidthSecondValue * interpolationValue);
                }
                if (setBottomLeftWidthFirstValue && setBottomLeftWidthSecondValue)
                {
                    BottomLeft.Width = BottomLeftWidthFirstValue * (1 - interpolationValue) + BottomLeftWidthSecondValue * interpolationValue;
                }
                if (setBottomLeftXFirstValue && setBottomLeftXSecondValue)
                {
                    BottomLeft.X = BottomLeftXFirstValue * (1 - interpolationValue) + BottomLeftXSecondValue * interpolationValue;
                }
                if (setBottomLeftYFirstValue && setBottomLeftYSecondValue)
                {
                    BottomLeft.Y = BottomLeftYFirstValue * (1 - interpolationValue) + BottomLeftYSecondValue * interpolationValue;
                }
                if (setBottomRightBlueFirstValue && setBottomRightBlueSecondValue)
                {
                    BottomRight.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(BottomRightBlueFirstValue* (1 - interpolationValue) + BottomRightBlueSecondValue * interpolationValue);
                }
                if (setBottomRightGreenFirstValue && setBottomRightGreenSecondValue)
                {
                    BottomRight.Green = FlatRedBall.Math.MathFunctions.RoundToInt(BottomRightGreenFirstValue* (1 - interpolationValue) + BottomRightGreenSecondValue * interpolationValue);
                }
                if (setBottomRightHeightFirstValue && setBottomRightHeightSecondValue)
                {
                    BottomRight.Height = BottomRightHeightFirstValue * (1 - interpolationValue) + BottomRightHeightSecondValue * interpolationValue;
                }
                if (setBottomRightRedFirstValue && setBottomRightRedSecondValue)
                {
                    BottomRight.Red = FlatRedBall.Math.MathFunctions.RoundToInt(BottomRightRedFirstValue* (1 - interpolationValue) + BottomRightRedSecondValue * interpolationValue);
                }
                if (setBottomRightTextureHeightFirstValue && setBottomRightTextureHeightSecondValue)
                {
                    BottomRight.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(BottomRightTextureHeightFirstValue* (1 - interpolationValue) + BottomRightTextureHeightSecondValue * interpolationValue);
                }
                if (setBottomRightTextureLeftFirstValue && setBottomRightTextureLeftSecondValue)
                {
                    BottomRight.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(BottomRightTextureLeftFirstValue* (1 - interpolationValue) + BottomRightTextureLeftSecondValue * interpolationValue);
                }
                if (setBottomRightTextureTopFirstValue && setBottomRightTextureTopSecondValue)
                {
                    BottomRight.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(BottomRightTextureTopFirstValue* (1 - interpolationValue) + BottomRightTextureTopSecondValue * interpolationValue);
                }
                if (setBottomRightTextureWidthFirstValue && setBottomRightTextureWidthSecondValue)
                {
                    BottomRight.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(BottomRightTextureWidthFirstValue* (1 - interpolationValue) + BottomRightTextureWidthSecondValue * interpolationValue);
                }
                if (setBottomRightWidthFirstValue && setBottomRightWidthSecondValue)
                {
                    BottomRight.Width = BottomRightWidthFirstValue * (1 - interpolationValue) + BottomRightWidthSecondValue * interpolationValue;
                }
                if (setBottomRightXFirstValue && setBottomRightXSecondValue)
                {
                    BottomRight.X = BottomRightXFirstValue * (1 - interpolationValue) + BottomRightXSecondValue * interpolationValue;
                }
                if (setBottomRightYFirstValue && setBottomRightYSecondValue)
                {
                    BottomRight.Y = BottomRightYFirstValue * (1 - interpolationValue) + BottomRightYSecondValue * interpolationValue;
                }
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
                }
                if (setLeftBlueFirstValue && setLeftBlueSecondValue)
                {
                    Left.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(LeftBlueFirstValue* (1 - interpolationValue) + LeftBlueSecondValue * interpolationValue);
                }
                if (setLeftGreenFirstValue && setLeftGreenSecondValue)
                {
                    Left.Green = FlatRedBall.Math.MathFunctions.RoundToInt(LeftGreenFirstValue* (1 - interpolationValue) + LeftGreenSecondValue * interpolationValue);
                }
                if (setLeftHeightFirstValue && setLeftHeightSecondValue)
                {
                    Left.Height = LeftHeightFirstValue * (1 - interpolationValue) + LeftHeightSecondValue * interpolationValue;
                }
                if (setLeftRedFirstValue && setLeftRedSecondValue)
                {
                    Left.Red = FlatRedBall.Math.MathFunctions.RoundToInt(LeftRedFirstValue* (1 - interpolationValue) + LeftRedSecondValue * interpolationValue);
                }
                if (setLeftTextureHeightFirstValue && setLeftTextureHeightSecondValue)
                {
                    Left.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(LeftTextureHeightFirstValue* (1 - interpolationValue) + LeftTextureHeightSecondValue * interpolationValue);
                }
                if (setLeftTextureLeftFirstValue && setLeftTextureLeftSecondValue)
                {
                    Left.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(LeftTextureLeftFirstValue* (1 - interpolationValue) + LeftTextureLeftSecondValue * interpolationValue);
                }
                if (setLeftTextureTopFirstValue && setLeftTextureTopSecondValue)
                {
                    Left.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(LeftTextureTopFirstValue* (1 - interpolationValue) + LeftTextureTopSecondValue * interpolationValue);
                }
                if (setLeftTextureWidthFirstValue && setLeftTextureWidthSecondValue)
                {
                    Left.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(LeftTextureWidthFirstValue* (1 - interpolationValue) + LeftTextureWidthSecondValue * interpolationValue);
                }
                if (setLeftWidthFirstValue && setLeftWidthSecondValue)
                {
                    Left.Width = LeftWidthFirstValue * (1 - interpolationValue) + LeftWidthSecondValue * interpolationValue;
                }
                if (setLeftXFirstValue && setLeftXSecondValue)
                {
                    Left.X = LeftXFirstValue * (1 - interpolationValue) + LeftXSecondValue * interpolationValue;
                }
                if (setLeftYFirstValue && setLeftYSecondValue)
                {
                    Left.Y = LeftYFirstValue * (1 - interpolationValue) + LeftYSecondValue * interpolationValue;
                }
                if (setMiddleAlphaFirstValue && setMiddleAlphaSecondValue)
                {
                    Middle.Alpha = FlatRedBall.Math.MathFunctions.RoundToInt(MiddleAlphaFirstValue* (1 - interpolationValue) + MiddleAlphaSecondValue * interpolationValue);
                }
                if (setMiddleBlueFirstValue && setMiddleBlueSecondValue)
                {
                    Middle.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(MiddleBlueFirstValue* (1 - interpolationValue) + MiddleBlueSecondValue * interpolationValue);
                }
                if (setMiddleGreenFirstValue && setMiddleGreenSecondValue)
                {
                    Middle.Green = FlatRedBall.Math.MathFunctions.RoundToInt(MiddleGreenFirstValue* (1 - interpolationValue) + MiddleGreenSecondValue * interpolationValue);
                }
                if (setMiddleHeightFirstValue && setMiddleHeightSecondValue)
                {
                    Middle.Height = MiddleHeightFirstValue * (1 - interpolationValue) + MiddleHeightSecondValue * interpolationValue;
                }
                if (setMiddleRedFirstValue && setMiddleRedSecondValue)
                {
                    Middle.Red = FlatRedBall.Math.MathFunctions.RoundToInt(MiddleRedFirstValue* (1 - interpolationValue) + MiddleRedSecondValue * interpolationValue);
                }
                if (setMiddleTextureHeightFirstValue && setMiddleTextureHeightSecondValue)
                {
                    Middle.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(MiddleTextureHeightFirstValue* (1 - interpolationValue) + MiddleTextureHeightSecondValue * interpolationValue);
                }
                if (setMiddleTextureLeftFirstValue && setMiddleTextureLeftSecondValue)
                {
                    Middle.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(MiddleTextureLeftFirstValue* (1 - interpolationValue) + MiddleTextureLeftSecondValue * interpolationValue);
                }
                if (setMiddleTextureTopFirstValue && setMiddleTextureTopSecondValue)
                {
                    Middle.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(MiddleTextureTopFirstValue* (1 - interpolationValue) + MiddleTextureTopSecondValue * interpolationValue);
                }
                if (setMiddleTextureWidthFirstValue && setMiddleTextureWidthSecondValue)
                {
                    Middle.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(MiddleTextureWidthFirstValue* (1 - interpolationValue) + MiddleTextureWidthSecondValue * interpolationValue);
                }
                if (setMiddleWidthFirstValue && setMiddleWidthSecondValue)
                {
                    Middle.Width = MiddleWidthFirstValue * (1 - interpolationValue) + MiddleWidthSecondValue * interpolationValue;
                }
                if (setMiddleXFirstValue && setMiddleXSecondValue)
                {
                    Middle.X = MiddleXFirstValue * (1 - interpolationValue) + MiddleXSecondValue * interpolationValue;
                }
                if (setMiddleYFirstValue && setMiddleYSecondValue)
                {
                    Middle.Y = MiddleYFirstValue * (1 - interpolationValue) + MiddleYSecondValue * interpolationValue;
                }
                if (setRightBlueFirstValue && setRightBlueSecondValue)
                {
                    Right.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(RightBlueFirstValue* (1 - interpolationValue) + RightBlueSecondValue * interpolationValue);
                }
                if (setRightGreenFirstValue && setRightGreenSecondValue)
                {
                    Right.Green = FlatRedBall.Math.MathFunctions.RoundToInt(RightGreenFirstValue* (1 - interpolationValue) + RightGreenSecondValue * interpolationValue);
                }
                if (setRightHeightFirstValue && setRightHeightSecondValue)
                {
                    Right.Height = RightHeightFirstValue * (1 - interpolationValue) + RightHeightSecondValue * interpolationValue;
                }
                if (setRightRedFirstValue && setRightRedSecondValue)
                {
                    Right.Red = FlatRedBall.Math.MathFunctions.RoundToInt(RightRedFirstValue* (1 - interpolationValue) + RightRedSecondValue * interpolationValue);
                }
                if (setRightTextureHeightFirstValue && setRightTextureHeightSecondValue)
                {
                    Right.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(RightTextureHeightFirstValue* (1 - interpolationValue) + RightTextureHeightSecondValue * interpolationValue);
                }
                if (setRightTextureLeftFirstValue && setRightTextureLeftSecondValue)
                {
                    Right.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(RightTextureLeftFirstValue* (1 - interpolationValue) + RightTextureLeftSecondValue * interpolationValue);
                }
                if (setRightTextureTopFirstValue && setRightTextureTopSecondValue)
                {
                    Right.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(RightTextureTopFirstValue* (1 - interpolationValue) + RightTextureTopSecondValue * interpolationValue);
                }
                if (setRightTextureWidthFirstValue && setRightTextureWidthSecondValue)
                {
                    Right.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(RightTextureWidthFirstValue* (1 - interpolationValue) + RightTextureWidthSecondValue * interpolationValue);
                }
                if (setRightWidthFirstValue && setRightWidthSecondValue)
                {
                    Right.Width = RightWidthFirstValue * (1 - interpolationValue) + RightWidthSecondValue * interpolationValue;
                }
                if (setRightXFirstValue && setRightXSecondValue)
                {
                    Right.X = RightXFirstValue * (1 - interpolationValue) + RightXSecondValue * interpolationValue;
                }
                if (setRightYFirstValue && setRightYSecondValue)
                {
                    Right.Y = RightYFirstValue * (1 - interpolationValue) + RightYSecondValue * interpolationValue;
                }
                if (setTopBlueFirstValue && setTopBlueSecondValue)
                {
                    Top.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(TopBlueFirstValue* (1 - interpolationValue) + TopBlueSecondValue * interpolationValue);
                }
                if (setTopGreenFirstValue && setTopGreenSecondValue)
                {
                    Top.Green = FlatRedBall.Math.MathFunctions.RoundToInt(TopGreenFirstValue* (1 - interpolationValue) + TopGreenSecondValue * interpolationValue);
                }
                if (setTopHeightFirstValue && setTopHeightSecondValue)
                {
                    Top.Height = TopHeightFirstValue * (1 - interpolationValue) + TopHeightSecondValue * interpolationValue;
                }
                if (setTopRedFirstValue && setTopRedSecondValue)
                {
                    Top.Red = FlatRedBall.Math.MathFunctions.RoundToInt(TopRedFirstValue* (1 - interpolationValue) + TopRedSecondValue * interpolationValue);
                }
                if (setTopTextureHeightFirstValue && setTopTextureHeightSecondValue)
                {
                    Top.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(TopTextureHeightFirstValue* (1 - interpolationValue) + TopTextureHeightSecondValue * interpolationValue);
                }
                if (setTopTextureLeftFirstValue && setTopTextureLeftSecondValue)
                {
                    Top.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(TopTextureLeftFirstValue* (1 - interpolationValue) + TopTextureLeftSecondValue * interpolationValue);
                }
                if (setTopTextureTopFirstValue && setTopTextureTopSecondValue)
                {
                    Top.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(TopTextureTopFirstValue* (1 - interpolationValue) + TopTextureTopSecondValue * interpolationValue);
                }
                if (setTopTextureWidthFirstValue && setTopTextureWidthSecondValue)
                {
                    Top.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(TopTextureWidthFirstValue* (1 - interpolationValue) + TopTextureWidthSecondValue * interpolationValue);
                }
                if (setTopWidthFirstValue && setTopWidthSecondValue)
                {
                    Top.Width = TopWidthFirstValue * (1 - interpolationValue) + TopWidthSecondValue * interpolationValue;
                }
                if (setTopXFirstValue && setTopXSecondValue)
                {
                    Top.X = TopXFirstValue * (1 - interpolationValue) + TopXSecondValue * interpolationValue;
                }
                if (setTopYFirstValue && setTopYSecondValue)
                {
                    Top.Y = TopYFirstValue * (1 - interpolationValue) + TopYSecondValue * interpolationValue;
                }
                if (setTopLeftBlueFirstValue && setTopLeftBlueSecondValue)
                {
                    TopLeft.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(TopLeftBlueFirstValue* (1 - interpolationValue) + TopLeftBlueSecondValue * interpolationValue);
                }
                if (setTopLeftGreenFirstValue && setTopLeftGreenSecondValue)
                {
                    TopLeft.Green = FlatRedBall.Math.MathFunctions.RoundToInt(TopLeftGreenFirstValue* (1 - interpolationValue) + TopLeftGreenSecondValue * interpolationValue);
                }
                if (setTopLeftHeightFirstValue && setTopLeftHeightSecondValue)
                {
                    TopLeft.Height = TopLeftHeightFirstValue * (1 - interpolationValue) + TopLeftHeightSecondValue * interpolationValue;
                }
                if (setTopLeftRedFirstValue && setTopLeftRedSecondValue)
                {
                    TopLeft.Red = FlatRedBall.Math.MathFunctions.RoundToInt(TopLeftRedFirstValue* (1 - interpolationValue) + TopLeftRedSecondValue * interpolationValue);
                }
                if (setTopLeftTextureHeightFirstValue && setTopLeftTextureHeightSecondValue)
                {
                    TopLeft.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(TopLeftTextureHeightFirstValue* (1 - interpolationValue) + TopLeftTextureHeightSecondValue * interpolationValue);
                }
                if (setTopLeftTextureLeftFirstValue && setTopLeftTextureLeftSecondValue)
                {
                    TopLeft.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(TopLeftTextureLeftFirstValue* (1 - interpolationValue) + TopLeftTextureLeftSecondValue * interpolationValue);
                }
                if (setTopLeftTextureTopFirstValue && setTopLeftTextureTopSecondValue)
                {
                    TopLeft.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(TopLeftTextureTopFirstValue* (1 - interpolationValue) + TopLeftTextureTopSecondValue * interpolationValue);
                }
                if (setTopLeftTextureWidthFirstValue && setTopLeftTextureWidthSecondValue)
                {
                    TopLeft.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(TopLeftTextureWidthFirstValue* (1 - interpolationValue) + TopLeftTextureWidthSecondValue * interpolationValue);
                }
                if (setTopLeftWidthFirstValue && setTopLeftWidthSecondValue)
                {
                    TopLeft.Width = TopLeftWidthFirstValue * (1 - interpolationValue) + TopLeftWidthSecondValue * interpolationValue;
                }
                if (setTopLeftXFirstValue && setTopLeftXSecondValue)
                {
                    TopLeft.X = TopLeftXFirstValue * (1 - interpolationValue) + TopLeftXSecondValue * interpolationValue;
                }
                if (setTopLeftYFirstValue && setTopLeftYSecondValue)
                {
                    TopLeft.Y = TopLeftYFirstValue * (1 - interpolationValue) + TopLeftYSecondValue * interpolationValue;
                }
                if (setTopRightBlueFirstValue && setTopRightBlueSecondValue)
                {
                    TopRight.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(TopRightBlueFirstValue* (1 - interpolationValue) + TopRightBlueSecondValue * interpolationValue);
                }
                if (setTopRightGreenFirstValue && setTopRightGreenSecondValue)
                {
                    TopRight.Green = FlatRedBall.Math.MathFunctions.RoundToInt(TopRightGreenFirstValue* (1 - interpolationValue) + TopRightGreenSecondValue * interpolationValue);
                }
                if (setTopRightHeightFirstValue && setTopRightHeightSecondValue)
                {
                    TopRight.Height = TopRightHeightFirstValue * (1 - interpolationValue) + TopRightHeightSecondValue * interpolationValue;
                }
                if (setTopRightRedFirstValue && setTopRightRedSecondValue)
                {
                    TopRight.Red = FlatRedBall.Math.MathFunctions.RoundToInt(TopRightRedFirstValue* (1 - interpolationValue) + TopRightRedSecondValue * interpolationValue);
                }
                if (setTopRightTextureHeightFirstValue && setTopRightTextureHeightSecondValue)
                {
                    TopRight.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(TopRightTextureHeightFirstValue* (1 - interpolationValue) + TopRightTextureHeightSecondValue * interpolationValue);
                }
                if (setTopRightTextureLeftFirstValue && setTopRightTextureLeftSecondValue)
                {
                    TopRight.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(TopRightTextureLeftFirstValue* (1 - interpolationValue) + TopRightTextureLeftSecondValue * interpolationValue);
                }
                if (setTopRightTextureTopFirstValue && setTopRightTextureTopSecondValue)
                {
                    TopRight.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(TopRightTextureTopFirstValue* (1 - interpolationValue) + TopRightTextureTopSecondValue * interpolationValue);
                }
                if (setTopRightTextureWidthFirstValue && setTopRightTextureWidthSecondValue)
                {
                    TopRight.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(TopRightTextureWidthFirstValue* (1 - interpolationValue) + TopRightTextureWidthSecondValue * interpolationValue);
                }
                if (setTopRightWidthFirstValue && setTopRightWidthSecondValue)
                {
                    TopRight.Width = TopRightWidthFirstValue * (1 - interpolationValue) + TopRightWidthSecondValue * interpolationValue;
                }
                if (setTopRightXFirstValue && setTopRightXSecondValue)
                {
                    TopRight.X = TopRightXFirstValue * (1 - interpolationValue) + TopRightXSecondValue * interpolationValue;
                }
                if (setTopRightYFirstValue && setTopRightYSecondValue)
                {
                    TopRight.Y = TopRightYFirstValue * (1 - interpolationValue) + TopRightYSecondValue * interpolationValue;
                }
                if (setWidthFirstValue && setWidthSecondValue)
                {
                    Width = WidthFirstValue * (1 - interpolationValue) + WidthSecondValue * interpolationValue;
                }
                if (setXFirstValue && setXSecondValue)
                {
                    X = XFirstValue * (1 - interpolationValue) + XSecondValue * interpolationValue;
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
            public void InterpolateBetween (FlickerState firstState, FlickerState secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setBottomTextureLeftFirstValue = false;
                bool setBottomTextureLeftSecondValue = false;
                int BottomTextureLeftFirstValue= 0;
                int BottomTextureLeftSecondValue= 0;
                bool setBottomTextureTopFirstValue = false;
                bool setBottomTextureTopSecondValue = false;
                int BottomTextureTopFirstValue= 0;
                int BottomTextureTopSecondValue= 0;
                bool setBottomLeftTextureLeftFirstValue = false;
                bool setBottomLeftTextureLeftSecondValue = false;
                int BottomLeftTextureLeftFirstValue= 0;
                int BottomLeftTextureLeftSecondValue= 0;
                bool setBottomLeftTextureTopFirstValue = false;
                bool setBottomLeftTextureTopSecondValue = false;
                int BottomLeftTextureTopFirstValue= 0;
                int BottomLeftTextureTopSecondValue= 0;
                bool setBottomRightTextureLeftFirstValue = false;
                bool setBottomRightTextureLeftSecondValue = false;
                int BottomRightTextureLeftFirstValue= 0;
                int BottomRightTextureLeftSecondValue= 0;
                bool setBottomRightTextureTopFirstValue = false;
                bool setBottomRightTextureTopSecondValue = false;
                int BottomRightTextureTopFirstValue= 0;
                int BottomRightTextureTopSecondValue= 0;
                bool setLeftTextureLeftFirstValue = false;
                bool setLeftTextureLeftSecondValue = false;
                int LeftTextureLeftFirstValue= 0;
                int LeftTextureLeftSecondValue= 0;
                bool setLeftTextureTopFirstValue = false;
                bool setLeftTextureTopSecondValue = false;
                int LeftTextureTopFirstValue= 0;
                int LeftTextureTopSecondValue= 0;
                bool setRightTextureLeftFirstValue = false;
                bool setRightTextureLeftSecondValue = false;
                int RightTextureLeftFirstValue= 0;
                int RightTextureLeftSecondValue= 0;
                bool setRightTextureTopFirstValue = false;
                bool setRightTextureTopSecondValue = false;
                int RightTextureTopFirstValue= 0;
                int RightTextureTopSecondValue= 0;
                bool setTopTextureLeftFirstValue = false;
                bool setTopTextureLeftSecondValue = false;
                int TopTextureLeftFirstValue= 0;
                int TopTextureLeftSecondValue= 0;
                bool setTopTextureTopFirstValue = false;
                bool setTopTextureTopSecondValue = false;
                int TopTextureTopFirstValue= 0;
                int TopTextureTopSecondValue= 0;
                bool setTopLeftTextureLeftFirstValue = false;
                bool setTopLeftTextureLeftSecondValue = false;
                int TopLeftTextureLeftFirstValue= 0;
                int TopLeftTextureLeftSecondValue= 0;
                bool setTopLeftTextureTopFirstValue = false;
                bool setTopLeftTextureTopSecondValue = false;
                int TopLeftTextureTopFirstValue= 0;
                int TopLeftTextureTopSecondValue= 0;
                bool setTopRightTextureLeftFirstValue = false;
                bool setTopRightTextureLeftSecondValue = false;
                int TopRightTextureLeftFirstValue= 0;
                int TopRightTextureLeftSecondValue= 0;
                bool setTopRightTextureTopFirstValue = false;
                bool setTopRightTextureTopSecondValue = false;
                int TopRightTextureTopFirstValue= 0;
                int TopRightTextureTopSecondValue= 0;
                switch(firstState)
                {
                    case  FlickerState.Flicker1:
                        setBottomTextureLeftFirstValue = true;
                        BottomTextureLeftFirstValue = 64;
                        setBottomTextureTopFirstValue = true;
                        BottomTextureTopFirstValue = 192;
                        setBottomLeftTextureLeftFirstValue = true;
                        BottomLeftTextureLeftFirstValue = 0;
                        setBottomLeftTextureTopFirstValue = true;
                        BottomLeftTextureTopFirstValue = 192;
                        setBottomRightTextureLeftFirstValue = true;
                        BottomRightTextureLeftFirstValue = 192;
                        setBottomRightTextureTopFirstValue = true;
                        BottomRightTextureTopFirstValue = 192;
                        setLeftTextureLeftFirstValue = true;
                        LeftTextureLeftFirstValue = 0;
                        setLeftTextureTopFirstValue = true;
                        LeftTextureTopFirstValue = 64;
                        setRightTextureLeftFirstValue = true;
                        RightTextureLeftFirstValue = 192;
                        setRightTextureTopFirstValue = true;
                        RightTextureTopFirstValue = 64;
                        setTopTextureLeftFirstValue = true;
                        TopTextureLeftFirstValue = 64;
                        setTopTextureTopFirstValue = true;
                        TopTextureTopFirstValue = 0;
                        setTopLeftTextureLeftFirstValue = true;
                        TopLeftTextureLeftFirstValue = 0;
                        setTopLeftTextureTopFirstValue = true;
                        TopLeftTextureTopFirstValue = 0;
                        setTopRightTextureLeftFirstValue = true;
                        TopRightTextureLeftFirstValue = 192;
                        setTopRightTextureTopFirstValue = true;
                        TopRightTextureTopFirstValue = 0;
                        break;
                    case  FlickerState.Flicker2:
                        setBottomTextureLeftFirstValue = true;
                        BottomTextureLeftFirstValue = 320;
                        setBottomTextureTopFirstValue = true;
                        BottomTextureTopFirstValue = 192;
                        setBottomLeftTextureLeftFirstValue = true;
                        BottomLeftTextureLeftFirstValue = 256;
                        setBottomLeftTextureTopFirstValue = true;
                        BottomLeftTextureTopFirstValue = 192;
                        setBottomRightTextureLeftFirstValue = true;
                        BottomRightTextureLeftFirstValue = 448;
                        setBottomRightTextureTopFirstValue = true;
                        BottomRightTextureTopFirstValue = 192;
                        setLeftTextureLeftFirstValue = true;
                        LeftTextureLeftFirstValue = 256;
                        setLeftTextureTopFirstValue = true;
                        LeftTextureTopFirstValue = 64;
                        setRightTextureLeftFirstValue = true;
                        RightTextureLeftFirstValue = 448;
                        setRightTextureTopFirstValue = true;
                        RightTextureTopFirstValue = 64;
                        setTopTextureLeftFirstValue = true;
                        TopTextureLeftFirstValue = 320;
                        setTopTextureTopFirstValue = true;
                        TopTextureTopFirstValue = 0;
                        setTopLeftTextureLeftFirstValue = true;
                        TopLeftTextureLeftFirstValue = 256;
                        setTopLeftTextureTopFirstValue = true;
                        TopLeftTextureTopFirstValue = 0;
                        setTopRightTextureLeftFirstValue = true;
                        TopRightTextureLeftFirstValue = 448;
                        setTopRightTextureTopFirstValue = true;
                        TopRightTextureTopFirstValue = 0;
                        break;
                    case  FlickerState.Flicker3:
                        setBottomTextureLeftFirstValue = true;
                        BottomTextureLeftFirstValue = 576;
                        setBottomTextureTopFirstValue = true;
                        BottomTextureTopFirstValue = 192;
                        setBottomLeftTextureLeftFirstValue = true;
                        BottomLeftTextureLeftFirstValue = 512;
                        setBottomLeftTextureTopFirstValue = true;
                        BottomLeftTextureTopFirstValue = 192;
                        setBottomRightTextureLeftFirstValue = true;
                        BottomRightTextureLeftFirstValue = 704;
                        setBottomRightTextureTopFirstValue = true;
                        BottomRightTextureTopFirstValue = 192;
                        setLeftTextureLeftFirstValue = true;
                        LeftTextureLeftFirstValue = 512;
                        setLeftTextureTopFirstValue = true;
                        LeftTextureTopFirstValue = 64;
                        setRightTextureLeftFirstValue = true;
                        RightTextureLeftFirstValue = 704;
                        setRightTextureTopFirstValue = true;
                        RightTextureTopFirstValue = 64;
                        setTopTextureLeftFirstValue = true;
                        TopTextureLeftFirstValue = 576;
                        setTopTextureTopFirstValue = true;
                        TopTextureTopFirstValue = 0;
                        setTopLeftTextureLeftFirstValue = true;
                        TopLeftTextureLeftFirstValue = 512;
                        setTopLeftTextureTopFirstValue = true;
                        TopLeftTextureTopFirstValue = 0;
                        setTopRightTextureLeftFirstValue = true;
                        TopRightTextureLeftFirstValue = 704;
                        setTopRightTextureTopFirstValue = true;
                        TopRightTextureTopFirstValue = 0;
                        break;
                    case  FlickerState.Flicker4:
                        setBottomTextureLeftFirstValue = true;
                        BottomTextureLeftFirstValue = 64;
                        setBottomTextureTopFirstValue = true;
                        BottomTextureTopFirstValue = 448;
                        setBottomLeftTextureLeftFirstValue = true;
                        BottomLeftTextureLeftFirstValue = 0;
                        setBottomLeftTextureTopFirstValue = true;
                        BottomLeftTextureTopFirstValue = 448;
                        setBottomRightTextureLeftFirstValue = true;
                        BottomRightTextureLeftFirstValue = 192;
                        setBottomRightTextureTopFirstValue = true;
                        BottomRightTextureTopFirstValue = 448;
                        setLeftTextureLeftFirstValue = true;
                        LeftTextureLeftFirstValue = 0;
                        setLeftTextureTopFirstValue = true;
                        LeftTextureTopFirstValue = 320;
                        setRightTextureLeftFirstValue = true;
                        RightTextureLeftFirstValue = 192;
                        setRightTextureTopFirstValue = true;
                        RightTextureTopFirstValue = 320;
                        setTopTextureLeftFirstValue = true;
                        TopTextureLeftFirstValue = 64;
                        setTopTextureTopFirstValue = true;
                        TopTextureTopFirstValue = 256;
                        setTopLeftTextureLeftFirstValue = true;
                        TopLeftTextureLeftFirstValue = 0;
                        setTopLeftTextureTopFirstValue = true;
                        TopLeftTextureTopFirstValue = 256;
                        setTopRightTextureLeftFirstValue = true;
                        TopRightTextureLeftFirstValue = 192;
                        setTopRightTextureTopFirstValue = true;
                        TopRightTextureTopFirstValue = 256;
                        break;
                    case  FlickerState.Flicker5:
                        setBottomTextureLeftFirstValue = true;
                        BottomTextureLeftFirstValue = 320;
                        setBottomTextureTopFirstValue = true;
                        BottomTextureTopFirstValue = 448;
                        setBottomLeftTextureLeftFirstValue = true;
                        BottomLeftTextureLeftFirstValue = 256;
                        setBottomLeftTextureTopFirstValue = true;
                        BottomLeftTextureTopFirstValue = 448;
                        setBottomRightTextureLeftFirstValue = true;
                        BottomRightTextureLeftFirstValue = 448;
                        setBottomRightTextureTopFirstValue = true;
                        BottomRightTextureTopFirstValue = 448;
                        setLeftTextureLeftFirstValue = true;
                        LeftTextureLeftFirstValue = 256;
                        setLeftTextureTopFirstValue = true;
                        LeftTextureTopFirstValue = 320;
                        setRightTextureLeftFirstValue = true;
                        RightTextureLeftFirstValue = 448;
                        setRightTextureTopFirstValue = true;
                        RightTextureTopFirstValue = 320;
                        setTopTextureLeftFirstValue = true;
                        TopTextureLeftFirstValue = 320;
                        setTopTextureTopFirstValue = true;
                        TopTextureTopFirstValue = 256;
                        setTopLeftTextureLeftFirstValue = true;
                        TopLeftTextureLeftFirstValue = 256;
                        setTopLeftTextureTopFirstValue = true;
                        TopLeftTextureTopFirstValue = 256;
                        setTopRightTextureLeftFirstValue = true;
                        TopRightTextureLeftFirstValue = 448;
                        setTopRightTextureTopFirstValue = true;
                        TopRightTextureTopFirstValue = 256;
                        break;
                    case  FlickerState.Flicker6:
                        setBottomTextureLeftFirstValue = true;
                        BottomTextureLeftFirstValue = 576;
                        setBottomTextureTopFirstValue = true;
                        BottomTextureTopFirstValue = 448;
                        setBottomLeftTextureLeftFirstValue = true;
                        BottomLeftTextureLeftFirstValue = 512;
                        setBottomLeftTextureTopFirstValue = true;
                        BottomLeftTextureTopFirstValue = 448;
                        setBottomRightTextureLeftFirstValue = true;
                        BottomRightTextureLeftFirstValue = 704;
                        setBottomRightTextureTopFirstValue = true;
                        BottomRightTextureTopFirstValue = 448;
                        setLeftTextureLeftFirstValue = true;
                        LeftTextureLeftFirstValue = 512;
                        setLeftTextureTopFirstValue = true;
                        LeftTextureTopFirstValue = 320;
                        setRightTextureLeftFirstValue = true;
                        RightTextureLeftFirstValue = 704;
                        setRightTextureTopFirstValue = true;
                        RightTextureTopFirstValue = 320;
                        setTopTextureLeftFirstValue = true;
                        TopTextureLeftFirstValue = 576;
                        setTopTextureTopFirstValue = true;
                        TopTextureTopFirstValue = 256;
                        setTopLeftTextureLeftFirstValue = true;
                        TopLeftTextureLeftFirstValue = 512;
                        setTopLeftTextureTopFirstValue = true;
                        TopLeftTextureTopFirstValue = 256;
                        setTopRightTextureLeftFirstValue = true;
                        TopRightTextureLeftFirstValue = 704;
                        setTopRightTextureTopFirstValue = true;
                        TopRightTextureTopFirstValue = 256;
                        break;
                    case  FlickerState.Flicker7:
                        setBottomTextureLeftFirstValue = true;
                        BottomTextureLeftFirstValue = 64;
                        setBottomTextureTopFirstValue = true;
                        BottomTextureTopFirstValue = 704;
                        setBottomLeftTextureLeftFirstValue = true;
                        BottomLeftTextureLeftFirstValue = 0;
                        setBottomLeftTextureTopFirstValue = true;
                        BottomLeftTextureTopFirstValue = 704;
                        setBottomRightTextureLeftFirstValue = true;
                        BottomRightTextureLeftFirstValue = 192;
                        setBottomRightTextureTopFirstValue = true;
                        BottomRightTextureTopFirstValue = 704;
                        setLeftTextureLeftFirstValue = true;
                        LeftTextureLeftFirstValue = 0;
                        setLeftTextureTopFirstValue = true;
                        LeftTextureTopFirstValue = 576;
                        setRightTextureLeftFirstValue = true;
                        RightTextureLeftFirstValue = 192;
                        setRightTextureTopFirstValue = true;
                        RightTextureTopFirstValue = 576;
                        setTopTextureLeftFirstValue = true;
                        TopTextureLeftFirstValue = 64;
                        setTopTextureTopFirstValue = true;
                        TopTextureTopFirstValue = 512;
                        setTopLeftTextureLeftFirstValue = true;
                        TopLeftTextureLeftFirstValue = 0;
                        setTopLeftTextureTopFirstValue = true;
                        TopLeftTextureTopFirstValue = 512;
                        setTopRightTextureLeftFirstValue = true;
                        TopRightTextureLeftFirstValue = 192;
                        setTopRightTextureTopFirstValue = true;
                        TopRightTextureTopFirstValue = 512;
                        break;
                    case  FlickerState.Flicker8:
                        setBottomTextureLeftFirstValue = true;
                        BottomTextureLeftFirstValue = 320;
                        setBottomTextureTopFirstValue = true;
                        BottomTextureTopFirstValue = 704;
                        setBottomLeftTextureLeftFirstValue = true;
                        BottomLeftTextureLeftFirstValue = 256;
                        setBottomLeftTextureTopFirstValue = true;
                        BottomLeftTextureTopFirstValue = 704;
                        setBottomRightTextureLeftFirstValue = true;
                        BottomRightTextureLeftFirstValue = 448;
                        setBottomRightTextureTopFirstValue = true;
                        BottomRightTextureTopFirstValue = 704;
                        setLeftTextureLeftFirstValue = true;
                        LeftTextureLeftFirstValue = 256;
                        setLeftTextureTopFirstValue = true;
                        LeftTextureTopFirstValue = 576;
                        setRightTextureLeftFirstValue = true;
                        RightTextureLeftFirstValue = 448;
                        setRightTextureTopFirstValue = true;
                        RightTextureTopFirstValue = 576;
                        setTopTextureLeftFirstValue = true;
                        TopTextureLeftFirstValue = 320;
                        setTopTextureTopFirstValue = true;
                        TopTextureTopFirstValue = 512;
                        setTopLeftTextureLeftFirstValue = true;
                        TopLeftTextureLeftFirstValue = 256;
                        setTopLeftTextureTopFirstValue = true;
                        TopLeftTextureTopFirstValue = 512;
                        setTopRightTextureLeftFirstValue = true;
                        TopRightTextureLeftFirstValue = 448;
                        setTopRightTextureTopFirstValue = true;
                        TopRightTextureTopFirstValue = 512;
                        break;
                    case  FlickerState.Flicker9:
                        setBottomTextureLeftFirstValue = true;
                        BottomTextureLeftFirstValue = 576;
                        setBottomTextureTopFirstValue = true;
                        BottomTextureTopFirstValue = 704;
                        setBottomLeftTextureLeftFirstValue = true;
                        BottomLeftTextureLeftFirstValue = 512;
                        setBottomLeftTextureTopFirstValue = true;
                        BottomLeftTextureTopFirstValue = 704;
                        setBottomRightTextureLeftFirstValue = true;
                        BottomRightTextureLeftFirstValue = 704;
                        setBottomRightTextureTopFirstValue = true;
                        BottomRightTextureTopFirstValue = 704;
                        setLeftTextureLeftFirstValue = true;
                        LeftTextureLeftFirstValue = 512;
                        setLeftTextureTopFirstValue = true;
                        LeftTextureTopFirstValue = 576;
                        setRightTextureLeftFirstValue = true;
                        RightTextureLeftFirstValue = 704;
                        setRightTextureTopFirstValue = true;
                        RightTextureTopFirstValue = 576;
                        setTopTextureLeftFirstValue = true;
                        TopTextureLeftFirstValue = 576;
                        setTopTextureTopFirstValue = true;
                        TopTextureTopFirstValue = 512;
                        setTopLeftTextureLeftFirstValue = true;
                        TopLeftTextureLeftFirstValue = 512;
                        setTopLeftTextureTopFirstValue = true;
                        TopLeftTextureTopFirstValue = 512;
                        setTopRightTextureLeftFirstValue = true;
                        TopRightTextureLeftFirstValue = 704;
                        setTopRightTextureTopFirstValue = true;
                        TopRightTextureTopFirstValue = 512;
                        break;
                }
                switch(secondState)
                {
                    case  FlickerState.Flicker1:
                        setBottomTextureLeftSecondValue = true;
                        BottomTextureLeftSecondValue = 64;
                        setBottomTextureTopSecondValue = true;
                        BottomTextureTopSecondValue = 192;
                        setBottomLeftTextureLeftSecondValue = true;
                        BottomLeftTextureLeftSecondValue = 0;
                        setBottomLeftTextureTopSecondValue = true;
                        BottomLeftTextureTopSecondValue = 192;
                        setBottomRightTextureLeftSecondValue = true;
                        BottomRightTextureLeftSecondValue = 192;
                        setBottomRightTextureTopSecondValue = true;
                        BottomRightTextureTopSecondValue = 192;
                        setLeftTextureLeftSecondValue = true;
                        LeftTextureLeftSecondValue = 0;
                        setLeftTextureTopSecondValue = true;
                        LeftTextureTopSecondValue = 64;
                        setRightTextureLeftSecondValue = true;
                        RightTextureLeftSecondValue = 192;
                        setRightTextureTopSecondValue = true;
                        RightTextureTopSecondValue = 64;
                        setTopTextureLeftSecondValue = true;
                        TopTextureLeftSecondValue = 64;
                        setTopTextureTopSecondValue = true;
                        TopTextureTopSecondValue = 0;
                        setTopLeftTextureLeftSecondValue = true;
                        TopLeftTextureLeftSecondValue = 0;
                        setTopLeftTextureTopSecondValue = true;
                        TopLeftTextureTopSecondValue = 0;
                        setTopRightTextureLeftSecondValue = true;
                        TopRightTextureLeftSecondValue = 192;
                        setTopRightTextureTopSecondValue = true;
                        TopRightTextureTopSecondValue = 0;
                        break;
                    case  FlickerState.Flicker2:
                        setBottomTextureLeftSecondValue = true;
                        BottomTextureLeftSecondValue = 320;
                        setBottomTextureTopSecondValue = true;
                        BottomTextureTopSecondValue = 192;
                        setBottomLeftTextureLeftSecondValue = true;
                        BottomLeftTextureLeftSecondValue = 256;
                        setBottomLeftTextureTopSecondValue = true;
                        BottomLeftTextureTopSecondValue = 192;
                        setBottomRightTextureLeftSecondValue = true;
                        BottomRightTextureLeftSecondValue = 448;
                        setBottomRightTextureTopSecondValue = true;
                        BottomRightTextureTopSecondValue = 192;
                        setLeftTextureLeftSecondValue = true;
                        LeftTextureLeftSecondValue = 256;
                        setLeftTextureTopSecondValue = true;
                        LeftTextureTopSecondValue = 64;
                        setRightTextureLeftSecondValue = true;
                        RightTextureLeftSecondValue = 448;
                        setRightTextureTopSecondValue = true;
                        RightTextureTopSecondValue = 64;
                        setTopTextureLeftSecondValue = true;
                        TopTextureLeftSecondValue = 320;
                        setTopTextureTopSecondValue = true;
                        TopTextureTopSecondValue = 0;
                        setTopLeftTextureLeftSecondValue = true;
                        TopLeftTextureLeftSecondValue = 256;
                        setTopLeftTextureTopSecondValue = true;
                        TopLeftTextureTopSecondValue = 0;
                        setTopRightTextureLeftSecondValue = true;
                        TopRightTextureLeftSecondValue = 448;
                        setTopRightTextureTopSecondValue = true;
                        TopRightTextureTopSecondValue = 0;
                        break;
                    case  FlickerState.Flicker3:
                        setBottomTextureLeftSecondValue = true;
                        BottomTextureLeftSecondValue = 576;
                        setBottomTextureTopSecondValue = true;
                        BottomTextureTopSecondValue = 192;
                        setBottomLeftTextureLeftSecondValue = true;
                        BottomLeftTextureLeftSecondValue = 512;
                        setBottomLeftTextureTopSecondValue = true;
                        BottomLeftTextureTopSecondValue = 192;
                        setBottomRightTextureLeftSecondValue = true;
                        BottomRightTextureLeftSecondValue = 704;
                        setBottomRightTextureTopSecondValue = true;
                        BottomRightTextureTopSecondValue = 192;
                        setLeftTextureLeftSecondValue = true;
                        LeftTextureLeftSecondValue = 512;
                        setLeftTextureTopSecondValue = true;
                        LeftTextureTopSecondValue = 64;
                        setRightTextureLeftSecondValue = true;
                        RightTextureLeftSecondValue = 704;
                        setRightTextureTopSecondValue = true;
                        RightTextureTopSecondValue = 64;
                        setTopTextureLeftSecondValue = true;
                        TopTextureLeftSecondValue = 576;
                        setTopTextureTopSecondValue = true;
                        TopTextureTopSecondValue = 0;
                        setTopLeftTextureLeftSecondValue = true;
                        TopLeftTextureLeftSecondValue = 512;
                        setTopLeftTextureTopSecondValue = true;
                        TopLeftTextureTopSecondValue = 0;
                        setTopRightTextureLeftSecondValue = true;
                        TopRightTextureLeftSecondValue = 704;
                        setTopRightTextureTopSecondValue = true;
                        TopRightTextureTopSecondValue = 0;
                        break;
                    case  FlickerState.Flicker4:
                        setBottomTextureLeftSecondValue = true;
                        BottomTextureLeftSecondValue = 64;
                        setBottomTextureTopSecondValue = true;
                        BottomTextureTopSecondValue = 448;
                        setBottomLeftTextureLeftSecondValue = true;
                        BottomLeftTextureLeftSecondValue = 0;
                        setBottomLeftTextureTopSecondValue = true;
                        BottomLeftTextureTopSecondValue = 448;
                        setBottomRightTextureLeftSecondValue = true;
                        BottomRightTextureLeftSecondValue = 192;
                        setBottomRightTextureTopSecondValue = true;
                        BottomRightTextureTopSecondValue = 448;
                        setLeftTextureLeftSecondValue = true;
                        LeftTextureLeftSecondValue = 0;
                        setLeftTextureTopSecondValue = true;
                        LeftTextureTopSecondValue = 320;
                        setRightTextureLeftSecondValue = true;
                        RightTextureLeftSecondValue = 192;
                        setRightTextureTopSecondValue = true;
                        RightTextureTopSecondValue = 320;
                        setTopTextureLeftSecondValue = true;
                        TopTextureLeftSecondValue = 64;
                        setTopTextureTopSecondValue = true;
                        TopTextureTopSecondValue = 256;
                        setTopLeftTextureLeftSecondValue = true;
                        TopLeftTextureLeftSecondValue = 0;
                        setTopLeftTextureTopSecondValue = true;
                        TopLeftTextureTopSecondValue = 256;
                        setTopRightTextureLeftSecondValue = true;
                        TopRightTextureLeftSecondValue = 192;
                        setTopRightTextureTopSecondValue = true;
                        TopRightTextureTopSecondValue = 256;
                        break;
                    case  FlickerState.Flicker5:
                        setBottomTextureLeftSecondValue = true;
                        BottomTextureLeftSecondValue = 320;
                        setBottomTextureTopSecondValue = true;
                        BottomTextureTopSecondValue = 448;
                        setBottomLeftTextureLeftSecondValue = true;
                        BottomLeftTextureLeftSecondValue = 256;
                        setBottomLeftTextureTopSecondValue = true;
                        BottomLeftTextureTopSecondValue = 448;
                        setBottomRightTextureLeftSecondValue = true;
                        BottomRightTextureLeftSecondValue = 448;
                        setBottomRightTextureTopSecondValue = true;
                        BottomRightTextureTopSecondValue = 448;
                        setLeftTextureLeftSecondValue = true;
                        LeftTextureLeftSecondValue = 256;
                        setLeftTextureTopSecondValue = true;
                        LeftTextureTopSecondValue = 320;
                        setRightTextureLeftSecondValue = true;
                        RightTextureLeftSecondValue = 448;
                        setRightTextureTopSecondValue = true;
                        RightTextureTopSecondValue = 320;
                        setTopTextureLeftSecondValue = true;
                        TopTextureLeftSecondValue = 320;
                        setTopTextureTopSecondValue = true;
                        TopTextureTopSecondValue = 256;
                        setTopLeftTextureLeftSecondValue = true;
                        TopLeftTextureLeftSecondValue = 256;
                        setTopLeftTextureTopSecondValue = true;
                        TopLeftTextureTopSecondValue = 256;
                        setTopRightTextureLeftSecondValue = true;
                        TopRightTextureLeftSecondValue = 448;
                        setTopRightTextureTopSecondValue = true;
                        TopRightTextureTopSecondValue = 256;
                        break;
                    case  FlickerState.Flicker6:
                        setBottomTextureLeftSecondValue = true;
                        BottomTextureLeftSecondValue = 576;
                        setBottomTextureTopSecondValue = true;
                        BottomTextureTopSecondValue = 448;
                        setBottomLeftTextureLeftSecondValue = true;
                        BottomLeftTextureLeftSecondValue = 512;
                        setBottomLeftTextureTopSecondValue = true;
                        BottomLeftTextureTopSecondValue = 448;
                        setBottomRightTextureLeftSecondValue = true;
                        BottomRightTextureLeftSecondValue = 704;
                        setBottomRightTextureTopSecondValue = true;
                        BottomRightTextureTopSecondValue = 448;
                        setLeftTextureLeftSecondValue = true;
                        LeftTextureLeftSecondValue = 512;
                        setLeftTextureTopSecondValue = true;
                        LeftTextureTopSecondValue = 320;
                        setRightTextureLeftSecondValue = true;
                        RightTextureLeftSecondValue = 704;
                        setRightTextureTopSecondValue = true;
                        RightTextureTopSecondValue = 320;
                        setTopTextureLeftSecondValue = true;
                        TopTextureLeftSecondValue = 576;
                        setTopTextureTopSecondValue = true;
                        TopTextureTopSecondValue = 256;
                        setTopLeftTextureLeftSecondValue = true;
                        TopLeftTextureLeftSecondValue = 512;
                        setTopLeftTextureTopSecondValue = true;
                        TopLeftTextureTopSecondValue = 256;
                        setTopRightTextureLeftSecondValue = true;
                        TopRightTextureLeftSecondValue = 704;
                        setTopRightTextureTopSecondValue = true;
                        TopRightTextureTopSecondValue = 256;
                        break;
                    case  FlickerState.Flicker7:
                        setBottomTextureLeftSecondValue = true;
                        BottomTextureLeftSecondValue = 64;
                        setBottomTextureTopSecondValue = true;
                        BottomTextureTopSecondValue = 704;
                        setBottomLeftTextureLeftSecondValue = true;
                        BottomLeftTextureLeftSecondValue = 0;
                        setBottomLeftTextureTopSecondValue = true;
                        BottomLeftTextureTopSecondValue = 704;
                        setBottomRightTextureLeftSecondValue = true;
                        BottomRightTextureLeftSecondValue = 192;
                        setBottomRightTextureTopSecondValue = true;
                        BottomRightTextureTopSecondValue = 704;
                        setLeftTextureLeftSecondValue = true;
                        LeftTextureLeftSecondValue = 0;
                        setLeftTextureTopSecondValue = true;
                        LeftTextureTopSecondValue = 576;
                        setRightTextureLeftSecondValue = true;
                        RightTextureLeftSecondValue = 192;
                        setRightTextureTopSecondValue = true;
                        RightTextureTopSecondValue = 576;
                        setTopTextureLeftSecondValue = true;
                        TopTextureLeftSecondValue = 64;
                        setTopTextureTopSecondValue = true;
                        TopTextureTopSecondValue = 512;
                        setTopLeftTextureLeftSecondValue = true;
                        TopLeftTextureLeftSecondValue = 0;
                        setTopLeftTextureTopSecondValue = true;
                        TopLeftTextureTopSecondValue = 512;
                        setTopRightTextureLeftSecondValue = true;
                        TopRightTextureLeftSecondValue = 192;
                        setTopRightTextureTopSecondValue = true;
                        TopRightTextureTopSecondValue = 512;
                        break;
                    case  FlickerState.Flicker8:
                        setBottomTextureLeftSecondValue = true;
                        BottomTextureLeftSecondValue = 320;
                        setBottomTextureTopSecondValue = true;
                        BottomTextureTopSecondValue = 704;
                        setBottomLeftTextureLeftSecondValue = true;
                        BottomLeftTextureLeftSecondValue = 256;
                        setBottomLeftTextureTopSecondValue = true;
                        BottomLeftTextureTopSecondValue = 704;
                        setBottomRightTextureLeftSecondValue = true;
                        BottomRightTextureLeftSecondValue = 448;
                        setBottomRightTextureTopSecondValue = true;
                        BottomRightTextureTopSecondValue = 704;
                        setLeftTextureLeftSecondValue = true;
                        LeftTextureLeftSecondValue = 256;
                        setLeftTextureTopSecondValue = true;
                        LeftTextureTopSecondValue = 576;
                        setRightTextureLeftSecondValue = true;
                        RightTextureLeftSecondValue = 448;
                        setRightTextureTopSecondValue = true;
                        RightTextureTopSecondValue = 576;
                        setTopTextureLeftSecondValue = true;
                        TopTextureLeftSecondValue = 320;
                        setTopTextureTopSecondValue = true;
                        TopTextureTopSecondValue = 512;
                        setTopLeftTextureLeftSecondValue = true;
                        TopLeftTextureLeftSecondValue = 256;
                        setTopLeftTextureTopSecondValue = true;
                        TopLeftTextureTopSecondValue = 512;
                        setTopRightTextureLeftSecondValue = true;
                        TopRightTextureLeftSecondValue = 448;
                        setTopRightTextureTopSecondValue = true;
                        TopRightTextureTopSecondValue = 512;
                        break;
                    case  FlickerState.Flicker9:
                        setBottomTextureLeftSecondValue = true;
                        BottomTextureLeftSecondValue = 576;
                        setBottomTextureTopSecondValue = true;
                        BottomTextureTopSecondValue = 704;
                        setBottomLeftTextureLeftSecondValue = true;
                        BottomLeftTextureLeftSecondValue = 512;
                        setBottomLeftTextureTopSecondValue = true;
                        BottomLeftTextureTopSecondValue = 704;
                        setBottomRightTextureLeftSecondValue = true;
                        BottomRightTextureLeftSecondValue = 704;
                        setBottomRightTextureTopSecondValue = true;
                        BottomRightTextureTopSecondValue = 704;
                        setLeftTextureLeftSecondValue = true;
                        LeftTextureLeftSecondValue = 512;
                        setLeftTextureTopSecondValue = true;
                        LeftTextureTopSecondValue = 576;
                        setRightTextureLeftSecondValue = true;
                        RightTextureLeftSecondValue = 704;
                        setRightTextureTopSecondValue = true;
                        RightTextureTopSecondValue = 576;
                        setTopTextureLeftSecondValue = true;
                        TopTextureLeftSecondValue = 576;
                        setTopTextureTopSecondValue = true;
                        TopTextureTopSecondValue = 512;
                        setTopLeftTextureLeftSecondValue = true;
                        TopLeftTextureLeftSecondValue = 512;
                        setTopLeftTextureTopSecondValue = true;
                        TopLeftTextureTopSecondValue = 512;
                        setTopRightTextureLeftSecondValue = true;
                        TopRightTextureLeftSecondValue = 704;
                        setTopRightTextureTopSecondValue = true;
                        TopRightTextureTopSecondValue = 512;
                        break;
                }
                if (setBottomTextureLeftFirstValue && setBottomTextureLeftSecondValue)
                {
                    Bottom.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(BottomTextureLeftFirstValue* (1 - interpolationValue) + BottomTextureLeftSecondValue * interpolationValue);
                }
                if (setBottomTextureTopFirstValue && setBottomTextureTopSecondValue)
                {
                    Bottom.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(BottomTextureTopFirstValue* (1 - interpolationValue) + BottomTextureTopSecondValue * interpolationValue);
                }
                if (setBottomLeftTextureLeftFirstValue && setBottomLeftTextureLeftSecondValue)
                {
                    BottomLeft.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(BottomLeftTextureLeftFirstValue* (1 - interpolationValue) + BottomLeftTextureLeftSecondValue * interpolationValue);
                }
                if (setBottomLeftTextureTopFirstValue && setBottomLeftTextureTopSecondValue)
                {
                    BottomLeft.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(BottomLeftTextureTopFirstValue* (1 - interpolationValue) + BottomLeftTextureTopSecondValue * interpolationValue);
                }
                if (setBottomRightTextureLeftFirstValue && setBottomRightTextureLeftSecondValue)
                {
                    BottomRight.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(BottomRightTextureLeftFirstValue* (1 - interpolationValue) + BottomRightTextureLeftSecondValue * interpolationValue);
                }
                if (setBottomRightTextureTopFirstValue && setBottomRightTextureTopSecondValue)
                {
                    BottomRight.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(BottomRightTextureTopFirstValue* (1 - interpolationValue) + BottomRightTextureTopSecondValue * interpolationValue);
                }
                if (setLeftTextureLeftFirstValue && setLeftTextureLeftSecondValue)
                {
                    Left.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(LeftTextureLeftFirstValue* (1 - interpolationValue) + LeftTextureLeftSecondValue * interpolationValue);
                }
                if (setLeftTextureTopFirstValue && setLeftTextureTopSecondValue)
                {
                    Left.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(LeftTextureTopFirstValue* (1 - interpolationValue) + LeftTextureTopSecondValue * interpolationValue);
                }
                if (setRightTextureLeftFirstValue && setRightTextureLeftSecondValue)
                {
                    Right.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(RightTextureLeftFirstValue* (1 - interpolationValue) + RightTextureLeftSecondValue * interpolationValue);
                }
                if (setRightTextureTopFirstValue && setRightTextureTopSecondValue)
                {
                    Right.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(RightTextureTopFirstValue* (1 - interpolationValue) + RightTextureTopSecondValue * interpolationValue);
                }
                if (setTopTextureLeftFirstValue && setTopTextureLeftSecondValue)
                {
                    Top.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(TopTextureLeftFirstValue* (1 - interpolationValue) + TopTextureLeftSecondValue * interpolationValue);
                }
                if (setTopTextureTopFirstValue && setTopTextureTopSecondValue)
                {
                    Top.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(TopTextureTopFirstValue* (1 - interpolationValue) + TopTextureTopSecondValue * interpolationValue);
                }
                if (setTopLeftTextureLeftFirstValue && setTopLeftTextureLeftSecondValue)
                {
                    TopLeft.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(TopLeftTextureLeftFirstValue* (1 - interpolationValue) + TopLeftTextureLeftSecondValue * interpolationValue);
                }
                if (setTopLeftTextureTopFirstValue && setTopLeftTextureTopSecondValue)
                {
                    TopLeft.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(TopLeftTextureTopFirstValue* (1 - interpolationValue) + TopLeftTextureTopSecondValue * interpolationValue);
                }
                if (setTopRightTextureLeftFirstValue && setTopRightTextureLeftSecondValue)
                {
                    TopRight.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(TopRightTextureLeftFirstValue* (1 - interpolationValue) + TopRightTextureLeftSecondValue * interpolationValue);
                }
                if (setTopRightTextureTopFirstValue && setTopRightTextureTopSecondValue)
                {
                    TopRight.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(TopRightTextureTopFirstValue* (1 - interpolationValue) + TopRightTextureTopSecondValue * interpolationValue);
                }
                if (interpolationValue < 1)
                {
                    mCurrentFlickerStateState = firstState;
                }
                else
                {
                    mCurrentFlickerStateState = secondState;
                }
            }
            public void InterpolateBetween (ColorState firstState, ColorState secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setBottomBlueFirstValue = false;
                bool setBottomBlueSecondValue = false;
                int BottomBlueFirstValue= 0;
                int BottomBlueSecondValue= 0;
                bool setBottomGreenFirstValue = false;
                bool setBottomGreenSecondValue = false;
                int BottomGreenFirstValue= 0;
                int BottomGreenSecondValue= 0;
                bool setBottomRedFirstValue = false;
                bool setBottomRedSecondValue = false;
                int BottomRedFirstValue= 0;
                int BottomRedSecondValue= 0;
                bool setBottomLeftBlueFirstValue = false;
                bool setBottomLeftBlueSecondValue = false;
                int BottomLeftBlueFirstValue= 0;
                int BottomLeftBlueSecondValue= 0;
                bool setBottomLeftGreenFirstValue = false;
                bool setBottomLeftGreenSecondValue = false;
                int BottomLeftGreenFirstValue= 0;
                int BottomLeftGreenSecondValue= 0;
                bool setBottomLeftRedFirstValue = false;
                bool setBottomLeftRedSecondValue = false;
                int BottomLeftRedFirstValue= 0;
                int BottomLeftRedSecondValue= 0;
                bool setBottomRightBlueFirstValue = false;
                bool setBottomRightBlueSecondValue = false;
                int BottomRightBlueFirstValue= 0;
                int BottomRightBlueSecondValue= 0;
                bool setBottomRightGreenFirstValue = false;
                bool setBottomRightGreenSecondValue = false;
                int BottomRightGreenFirstValue= 0;
                int BottomRightGreenSecondValue= 0;
                bool setBottomRightRedFirstValue = false;
                bool setBottomRightRedSecondValue = false;
                int BottomRightRedFirstValue= 0;
                int BottomRightRedSecondValue= 0;
                bool setLeftBlueFirstValue = false;
                bool setLeftBlueSecondValue = false;
                int LeftBlueFirstValue= 0;
                int LeftBlueSecondValue= 0;
                bool setLeftGreenFirstValue = false;
                bool setLeftGreenSecondValue = false;
                int LeftGreenFirstValue= 0;
                int LeftGreenSecondValue= 0;
                bool setLeftRedFirstValue = false;
                bool setLeftRedSecondValue = false;
                int LeftRedFirstValue= 0;
                int LeftRedSecondValue= 0;
                bool setMiddleBlueFirstValue = false;
                bool setMiddleBlueSecondValue = false;
                int MiddleBlueFirstValue= 0;
                int MiddleBlueSecondValue= 0;
                bool setMiddleGreenFirstValue = false;
                bool setMiddleGreenSecondValue = false;
                int MiddleGreenFirstValue= 0;
                int MiddleGreenSecondValue= 0;
                bool setMiddleRedFirstValue = false;
                bool setMiddleRedSecondValue = false;
                int MiddleRedFirstValue= 0;
                int MiddleRedSecondValue= 0;
                bool setRightBlueFirstValue = false;
                bool setRightBlueSecondValue = false;
                int RightBlueFirstValue= 0;
                int RightBlueSecondValue= 0;
                bool setRightGreenFirstValue = false;
                bool setRightGreenSecondValue = false;
                int RightGreenFirstValue= 0;
                int RightGreenSecondValue= 0;
                bool setRightRedFirstValue = false;
                bool setRightRedSecondValue = false;
                int RightRedFirstValue= 0;
                int RightRedSecondValue= 0;
                bool setTopBlueFirstValue = false;
                bool setTopBlueSecondValue = false;
                int TopBlueFirstValue= 0;
                int TopBlueSecondValue= 0;
                bool setTopGreenFirstValue = false;
                bool setTopGreenSecondValue = false;
                int TopGreenFirstValue= 0;
                int TopGreenSecondValue= 0;
                bool setTopRedFirstValue = false;
                bool setTopRedSecondValue = false;
                int TopRedFirstValue= 0;
                int TopRedSecondValue= 0;
                bool setTopLeftBlueFirstValue = false;
                bool setTopLeftBlueSecondValue = false;
                int TopLeftBlueFirstValue= 0;
                int TopLeftBlueSecondValue= 0;
                bool setTopLeftGreenFirstValue = false;
                bool setTopLeftGreenSecondValue = false;
                int TopLeftGreenFirstValue= 0;
                int TopLeftGreenSecondValue= 0;
                bool setTopLeftRedFirstValue = false;
                bool setTopLeftRedSecondValue = false;
                int TopLeftRedFirstValue= 0;
                int TopLeftRedSecondValue= 0;
                bool setTopRightBlueFirstValue = false;
                bool setTopRightBlueSecondValue = false;
                int TopRightBlueFirstValue= 0;
                int TopRightBlueSecondValue= 0;
                bool setTopRightGreenFirstValue = false;
                bool setTopRightGreenSecondValue = false;
                int TopRightGreenFirstValue= 0;
                int TopRightGreenSecondValue= 0;
                bool setTopRightRedFirstValue = false;
                bool setTopRightRedSecondValue = false;
                int TopRightRedFirstValue= 0;
                int TopRightRedSecondValue= 0;
                switch(firstState)
                {
                    case  ColorState.Red:
                        setBottomBlueFirstValue = true;
                        BottomBlueFirstValue = 0;
                        setBottomGreenFirstValue = true;
                        BottomGreenFirstValue = 0;
                        setBottomRedFirstValue = true;
                        BottomRedFirstValue = 255;
                        setBottomLeftBlueFirstValue = true;
                        BottomLeftBlueFirstValue = 0;
                        setBottomLeftGreenFirstValue = true;
                        BottomLeftGreenFirstValue = 0;
                        setBottomLeftRedFirstValue = true;
                        BottomLeftRedFirstValue = 255;
                        setBottomRightBlueFirstValue = true;
                        BottomRightBlueFirstValue = 0;
                        setBottomRightGreenFirstValue = true;
                        BottomRightGreenFirstValue = 0;
                        setBottomRightRedFirstValue = true;
                        BottomRightRedFirstValue = 255;
                        setLeftBlueFirstValue = true;
                        LeftBlueFirstValue = 0;
                        setLeftGreenFirstValue = true;
                        LeftGreenFirstValue = 0;
                        setLeftRedFirstValue = true;
                        LeftRedFirstValue = 255;
                        setMiddleBlueFirstValue = true;
                        MiddleBlueFirstValue = 0;
                        setMiddleGreenFirstValue = true;
                        MiddleGreenFirstValue = 0;
                        setMiddleRedFirstValue = true;
                        MiddleRedFirstValue = 36;
                        setRightBlueFirstValue = true;
                        RightBlueFirstValue = 0;
                        setRightGreenFirstValue = true;
                        RightGreenFirstValue = 0;
                        setRightRedFirstValue = true;
                        RightRedFirstValue = 255;
                        setTopBlueFirstValue = true;
                        TopBlueFirstValue = 0;
                        setTopGreenFirstValue = true;
                        TopGreenFirstValue = 0;
                        setTopRedFirstValue = true;
                        TopRedFirstValue = 255;
                        setTopLeftBlueFirstValue = true;
                        TopLeftBlueFirstValue = 0;
                        setTopLeftGreenFirstValue = true;
                        TopLeftGreenFirstValue = 0;
                        setTopLeftRedFirstValue = true;
                        TopLeftRedFirstValue = 255;
                        setTopRightBlueFirstValue = true;
                        TopRightBlueFirstValue = 0;
                        setTopRightGreenFirstValue = true;
                        TopRightGreenFirstValue = 0;
                        setTopRightRedFirstValue = true;
                        TopRightRedFirstValue = 255;
                        break;
                    case  ColorState.Green:
                        setBottomBlueFirstValue = true;
                        BottomBlueFirstValue = 0;
                        setBottomGreenFirstValue = true;
                        BottomGreenFirstValue = 255;
                        setBottomRedFirstValue = true;
                        BottomRedFirstValue = 0;
                        setBottomLeftBlueFirstValue = true;
                        BottomLeftBlueFirstValue = 0;
                        setBottomLeftGreenFirstValue = true;
                        BottomLeftGreenFirstValue = 255;
                        setBottomLeftRedFirstValue = true;
                        BottomLeftRedFirstValue = 0;
                        setBottomRightBlueFirstValue = true;
                        BottomRightBlueFirstValue = 0;
                        setBottomRightGreenFirstValue = true;
                        BottomRightGreenFirstValue = 255;
                        setBottomRightRedFirstValue = true;
                        BottomRightRedFirstValue = 0;
                        setLeftBlueFirstValue = true;
                        LeftBlueFirstValue = 0;
                        setLeftGreenFirstValue = true;
                        LeftGreenFirstValue = 255;
                        setLeftRedFirstValue = true;
                        LeftRedFirstValue = 0;
                        setMiddleBlueFirstValue = true;
                        MiddleBlueFirstValue = 0;
                        setMiddleGreenFirstValue = true;
                        MiddleGreenFirstValue = 48;
                        setMiddleRedFirstValue = true;
                        MiddleRedFirstValue = 0;
                        setRightBlueFirstValue = true;
                        RightBlueFirstValue = 0;
                        setRightGreenFirstValue = true;
                        RightGreenFirstValue = 255;
                        setRightRedFirstValue = true;
                        RightRedFirstValue = 0;
                        setTopBlueFirstValue = true;
                        TopBlueFirstValue = 0;
                        setTopGreenFirstValue = true;
                        TopGreenFirstValue = 255;
                        setTopRedFirstValue = true;
                        TopRedFirstValue = 0;
                        setTopLeftBlueFirstValue = true;
                        TopLeftBlueFirstValue = 0;
                        setTopLeftGreenFirstValue = true;
                        TopLeftGreenFirstValue = 255;
                        setTopLeftRedFirstValue = true;
                        TopLeftRedFirstValue = 0;
                        setTopRightBlueFirstValue = true;
                        TopRightBlueFirstValue = 0;
                        setTopRightGreenFirstValue = true;
                        TopRightGreenFirstValue = 255;
                        setTopRightRedFirstValue = true;
                        TopRightRedFirstValue = 0;
                        break;
                    case  ColorState.Black:
                        setBottomBlueFirstValue = true;
                        BottomBlueFirstValue = 50;
                        setBottomGreenFirstValue = true;
                        BottomGreenFirstValue = 50;
                        setBottomRedFirstValue = true;
                        BottomRedFirstValue = 50;
                        setBottomLeftBlueFirstValue = true;
                        BottomLeftBlueFirstValue = 50;
                        setBottomLeftGreenFirstValue = true;
                        BottomLeftGreenFirstValue = 50;
                        setBottomLeftRedFirstValue = true;
                        BottomLeftRedFirstValue = 50;
                        setBottomRightBlueFirstValue = true;
                        BottomRightBlueFirstValue = 50;
                        setBottomRightGreenFirstValue = true;
                        BottomRightGreenFirstValue = 50;
                        setBottomRightRedFirstValue = true;
                        BottomRightRedFirstValue = 50;
                        setLeftBlueFirstValue = true;
                        LeftBlueFirstValue = 50;
                        setLeftGreenFirstValue = true;
                        LeftGreenFirstValue = 50;
                        setLeftRedFirstValue = true;
                        LeftRedFirstValue = 50;
                        setMiddleBlueFirstValue = true;
                        MiddleBlueFirstValue = 75;
                        setMiddleGreenFirstValue = true;
                        MiddleGreenFirstValue = 75;
                        setMiddleRedFirstValue = true;
                        MiddleRedFirstValue = 75;
                        setRightBlueFirstValue = true;
                        RightBlueFirstValue = 50;
                        setRightGreenFirstValue = true;
                        RightGreenFirstValue = 50;
                        setRightRedFirstValue = true;
                        RightRedFirstValue = 50;
                        setTopBlueFirstValue = true;
                        TopBlueFirstValue = 50;
                        setTopGreenFirstValue = true;
                        TopGreenFirstValue = 50;
                        setTopRedFirstValue = true;
                        TopRedFirstValue = 50;
                        setTopLeftBlueFirstValue = true;
                        TopLeftBlueFirstValue = 50;
                        setTopLeftGreenFirstValue = true;
                        TopLeftGreenFirstValue = 50;
                        setTopLeftRedFirstValue = true;
                        TopLeftRedFirstValue = 50;
                        setTopRightBlueFirstValue = true;
                        TopRightBlueFirstValue = 50;
                        setTopRightGreenFirstValue = true;
                        TopRightGreenFirstValue = 50;
                        setTopRightRedFirstValue = true;
                        TopRightRedFirstValue = 50;
                        break;
                    case  ColorState.Blue:
                        setBottomBlueFirstValue = true;
                        BottomBlueFirstValue = 250;
                        setBottomGreenFirstValue = true;
                        BottomGreenFirstValue = 206;
                        setBottomRedFirstValue = true;
                        BottomRedFirstValue = 135;
                        setBottomLeftBlueFirstValue = true;
                        BottomLeftBlueFirstValue = 250;
                        setBottomLeftGreenFirstValue = true;
                        BottomLeftGreenFirstValue = 206;
                        setBottomLeftRedFirstValue = true;
                        BottomLeftRedFirstValue = 135;
                        setBottomRightBlueFirstValue = true;
                        BottomRightBlueFirstValue = 250;
                        setBottomRightGreenFirstValue = true;
                        BottomRightGreenFirstValue = 206;
                        setBottomRightRedFirstValue = true;
                        BottomRightRedFirstValue = 135;
                        setLeftBlueFirstValue = true;
                        LeftBlueFirstValue = 250;
                        setLeftGreenFirstValue = true;
                        LeftGreenFirstValue = 206;
                        setLeftRedFirstValue = true;
                        LeftRedFirstValue = 135;
                        setMiddleBlueFirstValue = true;
                        MiddleBlueFirstValue = 255;
                        setMiddleGreenFirstValue = true;
                        MiddleGreenFirstValue = 255;
                        setMiddleRedFirstValue = true;
                        MiddleRedFirstValue = 224;
                        setRightBlueFirstValue = true;
                        RightBlueFirstValue = 250;
                        setRightGreenFirstValue = true;
                        RightGreenFirstValue = 206;
                        setRightRedFirstValue = true;
                        RightRedFirstValue = 135;
                        setTopBlueFirstValue = true;
                        TopBlueFirstValue = 250;
                        setTopGreenFirstValue = true;
                        TopGreenFirstValue = 206;
                        setTopRedFirstValue = true;
                        TopRedFirstValue = 135;
                        setTopLeftBlueFirstValue = true;
                        TopLeftBlueFirstValue = 235;
                        setTopLeftGreenFirstValue = true;
                        TopLeftGreenFirstValue = 206;
                        setTopLeftRedFirstValue = true;
                        TopLeftRedFirstValue = 135;
                        setTopRightBlueFirstValue = true;
                        TopRightBlueFirstValue = 250;
                        setTopRightGreenFirstValue = true;
                        TopRightGreenFirstValue = 206;
                        setTopRightRedFirstValue = true;
                        TopRightRedFirstValue = 135;
                        break;
                }
                switch(secondState)
                {
                    case  ColorState.Red:
                        setBottomBlueSecondValue = true;
                        BottomBlueSecondValue = 0;
                        setBottomGreenSecondValue = true;
                        BottomGreenSecondValue = 0;
                        setBottomRedSecondValue = true;
                        BottomRedSecondValue = 255;
                        setBottomLeftBlueSecondValue = true;
                        BottomLeftBlueSecondValue = 0;
                        setBottomLeftGreenSecondValue = true;
                        BottomLeftGreenSecondValue = 0;
                        setBottomLeftRedSecondValue = true;
                        BottomLeftRedSecondValue = 255;
                        setBottomRightBlueSecondValue = true;
                        BottomRightBlueSecondValue = 0;
                        setBottomRightGreenSecondValue = true;
                        BottomRightGreenSecondValue = 0;
                        setBottomRightRedSecondValue = true;
                        BottomRightRedSecondValue = 255;
                        setLeftBlueSecondValue = true;
                        LeftBlueSecondValue = 0;
                        setLeftGreenSecondValue = true;
                        LeftGreenSecondValue = 0;
                        setLeftRedSecondValue = true;
                        LeftRedSecondValue = 255;
                        setMiddleBlueSecondValue = true;
                        MiddleBlueSecondValue = 0;
                        setMiddleGreenSecondValue = true;
                        MiddleGreenSecondValue = 0;
                        setMiddleRedSecondValue = true;
                        MiddleRedSecondValue = 36;
                        setRightBlueSecondValue = true;
                        RightBlueSecondValue = 0;
                        setRightGreenSecondValue = true;
                        RightGreenSecondValue = 0;
                        setRightRedSecondValue = true;
                        RightRedSecondValue = 255;
                        setTopBlueSecondValue = true;
                        TopBlueSecondValue = 0;
                        setTopGreenSecondValue = true;
                        TopGreenSecondValue = 0;
                        setTopRedSecondValue = true;
                        TopRedSecondValue = 255;
                        setTopLeftBlueSecondValue = true;
                        TopLeftBlueSecondValue = 0;
                        setTopLeftGreenSecondValue = true;
                        TopLeftGreenSecondValue = 0;
                        setTopLeftRedSecondValue = true;
                        TopLeftRedSecondValue = 255;
                        setTopRightBlueSecondValue = true;
                        TopRightBlueSecondValue = 0;
                        setTopRightGreenSecondValue = true;
                        TopRightGreenSecondValue = 0;
                        setTopRightRedSecondValue = true;
                        TopRightRedSecondValue = 255;
                        break;
                    case  ColorState.Green:
                        setBottomBlueSecondValue = true;
                        BottomBlueSecondValue = 0;
                        setBottomGreenSecondValue = true;
                        BottomGreenSecondValue = 255;
                        setBottomRedSecondValue = true;
                        BottomRedSecondValue = 0;
                        setBottomLeftBlueSecondValue = true;
                        BottomLeftBlueSecondValue = 0;
                        setBottomLeftGreenSecondValue = true;
                        BottomLeftGreenSecondValue = 255;
                        setBottomLeftRedSecondValue = true;
                        BottomLeftRedSecondValue = 0;
                        setBottomRightBlueSecondValue = true;
                        BottomRightBlueSecondValue = 0;
                        setBottomRightGreenSecondValue = true;
                        BottomRightGreenSecondValue = 255;
                        setBottomRightRedSecondValue = true;
                        BottomRightRedSecondValue = 0;
                        setLeftBlueSecondValue = true;
                        LeftBlueSecondValue = 0;
                        setLeftGreenSecondValue = true;
                        LeftGreenSecondValue = 255;
                        setLeftRedSecondValue = true;
                        LeftRedSecondValue = 0;
                        setMiddleBlueSecondValue = true;
                        MiddleBlueSecondValue = 0;
                        setMiddleGreenSecondValue = true;
                        MiddleGreenSecondValue = 48;
                        setMiddleRedSecondValue = true;
                        MiddleRedSecondValue = 0;
                        setRightBlueSecondValue = true;
                        RightBlueSecondValue = 0;
                        setRightGreenSecondValue = true;
                        RightGreenSecondValue = 255;
                        setRightRedSecondValue = true;
                        RightRedSecondValue = 0;
                        setTopBlueSecondValue = true;
                        TopBlueSecondValue = 0;
                        setTopGreenSecondValue = true;
                        TopGreenSecondValue = 255;
                        setTopRedSecondValue = true;
                        TopRedSecondValue = 0;
                        setTopLeftBlueSecondValue = true;
                        TopLeftBlueSecondValue = 0;
                        setTopLeftGreenSecondValue = true;
                        TopLeftGreenSecondValue = 255;
                        setTopLeftRedSecondValue = true;
                        TopLeftRedSecondValue = 0;
                        setTopRightBlueSecondValue = true;
                        TopRightBlueSecondValue = 0;
                        setTopRightGreenSecondValue = true;
                        TopRightGreenSecondValue = 255;
                        setTopRightRedSecondValue = true;
                        TopRightRedSecondValue = 0;
                        break;
                    case  ColorState.Black:
                        setBottomBlueSecondValue = true;
                        BottomBlueSecondValue = 50;
                        setBottomGreenSecondValue = true;
                        BottomGreenSecondValue = 50;
                        setBottomRedSecondValue = true;
                        BottomRedSecondValue = 50;
                        setBottomLeftBlueSecondValue = true;
                        BottomLeftBlueSecondValue = 50;
                        setBottomLeftGreenSecondValue = true;
                        BottomLeftGreenSecondValue = 50;
                        setBottomLeftRedSecondValue = true;
                        BottomLeftRedSecondValue = 50;
                        setBottomRightBlueSecondValue = true;
                        BottomRightBlueSecondValue = 50;
                        setBottomRightGreenSecondValue = true;
                        BottomRightGreenSecondValue = 50;
                        setBottomRightRedSecondValue = true;
                        BottomRightRedSecondValue = 50;
                        setLeftBlueSecondValue = true;
                        LeftBlueSecondValue = 50;
                        setLeftGreenSecondValue = true;
                        LeftGreenSecondValue = 50;
                        setLeftRedSecondValue = true;
                        LeftRedSecondValue = 50;
                        setMiddleBlueSecondValue = true;
                        MiddleBlueSecondValue = 75;
                        setMiddleGreenSecondValue = true;
                        MiddleGreenSecondValue = 75;
                        setMiddleRedSecondValue = true;
                        MiddleRedSecondValue = 75;
                        setRightBlueSecondValue = true;
                        RightBlueSecondValue = 50;
                        setRightGreenSecondValue = true;
                        RightGreenSecondValue = 50;
                        setRightRedSecondValue = true;
                        RightRedSecondValue = 50;
                        setTopBlueSecondValue = true;
                        TopBlueSecondValue = 50;
                        setTopGreenSecondValue = true;
                        TopGreenSecondValue = 50;
                        setTopRedSecondValue = true;
                        TopRedSecondValue = 50;
                        setTopLeftBlueSecondValue = true;
                        TopLeftBlueSecondValue = 50;
                        setTopLeftGreenSecondValue = true;
                        TopLeftGreenSecondValue = 50;
                        setTopLeftRedSecondValue = true;
                        TopLeftRedSecondValue = 50;
                        setTopRightBlueSecondValue = true;
                        TopRightBlueSecondValue = 50;
                        setTopRightGreenSecondValue = true;
                        TopRightGreenSecondValue = 50;
                        setTopRightRedSecondValue = true;
                        TopRightRedSecondValue = 50;
                        break;
                    case  ColorState.Blue:
                        setBottomBlueSecondValue = true;
                        BottomBlueSecondValue = 250;
                        setBottomGreenSecondValue = true;
                        BottomGreenSecondValue = 206;
                        setBottomRedSecondValue = true;
                        BottomRedSecondValue = 135;
                        setBottomLeftBlueSecondValue = true;
                        BottomLeftBlueSecondValue = 250;
                        setBottomLeftGreenSecondValue = true;
                        BottomLeftGreenSecondValue = 206;
                        setBottomLeftRedSecondValue = true;
                        BottomLeftRedSecondValue = 135;
                        setBottomRightBlueSecondValue = true;
                        BottomRightBlueSecondValue = 250;
                        setBottomRightGreenSecondValue = true;
                        BottomRightGreenSecondValue = 206;
                        setBottomRightRedSecondValue = true;
                        BottomRightRedSecondValue = 135;
                        setLeftBlueSecondValue = true;
                        LeftBlueSecondValue = 250;
                        setLeftGreenSecondValue = true;
                        LeftGreenSecondValue = 206;
                        setLeftRedSecondValue = true;
                        LeftRedSecondValue = 135;
                        setMiddleBlueSecondValue = true;
                        MiddleBlueSecondValue = 255;
                        setMiddleGreenSecondValue = true;
                        MiddleGreenSecondValue = 255;
                        setMiddleRedSecondValue = true;
                        MiddleRedSecondValue = 224;
                        setRightBlueSecondValue = true;
                        RightBlueSecondValue = 250;
                        setRightGreenSecondValue = true;
                        RightGreenSecondValue = 206;
                        setRightRedSecondValue = true;
                        RightRedSecondValue = 135;
                        setTopBlueSecondValue = true;
                        TopBlueSecondValue = 250;
                        setTopGreenSecondValue = true;
                        TopGreenSecondValue = 206;
                        setTopRedSecondValue = true;
                        TopRedSecondValue = 135;
                        setTopLeftBlueSecondValue = true;
                        TopLeftBlueSecondValue = 235;
                        setTopLeftGreenSecondValue = true;
                        TopLeftGreenSecondValue = 206;
                        setTopLeftRedSecondValue = true;
                        TopLeftRedSecondValue = 135;
                        setTopRightBlueSecondValue = true;
                        TopRightBlueSecondValue = 250;
                        setTopRightGreenSecondValue = true;
                        TopRightGreenSecondValue = 206;
                        setTopRightRedSecondValue = true;
                        TopRightRedSecondValue = 135;
                        break;
                }
                if (setBottomBlueFirstValue && setBottomBlueSecondValue)
                {
                    Bottom.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(BottomBlueFirstValue* (1 - interpolationValue) + BottomBlueSecondValue * interpolationValue);
                }
                if (setBottomGreenFirstValue && setBottomGreenSecondValue)
                {
                    Bottom.Green = FlatRedBall.Math.MathFunctions.RoundToInt(BottomGreenFirstValue* (1 - interpolationValue) + BottomGreenSecondValue * interpolationValue);
                }
                if (setBottomRedFirstValue && setBottomRedSecondValue)
                {
                    Bottom.Red = FlatRedBall.Math.MathFunctions.RoundToInt(BottomRedFirstValue* (1 - interpolationValue) + BottomRedSecondValue * interpolationValue);
                }
                if (setBottomLeftBlueFirstValue && setBottomLeftBlueSecondValue)
                {
                    BottomLeft.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(BottomLeftBlueFirstValue* (1 - interpolationValue) + BottomLeftBlueSecondValue * interpolationValue);
                }
                if (setBottomLeftGreenFirstValue && setBottomLeftGreenSecondValue)
                {
                    BottomLeft.Green = FlatRedBall.Math.MathFunctions.RoundToInt(BottomLeftGreenFirstValue* (1 - interpolationValue) + BottomLeftGreenSecondValue * interpolationValue);
                }
                if (setBottomLeftRedFirstValue && setBottomLeftRedSecondValue)
                {
                    BottomLeft.Red = FlatRedBall.Math.MathFunctions.RoundToInt(BottomLeftRedFirstValue* (1 - interpolationValue) + BottomLeftRedSecondValue * interpolationValue);
                }
                if (setBottomRightBlueFirstValue && setBottomRightBlueSecondValue)
                {
                    BottomRight.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(BottomRightBlueFirstValue* (1 - interpolationValue) + BottomRightBlueSecondValue * interpolationValue);
                }
                if (setBottomRightGreenFirstValue && setBottomRightGreenSecondValue)
                {
                    BottomRight.Green = FlatRedBall.Math.MathFunctions.RoundToInt(BottomRightGreenFirstValue* (1 - interpolationValue) + BottomRightGreenSecondValue * interpolationValue);
                }
                if (setBottomRightRedFirstValue && setBottomRightRedSecondValue)
                {
                    BottomRight.Red = FlatRedBall.Math.MathFunctions.RoundToInt(BottomRightRedFirstValue* (1 - interpolationValue) + BottomRightRedSecondValue * interpolationValue);
                }
                if (setLeftBlueFirstValue && setLeftBlueSecondValue)
                {
                    Left.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(LeftBlueFirstValue* (1 - interpolationValue) + LeftBlueSecondValue * interpolationValue);
                }
                if (setLeftGreenFirstValue && setLeftGreenSecondValue)
                {
                    Left.Green = FlatRedBall.Math.MathFunctions.RoundToInt(LeftGreenFirstValue* (1 - interpolationValue) + LeftGreenSecondValue * interpolationValue);
                }
                if (setLeftRedFirstValue && setLeftRedSecondValue)
                {
                    Left.Red = FlatRedBall.Math.MathFunctions.RoundToInt(LeftRedFirstValue* (1 - interpolationValue) + LeftRedSecondValue * interpolationValue);
                }
                if (setMiddleBlueFirstValue && setMiddleBlueSecondValue)
                {
                    Middle.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(MiddleBlueFirstValue* (1 - interpolationValue) + MiddleBlueSecondValue * interpolationValue);
                }
                if (setMiddleGreenFirstValue && setMiddleGreenSecondValue)
                {
                    Middle.Green = FlatRedBall.Math.MathFunctions.RoundToInt(MiddleGreenFirstValue* (1 - interpolationValue) + MiddleGreenSecondValue * interpolationValue);
                }
                if (setMiddleRedFirstValue && setMiddleRedSecondValue)
                {
                    Middle.Red = FlatRedBall.Math.MathFunctions.RoundToInt(MiddleRedFirstValue* (1 - interpolationValue) + MiddleRedSecondValue * interpolationValue);
                }
                if (setRightBlueFirstValue && setRightBlueSecondValue)
                {
                    Right.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(RightBlueFirstValue* (1 - interpolationValue) + RightBlueSecondValue * interpolationValue);
                }
                if (setRightGreenFirstValue && setRightGreenSecondValue)
                {
                    Right.Green = FlatRedBall.Math.MathFunctions.RoundToInt(RightGreenFirstValue* (1 - interpolationValue) + RightGreenSecondValue * interpolationValue);
                }
                if (setRightRedFirstValue && setRightRedSecondValue)
                {
                    Right.Red = FlatRedBall.Math.MathFunctions.RoundToInt(RightRedFirstValue* (1 - interpolationValue) + RightRedSecondValue * interpolationValue);
                }
                if (setTopBlueFirstValue && setTopBlueSecondValue)
                {
                    Top.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(TopBlueFirstValue* (1 - interpolationValue) + TopBlueSecondValue * interpolationValue);
                }
                if (setTopGreenFirstValue && setTopGreenSecondValue)
                {
                    Top.Green = FlatRedBall.Math.MathFunctions.RoundToInt(TopGreenFirstValue* (1 - interpolationValue) + TopGreenSecondValue * interpolationValue);
                }
                if (setTopRedFirstValue && setTopRedSecondValue)
                {
                    Top.Red = FlatRedBall.Math.MathFunctions.RoundToInt(TopRedFirstValue* (1 - interpolationValue) + TopRedSecondValue * interpolationValue);
                }
                if (setTopLeftBlueFirstValue && setTopLeftBlueSecondValue)
                {
                    TopLeft.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(TopLeftBlueFirstValue* (1 - interpolationValue) + TopLeftBlueSecondValue * interpolationValue);
                }
                if (setTopLeftGreenFirstValue && setTopLeftGreenSecondValue)
                {
                    TopLeft.Green = FlatRedBall.Math.MathFunctions.RoundToInt(TopLeftGreenFirstValue* (1 - interpolationValue) + TopLeftGreenSecondValue * interpolationValue);
                }
                if (setTopLeftRedFirstValue && setTopLeftRedSecondValue)
                {
                    TopLeft.Red = FlatRedBall.Math.MathFunctions.RoundToInt(TopLeftRedFirstValue* (1 - interpolationValue) + TopLeftRedSecondValue * interpolationValue);
                }
                if (setTopRightBlueFirstValue && setTopRightBlueSecondValue)
                {
                    TopRight.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(TopRightBlueFirstValue* (1 - interpolationValue) + TopRightBlueSecondValue * interpolationValue);
                }
                if (setTopRightGreenFirstValue && setTopRightGreenSecondValue)
                {
                    TopRight.Green = FlatRedBall.Math.MathFunctions.RoundToInt(TopRightGreenFirstValue* (1 - interpolationValue) + TopRightGreenSecondValue * interpolationValue);
                }
                if (setTopRightRedFirstValue && setTopRightRedSecondValue)
                {
                    TopRight.Red = FlatRedBall.Math.MathFunctions.RoundToInt(TopRightRedFirstValue* (1 - interpolationValue) + TopRightRedSecondValue * interpolationValue);
                }
                if (interpolationValue < 1)
                {
                    mCurrentColorStateState = firstState;
                }
                else
                {
                    mCurrentColorStateState = secondState;
                }
            }
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.ChatOptionFrameRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.ChatOptionFrameRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.ChatOptionFrameRuntime.FlickerState fromState,AbbatoirIntergrade.GumRuntimes.ChatOptionFrameRuntime.FlickerState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (FlickerState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "FlickerState").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentFlickerStateState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (FlickerState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentFlickerStateState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.ChatOptionFrameRuntime.ColorState fromState,AbbatoirIntergrade.GumRuntimes.ChatOptionFrameRuntime.ColorState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (ColorState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "ColorState").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentColorStateState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (ColorState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentColorStateState = toState;
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
                            Name = "Middle.Alpha",
                            Type = "int",
                            Value = Middle.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Blue",
                            Type = "int",
                            Value = Middle.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Green",
                            Type = "int",
                            Value = Middle.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Height",
                            Type = "float",
                            Value = Middle.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Height Units",
                            Type = "DimensionUnitType",
                            Value = Middle.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Red",
                            Type = "int",
                            Value = Middle.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.SourceFile",
                            Type = "string",
                            Value = Middle.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Texture Address",
                            Type = "TextureAddress",
                            Value = Middle.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Texture Height",
                            Type = "int",
                            Value = Middle.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Texture Left",
                            Type = "int",
                            Value = Middle.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Texture Top",
                            Type = "int",
                            Value = Middle.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Texture Width",
                            Type = "int",
                            Value = Middle.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Width",
                            Type = "float",
                            Value = Middle.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Width Units",
                            Type = "DimensionUnitType",
                            Value = Middle.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.X",
                            Type = "float",
                            Value = Middle.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.X Origin",
                            Type = "HorizontalAlignment",
                            Value = Middle.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.X Units",
                            Type = "PositionUnitType",
                            Value = Middle.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Y",
                            Type = "float",
                            Value = Middle.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Middle.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Y Units",
                            Type = "PositionUnitType",
                            Value = Middle.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Blue",
                            Type = "int",
                            Value = TopLeft.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Green",
                            Type = "int",
                            Value = TopLeft.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Height",
                            Type = "float",
                            Value = TopLeft.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Height Units",
                            Type = "DimensionUnitType",
                            Value = TopLeft.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Red",
                            Type = "int",
                            Value = TopLeft.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.SourceFile",
                            Type = "string",
                            Value = TopLeft.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Address",
                            Type = "TextureAddress",
                            Value = TopLeft.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Height",
                            Type = "int",
                            Value = TopLeft.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Left",
                            Type = "int",
                            Value = TopLeft.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Top",
                            Type = "int",
                            Value = TopLeft.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Width",
                            Type = "int",
                            Value = TopLeft.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Width",
                            Type = "float",
                            Value = TopLeft.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Width Units",
                            Type = "DimensionUnitType",
                            Value = TopLeft.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.X",
                            Type = "float",
                            Value = TopLeft.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.X Origin",
                            Type = "HorizontalAlignment",
                            Value = TopLeft.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.X Units",
                            Type = "PositionUnitType",
                            Value = TopLeft.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Y",
                            Type = "float",
                            Value = TopLeft.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Y Origin",
                            Type = "VerticalAlignment",
                            Value = TopLeft.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Y Units",
                            Type = "PositionUnitType",
                            Value = TopLeft.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Blue",
                            Type = "int",
                            Value = Top.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Green",
                            Type = "int",
                            Value = Top.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Height",
                            Type = "float",
                            Value = Top.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Height Units",
                            Type = "DimensionUnitType",
                            Value = Top.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Red",
                            Type = "int",
                            Value = Top.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.SourceFile",
                            Type = "string",
                            Value = Top.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Address",
                            Type = "TextureAddress",
                            Value = Top.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Height",
                            Type = "int",
                            Value = Top.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Left",
                            Type = "int",
                            Value = Top.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Top",
                            Type = "int",
                            Value = Top.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Width",
                            Type = "int",
                            Value = Top.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Width",
                            Type = "float",
                            Value = Top.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Width Units",
                            Type = "DimensionUnitType",
                            Value = Top.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.X",
                            Type = "float",
                            Value = Top.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.X Origin",
                            Type = "HorizontalAlignment",
                            Value = Top.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.X Units",
                            Type = "PositionUnitType",
                            Value = Top.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Y",
                            Type = "float",
                            Value = Top.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Top.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Y Units",
                            Type = "PositionUnitType",
                            Value = Top.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Blue",
                            Type = "int",
                            Value = TopRight.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Green",
                            Type = "int",
                            Value = TopRight.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Height",
                            Type = "float",
                            Value = TopRight.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Height Units",
                            Type = "DimensionUnitType",
                            Value = TopRight.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Red",
                            Type = "int",
                            Value = TopRight.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.SourceFile",
                            Type = "string",
                            Value = TopRight.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Address",
                            Type = "TextureAddress",
                            Value = TopRight.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Height",
                            Type = "int",
                            Value = TopRight.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Left",
                            Type = "int",
                            Value = TopRight.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Top",
                            Type = "int",
                            Value = TopRight.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Width",
                            Type = "int",
                            Value = TopRight.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Width",
                            Type = "float",
                            Value = TopRight.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Width Units",
                            Type = "DimensionUnitType",
                            Value = TopRight.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.X",
                            Type = "float",
                            Value = TopRight.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.X Origin",
                            Type = "HorizontalAlignment",
                            Value = TopRight.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.X Units",
                            Type = "PositionUnitType",
                            Value = TopRight.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Y",
                            Type = "float",
                            Value = TopRight.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Y Origin",
                            Type = "VerticalAlignment",
                            Value = TopRight.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Y Units",
                            Type = "PositionUnitType",
                            Value = TopRight.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Blue",
                            Type = "int",
                            Value = Right.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Green",
                            Type = "int",
                            Value = Right.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Height",
                            Type = "float",
                            Value = Right.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Height Units",
                            Type = "DimensionUnitType",
                            Value = Right.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Red",
                            Type = "int",
                            Value = Right.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.SourceFile",
                            Type = "string",
                            Value = Right.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Address",
                            Type = "TextureAddress",
                            Value = Right.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Height",
                            Type = "int",
                            Value = Right.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Left",
                            Type = "int",
                            Value = Right.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Top",
                            Type = "int",
                            Value = Right.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Width",
                            Type = "int",
                            Value = Right.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Width",
                            Type = "float",
                            Value = Right.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Width Units",
                            Type = "DimensionUnitType",
                            Value = Right.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.X",
                            Type = "float",
                            Value = Right.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.X Origin",
                            Type = "HorizontalAlignment",
                            Value = Right.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.X Units",
                            Type = "PositionUnitType",
                            Value = Right.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Y",
                            Type = "float",
                            Value = Right.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Right.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Y Units",
                            Type = "PositionUnitType",
                            Value = Right.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Blue",
                            Type = "int",
                            Value = BottomRight.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Green",
                            Type = "int",
                            Value = BottomRight.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Height",
                            Type = "float",
                            Value = BottomRight.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Height Units",
                            Type = "DimensionUnitType",
                            Value = BottomRight.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Red",
                            Type = "int",
                            Value = BottomRight.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.SourceFile",
                            Type = "string",
                            Value = BottomRight.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Address",
                            Type = "TextureAddress",
                            Value = BottomRight.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Height",
                            Type = "int",
                            Value = BottomRight.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Left",
                            Type = "int",
                            Value = BottomRight.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Top",
                            Type = "int",
                            Value = BottomRight.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Width",
                            Type = "int",
                            Value = BottomRight.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Width",
                            Type = "float",
                            Value = BottomRight.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Width Units",
                            Type = "DimensionUnitType",
                            Value = BottomRight.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.X",
                            Type = "float",
                            Value = BottomRight.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.X Origin",
                            Type = "HorizontalAlignment",
                            Value = BottomRight.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.X Units",
                            Type = "PositionUnitType",
                            Value = BottomRight.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Y",
                            Type = "float",
                            Value = BottomRight.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Y Origin",
                            Type = "VerticalAlignment",
                            Value = BottomRight.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Y Units",
                            Type = "PositionUnitType",
                            Value = BottomRight.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Blue",
                            Type = "int",
                            Value = Bottom.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Green",
                            Type = "int",
                            Value = Bottom.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Height",
                            Type = "float",
                            Value = Bottom.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Height Units",
                            Type = "DimensionUnitType",
                            Value = Bottom.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Red",
                            Type = "int",
                            Value = Bottom.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.SourceFile",
                            Type = "string",
                            Value = Bottom.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Address",
                            Type = "TextureAddress",
                            Value = Bottom.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Height",
                            Type = "int",
                            Value = Bottom.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Left",
                            Type = "int",
                            Value = Bottom.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Top",
                            Type = "int",
                            Value = Bottom.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Width",
                            Type = "int",
                            Value = Bottom.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Width",
                            Type = "float",
                            Value = Bottom.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Width Units",
                            Type = "DimensionUnitType",
                            Value = Bottom.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.X",
                            Type = "float",
                            Value = Bottom.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.X Origin",
                            Type = "HorizontalAlignment",
                            Value = Bottom.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.X Units",
                            Type = "PositionUnitType",
                            Value = Bottom.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Y",
                            Type = "float",
                            Value = Bottom.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Bottom.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Y Units",
                            Type = "PositionUnitType",
                            Value = Bottom.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Blue",
                            Type = "int",
                            Value = BottomLeft.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Green",
                            Type = "int",
                            Value = BottomLeft.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Height",
                            Type = "float",
                            Value = BottomLeft.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Height Units",
                            Type = "DimensionUnitType",
                            Value = BottomLeft.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Red",
                            Type = "int",
                            Value = BottomLeft.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.SourceFile",
                            Type = "string",
                            Value = BottomLeft.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Address",
                            Type = "TextureAddress",
                            Value = BottomLeft.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Height",
                            Type = "int",
                            Value = BottomLeft.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Left",
                            Type = "int",
                            Value = BottomLeft.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Top",
                            Type = "int",
                            Value = BottomLeft.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Width",
                            Type = "int",
                            Value = BottomLeft.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Width",
                            Type = "float",
                            Value = BottomLeft.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Width Units",
                            Type = "DimensionUnitType",
                            Value = BottomLeft.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.X",
                            Type = "float",
                            Value = BottomLeft.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.X Origin",
                            Type = "HorizontalAlignment",
                            Value = BottomLeft.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.X Units",
                            Type = "PositionUnitType",
                            Value = BottomLeft.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Y",
                            Type = "float",
                            Value = BottomLeft.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Y Origin",
                            Type = "VerticalAlignment",
                            Value = BottomLeft.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Y Units",
                            Type = "PositionUnitType",
                            Value = BottomLeft.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Blue",
                            Type = "int",
                            Value = Left.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Green",
                            Type = "int",
                            Value = Left.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Height",
                            Type = "float",
                            Value = Left.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Height Units",
                            Type = "DimensionUnitType",
                            Value = Left.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Red",
                            Type = "int",
                            Value = Left.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.SourceFile",
                            Type = "string",
                            Value = Left.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Address",
                            Type = "TextureAddress",
                            Value = Left.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Height",
                            Type = "int",
                            Value = Left.TextureHeight
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Left",
                            Type = "int",
                            Value = Left.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Top",
                            Type = "int",
                            Value = Left.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Width",
                            Type = "int",
                            Value = Left.TextureWidth
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Width",
                            Type = "float",
                            Value = Left.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Width Units",
                            Type = "DimensionUnitType",
                            Value = Left.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.X",
                            Type = "float",
                            Value = Left.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.X Origin",
                            Type = "HorizontalAlignment",
                            Value = Left.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.X Units",
                            Type = "PositionUnitType",
                            Value = Left.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Y",
                            Type = "float",
                            Value = Left.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Left.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Y Units",
                            Type = "PositionUnitType",
                            Value = Left.YUnits
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
                            Value = Height + 12.99866f
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
                            Value = Width + 8.223843f
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
                            Value = X + -0.1339325f
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
                            Value = Y + -0.008815452f
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
                            Name = "Middle.Alpha",
                            Type = "int",
                            Value = Middle.Alpha + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Blue",
                            Type = "int",
                            Value = Middle.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Green",
                            Type = "int",
                            Value = Middle.Green + 30
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Height",
                            Type = "float",
                            Value = Middle.Height + -32f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Height Units",
                            Type = "DimensionUnitType",
                            Value = Middle.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Red",
                            Type = "int",
                            Value = Middle.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.SourceFile",
                            Type = "string",
                            Value = Middle.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Texture Address",
                            Type = "TextureAddress",
                            Value = Middle.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Texture Height",
                            Type = "int",
                            Value = Middle.TextureHeight + 1
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Texture Left",
                            Type = "int",
                            Value = Middle.TextureLeft + 36
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Texture Top",
                            Type = "int",
                            Value = Middle.TextureTop + 36
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Texture Width",
                            Type = "int",
                            Value = Middle.TextureWidth + 1
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Width",
                            Type = "float",
                            Value = Middle.Width + -32f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Width Units",
                            Type = "DimensionUnitType",
                            Value = Middle.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.X",
                            Type = "float",
                            Value = Middle.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.X Origin",
                            Type = "HorizontalAlignment",
                            Value = Middle.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.X Units",
                            Type = "PositionUnitType",
                            Value = Middle.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Y",
                            Type = "float",
                            Value = Middle.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Middle.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Y Units",
                            Type = "PositionUnitType",
                            Value = Middle.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Blue",
                            Type = "int",
                            Value = TopLeft.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Green",
                            Type = "int",
                            Value = TopLeft.Green + 175
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Height",
                            Type = "float",
                            Value = TopLeft.Height + 32f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Height Units",
                            Type = "DimensionUnitType",
                            Value = TopLeft.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Red",
                            Type = "int",
                            Value = TopLeft.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.SourceFile",
                            Type = "string",
                            Value = TopLeft.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Address",
                            Type = "TextureAddress",
                            Value = TopLeft.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Height",
                            Type = "int",
                            Value = TopLeft.TextureHeight + 64
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Left",
                            Type = "int",
                            Value = TopLeft.TextureLeft + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Top",
                            Type = "int",
                            Value = TopLeft.TextureTop + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Width",
                            Type = "int",
                            Value = TopLeft.TextureWidth + 64
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Width",
                            Type = "float",
                            Value = TopLeft.Width + 32f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Width Units",
                            Type = "DimensionUnitType",
                            Value = TopLeft.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.X",
                            Type = "float",
                            Value = TopLeft.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.X Origin",
                            Type = "HorizontalAlignment",
                            Value = TopLeft.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.X Units",
                            Type = "PositionUnitType",
                            Value = TopLeft.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Y",
                            Type = "float",
                            Value = TopLeft.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Y Origin",
                            Type = "VerticalAlignment",
                            Value = TopLeft.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Y Units",
                            Type = "PositionUnitType",
                            Value = TopLeft.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Blue",
                            Type = "int",
                            Value = Top.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Green",
                            Type = "int",
                            Value = Top.Green + 175
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Height",
                            Type = "float",
                            Value = Top.Height + 32f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Height Units",
                            Type = "DimensionUnitType",
                            Value = Top.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Red",
                            Type = "int",
                            Value = Top.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.SourceFile",
                            Type = "string",
                            Value = Top.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Address",
                            Type = "TextureAddress",
                            Value = Top.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Height",
                            Type = "int",
                            Value = Top.TextureHeight + 64
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Left",
                            Type = "int",
                            Value = Top.TextureLeft + 64
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Top",
                            Type = "int",
                            Value = Top.TextureTop + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Width",
                            Type = "int",
                            Value = Top.TextureWidth + 128
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Width",
                            Type = "float",
                            Value = Top.Width + -64f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Width Units",
                            Type = "DimensionUnitType",
                            Value = Top.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.X",
                            Type = "float",
                            Value = Top.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.X Origin",
                            Type = "HorizontalAlignment",
                            Value = Top.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.X Units",
                            Type = "PositionUnitType",
                            Value = Top.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Y",
                            Type = "float",
                            Value = Top.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Top.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Y Units",
                            Type = "PositionUnitType",
                            Value = Top.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Blue",
                            Type = "int",
                            Value = TopRight.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Green",
                            Type = "int",
                            Value = TopRight.Green + 175
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Height",
                            Type = "float",
                            Value = TopRight.Height + 32f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Height Units",
                            Type = "DimensionUnitType",
                            Value = TopRight.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Red",
                            Type = "int",
                            Value = TopRight.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.SourceFile",
                            Type = "string",
                            Value = TopRight.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Address",
                            Type = "TextureAddress",
                            Value = TopRight.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Height",
                            Type = "int",
                            Value = TopRight.TextureHeight + 64
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Left",
                            Type = "int",
                            Value = TopRight.TextureLeft + 192
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Top",
                            Type = "int",
                            Value = TopRight.TextureTop + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Width",
                            Type = "int",
                            Value = TopRight.TextureWidth + 64
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Width",
                            Type = "float",
                            Value = TopRight.Width + 32f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Width Units",
                            Type = "DimensionUnitType",
                            Value = TopRight.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.X",
                            Type = "float",
                            Value = TopRight.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.X Origin",
                            Type = "HorizontalAlignment",
                            Value = TopRight.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.X Units",
                            Type = "PositionUnitType",
                            Value = TopRight.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Y",
                            Type = "float",
                            Value = TopRight.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Y Origin",
                            Type = "VerticalAlignment",
                            Value = TopRight.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Y Units",
                            Type = "PositionUnitType",
                            Value = TopRight.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Blue",
                            Type = "int",
                            Value = Right.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Green",
                            Type = "int",
                            Value = Right.Green + 175
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Height",
                            Type = "float",
                            Value = Right.Height + -64f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Height Units",
                            Type = "DimensionUnitType",
                            Value = Right.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Red",
                            Type = "int",
                            Value = Right.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.SourceFile",
                            Type = "string",
                            Value = Right.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Address",
                            Type = "TextureAddress",
                            Value = Right.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Height",
                            Type = "int",
                            Value = Right.TextureHeight + 128
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Left",
                            Type = "int",
                            Value = Right.TextureLeft + 192
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Top",
                            Type = "int",
                            Value = Right.TextureTop + 64
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Width",
                            Type = "int",
                            Value = Right.TextureWidth + 64
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Width",
                            Type = "float",
                            Value = Right.Width + 32f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Width Units",
                            Type = "DimensionUnitType",
                            Value = Right.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.X",
                            Type = "float",
                            Value = Right.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.X Origin",
                            Type = "HorizontalAlignment",
                            Value = Right.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.X Units",
                            Type = "PositionUnitType",
                            Value = Right.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Y",
                            Type = "float",
                            Value = Right.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Right.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Y Units",
                            Type = "PositionUnitType",
                            Value = Right.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Blue",
                            Type = "int",
                            Value = BottomRight.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Green",
                            Type = "int",
                            Value = BottomRight.Green + 175
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Height",
                            Type = "float",
                            Value = BottomRight.Height + 32f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Height Units",
                            Type = "DimensionUnitType",
                            Value = BottomRight.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Red",
                            Type = "int",
                            Value = BottomRight.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.SourceFile",
                            Type = "string",
                            Value = BottomRight.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Address",
                            Type = "TextureAddress",
                            Value = BottomRight.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Height",
                            Type = "int",
                            Value = BottomRight.TextureHeight + 64
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Left",
                            Type = "int",
                            Value = BottomRight.TextureLeft + 192
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Top",
                            Type = "int",
                            Value = BottomRight.TextureTop + 192
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Width",
                            Type = "int",
                            Value = BottomRight.TextureWidth + 64
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Width",
                            Type = "float",
                            Value = BottomRight.Width + 32f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Width Units",
                            Type = "DimensionUnitType",
                            Value = BottomRight.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.X",
                            Type = "float",
                            Value = BottomRight.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.X Origin",
                            Type = "HorizontalAlignment",
                            Value = BottomRight.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.X Units",
                            Type = "PositionUnitType",
                            Value = BottomRight.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Y",
                            Type = "float",
                            Value = BottomRight.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Y Origin",
                            Type = "VerticalAlignment",
                            Value = BottomRight.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Y Units",
                            Type = "PositionUnitType",
                            Value = BottomRight.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Blue",
                            Type = "int",
                            Value = Bottom.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Green",
                            Type = "int",
                            Value = Bottom.Green + 175
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Height",
                            Type = "float",
                            Value = Bottom.Height + 32f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Height Units",
                            Type = "DimensionUnitType",
                            Value = Bottom.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Red",
                            Type = "int",
                            Value = Bottom.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.SourceFile",
                            Type = "string",
                            Value = Bottom.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Address",
                            Type = "TextureAddress",
                            Value = Bottom.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Height",
                            Type = "int",
                            Value = Bottom.TextureHeight + 64
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Left",
                            Type = "int",
                            Value = Bottom.TextureLeft + 64
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Top",
                            Type = "int",
                            Value = Bottom.TextureTop + 192
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Width",
                            Type = "int",
                            Value = Bottom.TextureWidth + 128
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Width",
                            Type = "float",
                            Value = Bottom.Width + -64f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Width Units",
                            Type = "DimensionUnitType",
                            Value = Bottom.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.X",
                            Type = "float",
                            Value = Bottom.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.X Origin",
                            Type = "HorizontalAlignment",
                            Value = Bottom.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.X Units",
                            Type = "PositionUnitType",
                            Value = Bottom.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Y",
                            Type = "float",
                            Value = Bottom.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Bottom.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Y Units",
                            Type = "PositionUnitType",
                            Value = Bottom.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Blue",
                            Type = "int",
                            Value = BottomLeft.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Green",
                            Type = "int",
                            Value = BottomLeft.Green + 175
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Height",
                            Type = "float",
                            Value = BottomLeft.Height + 32f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Height Units",
                            Type = "DimensionUnitType",
                            Value = BottomLeft.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Red",
                            Type = "int",
                            Value = BottomLeft.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.SourceFile",
                            Type = "string",
                            Value = BottomLeft.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Address",
                            Type = "TextureAddress",
                            Value = BottomLeft.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Height",
                            Type = "int",
                            Value = BottomLeft.TextureHeight + 64
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Left",
                            Type = "int",
                            Value = BottomLeft.TextureLeft + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Top",
                            Type = "int",
                            Value = BottomLeft.TextureTop + 192
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Width",
                            Type = "int",
                            Value = BottomLeft.TextureWidth + 64
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Width",
                            Type = "float",
                            Value = BottomLeft.Width + 32f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Width Units",
                            Type = "DimensionUnitType",
                            Value = BottomLeft.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.X",
                            Type = "float",
                            Value = BottomLeft.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.X Origin",
                            Type = "HorizontalAlignment",
                            Value = BottomLeft.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.X Units",
                            Type = "PositionUnitType",
                            Value = BottomLeft.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Y",
                            Type = "float",
                            Value = BottomLeft.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Y Origin",
                            Type = "VerticalAlignment",
                            Value = BottomLeft.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Y Units",
                            Type = "PositionUnitType",
                            Value = BottomLeft.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Blue",
                            Type = "int",
                            Value = Left.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Green",
                            Type = "int",
                            Value = Left.Green + 175
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Height",
                            Type = "float",
                            Value = Left.Height + -64f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Height Units",
                            Type = "DimensionUnitType",
                            Value = Left.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Red",
                            Type = "int",
                            Value = Left.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.SourceFile",
                            Type = "string",
                            Value = Left.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Address",
                            Type = "TextureAddress",
                            Value = Left.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Height",
                            Type = "int",
                            Value = Left.TextureHeight + 128
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Left",
                            Type = "int",
                            Value = Left.TextureLeft + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Top",
                            Type = "int",
                            Value = Left.TextureTop + 64
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Width",
                            Type = "int",
                            Value = Left.TextureWidth + 64
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Width",
                            Type = "float",
                            Value = Left.Width + 32f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Width Units",
                            Type = "DimensionUnitType",
                            Value = Left.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.X",
                            Type = "float",
                            Value = Left.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.X Origin",
                            Type = "HorizontalAlignment",
                            Value = Left.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.X Units",
                            Type = "PositionUnitType",
                            Value = Left.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Y",
                            Type = "float",
                            Value = Left.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Y Origin",
                            Type = "VerticalAlignment",
                            Value = Left.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Y Units",
                            Type = "PositionUnitType",
                            Value = Left.YUnits
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (FlickerState state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  FlickerState.Flicker1:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Left",
                            Type = "int",
                            Value = TopLeft.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Top",
                            Type = "int",
                            Value = TopLeft.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Left",
                            Type = "int",
                            Value = Top.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Top",
                            Type = "int",
                            Value = Top.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Left",
                            Type = "int",
                            Value = TopRight.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Top",
                            Type = "int",
                            Value = TopRight.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Left",
                            Type = "int",
                            Value = Right.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Top",
                            Type = "int",
                            Value = Right.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Left",
                            Type = "int",
                            Value = BottomRight.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Top",
                            Type = "int",
                            Value = BottomRight.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Left",
                            Type = "int",
                            Value = Bottom.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Top",
                            Type = "int",
                            Value = Bottom.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Left",
                            Type = "int",
                            Value = BottomLeft.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Top",
                            Type = "int",
                            Value = BottomLeft.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Left",
                            Type = "int",
                            Value = Left.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Top",
                            Type = "int",
                            Value = Left.TextureTop
                        }
                        );
                        break;
                    case  FlickerState.Flicker2:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Left",
                            Type = "int",
                            Value = TopLeft.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Top",
                            Type = "int",
                            Value = TopLeft.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Left",
                            Type = "int",
                            Value = Top.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Top",
                            Type = "int",
                            Value = Top.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Left",
                            Type = "int",
                            Value = TopRight.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Top",
                            Type = "int",
                            Value = TopRight.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Left",
                            Type = "int",
                            Value = Right.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Top",
                            Type = "int",
                            Value = Right.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Left",
                            Type = "int",
                            Value = BottomRight.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Top",
                            Type = "int",
                            Value = BottomRight.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Left",
                            Type = "int",
                            Value = Bottom.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Top",
                            Type = "int",
                            Value = Bottom.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Left",
                            Type = "int",
                            Value = BottomLeft.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Top",
                            Type = "int",
                            Value = BottomLeft.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Left",
                            Type = "int",
                            Value = Left.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Top",
                            Type = "int",
                            Value = Left.TextureTop
                        }
                        );
                        break;
                    case  FlickerState.Flicker3:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Left",
                            Type = "int",
                            Value = TopLeft.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Top",
                            Type = "int",
                            Value = TopLeft.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Left",
                            Type = "int",
                            Value = Top.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Top",
                            Type = "int",
                            Value = Top.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Left",
                            Type = "int",
                            Value = TopRight.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Top",
                            Type = "int",
                            Value = TopRight.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Left",
                            Type = "int",
                            Value = Right.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Top",
                            Type = "int",
                            Value = Right.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Left",
                            Type = "int",
                            Value = BottomRight.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Top",
                            Type = "int",
                            Value = BottomRight.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Left",
                            Type = "int",
                            Value = Bottom.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Top",
                            Type = "int",
                            Value = Bottom.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Left",
                            Type = "int",
                            Value = BottomLeft.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Top",
                            Type = "int",
                            Value = BottomLeft.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Left",
                            Type = "int",
                            Value = Left.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Top",
                            Type = "int",
                            Value = Left.TextureTop
                        }
                        );
                        break;
                    case  FlickerState.Flicker4:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Left",
                            Type = "int",
                            Value = TopLeft.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Top",
                            Type = "int",
                            Value = TopLeft.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Left",
                            Type = "int",
                            Value = Top.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Top",
                            Type = "int",
                            Value = Top.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Left",
                            Type = "int",
                            Value = TopRight.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Top",
                            Type = "int",
                            Value = TopRight.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Left",
                            Type = "int",
                            Value = Right.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Top",
                            Type = "int",
                            Value = Right.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Left",
                            Type = "int",
                            Value = BottomRight.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Top",
                            Type = "int",
                            Value = BottomRight.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Left",
                            Type = "int",
                            Value = Bottom.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Top",
                            Type = "int",
                            Value = Bottom.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Left",
                            Type = "int",
                            Value = BottomLeft.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Top",
                            Type = "int",
                            Value = BottomLeft.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Left",
                            Type = "int",
                            Value = Left.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Top",
                            Type = "int",
                            Value = Left.TextureTop
                        }
                        );
                        break;
                    case  FlickerState.Flicker5:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Left",
                            Type = "int",
                            Value = TopLeft.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Top",
                            Type = "int",
                            Value = TopLeft.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Left",
                            Type = "int",
                            Value = Top.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Top",
                            Type = "int",
                            Value = Top.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Left",
                            Type = "int",
                            Value = TopRight.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Top",
                            Type = "int",
                            Value = TopRight.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Left",
                            Type = "int",
                            Value = Right.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Top",
                            Type = "int",
                            Value = Right.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Left",
                            Type = "int",
                            Value = BottomRight.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Top",
                            Type = "int",
                            Value = BottomRight.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Left",
                            Type = "int",
                            Value = Bottom.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Top",
                            Type = "int",
                            Value = Bottom.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Left",
                            Type = "int",
                            Value = BottomLeft.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Top",
                            Type = "int",
                            Value = BottomLeft.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Left",
                            Type = "int",
                            Value = Left.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Top",
                            Type = "int",
                            Value = Left.TextureTop
                        }
                        );
                        break;
                    case  FlickerState.Flicker6:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Left",
                            Type = "int",
                            Value = TopLeft.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Top",
                            Type = "int",
                            Value = TopLeft.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Left",
                            Type = "int",
                            Value = Top.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Top",
                            Type = "int",
                            Value = Top.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Left",
                            Type = "int",
                            Value = TopRight.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Top",
                            Type = "int",
                            Value = TopRight.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Left",
                            Type = "int",
                            Value = Right.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Top",
                            Type = "int",
                            Value = Right.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Left",
                            Type = "int",
                            Value = BottomRight.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Top",
                            Type = "int",
                            Value = BottomRight.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Left",
                            Type = "int",
                            Value = Bottom.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Top",
                            Type = "int",
                            Value = Bottom.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Left",
                            Type = "int",
                            Value = BottomLeft.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Top",
                            Type = "int",
                            Value = BottomLeft.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Left",
                            Type = "int",
                            Value = Left.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Top",
                            Type = "int",
                            Value = Left.TextureTop
                        }
                        );
                        break;
                    case  FlickerState.Flicker7:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Left",
                            Type = "int",
                            Value = TopLeft.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Top",
                            Type = "int",
                            Value = TopLeft.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Left",
                            Type = "int",
                            Value = Top.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Top",
                            Type = "int",
                            Value = Top.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Left",
                            Type = "int",
                            Value = TopRight.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Top",
                            Type = "int",
                            Value = TopRight.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Left",
                            Type = "int",
                            Value = Right.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Top",
                            Type = "int",
                            Value = Right.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Left",
                            Type = "int",
                            Value = BottomRight.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Top",
                            Type = "int",
                            Value = BottomRight.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Left",
                            Type = "int",
                            Value = Bottom.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Top",
                            Type = "int",
                            Value = Bottom.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Left",
                            Type = "int",
                            Value = BottomLeft.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Top",
                            Type = "int",
                            Value = BottomLeft.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Left",
                            Type = "int",
                            Value = Left.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Top",
                            Type = "int",
                            Value = Left.TextureTop
                        }
                        );
                        break;
                    case  FlickerState.Flicker8:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Left",
                            Type = "int",
                            Value = TopLeft.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Top",
                            Type = "int",
                            Value = TopLeft.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Left",
                            Type = "int",
                            Value = Top.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Top",
                            Type = "int",
                            Value = Top.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Left",
                            Type = "int",
                            Value = TopRight.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Top",
                            Type = "int",
                            Value = TopRight.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Left",
                            Type = "int",
                            Value = Right.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Top",
                            Type = "int",
                            Value = Right.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Left",
                            Type = "int",
                            Value = BottomRight.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Top",
                            Type = "int",
                            Value = BottomRight.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Left",
                            Type = "int",
                            Value = Bottom.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Top",
                            Type = "int",
                            Value = Bottom.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Left",
                            Type = "int",
                            Value = BottomLeft.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Top",
                            Type = "int",
                            Value = BottomLeft.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Left",
                            Type = "int",
                            Value = Left.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Top",
                            Type = "int",
                            Value = Left.TextureTop
                        }
                        );
                        break;
                    case  FlickerState.Flicker9:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Left",
                            Type = "int",
                            Value = TopLeft.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Top",
                            Type = "int",
                            Value = TopLeft.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Left",
                            Type = "int",
                            Value = Top.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Top",
                            Type = "int",
                            Value = Top.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Left",
                            Type = "int",
                            Value = TopRight.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Top",
                            Type = "int",
                            Value = TopRight.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Left",
                            Type = "int",
                            Value = Right.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Top",
                            Type = "int",
                            Value = Right.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Left",
                            Type = "int",
                            Value = BottomRight.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Top",
                            Type = "int",
                            Value = BottomRight.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Left",
                            Type = "int",
                            Value = Bottom.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Top",
                            Type = "int",
                            Value = Bottom.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Left",
                            Type = "int",
                            Value = BottomLeft.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Top",
                            Type = "int",
                            Value = BottomLeft.TextureTop
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Left",
                            Type = "int",
                            Value = Left.TextureLeft
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Top",
                            Type = "int",
                            Value = Left.TextureTop
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (FlickerState state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  FlickerState.Flicker1:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Left",
                            Type = "int",
                            Value = TopLeft.TextureLeft + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Top",
                            Type = "int",
                            Value = TopLeft.TextureTop + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Left",
                            Type = "int",
                            Value = Top.TextureLeft + 64
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Top",
                            Type = "int",
                            Value = Top.TextureTop + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Left",
                            Type = "int",
                            Value = TopRight.TextureLeft + 192
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Top",
                            Type = "int",
                            Value = TopRight.TextureTop + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Left",
                            Type = "int",
                            Value = Right.TextureLeft + 192
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Top",
                            Type = "int",
                            Value = Right.TextureTop + 64
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Left",
                            Type = "int",
                            Value = BottomRight.TextureLeft + 192
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Top",
                            Type = "int",
                            Value = BottomRight.TextureTop + 192
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Left",
                            Type = "int",
                            Value = Bottom.TextureLeft + 64
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Top",
                            Type = "int",
                            Value = Bottom.TextureTop + 192
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Left",
                            Type = "int",
                            Value = BottomLeft.TextureLeft + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Top",
                            Type = "int",
                            Value = BottomLeft.TextureTop + 192
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Left",
                            Type = "int",
                            Value = Left.TextureLeft + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Top",
                            Type = "int",
                            Value = Left.TextureTop + 64
                        }
                        );
                        break;
                    case  FlickerState.Flicker2:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Left",
                            Type = "int",
                            Value = TopLeft.TextureLeft + 256
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Top",
                            Type = "int",
                            Value = TopLeft.TextureTop + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Left",
                            Type = "int",
                            Value = Top.TextureLeft + 320
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Top",
                            Type = "int",
                            Value = Top.TextureTop + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Left",
                            Type = "int",
                            Value = TopRight.TextureLeft + 448
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Top",
                            Type = "int",
                            Value = TopRight.TextureTop + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Left",
                            Type = "int",
                            Value = Right.TextureLeft + 448
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Top",
                            Type = "int",
                            Value = Right.TextureTop + 64
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Left",
                            Type = "int",
                            Value = BottomRight.TextureLeft + 448
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Top",
                            Type = "int",
                            Value = BottomRight.TextureTop + 192
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Left",
                            Type = "int",
                            Value = Bottom.TextureLeft + 320
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Top",
                            Type = "int",
                            Value = Bottom.TextureTop + 192
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Left",
                            Type = "int",
                            Value = BottomLeft.TextureLeft + 256
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Top",
                            Type = "int",
                            Value = BottomLeft.TextureTop + 192
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Left",
                            Type = "int",
                            Value = Left.TextureLeft + 256
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Top",
                            Type = "int",
                            Value = Left.TextureTop + 64
                        }
                        );
                        break;
                    case  FlickerState.Flicker3:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Left",
                            Type = "int",
                            Value = TopLeft.TextureLeft + 512
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Top",
                            Type = "int",
                            Value = TopLeft.TextureTop + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Left",
                            Type = "int",
                            Value = Top.TextureLeft + 576
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Top",
                            Type = "int",
                            Value = Top.TextureTop + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Left",
                            Type = "int",
                            Value = TopRight.TextureLeft + 704
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Top",
                            Type = "int",
                            Value = TopRight.TextureTop + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Left",
                            Type = "int",
                            Value = Right.TextureLeft + 704
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Top",
                            Type = "int",
                            Value = Right.TextureTop + 64
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Left",
                            Type = "int",
                            Value = BottomRight.TextureLeft + 704
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Top",
                            Type = "int",
                            Value = BottomRight.TextureTop + 192
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Left",
                            Type = "int",
                            Value = Bottom.TextureLeft + 576
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Top",
                            Type = "int",
                            Value = Bottom.TextureTop + 192
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Left",
                            Type = "int",
                            Value = BottomLeft.TextureLeft + 512
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Top",
                            Type = "int",
                            Value = BottomLeft.TextureTop + 192
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Left",
                            Type = "int",
                            Value = Left.TextureLeft + 512
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Top",
                            Type = "int",
                            Value = Left.TextureTop + 64
                        }
                        );
                        break;
                    case  FlickerState.Flicker4:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Left",
                            Type = "int",
                            Value = TopLeft.TextureLeft + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Top",
                            Type = "int",
                            Value = TopLeft.TextureTop + 256
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Left",
                            Type = "int",
                            Value = Top.TextureLeft + 64
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Top",
                            Type = "int",
                            Value = Top.TextureTop + 256
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Left",
                            Type = "int",
                            Value = TopRight.TextureLeft + 192
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Top",
                            Type = "int",
                            Value = TopRight.TextureTop + 256
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Left",
                            Type = "int",
                            Value = Right.TextureLeft + 192
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Top",
                            Type = "int",
                            Value = Right.TextureTop + 320
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Left",
                            Type = "int",
                            Value = BottomRight.TextureLeft + 192
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Top",
                            Type = "int",
                            Value = BottomRight.TextureTop + 448
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Left",
                            Type = "int",
                            Value = Bottom.TextureLeft + 64
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Top",
                            Type = "int",
                            Value = Bottom.TextureTop + 448
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Left",
                            Type = "int",
                            Value = BottomLeft.TextureLeft + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Top",
                            Type = "int",
                            Value = BottomLeft.TextureTop + 448
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Left",
                            Type = "int",
                            Value = Left.TextureLeft + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Top",
                            Type = "int",
                            Value = Left.TextureTop + 320
                        }
                        );
                        break;
                    case  FlickerState.Flicker5:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Left",
                            Type = "int",
                            Value = TopLeft.TextureLeft + 256
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Top",
                            Type = "int",
                            Value = TopLeft.TextureTop + 256
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Left",
                            Type = "int",
                            Value = Top.TextureLeft + 320
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Top",
                            Type = "int",
                            Value = Top.TextureTop + 256
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Left",
                            Type = "int",
                            Value = TopRight.TextureLeft + 448
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Top",
                            Type = "int",
                            Value = TopRight.TextureTop + 256
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Left",
                            Type = "int",
                            Value = Right.TextureLeft + 448
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Top",
                            Type = "int",
                            Value = Right.TextureTop + 320
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Left",
                            Type = "int",
                            Value = BottomRight.TextureLeft + 448
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Top",
                            Type = "int",
                            Value = BottomRight.TextureTop + 448
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Left",
                            Type = "int",
                            Value = Bottom.TextureLeft + 320
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Top",
                            Type = "int",
                            Value = Bottom.TextureTop + 448
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Left",
                            Type = "int",
                            Value = BottomLeft.TextureLeft + 256
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Top",
                            Type = "int",
                            Value = BottomLeft.TextureTop + 448
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Left",
                            Type = "int",
                            Value = Left.TextureLeft + 256
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Top",
                            Type = "int",
                            Value = Left.TextureTop + 320
                        }
                        );
                        break;
                    case  FlickerState.Flicker6:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Left",
                            Type = "int",
                            Value = TopLeft.TextureLeft + 512
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Top",
                            Type = "int",
                            Value = TopLeft.TextureTop + 256
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Left",
                            Type = "int",
                            Value = Top.TextureLeft + 576
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Top",
                            Type = "int",
                            Value = Top.TextureTop + 256
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Left",
                            Type = "int",
                            Value = TopRight.TextureLeft + 704
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Top",
                            Type = "int",
                            Value = TopRight.TextureTop + 256
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Left",
                            Type = "int",
                            Value = Right.TextureLeft + 704
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Top",
                            Type = "int",
                            Value = Right.TextureTop + 320
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Left",
                            Type = "int",
                            Value = BottomRight.TextureLeft + 704
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Top",
                            Type = "int",
                            Value = BottomRight.TextureTop + 448
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Left",
                            Type = "int",
                            Value = Bottom.TextureLeft + 576
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Top",
                            Type = "int",
                            Value = Bottom.TextureTop + 448
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Left",
                            Type = "int",
                            Value = BottomLeft.TextureLeft + 512
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Top",
                            Type = "int",
                            Value = BottomLeft.TextureTop + 448
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Left",
                            Type = "int",
                            Value = Left.TextureLeft + 512
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Top",
                            Type = "int",
                            Value = Left.TextureTop + 320
                        }
                        );
                        break;
                    case  FlickerState.Flicker7:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Left",
                            Type = "int",
                            Value = TopLeft.TextureLeft + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Top",
                            Type = "int",
                            Value = TopLeft.TextureTop + 512
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Left",
                            Type = "int",
                            Value = Top.TextureLeft + 64
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Top",
                            Type = "int",
                            Value = Top.TextureTop + 512
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Left",
                            Type = "int",
                            Value = TopRight.TextureLeft + 192
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Top",
                            Type = "int",
                            Value = TopRight.TextureTop + 512
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Left",
                            Type = "int",
                            Value = Right.TextureLeft + 192
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Top",
                            Type = "int",
                            Value = Right.TextureTop + 576
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Left",
                            Type = "int",
                            Value = BottomRight.TextureLeft + 192
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Top",
                            Type = "int",
                            Value = BottomRight.TextureTop + 704
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Left",
                            Type = "int",
                            Value = Bottom.TextureLeft + 64
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Top",
                            Type = "int",
                            Value = Bottom.TextureTop + 704
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Left",
                            Type = "int",
                            Value = BottomLeft.TextureLeft + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Top",
                            Type = "int",
                            Value = BottomLeft.TextureTop + 704
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Left",
                            Type = "int",
                            Value = Left.TextureLeft + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Top",
                            Type = "int",
                            Value = Left.TextureTop + 576
                        }
                        );
                        break;
                    case  FlickerState.Flicker8:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Left",
                            Type = "int",
                            Value = TopLeft.TextureLeft + 256
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Top",
                            Type = "int",
                            Value = TopLeft.TextureTop + 512
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Left",
                            Type = "int",
                            Value = Top.TextureLeft + 320
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Top",
                            Type = "int",
                            Value = Top.TextureTop + 512
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Left",
                            Type = "int",
                            Value = TopRight.TextureLeft + 448
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Top",
                            Type = "int",
                            Value = TopRight.TextureTop + 512
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Left",
                            Type = "int",
                            Value = Right.TextureLeft + 448
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Top",
                            Type = "int",
                            Value = Right.TextureTop + 576
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Left",
                            Type = "int",
                            Value = BottomRight.TextureLeft + 448
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Top",
                            Type = "int",
                            Value = BottomRight.TextureTop + 704
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Left",
                            Type = "int",
                            Value = Bottom.TextureLeft + 320
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Top",
                            Type = "int",
                            Value = Bottom.TextureTop + 704
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Left",
                            Type = "int",
                            Value = BottomLeft.TextureLeft + 256
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Top",
                            Type = "int",
                            Value = BottomLeft.TextureTop + 704
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Left",
                            Type = "int",
                            Value = Left.TextureLeft + 256
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Top",
                            Type = "int",
                            Value = Left.TextureTop + 576
                        }
                        );
                        break;
                    case  FlickerState.Flicker9:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Left",
                            Type = "int",
                            Value = TopLeft.TextureLeft + 512
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Texture Top",
                            Type = "int",
                            Value = TopLeft.TextureTop + 512
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Left",
                            Type = "int",
                            Value = Top.TextureLeft + 576
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Texture Top",
                            Type = "int",
                            Value = Top.TextureTop + 512
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Left",
                            Type = "int",
                            Value = TopRight.TextureLeft + 704
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Texture Top",
                            Type = "int",
                            Value = TopRight.TextureTop + 512
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Left",
                            Type = "int",
                            Value = Right.TextureLeft + 704
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Texture Top",
                            Type = "int",
                            Value = Right.TextureTop + 576
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Left",
                            Type = "int",
                            Value = BottomRight.TextureLeft + 704
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Texture Top",
                            Type = "int",
                            Value = BottomRight.TextureTop + 704
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Left",
                            Type = "int",
                            Value = Bottom.TextureLeft + 576
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Texture Top",
                            Type = "int",
                            Value = Bottom.TextureTop + 704
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Left",
                            Type = "int",
                            Value = BottomLeft.TextureLeft + 512
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Texture Top",
                            Type = "int",
                            Value = BottomLeft.TextureTop + 704
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Left",
                            Type = "int",
                            Value = Left.TextureLeft + 512
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Texture Top",
                            Type = "int",
                            Value = Left.TextureTop + 576
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (ColorState state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  ColorState.Red:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Blue",
                            Type = "int",
                            Value = Middle.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Green",
                            Type = "int",
                            Value = Middle.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Red",
                            Type = "int",
                            Value = Middle.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Blue",
                            Type = "int",
                            Value = TopLeft.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Green",
                            Type = "int",
                            Value = TopLeft.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Red",
                            Type = "int",
                            Value = TopLeft.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Blue",
                            Type = "int",
                            Value = Top.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Green",
                            Type = "int",
                            Value = Top.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Red",
                            Type = "int",
                            Value = Top.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Blue",
                            Type = "int",
                            Value = TopRight.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Green",
                            Type = "int",
                            Value = TopRight.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Red",
                            Type = "int",
                            Value = TopRight.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Blue",
                            Type = "int",
                            Value = Right.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Green",
                            Type = "int",
                            Value = Right.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Red",
                            Type = "int",
                            Value = Right.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Blue",
                            Type = "int",
                            Value = BottomRight.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Green",
                            Type = "int",
                            Value = BottomRight.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Red",
                            Type = "int",
                            Value = BottomRight.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Blue",
                            Type = "int",
                            Value = Bottom.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Green",
                            Type = "int",
                            Value = Bottom.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Red",
                            Type = "int",
                            Value = Bottom.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Blue",
                            Type = "int",
                            Value = BottomLeft.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Green",
                            Type = "int",
                            Value = BottomLeft.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Red",
                            Type = "int",
                            Value = BottomLeft.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Blue",
                            Type = "int",
                            Value = Left.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Green",
                            Type = "int",
                            Value = Left.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Red",
                            Type = "int",
                            Value = Left.Red
                        }
                        );
                        break;
                    case  ColorState.Green:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Blue",
                            Type = "int",
                            Value = Middle.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Green",
                            Type = "int",
                            Value = Middle.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Red",
                            Type = "int",
                            Value = Middle.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Blue",
                            Type = "int",
                            Value = TopLeft.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Green",
                            Type = "int",
                            Value = TopLeft.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Red",
                            Type = "int",
                            Value = TopLeft.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Blue",
                            Type = "int",
                            Value = Top.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Green",
                            Type = "int",
                            Value = Top.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Red",
                            Type = "int",
                            Value = Top.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Blue",
                            Type = "int",
                            Value = TopRight.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Green",
                            Type = "int",
                            Value = TopRight.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Red",
                            Type = "int",
                            Value = TopRight.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Blue",
                            Type = "int",
                            Value = Right.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Green",
                            Type = "int",
                            Value = Right.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Red",
                            Type = "int",
                            Value = Right.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Blue",
                            Type = "int",
                            Value = BottomRight.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Green",
                            Type = "int",
                            Value = BottomRight.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Red",
                            Type = "int",
                            Value = BottomRight.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Blue",
                            Type = "int",
                            Value = Bottom.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Green",
                            Type = "int",
                            Value = Bottom.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Red",
                            Type = "int",
                            Value = Bottom.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Blue",
                            Type = "int",
                            Value = BottomLeft.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Green",
                            Type = "int",
                            Value = BottomLeft.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Red",
                            Type = "int",
                            Value = BottomLeft.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Blue",
                            Type = "int",
                            Value = Left.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Green",
                            Type = "int",
                            Value = Left.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Red",
                            Type = "int",
                            Value = Left.Red
                        }
                        );
                        break;
                    case  ColorState.Black:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Blue",
                            Type = "int",
                            Value = Middle.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Green",
                            Type = "int",
                            Value = Middle.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Red",
                            Type = "int",
                            Value = Middle.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Blue",
                            Type = "int",
                            Value = TopLeft.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Green",
                            Type = "int",
                            Value = TopLeft.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Red",
                            Type = "int",
                            Value = TopLeft.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Blue",
                            Type = "int",
                            Value = Top.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Green",
                            Type = "int",
                            Value = Top.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Red",
                            Type = "int",
                            Value = Top.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Blue",
                            Type = "int",
                            Value = TopRight.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Green",
                            Type = "int",
                            Value = TopRight.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Red",
                            Type = "int",
                            Value = TopRight.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Blue",
                            Type = "int",
                            Value = Right.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Green",
                            Type = "int",
                            Value = Right.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Red",
                            Type = "int",
                            Value = Right.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Blue",
                            Type = "int",
                            Value = BottomRight.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Green",
                            Type = "int",
                            Value = BottomRight.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Red",
                            Type = "int",
                            Value = BottomRight.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Blue",
                            Type = "int",
                            Value = Bottom.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Green",
                            Type = "int",
                            Value = Bottom.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Red",
                            Type = "int",
                            Value = Bottom.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Blue",
                            Type = "int",
                            Value = BottomLeft.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Green",
                            Type = "int",
                            Value = BottomLeft.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Red",
                            Type = "int",
                            Value = BottomLeft.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Blue",
                            Type = "int",
                            Value = Left.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Green",
                            Type = "int",
                            Value = Left.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Red",
                            Type = "int",
                            Value = Left.Red
                        }
                        );
                        break;
                    case  ColorState.Blue:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Blue",
                            Type = "int",
                            Value = Middle.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Green",
                            Type = "int",
                            Value = Middle.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Red",
                            Type = "int",
                            Value = Middle.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Blue",
                            Type = "int",
                            Value = TopLeft.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Green",
                            Type = "int",
                            Value = TopLeft.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Red",
                            Type = "int",
                            Value = TopLeft.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Blue",
                            Type = "int",
                            Value = Top.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Green",
                            Type = "int",
                            Value = Top.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Red",
                            Type = "int",
                            Value = Top.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Blue",
                            Type = "int",
                            Value = TopRight.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Green",
                            Type = "int",
                            Value = TopRight.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Red",
                            Type = "int",
                            Value = TopRight.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Blue",
                            Type = "int",
                            Value = Right.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Green",
                            Type = "int",
                            Value = Right.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Red",
                            Type = "int",
                            Value = Right.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Blue",
                            Type = "int",
                            Value = BottomRight.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Green",
                            Type = "int",
                            Value = BottomRight.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Red",
                            Type = "int",
                            Value = BottomRight.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Blue",
                            Type = "int",
                            Value = Bottom.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Green",
                            Type = "int",
                            Value = Bottom.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Red",
                            Type = "int",
                            Value = Bottom.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Blue",
                            Type = "int",
                            Value = BottomLeft.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Green",
                            Type = "int",
                            Value = BottomLeft.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Red",
                            Type = "int",
                            Value = BottomLeft.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Blue",
                            Type = "int",
                            Value = Left.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Green",
                            Type = "int",
                            Value = Left.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Red",
                            Type = "int",
                            Value = Left.Red
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (ColorState state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  ColorState.Red:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Blue",
                            Type = "int",
                            Value = Middle.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Green",
                            Type = "int",
                            Value = Middle.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Red",
                            Type = "int",
                            Value = Middle.Red + 36
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Blue",
                            Type = "int",
                            Value = TopLeft.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Green",
                            Type = "int",
                            Value = TopLeft.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Red",
                            Type = "int",
                            Value = TopLeft.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Blue",
                            Type = "int",
                            Value = Top.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Green",
                            Type = "int",
                            Value = Top.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Red",
                            Type = "int",
                            Value = Top.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Blue",
                            Type = "int",
                            Value = TopRight.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Green",
                            Type = "int",
                            Value = TopRight.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Red",
                            Type = "int",
                            Value = TopRight.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Blue",
                            Type = "int",
                            Value = Right.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Green",
                            Type = "int",
                            Value = Right.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Red",
                            Type = "int",
                            Value = Right.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Blue",
                            Type = "int",
                            Value = BottomRight.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Green",
                            Type = "int",
                            Value = BottomRight.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Red",
                            Type = "int",
                            Value = BottomRight.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Blue",
                            Type = "int",
                            Value = Bottom.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Green",
                            Type = "int",
                            Value = Bottom.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Red",
                            Type = "int",
                            Value = Bottom.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Blue",
                            Type = "int",
                            Value = BottomLeft.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Green",
                            Type = "int",
                            Value = BottomLeft.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Red",
                            Type = "int",
                            Value = BottomLeft.Red + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Blue",
                            Type = "int",
                            Value = Left.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Green",
                            Type = "int",
                            Value = Left.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Red",
                            Type = "int",
                            Value = Left.Red + 255
                        }
                        );
                        break;
                    case  ColorState.Green:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Blue",
                            Type = "int",
                            Value = Middle.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Green",
                            Type = "int",
                            Value = Middle.Green + 48
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Red",
                            Type = "int",
                            Value = Middle.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Blue",
                            Type = "int",
                            Value = TopLeft.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Green",
                            Type = "int",
                            Value = TopLeft.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Red",
                            Type = "int",
                            Value = TopLeft.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Blue",
                            Type = "int",
                            Value = Top.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Green",
                            Type = "int",
                            Value = Top.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Red",
                            Type = "int",
                            Value = Top.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Blue",
                            Type = "int",
                            Value = TopRight.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Green",
                            Type = "int",
                            Value = TopRight.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Red",
                            Type = "int",
                            Value = TopRight.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Blue",
                            Type = "int",
                            Value = Right.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Green",
                            Type = "int",
                            Value = Right.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Red",
                            Type = "int",
                            Value = Right.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Blue",
                            Type = "int",
                            Value = BottomRight.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Green",
                            Type = "int",
                            Value = BottomRight.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Red",
                            Type = "int",
                            Value = BottomRight.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Blue",
                            Type = "int",
                            Value = Bottom.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Green",
                            Type = "int",
                            Value = Bottom.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Red",
                            Type = "int",
                            Value = Bottom.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Blue",
                            Type = "int",
                            Value = BottomLeft.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Green",
                            Type = "int",
                            Value = BottomLeft.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Red",
                            Type = "int",
                            Value = BottomLeft.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Blue",
                            Type = "int",
                            Value = Left.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Green",
                            Type = "int",
                            Value = Left.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Red",
                            Type = "int",
                            Value = Left.Red + 0
                        }
                        );
                        break;
                    case  ColorState.Black:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Blue",
                            Type = "int",
                            Value = Middle.Blue + 75
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Green",
                            Type = "int",
                            Value = Middle.Green + 75
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Red",
                            Type = "int",
                            Value = Middle.Red + 75
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Blue",
                            Type = "int",
                            Value = TopLeft.Blue + 50
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Green",
                            Type = "int",
                            Value = TopLeft.Green + 50
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Red",
                            Type = "int",
                            Value = TopLeft.Red + 50
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Blue",
                            Type = "int",
                            Value = Top.Blue + 50
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Green",
                            Type = "int",
                            Value = Top.Green + 50
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Red",
                            Type = "int",
                            Value = Top.Red + 50
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Blue",
                            Type = "int",
                            Value = TopRight.Blue + 50
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Green",
                            Type = "int",
                            Value = TopRight.Green + 50
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Red",
                            Type = "int",
                            Value = TopRight.Red + 50
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Blue",
                            Type = "int",
                            Value = Right.Blue + 50
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Green",
                            Type = "int",
                            Value = Right.Green + 50
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Red",
                            Type = "int",
                            Value = Right.Red + 50
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Blue",
                            Type = "int",
                            Value = BottomRight.Blue + 50
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Green",
                            Type = "int",
                            Value = BottomRight.Green + 50
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Red",
                            Type = "int",
                            Value = BottomRight.Red + 50
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Blue",
                            Type = "int",
                            Value = Bottom.Blue + 50
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Green",
                            Type = "int",
                            Value = Bottom.Green + 50
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Red",
                            Type = "int",
                            Value = Bottom.Red + 50
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Blue",
                            Type = "int",
                            Value = BottomLeft.Blue + 50
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Green",
                            Type = "int",
                            Value = BottomLeft.Green + 50
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Red",
                            Type = "int",
                            Value = BottomLeft.Red + 50
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Blue",
                            Type = "int",
                            Value = Left.Blue + 50
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Green",
                            Type = "int",
                            Value = Left.Green + 50
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Red",
                            Type = "int",
                            Value = Left.Red + 50
                        }
                        );
                        break;
                    case  ColorState.Blue:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Blue",
                            Type = "int",
                            Value = Middle.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Green",
                            Type = "int",
                            Value = Middle.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Middle.Red",
                            Type = "int",
                            Value = Middle.Red + 224
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Blue",
                            Type = "int",
                            Value = TopLeft.Blue + 235
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Green",
                            Type = "int",
                            Value = TopLeft.Green + 206
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopLeft.Red",
                            Type = "int",
                            Value = TopLeft.Red + 135
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Blue",
                            Type = "int",
                            Value = Top.Blue + 250
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Green",
                            Type = "int",
                            Value = Top.Green + 206
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Top.Red",
                            Type = "int",
                            Value = Top.Red + 135
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Blue",
                            Type = "int",
                            Value = TopRight.Blue + 250
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Green",
                            Type = "int",
                            Value = TopRight.Green + 206
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TopRight.Red",
                            Type = "int",
                            Value = TopRight.Red + 135
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Blue",
                            Type = "int",
                            Value = Right.Blue + 250
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Green",
                            Type = "int",
                            Value = Right.Green + 206
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Right.Red",
                            Type = "int",
                            Value = Right.Red + 135
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Blue",
                            Type = "int",
                            Value = BottomRight.Blue + 250
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Green",
                            Type = "int",
                            Value = BottomRight.Green + 206
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomRight.Red",
                            Type = "int",
                            Value = BottomRight.Red + 135
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Blue",
                            Type = "int",
                            Value = Bottom.Blue + 250
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Green",
                            Type = "int",
                            Value = Bottom.Green + 206
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Bottom.Red",
                            Type = "int",
                            Value = Bottom.Red + 135
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Blue",
                            Type = "int",
                            Value = BottomLeft.Blue + 250
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Green",
                            Type = "int",
                            Value = BottomLeft.Green + 206
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BottomLeft.Red",
                            Type = "int",
                            Value = BottomLeft.Red + 135
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Blue",
                            Type = "int",
                            Value = Left.Blue + 250
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Green",
                            Type = "int",
                            Value = Left.Green + 206
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Left.Red",
                            Type = "int",
                            Value = Left.Red + 135
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
                    else if (category.Name == "FlickerState")
                    {
                        if(state.Name == "Flicker1") this.mCurrentFlickerStateState = FlickerState.Flicker1;
                        if(state.Name == "Flicker2") this.mCurrentFlickerStateState = FlickerState.Flicker2;
                        if(state.Name == "Flicker3") this.mCurrentFlickerStateState = FlickerState.Flicker3;
                        if(state.Name == "Flicker4") this.mCurrentFlickerStateState = FlickerState.Flicker4;
                        if(state.Name == "Flicker5") this.mCurrentFlickerStateState = FlickerState.Flicker5;
                        if(state.Name == "Flicker6") this.mCurrentFlickerStateState = FlickerState.Flicker6;
                        if(state.Name == "Flicker7") this.mCurrentFlickerStateState = FlickerState.Flicker7;
                        if(state.Name == "Flicker8") this.mCurrentFlickerStateState = FlickerState.Flicker8;
                        if(state.Name == "Flicker9") this.mCurrentFlickerStateState = FlickerState.Flicker9;
                    }
                    else if (category.Name == "ColorState")
                    {
                        if(state.Name == "Red") this.mCurrentColorStateState = ColorState.Red;
                        if(state.Name == "Green") this.mCurrentColorStateState = ColorState.Green;
                        if(state.Name == "Black") this.mCurrentColorStateState = ColorState.Black;
                        if(state.Name == "Blue") this.mCurrentColorStateState = ColorState.Blue;
                    }
                }
                base.ApplyState(state);
            }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime Middle { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime TopLeft { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime Top { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime TopRight { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime Right { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime BottomRight { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime Bottom { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime BottomLeft { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime Left { get; set; }
            public Microsoft.Xna.Framework.Graphics.Texture2D MiddleSourceFile
            {
                get
                {
                    return Middle.SourceFile;
                }
                set
                {
                    if (Middle.SourceFile != value)
                    {
                        Middle.SourceFile = value;
                        MiddleSourceFileChanged?.Invoke(this, null);
                    }
                }
            }
            public int MiddleTextureHeight
            {
                get
                {
                    return Middle.TextureHeight;
                }
                set
                {
                    if (Middle.TextureHeight != value)
                    {
                        Middle.TextureHeight = value;
                        MiddleTextureHeightChanged?.Invoke(this, null);
                    }
                }
            }
            public int MiddleTextureLeft
            {
                get
                {
                    return Middle.TextureLeft;
                }
                set
                {
                    if (Middle.TextureLeft != value)
                    {
                        Middle.TextureLeft = value;
                        MiddleTextureLeftChanged?.Invoke(this, null);
                    }
                }
            }
            public int MiddleTextureTop
            {
                get
                {
                    return Middle.TextureTop;
                }
                set
                {
                    if (Middle.TextureTop != value)
                    {
                        Middle.TextureTop = value;
                        MiddleTextureTopChanged?.Invoke(this, null);
                    }
                }
            }
            public int MiddleTextureWidth
            {
                get
                {
                    return Middle.TextureWidth;
                }
                set
                {
                    if (Middle.TextureWidth != value)
                    {
                        Middle.TextureWidth = value;
                        MiddleTextureWidthChanged?.Invoke(this, null);
                    }
                }
            }
            public event System.EventHandler MiddleSourceFileChanged;
            public event System.EventHandler MiddleTextureHeightChanged;
            public event System.EventHandler MiddleTextureLeftChanged;
            public event System.EventHandler MiddleTextureTopChanged;
            public event System.EventHandler MiddleTextureWidthChanged;
            public ChatOptionFrameRuntime (bool fullInstantiation = true) 
            	: base(false)
            {
                this.HasEvents = false;
                this.ExposeChildrenEvents = false;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "Frames/ChatOptionFrame");
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
                Middle = this.GetGraphicalUiElementByName("Middle") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                TopLeft = this.GetGraphicalUiElementByName("TopLeft") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                Top = this.GetGraphicalUiElementByName("Top") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                TopRight = this.GetGraphicalUiElementByName("TopRight") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                Right = this.GetGraphicalUiElementByName("Right") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                BottomRight = this.GetGraphicalUiElementByName("BottomRight") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                Bottom = this.GetGraphicalUiElementByName("Bottom") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                BottomLeft = this.GetGraphicalUiElementByName("BottomLeft") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                Left = this.GetGraphicalUiElementByName("Left") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
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
