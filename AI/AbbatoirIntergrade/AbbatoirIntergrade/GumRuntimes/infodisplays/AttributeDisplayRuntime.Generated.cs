    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes
    {
        public partial class AttributeDisplayRuntime : AbbatoirIntergrade.GumRuntimes.ContainerRuntime
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
                            ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                            Height = 100f;
                            HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            Width = 100f;
                            WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            AttributeIconInstance.Height = 0f;
                            AttributeIconInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            AttributeIconInstance.Width = 100f;
                            AttributeIconInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                            AttributeIconInstance.X = 5f;
                            AttributeIconInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            SetProperty("AttributeTextInstance.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                            AttributeTextInstance.Height = 0f;
                            AttributeTextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            AttributeTextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            AttributeTextInstance.Text = "100%";
                            AttributeTextInstance.UseCustomFont = true;
                            AttributeTextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            AttributeTextInstance.Width = 0f;
                            AttributeTextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            AttributeTextInstance.X = 10f;
                            AttributeTextInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
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
                bool setAttributeIconInstanceHeightFirstValue = false;
                bool setAttributeIconInstanceHeightSecondValue = false;
                float AttributeIconInstanceHeightFirstValue= 0;
                float AttributeIconInstanceHeightSecondValue= 0;
                bool setAttributeIconInstanceWidthFirstValue = false;
                bool setAttributeIconInstanceWidthSecondValue = false;
                float AttributeIconInstanceWidthFirstValue= 0;
                float AttributeIconInstanceWidthSecondValue= 0;
                bool setAttributeIconInstanceXFirstValue = false;
                bool setAttributeIconInstanceXSecondValue = false;
                float AttributeIconInstanceXFirstValue= 0;
                float AttributeIconInstanceXSecondValue= 0;
                bool setAttributeTextInstanceHeightFirstValue = false;
                bool setAttributeTextInstanceHeightSecondValue = false;
                float AttributeTextInstanceHeightFirstValue= 0;
                float AttributeTextInstanceHeightSecondValue= 0;
                bool setAttributeTextInstanceWidthFirstValue = false;
                bool setAttributeTextInstanceWidthSecondValue = false;
                float AttributeTextInstanceWidthFirstValue= 0;
                float AttributeTextInstanceWidthSecondValue= 0;
                bool setAttributeTextInstanceXFirstValue = false;
                bool setAttributeTextInstanceXSecondValue = false;
                float AttributeTextInstanceXFirstValue= 0;
                float AttributeTextInstanceXSecondValue= 0;
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setAttributeIconInstanceHeightFirstValue = true;
                        AttributeIconInstanceHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.AttributeIconInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setAttributeIconInstanceWidthFirstValue = true;
                        AttributeIconInstanceWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.AttributeIconInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        setAttributeIconInstanceXFirstValue = true;
                        AttributeIconInstanceXFirstValue = 5f;
                        if (interpolationValue < 1)
                        {
                            this.AttributeIconInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("AttributeTextInstance.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setAttributeTextInstanceHeightFirstValue = true;
                        AttributeTextInstanceHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.AttributeTextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.AttributeTextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.AttributeTextInstance.Text = "100%";
                        }
                        if (interpolationValue < 1)
                        {
                            this.AttributeTextInstance.UseCustomFont = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.AttributeTextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setAttributeTextInstanceWidthFirstValue = true;
                        AttributeTextInstanceWidthFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.AttributeTextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setAttributeTextInstanceXFirstValue = true;
                        AttributeTextInstanceXFirstValue = 10f;
                        if (interpolationValue < 1)
                        {
                            this.AttributeTextInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setHeightFirstValue = true;
                        HeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setWidthFirstValue = true;
                        WidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setAttributeIconInstanceHeightSecondValue = true;
                        AttributeIconInstanceHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.AttributeIconInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setAttributeIconInstanceWidthSecondValue = true;
                        AttributeIconInstanceWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.AttributeIconInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        setAttributeIconInstanceXSecondValue = true;
                        AttributeIconInstanceXSecondValue = 5f;
                        if (interpolationValue >= 1)
                        {
                            this.AttributeIconInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("AttributeTextInstance.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setAttributeTextInstanceHeightSecondValue = true;
                        AttributeTextInstanceHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.AttributeTextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.AttributeTextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.AttributeTextInstance.Text = "100%";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.AttributeTextInstance.UseCustomFont = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.AttributeTextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setAttributeTextInstanceWidthSecondValue = true;
                        AttributeTextInstanceWidthSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.AttributeTextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setAttributeTextInstanceXSecondValue = true;
                        AttributeTextInstanceXSecondValue = 10f;
                        if (interpolationValue >= 1)
                        {
                            this.AttributeTextInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setHeightSecondValue = true;
                        HeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setWidthSecondValue = true;
                        WidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        break;
                }
                if (setAttributeIconInstanceHeightFirstValue && setAttributeIconInstanceHeightSecondValue)
                {
                    AttributeIconInstance.Height = AttributeIconInstanceHeightFirstValue * (1 - interpolationValue) + AttributeIconInstanceHeightSecondValue * interpolationValue;
                }
                if (setAttributeIconInstanceWidthFirstValue && setAttributeIconInstanceWidthSecondValue)
                {
                    AttributeIconInstance.Width = AttributeIconInstanceWidthFirstValue * (1 - interpolationValue) + AttributeIconInstanceWidthSecondValue * interpolationValue;
                }
                if (setAttributeIconInstanceXFirstValue && setAttributeIconInstanceXSecondValue)
                {
                    AttributeIconInstance.X = AttributeIconInstanceXFirstValue * (1 - interpolationValue) + AttributeIconInstanceXSecondValue * interpolationValue;
                }
                if (setAttributeTextInstanceHeightFirstValue && setAttributeTextInstanceHeightSecondValue)
                {
                    AttributeTextInstance.Height = AttributeTextInstanceHeightFirstValue * (1 - interpolationValue) + AttributeTextInstanceHeightSecondValue * interpolationValue;
                }
                if (setAttributeTextInstanceWidthFirstValue && setAttributeTextInstanceWidthSecondValue)
                {
                    AttributeTextInstance.Width = AttributeTextInstanceWidthFirstValue * (1 - interpolationValue) + AttributeTextInstanceWidthSecondValue * interpolationValue;
                }
                if (setAttributeTextInstanceXFirstValue && setAttributeTextInstanceXSecondValue)
                {
                    AttributeTextInstance.X = AttributeTextInstanceXFirstValue * (1 - interpolationValue) + AttributeTextInstanceXSecondValue * interpolationValue;
                }
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.AttributeDisplayRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.AttributeDisplayRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
                AttributeIconInstance.StopAnimations();
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
                            Name = "AttributeIconInstance.Height",
                            Type = "float",
                            Value = AttributeIconInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = AttributeIconInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.Width",
                            Type = "float",
                            Value = AttributeIconInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = AttributeIconInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.X",
                            Type = "float",
                            Value = AttributeIconInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.X Units",
                            Type = "PositionUnitType",
                            Value = AttributeIconInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.CustomFontFile",
                            Type = "string",
                            Value = AttributeTextInstance.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.Height",
                            Type = "float",
                            Value = AttributeTextInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = AttributeTextInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = AttributeTextInstance.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.Text",
                            Type = "string",
                            Value = AttributeTextInstance.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.UseCustomFont",
                            Type = "bool",
                            Value = AttributeTextInstance.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = AttributeTextInstance.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.Width",
                            Type = "float",
                            Value = AttributeTextInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = AttributeTextInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.X",
                            Type = "float",
                            Value = AttributeTextInstance.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.X Units",
                            Type = "PositionUnitType",
                            Value = AttributeTextInstance.XUnits
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
                            Name = "AttributeIconInstance.Height",
                            Type = "float",
                            Value = AttributeIconInstance.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = AttributeIconInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.Width",
                            Type = "float",
                            Value = AttributeIconInstance.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = AttributeIconInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.X",
                            Type = "float",
                            Value = AttributeIconInstance.X + 5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeIconInstance.X Units",
                            Type = "PositionUnitType",
                            Value = AttributeIconInstance.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.CustomFontFile",
                            Type = "string",
                            Value = AttributeTextInstance.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.Height",
                            Type = "float",
                            Value = AttributeTextInstance.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = AttributeTextInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = AttributeTextInstance.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.Text",
                            Type = "string",
                            Value = AttributeTextInstance.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.UseCustomFont",
                            Type = "bool",
                            Value = AttributeTextInstance.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = AttributeTextInstance.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.Width",
                            Type = "float",
                            Value = AttributeTextInstance.Width + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = AttributeTextInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.X",
                            Type = "float",
                            Value = AttributeTextInstance.X + 10f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "AttributeTextInstance.X Units",
                            Type = "PositionUnitType",
                            Value = AttributeTextInstance.XUnits
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
            private AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime AttributeIconInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime AttributeTextInstance { get; set; }
            public AttributeIconRuntime.AttributeType AttributeIconTypeState
            {
                get
                {
                    return AttributeIconInstance.CurrentAttributeTypeState;
                }
                set
                {
                    if (AttributeIconInstance.CurrentAttributeTypeState != value)
                    {
                        AttributeIconInstance.CurrentAttributeTypeState = value;
                        AttributeIconTypeStateChanged?.Invoke(this, null);
                    }
                }
            }
            public float TextInstanceFontScale
            {
                get
                {
                    return AttributeTextInstance.FontScale;
                }
                set
                {
                    if (AttributeTextInstance.FontScale != value)
                    {
                        AttributeTextInstance.FontScale = value;
                        TextInstanceFontScaleChanged?.Invoke(this, null);
                    }
                }
            }
            public RenderingLibrary.Graphics.HorizontalAlignment TextInstanceHorizontalAlignment
            {
                get
                {
                    return AttributeTextInstance.HorizontalAlignment;
                }
                set
                {
                    if (AttributeTextInstance.HorizontalAlignment != value)
                    {
                        AttributeTextInstance.HorizontalAlignment = value;
                        TextInstanceHorizontalAlignmentChanged?.Invoke(this, null);
                    }
                }
            }
            public string AttributeText
            {
                get
                {
                    return AttributeTextInstance.Text;
                }
                set
                {
                    if (AttributeTextInstance.Text != value)
                    {
                        AttributeTextInstance.Text = value;
                        AttributeTextChanged?.Invoke(this, null);
                    }
                }
            }
            public event FlatRedBall.Gui.WindowEvent AttributeIconInstanceClick;
            public event System.EventHandler AttributeIconTypeStateChanged;
            public event System.EventHandler TextInstanceFontScaleChanged;
            public event System.EventHandler TextInstanceHorizontalAlignmentChanged;
            public event System.EventHandler AttributeTextChanged;
            public AttributeDisplayRuntime (bool fullInstantiation = true) 
            	: base(false)
            {
                this.HasEvents = false;
                this.ExposeChildrenEvents = true;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "infodisplays/AttributeDisplay");
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
                AttributeIconInstance = this.GetGraphicalUiElementByName("AttributeIconInstance") as AbbatoirIntergrade.GumRuntimes.AttributeIconRuntime;
                AttributeTextInstance = this.GetGraphicalUiElementByName("AttributeTextInstance") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
                AttributeIconInstance.Click += (unused) => AttributeIconInstanceClick?.Invoke(this);
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
