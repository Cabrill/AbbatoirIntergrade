    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes
    {
        public partial class TechnologyTreeRuntime : AbbatoirIntergrade.GumRuntimes.ContainerRuntime
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
                            ChildrenLayout = Gum.Managers.ChildrenLayout.Regular;
                            ClipsChildren = false;
                            Height = 90f;
                            HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            Visible = true;
                            Width = 90f;
                            WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            WrapsChildren = false;
                            XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            NineSliceInstance.Height = 100f;
                            NineSliceInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            NineSliceInstance.Width = 100f;
                            NineSliceInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            NineSliceInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            ContainerInstance.Height = 100f;
                            ContainerInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ContainerInstance.Width = 100f;
                            ContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            SetProperty("TitleText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                            TitleText.Height = 10f;
                            TitleText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            TitleText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            TitleText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ContainerInstance") ?? this;
                            TitleText.Text = "Technology Tree";
                            TitleText.UseCustomFont = true;
                            TitleText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            TitleText.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            TitleText.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            TitleText.Y = 2f;
                            TitleText.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                            TitleText.YUnits = Gum.Converters.GeneralUnitType.Percentage;
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
                bool setContainerInstanceHeightFirstValue = false;
                bool setContainerInstanceHeightSecondValue = false;
                float ContainerInstanceHeightFirstValue= 0;
                float ContainerInstanceHeightSecondValue= 0;
                bool setContainerInstanceWidthFirstValue = false;
                bool setContainerInstanceWidthSecondValue = false;
                float ContainerInstanceWidthFirstValue= 0;
                float ContainerInstanceWidthSecondValue= 0;
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setNineSliceInstanceHeightFirstValue = false;
                bool setNineSliceInstanceHeightSecondValue = false;
                float NineSliceInstanceHeightFirstValue= 0;
                float NineSliceInstanceHeightSecondValue= 0;
                bool setNineSliceInstanceWidthFirstValue = false;
                bool setNineSliceInstanceWidthSecondValue = false;
                float NineSliceInstanceWidthFirstValue= 0;
                float NineSliceInstanceWidthSecondValue= 0;
                bool setTitleTextHeightFirstValue = false;
                bool setTitleTextHeightSecondValue = false;
                float TitleTextHeightFirstValue= 0;
                float TitleTextHeightSecondValue= 0;
                bool setTitleTextYFirstValue = false;
                bool setTitleTextYSecondValue = false;
                float TitleTextYFirstValue= 0;
                float TitleTextYSecondValue= 0;
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
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
                        setContainerInstanceHeightFirstValue = true;
                        ContainerInstanceHeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.ContainerInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setContainerInstanceWidthFirstValue = true;
                        ContainerInstanceWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.ContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setHeightFirstValue = true;
                        HeightFirstValue = 90f;
                        if (interpolationValue < 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setNineSliceInstanceHeightFirstValue = true;
                        NineSliceInstanceHeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.NineSliceInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setNineSliceInstanceWidthFirstValue = true;
                        NineSliceInstanceWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.NineSliceInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.NineSliceInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("TitleText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setTitleTextHeightFirstValue = true;
                        TitleTextHeightFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.TitleText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TitleText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TitleText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ContainerInstance") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TitleText.Text = "Technology Tree";
                        }
                        if (interpolationValue < 1)
                        {
                            this.TitleText.UseCustomFont = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TitleText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TitleText.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TitleText.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setTitleTextYFirstValue = true;
                        TitleTextYFirstValue = 2f;
                        if (interpolationValue < 1)
                        {
                            this.TitleText.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue < 1)
                        {
                            this.TitleText.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.Visible = true;
                        }
                        setWidthFirstValue = true;
                        WidthFirstValue = 90f;
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
                        if (interpolationValue < 1)
                        {
                            this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
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
                        setContainerInstanceHeightSecondValue = true;
                        ContainerInstanceHeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.ContainerInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setContainerInstanceWidthSecondValue = true;
                        ContainerInstanceWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.ContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setHeightSecondValue = true;
                        HeightSecondValue = 90f;
                        if (interpolationValue >= 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setNineSliceInstanceHeightSecondValue = true;
                        NineSliceInstanceHeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.NineSliceInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setNineSliceInstanceWidthSecondValue = true;
                        NineSliceInstanceWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.NineSliceInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.NineSliceInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("TitleText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setTitleTextHeightSecondValue = true;
                        TitleTextHeightSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.TitleText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TitleText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TitleText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ContainerInstance") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TitleText.Text = "Technology Tree";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TitleText.UseCustomFont = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TitleText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TitleText.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TitleText.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setTitleTextYSecondValue = true;
                        TitleTextYSecondValue = 2f;
                        if (interpolationValue >= 1)
                        {
                            this.TitleText.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TitleText.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.Visible = true;
                        }
                        setWidthSecondValue = true;
                        WidthSecondValue = 90f;
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
                        if (interpolationValue >= 1)
                        {
                            this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        break;
                }
                if (setContainerInstanceHeightFirstValue && setContainerInstanceHeightSecondValue)
                {
                    ContainerInstance.Height = ContainerInstanceHeightFirstValue * (1 - interpolationValue) + ContainerInstanceHeightSecondValue * interpolationValue;
                }
                if (setContainerInstanceWidthFirstValue && setContainerInstanceWidthSecondValue)
                {
                    ContainerInstance.Width = ContainerInstanceWidthFirstValue * (1 - interpolationValue) + ContainerInstanceWidthSecondValue * interpolationValue;
                }
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
                }
                if (setNineSliceInstanceHeightFirstValue && setNineSliceInstanceHeightSecondValue)
                {
                    NineSliceInstance.Height = NineSliceInstanceHeightFirstValue * (1 - interpolationValue) + NineSliceInstanceHeightSecondValue * interpolationValue;
                }
                if (setNineSliceInstanceWidthFirstValue && setNineSliceInstanceWidthSecondValue)
                {
                    NineSliceInstance.Width = NineSliceInstanceWidthFirstValue * (1 - interpolationValue) + NineSliceInstanceWidthSecondValue * interpolationValue;
                }
                if (setTitleTextHeightFirstValue && setTitleTextHeightSecondValue)
                {
                    TitleText.Height = TitleTextHeightFirstValue * (1 - interpolationValue) + TitleTextHeightSecondValue * interpolationValue;
                }
                if (setTitleTextYFirstValue && setTitleTextYSecondValue)
                {
                    TitleText.Y = TitleTextYFirstValue * (1 - interpolationValue) + TitleTextYSecondValue * interpolationValue;
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.TechnologyTreeRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.TechnologyTreeRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
                            Name = "NineSliceInstance.Height",
                            Type = "float",
                            Value = NineSliceInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = NineSliceInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Width",
                            Type = "float",
                            Value = NineSliceInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = NineSliceInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.X Units",
                            Type = "PositionUnitType",
                            Value = NineSliceInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Height",
                            Type = "float",
                            Value = ContainerInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = ContainerInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Width",
                            Type = "float",
                            Value = ContainerInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = ContainerInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TitleText.CustomFontFile",
                            Type = "string",
                            Value = TitleText.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TitleText.Height",
                            Type = "float",
                            Value = TitleText.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TitleText.Height Units",
                            Type = "DimensionUnitType",
                            Value = TitleText.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TitleText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = TitleText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TitleText.Parent",
                            Type = "string",
                            Value = TitleText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TitleText.Text",
                            Type = "string",
                            Value = TitleText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TitleText.UseCustomFont",
                            Type = "bool",
                            Value = TitleText.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TitleText.Width Units",
                            Type = "DimensionUnitType",
                            Value = TitleText.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TitleText.X Origin",
                            Type = "HorizontalAlignment",
                            Value = TitleText.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TitleText.X Units",
                            Type = "PositionUnitType",
                            Value = TitleText.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TitleText.Y",
                            Type = "float",
                            Value = TitleText.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TitleText.Y Origin",
                            Type = "VerticalAlignment",
                            Value = TitleText.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TitleText.Y Units",
                            Type = "PositionUnitType",
                            Value = TitleText.YUnits
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
                            Value = Height + 90f
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
                            Value = Width + 90f
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
                            Name = "NineSliceInstance.Height",
                            Type = "float",
                            Value = NineSliceInstance.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = NineSliceInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Width",
                            Type = "float",
                            Value = NineSliceInstance.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = NineSliceInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NineSliceInstance.X Units",
                            Type = "PositionUnitType",
                            Value = NineSliceInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Height",
                            Type = "float",
                            Value = ContainerInstance.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = ContainerInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Width",
                            Type = "float",
                            Value = ContainerInstance.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContainerInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = ContainerInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TitleText.CustomFontFile",
                            Type = "string",
                            Value = TitleText.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TitleText.Height",
                            Type = "float",
                            Value = TitleText.Height + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TitleText.Height Units",
                            Type = "DimensionUnitType",
                            Value = TitleText.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TitleText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = TitleText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TitleText.Parent",
                            Type = "string",
                            Value = TitleText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TitleText.Text",
                            Type = "string",
                            Value = TitleText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TitleText.UseCustomFont",
                            Type = "bool",
                            Value = TitleText.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TitleText.Width Units",
                            Type = "DimensionUnitType",
                            Value = TitleText.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TitleText.X Origin",
                            Type = "HorizontalAlignment",
                            Value = TitleText.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TitleText.X Units",
                            Type = "PositionUnitType",
                            Value = TitleText.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TitleText.Y",
                            Type = "float",
                            Value = TitleText.Y + 2f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TitleText.Y Origin",
                            Type = "VerticalAlignment",
                            Value = TitleText.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TitleText.Y Units",
                            Type = "PositionUnitType",
                            Value = TitleText.YUnits
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
            private AbbatoirIntergrade.GumRuntimes.NineSliceRuntime NineSliceInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime ContainerInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime TitleText { get; set; }
            public event FlatRedBall.Gui.WindowEvent ContainerInstanceClick;
            public TechnologyTreeRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                this.HasEvents = true;
                this.ExposeChildrenEvents = true;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "TechnologyTree");
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
                NineSliceInstance = this.GetGraphicalUiElementByName("NineSliceInstance") as AbbatoirIntergrade.GumRuntimes.NineSliceRuntime;
                ContainerInstance = this.GetGraphicalUiElementByName("ContainerInstance") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
                TitleText = this.GetGraphicalUiElementByName("TitleText") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
                ContainerInstance.Click += (unused) => ContainerInstanceClick?.Invoke(this);
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
