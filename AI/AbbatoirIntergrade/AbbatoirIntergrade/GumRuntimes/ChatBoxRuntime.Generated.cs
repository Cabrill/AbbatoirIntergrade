    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes
    {
        public partial class ChatBoxRuntime : AbbatoirIntergrade.GumRuntimes.ContainerRuntime
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            public enum Appearance
            {
                ChatOpen,
                Appear1,
                Appear2,
                Appear3,
                Appear4,
                ChatClosed
            }
            public enum MessageIndicator
            {
                NewMessage,
                NoMessage,
                NoMessageHighlighted,
                NewMessageHighlighted
            }
            public enum ResponseAvailability
            {
                AwaitingResponse,
                AlreadyResponded
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            Appearance mCurrentAppearanceState;
            MessageIndicator mCurrentMessageIndicatorState;
            ResponseAvailability mCurrentResponseAvailabilityState;
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
                            XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            ChatFrameInstance.Height = 100f;
                            ChatFrameInstance.Width = 100f;
                            ChatFrameInstance.X = 50f;
                            ChatFrameInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            ChatFrameInstance.Y = 50f;
                            ChatFrameInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            StyleBarInstance.Height = 10f;
                            StyleBarInstance.Visible = false;
                            StyleBarInstance.Width = 100f;
                            StyleBarInstance.X = 50f;
                            StyleBarInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            StyleBarInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            StyleBarInstance.Y = 50f;
                            StyleBarInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            StyleBarInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            ColoredRectangleInstance.Alpha = 160;
                            ColoredRectangleInstance.Blue = 0;
                            ColoredRectangleInstance.Green = 0;
                            ColoredRectangleInstance.Height = 82.10236f;
                            ColoredRectangleInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ColoredRectangleInstance.Red = 0;
                            ColoredRectangleInstance.Width = 80.05469f;
                            ColoredRectangleInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ColoredRectangleInstance.X = 49.64584f;
                            ColoredRectangleInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            ColoredRectangleInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            ColoredRectangleInstance.Y = 50.04165f;
                            ColoredRectangleInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            ColoredRectangleInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            ChatOption0.Height = 0f;
                            ChatOption0.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            ChatOption0.CurrentHighlightState = AbbatoirIntergrade.GumRuntimes.ChatOptionRuntime.Highlight.NotHighlighted;
                            ChatOption0.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ResponseContainer");
                            ChatOption0.Width = 100f;
                            ChatOption0.X = 0f;
                            ChatOption0.Y = 0f;
                            CurrentText.Font = "SVI Basic Manual";
                            CurrentText.FontSize = 30;
                            CurrentText.Height = 18.29847f;
                            CurrentText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            CurrentText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ChatContainer");
                            CurrentText.Width = 92.96616f;
                            CurrentText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            CurrentText.X = 0.820613f;
                            CurrentText.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            CurrentText.Y = 2.029169f;
                            CurrentText.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            ChatOption1.Height = 0f;
                            ChatOption1.CurrentHighlightState = AbbatoirIntergrade.GumRuntimes.ChatOptionRuntime.Highlight.NotHighlighted;
                            ChatOption1.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ResponseContainer");
                            ChatOption1.Width = 100f;
                            ChatOption2.Height = 0f;
                            ChatOption2.CurrentHighlightState = AbbatoirIntergrade.GumRuntimes.ChatOptionRuntime.Highlight.NotHighlighted;
                            ChatOption2.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ResponseContainer");
                            ChatOption2.Width = 100f;
                            ResponseContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                            ResponseContainer.Height = 80f;
                            ResponseContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ResponseContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ChatContainer");
                            ResponseContainer.Width = 100f;
                            ResponseContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ResponseContainer.WrapsChildren = false;
                            ResponseContainer.X = 0f;
                            ResponseContainer.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            ResponseContainer.Y = 0f;
                            ResponseContainer.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            ChatContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                            ChatContainer.Height = 82.13544f;
                            ChatContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ChatContainer.Width = 79.9707f;
                            ChatContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ChatContainer.X = 9.638672f;
                            ChatContainer.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            ChatContainer.Y = 8.975698f;
                            ChatContainer.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            CloseChatButtonInstance.Height = 100f;
                            CloseChatButtonInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                            CloseChatButtonInstance.Width = 5f;
                            CloseChatButtonInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            CloseChatButtonInstance.X = 84.7412f;
                            CloseChatButtonInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            CloseChatButtonInstance.Y = 6.777447f;
                            CloseChatButtonInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            MessageBox.CurrentColorStateState = AbbatoirIntergrade.GumRuntimes.GlowingBoxRuntime.ColorState.Black;
                            MessageBox.Height = 100f;
                            MessageBox.HeightUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                            MessageBox.Visible = false;
                            MessageBox.Width = 10f;
                            MessageBox.X = 0.5952342f;
                            MessageBox.Y = 100f;
                            MessageBox.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                            TextInstance.Font = "SVI Basic Manual";
                            TextInstance.FontSize = 30;
                            TextInstance.Height = -64f;
                            TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            TextInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "MessageBox");
                            TextInstance.Text = "!";
                            TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            TextInstance.Visible = false;
                            TextInstance.Width = -64f;
                            TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            TextInstance.X = 50f;
                            TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            TextInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            TextInstance.Y = 50f;
                            TextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            TextInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            ChatHistoryButton.Height = 56f;
                            ChatHistoryButton.CurrentUpDownState = AbbatoirIntergrade.GumRuntimes.UpDownButtonRuntime.UpDown.Up;
                            ChatHistoryButton.Width = 66f;
                            ChatHistoryButton.X = 4.244792f;
                            ChatHistoryButton.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            ChatHistoryButton.Y = 15.46297f;
                            ChatHistoryButton.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            RecentResponseContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                            RecentResponseContainer.Height = 82f;
                            RecentResponseContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            RecentResponseContainer.Visible = false;
                            RecentResponseContainer.Width = 80f;
                            RecentResponseContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            RecentResponseContainer.X = 9.5f;
                            RecentResponseContainer.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            RecentResponseContainer.Y = 10f;
                            RecentResponseContainer.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            DialogueShownChatOption.CurrentHighlightState = AbbatoirIntergrade.GumRuntimes.ChatOptionRuntime.Highlight.Highlighted;
                            DialogueShownChatOption.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "RecentResponseContainer");
                            ResponseChosenChatOption.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "RecentResponseContainer");
                            ResponseChosenChatOption.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            ResponseChosenChatOption.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                            ResponseChosenChatOption.Y = 5f;
                            break;
                    }
                }
            }
            public Appearance CurrentAppearanceState
            {
                get
                {
                    return mCurrentAppearanceState;
                }
                set
                {
                    mCurrentAppearanceState = value;
                    switch(mCurrentAppearanceState)
                    {
                        case  Appearance.ChatOpen:
                            ChatFrameInstance.Height = 100f;
                            ChatFrameInstance.Visible = true;
                            StyleBarInstance.Height = 10f;
                            StyleBarInstance.Visible = false;
                            StyleBarInstance.Width = 100f;
                            StyleBarInstance.X = 50f;
                            StyleBarInstance.Y = 50f;
                            ColoredRectangleInstance.Alpha = 160;
                            ColoredRectangleInstance.Height = 82.10236f;
                            ColoredRectangleInstance.Visible = true;
                            CurrentText.Visible = true;
                            ResponseContainer.Visible = true;
                            ChatContainer.Visible = false;
                            CloseChatButtonInstance.Visible = true;
                            MessageBox.Visible = false;
                            TextInstance.Visible = false;
                            ChatHistoryButton.Visible = true;
                            RecentResponseContainer.Visible = false;
                            break;
                        case  Appearance.Appear1:
                            ChatFrameInstance.Height = 5f;
                            ChatFrameInstance.Visible = false;
                            StyleBarInstance.Height = 10f;
                            StyleBarInstance.Visible = true;
                            StyleBarInstance.Width = 10f;
                            StyleBarInstance.X = 6f;
                            StyleBarInstance.Y = 90f;
                            ColoredRectangleInstance.Alpha = 160;
                            ColoredRectangleInstance.Height = 4.1f;
                            ColoredRectangleInstance.Visible = false;
                            CurrentText.Visible = false;
                            ResponseContainer.Visible = false;
                            ChatContainer.Visible = false;
                            CloseChatButtonInstance.Visible = false;
                            MessageBox.Visible = false;
                            TextInstance.Visible = false;
                            ChatHistoryButton.Visible = false;
                            RecentResponseContainer.Visible = false;
                            break;
                        case  Appearance.Appear2:
                            ChatFrameInstance.Height = 5f;
                            ChatFrameInstance.Visible = false;
                            StyleBarInstance.Height = 10f;
                            StyleBarInstance.Visible = true;
                            StyleBarInstance.Width = 100f;
                            StyleBarInstance.X = 50f;
                            StyleBarInstance.Y = 50f;
                            ColoredRectangleInstance.Alpha = 160;
                            ColoredRectangleInstance.Height = 4.1f;
                            ColoredRectangleInstance.Visible = false;
                            CurrentText.Visible = false;
                            ResponseContainer.Visible = false;
                            ChatContainer.Visible = false;
                            CloseChatButtonInstance.Visible = false;
                            MessageBox.Visible = false;
                            TextInstance.Visible = false;
                            ChatHistoryButton.Visible = false;
                            RecentResponseContainer.Visible = false;
                            break;
                        case  Appearance.Appear3:
                            ChatFrameInstance.Height = 5f;
                            ChatFrameInstance.Visible = true;
                            StyleBarInstance.Height = 10f;
                            StyleBarInstance.Visible = false;
                            StyleBarInstance.Width = 100f;
                            StyleBarInstance.X = 50f;
                            StyleBarInstance.Y = 50f;
                            ColoredRectangleInstance.Alpha = 0;
                            ColoredRectangleInstance.Height = 4.1f;
                            ColoredRectangleInstance.Visible = true;
                            CurrentText.Visible = false;
                            ResponseContainer.Visible = true;
                            ChatContainer.Visible = false;
                            CloseChatButtonInstance.Visible = false;
                            MessageBox.Visible = false;
                            TextInstance.Visible = false;
                            ChatHistoryButton.Visible = false;
                            RecentResponseContainer.Visible = false;
                            break;
                        case  Appearance.Appear4:
                            ChatFrameInstance.Height = 100f;
                            ChatFrameInstance.Visible = true;
                            StyleBarInstance.Height = 10f;
                            StyleBarInstance.Visible = false;
                            StyleBarInstance.Width = 100f;
                            StyleBarInstance.X = 50f;
                            StyleBarInstance.Y = 50f;
                            ColoredRectangleInstance.Alpha = 80;
                            ColoredRectangleInstance.Height = 82.10236f;
                            ColoredRectangleInstance.Visible = true;
                            CurrentText.Visible = false;
                            ResponseContainer.Visible = false;
                            ChatContainer.Visible = true;
                            CloseChatButtonInstance.Visible = false;
                            MessageBox.Visible = false;
                            TextInstance.Visible = false;
                            ChatHistoryButton.Visible = false;
                            RecentResponseContainer.Visible = false;
                            break;
                        case  Appearance.ChatClosed:
                            ChatFrameInstance.Height = 100f;
                            ChatFrameInstance.Visible = false;
                            StyleBarInstance.Height = 10f;
                            StyleBarInstance.Visible = false;
                            StyleBarInstance.Width = 10f;
                            StyleBarInstance.X = 6f;
                            StyleBarInstance.Y = 90f;
                            ColoredRectangleInstance.Alpha = 160;
                            ColoredRectangleInstance.Height = 4.1f;
                            ColoredRectangleInstance.Visible = false;
                            CurrentText.Visible = true;
                            ResponseContainer.Visible = true;
                            ChatContainer.Visible = false;
                            CloseChatButtonInstance.Visible = false;
                            MessageBox.Visible = true;
                            TextInstance.Visible = false;
                            ChatHistoryButton.Visible = false;
                            RecentResponseContainer.Visible = false;
                            break;
                    }
                }
            }
            public MessageIndicator CurrentMessageIndicatorState
            {
                get
                {
                    return mCurrentMessageIndicatorState;
                }
                set
                {
                    mCurrentMessageIndicatorState = value;
                    switch(mCurrentMessageIndicatorState)
                    {
                        case  MessageIndicator.NewMessage:
                            MessageBox.CurrentColorStateState = AbbatoirIntergrade.GumRuntimes.GlowingBoxRuntime.ColorState.Blue;
                            TextInstance.Blue = 0;
                            TextInstance.Green = 0;
                            TextInstance.Red = 0;
                            TextInstance.Visible = true;
                            break;
                        case  MessageIndicator.NoMessage:
                            MessageBox.CurrentColorStateState = AbbatoirIntergrade.GumRuntimes.GlowingBoxRuntime.ColorState.Black;
                            TextInstance.Blue = 255;
                            TextInstance.Green = 255;
                            TextInstance.Red = 255;
                            TextInstance.Visible = false;
                            break;
                        case  MessageIndicator.NoMessageHighlighted:
                            MessageBox.CurrentColorStateState = AbbatoirIntergrade.GumRuntimes.GlowingBoxRuntime.ColorState.Green;
                            TextInstance.Blue = 255;
                            TextInstance.Green = 255;
                            TextInstance.Red = 255;
                            TextInstance.Visible = false;
                            break;
                        case  MessageIndicator.NewMessageHighlighted:
                            MessageBox.CurrentColorStateState = AbbatoirIntergrade.GumRuntimes.GlowingBoxRuntime.ColorState.Green;
                            TextInstance.Blue = 255;
                            TextInstance.Green = 255;
                            TextInstance.Red = 255;
                            TextInstance.Visible = true;
                            break;
                    }
                }
            }
            public ResponseAvailability CurrentResponseAvailabilityState
            {
                get
                {
                    return mCurrentResponseAvailabilityState;
                }
                set
                {
                    mCurrentResponseAvailabilityState = value;
                    switch(mCurrentResponseAvailabilityState)
                    {
                        case  ResponseAvailability.AwaitingResponse:
                            ChatContainer.Visible = true;
                            RecentResponseContainer.Visible = false;
                            break;
                        case  ResponseAvailability.AlreadyResponded:
                            ChatContainer.Visible = false;
                            RecentResponseContainer.Visible = true;
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
                bool setChatContainerHeightFirstValue = false;
                bool setChatContainerHeightSecondValue = false;
                float ChatContainerHeightFirstValue= 0;
                float ChatContainerHeightSecondValue= 0;
                bool setChatContainerWidthFirstValue = false;
                bool setChatContainerWidthSecondValue = false;
                float ChatContainerWidthFirstValue= 0;
                float ChatContainerWidthSecondValue= 0;
                bool setChatContainerXFirstValue = false;
                bool setChatContainerXSecondValue = false;
                float ChatContainerXFirstValue= 0;
                float ChatContainerXSecondValue= 0;
                bool setChatContainerYFirstValue = false;
                bool setChatContainerYSecondValue = false;
                float ChatContainerYFirstValue= 0;
                float ChatContainerYSecondValue= 0;
                bool setChatFrameInstanceHeightFirstValue = false;
                bool setChatFrameInstanceHeightSecondValue = false;
                float ChatFrameInstanceHeightFirstValue= 0;
                float ChatFrameInstanceHeightSecondValue= 0;
                bool setChatFrameInstanceWidthFirstValue = false;
                bool setChatFrameInstanceWidthSecondValue = false;
                float ChatFrameInstanceWidthFirstValue= 0;
                float ChatFrameInstanceWidthSecondValue= 0;
                bool setChatFrameInstanceXFirstValue = false;
                bool setChatFrameInstanceXSecondValue = false;
                float ChatFrameInstanceXFirstValue= 0;
                float ChatFrameInstanceXSecondValue= 0;
                bool setChatFrameInstanceYFirstValue = false;
                bool setChatFrameInstanceYSecondValue = false;
                float ChatFrameInstanceYFirstValue= 0;
                float ChatFrameInstanceYSecondValue= 0;
                bool setChatHistoryButtonHeightFirstValue = false;
                bool setChatHistoryButtonHeightSecondValue = false;
                float ChatHistoryButtonHeightFirstValue= 0;
                float ChatHistoryButtonHeightSecondValue= 0;
                bool setChatHistoryButtonCurrentUpDownStateFirstValue = false;
                bool setChatHistoryButtonCurrentUpDownStateSecondValue = false;
                UpDownButtonRuntime.UpDown ChatHistoryButtonCurrentUpDownStateFirstValue= UpDownButtonRuntime.UpDown.Up;
                UpDownButtonRuntime.UpDown ChatHistoryButtonCurrentUpDownStateSecondValue= UpDownButtonRuntime.UpDown.Up;
                bool setChatHistoryButtonWidthFirstValue = false;
                bool setChatHistoryButtonWidthSecondValue = false;
                float ChatHistoryButtonWidthFirstValue= 0;
                float ChatHistoryButtonWidthSecondValue= 0;
                bool setChatHistoryButtonXFirstValue = false;
                bool setChatHistoryButtonXSecondValue = false;
                float ChatHistoryButtonXFirstValue= 0;
                float ChatHistoryButtonXSecondValue= 0;
                bool setChatHistoryButtonYFirstValue = false;
                bool setChatHistoryButtonYSecondValue = false;
                float ChatHistoryButtonYFirstValue= 0;
                float ChatHistoryButtonYSecondValue= 0;
                bool setChatOption0HeightFirstValue = false;
                bool setChatOption0HeightSecondValue = false;
                float ChatOption0HeightFirstValue= 0;
                float ChatOption0HeightSecondValue= 0;
                bool setChatOption0CurrentHighlightStateFirstValue = false;
                bool setChatOption0CurrentHighlightStateSecondValue = false;
                ChatOptionRuntime.Highlight ChatOption0CurrentHighlightStateFirstValue= ChatOptionRuntime.Highlight.Highlighted;
                ChatOptionRuntime.Highlight ChatOption0CurrentHighlightStateSecondValue= ChatOptionRuntime.Highlight.Highlighted;
                bool setChatOption0WidthFirstValue = false;
                bool setChatOption0WidthSecondValue = false;
                float ChatOption0WidthFirstValue= 0;
                float ChatOption0WidthSecondValue= 0;
                bool setChatOption0XFirstValue = false;
                bool setChatOption0XSecondValue = false;
                float ChatOption0XFirstValue= 0;
                float ChatOption0XSecondValue= 0;
                bool setChatOption0YFirstValue = false;
                bool setChatOption0YSecondValue = false;
                float ChatOption0YFirstValue= 0;
                float ChatOption0YSecondValue= 0;
                bool setChatOption1HeightFirstValue = false;
                bool setChatOption1HeightSecondValue = false;
                float ChatOption1HeightFirstValue= 0;
                float ChatOption1HeightSecondValue= 0;
                bool setChatOption1CurrentHighlightStateFirstValue = false;
                bool setChatOption1CurrentHighlightStateSecondValue = false;
                ChatOptionRuntime.Highlight ChatOption1CurrentHighlightStateFirstValue= ChatOptionRuntime.Highlight.Highlighted;
                ChatOptionRuntime.Highlight ChatOption1CurrentHighlightStateSecondValue= ChatOptionRuntime.Highlight.Highlighted;
                bool setChatOption1WidthFirstValue = false;
                bool setChatOption1WidthSecondValue = false;
                float ChatOption1WidthFirstValue= 0;
                float ChatOption1WidthSecondValue= 0;
                bool setChatOption2HeightFirstValue = false;
                bool setChatOption2HeightSecondValue = false;
                float ChatOption2HeightFirstValue= 0;
                float ChatOption2HeightSecondValue= 0;
                bool setChatOption2CurrentHighlightStateFirstValue = false;
                bool setChatOption2CurrentHighlightStateSecondValue = false;
                ChatOptionRuntime.Highlight ChatOption2CurrentHighlightStateFirstValue= ChatOptionRuntime.Highlight.Highlighted;
                ChatOptionRuntime.Highlight ChatOption2CurrentHighlightStateSecondValue= ChatOptionRuntime.Highlight.Highlighted;
                bool setChatOption2WidthFirstValue = false;
                bool setChatOption2WidthSecondValue = false;
                float ChatOption2WidthFirstValue= 0;
                float ChatOption2WidthSecondValue= 0;
                bool setCloseChatButtonInstanceHeightFirstValue = false;
                bool setCloseChatButtonInstanceHeightSecondValue = false;
                float CloseChatButtonInstanceHeightFirstValue= 0;
                float CloseChatButtonInstanceHeightSecondValue= 0;
                bool setCloseChatButtonInstanceWidthFirstValue = false;
                bool setCloseChatButtonInstanceWidthSecondValue = false;
                float CloseChatButtonInstanceWidthFirstValue= 0;
                float CloseChatButtonInstanceWidthSecondValue= 0;
                bool setCloseChatButtonInstanceXFirstValue = false;
                bool setCloseChatButtonInstanceXSecondValue = false;
                float CloseChatButtonInstanceXFirstValue= 0;
                float CloseChatButtonInstanceXSecondValue= 0;
                bool setCloseChatButtonInstanceYFirstValue = false;
                bool setCloseChatButtonInstanceYSecondValue = false;
                float CloseChatButtonInstanceYFirstValue= 0;
                float CloseChatButtonInstanceYSecondValue= 0;
                bool setColoredRectangleInstanceAlphaFirstValue = false;
                bool setColoredRectangleInstanceAlphaSecondValue = false;
                int ColoredRectangleInstanceAlphaFirstValue= 0;
                int ColoredRectangleInstanceAlphaSecondValue= 0;
                bool setColoredRectangleInstanceBlueFirstValue = false;
                bool setColoredRectangleInstanceBlueSecondValue = false;
                int ColoredRectangleInstanceBlueFirstValue= 0;
                int ColoredRectangleInstanceBlueSecondValue= 0;
                bool setColoredRectangleInstanceGreenFirstValue = false;
                bool setColoredRectangleInstanceGreenSecondValue = false;
                int ColoredRectangleInstanceGreenFirstValue= 0;
                int ColoredRectangleInstanceGreenSecondValue= 0;
                bool setColoredRectangleInstanceHeightFirstValue = false;
                bool setColoredRectangleInstanceHeightSecondValue = false;
                float ColoredRectangleInstanceHeightFirstValue= 0;
                float ColoredRectangleInstanceHeightSecondValue= 0;
                bool setColoredRectangleInstanceRedFirstValue = false;
                bool setColoredRectangleInstanceRedSecondValue = false;
                int ColoredRectangleInstanceRedFirstValue= 0;
                int ColoredRectangleInstanceRedSecondValue= 0;
                bool setColoredRectangleInstanceWidthFirstValue = false;
                bool setColoredRectangleInstanceWidthSecondValue = false;
                float ColoredRectangleInstanceWidthFirstValue= 0;
                float ColoredRectangleInstanceWidthSecondValue= 0;
                bool setColoredRectangleInstanceXFirstValue = false;
                bool setColoredRectangleInstanceXSecondValue = false;
                float ColoredRectangleInstanceXFirstValue= 0;
                float ColoredRectangleInstanceXSecondValue= 0;
                bool setColoredRectangleInstanceYFirstValue = false;
                bool setColoredRectangleInstanceYSecondValue = false;
                float ColoredRectangleInstanceYFirstValue= 0;
                float ColoredRectangleInstanceYSecondValue= 0;
                bool setCurrentTextFontSizeFirstValue = false;
                bool setCurrentTextFontSizeSecondValue = false;
                int CurrentTextFontSizeFirstValue= 0;
                int CurrentTextFontSizeSecondValue= 0;
                bool setCurrentTextHeightFirstValue = false;
                bool setCurrentTextHeightSecondValue = false;
                float CurrentTextHeightFirstValue= 0;
                float CurrentTextHeightSecondValue= 0;
                bool setCurrentTextWidthFirstValue = false;
                bool setCurrentTextWidthSecondValue = false;
                float CurrentTextWidthFirstValue= 0;
                float CurrentTextWidthSecondValue= 0;
                bool setCurrentTextXFirstValue = false;
                bool setCurrentTextXSecondValue = false;
                float CurrentTextXFirstValue= 0;
                float CurrentTextXSecondValue= 0;
                bool setCurrentTextYFirstValue = false;
                bool setCurrentTextYSecondValue = false;
                float CurrentTextYFirstValue= 0;
                float CurrentTextYSecondValue= 0;
                bool setDialogueShownChatOptionCurrentHighlightStateFirstValue = false;
                bool setDialogueShownChatOptionCurrentHighlightStateSecondValue = false;
                ChatOptionRuntime.Highlight DialogueShownChatOptionCurrentHighlightStateFirstValue= ChatOptionRuntime.Highlight.Highlighted;
                ChatOptionRuntime.Highlight DialogueShownChatOptionCurrentHighlightStateSecondValue= ChatOptionRuntime.Highlight.Highlighted;
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setMessageBoxCurrentColorStateStateFirstValue = false;
                bool setMessageBoxCurrentColorStateStateSecondValue = false;
                GlowingBoxRuntime.ColorState MessageBoxCurrentColorStateStateFirstValue= GlowingBoxRuntime.ColorState.Red;
                GlowingBoxRuntime.ColorState MessageBoxCurrentColorStateStateSecondValue= GlowingBoxRuntime.ColorState.Red;
                bool setMessageBoxHeightFirstValue = false;
                bool setMessageBoxHeightSecondValue = false;
                float MessageBoxHeightFirstValue= 0;
                float MessageBoxHeightSecondValue= 0;
                bool setMessageBoxWidthFirstValue = false;
                bool setMessageBoxWidthSecondValue = false;
                float MessageBoxWidthFirstValue= 0;
                float MessageBoxWidthSecondValue= 0;
                bool setMessageBoxXFirstValue = false;
                bool setMessageBoxXSecondValue = false;
                float MessageBoxXFirstValue= 0;
                float MessageBoxXSecondValue= 0;
                bool setMessageBoxYFirstValue = false;
                bool setMessageBoxYSecondValue = false;
                float MessageBoxYFirstValue= 0;
                float MessageBoxYSecondValue= 0;
                bool setRecentResponseContainerHeightFirstValue = false;
                bool setRecentResponseContainerHeightSecondValue = false;
                float RecentResponseContainerHeightFirstValue= 0;
                float RecentResponseContainerHeightSecondValue= 0;
                bool setRecentResponseContainerWidthFirstValue = false;
                bool setRecentResponseContainerWidthSecondValue = false;
                float RecentResponseContainerWidthFirstValue= 0;
                float RecentResponseContainerWidthSecondValue= 0;
                bool setRecentResponseContainerXFirstValue = false;
                bool setRecentResponseContainerXSecondValue = false;
                float RecentResponseContainerXFirstValue= 0;
                float RecentResponseContainerXSecondValue= 0;
                bool setRecentResponseContainerYFirstValue = false;
                bool setRecentResponseContainerYSecondValue = false;
                float RecentResponseContainerYFirstValue= 0;
                float RecentResponseContainerYSecondValue= 0;
                bool setResponseChosenChatOptionYFirstValue = false;
                bool setResponseChosenChatOptionYSecondValue = false;
                float ResponseChosenChatOptionYFirstValue= 0;
                float ResponseChosenChatOptionYSecondValue= 0;
                bool setResponseContainerHeightFirstValue = false;
                bool setResponseContainerHeightSecondValue = false;
                float ResponseContainerHeightFirstValue= 0;
                float ResponseContainerHeightSecondValue= 0;
                bool setResponseContainerWidthFirstValue = false;
                bool setResponseContainerWidthSecondValue = false;
                float ResponseContainerWidthFirstValue= 0;
                float ResponseContainerWidthSecondValue= 0;
                bool setResponseContainerXFirstValue = false;
                bool setResponseContainerXSecondValue = false;
                float ResponseContainerXFirstValue= 0;
                float ResponseContainerXSecondValue= 0;
                bool setResponseContainerYFirstValue = false;
                bool setResponseContainerYSecondValue = false;
                float ResponseContainerYFirstValue= 0;
                float ResponseContainerYSecondValue= 0;
                bool setStyleBarInstanceHeightFirstValue = false;
                bool setStyleBarInstanceHeightSecondValue = false;
                float StyleBarInstanceHeightFirstValue= 0;
                float StyleBarInstanceHeightSecondValue= 0;
                bool setStyleBarInstanceWidthFirstValue = false;
                bool setStyleBarInstanceWidthSecondValue = false;
                float StyleBarInstanceWidthFirstValue= 0;
                float StyleBarInstanceWidthSecondValue= 0;
                bool setStyleBarInstanceXFirstValue = false;
                bool setStyleBarInstanceXSecondValue = false;
                float StyleBarInstanceXFirstValue= 0;
                float StyleBarInstanceXSecondValue= 0;
                bool setStyleBarInstanceYFirstValue = false;
                bool setStyleBarInstanceYSecondValue = false;
                float StyleBarInstanceYFirstValue= 0;
                float StyleBarInstanceYSecondValue= 0;
                bool setTextInstanceFontSizeFirstValue = false;
                bool setTextInstanceFontSizeSecondValue = false;
                int TextInstanceFontSizeFirstValue= 0;
                int TextInstanceFontSizeSecondValue= 0;
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
                        if (interpolationValue < 1)
                        {
                            this.ChatContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setChatContainerHeightFirstValue = true;
                        ChatContainerHeightFirstValue = 82.13544f;
                        if (interpolationValue < 1)
                        {
                            this.ChatContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setChatContainerWidthFirstValue = true;
                        ChatContainerWidthFirstValue = 79.9707f;
                        if (interpolationValue < 1)
                        {
                            this.ChatContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setChatContainerXFirstValue = true;
                        ChatContainerXFirstValue = 9.638672f;
                        if (interpolationValue < 1)
                        {
                            this.ChatContainer.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setChatContainerYFirstValue = true;
                        ChatContainerYFirstValue = 8.975698f;
                        if (interpolationValue < 1)
                        {
                            this.ChatContainer.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setChatFrameInstanceHeightFirstValue = true;
                        ChatFrameInstanceHeightFirstValue = 100f;
                        setChatFrameInstanceWidthFirstValue = true;
                        ChatFrameInstanceWidthFirstValue = 100f;
                        setChatFrameInstanceXFirstValue = true;
                        ChatFrameInstanceXFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.ChatFrameInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setChatFrameInstanceYFirstValue = true;
                        ChatFrameInstanceYFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.ChatFrameInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setChatHistoryButtonHeightFirstValue = true;
                        ChatHistoryButtonHeightFirstValue = 56f;
                        setChatHistoryButtonCurrentUpDownStateFirstValue = true;
                        ChatHistoryButtonCurrentUpDownStateFirstValue = AbbatoirIntergrade.GumRuntimes.UpDownButtonRuntime.UpDown.Up;
                        setChatHistoryButtonWidthFirstValue = true;
                        ChatHistoryButtonWidthFirstValue = 66f;
                        setChatHistoryButtonXFirstValue = true;
                        ChatHistoryButtonXFirstValue = 4.244792f;
                        if (interpolationValue < 1)
                        {
                            this.ChatHistoryButton.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setChatHistoryButtonYFirstValue = true;
                        ChatHistoryButtonYFirstValue = 15.46297f;
                        if (interpolationValue < 1)
                        {
                            this.ChatHistoryButton.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setChatOption0HeightFirstValue = true;
                        ChatOption0HeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ChatOption0.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setChatOption0CurrentHighlightStateFirstValue = true;
                        ChatOption0CurrentHighlightStateFirstValue = AbbatoirIntergrade.GumRuntimes.ChatOptionRuntime.Highlight.NotHighlighted;
                        if (interpolationValue < 1)
                        {
                            this.ChatOption0.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ResponseContainer");
                        }
                        setChatOption0WidthFirstValue = true;
                        ChatOption0WidthFirstValue = 100f;
                        setChatOption0XFirstValue = true;
                        ChatOption0XFirstValue = 0f;
                        setChatOption0YFirstValue = true;
                        ChatOption0YFirstValue = 0f;
                        setChatOption1HeightFirstValue = true;
                        ChatOption1HeightFirstValue = 0f;
                        setChatOption1CurrentHighlightStateFirstValue = true;
                        ChatOption1CurrentHighlightStateFirstValue = AbbatoirIntergrade.GumRuntimes.ChatOptionRuntime.Highlight.NotHighlighted;
                        if (interpolationValue < 1)
                        {
                            this.ChatOption1.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ResponseContainer");
                        }
                        setChatOption1WidthFirstValue = true;
                        ChatOption1WidthFirstValue = 100f;
                        setChatOption2HeightFirstValue = true;
                        ChatOption2HeightFirstValue = 0f;
                        setChatOption2CurrentHighlightStateFirstValue = true;
                        ChatOption2CurrentHighlightStateFirstValue = AbbatoirIntergrade.GumRuntimes.ChatOptionRuntime.Highlight.NotHighlighted;
                        if (interpolationValue < 1)
                        {
                            this.ChatOption2.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ResponseContainer");
                        }
                        setChatOption2WidthFirstValue = true;
                        ChatOption2WidthFirstValue = 100f;
                        setCloseChatButtonInstanceHeightFirstValue = true;
                        CloseChatButtonInstanceHeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.CloseChatButtonInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        setCloseChatButtonInstanceWidthFirstValue = true;
                        CloseChatButtonInstanceWidthFirstValue = 5f;
                        if (interpolationValue < 1)
                        {
                            this.CloseChatButtonInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setCloseChatButtonInstanceXFirstValue = true;
                        CloseChatButtonInstanceXFirstValue = 84.7412f;
                        if (interpolationValue < 1)
                        {
                            this.CloseChatButtonInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setCloseChatButtonInstanceYFirstValue = true;
                        CloseChatButtonInstanceYFirstValue = 6.777447f;
                        if (interpolationValue < 1)
                        {
                            this.CloseChatButtonInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setColoredRectangleInstanceAlphaFirstValue = true;
                        ColoredRectangleInstanceAlphaFirstValue = 160;
                        setColoredRectangleInstanceBlueFirstValue = true;
                        ColoredRectangleInstanceBlueFirstValue = 0;
                        setColoredRectangleInstanceGreenFirstValue = true;
                        ColoredRectangleInstanceGreenFirstValue = 0;
                        setColoredRectangleInstanceHeightFirstValue = true;
                        ColoredRectangleInstanceHeightFirstValue = 82.10236f;
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setColoredRectangleInstanceRedFirstValue = true;
                        ColoredRectangleInstanceRedFirstValue = 0;
                        setColoredRectangleInstanceWidthFirstValue = true;
                        ColoredRectangleInstanceWidthFirstValue = 80.05469f;
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setColoredRectangleInstanceXFirstValue = true;
                        ColoredRectangleInstanceXFirstValue = 49.64584f;
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setColoredRectangleInstanceYFirstValue = true;
                        ColoredRectangleInstanceYFirstValue = 50.04165f;
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CurrentText.Font = "SVI Basic Manual";
                        }
                        setCurrentTextFontSizeFirstValue = true;
                        CurrentTextFontSizeFirstValue = 30;
                        setCurrentTextHeightFirstValue = true;
                        CurrentTextHeightFirstValue = 18.29847f;
                        if (interpolationValue < 1)
                        {
                            this.CurrentText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CurrentText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ChatContainer");
                        }
                        setCurrentTextWidthFirstValue = true;
                        CurrentTextWidthFirstValue = 92.96616f;
                        if (interpolationValue < 1)
                        {
                            this.CurrentText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setCurrentTextXFirstValue = true;
                        CurrentTextXFirstValue = 0.820613f;
                        if (interpolationValue < 1)
                        {
                            this.CurrentText.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setCurrentTextYFirstValue = true;
                        CurrentTextYFirstValue = 2.029169f;
                        if (interpolationValue < 1)
                        {
                            this.CurrentText.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setDialogueShownChatOptionCurrentHighlightStateFirstValue = true;
                        DialogueShownChatOptionCurrentHighlightStateFirstValue = AbbatoirIntergrade.GumRuntimes.ChatOptionRuntime.Highlight.Highlighted;
                        if (interpolationValue < 1)
                        {
                            this.DialogueShownChatOption.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "RecentResponseContainer");
                        }
                        setHeightFirstValue = true;
                        HeightFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setMessageBoxCurrentColorStateStateFirstValue = true;
                        MessageBoxCurrentColorStateStateFirstValue = AbbatoirIntergrade.GumRuntimes.GlowingBoxRuntime.ColorState.Black;
                        setMessageBoxHeightFirstValue = true;
                        MessageBoxHeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.MessageBox.HeightUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MessageBox.Visible = false;
                        }
                        setMessageBoxWidthFirstValue = true;
                        MessageBoxWidthFirstValue = 10f;
                        setMessageBoxXFirstValue = true;
                        MessageBoxXFirstValue = 0.5952342f;
                        setMessageBoxYFirstValue = true;
                        MessageBoxYFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.MessageBox.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue < 1)
                        {
                            this.RecentResponseContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setRecentResponseContainerHeightFirstValue = true;
                        RecentResponseContainerHeightFirstValue = 82f;
                        if (interpolationValue < 1)
                        {
                            this.RecentResponseContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.RecentResponseContainer.Visible = false;
                        }
                        setRecentResponseContainerWidthFirstValue = true;
                        RecentResponseContainerWidthFirstValue = 80f;
                        if (interpolationValue < 1)
                        {
                            this.RecentResponseContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setRecentResponseContainerXFirstValue = true;
                        RecentResponseContainerXFirstValue = 9.5f;
                        if (interpolationValue < 1)
                        {
                            this.RecentResponseContainer.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setRecentResponseContainerYFirstValue = true;
                        RecentResponseContainerYFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.RecentResponseContainer.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ResponseChosenChatOption.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "RecentResponseContainer");
                        }
                        if (interpolationValue < 1)
                        {
                            this.ResponseChosenChatOption.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ResponseChosenChatOption.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setResponseChosenChatOptionYFirstValue = true;
                        ResponseChosenChatOptionYFirstValue = 5f;
                        if (interpolationValue < 1)
                        {
                            this.ResponseContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setResponseContainerHeightFirstValue = true;
                        ResponseContainerHeightFirstValue = 80f;
                        if (interpolationValue < 1)
                        {
                            this.ResponseContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ResponseContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ChatContainer");
                        }
                        setResponseContainerWidthFirstValue = true;
                        ResponseContainerWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.ResponseContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ResponseContainer.WrapsChildren = false;
                        }
                        setResponseContainerXFirstValue = true;
                        ResponseContainerXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ResponseContainer.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setResponseContainerYFirstValue = true;
                        ResponseContainerYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ResponseContainer.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setStyleBarInstanceHeightFirstValue = true;
                        StyleBarInstanceHeightFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.StyleBarInstance.Visible = false;
                        }
                        setStyleBarInstanceWidthFirstValue = true;
                        StyleBarInstanceWidthFirstValue = 100f;
                        setStyleBarInstanceXFirstValue = true;
                        StyleBarInstanceXFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.StyleBarInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.StyleBarInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setStyleBarInstanceYFirstValue = true;
                        StyleBarInstanceYFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.StyleBarInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.StyleBarInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.Font = "SVI Basic Manual";
                        }
                        setTextInstanceFontSizeFirstValue = true;
                        TextInstanceFontSizeFirstValue = 30;
                        setTextInstanceHeightFirstValue = true;
                        TextInstanceHeightFirstValue = -64f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "MessageBox");
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.Text = "!";
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.Visible = false;
                        }
                        setTextInstanceWidthFirstValue = true;
                        TextInstanceWidthFirstValue = -64f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setTextInstanceXFirstValue = true;
                        TextInstanceXFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setTextInstanceYFirstValue = true;
                        TextInstanceYFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setWidthFirstValue = true;
                        WidthFirstValue = 50f;
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
                            this.ChatContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setChatContainerHeightSecondValue = true;
                        ChatContainerHeightSecondValue = 82.13544f;
                        if (interpolationValue >= 1)
                        {
                            this.ChatContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setChatContainerWidthSecondValue = true;
                        ChatContainerWidthSecondValue = 79.9707f;
                        if (interpolationValue >= 1)
                        {
                            this.ChatContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setChatContainerXSecondValue = true;
                        ChatContainerXSecondValue = 9.638672f;
                        if (interpolationValue >= 1)
                        {
                            this.ChatContainer.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setChatContainerYSecondValue = true;
                        ChatContainerYSecondValue = 8.975698f;
                        if (interpolationValue >= 1)
                        {
                            this.ChatContainer.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setChatFrameInstanceHeightSecondValue = true;
                        ChatFrameInstanceHeightSecondValue = 100f;
                        setChatFrameInstanceWidthSecondValue = true;
                        ChatFrameInstanceWidthSecondValue = 100f;
                        setChatFrameInstanceXSecondValue = true;
                        ChatFrameInstanceXSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.ChatFrameInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setChatFrameInstanceYSecondValue = true;
                        ChatFrameInstanceYSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.ChatFrameInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setChatHistoryButtonHeightSecondValue = true;
                        ChatHistoryButtonHeightSecondValue = 56f;
                        setChatHistoryButtonCurrentUpDownStateSecondValue = true;
                        ChatHistoryButtonCurrentUpDownStateSecondValue = AbbatoirIntergrade.GumRuntimes.UpDownButtonRuntime.UpDown.Up;
                        setChatHistoryButtonWidthSecondValue = true;
                        ChatHistoryButtonWidthSecondValue = 66f;
                        setChatHistoryButtonXSecondValue = true;
                        ChatHistoryButtonXSecondValue = 4.244792f;
                        if (interpolationValue >= 1)
                        {
                            this.ChatHistoryButton.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setChatHistoryButtonYSecondValue = true;
                        ChatHistoryButtonYSecondValue = 15.46297f;
                        if (interpolationValue >= 1)
                        {
                            this.ChatHistoryButton.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setChatOption0HeightSecondValue = true;
                        ChatOption0HeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ChatOption0.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        setChatOption0CurrentHighlightStateSecondValue = true;
                        ChatOption0CurrentHighlightStateSecondValue = AbbatoirIntergrade.GumRuntimes.ChatOptionRuntime.Highlight.NotHighlighted;
                        if (interpolationValue >= 1)
                        {
                            this.ChatOption0.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ResponseContainer");
                        }
                        setChatOption0WidthSecondValue = true;
                        ChatOption0WidthSecondValue = 100f;
                        setChatOption0XSecondValue = true;
                        ChatOption0XSecondValue = 0f;
                        setChatOption0YSecondValue = true;
                        ChatOption0YSecondValue = 0f;
                        setChatOption1HeightSecondValue = true;
                        ChatOption1HeightSecondValue = 0f;
                        setChatOption1CurrentHighlightStateSecondValue = true;
                        ChatOption1CurrentHighlightStateSecondValue = AbbatoirIntergrade.GumRuntimes.ChatOptionRuntime.Highlight.NotHighlighted;
                        if (interpolationValue >= 1)
                        {
                            this.ChatOption1.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ResponseContainer");
                        }
                        setChatOption1WidthSecondValue = true;
                        ChatOption1WidthSecondValue = 100f;
                        setChatOption2HeightSecondValue = true;
                        ChatOption2HeightSecondValue = 0f;
                        setChatOption2CurrentHighlightStateSecondValue = true;
                        ChatOption2CurrentHighlightStateSecondValue = AbbatoirIntergrade.GumRuntimes.ChatOptionRuntime.Highlight.NotHighlighted;
                        if (interpolationValue >= 1)
                        {
                            this.ChatOption2.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ResponseContainer");
                        }
                        setChatOption2WidthSecondValue = true;
                        ChatOption2WidthSecondValue = 100f;
                        setCloseChatButtonInstanceHeightSecondValue = true;
                        CloseChatButtonInstanceHeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.CloseChatButtonInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        setCloseChatButtonInstanceWidthSecondValue = true;
                        CloseChatButtonInstanceWidthSecondValue = 5f;
                        if (interpolationValue >= 1)
                        {
                            this.CloseChatButtonInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setCloseChatButtonInstanceXSecondValue = true;
                        CloseChatButtonInstanceXSecondValue = 84.7412f;
                        if (interpolationValue >= 1)
                        {
                            this.CloseChatButtonInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setCloseChatButtonInstanceYSecondValue = true;
                        CloseChatButtonInstanceYSecondValue = 6.777447f;
                        if (interpolationValue >= 1)
                        {
                            this.CloseChatButtonInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setColoredRectangleInstanceAlphaSecondValue = true;
                        ColoredRectangleInstanceAlphaSecondValue = 160;
                        setColoredRectangleInstanceBlueSecondValue = true;
                        ColoredRectangleInstanceBlueSecondValue = 0;
                        setColoredRectangleInstanceGreenSecondValue = true;
                        ColoredRectangleInstanceGreenSecondValue = 0;
                        setColoredRectangleInstanceHeightSecondValue = true;
                        ColoredRectangleInstanceHeightSecondValue = 82.10236f;
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setColoredRectangleInstanceRedSecondValue = true;
                        ColoredRectangleInstanceRedSecondValue = 0;
                        setColoredRectangleInstanceWidthSecondValue = true;
                        ColoredRectangleInstanceWidthSecondValue = 80.05469f;
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setColoredRectangleInstanceXSecondValue = true;
                        ColoredRectangleInstanceXSecondValue = 49.64584f;
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setColoredRectangleInstanceYSecondValue = true;
                        ColoredRectangleInstanceYSecondValue = 50.04165f;
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CurrentText.Font = "SVI Basic Manual";
                        }
                        setCurrentTextFontSizeSecondValue = true;
                        CurrentTextFontSizeSecondValue = 30;
                        setCurrentTextHeightSecondValue = true;
                        CurrentTextHeightSecondValue = 18.29847f;
                        if (interpolationValue >= 1)
                        {
                            this.CurrentText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CurrentText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ChatContainer");
                        }
                        setCurrentTextWidthSecondValue = true;
                        CurrentTextWidthSecondValue = 92.96616f;
                        if (interpolationValue >= 1)
                        {
                            this.CurrentText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setCurrentTextXSecondValue = true;
                        CurrentTextXSecondValue = 0.820613f;
                        if (interpolationValue >= 1)
                        {
                            this.CurrentText.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setCurrentTextYSecondValue = true;
                        CurrentTextYSecondValue = 2.029169f;
                        if (interpolationValue >= 1)
                        {
                            this.CurrentText.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setDialogueShownChatOptionCurrentHighlightStateSecondValue = true;
                        DialogueShownChatOptionCurrentHighlightStateSecondValue = AbbatoirIntergrade.GumRuntimes.ChatOptionRuntime.Highlight.Highlighted;
                        if (interpolationValue >= 1)
                        {
                            this.DialogueShownChatOption.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "RecentResponseContainer");
                        }
                        setHeightSecondValue = true;
                        HeightSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setMessageBoxCurrentColorStateStateSecondValue = true;
                        MessageBoxCurrentColorStateStateSecondValue = AbbatoirIntergrade.GumRuntimes.GlowingBoxRuntime.ColorState.Black;
                        setMessageBoxHeightSecondValue = true;
                        MessageBoxHeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.MessageBox.HeightUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MessageBox.Visible = false;
                        }
                        setMessageBoxWidthSecondValue = true;
                        MessageBoxWidthSecondValue = 10f;
                        setMessageBoxXSecondValue = true;
                        MessageBoxXSecondValue = 0.5952342f;
                        setMessageBoxYSecondValue = true;
                        MessageBoxYSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.MessageBox.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.RecentResponseContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setRecentResponseContainerHeightSecondValue = true;
                        RecentResponseContainerHeightSecondValue = 82f;
                        if (interpolationValue >= 1)
                        {
                            this.RecentResponseContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.RecentResponseContainer.Visible = false;
                        }
                        setRecentResponseContainerWidthSecondValue = true;
                        RecentResponseContainerWidthSecondValue = 80f;
                        if (interpolationValue >= 1)
                        {
                            this.RecentResponseContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setRecentResponseContainerXSecondValue = true;
                        RecentResponseContainerXSecondValue = 9.5f;
                        if (interpolationValue >= 1)
                        {
                            this.RecentResponseContainer.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setRecentResponseContainerYSecondValue = true;
                        RecentResponseContainerYSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.RecentResponseContainer.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ResponseChosenChatOption.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "RecentResponseContainer");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ResponseChosenChatOption.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ResponseChosenChatOption.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        }
                        setResponseChosenChatOptionYSecondValue = true;
                        ResponseChosenChatOptionYSecondValue = 5f;
                        if (interpolationValue >= 1)
                        {
                            this.ResponseContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setResponseContainerHeightSecondValue = true;
                        ResponseContainerHeightSecondValue = 80f;
                        if (interpolationValue >= 1)
                        {
                            this.ResponseContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ResponseContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ChatContainer");
                        }
                        setResponseContainerWidthSecondValue = true;
                        ResponseContainerWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.ResponseContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ResponseContainer.WrapsChildren = false;
                        }
                        setResponseContainerXSecondValue = true;
                        ResponseContainerXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ResponseContainer.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setResponseContainerYSecondValue = true;
                        ResponseContainerYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ResponseContainer.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setStyleBarInstanceHeightSecondValue = true;
                        StyleBarInstanceHeightSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.StyleBarInstance.Visible = false;
                        }
                        setStyleBarInstanceWidthSecondValue = true;
                        StyleBarInstanceWidthSecondValue = 100f;
                        setStyleBarInstanceXSecondValue = true;
                        StyleBarInstanceXSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.StyleBarInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.StyleBarInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setStyleBarInstanceYSecondValue = true;
                        StyleBarInstanceYSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.StyleBarInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.StyleBarInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.Font = "SVI Basic Manual";
                        }
                        setTextInstanceFontSizeSecondValue = true;
                        TextInstanceFontSizeSecondValue = 30;
                        setTextInstanceHeightSecondValue = true;
                        TextInstanceHeightSecondValue = -64f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "MessageBox");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.Text = "!";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.Visible = false;
                        }
                        setTextInstanceWidthSecondValue = true;
                        TextInstanceWidthSecondValue = -64f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setTextInstanceXSecondValue = true;
                        TextInstanceXSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setTextInstanceYSecondValue = true;
                        TextInstanceYSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setWidthSecondValue = true;
                        WidthSecondValue = 50f;
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
                if (setChatContainerHeightFirstValue && setChatContainerHeightSecondValue)
                {
                    ChatContainer.Height = ChatContainerHeightFirstValue * (1 - interpolationValue) + ChatContainerHeightSecondValue * interpolationValue;
                }
                if (setChatContainerWidthFirstValue && setChatContainerWidthSecondValue)
                {
                    ChatContainer.Width = ChatContainerWidthFirstValue * (1 - interpolationValue) + ChatContainerWidthSecondValue * interpolationValue;
                }
                if (setChatContainerXFirstValue && setChatContainerXSecondValue)
                {
                    ChatContainer.X = ChatContainerXFirstValue * (1 - interpolationValue) + ChatContainerXSecondValue * interpolationValue;
                }
                if (setChatContainerYFirstValue && setChatContainerYSecondValue)
                {
                    ChatContainer.Y = ChatContainerYFirstValue * (1 - interpolationValue) + ChatContainerYSecondValue * interpolationValue;
                }
                if (setChatFrameInstanceHeightFirstValue && setChatFrameInstanceHeightSecondValue)
                {
                    ChatFrameInstance.Height = ChatFrameInstanceHeightFirstValue * (1 - interpolationValue) + ChatFrameInstanceHeightSecondValue * interpolationValue;
                }
                if (setChatFrameInstanceWidthFirstValue && setChatFrameInstanceWidthSecondValue)
                {
                    ChatFrameInstance.Width = ChatFrameInstanceWidthFirstValue * (1 - interpolationValue) + ChatFrameInstanceWidthSecondValue * interpolationValue;
                }
                if (setChatFrameInstanceXFirstValue && setChatFrameInstanceXSecondValue)
                {
                    ChatFrameInstance.X = ChatFrameInstanceXFirstValue * (1 - interpolationValue) + ChatFrameInstanceXSecondValue * interpolationValue;
                }
                if (setChatFrameInstanceYFirstValue && setChatFrameInstanceYSecondValue)
                {
                    ChatFrameInstance.Y = ChatFrameInstanceYFirstValue * (1 - interpolationValue) + ChatFrameInstanceYSecondValue * interpolationValue;
                }
                if (setChatHistoryButtonHeightFirstValue && setChatHistoryButtonHeightSecondValue)
                {
                    ChatHistoryButton.Height = ChatHistoryButtonHeightFirstValue * (1 - interpolationValue) + ChatHistoryButtonHeightSecondValue * interpolationValue;
                }
                if (setChatHistoryButtonCurrentUpDownStateFirstValue && setChatHistoryButtonCurrentUpDownStateSecondValue)
                {
                    ChatHistoryButton.InterpolateBetween(ChatHistoryButtonCurrentUpDownStateFirstValue, ChatHistoryButtonCurrentUpDownStateSecondValue, interpolationValue);
                }
                if (setChatHistoryButtonWidthFirstValue && setChatHistoryButtonWidthSecondValue)
                {
                    ChatHistoryButton.Width = ChatHistoryButtonWidthFirstValue * (1 - interpolationValue) + ChatHistoryButtonWidthSecondValue * interpolationValue;
                }
                if (setChatHistoryButtonXFirstValue && setChatHistoryButtonXSecondValue)
                {
                    ChatHistoryButton.X = ChatHistoryButtonXFirstValue * (1 - interpolationValue) + ChatHistoryButtonXSecondValue * interpolationValue;
                }
                if (setChatHistoryButtonYFirstValue && setChatHistoryButtonYSecondValue)
                {
                    ChatHistoryButton.Y = ChatHistoryButtonYFirstValue * (1 - interpolationValue) + ChatHistoryButtonYSecondValue * interpolationValue;
                }
                if (setChatOption0HeightFirstValue && setChatOption0HeightSecondValue)
                {
                    ChatOption0.Height = ChatOption0HeightFirstValue * (1 - interpolationValue) + ChatOption0HeightSecondValue * interpolationValue;
                }
                if (setChatOption0CurrentHighlightStateFirstValue && setChatOption0CurrentHighlightStateSecondValue)
                {
                    ChatOption0.InterpolateBetween(ChatOption0CurrentHighlightStateFirstValue, ChatOption0CurrentHighlightStateSecondValue, interpolationValue);
                }
                if (setChatOption0WidthFirstValue && setChatOption0WidthSecondValue)
                {
                    ChatOption0.Width = ChatOption0WidthFirstValue * (1 - interpolationValue) + ChatOption0WidthSecondValue * interpolationValue;
                }
                if (setChatOption0XFirstValue && setChatOption0XSecondValue)
                {
                    ChatOption0.X = ChatOption0XFirstValue * (1 - interpolationValue) + ChatOption0XSecondValue * interpolationValue;
                }
                if (setChatOption0YFirstValue && setChatOption0YSecondValue)
                {
                    ChatOption0.Y = ChatOption0YFirstValue * (1 - interpolationValue) + ChatOption0YSecondValue * interpolationValue;
                }
                if (setChatOption1HeightFirstValue && setChatOption1HeightSecondValue)
                {
                    ChatOption1.Height = ChatOption1HeightFirstValue * (1 - interpolationValue) + ChatOption1HeightSecondValue * interpolationValue;
                }
                if (setChatOption1CurrentHighlightStateFirstValue && setChatOption1CurrentHighlightStateSecondValue)
                {
                    ChatOption1.InterpolateBetween(ChatOption1CurrentHighlightStateFirstValue, ChatOption1CurrentHighlightStateSecondValue, interpolationValue);
                }
                if (setChatOption1WidthFirstValue && setChatOption1WidthSecondValue)
                {
                    ChatOption1.Width = ChatOption1WidthFirstValue * (1 - interpolationValue) + ChatOption1WidthSecondValue * interpolationValue;
                }
                if (setChatOption2HeightFirstValue && setChatOption2HeightSecondValue)
                {
                    ChatOption2.Height = ChatOption2HeightFirstValue * (1 - interpolationValue) + ChatOption2HeightSecondValue * interpolationValue;
                }
                if (setChatOption2CurrentHighlightStateFirstValue && setChatOption2CurrentHighlightStateSecondValue)
                {
                    ChatOption2.InterpolateBetween(ChatOption2CurrentHighlightStateFirstValue, ChatOption2CurrentHighlightStateSecondValue, interpolationValue);
                }
                if (setChatOption2WidthFirstValue && setChatOption2WidthSecondValue)
                {
                    ChatOption2.Width = ChatOption2WidthFirstValue * (1 - interpolationValue) + ChatOption2WidthSecondValue * interpolationValue;
                }
                if (setCloseChatButtonInstanceHeightFirstValue && setCloseChatButtonInstanceHeightSecondValue)
                {
                    CloseChatButtonInstance.Height = CloseChatButtonInstanceHeightFirstValue * (1 - interpolationValue) + CloseChatButtonInstanceHeightSecondValue * interpolationValue;
                }
                if (setCloseChatButtonInstanceWidthFirstValue && setCloseChatButtonInstanceWidthSecondValue)
                {
                    CloseChatButtonInstance.Width = CloseChatButtonInstanceWidthFirstValue * (1 - interpolationValue) + CloseChatButtonInstanceWidthSecondValue * interpolationValue;
                }
                if (setCloseChatButtonInstanceXFirstValue && setCloseChatButtonInstanceXSecondValue)
                {
                    CloseChatButtonInstance.X = CloseChatButtonInstanceXFirstValue * (1 - interpolationValue) + CloseChatButtonInstanceXSecondValue * interpolationValue;
                }
                if (setCloseChatButtonInstanceYFirstValue && setCloseChatButtonInstanceYSecondValue)
                {
                    CloseChatButtonInstance.Y = CloseChatButtonInstanceYFirstValue * (1 - interpolationValue) + CloseChatButtonInstanceYSecondValue * interpolationValue;
                }
                if (setColoredRectangleInstanceAlphaFirstValue && setColoredRectangleInstanceAlphaSecondValue)
                {
                    ColoredRectangleInstance.Alpha = FlatRedBall.Math.MathFunctions.RoundToInt(ColoredRectangleInstanceAlphaFirstValue* (1 - interpolationValue) + ColoredRectangleInstanceAlphaSecondValue * interpolationValue);
                }
                if (setColoredRectangleInstanceBlueFirstValue && setColoredRectangleInstanceBlueSecondValue)
                {
                    ColoredRectangleInstance.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(ColoredRectangleInstanceBlueFirstValue* (1 - interpolationValue) + ColoredRectangleInstanceBlueSecondValue * interpolationValue);
                }
                if (setColoredRectangleInstanceGreenFirstValue && setColoredRectangleInstanceGreenSecondValue)
                {
                    ColoredRectangleInstance.Green = FlatRedBall.Math.MathFunctions.RoundToInt(ColoredRectangleInstanceGreenFirstValue* (1 - interpolationValue) + ColoredRectangleInstanceGreenSecondValue * interpolationValue);
                }
                if (setColoredRectangleInstanceHeightFirstValue && setColoredRectangleInstanceHeightSecondValue)
                {
                    ColoredRectangleInstance.Height = ColoredRectangleInstanceHeightFirstValue * (1 - interpolationValue) + ColoredRectangleInstanceHeightSecondValue * interpolationValue;
                }
                if (setColoredRectangleInstanceRedFirstValue && setColoredRectangleInstanceRedSecondValue)
                {
                    ColoredRectangleInstance.Red = FlatRedBall.Math.MathFunctions.RoundToInt(ColoredRectangleInstanceRedFirstValue* (1 - interpolationValue) + ColoredRectangleInstanceRedSecondValue * interpolationValue);
                }
                if (setColoredRectangleInstanceWidthFirstValue && setColoredRectangleInstanceWidthSecondValue)
                {
                    ColoredRectangleInstance.Width = ColoredRectangleInstanceWidthFirstValue * (1 - interpolationValue) + ColoredRectangleInstanceWidthSecondValue * interpolationValue;
                }
                if (setColoredRectangleInstanceXFirstValue && setColoredRectangleInstanceXSecondValue)
                {
                    ColoredRectangleInstance.X = ColoredRectangleInstanceXFirstValue * (1 - interpolationValue) + ColoredRectangleInstanceXSecondValue * interpolationValue;
                }
                if (setColoredRectangleInstanceYFirstValue && setColoredRectangleInstanceYSecondValue)
                {
                    ColoredRectangleInstance.Y = ColoredRectangleInstanceYFirstValue * (1 - interpolationValue) + ColoredRectangleInstanceYSecondValue * interpolationValue;
                }
                if (setCurrentTextFontSizeFirstValue && setCurrentTextFontSizeSecondValue)
                {
                    CurrentText.FontSize = FlatRedBall.Math.MathFunctions.RoundToInt(CurrentTextFontSizeFirstValue* (1 - interpolationValue) + CurrentTextFontSizeSecondValue * interpolationValue);
                }
                if (setCurrentTextHeightFirstValue && setCurrentTextHeightSecondValue)
                {
                    CurrentText.Height = CurrentTextHeightFirstValue * (1 - interpolationValue) + CurrentTextHeightSecondValue * interpolationValue;
                }
                if (setCurrentTextWidthFirstValue && setCurrentTextWidthSecondValue)
                {
                    CurrentText.Width = CurrentTextWidthFirstValue * (1 - interpolationValue) + CurrentTextWidthSecondValue * interpolationValue;
                }
                if (setCurrentTextXFirstValue && setCurrentTextXSecondValue)
                {
                    CurrentText.X = CurrentTextXFirstValue * (1 - interpolationValue) + CurrentTextXSecondValue * interpolationValue;
                }
                if (setCurrentTextYFirstValue && setCurrentTextYSecondValue)
                {
                    CurrentText.Y = CurrentTextYFirstValue * (1 - interpolationValue) + CurrentTextYSecondValue * interpolationValue;
                }
                if (setDialogueShownChatOptionCurrentHighlightStateFirstValue && setDialogueShownChatOptionCurrentHighlightStateSecondValue)
                {
                    DialogueShownChatOption.InterpolateBetween(DialogueShownChatOptionCurrentHighlightStateFirstValue, DialogueShownChatOptionCurrentHighlightStateSecondValue, interpolationValue);
                }
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
                }
                if (setMessageBoxCurrentColorStateStateFirstValue && setMessageBoxCurrentColorStateStateSecondValue)
                {
                    MessageBox.InterpolateBetween(MessageBoxCurrentColorStateStateFirstValue, MessageBoxCurrentColorStateStateSecondValue, interpolationValue);
                }
                if (setMessageBoxHeightFirstValue && setMessageBoxHeightSecondValue)
                {
                    MessageBox.Height = MessageBoxHeightFirstValue * (1 - interpolationValue) + MessageBoxHeightSecondValue * interpolationValue;
                }
                if (setMessageBoxWidthFirstValue && setMessageBoxWidthSecondValue)
                {
                    MessageBox.Width = MessageBoxWidthFirstValue * (1 - interpolationValue) + MessageBoxWidthSecondValue * interpolationValue;
                }
                if (setMessageBoxXFirstValue && setMessageBoxXSecondValue)
                {
                    MessageBox.X = MessageBoxXFirstValue * (1 - interpolationValue) + MessageBoxXSecondValue * interpolationValue;
                }
                if (setMessageBoxYFirstValue && setMessageBoxYSecondValue)
                {
                    MessageBox.Y = MessageBoxYFirstValue * (1 - interpolationValue) + MessageBoxYSecondValue * interpolationValue;
                }
                if (setRecentResponseContainerHeightFirstValue && setRecentResponseContainerHeightSecondValue)
                {
                    RecentResponseContainer.Height = RecentResponseContainerHeightFirstValue * (1 - interpolationValue) + RecentResponseContainerHeightSecondValue * interpolationValue;
                }
                if (setRecentResponseContainerWidthFirstValue && setRecentResponseContainerWidthSecondValue)
                {
                    RecentResponseContainer.Width = RecentResponseContainerWidthFirstValue * (1 - interpolationValue) + RecentResponseContainerWidthSecondValue * interpolationValue;
                }
                if (setRecentResponseContainerXFirstValue && setRecentResponseContainerXSecondValue)
                {
                    RecentResponseContainer.X = RecentResponseContainerXFirstValue * (1 - interpolationValue) + RecentResponseContainerXSecondValue * interpolationValue;
                }
                if (setRecentResponseContainerYFirstValue && setRecentResponseContainerYSecondValue)
                {
                    RecentResponseContainer.Y = RecentResponseContainerYFirstValue * (1 - interpolationValue) + RecentResponseContainerYSecondValue * interpolationValue;
                }
                if (setResponseChosenChatOptionYFirstValue && setResponseChosenChatOptionYSecondValue)
                {
                    ResponseChosenChatOption.Y = ResponseChosenChatOptionYFirstValue * (1 - interpolationValue) + ResponseChosenChatOptionYSecondValue * interpolationValue;
                }
                if (setResponseContainerHeightFirstValue && setResponseContainerHeightSecondValue)
                {
                    ResponseContainer.Height = ResponseContainerHeightFirstValue * (1 - interpolationValue) + ResponseContainerHeightSecondValue * interpolationValue;
                }
                if (setResponseContainerWidthFirstValue && setResponseContainerWidthSecondValue)
                {
                    ResponseContainer.Width = ResponseContainerWidthFirstValue * (1 - interpolationValue) + ResponseContainerWidthSecondValue * interpolationValue;
                }
                if (setResponseContainerXFirstValue && setResponseContainerXSecondValue)
                {
                    ResponseContainer.X = ResponseContainerXFirstValue * (1 - interpolationValue) + ResponseContainerXSecondValue * interpolationValue;
                }
                if (setResponseContainerYFirstValue && setResponseContainerYSecondValue)
                {
                    ResponseContainer.Y = ResponseContainerYFirstValue * (1 - interpolationValue) + ResponseContainerYSecondValue * interpolationValue;
                }
                if (setStyleBarInstanceHeightFirstValue && setStyleBarInstanceHeightSecondValue)
                {
                    StyleBarInstance.Height = StyleBarInstanceHeightFirstValue * (1 - interpolationValue) + StyleBarInstanceHeightSecondValue * interpolationValue;
                }
                if (setStyleBarInstanceWidthFirstValue && setStyleBarInstanceWidthSecondValue)
                {
                    StyleBarInstance.Width = StyleBarInstanceWidthFirstValue * (1 - interpolationValue) + StyleBarInstanceWidthSecondValue * interpolationValue;
                }
                if (setStyleBarInstanceXFirstValue && setStyleBarInstanceXSecondValue)
                {
                    StyleBarInstance.X = StyleBarInstanceXFirstValue * (1 - interpolationValue) + StyleBarInstanceXSecondValue * interpolationValue;
                }
                if (setStyleBarInstanceYFirstValue && setStyleBarInstanceYSecondValue)
                {
                    StyleBarInstance.Y = StyleBarInstanceYFirstValue * (1 - interpolationValue) + StyleBarInstanceYSecondValue * interpolationValue;
                }
                if (setTextInstanceFontSizeFirstValue && setTextInstanceFontSizeSecondValue)
                {
                    TextInstance.FontSize = FlatRedBall.Math.MathFunctions.RoundToInt(TextInstanceFontSizeFirstValue* (1 - interpolationValue) + TextInstanceFontSizeSecondValue * interpolationValue);
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
            public void InterpolateBetween (Appearance firstState, Appearance secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setChatFrameInstanceHeightFirstValue = false;
                bool setChatFrameInstanceHeightSecondValue = false;
                float ChatFrameInstanceHeightFirstValue= 0;
                float ChatFrameInstanceHeightSecondValue= 0;
                bool setColoredRectangleInstanceAlphaFirstValue = false;
                bool setColoredRectangleInstanceAlphaSecondValue = false;
                int ColoredRectangleInstanceAlphaFirstValue= 0;
                int ColoredRectangleInstanceAlphaSecondValue= 0;
                bool setColoredRectangleInstanceHeightFirstValue = false;
                bool setColoredRectangleInstanceHeightSecondValue = false;
                float ColoredRectangleInstanceHeightFirstValue= 0;
                float ColoredRectangleInstanceHeightSecondValue= 0;
                bool setStyleBarInstanceHeightFirstValue = false;
                bool setStyleBarInstanceHeightSecondValue = false;
                float StyleBarInstanceHeightFirstValue= 0;
                float StyleBarInstanceHeightSecondValue= 0;
                bool setStyleBarInstanceWidthFirstValue = false;
                bool setStyleBarInstanceWidthSecondValue = false;
                float StyleBarInstanceWidthFirstValue= 0;
                float StyleBarInstanceWidthSecondValue= 0;
                bool setStyleBarInstanceXFirstValue = false;
                bool setStyleBarInstanceXSecondValue = false;
                float StyleBarInstanceXFirstValue= 0;
                float StyleBarInstanceXSecondValue= 0;
                bool setStyleBarInstanceYFirstValue = false;
                bool setStyleBarInstanceYSecondValue = false;
                float StyleBarInstanceYFirstValue= 0;
                float StyleBarInstanceYSecondValue= 0;
                switch(firstState)
                {
                    case  Appearance.ChatOpen:
                        if (interpolationValue < 1)
                        {
                            this.ChatContainer.Visible = false;
                        }
                        setChatFrameInstanceHeightFirstValue = true;
                        ChatFrameInstanceHeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.ChatFrameInstance.Visible = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ChatHistoryButton.Visible = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CloseChatButtonInstance.Visible = true;
                        }
                        setColoredRectangleInstanceAlphaFirstValue = true;
                        ColoredRectangleInstanceAlphaFirstValue = 160;
                        setColoredRectangleInstanceHeightFirstValue = true;
                        ColoredRectangleInstanceHeightFirstValue = 82.10236f;
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance.Visible = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CurrentText.Visible = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MessageBox.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.RecentResponseContainer.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ResponseContainer.Visible = true;
                        }
                        setStyleBarInstanceHeightFirstValue = true;
                        StyleBarInstanceHeightFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.StyleBarInstance.Visible = false;
                        }
                        setStyleBarInstanceWidthFirstValue = true;
                        StyleBarInstanceWidthFirstValue = 100f;
                        setStyleBarInstanceXFirstValue = true;
                        StyleBarInstanceXFirstValue = 50f;
                        setStyleBarInstanceYFirstValue = true;
                        StyleBarInstanceYFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.Visible = false;
                        }
                        break;
                    case  Appearance.Appear1:
                        if (interpolationValue < 1)
                        {
                            this.ChatContainer.Visible = false;
                        }
                        setChatFrameInstanceHeightFirstValue = true;
                        ChatFrameInstanceHeightFirstValue = 5f;
                        if (interpolationValue < 1)
                        {
                            this.ChatFrameInstance.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ChatHistoryButton.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CloseChatButtonInstance.Visible = false;
                        }
                        setColoredRectangleInstanceAlphaFirstValue = true;
                        ColoredRectangleInstanceAlphaFirstValue = 160;
                        setColoredRectangleInstanceHeightFirstValue = true;
                        ColoredRectangleInstanceHeightFirstValue = 4.1f;
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CurrentText.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MessageBox.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.RecentResponseContainer.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ResponseContainer.Visible = false;
                        }
                        setStyleBarInstanceHeightFirstValue = true;
                        StyleBarInstanceHeightFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.StyleBarInstance.Visible = true;
                        }
                        setStyleBarInstanceWidthFirstValue = true;
                        StyleBarInstanceWidthFirstValue = 10f;
                        setStyleBarInstanceXFirstValue = true;
                        StyleBarInstanceXFirstValue = 6f;
                        setStyleBarInstanceYFirstValue = true;
                        StyleBarInstanceYFirstValue = 90f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.Visible = false;
                        }
                        break;
                    case  Appearance.Appear2:
                        if (interpolationValue < 1)
                        {
                            this.ChatContainer.Visible = false;
                        }
                        setChatFrameInstanceHeightFirstValue = true;
                        ChatFrameInstanceHeightFirstValue = 5f;
                        if (interpolationValue < 1)
                        {
                            this.ChatFrameInstance.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ChatHistoryButton.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CloseChatButtonInstance.Visible = false;
                        }
                        setColoredRectangleInstanceAlphaFirstValue = true;
                        ColoredRectangleInstanceAlphaFirstValue = 160;
                        setColoredRectangleInstanceHeightFirstValue = true;
                        ColoredRectangleInstanceHeightFirstValue = 4.1f;
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CurrentText.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MessageBox.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.RecentResponseContainer.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ResponseContainer.Visible = false;
                        }
                        setStyleBarInstanceHeightFirstValue = true;
                        StyleBarInstanceHeightFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.StyleBarInstance.Visible = true;
                        }
                        setStyleBarInstanceWidthFirstValue = true;
                        StyleBarInstanceWidthFirstValue = 100f;
                        setStyleBarInstanceXFirstValue = true;
                        StyleBarInstanceXFirstValue = 50f;
                        setStyleBarInstanceYFirstValue = true;
                        StyleBarInstanceYFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.Visible = false;
                        }
                        break;
                    case  Appearance.Appear3:
                        if (interpolationValue < 1)
                        {
                            this.ChatContainer.Visible = false;
                        }
                        setChatFrameInstanceHeightFirstValue = true;
                        ChatFrameInstanceHeightFirstValue = 5f;
                        if (interpolationValue < 1)
                        {
                            this.ChatFrameInstance.Visible = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ChatHistoryButton.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CloseChatButtonInstance.Visible = false;
                        }
                        setColoredRectangleInstanceAlphaFirstValue = true;
                        ColoredRectangleInstanceAlphaFirstValue = 0;
                        setColoredRectangleInstanceHeightFirstValue = true;
                        ColoredRectangleInstanceHeightFirstValue = 4.1f;
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance.Visible = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CurrentText.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MessageBox.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.RecentResponseContainer.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ResponseContainer.Visible = true;
                        }
                        setStyleBarInstanceHeightFirstValue = true;
                        StyleBarInstanceHeightFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.StyleBarInstance.Visible = false;
                        }
                        setStyleBarInstanceWidthFirstValue = true;
                        StyleBarInstanceWidthFirstValue = 100f;
                        setStyleBarInstanceXFirstValue = true;
                        StyleBarInstanceXFirstValue = 50f;
                        setStyleBarInstanceYFirstValue = true;
                        StyleBarInstanceYFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.Visible = false;
                        }
                        break;
                    case  Appearance.Appear4:
                        if (interpolationValue < 1)
                        {
                            this.ChatContainer.Visible = true;
                        }
                        setChatFrameInstanceHeightFirstValue = true;
                        ChatFrameInstanceHeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.ChatFrameInstance.Visible = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ChatHistoryButton.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CloseChatButtonInstance.Visible = false;
                        }
                        setColoredRectangleInstanceAlphaFirstValue = true;
                        ColoredRectangleInstanceAlphaFirstValue = 80;
                        setColoredRectangleInstanceHeightFirstValue = true;
                        ColoredRectangleInstanceHeightFirstValue = 82.10236f;
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance.Visible = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CurrentText.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MessageBox.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.RecentResponseContainer.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ResponseContainer.Visible = false;
                        }
                        setStyleBarInstanceHeightFirstValue = true;
                        StyleBarInstanceHeightFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.StyleBarInstance.Visible = false;
                        }
                        setStyleBarInstanceWidthFirstValue = true;
                        StyleBarInstanceWidthFirstValue = 100f;
                        setStyleBarInstanceXFirstValue = true;
                        StyleBarInstanceXFirstValue = 50f;
                        setStyleBarInstanceYFirstValue = true;
                        StyleBarInstanceYFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.Visible = false;
                        }
                        break;
                    case  Appearance.ChatClosed:
                        if (interpolationValue < 1)
                        {
                            this.ChatContainer.Visible = false;
                        }
                        setChatFrameInstanceHeightFirstValue = true;
                        ChatFrameInstanceHeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.ChatFrameInstance.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ChatHistoryButton.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CloseChatButtonInstance.Visible = false;
                        }
                        setColoredRectangleInstanceAlphaFirstValue = true;
                        ColoredRectangleInstanceAlphaFirstValue = 160;
                        setColoredRectangleInstanceHeightFirstValue = true;
                        ColoredRectangleInstanceHeightFirstValue = 4.1f;
                        if (interpolationValue < 1)
                        {
                            this.ColoredRectangleInstance.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CurrentText.Visible = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MessageBox.Visible = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.RecentResponseContainer.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ResponseContainer.Visible = true;
                        }
                        setStyleBarInstanceHeightFirstValue = true;
                        StyleBarInstanceHeightFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.StyleBarInstance.Visible = false;
                        }
                        setStyleBarInstanceWidthFirstValue = true;
                        StyleBarInstanceWidthFirstValue = 10f;
                        setStyleBarInstanceXFirstValue = true;
                        StyleBarInstanceXFirstValue = 6f;
                        setStyleBarInstanceYFirstValue = true;
                        StyleBarInstanceYFirstValue = 90f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.Visible = false;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  Appearance.ChatOpen:
                        if (interpolationValue >= 1)
                        {
                            this.ChatContainer.Visible = false;
                        }
                        setChatFrameInstanceHeightSecondValue = true;
                        ChatFrameInstanceHeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.ChatFrameInstance.Visible = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ChatHistoryButton.Visible = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CloseChatButtonInstance.Visible = true;
                        }
                        setColoredRectangleInstanceAlphaSecondValue = true;
                        ColoredRectangleInstanceAlphaSecondValue = 160;
                        setColoredRectangleInstanceHeightSecondValue = true;
                        ColoredRectangleInstanceHeightSecondValue = 82.10236f;
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance.Visible = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CurrentText.Visible = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MessageBox.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.RecentResponseContainer.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ResponseContainer.Visible = true;
                        }
                        setStyleBarInstanceHeightSecondValue = true;
                        StyleBarInstanceHeightSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.StyleBarInstance.Visible = false;
                        }
                        setStyleBarInstanceWidthSecondValue = true;
                        StyleBarInstanceWidthSecondValue = 100f;
                        setStyleBarInstanceXSecondValue = true;
                        StyleBarInstanceXSecondValue = 50f;
                        setStyleBarInstanceYSecondValue = true;
                        StyleBarInstanceYSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.Visible = false;
                        }
                        break;
                    case  Appearance.Appear1:
                        if (interpolationValue >= 1)
                        {
                            this.ChatContainer.Visible = false;
                        }
                        setChatFrameInstanceHeightSecondValue = true;
                        ChatFrameInstanceHeightSecondValue = 5f;
                        if (interpolationValue >= 1)
                        {
                            this.ChatFrameInstance.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ChatHistoryButton.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CloseChatButtonInstance.Visible = false;
                        }
                        setColoredRectangleInstanceAlphaSecondValue = true;
                        ColoredRectangleInstanceAlphaSecondValue = 160;
                        setColoredRectangleInstanceHeightSecondValue = true;
                        ColoredRectangleInstanceHeightSecondValue = 4.1f;
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CurrentText.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MessageBox.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.RecentResponseContainer.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ResponseContainer.Visible = false;
                        }
                        setStyleBarInstanceHeightSecondValue = true;
                        StyleBarInstanceHeightSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.StyleBarInstance.Visible = true;
                        }
                        setStyleBarInstanceWidthSecondValue = true;
                        StyleBarInstanceWidthSecondValue = 10f;
                        setStyleBarInstanceXSecondValue = true;
                        StyleBarInstanceXSecondValue = 6f;
                        setStyleBarInstanceYSecondValue = true;
                        StyleBarInstanceYSecondValue = 90f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.Visible = false;
                        }
                        break;
                    case  Appearance.Appear2:
                        if (interpolationValue >= 1)
                        {
                            this.ChatContainer.Visible = false;
                        }
                        setChatFrameInstanceHeightSecondValue = true;
                        ChatFrameInstanceHeightSecondValue = 5f;
                        if (interpolationValue >= 1)
                        {
                            this.ChatFrameInstance.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ChatHistoryButton.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CloseChatButtonInstance.Visible = false;
                        }
                        setColoredRectangleInstanceAlphaSecondValue = true;
                        ColoredRectangleInstanceAlphaSecondValue = 160;
                        setColoredRectangleInstanceHeightSecondValue = true;
                        ColoredRectangleInstanceHeightSecondValue = 4.1f;
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CurrentText.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MessageBox.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.RecentResponseContainer.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ResponseContainer.Visible = false;
                        }
                        setStyleBarInstanceHeightSecondValue = true;
                        StyleBarInstanceHeightSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.StyleBarInstance.Visible = true;
                        }
                        setStyleBarInstanceWidthSecondValue = true;
                        StyleBarInstanceWidthSecondValue = 100f;
                        setStyleBarInstanceXSecondValue = true;
                        StyleBarInstanceXSecondValue = 50f;
                        setStyleBarInstanceYSecondValue = true;
                        StyleBarInstanceYSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.Visible = false;
                        }
                        break;
                    case  Appearance.Appear3:
                        if (interpolationValue >= 1)
                        {
                            this.ChatContainer.Visible = false;
                        }
                        setChatFrameInstanceHeightSecondValue = true;
                        ChatFrameInstanceHeightSecondValue = 5f;
                        if (interpolationValue >= 1)
                        {
                            this.ChatFrameInstance.Visible = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ChatHistoryButton.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CloseChatButtonInstance.Visible = false;
                        }
                        setColoredRectangleInstanceAlphaSecondValue = true;
                        ColoredRectangleInstanceAlphaSecondValue = 0;
                        setColoredRectangleInstanceHeightSecondValue = true;
                        ColoredRectangleInstanceHeightSecondValue = 4.1f;
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance.Visible = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CurrentText.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MessageBox.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.RecentResponseContainer.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ResponseContainer.Visible = true;
                        }
                        setStyleBarInstanceHeightSecondValue = true;
                        StyleBarInstanceHeightSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.StyleBarInstance.Visible = false;
                        }
                        setStyleBarInstanceWidthSecondValue = true;
                        StyleBarInstanceWidthSecondValue = 100f;
                        setStyleBarInstanceXSecondValue = true;
                        StyleBarInstanceXSecondValue = 50f;
                        setStyleBarInstanceYSecondValue = true;
                        StyleBarInstanceYSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.Visible = false;
                        }
                        break;
                    case  Appearance.Appear4:
                        if (interpolationValue >= 1)
                        {
                            this.ChatContainer.Visible = true;
                        }
                        setChatFrameInstanceHeightSecondValue = true;
                        ChatFrameInstanceHeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.ChatFrameInstance.Visible = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ChatHistoryButton.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CloseChatButtonInstance.Visible = false;
                        }
                        setColoredRectangleInstanceAlphaSecondValue = true;
                        ColoredRectangleInstanceAlphaSecondValue = 80;
                        setColoredRectangleInstanceHeightSecondValue = true;
                        ColoredRectangleInstanceHeightSecondValue = 82.10236f;
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance.Visible = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CurrentText.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MessageBox.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.RecentResponseContainer.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ResponseContainer.Visible = false;
                        }
                        setStyleBarInstanceHeightSecondValue = true;
                        StyleBarInstanceHeightSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.StyleBarInstance.Visible = false;
                        }
                        setStyleBarInstanceWidthSecondValue = true;
                        StyleBarInstanceWidthSecondValue = 100f;
                        setStyleBarInstanceXSecondValue = true;
                        StyleBarInstanceXSecondValue = 50f;
                        setStyleBarInstanceYSecondValue = true;
                        StyleBarInstanceYSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.Visible = false;
                        }
                        break;
                    case  Appearance.ChatClosed:
                        if (interpolationValue >= 1)
                        {
                            this.ChatContainer.Visible = false;
                        }
                        setChatFrameInstanceHeightSecondValue = true;
                        ChatFrameInstanceHeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.ChatFrameInstance.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ChatHistoryButton.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CloseChatButtonInstance.Visible = false;
                        }
                        setColoredRectangleInstanceAlphaSecondValue = true;
                        ColoredRectangleInstanceAlphaSecondValue = 160;
                        setColoredRectangleInstanceHeightSecondValue = true;
                        ColoredRectangleInstanceHeightSecondValue = 4.1f;
                        if (interpolationValue >= 1)
                        {
                            this.ColoredRectangleInstance.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CurrentText.Visible = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MessageBox.Visible = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.RecentResponseContainer.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ResponseContainer.Visible = true;
                        }
                        setStyleBarInstanceHeightSecondValue = true;
                        StyleBarInstanceHeightSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.StyleBarInstance.Visible = false;
                        }
                        setStyleBarInstanceWidthSecondValue = true;
                        StyleBarInstanceWidthSecondValue = 10f;
                        setStyleBarInstanceXSecondValue = true;
                        StyleBarInstanceXSecondValue = 6f;
                        setStyleBarInstanceYSecondValue = true;
                        StyleBarInstanceYSecondValue = 90f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.Visible = false;
                        }
                        break;
                }
                if (setChatFrameInstanceHeightFirstValue && setChatFrameInstanceHeightSecondValue)
                {
                    ChatFrameInstance.Height = ChatFrameInstanceHeightFirstValue * (1 - interpolationValue) + ChatFrameInstanceHeightSecondValue * interpolationValue;
                }
                if (setColoredRectangleInstanceAlphaFirstValue && setColoredRectangleInstanceAlphaSecondValue)
                {
                    ColoredRectangleInstance.Alpha = FlatRedBall.Math.MathFunctions.RoundToInt(ColoredRectangleInstanceAlphaFirstValue* (1 - interpolationValue) + ColoredRectangleInstanceAlphaSecondValue * interpolationValue);
                }
                if (setColoredRectangleInstanceHeightFirstValue && setColoredRectangleInstanceHeightSecondValue)
                {
                    ColoredRectangleInstance.Height = ColoredRectangleInstanceHeightFirstValue * (1 - interpolationValue) + ColoredRectangleInstanceHeightSecondValue * interpolationValue;
                }
                if (setStyleBarInstanceHeightFirstValue && setStyleBarInstanceHeightSecondValue)
                {
                    StyleBarInstance.Height = StyleBarInstanceHeightFirstValue * (1 - interpolationValue) + StyleBarInstanceHeightSecondValue * interpolationValue;
                }
                if (setStyleBarInstanceWidthFirstValue && setStyleBarInstanceWidthSecondValue)
                {
                    StyleBarInstance.Width = StyleBarInstanceWidthFirstValue * (1 - interpolationValue) + StyleBarInstanceWidthSecondValue * interpolationValue;
                }
                if (setStyleBarInstanceXFirstValue && setStyleBarInstanceXSecondValue)
                {
                    StyleBarInstance.X = StyleBarInstanceXFirstValue * (1 - interpolationValue) + StyleBarInstanceXSecondValue * interpolationValue;
                }
                if (setStyleBarInstanceYFirstValue && setStyleBarInstanceYSecondValue)
                {
                    StyleBarInstance.Y = StyleBarInstanceYFirstValue * (1 - interpolationValue) + StyleBarInstanceYSecondValue * interpolationValue;
                }
                if (interpolationValue < 1)
                {
                    mCurrentAppearanceState = firstState;
                }
                else
                {
                    mCurrentAppearanceState = secondState;
                }
            }
            public void InterpolateBetween (MessageIndicator firstState, MessageIndicator secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setMessageBoxCurrentColorStateStateFirstValue = false;
                bool setMessageBoxCurrentColorStateStateSecondValue = false;
                GlowingBoxRuntime.ColorState MessageBoxCurrentColorStateStateFirstValue= GlowingBoxRuntime.ColorState.Red;
                GlowingBoxRuntime.ColorState MessageBoxCurrentColorStateStateSecondValue= GlowingBoxRuntime.ColorState.Red;
                bool setTextInstanceBlueFirstValue = false;
                bool setTextInstanceBlueSecondValue = false;
                int TextInstanceBlueFirstValue= 0;
                int TextInstanceBlueSecondValue= 0;
                bool setTextInstanceGreenFirstValue = false;
                bool setTextInstanceGreenSecondValue = false;
                int TextInstanceGreenFirstValue= 0;
                int TextInstanceGreenSecondValue= 0;
                bool setTextInstanceRedFirstValue = false;
                bool setTextInstanceRedSecondValue = false;
                int TextInstanceRedFirstValue= 0;
                int TextInstanceRedSecondValue= 0;
                switch(firstState)
                {
                    case  MessageIndicator.NewMessage:
                        setMessageBoxCurrentColorStateStateFirstValue = true;
                        MessageBoxCurrentColorStateStateFirstValue = AbbatoirIntergrade.GumRuntimes.GlowingBoxRuntime.ColorState.Blue;
                        setTextInstanceBlueFirstValue = true;
                        TextInstanceBlueFirstValue = 0;
                        setTextInstanceGreenFirstValue = true;
                        TextInstanceGreenFirstValue = 0;
                        setTextInstanceRedFirstValue = true;
                        TextInstanceRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.Visible = true;
                        }
                        break;
                    case  MessageIndicator.NoMessage:
                        setMessageBoxCurrentColorStateStateFirstValue = true;
                        MessageBoxCurrentColorStateStateFirstValue = AbbatoirIntergrade.GumRuntimes.GlowingBoxRuntime.ColorState.Black;
                        setTextInstanceBlueFirstValue = true;
                        TextInstanceBlueFirstValue = 255;
                        setTextInstanceGreenFirstValue = true;
                        TextInstanceGreenFirstValue = 255;
                        setTextInstanceRedFirstValue = true;
                        TextInstanceRedFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.Visible = false;
                        }
                        break;
                    case  MessageIndicator.NoMessageHighlighted:
                        setMessageBoxCurrentColorStateStateFirstValue = true;
                        MessageBoxCurrentColorStateStateFirstValue = AbbatoirIntergrade.GumRuntimes.GlowingBoxRuntime.ColorState.Green;
                        setTextInstanceBlueFirstValue = true;
                        TextInstanceBlueFirstValue = 255;
                        setTextInstanceGreenFirstValue = true;
                        TextInstanceGreenFirstValue = 255;
                        setTextInstanceRedFirstValue = true;
                        TextInstanceRedFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.Visible = false;
                        }
                        break;
                    case  MessageIndicator.NewMessageHighlighted:
                        setMessageBoxCurrentColorStateStateFirstValue = true;
                        MessageBoxCurrentColorStateStateFirstValue = AbbatoirIntergrade.GumRuntimes.GlowingBoxRuntime.ColorState.Green;
                        setTextInstanceBlueFirstValue = true;
                        TextInstanceBlueFirstValue = 255;
                        setTextInstanceGreenFirstValue = true;
                        TextInstanceGreenFirstValue = 255;
                        setTextInstanceRedFirstValue = true;
                        TextInstanceRedFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.Visible = true;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  MessageIndicator.NewMessage:
                        setMessageBoxCurrentColorStateStateSecondValue = true;
                        MessageBoxCurrentColorStateStateSecondValue = AbbatoirIntergrade.GumRuntimes.GlowingBoxRuntime.ColorState.Blue;
                        setTextInstanceBlueSecondValue = true;
                        TextInstanceBlueSecondValue = 0;
                        setTextInstanceGreenSecondValue = true;
                        TextInstanceGreenSecondValue = 0;
                        setTextInstanceRedSecondValue = true;
                        TextInstanceRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.Visible = true;
                        }
                        break;
                    case  MessageIndicator.NoMessage:
                        setMessageBoxCurrentColorStateStateSecondValue = true;
                        MessageBoxCurrentColorStateStateSecondValue = AbbatoirIntergrade.GumRuntimes.GlowingBoxRuntime.ColorState.Black;
                        setTextInstanceBlueSecondValue = true;
                        TextInstanceBlueSecondValue = 255;
                        setTextInstanceGreenSecondValue = true;
                        TextInstanceGreenSecondValue = 255;
                        setTextInstanceRedSecondValue = true;
                        TextInstanceRedSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.Visible = false;
                        }
                        break;
                    case  MessageIndicator.NoMessageHighlighted:
                        setMessageBoxCurrentColorStateStateSecondValue = true;
                        MessageBoxCurrentColorStateStateSecondValue = AbbatoirIntergrade.GumRuntimes.GlowingBoxRuntime.ColorState.Green;
                        setTextInstanceBlueSecondValue = true;
                        TextInstanceBlueSecondValue = 255;
                        setTextInstanceGreenSecondValue = true;
                        TextInstanceGreenSecondValue = 255;
                        setTextInstanceRedSecondValue = true;
                        TextInstanceRedSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.Visible = false;
                        }
                        break;
                    case  MessageIndicator.NewMessageHighlighted:
                        setMessageBoxCurrentColorStateStateSecondValue = true;
                        MessageBoxCurrentColorStateStateSecondValue = AbbatoirIntergrade.GumRuntimes.GlowingBoxRuntime.ColorState.Green;
                        setTextInstanceBlueSecondValue = true;
                        TextInstanceBlueSecondValue = 255;
                        setTextInstanceGreenSecondValue = true;
                        TextInstanceGreenSecondValue = 255;
                        setTextInstanceRedSecondValue = true;
                        TextInstanceRedSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.Visible = true;
                        }
                        break;
                }
                if (setMessageBoxCurrentColorStateStateFirstValue && setMessageBoxCurrentColorStateStateSecondValue)
                {
                    MessageBox.InterpolateBetween(MessageBoxCurrentColorStateStateFirstValue, MessageBoxCurrentColorStateStateSecondValue, interpolationValue);
                }
                if (setTextInstanceBlueFirstValue && setTextInstanceBlueSecondValue)
                {
                    TextInstance.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(TextInstanceBlueFirstValue* (1 - interpolationValue) + TextInstanceBlueSecondValue * interpolationValue);
                }
                if (setTextInstanceGreenFirstValue && setTextInstanceGreenSecondValue)
                {
                    TextInstance.Green = FlatRedBall.Math.MathFunctions.RoundToInt(TextInstanceGreenFirstValue* (1 - interpolationValue) + TextInstanceGreenSecondValue * interpolationValue);
                }
                if (setTextInstanceRedFirstValue && setTextInstanceRedSecondValue)
                {
                    TextInstance.Red = FlatRedBall.Math.MathFunctions.RoundToInt(TextInstanceRedFirstValue* (1 - interpolationValue) + TextInstanceRedSecondValue * interpolationValue);
                }
                if (interpolationValue < 1)
                {
                    mCurrentMessageIndicatorState = firstState;
                }
                else
                {
                    mCurrentMessageIndicatorState = secondState;
                }
            }
            public void InterpolateBetween (ResponseAvailability firstState, ResponseAvailability secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                switch(firstState)
                {
                    case  ResponseAvailability.AwaitingResponse:
                        if (interpolationValue < 1)
                        {
                            this.ChatContainer.Visible = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.RecentResponseContainer.Visible = false;
                        }
                        break;
                    case  ResponseAvailability.AlreadyResponded:
                        if (interpolationValue < 1)
                        {
                            this.ChatContainer.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.RecentResponseContainer.Visible = true;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  ResponseAvailability.AwaitingResponse:
                        if (interpolationValue >= 1)
                        {
                            this.ChatContainer.Visible = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.RecentResponseContainer.Visible = false;
                        }
                        break;
                    case  ResponseAvailability.AlreadyResponded:
                        if (interpolationValue >= 1)
                        {
                            this.ChatContainer.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.RecentResponseContainer.Visible = true;
                        }
                        break;
                }
                if (interpolationValue < 1)
                {
                    mCurrentResponseAvailabilityState = firstState;
                }
                else
                {
                    mCurrentResponseAvailabilityState = secondState;
                }
            }
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.ChatBoxRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.ChatBoxRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.ChatBoxRuntime.Appearance fromState,AbbatoirIntergrade.GumRuntimes.ChatBoxRuntime.Appearance toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Appearance toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "Appearance").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentAppearanceState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (Appearance toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentAppearanceState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.ChatBoxRuntime.MessageIndicator fromState,AbbatoirIntergrade.GumRuntimes.ChatBoxRuntime.MessageIndicator toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (MessageIndicator toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "MessageIndicator").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentMessageIndicatorState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (MessageIndicator toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentMessageIndicatorState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.ChatBoxRuntime.ResponseAvailability fromState,AbbatoirIntergrade.GumRuntimes.ChatBoxRuntime.ResponseAvailability toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (ResponseAvailability toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "ResponseAvailability").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentResponseAvailabilityState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (ResponseAvailability toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentResponseAvailabilityState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            #endregion
            #region State Animations
            private System.Collections.Generic.IEnumerable<FlatRedBall.Instructions.Instruction> AppearAnimationInstructions (object target) 
            {
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction( ()=> this.CurrentAppearanceState = Appearance.ChatClosed);
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime;
                    toReturn.Target = target;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(Appearance.Appear1, 0.05f, FlatRedBall.Glue.StateInterpolation.InterpolationType.Linear, FlatRedBall.Glue.StateInterpolation.Easing.Out, AppearAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(Appearance.Appear2, 0.2f, FlatRedBall.Glue.StateInterpolation.InterpolationType.Quadratic, FlatRedBall.Glue.StateInterpolation.Easing.Out, AppearAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0.05f;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(Appearance.Appear3, 0.09999999f, FlatRedBall.Glue.StateInterpolation.InterpolationType.Quadratic, FlatRedBall.Glue.StateInterpolation.Easing.Out, AppearAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0.25f;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(Appearance.Appear4, 0.15f, FlatRedBall.Glue.StateInterpolation.InterpolationType.Linear, FlatRedBall.Glue.StateInterpolation.Easing.Out, AppearAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0.35f;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(Appearance.ChatOpen, 0.25f, FlatRedBall.Glue.StateInterpolation.InterpolationType.Linear, FlatRedBall.Glue.StateInterpolation.Easing.Out, AppearAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0.5f;
                    yield return toReturn;
                }
            }
            private System.Collections.Generic.IEnumerable<FlatRedBall.Instructions.Instruction> AppearAnimationRelativeInstructions (object target) 
            {
                {
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(() =>
                    {
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "Appearance/ChatClosed").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "Appearance/Appear1").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(Appearance.Appear1);
                        Gum.DataTypes.Variables.StateSave second = first.Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.AddIntoThis(second, difference);
                        FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: 0.05f, type: FlatRedBall.Glue.StateInterpolation.InterpolationType.Linear, easing: FlatRedBall.Glue.StateInterpolation.Easing.Out);
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
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "Appearance/Appear1").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "Appearance/Appear2").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(Appearance.Appear2);
                        Gum.DataTypes.Variables.StateSave second = first.Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.AddIntoThis(second, difference);
                        FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: 0.2f, type: FlatRedBall.Glue.StateInterpolation.InterpolationType.Quadratic, easing: FlatRedBall.Glue.StateInterpolation.Easing.Out);
                        tweener.Owner = this;
                        tweener.PositionChanged = newPosition => this.InterpolateBetween(first, second, newPosition);
                        tweener.Start();
                        StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                    }
                    );
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0.05f;
                    toReturn.Target = target;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(() =>
                    {
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "Appearance/Appear2").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "Appearance/Appear3").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(Appearance.Appear3);
                        Gum.DataTypes.Variables.StateSave second = first.Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.AddIntoThis(second, difference);
                        FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: 0.09999999f, type: FlatRedBall.Glue.StateInterpolation.InterpolationType.Quadratic, easing: FlatRedBall.Glue.StateInterpolation.Easing.Out);
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
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "Appearance/Appear3").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "Appearance/Appear4").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(Appearance.Appear4);
                        Gum.DataTypes.Variables.StateSave second = first.Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.AddIntoThis(second, difference);
                        FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: 0.15f, type: FlatRedBall.Glue.StateInterpolation.InterpolationType.Linear, easing: FlatRedBall.Glue.StateInterpolation.Easing.Out);
                        tweener.Owner = this;
                        tweener.PositionChanged = newPosition => this.InterpolateBetween(first, second, newPosition);
                        tweener.Start();
                        StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                    }
                    );
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0.35f;
                    toReturn.Target = target;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(() =>
                    {
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "Appearance/Appear4").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "Appearance/ChatOpen").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(Appearance.ChatOpen);
                        Gum.DataTypes.Variables.StateSave second = first.Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.AddIntoThis(second, difference);
                        FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: 0.25f, type: FlatRedBall.Glue.StateInterpolation.InterpolationType.Linear, easing: FlatRedBall.Glue.StateInterpolation.Easing.Out);
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
            }
            private FlatRedBall.Gum.Animation.GumAnimation appearAnimation;
            public FlatRedBall.Gum.Animation.GumAnimation AppearAnimation
            {
                get
                {
                    if (appearAnimation == null)
                    {
                        appearAnimation = new FlatRedBall.Gum.Animation.GumAnimation(0.75f, AppearAnimationInstructions);
                        appearAnimation.AddEvent("ChatOpen", 0.74f);
                    }
                    return appearAnimation;
                }
            }
            private FlatRedBall.Gum.Animation.GumAnimation appearAnimationRelative;
            public FlatRedBall.Gum.Animation.GumAnimation AppearAnimationRelative
            {
                get
                {
                    if (appearAnimationRelative == null)
                    {
                        appearAnimationRelative = new FlatRedBall.Gum.Animation.GumAnimation(0.75f, AppearAnimationRelativeInstructions);
                        appearAnimationRelative.AddEvent("ChatOpen", 0.74f);
                    }
                    return appearAnimationRelative;
                }
            }
            private System.Collections.Generic.IEnumerable<FlatRedBall.Instructions.Instruction> DisappearAnimationInstructions (object target) 
            {
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction( ()=> this.CurrentAppearanceState = Appearance.ChatOpen);
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime;
                    toReturn.Target = target;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(Appearance.Appear4, 0.1f, FlatRedBall.Glue.StateInterpolation.InterpolationType.Linear, FlatRedBall.Glue.StateInterpolation.Easing.Out, DisappearAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(Appearance.Appear3, 0.2f, FlatRedBall.Glue.StateInterpolation.InterpolationType.Quadratic, FlatRedBall.Glue.StateInterpolation.Easing.In, DisappearAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0.1f;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(Appearance.Appear2, 0.09999999f, FlatRedBall.Glue.StateInterpolation.InterpolationType.Linear, FlatRedBall.Glue.StateInterpolation.Easing.In, DisappearAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0.3f;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(Appearance.Appear1, 0.2f, FlatRedBall.Glue.StateInterpolation.InterpolationType.Quadratic, FlatRedBall.Glue.StateInterpolation.Easing.In, DisappearAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0.4f;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(Appearance.ChatClosed, 0.00999999f, FlatRedBall.Glue.StateInterpolation.InterpolationType.Quadratic, FlatRedBall.Glue.StateInterpolation.Easing.In, DisappearAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0.6f;
                    yield return toReturn;
                }
            }
            private System.Collections.Generic.IEnumerable<FlatRedBall.Instructions.Instruction> DisappearAnimationRelativeInstructions (object target) 
            {
                {
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(() =>
                    {
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "Appearance/ChatOpen").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "Appearance/Appear4").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(Appearance.Appear4);
                        Gum.DataTypes.Variables.StateSave second = first.Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.AddIntoThis(second, difference);
                        FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: 0.1f, type: FlatRedBall.Glue.StateInterpolation.InterpolationType.Linear, easing: FlatRedBall.Glue.StateInterpolation.Easing.Out);
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
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "Appearance/Appear4").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "Appearance/Appear3").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(Appearance.Appear3);
                        Gum.DataTypes.Variables.StateSave second = first.Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.AddIntoThis(second, difference);
                        FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: 0.2f, type: FlatRedBall.Glue.StateInterpolation.InterpolationType.Quadratic, easing: FlatRedBall.Glue.StateInterpolation.Easing.In);
                        tweener.Owner = this;
                        tweener.PositionChanged = newPosition => this.InterpolateBetween(first, second, newPosition);
                        tweener.Start();
                        StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                    }
                    );
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0.1f;
                    toReturn.Target = target;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(() =>
                    {
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "Appearance/Appear3").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "Appearance/Appear2").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(Appearance.Appear2);
                        Gum.DataTypes.Variables.StateSave second = first.Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.AddIntoThis(second, difference);
                        FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: 0.09999999f, type: FlatRedBall.Glue.StateInterpolation.InterpolationType.Linear, easing: FlatRedBall.Glue.StateInterpolation.Easing.In);
                        tweener.Owner = this;
                        tweener.PositionChanged = newPosition => this.InterpolateBetween(first, second, newPosition);
                        tweener.Start();
                        StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                    }
                    );
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0.3f;
                    toReturn.Target = target;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(() =>
                    {
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "Appearance/Appear2").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "Appearance/Appear1").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(Appearance.Appear1);
                        Gum.DataTypes.Variables.StateSave second = first.Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.AddIntoThis(second, difference);
                        FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: 0.2f, type: FlatRedBall.Glue.StateInterpolation.InterpolationType.Quadratic, easing: FlatRedBall.Glue.StateInterpolation.Easing.In);
                        tweener.Owner = this;
                        tweener.PositionChanged = newPosition => this.InterpolateBetween(first, second, newPosition);
                        tweener.Start();
                        StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                    }
                    );
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0.4f;
                    toReturn.Target = target;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(() =>
                    {
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "Appearance/Appear1").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "Appearance/ChatClosed").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(Appearance.ChatClosed);
                        Gum.DataTypes.Variables.StateSave second = first.Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.AddIntoThis(second, difference);
                        FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: 0.00999999f, type: FlatRedBall.Glue.StateInterpolation.InterpolationType.Quadratic, easing: FlatRedBall.Glue.StateInterpolation.Easing.In);
                        tweener.Owner = this;
                        tweener.PositionChanged = newPosition => this.InterpolateBetween(first, second, newPosition);
                        tweener.Start();
                        StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                    }
                    );
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0.6f;
                    toReturn.Target = target;
                    yield return toReturn;
                }
            }
            private FlatRedBall.Gum.Animation.GumAnimation disappearAnimation;
            public FlatRedBall.Gum.Animation.GumAnimation DisappearAnimation
            {
                get
                {
                    if (disappearAnimation == null)
                    {
                        disappearAnimation = new FlatRedBall.Gum.Animation.GumAnimation(0.62f, DisappearAnimationInstructions);
                        disappearAnimation.AddEvent("ChatClosed", 0.62f);
                    }
                    return disappearAnimation;
                }
            }
            private FlatRedBall.Gum.Animation.GumAnimation disappearAnimationRelative;
            public FlatRedBall.Gum.Animation.GumAnimation DisappearAnimationRelative
            {
                get
                {
                    if (disappearAnimationRelative == null)
                    {
                        disappearAnimationRelative = new FlatRedBall.Gum.Animation.GumAnimation(0.62f, DisappearAnimationRelativeInstructions);
                        disappearAnimationRelative.AddEvent("ChatClosed", 0.62f);
                    }
                    return disappearAnimationRelative;
                }
            }
            #endregion
            public override void StopAnimations () 
            {
                base.StopAnimations();
                ChatFrameInstance.StopAnimations();
                StyleBarInstance.StopAnimations();
                ChatOption0.StopAnimations();
                ChatOption1.StopAnimations();
                ChatOption2.StopAnimations();
                CloseChatButtonInstance.StopAnimations();
                MessageBox.StopAnimations();
                ChatHistoryButton.StopAnimations();
                DialogueShownChatOption.StopAnimations();
                ResponseChosenChatOption.StopAnimations();
                AppearAnimation.Stop();
                DisappearAnimation.Stop();
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
                            Name = "ChatFrameInstance.Height",
                            Type = "float",
                            Value = ChatFrameInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatFrameInstance.Width",
                            Type = "float",
                            Value = ChatFrameInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatFrameInstance.X",
                            Type = "float",
                            Value = ChatFrameInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatFrameInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ChatFrameInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatFrameInstance.Y",
                            Type = "float",
                            Value = ChatFrameInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatFrameInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = ChatFrameInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Height",
                            Type = "float",
                            Value = StyleBarInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Visible",
                            Type = "bool",
                            Value = StyleBarInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Width",
                            Type = "float",
                            Value = StyleBarInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.X",
                            Type = "float",
                            Value = StyleBarInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = StyleBarInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.X Units",
                            Type = "PositionUnitType",
                            Value = StyleBarInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Y",
                            Type = "float",
                            Value = StyleBarInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = StyleBarInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = StyleBarInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Alpha",
                            Type = "int",
                            Value = ColoredRectangleInstance.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Blue",
                            Type = "int",
                            Value = ColoredRectangleInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Green",
                            Type = "int",
                            Value = ColoredRectangleInstance.Green
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
                            Name = "ColoredRectangleInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = ColoredRectangleInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Red",
                            Type = "int",
                            Value = ColoredRectangleInstance.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Width",
                            Type = "float",
                            Value = ColoredRectangleInstance.Width
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
                            Name = "ColoredRectangleInstance.X",
                            Type = "float",
                            Value = ColoredRectangleInstance.X
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
                            Name = "ColoredRectangleInstance.Y",
                            Type = "float",
                            Value = ColoredRectangleInstance.Y
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
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatOption0.Height",
                            Type = "float",
                            Value = ChatOption0.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatOption0.Height Units",
                            Type = "DimensionUnitType",
                            Value = ChatOption0.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatOption0.HighlightState",
                            Type = "HighlightState",
                            Value = ChatOption0.CurrentHighlightState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatOption0.Parent",
                            Type = "string",
                            Value = ChatOption0.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatOption0.Width",
                            Type = "float",
                            Value = ChatOption0.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatOption0.X",
                            Type = "float",
                            Value = ChatOption0.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatOption0.Y",
                            Type = "float",
                            Value = ChatOption0.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentText.Font",
                            Type = "string",
                            Value = CurrentText.Font
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentText.FontSize",
                            Type = "int",
                            Value = CurrentText.FontSize
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentText.Height",
                            Type = "float",
                            Value = CurrentText.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentText.Height Units",
                            Type = "DimensionUnitType",
                            Value = CurrentText.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentText.Parent",
                            Type = "string",
                            Value = CurrentText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentText.Width",
                            Type = "float",
                            Value = CurrentText.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentText.Width Units",
                            Type = "DimensionUnitType",
                            Value = CurrentText.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentText.X",
                            Type = "float",
                            Value = CurrentText.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentText.X Units",
                            Type = "PositionUnitType",
                            Value = CurrentText.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentText.Y",
                            Type = "float",
                            Value = CurrentText.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentText.Y Units",
                            Type = "PositionUnitType",
                            Value = CurrentText.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatOption1.Height",
                            Type = "float",
                            Value = ChatOption1.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatOption1.HighlightState",
                            Type = "HighlightState",
                            Value = ChatOption1.CurrentHighlightState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatOption1.Parent",
                            Type = "string",
                            Value = ChatOption1.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatOption1.Width",
                            Type = "float",
                            Value = ChatOption1.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatOption2.Height",
                            Type = "float",
                            Value = ChatOption2.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatOption2.HighlightState",
                            Type = "HighlightState",
                            Value = ChatOption2.CurrentHighlightState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatOption2.Parent",
                            Type = "string",
                            Value = ChatOption2.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatOption2.Width",
                            Type = "float",
                            Value = ChatOption2.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResponseContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = ResponseContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResponseContainer.Height",
                            Type = "float",
                            Value = ResponseContainer.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResponseContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = ResponseContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResponseContainer.Parent",
                            Type = "string",
                            Value = ResponseContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResponseContainer.Width",
                            Type = "float",
                            Value = ResponseContainer.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResponseContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = ResponseContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResponseContainer.Wraps Children",
                            Type = "bool",
                            Value = ResponseContainer.WrapsChildren
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResponseContainer.X",
                            Type = "float",
                            Value = ResponseContainer.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResponseContainer.X Units",
                            Type = "PositionUnitType",
                            Value = ResponseContainer.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResponseContainer.Y",
                            Type = "float",
                            Value = ResponseContainer.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResponseContainer.Y Units",
                            Type = "PositionUnitType",
                            Value = ResponseContainer.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = ChatContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatContainer.Height",
                            Type = "float",
                            Value = ChatContainer.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = ChatContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatContainer.Width",
                            Type = "float",
                            Value = ChatContainer.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = ChatContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatContainer.X",
                            Type = "float",
                            Value = ChatContainer.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatContainer.X Units",
                            Type = "PositionUnitType",
                            Value = ChatContainer.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatContainer.Y",
                            Type = "float",
                            Value = ChatContainer.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatContainer.Y Units",
                            Type = "PositionUnitType",
                            Value = ChatContainer.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseChatButtonInstance.Height",
                            Type = "float",
                            Value = CloseChatButtonInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseChatButtonInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = CloseChatButtonInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseChatButtonInstance.Width",
                            Type = "float",
                            Value = CloseChatButtonInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseChatButtonInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = CloseChatButtonInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseChatButtonInstance.X",
                            Type = "float",
                            Value = CloseChatButtonInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseChatButtonInstance.X Units",
                            Type = "PositionUnitType",
                            Value = CloseChatButtonInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseChatButtonInstance.Y",
                            Type = "float",
                            Value = CloseChatButtonInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseChatButtonInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = CloseChatButtonInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageBox.ColorStateState",
                            Type = "ColorStateState",
                            Value = MessageBox.CurrentColorStateState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageBox.Height",
                            Type = "float",
                            Value = MessageBox.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageBox.Height Units",
                            Type = "DimensionUnitType",
                            Value = MessageBox.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageBox.Visible",
                            Type = "bool",
                            Value = MessageBox.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageBox.Width",
                            Type = "float",
                            Value = MessageBox.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageBox.X",
                            Type = "float",
                            Value = MessageBox.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageBox.Y",
                            Type = "float",
                            Value = MessageBox.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageBox.Y Origin",
                            Type = "VerticalAlignment",
                            Value = MessageBox.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Font",
                            Type = "string",
                            Value = TextInstance.Font
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.FontSize",
                            Type = "int",
                            Value = TextInstance.FontSize
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
                            Name = "TextInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = TextInstance.HeightUnits
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
                            Name = "TextInstance.Parent",
                            Type = "string",
                            Value = TextInstance.Parent
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
                            Name = "TextInstance.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = TextInstance.VerticalAlignment
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
                            Name = "TextInstance.Width",
                            Type = "float",
                            Value = TextInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = TextInstance.WidthUnits
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
                            Name = "TextInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = TextInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = TextInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatHistoryButton.Height",
                            Type = "float",
                            Value = ChatHistoryButton.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatHistoryButton.UpDownState",
                            Type = "UpDownState",
                            Value = ChatHistoryButton.CurrentUpDownState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatHistoryButton.Width",
                            Type = "float",
                            Value = ChatHistoryButton.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatHistoryButton.X",
                            Type = "float",
                            Value = ChatHistoryButton.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatHistoryButton.X Units",
                            Type = "PositionUnitType",
                            Value = ChatHistoryButton.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatHistoryButton.Y",
                            Type = "float",
                            Value = ChatHistoryButton.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatHistoryButton.Y Units",
                            Type = "PositionUnitType",
                            Value = ChatHistoryButton.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RecentResponseContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = RecentResponseContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RecentResponseContainer.Height",
                            Type = "float",
                            Value = RecentResponseContainer.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RecentResponseContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = RecentResponseContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RecentResponseContainer.Visible",
                            Type = "bool",
                            Value = RecentResponseContainer.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RecentResponseContainer.Width",
                            Type = "float",
                            Value = RecentResponseContainer.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RecentResponseContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = RecentResponseContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RecentResponseContainer.X",
                            Type = "float",
                            Value = RecentResponseContainer.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RecentResponseContainer.X Units",
                            Type = "PositionUnitType",
                            Value = RecentResponseContainer.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RecentResponseContainer.Y",
                            Type = "float",
                            Value = RecentResponseContainer.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RecentResponseContainer.Y Units",
                            Type = "PositionUnitType",
                            Value = RecentResponseContainer.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DialogueShownChatOption.HighlightState",
                            Type = "HighlightState",
                            Value = DialogueShownChatOption.CurrentHighlightState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DialogueShownChatOption.Parent",
                            Type = "string",
                            Value = DialogueShownChatOption.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResponseChosenChatOption.Parent",
                            Type = "string",
                            Value = ResponseChosenChatOption.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResponseChosenChatOption.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ResponseChosenChatOption.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResponseChosenChatOption.X Units",
                            Type = "PositionUnitType",
                            Value = ResponseChosenChatOption.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResponseChosenChatOption.Y",
                            Type = "float",
                            Value = ResponseChosenChatOption.Y
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
                            Name = "ChatFrameInstance.Height",
                            Type = "float",
                            Value = ChatFrameInstance.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatFrameInstance.Width",
                            Type = "float",
                            Value = ChatFrameInstance.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatFrameInstance.X",
                            Type = "float",
                            Value = ChatFrameInstance.X + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatFrameInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ChatFrameInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatFrameInstance.Y",
                            Type = "float",
                            Value = ChatFrameInstance.Y + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatFrameInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = ChatFrameInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Height",
                            Type = "float",
                            Value = StyleBarInstance.Height + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Visible",
                            Type = "bool",
                            Value = StyleBarInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Width",
                            Type = "float",
                            Value = StyleBarInstance.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.X",
                            Type = "float",
                            Value = StyleBarInstance.X + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = StyleBarInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.X Units",
                            Type = "PositionUnitType",
                            Value = StyleBarInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Y",
                            Type = "float",
                            Value = StyleBarInstance.Y + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = StyleBarInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = StyleBarInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Alpha",
                            Type = "int",
                            Value = ColoredRectangleInstance.Alpha + 160
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Blue",
                            Type = "int",
                            Value = ColoredRectangleInstance.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Green",
                            Type = "int",
                            Value = ColoredRectangleInstance.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Height",
                            Type = "float",
                            Value = ColoredRectangleInstance.Height + 82.10236f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = ColoredRectangleInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Red",
                            Type = "int",
                            Value = ColoredRectangleInstance.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Width",
                            Type = "float",
                            Value = ColoredRectangleInstance.Width + 80.05469f
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
                            Name = "ColoredRectangleInstance.X",
                            Type = "float",
                            Value = ColoredRectangleInstance.X + 49.64584f
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
                            Name = "ColoredRectangleInstance.Y",
                            Type = "float",
                            Value = ColoredRectangleInstance.Y + 50.04165f
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
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatOption0.Height",
                            Type = "float",
                            Value = ChatOption0.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatOption0.Height Units",
                            Type = "DimensionUnitType",
                            Value = ChatOption0.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatOption0.HighlightState",
                            Type = "HighlightState",
                            Value = ChatOption0.CurrentHighlightState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatOption0.Parent",
                            Type = "string",
                            Value = ChatOption0.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatOption0.Width",
                            Type = "float",
                            Value = ChatOption0.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatOption0.X",
                            Type = "float",
                            Value = ChatOption0.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatOption0.Y",
                            Type = "float",
                            Value = ChatOption0.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentText.Font",
                            Type = "string",
                            Value = CurrentText.Font
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentText.FontSize",
                            Type = "int",
                            Value = CurrentText.FontSize + 30
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentText.Height",
                            Type = "float",
                            Value = CurrentText.Height + 18.29847f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentText.Height Units",
                            Type = "DimensionUnitType",
                            Value = CurrentText.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentText.Parent",
                            Type = "string",
                            Value = CurrentText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentText.Width",
                            Type = "float",
                            Value = CurrentText.Width + 92.96616f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentText.Width Units",
                            Type = "DimensionUnitType",
                            Value = CurrentText.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentText.X",
                            Type = "float",
                            Value = CurrentText.X + 0.820613f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentText.X Units",
                            Type = "PositionUnitType",
                            Value = CurrentText.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentText.Y",
                            Type = "float",
                            Value = CurrentText.Y + 2.029169f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentText.Y Units",
                            Type = "PositionUnitType",
                            Value = CurrentText.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatOption1.Height",
                            Type = "float",
                            Value = ChatOption1.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatOption1.HighlightState",
                            Type = "HighlightState",
                            Value = ChatOption1.CurrentHighlightState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatOption1.Parent",
                            Type = "string",
                            Value = ChatOption1.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatOption1.Width",
                            Type = "float",
                            Value = ChatOption1.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatOption2.Height",
                            Type = "float",
                            Value = ChatOption2.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatOption2.HighlightState",
                            Type = "HighlightState",
                            Value = ChatOption2.CurrentHighlightState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatOption2.Parent",
                            Type = "string",
                            Value = ChatOption2.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatOption2.Width",
                            Type = "float",
                            Value = ChatOption2.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResponseContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = ResponseContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResponseContainer.Height",
                            Type = "float",
                            Value = ResponseContainer.Height + 80f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResponseContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = ResponseContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResponseContainer.Parent",
                            Type = "string",
                            Value = ResponseContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResponseContainer.Width",
                            Type = "float",
                            Value = ResponseContainer.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResponseContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = ResponseContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResponseContainer.Wraps Children",
                            Type = "bool",
                            Value = ResponseContainer.WrapsChildren
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResponseContainer.X",
                            Type = "float",
                            Value = ResponseContainer.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResponseContainer.X Units",
                            Type = "PositionUnitType",
                            Value = ResponseContainer.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResponseContainer.Y",
                            Type = "float",
                            Value = ResponseContainer.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResponseContainer.Y Units",
                            Type = "PositionUnitType",
                            Value = ResponseContainer.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = ChatContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatContainer.Height",
                            Type = "float",
                            Value = ChatContainer.Height + 82.13544f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = ChatContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatContainer.Width",
                            Type = "float",
                            Value = ChatContainer.Width + 79.9707f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = ChatContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatContainer.X",
                            Type = "float",
                            Value = ChatContainer.X + 9.638672f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatContainer.X Units",
                            Type = "PositionUnitType",
                            Value = ChatContainer.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatContainer.Y",
                            Type = "float",
                            Value = ChatContainer.Y + 8.975698f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatContainer.Y Units",
                            Type = "PositionUnitType",
                            Value = ChatContainer.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseChatButtonInstance.Height",
                            Type = "float",
                            Value = CloseChatButtonInstance.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseChatButtonInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = CloseChatButtonInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseChatButtonInstance.Width",
                            Type = "float",
                            Value = CloseChatButtonInstance.Width + 5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseChatButtonInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = CloseChatButtonInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseChatButtonInstance.X",
                            Type = "float",
                            Value = CloseChatButtonInstance.X + 84.7412f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseChatButtonInstance.X Units",
                            Type = "PositionUnitType",
                            Value = CloseChatButtonInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseChatButtonInstance.Y",
                            Type = "float",
                            Value = CloseChatButtonInstance.Y + 6.777447f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseChatButtonInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = CloseChatButtonInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageBox.ColorStateState",
                            Type = "ColorStateState",
                            Value = MessageBox.CurrentColorStateState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageBox.Height",
                            Type = "float",
                            Value = MessageBox.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageBox.Height Units",
                            Type = "DimensionUnitType",
                            Value = MessageBox.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageBox.Visible",
                            Type = "bool",
                            Value = MessageBox.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageBox.Width",
                            Type = "float",
                            Value = MessageBox.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageBox.X",
                            Type = "float",
                            Value = MessageBox.X + 0.5952342f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageBox.Y",
                            Type = "float",
                            Value = MessageBox.Y + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageBox.Y Origin",
                            Type = "VerticalAlignment",
                            Value = MessageBox.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Font",
                            Type = "string",
                            Value = TextInstance.Font
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.FontSize",
                            Type = "int",
                            Value = TextInstance.FontSize + 30
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Height",
                            Type = "float",
                            Value = TextInstance.Height + -64f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = TextInstance.HeightUnits
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
                            Name = "TextInstance.Parent",
                            Type = "string",
                            Value = TextInstance.Parent
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
                            Name = "TextInstance.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = TextInstance.VerticalAlignment
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
                            Name = "TextInstance.Width",
                            Type = "float",
                            Value = TextInstance.Width + -64f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = TextInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.X",
                            Type = "float",
                            Value = TextInstance.X + 50f
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
                            Value = TextInstance.Y + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = TextInstance.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = TextInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatHistoryButton.Height",
                            Type = "float",
                            Value = ChatHistoryButton.Height + 56f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatHistoryButton.UpDownState",
                            Type = "UpDownState",
                            Value = ChatHistoryButton.CurrentUpDownState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatHistoryButton.Width",
                            Type = "float",
                            Value = ChatHistoryButton.Width + 66f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatHistoryButton.X",
                            Type = "float",
                            Value = ChatHistoryButton.X + 4.244792f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatHistoryButton.X Units",
                            Type = "PositionUnitType",
                            Value = ChatHistoryButton.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatHistoryButton.Y",
                            Type = "float",
                            Value = ChatHistoryButton.Y + 15.46297f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatHistoryButton.Y Units",
                            Type = "PositionUnitType",
                            Value = ChatHistoryButton.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RecentResponseContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = RecentResponseContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RecentResponseContainer.Height",
                            Type = "float",
                            Value = RecentResponseContainer.Height + 82f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RecentResponseContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = RecentResponseContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RecentResponseContainer.Visible",
                            Type = "bool",
                            Value = RecentResponseContainer.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RecentResponseContainer.Width",
                            Type = "float",
                            Value = RecentResponseContainer.Width + 80f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RecentResponseContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = RecentResponseContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RecentResponseContainer.X",
                            Type = "float",
                            Value = RecentResponseContainer.X + 9.5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RecentResponseContainer.X Units",
                            Type = "PositionUnitType",
                            Value = RecentResponseContainer.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RecentResponseContainer.Y",
                            Type = "float",
                            Value = RecentResponseContainer.Y + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RecentResponseContainer.Y Units",
                            Type = "PositionUnitType",
                            Value = RecentResponseContainer.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DialogueShownChatOption.HighlightState",
                            Type = "HighlightState",
                            Value = DialogueShownChatOption.CurrentHighlightState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DialogueShownChatOption.Parent",
                            Type = "string",
                            Value = DialogueShownChatOption.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResponseChosenChatOption.Parent",
                            Type = "string",
                            Value = ResponseChosenChatOption.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResponseChosenChatOption.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ResponseChosenChatOption.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResponseChosenChatOption.X Units",
                            Type = "PositionUnitType",
                            Value = ResponseChosenChatOption.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResponseChosenChatOption.Y",
                            Type = "float",
                            Value = ResponseChosenChatOption.Y + 5f
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (Appearance state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  Appearance.ChatOpen:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatFrameInstance.Height",
                            Type = "float",
                            Value = ChatFrameInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatFrameInstance.Visible",
                            Type = "bool",
                            Value = ChatFrameInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Height",
                            Type = "float",
                            Value = StyleBarInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Visible",
                            Type = "bool",
                            Value = StyleBarInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Width",
                            Type = "float",
                            Value = StyleBarInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.X",
                            Type = "float",
                            Value = StyleBarInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Y",
                            Type = "float",
                            Value = StyleBarInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Alpha",
                            Type = "int",
                            Value = ColoredRectangleInstance.Alpha
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
                            Name = "ColoredRectangleInstance.Visible",
                            Type = "bool",
                            Value = ColoredRectangleInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentText.Visible",
                            Type = "bool",
                            Value = CurrentText.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResponseContainer.Visible",
                            Type = "bool",
                            Value = ResponseContainer.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatContainer.Visible",
                            Type = "bool",
                            Value = ChatContainer.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseChatButtonInstance.Visible",
                            Type = "bool",
                            Value = CloseChatButtonInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageBox.Visible",
                            Type = "bool",
                            Value = MessageBox.Visible
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
                            Name = "ChatHistoryButton.Visible",
                            Type = "bool",
                            Value = ChatHistoryButton.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RecentResponseContainer.Visible",
                            Type = "bool",
                            Value = RecentResponseContainer.Visible
                        }
                        );
                        break;
                    case  Appearance.Appear1:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatFrameInstance.Height",
                            Type = "float",
                            Value = ChatFrameInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatFrameInstance.Visible",
                            Type = "bool",
                            Value = ChatFrameInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Height",
                            Type = "float",
                            Value = StyleBarInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Visible",
                            Type = "bool",
                            Value = StyleBarInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Width",
                            Type = "float",
                            Value = StyleBarInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.X",
                            Type = "float",
                            Value = StyleBarInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Y",
                            Type = "float",
                            Value = StyleBarInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Alpha",
                            Type = "int",
                            Value = ColoredRectangleInstance.Alpha
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
                            Name = "ColoredRectangleInstance.Visible",
                            Type = "bool",
                            Value = ColoredRectangleInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentText.Visible",
                            Type = "bool",
                            Value = CurrentText.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResponseContainer.Visible",
                            Type = "bool",
                            Value = ResponseContainer.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatContainer.Visible",
                            Type = "bool",
                            Value = ChatContainer.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseChatButtonInstance.Visible",
                            Type = "bool",
                            Value = CloseChatButtonInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageBox.Visible",
                            Type = "bool",
                            Value = MessageBox.Visible
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
                            Name = "ChatHistoryButton.Visible",
                            Type = "bool",
                            Value = ChatHistoryButton.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RecentResponseContainer.Visible",
                            Type = "bool",
                            Value = RecentResponseContainer.Visible
                        }
                        );
                        break;
                    case  Appearance.Appear2:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatFrameInstance.Height",
                            Type = "float",
                            Value = ChatFrameInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatFrameInstance.Visible",
                            Type = "bool",
                            Value = ChatFrameInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Height",
                            Type = "float",
                            Value = StyleBarInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Visible",
                            Type = "bool",
                            Value = StyleBarInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Width",
                            Type = "float",
                            Value = StyleBarInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.X",
                            Type = "float",
                            Value = StyleBarInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Y",
                            Type = "float",
                            Value = StyleBarInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Alpha",
                            Type = "int",
                            Value = ColoredRectangleInstance.Alpha
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
                            Name = "ColoredRectangleInstance.Visible",
                            Type = "bool",
                            Value = ColoredRectangleInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentText.Visible",
                            Type = "bool",
                            Value = CurrentText.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResponseContainer.Visible",
                            Type = "bool",
                            Value = ResponseContainer.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatContainer.Visible",
                            Type = "bool",
                            Value = ChatContainer.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseChatButtonInstance.Visible",
                            Type = "bool",
                            Value = CloseChatButtonInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageBox.Visible",
                            Type = "bool",
                            Value = MessageBox.Visible
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
                            Name = "ChatHistoryButton.Visible",
                            Type = "bool",
                            Value = ChatHistoryButton.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RecentResponseContainer.Visible",
                            Type = "bool",
                            Value = RecentResponseContainer.Visible
                        }
                        );
                        break;
                    case  Appearance.Appear3:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatFrameInstance.Height",
                            Type = "float",
                            Value = ChatFrameInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatFrameInstance.Visible",
                            Type = "bool",
                            Value = ChatFrameInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Height",
                            Type = "float",
                            Value = StyleBarInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Visible",
                            Type = "bool",
                            Value = StyleBarInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Width",
                            Type = "float",
                            Value = StyleBarInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.X",
                            Type = "float",
                            Value = StyleBarInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Y",
                            Type = "float",
                            Value = StyleBarInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Alpha",
                            Type = "int",
                            Value = ColoredRectangleInstance.Alpha
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
                            Name = "ColoredRectangleInstance.Visible",
                            Type = "bool",
                            Value = ColoredRectangleInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentText.Visible",
                            Type = "bool",
                            Value = CurrentText.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResponseContainer.Visible",
                            Type = "bool",
                            Value = ResponseContainer.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatContainer.Visible",
                            Type = "bool",
                            Value = ChatContainer.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseChatButtonInstance.Visible",
                            Type = "bool",
                            Value = CloseChatButtonInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageBox.Visible",
                            Type = "bool",
                            Value = MessageBox.Visible
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
                            Name = "ChatHistoryButton.Visible",
                            Type = "bool",
                            Value = ChatHistoryButton.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RecentResponseContainer.Visible",
                            Type = "bool",
                            Value = RecentResponseContainer.Visible
                        }
                        );
                        break;
                    case  Appearance.Appear4:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatFrameInstance.Height",
                            Type = "float",
                            Value = ChatFrameInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatFrameInstance.Visible",
                            Type = "bool",
                            Value = ChatFrameInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Height",
                            Type = "float",
                            Value = StyleBarInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Visible",
                            Type = "bool",
                            Value = StyleBarInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Width",
                            Type = "float",
                            Value = StyleBarInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.X",
                            Type = "float",
                            Value = StyleBarInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Y",
                            Type = "float",
                            Value = StyleBarInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Alpha",
                            Type = "int",
                            Value = ColoredRectangleInstance.Alpha
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
                            Name = "ColoredRectangleInstance.Visible",
                            Type = "bool",
                            Value = ColoredRectangleInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentText.Visible",
                            Type = "bool",
                            Value = CurrentText.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResponseContainer.Visible",
                            Type = "bool",
                            Value = ResponseContainer.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatContainer.Visible",
                            Type = "bool",
                            Value = ChatContainer.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseChatButtonInstance.Visible",
                            Type = "bool",
                            Value = CloseChatButtonInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageBox.Visible",
                            Type = "bool",
                            Value = MessageBox.Visible
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
                            Name = "ChatHistoryButton.Visible",
                            Type = "bool",
                            Value = ChatHistoryButton.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RecentResponseContainer.Visible",
                            Type = "bool",
                            Value = RecentResponseContainer.Visible
                        }
                        );
                        break;
                    case  Appearance.ChatClosed:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatFrameInstance.Height",
                            Type = "float",
                            Value = ChatFrameInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatFrameInstance.Visible",
                            Type = "bool",
                            Value = ChatFrameInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Height",
                            Type = "float",
                            Value = StyleBarInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Visible",
                            Type = "bool",
                            Value = StyleBarInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Width",
                            Type = "float",
                            Value = StyleBarInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.X",
                            Type = "float",
                            Value = StyleBarInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Y",
                            Type = "float",
                            Value = StyleBarInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Alpha",
                            Type = "int",
                            Value = ColoredRectangleInstance.Alpha
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
                            Name = "ColoredRectangleInstance.Visible",
                            Type = "bool",
                            Value = ColoredRectangleInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentText.Visible",
                            Type = "bool",
                            Value = CurrentText.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResponseContainer.Visible",
                            Type = "bool",
                            Value = ResponseContainer.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatContainer.Visible",
                            Type = "bool",
                            Value = ChatContainer.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseChatButtonInstance.Visible",
                            Type = "bool",
                            Value = CloseChatButtonInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageBox.Visible",
                            Type = "bool",
                            Value = MessageBox.Visible
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
                            Name = "ChatHistoryButton.Visible",
                            Type = "bool",
                            Value = ChatHistoryButton.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RecentResponseContainer.Visible",
                            Type = "bool",
                            Value = RecentResponseContainer.Visible
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (Appearance state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  Appearance.ChatOpen:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatFrameInstance.Height",
                            Type = "float",
                            Value = ChatFrameInstance.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatFrameInstance.Visible",
                            Type = "bool",
                            Value = ChatFrameInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Height",
                            Type = "float",
                            Value = StyleBarInstance.Height + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Visible",
                            Type = "bool",
                            Value = StyleBarInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Width",
                            Type = "float",
                            Value = StyleBarInstance.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.X",
                            Type = "float",
                            Value = StyleBarInstance.X + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Y",
                            Type = "float",
                            Value = StyleBarInstance.Y + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Alpha",
                            Type = "int",
                            Value = ColoredRectangleInstance.Alpha + 160
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Height",
                            Type = "float",
                            Value = ColoredRectangleInstance.Height + 82.10236f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Visible",
                            Type = "bool",
                            Value = ColoredRectangleInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentText.Visible",
                            Type = "bool",
                            Value = CurrentText.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResponseContainer.Visible",
                            Type = "bool",
                            Value = ResponseContainer.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatContainer.Visible",
                            Type = "bool",
                            Value = ChatContainer.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseChatButtonInstance.Visible",
                            Type = "bool",
                            Value = CloseChatButtonInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageBox.Visible",
                            Type = "bool",
                            Value = MessageBox.Visible
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
                            Name = "ChatHistoryButton.Visible",
                            Type = "bool",
                            Value = ChatHistoryButton.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RecentResponseContainer.Visible",
                            Type = "bool",
                            Value = RecentResponseContainer.Visible
                        }
                        );
                        break;
                    case  Appearance.Appear1:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatFrameInstance.Height",
                            Type = "float",
                            Value = ChatFrameInstance.Height + 5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatFrameInstance.Visible",
                            Type = "bool",
                            Value = ChatFrameInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Height",
                            Type = "float",
                            Value = StyleBarInstance.Height + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Visible",
                            Type = "bool",
                            Value = StyleBarInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Width",
                            Type = "float",
                            Value = StyleBarInstance.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.X",
                            Type = "float",
                            Value = StyleBarInstance.X + 6f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Y",
                            Type = "float",
                            Value = StyleBarInstance.Y + 90f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Alpha",
                            Type = "int",
                            Value = ColoredRectangleInstance.Alpha + 160
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Height",
                            Type = "float",
                            Value = ColoredRectangleInstance.Height + 4.1f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Visible",
                            Type = "bool",
                            Value = ColoredRectangleInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentText.Visible",
                            Type = "bool",
                            Value = CurrentText.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResponseContainer.Visible",
                            Type = "bool",
                            Value = ResponseContainer.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatContainer.Visible",
                            Type = "bool",
                            Value = ChatContainer.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseChatButtonInstance.Visible",
                            Type = "bool",
                            Value = CloseChatButtonInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageBox.Visible",
                            Type = "bool",
                            Value = MessageBox.Visible
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
                            Name = "ChatHistoryButton.Visible",
                            Type = "bool",
                            Value = ChatHistoryButton.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RecentResponseContainer.Visible",
                            Type = "bool",
                            Value = RecentResponseContainer.Visible
                        }
                        );
                        break;
                    case  Appearance.Appear2:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatFrameInstance.Height",
                            Type = "float",
                            Value = ChatFrameInstance.Height + 5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatFrameInstance.Visible",
                            Type = "bool",
                            Value = ChatFrameInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Height",
                            Type = "float",
                            Value = StyleBarInstance.Height + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Visible",
                            Type = "bool",
                            Value = StyleBarInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Width",
                            Type = "float",
                            Value = StyleBarInstance.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.X",
                            Type = "float",
                            Value = StyleBarInstance.X + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Y",
                            Type = "float",
                            Value = StyleBarInstance.Y + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Alpha",
                            Type = "int",
                            Value = ColoredRectangleInstance.Alpha + 160
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Height",
                            Type = "float",
                            Value = ColoredRectangleInstance.Height + 4.1f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Visible",
                            Type = "bool",
                            Value = ColoredRectangleInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentText.Visible",
                            Type = "bool",
                            Value = CurrentText.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResponseContainer.Visible",
                            Type = "bool",
                            Value = ResponseContainer.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatContainer.Visible",
                            Type = "bool",
                            Value = ChatContainer.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseChatButtonInstance.Visible",
                            Type = "bool",
                            Value = CloseChatButtonInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageBox.Visible",
                            Type = "bool",
                            Value = MessageBox.Visible
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
                            Name = "ChatHistoryButton.Visible",
                            Type = "bool",
                            Value = ChatHistoryButton.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RecentResponseContainer.Visible",
                            Type = "bool",
                            Value = RecentResponseContainer.Visible
                        }
                        );
                        break;
                    case  Appearance.Appear3:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatFrameInstance.Height",
                            Type = "float",
                            Value = ChatFrameInstance.Height + 5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatFrameInstance.Visible",
                            Type = "bool",
                            Value = ChatFrameInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Height",
                            Type = "float",
                            Value = StyleBarInstance.Height + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Visible",
                            Type = "bool",
                            Value = StyleBarInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Width",
                            Type = "float",
                            Value = StyleBarInstance.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.X",
                            Type = "float",
                            Value = StyleBarInstance.X + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Y",
                            Type = "float",
                            Value = StyleBarInstance.Y + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Alpha",
                            Type = "int",
                            Value = ColoredRectangleInstance.Alpha + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Height",
                            Type = "float",
                            Value = ColoredRectangleInstance.Height + 4.1f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Visible",
                            Type = "bool",
                            Value = ColoredRectangleInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentText.Visible",
                            Type = "bool",
                            Value = CurrentText.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResponseContainer.Visible",
                            Type = "bool",
                            Value = ResponseContainer.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatContainer.Visible",
                            Type = "bool",
                            Value = ChatContainer.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseChatButtonInstance.Visible",
                            Type = "bool",
                            Value = CloseChatButtonInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageBox.Visible",
                            Type = "bool",
                            Value = MessageBox.Visible
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
                            Name = "ChatHistoryButton.Visible",
                            Type = "bool",
                            Value = ChatHistoryButton.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RecentResponseContainer.Visible",
                            Type = "bool",
                            Value = RecentResponseContainer.Visible
                        }
                        );
                        break;
                    case  Appearance.Appear4:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatFrameInstance.Height",
                            Type = "float",
                            Value = ChatFrameInstance.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatFrameInstance.Visible",
                            Type = "bool",
                            Value = ChatFrameInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Height",
                            Type = "float",
                            Value = StyleBarInstance.Height + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Visible",
                            Type = "bool",
                            Value = StyleBarInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Width",
                            Type = "float",
                            Value = StyleBarInstance.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.X",
                            Type = "float",
                            Value = StyleBarInstance.X + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Y",
                            Type = "float",
                            Value = StyleBarInstance.Y + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Alpha",
                            Type = "int",
                            Value = ColoredRectangleInstance.Alpha + 80
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Height",
                            Type = "float",
                            Value = ColoredRectangleInstance.Height + 82.10236f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Visible",
                            Type = "bool",
                            Value = ColoredRectangleInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentText.Visible",
                            Type = "bool",
                            Value = CurrentText.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResponseContainer.Visible",
                            Type = "bool",
                            Value = ResponseContainer.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatContainer.Visible",
                            Type = "bool",
                            Value = ChatContainer.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseChatButtonInstance.Visible",
                            Type = "bool",
                            Value = CloseChatButtonInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageBox.Visible",
                            Type = "bool",
                            Value = MessageBox.Visible
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
                            Name = "ChatHistoryButton.Visible",
                            Type = "bool",
                            Value = ChatHistoryButton.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RecentResponseContainer.Visible",
                            Type = "bool",
                            Value = RecentResponseContainer.Visible
                        }
                        );
                        break;
                    case  Appearance.ChatClosed:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatFrameInstance.Height",
                            Type = "float",
                            Value = ChatFrameInstance.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatFrameInstance.Visible",
                            Type = "bool",
                            Value = ChatFrameInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Height",
                            Type = "float",
                            Value = StyleBarInstance.Height + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Visible",
                            Type = "bool",
                            Value = StyleBarInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Width",
                            Type = "float",
                            Value = StyleBarInstance.Width + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.X",
                            Type = "float",
                            Value = StyleBarInstance.X + 6f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StyleBarInstance.Y",
                            Type = "float",
                            Value = StyleBarInstance.Y + 90f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Alpha",
                            Type = "int",
                            Value = ColoredRectangleInstance.Alpha + 160
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Height",
                            Type = "float",
                            Value = ColoredRectangleInstance.Height + 4.1f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ColoredRectangleInstance.Visible",
                            Type = "bool",
                            Value = ColoredRectangleInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentText.Visible",
                            Type = "bool",
                            Value = CurrentText.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResponseContainer.Visible",
                            Type = "bool",
                            Value = ResponseContainer.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatContainer.Visible",
                            Type = "bool",
                            Value = ChatContainer.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseChatButtonInstance.Visible",
                            Type = "bool",
                            Value = CloseChatButtonInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageBox.Visible",
                            Type = "bool",
                            Value = MessageBox.Visible
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
                            Name = "ChatHistoryButton.Visible",
                            Type = "bool",
                            Value = ChatHistoryButton.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RecentResponseContainer.Visible",
                            Type = "bool",
                            Value = RecentResponseContainer.Visible
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (MessageIndicator state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  MessageIndicator.NewMessage:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageBox.ColorStateState",
                            Type = "ColorStateState",
                            Value = MessageBox.CurrentColorStateState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Blue",
                            Type = "int",
                            Value = TextInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Green",
                            Type = "int",
                            Value = TextInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Red",
                            Type = "int",
                            Value = TextInstance.Red
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
                        break;
                    case  MessageIndicator.NoMessage:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageBox.ColorStateState",
                            Type = "ColorStateState",
                            Value = MessageBox.CurrentColorStateState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Blue",
                            Type = "int",
                            Value = TextInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Green",
                            Type = "int",
                            Value = TextInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Red",
                            Type = "int",
                            Value = TextInstance.Red
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
                        break;
                    case  MessageIndicator.NoMessageHighlighted:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageBox.ColorStateState",
                            Type = "ColorStateState",
                            Value = MessageBox.CurrentColorStateState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Blue",
                            Type = "int",
                            Value = TextInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Green",
                            Type = "int",
                            Value = TextInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Red",
                            Type = "int",
                            Value = TextInstance.Red
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
                        break;
                    case  MessageIndicator.NewMessageHighlighted:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageBox.ColorStateState",
                            Type = "ColorStateState",
                            Value = MessageBox.CurrentColorStateState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Blue",
                            Type = "int",
                            Value = TextInstance.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Green",
                            Type = "int",
                            Value = TextInstance.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Red",
                            Type = "int",
                            Value = TextInstance.Red
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
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (MessageIndicator state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  MessageIndicator.NewMessage:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageBox.ColorStateState",
                            Type = "ColorStateState",
                            Value = MessageBox.CurrentColorStateState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Blue",
                            Type = "int",
                            Value = TextInstance.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Green",
                            Type = "int",
                            Value = TextInstance.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Red",
                            Type = "int",
                            Value = TextInstance.Red + 0
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
                        break;
                    case  MessageIndicator.NoMessage:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageBox.ColorStateState",
                            Type = "ColorStateState",
                            Value = MessageBox.CurrentColorStateState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Blue",
                            Type = "int",
                            Value = TextInstance.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Green",
                            Type = "int",
                            Value = TextInstance.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Red",
                            Type = "int",
                            Value = TextInstance.Red + 255
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
                        break;
                    case  MessageIndicator.NoMessageHighlighted:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageBox.ColorStateState",
                            Type = "ColorStateState",
                            Value = MessageBox.CurrentColorStateState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Blue",
                            Type = "int",
                            Value = TextInstance.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Green",
                            Type = "int",
                            Value = TextInstance.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Red",
                            Type = "int",
                            Value = TextInstance.Red + 255
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
                        break;
                    case  MessageIndicator.NewMessageHighlighted:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MessageBox.ColorStateState",
                            Type = "ColorStateState",
                            Value = MessageBox.CurrentColorStateState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Blue",
                            Type = "int",
                            Value = TextInstance.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Green",
                            Type = "int",
                            Value = TextInstance.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Red",
                            Type = "int",
                            Value = TextInstance.Red + 255
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
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (ResponseAvailability state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  ResponseAvailability.AwaitingResponse:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatContainer.Visible",
                            Type = "bool",
                            Value = ChatContainer.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RecentResponseContainer.Visible",
                            Type = "bool",
                            Value = RecentResponseContainer.Visible
                        }
                        );
                        break;
                    case  ResponseAvailability.AlreadyResponded:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatContainer.Visible",
                            Type = "bool",
                            Value = ChatContainer.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RecentResponseContainer.Visible",
                            Type = "bool",
                            Value = RecentResponseContainer.Visible
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (ResponseAvailability state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  ResponseAvailability.AwaitingResponse:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatContainer.Visible",
                            Type = "bool",
                            Value = ChatContainer.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RecentResponseContainer.Visible",
                            Type = "bool",
                            Value = RecentResponseContainer.Visible
                        }
                        );
                        break;
                    case  ResponseAvailability.AlreadyResponded:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatContainer.Visible",
                            Type = "bool",
                            Value = ChatContainer.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RecentResponseContainer.Visible",
                            Type = "bool",
                            Value = RecentResponseContainer.Visible
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
                    else if (category.Name == "Appearance")
                    {
                        if(state.Name == "ChatOpen") this.mCurrentAppearanceState = Appearance.ChatOpen;
                        if(state.Name == "Appear1") this.mCurrentAppearanceState = Appearance.Appear1;
                        if(state.Name == "Appear2") this.mCurrentAppearanceState = Appearance.Appear2;
                        if(state.Name == "Appear3") this.mCurrentAppearanceState = Appearance.Appear3;
                        if(state.Name == "Appear4") this.mCurrentAppearanceState = Appearance.Appear4;
                        if(state.Name == "ChatClosed") this.mCurrentAppearanceState = Appearance.ChatClosed;
                    }
                    else if (category.Name == "MessageIndicator")
                    {
                        if(state.Name == "NewMessage") this.mCurrentMessageIndicatorState = MessageIndicator.NewMessage;
                        if(state.Name == "NoMessage") this.mCurrentMessageIndicatorState = MessageIndicator.NoMessage;
                        if(state.Name == "NoMessageHighlighted") this.mCurrentMessageIndicatorState = MessageIndicator.NoMessageHighlighted;
                        if(state.Name == "NewMessageHighlighted") this.mCurrentMessageIndicatorState = MessageIndicator.NewMessageHighlighted;
                    }
                    else if (category.Name == "ResponseAvailability")
                    {
                        if(state.Name == "AwaitingResponse") this.mCurrentResponseAvailabilityState = ResponseAvailability.AwaitingResponse;
                        if(state.Name == "AlreadyResponded") this.mCurrentResponseAvailabilityState = ResponseAvailability.AlreadyResponded;
                    }
                }
                base.ApplyState(state);
            }
            private AbbatoirIntergrade.GumRuntimes.ChatFrameRuntime ChatFrameInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.StyleBarRuntime StyleBarInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ColoredRectangleRuntime ColoredRectangleInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ChatOptionRuntime ChatOption0 { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime CurrentText { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ChatOptionRuntime ChatOption1 { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ChatOptionRuntime ChatOption2 { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime ResponseContainer { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime ChatContainer { get; set; }
            private AbbatoirIntergrade.GumRuntimes.CloseChatButtonRuntime CloseChatButtonInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.GlowingBoxRuntime MessageBox { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime TextInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.UpDownButtonRuntime ChatHistoryButton { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime RecentResponseContainer { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ChatOptionRuntime DialogueShownChatOption { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ChatOptionRuntime ResponseChosenChatOption { get; set; }
            public bool ChatContainerVisible
            {
                get
                {
                    return ChatContainer.Visible;
                }
                set
                {
                    if (ChatContainer.Visible != value)
                    {
                        ChatContainer.Visible = value;
                        ChatContainerVisibleChanged?.Invoke(this, null);
                    }
                }
            }
            public bool RecentResponseContainerVisible
            {
                get
                {
                    return RecentResponseContainer.Visible;
                }
                set
                {
                    if (RecentResponseContainer.Visible != value)
                    {
                        RecentResponseContainer.Visible = value;
                        RecentResponseContainerVisibleChanged?.Invoke(this, null);
                    }
                }
            }
            public event System.EventHandler ChatContainerVisibleChanged;
            public event System.EventHandler RecentResponseContainerVisibleChanged;
            public ChatBoxRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                this.HasEvents = false;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "ChatBox");
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
                ChatFrameInstance = this.GetGraphicalUiElementByName("ChatFrameInstance") as AbbatoirIntergrade.GumRuntimes.ChatFrameRuntime;
                StyleBarInstance = this.GetGraphicalUiElementByName("StyleBarInstance") as AbbatoirIntergrade.GumRuntimes.StyleBarRuntime;
                ColoredRectangleInstance = this.GetGraphicalUiElementByName("ColoredRectangleInstance") as AbbatoirIntergrade.GumRuntimes.ColoredRectangleRuntime;
                ChatOption0 = this.GetGraphicalUiElementByName("ChatOption0") as AbbatoirIntergrade.GumRuntimes.ChatOptionRuntime;
                CurrentText = this.GetGraphicalUiElementByName("CurrentText") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
                ChatOption1 = this.GetGraphicalUiElementByName("ChatOption1") as AbbatoirIntergrade.GumRuntimes.ChatOptionRuntime;
                ChatOption2 = this.GetGraphicalUiElementByName("ChatOption2") as AbbatoirIntergrade.GumRuntimes.ChatOptionRuntime;
                ResponseContainer = this.GetGraphicalUiElementByName("ResponseContainer") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
                ChatContainer = this.GetGraphicalUiElementByName("ChatContainer") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
                CloseChatButtonInstance = this.GetGraphicalUiElementByName("CloseChatButtonInstance") as AbbatoirIntergrade.GumRuntimes.CloseChatButtonRuntime;
                MessageBox = this.GetGraphicalUiElementByName("MessageBox") as AbbatoirIntergrade.GumRuntimes.GlowingBoxRuntime;
                TextInstance = this.GetGraphicalUiElementByName("TextInstance") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
                ChatHistoryButton = this.GetGraphicalUiElementByName("ChatHistoryButton") as AbbatoirIntergrade.GumRuntimes.UpDownButtonRuntime;
                RecentResponseContainer = this.GetGraphicalUiElementByName("RecentResponseContainer") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
                DialogueShownChatOption = this.GetGraphicalUiElementByName("DialogueShownChatOption") as AbbatoirIntergrade.GumRuntimes.ChatOptionRuntime;
                ResponseChosenChatOption = this.GetGraphicalUiElementByName("ResponseChosenChatOption") as AbbatoirIntergrade.GumRuntimes.ChatOptionRuntime;
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
