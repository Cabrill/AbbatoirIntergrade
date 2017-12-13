    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes
    {
        public partial class BuildMenuRuntime : AbbatoirIntergrade.GumRuntimes.ContainerRuntime
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            public enum Capacity
            {
                Four,
                FourLeft,
                FourRight,
                Seven,
                SevenLeft,
                SevenRight
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            Capacity mCurrentCapacityState;
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
                            Height = 50f;
                            HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            Width = 50f;
                            WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            X = -1280f;
                            XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            Y = 720f;
                            YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                            YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddleInverted;
                            FourButtonFrameInstance.Height = 53.646f;
                            FourButtonFrameInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            FourButtonFrameInstance.Visible = true;
                            FourButtonFrameInstance.Width = 23.4f;
                            FourButtonFrameInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            FourButtonFrameInstance.X = 50f;
                            FourButtonFrameInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            FourButtonFrameInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            FourButtonFrameInstance.Y = 100f;
                            FourButtonFrameInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                            FourButtonFrameInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            SevenButtonFrameInstance.Height = 88f;
                            SevenButtonFrameInstance.Visible = false;
                            SevenButtonFrameInstance.Width = 19.15f;
                            SevenButtonFrameInstance.X = 47.50298f;
                            SevenButtonFrameInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            SevenButtonFrameInstance.Y = 100.8836f;
                            SevenButtonFrameInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                            BuildButtonInstance0.X = 43.29829f;
                            BuildButtonInstance0.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            BuildButtonInstance0.Y = 67.83752f;
                            BuildButtonInstance0.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            BuildButtonInstance1.X = 33.23347f;
                            BuildButtonInstance1.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            BuildButtonInstance1.Y = 51.25159f;
                            BuildButtonInstance1.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            BuildButtonInstance2.X = 51.49597f;
                            BuildButtonInstance2.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            BuildButtonInstance2.Y = 51.31417f;
                            BuildButtonInstance2.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            BuildButtonInstance3.X = 42.26307f;
                            BuildButtonInstance3.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            BuildButtonInstance3.Y = 34.15827f;
                            BuildButtonInstance3.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            BuildButtonInstance4.Visible = false;
                            BuildButtonInstance4.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            BuildButtonInstance4.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            BuildButtonInstance5.Visible = false;
                            BuildButtonInstance5.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            BuildButtonInstance5.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            BuildButtonInstance6.Visible = false;
                            BuildButtonInstance6.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            BuildButtonInstance6.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            break;
                    }
                }
            }
            public Capacity CurrentCapacityState
            {
                get
                {
                    return mCurrentCapacityState;
                }
                set
                {
                    mCurrentCapacityState = value;
                    switch(mCurrentCapacityState)
                    {
                        case  Capacity.Four:
                            XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                            FourButtonFrameInstance.CurrentRotatedState = AbbatoirIntergrade.GumRuntimes.FourButtonFrameRuntime.Rotated.None;
                            FourButtonFrameInstance.Visible = true;
                            FourButtonFrameInstance.X = 50f;
                            FourButtonFrameInstance.Y = 100f;
                            SevenButtonFrameInstance.Visible = false;
                            SevenButtonFrameInstance.X = 47.50298f;
                            SevenButtonFrameInstance.Y = 100.8836f;
                            BuildButtonInstance0.X = 43.19118f;
                            BuildButtonInstance0.Y = 67.92753f;
                            BuildButtonInstance1.X = 34.37128f;
                            BuildButtonInstance1.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            BuildButtonInstance1.Y = 51.32274f;
                            BuildButtonInstance2.X = 52.03481f;
                            BuildButtonInstance2.Y = 51.35582f;
                            BuildButtonInstance3.X = 43.17259f;
                            BuildButtonInstance3.Y = 34.02776f;
                            BuildButtonInstance4.Visible = false;
                            BuildButtonInstance4.X = 0f;
                            BuildButtonInstance4.Y = 0f;
                            BuildButtonInstance5.Height = 24.47f;
                            BuildButtonInstance5.Visible = false;
                            BuildButtonInstance5.Width = 13.647f;
                            BuildButtonInstance5.X = 0f;
                            BuildButtonInstance5.Y = 0f;
                            BuildButtonInstance6.Height = 24.47f;
                            BuildButtonInstance6.Visible = false;
                            BuildButtonInstance6.Width = 13.647f;
                            BuildButtonInstance6.X = 0f;
                            BuildButtonInstance6.Y = 0f;
                            break;
                        case  Capacity.FourLeft:
                            XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            FourButtonFrameInstance.CurrentRotatedState = AbbatoirIntergrade.GumRuntimes.FourButtonFrameRuntime.Rotated.Left;
                            FourButtonFrameInstance.Visible = true;
                            FourButtonFrameInstance.X = 81.64063f;
                            FourButtonFrameInstance.Y = 83.00002f;
                            SevenButtonFrameInstance.Visible = false;
                            SevenButtonFrameInstance.X = 47.50298f;
                            SevenButtonFrameInstance.Y = 100.8836f;
                            BuildButtonInstance0.X = 82.09743f;
                            BuildButtonInstance0.Y = 37.92752f;
                            BuildButtonInstance1.X = 72.73f;
                            BuildButtonInstance1.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            BuildButtonInstance1.Y = 53.82274f;
                            BuildButtonInstance2.X = 72.73793f;
                            BuildButtonInstance2.Y = 21.95767f;
                            BuildButtonInstance3.X = 63.01634f;
                            BuildButtonInstance3.Y = 37.91665f;
                            BuildButtonInstance4.Visible = false;
                            BuildButtonInstance4.X = 0f;
                            BuildButtonInstance4.Y = 0f;
                            BuildButtonInstance5.Height = 24.47f;
                            BuildButtonInstance5.Visible = false;
                            BuildButtonInstance5.Width = 13.647f;
                            BuildButtonInstance5.X = 0f;
                            BuildButtonInstance5.Y = 0f;
                            BuildButtonInstance6.Height = 24.47f;
                            BuildButtonInstance6.Visible = false;
                            BuildButtonInstance6.Width = 13.647f;
                            BuildButtonInstance6.X = 0f;
                            BuildButtonInstance6.Y = 0f;
                            break;
                        case  Capacity.FourRight:
                            XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            FourButtonFrameInstance.CurrentRotatedState = AbbatoirIntergrade.GumRuntimes.FourButtonFrameRuntime.Rotated.Right;
                            FourButtonFrameInstance.Visible = true;
                            FourButtonFrameInstance.X = 11.69791f;
                            FourButtonFrameInstance.Y = 82.79628f;
                            SevenButtonFrameInstance.Visible = false;
                            SevenButtonFrameInstance.X = 47.50298f;
                            SevenButtonFrameInstance.Y = 100.8836f;
                            BuildButtonInstance0.X = 4.363056f;
                            BuildButtonInstance0.Y = 37.92752f;
                            BuildButtonInstance1.X = 13.73f;
                            BuildButtonInstance1.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            BuildButtonInstance1.Y = 53.56481f;
                            BuildButtonInstance2.X = 13.73f;
                            BuildButtonInstance2.Y = 22.05026f;
                            BuildButtonInstance3.X = 23.38464f;
                            BuildButtonInstance3.Y = 37.7976f;
                            BuildButtonInstance4.Visible = false;
                            BuildButtonInstance4.X = 0f;
                            BuildButtonInstance4.Y = 0f;
                            BuildButtonInstance5.Height = 24.47f;
                            BuildButtonInstance5.Visible = false;
                            BuildButtonInstance5.Width = 13.647f;
                            BuildButtonInstance5.X = 0f;
                            BuildButtonInstance5.Y = 0f;
                            BuildButtonInstance6.Height = 24.47f;
                            BuildButtonInstance6.Visible = false;
                            BuildButtonInstance6.Width = 13.647f;
                            BuildButtonInstance6.X = 0f;
                            BuildButtonInstance6.Y = 0f;
                            break;
                        case  Capacity.Seven:
                            XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                            FourButtonFrameInstance.Visible = false;
                            FourButtonFrameInstance.X = 50f;
                            FourButtonFrameInstance.Y = 100f;
                            SevenButtonFrameInstance.CurrentRotatedState = AbbatoirIntergrade.GumRuntimes.SevenButtonFrameRuntime.Rotated.None;
                            SevenButtonFrameInstance.Visible = true;
                            SevenButtonFrameInstance.X = 47.50298f;
                            SevenButtonFrameInstance.Y = 100.8836f;
                            BuildButtonInstance0.X = 43.14814f;
                            BuildButtonInstance0.Y = 68.01085f;
                            BuildButtonInstance1.X = 34.26563f;
                            BuildButtonInstance1.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            BuildButtonInstance1.Y = 51.43519f;
                            BuildButtonInstance2.X = 52.06459f;
                            BuildButtonInstance2.Y = 51.57408f;
                            BuildButtonInstance3.X = 43.15125f;
                            BuildButtonInstance3.Y = 35.08086f;
                            BuildButtonInstance4.Visible = true;
                            BuildButtonInstance4.X = 34.29688f;
                            BuildButtonInstance4.Y = 18.35648f;
                            BuildButtonInstance5.Height = 24.47f;
                            BuildButtonInstance5.Visible = true;
                            BuildButtonInstance5.Width = 13.647f;
                            BuildButtonInstance5.X = 52.00523f;
                            BuildButtonInstance5.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            BuildButtonInstance5.Y = 18.31018f;
                            BuildButtonInstance5.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            BuildButtonInstance6.Height = 24.47f;
                            BuildButtonInstance6.Visible = true;
                            BuildButtonInstance6.Width = 13.647f;
                            BuildButtonInstance6.X = 43.15125f;
                            BuildButtonInstance6.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            BuildButtonInstance6.Y = 1.134257f;
                            break;
                        case  Capacity.SevenLeft:
                            XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            FourButtonFrameInstance.Visible = false;
                            FourButtonFrameInstance.X = 56.6875f;
                            FourButtonFrameInstance.Y = 99.77779f;
                            SevenButtonFrameInstance.CurrentRotatedState = AbbatoirIntergrade.GumRuntimes.SevenButtonFrameRuntime.Rotated.Left;
                            SevenButtonFrameInstance.Visible = true;
                            SevenButtonFrameInstance.X = 60.5945f;
                            SevenButtonFrameInstance.Y = 116.85f;
                            BuildButtonInstance0.X = 82.00231f;
                            BuildButtonInstance0.Y = 37.87195f;
                            BuildButtonInstance1.X = 72.76563f;
                            BuildButtonInstance1.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            BuildButtonInstance1.Y = 53.65741f;
                            BuildButtonInstance2.X = 72.76772f;
                            BuildButtonInstance2.Y = 21.99075f;
                            BuildButtonInstance3.X = 63.51583f;
                            BuildButtonInstance3.Y = 37.90495f;
                            BuildButtonInstance4.Visible = true;
                            BuildButtonInstance4.X = 54.14063f;
                            BuildButtonInstance4.Y = 53.63426f;
                            BuildButtonInstance5.Height = 24.47f;
                            BuildButtonInstance5.Visible = true;
                            BuildButtonInstance5.Width = 13.647f;
                            BuildButtonInstance5.X = 54.1146f;
                            BuildButtonInstance5.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            BuildButtonInstance5.Y = 22.02546f;
                            BuildButtonInstance5.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            BuildButtonInstance6.Height = 24.47f;
                            BuildButtonInstance6.Visible = true;
                            BuildButtonInstance6.Width = 13.647f;
                            BuildButtonInstance6.X = 44.38015f;
                            BuildButtonInstance6.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            BuildButtonInstance6.Y = 37.88074f;
                            break;
                        case  Capacity.SevenRight:
                            XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            FourButtonFrameInstance.Visible = false;
                            FourButtonFrameInstance.X = 50f;
                            FourButtonFrameInstance.Y = 100f;
                            SevenButtonFrameInstance.CurrentRotatedState = AbbatoirIntergrade.GumRuntimes.SevenButtonFrameRuntime.Rotated.Right;
                            SevenButtonFrameInstance.Visible = true;
                            SevenButtonFrameInstance.X = 9.088921f;
                            SevenButtonFrameInstance.Y = 116.5294f;
                            BuildButtonInstance0.X = 4.293975f;
                            BuildButtonInstance0.Y = 37.88f;
                            BuildButtonInstance1.X = 13.57813f;
                            BuildButtonInstance1.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            BuildButtonInstance1.Y = 53.87964f;
                            BuildButtonInstance2.X = 13.61667f;
                            BuildButtonInstance2.Y = 21.90742f;
                            BuildButtonInstance3.X = 22.90776f;
                            BuildButtonInstance3.Y = 37.90197f;
                            BuildButtonInstance4.Visible = true;
                            BuildButtonInstance4.X = 32.28125f;
                            BuildButtonInstance4.Y = 53.74537f;
                            BuildButtonInstance5.Height = 24.47f;
                            BuildButtonInstance5.Visible = true;
                            BuildButtonInstance5.Width = 13.647f;
                            BuildButtonInstance5.X = 32.29986f;
                            BuildButtonInstance5.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            BuildButtonInstance5.Y = 22.04827f;
                            BuildButtonInstance5.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            BuildButtonInstance6.Height = 24.47f;
                            BuildButtonInstance6.Visible = true;
                            BuildButtonInstance6.Width = 13.647f;
                            BuildButtonInstance6.X = 41.88341f;
                            BuildButtonInstance6.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            BuildButtonInstance6.Y = 37.8168f;
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
                bool setBuildButtonInstance0XFirstValue = false;
                bool setBuildButtonInstance0XSecondValue = false;
                float BuildButtonInstance0XFirstValue= 0;
                float BuildButtonInstance0XSecondValue= 0;
                bool setBuildButtonInstance0YFirstValue = false;
                bool setBuildButtonInstance0YSecondValue = false;
                float BuildButtonInstance0YFirstValue= 0;
                float BuildButtonInstance0YSecondValue= 0;
                bool setBuildButtonInstance1XFirstValue = false;
                bool setBuildButtonInstance1XSecondValue = false;
                float BuildButtonInstance1XFirstValue= 0;
                float BuildButtonInstance1XSecondValue= 0;
                bool setBuildButtonInstance1YFirstValue = false;
                bool setBuildButtonInstance1YSecondValue = false;
                float BuildButtonInstance1YFirstValue= 0;
                float BuildButtonInstance1YSecondValue= 0;
                bool setBuildButtonInstance2XFirstValue = false;
                bool setBuildButtonInstance2XSecondValue = false;
                float BuildButtonInstance2XFirstValue= 0;
                float BuildButtonInstance2XSecondValue= 0;
                bool setBuildButtonInstance2YFirstValue = false;
                bool setBuildButtonInstance2YSecondValue = false;
                float BuildButtonInstance2YFirstValue= 0;
                float BuildButtonInstance2YSecondValue= 0;
                bool setBuildButtonInstance3XFirstValue = false;
                bool setBuildButtonInstance3XSecondValue = false;
                float BuildButtonInstance3XFirstValue= 0;
                float BuildButtonInstance3XSecondValue= 0;
                bool setBuildButtonInstance3YFirstValue = false;
                bool setBuildButtonInstance3YSecondValue = false;
                float BuildButtonInstance3YFirstValue= 0;
                float BuildButtonInstance3YSecondValue= 0;
                bool setFourButtonFrameInstanceHeightFirstValue = false;
                bool setFourButtonFrameInstanceHeightSecondValue = false;
                float FourButtonFrameInstanceHeightFirstValue= 0;
                float FourButtonFrameInstanceHeightSecondValue= 0;
                bool setFourButtonFrameInstanceWidthFirstValue = false;
                bool setFourButtonFrameInstanceWidthSecondValue = false;
                float FourButtonFrameInstanceWidthFirstValue= 0;
                float FourButtonFrameInstanceWidthSecondValue= 0;
                bool setFourButtonFrameInstanceXFirstValue = false;
                bool setFourButtonFrameInstanceXSecondValue = false;
                float FourButtonFrameInstanceXFirstValue= 0;
                float FourButtonFrameInstanceXSecondValue= 0;
                bool setFourButtonFrameInstanceYFirstValue = false;
                bool setFourButtonFrameInstanceYSecondValue = false;
                float FourButtonFrameInstanceYFirstValue= 0;
                float FourButtonFrameInstanceYSecondValue= 0;
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setSevenButtonFrameInstanceHeightFirstValue = false;
                bool setSevenButtonFrameInstanceHeightSecondValue = false;
                float SevenButtonFrameInstanceHeightFirstValue= 0;
                float SevenButtonFrameInstanceHeightSecondValue= 0;
                bool setSevenButtonFrameInstanceWidthFirstValue = false;
                bool setSevenButtonFrameInstanceWidthSecondValue = false;
                float SevenButtonFrameInstanceWidthFirstValue= 0;
                float SevenButtonFrameInstanceWidthSecondValue= 0;
                bool setSevenButtonFrameInstanceXFirstValue = false;
                bool setSevenButtonFrameInstanceXSecondValue = false;
                float SevenButtonFrameInstanceXFirstValue= 0;
                float SevenButtonFrameInstanceXSecondValue= 0;
                bool setSevenButtonFrameInstanceYFirstValue = false;
                bool setSevenButtonFrameInstanceYSecondValue = false;
                float SevenButtonFrameInstanceYFirstValue= 0;
                float SevenButtonFrameInstanceYSecondValue= 0;
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
                        setBuildButtonInstance0XFirstValue = true;
                        BuildButtonInstance0XFirstValue = 43.29829f;
                        if (interpolationValue < 1)
                        {
                            this.BuildButtonInstance0.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setBuildButtonInstance0YFirstValue = true;
                        BuildButtonInstance0YFirstValue = 67.83752f;
                        if (interpolationValue < 1)
                        {
                            this.BuildButtonInstance0.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setBuildButtonInstance1XFirstValue = true;
                        BuildButtonInstance1XFirstValue = 33.23347f;
                        if (interpolationValue < 1)
                        {
                            this.BuildButtonInstance1.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setBuildButtonInstance1YFirstValue = true;
                        BuildButtonInstance1YFirstValue = 51.25159f;
                        if (interpolationValue < 1)
                        {
                            this.BuildButtonInstance1.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setBuildButtonInstance2XFirstValue = true;
                        BuildButtonInstance2XFirstValue = 51.49597f;
                        if (interpolationValue < 1)
                        {
                            this.BuildButtonInstance2.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setBuildButtonInstance2YFirstValue = true;
                        BuildButtonInstance2YFirstValue = 51.31417f;
                        if (interpolationValue < 1)
                        {
                            this.BuildButtonInstance2.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setBuildButtonInstance3XFirstValue = true;
                        BuildButtonInstance3XFirstValue = 42.26307f;
                        if (interpolationValue < 1)
                        {
                            this.BuildButtonInstance3.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setBuildButtonInstance3YFirstValue = true;
                        BuildButtonInstance3YFirstValue = 34.15827f;
                        if (interpolationValue < 1)
                        {
                            this.BuildButtonInstance3.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.BuildButtonInstance4.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.BuildButtonInstance4.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.BuildButtonInstance4.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.BuildButtonInstance5.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.BuildButtonInstance5.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.BuildButtonInstance5.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.BuildButtonInstance6.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.BuildButtonInstance6.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.BuildButtonInstance6.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setFourButtonFrameInstanceHeightFirstValue = true;
                        FourButtonFrameInstanceHeightFirstValue = 53.646f;
                        if (interpolationValue < 1)
                        {
                            this.FourButtonFrameInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.FourButtonFrameInstance.Visible = true;
                        }
                        setFourButtonFrameInstanceWidthFirstValue = true;
                        FourButtonFrameInstanceWidthFirstValue = 23.4f;
                        if (interpolationValue < 1)
                        {
                            this.FourButtonFrameInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setFourButtonFrameInstanceXFirstValue = true;
                        FourButtonFrameInstanceXFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.FourButtonFrameInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.FourButtonFrameInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setFourButtonFrameInstanceYFirstValue = true;
                        FourButtonFrameInstanceYFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.FourButtonFrameInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue < 1)
                        {
                            this.FourButtonFrameInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setHeightFirstValue = true;
                        HeightFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setSevenButtonFrameInstanceHeightFirstValue = true;
                        SevenButtonFrameInstanceHeightFirstValue = 88f;
                        if (interpolationValue < 1)
                        {
                            this.SevenButtonFrameInstance.Visible = false;
                        }
                        setSevenButtonFrameInstanceWidthFirstValue = true;
                        SevenButtonFrameInstanceWidthFirstValue = 19.15f;
                        setSevenButtonFrameInstanceXFirstValue = true;
                        SevenButtonFrameInstanceXFirstValue = 47.50298f;
                        if (interpolationValue < 1)
                        {
                            this.SevenButtonFrameInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setSevenButtonFrameInstanceYFirstValue = true;
                        SevenButtonFrameInstanceYFirstValue = 100.8836f;
                        if (interpolationValue < 1)
                        {
                            this.SevenButtonFrameInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        setWidthFirstValue = true;
                        WidthFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setXFirstValue = true;
                        XFirstValue = -1280f;
                        if (interpolationValue < 1)
                        {
                            this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setYFirstValue = true;
                        YFirstValue = 720f;
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
                        setBuildButtonInstance0XSecondValue = true;
                        BuildButtonInstance0XSecondValue = 43.29829f;
                        if (interpolationValue >= 1)
                        {
                            this.BuildButtonInstance0.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setBuildButtonInstance0YSecondValue = true;
                        BuildButtonInstance0YSecondValue = 67.83752f;
                        if (interpolationValue >= 1)
                        {
                            this.BuildButtonInstance0.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setBuildButtonInstance1XSecondValue = true;
                        BuildButtonInstance1XSecondValue = 33.23347f;
                        if (interpolationValue >= 1)
                        {
                            this.BuildButtonInstance1.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setBuildButtonInstance1YSecondValue = true;
                        BuildButtonInstance1YSecondValue = 51.25159f;
                        if (interpolationValue >= 1)
                        {
                            this.BuildButtonInstance1.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setBuildButtonInstance2XSecondValue = true;
                        BuildButtonInstance2XSecondValue = 51.49597f;
                        if (interpolationValue >= 1)
                        {
                            this.BuildButtonInstance2.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setBuildButtonInstance2YSecondValue = true;
                        BuildButtonInstance2YSecondValue = 51.31417f;
                        if (interpolationValue >= 1)
                        {
                            this.BuildButtonInstance2.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setBuildButtonInstance3XSecondValue = true;
                        BuildButtonInstance3XSecondValue = 42.26307f;
                        if (interpolationValue >= 1)
                        {
                            this.BuildButtonInstance3.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setBuildButtonInstance3YSecondValue = true;
                        BuildButtonInstance3YSecondValue = 34.15827f;
                        if (interpolationValue >= 1)
                        {
                            this.BuildButtonInstance3.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.BuildButtonInstance4.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.BuildButtonInstance4.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.BuildButtonInstance4.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.BuildButtonInstance5.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.BuildButtonInstance5.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.BuildButtonInstance5.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.BuildButtonInstance6.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.BuildButtonInstance6.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.BuildButtonInstance6.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setFourButtonFrameInstanceHeightSecondValue = true;
                        FourButtonFrameInstanceHeightSecondValue = 53.646f;
                        if (interpolationValue >= 1)
                        {
                            this.FourButtonFrameInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.FourButtonFrameInstance.Visible = true;
                        }
                        setFourButtonFrameInstanceWidthSecondValue = true;
                        FourButtonFrameInstanceWidthSecondValue = 23.4f;
                        if (interpolationValue >= 1)
                        {
                            this.FourButtonFrameInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setFourButtonFrameInstanceXSecondValue = true;
                        FourButtonFrameInstanceXSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.FourButtonFrameInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.FourButtonFrameInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setFourButtonFrameInstanceYSecondValue = true;
                        FourButtonFrameInstanceYSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.FourButtonFrameInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.FourButtonFrameInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setHeightSecondValue = true;
                        HeightSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setSevenButtonFrameInstanceHeightSecondValue = true;
                        SevenButtonFrameInstanceHeightSecondValue = 88f;
                        if (interpolationValue >= 1)
                        {
                            this.SevenButtonFrameInstance.Visible = false;
                        }
                        setSevenButtonFrameInstanceWidthSecondValue = true;
                        SevenButtonFrameInstanceWidthSecondValue = 19.15f;
                        setSevenButtonFrameInstanceXSecondValue = true;
                        SevenButtonFrameInstanceXSecondValue = 47.50298f;
                        if (interpolationValue >= 1)
                        {
                            this.SevenButtonFrameInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setSevenButtonFrameInstanceYSecondValue = true;
                        SevenButtonFrameInstanceYSecondValue = 100.8836f;
                        if (interpolationValue >= 1)
                        {
                            this.SevenButtonFrameInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        setWidthSecondValue = true;
                        WidthSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setXSecondValue = true;
                        XSecondValue = -1280f;
                        if (interpolationValue >= 1)
                        {
                            this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setYSecondValue = true;
                        YSecondValue = 720f;
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
                if (setBuildButtonInstance0XFirstValue && setBuildButtonInstance0XSecondValue)
                {
                    BuildButtonInstance0.X = BuildButtonInstance0XFirstValue * (1 - interpolationValue) + BuildButtonInstance0XSecondValue * interpolationValue;
                }
                if (setBuildButtonInstance0YFirstValue && setBuildButtonInstance0YSecondValue)
                {
                    BuildButtonInstance0.Y = BuildButtonInstance0YFirstValue * (1 - interpolationValue) + BuildButtonInstance0YSecondValue * interpolationValue;
                }
                if (setBuildButtonInstance1XFirstValue && setBuildButtonInstance1XSecondValue)
                {
                    BuildButtonInstance1.X = BuildButtonInstance1XFirstValue * (1 - interpolationValue) + BuildButtonInstance1XSecondValue * interpolationValue;
                }
                if (setBuildButtonInstance1YFirstValue && setBuildButtonInstance1YSecondValue)
                {
                    BuildButtonInstance1.Y = BuildButtonInstance1YFirstValue * (1 - interpolationValue) + BuildButtonInstance1YSecondValue * interpolationValue;
                }
                if (setBuildButtonInstance2XFirstValue && setBuildButtonInstance2XSecondValue)
                {
                    BuildButtonInstance2.X = BuildButtonInstance2XFirstValue * (1 - interpolationValue) + BuildButtonInstance2XSecondValue * interpolationValue;
                }
                if (setBuildButtonInstance2YFirstValue && setBuildButtonInstance2YSecondValue)
                {
                    BuildButtonInstance2.Y = BuildButtonInstance2YFirstValue * (1 - interpolationValue) + BuildButtonInstance2YSecondValue * interpolationValue;
                }
                if (setBuildButtonInstance3XFirstValue && setBuildButtonInstance3XSecondValue)
                {
                    BuildButtonInstance3.X = BuildButtonInstance3XFirstValue * (1 - interpolationValue) + BuildButtonInstance3XSecondValue * interpolationValue;
                }
                if (setBuildButtonInstance3YFirstValue && setBuildButtonInstance3YSecondValue)
                {
                    BuildButtonInstance3.Y = BuildButtonInstance3YFirstValue * (1 - interpolationValue) + BuildButtonInstance3YSecondValue * interpolationValue;
                }
                if (setFourButtonFrameInstanceHeightFirstValue && setFourButtonFrameInstanceHeightSecondValue)
                {
                    FourButtonFrameInstance.Height = FourButtonFrameInstanceHeightFirstValue * (1 - interpolationValue) + FourButtonFrameInstanceHeightSecondValue * interpolationValue;
                }
                if (setFourButtonFrameInstanceWidthFirstValue && setFourButtonFrameInstanceWidthSecondValue)
                {
                    FourButtonFrameInstance.Width = FourButtonFrameInstanceWidthFirstValue * (1 - interpolationValue) + FourButtonFrameInstanceWidthSecondValue * interpolationValue;
                }
                if (setFourButtonFrameInstanceXFirstValue && setFourButtonFrameInstanceXSecondValue)
                {
                    FourButtonFrameInstance.X = FourButtonFrameInstanceXFirstValue * (1 - interpolationValue) + FourButtonFrameInstanceXSecondValue * interpolationValue;
                }
                if (setFourButtonFrameInstanceYFirstValue && setFourButtonFrameInstanceYSecondValue)
                {
                    FourButtonFrameInstance.Y = FourButtonFrameInstanceYFirstValue * (1 - interpolationValue) + FourButtonFrameInstanceYSecondValue * interpolationValue;
                }
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
                }
                if (setSevenButtonFrameInstanceHeightFirstValue && setSevenButtonFrameInstanceHeightSecondValue)
                {
                    SevenButtonFrameInstance.Height = SevenButtonFrameInstanceHeightFirstValue * (1 - interpolationValue) + SevenButtonFrameInstanceHeightSecondValue * interpolationValue;
                }
                if (setSevenButtonFrameInstanceWidthFirstValue && setSevenButtonFrameInstanceWidthSecondValue)
                {
                    SevenButtonFrameInstance.Width = SevenButtonFrameInstanceWidthFirstValue * (1 - interpolationValue) + SevenButtonFrameInstanceWidthSecondValue * interpolationValue;
                }
                if (setSevenButtonFrameInstanceXFirstValue && setSevenButtonFrameInstanceXSecondValue)
                {
                    SevenButtonFrameInstance.X = SevenButtonFrameInstanceXFirstValue * (1 - interpolationValue) + SevenButtonFrameInstanceXSecondValue * interpolationValue;
                }
                if (setSevenButtonFrameInstanceYFirstValue && setSevenButtonFrameInstanceYSecondValue)
                {
                    SevenButtonFrameInstance.Y = SevenButtonFrameInstanceYFirstValue * (1 - interpolationValue) + SevenButtonFrameInstanceYSecondValue * interpolationValue;
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
            public void InterpolateBetween (Capacity firstState, Capacity secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setBuildButtonInstance0XFirstValue = false;
                bool setBuildButtonInstance0XSecondValue = false;
                float BuildButtonInstance0XFirstValue= 0;
                float BuildButtonInstance0XSecondValue= 0;
                bool setBuildButtonInstance0YFirstValue = false;
                bool setBuildButtonInstance0YSecondValue = false;
                float BuildButtonInstance0YFirstValue= 0;
                float BuildButtonInstance0YSecondValue= 0;
                bool setBuildButtonInstance1XFirstValue = false;
                bool setBuildButtonInstance1XSecondValue = false;
                float BuildButtonInstance1XFirstValue= 0;
                float BuildButtonInstance1XSecondValue= 0;
                bool setBuildButtonInstance1YFirstValue = false;
                bool setBuildButtonInstance1YSecondValue = false;
                float BuildButtonInstance1YFirstValue= 0;
                float BuildButtonInstance1YSecondValue= 0;
                bool setBuildButtonInstance2XFirstValue = false;
                bool setBuildButtonInstance2XSecondValue = false;
                float BuildButtonInstance2XFirstValue= 0;
                float BuildButtonInstance2XSecondValue= 0;
                bool setBuildButtonInstance2YFirstValue = false;
                bool setBuildButtonInstance2YSecondValue = false;
                float BuildButtonInstance2YFirstValue= 0;
                float BuildButtonInstance2YSecondValue= 0;
                bool setBuildButtonInstance3XFirstValue = false;
                bool setBuildButtonInstance3XSecondValue = false;
                float BuildButtonInstance3XFirstValue= 0;
                float BuildButtonInstance3XSecondValue= 0;
                bool setBuildButtonInstance3YFirstValue = false;
                bool setBuildButtonInstance3YSecondValue = false;
                float BuildButtonInstance3YFirstValue= 0;
                float BuildButtonInstance3YSecondValue= 0;
                bool setBuildButtonInstance4XFirstValue = false;
                bool setBuildButtonInstance4XSecondValue = false;
                float BuildButtonInstance4XFirstValue= 0;
                float BuildButtonInstance4XSecondValue= 0;
                bool setBuildButtonInstance4YFirstValue = false;
                bool setBuildButtonInstance4YSecondValue = false;
                float BuildButtonInstance4YFirstValue= 0;
                float BuildButtonInstance4YSecondValue= 0;
                bool setBuildButtonInstance5HeightFirstValue = false;
                bool setBuildButtonInstance5HeightSecondValue = false;
                float BuildButtonInstance5HeightFirstValue= 0;
                float BuildButtonInstance5HeightSecondValue= 0;
                bool setBuildButtonInstance5WidthFirstValue = false;
                bool setBuildButtonInstance5WidthSecondValue = false;
                float BuildButtonInstance5WidthFirstValue= 0;
                float BuildButtonInstance5WidthSecondValue= 0;
                bool setBuildButtonInstance5XFirstValue = false;
                bool setBuildButtonInstance5XSecondValue = false;
                float BuildButtonInstance5XFirstValue= 0;
                float BuildButtonInstance5XSecondValue= 0;
                bool setBuildButtonInstance5YFirstValue = false;
                bool setBuildButtonInstance5YSecondValue = false;
                float BuildButtonInstance5YFirstValue= 0;
                float BuildButtonInstance5YSecondValue= 0;
                bool setBuildButtonInstance6HeightFirstValue = false;
                bool setBuildButtonInstance6HeightSecondValue = false;
                float BuildButtonInstance6HeightFirstValue= 0;
                float BuildButtonInstance6HeightSecondValue= 0;
                bool setBuildButtonInstance6WidthFirstValue = false;
                bool setBuildButtonInstance6WidthSecondValue = false;
                float BuildButtonInstance6WidthFirstValue= 0;
                float BuildButtonInstance6WidthSecondValue= 0;
                bool setBuildButtonInstance6XFirstValue = false;
                bool setBuildButtonInstance6XSecondValue = false;
                float BuildButtonInstance6XFirstValue= 0;
                float BuildButtonInstance6XSecondValue= 0;
                bool setBuildButtonInstance6YFirstValue = false;
                bool setBuildButtonInstance6YSecondValue = false;
                float BuildButtonInstance6YFirstValue= 0;
                float BuildButtonInstance6YSecondValue= 0;
                bool setFourButtonFrameInstanceCurrentRotatedStateFirstValue = false;
                bool setFourButtonFrameInstanceCurrentRotatedStateSecondValue = false;
                FourButtonFrameRuntime.Rotated FourButtonFrameInstanceCurrentRotatedStateFirstValue= FourButtonFrameRuntime.Rotated.Left;
                FourButtonFrameRuntime.Rotated FourButtonFrameInstanceCurrentRotatedStateSecondValue= FourButtonFrameRuntime.Rotated.Left;
                bool setFourButtonFrameInstanceXFirstValue = false;
                bool setFourButtonFrameInstanceXSecondValue = false;
                float FourButtonFrameInstanceXFirstValue= 0;
                float FourButtonFrameInstanceXSecondValue= 0;
                bool setFourButtonFrameInstanceYFirstValue = false;
                bool setFourButtonFrameInstanceYSecondValue = false;
                float FourButtonFrameInstanceYFirstValue= 0;
                float FourButtonFrameInstanceYSecondValue= 0;
                bool setSevenButtonFrameInstanceXFirstValue = false;
                bool setSevenButtonFrameInstanceXSecondValue = false;
                float SevenButtonFrameInstanceXFirstValue= 0;
                float SevenButtonFrameInstanceXSecondValue= 0;
                bool setSevenButtonFrameInstanceYFirstValue = false;
                bool setSevenButtonFrameInstanceYSecondValue = false;
                float SevenButtonFrameInstanceYFirstValue= 0;
                float SevenButtonFrameInstanceYSecondValue= 0;
                bool setSevenButtonFrameInstanceCurrentRotatedStateFirstValue = false;
                bool setSevenButtonFrameInstanceCurrentRotatedStateSecondValue = false;
                SevenButtonFrameRuntime.Rotated SevenButtonFrameInstanceCurrentRotatedStateFirstValue= SevenButtonFrameRuntime.Rotated.Left;
                SevenButtonFrameRuntime.Rotated SevenButtonFrameInstanceCurrentRotatedStateSecondValue= SevenButtonFrameRuntime.Rotated.Left;
                switch(firstState)
                {
                    case  Capacity.Four:
                        setBuildButtonInstance0XFirstValue = true;
                        BuildButtonInstance0XFirstValue = 43.19118f;
                        setBuildButtonInstance0YFirstValue = true;
                        BuildButtonInstance0YFirstValue = 67.92753f;
                        setBuildButtonInstance1XFirstValue = true;
                        BuildButtonInstance1XFirstValue = 34.37128f;
                        if (interpolationValue < 1)
                        {
                            this.BuildButtonInstance1.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setBuildButtonInstance1YFirstValue = true;
                        BuildButtonInstance1YFirstValue = 51.32274f;
                        setBuildButtonInstance2XFirstValue = true;
                        BuildButtonInstance2XFirstValue = 52.03481f;
                        setBuildButtonInstance2YFirstValue = true;
                        BuildButtonInstance2YFirstValue = 51.35582f;
                        setBuildButtonInstance3XFirstValue = true;
                        BuildButtonInstance3XFirstValue = 43.17259f;
                        setBuildButtonInstance3YFirstValue = true;
                        BuildButtonInstance3YFirstValue = 34.02776f;
                        if (interpolationValue < 1)
                        {
                            this.BuildButtonInstance4.Visible = false;
                        }
                        setBuildButtonInstance4XFirstValue = true;
                        BuildButtonInstance4XFirstValue = 0f;
                        setBuildButtonInstance4YFirstValue = true;
                        BuildButtonInstance4YFirstValue = 0f;
                        setBuildButtonInstance5HeightFirstValue = true;
                        BuildButtonInstance5HeightFirstValue = 24.47f;
                        if (interpolationValue < 1)
                        {
                            this.BuildButtonInstance5.Visible = false;
                        }
                        setBuildButtonInstance5WidthFirstValue = true;
                        BuildButtonInstance5WidthFirstValue = 13.647f;
                        setBuildButtonInstance5XFirstValue = true;
                        BuildButtonInstance5XFirstValue = 0f;
                        setBuildButtonInstance5YFirstValue = true;
                        BuildButtonInstance5YFirstValue = 0f;
                        setBuildButtonInstance6HeightFirstValue = true;
                        BuildButtonInstance6HeightFirstValue = 24.47f;
                        if (interpolationValue < 1)
                        {
                            this.BuildButtonInstance6.Visible = false;
                        }
                        setBuildButtonInstance6WidthFirstValue = true;
                        BuildButtonInstance6WidthFirstValue = 13.647f;
                        setBuildButtonInstance6XFirstValue = true;
                        BuildButtonInstance6XFirstValue = 0f;
                        setBuildButtonInstance6YFirstValue = true;
                        BuildButtonInstance6YFirstValue = 0f;
                        setFourButtonFrameInstanceCurrentRotatedStateFirstValue = true;
                        FourButtonFrameInstanceCurrentRotatedStateFirstValue = AbbatoirIntergrade.GumRuntimes.FourButtonFrameRuntime.Rotated.None;
                        if (interpolationValue < 1)
                        {
                            this.FourButtonFrameInstance.Visible = true;
                        }
                        setFourButtonFrameInstanceXFirstValue = true;
                        FourButtonFrameInstanceXFirstValue = 50f;
                        setFourButtonFrameInstanceYFirstValue = true;
                        FourButtonFrameInstanceYFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.SevenButtonFrameInstance.Visible = false;
                        }
                        setSevenButtonFrameInstanceXFirstValue = true;
                        SevenButtonFrameInstanceXFirstValue = 47.50298f;
                        setSevenButtonFrameInstanceYFirstValue = true;
                        SevenButtonFrameInstanceYFirstValue = 100.8836f;
                        if (interpolationValue < 1)
                        {
                            this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        break;
                    case  Capacity.FourLeft:
                        setBuildButtonInstance0XFirstValue = true;
                        BuildButtonInstance0XFirstValue = 82.09743f;
                        setBuildButtonInstance0YFirstValue = true;
                        BuildButtonInstance0YFirstValue = 37.92752f;
                        setBuildButtonInstance1XFirstValue = true;
                        BuildButtonInstance1XFirstValue = 72.73f;
                        if (interpolationValue < 1)
                        {
                            this.BuildButtonInstance1.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setBuildButtonInstance1YFirstValue = true;
                        BuildButtonInstance1YFirstValue = 53.82274f;
                        setBuildButtonInstance2XFirstValue = true;
                        BuildButtonInstance2XFirstValue = 72.73793f;
                        setBuildButtonInstance2YFirstValue = true;
                        BuildButtonInstance2YFirstValue = 21.95767f;
                        setBuildButtonInstance3XFirstValue = true;
                        BuildButtonInstance3XFirstValue = 63.01634f;
                        setBuildButtonInstance3YFirstValue = true;
                        BuildButtonInstance3YFirstValue = 37.91665f;
                        if (interpolationValue < 1)
                        {
                            this.BuildButtonInstance4.Visible = false;
                        }
                        setBuildButtonInstance4XFirstValue = true;
                        BuildButtonInstance4XFirstValue = 0f;
                        setBuildButtonInstance4YFirstValue = true;
                        BuildButtonInstance4YFirstValue = 0f;
                        setBuildButtonInstance5HeightFirstValue = true;
                        BuildButtonInstance5HeightFirstValue = 24.47f;
                        if (interpolationValue < 1)
                        {
                            this.BuildButtonInstance5.Visible = false;
                        }
                        setBuildButtonInstance5WidthFirstValue = true;
                        BuildButtonInstance5WidthFirstValue = 13.647f;
                        setBuildButtonInstance5XFirstValue = true;
                        BuildButtonInstance5XFirstValue = 0f;
                        setBuildButtonInstance5YFirstValue = true;
                        BuildButtonInstance5YFirstValue = 0f;
                        setBuildButtonInstance6HeightFirstValue = true;
                        BuildButtonInstance6HeightFirstValue = 24.47f;
                        if (interpolationValue < 1)
                        {
                            this.BuildButtonInstance6.Visible = false;
                        }
                        setBuildButtonInstance6WidthFirstValue = true;
                        BuildButtonInstance6WidthFirstValue = 13.647f;
                        setBuildButtonInstance6XFirstValue = true;
                        BuildButtonInstance6XFirstValue = 0f;
                        setBuildButtonInstance6YFirstValue = true;
                        BuildButtonInstance6YFirstValue = 0f;
                        setFourButtonFrameInstanceCurrentRotatedStateFirstValue = true;
                        FourButtonFrameInstanceCurrentRotatedStateFirstValue = AbbatoirIntergrade.GumRuntimes.FourButtonFrameRuntime.Rotated.Left;
                        if (interpolationValue < 1)
                        {
                            this.FourButtonFrameInstance.Visible = true;
                        }
                        setFourButtonFrameInstanceXFirstValue = true;
                        FourButtonFrameInstanceXFirstValue = 81.64063f;
                        setFourButtonFrameInstanceYFirstValue = true;
                        FourButtonFrameInstanceYFirstValue = 83.00002f;
                        if (interpolationValue < 1)
                        {
                            this.SevenButtonFrameInstance.Visible = false;
                        }
                        setSevenButtonFrameInstanceXFirstValue = true;
                        SevenButtonFrameInstanceXFirstValue = 47.50298f;
                        setSevenButtonFrameInstanceYFirstValue = true;
                        SevenButtonFrameInstanceYFirstValue = 100.8836f;
                        if (interpolationValue < 1)
                        {
                            this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        break;
                    case  Capacity.FourRight:
                        setBuildButtonInstance0XFirstValue = true;
                        BuildButtonInstance0XFirstValue = 4.363056f;
                        setBuildButtonInstance0YFirstValue = true;
                        BuildButtonInstance0YFirstValue = 37.92752f;
                        setBuildButtonInstance1XFirstValue = true;
                        BuildButtonInstance1XFirstValue = 13.73f;
                        if (interpolationValue < 1)
                        {
                            this.BuildButtonInstance1.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setBuildButtonInstance1YFirstValue = true;
                        BuildButtonInstance1YFirstValue = 53.56481f;
                        setBuildButtonInstance2XFirstValue = true;
                        BuildButtonInstance2XFirstValue = 13.73f;
                        setBuildButtonInstance2YFirstValue = true;
                        BuildButtonInstance2YFirstValue = 22.05026f;
                        setBuildButtonInstance3XFirstValue = true;
                        BuildButtonInstance3XFirstValue = 23.38464f;
                        setBuildButtonInstance3YFirstValue = true;
                        BuildButtonInstance3YFirstValue = 37.7976f;
                        if (interpolationValue < 1)
                        {
                            this.BuildButtonInstance4.Visible = false;
                        }
                        setBuildButtonInstance4XFirstValue = true;
                        BuildButtonInstance4XFirstValue = 0f;
                        setBuildButtonInstance4YFirstValue = true;
                        BuildButtonInstance4YFirstValue = 0f;
                        setBuildButtonInstance5HeightFirstValue = true;
                        BuildButtonInstance5HeightFirstValue = 24.47f;
                        if (interpolationValue < 1)
                        {
                            this.BuildButtonInstance5.Visible = false;
                        }
                        setBuildButtonInstance5WidthFirstValue = true;
                        BuildButtonInstance5WidthFirstValue = 13.647f;
                        setBuildButtonInstance5XFirstValue = true;
                        BuildButtonInstance5XFirstValue = 0f;
                        setBuildButtonInstance5YFirstValue = true;
                        BuildButtonInstance5YFirstValue = 0f;
                        setBuildButtonInstance6HeightFirstValue = true;
                        BuildButtonInstance6HeightFirstValue = 24.47f;
                        if (interpolationValue < 1)
                        {
                            this.BuildButtonInstance6.Visible = false;
                        }
                        setBuildButtonInstance6WidthFirstValue = true;
                        BuildButtonInstance6WidthFirstValue = 13.647f;
                        setBuildButtonInstance6XFirstValue = true;
                        BuildButtonInstance6XFirstValue = 0f;
                        setBuildButtonInstance6YFirstValue = true;
                        BuildButtonInstance6YFirstValue = 0f;
                        setFourButtonFrameInstanceCurrentRotatedStateFirstValue = true;
                        FourButtonFrameInstanceCurrentRotatedStateFirstValue = AbbatoirIntergrade.GumRuntimes.FourButtonFrameRuntime.Rotated.Right;
                        if (interpolationValue < 1)
                        {
                            this.FourButtonFrameInstance.Visible = true;
                        }
                        setFourButtonFrameInstanceXFirstValue = true;
                        FourButtonFrameInstanceXFirstValue = 11.69791f;
                        setFourButtonFrameInstanceYFirstValue = true;
                        FourButtonFrameInstanceYFirstValue = 82.79628f;
                        if (interpolationValue < 1)
                        {
                            this.SevenButtonFrameInstance.Visible = false;
                        }
                        setSevenButtonFrameInstanceXFirstValue = true;
                        SevenButtonFrameInstanceXFirstValue = 47.50298f;
                        setSevenButtonFrameInstanceYFirstValue = true;
                        SevenButtonFrameInstanceYFirstValue = 100.8836f;
                        if (interpolationValue < 1)
                        {
                            this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        break;
                    case  Capacity.Seven:
                        setBuildButtonInstance0XFirstValue = true;
                        BuildButtonInstance0XFirstValue = 43.14814f;
                        setBuildButtonInstance0YFirstValue = true;
                        BuildButtonInstance0YFirstValue = 68.01085f;
                        setBuildButtonInstance1XFirstValue = true;
                        BuildButtonInstance1XFirstValue = 34.26563f;
                        if (interpolationValue < 1)
                        {
                            this.BuildButtonInstance1.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setBuildButtonInstance1YFirstValue = true;
                        BuildButtonInstance1YFirstValue = 51.43519f;
                        setBuildButtonInstance2XFirstValue = true;
                        BuildButtonInstance2XFirstValue = 52.06459f;
                        setBuildButtonInstance2YFirstValue = true;
                        BuildButtonInstance2YFirstValue = 51.57408f;
                        setBuildButtonInstance3XFirstValue = true;
                        BuildButtonInstance3XFirstValue = 43.15125f;
                        setBuildButtonInstance3YFirstValue = true;
                        BuildButtonInstance3YFirstValue = 35.08086f;
                        if (interpolationValue < 1)
                        {
                            this.BuildButtonInstance4.Visible = true;
                        }
                        setBuildButtonInstance4XFirstValue = true;
                        BuildButtonInstance4XFirstValue = 34.29688f;
                        setBuildButtonInstance4YFirstValue = true;
                        BuildButtonInstance4YFirstValue = 18.35648f;
                        setBuildButtonInstance5HeightFirstValue = true;
                        BuildButtonInstance5HeightFirstValue = 24.47f;
                        if (interpolationValue < 1)
                        {
                            this.BuildButtonInstance5.Visible = true;
                        }
                        setBuildButtonInstance5WidthFirstValue = true;
                        BuildButtonInstance5WidthFirstValue = 13.647f;
                        setBuildButtonInstance5XFirstValue = true;
                        BuildButtonInstance5XFirstValue = 52.00523f;
                        if (interpolationValue < 1)
                        {
                            this.BuildButtonInstance5.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setBuildButtonInstance5YFirstValue = true;
                        BuildButtonInstance5YFirstValue = 18.31018f;
                        if (interpolationValue < 1)
                        {
                            this.BuildButtonInstance5.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setBuildButtonInstance6HeightFirstValue = true;
                        BuildButtonInstance6HeightFirstValue = 24.47f;
                        if (interpolationValue < 1)
                        {
                            this.BuildButtonInstance6.Visible = true;
                        }
                        setBuildButtonInstance6WidthFirstValue = true;
                        BuildButtonInstance6WidthFirstValue = 13.647f;
                        setBuildButtonInstance6XFirstValue = true;
                        BuildButtonInstance6XFirstValue = 43.15125f;
                        if (interpolationValue < 1)
                        {
                            this.BuildButtonInstance6.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setBuildButtonInstance6YFirstValue = true;
                        BuildButtonInstance6YFirstValue = 1.134257f;
                        if (interpolationValue < 1)
                        {
                            this.FourButtonFrameInstance.Visible = false;
                        }
                        setFourButtonFrameInstanceXFirstValue = true;
                        FourButtonFrameInstanceXFirstValue = 50f;
                        setFourButtonFrameInstanceYFirstValue = true;
                        FourButtonFrameInstanceYFirstValue = 100f;
                        setSevenButtonFrameInstanceCurrentRotatedStateFirstValue = true;
                        SevenButtonFrameInstanceCurrentRotatedStateFirstValue = AbbatoirIntergrade.GumRuntimes.SevenButtonFrameRuntime.Rotated.None;
                        if (interpolationValue < 1)
                        {
                            this.SevenButtonFrameInstance.Visible = true;
                        }
                        setSevenButtonFrameInstanceXFirstValue = true;
                        SevenButtonFrameInstanceXFirstValue = 47.50298f;
                        setSevenButtonFrameInstanceYFirstValue = true;
                        SevenButtonFrameInstanceYFirstValue = 100.8836f;
                        if (interpolationValue < 1)
                        {
                            this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        break;
                    case  Capacity.SevenLeft:
                        setBuildButtonInstance0XFirstValue = true;
                        BuildButtonInstance0XFirstValue = 82.00231f;
                        setBuildButtonInstance0YFirstValue = true;
                        BuildButtonInstance0YFirstValue = 37.87195f;
                        setBuildButtonInstance1XFirstValue = true;
                        BuildButtonInstance1XFirstValue = 72.76563f;
                        if (interpolationValue < 1)
                        {
                            this.BuildButtonInstance1.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setBuildButtonInstance1YFirstValue = true;
                        BuildButtonInstance1YFirstValue = 53.65741f;
                        setBuildButtonInstance2XFirstValue = true;
                        BuildButtonInstance2XFirstValue = 72.76772f;
                        setBuildButtonInstance2YFirstValue = true;
                        BuildButtonInstance2YFirstValue = 21.99075f;
                        setBuildButtonInstance3XFirstValue = true;
                        BuildButtonInstance3XFirstValue = 63.51583f;
                        setBuildButtonInstance3YFirstValue = true;
                        BuildButtonInstance3YFirstValue = 37.90495f;
                        if (interpolationValue < 1)
                        {
                            this.BuildButtonInstance4.Visible = true;
                        }
                        setBuildButtonInstance4XFirstValue = true;
                        BuildButtonInstance4XFirstValue = 54.14063f;
                        setBuildButtonInstance4YFirstValue = true;
                        BuildButtonInstance4YFirstValue = 53.63426f;
                        setBuildButtonInstance5HeightFirstValue = true;
                        BuildButtonInstance5HeightFirstValue = 24.47f;
                        if (interpolationValue < 1)
                        {
                            this.BuildButtonInstance5.Visible = true;
                        }
                        setBuildButtonInstance5WidthFirstValue = true;
                        BuildButtonInstance5WidthFirstValue = 13.647f;
                        setBuildButtonInstance5XFirstValue = true;
                        BuildButtonInstance5XFirstValue = 54.1146f;
                        if (interpolationValue < 1)
                        {
                            this.BuildButtonInstance5.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setBuildButtonInstance5YFirstValue = true;
                        BuildButtonInstance5YFirstValue = 22.02546f;
                        if (interpolationValue < 1)
                        {
                            this.BuildButtonInstance5.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setBuildButtonInstance6HeightFirstValue = true;
                        BuildButtonInstance6HeightFirstValue = 24.47f;
                        if (interpolationValue < 1)
                        {
                            this.BuildButtonInstance6.Visible = true;
                        }
                        setBuildButtonInstance6WidthFirstValue = true;
                        BuildButtonInstance6WidthFirstValue = 13.647f;
                        setBuildButtonInstance6XFirstValue = true;
                        BuildButtonInstance6XFirstValue = 44.38015f;
                        if (interpolationValue < 1)
                        {
                            this.BuildButtonInstance6.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setBuildButtonInstance6YFirstValue = true;
                        BuildButtonInstance6YFirstValue = 37.88074f;
                        if (interpolationValue < 1)
                        {
                            this.FourButtonFrameInstance.Visible = false;
                        }
                        setFourButtonFrameInstanceXFirstValue = true;
                        FourButtonFrameInstanceXFirstValue = 56.6875f;
                        setFourButtonFrameInstanceYFirstValue = true;
                        FourButtonFrameInstanceYFirstValue = 99.77779f;
                        setSevenButtonFrameInstanceCurrentRotatedStateFirstValue = true;
                        SevenButtonFrameInstanceCurrentRotatedStateFirstValue = AbbatoirIntergrade.GumRuntimes.SevenButtonFrameRuntime.Rotated.Left;
                        if (interpolationValue < 1)
                        {
                            this.SevenButtonFrameInstance.Visible = true;
                        }
                        setSevenButtonFrameInstanceXFirstValue = true;
                        SevenButtonFrameInstanceXFirstValue = 60.5945f;
                        setSevenButtonFrameInstanceYFirstValue = true;
                        SevenButtonFrameInstanceYFirstValue = 116.85f;
                        if (interpolationValue < 1)
                        {
                            this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        break;
                    case  Capacity.SevenRight:
                        setBuildButtonInstance0XFirstValue = true;
                        BuildButtonInstance0XFirstValue = 4.293975f;
                        setBuildButtonInstance0YFirstValue = true;
                        BuildButtonInstance0YFirstValue = 37.88f;
                        setBuildButtonInstance1XFirstValue = true;
                        BuildButtonInstance1XFirstValue = 13.57813f;
                        if (interpolationValue < 1)
                        {
                            this.BuildButtonInstance1.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setBuildButtonInstance1YFirstValue = true;
                        BuildButtonInstance1YFirstValue = 53.87964f;
                        setBuildButtonInstance2XFirstValue = true;
                        BuildButtonInstance2XFirstValue = 13.61667f;
                        setBuildButtonInstance2YFirstValue = true;
                        BuildButtonInstance2YFirstValue = 21.90742f;
                        setBuildButtonInstance3XFirstValue = true;
                        BuildButtonInstance3XFirstValue = 22.90776f;
                        setBuildButtonInstance3YFirstValue = true;
                        BuildButtonInstance3YFirstValue = 37.90197f;
                        if (interpolationValue < 1)
                        {
                            this.BuildButtonInstance4.Visible = true;
                        }
                        setBuildButtonInstance4XFirstValue = true;
                        BuildButtonInstance4XFirstValue = 32.28125f;
                        setBuildButtonInstance4YFirstValue = true;
                        BuildButtonInstance4YFirstValue = 53.74537f;
                        setBuildButtonInstance5HeightFirstValue = true;
                        BuildButtonInstance5HeightFirstValue = 24.47f;
                        if (interpolationValue < 1)
                        {
                            this.BuildButtonInstance5.Visible = true;
                        }
                        setBuildButtonInstance5WidthFirstValue = true;
                        BuildButtonInstance5WidthFirstValue = 13.647f;
                        setBuildButtonInstance5XFirstValue = true;
                        BuildButtonInstance5XFirstValue = 32.29986f;
                        if (interpolationValue < 1)
                        {
                            this.BuildButtonInstance5.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setBuildButtonInstance5YFirstValue = true;
                        BuildButtonInstance5YFirstValue = 22.04827f;
                        if (interpolationValue < 1)
                        {
                            this.BuildButtonInstance5.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setBuildButtonInstance6HeightFirstValue = true;
                        BuildButtonInstance6HeightFirstValue = 24.47f;
                        if (interpolationValue < 1)
                        {
                            this.BuildButtonInstance6.Visible = true;
                        }
                        setBuildButtonInstance6WidthFirstValue = true;
                        BuildButtonInstance6WidthFirstValue = 13.647f;
                        setBuildButtonInstance6XFirstValue = true;
                        BuildButtonInstance6XFirstValue = 41.88341f;
                        if (interpolationValue < 1)
                        {
                            this.BuildButtonInstance6.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setBuildButtonInstance6YFirstValue = true;
                        BuildButtonInstance6YFirstValue = 37.8168f;
                        if (interpolationValue < 1)
                        {
                            this.FourButtonFrameInstance.Visible = false;
                        }
                        setFourButtonFrameInstanceXFirstValue = true;
                        FourButtonFrameInstanceXFirstValue = 50f;
                        setFourButtonFrameInstanceYFirstValue = true;
                        FourButtonFrameInstanceYFirstValue = 100f;
                        setSevenButtonFrameInstanceCurrentRotatedStateFirstValue = true;
                        SevenButtonFrameInstanceCurrentRotatedStateFirstValue = AbbatoirIntergrade.GumRuntimes.SevenButtonFrameRuntime.Rotated.Right;
                        if (interpolationValue < 1)
                        {
                            this.SevenButtonFrameInstance.Visible = true;
                        }
                        setSevenButtonFrameInstanceXFirstValue = true;
                        SevenButtonFrameInstanceXFirstValue = 9.088921f;
                        setSevenButtonFrameInstanceYFirstValue = true;
                        SevenButtonFrameInstanceYFirstValue = 116.5294f;
                        if (interpolationValue < 1)
                        {
                            this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  Capacity.Four:
                        setBuildButtonInstance0XSecondValue = true;
                        BuildButtonInstance0XSecondValue = 43.19118f;
                        setBuildButtonInstance0YSecondValue = true;
                        BuildButtonInstance0YSecondValue = 67.92753f;
                        setBuildButtonInstance1XSecondValue = true;
                        BuildButtonInstance1XSecondValue = 34.37128f;
                        if (interpolationValue >= 1)
                        {
                            this.BuildButtonInstance1.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setBuildButtonInstance1YSecondValue = true;
                        BuildButtonInstance1YSecondValue = 51.32274f;
                        setBuildButtonInstance2XSecondValue = true;
                        BuildButtonInstance2XSecondValue = 52.03481f;
                        setBuildButtonInstance2YSecondValue = true;
                        BuildButtonInstance2YSecondValue = 51.35582f;
                        setBuildButtonInstance3XSecondValue = true;
                        BuildButtonInstance3XSecondValue = 43.17259f;
                        setBuildButtonInstance3YSecondValue = true;
                        BuildButtonInstance3YSecondValue = 34.02776f;
                        if (interpolationValue >= 1)
                        {
                            this.BuildButtonInstance4.Visible = false;
                        }
                        setBuildButtonInstance4XSecondValue = true;
                        BuildButtonInstance4XSecondValue = 0f;
                        setBuildButtonInstance4YSecondValue = true;
                        BuildButtonInstance4YSecondValue = 0f;
                        setBuildButtonInstance5HeightSecondValue = true;
                        BuildButtonInstance5HeightSecondValue = 24.47f;
                        if (interpolationValue >= 1)
                        {
                            this.BuildButtonInstance5.Visible = false;
                        }
                        setBuildButtonInstance5WidthSecondValue = true;
                        BuildButtonInstance5WidthSecondValue = 13.647f;
                        setBuildButtonInstance5XSecondValue = true;
                        BuildButtonInstance5XSecondValue = 0f;
                        setBuildButtonInstance5YSecondValue = true;
                        BuildButtonInstance5YSecondValue = 0f;
                        setBuildButtonInstance6HeightSecondValue = true;
                        BuildButtonInstance6HeightSecondValue = 24.47f;
                        if (interpolationValue >= 1)
                        {
                            this.BuildButtonInstance6.Visible = false;
                        }
                        setBuildButtonInstance6WidthSecondValue = true;
                        BuildButtonInstance6WidthSecondValue = 13.647f;
                        setBuildButtonInstance6XSecondValue = true;
                        BuildButtonInstance6XSecondValue = 0f;
                        setBuildButtonInstance6YSecondValue = true;
                        BuildButtonInstance6YSecondValue = 0f;
                        setFourButtonFrameInstanceCurrentRotatedStateSecondValue = true;
                        FourButtonFrameInstanceCurrentRotatedStateSecondValue = AbbatoirIntergrade.GumRuntimes.FourButtonFrameRuntime.Rotated.None;
                        if (interpolationValue >= 1)
                        {
                            this.FourButtonFrameInstance.Visible = true;
                        }
                        setFourButtonFrameInstanceXSecondValue = true;
                        FourButtonFrameInstanceXSecondValue = 50f;
                        setFourButtonFrameInstanceYSecondValue = true;
                        FourButtonFrameInstanceYSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.SevenButtonFrameInstance.Visible = false;
                        }
                        setSevenButtonFrameInstanceXSecondValue = true;
                        SevenButtonFrameInstanceXSecondValue = 47.50298f;
                        setSevenButtonFrameInstanceYSecondValue = true;
                        SevenButtonFrameInstanceYSecondValue = 100.8836f;
                        if (interpolationValue >= 1)
                        {
                            this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        break;
                    case  Capacity.FourLeft:
                        setBuildButtonInstance0XSecondValue = true;
                        BuildButtonInstance0XSecondValue = 82.09743f;
                        setBuildButtonInstance0YSecondValue = true;
                        BuildButtonInstance0YSecondValue = 37.92752f;
                        setBuildButtonInstance1XSecondValue = true;
                        BuildButtonInstance1XSecondValue = 72.73f;
                        if (interpolationValue >= 1)
                        {
                            this.BuildButtonInstance1.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setBuildButtonInstance1YSecondValue = true;
                        BuildButtonInstance1YSecondValue = 53.82274f;
                        setBuildButtonInstance2XSecondValue = true;
                        BuildButtonInstance2XSecondValue = 72.73793f;
                        setBuildButtonInstance2YSecondValue = true;
                        BuildButtonInstance2YSecondValue = 21.95767f;
                        setBuildButtonInstance3XSecondValue = true;
                        BuildButtonInstance3XSecondValue = 63.01634f;
                        setBuildButtonInstance3YSecondValue = true;
                        BuildButtonInstance3YSecondValue = 37.91665f;
                        if (interpolationValue >= 1)
                        {
                            this.BuildButtonInstance4.Visible = false;
                        }
                        setBuildButtonInstance4XSecondValue = true;
                        BuildButtonInstance4XSecondValue = 0f;
                        setBuildButtonInstance4YSecondValue = true;
                        BuildButtonInstance4YSecondValue = 0f;
                        setBuildButtonInstance5HeightSecondValue = true;
                        BuildButtonInstance5HeightSecondValue = 24.47f;
                        if (interpolationValue >= 1)
                        {
                            this.BuildButtonInstance5.Visible = false;
                        }
                        setBuildButtonInstance5WidthSecondValue = true;
                        BuildButtonInstance5WidthSecondValue = 13.647f;
                        setBuildButtonInstance5XSecondValue = true;
                        BuildButtonInstance5XSecondValue = 0f;
                        setBuildButtonInstance5YSecondValue = true;
                        BuildButtonInstance5YSecondValue = 0f;
                        setBuildButtonInstance6HeightSecondValue = true;
                        BuildButtonInstance6HeightSecondValue = 24.47f;
                        if (interpolationValue >= 1)
                        {
                            this.BuildButtonInstance6.Visible = false;
                        }
                        setBuildButtonInstance6WidthSecondValue = true;
                        BuildButtonInstance6WidthSecondValue = 13.647f;
                        setBuildButtonInstance6XSecondValue = true;
                        BuildButtonInstance6XSecondValue = 0f;
                        setBuildButtonInstance6YSecondValue = true;
                        BuildButtonInstance6YSecondValue = 0f;
                        setFourButtonFrameInstanceCurrentRotatedStateSecondValue = true;
                        FourButtonFrameInstanceCurrentRotatedStateSecondValue = AbbatoirIntergrade.GumRuntimes.FourButtonFrameRuntime.Rotated.Left;
                        if (interpolationValue >= 1)
                        {
                            this.FourButtonFrameInstance.Visible = true;
                        }
                        setFourButtonFrameInstanceXSecondValue = true;
                        FourButtonFrameInstanceXSecondValue = 81.64063f;
                        setFourButtonFrameInstanceYSecondValue = true;
                        FourButtonFrameInstanceYSecondValue = 83.00002f;
                        if (interpolationValue >= 1)
                        {
                            this.SevenButtonFrameInstance.Visible = false;
                        }
                        setSevenButtonFrameInstanceXSecondValue = true;
                        SevenButtonFrameInstanceXSecondValue = 47.50298f;
                        setSevenButtonFrameInstanceYSecondValue = true;
                        SevenButtonFrameInstanceYSecondValue = 100.8836f;
                        if (interpolationValue >= 1)
                        {
                            this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        break;
                    case  Capacity.FourRight:
                        setBuildButtonInstance0XSecondValue = true;
                        BuildButtonInstance0XSecondValue = 4.363056f;
                        setBuildButtonInstance0YSecondValue = true;
                        BuildButtonInstance0YSecondValue = 37.92752f;
                        setBuildButtonInstance1XSecondValue = true;
                        BuildButtonInstance1XSecondValue = 13.73f;
                        if (interpolationValue >= 1)
                        {
                            this.BuildButtonInstance1.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setBuildButtonInstance1YSecondValue = true;
                        BuildButtonInstance1YSecondValue = 53.56481f;
                        setBuildButtonInstance2XSecondValue = true;
                        BuildButtonInstance2XSecondValue = 13.73f;
                        setBuildButtonInstance2YSecondValue = true;
                        BuildButtonInstance2YSecondValue = 22.05026f;
                        setBuildButtonInstance3XSecondValue = true;
                        BuildButtonInstance3XSecondValue = 23.38464f;
                        setBuildButtonInstance3YSecondValue = true;
                        BuildButtonInstance3YSecondValue = 37.7976f;
                        if (interpolationValue >= 1)
                        {
                            this.BuildButtonInstance4.Visible = false;
                        }
                        setBuildButtonInstance4XSecondValue = true;
                        BuildButtonInstance4XSecondValue = 0f;
                        setBuildButtonInstance4YSecondValue = true;
                        BuildButtonInstance4YSecondValue = 0f;
                        setBuildButtonInstance5HeightSecondValue = true;
                        BuildButtonInstance5HeightSecondValue = 24.47f;
                        if (interpolationValue >= 1)
                        {
                            this.BuildButtonInstance5.Visible = false;
                        }
                        setBuildButtonInstance5WidthSecondValue = true;
                        BuildButtonInstance5WidthSecondValue = 13.647f;
                        setBuildButtonInstance5XSecondValue = true;
                        BuildButtonInstance5XSecondValue = 0f;
                        setBuildButtonInstance5YSecondValue = true;
                        BuildButtonInstance5YSecondValue = 0f;
                        setBuildButtonInstance6HeightSecondValue = true;
                        BuildButtonInstance6HeightSecondValue = 24.47f;
                        if (interpolationValue >= 1)
                        {
                            this.BuildButtonInstance6.Visible = false;
                        }
                        setBuildButtonInstance6WidthSecondValue = true;
                        BuildButtonInstance6WidthSecondValue = 13.647f;
                        setBuildButtonInstance6XSecondValue = true;
                        BuildButtonInstance6XSecondValue = 0f;
                        setBuildButtonInstance6YSecondValue = true;
                        BuildButtonInstance6YSecondValue = 0f;
                        setFourButtonFrameInstanceCurrentRotatedStateSecondValue = true;
                        FourButtonFrameInstanceCurrentRotatedStateSecondValue = AbbatoirIntergrade.GumRuntimes.FourButtonFrameRuntime.Rotated.Right;
                        if (interpolationValue >= 1)
                        {
                            this.FourButtonFrameInstance.Visible = true;
                        }
                        setFourButtonFrameInstanceXSecondValue = true;
                        FourButtonFrameInstanceXSecondValue = 11.69791f;
                        setFourButtonFrameInstanceYSecondValue = true;
                        FourButtonFrameInstanceYSecondValue = 82.79628f;
                        if (interpolationValue >= 1)
                        {
                            this.SevenButtonFrameInstance.Visible = false;
                        }
                        setSevenButtonFrameInstanceXSecondValue = true;
                        SevenButtonFrameInstanceXSecondValue = 47.50298f;
                        setSevenButtonFrameInstanceYSecondValue = true;
                        SevenButtonFrameInstanceYSecondValue = 100.8836f;
                        if (interpolationValue >= 1)
                        {
                            this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        break;
                    case  Capacity.Seven:
                        setBuildButtonInstance0XSecondValue = true;
                        BuildButtonInstance0XSecondValue = 43.14814f;
                        setBuildButtonInstance0YSecondValue = true;
                        BuildButtonInstance0YSecondValue = 68.01085f;
                        setBuildButtonInstance1XSecondValue = true;
                        BuildButtonInstance1XSecondValue = 34.26563f;
                        if (interpolationValue >= 1)
                        {
                            this.BuildButtonInstance1.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setBuildButtonInstance1YSecondValue = true;
                        BuildButtonInstance1YSecondValue = 51.43519f;
                        setBuildButtonInstance2XSecondValue = true;
                        BuildButtonInstance2XSecondValue = 52.06459f;
                        setBuildButtonInstance2YSecondValue = true;
                        BuildButtonInstance2YSecondValue = 51.57408f;
                        setBuildButtonInstance3XSecondValue = true;
                        BuildButtonInstance3XSecondValue = 43.15125f;
                        setBuildButtonInstance3YSecondValue = true;
                        BuildButtonInstance3YSecondValue = 35.08086f;
                        if (interpolationValue >= 1)
                        {
                            this.BuildButtonInstance4.Visible = true;
                        }
                        setBuildButtonInstance4XSecondValue = true;
                        BuildButtonInstance4XSecondValue = 34.29688f;
                        setBuildButtonInstance4YSecondValue = true;
                        BuildButtonInstance4YSecondValue = 18.35648f;
                        setBuildButtonInstance5HeightSecondValue = true;
                        BuildButtonInstance5HeightSecondValue = 24.47f;
                        if (interpolationValue >= 1)
                        {
                            this.BuildButtonInstance5.Visible = true;
                        }
                        setBuildButtonInstance5WidthSecondValue = true;
                        BuildButtonInstance5WidthSecondValue = 13.647f;
                        setBuildButtonInstance5XSecondValue = true;
                        BuildButtonInstance5XSecondValue = 52.00523f;
                        if (interpolationValue >= 1)
                        {
                            this.BuildButtonInstance5.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setBuildButtonInstance5YSecondValue = true;
                        BuildButtonInstance5YSecondValue = 18.31018f;
                        if (interpolationValue >= 1)
                        {
                            this.BuildButtonInstance5.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setBuildButtonInstance6HeightSecondValue = true;
                        BuildButtonInstance6HeightSecondValue = 24.47f;
                        if (interpolationValue >= 1)
                        {
                            this.BuildButtonInstance6.Visible = true;
                        }
                        setBuildButtonInstance6WidthSecondValue = true;
                        BuildButtonInstance6WidthSecondValue = 13.647f;
                        setBuildButtonInstance6XSecondValue = true;
                        BuildButtonInstance6XSecondValue = 43.15125f;
                        if (interpolationValue >= 1)
                        {
                            this.BuildButtonInstance6.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setBuildButtonInstance6YSecondValue = true;
                        BuildButtonInstance6YSecondValue = 1.134257f;
                        if (interpolationValue >= 1)
                        {
                            this.FourButtonFrameInstance.Visible = false;
                        }
                        setFourButtonFrameInstanceXSecondValue = true;
                        FourButtonFrameInstanceXSecondValue = 50f;
                        setFourButtonFrameInstanceYSecondValue = true;
                        FourButtonFrameInstanceYSecondValue = 100f;
                        setSevenButtonFrameInstanceCurrentRotatedStateSecondValue = true;
                        SevenButtonFrameInstanceCurrentRotatedStateSecondValue = AbbatoirIntergrade.GumRuntimes.SevenButtonFrameRuntime.Rotated.None;
                        if (interpolationValue >= 1)
                        {
                            this.SevenButtonFrameInstance.Visible = true;
                        }
                        setSevenButtonFrameInstanceXSecondValue = true;
                        SevenButtonFrameInstanceXSecondValue = 47.50298f;
                        setSevenButtonFrameInstanceYSecondValue = true;
                        SevenButtonFrameInstanceYSecondValue = 100.8836f;
                        if (interpolationValue >= 1)
                        {
                            this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        break;
                    case  Capacity.SevenLeft:
                        setBuildButtonInstance0XSecondValue = true;
                        BuildButtonInstance0XSecondValue = 82.00231f;
                        setBuildButtonInstance0YSecondValue = true;
                        BuildButtonInstance0YSecondValue = 37.87195f;
                        setBuildButtonInstance1XSecondValue = true;
                        BuildButtonInstance1XSecondValue = 72.76563f;
                        if (interpolationValue >= 1)
                        {
                            this.BuildButtonInstance1.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setBuildButtonInstance1YSecondValue = true;
                        BuildButtonInstance1YSecondValue = 53.65741f;
                        setBuildButtonInstance2XSecondValue = true;
                        BuildButtonInstance2XSecondValue = 72.76772f;
                        setBuildButtonInstance2YSecondValue = true;
                        BuildButtonInstance2YSecondValue = 21.99075f;
                        setBuildButtonInstance3XSecondValue = true;
                        BuildButtonInstance3XSecondValue = 63.51583f;
                        setBuildButtonInstance3YSecondValue = true;
                        BuildButtonInstance3YSecondValue = 37.90495f;
                        if (interpolationValue >= 1)
                        {
                            this.BuildButtonInstance4.Visible = true;
                        }
                        setBuildButtonInstance4XSecondValue = true;
                        BuildButtonInstance4XSecondValue = 54.14063f;
                        setBuildButtonInstance4YSecondValue = true;
                        BuildButtonInstance4YSecondValue = 53.63426f;
                        setBuildButtonInstance5HeightSecondValue = true;
                        BuildButtonInstance5HeightSecondValue = 24.47f;
                        if (interpolationValue >= 1)
                        {
                            this.BuildButtonInstance5.Visible = true;
                        }
                        setBuildButtonInstance5WidthSecondValue = true;
                        BuildButtonInstance5WidthSecondValue = 13.647f;
                        setBuildButtonInstance5XSecondValue = true;
                        BuildButtonInstance5XSecondValue = 54.1146f;
                        if (interpolationValue >= 1)
                        {
                            this.BuildButtonInstance5.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setBuildButtonInstance5YSecondValue = true;
                        BuildButtonInstance5YSecondValue = 22.02546f;
                        if (interpolationValue >= 1)
                        {
                            this.BuildButtonInstance5.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setBuildButtonInstance6HeightSecondValue = true;
                        BuildButtonInstance6HeightSecondValue = 24.47f;
                        if (interpolationValue >= 1)
                        {
                            this.BuildButtonInstance6.Visible = true;
                        }
                        setBuildButtonInstance6WidthSecondValue = true;
                        BuildButtonInstance6WidthSecondValue = 13.647f;
                        setBuildButtonInstance6XSecondValue = true;
                        BuildButtonInstance6XSecondValue = 44.38015f;
                        if (interpolationValue >= 1)
                        {
                            this.BuildButtonInstance6.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setBuildButtonInstance6YSecondValue = true;
                        BuildButtonInstance6YSecondValue = 37.88074f;
                        if (interpolationValue >= 1)
                        {
                            this.FourButtonFrameInstance.Visible = false;
                        }
                        setFourButtonFrameInstanceXSecondValue = true;
                        FourButtonFrameInstanceXSecondValue = 56.6875f;
                        setFourButtonFrameInstanceYSecondValue = true;
                        FourButtonFrameInstanceYSecondValue = 99.77779f;
                        setSevenButtonFrameInstanceCurrentRotatedStateSecondValue = true;
                        SevenButtonFrameInstanceCurrentRotatedStateSecondValue = AbbatoirIntergrade.GumRuntimes.SevenButtonFrameRuntime.Rotated.Left;
                        if (interpolationValue >= 1)
                        {
                            this.SevenButtonFrameInstance.Visible = true;
                        }
                        setSevenButtonFrameInstanceXSecondValue = true;
                        SevenButtonFrameInstanceXSecondValue = 60.5945f;
                        setSevenButtonFrameInstanceYSecondValue = true;
                        SevenButtonFrameInstanceYSecondValue = 116.85f;
                        if (interpolationValue >= 1)
                        {
                            this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        break;
                    case  Capacity.SevenRight:
                        setBuildButtonInstance0XSecondValue = true;
                        BuildButtonInstance0XSecondValue = 4.293975f;
                        setBuildButtonInstance0YSecondValue = true;
                        BuildButtonInstance0YSecondValue = 37.88f;
                        setBuildButtonInstance1XSecondValue = true;
                        BuildButtonInstance1XSecondValue = 13.57813f;
                        if (interpolationValue >= 1)
                        {
                            this.BuildButtonInstance1.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setBuildButtonInstance1YSecondValue = true;
                        BuildButtonInstance1YSecondValue = 53.87964f;
                        setBuildButtonInstance2XSecondValue = true;
                        BuildButtonInstance2XSecondValue = 13.61667f;
                        setBuildButtonInstance2YSecondValue = true;
                        BuildButtonInstance2YSecondValue = 21.90742f;
                        setBuildButtonInstance3XSecondValue = true;
                        BuildButtonInstance3XSecondValue = 22.90776f;
                        setBuildButtonInstance3YSecondValue = true;
                        BuildButtonInstance3YSecondValue = 37.90197f;
                        if (interpolationValue >= 1)
                        {
                            this.BuildButtonInstance4.Visible = true;
                        }
                        setBuildButtonInstance4XSecondValue = true;
                        BuildButtonInstance4XSecondValue = 32.28125f;
                        setBuildButtonInstance4YSecondValue = true;
                        BuildButtonInstance4YSecondValue = 53.74537f;
                        setBuildButtonInstance5HeightSecondValue = true;
                        BuildButtonInstance5HeightSecondValue = 24.47f;
                        if (interpolationValue >= 1)
                        {
                            this.BuildButtonInstance5.Visible = true;
                        }
                        setBuildButtonInstance5WidthSecondValue = true;
                        BuildButtonInstance5WidthSecondValue = 13.647f;
                        setBuildButtonInstance5XSecondValue = true;
                        BuildButtonInstance5XSecondValue = 32.29986f;
                        if (interpolationValue >= 1)
                        {
                            this.BuildButtonInstance5.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setBuildButtonInstance5YSecondValue = true;
                        BuildButtonInstance5YSecondValue = 22.04827f;
                        if (interpolationValue >= 1)
                        {
                            this.BuildButtonInstance5.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setBuildButtonInstance6HeightSecondValue = true;
                        BuildButtonInstance6HeightSecondValue = 24.47f;
                        if (interpolationValue >= 1)
                        {
                            this.BuildButtonInstance6.Visible = true;
                        }
                        setBuildButtonInstance6WidthSecondValue = true;
                        BuildButtonInstance6WidthSecondValue = 13.647f;
                        setBuildButtonInstance6XSecondValue = true;
                        BuildButtonInstance6XSecondValue = 41.88341f;
                        if (interpolationValue >= 1)
                        {
                            this.BuildButtonInstance6.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setBuildButtonInstance6YSecondValue = true;
                        BuildButtonInstance6YSecondValue = 37.8168f;
                        if (interpolationValue >= 1)
                        {
                            this.FourButtonFrameInstance.Visible = false;
                        }
                        setFourButtonFrameInstanceXSecondValue = true;
                        FourButtonFrameInstanceXSecondValue = 50f;
                        setFourButtonFrameInstanceYSecondValue = true;
                        FourButtonFrameInstanceYSecondValue = 100f;
                        setSevenButtonFrameInstanceCurrentRotatedStateSecondValue = true;
                        SevenButtonFrameInstanceCurrentRotatedStateSecondValue = AbbatoirIntergrade.GumRuntimes.SevenButtonFrameRuntime.Rotated.Right;
                        if (interpolationValue >= 1)
                        {
                            this.SevenButtonFrameInstance.Visible = true;
                        }
                        setSevenButtonFrameInstanceXSecondValue = true;
                        SevenButtonFrameInstanceXSecondValue = 9.088921f;
                        setSevenButtonFrameInstanceYSecondValue = true;
                        SevenButtonFrameInstanceYSecondValue = 116.5294f;
                        if (interpolationValue >= 1)
                        {
                            this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        break;
                }
                if (setBuildButtonInstance0XFirstValue && setBuildButtonInstance0XSecondValue)
                {
                    BuildButtonInstance0.X = BuildButtonInstance0XFirstValue * (1 - interpolationValue) + BuildButtonInstance0XSecondValue * interpolationValue;
                }
                if (setBuildButtonInstance0YFirstValue && setBuildButtonInstance0YSecondValue)
                {
                    BuildButtonInstance0.Y = BuildButtonInstance0YFirstValue * (1 - interpolationValue) + BuildButtonInstance0YSecondValue * interpolationValue;
                }
                if (setBuildButtonInstance1XFirstValue && setBuildButtonInstance1XSecondValue)
                {
                    BuildButtonInstance1.X = BuildButtonInstance1XFirstValue * (1 - interpolationValue) + BuildButtonInstance1XSecondValue * interpolationValue;
                }
                if (setBuildButtonInstance1YFirstValue && setBuildButtonInstance1YSecondValue)
                {
                    BuildButtonInstance1.Y = BuildButtonInstance1YFirstValue * (1 - interpolationValue) + BuildButtonInstance1YSecondValue * interpolationValue;
                }
                if (setBuildButtonInstance2XFirstValue && setBuildButtonInstance2XSecondValue)
                {
                    BuildButtonInstance2.X = BuildButtonInstance2XFirstValue * (1 - interpolationValue) + BuildButtonInstance2XSecondValue * interpolationValue;
                }
                if (setBuildButtonInstance2YFirstValue && setBuildButtonInstance2YSecondValue)
                {
                    BuildButtonInstance2.Y = BuildButtonInstance2YFirstValue * (1 - interpolationValue) + BuildButtonInstance2YSecondValue * interpolationValue;
                }
                if (setBuildButtonInstance3XFirstValue && setBuildButtonInstance3XSecondValue)
                {
                    BuildButtonInstance3.X = BuildButtonInstance3XFirstValue * (1 - interpolationValue) + BuildButtonInstance3XSecondValue * interpolationValue;
                }
                if (setBuildButtonInstance3YFirstValue && setBuildButtonInstance3YSecondValue)
                {
                    BuildButtonInstance3.Y = BuildButtonInstance3YFirstValue * (1 - interpolationValue) + BuildButtonInstance3YSecondValue * interpolationValue;
                }
                if (setBuildButtonInstance4XFirstValue && setBuildButtonInstance4XSecondValue)
                {
                    BuildButtonInstance4.X = BuildButtonInstance4XFirstValue * (1 - interpolationValue) + BuildButtonInstance4XSecondValue * interpolationValue;
                }
                if (setBuildButtonInstance4YFirstValue && setBuildButtonInstance4YSecondValue)
                {
                    BuildButtonInstance4.Y = BuildButtonInstance4YFirstValue * (1 - interpolationValue) + BuildButtonInstance4YSecondValue * interpolationValue;
                }
                if (setBuildButtonInstance5HeightFirstValue && setBuildButtonInstance5HeightSecondValue)
                {
                    BuildButtonInstance5.Height = BuildButtonInstance5HeightFirstValue * (1 - interpolationValue) + BuildButtonInstance5HeightSecondValue * interpolationValue;
                }
                if (setBuildButtonInstance5WidthFirstValue && setBuildButtonInstance5WidthSecondValue)
                {
                    BuildButtonInstance5.Width = BuildButtonInstance5WidthFirstValue * (1 - interpolationValue) + BuildButtonInstance5WidthSecondValue * interpolationValue;
                }
                if (setBuildButtonInstance5XFirstValue && setBuildButtonInstance5XSecondValue)
                {
                    BuildButtonInstance5.X = BuildButtonInstance5XFirstValue * (1 - interpolationValue) + BuildButtonInstance5XSecondValue * interpolationValue;
                }
                if (setBuildButtonInstance5YFirstValue && setBuildButtonInstance5YSecondValue)
                {
                    BuildButtonInstance5.Y = BuildButtonInstance5YFirstValue * (1 - interpolationValue) + BuildButtonInstance5YSecondValue * interpolationValue;
                }
                if (setBuildButtonInstance6HeightFirstValue && setBuildButtonInstance6HeightSecondValue)
                {
                    BuildButtonInstance6.Height = BuildButtonInstance6HeightFirstValue * (1 - interpolationValue) + BuildButtonInstance6HeightSecondValue * interpolationValue;
                }
                if (setBuildButtonInstance6WidthFirstValue && setBuildButtonInstance6WidthSecondValue)
                {
                    BuildButtonInstance6.Width = BuildButtonInstance6WidthFirstValue * (1 - interpolationValue) + BuildButtonInstance6WidthSecondValue * interpolationValue;
                }
                if (setBuildButtonInstance6XFirstValue && setBuildButtonInstance6XSecondValue)
                {
                    BuildButtonInstance6.X = BuildButtonInstance6XFirstValue * (1 - interpolationValue) + BuildButtonInstance6XSecondValue * interpolationValue;
                }
                if (setBuildButtonInstance6YFirstValue && setBuildButtonInstance6YSecondValue)
                {
                    BuildButtonInstance6.Y = BuildButtonInstance6YFirstValue * (1 - interpolationValue) + BuildButtonInstance6YSecondValue * interpolationValue;
                }
                if (setFourButtonFrameInstanceCurrentRotatedStateFirstValue && setFourButtonFrameInstanceCurrentRotatedStateSecondValue)
                {
                    FourButtonFrameInstance.InterpolateBetween(FourButtonFrameInstanceCurrentRotatedStateFirstValue, FourButtonFrameInstanceCurrentRotatedStateSecondValue, interpolationValue);
                }
                if (setFourButtonFrameInstanceXFirstValue && setFourButtonFrameInstanceXSecondValue)
                {
                    FourButtonFrameInstance.X = FourButtonFrameInstanceXFirstValue * (1 - interpolationValue) + FourButtonFrameInstanceXSecondValue * interpolationValue;
                }
                if (setFourButtonFrameInstanceYFirstValue && setFourButtonFrameInstanceYSecondValue)
                {
                    FourButtonFrameInstance.Y = FourButtonFrameInstanceYFirstValue * (1 - interpolationValue) + FourButtonFrameInstanceYSecondValue * interpolationValue;
                }
                if (setSevenButtonFrameInstanceXFirstValue && setSevenButtonFrameInstanceXSecondValue)
                {
                    SevenButtonFrameInstance.X = SevenButtonFrameInstanceXFirstValue * (1 - interpolationValue) + SevenButtonFrameInstanceXSecondValue * interpolationValue;
                }
                if (setSevenButtonFrameInstanceYFirstValue && setSevenButtonFrameInstanceYSecondValue)
                {
                    SevenButtonFrameInstance.Y = SevenButtonFrameInstanceYFirstValue * (1 - interpolationValue) + SevenButtonFrameInstanceYSecondValue * interpolationValue;
                }
                if (setSevenButtonFrameInstanceCurrentRotatedStateFirstValue && setSevenButtonFrameInstanceCurrentRotatedStateSecondValue)
                {
                    SevenButtonFrameInstance.InterpolateBetween(SevenButtonFrameInstanceCurrentRotatedStateFirstValue, SevenButtonFrameInstanceCurrentRotatedStateSecondValue, interpolationValue);
                }
                if (interpolationValue < 1)
                {
                    mCurrentCapacityState = firstState;
                }
                else
                {
                    mCurrentCapacityState = secondState;
                }
            }
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.BuildMenuRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.BuildMenuRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.BuildMenuRuntime.Capacity fromState,AbbatoirIntergrade.GumRuntimes.BuildMenuRuntime.Capacity toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Capacity toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "Capacity").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentCapacityState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (Capacity toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentCapacityState = toState;
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
                FourButtonFrameInstance.StopAnimations();
                SevenButtonFrameInstance.StopAnimations();
                BuildButtonInstance0.StopAnimations();
                BuildButtonInstance1.StopAnimations();
                BuildButtonInstance2.StopAnimations();
                BuildButtonInstance3.StopAnimations();
                BuildButtonInstance4.StopAnimations();
                BuildButtonInstance5.StopAnimations();
                BuildButtonInstance6.StopAnimations();
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
                            Name = "FourButtonFrameInstance.Height",
                            Type = "float",
                            Value = FourButtonFrameInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = FourButtonFrameInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.Visible",
                            Type = "bool",
                            Value = FourButtonFrameInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.Width",
                            Type = "float",
                            Value = FourButtonFrameInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = FourButtonFrameInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.X",
                            Type = "float",
                            Value = FourButtonFrameInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = FourButtonFrameInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.X Units",
                            Type = "PositionUnitType",
                            Value = FourButtonFrameInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.Y",
                            Type = "float",
                            Value = FourButtonFrameInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = FourButtonFrameInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = FourButtonFrameInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.Height",
                            Type = "float",
                            Value = SevenButtonFrameInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.Visible",
                            Type = "bool",
                            Value = SevenButtonFrameInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.Width",
                            Type = "float",
                            Value = SevenButtonFrameInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.X",
                            Type = "float",
                            Value = SevenButtonFrameInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = SevenButtonFrameInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.Y",
                            Type = "float",
                            Value = SevenButtonFrameInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = SevenButtonFrameInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance0.X",
                            Type = "float",
                            Value = BuildButtonInstance0.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance0.X Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance0.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance0.Y",
                            Type = "float",
                            Value = BuildButtonInstance0.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance0.Y Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance0.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance1.X",
                            Type = "float",
                            Value = BuildButtonInstance1.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance1.X Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance1.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance1.Y",
                            Type = "float",
                            Value = BuildButtonInstance1.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance1.Y Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance1.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance2.X",
                            Type = "float",
                            Value = BuildButtonInstance2.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance2.X Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance2.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance2.Y",
                            Type = "float",
                            Value = BuildButtonInstance2.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance2.Y Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance2.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance3.X",
                            Type = "float",
                            Value = BuildButtonInstance3.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance3.X Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance3.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance3.Y",
                            Type = "float",
                            Value = BuildButtonInstance3.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance3.Y Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance3.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance4.Visible",
                            Type = "bool",
                            Value = BuildButtonInstance4.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance4.X Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance4.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance4.Y Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance4.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Visible",
                            Type = "bool",
                            Value = BuildButtonInstance5.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.X Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance5.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Y Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance5.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.Visible",
                            Type = "bool",
                            Value = BuildButtonInstance6.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.X Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance6.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.Y Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance6.YUnits
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
                            Value = Height + 50f
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
                            Value = Width + 50f
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
                            Name = "X",
                            Type = "float",
                            Value = X + -1280f
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
                            Value = Y + 720f
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
                            Name = "FourButtonFrameInstance.Height",
                            Type = "float",
                            Value = FourButtonFrameInstance.Height + 53.646f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = FourButtonFrameInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.Visible",
                            Type = "bool",
                            Value = FourButtonFrameInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.Width",
                            Type = "float",
                            Value = FourButtonFrameInstance.Width + 23.4f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = FourButtonFrameInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.X",
                            Type = "float",
                            Value = FourButtonFrameInstance.X + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = FourButtonFrameInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.X Units",
                            Type = "PositionUnitType",
                            Value = FourButtonFrameInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.Y",
                            Type = "float",
                            Value = FourButtonFrameInstance.Y + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = FourButtonFrameInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = FourButtonFrameInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.Height",
                            Type = "float",
                            Value = SevenButtonFrameInstance.Height + 88f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.Visible",
                            Type = "bool",
                            Value = SevenButtonFrameInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.Width",
                            Type = "float",
                            Value = SevenButtonFrameInstance.Width + 19.15f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.X",
                            Type = "float",
                            Value = SevenButtonFrameInstance.X + 47.50298f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = SevenButtonFrameInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.Y",
                            Type = "float",
                            Value = SevenButtonFrameInstance.Y + 100.8836f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = SevenButtonFrameInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance0.X",
                            Type = "float",
                            Value = BuildButtonInstance0.X + 43.29829f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance0.X Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance0.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance0.Y",
                            Type = "float",
                            Value = BuildButtonInstance0.Y + 67.83752f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance0.Y Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance0.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance1.X",
                            Type = "float",
                            Value = BuildButtonInstance1.X + 33.23347f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance1.X Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance1.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance1.Y",
                            Type = "float",
                            Value = BuildButtonInstance1.Y + 51.25159f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance1.Y Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance1.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance2.X",
                            Type = "float",
                            Value = BuildButtonInstance2.X + 51.49597f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance2.X Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance2.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance2.Y",
                            Type = "float",
                            Value = BuildButtonInstance2.Y + 51.31417f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance2.Y Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance2.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance3.X",
                            Type = "float",
                            Value = BuildButtonInstance3.X + 42.26307f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance3.X Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance3.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance3.Y",
                            Type = "float",
                            Value = BuildButtonInstance3.Y + 34.15827f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance3.Y Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance3.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance4.Visible",
                            Type = "bool",
                            Value = BuildButtonInstance4.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance4.X Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance4.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance4.Y Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance4.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Visible",
                            Type = "bool",
                            Value = BuildButtonInstance5.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.X Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance5.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Y Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance5.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.Visible",
                            Type = "bool",
                            Value = BuildButtonInstance6.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.X Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance6.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.Y Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance6.YUnits
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (Capacity state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  Capacity.Four:
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
                            Name = "Y Origin",
                            Type = "VerticalAlignment",
                            Value = YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.RotatedState",
                            Type = "RotatedState",
                            Value = FourButtonFrameInstance.CurrentRotatedState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.Visible",
                            Type = "bool",
                            Value = FourButtonFrameInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.X",
                            Type = "float",
                            Value = FourButtonFrameInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.Y",
                            Type = "float",
                            Value = FourButtonFrameInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.Visible",
                            Type = "bool",
                            Value = SevenButtonFrameInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.X",
                            Type = "float",
                            Value = SevenButtonFrameInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.Y",
                            Type = "float",
                            Value = SevenButtonFrameInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance0.X",
                            Type = "float",
                            Value = BuildButtonInstance0.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance0.Y",
                            Type = "float",
                            Value = BuildButtonInstance0.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance1.X",
                            Type = "float",
                            Value = BuildButtonInstance1.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance1.X Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance1.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance1.Y",
                            Type = "float",
                            Value = BuildButtonInstance1.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance2.X",
                            Type = "float",
                            Value = BuildButtonInstance2.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance2.Y",
                            Type = "float",
                            Value = BuildButtonInstance2.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance3.X",
                            Type = "float",
                            Value = BuildButtonInstance3.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance3.Y",
                            Type = "float",
                            Value = BuildButtonInstance3.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance4.Visible",
                            Type = "bool",
                            Value = BuildButtonInstance4.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance4.X",
                            Type = "float",
                            Value = BuildButtonInstance4.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance4.Y",
                            Type = "float",
                            Value = BuildButtonInstance4.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Height",
                            Type = "float",
                            Value = BuildButtonInstance5.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Visible",
                            Type = "bool",
                            Value = BuildButtonInstance5.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Width",
                            Type = "float",
                            Value = BuildButtonInstance5.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.X",
                            Type = "float",
                            Value = BuildButtonInstance5.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Y",
                            Type = "float",
                            Value = BuildButtonInstance5.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.Height",
                            Type = "float",
                            Value = BuildButtonInstance6.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.Visible",
                            Type = "bool",
                            Value = BuildButtonInstance6.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.Width",
                            Type = "float",
                            Value = BuildButtonInstance6.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.X",
                            Type = "float",
                            Value = BuildButtonInstance6.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.Y",
                            Type = "float",
                            Value = BuildButtonInstance6.Y
                        }
                        );
                        break;
                    case  Capacity.FourLeft:
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
                            Name = "Y Origin",
                            Type = "VerticalAlignment",
                            Value = YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.RotatedState",
                            Type = "RotatedState",
                            Value = FourButtonFrameInstance.CurrentRotatedState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.Visible",
                            Type = "bool",
                            Value = FourButtonFrameInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.X",
                            Type = "float",
                            Value = FourButtonFrameInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.Y",
                            Type = "float",
                            Value = FourButtonFrameInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.Visible",
                            Type = "bool",
                            Value = SevenButtonFrameInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.X",
                            Type = "float",
                            Value = SevenButtonFrameInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.Y",
                            Type = "float",
                            Value = SevenButtonFrameInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance0.X",
                            Type = "float",
                            Value = BuildButtonInstance0.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance0.Y",
                            Type = "float",
                            Value = BuildButtonInstance0.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance1.X",
                            Type = "float",
                            Value = BuildButtonInstance1.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance1.X Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance1.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance1.Y",
                            Type = "float",
                            Value = BuildButtonInstance1.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance2.X",
                            Type = "float",
                            Value = BuildButtonInstance2.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance2.Y",
                            Type = "float",
                            Value = BuildButtonInstance2.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance3.X",
                            Type = "float",
                            Value = BuildButtonInstance3.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance3.Y",
                            Type = "float",
                            Value = BuildButtonInstance3.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance4.Visible",
                            Type = "bool",
                            Value = BuildButtonInstance4.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance4.X",
                            Type = "float",
                            Value = BuildButtonInstance4.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance4.Y",
                            Type = "float",
                            Value = BuildButtonInstance4.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Height",
                            Type = "float",
                            Value = BuildButtonInstance5.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Visible",
                            Type = "bool",
                            Value = BuildButtonInstance5.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Width",
                            Type = "float",
                            Value = BuildButtonInstance5.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.X",
                            Type = "float",
                            Value = BuildButtonInstance5.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Y",
                            Type = "float",
                            Value = BuildButtonInstance5.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.Height",
                            Type = "float",
                            Value = BuildButtonInstance6.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.Visible",
                            Type = "bool",
                            Value = BuildButtonInstance6.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.Width",
                            Type = "float",
                            Value = BuildButtonInstance6.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.X",
                            Type = "float",
                            Value = BuildButtonInstance6.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.Y",
                            Type = "float",
                            Value = BuildButtonInstance6.Y
                        }
                        );
                        break;
                    case  Capacity.FourRight:
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
                            Name = "Y Origin",
                            Type = "VerticalAlignment",
                            Value = YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.RotatedState",
                            Type = "RotatedState",
                            Value = FourButtonFrameInstance.CurrentRotatedState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.Visible",
                            Type = "bool",
                            Value = FourButtonFrameInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.X",
                            Type = "float",
                            Value = FourButtonFrameInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.Y",
                            Type = "float",
                            Value = FourButtonFrameInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.Visible",
                            Type = "bool",
                            Value = SevenButtonFrameInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.X",
                            Type = "float",
                            Value = SevenButtonFrameInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.Y",
                            Type = "float",
                            Value = SevenButtonFrameInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance0.X",
                            Type = "float",
                            Value = BuildButtonInstance0.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance0.Y",
                            Type = "float",
                            Value = BuildButtonInstance0.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance1.X",
                            Type = "float",
                            Value = BuildButtonInstance1.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance1.X Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance1.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance1.Y",
                            Type = "float",
                            Value = BuildButtonInstance1.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance2.X",
                            Type = "float",
                            Value = BuildButtonInstance2.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance2.Y",
                            Type = "float",
                            Value = BuildButtonInstance2.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance3.X",
                            Type = "float",
                            Value = BuildButtonInstance3.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance3.Y",
                            Type = "float",
                            Value = BuildButtonInstance3.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance4.Visible",
                            Type = "bool",
                            Value = BuildButtonInstance4.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance4.X",
                            Type = "float",
                            Value = BuildButtonInstance4.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance4.Y",
                            Type = "float",
                            Value = BuildButtonInstance4.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Height",
                            Type = "float",
                            Value = BuildButtonInstance5.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Visible",
                            Type = "bool",
                            Value = BuildButtonInstance5.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Width",
                            Type = "float",
                            Value = BuildButtonInstance5.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.X",
                            Type = "float",
                            Value = BuildButtonInstance5.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Y",
                            Type = "float",
                            Value = BuildButtonInstance5.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.Height",
                            Type = "float",
                            Value = BuildButtonInstance6.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.Visible",
                            Type = "bool",
                            Value = BuildButtonInstance6.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.Width",
                            Type = "float",
                            Value = BuildButtonInstance6.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.X",
                            Type = "float",
                            Value = BuildButtonInstance6.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.Y",
                            Type = "float",
                            Value = BuildButtonInstance6.Y
                        }
                        );
                        break;
                    case  Capacity.Seven:
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
                            Name = "Y Origin",
                            Type = "VerticalAlignment",
                            Value = YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.Visible",
                            Type = "bool",
                            Value = FourButtonFrameInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.X",
                            Type = "float",
                            Value = FourButtonFrameInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.Y",
                            Type = "float",
                            Value = FourButtonFrameInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.RotatedState",
                            Type = "RotatedState",
                            Value = SevenButtonFrameInstance.CurrentRotatedState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.Visible",
                            Type = "bool",
                            Value = SevenButtonFrameInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.X",
                            Type = "float",
                            Value = SevenButtonFrameInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.Y",
                            Type = "float",
                            Value = SevenButtonFrameInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance0.X",
                            Type = "float",
                            Value = BuildButtonInstance0.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance0.Y",
                            Type = "float",
                            Value = BuildButtonInstance0.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance1.X",
                            Type = "float",
                            Value = BuildButtonInstance1.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance1.X Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance1.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance1.Y",
                            Type = "float",
                            Value = BuildButtonInstance1.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance2.X",
                            Type = "float",
                            Value = BuildButtonInstance2.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance2.Y",
                            Type = "float",
                            Value = BuildButtonInstance2.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance3.X",
                            Type = "float",
                            Value = BuildButtonInstance3.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance3.Y",
                            Type = "float",
                            Value = BuildButtonInstance3.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance4.Visible",
                            Type = "bool",
                            Value = BuildButtonInstance4.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance4.X",
                            Type = "float",
                            Value = BuildButtonInstance4.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance4.Y",
                            Type = "float",
                            Value = BuildButtonInstance4.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Height",
                            Type = "float",
                            Value = BuildButtonInstance5.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Visible",
                            Type = "bool",
                            Value = BuildButtonInstance5.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Width",
                            Type = "float",
                            Value = BuildButtonInstance5.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.X",
                            Type = "float",
                            Value = BuildButtonInstance5.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.X Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance5.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Y",
                            Type = "float",
                            Value = BuildButtonInstance5.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Y Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance5.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.Height",
                            Type = "float",
                            Value = BuildButtonInstance6.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.Visible",
                            Type = "bool",
                            Value = BuildButtonInstance6.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.Width",
                            Type = "float",
                            Value = BuildButtonInstance6.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.X",
                            Type = "float",
                            Value = BuildButtonInstance6.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.X Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance6.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.Y",
                            Type = "float",
                            Value = BuildButtonInstance6.Y
                        }
                        );
                        break;
                    case  Capacity.SevenLeft:
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
                            Name = "Y Origin",
                            Type = "VerticalAlignment",
                            Value = YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.Visible",
                            Type = "bool",
                            Value = FourButtonFrameInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.X",
                            Type = "float",
                            Value = FourButtonFrameInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.Y",
                            Type = "float",
                            Value = FourButtonFrameInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.RotatedState",
                            Type = "RotatedState",
                            Value = SevenButtonFrameInstance.CurrentRotatedState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.Visible",
                            Type = "bool",
                            Value = SevenButtonFrameInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.X",
                            Type = "float",
                            Value = SevenButtonFrameInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.Y",
                            Type = "float",
                            Value = SevenButtonFrameInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance0.X",
                            Type = "float",
                            Value = BuildButtonInstance0.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance0.Y",
                            Type = "float",
                            Value = BuildButtonInstance0.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance1.X",
                            Type = "float",
                            Value = BuildButtonInstance1.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance1.X Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance1.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance1.Y",
                            Type = "float",
                            Value = BuildButtonInstance1.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance2.X",
                            Type = "float",
                            Value = BuildButtonInstance2.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance2.Y",
                            Type = "float",
                            Value = BuildButtonInstance2.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance3.X",
                            Type = "float",
                            Value = BuildButtonInstance3.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance3.Y",
                            Type = "float",
                            Value = BuildButtonInstance3.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance4.Visible",
                            Type = "bool",
                            Value = BuildButtonInstance4.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance4.X",
                            Type = "float",
                            Value = BuildButtonInstance4.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance4.Y",
                            Type = "float",
                            Value = BuildButtonInstance4.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Height",
                            Type = "float",
                            Value = BuildButtonInstance5.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Visible",
                            Type = "bool",
                            Value = BuildButtonInstance5.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Width",
                            Type = "float",
                            Value = BuildButtonInstance5.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.X",
                            Type = "float",
                            Value = BuildButtonInstance5.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.X Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance5.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Y",
                            Type = "float",
                            Value = BuildButtonInstance5.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Y Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance5.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.Height",
                            Type = "float",
                            Value = BuildButtonInstance6.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.Visible",
                            Type = "bool",
                            Value = BuildButtonInstance6.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.Width",
                            Type = "float",
                            Value = BuildButtonInstance6.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.X",
                            Type = "float",
                            Value = BuildButtonInstance6.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.X Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance6.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.Y",
                            Type = "float",
                            Value = BuildButtonInstance6.Y
                        }
                        );
                        break;
                    case  Capacity.SevenRight:
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
                            Name = "Y Origin",
                            Type = "VerticalAlignment",
                            Value = YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.Visible",
                            Type = "bool",
                            Value = FourButtonFrameInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.X",
                            Type = "float",
                            Value = FourButtonFrameInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.Y",
                            Type = "float",
                            Value = FourButtonFrameInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.RotatedState",
                            Type = "RotatedState",
                            Value = SevenButtonFrameInstance.CurrentRotatedState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.Visible",
                            Type = "bool",
                            Value = SevenButtonFrameInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.X",
                            Type = "float",
                            Value = SevenButtonFrameInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.Y",
                            Type = "float",
                            Value = SevenButtonFrameInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance0.X",
                            Type = "float",
                            Value = BuildButtonInstance0.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance0.Y",
                            Type = "float",
                            Value = BuildButtonInstance0.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance1.X",
                            Type = "float",
                            Value = BuildButtonInstance1.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance1.X Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance1.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance1.Y",
                            Type = "float",
                            Value = BuildButtonInstance1.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance2.X",
                            Type = "float",
                            Value = BuildButtonInstance2.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance2.Y",
                            Type = "float",
                            Value = BuildButtonInstance2.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance3.X",
                            Type = "float",
                            Value = BuildButtonInstance3.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance3.Y",
                            Type = "float",
                            Value = BuildButtonInstance3.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance4.Visible",
                            Type = "bool",
                            Value = BuildButtonInstance4.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance4.X",
                            Type = "float",
                            Value = BuildButtonInstance4.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance4.Y",
                            Type = "float",
                            Value = BuildButtonInstance4.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Height",
                            Type = "float",
                            Value = BuildButtonInstance5.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Visible",
                            Type = "bool",
                            Value = BuildButtonInstance5.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Width",
                            Type = "float",
                            Value = BuildButtonInstance5.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.X",
                            Type = "float",
                            Value = BuildButtonInstance5.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.X Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance5.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Y",
                            Type = "float",
                            Value = BuildButtonInstance5.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Y Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance5.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.Height",
                            Type = "float",
                            Value = BuildButtonInstance6.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.Visible",
                            Type = "bool",
                            Value = BuildButtonInstance6.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.Width",
                            Type = "float",
                            Value = BuildButtonInstance6.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.X",
                            Type = "float",
                            Value = BuildButtonInstance6.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.X Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance6.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.Y",
                            Type = "float",
                            Value = BuildButtonInstance6.Y
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (Capacity state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  Capacity.Four:
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
                            Name = "Y Origin",
                            Type = "VerticalAlignment",
                            Value = YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.RotatedState",
                            Type = "RotatedState",
                            Value = FourButtonFrameInstance.CurrentRotatedState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.Visible",
                            Type = "bool",
                            Value = FourButtonFrameInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.X",
                            Type = "float",
                            Value = FourButtonFrameInstance.X + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.Y",
                            Type = "float",
                            Value = FourButtonFrameInstance.Y + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.Visible",
                            Type = "bool",
                            Value = SevenButtonFrameInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.X",
                            Type = "float",
                            Value = SevenButtonFrameInstance.X + 47.50298f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.Y",
                            Type = "float",
                            Value = SevenButtonFrameInstance.Y + 100.8836f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance0.X",
                            Type = "float",
                            Value = BuildButtonInstance0.X + 43.19118f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance0.Y",
                            Type = "float",
                            Value = BuildButtonInstance0.Y + 67.92753f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance1.X",
                            Type = "float",
                            Value = BuildButtonInstance1.X + 34.37128f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance1.X Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance1.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance1.Y",
                            Type = "float",
                            Value = BuildButtonInstance1.Y + 51.32274f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance2.X",
                            Type = "float",
                            Value = BuildButtonInstance2.X + 52.03481f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance2.Y",
                            Type = "float",
                            Value = BuildButtonInstance2.Y + 51.35582f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance3.X",
                            Type = "float",
                            Value = BuildButtonInstance3.X + 43.17259f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance3.Y",
                            Type = "float",
                            Value = BuildButtonInstance3.Y + 34.02776f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance4.Visible",
                            Type = "bool",
                            Value = BuildButtonInstance4.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance4.X",
                            Type = "float",
                            Value = BuildButtonInstance4.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance4.Y",
                            Type = "float",
                            Value = BuildButtonInstance4.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Height",
                            Type = "float",
                            Value = BuildButtonInstance5.Height + 24.47f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Visible",
                            Type = "bool",
                            Value = BuildButtonInstance5.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Width",
                            Type = "float",
                            Value = BuildButtonInstance5.Width + 13.647f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.X",
                            Type = "float",
                            Value = BuildButtonInstance5.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Y",
                            Type = "float",
                            Value = BuildButtonInstance5.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.Height",
                            Type = "float",
                            Value = BuildButtonInstance6.Height + 24.47f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.Visible",
                            Type = "bool",
                            Value = BuildButtonInstance6.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.Width",
                            Type = "float",
                            Value = BuildButtonInstance6.Width + 13.647f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.X",
                            Type = "float",
                            Value = BuildButtonInstance6.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.Y",
                            Type = "float",
                            Value = BuildButtonInstance6.Y + 0f
                        }
                        );
                        break;
                    case  Capacity.FourLeft:
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
                            Name = "Y Origin",
                            Type = "VerticalAlignment",
                            Value = YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.RotatedState",
                            Type = "RotatedState",
                            Value = FourButtonFrameInstance.CurrentRotatedState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.Visible",
                            Type = "bool",
                            Value = FourButtonFrameInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.X",
                            Type = "float",
                            Value = FourButtonFrameInstance.X + 81.64063f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.Y",
                            Type = "float",
                            Value = FourButtonFrameInstance.Y + 83.00002f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.Visible",
                            Type = "bool",
                            Value = SevenButtonFrameInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.X",
                            Type = "float",
                            Value = SevenButtonFrameInstance.X + 47.50298f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.Y",
                            Type = "float",
                            Value = SevenButtonFrameInstance.Y + 100.8836f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance0.X",
                            Type = "float",
                            Value = BuildButtonInstance0.X + 82.09743f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance0.Y",
                            Type = "float",
                            Value = BuildButtonInstance0.Y + 37.92752f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance1.X",
                            Type = "float",
                            Value = BuildButtonInstance1.X + 72.73f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance1.X Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance1.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance1.Y",
                            Type = "float",
                            Value = BuildButtonInstance1.Y + 53.82274f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance2.X",
                            Type = "float",
                            Value = BuildButtonInstance2.X + 72.73793f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance2.Y",
                            Type = "float",
                            Value = BuildButtonInstance2.Y + 21.95767f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance3.X",
                            Type = "float",
                            Value = BuildButtonInstance3.X + 63.01634f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance3.Y",
                            Type = "float",
                            Value = BuildButtonInstance3.Y + 37.91665f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance4.Visible",
                            Type = "bool",
                            Value = BuildButtonInstance4.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance4.X",
                            Type = "float",
                            Value = BuildButtonInstance4.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance4.Y",
                            Type = "float",
                            Value = BuildButtonInstance4.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Height",
                            Type = "float",
                            Value = BuildButtonInstance5.Height + 24.47f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Visible",
                            Type = "bool",
                            Value = BuildButtonInstance5.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Width",
                            Type = "float",
                            Value = BuildButtonInstance5.Width + 13.647f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.X",
                            Type = "float",
                            Value = BuildButtonInstance5.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Y",
                            Type = "float",
                            Value = BuildButtonInstance5.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.Height",
                            Type = "float",
                            Value = BuildButtonInstance6.Height + 24.47f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.Visible",
                            Type = "bool",
                            Value = BuildButtonInstance6.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.Width",
                            Type = "float",
                            Value = BuildButtonInstance6.Width + 13.647f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.X",
                            Type = "float",
                            Value = BuildButtonInstance6.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.Y",
                            Type = "float",
                            Value = BuildButtonInstance6.Y + 0f
                        }
                        );
                        break;
                    case  Capacity.FourRight:
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
                            Name = "Y Origin",
                            Type = "VerticalAlignment",
                            Value = YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.RotatedState",
                            Type = "RotatedState",
                            Value = FourButtonFrameInstance.CurrentRotatedState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.Visible",
                            Type = "bool",
                            Value = FourButtonFrameInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.X",
                            Type = "float",
                            Value = FourButtonFrameInstance.X + 11.69791f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.Y",
                            Type = "float",
                            Value = FourButtonFrameInstance.Y + 82.79628f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.Visible",
                            Type = "bool",
                            Value = SevenButtonFrameInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.X",
                            Type = "float",
                            Value = SevenButtonFrameInstance.X + 47.50298f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.Y",
                            Type = "float",
                            Value = SevenButtonFrameInstance.Y + 100.8836f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance0.X",
                            Type = "float",
                            Value = BuildButtonInstance0.X + 4.363056f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance0.Y",
                            Type = "float",
                            Value = BuildButtonInstance0.Y + 37.92752f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance1.X",
                            Type = "float",
                            Value = BuildButtonInstance1.X + 13.73f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance1.X Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance1.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance1.Y",
                            Type = "float",
                            Value = BuildButtonInstance1.Y + 53.56481f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance2.X",
                            Type = "float",
                            Value = BuildButtonInstance2.X + 13.73f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance2.Y",
                            Type = "float",
                            Value = BuildButtonInstance2.Y + 22.05026f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance3.X",
                            Type = "float",
                            Value = BuildButtonInstance3.X + 23.38464f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance3.Y",
                            Type = "float",
                            Value = BuildButtonInstance3.Y + 37.7976f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance4.Visible",
                            Type = "bool",
                            Value = BuildButtonInstance4.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance4.X",
                            Type = "float",
                            Value = BuildButtonInstance4.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance4.Y",
                            Type = "float",
                            Value = BuildButtonInstance4.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Height",
                            Type = "float",
                            Value = BuildButtonInstance5.Height + 24.47f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Visible",
                            Type = "bool",
                            Value = BuildButtonInstance5.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Width",
                            Type = "float",
                            Value = BuildButtonInstance5.Width + 13.647f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.X",
                            Type = "float",
                            Value = BuildButtonInstance5.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Y",
                            Type = "float",
                            Value = BuildButtonInstance5.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.Height",
                            Type = "float",
                            Value = BuildButtonInstance6.Height + 24.47f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.Visible",
                            Type = "bool",
                            Value = BuildButtonInstance6.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.Width",
                            Type = "float",
                            Value = BuildButtonInstance6.Width + 13.647f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.X",
                            Type = "float",
                            Value = BuildButtonInstance6.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.Y",
                            Type = "float",
                            Value = BuildButtonInstance6.Y + 0f
                        }
                        );
                        break;
                    case  Capacity.Seven:
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
                            Name = "Y Origin",
                            Type = "VerticalAlignment",
                            Value = YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.Visible",
                            Type = "bool",
                            Value = FourButtonFrameInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.X",
                            Type = "float",
                            Value = FourButtonFrameInstance.X + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.Y",
                            Type = "float",
                            Value = FourButtonFrameInstance.Y + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.RotatedState",
                            Type = "RotatedState",
                            Value = SevenButtonFrameInstance.CurrentRotatedState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.Visible",
                            Type = "bool",
                            Value = SevenButtonFrameInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.X",
                            Type = "float",
                            Value = SevenButtonFrameInstance.X + 47.50298f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.Y",
                            Type = "float",
                            Value = SevenButtonFrameInstance.Y + 100.8836f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance0.X",
                            Type = "float",
                            Value = BuildButtonInstance0.X + 43.14814f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance0.Y",
                            Type = "float",
                            Value = BuildButtonInstance0.Y + 68.01085f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance1.X",
                            Type = "float",
                            Value = BuildButtonInstance1.X + 34.26563f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance1.X Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance1.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance1.Y",
                            Type = "float",
                            Value = BuildButtonInstance1.Y + 51.43519f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance2.X",
                            Type = "float",
                            Value = BuildButtonInstance2.X + 52.06459f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance2.Y",
                            Type = "float",
                            Value = BuildButtonInstance2.Y + 51.57408f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance3.X",
                            Type = "float",
                            Value = BuildButtonInstance3.X + 43.15125f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance3.Y",
                            Type = "float",
                            Value = BuildButtonInstance3.Y + 35.08086f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance4.Visible",
                            Type = "bool",
                            Value = BuildButtonInstance4.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance4.X",
                            Type = "float",
                            Value = BuildButtonInstance4.X + 34.29688f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance4.Y",
                            Type = "float",
                            Value = BuildButtonInstance4.Y + 18.35648f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Height",
                            Type = "float",
                            Value = BuildButtonInstance5.Height + 24.47f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Visible",
                            Type = "bool",
                            Value = BuildButtonInstance5.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Width",
                            Type = "float",
                            Value = BuildButtonInstance5.Width + 13.647f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.X",
                            Type = "float",
                            Value = BuildButtonInstance5.X + 52.00523f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.X Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance5.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Y",
                            Type = "float",
                            Value = BuildButtonInstance5.Y + 18.31018f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Y Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance5.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.Height",
                            Type = "float",
                            Value = BuildButtonInstance6.Height + 24.47f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.Visible",
                            Type = "bool",
                            Value = BuildButtonInstance6.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.Width",
                            Type = "float",
                            Value = BuildButtonInstance6.Width + 13.647f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.X",
                            Type = "float",
                            Value = BuildButtonInstance6.X + 43.15125f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.X Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance6.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.Y",
                            Type = "float",
                            Value = BuildButtonInstance6.Y + 1.134257f
                        }
                        );
                        break;
                    case  Capacity.SevenLeft:
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
                            Name = "Y Origin",
                            Type = "VerticalAlignment",
                            Value = YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.Visible",
                            Type = "bool",
                            Value = FourButtonFrameInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.X",
                            Type = "float",
                            Value = FourButtonFrameInstance.X + 56.6875f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.Y",
                            Type = "float",
                            Value = FourButtonFrameInstance.Y + 99.77779f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.RotatedState",
                            Type = "RotatedState",
                            Value = SevenButtonFrameInstance.CurrentRotatedState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.Visible",
                            Type = "bool",
                            Value = SevenButtonFrameInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.X",
                            Type = "float",
                            Value = SevenButtonFrameInstance.X + 60.5945f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.Y",
                            Type = "float",
                            Value = SevenButtonFrameInstance.Y + 116.85f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance0.X",
                            Type = "float",
                            Value = BuildButtonInstance0.X + 82.00231f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance0.Y",
                            Type = "float",
                            Value = BuildButtonInstance0.Y + 37.87195f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance1.X",
                            Type = "float",
                            Value = BuildButtonInstance1.X + 72.76563f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance1.X Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance1.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance1.Y",
                            Type = "float",
                            Value = BuildButtonInstance1.Y + 53.65741f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance2.X",
                            Type = "float",
                            Value = BuildButtonInstance2.X + 72.76772f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance2.Y",
                            Type = "float",
                            Value = BuildButtonInstance2.Y + 21.99075f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance3.X",
                            Type = "float",
                            Value = BuildButtonInstance3.X + 63.51583f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance3.Y",
                            Type = "float",
                            Value = BuildButtonInstance3.Y + 37.90495f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance4.Visible",
                            Type = "bool",
                            Value = BuildButtonInstance4.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance4.X",
                            Type = "float",
                            Value = BuildButtonInstance4.X + 54.14063f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance4.Y",
                            Type = "float",
                            Value = BuildButtonInstance4.Y + 53.63426f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Height",
                            Type = "float",
                            Value = BuildButtonInstance5.Height + 24.47f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Visible",
                            Type = "bool",
                            Value = BuildButtonInstance5.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Width",
                            Type = "float",
                            Value = BuildButtonInstance5.Width + 13.647f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.X",
                            Type = "float",
                            Value = BuildButtonInstance5.X + 54.1146f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.X Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance5.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Y",
                            Type = "float",
                            Value = BuildButtonInstance5.Y + 22.02546f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Y Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance5.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.Height",
                            Type = "float",
                            Value = BuildButtonInstance6.Height + 24.47f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.Visible",
                            Type = "bool",
                            Value = BuildButtonInstance6.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.Width",
                            Type = "float",
                            Value = BuildButtonInstance6.Width + 13.647f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.X",
                            Type = "float",
                            Value = BuildButtonInstance6.X + 44.38015f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.X Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance6.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.Y",
                            Type = "float",
                            Value = BuildButtonInstance6.Y + 37.88074f
                        }
                        );
                        break;
                    case  Capacity.SevenRight:
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
                            Name = "Y Origin",
                            Type = "VerticalAlignment",
                            Value = YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.Visible",
                            Type = "bool",
                            Value = FourButtonFrameInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.X",
                            Type = "float",
                            Value = FourButtonFrameInstance.X + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FourButtonFrameInstance.Y",
                            Type = "float",
                            Value = FourButtonFrameInstance.Y + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.RotatedState",
                            Type = "RotatedState",
                            Value = SevenButtonFrameInstance.CurrentRotatedState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.Visible",
                            Type = "bool",
                            Value = SevenButtonFrameInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.X",
                            Type = "float",
                            Value = SevenButtonFrameInstance.X + 9.088921f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SevenButtonFrameInstance.Y",
                            Type = "float",
                            Value = SevenButtonFrameInstance.Y + 116.5294f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance0.X",
                            Type = "float",
                            Value = BuildButtonInstance0.X + 4.293975f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance0.Y",
                            Type = "float",
                            Value = BuildButtonInstance0.Y + 37.88f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance1.X",
                            Type = "float",
                            Value = BuildButtonInstance1.X + 13.57813f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance1.X Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance1.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance1.Y",
                            Type = "float",
                            Value = BuildButtonInstance1.Y + 53.87964f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance2.X",
                            Type = "float",
                            Value = BuildButtonInstance2.X + 13.61667f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance2.Y",
                            Type = "float",
                            Value = BuildButtonInstance2.Y + 21.90742f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance3.X",
                            Type = "float",
                            Value = BuildButtonInstance3.X + 22.90776f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance3.Y",
                            Type = "float",
                            Value = BuildButtonInstance3.Y + 37.90197f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance4.Visible",
                            Type = "bool",
                            Value = BuildButtonInstance4.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance4.X",
                            Type = "float",
                            Value = BuildButtonInstance4.X + 32.28125f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance4.Y",
                            Type = "float",
                            Value = BuildButtonInstance4.Y + 53.74537f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Height",
                            Type = "float",
                            Value = BuildButtonInstance5.Height + 24.47f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Visible",
                            Type = "bool",
                            Value = BuildButtonInstance5.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Width",
                            Type = "float",
                            Value = BuildButtonInstance5.Width + 13.647f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.X",
                            Type = "float",
                            Value = BuildButtonInstance5.X + 32.29986f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.X Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance5.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Y",
                            Type = "float",
                            Value = BuildButtonInstance5.Y + 22.04827f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance5.Y Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance5.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.Height",
                            Type = "float",
                            Value = BuildButtonInstance6.Height + 24.47f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.Visible",
                            Type = "bool",
                            Value = BuildButtonInstance6.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.Width",
                            Type = "float",
                            Value = BuildButtonInstance6.Width + 13.647f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.X",
                            Type = "float",
                            Value = BuildButtonInstance6.X + 41.88341f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.X Units",
                            Type = "PositionUnitType",
                            Value = BuildButtonInstance6.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildButtonInstance6.Y",
                            Type = "float",
                            Value = BuildButtonInstance6.Y + 37.8168f
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
                    else if (category.Name == "Capacity")
                    {
                        if(state.Name == "Four") this.mCurrentCapacityState = Capacity.Four;
                        if(state.Name == "FourLeft") this.mCurrentCapacityState = Capacity.FourLeft;
                        if(state.Name == "FourRight") this.mCurrentCapacityState = Capacity.FourRight;
                        if(state.Name == "Seven") this.mCurrentCapacityState = Capacity.Seven;
                        if(state.Name == "SevenLeft") this.mCurrentCapacityState = Capacity.SevenLeft;
                        if(state.Name == "SevenRight") this.mCurrentCapacityState = Capacity.SevenRight;
                    }
                }
                base.ApplyState(state);
            }
            private AbbatoirIntergrade.GumRuntimes.FourButtonFrameRuntime FourButtonFrameInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SevenButtonFrameRuntime SevenButtonFrameInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime BuildButtonInstance0 { get; set; }
            private AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime BuildButtonInstance1 { get; set; }
            private AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime BuildButtonInstance2 { get; set; }
            private AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime BuildButtonInstance3 { get; set; }
            private AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime BuildButtonInstance4 { get; set; }
            private AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime BuildButtonInstance5 { get; set; }
            private AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime BuildButtonInstance6 { get; set; }
            public BuildMenuRuntime (bool fullInstantiation = true) 
            	: base(false)
            {
                this.HasEvents = false;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "BuildMenu");
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
                FourButtonFrameInstance = this.GetGraphicalUiElementByName("FourButtonFrameInstance") as AbbatoirIntergrade.GumRuntimes.FourButtonFrameRuntime;
                SevenButtonFrameInstance = this.GetGraphicalUiElementByName("SevenButtonFrameInstance") as AbbatoirIntergrade.GumRuntimes.SevenButtonFrameRuntime;
                BuildButtonInstance0 = this.GetGraphicalUiElementByName("BuildButtonInstance0") as AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime;
                BuildButtonInstance1 = this.GetGraphicalUiElementByName("BuildButtonInstance1") as AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime;
                BuildButtonInstance2 = this.GetGraphicalUiElementByName("BuildButtonInstance2") as AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime;
                BuildButtonInstance3 = this.GetGraphicalUiElementByName("BuildButtonInstance3") as AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime;
                BuildButtonInstance4 = this.GetGraphicalUiElementByName("BuildButtonInstance4") as AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime;
                BuildButtonInstance5 = this.GetGraphicalUiElementByName("BuildButtonInstance5") as AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime;
                BuildButtonInstance6 = this.GetGraphicalUiElementByName("BuildButtonInstance6") as AbbatoirIntergrade.GumRuntimes.BuildButtonRuntime;
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
