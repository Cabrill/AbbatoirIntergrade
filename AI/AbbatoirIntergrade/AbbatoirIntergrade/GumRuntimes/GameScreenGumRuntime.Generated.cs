    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes
    {
        public partial class GameScreenGumRuntime : Gum.Wireframe.GraphicalUiElement
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            public enum ChatHistoryShowing
            {
                ChatHistoryHidden,
                ChatHistoryShow1,
                ChatHistoryShow2,
                ChatHistoryShow3,
                ChatHistoryShow4,
                ChatHistoryShown
            }
            public enum Fading
            {
                Faded,
                NotFaded
            }
            public enum HordeDisplay
            {
                HordeStart,
                HordeMiddle,
                HordeMiddleBig,
                HordeEnd
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            ChatHistoryShowing mCurrentChatHistoryShowingState;
            Fading mCurrentFadingState;
            HordeDisplay mCurrentHordeDisplayState;
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
                            HorizonBoxInstance.Visible = true;
                            EnemyInfoInstance.Visible = false;
                            StructureInfoInstance.Visible = false;
                            ChatBoxInstance.CurrentAppearanceState = AbbatoirIntergrade.GumRuntimes.ChatBoxRuntime.Appearance.ChatClosed;
                            ChatBoxInstance.Visible = false;
                            ChatBoxInstance.X = 0f;
                            ChatBoxInstance.Y = 50f;
                            BuildMenuInstance.Visible = false;
                            LivesPointsDisplayInstance.X = 100f;
                            LivesPointsDisplayInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            LivesPointsDisplayInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            ChatHistoryInstance.Visible = false;
                            ChatHistoryInstance.X = 10f;
                            ChatHistoryInstance.Y = 0f;
                            ScreenShadeInstance.Visible = false;
                            MenuWindowInstance.ButtonType1State = AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime.ButtonType.X;
                            MenuWindowInstance.Visible = false;
                            DimmingRectangle.Alpha = 0;
                            DimmingRectangle.Blue = 0;
                            DimmingRectangle.Green = 0;
                            DimmingRectangle.Height = 100f;
                            DimmingRectangle.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            DimmingRectangle.Red = 0;
                            DimmingRectangle.Width = 100f;
                            DimmingRectangle.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            LocationTimeAnnouncementInstance.CurrentDisplayingState = AbbatoirIntergrade.GumRuntimes.LocationTimeAnnouncementRuntime.Displaying.Start;
                            ConfirmationWindowInstance.Visible = false;
                            CurrentMusicDisplayInstance.CurrentAppearingState = AbbatoirIntergrade.GumRuntimes.CurrentMusicDisplayRuntime.Appearing.Hidden;
                            CurrentMusicDisplayInstance.X = -10f;
                            CurrentMusicDisplayInstance.Y = 230f;
                            HordeText.Blue = 50;
                            HordeText.Font = "Informal Roman";
                            HordeText.FontSize = 96;
                            HordeText.Green = 50;
                            HordeText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            HordeText.OutlineThickness = 1;
                            HordeText.Text = "UNSTOPPABLE HORDE!";
                            HordeText.Visible = false;
                            HordeText.Width = 0f;
                            HordeText.X = -1800f;
                            HordeText.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            HordeText.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            HordeText.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            HordeText.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            ReadyButtonInstance.X = 1650f;
                            ReadyButtonInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            ReadyButtonInstance.Y = 125f;
                            ReadyButtonInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            break;
                    }
                }
            }
            public ChatHistoryShowing CurrentChatHistoryShowingState
            {
                get
                {
                    return mCurrentChatHistoryShowingState;
                }
                set
                {
                    mCurrentChatHistoryShowingState = value;
                    switch(mCurrentChatHistoryShowingState)
                    {
                        case  ChatHistoryShowing.ChatHistoryHidden:
                            ChatBoxInstance.CurrentAppearanceState = AbbatoirIntergrade.GumRuntimes.ChatBoxRuntime.Appearance.ChatOpen;
                            ChatBoxInstance.RecentResponseContainerVisible = false;
                            ChatBoxInstance.Visible = true;
                            ChatBoxInstance.Width = 50f;
                            ChatBoxInstance.X = 0f;
                            ChatBoxInstance.Y = 50f;
                            ChatHistoryInstance.Visible = false;
                            break;
                        case  ChatHistoryShowing.ChatHistoryShow1:
                            ChatBoxInstance.CurrentAppearanceState = AbbatoirIntergrade.GumRuntimes.ChatBoxRuntime.Appearance.Appear4;
                            ChatBoxInstance.RecentResponseContainerVisible = false;
                            ChatBoxInstance.Visible = true;
                            ChatBoxInstance.Width = 50f;
                            ChatBoxInstance.X = 0f;
                            ChatBoxInstance.Y = 50f;
                            ChatHistoryInstance.Visible = false;
                            break;
                        case  ChatHistoryShowing.ChatHistoryShow2:
                            ChatBoxInstance.CurrentAppearanceState = AbbatoirIntergrade.GumRuntimes.ChatBoxRuntime.Appearance.Appear3;
                            ChatBoxInstance.ChatContainerVisible = false;
                            ChatBoxInstance.RecentResponseContainerVisible = false;
                            ChatBoxInstance.Visible = true;
                            ChatBoxInstance.Width = 50f;
                            ChatBoxInstance.X = 0f;
                            ChatBoxInstance.Y = 50f;
                            ChatHistoryInstance.Visible = false;
                            break;
                        case  ChatHistoryShowing.ChatHistoryShow3:
                            ChatBoxInstance.CurrentAppearanceState = AbbatoirIntergrade.GumRuntimes.ChatBoxRuntime.Appearance.Appear2;
                            ChatBoxInstance.RecentResponseContainerVisible = false;
                            ChatBoxInstance.Visible = true;
                            ChatBoxInstance.Width = 50f;
                            ChatBoxInstance.X = 0f;
                            ChatBoxInstance.Y = 50f;
                            ChatHistoryInstance.Visible = false;
                            break;
                        case  ChatHistoryShowing.ChatHistoryShow4:
                            ChatBoxInstance.CurrentAppearanceState = AbbatoirIntergrade.GumRuntimes.ChatBoxRuntime.Appearance.Appear2;
                            ChatBoxInstance.RecentResponseContainerVisible = false;
                            ChatBoxInstance.Visible = true;
                            ChatBoxInstance.Width = 33.20313f;
                            ChatBoxInstance.X = 10f;
                            ChatBoxInstance.Y = 28f;
                            ChatHistoryInstance.Visible = false;
                            break;
                        case  ChatHistoryShowing.ChatHistoryShown:
                            ChatBoxInstance.CurrentAppearanceState = AbbatoirIntergrade.GumRuntimes.ChatBoxRuntime.Appearance.ChatOpen;
                            ChatBoxInstance.RecentResponseContainerVisible = false;
                            ChatBoxInstance.Visible = false;
                            ChatBoxInstance.Width = 33.20313f;
                            ChatBoxInstance.X = 10f;
                            ChatBoxInstance.Y = 28f;
                            ChatHistoryInstance.Visible = true;
                            break;
                    }
                }
            }
            public Fading CurrentFadingState
            {
                get
                {
                    return mCurrentFadingState;
                }
                set
                {
                    mCurrentFadingState = value;
                    switch(mCurrentFadingState)
                    {
                        case  Fading.Faded:
                            DimmingRectangle.Alpha = 255;
                            break;
                        case  Fading.NotFaded:
                            DimmingRectangle.Alpha = 0;
                            break;
                    }
                }
            }
            public HordeDisplay CurrentHordeDisplayState
            {
                get
                {
                    return mCurrentHordeDisplayState;
                }
                set
                {
                    mCurrentHordeDisplayState = value;
                    switch(mCurrentHordeDisplayState)
                    {
                        case  HordeDisplay.HordeStart:
                            HordeText.Alpha = 0;
                            HordeText.FontScale = 1f;
                            HordeText.Visible = true;
                            HordeText.X = 0f;
                            break;
                        case  HordeDisplay.HordeMiddle:
                            HordeText.Alpha = 255;
                            HordeText.FontScale = 1f;
                            HordeText.Visible = true;
                            HordeText.X = 0f;
                            break;
                        case  HordeDisplay.HordeMiddleBig:
                            HordeText.Alpha = 255;
                            HordeText.FontScale = 1.5f;
                            HordeText.Visible = true;
                            HordeText.X = 0f;
                            break;
                        case  HordeDisplay.HordeEnd:
                            HordeText.Alpha = 0;
                            HordeText.FontScale = 0.5f;
                            HordeText.Visible = true;
                            HordeText.X = 0f;
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
                bool setChatBoxInstanceCurrentAppearanceStateFirstValue = false;
                bool setChatBoxInstanceCurrentAppearanceStateSecondValue = false;
                ChatBoxRuntime.Appearance ChatBoxInstanceCurrentAppearanceStateFirstValue= ChatBoxRuntime.Appearance.ChatOpen;
                ChatBoxRuntime.Appearance ChatBoxInstanceCurrentAppearanceStateSecondValue= ChatBoxRuntime.Appearance.ChatOpen;
                bool setChatBoxInstanceXFirstValue = false;
                bool setChatBoxInstanceXSecondValue = false;
                float ChatBoxInstanceXFirstValue= 0;
                float ChatBoxInstanceXSecondValue= 0;
                bool setChatBoxInstanceYFirstValue = false;
                bool setChatBoxInstanceYSecondValue = false;
                float ChatBoxInstanceYFirstValue= 0;
                float ChatBoxInstanceYSecondValue= 0;
                bool setChatHistoryInstanceXFirstValue = false;
                bool setChatHistoryInstanceXSecondValue = false;
                float ChatHistoryInstanceXFirstValue= 0;
                float ChatHistoryInstanceXSecondValue= 0;
                bool setChatHistoryInstanceYFirstValue = false;
                bool setChatHistoryInstanceYSecondValue = false;
                float ChatHistoryInstanceYFirstValue= 0;
                float ChatHistoryInstanceYSecondValue= 0;
                bool setCurrentMusicDisplayInstanceCurrentAppearingStateFirstValue = false;
                bool setCurrentMusicDisplayInstanceCurrentAppearingStateSecondValue = false;
                CurrentMusicDisplayRuntime.Appearing CurrentMusicDisplayInstanceCurrentAppearingStateFirstValue= CurrentMusicDisplayRuntime.Appearing.Hidden;
                CurrentMusicDisplayRuntime.Appearing CurrentMusicDisplayInstanceCurrentAppearingStateSecondValue= CurrentMusicDisplayRuntime.Appearing.Hidden;
                bool setCurrentMusicDisplayInstanceXFirstValue = false;
                bool setCurrentMusicDisplayInstanceXSecondValue = false;
                float CurrentMusicDisplayInstanceXFirstValue= 0;
                float CurrentMusicDisplayInstanceXSecondValue= 0;
                bool setCurrentMusicDisplayInstanceYFirstValue = false;
                bool setCurrentMusicDisplayInstanceYSecondValue = false;
                float CurrentMusicDisplayInstanceYFirstValue= 0;
                float CurrentMusicDisplayInstanceYSecondValue= 0;
                bool setDimmingRectangleAlphaFirstValue = false;
                bool setDimmingRectangleAlphaSecondValue = false;
                int DimmingRectangleAlphaFirstValue= 0;
                int DimmingRectangleAlphaSecondValue= 0;
                bool setDimmingRectangleBlueFirstValue = false;
                bool setDimmingRectangleBlueSecondValue = false;
                int DimmingRectangleBlueFirstValue= 0;
                int DimmingRectangleBlueSecondValue= 0;
                bool setDimmingRectangleGreenFirstValue = false;
                bool setDimmingRectangleGreenSecondValue = false;
                int DimmingRectangleGreenFirstValue= 0;
                int DimmingRectangleGreenSecondValue= 0;
                bool setDimmingRectangleHeightFirstValue = false;
                bool setDimmingRectangleHeightSecondValue = false;
                float DimmingRectangleHeightFirstValue= 0;
                float DimmingRectangleHeightSecondValue= 0;
                bool setDimmingRectangleRedFirstValue = false;
                bool setDimmingRectangleRedSecondValue = false;
                int DimmingRectangleRedFirstValue= 0;
                int DimmingRectangleRedSecondValue= 0;
                bool setDimmingRectangleWidthFirstValue = false;
                bool setDimmingRectangleWidthSecondValue = false;
                float DimmingRectangleWidthFirstValue= 0;
                float DimmingRectangleWidthSecondValue= 0;
                bool setHordeTextBlueFirstValue = false;
                bool setHordeTextBlueSecondValue = false;
                int HordeTextBlueFirstValue= 0;
                int HordeTextBlueSecondValue= 0;
                bool setHordeTextFontSizeFirstValue = false;
                bool setHordeTextFontSizeSecondValue = false;
                int HordeTextFontSizeFirstValue= 0;
                int HordeTextFontSizeSecondValue= 0;
                bool setHordeTextGreenFirstValue = false;
                bool setHordeTextGreenSecondValue = false;
                int HordeTextGreenFirstValue= 0;
                int HordeTextGreenSecondValue= 0;
                bool setHordeTextOutlineThicknessFirstValue = false;
                bool setHordeTextOutlineThicknessSecondValue = false;
                int HordeTextOutlineThicknessFirstValue= 0;
                int HordeTextOutlineThicknessSecondValue= 0;
                bool setHordeTextWidthFirstValue = false;
                bool setHordeTextWidthSecondValue = false;
                float HordeTextWidthFirstValue= 0;
                float HordeTextWidthSecondValue= 0;
                bool setHordeTextXFirstValue = false;
                bool setHordeTextXSecondValue = false;
                float HordeTextXFirstValue= 0;
                float HordeTextXSecondValue= 0;
                bool setLivesPointsDisplayInstanceXFirstValue = false;
                bool setLivesPointsDisplayInstanceXSecondValue = false;
                float LivesPointsDisplayInstanceXFirstValue= 0;
                float LivesPointsDisplayInstanceXSecondValue= 0;
                bool setLocationTimeAnnouncementInstanceCurrentDisplayingStateFirstValue = false;
                bool setLocationTimeAnnouncementInstanceCurrentDisplayingStateSecondValue = false;
                LocationTimeAnnouncementRuntime.Displaying LocationTimeAnnouncementInstanceCurrentDisplayingStateFirstValue= LocationTimeAnnouncementRuntime.Displaying.Start;
                LocationTimeAnnouncementRuntime.Displaying LocationTimeAnnouncementInstanceCurrentDisplayingStateSecondValue= LocationTimeAnnouncementRuntime.Displaying.Start;
                bool setReadyButtonInstanceXFirstValue = false;
                bool setReadyButtonInstanceXSecondValue = false;
                float ReadyButtonInstanceXFirstValue= 0;
                float ReadyButtonInstanceXSecondValue= 0;
                bool setReadyButtonInstanceYFirstValue = false;
                bool setReadyButtonInstanceYSecondValue = false;
                float ReadyButtonInstanceYFirstValue= 0;
                float ReadyButtonInstanceYSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        if (interpolationValue < 1)
                        {
                            this.BuildMenuInstance.Visible = false;
                        }
                        setChatBoxInstanceCurrentAppearanceStateFirstValue = true;
                        ChatBoxInstanceCurrentAppearanceStateFirstValue = AbbatoirIntergrade.GumRuntimes.ChatBoxRuntime.Appearance.ChatClosed;
                        if (interpolationValue < 1)
                        {
                            this.ChatBoxInstance.Visible = false;
                        }
                        setChatBoxInstanceXFirstValue = true;
                        ChatBoxInstanceXFirstValue = 0f;
                        setChatBoxInstanceYFirstValue = true;
                        ChatBoxInstanceYFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.ChatHistoryInstance.Visible = false;
                        }
                        setChatHistoryInstanceXFirstValue = true;
                        ChatHistoryInstanceXFirstValue = 10f;
                        setChatHistoryInstanceYFirstValue = true;
                        ChatHistoryInstanceYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ConfirmationWindowInstance.Visible = false;
                        }
                        setCurrentMusicDisplayInstanceCurrentAppearingStateFirstValue = true;
                        CurrentMusicDisplayInstanceCurrentAppearingStateFirstValue = AbbatoirIntergrade.GumRuntimes.CurrentMusicDisplayRuntime.Appearing.Hidden;
                        setCurrentMusicDisplayInstanceXFirstValue = true;
                        CurrentMusicDisplayInstanceXFirstValue = -10f;
                        setCurrentMusicDisplayInstanceYFirstValue = true;
                        CurrentMusicDisplayInstanceYFirstValue = 230f;
                        setDimmingRectangleAlphaFirstValue = true;
                        DimmingRectangleAlphaFirstValue = 0;
                        setDimmingRectangleBlueFirstValue = true;
                        DimmingRectangleBlueFirstValue = 0;
                        setDimmingRectangleGreenFirstValue = true;
                        DimmingRectangleGreenFirstValue = 0;
                        setDimmingRectangleHeightFirstValue = true;
                        DimmingRectangleHeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.DimmingRectangle.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setDimmingRectangleRedFirstValue = true;
                        DimmingRectangleRedFirstValue = 0;
                        setDimmingRectangleWidthFirstValue = true;
                        DimmingRectangleWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.DimmingRectangle.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.EnemyInfoInstance.Visible = false;
                        }
                        setHordeTextBlueFirstValue = true;
                        HordeTextBlueFirstValue = 50;
                        if (interpolationValue < 1)
                        {
                            this.HordeText.Font = "Informal Roman";
                        }
                        setHordeTextFontSizeFirstValue = true;
                        HordeTextFontSizeFirstValue = 96;
                        setHordeTextGreenFirstValue = true;
                        HordeTextGreenFirstValue = 50;
                        if (interpolationValue < 1)
                        {
                            this.HordeText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setHordeTextOutlineThicknessFirstValue = true;
                        HordeTextOutlineThicknessFirstValue = 1;
                        if (interpolationValue < 1)
                        {
                            this.HordeText.Text = "UNSTOPPABLE HORDE!";
                        }
                        if (interpolationValue < 1)
                        {
                            this.HordeText.Visible = false;
                        }
                        setHordeTextWidthFirstValue = true;
                        HordeTextWidthFirstValue = 0f;
                        setHordeTextXFirstValue = true;
                        HordeTextXFirstValue = -1800f;
                        if (interpolationValue < 1)
                        {
                            this.HordeText.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.HordeText.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue < 1)
                        {
                            this.HordeText.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.HordeText.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue < 1)
                        {
                            this.HorizonBoxInstance.Visible = true;
                        }
                        setLivesPointsDisplayInstanceXFirstValue = true;
                        LivesPointsDisplayInstanceXFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.LivesPointsDisplayInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.LivesPointsDisplayInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setLocationTimeAnnouncementInstanceCurrentDisplayingStateFirstValue = true;
                        LocationTimeAnnouncementInstanceCurrentDisplayingStateFirstValue = AbbatoirIntergrade.GumRuntimes.LocationTimeAnnouncementRuntime.Displaying.Start;
                        if (interpolationValue < 1)
                        {
                            this.MenuWindowInstance.ButtonType1State = AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime.ButtonType.X;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MenuWindowInstance.Visible = false;
                        }
                        setReadyButtonInstanceXFirstValue = true;
                        ReadyButtonInstanceXFirstValue = 1650f;
                        if (interpolationValue < 1)
                        {
                            this.ReadyButtonInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setReadyButtonInstanceYFirstValue = true;
                        ReadyButtonInstanceYFirstValue = 125f;
                        if (interpolationValue < 1)
                        {
                            this.ReadyButtonInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ScreenShadeInstance.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.StructureInfoInstance.Visible = false;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        if (interpolationValue >= 1)
                        {
                            this.BuildMenuInstance.Visible = false;
                        }
                        setChatBoxInstanceCurrentAppearanceStateSecondValue = true;
                        ChatBoxInstanceCurrentAppearanceStateSecondValue = AbbatoirIntergrade.GumRuntimes.ChatBoxRuntime.Appearance.ChatClosed;
                        if (interpolationValue >= 1)
                        {
                            this.ChatBoxInstance.Visible = false;
                        }
                        setChatBoxInstanceXSecondValue = true;
                        ChatBoxInstanceXSecondValue = 0f;
                        setChatBoxInstanceYSecondValue = true;
                        ChatBoxInstanceYSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.ChatHistoryInstance.Visible = false;
                        }
                        setChatHistoryInstanceXSecondValue = true;
                        ChatHistoryInstanceXSecondValue = 10f;
                        setChatHistoryInstanceYSecondValue = true;
                        ChatHistoryInstanceYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ConfirmationWindowInstance.Visible = false;
                        }
                        setCurrentMusicDisplayInstanceCurrentAppearingStateSecondValue = true;
                        CurrentMusicDisplayInstanceCurrentAppearingStateSecondValue = AbbatoirIntergrade.GumRuntimes.CurrentMusicDisplayRuntime.Appearing.Hidden;
                        setCurrentMusicDisplayInstanceXSecondValue = true;
                        CurrentMusicDisplayInstanceXSecondValue = -10f;
                        setCurrentMusicDisplayInstanceYSecondValue = true;
                        CurrentMusicDisplayInstanceYSecondValue = 230f;
                        setDimmingRectangleAlphaSecondValue = true;
                        DimmingRectangleAlphaSecondValue = 0;
                        setDimmingRectangleBlueSecondValue = true;
                        DimmingRectangleBlueSecondValue = 0;
                        setDimmingRectangleGreenSecondValue = true;
                        DimmingRectangleGreenSecondValue = 0;
                        setDimmingRectangleHeightSecondValue = true;
                        DimmingRectangleHeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.DimmingRectangle.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setDimmingRectangleRedSecondValue = true;
                        DimmingRectangleRedSecondValue = 0;
                        setDimmingRectangleWidthSecondValue = true;
                        DimmingRectangleWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.DimmingRectangle.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.EnemyInfoInstance.Visible = false;
                        }
                        setHordeTextBlueSecondValue = true;
                        HordeTextBlueSecondValue = 50;
                        if (interpolationValue >= 1)
                        {
                            this.HordeText.Font = "Informal Roman";
                        }
                        setHordeTextFontSizeSecondValue = true;
                        HordeTextFontSizeSecondValue = 96;
                        setHordeTextGreenSecondValue = true;
                        HordeTextGreenSecondValue = 50;
                        if (interpolationValue >= 1)
                        {
                            this.HordeText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setHordeTextOutlineThicknessSecondValue = true;
                        HordeTextOutlineThicknessSecondValue = 1;
                        if (interpolationValue >= 1)
                        {
                            this.HordeText.Text = "UNSTOPPABLE HORDE!";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HordeText.Visible = false;
                        }
                        setHordeTextWidthSecondValue = true;
                        HordeTextWidthSecondValue = 0f;
                        setHordeTextXSecondValue = true;
                        HordeTextXSecondValue = -1800f;
                        if (interpolationValue >= 1)
                        {
                            this.HordeText.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HordeText.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HordeText.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HordeText.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HorizonBoxInstance.Visible = true;
                        }
                        setLivesPointsDisplayInstanceXSecondValue = true;
                        LivesPointsDisplayInstanceXSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.LivesPointsDisplayInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.LivesPointsDisplayInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setLocationTimeAnnouncementInstanceCurrentDisplayingStateSecondValue = true;
                        LocationTimeAnnouncementInstanceCurrentDisplayingStateSecondValue = AbbatoirIntergrade.GumRuntimes.LocationTimeAnnouncementRuntime.Displaying.Start;
                        if (interpolationValue >= 1)
                        {
                            this.MenuWindowInstance.ButtonType1State = AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime.ButtonType.X;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MenuWindowInstance.Visible = false;
                        }
                        setReadyButtonInstanceXSecondValue = true;
                        ReadyButtonInstanceXSecondValue = 1650f;
                        if (interpolationValue >= 1)
                        {
                            this.ReadyButtonInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setReadyButtonInstanceYSecondValue = true;
                        ReadyButtonInstanceYSecondValue = 125f;
                        if (interpolationValue >= 1)
                        {
                            this.ReadyButtonInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ScreenShadeInstance.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.StructureInfoInstance.Visible = false;
                        }
                        break;
                }
                if (setChatBoxInstanceCurrentAppearanceStateFirstValue && setChatBoxInstanceCurrentAppearanceStateSecondValue)
                {
                    ChatBoxInstance.InterpolateBetween(ChatBoxInstanceCurrentAppearanceStateFirstValue, ChatBoxInstanceCurrentAppearanceStateSecondValue, interpolationValue);
                }
                if (setChatBoxInstanceXFirstValue && setChatBoxInstanceXSecondValue)
                {
                    ChatBoxInstance.X = ChatBoxInstanceXFirstValue * (1 - interpolationValue) + ChatBoxInstanceXSecondValue * interpolationValue;
                }
                if (setChatBoxInstanceYFirstValue && setChatBoxInstanceYSecondValue)
                {
                    ChatBoxInstance.Y = ChatBoxInstanceYFirstValue * (1 - interpolationValue) + ChatBoxInstanceYSecondValue * interpolationValue;
                }
                if (setChatHistoryInstanceXFirstValue && setChatHistoryInstanceXSecondValue)
                {
                    ChatHistoryInstance.X = ChatHistoryInstanceXFirstValue * (1 - interpolationValue) + ChatHistoryInstanceXSecondValue * interpolationValue;
                }
                if (setChatHistoryInstanceYFirstValue && setChatHistoryInstanceYSecondValue)
                {
                    ChatHistoryInstance.Y = ChatHistoryInstanceYFirstValue * (1 - interpolationValue) + ChatHistoryInstanceYSecondValue * interpolationValue;
                }
                if (setCurrentMusicDisplayInstanceCurrentAppearingStateFirstValue && setCurrentMusicDisplayInstanceCurrentAppearingStateSecondValue)
                {
                    CurrentMusicDisplayInstance.InterpolateBetween(CurrentMusicDisplayInstanceCurrentAppearingStateFirstValue, CurrentMusicDisplayInstanceCurrentAppearingStateSecondValue, interpolationValue);
                }
                if (setCurrentMusicDisplayInstanceXFirstValue && setCurrentMusicDisplayInstanceXSecondValue)
                {
                    CurrentMusicDisplayInstance.X = CurrentMusicDisplayInstanceXFirstValue * (1 - interpolationValue) + CurrentMusicDisplayInstanceXSecondValue * interpolationValue;
                }
                if (setCurrentMusicDisplayInstanceYFirstValue && setCurrentMusicDisplayInstanceYSecondValue)
                {
                    CurrentMusicDisplayInstance.Y = CurrentMusicDisplayInstanceYFirstValue * (1 - interpolationValue) + CurrentMusicDisplayInstanceYSecondValue * interpolationValue;
                }
                if (setDimmingRectangleAlphaFirstValue && setDimmingRectangleAlphaSecondValue)
                {
                    DimmingRectangle.Alpha = FlatRedBall.Math.MathFunctions.RoundToInt(DimmingRectangleAlphaFirstValue* (1 - interpolationValue) + DimmingRectangleAlphaSecondValue * interpolationValue);
                }
                if (setDimmingRectangleBlueFirstValue && setDimmingRectangleBlueSecondValue)
                {
                    DimmingRectangle.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(DimmingRectangleBlueFirstValue* (1 - interpolationValue) + DimmingRectangleBlueSecondValue * interpolationValue);
                }
                if (setDimmingRectangleGreenFirstValue && setDimmingRectangleGreenSecondValue)
                {
                    DimmingRectangle.Green = FlatRedBall.Math.MathFunctions.RoundToInt(DimmingRectangleGreenFirstValue* (1 - interpolationValue) + DimmingRectangleGreenSecondValue * interpolationValue);
                }
                if (setDimmingRectangleHeightFirstValue && setDimmingRectangleHeightSecondValue)
                {
                    DimmingRectangle.Height = DimmingRectangleHeightFirstValue * (1 - interpolationValue) + DimmingRectangleHeightSecondValue * interpolationValue;
                }
                if (setDimmingRectangleRedFirstValue && setDimmingRectangleRedSecondValue)
                {
                    DimmingRectangle.Red = FlatRedBall.Math.MathFunctions.RoundToInt(DimmingRectangleRedFirstValue* (1 - interpolationValue) + DimmingRectangleRedSecondValue * interpolationValue);
                }
                if (setDimmingRectangleWidthFirstValue && setDimmingRectangleWidthSecondValue)
                {
                    DimmingRectangle.Width = DimmingRectangleWidthFirstValue * (1 - interpolationValue) + DimmingRectangleWidthSecondValue * interpolationValue;
                }
                if (setHordeTextBlueFirstValue && setHordeTextBlueSecondValue)
                {
                    HordeText.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(HordeTextBlueFirstValue* (1 - interpolationValue) + HordeTextBlueSecondValue * interpolationValue);
                }
                if (setHordeTextFontSizeFirstValue && setHordeTextFontSizeSecondValue)
                {
                    HordeText.FontSize = FlatRedBall.Math.MathFunctions.RoundToInt(HordeTextFontSizeFirstValue* (1 - interpolationValue) + HordeTextFontSizeSecondValue * interpolationValue);
                }
                if (setHordeTextGreenFirstValue && setHordeTextGreenSecondValue)
                {
                    HordeText.Green = FlatRedBall.Math.MathFunctions.RoundToInt(HordeTextGreenFirstValue* (1 - interpolationValue) + HordeTextGreenSecondValue * interpolationValue);
                }
                if (setHordeTextOutlineThicknessFirstValue && setHordeTextOutlineThicknessSecondValue)
                {
                    HordeText.OutlineThickness = FlatRedBall.Math.MathFunctions.RoundToInt(HordeTextOutlineThicknessFirstValue* (1 - interpolationValue) + HordeTextOutlineThicknessSecondValue * interpolationValue);
                }
                if (setHordeTextWidthFirstValue && setHordeTextWidthSecondValue)
                {
                    HordeText.Width = HordeTextWidthFirstValue * (1 - interpolationValue) + HordeTextWidthSecondValue * interpolationValue;
                }
                if (setHordeTextXFirstValue && setHordeTextXSecondValue)
                {
                    HordeText.X = HordeTextXFirstValue * (1 - interpolationValue) + HordeTextXSecondValue * interpolationValue;
                }
                if (setLivesPointsDisplayInstanceXFirstValue && setLivesPointsDisplayInstanceXSecondValue)
                {
                    LivesPointsDisplayInstance.X = LivesPointsDisplayInstanceXFirstValue * (1 - interpolationValue) + LivesPointsDisplayInstanceXSecondValue * interpolationValue;
                }
                if (setLocationTimeAnnouncementInstanceCurrentDisplayingStateFirstValue && setLocationTimeAnnouncementInstanceCurrentDisplayingStateSecondValue)
                {
                    LocationTimeAnnouncementInstance.InterpolateBetween(LocationTimeAnnouncementInstanceCurrentDisplayingStateFirstValue, LocationTimeAnnouncementInstanceCurrentDisplayingStateSecondValue, interpolationValue);
                }
                if (setReadyButtonInstanceXFirstValue && setReadyButtonInstanceXSecondValue)
                {
                    ReadyButtonInstance.X = ReadyButtonInstanceXFirstValue * (1 - interpolationValue) + ReadyButtonInstanceXSecondValue * interpolationValue;
                }
                if (setReadyButtonInstanceYFirstValue && setReadyButtonInstanceYSecondValue)
                {
                    ReadyButtonInstance.Y = ReadyButtonInstanceYFirstValue * (1 - interpolationValue) + ReadyButtonInstanceYSecondValue * interpolationValue;
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
            public void InterpolateBetween (ChatHistoryShowing firstState, ChatHistoryShowing secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setChatBoxInstanceCurrentAppearanceStateFirstValue = false;
                bool setChatBoxInstanceCurrentAppearanceStateSecondValue = false;
                ChatBoxRuntime.Appearance ChatBoxInstanceCurrentAppearanceStateFirstValue= ChatBoxRuntime.Appearance.ChatOpen;
                ChatBoxRuntime.Appearance ChatBoxInstanceCurrentAppearanceStateSecondValue= ChatBoxRuntime.Appearance.ChatOpen;
                bool setChatBoxInstanceWidthFirstValue = false;
                bool setChatBoxInstanceWidthSecondValue = false;
                float ChatBoxInstanceWidthFirstValue= 0;
                float ChatBoxInstanceWidthSecondValue= 0;
                bool setChatBoxInstanceXFirstValue = false;
                bool setChatBoxInstanceXSecondValue = false;
                float ChatBoxInstanceXFirstValue= 0;
                float ChatBoxInstanceXSecondValue= 0;
                bool setChatBoxInstanceYFirstValue = false;
                bool setChatBoxInstanceYSecondValue = false;
                float ChatBoxInstanceYFirstValue= 0;
                float ChatBoxInstanceYSecondValue= 0;
                switch(firstState)
                {
                    case  ChatHistoryShowing.ChatHistoryHidden:
                        setChatBoxInstanceCurrentAppearanceStateFirstValue = true;
                        ChatBoxInstanceCurrentAppearanceStateFirstValue = AbbatoirIntergrade.GumRuntimes.ChatBoxRuntime.Appearance.ChatOpen;
                        if (interpolationValue < 1)
                        {
                            this.ChatBoxInstance.RecentResponseContainerVisible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ChatBoxInstance.Visible = true;
                        }
                        setChatBoxInstanceWidthFirstValue = true;
                        ChatBoxInstanceWidthFirstValue = 50f;
                        setChatBoxInstanceXFirstValue = true;
                        ChatBoxInstanceXFirstValue = 0f;
                        setChatBoxInstanceYFirstValue = true;
                        ChatBoxInstanceYFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.ChatHistoryInstance.Visible = false;
                        }
                        break;
                    case  ChatHistoryShowing.ChatHistoryShow1:
                        setChatBoxInstanceCurrentAppearanceStateFirstValue = true;
                        ChatBoxInstanceCurrentAppearanceStateFirstValue = AbbatoirIntergrade.GumRuntimes.ChatBoxRuntime.Appearance.Appear4;
                        if (interpolationValue < 1)
                        {
                            this.ChatBoxInstance.RecentResponseContainerVisible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ChatBoxInstance.Visible = true;
                        }
                        setChatBoxInstanceWidthFirstValue = true;
                        ChatBoxInstanceWidthFirstValue = 50f;
                        setChatBoxInstanceXFirstValue = true;
                        ChatBoxInstanceXFirstValue = 0f;
                        setChatBoxInstanceYFirstValue = true;
                        ChatBoxInstanceYFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.ChatHistoryInstance.Visible = false;
                        }
                        break;
                    case  ChatHistoryShowing.ChatHistoryShow2:
                        setChatBoxInstanceCurrentAppearanceStateFirstValue = true;
                        ChatBoxInstanceCurrentAppearanceStateFirstValue = AbbatoirIntergrade.GumRuntimes.ChatBoxRuntime.Appearance.Appear3;
                        if (interpolationValue < 1)
                        {
                            this.ChatBoxInstance.ChatContainerVisible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ChatBoxInstance.RecentResponseContainerVisible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ChatBoxInstance.Visible = true;
                        }
                        setChatBoxInstanceWidthFirstValue = true;
                        ChatBoxInstanceWidthFirstValue = 50f;
                        setChatBoxInstanceXFirstValue = true;
                        ChatBoxInstanceXFirstValue = 0f;
                        setChatBoxInstanceYFirstValue = true;
                        ChatBoxInstanceYFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.ChatHistoryInstance.Visible = false;
                        }
                        break;
                    case  ChatHistoryShowing.ChatHistoryShow3:
                        setChatBoxInstanceCurrentAppearanceStateFirstValue = true;
                        ChatBoxInstanceCurrentAppearanceStateFirstValue = AbbatoirIntergrade.GumRuntimes.ChatBoxRuntime.Appearance.Appear2;
                        if (interpolationValue < 1)
                        {
                            this.ChatBoxInstance.RecentResponseContainerVisible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ChatBoxInstance.Visible = true;
                        }
                        setChatBoxInstanceWidthFirstValue = true;
                        ChatBoxInstanceWidthFirstValue = 50f;
                        setChatBoxInstanceXFirstValue = true;
                        ChatBoxInstanceXFirstValue = 0f;
                        setChatBoxInstanceYFirstValue = true;
                        ChatBoxInstanceYFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.ChatHistoryInstance.Visible = false;
                        }
                        break;
                    case  ChatHistoryShowing.ChatHistoryShow4:
                        setChatBoxInstanceCurrentAppearanceStateFirstValue = true;
                        ChatBoxInstanceCurrentAppearanceStateFirstValue = AbbatoirIntergrade.GumRuntimes.ChatBoxRuntime.Appearance.Appear2;
                        if (interpolationValue < 1)
                        {
                            this.ChatBoxInstance.RecentResponseContainerVisible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ChatBoxInstance.Visible = true;
                        }
                        setChatBoxInstanceWidthFirstValue = true;
                        ChatBoxInstanceWidthFirstValue = 33.20313f;
                        setChatBoxInstanceXFirstValue = true;
                        ChatBoxInstanceXFirstValue = 10f;
                        setChatBoxInstanceYFirstValue = true;
                        ChatBoxInstanceYFirstValue = 28f;
                        if (interpolationValue < 1)
                        {
                            this.ChatHistoryInstance.Visible = false;
                        }
                        break;
                    case  ChatHistoryShowing.ChatHistoryShown:
                        setChatBoxInstanceCurrentAppearanceStateFirstValue = true;
                        ChatBoxInstanceCurrentAppearanceStateFirstValue = AbbatoirIntergrade.GumRuntimes.ChatBoxRuntime.Appearance.ChatOpen;
                        if (interpolationValue < 1)
                        {
                            this.ChatBoxInstance.RecentResponseContainerVisible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ChatBoxInstance.Visible = false;
                        }
                        setChatBoxInstanceWidthFirstValue = true;
                        ChatBoxInstanceWidthFirstValue = 33.20313f;
                        setChatBoxInstanceXFirstValue = true;
                        ChatBoxInstanceXFirstValue = 10f;
                        setChatBoxInstanceYFirstValue = true;
                        ChatBoxInstanceYFirstValue = 28f;
                        if (interpolationValue < 1)
                        {
                            this.ChatHistoryInstance.Visible = true;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  ChatHistoryShowing.ChatHistoryHidden:
                        setChatBoxInstanceCurrentAppearanceStateSecondValue = true;
                        ChatBoxInstanceCurrentAppearanceStateSecondValue = AbbatoirIntergrade.GumRuntimes.ChatBoxRuntime.Appearance.ChatOpen;
                        if (interpolationValue >= 1)
                        {
                            this.ChatBoxInstance.RecentResponseContainerVisible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ChatBoxInstance.Visible = true;
                        }
                        setChatBoxInstanceWidthSecondValue = true;
                        ChatBoxInstanceWidthSecondValue = 50f;
                        setChatBoxInstanceXSecondValue = true;
                        ChatBoxInstanceXSecondValue = 0f;
                        setChatBoxInstanceYSecondValue = true;
                        ChatBoxInstanceYSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.ChatHistoryInstance.Visible = false;
                        }
                        break;
                    case  ChatHistoryShowing.ChatHistoryShow1:
                        setChatBoxInstanceCurrentAppearanceStateSecondValue = true;
                        ChatBoxInstanceCurrentAppearanceStateSecondValue = AbbatoirIntergrade.GumRuntimes.ChatBoxRuntime.Appearance.Appear4;
                        if (interpolationValue >= 1)
                        {
                            this.ChatBoxInstance.RecentResponseContainerVisible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ChatBoxInstance.Visible = true;
                        }
                        setChatBoxInstanceWidthSecondValue = true;
                        ChatBoxInstanceWidthSecondValue = 50f;
                        setChatBoxInstanceXSecondValue = true;
                        ChatBoxInstanceXSecondValue = 0f;
                        setChatBoxInstanceYSecondValue = true;
                        ChatBoxInstanceYSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.ChatHistoryInstance.Visible = false;
                        }
                        break;
                    case  ChatHistoryShowing.ChatHistoryShow2:
                        setChatBoxInstanceCurrentAppearanceStateSecondValue = true;
                        ChatBoxInstanceCurrentAppearanceStateSecondValue = AbbatoirIntergrade.GumRuntimes.ChatBoxRuntime.Appearance.Appear3;
                        if (interpolationValue >= 1)
                        {
                            this.ChatBoxInstance.ChatContainerVisible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ChatBoxInstance.RecentResponseContainerVisible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ChatBoxInstance.Visible = true;
                        }
                        setChatBoxInstanceWidthSecondValue = true;
                        ChatBoxInstanceWidthSecondValue = 50f;
                        setChatBoxInstanceXSecondValue = true;
                        ChatBoxInstanceXSecondValue = 0f;
                        setChatBoxInstanceYSecondValue = true;
                        ChatBoxInstanceYSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.ChatHistoryInstance.Visible = false;
                        }
                        break;
                    case  ChatHistoryShowing.ChatHistoryShow3:
                        setChatBoxInstanceCurrentAppearanceStateSecondValue = true;
                        ChatBoxInstanceCurrentAppearanceStateSecondValue = AbbatoirIntergrade.GumRuntimes.ChatBoxRuntime.Appearance.Appear2;
                        if (interpolationValue >= 1)
                        {
                            this.ChatBoxInstance.RecentResponseContainerVisible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ChatBoxInstance.Visible = true;
                        }
                        setChatBoxInstanceWidthSecondValue = true;
                        ChatBoxInstanceWidthSecondValue = 50f;
                        setChatBoxInstanceXSecondValue = true;
                        ChatBoxInstanceXSecondValue = 0f;
                        setChatBoxInstanceYSecondValue = true;
                        ChatBoxInstanceYSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.ChatHistoryInstance.Visible = false;
                        }
                        break;
                    case  ChatHistoryShowing.ChatHistoryShow4:
                        setChatBoxInstanceCurrentAppearanceStateSecondValue = true;
                        ChatBoxInstanceCurrentAppearanceStateSecondValue = AbbatoirIntergrade.GumRuntimes.ChatBoxRuntime.Appearance.Appear2;
                        if (interpolationValue >= 1)
                        {
                            this.ChatBoxInstance.RecentResponseContainerVisible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ChatBoxInstance.Visible = true;
                        }
                        setChatBoxInstanceWidthSecondValue = true;
                        ChatBoxInstanceWidthSecondValue = 33.20313f;
                        setChatBoxInstanceXSecondValue = true;
                        ChatBoxInstanceXSecondValue = 10f;
                        setChatBoxInstanceYSecondValue = true;
                        ChatBoxInstanceYSecondValue = 28f;
                        if (interpolationValue >= 1)
                        {
                            this.ChatHistoryInstance.Visible = false;
                        }
                        break;
                    case  ChatHistoryShowing.ChatHistoryShown:
                        setChatBoxInstanceCurrentAppearanceStateSecondValue = true;
                        ChatBoxInstanceCurrentAppearanceStateSecondValue = AbbatoirIntergrade.GumRuntimes.ChatBoxRuntime.Appearance.ChatOpen;
                        if (interpolationValue >= 1)
                        {
                            this.ChatBoxInstance.RecentResponseContainerVisible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ChatBoxInstance.Visible = false;
                        }
                        setChatBoxInstanceWidthSecondValue = true;
                        ChatBoxInstanceWidthSecondValue = 33.20313f;
                        setChatBoxInstanceXSecondValue = true;
                        ChatBoxInstanceXSecondValue = 10f;
                        setChatBoxInstanceYSecondValue = true;
                        ChatBoxInstanceYSecondValue = 28f;
                        if (interpolationValue >= 1)
                        {
                            this.ChatHistoryInstance.Visible = true;
                        }
                        break;
                }
                if (setChatBoxInstanceCurrentAppearanceStateFirstValue && setChatBoxInstanceCurrentAppearanceStateSecondValue)
                {
                    ChatBoxInstance.InterpolateBetween(ChatBoxInstanceCurrentAppearanceStateFirstValue, ChatBoxInstanceCurrentAppearanceStateSecondValue, interpolationValue);
                }
                if (setChatBoxInstanceWidthFirstValue && setChatBoxInstanceWidthSecondValue)
                {
                    ChatBoxInstance.Width = ChatBoxInstanceWidthFirstValue * (1 - interpolationValue) + ChatBoxInstanceWidthSecondValue * interpolationValue;
                }
                if (setChatBoxInstanceXFirstValue && setChatBoxInstanceXSecondValue)
                {
                    ChatBoxInstance.X = ChatBoxInstanceXFirstValue * (1 - interpolationValue) + ChatBoxInstanceXSecondValue * interpolationValue;
                }
                if (setChatBoxInstanceYFirstValue && setChatBoxInstanceYSecondValue)
                {
                    ChatBoxInstance.Y = ChatBoxInstanceYFirstValue * (1 - interpolationValue) + ChatBoxInstanceYSecondValue * interpolationValue;
                }
                if (interpolationValue < 1)
                {
                    mCurrentChatHistoryShowingState = firstState;
                }
                else
                {
                    mCurrentChatHistoryShowingState = secondState;
                }
            }
            public void InterpolateBetween (Fading firstState, Fading secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setDimmingRectangleAlphaFirstValue = false;
                bool setDimmingRectangleAlphaSecondValue = false;
                int DimmingRectangleAlphaFirstValue= 0;
                int DimmingRectangleAlphaSecondValue= 0;
                switch(firstState)
                {
                    case  Fading.Faded:
                        setDimmingRectangleAlphaFirstValue = true;
                        DimmingRectangleAlphaFirstValue = 255;
                        break;
                    case  Fading.NotFaded:
                        setDimmingRectangleAlphaFirstValue = true;
                        DimmingRectangleAlphaFirstValue = 0;
                        break;
                }
                switch(secondState)
                {
                    case  Fading.Faded:
                        setDimmingRectangleAlphaSecondValue = true;
                        DimmingRectangleAlphaSecondValue = 255;
                        break;
                    case  Fading.NotFaded:
                        setDimmingRectangleAlphaSecondValue = true;
                        DimmingRectangleAlphaSecondValue = 0;
                        break;
                }
                if (setDimmingRectangleAlphaFirstValue && setDimmingRectangleAlphaSecondValue)
                {
                    DimmingRectangle.Alpha = FlatRedBall.Math.MathFunctions.RoundToInt(DimmingRectangleAlphaFirstValue* (1 - interpolationValue) + DimmingRectangleAlphaSecondValue * interpolationValue);
                }
                if (interpolationValue < 1)
                {
                    mCurrentFadingState = firstState;
                }
                else
                {
                    mCurrentFadingState = secondState;
                }
            }
            public void InterpolateBetween (HordeDisplay firstState, HordeDisplay secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setHordeTextAlphaFirstValue = false;
                bool setHordeTextAlphaSecondValue = false;
                int HordeTextAlphaFirstValue= 0;
                int HordeTextAlphaSecondValue= 0;
                bool setHordeTextFontScaleFirstValue = false;
                bool setHordeTextFontScaleSecondValue = false;
                float HordeTextFontScaleFirstValue= 0;
                float HordeTextFontScaleSecondValue= 0;
                bool setHordeTextXFirstValue = false;
                bool setHordeTextXSecondValue = false;
                float HordeTextXFirstValue= 0;
                float HordeTextXSecondValue= 0;
                switch(firstState)
                {
                    case  HordeDisplay.HordeStart:
                        setHordeTextAlphaFirstValue = true;
                        HordeTextAlphaFirstValue = 0;
                        setHordeTextFontScaleFirstValue = true;
                        HordeTextFontScaleFirstValue = 1f;
                        if (interpolationValue < 1)
                        {
                            this.HordeText.Visible = true;
                        }
                        setHordeTextXFirstValue = true;
                        HordeTextXFirstValue = 0f;
                        break;
                    case  HordeDisplay.HordeMiddle:
                        setHordeTextAlphaFirstValue = true;
                        HordeTextAlphaFirstValue = 255;
                        setHordeTextFontScaleFirstValue = true;
                        HordeTextFontScaleFirstValue = 1f;
                        if (interpolationValue < 1)
                        {
                            this.HordeText.Visible = true;
                        }
                        setHordeTextXFirstValue = true;
                        HordeTextXFirstValue = 0f;
                        break;
                    case  HordeDisplay.HordeMiddleBig:
                        setHordeTextAlphaFirstValue = true;
                        HordeTextAlphaFirstValue = 255;
                        setHordeTextFontScaleFirstValue = true;
                        HordeTextFontScaleFirstValue = 1.5f;
                        if (interpolationValue < 1)
                        {
                            this.HordeText.Visible = true;
                        }
                        setHordeTextXFirstValue = true;
                        HordeTextXFirstValue = 0f;
                        break;
                    case  HordeDisplay.HordeEnd:
                        setHordeTextAlphaFirstValue = true;
                        HordeTextAlphaFirstValue = 0;
                        setHordeTextFontScaleFirstValue = true;
                        HordeTextFontScaleFirstValue = 0.5f;
                        if (interpolationValue < 1)
                        {
                            this.HordeText.Visible = true;
                        }
                        setHordeTextXFirstValue = true;
                        HordeTextXFirstValue = 0f;
                        break;
                }
                switch(secondState)
                {
                    case  HordeDisplay.HordeStart:
                        setHordeTextAlphaSecondValue = true;
                        HordeTextAlphaSecondValue = 0;
                        setHordeTextFontScaleSecondValue = true;
                        HordeTextFontScaleSecondValue = 1f;
                        if (interpolationValue >= 1)
                        {
                            this.HordeText.Visible = true;
                        }
                        setHordeTextXSecondValue = true;
                        HordeTextXSecondValue = 0f;
                        break;
                    case  HordeDisplay.HordeMiddle:
                        setHordeTextAlphaSecondValue = true;
                        HordeTextAlphaSecondValue = 255;
                        setHordeTextFontScaleSecondValue = true;
                        HordeTextFontScaleSecondValue = 1f;
                        if (interpolationValue >= 1)
                        {
                            this.HordeText.Visible = true;
                        }
                        setHordeTextXSecondValue = true;
                        HordeTextXSecondValue = 0f;
                        break;
                    case  HordeDisplay.HordeMiddleBig:
                        setHordeTextAlphaSecondValue = true;
                        HordeTextAlphaSecondValue = 255;
                        setHordeTextFontScaleSecondValue = true;
                        HordeTextFontScaleSecondValue = 1.5f;
                        if (interpolationValue >= 1)
                        {
                            this.HordeText.Visible = true;
                        }
                        setHordeTextXSecondValue = true;
                        HordeTextXSecondValue = 0f;
                        break;
                    case  HordeDisplay.HordeEnd:
                        setHordeTextAlphaSecondValue = true;
                        HordeTextAlphaSecondValue = 0;
                        setHordeTextFontScaleSecondValue = true;
                        HordeTextFontScaleSecondValue = 0.5f;
                        if (interpolationValue >= 1)
                        {
                            this.HordeText.Visible = true;
                        }
                        setHordeTextXSecondValue = true;
                        HordeTextXSecondValue = 0f;
                        break;
                }
                if (setHordeTextAlphaFirstValue && setHordeTextAlphaSecondValue)
                {
                    HordeText.Alpha = FlatRedBall.Math.MathFunctions.RoundToInt(HordeTextAlphaFirstValue* (1 - interpolationValue) + HordeTextAlphaSecondValue * interpolationValue);
                }
                if (setHordeTextFontScaleFirstValue && setHordeTextFontScaleSecondValue)
                {
                    HordeText.FontScale = HordeTextFontScaleFirstValue * (1 - interpolationValue) + HordeTextFontScaleSecondValue * interpolationValue;
                }
                if (setHordeTextXFirstValue && setHordeTextXSecondValue)
                {
                    HordeText.X = HordeTextXFirstValue * (1 - interpolationValue) + HordeTextXSecondValue * interpolationValue;
                }
                if (interpolationValue < 1)
                {
                    mCurrentHordeDisplayState = firstState;
                }
                else
                {
                    mCurrentHordeDisplayState = secondState;
                }
            }
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.GameScreenGumRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.GameScreenGumRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.GameScreenGumRuntime.ChatHistoryShowing fromState,AbbatoirIntergrade.GumRuntimes.GameScreenGumRuntime.ChatHistoryShowing toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (ChatHistoryShowing toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "ChatHistoryShowing").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentChatHistoryShowingState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (ChatHistoryShowing toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentChatHistoryShowingState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.GameScreenGumRuntime.Fading fromState,AbbatoirIntergrade.GumRuntimes.GameScreenGumRuntime.Fading toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Fading toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "Fading").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentFadingState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (Fading toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentFadingState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.GameScreenGumRuntime.HordeDisplay fromState,AbbatoirIntergrade.GumRuntimes.GameScreenGumRuntime.HordeDisplay toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (HordeDisplay toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "HordeDisplay").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentHordeDisplayState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (HordeDisplay toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentHordeDisplayState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            #endregion
            #region State Animations
            private System.Collections.Generic.IEnumerable<FlatRedBall.Instructions.Instruction> ShowChatHistoryAnimationInstructions (object target) 
            {
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction( ()=> this.CurrentChatHistoryShowingState = ChatHistoryShowing.ChatHistoryHidden);
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime;
                    toReturn.Target = target;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(ChatHistoryShowing.ChatHistoryShow1, 0.1f, FlatRedBall.Glue.StateInterpolation.InterpolationType.Exponential, FlatRedBall.Glue.StateInterpolation.Easing.InOut, ShowChatHistoryAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(ChatHistoryShowing.ChatHistoryShow2, 0.1f, FlatRedBall.Glue.StateInterpolation.InterpolationType.Exponential, FlatRedBall.Glue.StateInterpolation.Easing.InOut, ShowChatHistoryAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0.1f;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(ChatHistoryShowing.ChatHistoryShow3, 0.1f, FlatRedBall.Glue.StateInterpolation.InterpolationType.Exponential, FlatRedBall.Glue.StateInterpolation.Easing.InOut, ShowChatHistoryAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0.2f;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(ChatHistoryShowing.ChatHistoryShow4, 0.09999999f, FlatRedBall.Glue.StateInterpolation.InterpolationType.Exponential, FlatRedBall.Glue.StateInterpolation.Easing.InOut, ShowChatHistoryAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0.3f;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(ChatHistoryShowing.ChatHistoryShown, 0.09999999f, FlatRedBall.Glue.StateInterpolation.InterpolationType.Exponential, FlatRedBall.Glue.StateInterpolation.Easing.InOut, ShowChatHistoryAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0.4f;
                    yield return toReturn;
                }
            }
            private System.Collections.Generic.IEnumerable<FlatRedBall.Instructions.Instruction> ShowChatHistoryAnimationRelativeInstructions (object target) 
            {
                {
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(() =>
                    {
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "ChatHistoryShowing/ChatHistoryHidden").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "ChatHistoryShowing/ChatHistoryShow1").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(ChatHistoryShowing.ChatHistoryShow1);
                        Gum.DataTypes.Variables.StateSave second = first.Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.AddIntoThis(second, difference);
                        FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: 0.1f, type: FlatRedBall.Glue.StateInterpolation.InterpolationType.Exponential, easing: FlatRedBall.Glue.StateInterpolation.Easing.InOut);
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
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "ChatHistoryShowing/ChatHistoryShow1").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "ChatHistoryShowing/ChatHistoryShow2").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(ChatHistoryShowing.ChatHistoryShow2);
                        Gum.DataTypes.Variables.StateSave second = first.Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.AddIntoThis(second, difference);
                        FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: 0.1f, type: FlatRedBall.Glue.StateInterpolation.InterpolationType.Exponential, easing: FlatRedBall.Glue.StateInterpolation.Easing.InOut);
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
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "ChatHistoryShowing/ChatHistoryShow2").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "ChatHistoryShowing/ChatHistoryShow3").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(ChatHistoryShowing.ChatHistoryShow3);
                        Gum.DataTypes.Variables.StateSave second = first.Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.AddIntoThis(second, difference);
                        FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: 0.1f, type: FlatRedBall.Glue.StateInterpolation.InterpolationType.Exponential, easing: FlatRedBall.Glue.StateInterpolation.Easing.InOut);
                        tweener.Owner = this;
                        tweener.PositionChanged = newPosition => this.InterpolateBetween(first, second, newPosition);
                        tweener.Start();
                        StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                    }
                    );
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0.2f;
                    toReturn.Target = target;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(() =>
                    {
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "ChatHistoryShowing/ChatHistoryShow3").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "ChatHistoryShowing/ChatHistoryShow4").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(ChatHistoryShowing.ChatHistoryShow4);
                        Gum.DataTypes.Variables.StateSave second = first.Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.AddIntoThis(second, difference);
                        FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: 0.09999999f, type: FlatRedBall.Glue.StateInterpolation.InterpolationType.Exponential, easing: FlatRedBall.Glue.StateInterpolation.Easing.InOut);
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
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "ChatHistoryShowing/ChatHistoryShow4").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "ChatHistoryShowing/ChatHistoryShown").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(ChatHistoryShowing.ChatHistoryShown);
                        Gum.DataTypes.Variables.StateSave second = first.Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.AddIntoThis(second, difference);
                        FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: 0.09999999f, type: FlatRedBall.Glue.StateInterpolation.InterpolationType.Exponential, easing: FlatRedBall.Glue.StateInterpolation.Easing.InOut);
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
            }
            private FlatRedBall.Gum.Animation.GumAnimation showChatHistoryAnimation;
            public FlatRedBall.Gum.Animation.GumAnimation ShowChatHistoryAnimation
            {
                get
                {
                    if (showChatHistoryAnimation == null)
                    {
                        showChatHistoryAnimation = new FlatRedBall.Gum.Animation.GumAnimation(0.5f, ShowChatHistoryAnimationInstructions);
                    }
                    return showChatHistoryAnimation;
                }
            }
            private FlatRedBall.Gum.Animation.GumAnimation showChatHistoryAnimationRelative;
            public FlatRedBall.Gum.Animation.GumAnimation ShowChatHistoryAnimationRelative
            {
                get
                {
                    if (showChatHistoryAnimationRelative == null)
                    {
                        showChatHistoryAnimationRelative = new FlatRedBall.Gum.Animation.GumAnimation(0.5f, ShowChatHistoryAnimationRelativeInstructions);
                    }
                    return showChatHistoryAnimationRelative;
                }
            }
            private System.Collections.Generic.IEnumerable<FlatRedBall.Instructions.Instruction> HideChatHistoryAnimationInstructions (object target) 
            {
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction( ()=> this.CurrentChatHistoryShowingState = ChatHistoryShowing.ChatHistoryShown);
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime;
                    toReturn.Target = target;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(ChatHistoryShowing.ChatHistoryShow4, 0.1f, FlatRedBall.Glue.StateInterpolation.InterpolationType.Linear, FlatRedBall.Glue.StateInterpolation.Easing.Out, HideChatHistoryAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(ChatHistoryShowing.ChatHistoryShow3, 0.1f, FlatRedBall.Glue.StateInterpolation.InterpolationType.Exponential, FlatRedBall.Glue.StateInterpolation.Easing.InOut, HideChatHistoryAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0.1f;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(ChatHistoryShowing.ChatHistoryShow2, 0.1f, FlatRedBall.Glue.StateInterpolation.InterpolationType.Exponential, FlatRedBall.Glue.StateInterpolation.Easing.InOut, HideChatHistoryAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0.2f;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(ChatHistoryShowing.ChatHistoryShow1, 0.09999999f, FlatRedBall.Glue.StateInterpolation.InterpolationType.Exponential, FlatRedBall.Glue.StateInterpolation.Easing.InOut, HideChatHistoryAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0.3f;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(ChatHistoryShowing.ChatHistoryHidden, 0.09999999f, FlatRedBall.Glue.StateInterpolation.InterpolationType.Exponential, FlatRedBall.Glue.StateInterpolation.Easing.InOut, HideChatHistoryAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0.4f;
                    yield return toReturn;
                }
            }
            private System.Collections.Generic.IEnumerable<FlatRedBall.Instructions.Instruction> HideChatHistoryAnimationRelativeInstructions (object target) 
            {
                {
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(() =>
                    {
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "ChatHistoryShowing/ChatHistoryShown").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "ChatHistoryShowing/ChatHistoryShow4").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(ChatHistoryShowing.ChatHistoryShow4);
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
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "ChatHistoryShowing/ChatHistoryShow4").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "ChatHistoryShowing/ChatHistoryShow3").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(ChatHistoryShowing.ChatHistoryShow3);
                        Gum.DataTypes.Variables.StateSave second = first.Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.AddIntoThis(second, difference);
                        FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: 0.1f, type: FlatRedBall.Glue.StateInterpolation.InterpolationType.Exponential, easing: FlatRedBall.Glue.StateInterpolation.Easing.InOut);
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
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "ChatHistoryShowing/ChatHistoryShow3").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "ChatHistoryShowing/ChatHistoryShow2").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(ChatHistoryShowing.ChatHistoryShow2);
                        Gum.DataTypes.Variables.StateSave second = first.Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.AddIntoThis(second, difference);
                        FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: 0.1f, type: FlatRedBall.Glue.StateInterpolation.InterpolationType.Exponential, easing: FlatRedBall.Glue.StateInterpolation.Easing.InOut);
                        tweener.Owner = this;
                        tweener.PositionChanged = newPosition => this.InterpolateBetween(first, second, newPosition);
                        tweener.Start();
                        StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                    }
                    );
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0.2f;
                    toReturn.Target = target;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(() =>
                    {
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "ChatHistoryShowing/ChatHistoryShow2").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "ChatHistoryShowing/ChatHistoryShow1").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(ChatHistoryShowing.ChatHistoryShow1);
                        Gum.DataTypes.Variables.StateSave second = first.Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.AddIntoThis(second, difference);
                        FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: 0.09999999f, type: FlatRedBall.Glue.StateInterpolation.InterpolationType.Exponential, easing: FlatRedBall.Glue.StateInterpolation.Easing.InOut);
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
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "ChatHistoryShowing/ChatHistoryShow1").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "ChatHistoryShowing/ChatHistoryHidden").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(ChatHistoryShowing.ChatHistoryHidden);
                        Gum.DataTypes.Variables.StateSave second = first.Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.AddIntoThis(second, difference);
                        FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: 0.09999999f, type: FlatRedBall.Glue.StateInterpolation.InterpolationType.Exponential, easing: FlatRedBall.Glue.StateInterpolation.Easing.InOut);
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
            }
            private FlatRedBall.Gum.Animation.GumAnimation hideChatHistoryAnimation;
            public FlatRedBall.Gum.Animation.GumAnimation HideChatHistoryAnimation
            {
                get
                {
                    if (hideChatHistoryAnimation == null)
                    {
                        hideChatHistoryAnimation = new FlatRedBall.Gum.Animation.GumAnimation(0.51f, HideChatHistoryAnimationInstructions);
                        hideChatHistoryAnimation.AddEvent("SetupResponseAvailability", 0.51f);
                    }
                    return hideChatHistoryAnimation;
                }
            }
            private FlatRedBall.Gum.Animation.GumAnimation hideChatHistoryAnimationRelative;
            public FlatRedBall.Gum.Animation.GumAnimation HideChatHistoryAnimationRelative
            {
                get
                {
                    if (hideChatHistoryAnimationRelative == null)
                    {
                        hideChatHistoryAnimationRelative = new FlatRedBall.Gum.Animation.GumAnimation(0.51f, HideChatHistoryAnimationRelativeInstructions);
                        hideChatHistoryAnimationRelative.AddEvent("SetupResponseAvailability", 0.51f);
                    }
                    return hideChatHistoryAnimationRelative;
                }
            }
            private System.Collections.Generic.IEnumerable<FlatRedBall.Instructions.Instruction> FadeInAnimationInstructions (object target) 
            {
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction( ()=> this.CurrentFadingState = Fading.Faded);
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime;
                    toReturn.Target = target;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(Fading.NotFaded, 1, FlatRedBall.Glue.StateInterpolation.InterpolationType.Linear, FlatRedBall.Glue.StateInterpolation.Easing.Out, FadeInAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0;
                    yield return toReturn;
                }
            }
            private System.Collections.Generic.IEnumerable<FlatRedBall.Instructions.Instruction> FadeInAnimationRelativeInstructions (object target) 
            {
                {
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(() =>
                    {
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "Fading/Faded").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "Fading/NotFaded").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(Fading.NotFaded);
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
            private FlatRedBall.Gum.Animation.GumAnimation fadeInAnimation;
            public FlatRedBall.Gum.Animation.GumAnimation FadeInAnimation
            {
                get
                {
                    if (fadeInAnimation == null)
                    {
                        fadeInAnimation = new FlatRedBall.Gum.Animation.GumAnimation(1, FadeInAnimationInstructions);
                    }
                    return fadeInAnimation;
                }
            }
            private FlatRedBall.Gum.Animation.GumAnimation fadeInAnimationRelative;
            public FlatRedBall.Gum.Animation.GumAnimation FadeInAnimationRelative
            {
                get
                {
                    if (fadeInAnimationRelative == null)
                    {
                        fadeInAnimationRelative = new FlatRedBall.Gum.Animation.GumAnimation(1, FadeInAnimationRelativeInstructions);
                    }
                    return fadeInAnimationRelative;
                }
            }
            private System.Collections.Generic.IEnumerable<FlatRedBall.Instructions.Instruction> FadeOutAnimationInstructions (object target) 
            {
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction( ()=> this.CurrentFadingState = Fading.NotFaded);
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime;
                    toReturn.Target = target;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(Fading.Faded, 2.5f, FlatRedBall.Glue.StateInterpolation.InterpolationType.Linear, FlatRedBall.Glue.StateInterpolation.Easing.Out, FadeOutAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0;
                    yield return toReturn;
                }
            }
            private System.Collections.Generic.IEnumerable<FlatRedBall.Instructions.Instruction> FadeOutAnimationRelativeInstructions (object target) 
            {
                {
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(() =>
                    {
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "Fading/NotFaded").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "Fading/Faded").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(Fading.Faded);
                        Gum.DataTypes.Variables.StateSave second = first.Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.AddIntoThis(second, difference);
                        FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: 2.5f, type: FlatRedBall.Glue.StateInterpolation.InterpolationType.Linear, easing: FlatRedBall.Glue.StateInterpolation.Easing.Out);
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
            private FlatRedBall.Gum.Animation.GumAnimation fadeOutAnimation;
            public FlatRedBall.Gum.Animation.GumAnimation FadeOutAnimation
            {
                get
                {
                    if (fadeOutAnimation == null)
                    {
                        fadeOutAnimation = new FlatRedBall.Gum.Animation.GumAnimation(2.5f, FadeOutAnimationInstructions);
                    }
                    return fadeOutAnimation;
                }
            }
            private FlatRedBall.Gum.Animation.GumAnimation fadeOutAnimationRelative;
            public FlatRedBall.Gum.Animation.GumAnimation FadeOutAnimationRelative
            {
                get
                {
                    if (fadeOutAnimationRelative == null)
                    {
                        fadeOutAnimationRelative = new FlatRedBall.Gum.Animation.GumAnimation(2.5f, FadeOutAnimationRelativeInstructions);
                    }
                    return fadeOutAnimationRelative;
                }
            }
            private System.Collections.Generic.IEnumerable<FlatRedBall.Instructions.Instruction> HordeIncomingAnimationInstructions (object target) 
            {
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction( ()=> this.CurrentHordeDisplayState = HordeDisplay.HordeStart);
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime;
                    toReturn.Target = target;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(HordeDisplay.HordeMiddle, 0.25f, FlatRedBall.Glue.StateInterpolation.InterpolationType.Linear, FlatRedBall.Glue.StateInterpolation.Easing.Out, HordeIncomingAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(HordeDisplay.HordeMiddleBig, 0.25f, FlatRedBall.Glue.StateInterpolation.InterpolationType.Circular, FlatRedBall.Glue.StateInterpolation.Easing.InOut, HordeIncomingAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0.25f;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(HordeDisplay.HordeMiddle, 0.25f, FlatRedBall.Glue.StateInterpolation.InterpolationType.Circular, FlatRedBall.Glue.StateInterpolation.Easing.InOut, HordeIncomingAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0.5f;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(HordeDisplay.HordeMiddleBig, 0.25f, FlatRedBall.Glue.StateInterpolation.InterpolationType.Circular, FlatRedBall.Glue.StateInterpolation.Easing.InOut, HordeIncomingAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 0.75f;
                    yield return toReturn;
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(  () => this.InterpolateTo(HordeDisplay.HordeEnd, 3, FlatRedBall.Glue.StateInterpolation.InterpolationType.Circular, FlatRedBall.Glue.StateInterpolation.Easing.InOut, HordeIncomingAnimation));
                    toReturn.Target = target;
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 1;
                    yield return toReturn;
                }
            }
            private System.Collections.Generic.IEnumerable<FlatRedBall.Instructions.Instruction> HordeIncomingAnimationRelativeInstructions (object target) 
            {
                {
                }
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(() =>
                    {
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "HordeDisplay/HordeStart").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "HordeDisplay/HordeMiddle").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(HordeDisplay.HordeMiddle);
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
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "HordeDisplay/HordeMiddle").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "HordeDisplay/HordeMiddleBig").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(HordeDisplay.HordeMiddleBig);
                        Gum.DataTypes.Variables.StateSave second = first.Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.AddIntoThis(second, difference);
                        FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: 0.25f, type: FlatRedBall.Glue.StateInterpolation.InterpolationType.Circular, easing: FlatRedBall.Glue.StateInterpolation.Easing.InOut);
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
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "HordeDisplay/HordeMiddleBig").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "HordeDisplay/HordeMiddle").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(HordeDisplay.HordeMiddle);
                        Gum.DataTypes.Variables.StateSave second = first.Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.AddIntoThis(second, difference);
                        FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: 0.25f, type: FlatRedBall.Glue.StateInterpolation.InterpolationType.Circular, easing: FlatRedBall.Glue.StateInterpolation.Easing.InOut);
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
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "HordeDisplay/HordeMiddle").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "HordeDisplay/HordeMiddleBig").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(HordeDisplay.HordeMiddleBig);
                        Gum.DataTypes.Variables.StateSave second = first.Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.AddIntoThis(second, difference);
                        FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: 0.25f, type: FlatRedBall.Glue.StateInterpolation.InterpolationType.Circular, easing: FlatRedBall.Glue.StateInterpolation.Easing.InOut);
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
                {
                    var toReturn = new FlatRedBall.Instructions.DelegateInstruction(() =>
                    {
                        var relativeStart = ElementSave.AllStates.FirstOrDefault(item => item.Name == "HordeDisplay/HordeMiddleBig").Clone();
                        var relativeEnd = ElementSave.AllStates.FirstOrDefault(item => item.Name == "HordeDisplay/HordeEnd").Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.SubtractFromThis(relativeEnd, relativeStart);
                        var difference = relativeEnd;
                        Gum.DataTypes.Variables.StateSave first = GetCurrentValuesOnState(HordeDisplay.HordeEnd);
                        Gum.DataTypes.Variables.StateSave second = first.Clone();
                        Gum.DataTypes.Variables.StateSaveExtensionMethods.AddIntoThis(second, difference);
                        FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: 3, type: FlatRedBall.Glue.StateInterpolation.InterpolationType.Circular, easing: FlatRedBall.Glue.StateInterpolation.Easing.InOut);
                        tweener.Owner = this;
                        tweener.PositionChanged = newPosition => this.InterpolateBetween(first, second, newPosition);
                        tweener.Start();
                        StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                    }
                    );
                    toReturn.TimeToExecute = FlatRedBall.TimeManager.CurrentTime + 1;
                    toReturn.Target = target;
                    yield return toReturn;
                }
            }
            private FlatRedBall.Gum.Animation.GumAnimation hordeIncomingAnimation;
            public FlatRedBall.Gum.Animation.GumAnimation HordeIncomingAnimation
            {
                get
                {
                    if (hordeIncomingAnimation == null)
                    {
                        hordeIncomingAnimation = new FlatRedBall.Gum.Animation.GumAnimation(4, HordeIncomingAnimationInstructions);
                    }
                    return hordeIncomingAnimation;
                }
            }
            private FlatRedBall.Gum.Animation.GumAnimation hordeIncomingAnimationRelative;
            public FlatRedBall.Gum.Animation.GumAnimation HordeIncomingAnimationRelative
            {
                get
                {
                    if (hordeIncomingAnimationRelative == null)
                    {
                        hordeIncomingAnimationRelative = new FlatRedBall.Gum.Animation.GumAnimation(4, HordeIncomingAnimationRelativeInstructions);
                    }
                    return hordeIncomingAnimationRelative;
                }
            }
            #endregion
            public override void StopAnimations () 
            {
                base.StopAnimations();
                HorizonBoxInstance.StopAnimations();
                EnemyInfoInstance.StopAnimations();
                StructureInfoInstance.StopAnimations();
                ChatBoxInstance.StopAnimations();
                BuildMenuInstance.StopAnimations();
                LivesPointsDisplayInstance.StopAnimations();
                ChatHistoryInstance.StopAnimations();
                TopStatusBarInstance.StopAnimations();
                ScreenShadeInstance.StopAnimations();
                MenuWindowInstance.StopAnimations();
                LocationTimeAnnouncementInstance.StopAnimations();
                ConfirmationWindowInstance.StopAnimations();
                CurrentMusicDisplayInstance.StopAnimations();
                ReadyButtonInstance.StopAnimations();
                ShowChatHistoryAnimation.Stop();
                HideChatHistoryAnimation.Stop();
                FadeInAnimation.Stop();
                FadeOutAnimation.Stop();
                HordeIncomingAnimation.Stop();
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
                            Name = "HorizonBoxInstance.Visible",
                            Type = "bool",
                            Value = HorizonBoxInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnemyInfoInstance.Visible",
                            Type = "bool",
                            Value = EnemyInfoInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureInfoInstance.Visible",
                            Type = "bool",
                            Value = StructureInfoInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.AppearanceState",
                            Type = "Appearance",
                            Value = ChatBoxInstance.CurrentAppearanceState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.Visible",
                            Type = "bool",
                            Value = ChatBoxInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.X",
                            Type = "float",
                            Value = ChatBoxInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.Y",
                            Type = "float",
                            Value = ChatBoxInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildMenuInstance.Visible",
                            Type = "bool",
                            Value = BuildMenuInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesPointsDisplayInstance.X",
                            Type = "float",
                            Value = LivesPointsDisplayInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesPointsDisplayInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = LivesPointsDisplayInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesPointsDisplayInstance.X Units",
                            Type = "PositionUnitType",
                            Value = LivesPointsDisplayInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatHistoryInstance.Visible",
                            Type = "bool",
                            Value = ChatHistoryInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatHistoryInstance.X",
                            Type = "float",
                            Value = ChatHistoryInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatHistoryInstance.Y",
                            Type = "float",
                            Value = ChatHistoryInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScreenShadeInstance.Visible",
                            Type = "bool",
                            Value = ScreenShadeInstance.Visible
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
                            Name = "MenuWindowInstance.Visible",
                            Type = "bool",
                            Value = MenuWindowInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DimmingRectangle.Alpha",
                            Type = "int",
                            Value = DimmingRectangle.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DimmingRectangle.Blue",
                            Type = "int",
                            Value = DimmingRectangle.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DimmingRectangle.Green",
                            Type = "int",
                            Value = DimmingRectangle.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DimmingRectangle.Height",
                            Type = "float",
                            Value = DimmingRectangle.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DimmingRectangle.Height Units",
                            Type = "DimensionUnitType",
                            Value = DimmingRectangle.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DimmingRectangle.Red",
                            Type = "int",
                            Value = DimmingRectangle.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DimmingRectangle.Width",
                            Type = "float",
                            Value = DimmingRectangle.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DimmingRectangle.Width Units",
                            Type = "DimensionUnitType",
                            Value = DimmingRectangle.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LocationTimeAnnouncementInstance.DisplayingState",
                            Type = "DisplayingState",
                            Value = LocationTimeAnnouncementInstance.CurrentDisplayingState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConfirmationWindowInstance.Visible",
                            Type = "bool",
                            Value = ConfirmationWindowInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicDisplayInstance.AppearingState",
                            Type = "AppearingState",
                            Value = CurrentMusicDisplayInstance.CurrentAppearingState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicDisplayInstance.X",
                            Type = "float",
                            Value = CurrentMusicDisplayInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicDisplayInstance.Y",
                            Type = "float",
                            Value = CurrentMusicDisplayInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.Blue",
                            Type = "int",
                            Value = HordeText.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.Font",
                            Type = "string",
                            Value = HordeText.Font
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.FontSize",
                            Type = "int",
                            Value = HordeText.FontSize
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.Green",
                            Type = "int",
                            Value = HordeText.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = HordeText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.OutlineThickness",
                            Type = "int",
                            Value = HordeText.OutlineThickness
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.Text",
                            Type = "string",
                            Value = HordeText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.Visible",
                            Type = "bool",
                            Value = HordeText.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.Width",
                            Type = "float",
                            Value = HordeText.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.X",
                            Type = "float",
                            Value = HordeText.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.X Origin",
                            Type = "HorizontalAlignment",
                            Value = HordeText.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.X Units",
                            Type = "PositionUnitType",
                            Value = HordeText.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.Y Origin",
                            Type = "VerticalAlignment",
                            Value = HordeText.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.Y Units",
                            Type = "PositionUnitType",
                            Value = HordeText.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ReadyButtonInstance.X",
                            Type = "float",
                            Value = ReadyButtonInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ReadyButtonInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ReadyButtonInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ReadyButtonInstance.Y",
                            Type = "float",
                            Value = ReadyButtonInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ReadyButtonInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = ReadyButtonInstance.YOrigin
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
                            Name = "HorizonBoxInstance.Visible",
                            Type = "bool",
                            Value = HorizonBoxInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EnemyInfoInstance.Visible",
                            Type = "bool",
                            Value = EnemyInfoInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StructureInfoInstance.Visible",
                            Type = "bool",
                            Value = StructureInfoInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.AppearanceState",
                            Type = "Appearance",
                            Value = ChatBoxInstance.CurrentAppearanceState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.Visible",
                            Type = "bool",
                            Value = ChatBoxInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.X",
                            Type = "float",
                            Value = ChatBoxInstance.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.Y",
                            Type = "float",
                            Value = ChatBoxInstance.Y + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BuildMenuInstance.Visible",
                            Type = "bool",
                            Value = BuildMenuInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesPointsDisplayInstance.X",
                            Type = "float",
                            Value = LivesPointsDisplayInstance.X + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesPointsDisplayInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = LivesPointsDisplayInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LivesPointsDisplayInstance.X Units",
                            Type = "PositionUnitType",
                            Value = LivesPointsDisplayInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatHistoryInstance.Visible",
                            Type = "bool",
                            Value = ChatHistoryInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatHistoryInstance.X",
                            Type = "float",
                            Value = ChatHistoryInstance.X + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatHistoryInstance.Y",
                            Type = "float",
                            Value = ChatHistoryInstance.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ScreenShadeInstance.Visible",
                            Type = "bool",
                            Value = ScreenShadeInstance.Visible
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
                            Name = "MenuWindowInstance.Visible",
                            Type = "bool",
                            Value = MenuWindowInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DimmingRectangle.Alpha",
                            Type = "int",
                            Value = DimmingRectangle.Alpha + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DimmingRectangle.Blue",
                            Type = "int",
                            Value = DimmingRectangle.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DimmingRectangle.Green",
                            Type = "int",
                            Value = DimmingRectangle.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DimmingRectangle.Height",
                            Type = "float",
                            Value = DimmingRectangle.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DimmingRectangle.Height Units",
                            Type = "DimensionUnitType",
                            Value = DimmingRectangle.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DimmingRectangle.Red",
                            Type = "int",
                            Value = DimmingRectangle.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DimmingRectangle.Width",
                            Type = "float",
                            Value = DimmingRectangle.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DimmingRectangle.Width Units",
                            Type = "DimensionUnitType",
                            Value = DimmingRectangle.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LocationTimeAnnouncementInstance.DisplayingState",
                            Type = "DisplayingState",
                            Value = LocationTimeAnnouncementInstance.CurrentDisplayingState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConfirmationWindowInstance.Visible",
                            Type = "bool",
                            Value = ConfirmationWindowInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicDisplayInstance.AppearingState",
                            Type = "AppearingState",
                            Value = CurrentMusicDisplayInstance.CurrentAppearingState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicDisplayInstance.X",
                            Type = "float",
                            Value = CurrentMusicDisplayInstance.X + -10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CurrentMusicDisplayInstance.Y",
                            Type = "float",
                            Value = CurrentMusicDisplayInstance.Y + 230f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.Blue",
                            Type = "int",
                            Value = HordeText.Blue + 50
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.Font",
                            Type = "string",
                            Value = HordeText.Font
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.FontSize",
                            Type = "int",
                            Value = HordeText.FontSize + 96
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.Green",
                            Type = "int",
                            Value = HordeText.Green + 50
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = HordeText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.OutlineThickness",
                            Type = "int",
                            Value = HordeText.OutlineThickness + 1
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.Text",
                            Type = "string",
                            Value = HordeText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.Visible",
                            Type = "bool",
                            Value = HordeText.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.Width",
                            Type = "float",
                            Value = HordeText.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.X",
                            Type = "float",
                            Value = HordeText.X + -1800f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.X Origin",
                            Type = "HorizontalAlignment",
                            Value = HordeText.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.X Units",
                            Type = "PositionUnitType",
                            Value = HordeText.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.Y Origin",
                            Type = "VerticalAlignment",
                            Value = HordeText.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.Y Units",
                            Type = "PositionUnitType",
                            Value = HordeText.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ReadyButtonInstance.X",
                            Type = "float",
                            Value = ReadyButtonInstance.X + 1650f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ReadyButtonInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ReadyButtonInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ReadyButtonInstance.Y",
                            Type = "float",
                            Value = ReadyButtonInstance.Y + 125f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ReadyButtonInstance.Y Origin",
                            Type = "VerticalAlignment",
                            Value = ReadyButtonInstance.YOrigin
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (ChatHistoryShowing state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  ChatHistoryShowing.ChatHistoryHidden:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.AppearanceState",
                            Type = "Appearance",
                            Value = ChatBoxInstance.CurrentAppearanceState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.RecentResponseContainerVisible",
                            Type = "bool",
                            Value = ChatBoxInstance.RecentResponseContainerVisible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.Visible",
                            Type = "bool",
                            Value = ChatBoxInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.Width",
                            Type = "float",
                            Value = ChatBoxInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.X",
                            Type = "float",
                            Value = ChatBoxInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.Y",
                            Type = "float",
                            Value = ChatBoxInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatHistoryInstance.Visible",
                            Type = "bool",
                            Value = ChatHistoryInstance.Visible
                        }
                        );
                        break;
                    case  ChatHistoryShowing.ChatHistoryShow1:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.AppearanceState",
                            Type = "Appearance",
                            Value = ChatBoxInstance.CurrentAppearanceState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.RecentResponseContainerVisible",
                            Type = "bool",
                            Value = ChatBoxInstance.RecentResponseContainerVisible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.Visible",
                            Type = "bool",
                            Value = ChatBoxInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.Width",
                            Type = "float",
                            Value = ChatBoxInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.X",
                            Type = "float",
                            Value = ChatBoxInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.Y",
                            Type = "float",
                            Value = ChatBoxInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatHistoryInstance.Visible",
                            Type = "bool",
                            Value = ChatHistoryInstance.Visible
                        }
                        );
                        break;
                    case  ChatHistoryShowing.ChatHistoryShow2:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.AppearanceState",
                            Type = "Appearance",
                            Value = ChatBoxInstance.CurrentAppearanceState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.ChatContainerVisible",
                            Type = "bool",
                            Value = ChatBoxInstance.ChatContainerVisible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.RecentResponseContainerVisible",
                            Type = "bool",
                            Value = ChatBoxInstance.RecentResponseContainerVisible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.Visible",
                            Type = "bool",
                            Value = ChatBoxInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.Width",
                            Type = "float",
                            Value = ChatBoxInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.X",
                            Type = "float",
                            Value = ChatBoxInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.Y",
                            Type = "float",
                            Value = ChatBoxInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatHistoryInstance.Visible",
                            Type = "bool",
                            Value = ChatHistoryInstance.Visible
                        }
                        );
                        break;
                    case  ChatHistoryShowing.ChatHistoryShow3:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.AppearanceState",
                            Type = "Appearance",
                            Value = ChatBoxInstance.CurrentAppearanceState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.RecentResponseContainerVisible",
                            Type = "bool",
                            Value = ChatBoxInstance.RecentResponseContainerVisible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.Visible",
                            Type = "bool",
                            Value = ChatBoxInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.Width",
                            Type = "float",
                            Value = ChatBoxInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.X",
                            Type = "float",
                            Value = ChatBoxInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.Y",
                            Type = "float",
                            Value = ChatBoxInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatHistoryInstance.Visible",
                            Type = "bool",
                            Value = ChatHistoryInstance.Visible
                        }
                        );
                        break;
                    case  ChatHistoryShowing.ChatHistoryShow4:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.AppearanceState",
                            Type = "Appearance",
                            Value = ChatBoxInstance.CurrentAppearanceState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.RecentResponseContainerVisible",
                            Type = "bool",
                            Value = ChatBoxInstance.RecentResponseContainerVisible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.Visible",
                            Type = "bool",
                            Value = ChatBoxInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.Width",
                            Type = "float",
                            Value = ChatBoxInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.X",
                            Type = "float",
                            Value = ChatBoxInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.Y",
                            Type = "float",
                            Value = ChatBoxInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatHistoryInstance.Visible",
                            Type = "bool",
                            Value = ChatHistoryInstance.Visible
                        }
                        );
                        break;
                    case  ChatHistoryShowing.ChatHistoryShown:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.AppearanceState",
                            Type = "Appearance",
                            Value = ChatBoxInstance.CurrentAppearanceState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.RecentResponseContainerVisible",
                            Type = "bool",
                            Value = ChatBoxInstance.RecentResponseContainerVisible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.Visible",
                            Type = "bool",
                            Value = ChatBoxInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.Width",
                            Type = "float",
                            Value = ChatBoxInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.X",
                            Type = "float",
                            Value = ChatBoxInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.Y",
                            Type = "float",
                            Value = ChatBoxInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatHistoryInstance.Visible",
                            Type = "bool",
                            Value = ChatHistoryInstance.Visible
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (ChatHistoryShowing state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  ChatHistoryShowing.ChatHistoryHidden:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.AppearanceState",
                            Type = "Appearance",
                            Value = ChatBoxInstance.CurrentAppearanceState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.RecentResponseContainerVisible",
                            Type = "bool",
                            Value = ChatBoxInstance.RecentResponseContainerVisible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.Visible",
                            Type = "bool",
                            Value = ChatBoxInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.Width",
                            Type = "float",
                            Value = ChatBoxInstance.Width + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.X",
                            Type = "float",
                            Value = ChatBoxInstance.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.Y",
                            Type = "float",
                            Value = ChatBoxInstance.Y + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatHistoryInstance.Visible",
                            Type = "bool",
                            Value = ChatHistoryInstance.Visible
                        }
                        );
                        break;
                    case  ChatHistoryShowing.ChatHistoryShow1:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.AppearanceState",
                            Type = "Appearance",
                            Value = ChatBoxInstance.CurrentAppearanceState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.RecentResponseContainerVisible",
                            Type = "bool",
                            Value = ChatBoxInstance.RecentResponseContainerVisible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.Visible",
                            Type = "bool",
                            Value = ChatBoxInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.Width",
                            Type = "float",
                            Value = ChatBoxInstance.Width + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.X",
                            Type = "float",
                            Value = ChatBoxInstance.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.Y",
                            Type = "float",
                            Value = ChatBoxInstance.Y + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatHistoryInstance.Visible",
                            Type = "bool",
                            Value = ChatHistoryInstance.Visible
                        }
                        );
                        break;
                    case  ChatHistoryShowing.ChatHistoryShow2:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.AppearanceState",
                            Type = "Appearance",
                            Value = ChatBoxInstance.CurrentAppearanceState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.ChatContainerVisible",
                            Type = "bool",
                            Value = ChatBoxInstance.ChatContainerVisible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.RecentResponseContainerVisible",
                            Type = "bool",
                            Value = ChatBoxInstance.RecentResponseContainerVisible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.Visible",
                            Type = "bool",
                            Value = ChatBoxInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.Width",
                            Type = "float",
                            Value = ChatBoxInstance.Width + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.X",
                            Type = "float",
                            Value = ChatBoxInstance.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.Y",
                            Type = "float",
                            Value = ChatBoxInstance.Y + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatHistoryInstance.Visible",
                            Type = "bool",
                            Value = ChatHistoryInstance.Visible
                        }
                        );
                        break;
                    case  ChatHistoryShowing.ChatHistoryShow3:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.AppearanceState",
                            Type = "Appearance",
                            Value = ChatBoxInstance.CurrentAppearanceState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.RecentResponseContainerVisible",
                            Type = "bool",
                            Value = ChatBoxInstance.RecentResponseContainerVisible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.Visible",
                            Type = "bool",
                            Value = ChatBoxInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.Width",
                            Type = "float",
                            Value = ChatBoxInstance.Width + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.X",
                            Type = "float",
                            Value = ChatBoxInstance.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.Y",
                            Type = "float",
                            Value = ChatBoxInstance.Y + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatHistoryInstance.Visible",
                            Type = "bool",
                            Value = ChatHistoryInstance.Visible
                        }
                        );
                        break;
                    case  ChatHistoryShowing.ChatHistoryShow4:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.AppearanceState",
                            Type = "Appearance",
                            Value = ChatBoxInstance.CurrentAppearanceState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.RecentResponseContainerVisible",
                            Type = "bool",
                            Value = ChatBoxInstance.RecentResponseContainerVisible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.Visible",
                            Type = "bool",
                            Value = ChatBoxInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.Width",
                            Type = "float",
                            Value = ChatBoxInstance.Width + 33.20313f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.X",
                            Type = "float",
                            Value = ChatBoxInstance.X + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.Y",
                            Type = "float",
                            Value = ChatBoxInstance.Y + 28f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatHistoryInstance.Visible",
                            Type = "bool",
                            Value = ChatHistoryInstance.Visible
                        }
                        );
                        break;
                    case  ChatHistoryShowing.ChatHistoryShown:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.AppearanceState",
                            Type = "Appearance",
                            Value = ChatBoxInstance.CurrentAppearanceState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.RecentResponseContainerVisible",
                            Type = "bool",
                            Value = ChatBoxInstance.RecentResponseContainerVisible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.Visible",
                            Type = "bool",
                            Value = ChatBoxInstance.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.Width",
                            Type = "float",
                            Value = ChatBoxInstance.Width + 33.20313f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.X",
                            Type = "float",
                            Value = ChatBoxInstance.X + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatBoxInstance.Y",
                            Type = "float",
                            Value = ChatBoxInstance.Y + 28f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChatHistoryInstance.Visible",
                            Type = "bool",
                            Value = ChatHistoryInstance.Visible
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (Fading state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  Fading.Faded:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DimmingRectangle.Alpha",
                            Type = "int",
                            Value = DimmingRectangle.Alpha
                        }
                        );
                        break;
                    case  Fading.NotFaded:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DimmingRectangle.Alpha",
                            Type = "int",
                            Value = DimmingRectangle.Alpha
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (Fading state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  Fading.Faded:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DimmingRectangle.Alpha",
                            Type = "int",
                            Value = DimmingRectangle.Alpha + 255
                        }
                        );
                        break;
                    case  Fading.NotFaded:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DimmingRectangle.Alpha",
                            Type = "int",
                            Value = DimmingRectangle.Alpha + 0
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (HordeDisplay state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  HordeDisplay.HordeStart:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.Alpha",
                            Type = "int",
                            Value = HordeText.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.Font Scale",
                            Type = "float",
                            Value = HordeText.FontScale
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.Visible",
                            Type = "bool",
                            Value = HordeText.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.X",
                            Type = "float",
                            Value = HordeText.X
                        }
                        );
                        break;
                    case  HordeDisplay.HordeMiddle:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.Alpha",
                            Type = "int",
                            Value = HordeText.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.Font Scale",
                            Type = "float",
                            Value = HordeText.FontScale
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.Visible",
                            Type = "bool",
                            Value = HordeText.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.X",
                            Type = "float",
                            Value = HordeText.X
                        }
                        );
                        break;
                    case  HordeDisplay.HordeMiddleBig:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.Alpha",
                            Type = "int",
                            Value = HordeText.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.Font Scale",
                            Type = "float",
                            Value = HordeText.FontScale
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.Visible",
                            Type = "bool",
                            Value = HordeText.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.X",
                            Type = "float",
                            Value = HordeText.X
                        }
                        );
                        break;
                    case  HordeDisplay.HordeEnd:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.Alpha",
                            Type = "int",
                            Value = HordeText.Alpha
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.Font Scale",
                            Type = "float",
                            Value = HordeText.FontScale
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.Visible",
                            Type = "bool",
                            Value = HordeText.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.X",
                            Type = "float",
                            Value = HordeText.X
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (HordeDisplay state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  HordeDisplay.HordeStart:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.Alpha",
                            Type = "int",
                            Value = HordeText.Alpha + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.Font Scale",
                            Type = "float",
                            Value = HordeText.FontScale + 1f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.Visible",
                            Type = "bool",
                            Value = HordeText.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.X",
                            Type = "float",
                            Value = HordeText.X + 0f
                        }
                        );
                        break;
                    case  HordeDisplay.HordeMiddle:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.Alpha",
                            Type = "int",
                            Value = HordeText.Alpha + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.Font Scale",
                            Type = "float",
                            Value = HordeText.FontScale + 1f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.Visible",
                            Type = "bool",
                            Value = HordeText.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.X",
                            Type = "float",
                            Value = HordeText.X + 0f
                        }
                        );
                        break;
                    case  HordeDisplay.HordeMiddleBig:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.Alpha",
                            Type = "int",
                            Value = HordeText.Alpha + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.Font Scale",
                            Type = "float",
                            Value = HordeText.FontScale + 1.5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.Visible",
                            Type = "bool",
                            Value = HordeText.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.X",
                            Type = "float",
                            Value = HordeText.X + 0f
                        }
                        );
                        break;
                    case  HordeDisplay.HordeEnd:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.Alpha",
                            Type = "int",
                            Value = HordeText.Alpha + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.Font Scale",
                            Type = "float",
                            Value = HordeText.FontScale + 0.5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.Visible",
                            Type = "bool",
                            Value = HordeText.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HordeText.X",
                            Type = "float",
                            Value = HordeText.X + 0f
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
                    else if (category.Name == "ChatHistoryShowing")
                    {
                        if(state.Name == "ChatHistoryHidden") this.mCurrentChatHistoryShowingState = ChatHistoryShowing.ChatHistoryHidden;
                        if(state.Name == "ChatHistoryShow1") this.mCurrentChatHistoryShowingState = ChatHistoryShowing.ChatHistoryShow1;
                        if(state.Name == "ChatHistoryShow2") this.mCurrentChatHistoryShowingState = ChatHistoryShowing.ChatHistoryShow2;
                        if(state.Name == "ChatHistoryShow3") this.mCurrentChatHistoryShowingState = ChatHistoryShowing.ChatHistoryShow3;
                        if(state.Name == "ChatHistoryShow4") this.mCurrentChatHistoryShowingState = ChatHistoryShowing.ChatHistoryShow4;
                        if(state.Name == "ChatHistoryShown") this.mCurrentChatHistoryShowingState = ChatHistoryShowing.ChatHistoryShown;
                    }
                    else if (category.Name == "Fading")
                    {
                        if(state.Name == "Faded") this.mCurrentFadingState = Fading.Faded;
                        if(state.Name == "NotFaded") this.mCurrentFadingState = Fading.NotFaded;
                    }
                    else if (category.Name == "HordeDisplay")
                    {
                        if(state.Name == "HordeStart") this.mCurrentHordeDisplayState = HordeDisplay.HordeStart;
                        if(state.Name == "HordeMiddle") this.mCurrentHordeDisplayState = HordeDisplay.HordeMiddle;
                        if(state.Name == "HordeMiddleBig") this.mCurrentHordeDisplayState = HordeDisplay.HordeMiddleBig;
                        if(state.Name == "HordeEnd") this.mCurrentHordeDisplayState = HordeDisplay.HordeEnd;
                    }
                }
                base.ApplyState(state);
            }
            private AbbatoirIntergrade.GumRuntimes.HorizonBoxRuntime HorizonBoxInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.EnemyInfoRuntime EnemyInfoInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.StructureInfoRuntime StructureInfoInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ChatBoxRuntime ChatBoxInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.BuildMenuRuntime BuildMenuInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.LivesPointsDisplayRuntime LivesPointsDisplayInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ChatHistoryRuntime ChatHistoryInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TopStatusBarRuntime TopStatusBarInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ScreenShadeRuntime ScreenShadeInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.MenuWindowRuntime MenuWindowInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ColoredRectangleRuntime DimmingRectangle { get; set; }
            private AbbatoirIntergrade.GumRuntimes.LocationTimeAnnouncementRuntime LocationTimeAnnouncementInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ConfirmationWindowRuntime ConfirmationWindowInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.CurrentMusicDisplayRuntime CurrentMusicDisplayInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime HordeText { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ReadyButtonRuntime ReadyButtonInstance { get; set; }
            public GameScreenGumRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            {
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Screens.First(item => item.Name == "GameScreenGum");
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
                HorizonBoxInstance = this.GetGraphicalUiElementByName("HorizonBoxInstance") as AbbatoirIntergrade.GumRuntimes.HorizonBoxRuntime;
                EnemyInfoInstance = this.GetGraphicalUiElementByName("EnemyInfoInstance") as AbbatoirIntergrade.GumRuntimes.EnemyInfoRuntime;
                StructureInfoInstance = this.GetGraphicalUiElementByName("StructureInfoInstance") as AbbatoirIntergrade.GumRuntimes.StructureInfoRuntime;
                ChatBoxInstance = this.GetGraphicalUiElementByName("ChatBoxInstance") as AbbatoirIntergrade.GumRuntimes.ChatBoxRuntime;
                BuildMenuInstance = this.GetGraphicalUiElementByName("BuildMenuInstance") as AbbatoirIntergrade.GumRuntimes.BuildMenuRuntime;
                LivesPointsDisplayInstance = this.GetGraphicalUiElementByName("LivesPointsDisplayInstance") as AbbatoirIntergrade.GumRuntimes.LivesPointsDisplayRuntime;
                ChatHistoryInstance = this.GetGraphicalUiElementByName("ChatHistoryInstance") as AbbatoirIntergrade.GumRuntimes.ChatHistoryRuntime;
                TopStatusBarInstance = this.GetGraphicalUiElementByName("TopStatusBarInstance") as AbbatoirIntergrade.GumRuntimes.TopStatusBarRuntime;
                ScreenShadeInstance = this.GetGraphicalUiElementByName("ScreenShadeInstance") as AbbatoirIntergrade.GumRuntimes.ScreenShadeRuntime;
                MenuWindowInstance = this.GetGraphicalUiElementByName("MenuWindowInstance") as AbbatoirIntergrade.GumRuntimes.MenuWindowRuntime;
                DimmingRectangle = this.GetGraphicalUiElementByName("DimmingRectangle") as AbbatoirIntergrade.GumRuntimes.ColoredRectangleRuntime;
                LocationTimeAnnouncementInstance = this.GetGraphicalUiElementByName("LocationTimeAnnouncementInstance") as AbbatoirIntergrade.GumRuntimes.LocationTimeAnnouncementRuntime;
                ConfirmationWindowInstance = this.GetGraphicalUiElementByName("ConfirmationWindowInstance") as AbbatoirIntergrade.GumRuntimes.ConfirmationWindowRuntime;
                CurrentMusicDisplayInstance = this.GetGraphicalUiElementByName("CurrentMusicDisplayInstance") as AbbatoirIntergrade.GumRuntimes.CurrentMusicDisplayRuntime;
                HordeText = this.GetGraphicalUiElementByName("HordeText") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
                ReadyButtonInstance = this.GetGraphicalUiElementByName("ReadyButtonInstance") as AbbatoirIntergrade.GumRuntimes.ReadyButtonRuntime;
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
