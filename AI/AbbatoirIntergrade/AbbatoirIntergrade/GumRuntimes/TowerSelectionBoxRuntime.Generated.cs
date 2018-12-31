    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes
    {
        public partial class TowerSelectionBoxRuntime : AbbatoirIntergrade.GumRuntimes.ContainerRuntime
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            public enum SelectionMode
            {
                Single,
                Double
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            SelectionMode? mCurrentSelectionModeState;
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
                            Height = 100f;
                            HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            Width = 100f;
                            WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            LargeInfoFrameInstance.Height = 75f;
                            LargeInfoFrameInstance.Width = 75f;
                            LargeInfoFrameInstance.X = 0f;
                            LargeInfoFrameInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            LargeInfoFrameInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            LargeInfoFrameInstance.Y = 0f;
                            LargeInfoFrameInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            LargeInfoFrameInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            StructureChoice1.CurrentUpgradeAvailabilityState = AbbatoirIntergrade.GumRuntimes.infodisplays.StructureInfoRuntime.UpgradeAvailability.NotAvailable;
                            StructureChoice1.X = -450f;
                            StructureChoice1.Y = -100f;
                            StructureChoice2.CurrentUpgradeAvailabilityState = AbbatoirIntergrade.GumRuntimes.infodisplays.StructureInfoRuntime.UpgradeAvailability.NotAvailable;
                            StructureChoice2.X = 450f;
                            StructureChoice2.Y = -100f;
                            SetProperty("InstructionsText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                            InstructionsText.Height = 138f;
                            InstructionsText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            InstructionsText.Text = "We have time to develop one new defense!  \n\nChoose one:";
                            InstructionsText.UseCustomFont = true;
                            InstructionsText.Width = 1492f;
                            InstructionsText.X = 537f;
                            InstructionsText.Y = 252f;
                            SetProperty("TextInstance.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                            TextInstance.Height = 0f;
                            TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            TextInstance.Text = "|\nOR\n|";
                            TextInstance.UseCustomFont = true;
                            TextInstance.Width = 160f;
                            TextInstance.X = 0f;
                            TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            TextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            TextInstance.Y = 639f;
                            ConfirmButton.CurrentButtonTypeState = AbbatoirIntergrade.GumRuntimes.frames.ButtonFrameRuntime.ButtonType.Check;
                            ConfirmButton.Visible = false;
                            ConfirmButton.X = 0f;
                            ConfirmButton.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            ConfirmButton.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            ConfirmButton.Y = 841f;
                            break;
                    }
                }
            }
            public SelectionMode? CurrentSelectionModeState
            {
                get
                {
                    return mCurrentSelectionModeState;
                }
                set
                {
                    if (value != null)
                    {
                        mCurrentSelectionModeState = value;
                        switch(mCurrentSelectionModeState)
                        {
                            case  SelectionMode.Single:
                                StructureChoice1.CurrentSelectionState = AbbatoirIntergrade.GumRuntimes.infodisplays.StructureInfoRuntime.Selection.Selected;
                                StructureChoice1.X = -4f;
                                StructureChoice1.Y = -23.6349f;
                                StructureChoice2.Visible = false;
                                InstructionsText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                                InstructionsText.Text = "We have developed our final defense:";
                                InstructionsText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                                TextInstance.Visible = false;
                                ConfirmButton.Visible = true;
                                ConfirmButton.X = 581f;
                                ConfirmButton.Y = 843f;
                                break;
                            case  SelectionMode.Double:
                                StructureChoice1.CurrentSelectionState = AbbatoirIntergrade.GumRuntimes.infodisplays.StructureInfoRuntime.Selection.Selected;
                                StructureChoice1.X = -450f;
                                StructureChoice1.Y = -100f;
                                StructureChoice2.Visible = true;
                                InstructionsText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                                InstructionsText.Text = "We have time to develop one new defense!  \n\nChoose one:";
                                InstructionsText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Top;
                                TextInstance.Visible = true;
                                ConfirmButton.Visible = false;
                                ConfirmButton.X = 0f;
                                ConfirmButton.Y = 841f;
                                break;
                        }
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
                bool setConfirmButtonCurrentButtonTypeStateFirstValue = false;
                bool setConfirmButtonCurrentButtonTypeStateSecondValue = false;
                AbbatoirIntergrade.GumRuntimes.frames.ButtonFrameRuntime.ButtonType ConfirmButtonCurrentButtonTypeStateFirstValue= AbbatoirIntergrade.GumRuntimes.frames.ButtonFrameRuntime.ButtonType.Check;
                AbbatoirIntergrade.GumRuntimes.frames.ButtonFrameRuntime.ButtonType ConfirmButtonCurrentButtonTypeStateSecondValue= AbbatoirIntergrade.GumRuntimes.frames.ButtonFrameRuntime.ButtonType.Check;
                bool setConfirmButtonXFirstValue = false;
                bool setConfirmButtonXSecondValue = false;
                float ConfirmButtonXFirstValue= 0;
                float ConfirmButtonXSecondValue= 0;
                bool setConfirmButtonYFirstValue = false;
                bool setConfirmButtonYSecondValue = false;
                float ConfirmButtonYFirstValue= 0;
                float ConfirmButtonYSecondValue= 0;
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setInstructionsTextHeightFirstValue = false;
                bool setInstructionsTextHeightSecondValue = false;
                float InstructionsTextHeightFirstValue= 0;
                float InstructionsTextHeightSecondValue= 0;
                bool setInstructionsTextWidthFirstValue = false;
                bool setInstructionsTextWidthSecondValue = false;
                float InstructionsTextWidthFirstValue= 0;
                float InstructionsTextWidthSecondValue= 0;
                bool setInstructionsTextXFirstValue = false;
                bool setInstructionsTextXSecondValue = false;
                float InstructionsTextXFirstValue= 0;
                float InstructionsTextXSecondValue= 0;
                bool setInstructionsTextYFirstValue = false;
                bool setInstructionsTextYSecondValue = false;
                float InstructionsTextYFirstValue= 0;
                float InstructionsTextYSecondValue= 0;
                bool setLargeInfoFrameInstanceHeightFirstValue = false;
                bool setLargeInfoFrameInstanceHeightSecondValue = false;
                float LargeInfoFrameInstanceHeightFirstValue= 0;
                float LargeInfoFrameInstanceHeightSecondValue= 0;
                bool setLargeInfoFrameInstanceWidthFirstValue = false;
                bool setLargeInfoFrameInstanceWidthSecondValue = false;
                float LargeInfoFrameInstanceWidthFirstValue= 0;
                float LargeInfoFrameInstanceWidthSecondValue= 0;
                bool setLargeInfoFrameInstanceXFirstValue = false;
                bool setLargeInfoFrameInstanceXSecondValue = false;
                float LargeInfoFrameInstanceXFirstValue= 0;
                float LargeInfoFrameInstanceXSecondValue= 0;
                bool setLargeInfoFrameInstanceYFirstValue = false;
                bool setLargeInfoFrameInstanceYSecondValue = false;
                float LargeInfoFrameInstanceYFirstValue= 0;
                float LargeInfoFrameInstanceYSecondValue= 0;
                bool setStructureChoice1CurrentUpgradeAvailabilityStateFirstValue = false;
                bool setStructureChoice1CurrentUpgradeAvailabilityStateSecondValue = false;
                AbbatoirIntergrade.GumRuntimes.infodisplays.StructureInfoRuntime.UpgradeAvailability StructureChoice1CurrentUpgradeAvailabilityStateFirstValue= AbbatoirIntergrade.GumRuntimes.infodisplays.StructureInfoRuntime.UpgradeAvailability.Available;
                AbbatoirIntergrade.GumRuntimes.infodisplays.StructureInfoRuntime.UpgradeAvailability StructureChoice1CurrentUpgradeAvailabilityStateSecondValue= AbbatoirIntergrade.GumRuntimes.infodisplays.StructureInfoRuntime.UpgradeAvailability.Available;
                bool setStructureChoice1XFirstValue = false;
                bool setStructureChoice1XSecondValue = false;
                float StructureChoice1XFirstValue= 0;
                float StructureChoice1XSecondValue= 0;
                bool setStructureChoice1YFirstValue = false;
                bool setStructureChoice1YSecondValue = false;
                float StructureChoice1YFirstValue= 0;
                float StructureChoice1YSecondValue= 0;
                bool setStructureChoice2CurrentUpgradeAvailabilityStateFirstValue = false;
                bool setStructureChoice2CurrentUpgradeAvailabilityStateSecondValue = false;
                AbbatoirIntergrade.GumRuntimes.infodisplays.StructureInfoRuntime.UpgradeAvailability StructureChoice2CurrentUpgradeAvailabilityStateFirstValue= AbbatoirIntergrade.GumRuntimes.infodisplays.StructureInfoRuntime.UpgradeAvailability.Available;
                AbbatoirIntergrade.GumRuntimes.infodisplays.StructureInfoRuntime.UpgradeAvailability StructureChoice2CurrentUpgradeAvailabilityStateSecondValue= AbbatoirIntergrade.GumRuntimes.infodisplays.StructureInfoRuntime.UpgradeAvailability.Available;
                bool setStructureChoice2XFirstValue = false;
                bool setStructureChoice2XSecondValue = false;
                float StructureChoice2XFirstValue= 0;
                float StructureChoice2XSecondValue= 0;
                bool setStructureChoice2YFirstValue = false;
                bool setStructureChoice2YSecondValue = false;
                float StructureChoice2YFirstValue= 0;
                float StructureChoice2YSecondValue= 0;
                bool setTextInstanceHeightFirstValue = false;
                bool setTextInstanceHeightSecondValue = false;
                float TextInstanceHeightFirstValue= 0;
                float TextInstanceHeightSecondValue= 0;
                bool setTextInstanceWidthFirstValue = false;
                bool setTextInstanceWidthSecondValue = false;
                float TextInstanceWidthFirstValue= 0;
                float TextInstanceWidthSecondValue= 0;
                bool setTextInstanceXFirstValue = false;
                bool setTextInstanceXSecondValue = false;
                float TextInstanceXFirstValue= 0;
                float TextInstanceXSecondValue= 0;
                bool setTextInstanceYFirstValue = false;
                bool setTextInstanceYSecondValue = false;
                float TextInstanceYFirstValue= 0;
                float TextInstanceYSecondValue= 0;
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setConfirmButtonCurrentButtonTypeStateFirstValue = true;
                        ConfirmButtonCurrentButtonTypeStateFirstValue = AbbatoirIntergrade.GumRuntimes.frames.ButtonFrameRuntime.ButtonType.Check;
                        if (interpolationValue < 1)
                        {
                            this.ConfirmButton.Visible = false;
                        }
                        setConfirmButtonXFirstValue = true;
                        ConfirmButtonXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ConfirmButton.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ConfirmButton.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setConfirmButtonYFirstValue = true;
                        ConfirmButtonYFirstValue = 841f;
                        setHeightFirstValue = true;
                        HeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("InstructionsText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setInstructionsTextHeightFirstValue = true;
                        InstructionsTextHeightFirstValue = 138f;
                        if (interpolationValue < 1)
                        {
                            this.InstructionsText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.InstructionsText.Text = "We have time to develop one new defense!  \n\nChoose one:";
                        }
                        if (interpolationValue < 1)
                        {
                            this.InstructionsText.UseCustomFont = true;
                        }
                        setInstructionsTextWidthFirstValue = true;
                        InstructionsTextWidthFirstValue = 1492f;
                        setInstructionsTextXFirstValue = true;
                        InstructionsTextXFirstValue = 537f;
                        setInstructionsTextYFirstValue = true;
                        InstructionsTextYFirstValue = 252f;
                        setLargeInfoFrameInstanceHeightFirstValue = true;
                        LargeInfoFrameInstanceHeightFirstValue = 75f;
                        setLargeInfoFrameInstanceWidthFirstValue = true;
                        LargeInfoFrameInstanceWidthFirstValue = 75f;
                        setLargeInfoFrameInstanceXFirstValue = true;
                        LargeInfoFrameInstanceXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.LargeInfoFrameInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.LargeInfoFrameInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setLargeInfoFrameInstanceYFirstValue = true;
                        LargeInfoFrameInstanceYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.LargeInfoFrameInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.LargeInfoFrameInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setStructureChoice1CurrentUpgradeAvailabilityStateFirstValue = true;
                        StructureChoice1CurrentUpgradeAvailabilityStateFirstValue = AbbatoirIntergrade.GumRuntimes.infodisplays.StructureInfoRuntime.UpgradeAvailability.NotAvailable;
                        setStructureChoice1XFirstValue = true;
                        StructureChoice1XFirstValue = -450f;
                        setStructureChoice1YFirstValue = true;
                        StructureChoice1YFirstValue = -100f;
                        setStructureChoice2CurrentUpgradeAvailabilityStateFirstValue = true;
                        StructureChoice2CurrentUpgradeAvailabilityStateFirstValue = AbbatoirIntergrade.GumRuntimes.infodisplays.StructureInfoRuntime.UpgradeAvailability.NotAvailable;
                        setStructureChoice2XFirstValue = true;
                        StructureChoice2XFirstValue = 450f;
                        setStructureChoice2YFirstValue = true;
                        StructureChoice2YFirstValue = -100f;
                        if (interpolationValue < 1)
                        {
                            SetProperty("TextInstance.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setTextInstanceHeightFirstValue = true;
                        TextInstanceHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.Text = "|\nOR\n|";
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.UseCustomFont = true;
                        }
                        setTextInstanceWidthFirstValue = true;
                        TextInstanceWidthFirstValue = 160f;
                        setTextInstanceXFirstValue = true;
                        TextInstanceXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setTextInstanceYFirstValue = true;
                        TextInstanceYFirstValue = 639f;
                        setWidthFirstValue = true;
                        WidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setConfirmButtonCurrentButtonTypeStateSecondValue = true;
                        ConfirmButtonCurrentButtonTypeStateSecondValue = AbbatoirIntergrade.GumRuntimes.frames.ButtonFrameRuntime.ButtonType.Check;
                        if (interpolationValue >= 1)
                        {
                            this.ConfirmButton.Visible = false;
                        }
                        setConfirmButtonXSecondValue = true;
                        ConfirmButtonXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ConfirmButton.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ConfirmButton.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setConfirmButtonYSecondValue = true;
                        ConfirmButtonYSecondValue = 841f;
                        setHeightSecondValue = true;
                        HeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("InstructionsText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setInstructionsTextHeightSecondValue = true;
                        InstructionsTextHeightSecondValue = 138f;
                        if (interpolationValue >= 1)
                        {
                            this.InstructionsText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.InstructionsText.Text = "We have time to develop one new defense!  \n\nChoose one:";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.InstructionsText.UseCustomFont = true;
                        }
                        setInstructionsTextWidthSecondValue = true;
                        InstructionsTextWidthSecondValue = 1492f;
                        setInstructionsTextXSecondValue = true;
                        InstructionsTextXSecondValue = 537f;
                        setInstructionsTextYSecondValue = true;
                        InstructionsTextYSecondValue = 252f;
                        setLargeInfoFrameInstanceHeightSecondValue = true;
                        LargeInfoFrameInstanceHeightSecondValue = 75f;
                        setLargeInfoFrameInstanceWidthSecondValue = true;
                        LargeInfoFrameInstanceWidthSecondValue = 75f;
                        setLargeInfoFrameInstanceXSecondValue = true;
                        LargeInfoFrameInstanceXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.LargeInfoFrameInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.LargeInfoFrameInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setLargeInfoFrameInstanceYSecondValue = true;
                        LargeInfoFrameInstanceYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.LargeInfoFrameInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.LargeInfoFrameInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setStructureChoice1CurrentUpgradeAvailabilityStateSecondValue = true;
                        StructureChoice1CurrentUpgradeAvailabilityStateSecondValue = AbbatoirIntergrade.GumRuntimes.infodisplays.StructureInfoRuntime.UpgradeAvailability.NotAvailable;
                        setStructureChoice1XSecondValue = true;
                        StructureChoice1XSecondValue = -450f;
                        setStructureChoice1YSecondValue = true;
                        StructureChoice1YSecondValue = -100f;
                        setStructureChoice2CurrentUpgradeAvailabilityStateSecondValue = true;
                        StructureChoice2CurrentUpgradeAvailabilityStateSecondValue = AbbatoirIntergrade.GumRuntimes.infodisplays.StructureInfoRuntime.UpgradeAvailability.NotAvailable;
                        setStructureChoice2XSecondValue = true;
                        StructureChoice2XSecondValue = 450f;
                        setStructureChoice2YSecondValue = true;
                        StructureChoice2YSecondValue = -100f;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("TextInstance.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setTextInstanceHeightSecondValue = true;
                        TextInstanceHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.Text = "|\nOR\n|";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.UseCustomFont = true;
                        }
                        setTextInstanceWidthSecondValue = true;
                        TextInstanceWidthSecondValue = 160f;
                        setTextInstanceXSecondValue = true;
                        TextInstanceXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setTextInstanceYSecondValue = true;
                        TextInstanceYSecondValue = 639f;
                        setWidthSecondValue = true;
                        WidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        break;
                }
                if (setConfirmButtonCurrentButtonTypeStateFirstValue && setConfirmButtonCurrentButtonTypeStateSecondValue)
                {
                    ConfirmButton.InterpolateBetween(ConfirmButtonCurrentButtonTypeStateFirstValue, ConfirmButtonCurrentButtonTypeStateSecondValue, interpolationValue);
                }
                if (setConfirmButtonXFirstValue && setConfirmButtonXSecondValue)
                {
                    ConfirmButton.X = ConfirmButtonXFirstValue * (1 - interpolationValue) + ConfirmButtonXSecondValue * interpolationValue;
                }
                if (setConfirmButtonYFirstValue && setConfirmButtonYSecondValue)
                {
                    ConfirmButton.Y = ConfirmButtonYFirstValue * (1 - interpolationValue) + ConfirmButtonYSecondValue * interpolationValue;
                }
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
                }
                if (setInstructionsTextHeightFirstValue && setInstructionsTextHeightSecondValue)
                {
                    InstructionsText.Height = InstructionsTextHeightFirstValue * (1 - interpolationValue) + InstructionsTextHeightSecondValue * interpolationValue;
                }
                if (setInstructionsTextWidthFirstValue && setInstructionsTextWidthSecondValue)
                {
                    InstructionsText.Width = InstructionsTextWidthFirstValue * (1 - interpolationValue) + InstructionsTextWidthSecondValue * interpolationValue;
                }
                if (setInstructionsTextXFirstValue && setInstructionsTextXSecondValue)
                {
                    InstructionsText.X = InstructionsTextXFirstValue * (1 - interpolationValue) + InstructionsTextXSecondValue * interpolationValue;
                }
                if (setInstructionsTextYFirstValue && setInstructionsTextYSecondValue)
                {
                    InstructionsText.Y = InstructionsTextYFirstValue * (1 - interpolationValue) + InstructionsTextYSecondValue * interpolationValue;
                }
                if (setLargeInfoFrameInstanceHeightFirstValue && setLargeInfoFrameInstanceHeightSecondValue)
                {
                    LargeInfoFrameInstance.Height = LargeInfoFrameInstanceHeightFirstValue * (1 - interpolationValue) + LargeInfoFrameInstanceHeightSecondValue * interpolationValue;
                }
                if (setLargeInfoFrameInstanceWidthFirstValue && setLargeInfoFrameInstanceWidthSecondValue)
                {
                    LargeInfoFrameInstance.Width = LargeInfoFrameInstanceWidthFirstValue * (1 - interpolationValue) + LargeInfoFrameInstanceWidthSecondValue * interpolationValue;
                }
                if (setLargeInfoFrameInstanceXFirstValue && setLargeInfoFrameInstanceXSecondValue)
                {
                    LargeInfoFrameInstance.X = LargeInfoFrameInstanceXFirstValue * (1 - interpolationValue) + LargeInfoFrameInstanceXSecondValue * interpolationValue;
                }
                if (setLargeInfoFrameInstanceYFirstValue && setLargeInfoFrameInstanceYSecondValue)
                {
                    LargeInfoFrameInstance.Y = LargeInfoFrameInstanceYFirstValue * (1 - interpolationValue) + LargeInfoFrameInstanceYSecondValue * interpolationValue;
                }
                if (setStructureChoice1CurrentUpgradeAvailabilityStateFirstValue && setStructureChoice1CurrentUpgradeAvailabilityStateSecondValue)
                {
                    StructureChoice1.InterpolateBetween(StructureChoice1CurrentUpgradeAvailabilityStateFirstValue, StructureChoice1CurrentUpgradeAvailabilityStateSecondValue, interpolationValue);
                }
                if (setStructureChoice1XFirstValue && setStructureChoice1XSecondValue)
                {
                    StructureChoice1.X = StructureChoice1XFirstValue * (1 - interpolationValue) + StructureChoice1XSecondValue * interpolationValue;
                }
                if (setStructureChoice1YFirstValue && setStructureChoice1YSecondValue)
                {
                    StructureChoice1.Y = StructureChoice1YFirstValue * (1 - interpolationValue) + StructureChoice1YSecondValue * interpolationValue;
                }
                if (setStructureChoice2CurrentUpgradeAvailabilityStateFirstValue && setStructureChoice2CurrentUpgradeAvailabilityStateSecondValue)
                {
                    StructureChoice2.InterpolateBetween(StructureChoice2CurrentUpgradeAvailabilityStateFirstValue, StructureChoice2CurrentUpgradeAvailabilityStateSecondValue, interpolationValue);
                }
                if (setStructureChoice2XFirstValue && setStructureChoice2XSecondValue)
                {
                    StructureChoice2.X = StructureChoice2XFirstValue * (1 - interpolationValue) + StructureChoice2XSecondValue * interpolationValue;
                }
                if (setStructureChoice2YFirstValue && setStructureChoice2YSecondValue)
                {
                    StructureChoice2.Y = StructureChoice2YFirstValue * (1 - interpolationValue) + StructureChoice2YSecondValue * interpolationValue;
                }
                if (setTextInstanceHeightFirstValue && setTextInstanceHeightSecondValue)
                {
                    TextInstance.Height = TextInstanceHeightFirstValue * (1 - interpolationValue) + TextInstanceHeightSecondValue * interpolationValue;
                }
                if (setTextInstanceWidthFirstValue && setTextInstanceWidthSecondValue)
                {
                    TextInstance.Width = TextInstanceWidthFirstValue * (1 - interpolationValue) + TextInstanceWidthSecondValue * interpolationValue;
                }
                if (setTextInstanceXFirstValue && setTextInstanceXSecondValue)
                {
                    TextInstance.X = TextInstanceXFirstValue * (1 - interpolationValue) + TextInstanceXSecondValue * interpolationValue;
                }
                if (setTextInstanceYFirstValue && setTextInstanceYSecondValue)
                {
                    TextInstance.Y = TextInstanceYFirstValue * (1 - interpolationValue) + TextInstanceYSecondValue * interpolationValue;
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
            public void InterpolateBetween (SelectionMode firstState, SelectionMode secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setConfirmButtonXFirstValue = false;
                bool setConfirmButtonXSecondValue = false;
                float ConfirmButtonXFirstValue= 0;
                float ConfirmButtonXSecondValue= 0;
                bool setConfirmButtonYFirstValue = false;
                bool setConfirmButtonYSecondValue = false;
                float ConfirmButtonYFirstValue= 0;
                float ConfirmButtonYSecondValue= 0;
                bool setStructureChoice1CurrentSelectionStateFirstValue = false;
                bool setStructureChoice1CurrentSelectionStateSecondValue = false;
                AbbatoirIntergrade.GumRuntimes.infodisplays.StructureInfoRuntime.Selection StructureChoice1CurrentSelectionStateFirstValue= AbbatoirIntergrade.GumRuntimes.infodisplays.StructureInfoRuntime.Selection.Selected;
                AbbatoirIntergrade.GumRuntimes.infodisplays.StructureInfoRuntime.Selection StructureChoice1CurrentSelectionStateSecondValue= AbbatoirIntergrade.GumRuntimes.infodisplays.StructureInfoRuntime.Selection.Selected;
                bool setStructureChoice1XFirstValue = false;
                bool setStructureChoice1XSecondValue = false;
                float StructureChoice1XFirstValue= 0;
                float StructureChoice1XSecondValue= 0;
                bool setStructureChoice1YFirstValue = false;
                bool setStructureChoice1YSecondValue = false;
                float StructureChoice1YFirstValue= 0;
                float StructureChoice1YSecondValue= 0;
                switch(firstState)
                {
                    case  SelectionMode.Single:
                        if (interpolationValue < 1)
                        {
                            this.ConfirmButton.Visible = true;
                        }
                        setConfirmButtonXFirstValue = true;
                        ConfirmButtonXFirstValue = 581f;
                        setConfirmButtonYFirstValue = true;
                        ConfirmButtonYFirstValue = 843f;
                        if (interpolationValue < 1)
                        {
                            this.InstructionsText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.InstructionsText.Text = "We have developed our final defense:";
                        }
                        if (interpolationValue < 1)
                        {
                            this.InstructionsText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setStructureChoice1CurrentSelectionStateFirstValue = true;
                        StructureChoice1CurrentSelectionStateFirstValue = AbbatoirIntergrade.GumRuntimes.infodisplays.StructureInfoRuntime.Selection.Selected;
                        setStructureChoice1XFirstValue = true;
                        StructureChoice1XFirstValue = -4f;
                        setStructureChoice1YFirstValue = true;
                        StructureChoice1YFirstValue = -23.6349f;
                        if (interpolationValue < 1)
                        {
                            this.StructureChoice2.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.Visible = false;
                        }
                        break;
                    case  SelectionMode.Double:
                        if (interpolationValue < 1)
                        {
                            this.ConfirmButton.Visible = false;
                        }
                        setConfirmButtonXFirstValue = true;
                        ConfirmButtonXFirstValue = 0f;
                        setConfirmButtonYFirstValue = true;
                        ConfirmButtonYFirstValue = 841f;
                        if (interpolationValue < 1)
                        {
                            this.InstructionsText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.InstructionsText.Text = "We have time to develop one new defense!  \n\nChoose one:";
                        }
                        if (interpolationValue < 1)
                        {
                            this.InstructionsText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        setStructureChoice1CurrentSelectionStateFirstValue = true;
                        StructureChoice1CurrentSelectionStateFirstValue = AbbatoirIntergrade.GumRuntimes.infodisplays.StructureInfoRuntime.Selection.Selected;
                        setStructureChoice1XFirstValue = true;
                        StructureChoice1XFirstValue = -450f;
                        setStructureChoice1YFirstValue = true;
                        StructureChoice1YFirstValue = -100f;
                        if (interpolationValue < 1)
                        {
                            this.StructureChoice2.Visible = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.Visible = true;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  SelectionMode.Single:
                        if (interpolationValue >= 1)
                        {
                            this.ConfirmButton.Visible = true;
                        }
                        setConfirmButtonXSecondValue = true;
                        ConfirmButtonXSecondValue = 581f;
                        setConfirmButtonYSecondValue = true;
                        ConfirmButtonYSecondValue = 843f;
                        if (interpolationValue >= 1)
                        {
                            this.InstructionsText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.InstructionsText.Text = "We have developed our final defense:";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.InstructionsText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setStructureChoice1CurrentSelectionStateSecondValue = true;
                        StructureChoice1CurrentSelectionStateSecondValue = AbbatoirIntergrade.GumRuntimes.infodisplays.StructureInfoRuntime.Selection.Selected;
                        setStructureChoice1XSecondValue = true;
                        StructureChoice1XSecondValue = -4f;
                        setStructureChoice1YSecondValue = true;
                        StructureChoice1YSecondValue = -23.6349f;
                        if (interpolationValue >= 1)
                        {
                            this.StructureChoice2.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.Visible = false;
                        }
                        break;
                    case  SelectionMode.Double:
                        if (interpolationValue >= 1)
                        {
                            this.ConfirmButton.Visible = false;
                        }
                        setConfirmButtonXSecondValue = true;
                        ConfirmButtonXSecondValue = 0f;
                        setConfirmButtonYSecondValue = true;
                        ConfirmButtonYSecondValue = 841f;
                        if (interpolationValue >= 1)
                        {
                            this.InstructionsText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.InstructionsText.Text = "We have time to develop one new defense!  \n\nChoose one:";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.InstructionsText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        setStructureChoice1CurrentSelectionStateSecondValue = true;
                        StructureChoice1CurrentSelectionStateSecondValue = AbbatoirIntergrade.GumRuntimes.infodisplays.StructureInfoRuntime.Selection.Selected;
                        setStructureChoice1XSecondValue = true;
                        StructureChoice1XSecondValue = -450f;
                        setStructureChoice1YSecondValue = true;
                        StructureChoice1YSecondValue = -100f;
                        if (interpolationValue >= 1)
                        {
                            this.StructureChoice2.Visible = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.Visible = true;
                        }
                        break;
                }
                if (setConfirmButtonXFirstValue && setConfirmButtonXSecondValue)
                {
                    ConfirmButton.X = ConfirmButtonXFirstValue * (1 - interpolationValue) + ConfirmButtonXSecondValue * interpolationValue;
                }
                if (setConfirmButtonYFirstValue && setConfirmButtonYSecondValue)
                {
                    ConfirmButton.Y = ConfirmButtonYFirstValue * (1 - interpolationValue) + ConfirmButtonYSecondValue * interpolationValue;
                }
                if (setStructureChoice1CurrentSelectionStateFirstValue && setStructureChoice1CurrentSelectionStateSecondValue)
                {
                    StructureChoice1.InterpolateBetween(StructureChoice1CurrentSelectionStateFirstValue, StructureChoice1CurrentSelectionStateSecondValue, interpolationValue);
                }
                if (setStructureChoice1XFirstValue && setStructureChoice1XSecondValue)
                {
                    StructureChoice1.X = StructureChoice1XFirstValue * (1 - interpolationValue) + StructureChoice1XSecondValue * interpolationValue;
                }
                if (setStructureChoice1YFirstValue && setStructureChoice1YSecondValue)
                {
                    StructureChoice1.Y = StructureChoice1YFirstValue * (1 - interpolationValue) + StructureChoice1YSecondValue * interpolationValue;
                }
                if (interpolationValue < 1)
                {
                    mCurrentSelectionModeState = firstState;
                }
                else
                {
                    mCurrentSelectionModeState = secondState;
                }
            }
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.TowerSelectionBoxRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.TowerSelectionBoxRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.TowerSelectionBoxRuntime.SelectionMode fromState,AbbatoirIntergrade.GumRuntimes.TowerSelectionBoxRuntime.SelectionMode toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (SelectionMode toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "SelectionMode").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentSelectionModeState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (SelectionMode toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentSelectionModeState = toState;
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
                DimmingInstance.StopAnimations();
                LargeInfoFrameInstance.StopAnimations();
                StructureChoice1.StopAnimations();
                StructureChoice2.StopAnimations();
                ConfirmButton.StopAnimations();
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
                            Name = "LargeInfoFrameInstance.Height",
                            Type = "float",
                            Value = LargeInfoFrameInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LargeInfoFrameInstance.Width",
                            Type = "float",
                            Value = LargeInfoFrameInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LargeInfoFrameInstance.X",
                            Type = "float",
                            Value = LargeInfoFrameInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LargeInfoFrameInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = LargeInfoFrameInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LargeInfoFrameInstance.X Units",
                            Type = "PositionUnitType",
                            Value = LargeInfoFrameInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LargeInfoFrameInstance.Y",
                            Type = "float",
                            Value = LargeInfoFrameInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LargeInfoFrameInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = LargeInfoFrameInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LargeInfoFrameInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = LargeInfoFrameInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureChoice1.UpgradeAvailabilityState",
                            Type = "UpgradeAvailabilityState",
                            Value = StructureChoice1.CurrentUpgradeAvailabilityState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureChoice1.X",
                            Type = "float",
                            Value = StructureChoice1.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureChoice1.Y",
                            Type = "float",
                            Value = StructureChoice1.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureChoice2.UpgradeAvailabilityState",
                            Type = "UpgradeAvailabilityState",
                            Value = StructureChoice2.CurrentUpgradeAvailabilityState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureChoice2.X",
                            Type = "float",
                            Value = StructureChoice2.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureChoice2.Y",
                            Type = "float",
                            Value = StructureChoice2.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InstructionsText.CustomFontFile",
                            Type = "string",
                            Value = InstructionsText.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InstructionsText.Height",
                            Type = "float",
                            Value = InstructionsText.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InstructionsText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = InstructionsText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InstructionsText.Text",
                            Type = "string",
                            Value = InstructionsText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InstructionsText.UseCustomFont",
                            Type = "bool",
                            Value = InstructionsText.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InstructionsText.Width",
                            Type = "float",
                            Value = InstructionsText.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InstructionsText.X",
                            Type = "float",
                            Value = InstructionsText.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InstructionsText.Y",
                            Type = "float",
                            Value = InstructionsText.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.CustomFontFile",
                            Type = "string",
                            Value = TextInstance.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Height",
                            Type = "float",
                            Value = TextInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = TextInstance.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Text",
                            Type = "string",
                            Value = TextInstance.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.UseCustomFont",
                            Type = "bool",
                            Value = TextInstance.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Width",
                            Type = "float",
                            Value = TextInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.X",
                            Type = "float",
                            Value = TextInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = TextInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.X Units",
                            Type = "PositionUnitType",
                            Value = TextInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Y",
                            Type = "float",
                            Value = TextInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConfirmButton.ButtonTypeState",
                            Type = "ButtonTypeState",
                            Value = ConfirmButton.CurrentButtonTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConfirmButton.Visible",
                            Type = "bool",
                            Value = ConfirmButton.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConfirmButton.X",
                            Type = "float",
                            Value = ConfirmButton.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConfirmButton.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ConfirmButton.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConfirmButton.X Units",
                            Type = "PositionUnitType",
                            Value = ConfirmButton.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConfirmButton.Y",
                            Type = "float",
                            Value = ConfirmButton.Y
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
                            Name = "LargeInfoFrameInstance.Height",
                            Type = "float",
                            Value = LargeInfoFrameInstance.Height + 75f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LargeInfoFrameInstance.Width",
                            Type = "float",
                            Value = LargeInfoFrameInstance.Width + 75f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LargeInfoFrameInstance.X",
                            Type = "float",
                            Value = LargeInfoFrameInstance.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LargeInfoFrameInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = LargeInfoFrameInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LargeInfoFrameInstance.X Units",
                            Type = "PositionUnitType",
                            Value = LargeInfoFrameInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LargeInfoFrameInstance.Y",
                            Type = "float",
                            Value = LargeInfoFrameInstance.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LargeInfoFrameInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = LargeInfoFrameInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LargeInfoFrameInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = LargeInfoFrameInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureChoice1.UpgradeAvailabilityState",
                            Type = "UpgradeAvailabilityState",
                            Value = StructureChoice1.CurrentUpgradeAvailabilityState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureChoice1.X",
                            Type = "float",
                            Value = StructureChoice1.X + -450f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureChoice1.Y",
                            Type = "float",
                            Value = StructureChoice1.Y + -100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureChoice2.UpgradeAvailabilityState",
                            Type = "UpgradeAvailabilityState",
                            Value = StructureChoice2.CurrentUpgradeAvailabilityState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureChoice2.X",
                            Type = "float",
                            Value = StructureChoice2.X + 450f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureChoice2.Y",
                            Type = "float",
                            Value = StructureChoice2.Y + -100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InstructionsText.CustomFontFile",
                            Type = "string",
                            Value = InstructionsText.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InstructionsText.Height",
                            Type = "float",
                            Value = InstructionsText.Height + 138f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InstructionsText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = InstructionsText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InstructionsText.Text",
                            Type = "string",
                            Value = InstructionsText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InstructionsText.UseCustomFont",
                            Type = "bool",
                            Value = InstructionsText.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InstructionsText.Width",
                            Type = "float",
                            Value = InstructionsText.Width + 1492f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InstructionsText.X",
                            Type = "float",
                            Value = InstructionsText.X + 537f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InstructionsText.Y",
                            Type = "float",
                            Value = InstructionsText.Y + 252f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.CustomFontFile",
                            Type = "string",
                            Value = TextInstance.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Height",
                            Type = "float",
                            Value = TextInstance.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = TextInstance.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Text",
                            Type = "string",
                            Value = TextInstance.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.UseCustomFont",
                            Type = "bool",
                            Value = TextInstance.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Width",
                            Type = "float",
                            Value = TextInstance.Width + 160f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.X",
                            Type = "float",
                            Value = TextInstance.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = TextInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.X Units",
                            Type = "PositionUnitType",
                            Value = TextInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Y",
                            Type = "float",
                            Value = TextInstance.Y + 639f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConfirmButton.ButtonTypeState",
                            Type = "ButtonTypeState",
                            Value = ConfirmButton.CurrentButtonTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConfirmButton.Visible",
                            Type = "bool",
                            Value = ConfirmButton.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConfirmButton.X",
                            Type = "float",
                            Value = ConfirmButton.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConfirmButton.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ConfirmButton.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConfirmButton.X Units",
                            Type = "PositionUnitType",
                            Value = ConfirmButton.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConfirmButton.Y",
                            Type = "float",
                            Value = ConfirmButton.Y + 841f
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (SelectionMode state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  SelectionMode.Single:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureChoice1.SelectionState",
                            Type = "SelectionState",
                            Value = StructureChoice1.CurrentSelectionState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureChoice1.X",
                            Type = "float",
                            Value = StructureChoice1.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureChoice1.Y",
                            Type = "float",
                            Value = StructureChoice1.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureChoice2.Visible",
                            Type = "bool",
                            Value = StructureChoice2.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InstructionsText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = InstructionsText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InstructionsText.Text",
                            Type = "string",
                            Value = InstructionsText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InstructionsText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = InstructionsText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Visible",
                            Type = "bool",
                            Value = TextInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConfirmButton.Visible",
                            Type = "bool",
                            Value = ConfirmButton.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConfirmButton.X",
                            Type = "float",
                            Value = ConfirmButton.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConfirmButton.Y",
                            Type = "float",
                            Value = ConfirmButton.Y
                        }
                        );
                        break;
                    case  SelectionMode.Double:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureChoice1.SelectionState",
                            Type = "SelectionState",
                            Value = StructureChoice1.CurrentSelectionState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureChoice1.X",
                            Type = "float",
                            Value = StructureChoice1.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureChoice1.Y",
                            Type = "float",
                            Value = StructureChoice1.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureChoice2.Visible",
                            Type = "bool",
                            Value = StructureChoice2.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InstructionsText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = InstructionsText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InstructionsText.Text",
                            Type = "string",
                            Value = InstructionsText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InstructionsText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = InstructionsText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Visible",
                            Type = "bool",
                            Value = TextInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConfirmButton.Visible",
                            Type = "bool",
                            Value = ConfirmButton.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConfirmButton.X",
                            Type = "float",
                            Value = ConfirmButton.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConfirmButton.Y",
                            Type = "float",
                            Value = ConfirmButton.Y
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (SelectionMode state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  SelectionMode.Single:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureChoice1.SelectionState",
                            Type = "SelectionState",
                            Value = StructureChoice1.CurrentSelectionState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureChoice1.X",
                            Type = "float",
                            Value = StructureChoice1.X + -4f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureChoice1.Y",
                            Type = "float",
                            Value = StructureChoice1.Y + -23.6349f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureChoice2.Visible",
                            Type = "bool",
                            Value = StructureChoice2.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InstructionsText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = InstructionsText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InstructionsText.Text",
                            Type = "string",
                            Value = InstructionsText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InstructionsText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = InstructionsText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Visible",
                            Type = "bool",
                            Value = TextInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConfirmButton.Visible",
                            Type = "bool",
                            Value = ConfirmButton.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConfirmButton.X",
                            Type = "float",
                            Value = ConfirmButton.X + 581f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConfirmButton.Y",
                            Type = "float",
                            Value = ConfirmButton.Y + 843f
                        }
                        );
                        break;
                    case  SelectionMode.Double:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureChoice1.SelectionState",
                            Type = "SelectionState",
                            Value = StructureChoice1.CurrentSelectionState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureChoice1.X",
                            Type = "float",
                            Value = StructureChoice1.X + -450f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureChoice1.Y",
                            Type = "float",
                            Value = StructureChoice1.Y + -100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureChoice2.Visible",
                            Type = "bool",
                            Value = StructureChoice2.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InstructionsText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = InstructionsText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InstructionsText.Text",
                            Type = "string",
                            Value = InstructionsText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InstructionsText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = InstructionsText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Visible",
                            Type = "bool",
                            Value = TextInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConfirmButton.Visible",
                            Type = "bool",
                            Value = ConfirmButton.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConfirmButton.X",
                            Type = "float",
                            Value = ConfirmButton.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConfirmButton.Y",
                            Type = "float",
                            Value = ConfirmButton.Y + 841f
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
                    else if (category.Name == "SelectionMode")
                    {
                        if(state.Name == "Single") this.mCurrentSelectionModeState = SelectionMode.Single;
                        if(state.Name == "Double") this.mCurrentSelectionModeState = SelectionMode.Double;
                    }
                }
                base.ApplyState(state);
            }
            private AbbatoirIntergrade.GumRuntimes.unique.DimmingRuntime DimmingInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.frames.LargeInfoFrameRuntime LargeInfoFrameInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.infodisplays.StructureInfoRuntime StructureChoice1 { get; set; }
            private AbbatoirIntergrade.GumRuntimes.infodisplays.StructureInfoRuntime StructureChoice2 { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime InstructionsText { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime TextInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.frames.ButtonFrameRuntime ConfirmButton { get; set; }
            public TowerSelectionBoxRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                this.HasEvents = false;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "TowerSelectionBox");
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
                DimmingInstance = this.GetGraphicalUiElementByName("DimmingInstance") as AbbatoirIntergrade.GumRuntimes.unique.DimmingRuntime;
                LargeInfoFrameInstance = this.GetGraphicalUiElementByName("LargeInfoFrameInstance") as AbbatoirIntergrade.GumRuntimes.frames.LargeInfoFrameRuntime;
                StructureChoice1 = this.GetGraphicalUiElementByName("StructureChoice1") as AbbatoirIntergrade.GumRuntimes.infodisplays.StructureInfoRuntime;
                StructureChoice2 = this.GetGraphicalUiElementByName("StructureChoice2") as AbbatoirIntergrade.GumRuntimes.infodisplays.StructureInfoRuntime;
                InstructionsText = this.GetGraphicalUiElementByName("InstructionsText") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
                TextInstance = this.GetGraphicalUiElementByName("TextInstance") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
                ConfirmButton = this.GetGraphicalUiElementByName("ConfirmButton") as AbbatoirIntergrade.GumRuntimes.frames.ButtonFrameRuntime;
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
