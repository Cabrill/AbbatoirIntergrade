    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes
    {
        public partial class ChatHistoryRuntime : AbbatoirIntergrade.GumRuntimes.ContainerRuntime
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
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
                            Width = 33f;
                            WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            InnerPanelInstance.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                            InnerPanelInstance.Height = 0f;
                            InnerPanelInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                            InnerPanelInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ClipContainerInstance") ?? this;
                            InnerPanelInstance.Width = 0f;
                            InnerPanelInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            VerticalScrollBarInstance.Height = 95.6991f;
                            VerticalScrollBarInstance.Width = 9f;
                            VerticalScrollBarInstance.X = 86.12688f;
                            VerticalScrollBarInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                            VerticalScrollBarInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            VerticalScrollBarInstance.Y = 2.150794f;
                            CloseButton.Height = 5.154763f;
                            CloseButton.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            CloseButton.Width = 8.498107f;
                            CloseButton.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            CloseButton.X = 86.21427f;
                            CloseButton.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            CloseButton.Y = 6.849455f;
                            CloseButton.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            ClipContainerInstance.ClipsChildren = true;
                            ClipContainerInstance.Height = 91.2456f;
                            ClipContainerInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ClipContainerInstance.Width = 61.38469f;
                            ClipContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ClipContainerInstance.X = 15.61001f;
                            ClipContainerInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            ClipContainerInstance.Y = 4.222222f;
                            ClipContainerInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            SetProperty("EndingText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                            EndingText.FontScale = 0.6f;
                            EndingText.Height = 0f;
                            EndingText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "InnerPanelInstance") ?? this;
                            EndingText.Text = "";
                            EndingText.UseCustomFont = true;
                            EndingText.Width = 100f;
                            EndingText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
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
                bool setClipContainerInstanceHeightFirstValue = false;
                bool setClipContainerInstanceHeightSecondValue = false;
                float ClipContainerInstanceHeightFirstValue= 0;
                float ClipContainerInstanceHeightSecondValue= 0;
                bool setClipContainerInstanceWidthFirstValue = false;
                bool setClipContainerInstanceWidthSecondValue = false;
                float ClipContainerInstanceWidthFirstValue= 0;
                float ClipContainerInstanceWidthSecondValue= 0;
                bool setClipContainerInstanceXFirstValue = false;
                bool setClipContainerInstanceXSecondValue = false;
                float ClipContainerInstanceXFirstValue= 0;
                float ClipContainerInstanceXSecondValue= 0;
                bool setClipContainerInstanceYFirstValue = false;
                bool setClipContainerInstanceYSecondValue = false;
                float ClipContainerInstanceYFirstValue= 0;
                float ClipContainerInstanceYSecondValue= 0;
                bool setCloseButtonHeightFirstValue = false;
                bool setCloseButtonHeightSecondValue = false;
                float CloseButtonHeightFirstValue= 0;
                float CloseButtonHeightSecondValue= 0;
                bool setCloseButtonWidthFirstValue = false;
                bool setCloseButtonWidthSecondValue = false;
                float CloseButtonWidthFirstValue= 0;
                float CloseButtonWidthSecondValue= 0;
                bool setCloseButtonXFirstValue = false;
                bool setCloseButtonXSecondValue = false;
                float CloseButtonXFirstValue= 0;
                float CloseButtonXSecondValue= 0;
                bool setCloseButtonYFirstValue = false;
                bool setCloseButtonYSecondValue = false;
                float CloseButtonYFirstValue= 0;
                float CloseButtonYSecondValue= 0;
                bool setEndingTextFontScaleFirstValue = false;
                bool setEndingTextFontScaleSecondValue = false;
                float EndingTextFontScaleFirstValue= 0;
                float EndingTextFontScaleSecondValue= 0;
                bool setEndingTextHeightFirstValue = false;
                bool setEndingTextHeightSecondValue = false;
                float EndingTextHeightFirstValue= 0;
                float EndingTextHeightSecondValue= 0;
                bool setEndingTextWidthFirstValue = false;
                bool setEndingTextWidthSecondValue = false;
                float EndingTextWidthFirstValue= 0;
                float EndingTextWidthSecondValue= 0;
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setInnerPanelInstanceHeightFirstValue = false;
                bool setInnerPanelInstanceHeightSecondValue = false;
                float InnerPanelInstanceHeightFirstValue= 0;
                float InnerPanelInstanceHeightSecondValue= 0;
                bool setInnerPanelInstanceWidthFirstValue = false;
                bool setInnerPanelInstanceWidthSecondValue = false;
                float InnerPanelInstanceWidthFirstValue= 0;
                float InnerPanelInstanceWidthSecondValue= 0;
                bool setVerticalScrollBarInstanceHeightFirstValue = false;
                bool setVerticalScrollBarInstanceHeightSecondValue = false;
                float VerticalScrollBarInstanceHeightFirstValue= 0;
                float VerticalScrollBarInstanceHeightSecondValue= 0;
                bool setVerticalScrollBarInstanceWidthFirstValue = false;
                bool setVerticalScrollBarInstanceWidthSecondValue = false;
                float VerticalScrollBarInstanceWidthFirstValue= 0;
                float VerticalScrollBarInstanceWidthSecondValue= 0;
                bool setVerticalScrollBarInstanceXFirstValue = false;
                bool setVerticalScrollBarInstanceXSecondValue = false;
                float VerticalScrollBarInstanceXFirstValue= 0;
                float VerticalScrollBarInstanceXSecondValue= 0;
                bool setVerticalScrollBarInstanceYFirstValue = false;
                bool setVerticalScrollBarInstanceYSecondValue = false;
                float VerticalScrollBarInstanceYFirstValue= 0;
                float VerticalScrollBarInstanceYSecondValue= 0;
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        if (interpolationValue < 1)
                        {
                            this.ClipContainerInstance.ClipsChildren = true;
                        }
                        setClipContainerInstanceHeightFirstValue = true;
                        ClipContainerInstanceHeightFirstValue = 91.2456f;
                        if (interpolationValue < 1)
                        {
                            this.ClipContainerInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setClipContainerInstanceWidthFirstValue = true;
                        ClipContainerInstanceWidthFirstValue = 61.38469f;
                        if (interpolationValue < 1)
                        {
                            this.ClipContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setClipContainerInstanceXFirstValue = true;
                        ClipContainerInstanceXFirstValue = 15.61001f;
                        if (interpolationValue < 1)
                        {
                            this.ClipContainerInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setClipContainerInstanceYFirstValue = true;
                        ClipContainerInstanceYFirstValue = 4.222222f;
                        if (interpolationValue < 1)
                        {
                            this.ClipContainerInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setCloseButtonHeightFirstValue = true;
                        CloseButtonHeightFirstValue = 5.154763f;
                        if (interpolationValue < 1)
                        {
                            this.CloseButton.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setCloseButtonWidthFirstValue = true;
                        CloseButtonWidthFirstValue = 8.498107f;
                        if (interpolationValue < 1)
                        {
                            this.CloseButton.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setCloseButtonXFirstValue = true;
                        CloseButtonXFirstValue = 86.21427f;
                        if (interpolationValue < 1)
                        {
                            this.CloseButton.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setCloseButtonYFirstValue = true;
                        CloseButtonYFirstValue = 6.849455f;
                        if (interpolationValue < 1)
                        {
                            this.CloseButton.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("EndingText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setEndingTextFontScaleFirstValue = true;
                        EndingTextFontScaleFirstValue = 0.6f;
                        setEndingTextHeightFirstValue = true;
                        EndingTextHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.EndingText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "InnerPanelInstance") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.EndingText.Text = "";
                        }
                        if (interpolationValue < 1)
                        {
                            this.EndingText.UseCustomFont = true;
                        }
                        setEndingTextWidthFirstValue = true;
                        EndingTextWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.EndingText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setHeightFirstValue = true;
                        HeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.InnerPanelInstance.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setInnerPanelInstanceHeightFirstValue = true;
                        InnerPanelInstanceHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.InnerPanelInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue < 1)
                        {
                            this.InnerPanelInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ClipContainerInstance") ?? this;
                        }
                        setInnerPanelInstanceWidthFirstValue = true;
                        InnerPanelInstanceWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.InnerPanelInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setVerticalScrollBarInstanceHeightFirstValue = true;
                        VerticalScrollBarInstanceHeightFirstValue = 95.6991f;
                        setVerticalScrollBarInstanceWidthFirstValue = true;
                        VerticalScrollBarInstanceWidthFirstValue = 9f;
                        setVerticalScrollBarInstanceXFirstValue = true;
                        VerticalScrollBarInstanceXFirstValue = 86.12688f;
                        if (interpolationValue < 1)
                        {
                            this.VerticalScrollBarInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue < 1)
                        {
                            this.VerticalScrollBarInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setVerticalScrollBarInstanceYFirstValue = true;
                        VerticalScrollBarInstanceYFirstValue = 2.150794f;
                        setWidthFirstValue = true;
                        WidthFirstValue = 33f;
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
                            this.ClipContainerInstance.ClipsChildren = true;
                        }
                        setClipContainerInstanceHeightSecondValue = true;
                        ClipContainerInstanceHeightSecondValue = 91.2456f;
                        if (interpolationValue >= 1)
                        {
                            this.ClipContainerInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setClipContainerInstanceWidthSecondValue = true;
                        ClipContainerInstanceWidthSecondValue = 61.38469f;
                        if (interpolationValue >= 1)
                        {
                            this.ClipContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setClipContainerInstanceXSecondValue = true;
                        ClipContainerInstanceXSecondValue = 15.61001f;
                        if (interpolationValue >= 1)
                        {
                            this.ClipContainerInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setClipContainerInstanceYSecondValue = true;
                        ClipContainerInstanceYSecondValue = 4.222222f;
                        if (interpolationValue >= 1)
                        {
                            this.ClipContainerInstance.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setCloseButtonHeightSecondValue = true;
                        CloseButtonHeightSecondValue = 5.154763f;
                        if (interpolationValue >= 1)
                        {
                            this.CloseButton.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setCloseButtonWidthSecondValue = true;
                        CloseButtonWidthSecondValue = 8.498107f;
                        if (interpolationValue >= 1)
                        {
                            this.CloseButton.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setCloseButtonXSecondValue = true;
                        CloseButtonXSecondValue = 86.21427f;
                        if (interpolationValue >= 1)
                        {
                            this.CloseButton.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setCloseButtonYSecondValue = true;
                        CloseButtonYSecondValue = 6.849455f;
                        if (interpolationValue >= 1)
                        {
                            this.CloseButton.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("EndingText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setEndingTextFontScaleSecondValue = true;
                        EndingTextFontScaleSecondValue = 0.6f;
                        setEndingTextHeightSecondValue = true;
                        EndingTextHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.EndingText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "InnerPanelInstance") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.EndingText.Text = "";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.EndingText.UseCustomFont = true;
                        }
                        setEndingTextWidthSecondValue = true;
                        EndingTextWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.EndingText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setHeightSecondValue = true;
                        HeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.InnerPanelInstance.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setInnerPanelInstanceHeightSecondValue = true;
                        InnerPanelInstanceHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.InnerPanelInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.InnerPanelInstance.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ClipContainerInstance") ?? this;
                        }
                        setInnerPanelInstanceWidthSecondValue = true;
                        InnerPanelInstanceWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.InnerPanelInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setVerticalScrollBarInstanceHeightSecondValue = true;
                        VerticalScrollBarInstanceHeightSecondValue = 95.6991f;
                        setVerticalScrollBarInstanceWidthSecondValue = true;
                        VerticalScrollBarInstanceWidthSecondValue = 9f;
                        setVerticalScrollBarInstanceXSecondValue = true;
                        VerticalScrollBarInstanceXSecondValue = 86.12688f;
                        if (interpolationValue >= 1)
                        {
                            this.VerticalScrollBarInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.VerticalScrollBarInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setVerticalScrollBarInstanceYSecondValue = true;
                        VerticalScrollBarInstanceYSecondValue = 2.150794f;
                        setWidthSecondValue = true;
                        WidthSecondValue = 33f;
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
                if (setClipContainerInstanceHeightFirstValue && setClipContainerInstanceHeightSecondValue)
                {
                    ClipContainerInstance.Height = ClipContainerInstanceHeightFirstValue * (1 - interpolationValue) + ClipContainerInstanceHeightSecondValue * interpolationValue;
                }
                if (setClipContainerInstanceWidthFirstValue && setClipContainerInstanceWidthSecondValue)
                {
                    ClipContainerInstance.Width = ClipContainerInstanceWidthFirstValue * (1 - interpolationValue) + ClipContainerInstanceWidthSecondValue * interpolationValue;
                }
                if (setClipContainerInstanceXFirstValue && setClipContainerInstanceXSecondValue)
                {
                    ClipContainerInstance.X = ClipContainerInstanceXFirstValue * (1 - interpolationValue) + ClipContainerInstanceXSecondValue * interpolationValue;
                }
                if (setClipContainerInstanceYFirstValue && setClipContainerInstanceYSecondValue)
                {
                    ClipContainerInstance.Y = ClipContainerInstanceYFirstValue * (1 - interpolationValue) + ClipContainerInstanceYSecondValue * interpolationValue;
                }
                if (setCloseButtonHeightFirstValue && setCloseButtonHeightSecondValue)
                {
                    CloseButton.Height = CloseButtonHeightFirstValue * (1 - interpolationValue) + CloseButtonHeightSecondValue * interpolationValue;
                }
                if (setCloseButtonWidthFirstValue && setCloseButtonWidthSecondValue)
                {
                    CloseButton.Width = CloseButtonWidthFirstValue * (1 - interpolationValue) + CloseButtonWidthSecondValue * interpolationValue;
                }
                if (setCloseButtonXFirstValue && setCloseButtonXSecondValue)
                {
                    CloseButton.X = CloseButtonXFirstValue * (1 - interpolationValue) + CloseButtonXSecondValue * interpolationValue;
                }
                if (setCloseButtonYFirstValue && setCloseButtonYSecondValue)
                {
                    CloseButton.Y = CloseButtonYFirstValue * (1 - interpolationValue) + CloseButtonYSecondValue * interpolationValue;
                }
                if (setEndingTextFontScaleFirstValue && setEndingTextFontScaleSecondValue)
                {
                    EndingText.FontScale = EndingTextFontScaleFirstValue * (1 - interpolationValue) + EndingTextFontScaleSecondValue * interpolationValue;
                }
                if (setEndingTextHeightFirstValue && setEndingTextHeightSecondValue)
                {
                    EndingText.Height = EndingTextHeightFirstValue * (1 - interpolationValue) + EndingTextHeightSecondValue * interpolationValue;
                }
                if (setEndingTextWidthFirstValue && setEndingTextWidthSecondValue)
                {
                    EndingText.Width = EndingTextWidthFirstValue * (1 - interpolationValue) + EndingTextWidthSecondValue * interpolationValue;
                }
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
                }
                if (setInnerPanelInstanceHeightFirstValue && setInnerPanelInstanceHeightSecondValue)
                {
                    InnerPanelInstance.Height = InnerPanelInstanceHeightFirstValue * (1 - interpolationValue) + InnerPanelInstanceHeightSecondValue * interpolationValue;
                }
                if (setInnerPanelInstanceWidthFirstValue && setInnerPanelInstanceWidthSecondValue)
                {
                    InnerPanelInstance.Width = InnerPanelInstanceWidthFirstValue * (1 - interpolationValue) + InnerPanelInstanceWidthSecondValue * interpolationValue;
                }
                if (setVerticalScrollBarInstanceHeightFirstValue && setVerticalScrollBarInstanceHeightSecondValue)
                {
                    VerticalScrollBarInstance.Height = VerticalScrollBarInstanceHeightFirstValue * (1 - interpolationValue) + VerticalScrollBarInstanceHeightSecondValue * interpolationValue;
                }
                if (setVerticalScrollBarInstanceWidthFirstValue && setVerticalScrollBarInstanceWidthSecondValue)
                {
                    VerticalScrollBarInstance.Width = VerticalScrollBarInstanceWidthFirstValue * (1 - interpolationValue) + VerticalScrollBarInstanceWidthSecondValue * interpolationValue;
                }
                if (setVerticalScrollBarInstanceXFirstValue && setVerticalScrollBarInstanceXSecondValue)
                {
                    VerticalScrollBarInstance.X = VerticalScrollBarInstanceXFirstValue * (1 - interpolationValue) + VerticalScrollBarInstanceXSecondValue * interpolationValue;
                }
                if (setVerticalScrollBarInstanceYFirstValue && setVerticalScrollBarInstanceYSecondValue)
                {
                    VerticalScrollBarInstance.Y = VerticalScrollBarInstanceYFirstValue * (1 - interpolationValue) + VerticalScrollBarInstanceYSecondValue * interpolationValue;
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
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.ChatHistoryRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.ChatHistoryRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            #endregion
            #region State Animations
            #endregion
            public override void StopAnimations () 
            {
                base.StopAnimations();
                TallestInfoFrameInstance.StopAnimations();
                VerticalScrollBarInstance.StopAnimations();
                CloseButton.StopAnimations();
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
                            Name = "InnerPanelInstance.Children Layout",
                            Type = "ChildrenLayout",
                            Value = InnerPanelInstance.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InnerPanelInstance.Height",
                            Type = "float",
                            Value = InnerPanelInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InnerPanelInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = InnerPanelInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InnerPanelInstance.Parent",
                            Type = "string",
                            Value = InnerPanelInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InnerPanelInstance.Width",
                            Type = "float",
                            Value = InnerPanelInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InnerPanelInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = InnerPanelInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VerticalScrollBarInstance.Height",
                            Type = "float",
                            Value = VerticalScrollBarInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VerticalScrollBarInstance.Width",
                            Type = "float",
                            Value = VerticalScrollBarInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VerticalScrollBarInstance.X",
                            Type = "float",
                            Value = VerticalScrollBarInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VerticalScrollBarInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = VerticalScrollBarInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VerticalScrollBarInstance.X Units",
                            Type = "PositionUnitType",
                            Value = VerticalScrollBarInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VerticalScrollBarInstance.Y",
                            Type = "float",
                            Value = VerticalScrollBarInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseButton.Height",
                            Type = "float",
                            Value = CloseButton.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseButton.Height Units",
                            Type = "DimensionUnitType",
                            Value = CloseButton.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseButton.Width",
                            Type = "float",
                            Value = CloseButton.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseButton.Width Units",
                            Type = "DimensionUnitType",
                            Value = CloseButton.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseButton.X",
                            Type = "float",
                            Value = CloseButton.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseButton.X Units",
                            Type = "PositionUnitType",
                            Value = CloseButton.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseButton.Y",
                            Type = "float",
                            Value = CloseButton.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseButton.Y Units",
                            Type = "PositionUnitType",
                            Value = CloseButton.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.Clips Children",
                            Type = "bool",
                            Value = ClipContainerInstance.ClipsChildren
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.Height",
                            Type = "float",
                            Value = ClipContainerInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = ClipContainerInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.Width",
                            Type = "float",
                            Value = ClipContainerInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = ClipContainerInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.X",
                            Type = "float",
                            Value = ClipContainerInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.X Units",
                            Type = "PositionUnitType",
                            Value = ClipContainerInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.Y",
                            Type = "float",
                            Value = ClipContainerInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = ClipContainerInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EndingText.CustomFontFile",
                            Type = "string",
                            Value = EndingText.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EndingText.Font Scale",
                            Type = "float",
                            Value = EndingText.FontScale
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EndingText.Height",
                            Type = "float",
                            Value = EndingText.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EndingText.Parent",
                            Type = "string",
                            Value = EndingText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EndingText.Text",
                            Type = "string",
                            Value = EndingText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EndingText.UseCustomFont",
                            Type = "bool",
                            Value = EndingText.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EndingText.Width",
                            Type = "float",
                            Value = EndingText.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EndingText.Width Units",
                            Type = "DimensionUnitType",
                            Value = EndingText.WidthUnits
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
                            Value = Width + 33f
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
                            Name = "InnerPanelInstance.Children Layout",
                            Type = "ChildrenLayout",
                            Value = InnerPanelInstance.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InnerPanelInstance.Height",
                            Type = "float",
                            Value = InnerPanelInstance.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InnerPanelInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = InnerPanelInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InnerPanelInstance.Parent",
                            Type = "string",
                            Value = InnerPanelInstance.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InnerPanelInstance.Width",
                            Type = "float",
                            Value = InnerPanelInstance.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InnerPanelInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = InnerPanelInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VerticalScrollBarInstance.Height",
                            Type = "float",
                            Value = VerticalScrollBarInstance.Height + 95.6991f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VerticalScrollBarInstance.Width",
                            Type = "float",
                            Value = VerticalScrollBarInstance.Width + 9f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VerticalScrollBarInstance.X",
                            Type = "float",
                            Value = VerticalScrollBarInstance.X + 86.12688f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VerticalScrollBarInstance.X Origin",
                            Type = "HorizontalAlignment",
                            Value = VerticalScrollBarInstance.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VerticalScrollBarInstance.X Units",
                            Type = "PositionUnitType",
                            Value = VerticalScrollBarInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "VerticalScrollBarInstance.Y",
                            Type = "float",
                            Value = VerticalScrollBarInstance.Y + 2.150794f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseButton.Height",
                            Type = "float",
                            Value = CloseButton.Height + 5.154763f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseButton.Height Units",
                            Type = "DimensionUnitType",
                            Value = CloseButton.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseButton.Width",
                            Type = "float",
                            Value = CloseButton.Width + 8.498107f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseButton.Width Units",
                            Type = "DimensionUnitType",
                            Value = CloseButton.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseButton.X",
                            Type = "float",
                            Value = CloseButton.X + 86.21427f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseButton.X Units",
                            Type = "PositionUnitType",
                            Value = CloseButton.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseButton.Y",
                            Type = "float",
                            Value = CloseButton.Y + 6.849455f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CloseButton.Y Units",
                            Type = "PositionUnitType",
                            Value = CloseButton.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.Clips Children",
                            Type = "bool",
                            Value = ClipContainerInstance.ClipsChildren
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.Height",
                            Type = "float",
                            Value = ClipContainerInstance.Height + 91.2456f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = ClipContainerInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.Width",
                            Type = "float",
                            Value = ClipContainerInstance.Width + 61.38469f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = ClipContainerInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.X",
                            Type = "float",
                            Value = ClipContainerInstance.X + 15.61001f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.X Units",
                            Type = "PositionUnitType",
                            Value = ClipContainerInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.Y",
                            Type = "float",
                            Value = ClipContainerInstance.Y + 4.222222f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClipContainerInstance.Y Units",
                            Type = "PositionUnitType",
                            Value = ClipContainerInstance.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EndingText.CustomFontFile",
                            Type = "string",
                            Value = EndingText.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EndingText.Font Scale",
                            Type = "float",
                            Value = EndingText.FontScale + 0.6f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EndingText.Height",
                            Type = "float",
                            Value = EndingText.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EndingText.Parent",
                            Type = "string",
                            Value = EndingText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EndingText.Text",
                            Type = "string",
                            Value = EndingText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EndingText.UseCustomFont",
                            Type = "bool",
                            Value = EndingText.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EndingText.Width",
                            Type = "float",
                            Value = EndingText.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "EndingText.Width Units",
                            Type = "DimensionUnitType",
                            Value = EndingText.WidthUnits
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
                }
                base.ApplyState(state);
            }
            private bool tryCreateFormsObject;
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime InnerPanelInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.frames.TallestInfoFrameRuntime TallestInfoFrameInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.VerticalScrollBarRuntime VerticalScrollBarInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.specificbuttons.CloseChatButtonRuntime CloseButton { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime ClipContainerInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime EndingText { get; set; }
            public string EndingTextText
            {
                get
                {
                    return EndingText.Text;
                }
                set
                {
                    if (EndingText.Text != value)
                    {
                        EndingText.Text = value;
                        EndingTextTextChanged?.Invoke(this, null);
                    }
                }
            }
            public event System.EventHandler EndingTextTextChanged;
            public ChatHistoryRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                this.tryCreateFormsObject = tryCreateFormsObject;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "ChatHistory");
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
                InnerPanelInstance = this.GetGraphicalUiElementByName("InnerPanelInstance") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
                TallestInfoFrameInstance = this.GetGraphicalUiElementByName("TallestInfoFrameInstance") as AbbatoirIntergrade.GumRuntimes.frames.TallestInfoFrameRuntime;
                VerticalScrollBarInstance = this.GetGraphicalUiElementByName("VerticalScrollBarInstance") as AbbatoirIntergrade.GumRuntimes.VerticalScrollBarRuntime;
                CloseButton = this.GetGraphicalUiElementByName("CloseButton") as AbbatoirIntergrade.GumRuntimes.specificbuttons.CloseChatButtonRuntime;
                ClipContainerInstance = this.GetGraphicalUiElementByName("ClipContainerInstance") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
                EndingText = this.GetGraphicalUiElementByName("EndingText") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
                if (tryCreateFormsObject)
                {
                    FormsControl = new FlatRedBall.Forms.Controls.ScrollViewer(this);
                }
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
            public FlatRedBall.Forms.Controls.ScrollViewer FormsControl {get; private set;}
            public override object FormsControlAsObject { get { return FormsControl; } }
        }
    }
