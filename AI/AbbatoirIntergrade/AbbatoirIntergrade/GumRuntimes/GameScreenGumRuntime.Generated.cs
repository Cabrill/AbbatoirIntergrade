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
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            ChatHistoryShowing mCurrentChatHistoryShowingState;
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
                bool setLivesPointsDisplayInstanceXFirstValue = false;
                bool setLivesPointsDisplayInstanceXSecondValue = false;
                float LivesPointsDisplayInstanceXFirstValue= 0;
                float LivesPointsDisplayInstanceXSecondValue= 0;
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
                            this.EnemyInfoInstance.Visible = false;
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
                            this.EnemyInfoInstance.Visible = false;
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
                if (setLivesPointsDisplayInstanceXFirstValue && setLivesPointsDisplayInstanceXSecondValue)
                {
                    LivesPointsDisplayInstance.X = LivesPointsDisplayInstanceXFirstValue * (1 - interpolationValue) + LivesPointsDisplayInstanceXSecondValue * interpolationValue;
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
                ShowChatHistoryAnimation.Stop();
                HideChatHistoryAnimation.Stop();
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
            public GameScreenGumRuntime (bool fullInstantiation = true) 
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
