    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes
    {
        public partial class OptionsControlsRuntime : AbbatoirIntergrade.GumRuntimes.ContainerRuntime
        {
            #region State Enums
            public enum VariableState
            {
                Default,
                HiddenFullScreen
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
                            SoundText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "NamesContainer") ?? this;
                            SoundText.Text = "Sound Volume";
                            SoundText.UseCustomFont = true;
                            SoundText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            SoundText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            NamesContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                            NamesContainer.Height = 100f;
                            NamesContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            NamesContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "OptionsDisplayContainer") ?? this;
                            NamesContainer.Width = 49f;
                            NamesContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            SoundSlider.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "OptionContainer") ?? this;
                            OptionContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                            OptionContainer.Height = 100f;
                            OptionContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            OptionContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "OptionsDisplayContainer") ?? this;
                            OptionContainer.Width = 49f;
                            OptionContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            OptionContainer.X = 1f;
                            OptionContainer.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            SetProperty("MusicText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                            MusicText.FontScale = 1f;
                            MusicText.Height = 20f;
                            MusicText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            MusicText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "NamesContainer") ?? this;
                            MusicText.Text = "Music Volume";
                            MusicText.UseCustomFont = true;
                            MusicText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            MusicText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            MusicSlider.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "OptionContainer") ?? this;
                            SetProperty("FullScreenText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                            FullScreenText.FontScale = 1f;
                            FullScreenText.Height = 20f;
                            FullScreenText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            FullScreenText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "NamesContainer") ?? this;
                            FullScreenText.Text = "Full Screen";
                            FullScreenText.UseCustomFont = true;
                            FullScreenText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            FullScreenText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            FullScreenCheckBox.CheckBoxText = "";
                            FullScreenCheckBox.Height = 15f;
                            FullScreenCheckBox.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            FullScreenCheckBox.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "OptionContainer") ?? this;
                            FullScreenCheckBox.Width = 14.5f;
                            FullScreenCheckBox.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            FullScreenCheckBox.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            FullScreenCheckBox.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            FullScreenCheckBox.Y = 2.5f;
                            FullScreenCheckBox.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            OptionsDisplayContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                            OptionsDisplayContainer.Height = 100f;
                            OptionsDisplayContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            OptionsDisplayContainer.Width = 100f;
                            OptionsDisplayContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ResizeText.Blue = 255;
                            SetProperty("ResizeText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                            ResizeText.FontScale = 0.75f;
                            ResizeText.Green = 255;
                            ResizeText.Height = 0f;
                            ResizeText.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            ResizeText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            ResizeText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "OptionContainer") ?? this;
                            ResizeText.Red = 0;
                            ResizeText.Text = "(Resize the window by dragging the edges)";
                            ResizeText.UseCustomFont = true;
                            ResizeText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Top;
                            ResizeText.Width = 100f;
                            ResizeText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            break;
                        case  VariableState.HiddenFullScreen:
                            FullScreenText.Visible = false;
                            FullScreenCheckBox.Visible = false;
                            ResizeText.Visible = false;
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
                bool setFullScreenCheckBoxHeightFirstValue = false;
                bool setFullScreenCheckBoxHeightSecondValue = false;
                float FullScreenCheckBoxHeightFirstValue= 0;
                float FullScreenCheckBoxHeightSecondValue= 0;
                bool setFullScreenCheckBoxWidthFirstValue = false;
                bool setFullScreenCheckBoxWidthSecondValue = false;
                float FullScreenCheckBoxWidthFirstValue= 0;
                float FullScreenCheckBoxWidthSecondValue= 0;
                bool setFullScreenCheckBoxYFirstValue = false;
                bool setFullScreenCheckBoxYSecondValue = false;
                float FullScreenCheckBoxYFirstValue= 0;
                float FullScreenCheckBoxYSecondValue= 0;
                bool setFullScreenTextFontScaleFirstValue = false;
                bool setFullScreenTextFontScaleSecondValue = false;
                float FullScreenTextFontScaleFirstValue= 0;
                float FullScreenTextFontScaleSecondValue= 0;
                bool setFullScreenTextHeightFirstValue = false;
                bool setFullScreenTextHeightSecondValue = false;
                float FullScreenTextHeightFirstValue= 0;
                float FullScreenTextHeightSecondValue= 0;
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
                bool setOptionContainerXFirstValue = false;
                bool setOptionContainerXSecondValue = false;
                float OptionContainerXFirstValue= 0;
                float OptionContainerXSecondValue= 0;
                bool setOptionsDisplayContainerHeightFirstValue = false;
                bool setOptionsDisplayContainerHeightSecondValue = false;
                float OptionsDisplayContainerHeightFirstValue= 0;
                float OptionsDisplayContainerHeightSecondValue= 0;
                bool setOptionsDisplayContainerWidthFirstValue = false;
                bool setOptionsDisplayContainerWidthSecondValue = false;
                float OptionsDisplayContainerWidthFirstValue= 0;
                float OptionsDisplayContainerWidthSecondValue= 0;
                bool setResizeTextBlueFirstValue = false;
                bool setResizeTextBlueSecondValue = false;
                int ResizeTextBlueFirstValue= 0;
                int ResizeTextBlueSecondValue= 0;
                bool setResizeTextFontScaleFirstValue = false;
                bool setResizeTextFontScaleSecondValue = false;
                float ResizeTextFontScaleFirstValue= 0;
                float ResizeTextFontScaleSecondValue= 0;
                bool setResizeTextGreenFirstValue = false;
                bool setResizeTextGreenSecondValue = false;
                int ResizeTextGreenFirstValue= 0;
                int ResizeTextGreenSecondValue= 0;
                bool setResizeTextHeightFirstValue = false;
                bool setResizeTextHeightSecondValue = false;
                float ResizeTextHeightFirstValue= 0;
                float ResizeTextHeightSecondValue= 0;
                bool setResizeTextRedFirstValue = false;
                bool setResizeTextRedSecondValue = false;
                int ResizeTextRedFirstValue= 0;
                int ResizeTextRedSecondValue= 0;
                bool setResizeTextWidthFirstValue = false;
                bool setResizeTextWidthSecondValue = false;
                float ResizeTextWidthFirstValue= 0;
                float ResizeTextWidthSecondValue= 0;
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
                        if (interpolationValue < 1)
                        {
                            this.FullScreenCheckBox.CheckBoxText = "";
                        }
                        setFullScreenCheckBoxHeightFirstValue = true;
                        FullScreenCheckBoxHeightFirstValue = 15f;
                        if (interpolationValue < 1)
                        {
                            this.FullScreenCheckBox.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.FullScreenCheckBox.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "OptionContainer") ?? this;
                        }
                        setFullScreenCheckBoxWidthFirstValue = true;
                        FullScreenCheckBoxWidthFirstValue = 14.5f;
                        if (interpolationValue < 1)
                        {
                            this.FullScreenCheckBox.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.FullScreenCheckBox.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.FullScreenCheckBox.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setFullScreenCheckBoxYFirstValue = true;
                        FullScreenCheckBoxYFirstValue = 2.5f;
                        if (interpolationValue < 1)
                        {
                            this.FullScreenCheckBox.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("FullScreenText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setFullScreenTextFontScaleFirstValue = true;
                        FullScreenTextFontScaleFirstValue = 1f;
                        setFullScreenTextHeightFirstValue = true;
                        FullScreenTextHeightFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.FullScreenText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.FullScreenText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "NamesContainer") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.FullScreenText.Text = "Full Screen";
                        }
                        if (interpolationValue < 1)
                        {
                            this.FullScreenText.UseCustomFont = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.FullScreenText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.FullScreenText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setHeightFirstValue = true;
                        HeightFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MusicSlider.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "OptionContainer") ?? this;
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
                            this.MusicText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "NamesContainer") ?? this;
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
                        if (interpolationValue < 1)
                        {
                            this.NamesContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "OptionsDisplayContainer") ?? this;
                        }
                        setNamesContainerWidthFirstValue = true;
                        NamesContainerWidthFirstValue = 49f;
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
                        if (interpolationValue < 1)
                        {
                            this.OptionContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "OptionsDisplayContainer") ?? this;
                        }
                        setOptionContainerWidthFirstValue = true;
                        OptionContainerWidthFirstValue = 49f;
                        if (interpolationValue < 1)
                        {
                            this.OptionContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setOptionContainerXFirstValue = true;
                        OptionContainerXFirstValue = 1f;
                        if (interpolationValue < 1)
                        {
                            this.OptionContainer.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.OptionsDisplayContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setOptionsDisplayContainerHeightFirstValue = true;
                        OptionsDisplayContainerHeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.OptionsDisplayContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setOptionsDisplayContainerWidthFirstValue = true;
                        OptionsDisplayContainerWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.OptionsDisplayContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setResizeTextBlueFirstValue = true;
                        ResizeTextBlueFirstValue = 255;
                        if (interpolationValue < 1)
                        {
                            SetProperty("ResizeText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setResizeTextFontScaleFirstValue = true;
                        ResizeTextFontScaleFirstValue = 0.75f;
                        setResizeTextGreenFirstValue = true;
                        ResizeTextGreenFirstValue = 255;
                        setResizeTextHeightFirstValue = true;
                        ResizeTextHeightFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.ResizeText.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ResizeText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ResizeText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "OptionContainer") ?? this;
                        }
                        setResizeTextRedFirstValue = true;
                        ResizeTextRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.ResizeText.Text = "(Resize the window by dragging the edges)";
                        }
                        if (interpolationValue < 1)
                        {
                            this.ResizeText.UseCustomFont = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ResizeText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        setResizeTextWidthFirstValue = true;
                        ResizeTextWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.ResizeText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SoundSlider.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "OptionContainer") ?? this;
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
                            this.SoundText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "NamesContainer") ?? this;
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
                    case  VariableState.HiddenFullScreen:
                        if (interpolationValue < 1)
                        {
                            this.FullScreenCheckBox.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.FullScreenText.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ResizeText.Visible = false;
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
                        if (interpolationValue >= 1)
                        {
                            this.FullScreenCheckBox.CheckBoxText = "";
                        }
                        setFullScreenCheckBoxHeightSecondValue = true;
                        FullScreenCheckBoxHeightSecondValue = 15f;
                        if (interpolationValue >= 1)
                        {
                            this.FullScreenCheckBox.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.FullScreenCheckBox.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "OptionContainer") ?? this;
                        }
                        setFullScreenCheckBoxWidthSecondValue = true;
                        FullScreenCheckBoxWidthSecondValue = 14.5f;
                        if (interpolationValue >= 1)
                        {
                            this.FullScreenCheckBox.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.FullScreenCheckBox.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.FullScreenCheckBox.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        }
                        setFullScreenCheckBoxYSecondValue = true;
                        FullScreenCheckBoxYSecondValue = 2.5f;
                        if (interpolationValue >= 1)
                        {
                            this.FullScreenCheckBox.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("FullScreenText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setFullScreenTextFontScaleSecondValue = true;
                        FullScreenTextFontScaleSecondValue = 1f;
                        setFullScreenTextHeightSecondValue = true;
                        FullScreenTextHeightSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.FullScreenText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.FullScreenText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "NamesContainer") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.FullScreenText.Text = "Full Screen";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.FullScreenText.UseCustomFont = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.FullScreenText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.FullScreenText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setHeightSecondValue = true;
                        HeightSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MusicSlider.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "OptionContainer") ?? this;
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
                            this.MusicText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "NamesContainer") ?? this;
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
                        if (interpolationValue >= 1)
                        {
                            this.NamesContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "OptionsDisplayContainer") ?? this;
                        }
                        setNamesContainerWidthSecondValue = true;
                        NamesContainerWidthSecondValue = 49f;
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
                        if (interpolationValue >= 1)
                        {
                            this.OptionContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "OptionsDisplayContainer") ?? this;
                        }
                        setOptionContainerWidthSecondValue = true;
                        OptionContainerWidthSecondValue = 49f;
                        if (interpolationValue >= 1)
                        {
                            this.OptionContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setOptionContainerXSecondValue = true;
                        OptionContainerXSecondValue = 1f;
                        if (interpolationValue >= 1)
                        {
                            this.OptionContainer.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.OptionsDisplayContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setOptionsDisplayContainerHeightSecondValue = true;
                        OptionsDisplayContainerHeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.OptionsDisplayContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setOptionsDisplayContainerWidthSecondValue = true;
                        OptionsDisplayContainerWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.OptionsDisplayContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setResizeTextBlueSecondValue = true;
                        ResizeTextBlueSecondValue = 255;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("ResizeText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setResizeTextFontScaleSecondValue = true;
                        ResizeTextFontScaleSecondValue = 0.75f;
                        setResizeTextGreenSecondValue = true;
                        ResizeTextGreenSecondValue = 255;
                        setResizeTextHeightSecondValue = true;
                        ResizeTextHeightSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.ResizeText.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ResizeText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ResizeText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "OptionContainer") ?? this;
                        }
                        setResizeTextRedSecondValue = true;
                        ResizeTextRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.ResizeText.Text = "(Resize the window by dragging the edges)";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ResizeText.UseCustomFont = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ResizeText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        }
                        setResizeTextWidthSecondValue = true;
                        ResizeTextWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.ResizeText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SoundSlider.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "OptionContainer") ?? this;
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
                            this.SoundText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "NamesContainer") ?? this;
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
                    case  VariableState.HiddenFullScreen:
                        if (interpolationValue >= 1)
                        {
                            this.FullScreenCheckBox.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.FullScreenText.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ResizeText.Visible = false;
                        }
                        break;
                }
                if (setFullScreenCheckBoxHeightFirstValue && setFullScreenCheckBoxHeightSecondValue)
                {
                    FullScreenCheckBox.Height = FullScreenCheckBoxHeightFirstValue * (1 - interpolationValue) + FullScreenCheckBoxHeightSecondValue * interpolationValue;
                }
                if (setFullScreenCheckBoxWidthFirstValue && setFullScreenCheckBoxWidthSecondValue)
                {
                    FullScreenCheckBox.Width = FullScreenCheckBoxWidthFirstValue * (1 - interpolationValue) + FullScreenCheckBoxWidthSecondValue * interpolationValue;
                }
                if (setFullScreenCheckBoxYFirstValue && setFullScreenCheckBoxYSecondValue)
                {
                    FullScreenCheckBox.Y = FullScreenCheckBoxYFirstValue * (1 - interpolationValue) + FullScreenCheckBoxYSecondValue * interpolationValue;
                }
                if (setFullScreenTextFontScaleFirstValue && setFullScreenTextFontScaleSecondValue)
                {
                    FullScreenText.FontScale = FullScreenTextFontScaleFirstValue * (1 - interpolationValue) + FullScreenTextFontScaleSecondValue * interpolationValue;
                }
                if (setFullScreenTextHeightFirstValue && setFullScreenTextHeightSecondValue)
                {
                    FullScreenText.Height = FullScreenTextHeightFirstValue * (1 - interpolationValue) + FullScreenTextHeightSecondValue * interpolationValue;
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
                if (setOptionContainerXFirstValue && setOptionContainerXSecondValue)
                {
                    OptionContainer.X = OptionContainerXFirstValue * (1 - interpolationValue) + OptionContainerXSecondValue * interpolationValue;
                }
                if (setOptionsDisplayContainerHeightFirstValue && setOptionsDisplayContainerHeightSecondValue)
                {
                    OptionsDisplayContainer.Height = OptionsDisplayContainerHeightFirstValue * (1 - interpolationValue) + OptionsDisplayContainerHeightSecondValue * interpolationValue;
                }
                if (setOptionsDisplayContainerWidthFirstValue && setOptionsDisplayContainerWidthSecondValue)
                {
                    OptionsDisplayContainer.Width = OptionsDisplayContainerWidthFirstValue * (1 - interpolationValue) + OptionsDisplayContainerWidthSecondValue * interpolationValue;
                }
                if (setResizeTextBlueFirstValue && setResizeTextBlueSecondValue)
                {
                    ResizeText.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(ResizeTextBlueFirstValue* (1 - interpolationValue) + ResizeTextBlueSecondValue * interpolationValue);
                }
                if (setResizeTextFontScaleFirstValue && setResizeTextFontScaleSecondValue)
                {
                    ResizeText.FontScale = ResizeTextFontScaleFirstValue * (1 - interpolationValue) + ResizeTextFontScaleSecondValue * interpolationValue;
                }
                if (setResizeTextGreenFirstValue && setResizeTextGreenSecondValue)
                {
                    ResizeText.Green = FlatRedBall.Math.MathFunctions.RoundToInt(ResizeTextGreenFirstValue* (1 - interpolationValue) + ResizeTextGreenSecondValue * interpolationValue);
                }
                if (setResizeTextHeightFirstValue && setResizeTextHeightSecondValue)
                {
                    ResizeText.Height = ResizeTextHeightFirstValue * (1 - interpolationValue) + ResizeTextHeightSecondValue * interpolationValue;
                }
                if (setResizeTextRedFirstValue && setResizeTextRedSecondValue)
                {
                    ResizeText.Red = FlatRedBall.Math.MathFunctions.RoundToInt(ResizeTextRedFirstValue* (1 - interpolationValue) + ResizeTextRedSecondValue * interpolationValue);
                }
                if (setResizeTextWidthFirstValue && setResizeTextWidthSecondValue)
                {
                    ResizeText.Width = ResizeTextWidthFirstValue * (1 - interpolationValue) + ResizeTextWidthSecondValue * interpolationValue;
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
                FullScreenCheckBox.StopAnimations();
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
                            Name = "NamesContainer.Parent",
                            Type = "string",
                            Value = NamesContainer.Parent
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
                            Name = "OptionContainer.Parent",
                            Type = "string",
                            Value = OptionContainer.Parent
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
                            Name = "OptionContainer.X",
                            Type = "float",
                            Value = OptionContainer.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionContainer.X Units",
                            Type = "PositionUnitType",
                            Value = OptionContainer.XUnits
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
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FullScreenText.CustomFontFile",
                            Type = "string",
                            Value = FullScreenText.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FullScreenText.Font Scale",
                            Type = "float",
                            Value = FullScreenText.FontScale
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FullScreenText.Height",
                            Type = "float",
                            Value = FullScreenText.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FullScreenText.Height Units",
                            Type = "DimensionUnitType",
                            Value = FullScreenText.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FullScreenText.Parent",
                            Type = "string",
                            Value = FullScreenText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FullScreenText.Text",
                            Type = "string",
                            Value = FullScreenText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FullScreenText.UseCustomFont",
                            Type = "bool",
                            Value = FullScreenText.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FullScreenText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = FullScreenText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FullScreenText.Width Units",
                            Type = "DimensionUnitType",
                            Value = FullScreenText.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FullScreenCheckBox.CheckBoxText",
                            Type = "string",
                            Value = FullScreenCheckBox.CheckBoxText
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FullScreenCheckBox.Height",
                            Type = "float",
                            Value = FullScreenCheckBox.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FullScreenCheckBox.Height Units",
                            Type = "DimensionUnitType",
                            Value = FullScreenCheckBox.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FullScreenCheckBox.Parent",
                            Type = "string",
                            Value = FullScreenCheckBox.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FullScreenCheckBox.Width",
                            Type = "float",
                            Value = FullScreenCheckBox.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FullScreenCheckBox.Width Units",
                            Type = "DimensionUnitType",
                            Value = FullScreenCheckBox.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FullScreenCheckBox.X Origin",
                            Type = "HorizontalAlignment",
                            Value = FullScreenCheckBox.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FullScreenCheckBox.X Units",
                            Type = "PositionUnitType",
                            Value = FullScreenCheckBox.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FullScreenCheckBox.Y",
                            Type = "float",
                            Value = FullScreenCheckBox.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FullScreenCheckBox.Y Units",
                            Type = "PositionUnitType",
                            Value = FullScreenCheckBox.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionsDisplayContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = OptionsDisplayContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionsDisplayContainer.Height",
                            Type = "float",
                            Value = OptionsDisplayContainer.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionsDisplayContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = OptionsDisplayContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionsDisplayContainer.Width",
                            Type = "float",
                            Value = OptionsDisplayContainer.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionsDisplayContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = OptionsDisplayContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResizeText.Blue",
                            Type = "int",
                            Value = ResizeText.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResizeText.CustomFontFile",
                            Type = "string",
                            Value = ResizeText.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResizeText.Font Scale",
                            Type = "float",
                            Value = ResizeText.FontScale
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResizeText.Green",
                            Type = "int",
                            Value = ResizeText.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResizeText.Height",
                            Type = "float",
                            Value = ResizeText.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResizeText.Height Units",
                            Type = "DimensionUnitType",
                            Value = ResizeText.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResizeText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = ResizeText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResizeText.Parent",
                            Type = "string",
                            Value = ResizeText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResizeText.Red",
                            Type = "int",
                            Value = ResizeText.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResizeText.Text",
                            Type = "string",
                            Value = ResizeText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResizeText.UseCustomFont",
                            Type = "bool",
                            Value = ResizeText.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResizeText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = ResizeText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResizeText.Width",
                            Type = "float",
                            Value = ResizeText.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResizeText.Width Units",
                            Type = "DimensionUnitType",
                            Value = ResizeText.WidthUnits
                        }
                        );
                        break;
                    case  VariableState.HiddenFullScreen:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FullScreenText.Visible",
                            Type = "bool",
                            Value = FullScreenText.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FullScreenCheckBox.Visible",
                            Type = "bool",
                            Value = FullScreenCheckBox.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResizeText.Visible",
                            Type = "bool",
                            Value = ResizeText.Visible
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
                            Name = "NamesContainer.Parent",
                            Type = "string",
                            Value = NamesContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NamesContainer.Width",
                            Type = "float",
                            Value = NamesContainer.Width + 49f
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
                            Name = "OptionContainer.Parent",
                            Type = "string",
                            Value = OptionContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionContainer.Width",
                            Type = "float",
                            Value = OptionContainer.Width + 49f
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
                            Name = "OptionContainer.X",
                            Type = "float",
                            Value = OptionContainer.X + 1f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionContainer.X Units",
                            Type = "PositionUnitType",
                            Value = OptionContainer.XUnits
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
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FullScreenText.CustomFontFile",
                            Type = "string",
                            Value = FullScreenText.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FullScreenText.Font Scale",
                            Type = "float",
                            Value = FullScreenText.FontScale + 1f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FullScreenText.Height",
                            Type = "float",
                            Value = FullScreenText.Height + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FullScreenText.Height Units",
                            Type = "DimensionUnitType",
                            Value = FullScreenText.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FullScreenText.Parent",
                            Type = "string",
                            Value = FullScreenText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FullScreenText.Text",
                            Type = "string",
                            Value = FullScreenText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FullScreenText.UseCustomFont",
                            Type = "bool",
                            Value = FullScreenText.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FullScreenText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = FullScreenText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FullScreenText.Width Units",
                            Type = "DimensionUnitType",
                            Value = FullScreenText.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FullScreenCheckBox.CheckBoxText",
                            Type = "string",
                            Value = FullScreenCheckBox.CheckBoxText
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FullScreenCheckBox.Height",
                            Type = "float",
                            Value = FullScreenCheckBox.Height + 15f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FullScreenCheckBox.Height Units",
                            Type = "DimensionUnitType",
                            Value = FullScreenCheckBox.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FullScreenCheckBox.Parent",
                            Type = "string",
                            Value = FullScreenCheckBox.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FullScreenCheckBox.Width",
                            Type = "float",
                            Value = FullScreenCheckBox.Width + 14.5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FullScreenCheckBox.Width Units",
                            Type = "DimensionUnitType",
                            Value = FullScreenCheckBox.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FullScreenCheckBox.X Origin",
                            Type = "HorizontalAlignment",
                            Value = FullScreenCheckBox.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FullScreenCheckBox.X Units",
                            Type = "PositionUnitType",
                            Value = FullScreenCheckBox.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FullScreenCheckBox.Y",
                            Type = "float",
                            Value = FullScreenCheckBox.Y + 2.5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FullScreenCheckBox.Y Units",
                            Type = "PositionUnitType",
                            Value = FullScreenCheckBox.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionsDisplayContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = OptionsDisplayContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionsDisplayContainer.Height",
                            Type = "float",
                            Value = OptionsDisplayContainer.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionsDisplayContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = OptionsDisplayContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionsDisplayContainer.Width",
                            Type = "float",
                            Value = OptionsDisplayContainer.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OptionsDisplayContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = OptionsDisplayContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResizeText.Blue",
                            Type = "int",
                            Value = ResizeText.Blue + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResizeText.CustomFontFile",
                            Type = "string",
                            Value = ResizeText.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResizeText.Font Scale",
                            Type = "float",
                            Value = ResizeText.FontScale + 0.75f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResizeText.Green",
                            Type = "int",
                            Value = ResizeText.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResizeText.Height",
                            Type = "float",
                            Value = ResizeText.Height + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResizeText.Height Units",
                            Type = "DimensionUnitType",
                            Value = ResizeText.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResizeText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = ResizeText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResizeText.Parent",
                            Type = "string",
                            Value = ResizeText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResizeText.Red",
                            Type = "int",
                            Value = ResizeText.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResizeText.Text",
                            Type = "string",
                            Value = ResizeText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResizeText.UseCustomFont",
                            Type = "bool",
                            Value = ResizeText.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResizeText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = ResizeText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResizeText.Width",
                            Type = "float",
                            Value = ResizeText.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResizeText.Width Units",
                            Type = "DimensionUnitType",
                            Value = ResizeText.WidthUnits
                        }
                        );
                        break;
                    case  VariableState.HiddenFullScreen:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FullScreenText.Visible",
                            Type = "bool",
                            Value = FullScreenText.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FullScreenCheckBox.Visible",
                            Type = "bool",
                            Value = FullScreenCheckBox.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResizeText.Visible",
                            Type = "bool",
                            Value = ResizeText.Visible
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
                        if (state.Name == "HiddenFullScreen") this.mCurrentVariableState = VariableState.HiddenFullScreen;
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
            private AbbatoirIntergrade.GumRuntimes.TextRuntime FullScreenText { get; set; }
            private AbbatoirIntergrade.GumRuntimes.CheckBoxRuntime FullScreenCheckBox { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime OptionsDisplayContainer { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime ResizeText { get; set; }
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
                FullScreenText = this.GetGraphicalUiElementByName("FullScreenText") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
                FullScreenCheckBox = this.GetGraphicalUiElementByName("FullScreenCheckBox") as AbbatoirIntergrade.GumRuntimes.CheckBoxRuntime;
                OptionsDisplayContainer = this.GetGraphicalUiElementByName("OptionsDisplayContainer") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
                ResizeText = this.GetGraphicalUiElementByName("ResizeText") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
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
