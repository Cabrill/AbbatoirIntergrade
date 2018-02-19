    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes
    {
        public partial class OptionsControlsRuntime : AbbatoirIntergrade.GumRuntimes.ContainerRuntime
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
                            ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                            Height = 50f;
                            HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            Width = 50f;
                            WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            WrapsChildren = true;
                            SetProperty("SoundText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                            SoundText.FontScale = 1f;
                            SoundText.Height = 20f;
                            SoundText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            SoundText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "NamesContainer");
                            SoundText.Text = "Sound Volume";
                            SoundText.UseCustomFont = true;
                            SoundText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            SoundText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            NamesContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                            NamesContainer.Height = 100f;
                            NamesContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            NamesContainer.Width = 50f;
                            NamesContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            SoundSlider.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "OptionContainer");
                            OptionContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                            OptionContainer.Height = 100f;
                            OptionContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            OptionContainer.Width = 50f;
                            OptionContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            SetProperty("MusicText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                            MusicText.FontScale = 1f;
                            MusicText.Height = 20f;
                            MusicText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            MusicText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "NamesContainer");
                            MusicText.Text = "Music Volume";
                            MusicText.UseCustomFont = true;
                            MusicText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            MusicText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            MusicSlider.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "OptionContainer");
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
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setMusicTextFontScaleFirstValue = false;
                bool setMusicTextFontScaleSecondValue = false;
                float MusicTextFontScaleFirstValue= 0;
                float MusicTextFontScaleSecondValue= 0;
                bool setMusicTextHeightFirstValue = false;
                bool setMusicTextHeightSecondValue = false;
                float MusicTextHeightFirstValue= 0;
                float MusicTextHeightSecondValue= 0;
                bool setNamesContainerHeightFirstValue = false;
                bool setNamesContainerHeightSecondValue = false;
                float NamesContainerHeightFirstValue= 0;
                float NamesContainerHeightSecondValue= 0;
                bool setNamesContainerWidthFirstValue = false;
                bool setNamesContainerWidthSecondValue = false;
                float NamesContainerWidthFirstValue= 0;
                float NamesContainerWidthSecondValue= 0;
                bool setOptionContainerHeightFirstValue = false;
                bool setOptionContainerHeightSecondValue = false;
                float OptionContainerHeightFirstValue= 0;
                float OptionContainerHeightSecondValue= 0;
                bool setOptionContainerWidthFirstValue = false;
                bool setOptionContainerWidthSecondValue = false;
                float OptionContainerWidthFirstValue= 0;
                float OptionContainerWidthSecondValue= 0;
                bool setSoundTextFontScaleFirstValue = false;
                bool setSoundTextFontScaleSecondValue = false;
                float SoundTextFontScaleFirstValue= 0;
                float SoundTextFontScaleSecondValue= 0;
                bool setSoundTextHeightFirstValue = false;
                bool setSoundTextHeightSecondValue = false;
                float SoundTextHeightFirstValue= 0;
                float SoundTextHeightSecondValue= 0;
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        if (interpolationValue < 1)
                        {
                            this.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setHeightFirstValue = true;
                        HeightFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MusicSlider.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "OptionContainer");
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("MusicText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setMusicTextFontScaleFirstValue = true;
                        MusicTextFontScaleFirstValue = 1f;
                        setMusicTextHeightFirstValue = true;
                        MusicTextHeightFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.MusicText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MusicText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "NamesContainer");
                        }
                        if (interpolationValue < 1)
                        {
                            this.MusicText.Text = "Music Volume";
                        }
                        if (interpolationValue < 1)
                        {
                            this.MusicText.UseCustomFont = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MusicText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MusicText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.NamesContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setNamesContainerHeightFirstValue = true;
                        NamesContainerHeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.NamesContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setNamesContainerWidthFirstValue = true;
                        NamesContainerWidthFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.NamesContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.OptionContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setOptionContainerHeightFirstValue = true;
                        OptionContainerHeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.OptionContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setOptionContainerWidthFirstValue = true;
                        OptionContainerWidthFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.OptionContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SoundSlider.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "OptionContainer");
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("SoundText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setSoundTextFontScaleFirstValue = true;
                        SoundTextFontScaleFirstValue = 1f;
                        setSoundTextHeightFirstValue = true;
                        SoundTextHeightFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.SoundText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SoundText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "NamesContainer");
                        }
                        if (interpolationValue < 1)
                        {
                            this.SoundText.Text = "Sound Volume";
                        }
                        if (interpolationValue < 1)
                        {
                            this.SoundText.UseCustomFont = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SoundText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SoundText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setWidthFirstValue = true;
                        WidthFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.WrapsChildren = true;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        if (interpolationValue >= 1)
                        {
                            this.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setHeightSecondValue = true;
                        HeightSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MusicSlider.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "OptionContainer");
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("MusicText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setMusicTextFontScaleSecondValue = true;
                        MusicTextFontScaleSecondValue = 1f;
                        setMusicTextHeightSecondValue = true;
                        MusicTextHeightSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.MusicText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MusicText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "NamesContainer");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MusicText.Text = "Music Volume";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MusicText.UseCustomFont = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MusicText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MusicText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.NamesContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setNamesContainerHeightSecondValue = true;
                        NamesContainerHeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.NamesContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setNamesContainerWidthSecondValue = true;
                        NamesContainerWidthSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.NamesContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.OptionContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setOptionContainerHeightSecondValue = true;
                        OptionContainerHeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.OptionContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setOptionContainerWidthSecondValue = true;
                        OptionContainerWidthSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.OptionContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SoundSlider.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "OptionContainer");
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("SoundText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setSoundTextFontScaleSecondValue = true;
                        SoundTextFontScaleSecondValue = 1f;
                        setSoundTextHeightSecondValue = true;
                        SoundTextHeightSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.SoundText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SoundText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "NamesContainer");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SoundText.Text = "Sound Volume";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SoundText.UseCustomFont = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SoundText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SoundText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setWidthSecondValue = true;
                        WidthSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.WrapsChildren = true;
                        }
                        break;
                }
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
                }
                if (setMusicTextFontScaleFirstValue && setMusicTextFontScaleSecondValue)
                {
                    MusicText.FontScale = MusicTextFontScaleFirstValue * (1 - interpolationValue) + MusicTextFontScaleSecondValue * interpolationValue;
                }
                if (setMusicTextHeightFirstValue && setMusicTextHeightSecondValue)
                {
                    MusicText.Height = MusicTextHeightFirstValue * (1 - interpolationValue) + MusicTextHeightSecondValue * interpolationValue;
                }
                if (setNamesContainerHeightFirstValue && setNamesContainerHeightSecondValue)
                {
                    NamesContainer.Height = NamesContainerHeightFirstValue * (1 - interpolationValue) + NamesContainerHeightSecondValue * interpolationValue;
                }
                if (setNamesContainerWidthFirstValue && setNamesContainerWidthSecondValue)
                {
                    NamesContainer.Width = NamesContainerWidthFirstValue * (1 - interpolationValue) + NamesContainerWidthSecondValue * interpolationValue;
                }
                if (setOptionContainerHeightFirstValue && setOptionContainerHeightSecondValue)
                {
                    OptionContainer.Height = OptionContainerHeightFirstValue * (1 - interpolationValue) + OptionContainerHeightSecondValue * interpolationValue;
                }
                if (setOptionContainerWidthFirstValue && setOptionContainerWidthSecondValue)
                {
                    OptionContainer.Width = OptionContainerWidthFirstValue * (1 - interpolationValue) + OptionContainerWidthSecondValue * interpolationValue;
                }
                if (setSoundTextFontScaleFirstValue && setSoundTextFontScaleSecondValue)
                {
                    SoundText.FontScale = SoundTextFontScaleFirstValue * (1 - interpolationValue) + SoundTextFontScaleSecondValue * interpolationValue;
                }
                if (setSoundTextHeightFirstValue && setSoundTextHeightSecondValue)
                {
                    SoundText.Height = SoundTextHeightFirstValue * (1 - interpolationValue) + SoundTextHeightSecondValue * interpolationValue;
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.OptionsControlsRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.OptionsControlsRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
                SoundSlider.StopAnimations();
                MusicSlider.StopAnimations();
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
                            Name = "Wraps Children",
                            Type = "bool",
                            Value = WrapsChildren
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoundText.CustomFontFile",
                            Type = "string",
                            Value = SoundText.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoundText.Font Scale",
                            Type = "float",
                            Value = SoundText.FontScale
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoundText.Height",
                            Type = "float",
                            Value = SoundText.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoundText.Height Units",
                            Type = "DimensionUnitType",
                            Value = SoundText.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoundText.Parent",
                            Type = "string",
                            Value = SoundText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoundText.Text",
                            Type = "string",
                            Value = SoundText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoundText.UseCustomFont",
                            Type = "bool",
                            Value = SoundText.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoundText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = SoundText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoundText.Width Units",
                            Type = "DimensionUnitType",
                            Value = SoundText.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NamesContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = NamesContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NamesContainer.Height",
                            Type = "float",
                            Value = NamesContainer.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NamesContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = NamesContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NamesContainer.Width",
                            Type = "float",
                            Value = NamesContainer.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NamesContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = NamesContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoundSlider.Parent",
                            Type = "string",
                            Value = SoundSlider.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = OptionContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionContainer.Height",
                            Type = "float",
                            Value = OptionContainer.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = OptionContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionContainer.Width",
                            Type = "float",
                            Value = OptionContainer.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = OptionContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicText.CustomFontFile",
                            Type = "string",
                            Value = MusicText.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicText.Font Scale",
                            Type = "float",
                            Value = MusicText.FontScale
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicText.Height",
                            Type = "float",
                            Value = MusicText.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicText.Height Units",
                            Type = "DimensionUnitType",
                            Value = MusicText.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicText.Parent",
                            Type = "string",
                            Value = MusicText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicText.Text",
                            Type = "string",
                            Value = MusicText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicText.UseCustomFont",
                            Type = "bool",
                            Value = MusicText.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = MusicText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicText.Width Units",
                            Type = "DimensionUnitType",
                            Value = MusicText.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicSlider.Parent",
                            Type = "string",
                            Value = MusicSlider.Parent
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
                            Name = "Wraps Children",
                            Type = "bool",
                            Value = WrapsChildren
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoundText.CustomFontFile",
                            Type = "string",
                            Value = SoundText.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoundText.Font Scale",
                            Type = "float",
                            Value = SoundText.FontScale + 1f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoundText.Height",
                            Type = "float",
                            Value = SoundText.Height + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoundText.Height Units",
                            Type = "DimensionUnitType",
                            Value = SoundText.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoundText.Parent",
                            Type = "string",
                            Value = SoundText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoundText.Text",
                            Type = "string",
                            Value = SoundText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoundText.UseCustomFont",
                            Type = "bool",
                            Value = SoundText.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoundText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = SoundText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoundText.Width Units",
                            Type = "DimensionUnitType",
                            Value = SoundText.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NamesContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = NamesContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NamesContainer.Height",
                            Type = "float",
                            Value = NamesContainer.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NamesContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = NamesContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NamesContainer.Width",
                            Type = "float",
                            Value = NamesContainer.Width + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NamesContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = NamesContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SoundSlider.Parent",
                            Type = "string",
                            Value = SoundSlider.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = OptionContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionContainer.Height",
                            Type = "float",
                            Value = OptionContainer.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = OptionContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionContainer.Width",
                            Type = "float",
                            Value = OptionContainer.Width + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = OptionContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicText.CustomFontFile",
                            Type = "string",
                            Value = MusicText.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicText.Font Scale",
                            Type = "float",
                            Value = MusicText.FontScale + 1f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicText.Height",
                            Type = "float",
                            Value = MusicText.Height + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicText.Height Units",
                            Type = "DimensionUnitType",
                            Value = MusicText.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicText.Parent",
                            Type = "string",
                            Value = MusicText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicText.Text",
                            Type = "string",
                            Value = MusicText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicText.UseCustomFont",
                            Type = "bool",
                            Value = MusicText.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = MusicText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicText.Width Units",
                            Type = "DimensionUnitType",
                            Value = MusicText.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MusicSlider.Parent",
                            Type = "string",
                            Value = MusicSlider.Parent
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
            private AbbatoirIntergrade.GumRuntimes.TextRuntime SoundText { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime NamesContainer { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SliderBarRuntime SoundSlider { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime OptionContainer { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime MusicText { get; set; }
            private AbbatoirIntergrade.GumRuntimes.SliderBarRuntime MusicSlider { get; set; }
            public OptionsControlsRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                this.HasEvents = false;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "OptionsControls");
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
                SoundText = this.GetGraphicalUiElementByName("SoundText") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
                NamesContainer = this.GetGraphicalUiElementByName("NamesContainer") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
                SoundSlider = this.GetGraphicalUiElementByName("SoundSlider") as AbbatoirIntergrade.GumRuntimes.SliderBarRuntime;
                OptionContainer = this.GetGraphicalUiElementByName("OptionContainer") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
                MusicText = this.GetGraphicalUiElementByName("MusicText") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
                MusicSlider = this.GetGraphicalUiElementByName("MusicSlider") as AbbatoirIntergrade.GumRuntimes.SliderBarRuntime;
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
