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
                            ButtonFrameInstance0.X = 43.29829f;
                            ButtonFrameInstance0.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            ButtonFrameInstance0.Y = 67.83752f;
                            ButtonFrameInstance0.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            ButtonFrameInstance1.X = 33.23347f;
                            ButtonFrameInstance1.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            ButtonFrameInstance1.Y = 51.25159f;
                            ButtonFrameInstance1.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            ButtonFrameInstance2.X = 51.49597f;
                            ButtonFrameInstance2.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            ButtonFrameInstance2.Y = 51.31417f;
                            ButtonFrameInstance2.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            ButtonFrameInstance3.X = 42.26307f;
                            ButtonFrameInstance3.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            ButtonFrameInstance3.Y = 34.15827f;
                            ButtonFrameInstance3.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            ButtonFrameInstance4.Visible = false;
                            ButtonFrameInstance4.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            ButtonFrameInstance4.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            ButtonFrameInstance5.Visible = false;
                            ButtonFrameInstance5.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            ButtonFrameInstance5.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            ButtonFrameInstance6.Visible = false;
                            ButtonFrameInstance6.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            ButtonFrameInstance6.YUnits = Gum.Converters.GeneralUnitType.Percentage;
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
                            FourButtonFrameInstance.Visible = true;
                            FourButtonFrameInstance.X = 50f;
                            FourButtonFrameInstance.Y = 100f;
                            SevenButtonFrameInstance.Visible = false;
                            SevenButtonFrameInstance.X = 47.50298f;
                            SevenButtonFrameInstance.Y = 100.8836f;
                            ButtonFrameInstance0.X = 43.19118f;
                            ButtonFrameInstance0.Y = 67.92753f;
                            ButtonFrameInstance1.X = 34.37128f;
                            ButtonFrameInstance1.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            ButtonFrameInstance1.Y = 51.32274f;
                            ButtonFrameInstance2.X = 52.03481f;
                            ButtonFrameInstance2.Y = 51.35582f;
                            ButtonFrameInstance3.X = 43.17259f;
                            ButtonFrameInstance3.Y = 34.02776f;
                            ButtonFrameInstance4.Visible = false;
                            ButtonFrameInstance4.X = 0f;
                            ButtonFrameInstance4.Y = 0f;
                            ButtonFrameInstance5.Height = 24.47f;
                            ButtonFrameInstance5.Visible = false;
                            ButtonFrameInstance5.Width = 13.647f;
                            ButtonFrameInstance5.X = 0f;
                            ButtonFrameInstance5.Y = 0f;
                            ButtonFrameInstance6.Height = 24.47f;
                            ButtonFrameInstance6.Visible = false;
                            ButtonFrameInstance6.Width = 13.647f;
                            ButtonFrameInstance6.X = 0f;
                            ButtonFrameInstance6.Y = 0f;
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
                            ButtonFrameInstance0.X = 82.09743f;
                            ButtonFrameInstance0.Y = 37.92752f;
                            ButtonFrameInstance1.X = 72.73f;
                            ButtonFrameInstance1.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            ButtonFrameInstance1.Y = 53.82274f;
                            ButtonFrameInstance2.X = 72.73793f;
                            ButtonFrameInstance2.Y = 21.95767f;
                            ButtonFrameInstance3.X = 63.01634f;
                            ButtonFrameInstance3.Y = 37.91665f;
                            ButtonFrameInstance4.Visible = false;
                            ButtonFrameInstance4.X = 0f;
                            ButtonFrameInstance4.Y = 0f;
                            ButtonFrameInstance5.Height = 24.47f;
                            ButtonFrameInstance5.Visible = false;
                            ButtonFrameInstance5.Width = 13.647f;
                            ButtonFrameInstance5.X = 0f;
                            ButtonFrameInstance5.Y = 0f;
                            ButtonFrameInstance6.Height = 24.47f;
                            ButtonFrameInstance6.Visible = false;
                            ButtonFrameInstance6.Width = 13.647f;
                            ButtonFrameInstance6.X = 0f;
                            ButtonFrameInstance6.Y = 0f;
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
                            ButtonFrameInstance0.X = 4.363056f;
                            ButtonFrameInstance0.Y = 37.92752f;
                            ButtonFrameInstance1.X = 13.73f;
                            ButtonFrameInstance1.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            ButtonFrameInstance1.Y = 53.56481f;
                            ButtonFrameInstance2.X = 13.73f;
                            ButtonFrameInstance2.Y = 22.05026f;
                            ButtonFrameInstance3.X = 23.38464f;
                            ButtonFrameInstance3.Y = 37.7976f;
                            ButtonFrameInstance4.Visible = false;
                            ButtonFrameInstance4.X = 0f;
                            ButtonFrameInstance4.Y = 0f;
                            ButtonFrameInstance5.Height = 24.47f;
                            ButtonFrameInstance5.Visible = false;
                            ButtonFrameInstance5.Width = 13.647f;
                            ButtonFrameInstance5.X = 0f;
                            ButtonFrameInstance5.Y = 0f;
                            ButtonFrameInstance6.Height = 24.47f;
                            ButtonFrameInstance6.Visible = false;
                            ButtonFrameInstance6.Width = 13.647f;
                            ButtonFrameInstance6.X = 0f;
                            ButtonFrameInstance6.Y = 0f;
                            break;
                        case  Capacity.Seven:
                            XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                            FourButtonFrameInstance.Visible = false;
                            FourButtonFrameInstance.X = 50f;
                            FourButtonFrameInstance.Y = 100f;
                            SevenButtonFrameInstance.Visible = true;
                            SevenButtonFrameInstance.X = 47.50298f;
                            SevenButtonFrameInstance.Y = 100.8836f;
                            ButtonFrameInstance0.X = 43.14814f;
                            ButtonFrameInstance0.Y = 68.01085f;
                            ButtonFrameInstance1.X = 34.26563f;
                            ButtonFrameInstance1.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            ButtonFrameInstance1.Y = 51.43519f;
                            ButtonFrameInstance2.X = 52.06459f;
                            ButtonFrameInstance2.Y = 51.57408f;
                            ButtonFrameInstance3.X = 43.15125f;
                            ButtonFrameInstance3.Y = 35.08086f;
                            ButtonFrameInstance4.Visible = true;
                            ButtonFrameInstance4.X = 34.29688f;
                            ButtonFrameInstance4.Y = 18.35648f;
                            ButtonFrameInstance5.Height = 24.47f;
                            ButtonFrameInstance5.Visible = true;
                            ButtonFrameInstance5.Width = 13.647f;
                            ButtonFrameInstance5.X = 52.00523f;
                            ButtonFrameInstance5.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            ButtonFrameInstance5.Y = 18.31018f;
                            ButtonFrameInstance5.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            ButtonFrameInstance6.Height = 24.47f;
                            ButtonFrameInstance6.Visible = true;
                            ButtonFrameInstance6.Width = 13.647f;
                            ButtonFrameInstance6.X = 43.15125f;
                            ButtonFrameInstance6.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            ButtonFrameInstance6.Y = 1.134257f;
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
                            ButtonFrameInstance0.X = 82.00231f;
                            ButtonFrameInstance0.Y = 37.87195f;
                            ButtonFrameInstance1.X = 72.76563f;
                            ButtonFrameInstance1.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            ButtonFrameInstance1.Y = 53.65741f;
                            ButtonFrameInstance2.X = 72.76772f;
                            ButtonFrameInstance2.Y = 21.99075f;
                            ButtonFrameInstance3.X = 63.51583f;
                            ButtonFrameInstance3.Y = 37.90495f;
                            ButtonFrameInstance4.Visible = true;
                            ButtonFrameInstance4.X = 54.14063f;
                            ButtonFrameInstance4.Y = 53.63426f;
                            ButtonFrameInstance5.Height = 24.47f;
                            ButtonFrameInstance5.Visible = true;
                            ButtonFrameInstance5.Width = 13.647f;
                            ButtonFrameInstance5.X = 54.1146f;
                            ButtonFrameInstance5.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            ButtonFrameInstance5.Y = 22.02546f;
                            ButtonFrameInstance5.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            ButtonFrameInstance6.Height = 24.47f;
                            ButtonFrameInstance6.Visible = true;
                            ButtonFrameInstance6.Width = 13.647f;
                            ButtonFrameInstance6.X = 44.38015f;
                            ButtonFrameInstance6.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            ButtonFrameInstance6.Y = 37.88074f;
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
                            ButtonFrameInstance0.X = 4.293975f;
                            ButtonFrameInstance0.Y = 37.88f;
                            ButtonFrameInstance1.X = 13.57813f;
                            ButtonFrameInstance1.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            ButtonFrameInstance1.Y = 53.87964f;
                            ButtonFrameInstance2.X = 13.61667f;
                            ButtonFrameInstance2.Y = 21.90742f;
                            ButtonFrameInstance3.X = 22.90776f;
                            ButtonFrameInstance3.Y = 37.90197f;
                            ButtonFrameInstance4.Visible = true;
                            ButtonFrameInstance4.X = 32.28125f;
                            ButtonFrameInstance4.Y = 53.74537f;
                            ButtonFrameInstance5.Height = 24.47f;
                            ButtonFrameInstance5.Visible = true;
                            ButtonFrameInstance5.Width = 13.647f;
                            ButtonFrameInstance5.X = 32.29986f;
                            ButtonFrameInstance5.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            ButtonFrameInstance5.Y = 22.04827f;
                            ButtonFrameInstance5.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            ButtonFrameInstance6.Height = 24.47f;
                            ButtonFrameInstance6.Visible = true;
                            ButtonFrameInstance6.Width = 13.647f;
                            ButtonFrameInstance6.X = 41.88341f;
                            ButtonFrameInstance6.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            ButtonFrameInstance6.Y = 37.8168f;
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
                bool setButtonFrameInstance0XFirstValue = false;
                bool setButtonFrameInstance0XSecondValue = false;
                float ButtonFrameInstance0XFirstValue= 0;
                float ButtonFrameInstance0XSecondValue= 0;
                bool setButtonFrameInstance0YFirstValue = false;
                bool setButtonFrameInstance0YSecondValue = false;
                float ButtonFrameInstance0YFirstValue= 0;
                float ButtonFrameInstance0YSecondValue= 0;
                bool setButtonFrameInstance1XFirstValue = false;
                bool setButtonFrameInstance1XSecondValue = false;
                float ButtonFrameInstance1XFirstValue= 0;
                float ButtonFrameInstance1XSecondValue= 0;
                bool setButtonFrameInstance1YFirstValue = false;
                bool setButtonFrameInstance1YSecondValue = false;
                float ButtonFrameInstance1YFirstValue= 0;
                float ButtonFrameInstance1YSecondValue= 0;
                bool setButtonFrameInstance2XFirstValue = false;
                bool setButtonFrameInstance2XSecondValue = false;
                float ButtonFrameInstance2XFirstValue= 0;
                float ButtonFrameInstance2XSecondValue= 0;
                bool setButtonFrameInstance2YFirstValue = false;
                bool setButtonFrameInstance2YSecondValue = false;
                float ButtonFrameInstance2YFirstValue= 0;
                float ButtonFrameInstance2YSecondValue= 0;
                bool setButtonFrameInstance3XFirstValue = false;
                bool setButtonFrameInstance3XSecondValue = false;
                float ButtonFrameInstance3XFirstValue= 0;
                float ButtonFrameInstance3XSecondValue= 0;
                bool setButtonFrameInstance3YFirstValue = false;
                bool setButtonFrameInstance3YSecondValue = false;
                float ButtonFrameInstance3YFirstValue= 0;
                float ButtonFrameInstance3YSecondValue= 0;
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
                        setButtonFrameInstance0XFirstValue = true;
                        ButtonFrameInstance0XFirstValue = 43.29829f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance0.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance0YFirstValue = true;
                        ButtonFrameInstance0YFirstValue = 67.83752f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance0.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance1XFirstValue = true;
                        ButtonFrameInstance1XFirstValue = 33.23347f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance1.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance1YFirstValue = true;
                        ButtonFrameInstance1YFirstValue = 51.25159f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance1.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance2XFirstValue = true;
                        ButtonFrameInstance2XFirstValue = 51.49597f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance2.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance2YFirstValue = true;
                        ButtonFrameInstance2YFirstValue = 51.31417f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance2.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance3XFirstValue = true;
                        ButtonFrameInstance3XFirstValue = 42.26307f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance3.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance3YFirstValue = true;
                        ButtonFrameInstance3YFirstValue = 34.15827f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance3.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance4.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance4.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance4.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance5.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance5.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance5.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance6.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance6.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance6.YUnits = Gum.Converters.GeneralUnitType.Percentage;
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
                        setButtonFrameInstance0XSecondValue = true;
                        ButtonFrameInstance0XSecondValue = 43.29829f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance0.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance0YSecondValue = true;
                        ButtonFrameInstance0YSecondValue = 67.83752f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance0.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance1XSecondValue = true;
                        ButtonFrameInstance1XSecondValue = 33.23347f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance1.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance1YSecondValue = true;
                        ButtonFrameInstance1YSecondValue = 51.25159f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance1.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance2XSecondValue = true;
                        ButtonFrameInstance2XSecondValue = 51.49597f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance2.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance2YSecondValue = true;
                        ButtonFrameInstance2YSecondValue = 51.31417f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance2.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance3XSecondValue = true;
                        ButtonFrameInstance3XSecondValue = 42.26307f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance3.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance3YSecondValue = true;
                        ButtonFrameInstance3YSecondValue = 34.15827f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance3.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance4.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance4.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance4.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance5.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance5.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance5.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance6.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance6.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance6.YUnits = Gum.Converters.GeneralUnitType.Percentage;
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
                if (setButtonFrameInstance0XFirstValue && setButtonFrameInstance0XSecondValue)
                {
                    ButtonFrameInstance0.X = ButtonFrameInstance0XFirstValue * (1 - interpolationValue) + ButtonFrameInstance0XSecondValue * interpolationValue;
                }
                if (setButtonFrameInstance0YFirstValue && setButtonFrameInstance0YSecondValue)
                {
                    ButtonFrameInstance0.Y = ButtonFrameInstance0YFirstValue * (1 - interpolationValue) + ButtonFrameInstance0YSecondValue * interpolationValue;
                }
                if (setButtonFrameInstance1XFirstValue && setButtonFrameInstance1XSecondValue)
                {
                    ButtonFrameInstance1.X = ButtonFrameInstance1XFirstValue * (1 - interpolationValue) + ButtonFrameInstance1XSecondValue * interpolationValue;
                }
                if (setButtonFrameInstance1YFirstValue && setButtonFrameInstance1YSecondValue)
                {
                    ButtonFrameInstance1.Y = ButtonFrameInstance1YFirstValue * (1 - interpolationValue) + ButtonFrameInstance1YSecondValue * interpolationValue;
                }
                if (setButtonFrameInstance2XFirstValue && setButtonFrameInstance2XSecondValue)
                {
                    ButtonFrameInstance2.X = ButtonFrameInstance2XFirstValue * (1 - interpolationValue) + ButtonFrameInstance2XSecondValue * interpolationValue;
                }
                if (setButtonFrameInstance2YFirstValue && setButtonFrameInstance2YSecondValue)
                {
                    ButtonFrameInstance2.Y = ButtonFrameInstance2YFirstValue * (1 - interpolationValue) + ButtonFrameInstance2YSecondValue * interpolationValue;
                }
                if (setButtonFrameInstance3XFirstValue && setButtonFrameInstance3XSecondValue)
                {
                    ButtonFrameInstance3.X = ButtonFrameInstance3XFirstValue * (1 - interpolationValue) + ButtonFrameInstance3XSecondValue * interpolationValue;
                }
                if (setButtonFrameInstance3YFirstValue && setButtonFrameInstance3YSecondValue)
                {
                    ButtonFrameInstance3.Y = ButtonFrameInstance3YFirstValue * (1 - interpolationValue) + ButtonFrameInstance3YSecondValue * interpolationValue;
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
                bool setButtonFrameInstance0XFirstValue = false;
                bool setButtonFrameInstance0XSecondValue = false;
                float ButtonFrameInstance0XFirstValue= 0;
                float ButtonFrameInstance0XSecondValue= 0;
                bool setButtonFrameInstance0YFirstValue = false;
                bool setButtonFrameInstance0YSecondValue = false;
                float ButtonFrameInstance0YFirstValue= 0;
                float ButtonFrameInstance0YSecondValue= 0;
                bool setButtonFrameInstance1XFirstValue = false;
                bool setButtonFrameInstance1XSecondValue = false;
                float ButtonFrameInstance1XFirstValue= 0;
                float ButtonFrameInstance1XSecondValue= 0;
                bool setButtonFrameInstance1YFirstValue = false;
                bool setButtonFrameInstance1YSecondValue = false;
                float ButtonFrameInstance1YFirstValue= 0;
                float ButtonFrameInstance1YSecondValue= 0;
                bool setButtonFrameInstance2XFirstValue = false;
                bool setButtonFrameInstance2XSecondValue = false;
                float ButtonFrameInstance2XFirstValue= 0;
                float ButtonFrameInstance2XSecondValue= 0;
                bool setButtonFrameInstance2YFirstValue = false;
                bool setButtonFrameInstance2YSecondValue = false;
                float ButtonFrameInstance2YFirstValue= 0;
                float ButtonFrameInstance2YSecondValue= 0;
                bool setButtonFrameInstance3XFirstValue = false;
                bool setButtonFrameInstance3XSecondValue = false;
                float ButtonFrameInstance3XFirstValue= 0;
                float ButtonFrameInstance3XSecondValue= 0;
                bool setButtonFrameInstance3YFirstValue = false;
                bool setButtonFrameInstance3YSecondValue = false;
                float ButtonFrameInstance3YFirstValue= 0;
                float ButtonFrameInstance3YSecondValue= 0;
                bool setButtonFrameInstance4XFirstValue = false;
                bool setButtonFrameInstance4XSecondValue = false;
                float ButtonFrameInstance4XFirstValue= 0;
                float ButtonFrameInstance4XSecondValue= 0;
                bool setButtonFrameInstance4YFirstValue = false;
                bool setButtonFrameInstance4YSecondValue = false;
                float ButtonFrameInstance4YFirstValue= 0;
                float ButtonFrameInstance4YSecondValue= 0;
                bool setButtonFrameInstance5HeightFirstValue = false;
                bool setButtonFrameInstance5HeightSecondValue = false;
                float ButtonFrameInstance5HeightFirstValue= 0;
                float ButtonFrameInstance5HeightSecondValue= 0;
                bool setButtonFrameInstance5WidthFirstValue = false;
                bool setButtonFrameInstance5WidthSecondValue = false;
                float ButtonFrameInstance5WidthFirstValue= 0;
                float ButtonFrameInstance5WidthSecondValue= 0;
                bool setButtonFrameInstance5XFirstValue = false;
                bool setButtonFrameInstance5XSecondValue = false;
                float ButtonFrameInstance5XFirstValue= 0;
                float ButtonFrameInstance5XSecondValue= 0;
                bool setButtonFrameInstance5YFirstValue = false;
                bool setButtonFrameInstance5YSecondValue = false;
                float ButtonFrameInstance5YFirstValue= 0;
                float ButtonFrameInstance5YSecondValue= 0;
                bool setButtonFrameInstance6HeightFirstValue = false;
                bool setButtonFrameInstance6HeightSecondValue = false;
                float ButtonFrameInstance6HeightFirstValue= 0;
                float ButtonFrameInstance6HeightSecondValue= 0;
                bool setButtonFrameInstance6WidthFirstValue = false;
                bool setButtonFrameInstance6WidthSecondValue = false;
                float ButtonFrameInstance6WidthFirstValue= 0;
                float ButtonFrameInstance6WidthSecondValue= 0;
                bool setButtonFrameInstance6XFirstValue = false;
                bool setButtonFrameInstance6XSecondValue = false;
                float ButtonFrameInstance6XFirstValue= 0;
                float ButtonFrameInstance6XSecondValue= 0;
                bool setButtonFrameInstance6YFirstValue = false;
                bool setButtonFrameInstance6YSecondValue = false;
                float ButtonFrameInstance6YFirstValue= 0;
                float ButtonFrameInstance6YSecondValue= 0;
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
                bool setFourButtonFrameInstanceCurrentRotatedStateFirstValue = false;
                bool setFourButtonFrameInstanceCurrentRotatedStateSecondValue = false;
                FourButtonFrameRuntime.Rotated FourButtonFrameInstanceCurrentRotatedStateFirstValue= FourButtonFrameRuntime.Rotated.Left;
                FourButtonFrameRuntime.Rotated FourButtonFrameInstanceCurrentRotatedStateSecondValue= FourButtonFrameRuntime.Rotated.Left;
                bool setSevenButtonFrameInstanceCurrentRotatedStateFirstValue = false;
                bool setSevenButtonFrameInstanceCurrentRotatedStateSecondValue = false;
                SevenButtonFrameRuntime.Rotated SevenButtonFrameInstanceCurrentRotatedStateFirstValue= SevenButtonFrameRuntime.Rotated.Left;
                SevenButtonFrameRuntime.Rotated SevenButtonFrameInstanceCurrentRotatedStateSecondValue= SevenButtonFrameRuntime.Rotated.Left;
                switch(firstState)
                {
                    case  Capacity.Four:
                        setButtonFrameInstance0XFirstValue = true;
                        ButtonFrameInstance0XFirstValue = 43.19118f;
                        setButtonFrameInstance0YFirstValue = true;
                        ButtonFrameInstance0YFirstValue = 67.92753f;
                        setButtonFrameInstance1XFirstValue = true;
                        ButtonFrameInstance1XFirstValue = 34.37128f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance1.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance1YFirstValue = true;
                        ButtonFrameInstance1YFirstValue = 51.32274f;
                        setButtonFrameInstance2XFirstValue = true;
                        ButtonFrameInstance2XFirstValue = 52.03481f;
                        setButtonFrameInstance2YFirstValue = true;
                        ButtonFrameInstance2YFirstValue = 51.35582f;
                        setButtonFrameInstance3XFirstValue = true;
                        ButtonFrameInstance3XFirstValue = 43.17259f;
                        setButtonFrameInstance3YFirstValue = true;
                        ButtonFrameInstance3YFirstValue = 34.02776f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance4.Visible = false;
                        }
                        setButtonFrameInstance4XFirstValue = true;
                        ButtonFrameInstance4XFirstValue = 0f;
                        setButtonFrameInstance4YFirstValue = true;
                        ButtonFrameInstance4YFirstValue = 0f;
                        setButtonFrameInstance5HeightFirstValue = true;
                        ButtonFrameInstance5HeightFirstValue = 24.47f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance5.Visible = false;
                        }
                        setButtonFrameInstance5WidthFirstValue = true;
                        ButtonFrameInstance5WidthFirstValue = 13.647f;
                        setButtonFrameInstance5XFirstValue = true;
                        ButtonFrameInstance5XFirstValue = 0f;
                        setButtonFrameInstance5YFirstValue = true;
                        ButtonFrameInstance5YFirstValue = 0f;
                        setButtonFrameInstance6HeightFirstValue = true;
                        ButtonFrameInstance6HeightFirstValue = 24.47f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance6.Visible = false;
                        }
                        setButtonFrameInstance6WidthFirstValue = true;
                        ButtonFrameInstance6WidthFirstValue = 13.647f;
                        setButtonFrameInstance6XFirstValue = true;
                        ButtonFrameInstance6XFirstValue = 0f;
                        setButtonFrameInstance6YFirstValue = true;
                        ButtonFrameInstance6YFirstValue = 0f;
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
                        setButtonFrameInstance0XFirstValue = true;
                        ButtonFrameInstance0XFirstValue = 82.09743f;
                        setButtonFrameInstance0YFirstValue = true;
                        ButtonFrameInstance0YFirstValue = 37.92752f;
                        setButtonFrameInstance1XFirstValue = true;
                        ButtonFrameInstance1XFirstValue = 72.73f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance1.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance1YFirstValue = true;
                        ButtonFrameInstance1YFirstValue = 53.82274f;
                        setButtonFrameInstance2XFirstValue = true;
                        ButtonFrameInstance2XFirstValue = 72.73793f;
                        setButtonFrameInstance2YFirstValue = true;
                        ButtonFrameInstance2YFirstValue = 21.95767f;
                        setButtonFrameInstance3XFirstValue = true;
                        ButtonFrameInstance3XFirstValue = 63.01634f;
                        setButtonFrameInstance3YFirstValue = true;
                        ButtonFrameInstance3YFirstValue = 37.91665f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance4.Visible = false;
                        }
                        setButtonFrameInstance4XFirstValue = true;
                        ButtonFrameInstance4XFirstValue = 0f;
                        setButtonFrameInstance4YFirstValue = true;
                        ButtonFrameInstance4YFirstValue = 0f;
                        setButtonFrameInstance5HeightFirstValue = true;
                        ButtonFrameInstance5HeightFirstValue = 24.47f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance5.Visible = false;
                        }
                        setButtonFrameInstance5WidthFirstValue = true;
                        ButtonFrameInstance5WidthFirstValue = 13.647f;
                        setButtonFrameInstance5XFirstValue = true;
                        ButtonFrameInstance5XFirstValue = 0f;
                        setButtonFrameInstance5YFirstValue = true;
                        ButtonFrameInstance5YFirstValue = 0f;
                        setButtonFrameInstance6HeightFirstValue = true;
                        ButtonFrameInstance6HeightFirstValue = 24.47f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance6.Visible = false;
                        }
                        setButtonFrameInstance6WidthFirstValue = true;
                        ButtonFrameInstance6WidthFirstValue = 13.647f;
                        setButtonFrameInstance6XFirstValue = true;
                        ButtonFrameInstance6XFirstValue = 0f;
                        setButtonFrameInstance6YFirstValue = true;
                        ButtonFrameInstance6YFirstValue = 0f;
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
                        setButtonFrameInstance0XFirstValue = true;
                        ButtonFrameInstance0XFirstValue = 4.363056f;
                        setButtonFrameInstance0YFirstValue = true;
                        ButtonFrameInstance0YFirstValue = 37.92752f;
                        setButtonFrameInstance1XFirstValue = true;
                        ButtonFrameInstance1XFirstValue = 13.73f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance1.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance1YFirstValue = true;
                        ButtonFrameInstance1YFirstValue = 53.56481f;
                        setButtonFrameInstance2XFirstValue = true;
                        ButtonFrameInstance2XFirstValue = 13.73f;
                        setButtonFrameInstance2YFirstValue = true;
                        ButtonFrameInstance2YFirstValue = 22.05026f;
                        setButtonFrameInstance3XFirstValue = true;
                        ButtonFrameInstance3XFirstValue = 23.38464f;
                        setButtonFrameInstance3YFirstValue = true;
                        ButtonFrameInstance3YFirstValue = 37.7976f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance4.Visible = false;
                        }
                        setButtonFrameInstance4XFirstValue = true;
                        ButtonFrameInstance4XFirstValue = 0f;
                        setButtonFrameInstance4YFirstValue = true;
                        ButtonFrameInstance4YFirstValue = 0f;
                        setButtonFrameInstance5HeightFirstValue = true;
                        ButtonFrameInstance5HeightFirstValue = 24.47f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance5.Visible = false;
                        }
                        setButtonFrameInstance5WidthFirstValue = true;
                        ButtonFrameInstance5WidthFirstValue = 13.647f;
                        setButtonFrameInstance5XFirstValue = true;
                        ButtonFrameInstance5XFirstValue = 0f;
                        setButtonFrameInstance5YFirstValue = true;
                        ButtonFrameInstance5YFirstValue = 0f;
                        setButtonFrameInstance6HeightFirstValue = true;
                        ButtonFrameInstance6HeightFirstValue = 24.47f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance6.Visible = false;
                        }
                        setButtonFrameInstance6WidthFirstValue = true;
                        ButtonFrameInstance6WidthFirstValue = 13.647f;
                        setButtonFrameInstance6XFirstValue = true;
                        ButtonFrameInstance6XFirstValue = 0f;
                        setButtonFrameInstance6YFirstValue = true;
                        ButtonFrameInstance6YFirstValue = 0f;
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
                        setButtonFrameInstance0XFirstValue = true;
                        ButtonFrameInstance0XFirstValue = 43.14814f;
                        setButtonFrameInstance0YFirstValue = true;
                        ButtonFrameInstance0YFirstValue = 68.01085f;
                        setButtonFrameInstance1XFirstValue = true;
                        ButtonFrameInstance1XFirstValue = 34.26563f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance1.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance1YFirstValue = true;
                        ButtonFrameInstance1YFirstValue = 51.43519f;
                        setButtonFrameInstance2XFirstValue = true;
                        ButtonFrameInstance2XFirstValue = 52.06459f;
                        setButtonFrameInstance2YFirstValue = true;
                        ButtonFrameInstance2YFirstValue = 51.57408f;
                        setButtonFrameInstance3XFirstValue = true;
                        ButtonFrameInstance3XFirstValue = 43.15125f;
                        setButtonFrameInstance3YFirstValue = true;
                        ButtonFrameInstance3YFirstValue = 35.08086f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance4.Visible = true;
                        }
                        setButtonFrameInstance4XFirstValue = true;
                        ButtonFrameInstance4XFirstValue = 34.29688f;
                        setButtonFrameInstance4YFirstValue = true;
                        ButtonFrameInstance4YFirstValue = 18.35648f;
                        setButtonFrameInstance5HeightFirstValue = true;
                        ButtonFrameInstance5HeightFirstValue = 24.47f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance5.Visible = true;
                        }
                        setButtonFrameInstance5WidthFirstValue = true;
                        ButtonFrameInstance5WidthFirstValue = 13.647f;
                        setButtonFrameInstance5XFirstValue = true;
                        ButtonFrameInstance5XFirstValue = 52.00523f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance5.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance5YFirstValue = true;
                        ButtonFrameInstance5YFirstValue = 18.31018f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance5.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance6HeightFirstValue = true;
                        ButtonFrameInstance6HeightFirstValue = 24.47f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance6.Visible = true;
                        }
                        setButtonFrameInstance6WidthFirstValue = true;
                        ButtonFrameInstance6WidthFirstValue = 13.647f;
                        setButtonFrameInstance6XFirstValue = true;
                        ButtonFrameInstance6XFirstValue = 43.15125f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance6.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance6YFirstValue = true;
                        ButtonFrameInstance6YFirstValue = 1.134257f;
                        if (interpolationValue < 1)
                        {
                            this.FourButtonFrameInstance.Visible = false;
                        }
                        setFourButtonFrameInstanceXFirstValue = true;
                        FourButtonFrameInstanceXFirstValue = 50f;
                        setFourButtonFrameInstanceYFirstValue = true;
                        FourButtonFrameInstanceYFirstValue = 100f;
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
                        setButtonFrameInstance0XFirstValue = true;
                        ButtonFrameInstance0XFirstValue = 82.00231f;
                        setButtonFrameInstance0YFirstValue = true;
                        ButtonFrameInstance0YFirstValue = 37.87195f;
                        setButtonFrameInstance1XFirstValue = true;
                        ButtonFrameInstance1XFirstValue = 72.76563f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance1.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance1YFirstValue = true;
                        ButtonFrameInstance1YFirstValue = 53.65741f;
                        setButtonFrameInstance2XFirstValue = true;
                        ButtonFrameInstance2XFirstValue = 72.76772f;
                        setButtonFrameInstance2YFirstValue = true;
                        ButtonFrameInstance2YFirstValue = 21.99075f;
                        setButtonFrameInstance3XFirstValue = true;
                        ButtonFrameInstance3XFirstValue = 63.51583f;
                        setButtonFrameInstance3YFirstValue = true;
                        ButtonFrameInstance3YFirstValue = 37.90495f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance4.Visible = true;
                        }
                        setButtonFrameInstance4XFirstValue = true;
                        ButtonFrameInstance4XFirstValue = 54.14063f;
                        setButtonFrameInstance4YFirstValue = true;
                        ButtonFrameInstance4YFirstValue = 53.63426f;
                        setButtonFrameInstance5HeightFirstValue = true;
                        ButtonFrameInstance5HeightFirstValue = 24.47f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance5.Visible = true;
                        }
                        setButtonFrameInstance5WidthFirstValue = true;
                        ButtonFrameInstance5WidthFirstValue = 13.647f;
                        setButtonFrameInstance5XFirstValue = true;
                        ButtonFrameInstance5XFirstValue = 54.1146f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance5.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance5YFirstValue = true;
                        ButtonFrameInstance5YFirstValue = 22.02546f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance5.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance6HeightFirstValue = true;
                        ButtonFrameInstance6HeightFirstValue = 24.47f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance6.Visible = true;
                        }
                        setButtonFrameInstance6WidthFirstValue = true;
                        ButtonFrameInstance6WidthFirstValue = 13.647f;
                        setButtonFrameInstance6XFirstValue = true;
                        ButtonFrameInstance6XFirstValue = 44.38015f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance6.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance6YFirstValue = true;
                        ButtonFrameInstance6YFirstValue = 37.88074f;
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
                        setButtonFrameInstance0XFirstValue = true;
                        ButtonFrameInstance0XFirstValue = 4.293975f;
                        setButtonFrameInstance0YFirstValue = true;
                        ButtonFrameInstance0YFirstValue = 37.88f;
                        setButtonFrameInstance1XFirstValue = true;
                        ButtonFrameInstance1XFirstValue = 13.57813f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance1.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance1YFirstValue = true;
                        ButtonFrameInstance1YFirstValue = 53.87964f;
                        setButtonFrameInstance2XFirstValue = true;
                        ButtonFrameInstance2XFirstValue = 13.61667f;
                        setButtonFrameInstance2YFirstValue = true;
                        ButtonFrameInstance2YFirstValue = 21.90742f;
                        setButtonFrameInstance3XFirstValue = true;
                        ButtonFrameInstance3XFirstValue = 22.90776f;
                        setButtonFrameInstance3YFirstValue = true;
                        ButtonFrameInstance3YFirstValue = 37.90197f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance4.Visible = true;
                        }
                        setButtonFrameInstance4XFirstValue = true;
                        ButtonFrameInstance4XFirstValue = 32.28125f;
                        setButtonFrameInstance4YFirstValue = true;
                        ButtonFrameInstance4YFirstValue = 53.74537f;
                        setButtonFrameInstance5HeightFirstValue = true;
                        ButtonFrameInstance5HeightFirstValue = 24.47f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance5.Visible = true;
                        }
                        setButtonFrameInstance5WidthFirstValue = true;
                        ButtonFrameInstance5WidthFirstValue = 13.647f;
                        setButtonFrameInstance5XFirstValue = true;
                        ButtonFrameInstance5XFirstValue = 32.29986f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance5.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance5YFirstValue = true;
                        ButtonFrameInstance5YFirstValue = 22.04827f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance5.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance6HeightFirstValue = true;
                        ButtonFrameInstance6HeightFirstValue = 24.47f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance6.Visible = true;
                        }
                        setButtonFrameInstance6WidthFirstValue = true;
                        ButtonFrameInstance6WidthFirstValue = 13.647f;
                        setButtonFrameInstance6XFirstValue = true;
                        ButtonFrameInstance6XFirstValue = 41.88341f;
                        if (interpolationValue < 1)
                        {
                            this.ButtonFrameInstance6.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance6YFirstValue = true;
                        ButtonFrameInstance6YFirstValue = 37.8168f;
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
                        setButtonFrameInstance0XSecondValue = true;
                        ButtonFrameInstance0XSecondValue = 43.19118f;
                        setButtonFrameInstance0YSecondValue = true;
                        ButtonFrameInstance0YSecondValue = 67.92753f;
                        setButtonFrameInstance1XSecondValue = true;
                        ButtonFrameInstance1XSecondValue = 34.37128f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance1.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance1YSecondValue = true;
                        ButtonFrameInstance1YSecondValue = 51.32274f;
                        setButtonFrameInstance2XSecondValue = true;
                        ButtonFrameInstance2XSecondValue = 52.03481f;
                        setButtonFrameInstance2YSecondValue = true;
                        ButtonFrameInstance2YSecondValue = 51.35582f;
                        setButtonFrameInstance3XSecondValue = true;
                        ButtonFrameInstance3XSecondValue = 43.17259f;
                        setButtonFrameInstance3YSecondValue = true;
                        ButtonFrameInstance3YSecondValue = 34.02776f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance4.Visible = false;
                        }
                        setButtonFrameInstance4XSecondValue = true;
                        ButtonFrameInstance4XSecondValue = 0f;
                        setButtonFrameInstance4YSecondValue = true;
                        ButtonFrameInstance4YSecondValue = 0f;
                        setButtonFrameInstance5HeightSecondValue = true;
                        ButtonFrameInstance5HeightSecondValue = 24.47f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance5.Visible = false;
                        }
                        setButtonFrameInstance5WidthSecondValue = true;
                        ButtonFrameInstance5WidthSecondValue = 13.647f;
                        setButtonFrameInstance5XSecondValue = true;
                        ButtonFrameInstance5XSecondValue = 0f;
                        setButtonFrameInstance5YSecondValue = true;
                        ButtonFrameInstance5YSecondValue = 0f;
                        setButtonFrameInstance6HeightSecondValue = true;
                        ButtonFrameInstance6HeightSecondValue = 24.47f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance6.Visible = false;
                        }
                        setButtonFrameInstance6WidthSecondValue = true;
                        ButtonFrameInstance6WidthSecondValue = 13.647f;
                        setButtonFrameInstance6XSecondValue = true;
                        ButtonFrameInstance6XSecondValue = 0f;
                        setButtonFrameInstance6YSecondValue = true;
                        ButtonFrameInstance6YSecondValue = 0f;
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
                        setButtonFrameInstance0XSecondValue = true;
                        ButtonFrameInstance0XSecondValue = 82.09743f;
                        setButtonFrameInstance0YSecondValue = true;
                        ButtonFrameInstance0YSecondValue = 37.92752f;
                        setButtonFrameInstance1XSecondValue = true;
                        ButtonFrameInstance1XSecondValue = 72.73f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance1.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance1YSecondValue = true;
                        ButtonFrameInstance1YSecondValue = 53.82274f;
                        setButtonFrameInstance2XSecondValue = true;
                        ButtonFrameInstance2XSecondValue = 72.73793f;
                        setButtonFrameInstance2YSecondValue = true;
                        ButtonFrameInstance2YSecondValue = 21.95767f;
                        setButtonFrameInstance3XSecondValue = true;
                        ButtonFrameInstance3XSecondValue = 63.01634f;
                        setButtonFrameInstance3YSecondValue = true;
                        ButtonFrameInstance3YSecondValue = 37.91665f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance4.Visible = false;
                        }
                        setButtonFrameInstance4XSecondValue = true;
                        ButtonFrameInstance4XSecondValue = 0f;
                        setButtonFrameInstance4YSecondValue = true;
                        ButtonFrameInstance4YSecondValue = 0f;
                        setButtonFrameInstance5HeightSecondValue = true;
                        ButtonFrameInstance5HeightSecondValue = 24.47f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance5.Visible = false;
                        }
                        setButtonFrameInstance5WidthSecondValue = true;
                        ButtonFrameInstance5WidthSecondValue = 13.647f;
                        setButtonFrameInstance5XSecondValue = true;
                        ButtonFrameInstance5XSecondValue = 0f;
                        setButtonFrameInstance5YSecondValue = true;
                        ButtonFrameInstance5YSecondValue = 0f;
                        setButtonFrameInstance6HeightSecondValue = true;
                        ButtonFrameInstance6HeightSecondValue = 24.47f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance6.Visible = false;
                        }
                        setButtonFrameInstance6WidthSecondValue = true;
                        ButtonFrameInstance6WidthSecondValue = 13.647f;
                        setButtonFrameInstance6XSecondValue = true;
                        ButtonFrameInstance6XSecondValue = 0f;
                        setButtonFrameInstance6YSecondValue = true;
                        ButtonFrameInstance6YSecondValue = 0f;
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
                        setButtonFrameInstance0XSecondValue = true;
                        ButtonFrameInstance0XSecondValue = 4.363056f;
                        setButtonFrameInstance0YSecondValue = true;
                        ButtonFrameInstance0YSecondValue = 37.92752f;
                        setButtonFrameInstance1XSecondValue = true;
                        ButtonFrameInstance1XSecondValue = 13.73f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance1.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance1YSecondValue = true;
                        ButtonFrameInstance1YSecondValue = 53.56481f;
                        setButtonFrameInstance2XSecondValue = true;
                        ButtonFrameInstance2XSecondValue = 13.73f;
                        setButtonFrameInstance2YSecondValue = true;
                        ButtonFrameInstance2YSecondValue = 22.05026f;
                        setButtonFrameInstance3XSecondValue = true;
                        ButtonFrameInstance3XSecondValue = 23.38464f;
                        setButtonFrameInstance3YSecondValue = true;
                        ButtonFrameInstance3YSecondValue = 37.7976f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance4.Visible = false;
                        }
                        setButtonFrameInstance4XSecondValue = true;
                        ButtonFrameInstance4XSecondValue = 0f;
                        setButtonFrameInstance4YSecondValue = true;
                        ButtonFrameInstance4YSecondValue = 0f;
                        setButtonFrameInstance5HeightSecondValue = true;
                        ButtonFrameInstance5HeightSecondValue = 24.47f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance5.Visible = false;
                        }
                        setButtonFrameInstance5WidthSecondValue = true;
                        ButtonFrameInstance5WidthSecondValue = 13.647f;
                        setButtonFrameInstance5XSecondValue = true;
                        ButtonFrameInstance5XSecondValue = 0f;
                        setButtonFrameInstance5YSecondValue = true;
                        ButtonFrameInstance5YSecondValue = 0f;
                        setButtonFrameInstance6HeightSecondValue = true;
                        ButtonFrameInstance6HeightSecondValue = 24.47f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance6.Visible = false;
                        }
                        setButtonFrameInstance6WidthSecondValue = true;
                        ButtonFrameInstance6WidthSecondValue = 13.647f;
                        setButtonFrameInstance6XSecondValue = true;
                        ButtonFrameInstance6XSecondValue = 0f;
                        setButtonFrameInstance6YSecondValue = true;
                        ButtonFrameInstance6YSecondValue = 0f;
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
                        setButtonFrameInstance0XSecondValue = true;
                        ButtonFrameInstance0XSecondValue = 43.14814f;
                        setButtonFrameInstance0YSecondValue = true;
                        ButtonFrameInstance0YSecondValue = 68.01085f;
                        setButtonFrameInstance1XSecondValue = true;
                        ButtonFrameInstance1XSecondValue = 34.26563f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance1.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance1YSecondValue = true;
                        ButtonFrameInstance1YSecondValue = 51.43519f;
                        setButtonFrameInstance2XSecondValue = true;
                        ButtonFrameInstance2XSecondValue = 52.06459f;
                        setButtonFrameInstance2YSecondValue = true;
                        ButtonFrameInstance2YSecondValue = 51.57408f;
                        setButtonFrameInstance3XSecondValue = true;
                        ButtonFrameInstance3XSecondValue = 43.15125f;
                        setButtonFrameInstance3YSecondValue = true;
                        ButtonFrameInstance3YSecondValue = 35.08086f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance4.Visible = true;
                        }
                        setButtonFrameInstance4XSecondValue = true;
                        ButtonFrameInstance4XSecondValue = 34.29688f;
                        setButtonFrameInstance4YSecondValue = true;
                        ButtonFrameInstance4YSecondValue = 18.35648f;
                        setButtonFrameInstance5HeightSecondValue = true;
                        ButtonFrameInstance5HeightSecondValue = 24.47f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance5.Visible = true;
                        }
                        setButtonFrameInstance5WidthSecondValue = true;
                        ButtonFrameInstance5WidthSecondValue = 13.647f;
                        setButtonFrameInstance5XSecondValue = true;
                        ButtonFrameInstance5XSecondValue = 52.00523f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance5.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance5YSecondValue = true;
                        ButtonFrameInstance5YSecondValue = 18.31018f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance5.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance6HeightSecondValue = true;
                        ButtonFrameInstance6HeightSecondValue = 24.47f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance6.Visible = true;
                        }
                        setButtonFrameInstance6WidthSecondValue = true;
                        ButtonFrameInstance6WidthSecondValue = 13.647f;
                        setButtonFrameInstance6XSecondValue = true;
                        ButtonFrameInstance6XSecondValue = 43.15125f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance6.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance6YSecondValue = true;
                        ButtonFrameInstance6YSecondValue = 1.134257f;
                        if (interpolationValue >= 1)
                        {
                            this.FourButtonFrameInstance.Visible = false;
                        }
                        setFourButtonFrameInstanceXSecondValue = true;
                        FourButtonFrameInstanceXSecondValue = 50f;
                        setFourButtonFrameInstanceYSecondValue = true;
                        FourButtonFrameInstanceYSecondValue = 100f;
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
                        setButtonFrameInstance0XSecondValue = true;
                        ButtonFrameInstance0XSecondValue = 82.00231f;
                        setButtonFrameInstance0YSecondValue = true;
                        ButtonFrameInstance0YSecondValue = 37.87195f;
                        setButtonFrameInstance1XSecondValue = true;
                        ButtonFrameInstance1XSecondValue = 72.76563f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance1.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance1YSecondValue = true;
                        ButtonFrameInstance1YSecondValue = 53.65741f;
                        setButtonFrameInstance2XSecondValue = true;
                        ButtonFrameInstance2XSecondValue = 72.76772f;
                        setButtonFrameInstance2YSecondValue = true;
                        ButtonFrameInstance2YSecondValue = 21.99075f;
                        setButtonFrameInstance3XSecondValue = true;
                        ButtonFrameInstance3XSecondValue = 63.51583f;
                        setButtonFrameInstance3YSecondValue = true;
                        ButtonFrameInstance3YSecondValue = 37.90495f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance4.Visible = true;
                        }
                        setButtonFrameInstance4XSecondValue = true;
                        ButtonFrameInstance4XSecondValue = 54.14063f;
                        setButtonFrameInstance4YSecondValue = true;
                        ButtonFrameInstance4YSecondValue = 53.63426f;
                        setButtonFrameInstance5HeightSecondValue = true;
                        ButtonFrameInstance5HeightSecondValue = 24.47f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance5.Visible = true;
                        }
                        setButtonFrameInstance5WidthSecondValue = true;
                        ButtonFrameInstance5WidthSecondValue = 13.647f;
                        setButtonFrameInstance5XSecondValue = true;
                        ButtonFrameInstance5XSecondValue = 54.1146f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance5.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance5YSecondValue = true;
                        ButtonFrameInstance5YSecondValue = 22.02546f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance5.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance6HeightSecondValue = true;
                        ButtonFrameInstance6HeightSecondValue = 24.47f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance6.Visible = true;
                        }
                        setButtonFrameInstance6WidthSecondValue = true;
                        ButtonFrameInstance6WidthSecondValue = 13.647f;
                        setButtonFrameInstance6XSecondValue = true;
                        ButtonFrameInstance6XSecondValue = 44.38015f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance6.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance6YSecondValue = true;
                        ButtonFrameInstance6YSecondValue = 37.88074f;
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
                        setButtonFrameInstance0XSecondValue = true;
                        ButtonFrameInstance0XSecondValue = 4.293975f;
                        setButtonFrameInstance0YSecondValue = true;
                        ButtonFrameInstance0YSecondValue = 37.88f;
                        setButtonFrameInstance1XSecondValue = true;
                        ButtonFrameInstance1XSecondValue = 13.57813f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance1.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance1YSecondValue = true;
                        ButtonFrameInstance1YSecondValue = 53.87964f;
                        setButtonFrameInstance2XSecondValue = true;
                        ButtonFrameInstance2XSecondValue = 13.61667f;
                        setButtonFrameInstance2YSecondValue = true;
                        ButtonFrameInstance2YSecondValue = 21.90742f;
                        setButtonFrameInstance3XSecondValue = true;
                        ButtonFrameInstance3XSecondValue = 22.90776f;
                        setButtonFrameInstance3YSecondValue = true;
                        ButtonFrameInstance3YSecondValue = 37.90197f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance4.Visible = true;
                        }
                        setButtonFrameInstance4XSecondValue = true;
                        ButtonFrameInstance4XSecondValue = 32.28125f;
                        setButtonFrameInstance4YSecondValue = true;
                        ButtonFrameInstance4YSecondValue = 53.74537f;
                        setButtonFrameInstance5HeightSecondValue = true;
                        ButtonFrameInstance5HeightSecondValue = 24.47f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance5.Visible = true;
                        }
                        setButtonFrameInstance5WidthSecondValue = true;
                        ButtonFrameInstance5WidthSecondValue = 13.647f;
                        setButtonFrameInstance5XSecondValue = true;
                        ButtonFrameInstance5XSecondValue = 32.29986f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance5.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance5YSecondValue = true;
                        ButtonFrameInstance5YSecondValue = 22.04827f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance5.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance6HeightSecondValue = true;
                        ButtonFrameInstance6HeightSecondValue = 24.47f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance6.Visible = true;
                        }
                        setButtonFrameInstance6WidthSecondValue = true;
                        ButtonFrameInstance6WidthSecondValue = 13.647f;
                        setButtonFrameInstance6XSecondValue = true;
                        ButtonFrameInstance6XSecondValue = 41.88341f;
                        if (interpolationValue >= 1)
                        {
                            this.ButtonFrameInstance6.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setButtonFrameInstance6YSecondValue = true;
                        ButtonFrameInstance6YSecondValue = 37.8168f;
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
                if (setButtonFrameInstance0XFirstValue && setButtonFrameInstance0XSecondValue)
                {
                    ButtonFrameInstance0.X = ButtonFrameInstance0XFirstValue * (1 - interpolationValue) + ButtonFrameInstance0XSecondValue * interpolationValue;
                }
                if (setButtonFrameInstance0YFirstValue && setButtonFrameInstance0YSecondValue)
                {
                    ButtonFrameInstance0.Y = ButtonFrameInstance0YFirstValue * (1 - interpolationValue) + ButtonFrameInstance0YSecondValue * interpolationValue;
                }
                if (setButtonFrameInstance1XFirstValue && setButtonFrameInstance1XSecondValue)
                {
                    ButtonFrameInstance1.X = ButtonFrameInstance1XFirstValue * (1 - interpolationValue) + ButtonFrameInstance1XSecondValue * interpolationValue;
                }
                if (setButtonFrameInstance1YFirstValue && setButtonFrameInstance1YSecondValue)
                {
                    ButtonFrameInstance1.Y = ButtonFrameInstance1YFirstValue * (1 - interpolationValue) + ButtonFrameInstance1YSecondValue * interpolationValue;
                }
                if (setButtonFrameInstance2XFirstValue && setButtonFrameInstance2XSecondValue)
                {
                    ButtonFrameInstance2.X = ButtonFrameInstance2XFirstValue * (1 - interpolationValue) + ButtonFrameInstance2XSecondValue * interpolationValue;
                }
                if (setButtonFrameInstance2YFirstValue && setButtonFrameInstance2YSecondValue)
                {
                    ButtonFrameInstance2.Y = ButtonFrameInstance2YFirstValue * (1 - interpolationValue) + ButtonFrameInstance2YSecondValue * interpolationValue;
                }
                if (setButtonFrameInstance3XFirstValue && setButtonFrameInstance3XSecondValue)
                {
                    ButtonFrameInstance3.X = ButtonFrameInstance3XFirstValue * (1 - interpolationValue) + ButtonFrameInstance3XSecondValue * interpolationValue;
                }
                if (setButtonFrameInstance3YFirstValue && setButtonFrameInstance3YSecondValue)
                {
                    ButtonFrameInstance3.Y = ButtonFrameInstance3YFirstValue * (1 - interpolationValue) + ButtonFrameInstance3YSecondValue * interpolationValue;
                }
                if (setButtonFrameInstance4XFirstValue && setButtonFrameInstance4XSecondValue)
                {
                    ButtonFrameInstance4.X = ButtonFrameInstance4XFirstValue * (1 - interpolationValue) + ButtonFrameInstance4XSecondValue * interpolationValue;
                }
                if (setButtonFrameInstance4YFirstValue && setButtonFrameInstance4YSecondValue)
                {
                    ButtonFrameInstance4.Y = ButtonFrameInstance4YFirstValue * (1 - interpolationValue) + ButtonFrameInstance4YSecondValue * interpolationValue;
                }
                if (setButtonFrameInstance5HeightFirstValue && setButtonFrameInstance5HeightSecondValue)
                {
                    ButtonFrameInstance5.Height = ButtonFrameInstance5HeightFirstValue * (1 - interpolationValue) + ButtonFrameInstance5HeightSecondValue * interpolationValue;
                }
                if (setButtonFrameInstance5WidthFirstValue && setButtonFrameInstance5WidthSecondValue)
                {
                    ButtonFrameInstance5.Width = ButtonFrameInstance5WidthFirstValue * (1 - interpolationValue) + ButtonFrameInstance5WidthSecondValue * interpolationValue;
                }
                if (setButtonFrameInstance5XFirstValue && setButtonFrameInstance5XSecondValue)
                {
                    ButtonFrameInstance5.X = ButtonFrameInstance5XFirstValue * (1 - interpolationValue) + ButtonFrameInstance5XSecondValue * interpolationValue;
                }
                if (setButtonFrameInstance5YFirstValue && setButtonFrameInstance5YSecondValue)
                {
                    ButtonFrameInstance5.Y = ButtonFrameInstance5YFirstValue * (1 - interpolationValue) + ButtonFrameInstance5YSecondValue * interpolationValue;
                }
                if (setButtonFrameInstance6HeightFirstValue && setButtonFrameInstance6HeightSecondValue)
                {
                    ButtonFrameInstance6.Height = ButtonFrameInstance6HeightFirstValue * (1 - interpolationValue) + ButtonFrameInstance6HeightSecondValue * interpolationValue;
                }
                if (setButtonFrameInstance6WidthFirstValue && setButtonFrameInstance6WidthSecondValue)
                {
                    ButtonFrameInstance6.Width = ButtonFrameInstance6WidthFirstValue * (1 - interpolationValue) + ButtonFrameInstance6WidthSecondValue * interpolationValue;
                }
                if (setButtonFrameInstance6XFirstValue && setButtonFrameInstance6XSecondValue)
                {
                    ButtonFrameInstance6.X = ButtonFrameInstance6XFirstValue * (1 - interpolationValue) + ButtonFrameInstance6XSecondValue * interpolationValue;
                }
                if (setButtonFrameInstance6YFirstValue && setButtonFrameInstance6YSecondValue)
                {
                    ButtonFrameInstance6.Y = ButtonFrameInstance6YFirstValue * (1 - interpolationValue) + ButtonFrameInstance6YSecondValue * interpolationValue;
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
                if (setFourButtonFrameInstanceCurrentRotatedStateFirstValue && setFourButtonFrameInstanceCurrentRotatedStateSecondValue)
                {
                    FourButtonFrameInstance.InterpolateBetween(FourButtonFrameInstanceCurrentRotatedStateFirstValue, FourButtonFrameInstanceCurrentRotatedStateSecondValue, interpolationValue);
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
                ButtonFrameInstance0.StopAnimations();
                ButtonFrameInstance1.StopAnimations();
                ButtonFrameInstance2.StopAnimations();
                ButtonFrameInstance3.StopAnimations();
                ButtonFrameInstance4.StopAnimations();
                ButtonFrameInstance5.StopAnimations();
                ButtonFrameInstance6.StopAnimations();
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
                            Name = "ButtonFrameInstance0.X",
                            Type = "float",
                            Value = ButtonFrameInstance0.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance0.X Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance0.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance0.Y",
                            Type = "float",
                            Value = ButtonFrameInstance0.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance0.Y Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance0.YUnits
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
                            Name = "ButtonFrameInstance1.X Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance1.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance1.Y",
                            Type = "float",
                            Value = ButtonFrameInstance1.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance1.Y Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance1.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance2.X",
                            Type = "float",
                            Value = ButtonFrameInstance2.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance2.X Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance2.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance2.Y",
                            Type = "float",
                            Value = ButtonFrameInstance2.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance2.Y Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance2.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance3.X",
                            Type = "float",
                            Value = ButtonFrameInstance3.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance3.X Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance3.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance3.Y",
                            Type = "float",
                            Value = ButtonFrameInstance3.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance3.Y Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance3.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance4.Visible",
                            Type = "bool",
                            Value = ButtonFrameInstance4.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance4.X Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance4.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance4.Y Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance4.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Visible",
                            Type = "bool",
                            Value = ButtonFrameInstance5.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.X Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance5.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Y Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance5.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.Visible",
                            Type = "bool",
                            Value = ButtonFrameInstance6.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.X Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance6.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.Y Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance6.YUnits
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
                            Name = "ButtonFrameInstance0.X",
                            Type = "float",
                            Value = ButtonFrameInstance0.X + 43.29829f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance0.X Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance0.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance0.Y",
                            Type = "float",
                            Value = ButtonFrameInstance0.Y + 67.83752f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance0.Y Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance0.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance1.X",
                            Type = "float",
                            Value = ButtonFrameInstance1.X + 33.23347f
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
                            Name = "ButtonFrameInstance1.Y",
                            Type = "float",
                            Value = ButtonFrameInstance1.Y + 51.25159f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance1.Y Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance1.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance2.X",
                            Type = "float",
                            Value = ButtonFrameInstance2.X + 51.49597f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance2.X Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance2.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance2.Y",
                            Type = "float",
                            Value = ButtonFrameInstance2.Y + 51.31417f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance2.Y Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance2.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance3.X",
                            Type = "float",
                            Value = ButtonFrameInstance3.X + 42.26307f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance3.X Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance3.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance3.Y",
                            Type = "float",
                            Value = ButtonFrameInstance3.Y + 34.15827f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance3.Y Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance3.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance4.Visible",
                            Type = "bool",
                            Value = ButtonFrameInstance4.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance4.X Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance4.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance4.Y Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance4.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Visible",
                            Type = "bool",
                            Value = ButtonFrameInstance5.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.X Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance5.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Y Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance5.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.Visible",
                            Type = "bool",
                            Value = ButtonFrameInstance6.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.X Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance6.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.Y Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance6.YUnits
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
                            Name = "ButtonFrameInstance0.X",
                            Type = "float",
                            Value = ButtonFrameInstance0.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance0.Y",
                            Type = "float",
                            Value = ButtonFrameInstance0.Y
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
                            Name = "ButtonFrameInstance1.X Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance1.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance1.Y",
                            Type = "float",
                            Value = ButtonFrameInstance1.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance2.X",
                            Type = "float",
                            Value = ButtonFrameInstance2.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance2.Y",
                            Type = "float",
                            Value = ButtonFrameInstance2.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance3.X",
                            Type = "float",
                            Value = ButtonFrameInstance3.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance3.Y",
                            Type = "float",
                            Value = ButtonFrameInstance3.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance4.Visible",
                            Type = "bool",
                            Value = ButtonFrameInstance4.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance4.X",
                            Type = "float",
                            Value = ButtonFrameInstance4.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance4.Y",
                            Type = "float",
                            Value = ButtonFrameInstance4.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Height",
                            Type = "float",
                            Value = ButtonFrameInstance5.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Visible",
                            Type = "bool",
                            Value = ButtonFrameInstance5.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Width",
                            Type = "float",
                            Value = ButtonFrameInstance5.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.X",
                            Type = "float",
                            Value = ButtonFrameInstance5.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Y",
                            Type = "float",
                            Value = ButtonFrameInstance5.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.Height",
                            Type = "float",
                            Value = ButtonFrameInstance6.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.Visible",
                            Type = "bool",
                            Value = ButtonFrameInstance6.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.Width",
                            Type = "float",
                            Value = ButtonFrameInstance6.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.X",
                            Type = "float",
                            Value = ButtonFrameInstance6.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.Y",
                            Type = "float",
                            Value = ButtonFrameInstance6.Y
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
                            Name = "ButtonFrameInstance0.X",
                            Type = "float",
                            Value = ButtonFrameInstance0.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance0.Y",
                            Type = "float",
                            Value = ButtonFrameInstance0.Y
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
                            Name = "ButtonFrameInstance1.X Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance1.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance1.Y",
                            Type = "float",
                            Value = ButtonFrameInstance1.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance2.X",
                            Type = "float",
                            Value = ButtonFrameInstance2.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance2.Y",
                            Type = "float",
                            Value = ButtonFrameInstance2.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance3.X",
                            Type = "float",
                            Value = ButtonFrameInstance3.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance3.Y",
                            Type = "float",
                            Value = ButtonFrameInstance3.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance4.Visible",
                            Type = "bool",
                            Value = ButtonFrameInstance4.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance4.X",
                            Type = "float",
                            Value = ButtonFrameInstance4.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance4.Y",
                            Type = "float",
                            Value = ButtonFrameInstance4.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Height",
                            Type = "float",
                            Value = ButtonFrameInstance5.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Visible",
                            Type = "bool",
                            Value = ButtonFrameInstance5.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Width",
                            Type = "float",
                            Value = ButtonFrameInstance5.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.X",
                            Type = "float",
                            Value = ButtonFrameInstance5.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Y",
                            Type = "float",
                            Value = ButtonFrameInstance5.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.Height",
                            Type = "float",
                            Value = ButtonFrameInstance6.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.Visible",
                            Type = "bool",
                            Value = ButtonFrameInstance6.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.Width",
                            Type = "float",
                            Value = ButtonFrameInstance6.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.X",
                            Type = "float",
                            Value = ButtonFrameInstance6.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.Y",
                            Type = "float",
                            Value = ButtonFrameInstance6.Y
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
                            Name = "ButtonFrameInstance0.X",
                            Type = "float",
                            Value = ButtonFrameInstance0.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance0.Y",
                            Type = "float",
                            Value = ButtonFrameInstance0.Y
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
                            Name = "ButtonFrameInstance1.X Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance1.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance1.Y",
                            Type = "float",
                            Value = ButtonFrameInstance1.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance2.X",
                            Type = "float",
                            Value = ButtonFrameInstance2.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance2.Y",
                            Type = "float",
                            Value = ButtonFrameInstance2.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance3.X",
                            Type = "float",
                            Value = ButtonFrameInstance3.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance3.Y",
                            Type = "float",
                            Value = ButtonFrameInstance3.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance4.Visible",
                            Type = "bool",
                            Value = ButtonFrameInstance4.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance4.X",
                            Type = "float",
                            Value = ButtonFrameInstance4.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance4.Y",
                            Type = "float",
                            Value = ButtonFrameInstance4.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Height",
                            Type = "float",
                            Value = ButtonFrameInstance5.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Visible",
                            Type = "bool",
                            Value = ButtonFrameInstance5.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Width",
                            Type = "float",
                            Value = ButtonFrameInstance5.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.X",
                            Type = "float",
                            Value = ButtonFrameInstance5.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Y",
                            Type = "float",
                            Value = ButtonFrameInstance5.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.Height",
                            Type = "float",
                            Value = ButtonFrameInstance6.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.Visible",
                            Type = "bool",
                            Value = ButtonFrameInstance6.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.Width",
                            Type = "float",
                            Value = ButtonFrameInstance6.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.X",
                            Type = "float",
                            Value = ButtonFrameInstance6.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.Y",
                            Type = "float",
                            Value = ButtonFrameInstance6.Y
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
                            Name = "ButtonFrameInstance0.X",
                            Type = "float",
                            Value = ButtonFrameInstance0.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance0.Y",
                            Type = "float",
                            Value = ButtonFrameInstance0.Y
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
                            Name = "ButtonFrameInstance1.X Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance1.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance1.Y",
                            Type = "float",
                            Value = ButtonFrameInstance1.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance2.X",
                            Type = "float",
                            Value = ButtonFrameInstance2.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance2.Y",
                            Type = "float",
                            Value = ButtonFrameInstance2.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance3.X",
                            Type = "float",
                            Value = ButtonFrameInstance3.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance3.Y",
                            Type = "float",
                            Value = ButtonFrameInstance3.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance4.Visible",
                            Type = "bool",
                            Value = ButtonFrameInstance4.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance4.X",
                            Type = "float",
                            Value = ButtonFrameInstance4.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance4.Y",
                            Type = "float",
                            Value = ButtonFrameInstance4.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Height",
                            Type = "float",
                            Value = ButtonFrameInstance5.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Visible",
                            Type = "bool",
                            Value = ButtonFrameInstance5.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Width",
                            Type = "float",
                            Value = ButtonFrameInstance5.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.X",
                            Type = "float",
                            Value = ButtonFrameInstance5.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.X Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance5.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Y",
                            Type = "float",
                            Value = ButtonFrameInstance5.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Y Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance5.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.Height",
                            Type = "float",
                            Value = ButtonFrameInstance6.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.Visible",
                            Type = "bool",
                            Value = ButtonFrameInstance6.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.Width",
                            Type = "float",
                            Value = ButtonFrameInstance6.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.X",
                            Type = "float",
                            Value = ButtonFrameInstance6.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.X Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance6.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.Y",
                            Type = "float",
                            Value = ButtonFrameInstance6.Y
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
                            Name = "ButtonFrameInstance0.X",
                            Type = "float",
                            Value = ButtonFrameInstance0.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance0.Y",
                            Type = "float",
                            Value = ButtonFrameInstance0.Y
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
                            Name = "ButtonFrameInstance1.X Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance1.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance1.Y",
                            Type = "float",
                            Value = ButtonFrameInstance1.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance2.X",
                            Type = "float",
                            Value = ButtonFrameInstance2.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance2.Y",
                            Type = "float",
                            Value = ButtonFrameInstance2.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance3.X",
                            Type = "float",
                            Value = ButtonFrameInstance3.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance3.Y",
                            Type = "float",
                            Value = ButtonFrameInstance3.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance4.Visible",
                            Type = "bool",
                            Value = ButtonFrameInstance4.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance4.X",
                            Type = "float",
                            Value = ButtonFrameInstance4.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance4.Y",
                            Type = "float",
                            Value = ButtonFrameInstance4.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Height",
                            Type = "float",
                            Value = ButtonFrameInstance5.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Visible",
                            Type = "bool",
                            Value = ButtonFrameInstance5.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Width",
                            Type = "float",
                            Value = ButtonFrameInstance5.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.X",
                            Type = "float",
                            Value = ButtonFrameInstance5.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.X Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance5.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Y",
                            Type = "float",
                            Value = ButtonFrameInstance5.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Y Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance5.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.Height",
                            Type = "float",
                            Value = ButtonFrameInstance6.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.Visible",
                            Type = "bool",
                            Value = ButtonFrameInstance6.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.Width",
                            Type = "float",
                            Value = ButtonFrameInstance6.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.X",
                            Type = "float",
                            Value = ButtonFrameInstance6.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.X Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance6.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.Y",
                            Type = "float",
                            Value = ButtonFrameInstance6.Y
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
                            Name = "ButtonFrameInstance0.X",
                            Type = "float",
                            Value = ButtonFrameInstance0.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance0.Y",
                            Type = "float",
                            Value = ButtonFrameInstance0.Y
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
                            Name = "ButtonFrameInstance1.X Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance1.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance1.Y",
                            Type = "float",
                            Value = ButtonFrameInstance1.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance2.X",
                            Type = "float",
                            Value = ButtonFrameInstance2.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance2.Y",
                            Type = "float",
                            Value = ButtonFrameInstance2.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance3.X",
                            Type = "float",
                            Value = ButtonFrameInstance3.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance3.Y",
                            Type = "float",
                            Value = ButtonFrameInstance3.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance4.Visible",
                            Type = "bool",
                            Value = ButtonFrameInstance4.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance4.X",
                            Type = "float",
                            Value = ButtonFrameInstance4.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance4.Y",
                            Type = "float",
                            Value = ButtonFrameInstance4.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Height",
                            Type = "float",
                            Value = ButtonFrameInstance5.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Visible",
                            Type = "bool",
                            Value = ButtonFrameInstance5.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Width",
                            Type = "float",
                            Value = ButtonFrameInstance5.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.X",
                            Type = "float",
                            Value = ButtonFrameInstance5.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.X Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance5.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Y",
                            Type = "float",
                            Value = ButtonFrameInstance5.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Y Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance5.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.Height",
                            Type = "float",
                            Value = ButtonFrameInstance6.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.Visible",
                            Type = "bool",
                            Value = ButtonFrameInstance6.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.Width",
                            Type = "float",
                            Value = ButtonFrameInstance6.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.X",
                            Type = "float",
                            Value = ButtonFrameInstance6.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.X Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance6.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.Y",
                            Type = "float",
                            Value = ButtonFrameInstance6.Y
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
                            Name = "ButtonFrameInstance0.X",
                            Type = "float",
                            Value = ButtonFrameInstance0.X + 43.19118f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance0.Y",
                            Type = "float",
                            Value = ButtonFrameInstance0.Y + 67.92753f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance1.X",
                            Type = "float",
                            Value = ButtonFrameInstance1.X + 34.37128f
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
                            Name = "ButtonFrameInstance1.Y",
                            Type = "float",
                            Value = ButtonFrameInstance1.Y + 51.32274f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance2.X",
                            Type = "float",
                            Value = ButtonFrameInstance2.X + 52.03481f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance2.Y",
                            Type = "float",
                            Value = ButtonFrameInstance2.Y + 51.35582f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance3.X",
                            Type = "float",
                            Value = ButtonFrameInstance3.X + 43.17259f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance3.Y",
                            Type = "float",
                            Value = ButtonFrameInstance3.Y + 34.02776f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance4.Visible",
                            Type = "bool",
                            Value = ButtonFrameInstance4.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance4.X",
                            Type = "float",
                            Value = ButtonFrameInstance4.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance4.Y",
                            Type = "float",
                            Value = ButtonFrameInstance4.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Height",
                            Type = "float",
                            Value = ButtonFrameInstance5.Height + 24.47f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Visible",
                            Type = "bool",
                            Value = ButtonFrameInstance5.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Width",
                            Type = "float",
                            Value = ButtonFrameInstance5.Width + 13.647f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.X",
                            Type = "float",
                            Value = ButtonFrameInstance5.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Y",
                            Type = "float",
                            Value = ButtonFrameInstance5.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.Height",
                            Type = "float",
                            Value = ButtonFrameInstance6.Height + 24.47f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.Visible",
                            Type = "bool",
                            Value = ButtonFrameInstance6.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.Width",
                            Type = "float",
                            Value = ButtonFrameInstance6.Width + 13.647f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.X",
                            Type = "float",
                            Value = ButtonFrameInstance6.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.Y",
                            Type = "float",
                            Value = ButtonFrameInstance6.Y + 0f
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
                            Name = "ButtonFrameInstance0.X",
                            Type = "float",
                            Value = ButtonFrameInstance0.X + 82.09743f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance0.Y",
                            Type = "float",
                            Value = ButtonFrameInstance0.Y + 37.92752f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance1.X",
                            Type = "float",
                            Value = ButtonFrameInstance1.X + 72.73f
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
                            Name = "ButtonFrameInstance1.Y",
                            Type = "float",
                            Value = ButtonFrameInstance1.Y + 53.82274f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance2.X",
                            Type = "float",
                            Value = ButtonFrameInstance2.X + 72.73793f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance2.Y",
                            Type = "float",
                            Value = ButtonFrameInstance2.Y + 21.95767f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance3.X",
                            Type = "float",
                            Value = ButtonFrameInstance3.X + 63.01634f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance3.Y",
                            Type = "float",
                            Value = ButtonFrameInstance3.Y + 37.91665f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance4.Visible",
                            Type = "bool",
                            Value = ButtonFrameInstance4.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance4.X",
                            Type = "float",
                            Value = ButtonFrameInstance4.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance4.Y",
                            Type = "float",
                            Value = ButtonFrameInstance4.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Height",
                            Type = "float",
                            Value = ButtonFrameInstance5.Height + 24.47f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Visible",
                            Type = "bool",
                            Value = ButtonFrameInstance5.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Width",
                            Type = "float",
                            Value = ButtonFrameInstance5.Width + 13.647f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.X",
                            Type = "float",
                            Value = ButtonFrameInstance5.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Y",
                            Type = "float",
                            Value = ButtonFrameInstance5.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.Height",
                            Type = "float",
                            Value = ButtonFrameInstance6.Height + 24.47f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.Visible",
                            Type = "bool",
                            Value = ButtonFrameInstance6.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.Width",
                            Type = "float",
                            Value = ButtonFrameInstance6.Width + 13.647f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.X",
                            Type = "float",
                            Value = ButtonFrameInstance6.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.Y",
                            Type = "float",
                            Value = ButtonFrameInstance6.Y + 0f
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
                            Name = "ButtonFrameInstance0.X",
                            Type = "float",
                            Value = ButtonFrameInstance0.X + 4.363056f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance0.Y",
                            Type = "float",
                            Value = ButtonFrameInstance0.Y + 37.92752f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance1.X",
                            Type = "float",
                            Value = ButtonFrameInstance1.X + 13.73f
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
                            Name = "ButtonFrameInstance1.Y",
                            Type = "float",
                            Value = ButtonFrameInstance1.Y + 53.56481f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance2.X",
                            Type = "float",
                            Value = ButtonFrameInstance2.X + 13.73f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance2.Y",
                            Type = "float",
                            Value = ButtonFrameInstance2.Y + 22.05026f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance3.X",
                            Type = "float",
                            Value = ButtonFrameInstance3.X + 23.38464f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance3.Y",
                            Type = "float",
                            Value = ButtonFrameInstance3.Y + 37.7976f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance4.Visible",
                            Type = "bool",
                            Value = ButtonFrameInstance4.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance4.X",
                            Type = "float",
                            Value = ButtonFrameInstance4.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance4.Y",
                            Type = "float",
                            Value = ButtonFrameInstance4.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Height",
                            Type = "float",
                            Value = ButtonFrameInstance5.Height + 24.47f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Visible",
                            Type = "bool",
                            Value = ButtonFrameInstance5.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Width",
                            Type = "float",
                            Value = ButtonFrameInstance5.Width + 13.647f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.X",
                            Type = "float",
                            Value = ButtonFrameInstance5.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Y",
                            Type = "float",
                            Value = ButtonFrameInstance5.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.Height",
                            Type = "float",
                            Value = ButtonFrameInstance6.Height + 24.47f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.Visible",
                            Type = "bool",
                            Value = ButtonFrameInstance6.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.Width",
                            Type = "float",
                            Value = ButtonFrameInstance6.Width + 13.647f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.X",
                            Type = "float",
                            Value = ButtonFrameInstance6.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.Y",
                            Type = "float",
                            Value = ButtonFrameInstance6.Y + 0f
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
                            Name = "ButtonFrameInstance0.X",
                            Type = "float",
                            Value = ButtonFrameInstance0.X + 43.14814f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance0.Y",
                            Type = "float",
                            Value = ButtonFrameInstance0.Y + 68.01085f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance1.X",
                            Type = "float",
                            Value = ButtonFrameInstance1.X + 34.26563f
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
                            Name = "ButtonFrameInstance1.Y",
                            Type = "float",
                            Value = ButtonFrameInstance1.Y + 51.43519f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance2.X",
                            Type = "float",
                            Value = ButtonFrameInstance2.X + 52.06459f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance2.Y",
                            Type = "float",
                            Value = ButtonFrameInstance2.Y + 51.57408f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance3.X",
                            Type = "float",
                            Value = ButtonFrameInstance3.X + 43.15125f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance3.Y",
                            Type = "float",
                            Value = ButtonFrameInstance3.Y + 35.08086f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance4.Visible",
                            Type = "bool",
                            Value = ButtonFrameInstance4.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance4.X",
                            Type = "float",
                            Value = ButtonFrameInstance4.X + 34.29688f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance4.Y",
                            Type = "float",
                            Value = ButtonFrameInstance4.Y + 18.35648f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Height",
                            Type = "float",
                            Value = ButtonFrameInstance5.Height + 24.47f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Visible",
                            Type = "bool",
                            Value = ButtonFrameInstance5.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Width",
                            Type = "float",
                            Value = ButtonFrameInstance5.Width + 13.647f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.X",
                            Type = "float",
                            Value = ButtonFrameInstance5.X + 52.00523f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.X Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance5.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Y",
                            Type = "float",
                            Value = ButtonFrameInstance5.Y + 18.31018f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Y Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance5.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.Height",
                            Type = "float",
                            Value = ButtonFrameInstance6.Height + 24.47f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.Visible",
                            Type = "bool",
                            Value = ButtonFrameInstance6.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.Width",
                            Type = "float",
                            Value = ButtonFrameInstance6.Width + 13.647f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.X",
                            Type = "float",
                            Value = ButtonFrameInstance6.X + 43.15125f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.X Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance6.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.Y",
                            Type = "float",
                            Value = ButtonFrameInstance6.Y + 1.134257f
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
                            Name = "ButtonFrameInstance0.X",
                            Type = "float",
                            Value = ButtonFrameInstance0.X + 82.00231f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance0.Y",
                            Type = "float",
                            Value = ButtonFrameInstance0.Y + 37.87195f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance1.X",
                            Type = "float",
                            Value = ButtonFrameInstance1.X + 72.76563f
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
                            Name = "ButtonFrameInstance1.Y",
                            Type = "float",
                            Value = ButtonFrameInstance1.Y + 53.65741f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance2.X",
                            Type = "float",
                            Value = ButtonFrameInstance2.X + 72.76772f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance2.Y",
                            Type = "float",
                            Value = ButtonFrameInstance2.Y + 21.99075f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance3.X",
                            Type = "float",
                            Value = ButtonFrameInstance3.X + 63.51583f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance3.Y",
                            Type = "float",
                            Value = ButtonFrameInstance3.Y + 37.90495f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance4.Visible",
                            Type = "bool",
                            Value = ButtonFrameInstance4.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance4.X",
                            Type = "float",
                            Value = ButtonFrameInstance4.X + 54.14063f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance4.Y",
                            Type = "float",
                            Value = ButtonFrameInstance4.Y + 53.63426f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Height",
                            Type = "float",
                            Value = ButtonFrameInstance5.Height + 24.47f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Visible",
                            Type = "bool",
                            Value = ButtonFrameInstance5.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Width",
                            Type = "float",
                            Value = ButtonFrameInstance5.Width + 13.647f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.X",
                            Type = "float",
                            Value = ButtonFrameInstance5.X + 54.1146f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.X Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance5.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Y",
                            Type = "float",
                            Value = ButtonFrameInstance5.Y + 22.02546f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Y Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance5.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.Height",
                            Type = "float",
                            Value = ButtonFrameInstance6.Height + 24.47f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.Visible",
                            Type = "bool",
                            Value = ButtonFrameInstance6.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.Width",
                            Type = "float",
                            Value = ButtonFrameInstance6.Width + 13.647f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.X",
                            Type = "float",
                            Value = ButtonFrameInstance6.X + 44.38015f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.X Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance6.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.Y",
                            Type = "float",
                            Value = ButtonFrameInstance6.Y + 37.88074f
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
                            Name = "ButtonFrameInstance0.X",
                            Type = "float",
                            Value = ButtonFrameInstance0.X + 4.293975f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance0.Y",
                            Type = "float",
                            Value = ButtonFrameInstance0.Y + 37.88f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance1.X",
                            Type = "float",
                            Value = ButtonFrameInstance1.X + 13.57813f
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
                            Name = "ButtonFrameInstance1.Y",
                            Type = "float",
                            Value = ButtonFrameInstance1.Y + 53.87964f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance2.X",
                            Type = "float",
                            Value = ButtonFrameInstance2.X + 13.61667f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance2.Y",
                            Type = "float",
                            Value = ButtonFrameInstance2.Y + 21.90742f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance3.X",
                            Type = "float",
                            Value = ButtonFrameInstance3.X + 22.90776f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance3.Y",
                            Type = "float",
                            Value = ButtonFrameInstance3.Y + 37.90197f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance4.Visible",
                            Type = "bool",
                            Value = ButtonFrameInstance4.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance4.X",
                            Type = "float",
                            Value = ButtonFrameInstance4.X + 32.28125f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance4.Y",
                            Type = "float",
                            Value = ButtonFrameInstance4.Y + 53.74537f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Height",
                            Type = "float",
                            Value = ButtonFrameInstance5.Height + 24.47f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Visible",
                            Type = "bool",
                            Value = ButtonFrameInstance5.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Width",
                            Type = "float",
                            Value = ButtonFrameInstance5.Width + 13.647f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.X",
                            Type = "float",
                            Value = ButtonFrameInstance5.X + 32.29986f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.X Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance5.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Y",
                            Type = "float",
                            Value = ButtonFrameInstance5.Y + 22.04827f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance5.Y Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance5.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.Height",
                            Type = "float",
                            Value = ButtonFrameInstance6.Height + 24.47f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.Visible",
                            Type = "bool",
                            Value = ButtonFrameInstance6.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.Width",
                            Type = "float",
                            Value = ButtonFrameInstance6.Width + 13.647f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.X",
                            Type = "float",
                            Value = ButtonFrameInstance6.X + 41.88341f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.X Units",
                            Type = "PositionUnitType",
                            Value = ButtonFrameInstance6.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ButtonFrameInstance6.Y",
                            Type = "float",
                            Value = ButtonFrameInstance6.Y + 37.8168f
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
            private AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime ButtonFrameInstance0 { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime ButtonFrameInstance1 { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime ButtonFrameInstance2 { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime ButtonFrameInstance3 { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime ButtonFrameInstance4 { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime ButtonFrameInstance5 { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime ButtonFrameInstance6 { get; set; }
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
                ButtonFrameInstance0 = this.GetGraphicalUiElementByName("ButtonFrameInstance0") as AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime;
                ButtonFrameInstance1 = this.GetGraphicalUiElementByName("ButtonFrameInstance1") as AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime;
                ButtonFrameInstance2 = this.GetGraphicalUiElementByName("ButtonFrameInstance2") as AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime;
                ButtonFrameInstance3 = this.GetGraphicalUiElementByName("ButtonFrameInstance3") as AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime;
                ButtonFrameInstance4 = this.GetGraphicalUiElementByName("ButtonFrameInstance4") as AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime;
                ButtonFrameInstance5 = this.GetGraphicalUiElementByName("ButtonFrameInstance5") as AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime;
                ButtonFrameInstance6 = this.GetGraphicalUiElementByName("ButtonFrameInstance6") as AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime;
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
