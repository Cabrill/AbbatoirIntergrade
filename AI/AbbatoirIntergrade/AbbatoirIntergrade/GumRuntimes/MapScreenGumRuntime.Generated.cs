    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes
    {
        public partial class MapScreenGumRuntime : Gum.Wireframe.GraphicalUiElement
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            public enum MenuDisplay
            {
                MenuHidden,
                MenuShown
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            MenuDisplay mCurrentMenuDisplayState;
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
                            SpriteInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            SetProperty("SpriteInstance.SourceFile", "../Screens/MapScreen/worldmap.png");
                            SpriteInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            TechnologyTreeInstance.Visible = false;
                            LevelButtonInstance1.CurrentLevelNumberState = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.LevelNumber.Level1;
                            LevelButtonInstance1.X = 128f;
                            LevelButtonInstance1.Y = 1258f;
                            LevelButtonInstance2.CurrentLevelNumberState = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.LevelNumber.Level2;
                            LevelButtonInstance2.X = 98f;
                            LevelButtonInstance2.Y = 918f;
                            LevelButtonInstance3.CurrentLevelNumberState = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.LevelNumber.Level3;
                            LevelButtonInstance3.X = 268f;
                            LevelButtonInstance3.Y = 626f;
                            LevelButtonInstance4.CurrentLevelNumberState = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.LevelNumber.Level4;
                            LevelButtonInstance4.X = 540f;
                            LevelButtonInstance4.Y = 408f;
                            LevelButtonInstance5.CurrentLevelNumberState = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.LevelNumber.Level5;
                            LevelButtonInstance5.X = 926f;
                            LevelButtonInstance5.Y = 370f;
                            LevelButtonInstance6.CurrentLevelNumberState = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.LevelNumber.Level6;
                            LevelButtonInstance6.X = 1268f;
                            LevelButtonInstance6.Y = 552f;
                            LevelButtonInstance7.CurrentLevelNumberState = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.LevelNumber.Level7;
                            LevelButtonInstance7.X = 1614f;
                            LevelButtonInstance7.Y = 716f;
                            LevelButtonInstance8.CurrentLevelNumberState = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.LevelNumber.Level8;
                            LevelButtonInstance8.X = 1880f;
                            LevelButtonInstance8.Y = 576f;
                            LevelButtonInstance9.CurrentLevelNumberState = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.LevelNumber.Level9;
                            LevelButtonInstance9.X = 2082f;
                            LevelButtonInstance9.Y = 334f;
                            LevelButtonInstance10.CurrentLevelNumberState = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.LevelNumber.Level10;
                            LevelButtonInstance10.X = 2328f;
                            LevelButtonInstance10.Y = 248f;
                            OptionsButtonInstance.Height = 10.08334f;
                            OptionsButtonInstance.Width = 5.703125f;
                            ScreenDimRectangle.Alpha = 120;
                            ScreenDimRectangle.Blue = 0;
                            ScreenDimRectangle.Green = 0;
                            ScreenDimRectangle.Height = 100f;
                            ScreenDimRectangle.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ScreenDimRectangle.Red = 0;
                            ScreenDimRectangle.Width = 100f;
                            ScreenDimRectangle.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            MenuWindowInstance.ButtonType1State = AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime.ButtonType.X;
                            MenuWindowInstance.ButtonType2State = AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime.ButtonType.Disabled;
                            MenuWindowInstance.ButtonType3State = AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime.ButtonType.Disabled;
                            MenuWindowInstance.ButtonType4State = AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime.ButtonType.Play;
                            break;
                    }
                }
            }
            public MenuDisplay CurrentMenuDisplayState
            {
                get
                {
                    return mCurrentMenuDisplayState;
                }
                set
                {
                    mCurrentMenuDisplayState = value;
                    switch(mCurrentMenuDisplayState)
                    {
                        case  MenuDisplay.MenuHidden:
                            LevelButtonInstance1.CurrentButtonCategoryState = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                            LevelButtonInstance1.X = 102f;
                            LevelButtonInstance1.Y = 1236f;
                            LevelButtonInstance2.CurrentButtonCategoryState = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                            LevelButtonInstance3.CurrentButtonCategoryState = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                            LevelButtonInstance4.CurrentButtonCategoryState = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                            LevelButtonInstance5.CurrentButtonCategoryState = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                            LevelButtonInstance6.CurrentButtonCategoryState = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                            LevelButtonInstance7.CurrentButtonCategoryState = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                            LevelButtonInstance7.X = 1568f;
                            LevelButtonInstance7.Y = 724f;
                            LevelButtonInstance8.CurrentButtonCategoryState = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                            LevelButtonInstance9.CurrentButtonCategoryState = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                            LevelButtonInstance10.CurrentButtonCategoryState = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                            OptionsButtonInstance.Visible = true;
                            ScreenDimRectangle.Visible = false;
                            MenuWindowInstance.Visible = false;
                            break;
                        case  MenuDisplay.MenuShown:
                            LevelButtonInstance1.CurrentButtonCategoryState = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                            LevelButtonInstance1.X = 128f;
                            LevelButtonInstance1.Y = 1258f;
                            LevelButtonInstance2.CurrentButtonCategoryState = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                            LevelButtonInstance3.CurrentButtonCategoryState = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                            LevelButtonInstance4.CurrentButtonCategoryState = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                            LevelButtonInstance5.CurrentButtonCategoryState = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                            LevelButtonInstance6.CurrentButtonCategoryState = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                            LevelButtonInstance7.CurrentButtonCategoryState = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                            LevelButtonInstance7.X = 1614f;
                            LevelButtonInstance7.Y = 716f;
                            LevelButtonInstance8.CurrentButtonCategoryState = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                            LevelButtonInstance9.CurrentButtonCategoryState = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                            LevelButtonInstance10.CurrentButtonCategoryState = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                            OptionsButtonInstance.Visible = false;
                            ScreenDimRectangle.Visible = true;
                            MenuWindowInstance.Visible = true;
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
                bool setLevelButtonInstance1CurrentLevelNumberStateFirstValue = false;
                bool setLevelButtonInstance1CurrentLevelNumberStateSecondValue = false;
                LevelButtonRuntime.LevelNumber LevelButtonInstance1CurrentLevelNumberStateFirstValue= LevelButtonRuntime.LevelNumber.Level1;
                LevelButtonRuntime.LevelNumber LevelButtonInstance1CurrentLevelNumberStateSecondValue= LevelButtonRuntime.LevelNumber.Level1;
                bool setLevelButtonInstance1XFirstValue = false;
                bool setLevelButtonInstance1XSecondValue = false;
                float LevelButtonInstance1XFirstValue= 0;
                float LevelButtonInstance1XSecondValue= 0;
                bool setLevelButtonInstance1YFirstValue = false;
                bool setLevelButtonInstance1YSecondValue = false;
                float LevelButtonInstance1YFirstValue= 0;
                float LevelButtonInstance1YSecondValue= 0;
                bool setLevelButtonInstance10CurrentLevelNumberStateFirstValue = false;
                bool setLevelButtonInstance10CurrentLevelNumberStateSecondValue = false;
                LevelButtonRuntime.LevelNumber LevelButtonInstance10CurrentLevelNumberStateFirstValue= LevelButtonRuntime.LevelNumber.Level1;
                LevelButtonRuntime.LevelNumber LevelButtonInstance10CurrentLevelNumberStateSecondValue= LevelButtonRuntime.LevelNumber.Level1;
                bool setLevelButtonInstance10XFirstValue = false;
                bool setLevelButtonInstance10XSecondValue = false;
                float LevelButtonInstance10XFirstValue= 0;
                float LevelButtonInstance10XSecondValue= 0;
                bool setLevelButtonInstance10YFirstValue = false;
                bool setLevelButtonInstance10YSecondValue = false;
                float LevelButtonInstance10YFirstValue= 0;
                float LevelButtonInstance10YSecondValue= 0;
                bool setLevelButtonInstance2CurrentLevelNumberStateFirstValue = false;
                bool setLevelButtonInstance2CurrentLevelNumberStateSecondValue = false;
                LevelButtonRuntime.LevelNumber LevelButtonInstance2CurrentLevelNumberStateFirstValue= LevelButtonRuntime.LevelNumber.Level1;
                LevelButtonRuntime.LevelNumber LevelButtonInstance2CurrentLevelNumberStateSecondValue= LevelButtonRuntime.LevelNumber.Level1;
                bool setLevelButtonInstance2XFirstValue = false;
                bool setLevelButtonInstance2XSecondValue = false;
                float LevelButtonInstance2XFirstValue= 0;
                float LevelButtonInstance2XSecondValue= 0;
                bool setLevelButtonInstance2YFirstValue = false;
                bool setLevelButtonInstance2YSecondValue = false;
                float LevelButtonInstance2YFirstValue= 0;
                float LevelButtonInstance2YSecondValue= 0;
                bool setLevelButtonInstance3CurrentLevelNumberStateFirstValue = false;
                bool setLevelButtonInstance3CurrentLevelNumberStateSecondValue = false;
                LevelButtonRuntime.LevelNumber LevelButtonInstance3CurrentLevelNumberStateFirstValue= LevelButtonRuntime.LevelNumber.Level1;
                LevelButtonRuntime.LevelNumber LevelButtonInstance3CurrentLevelNumberStateSecondValue= LevelButtonRuntime.LevelNumber.Level1;
                bool setLevelButtonInstance3XFirstValue = false;
                bool setLevelButtonInstance3XSecondValue = false;
                float LevelButtonInstance3XFirstValue= 0;
                float LevelButtonInstance3XSecondValue= 0;
                bool setLevelButtonInstance3YFirstValue = false;
                bool setLevelButtonInstance3YSecondValue = false;
                float LevelButtonInstance3YFirstValue= 0;
                float LevelButtonInstance3YSecondValue= 0;
                bool setLevelButtonInstance4CurrentLevelNumberStateFirstValue = false;
                bool setLevelButtonInstance4CurrentLevelNumberStateSecondValue = false;
                LevelButtonRuntime.LevelNumber LevelButtonInstance4CurrentLevelNumberStateFirstValue= LevelButtonRuntime.LevelNumber.Level1;
                LevelButtonRuntime.LevelNumber LevelButtonInstance4CurrentLevelNumberStateSecondValue= LevelButtonRuntime.LevelNumber.Level1;
                bool setLevelButtonInstance4XFirstValue = false;
                bool setLevelButtonInstance4XSecondValue = false;
                float LevelButtonInstance4XFirstValue= 0;
                float LevelButtonInstance4XSecondValue= 0;
                bool setLevelButtonInstance4YFirstValue = false;
                bool setLevelButtonInstance4YSecondValue = false;
                float LevelButtonInstance4YFirstValue= 0;
                float LevelButtonInstance4YSecondValue= 0;
                bool setLevelButtonInstance5CurrentLevelNumberStateFirstValue = false;
                bool setLevelButtonInstance5CurrentLevelNumberStateSecondValue = false;
                LevelButtonRuntime.LevelNumber LevelButtonInstance5CurrentLevelNumberStateFirstValue= LevelButtonRuntime.LevelNumber.Level1;
                LevelButtonRuntime.LevelNumber LevelButtonInstance5CurrentLevelNumberStateSecondValue= LevelButtonRuntime.LevelNumber.Level1;
                bool setLevelButtonInstance5XFirstValue = false;
                bool setLevelButtonInstance5XSecondValue = false;
                float LevelButtonInstance5XFirstValue= 0;
                float LevelButtonInstance5XSecondValue= 0;
                bool setLevelButtonInstance5YFirstValue = false;
                bool setLevelButtonInstance5YSecondValue = false;
                float LevelButtonInstance5YFirstValue= 0;
                float LevelButtonInstance5YSecondValue= 0;
                bool setLevelButtonInstance6CurrentLevelNumberStateFirstValue = false;
                bool setLevelButtonInstance6CurrentLevelNumberStateSecondValue = false;
                LevelButtonRuntime.LevelNumber LevelButtonInstance6CurrentLevelNumberStateFirstValue= LevelButtonRuntime.LevelNumber.Level1;
                LevelButtonRuntime.LevelNumber LevelButtonInstance6CurrentLevelNumberStateSecondValue= LevelButtonRuntime.LevelNumber.Level1;
                bool setLevelButtonInstance6XFirstValue = false;
                bool setLevelButtonInstance6XSecondValue = false;
                float LevelButtonInstance6XFirstValue= 0;
                float LevelButtonInstance6XSecondValue= 0;
                bool setLevelButtonInstance6YFirstValue = false;
                bool setLevelButtonInstance6YSecondValue = false;
                float LevelButtonInstance6YFirstValue= 0;
                float LevelButtonInstance6YSecondValue= 0;
                bool setLevelButtonInstance7CurrentLevelNumberStateFirstValue = false;
                bool setLevelButtonInstance7CurrentLevelNumberStateSecondValue = false;
                LevelButtonRuntime.LevelNumber LevelButtonInstance7CurrentLevelNumberStateFirstValue= LevelButtonRuntime.LevelNumber.Level1;
                LevelButtonRuntime.LevelNumber LevelButtonInstance7CurrentLevelNumberStateSecondValue= LevelButtonRuntime.LevelNumber.Level1;
                bool setLevelButtonInstance7XFirstValue = false;
                bool setLevelButtonInstance7XSecondValue = false;
                float LevelButtonInstance7XFirstValue= 0;
                float LevelButtonInstance7XSecondValue= 0;
                bool setLevelButtonInstance7YFirstValue = false;
                bool setLevelButtonInstance7YSecondValue = false;
                float LevelButtonInstance7YFirstValue= 0;
                float LevelButtonInstance7YSecondValue= 0;
                bool setLevelButtonInstance8CurrentLevelNumberStateFirstValue = false;
                bool setLevelButtonInstance8CurrentLevelNumberStateSecondValue = false;
                LevelButtonRuntime.LevelNumber LevelButtonInstance8CurrentLevelNumberStateFirstValue= LevelButtonRuntime.LevelNumber.Level1;
                LevelButtonRuntime.LevelNumber LevelButtonInstance8CurrentLevelNumberStateSecondValue= LevelButtonRuntime.LevelNumber.Level1;
                bool setLevelButtonInstance8XFirstValue = false;
                bool setLevelButtonInstance8XSecondValue = false;
                float LevelButtonInstance8XFirstValue= 0;
                float LevelButtonInstance8XSecondValue= 0;
                bool setLevelButtonInstance8YFirstValue = false;
                bool setLevelButtonInstance8YSecondValue = false;
                float LevelButtonInstance8YFirstValue= 0;
                float LevelButtonInstance8YSecondValue= 0;
                bool setLevelButtonInstance9CurrentLevelNumberStateFirstValue = false;
                bool setLevelButtonInstance9CurrentLevelNumberStateSecondValue = false;
                LevelButtonRuntime.LevelNumber LevelButtonInstance9CurrentLevelNumberStateFirstValue= LevelButtonRuntime.LevelNumber.Level1;
                LevelButtonRuntime.LevelNumber LevelButtonInstance9CurrentLevelNumberStateSecondValue= LevelButtonRuntime.LevelNumber.Level1;
                bool setLevelButtonInstance9XFirstValue = false;
                bool setLevelButtonInstance9XSecondValue = false;
                float LevelButtonInstance9XFirstValue= 0;
                float LevelButtonInstance9XSecondValue= 0;
                bool setLevelButtonInstance9YFirstValue = false;
                bool setLevelButtonInstance9YSecondValue = false;
                float LevelButtonInstance9YFirstValue= 0;
                float LevelButtonInstance9YSecondValue= 0;
                bool setOptionsButtonInstanceHeightFirstValue = false;
                bool setOptionsButtonInstanceHeightSecondValue = false;
                float OptionsButtonInstanceHeightFirstValue= 0;
                float OptionsButtonInstanceHeightSecondValue= 0;
                bool setOptionsButtonInstanceWidthFirstValue = false;
                bool setOptionsButtonInstanceWidthSecondValue = false;
                float OptionsButtonInstanceWidthFirstValue= 0;
                float OptionsButtonInstanceWidthSecondValue= 0;
                bool setScreenDimRectangleAlphaFirstValue = false;
                bool setScreenDimRectangleAlphaSecondValue = false;
                int ScreenDimRectangleAlphaFirstValue= 0;
                int ScreenDimRectangleAlphaSecondValue= 0;
                bool setScreenDimRectangleBlueFirstValue = false;
                bool setScreenDimRectangleBlueSecondValue = false;
                int ScreenDimRectangleBlueFirstValue= 0;
                int ScreenDimRectangleBlueSecondValue= 0;
                bool setScreenDimRectangleGreenFirstValue = false;
                bool setScreenDimRectangleGreenSecondValue = false;
                int ScreenDimRectangleGreenFirstValue= 0;
                int ScreenDimRectangleGreenSecondValue= 0;
                bool setScreenDimRectangleHeightFirstValue = false;
                bool setScreenDimRectangleHeightSecondValue = false;
                float ScreenDimRectangleHeightFirstValue= 0;
                float ScreenDimRectangleHeightSecondValue= 0;
                bool setScreenDimRectangleRedFirstValue = false;
                bool setScreenDimRectangleRedSecondValue = false;
                int ScreenDimRectangleRedFirstValue= 0;
                int ScreenDimRectangleRedSecondValue= 0;
                bool setScreenDimRectangleWidthFirstValue = false;
                bool setScreenDimRectangleWidthSecondValue = false;
                float ScreenDimRectangleWidthFirstValue= 0;
                float ScreenDimRectangleWidthSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setLevelButtonInstance1CurrentLevelNumberStateFirstValue = true;
                        LevelButtonInstance1CurrentLevelNumberStateFirstValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.LevelNumber.Level1;
                        setLevelButtonInstance1XFirstValue = true;
                        LevelButtonInstance1XFirstValue = 128f;
                        setLevelButtonInstance1YFirstValue = true;
                        LevelButtonInstance1YFirstValue = 1258f;
                        setLevelButtonInstance10CurrentLevelNumberStateFirstValue = true;
                        LevelButtonInstance10CurrentLevelNumberStateFirstValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.LevelNumber.Level10;
                        setLevelButtonInstance10XFirstValue = true;
                        LevelButtonInstance10XFirstValue = 2328f;
                        setLevelButtonInstance10YFirstValue = true;
                        LevelButtonInstance10YFirstValue = 248f;
                        setLevelButtonInstance2CurrentLevelNumberStateFirstValue = true;
                        LevelButtonInstance2CurrentLevelNumberStateFirstValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.LevelNumber.Level2;
                        setLevelButtonInstance2XFirstValue = true;
                        LevelButtonInstance2XFirstValue = 98f;
                        setLevelButtonInstance2YFirstValue = true;
                        LevelButtonInstance2YFirstValue = 918f;
                        setLevelButtonInstance3CurrentLevelNumberStateFirstValue = true;
                        LevelButtonInstance3CurrentLevelNumberStateFirstValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.LevelNumber.Level3;
                        setLevelButtonInstance3XFirstValue = true;
                        LevelButtonInstance3XFirstValue = 268f;
                        setLevelButtonInstance3YFirstValue = true;
                        LevelButtonInstance3YFirstValue = 626f;
                        setLevelButtonInstance4CurrentLevelNumberStateFirstValue = true;
                        LevelButtonInstance4CurrentLevelNumberStateFirstValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.LevelNumber.Level4;
                        setLevelButtonInstance4XFirstValue = true;
                        LevelButtonInstance4XFirstValue = 540f;
                        setLevelButtonInstance4YFirstValue = true;
                        LevelButtonInstance4YFirstValue = 408f;
                        setLevelButtonInstance5CurrentLevelNumberStateFirstValue = true;
                        LevelButtonInstance5CurrentLevelNumberStateFirstValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.LevelNumber.Level5;
                        setLevelButtonInstance5XFirstValue = true;
                        LevelButtonInstance5XFirstValue = 926f;
                        setLevelButtonInstance5YFirstValue = true;
                        LevelButtonInstance5YFirstValue = 370f;
                        setLevelButtonInstance6CurrentLevelNumberStateFirstValue = true;
                        LevelButtonInstance6CurrentLevelNumberStateFirstValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.LevelNumber.Level6;
                        setLevelButtonInstance6XFirstValue = true;
                        LevelButtonInstance6XFirstValue = 1268f;
                        setLevelButtonInstance6YFirstValue = true;
                        LevelButtonInstance6YFirstValue = 552f;
                        setLevelButtonInstance7CurrentLevelNumberStateFirstValue = true;
                        LevelButtonInstance7CurrentLevelNumberStateFirstValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.LevelNumber.Level7;
                        setLevelButtonInstance7XFirstValue = true;
                        LevelButtonInstance7XFirstValue = 1614f;
                        setLevelButtonInstance7YFirstValue = true;
                        LevelButtonInstance7YFirstValue = 716f;
                        setLevelButtonInstance8CurrentLevelNumberStateFirstValue = true;
                        LevelButtonInstance8CurrentLevelNumberStateFirstValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.LevelNumber.Level8;
                        setLevelButtonInstance8XFirstValue = true;
                        LevelButtonInstance8XFirstValue = 1880f;
                        setLevelButtonInstance8YFirstValue = true;
                        LevelButtonInstance8YFirstValue = 576f;
                        setLevelButtonInstance9CurrentLevelNumberStateFirstValue = true;
                        LevelButtonInstance9CurrentLevelNumberStateFirstValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.LevelNumber.Level9;
                        setLevelButtonInstance9XFirstValue = true;
                        LevelButtonInstance9XFirstValue = 2082f;
                        setLevelButtonInstance9YFirstValue = true;
                        LevelButtonInstance9YFirstValue = 334f;
                        if (interpolationValue < 1)
                        {
                            this.MenuWindowInstance.ButtonType1State = AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime.ButtonType.X;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MenuWindowInstance.ButtonType2State = AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime.ButtonType.Disabled;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MenuWindowInstance.ButtonType3State = AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime.ButtonType.Disabled;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MenuWindowInstance.ButtonType4State = AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime.ButtonType.Play;
                        }
                        setOptionsButtonInstanceHeightFirstValue = true;
                        OptionsButtonInstanceHeightFirstValue = 10.08334f;
                        setOptionsButtonInstanceWidthFirstValue = true;
                        OptionsButtonInstanceWidthFirstValue = 5.703125f;
                        setScreenDimRectangleAlphaFirstValue = true;
                        ScreenDimRectangleAlphaFirstValue = 120;
                        setScreenDimRectangleBlueFirstValue = true;
                        ScreenDimRectangleBlueFirstValue = 0;
                        setScreenDimRectangleGreenFirstValue = true;
                        ScreenDimRectangleGreenFirstValue = 0;
                        setScreenDimRectangleHeightFirstValue = true;
                        ScreenDimRectangleHeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.ScreenDimRectangle.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setScreenDimRectangleRedFirstValue = true;
                        ScreenDimRectangleRedFirstValue = 0;
                        setScreenDimRectangleWidthFirstValue = true;
                        ScreenDimRectangleWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.ScreenDimRectangle.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("SpriteInstance.SourceFile", "../Screens/MapScreen/worldmap.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.SpriteInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TechnologyTreeInstance.Visible = false;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setLevelButtonInstance1CurrentLevelNumberStateSecondValue = true;
                        LevelButtonInstance1CurrentLevelNumberStateSecondValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.LevelNumber.Level1;
                        setLevelButtonInstance1XSecondValue = true;
                        LevelButtonInstance1XSecondValue = 128f;
                        setLevelButtonInstance1YSecondValue = true;
                        LevelButtonInstance1YSecondValue = 1258f;
                        setLevelButtonInstance10CurrentLevelNumberStateSecondValue = true;
                        LevelButtonInstance10CurrentLevelNumberStateSecondValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.LevelNumber.Level10;
                        setLevelButtonInstance10XSecondValue = true;
                        LevelButtonInstance10XSecondValue = 2328f;
                        setLevelButtonInstance10YSecondValue = true;
                        LevelButtonInstance10YSecondValue = 248f;
                        setLevelButtonInstance2CurrentLevelNumberStateSecondValue = true;
                        LevelButtonInstance2CurrentLevelNumberStateSecondValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.LevelNumber.Level2;
                        setLevelButtonInstance2XSecondValue = true;
                        LevelButtonInstance2XSecondValue = 98f;
                        setLevelButtonInstance2YSecondValue = true;
                        LevelButtonInstance2YSecondValue = 918f;
                        setLevelButtonInstance3CurrentLevelNumberStateSecondValue = true;
                        LevelButtonInstance3CurrentLevelNumberStateSecondValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.LevelNumber.Level3;
                        setLevelButtonInstance3XSecondValue = true;
                        LevelButtonInstance3XSecondValue = 268f;
                        setLevelButtonInstance3YSecondValue = true;
                        LevelButtonInstance3YSecondValue = 626f;
                        setLevelButtonInstance4CurrentLevelNumberStateSecondValue = true;
                        LevelButtonInstance4CurrentLevelNumberStateSecondValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.LevelNumber.Level4;
                        setLevelButtonInstance4XSecondValue = true;
                        LevelButtonInstance4XSecondValue = 540f;
                        setLevelButtonInstance4YSecondValue = true;
                        LevelButtonInstance4YSecondValue = 408f;
                        setLevelButtonInstance5CurrentLevelNumberStateSecondValue = true;
                        LevelButtonInstance5CurrentLevelNumberStateSecondValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.LevelNumber.Level5;
                        setLevelButtonInstance5XSecondValue = true;
                        LevelButtonInstance5XSecondValue = 926f;
                        setLevelButtonInstance5YSecondValue = true;
                        LevelButtonInstance5YSecondValue = 370f;
                        setLevelButtonInstance6CurrentLevelNumberStateSecondValue = true;
                        LevelButtonInstance6CurrentLevelNumberStateSecondValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.LevelNumber.Level6;
                        setLevelButtonInstance6XSecondValue = true;
                        LevelButtonInstance6XSecondValue = 1268f;
                        setLevelButtonInstance6YSecondValue = true;
                        LevelButtonInstance6YSecondValue = 552f;
                        setLevelButtonInstance7CurrentLevelNumberStateSecondValue = true;
                        LevelButtonInstance7CurrentLevelNumberStateSecondValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.LevelNumber.Level7;
                        setLevelButtonInstance7XSecondValue = true;
                        LevelButtonInstance7XSecondValue = 1614f;
                        setLevelButtonInstance7YSecondValue = true;
                        LevelButtonInstance7YSecondValue = 716f;
                        setLevelButtonInstance8CurrentLevelNumberStateSecondValue = true;
                        LevelButtonInstance8CurrentLevelNumberStateSecondValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.LevelNumber.Level8;
                        setLevelButtonInstance8XSecondValue = true;
                        LevelButtonInstance8XSecondValue = 1880f;
                        setLevelButtonInstance8YSecondValue = true;
                        LevelButtonInstance8YSecondValue = 576f;
                        setLevelButtonInstance9CurrentLevelNumberStateSecondValue = true;
                        LevelButtonInstance9CurrentLevelNumberStateSecondValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.LevelNumber.Level9;
                        setLevelButtonInstance9XSecondValue = true;
                        LevelButtonInstance9XSecondValue = 2082f;
                        setLevelButtonInstance9YSecondValue = true;
                        LevelButtonInstance9YSecondValue = 334f;
                        if (interpolationValue >= 1)
                        {
                            this.MenuWindowInstance.ButtonType1State = AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime.ButtonType.X;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MenuWindowInstance.ButtonType2State = AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime.ButtonType.Disabled;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MenuWindowInstance.ButtonType3State = AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime.ButtonType.Disabled;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MenuWindowInstance.ButtonType4State = AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime.ButtonType.Play;
                        }
                        setOptionsButtonInstanceHeightSecondValue = true;
                        OptionsButtonInstanceHeightSecondValue = 10.08334f;
                        setOptionsButtonInstanceWidthSecondValue = true;
                        OptionsButtonInstanceWidthSecondValue = 5.703125f;
                        setScreenDimRectangleAlphaSecondValue = true;
                        ScreenDimRectangleAlphaSecondValue = 120;
                        setScreenDimRectangleBlueSecondValue = true;
                        ScreenDimRectangleBlueSecondValue = 0;
                        setScreenDimRectangleGreenSecondValue = true;
                        ScreenDimRectangleGreenSecondValue = 0;
                        setScreenDimRectangleHeightSecondValue = true;
                        ScreenDimRectangleHeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.ScreenDimRectangle.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setScreenDimRectangleRedSecondValue = true;
                        ScreenDimRectangleRedSecondValue = 0;
                        setScreenDimRectangleWidthSecondValue = true;
                        ScreenDimRectangleWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.ScreenDimRectangle.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("SpriteInstance.SourceFile", "../Screens/MapScreen/worldmap.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SpriteInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TechnologyTreeInstance.Visible = false;
                        }
                        break;
                }
                if (setLevelButtonInstance1CurrentLevelNumberStateFirstValue && setLevelButtonInstance1CurrentLevelNumberStateSecondValue)
                {
                    LevelButtonInstance1.InterpolateBetween(LevelButtonInstance1CurrentLevelNumberStateFirstValue, LevelButtonInstance1CurrentLevelNumberStateSecondValue, interpolationValue);
                }
                if (setLevelButtonInstance1XFirstValue && setLevelButtonInstance1XSecondValue)
                {
                    LevelButtonInstance1.X = LevelButtonInstance1XFirstValue * (1 - interpolationValue) + LevelButtonInstance1XSecondValue * interpolationValue;
                }
                if (setLevelButtonInstance1YFirstValue && setLevelButtonInstance1YSecondValue)
                {
                    LevelButtonInstance1.Y = LevelButtonInstance1YFirstValue * (1 - interpolationValue) + LevelButtonInstance1YSecondValue * interpolationValue;
                }
                if (setLevelButtonInstance10CurrentLevelNumberStateFirstValue && setLevelButtonInstance10CurrentLevelNumberStateSecondValue)
                {
                    LevelButtonInstance10.InterpolateBetween(LevelButtonInstance10CurrentLevelNumberStateFirstValue, LevelButtonInstance10CurrentLevelNumberStateSecondValue, interpolationValue);
                }
                if (setLevelButtonInstance10XFirstValue && setLevelButtonInstance10XSecondValue)
                {
                    LevelButtonInstance10.X = LevelButtonInstance10XFirstValue * (1 - interpolationValue) + LevelButtonInstance10XSecondValue * interpolationValue;
                }
                if (setLevelButtonInstance10YFirstValue && setLevelButtonInstance10YSecondValue)
                {
                    LevelButtonInstance10.Y = LevelButtonInstance10YFirstValue * (1 - interpolationValue) + LevelButtonInstance10YSecondValue * interpolationValue;
                }
                if (setLevelButtonInstance2CurrentLevelNumberStateFirstValue && setLevelButtonInstance2CurrentLevelNumberStateSecondValue)
                {
                    LevelButtonInstance2.InterpolateBetween(LevelButtonInstance2CurrentLevelNumberStateFirstValue, LevelButtonInstance2CurrentLevelNumberStateSecondValue, interpolationValue);
                }
                if (setLevelButtonInstance2XFirstValue && setLevelButtonInstance2XSecondValue)
                {
                    LevelButtonInstance2.X = LevelButtonInstance2XFirstValue * (1 - interpolationValue) + LevelButtonInstance2XSecondValue * interpolationValue;
                }
                if (setLevelButtonInstance2YFirstValue && setLevelButtonInstance2YSecondValue)
                {
                    LevelButtonInstance2.Y = LevelButtonInstance2YFirstValue * (1 - interpolationValue) + LevelButtonInstance2YSecondValue * interpolationValue;
                }
                if (setLevelButtonInstance3CurrentLevelNumberStateFirstValue && setLevelButtonInstance3CurrentLevelNumberStateSecondValue)
                {
                    LevelButtonInstance3.InterpolateBetween(LevelButtonInstance3CurrentLevelNumberStateFirstValue, LevelButtonInstance3CurrentLevelNumberStateSecondValue, interpolationValue);
                }
                if (setLevelButtonInstance3XFirstValue && setLevelButtonInstance3XSecondValue)
                {
                    LevelButtonInstance3.X = LevelButtonInstance3XFirstValue * (1 - interpolationValue) + LevelButtonInstance3XSecondValue * interpolationValue;
                }
                if (setLevelButtonInstance3YFirstValue && setLevelButtonInstance3YSecondValue)
                {
                    LevelButtonInstance3.Y = LevelButtonInstance3YFirstValue * (1 - interpolationValue) + LevelButtonInstance3YSecondValue * interpolationValue;
                }
                if (setLevelButtonInstance4CurrentLevelNumberStateFirstValue && setLevelButtonInstance4CurrentLevelNumberStateSecondValue)
                {
                    LevelButtonInstance4.InterpolateBetween(LevelButtonInstance4CurrentLevelNumberStateFirstValue, LevelButtonInstance4CurrentLevelNumberStateSecondValue, interpolationValue);
                }
                if (setLevelButtonInstance4XFirstValue && setLevelButtonInstance4XSecondValue)
                {
                    LevelButtonInstance4.X = LevelButtonInstance4XFirstValue * (1 - interpolationValue) + LevelButtonInstance4XSecondValue * interpolationValue;
                }
                if (setLevelButtonInstance4YFirstValue && setLevelButtonInstance4YSecondValue)
                {
                    LevelButtonInstance4.Y = LevelButtonInstance4YFirstValue * (1 - interpolationValue) + LevelButtonInstance4YSecondValue * interpolationValue;
                }
                if (setLevelButtonInstance5CurrentLevelNumberStateFirstValue && setLevelButtonInstance5CurrentLevelNumberStateSecondValue)
                {
                    LevelButtonInstance5.InterpolateBetween(LevelButtonInstance5CurrentLevelNumberStateFirstValue, LevelButtonInstance5CurrentLevelNumberStateSecondValue, interpolationValue);
                }
                if (setLevelButtonInstance5XFirstValue && setLevelButtonInstance5XSecondValue)
                {
                    LevelButtonInstance5.X = LevelButtonInstance5XFirstValue * (1 - interpolationValue) + LevelButtonInstance5XSecondValue * interpolationValue;
                }
                if (setLevelButtonInstance5YFirstValue && setLevelButtonInstance5YSecondValue)
                {
                    LevelButtonInstance5.Y = LevelButtonInstance5YFirstValue * (1 - interpolationValue) + LevelButtonInstance5YSecondValue * interpolationValue;
                }
                if (setLevelButtonInstance6CurrentLevelNumberStateFirstValue && setLevelButtonInstance6CurrentLevelNumberStateSecondValue)
                {
                    LevelButtonInstance6.InterpolateBetween(LevelButtonInstance6CurrentLevelNumberStateFirstValue, LevelButtonInstance6CurrentLevelNumberStateSecondValue, interpolationValue);
                }
                if (setLevelButtonInstance6XFirstValue && setLevelButtonInstance6XSecondValue)
                {
                    LevelButtonInstance6.X = LevelButtonInstance6XFirstValue * (1 - interpolationValue) + LevelButtonInstance6XSecondValue * interpolationValue;
                }
                if (setLevelButtonInstance6YFirstValue && setLevelButtonInstance6YSecondValue)
                {
                    LevelButtonInstance6.Y = LevelButtonInstance6YFirstValue * (1 - interpolationValue) + LevelButtonInstance6YSecondValue * interpolationValue;
                }
                if (setLevelButtonInstance7CurrentLevelNumberStateFirstValue && setLevelButtonInstance7CurrentLevelNumberStateSecondValue)
                {
                    LevelButtonInstance7.InterpolateBetween(LevelButtonInstance7CurrentLevelNumberStateFirstValue, LevelButtonInstance7CurrentLevelNumberStateSecondValue, interpolationValue);
                }
                if (setLevelButtonInstance7XFirstValue && setLevelButtonInstance7XSecondValue)
                {
                    LevelButtonInstance7.X = LevelButtonInstance7XFirstValue * (1 - interpolationValue) + LevelButtonInstance7XSecondValue * interpolationValue;
                }
                if (setLevelButtonInstance7YFirstValue && setLevelButtonInstance7YSecondValue)
                {
                    LevelButtonInstance7.Y = LevelButtonInstance7YFirstValue * (1 - interpolationValue) + LevelButtonInstance7YSecondValue * interpolationValue;
                }
                if (setLevelButtonInstance8CurrentLevelNumberStateFirstValue && setLevelButtonInstance8CurrentLevelNumberStateSecondValue)
                {
                    LevelButtonInstance8.InterpolateBetween(LevelButtonInstance8CurrentLevelNumberStateFirstValue, LevelButtonInstance8CurrentLevelNumberStateSecondValue, interpolationValue);
                }
                if (setLevelButtonInstance8XFirstValue && setLevelButtonInstance8XSecondValue)
                {
                    LevelButtonInstance8.X = LevelButtonInstance8XFirstValue * (1 - interpolationValue) + LevelButtonInstance8XSecondValue * interpolationValue;
                }
                if (setLevelButtonInstance8YFirstValue && setLevelButtonInstance8YSecondValue)
                {
                    LevelButtonInstance8.Y = LevelButtonInstance8YFirstValue * (1 - interpolationValue) + LevelButtonInstance8YSecondValue * interpolationValue;
                }
                if (setLevelButtonInstance9CurrentLevelNumberStateFirstValue && setLevelButtonInstance9CurrentLevelNumberStateSecondValue)
                {
                    LevelButtonInstance9.InterpolateBetween(LevelButtonInstance9CurrentLevelNumberStateFirstValue, LevelButtonInstance9CurrentLevelNumberStateSecondValue, interpolationValue);
                }
                if (setLevelButtonInstance9XFirstValue && setLevelButtonInstance9XSecondValue)
                {
                    LevelButtonInstance9.X = LevelButtonInstance9XFirstValue * (1 - interpolationValue) + LevelButtonInstance9XSecondValue * interpolationValue;
                }
                if (setLevelButtonInstance9YFirstValue && setLevelButtonInstance9YSecondValue)
                {
                    LevelButtonInstance9.Y = LevelButtonInstance9YFirstValue * (1 - interpolationValue) + LevelButtonInstance9YSecondValue * interpolationValue;
                }
                if (setOptionsButtonInstanceHeightFirstValue && setOptionsButtonInstanceHeightSecondValue)
                {
                    OptionsButtonInstance.Height = OptionsButtonInstanceHeightFirstValue * (1 - interpolationValue) + OptionsButtonInstanceHeightSecondValue * interpolationValue;
                }
                if (setOptionsButtonInstanceWidthFirstValue && setOptionsButtonInstanceWidthSecondValue)
                {
                    OptionsButtonInstance.Width = OptionsButtonInstanceWidthFirstValue * (1 - interpolationValue) + OptionsButtonInstanceWidthSecondValue * interpolationValue;
                }
                if (setScreenDimRectangleAlphaFirstValue && setScreenDimRectangleAlphaSecondValue)
                {
                    ScreenDimRectangle.Alpha = FlatRedBall.Math.MathFunctions.RoundToInt(ScreenDimRectangleAlphaFirstValue* (1 - interpolationValue) + ScreenDimRectangleAlphaSecondValue * interpolationValue);
                }
                if (setScreenDimRectangleBlueFirstValue && setScreenDimRectangleBlueSecondValue)
                {
                    ScreenDimRectangle.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(ScreenDimRectangleBlueFirstValue* (1 - interpolationValue) + ScreenDimRectangleBlueSecondValue * interpolationValue);
                }
                if (setScreenDimRectangleGreenFirstValue && setScreenDimRectangleGreenSecondValue)
                {
                    ScreenDimRectangle.Green = FlatRedBall.Math.MathFunctions.RoundToInt(ScreenDimRectangleGreenFirstValue* (1 - interpolationValue) + ScreenDimRectangleGreenSecondValue * interpolationValue);
                }
                if (setScreenDimRectangleHeightFirstValue && setScreenDimRectangleHeightSecondValue)
                {
                    ScreenDimRectangle.Height = ScreenDimRectangleHeightFirstValue * (1 - interpolationValue) + ScreenDimRectangleHeightSecondValue * interpolationValue;
                }
                if (setScreenDimRectangleRedFirstValue && setScreenDimRectangleRedSecondValue)
                {
                    ScreenDimRectangle.Red = FlatRedBall.Math.MathFunctions.RoundToInt(ScreenDimRectangleRedFirstValue* (1 - interpolationValue) + ScreenDimRectangleRedSecondValue * interpolationValue);
                }
                if (setScreenDimRectangleWidthFirstValue && setScreenDimRectangleWidthSecondValue)
                {
                    ScreenDimRectangle.Width = ScreenDimRectangleWidthFirstValue * (1 - interpolationValue) + ScreenDimRectangleWidthSecondValue * interpolationValue;
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
            public void InterpolateBetween (MenuDisplay firstState, MenuDisplay secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setLevelButtonInstance1CurrentButtonCategoryStateFirstValue = false;
                bool setLevelButtonInstance1CurrentButtonCategoryStateSecondValue = false;
                LevelButtonRuntime.ButtonCategory LevelButtonInstance1CurrentButtonCategoryStateFirstValue= LevelButtonRuntime.ButtonCategory.Enabled;
                LevelButtonRuntime.ButtonCategory LevelButtonInstance1CurrentButtonCategoryStateSecondValue= LevelButtonRuntime.ButtonCategory.Enabled;
                bool setLevelButtonInstance1XFirstValue = false;
                bool setLevelButtonInstance1XSecondValue = false;
                float LevelButtonInstance1XFirstValue= 0;
                float LevelButtonInstance1XSecondValue= 0;
                bool setLevelButtonInstance1YFirstValue = false;
                bool setLevelButtonInstance1YSecondValue = false;
                float LevelButtonInstance1YFirstValue= 0;
                float LevelButtonInstance1YSecondValue= 0;
                bool setLevelButtonInstance10CurrentButtonCategoryStateFirstValue = false;
                bool setLevelButtonInstance10CurrentButtonCategoryStateSecondValue = false;
                LevelButtonRuntime.ButtonCategory LevelButtonInstance10CurrentButtonCategoryStateFirstValue= LevelButtonRuntime.ButtonCategory.Enabled;
                LevelButtonRuntime.ButtonCategory LevelButtonInstance10CurrentButtonCategoryStateSecondValue= LevelButtonRuntime.ButtonCategory.Enabled;
                bool setLevelButtonInstance2CurrentButtonCategoryStateFirstValue = false;
                bool setLevelButtonInstance2CurrentButtonCategoryStateSecondValue = false;
                LevelButtonRuntime.ButtonCategory LevelButtonInstance2CurrentButtonCategoryStateFirstValue= LevelButtonRuntime.ButtonCategory.Enabled;
                LevelButtonRuntime.ButtonCategory LevelButtonInstance2CurrentButtonCategoryStateSecondValue= LevelButtonRuntime.ButtonCategory.Enabled;
                bool setLevelButtonInstance3CurrentButtonCategoryStateFirstValue = false;
                bool setLevelButtonInstance3CurrentButtonCategoryStateSecondValue = false;
                LevelButtonRuntime.ButtonCategory LevelButtonInstance3CurrentButtonCategoryStateFirstValue= LevelButtonRuntime.ButtonCategory.Enabled;
                LevelButtonRuntime.ButtonCategory LevelButtonInstance3CurrentButtonCategoryStateSecondValue= LevelButtonRuntime.ButtonCategory.Enabled;
                bool setLevelButtonInstance4CurrentButtonCategoryStateFirstValue = false;
                bool setLevelButtonInstance4CurrentButtonCategoryStateSecondValue = false;
                LevelButtonRuntime.ButtonCategory LevelButtonInstance4CurrentButtonCategoryStateFirstValue= LevelButtonRuntime.ButtonCategory.Enabled;
                LevelButtonRuntime.ButtonCategory LevelButtonInstance4CurrentButtonCategoryStateSecondValue= LevelButtonRuntime.ButtonCategory.Enabled;
                bool setLevelButtonInstance5CurrentButtonCategoryStateFirstValue = false;
                bool setLevelButtonInstance5CurrentButtonCategoryStateSecondValue = false;
                LevelButtonRuntime.ButtonCategory LevelButtonInstance5CurrentButtonCategoryStateFirstValue= LevelButtonRuntime.ButtonCategory.Enabled;
                LevelButtonRuntime.ButtonCategory LevelButtonInstance5CurrentButtonCategoryStateSecondValue= LevelButtonRuntime.ButtonCategory.Enabled;
                bool setLevelButtonInstance6CurrentButtonCategoryStateFirstValue = false;
                bool setLevelButtonInstance6CurrentButtonCategoryStateSecondValue = false;
                LevelButtonRuntime.ButtonCategory LevelButtonInstance6CurrentButtonCategoryStateFirstValue= LevelButtonRuntime.ButtonCategory.Enabled;
                LevelButtonRuntime.ButtonCategory LevelButtonInstance6CurrentButtonCategoryStateSecondValue= LevelButtonRuntime.ButtonCategory.Enabled;
                bool setLevelButtonInstance7CurrentButtonCategoryStateFirstValue = false;
                bool setLevelButtonInstance7CurrentButtonCategoryStateSecondValue = false;
                LevelButtonRuntime.ButtonCategory LevelButtonInstance7CurrentButtonCategoryStateFirstValue= LevelButtonRuntime.ButtonCategory.Enabled;
                LevelButtonRuntime.ButtonCategory LevelButtonInstance7CurrentButtonCategoryStateSecondValue= LevelButtonRuntime.ButtonCategory.Enabled;
                bool setLevelButtonInstance7XFirstValue = false;
                bool setLevelButtonInstance7XSecondValue = false;
                float LevelButtonInstance7XFirstValue= 0;
                float LevelButtonInstance7XSecondValue= 0;
                bool setLevelButtonInstance7YFirstValue = false;
                bool setLevelButtonInstance7YSecondValue = false;
                float LevelButtonInstance7YFirstValue= 0;
                float LevelButtonInstance7YSecondValue= 0;
                bool setLevelButtonInstance8CurrentButtonCategoryStateFirstValue = false;
                bool setLevelButtonInstance8CurrentButtonCategoryStateSecondValue = false;
                LevelButtonRuntime.ButtonCategory LevelButtonInstance8CurrentButtonCategoryStateFirstValue= LevelButtonRuntime.ButtonCategory.Enabled;
                LevelButtonRuntime.ButtonCategory LevelButtonInstance8CurrentButtonCategoryStateSecondValue= LevelButtonRuntime.ButtonCategory.Enabled;
                bool setLevelButtonInstance9CurrentButtonCategoryStateFirstValue = false;
                bool setLevelButtonInstance9CurrentButtonCategoryStateSecondValue = false;
                LevelButtonRuntime.ButtonCategory LevelButtonInstance9CurrentButtonCategoryStateFirstValue= LevelButtonRuntime.ButtonCategory.Enabled;
                LevelButtonRuntime.ButtonCategory LevelButtonInstance9CurrentButtonCategoryStateSecondValue= LevelButtonRuntime.ButtonCategory.Enabled;
                switch(firstState)
                {
                    case  MenuDisplay.MenuHidden:
                        setLevelButtonInstance1CurrentButtonCategoryStateFirstValue = true;
                        LevelButtonInstance1CurrentButtonCategoryStateFirstValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                        setLevelButtonInstance1XFirstValue = true;
                        LevelButtonInstance1XFirstValue = 102f;
                        setLevelButtonInstance1YFirstValue = true;
                        LevelButtonInstance1YFirstValue = 1236f;
                        setLevelButtonInstance10CurrentButtonCategoryStateFirstValue = true;
                        LevelButtonInstance10CurrentButtonCategoryStateFirstValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                        setLevelButtonInstance2CurrentButtonCategoryStateFirstValue = true;
                        LevelButtonInstance2CurrentButtonCategoryStateFirstValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                        setLevelButtonInstance3CurrentButtonCategoryStateFirstValue = true;
                        LevelButtonInstance3CurrentButtonCategoryStateFirstValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                        setLevelButtonInstance4CurrentButtonCategoryStateFirstValue = true;
                        LevelButtonInstance4CurrentButtonCategoryStateFirstValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                        setLevelButtonInstance5CurrentButtonCategoryStateFirstValue = true;
                        LevelButtonInstance5CurrentButtonCategoryStateFirstValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                        setLevelButtonInstance6CurrentButtonCategoryStateFirstValue = true;
                        LevelButtonInstance6CurrentButtonCategoryStateFirstValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                        setLevelButtonInstance7CurrentButtonCategoryStateFirstValue = true;
                        LevelButtonInstance7CurrentButtonCategoryStateFirstValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                        setLevelButtonInstance7XFirstValue = true;
                        LevelButtonInstance7XFirstValue = 1568f;
                        setLevelButtonInstance7YFirstValue = true;
                        LevelButtonInstance7YFirstValue = 724f;
                        setLevelButtonInstance8CurrentButtonCategoryStateFirstValue = true;
                        LevelButtonInstance8CurrentButtonCategoryStateFirstValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                        setLevelButtonInstance9CurrentButtonCategoryStateFirstValue = true;
                        LevelButtonInstance9CurrentButtonCategoryStateFirstValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                        if (interpolationValue < 1)
                        {
                            this.MenuWindowInstance.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.OptionsButtonInstance.Visible = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ScreenDimRectangle.Visible = false;
                        }
                        break;
                    case  MenuDisplay.MenuShown:
                        setLevelButtonInstance1CurrentButtonCategoryStateFirstValue = true;
                        LevelButtonInstance1CurrentButtonCategoryStateFirstValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                        setLevelButtonInstance1XFirstValue = true;
                        LevelButtonInstance1XFirstValue = 128f;
                        setLevelButtonInstance1YFirstValue = true;
                        LevelButtonInstance1YFirstValue = 1258f;
                        setLevelButtonInstance10CurrentButtonCategoryStateFirstValue = true;
                        LevelButtonInstance10CurrentButtonCategoryStateFirstValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                        setLevelButtonInstance2CurrentButtonCategoryStateFirstValue = true;
                        LevelButtonInstance2CurrentButtonCategoryStateFirstValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                        setLevelButtonInstance3CurrentButtonCategoryStateFirstValue = true;
                        LevelButtonInstance3CurrentButtonCategoryStateFirstValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                        setLevelButtonInstance4CurrentButtonCategoryStateFirstValue = true;
                        LevelButtonInstance4CurrentButtonCategoryStateFirstValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                        setLevelButtonInstance5CurrentButtonCategoryStateFirstValue = true;
                        LevelButtonInstance5CurrentButtonCategoryStateFirstValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                        setLevelButtonInstance6CurrentButtonCategoryStateFirstValue = true;
                        LevelButtonInstance6CurrentButtonCategoryStateFirstValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                        setLevelButtonInstance7CurrentButtonCategoryStateFirstValue = true;
                        LevelButtonInstance7CurrentButtonCategoryStateFirstValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                        setLevelButtonInstance7XFirstValue = true;
                        LevelButtonInstance7XFirstValue = 1614f;
                        setLevelButtonInstance7YFirstValue = true;
                        LevelButtonInstance7YFirstValue = 716f;
                        setLevelButtonInstance8CurrentButtonCategoryStateFirstValue = true;
                        LevelButtonInstance8CurrentButtonCategoryStateFirstValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                        setLevelButtonInstance9CurrentButtonCategoryStateFirstValue = true;
                        LevelButtonInstance9CurrentButtonCategoryStateFirstValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                        if (interpolationValue < 1)
                        {
                            this.MenuWindowInstance.Visible = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.OptionsButtonInstance.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ScreenDimRectangle.Visible = true;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  MenuDisplay.MenuHidden:
                        setLevelButtonInstance1CurrentButtonCategoryStateSecondValue = true;
                        LevelButtonInstance1CurrentButtonCategoryStateSecondValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                        setLevelButtonInstance1XSecondValue = true;
                        LevelButtonInstance1XSecondValue = 102f;
                        setLevelButtonInstance1YSecondValue = true;
                        LevelButtonInstance1YSecondValue = 1236f;
                        setLevelButtonInstance10CurrentButtonCategoryStateSecondValue = true;
                        LevelButtonInstance10CurrentButtonCategoryStateSecondValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                        setLevelButtonInstance2CurrentButtonCategoryStateSecondValue = true;
                        LevelButtonInstance2CurrentButtonCategoryStateSecondValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                        setLevelButtonInstance3CurrentButtonCategoryStateSecondValue = true;
                        LevelButtonInstance3CurrentButtonCategoryStateSecondValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                        setLevelButtonInstance4CurrentButtonCategoryStateSecondValue = true;
                        LevelButtonInstance4CurrentButtonCategoryStateSecondValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                        setLevelButtonInstance5CurrentButtonCategoryStateSecondValue = true;
                        LevelButtonInstance5CurrentButtonCategoryStateSecondValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                        setLevelButtonInstance6CurrentButtonCategoryStateSecondValue = true;
                        LevelButtonInstance6CurrentButtonCategoryStateSecondValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                        setLevelButtonInstance7CurrentButtonCategoryStateSecondValue = true;
                        LevelButtonInstance7CurrentButtonCategoryStateSecondValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                        setLevelButtonInstance7XSecondValue = true;
                        LevelButtonInstance7XSecondValue = 1568f;
                        setLevelButtonInstance7YSecondValue = true;
                        LevelButtonInstance7YSecondValue = 724f;
                        setLevelButtonInstance8CurrentButtonCategoryStateSecondValue = true;
                        LevelButtonInstance8CurrentButtonCategoryStateSecondValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                        setLevelButtonInstance9CurrentButtonCategoryStateSecondValue = true;
                        LevelButtonInstance9CurrentButtonCategoryStateSecondValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                        if (interpolationValue >= 1)
                        {
                            this.MenuWindowInstance.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.OptionsButtonInstance.Visible = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ScreenDimRectangle.Visible = false;
                        }
                        break;
                    case  MenuDisplay.MenuShown:
                        setLevelButtonInstance1CurrentButtonCategoryStateSecondValue = true;
                        LevelButtonInstance1CurrentButtonCategoryStateSecondValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                        setLevelButtonInstance1XSecondValue = true;
                        LevelButtonInstance1XSecondValue = 128f;
                        setLevelButtonInstance1YSecondValue = true;
                        LevelButtonInstance1YSecondValue = 1258f;
                        setLevelButtonInstance10CurrentButtonCategoryStateSecondValue = true;
                        LevelButtonInstance10CurrentButtonCategoryStateSecondValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                        setLevelButtonInstance2CurrentButtonCategoryStateSecondValue = true;
                        LevelButtonInstance2CurrentButtonCategoryStateSecondValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                        setLevelButtonInstance3CurrentButtonCategoryStateSecondValue = true;
                        LevelButtonInstance3CurrentButtonCategoryStateSecondValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                        setLevelButtonInstance4CurrentButtonCategoryStateSecondValue = true;
                        LevelButtonInstance4CurrentButtonCategoryStateSecondValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                        setLevelButtonInstance5CurrentButtonCategoryStateSecondValue = true;
                        LevelButtonInstance5CurrentButtonCategoryStateSecondValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                        setLevelButtonInstance6CurrentButtonCategoryStateSecondValue = true;
                        LevelButtonInstance6CurrentButtonCategoryStateSecondValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                        setLevelButtonInstance7CurrentButtonCategoryStateSecondValue = true;
                        LevelButtonInstance7CurrentButtonCategoryStateSecondValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                        setLevelButtonInstance7XSecondValue = true;
                        LevelButtonInstance7XSecondValue = 1614f;
                        setLevelButtonInstance7YSecondValue = true;
                        LevelButtonInstance7YSecondValue = 716f;
                        setLevelButtonInstance8CurrentButtonCategoryStateSecondValue = true;
                        LevelButtonInstance8CurrentButtonCategoryStateSecondValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                        setLevelButtonInstance9CurrentButtonCategoryStateSecondValue = true;
                        LevelButtonInstance9CurrentButtonCategoryStateSecondValue = AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime.ButtonCategory.Enabled;
                        if (interpolationValue >= 1)
                        {
                            this.MenuWindowInstance.Visible = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.OptionsButtonInstance.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ScreenDimRectangle.Visible = true;
                        }
                        break;
                }
                if (setLevelButtonInstance1CurrentButtonCategoryStateFirstValue && setLevelButtonInstance1CurrentButtonCategoryStateSecondValue)
                {
                    LevelButtonInstance1.InterpolateBetween(LevelButtonInstance1CurrentButtonCategoryStateFirstValue, LevelButtonInstance1CurrentButtonCategoryStateSecondValue, interpolationValue);
                }
                if (setLevelButtonInstance1XFirstValue && setLevelButtonInstance1XSecondValue)
                {
                    LevelButtonInstance1.X = LevelButtonInstance1XFirstValue * (1 - interpolationValue) + LevelButtonInstance1XSecondValue * interpolationValue;
                }
                if (setLevelButtonInstance1YFirstValue && setLevelButtonInstance1YSecondValue)
                {
                    LevelButtonInstance1.Y = LevelButtonInstance1YFirstValue * (1 - interpolationValue) + LevelButtonInstance1YSecondValue * interpolationValue;
                }
                if (setLevelButtonInstance10CurrentButtonCategoryStateFirstValue && setLevelButtonInstance10CurrentButtonCategoryStateSecondValue)
                {
                    LevelButtonInstance10.InterpolateBetween(LevelButtonInstance10CurrentButtonCategoryStateFirstValue, LevelButtonInstance10CurrentButtonCategoryStateSecondValue, interpolationValue);
                }
                if (setLevelButtonInstance2CurrentButtonCategoryStateFirstValue && setLevelButtonInstance2CurrentButtonCategoryStateSecondValue)
                {
                    LevelButtonInstance2.InterpolateBetween(LevelButtonInstance2CurrentButtonCategoryStateFirstValue, LevelButtonInstance2CurrentButtonCategoryStateSecondValue, interpolationValue);
                }
                if (setLevelButtonInstance3CurrentButtonCategoryStateFirstValue && setLevelButtonInstance3CurrentButtonCategoryStateSecondValue)
                {
                    LevelButtonInstance3.InterpolateBetween(LevelButtonInstance3CurrentButtonCategoryStateFirstValue, LevelButtonInstance3CurrentButtonCategoryStateSecondValue, interpolationValue);
                }
                if (setLevelButtonInstance4CurrentButtonCategoryStateFirstValue && setLevelButtonInstance4CurrentButtonCategoryStateSecondValue)
                {
                    LevelButtonInstance4.InterpolateBetween(LevelButtonInstance4CurrentButtonCategoryStateFirstValue, LevelButtonInstance4CurrentButtonCategoryStateSecondValue, interpolationValue);
                }
                if (setLevelButtonInstance5CurrentButtonCategoryStateFirstValue && setLevelButtonInstance5CurrentButtonCategoryStateSecondValue)
                {
                    LevelButtonInstance5.InterpolateBetween(LevelButtonInstance5CurrentButtonCategoryStateFirstValue, LevelButtonInstance5CurrentButtonCategoryStateSecondValue, interpolationValue);
                }
                if (setLevelButtonInstance6CurrentButtonCategoryStateFirstValue && setLevelButtonInstance6CurrentButtonCategoryStateSecondValue)
                {
                    LevelButtonInstance6.InterpolateBetween(LevelButtonInstance6CurrentButtonCategoryStateFirstValue, LevelButtonInstance6CurrentButtonCategoryStateSecondValue, interpolationValue);
                }
                if (setLevelButtonInstance7CurrentButtonCategoryStateFirstValue && setLevelButtonInstance7CurrentButtonCategoryStateSecondValue)
                {
                    LevelButtonInstance7.InterpolateBetween(LevelButtonInstance7CurrentButtonCategoryStateFirstValue, LevelButtonInstance7CurrentButtonCategoryStateSecondValue, interpolationValue);
                }
                if (setLevelButtonInstance7XFirstValue && setLevelButtonInstance7XSecondValue)
                {
                    LevelButtonInstance7.X = LevelButtonInstance7XFirstValue * (1 - interpolationValue) + LevelButtonInstance7XSecondValue * interpolationValue;
                }
                if (setLevelButtonInstance7YFirstValue && setLevelButtonInstance7YSecondValue)
                {
                    LevelButtonInstance7.Y = LevelButtonInstance7YFirstValue * (1 - interpolationValue) + LevelButtonInstance7YSecondValue * interpolationValue;
                }
                if (setLevelButtonInstance8CurrentButtonCategoryStateFirstValue && setLevelButtonInstance8CurrentButtonCategoryStateSecondValue)
                {
                    LevelButtonInstance8.InterpolateBetween(LevelButtonInstance8CurrentButtonCategoryStateFirstValue, LevelButtonInstance8CurrentButtonCategoryStateSecondValue, interpolationValue);
                }
                if (setLevelButtonInstance9CurrentButtonCategoryStateFirstValue && setLevelButtonInstance9CurrentButtonCategoryStateSecondValue)
                {
                    LevelButtonInstance9.InterpolateBetween(LevelButtonInstance9CurrentButtonCategoryStateFirstValue, LevelButtonInstance9CurrentButtonCategoryStateSecondValue, interpolationValue);
                }
                if (interpolationValue < 1)
                {
                    mCurrentMenuDisplayState = firstState;
                }
                else
                {
                    mCurrentMenuDisplayState = secondState;
                }
            }
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.MapScreenGumRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.MapScreenGumRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.MapScreenGumRuntime.MenuDisplay fromState,AbbatoirIntergrade.GumRuntimes.MapScreenGumRuntime.MenuDisplay toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (MenuDisplay toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "MenuDisplay").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentMenuDisplayState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (MenuDisplay toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentMenuDisplayState = toState;
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
                TechnologyTreeInstance.StopAnimations();
                LevelButtonInstance1.StopAnimations();
                LevelButtonInstance2.StopAnimations();
                LevelButtonInstance3.StopAnimations();
                LevelButtonInstance4.StopAnimations();
                LevelButtonInstance5.StopAnimations();
                LevelButtonInstance6.StopAnimations();
                LevelButtonInstance7.StopAnimations();
                LevelButtonInstance8.StopAnimations();
                LevelButtonInstance9.StopAnimations();
                LevelButtonInstance10.StopAnimations();
                OptionsButtonInstance.StopAnimations();
                MenuWindowInstance.StopAnimations();
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
                            Name = "SpriteInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = SpriteInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.SourceFile",
                            Type = "string",
                            Value = SpriteInstance.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = SpriteInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TechnologyTreeInstance.Visible",
                            Type = "bool",
                            Value = TechnologyTreeInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance1.LevelNumberState",
                            Type = "LevelNumberState",
                            Value = LevelButtonInstance1.CurrentLevelNumberState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance1.X",
                            Type = "float",
                            Value = LevelButtonInstance1.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance1.Y",
                            Type = "float",
                            Value = LevelButtonInstance1.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance2.LevelNumberState",
                            Type = "LevelNumberState",
                            Value = LevelButtonInstance2.CurrentLevelNumberState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance2.X",
                            Type = "float",
                            Value = LevelButtonInstance2.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance2.Y",
                            Type = "float",
                            Value = LevelButtonInstance2.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance3.LevelNumberState",
                            Type = "LevelNumberState",
                            Value = LevelButtonInstance3.CurrentLevelNumberState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance3.X",
                            Type = "float",
                            Value = LevelButtonInstance3.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance3.Y",
                            Type = "float",
                            Value = LevelButtonInstance3.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance4.LevelNumberState",
                            Type = "LevelNumberState",
                            Value = LevelButtonInstance4.CurrentLevelNumberState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance4.X",
                            Type = "float",
                            Value = LevelButtonInstance4.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance4.Y",
                            Type = "float",
                            Value = LevelButtonInstance4.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance5.LevelNumberState",
                            Type = "LevelNumberState",
                            Value = LevelButtonInstance5.CurrentLevelNumberState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance5.X",
                            Type = "float",
                            Value = LevelButtonInstance5.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance5.Y",
                            Type = "float",
                            Value = LevelButtonInstance5.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance6.LevelNumberState",
                            Type = "LevelNumberState",
                            Value = LevelButtonInstance6.CurrentLevelNumberState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance6.X",
                            Type = "float",
                            Value = LevelButtonInstance6.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance6.Y",
                            Type = "float",
                            Value = LevelButtonInstance6.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance7.LevelNumberState",
                            Type = "LevelNumberState",
                            Value = LevelButtonInstance7.CurrentLevelNumberState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance7.X",
                            Type = "float",
                            Value = LevelButtonInstance7.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance7.Y",
                            Type = "float",
                            Value = LevelButtonInstance7.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance8.LevelNumberState",
                            Type = "LevelNumberState",
                            Value = LevelButtonInstance8.CurrentLevelNumberState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance8.X",
                            Type = "float",
                            Value = LevelButtonInstance8.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance8.Y",
                            Type = "float",
                            Value = LevelButtonInstance8.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance9.LevelNumberState",
                            Type = "LevelNumberState",
                            Value = LevelButtonInstance9.CurrentLevelNumberState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance9.X",
                            Type = "float",
                            Value = LevelButtonInstance9.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance9.Y",
                            Type = "float",
                            Value = LevelButtonInstance9.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance10.LevelNumberState",
                            Type = "LevelNumberState",
                            Value = LevelButtonInstance10.CurrentLevelNumberState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance10.X",
                            Type = "float",
                            Value = LevelButtonInstance10.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance10.Y",
                            Type = "float",
                            Value = LevelButtonInstance10.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionsButtonInstance.Height",
                            Type = "float",
                            Value = OptionsButtonInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionsButtonInstance.Width",
                            Type = "float",
                            Value = OptionsButtonInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScreenDimRectangle.Alpha",
                            Type = "int",
                            Value = ScreenDimRectangle.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScreenDimRectangle.Blue",
                            Type = "int",
                            Value = ScreenDimRectangle.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScreenDimRectangle.Green",
                            Type = "int",
                            Value = ScreenDimRectangle.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScreenDimRectangle.Height",
                            Type = "float",
                            Value = ScreenDimRectangle.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScreenDimRectangle.Height Units",
                            Type = "DimensionUnitType",
                            Value = ScreenDimRectangle.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScreenDimRectangle.Red",
                            Type = "int",
                            Value = ScreenDimRectangle.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScreenDimRectangle.Width",
                            Type = "float",
                            Value = ScreenDimRectangle.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScreenDimRectangle.Width Units",
                            Type = "DimensionUnitType",
                            Value = ScreenDimRectangle.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MenuWindowInstance.ButtonType1State",
                            Type = "ButtonTypeState",
                            Value = MenuWindowInstance.ButtonType1State
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MenuWindowInstance.ButtonType2State",
                            Type = "ButtonTypeState",
                            Value = MenuWindowInstance.ButtonType2State
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MenuWindowInstance.ButtonType3State",
                            Type = "ButtonTypeState",
                            Value = MenuWindowInstance.ButtonType3State
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MenuWindowInstance.ButtonType4State",
                            Type = "ButtonTypeState",
                            Value = MenuWindowInstance.ButtonType4State
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
                            Name = "SpriteInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = SpriteInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.SourceFile",
                            Type = "string",
                            Value = SpriteInstance.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpriteInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = SpriteInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TechnologyTreeInstance.Visible",
                            Type = "bool",
                            Value = TechnologyTreeInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance1.LevelNumberState",
                            Type = "LevelNumberState",
                            Value = LevelButtonInstance1.CurrentLevelNumberState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance1.X",
                            Type = "float",
                            Value = LevelButtonInstance1.X + 128f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance1.Y",
                            Type = "float",
                            Value = LevelButtonInstance1.Y + 1258f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance2.LevelNumberState",
                            Type = "LevelNumberState",
                            Value = LevelButtonInstance2.CurrentLevelNumberState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance2.X",
                            Type = "float",
                            Value = LevelButtonInstance2.X + 98f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance2.Y",
                            Type = "float",
                            Value = LevelButtonInstance2.Y + 918f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance3.LevelNumberState",
                            Type = "LevelNumberState",
                            Value = LevelButtonInstance3.CurrentLevelNumberState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance3.X",
                            Type = "float",
                            Value = LevelButtonInstance3.X + 268f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance3.Y",
                            Type = "float",
                            Value = LevelButtonInstance3.Y + 626f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance4.LevelNumberState",
                            Type = "LevelNumberState",
                            Value = LevelButtonInstance4.CurrentLevelNumberState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance4.X",
                            Type = "float",
                            Value = LevelButtonInstance4.X + 540f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance4.Y",
                            Type = "float",
                            Value = LevelButtonInstance4.Y + 408f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance5.LevelNumberState",
                            Type = "LevelNumberState",
                            Value = LevelButtonInstance5.CurrentLevelNumberState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance5.X",
                            Type = "float",
                            Value = LevelButtonInstance5.X + 926f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance5.Y",
                            Type = "float",
                            Value = LevelButtonInstance5.Y + 370f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance6.LevelNumberState",
                            Type = "LevelNumberState",
                            Value = LevelButtonInstance6.CurrentLevelNumberState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance6.X",
                            Type = "float",
                            Value = LevelButtonInstance6.X + 1268f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance6.Y",
                            Type = "float",
                            Value = LevelButtonInstance6.Y + 552f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance7.LevelNumberState",
                            Type = "LevelNumberState",
                            Value = LevelButtonInstance7.CurrentLevelNumberState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance7.X",
                            Type = "float",
                            Value = LevelButtonInstance7.X + 1614f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance7.Y",
                            Type = "float",
                            Value = LevelButtonInstance7.Y + 716f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance8.LevelNumberState",
                            Type = "LevelNumberState",
                            Value = LevelButtonInstance8.CurrentLevelNumberState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance8.X",
                            Type = "float",
                            Value = LevelButtonInstance8.X + 1880f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance8.Y",
                            Type = "float",
                            Value = LevelButtonInstance8.Y + 576f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance9.LevelNumberState",
                            Type = "LevelNumberState",
                            Value = LevelButtonInstance9.CurrentLevelNumberState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance9.X",
                            Type = "float",
                            Value = LevelButtonInstance9.X + 2082f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance9.Y",
                            Type = "float",
                            Value = LevelButtonInstance9.Y + 334f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance10.LevelNumberState",
                            Type = "LevelNumberState",
                            Value = LevelButtonInstance10.CurrentLevelNumberState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance10.X",
                            Type = "float",
                            Value = LevelButtonInstance10.X + 2328f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance10.Y",
                            Type = "float",
                            Value = LevelButtonInstance10.Y + 248f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionsButtonInstance.Height",
                            Type = "float",
                            Value = OptionsButtonInstance.Height + 10.08334f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionsButtonInstance.Width",
                            Type = "float",
                            Value = OptionsButtonInstance.Width + 5.703125f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScreenDimRectangle.Alpha",
                            Type = "int",
                            Value = ScreenDimRectangle.Alpha + 120
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScreenDimRectangle.Blue",
                            Type = "int",
                            Value = ScreenDimRectangle.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScreenDimRectangle.Green",
                            Type = "int",
                            Value = ScreenDimRectangle.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScreenDimRectangle.Height",
                            Type = "float",
                            Value = ScreenDimRectangle.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScreenDimRectangle.Height Units",
                            Type = "DimensionUnitType",
                            Value = ScreenDimRectangle.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScreenDimRectangle.Red",
                            Type = "int",
                            Value = ScreenDimRectangle.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScreenDimRectangle.Width",
                            Type = "float",
                            Value = ScreenDimRectangle.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScreenDimRectangle.Width Units",
                            Type = "DimensionUnitType",
                            Value = ScreenDimRectangle.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MenuWindowInstance.ButtonType1State",
                            Type = "ButtonTypeState",
                            Value = MenuWindowInstance.ButtonType1State
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MenuWindowInstance.ButtonType2State",
                            Type = "ButtonTypeState",
                            Value = MenuWindowInstance.ButtonType2State
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MenuWindowInstance.ButtonType3State",
                            Type = "ButtonTypeState",
                            Value = MenuWindowInstance.ButtonType3State
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MenuWindowInstance.ButtonType4State",
                            Type = "ButtonTypeState",
                            Value = MenuWindowInstance.ButtonType4State
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (MenuDisplay state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  MenuDisplay.MenuHidden:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance1.ButtonCategoryState",
                            Type = "ButtonCategoryState",
                            Value = LevelButtonInstance1.CurrentButtonCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance1.X",
                            Type = "float",
                            Value = LevelButtonInstance1.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance1.Y",
                            Type = "float",
                            Value = LevelButtonInstance1.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance2.ButtonCategoryState",
                            Type = "ButtonCategoryState",
                            Value = LevelButtonInstance2.CurrentButtonCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance3.ButtonCategoryState",
                            Type = "ButtonCategoryState",
                            Value = LevelButtonInstance3.CurrentButtonCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance4.ButtonCategoryState",
                            Type = "ButtonCategoryState",
                            Value = LevelButtonInstance4.CurrentButtonCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance5.ButtonCategoryState",
                            Type = "ButtonCategoryState",
                            Value = LevelButtonInstance5.CurrentButtonCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance6.ButtonCategoryState",
                            Type = "ButtonCategoryState",
                            Value = LevelButtonInstance6.CurrentButtonCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance7.ButtonCategoryState",
                            Type = "ButtonCategoryState",
                            Value = LevelButtonInstance7.CurrentButtonCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance7.X",
                            Type = "float",
                            Value = LevelButtonInstance7.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance7.Y",
                            Type = "float",
                            Value = LevelButtonInstance7.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance8.ButtonCategoryState",
                            Type = "ButtonCategoryState",
                            Value = LevelButtonInstance8.CurrentButtonCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance9.ButtonCategoryState",
                            Type = "ButtonCategoryState",
                            Value = LevelButtonInstance9.CurrentButtonCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance10.ButtonCategoryState",
                            Type = "ButtonCategoryState",
                            Value = LevelButtonInstance10.CurrentButtonCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionsButtonInstance.Visible",
                            Type = "bool",
                            Value = OptionsButtonInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScreenDimRectangle.Visible",
                            Type = "bool",
                            Value = ScreenDimRectangle.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MenuWindowInstance.Visible",
                            Type = "bool",
                            Value = MenuWindowInstance.Visible
                        }
                        );
                        break;
                    case  MenuDisplay.MenuShown:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance1.ButtonCategoryState",
                            Type = "ButtonCategoryState",
                            Value = LevelButtonInstance1.CurrentButtonCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance1.X",
                            Type = "float",
                            Value = LevelButtonInstance1.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance1.Y",
                            Type = "float",
                            Value = LevelButtonInstance1.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance2.ButtonCategoryState",
                            Type = "ButtonCategoryState",
                            Value = LevelButtonInstance2.CurrentButtonCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance3.ButtonCategoryState",
                            Type = "ButtonCategoryState",
                            Value = LevelButtonInstance3.CurrentButtonCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance4.ButtonCategoryState",
                            Type = "ButtonCategoryState",
                            Value = LevelButtonInstance4.CurrentButtonCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance5.ButtonCategoryState",
                            Type = "ButtonCategoryState",
                            Value = LevelButtonInstance5.CurrentButtonCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance6.ButtonCategoryState",
                            Type = "ButtonCategoryState",
                            Value = LevelButtonInstance6.CurrentButtonCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance7.ButtonCategoryState",
                            Type = "ButtonCategoryState",
                            Value = LevelButtonInstance7.CurrentButtonCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance7.X",
                            Type = "float",
                            Value = LevelButtonInstance7.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance7.Y",
                            Type = "float",
                            Value = LevelButtonInstance7.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance8.ButtonCategoryState",
                            Type = "ButtonCategoryState",
                            Value = LevelButtonInstance8.CurrentButtonCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance9.ButtonCategoryState",
                            Type = "ButtonCategoryState",
                            Value = LevelButtonInstance9.CurrentButtonCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance10.ButtonCategoryState",
                            Type = "ButtonCategoryState",
                            Value = LevelButtonInstance10.CurrentButtonCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionsButtonInstance.Visible",
                            Type = "bool",
                            Value = OptionsButtonInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScreenDimRectangle.Visible",
                            Type = "bool",
                            Value = ScreenDimRectangle.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MenuWindowInstance.Visible",
                            Type = "bool",
                            Value = MenuWindowInstance.Visible
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (MenuDisplay state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  MenuDisplay.MenuHidden:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance1.ButtonCategoryState",
                            Type = "ButtonCategoryState",
                            Value = LevelButtonInstance1.CurrentButtonCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance1.X",
                            Type = "float",
                            Value = LevelButtonInstance1.X + 102f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance1.Y",
                            Type = "float",
                            Value = LevelButtonInstance1.Y + 1236f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance2.ButtonCategoryState",
                            Type = "ButtonCategoryState",
                            Value = LevelButtonInstance2.CurrentButtonCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance3.ButtonCategoryState",
                            Type = "ButtonCategoryState",
                            Value = LevelButtonInstance3.CurrentButtonCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance4.ButtonCategoryState",
                            Type = "ButtonCategoryState",
                            Value = LevelButtonInstance4.CurrentButtonCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance5.ButtonCategoryState",
                            Type = "ButtonCategoryState",
                            Value = LevelButtonInstance5.CurrentButtonCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance6.ButtonCategoryState",
                            Type = "ButtonCategoryState",
                            Value = LevelButtonInstance6.CurrentButtonCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance7.ButtonCategoryState",
                            Type = "ButtonCategoryState",
                            Value = LevelButtonInstance7.CurrentButtonCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance7.X",
                            Type = "float",
                            Value = LevelButtonInstance7.X + 1568f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance7.Y",
                            Type = "float",
                            Value = LevelButtonInstance7.Y + 724f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance8.ButtonCategoryState",
                            Type = "ButtonCategoryState",
                            Value = LevelButtonInstance8.CurrentButtonCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance9.ButtonCategoryState",
                            Type = "ButtonCategoryState",
                            Value = LevelButtonInstance9.CurrentButtonCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance10.ButtonCategoryState",
                            Type = "ButtonCategoryState",
                            Value = LevelButtonInstance10.CurrentButtonCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionsButtonInstance.Visible",
                            Type = "bool",
                            Value = OptionsButtonInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScreenDimRectangle.Visible",
                            Type = "bool",
                            Value = ScreenDimRectangle.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MenuWindowInstance.Visible",
                            Type = "bool",
                            Value = MenuWindowInstance.Visible
                        }
                        );
                        break;
                    case  MenuDisplay.MenuShown:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance1.ButtonCategoryState",
                            Type = "ButtonCategoryState",
                            Value = LevelButtonInstance1.CurrentButtonCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance1.X",
                            Type = "float",
                            Value = LevelButtonInstance1.X + 128f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance1.Y",
                            Type = "float",
                            Value = LevelButtonInstance1.Y + 1258f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance2.ButtonCategoryState",
                            Type = "ButtonCategoryState",
                            Value = LevelButtonInstance2.CurrentButtonCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance3.ButtonCategoryState",
                            Type = "ButtonCategoryState",
                            Value = LevelButtonInstance3.CurrentButtonCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance4.ButtonCategoryState",
                            Type = "ButtonCategoryState",
                            Value = LevelButtonInstance4.CurrentButtonCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance5.ButtonCategoryState",
                            Type = "ButtonCategoryState",
                            Value = LevelButtonInstance5.CurrentButtonCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance6.ButtonCategoryState",
                            Type = "ButtonCategoryState",
                            Value = LevelButtonInstance6.CurrentButtonCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance7.ButtonCategoryState",
                            Type = "ButtonCategoryState",
                            Value = LevelButtonInstance7.CurrentButtonCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance7.X",
                            Type = "float",
                            Value = LevelButtonInstance7.X + 1614f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance7.Y",
                            Type = "float",
                            Value = LevelButtonInstance7.Y + 716f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance8.ButtonCategoryState",
                            Type = "ButtonCategoryState",
                            Value = LevelButtonInstance8.CurrentButtonCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance9.ButtonCategoryState",
                            Type = "ButtonCategoryState",
                            Value = LevelButtonInstance9.CurrentButtonCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LevelButtonInstance10.ButtonCategoryState",
                            Type = "ButtonCategoryState",
                            Value = LevelButtonInstance10.CurrentButtonCategoryState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionsButtonInstance.Visible",
                            Type = "bool",
                            Value = OptionsButtonInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScreenDimRectangle.Visible",
                            Type = "bool",
                            Value = ScreenDimRectangle.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MenuWindowInstance.Visible",
                            Type = "bool",
                            Value = MenuWindowInstance.Visible
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
                    else if (category.Name == "MenuDisplay")
                    {
                        if(state.Name == "MenuHidden") this.mCurrentMenuDisplayState = MenuDisplay.MenuHidden;
                        if(state.Name == "MenuShown") this.mCurrentMenuDisplayState = MenuDisplay.MenuShown;
                    }
                }
                base.ApplyState(state);
            }
            private AbbatoirIntergrade.GumRuntimes.SpriteRuntime SpriteInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TechnologyTreeRuntime TechnologyTreeInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime LevelButtonInstance1 { get; set; }
            private AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime LevelButtonInstance2 { get; set; }
            private AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime LevelButtonInstance3 { get; set; }
            private AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime LevelButtonInstance4 { get; set; }
            private AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime LevelButtonInstance5 { get; set; }
            private AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime LevelButtonInstance6 { get; set; }
            private AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime LevelButtonInstance7 { get; set; }
            private AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime LevelButtonInstance8 { get; set; }
            private AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime LevelButtonInstance9 { get; set; }
            private AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime LevelButtonInstance10 { get; set; }
            private AbbatoirIntergrade.GumRuntimes.OptionsButtonRuntime OptionsButtonInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ColoredRectangleRuntime ScreenDimRectangle { get; set; }
            private AbbatoirIntergrade.GumRuntimes.MenuWindowRuntime MenuWindowInstance { get; set; }
            public MapScreenGumRuntime (bool fullInstantiation = true) 
            {
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Screens.First(item => item.Name == "MapScreenGum");
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
                SpriteInstance = this.GetGraphicalUiElementByName("SpriteInstance") as AbbatoirIntergrade.GumRuntimes.SpriteRuntime;
                TechnologyTreeInstance = this.GetGraphicalUiElementByName("TechnologyTreeInstance") as AbbatoirIntergrade.GumRuntimes.TechnologyTreeRuntime;
                LevelButtonInstance1 = this.GetGraphicalUiElementByName("LevelButtonInstance1") as AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime;
                LevelButtonInstance2 = this.GetGraphicalUiElementByName("LevelButtonInstance2") as AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime;
                LevelButtonInstance3 = this.GetGraphicalUiElementByName("LevelButtonInstance3") as AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime;
                LevelButtonInstance4 = this.GetGraphicalUiElementByName("LevelButtonInstance4") as AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime;
                LevelButtonInstance5 = this.GetGraphicalUiElementByName("LevelButtonInstance5") as AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime;
                LevelButtonInstance6 = this.GetGraphicalUiElementByName("LevelButtonInstance6") as AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime;
                LevelButtonInstance7 = this.GetGraphicalUiElementByName("LevelButtonInstance7") as AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime;
                LevelButtonInstance8 = this.GetGraphicalUiElementByName("LevelButtonInstance8") as AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime;
                LevelButtonInstance9 = this.GetGraphicalUiElementByName("LevelButtonInstance9") as AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime;
                LevelButtonInstance10 = this.GetGraphicalUiElementByName("LevelButtonInstance10") as AbbatoirIntergrade.GumRuntimes.LevelButtonRuntime;
                OptionsButtonInstance = this.GetGraphicalUiElementByName("OptionsButtonInstance") as AbbatoirIntergrade.GumRuntimes.OptionsButtonRuntime;
                ScreenDimRectangle = this.GetGraphicalUiElementByName("ScreenDimRectangle") as AbbatoirIntergrade.GumRuntimes.ColoredRectangleRuntime;
                MenuWindowInstance = this.GetGraphicalUiElementByName("MenuWindowInstance") as AbbatoirIntergrade.GumRuntimes.MenuWindowRuntime;
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
