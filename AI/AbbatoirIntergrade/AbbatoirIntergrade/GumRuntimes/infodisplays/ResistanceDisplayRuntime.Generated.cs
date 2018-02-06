    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes
    {
        public partial class ResistanceDisplayRuntime : AbbatoirIntergrade.GumRuntimes.ContainerRuntime
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
                            DamageTypeIconInstance.Height = 0f;
                            DamageTypeIconInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            DamageTypeIconInstance.Width = 100f;
                            DamageTypeIconInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                            SetProperty("ResistanceTextInstance.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                            ResistanceTextInstance.FontScale = 0.5f;
                            ResistanceTextInstance.Height = 0f;
                            ResistanceTextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                            ResistanceTextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            ResistanceTextInstance.Text = "100%";
                            ResistanceTextInstance.UseCustomFont = true;
                            ResistanceTextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            ResistanceTextInstance.Width = 80f;
                            ResistanceTextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
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
                bool setDamageTypeIconInstanceHeightFirstValue = false;
                bool setDamageTypeIconInstanceHeightSecondValue = false;
                float DamageTypeIconInstanceHeightFirstValue= 0;
                float DamageTypeIconInstanceHeightSecondValue= 0;
                bool setDamageTypeIconInstanceWidthFirstValue = false;
                bool setDamageTypeIconInstanceWidthSecondValue = false;
                float DamageTypeIconInstanceWidthFirstValue= 0;
                float DamageTypeIconInstanceWidthSecondValue= 0;
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setResistanceTextInstanceFontScaleFirstValue = false;
                bool setResistanceTextInstanceFontScaleSecondValue = false;
                float ResistanceTextInstanceFontScaleFirstValue= 0;
                float ResistanceTextInstanceFontScaleSecondValue= 0;
                bool setResistanceTextInstanceHeightFirstValue = false;
                bool setResistanceTextInstanceHeightSecondValue = false;
                float ResistanceTextInstanceHeightFirstValue= 0;
                float ResistanceTextInstanceHeightSecondValue= 0;
                bool setResistanceTextInstanceWidthFirstValue = false;
                bool setResistanceTextInstanceWidthSecondValue = false;
                float ResistanceTextInstanceWidthFirstValue= 0;
                float ResistanceTextInstanceWidthSecondValue= 0;
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        if (interpolationValue < 1)
                        {
                            this.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setDamageTypeIconInstanceHeightFirstValue = true;
                        DamageTypeIconInstanceHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.DamageTypeIconInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setDamageTypeIconInstanceWidthFirstValue = true;
                        DamageTypeIconInstanceWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.DamageTypeIconInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        setHeightFirstValue = true;
                        HeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("ResistanceTextInstance.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setResistanceTextInstanceFontScaleFirstValue = true;
                        ResistanceTextInstanceFontScaleFirstValue = 0.5f;
                        setResistanceTextInstanceHeightFirstValue = true;
                        ResistanceTextInstanceHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ResistanceTextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ResistanceTextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ResistanceTextInstance.Text = "100%";
                        }
                        if (interpolationValue < 1)
                        {
                            this.ResistanceTextInstance.UseCustomFont = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ResistanceTextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setResistanceTextInstanceWidthFirstValue = true;
                        ResistanceTextInstanceWidthFirstValue = 80f;
                        if (interpolationValue < 1)
                        {
                            this.ResistanceTextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
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
                        if (interpolationValue >= 1)
                        {
                            this.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setDamageTypeIconInstanceHeightSecondValue = true;
                        DamageTypeIconInstanceHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.DamageTypeIconInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        setDamageTypeIconInstanceWidthSecondValue = true;
                        DamageTypeIconInstanceWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.DamageTypeIconInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.PercentageOfOtherDimension;
                        }
                        setHeightSecondValue = true;
                        HeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("ResistanceTextInstance.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setResistanceTextInstanceFontScaleSecondValue = true;
                        ResistanceTextInstanceFontScaleSecondValue = 0.5f;
                        setResistanceTextInstanceHeightSecondValue = true;
                        ResistanceTextInstanceHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ResistanceTextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ResistanceTextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ResistanceTextInstance.Text = "100%";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ResistanceTextInstance.UseCustomFont = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ResistanceTextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setResistanceTextInstanceWidthSecondValue = true;
                        ResistanceTextInstanceWidthSecondValue = 80f;
                        if (interpolationValue >= 1)
                        {
                            this.ResistanceTextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setWidthSecondValue = true;
                        WidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        break;
                }
                if (setDamageTypeIconInstanceHeightFirstValue && setDamageTypeIconInstanceHeightSecondValue)
                {
                    DamageTypeIconInstance.Height = DamageTypeIconInstanceHeightFirstValue * (1 - interpolationValue) + DamageTypeIconInstanceHeightSecondValue * interpolationValue;
                }
                if (setDamageTypeIconInstanceWidthFirstValue && setDamageTypeIconInstanceWidthSecondValue)
                {
                    DamageTypeIconInstance.Width = DamageTypeIconInstanceWidthFirstValue * (1 - interpolationValue) + DamageTypeIconInstanceWidthSecondValue * interpolationValue;
                }
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
                }
                if (setResistanceTextInstanceFontScaleFirstValue && setResistanceTextInstanceFontScaleSecondValue)
                {
                    ResistanceTextInstance.FontScale = ResistanceTextInstanceFontScaleFirstValue * (1 - interpolationValue) + ResistanceTextInstanceFontScaleSecondValue * interpolationValue;
                }
                if (setResistanceTextInstanceHeightFirstValue && setResistanceTextInstanceHeightSecondValue)
                {
                    ResistanceTextInstance.Height = ResistanceTextInstanceHeightFirstValue * (1 - interpolationValue) + ResistanceTextInstanceHeightSecondValue * interpolationValue;
                }
                if (setResistanceTextInstanceWidthFirstValue && setResistanceTextInstanceWidthSecondValue)
                {
                    ResistanceTextInstance.Width = ResistanceTextInstanceWidthFirstValue * (1 - interpolationValue) + ResistanceTextInstanceWidthSecondValue * interpolationValue;
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.ResistanceDisplayRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.ResistanceDisplayRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
                DamageTypeIconInstance.StopAnimations();
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
                            Name = "DamageTypeIconInstance.Height",
                            Type = "float",
                            Value = DamageTypeIconInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DamageTypeIconInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = DamageTypeIconInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DamageTypeIconInstance.Width",
                            Type = "float",
                            Value = DamageTypeIconInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DamageTypeIconInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = DamageTypeIconInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceTextInstance.CustomFontFile",
                            Type = "string",
                            Value = ResistanceTextInstance.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceTextInstance.Font Scale",
                            Type = "float",
                            Value = ResistanceTextInstance.FontScale
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceTextInstance.Height",
                            Type = "float",
                            Value = ResistanceTextInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceTextInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = ResistanceTextInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceTextInstance.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = ResistanceTextInstance.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceTextInstance.Text",
                            Type = "string",
                            Value = ResistanceTextInstance.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceTextInstance.UseCustomFont",
                            Type = "bool",
                            Value = ResistanceTextInstance.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceTextInstance.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = ResistanceTextInstance.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceTextInstance.Width",
                            Type = "float",
                            Value = ResistanceTextInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceTextInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = ResistanceTextInstance.WidthUnits
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
                            Name = "DamageTypeIconInstance.Height",
                            Type = "float",
                            Value = DamageTypeIconInstance.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DamageTypeIconInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = DamageTypeIconInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DamageTypeIconInstance.Width",
                            Type = "float",
                            Value = DamageTypeIconInstance.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "DamageTypeIconInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = DamageTypeIconInstance.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceTextInstance.CustomFontFile",
                            Type = "string",
                            Value = ResistanceTextInstance.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceTextInstance.Font Scale",
                            Type = "float",
                            Value = ResistanceTextInstance.FontScale + 0.5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceTextInstance.Height",
                            Type = "float",
                            Value = ResistanceTextInstance.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceTextInstance.Height Units",
                            Type = "DimensionUnitType",
                            Value = ResistanceTextInstance.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceTextInstance.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = ResistanceTextInstance.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceTextInstance.Text",
                            Type = "string",
                            Value = ResistanceTextInstance.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceTextInstance.UseCustomFont",
                            Type = "bool",
                            Value = ResistanceTextInstance.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceTextInstance.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = ResistanceTextInstance.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceTextInstance.Width",
                            Type = "float",
                            Value = ResistanceTextInstance.Width + 80f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceTextInstance.Width Units",
                            Type = "DimensionUnitType",
                            Value = ResistanceTextInstance.WidthUnits
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
            private AbbatoirIntergrade.GumRuntimes.DamageTypeIconRuntime DamageTypeIconInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime ResistanceTextInstance { get; set; }
            public DamageTypeIconRuntime.DamageType DamageTypeIconState
            {
                get
                {
                    return DamageTypeIconInstance.CurrentDamageTypeState;
                }
                set
                {
                    if (DamageTypeIconInstance.CurrentDamageTypeState != value)
                    {
                        DamageTypeIconInstance.CurrentDamageTypeState = value;
                        DamageTypeIconStateChanged?.Invoke(this, null);
                    }
                }
            }
            public float TextFontScale
            {
                get
                {
                    return ResistanceTextInstance.FontScale;
                }
                set
                {
                    if (ResistanceTextInstance.FontScale != value)
                    {
                        ResistanceTextInstance.FontScale = value;
                        TextFontScaleChanged?.Invoke(this, null);
                    }
                }
            }
            public RenderingLibrary.Graphics.HorizontalAlignment TextHorizontalAlignment
            {
                get
                {
                    return ResistanceTextInstance.HorizontalAlignment;
                }
                set
                {
                    if (ResistanceTextInstance.HorizontalAlignment != value)
                    {
                        ResistanceTextInstance.HorizontalAlignment = value;
                        TextHorizontalAlignmentChanged?.Invoke(this, null);
                    }
                }
            }
            public string ResistanceText
            {
                get
                {
                    return ResistanceTextInstance.Text;
                }
                set
                {
                    if (ResistanceTextInstance.Text != value)
                    {
                        ResistanceTextInstance.Text = value;
                        ResistanceTextChanged?.Invoke(this, null);
                    }
                }
            }
            public event FlatRedBall.Gui.WindowEvent DamageTypeIconInstanceClick;
            public event System.EventHandler DamageTypeIconStateChanged;
            public event System.EventHandler TextFontScaleChanged;
            public event System.EventHandler TextHorizontalAlignmentChanged;
            public event System.EventHandler ResistanceTextChanged;
            public ResistanceDisplayRuntime (bool fullInstantiation = true) 
            	: base(false)
            {
                this.HasEvents = false;
                this.ExposeChildrenEvents = true;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "infodisplays/ResistanceDisplay");
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
                DamageTypeIconInstance = this.GetGraphicalUiElementByName("DamageTypeIconInstance") as AbbatoirIntergrade.GumRuntimes.DamageTypeIconRuntime;
                ResistanceTextInstance = this.GetGraphicalUiElementByName("ResistanceTextInstance") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
                DamageTypeIconInstance.Click += (unused) => DamageTypeIconInstanceClick?.Invoke(this);
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
