    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes
    {
        public partial class TutorialTextRuntime : AbbatoirIntergrade.GumRuntimes.ContainerRuntime
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            public enum Confirmation
            {
                Allow,
                Denied
            }
            public enum SkipTutorial
            {
                ShowSkip,
                DontShow
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            Confirmation mCurrentConfirmationState;
            SkipTutorial mCurrentSkipTutorialState;
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
                            Height = 588f;
                            Width = 904f;
                            LargeInfoFrameInstance.Height = 100f;
                            LargeInfoFrameInstance.Width = 100f;
                            SetProperty("TextInstance.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                            TextInstance.FontScale = 0.5f;
                            TextInstance.Height = 502f;
                            TextInstance.Text = "Tutorial text here";
                            TextInstance.UseCustomFont = true;
                            TextInstance.Width = 620f;
                            TextInstance.X = 108f;
                            TextInstance.Y = 50f;
                            ConfirmationButton.CurrentButtonTypeState = AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime.ButtonType.Check;
                            ConfirmationButton.X = 732f;
                            ConfirmationButton.Y = 434f;
                            SkipTutorialButton.CurrentButtonTypeState = AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime.ButtonType.X;
                            SkipTutorialButton.CurrentColorsState = AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime.Colors.Red;
                            SkipTutorialButton.X = 69f;
                            SkipTutorialButton.Y = 436f;
                            SkipTutorialText.Blue = 0;
                            SetProperty("SkipTutorialText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                            SkipTutorialText.FontScale = 0.5f;
                            SkipTutorialText.Green = 0;
                            SkipTutorialText.Height = 97f;
                            SkipTutorialText.Text = "Click to skip tutorial";
                            SkipTutorialText.UseCustomFont = true;
                            SkipTutorialText.Width = 123f;
                            SkipTutorialText.X = 191f;
                            SkipTutorialText.Y = 453f;
                            ContinueText.Blue = 0;
                            SetProperty("ContinueText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                            ContinueText.FontScale = 0.5f;
                            ContinueText.Green = 255;
                            ContinueText.Height = 97f;
                            ContinueText.Red = 0;
                            ContinueText.Text = "Click to Continue";
                            ContinueText.UseCustomFont = true;
                            ContinueText.Width = 123f;
                            ContinueText.X = 607f;
                            ContinueText.Y = 476f;
                            break;
                    }
                }
            }
            public Confirmation CurrentConfirmationState
            {
                get
                {
                    return mCurrentConfirmationState;
                }
                set
                {
                    mCurrentConfirmationState = value;
                    switch(mCurrentConfirmationState)
                    {
                        case  Confirmation.Allow:
                            ConfirmationButton.Visible = true;
                            ContinueText.Visible = true;
                            break;
                        case  Confirmation.Denied:
                            ConfirmationButton.Visible = false;
                            ContinueText.Visible = false;
                            break;
                    }
                }
            }
            public SkipTutorial CurrentSkipTutorialState
            {
                get
                {
                    return mCurrentSkipTutorialState;
                }
                set
                {
                    mCurrentSkipTutorialState = value;
                    switch(mCurrentSkipTutorialState)
                    {
                        case  SkipTutorial.ShowSkip:
                            SkipTutorialButton.Visible = true;
                            SkipTutorialText.Visible = true;
                            break;
                        case  SkipTutorial.DontShow:
                            SkipTutorialButton.Visible = false;
                            SkipTutorialText.Visible = false;
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
                bool setConfirmationButtonCurrentButtonTypeStateFirstValue = false;
                bool setConfirmationButtonCurrentButtonTypeStateSecondValue = false;
                ButtonFrameRuntime.ButtonType ConfirmationButtonCurrentButtonTypeStateFirstValue= ButtonFrameRuntime.ButtonType.Check;
                ButtonFrameRuntime.ButtonType ConfirmationButtonCurrentButtonTypeStateSecondValue= ButtonFrameRuntime.ButtonType.Check;
                bool setConfirmationButtonXFirstValue = false;
                bool setConfirmationButtonXSecondValue = false;
                float ConfirmationButtonXFirstValue= 0;
                float ConfirmationButtonXSecondValue= 0;
                bool setConfirmationButtonYFirstValue = false;
                bool setConfirmationButtonYSecondValue = false;
                float ConfirmationButtonYFirstValue= 0;
                float ConfirmationButtonYSecondValue= 0;
                bool setContinueTextBlueFirstValue = false;
                bool setContinueTextBlueSecondValue = false;
                int ContinueTextBlueFirstValue= 0;
                int ContinueTextBlueSecondValue= 0;
                bool setContinueTextFontScaleFirstValue = false;
                bool setContinueTextFontScaleSecondValue = false;
                float ContinueTextFontScaleFirstValue= 0;
                float ContinueTextFontScaleSecondValue= 0;
                bool setContinueTextGreenFirstValue = false;
                bool setContinueTextGreenSecondValue = false;
                int ContinueTextGreenFirstValue= 0;
                int ContinueTextGreenSecondValue= 0;
                bool setContinueTextHeightFirstValue = false;
                bool setContinueTextHeightSecondValue = false;
                float ContinueTextHeightFirstValue= 0;
                float ContinueTextHeightSecondValue= 0;
                bool setContinueTextRedFirstValue = false;
                bool setContinueTextRedSecondValue = false;
                int ContinueTextRedFirstValue= 0;
                int ContinueTextRedSecondValue= 0;
                bool setContinueTextWidthFirstValue = false;
                bool setContinueTextWidthSecondValue = false;
                float ContinueTextWidthFirstValue= 0;
                float ContinueTextWidthSecondValue= 0;
                bool setContinueTextXFirstValue = false;
                bool setContinueTextXSecondValue = false;
                float ContinueTextXFirstValue= 0;
                float ContinueTextXSecondValue= 0;
                bool setContinueTextYFirstValue = false;
                bool setContinueTextYSecondValue = false;
                float ContinueTextYFirstValue= 0;
                float ContinueTextYSecondValue= 0;
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setLargeInfoFrameInstanceHeightFirstValue = false;
                bool setLargeInfoFrameInstanceHeightSecondValue = false;
                float LargeInfoFrameInstanceHeightFirstValue= 0;
                float LargeInfoFrameInstanceHeightSecondValue= 0;
                bool setLargeInfoFrameInstanceWidthFirstValue = false;
                bool setLargeInfoFrameInstanceWidthSecondValue = false;
                float LargeInfoFrameInstanceWidthFirstValue= 0;
                float LargeInfoFrameInstanceWidthSecondValue= 0;
                bool setSkipTutorialButtonCurrentButtonTypeStateFirstValue = false;
                bool setSkipTutorialButtonCurrentButtonTypeStateSecondValue = false;
                ButtonFrameRuntime.ButtonType SkipTutorialButtonCurrentButtonTypeStateFirstValue= ButtonFrameRuntime.ButtonType.Check;
                ButtonFrameRuntime.ButtonType SkipTutorialButtonCurrentButtonTypeStateSecondValue= ButtonFrameRuntime.ButtonType.Check;
                bool setSkipTutorialButtonCurrentColorsStateFirstValue = false;
                bool setSkipTutorialButtonCurrentColorsStateSecondValue = false;
                ButtonFrameRuntime.Colors SkipTutorialButtonCurrentColorsStateFirstValue= ButtonFrameRuntime.Colors.Normal;
                ButtonFrameRuntime.Colors SkipTutorialButtonCurrentColorsStateSecondValue= ButtonFrameRuntime.Colors.Normal;
                bool setSkipTutorialButtonXFirstValue = false;
                bool setSkipTutorialButtonXSecondValue = false;
                float SkipTutorialButtonXFirstValue= 0;
                float SkipTutorialButtonXSecondValue= 0;
                bool setSkipTutorialButtonYFirstValue = false;
                bool setSkipTutorialButtonYSecondValue = false;
                float SkipTutorialButtonYFirstValue= 0;
                float SkipTutorialButtonYSecondValue= 0;
                bool setSkipTutorialTextBlueFirstValue = false;
                bool setSkipTutorialTextBlueSecondValue = false;
                int SkipTutorialTextBlueFirstValue= 0;
                int SkipTutorialTextBlueSecondValue= 0;
                bool setSkipTutorialTextFontScaleFirstValue = false;
                bool setSkipTutorialTextFontScaleSecondValue = false;
                float SkipTutorialTextFontScaleFirstValue= 0;
                float SkipTutorialTextFontScaleSecondValue= 0;
                bool setSkipTutorialTextGreenFirstValue = false;
                bool setSkipTutorialTextGreenSecondValue = false;
                int SkipTutorialTextGreenFirstValue= 0;
                int SkipTutorialTextGreenSecondValue= 0;
                bool setSkipTutorialTextHeightFirstValue = false;
                bool setSkipTutorialTextHeightSecondValue = false;
                float SkipTutorialTextHeightFirstValue= 0;
                float SkipTutorialTextHeightSecondValue= 0;
                bool setSkipTutorialTextWidthFirstValue = false;
                bool setSkipTutorialTextWidthSecondValue = false;
                float SkipTutorialTextWidthFirstValue= 0;
                float SkipTutorialTextWidthSecondValue= 0;
                bool setSkipTutorialTextXFirstValue = false;
                bool setSkipTutorialTextXSecondValue = false;
                float SkipTutorialTextXFirstValue= 0;
                float SkipTutorialTextXSecondValue= 0;
                bool setSkipTutorialTextYFirstValue = false;
                bool setSkipTutorialTextYSecondValue = false;
                float SkipTutorialTextYFirstValue= 0;
                float SkipTutorialTextYSecondValue= 0;
                bool setTextInstanceFontScaleFirstValue = false;
                bool setTextInstanceFontScaleSecondValue = false;
                float TextInstanceFontScaleFirstValue= 0;
                float TextInstanceFontScaleSecondValue= 0;
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
                        setConfirmationButtonCurrentButtonTypeStateFirstValue = true;
                        ConfirmationButtonCurrentButtonTypeStateFirstValue = AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime.ButtonType.Check;
                        setConfirmationButtonXFirstValue = true;
                        ConfirmationButtonXFirstValue = 732f;
                        setConfirmationButtonYFirstValue = true;
                        ConfirmationButtonYFirstValue = 434f;
                        setContinueTextBlueFirstValue = true;
                        ContinueTextBlueFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            SetProperty("ContinueText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setContinueTextFontScaleFirstValue = true;
                        ContinueTextFontScaleFirstValue = 0.5f;
                        setContinueTextGreenFirstValue = true;
                        ContinueTextGreenFirstValue = 255;
                        setContinueTextHeightFirstValue = true;
                        ContinueTextHeightFirstValue = 97f;
                        setContinueTextRedFirstValue = true;
                        ContinueTextRedFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            this.ContinueText.Text = "Click to Continue";
                        }
                        if (interpolationValue < 1)
                        {
                            this.ContinueText.UseCustomFont = true;
                        }
                        setContinueTextWidthFirstValue = true;
                        ContinueTextWidthFirstValue = 123f;
                        setContinueTextXFirstValue = true;
                        ContinueTextXFirstValue = 607f;
                        setContinueTextYFirstValue = true;
                        ContinueTextYFirstValue = 476f;
                        setHeightFirstValue = true;
                        HeightFirstValue = 588f;
                        setLargeInfoFrameInstanceHeightFirstValue = true;
                        LargeInfoFrameInstanceHeightFirstValue = 100f;
                        setLargeInfoFrameInstanceWidthFirstValue = true;
                        LargeInfoFrameInstanceWidthFirstValue = 100f;
                        setSkipTutorialButtonCurrentButtonTypeStateFirstValue = true;
                        SkipTutorialButtonCurrentButtonTypeStateFirstValue = AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime.ButtonType.X;
                        setSkipTutorialButtonCurrentColorsStateFirstValue = true;
                        SkipTutorialButtonCurrentColorsStateFirstValue = AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime.Colors.Red;
                        setSkipTutorialButtonXFirstValue = true;
                        SkipTutorialButtonXFirstValue = 69f;
                        setSkipTutorialButtonYFirstValue = true;
                        SkipTutorialButtonYFirstValue = 436f;
                        setSkipTutorialTextBlueFirstValue = true;
                        SkipTutorialTextBlueFirstValue = 0;
                        if (interpolationValue < 1)
                        {
                            SetProperty("SkipTutorialText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setSkipTutorialTextFontScaleFirstValue = true;
                        SkipTutorialTextFontScaleFirstValue = 0.5f;
                        setSkipTutorialTextGreenFirstValue = true;
                        SkipTutorialTextGreenFirstValue = 0;
                        setSkipTutorialTextHeightFirstValue = true;
                        SkipTutorialTextHeightFirstValue = 97f;
                        if (interpolationValue < 1)
                        {
                            this.SkipTutorialText.Text = "Click to skip tutorial";
                        }
                        if (interpolationValue < 1)
                        {
                            this.SkipTutorialText.UseCustomFont = true;
                        }
                        setSkipTutorialTextWidthFirstValue = true;
                        SkipTutorialTextWidthFirstValue = 123f;
                        setSkipTutorialTextXFirstValue = true;
                        SkipTutorialTextXFirstValue = 191f;
                        setSkipTutorialTextYFirstValue = true;
                        SkipTutorialTextYFirstValue = 453f;
                        if (interpolationValue < 1)
                        {
                            SetProperty("TextInstance.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setTextInstanceFontScaleFirstValue = true;
                        TextInstanceFontScaleFirstValue = 0.5f;
                        setTextInstanceHeightFirstValue = true;
                        TextInstanceHeightFirstValue = 502f;
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.Text = "Tutorial text here";
                        }
                        if (interpolationValue < 1)
                        {
                            this.TextInstance.UseCustomFont = true;
                        }
                        setTextInstanceWidthFirstValue = true;
                        TextInstanceWidthFirstValue = 620f;
                        setTextInstanceXFirstValue = true;
                        TextInstanceXFirstValue = 108f;
                        setTextInstanceYFirstValue = true;
                        TextInstanceYFirstValue = 50f;
                        setWidthFirstValue = true;
                        WidthFirstValue = 904f;
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setConfirmationButtonCurrentButtonTypeStateSecondValue = true;
                        ConfirmationButtonCurrentButtonTypeStateSecondValue = AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime.ButtonType.Check;
                        setConfirmationButtonXSecondValue = true;
                        ConfirmationButtonXSecondValue = 732f;
                        setConfirmationButtonYSecondValue = true;
                        ConfirmationButtonYSecondValue = 434f;
                        setContinueTextBlueSecondValue = true;
                        ContinueTextBlueSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("ContinueText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setContinueTextFontScaleSecondValue = true;
                        ContinueTextFontScaleSecondValue = 0.5f;
                        setContinueTextGreenSecondValue = true;
                        ContinueTextGreenSecondValue = 255;
                        setContinueTextHeightSecondValue = true;
                        ContinueTextHeightSecondValue = 97f;
                        setContinueTextRedSecondValue = true;
                        ContinueTextRedSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            this.ContinueText.Text = "Click to Continue";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ContinueText.UseCustomFont = true;
                        }
                        setContinueTextWidthSecondValue = true;
                        ContinueTextWidthSecondValue = 123f;
                        setContinueTextXSecondValue = true;
                        ContinueTextXSecondValue = 607f;
                        setContinueTextYSecondValue = true;
                        ContinueTextYSecondValue = 476f;
                        setHeightSecondValue = true;
                        HeightSecondValue = 588f;
                        setLargeInfoFrameInstanceHeightSecondValue = true;
                        LargeInfoFrameInstanceHeightSecondValue = 100f;
                        setLargeInfoFrameInstanceWidthSecondValue = true;
                        LargeInfoFrameInstanceWidthSecondValue = 100f;
                        setSkipTutorialButtonCurrentButtonTypeStateSecondValue = true;
                        SkipTutorialButtonCurrentButtonTypeStateSecondValue = AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime.ButtonType.X;
                        setSkipTutorialButtonCurrentColorsStateSecondValue = true;
                        SkipTutorialButtonCurrentColorsStateSecondValue = AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime.Colors.Red;
                        setSkipTutorialButtonXSecondValue = true;
                        SkipTutorialButtonXSecondValue = 69f;
                        setSkipTutorialButtonYSecondValue = true;
                        SkipTutorialButtonYSecondValue = 436f;
                        setSkipTutorialTextBlueSecondValue = true;
                        SkipTutorialTextBlueSecondValue = 0;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("SkipTutorialText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setSkipTutorialTextFontScaleSecondValue = true;
                        SkipTutorialTextFontScaleSecondValue = 0.5f;
                        setSkipTutorialTextGreenSecondValue = true;
                        SkipTutorialTextGreenSecondValue = 0;
                        setSkipTutorialTextHeightSecondValue = true;
                        SkipTutorialTextHeightSecondValue = 97f;
                        if (interpolationValue >= 1)
                        {
                            this.SkipTutorialText.Text = "Click to skip tutorial";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SkipTutorialText.UseCustomFont = true;
                        }
                        setSkipTutorialTextWidthSecondValue = true;
                        SkipTutorialTextWidthSecondValue = 123f;
                        setSkipTutorialTextXSecondValue = true;
                        SkipTutorialTextXSecondValue = 191f;
                        setSkipTutorialTextYSecondValue = true;
                        SkipTutorialTextYSecondValue = 453f;
                        if (interpolationValue >= 1)
                        {
                            SetProperty("TextInstance.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        setTextInstanceFontScaleSecondValue = true;
                        TextInstanceFontScaleSecondValue = 0.5f;
                        setTextInstanceHeightSecondValue = true;
                        TextInstanceHeightSecondValue = 502f;
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.Text = "Tutorial text here";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.TextInstance.UseCustomFont = true;
                        }
                        setTextInstanceWidthSecondValue = true;
                        TextInstanceWidthSecondValue = 620f;
                        setTextInstanceXSecondValue = true;
                        TextInstanceXSecondValue = 108f;
                        setTextInstanceYSecondValue = true;
                        TextInstanceYSecondValue = 50f;
                        setWidthSecondValue = true;
                        WidthSecondValue = 904f;
                        break;
                }
                if (setConfirmationButtonCurrentButtonTypeStateFirstValue && setConfirmationButtonCurrentButtonTypeStateSecondValue)
                {
                    ConfirmationButton.InterpolateBetween(ConfirmationButtonCurrentButtonTypeStateFirstValue, ConfirmationButtonCurrentButtonTypeStateSecondValue, interpolationValue);
                }
                if (setConfirmationButtonXFirstValue && setConfirmationButtonXSecondValue)
                {
                    ConfirmationButton.X = ConfirmationButtonXFirstValue * (1 - interpolationValue) + ConfirmationButtonXSecondValue * interpolationValue;
                }
                if (setConfirmationButtonYFirstValue && setConfirmationButtonYSecondValue)
                {
                    ConfirmationButton.Y = ConfirmationButtonYFirstValue * (1 - interpolationValue) + ConfirmationButtonYSecondValue * interpolationValue;
                }
                if (setContinueTextBlueFirstValue && setContinueTextBlueSecondValue)
                {
                    ContinueText.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(ContinueTextBlueFirstValue* (1 - interpolationValue) + ContinueTextBlueSecondValue * interpolationValue);
                }
                if (setContinueTextFontScaleFirstValue && setContinueTextFontScaleSecondValue)
                {
                    ContinueText.FontScale = ContinueTextFontScaleFirstValue * (1 - interpolationValue) + ContinueTextFontScaleSecondValue * interpolationValue;
                }
                if (setContinueTextGreenFirstValue && setContinueTextGreenSecondValue)
                {
                    ContinueText.Green = FlatRedBall.Math.MathFunctions.RoundToInt(ContinueTextGreenFirstValue* (1 - interpolationValue) + ContinueTextGreenSecondValue * interpolationValue);
                }
                if (setContinueTextHeightFirstValue && setContinueTextHeightSecondValue)
                {
                    ContinueText.Height = ContinueTextHeightFirstValue * (1 - interpolationValue) + ContinueTextHeightSecondValue * interpolationValue;
                }
                if (setContinueTextRedFirstValue && setContinueTextRedSecondValue)
                {
                    ContinueText.Red = FlatRedBall.Math.MathFunctions.RoundToInt(ContinueTextRedFirstValue* (1 - interpolationValue) + ContinueTextRedSecondValue * interpolationValue);
                }
                if (setContinueTextWidthFirstValue && setContinueTextWidthSecondValue)
                {
                    ContinueText.Width = ContinueTextWidthFirstValue * (1 - interpolationValue) + ContinueTextWidthSecondValue * interpolationValue;
                }
                if (setContinueTextXFirstValue && setContinueTextXSecondValue)
                {
                    ContinueText.X = ContinueTextXFirstValue * (1 - interpolationValue) + ContinueTextXSecondValue * interpolationValue;
                }
                if (setContinueTextYFirstValue && setContinueTextYSecondValue)
                {
                    ContinueText.Y = ContinueTextYFirstValue * (1 - interpolationValue) + ContinueTextYSecondValue * interpolationValue;
                }
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
                }
                if (setLargeInfoFrameInstanceHeightFirstValue && setLargeInfoFrameInstanceHeightSecondValue)
                {
                    LargeInfoFrameInstance.Height = LargeInfoFrameInstanceHeightFirstValue * (1 - interpolationValue) + LargeInfoFrameInstanceHeightSecondValue * interpolationValue;
                }
                if (setLargeInfoFrameInstanceWidthFirstValue && setLargeInfoFrameInstanceWidthSecondValue)
                {
                    LargeInfoFrameInstance.Width = LargeInfoFrameInstanceWidthFirstValue * (1 - interpolationValue) + LargeInfoFrameInstanceWidthSecondValue * interpolationValue;
                }
                if (setSkipTutorialButtonCurrentButtonTypeStateFirstValue && setSkipTutorialButtonCurrentButtonTypeStateSecondValue)
                {
                    SkipTutorialButton.InterpolateBetween(SkipTutorialButtonCurrentButtonTypeStateFirstValue, SkipTutorialButtonCurrentButtonTypeStateSecondValue, interpolationValue);
                }
                if (setSkipTutorialButtonCurrentColorsStateFirstValue && setSkipTutorialButtonCurrentColorsStateSecondValue)
                {
                    SkipTutorialButton.InterpolateBetween(SkipTutorialButtonCurrentColorsStateFirstValue, SkipTutorialButtonCurrentColorsStateSecondValue, interpolationValue);
                }
                if (setSkipTutorialButtonXFirstValue && setSkipTutorialButtonXSecondValue)
                {
                    SkipTutorialButton.X = SkipTutorialButtonXFirstValue * (1 - interpolationValue) + SkipTutorialButtonXSecondValue * interpolationValue;
                }
                if (setSkipTutorialButtonYFirstValue && setSkipTutorialButtonYSecondValue)
                {
                    SkipTutorialButton.Y = SkipTutorialButtonYFirstValue * (1 - interpolationValue) + SkipTutorialButtonYSecondValue * interpolationValue;
                }
                if (setSkipTutorialTextBlueFirstValue && setSkipTutorialTextBlueSecondValue)
                {
                    SkipTutorialText.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(SkipTutorialTextBlueFirstValue* (1 - interpolationValue) + SkipTutorialTextBlueSecondValue * interpolationValue);
                }
                if (setSkipTutorialTextFontScaleFirstValue && setSkipTutorialTextFontScaleSecondValue)
                {
                    SkipTutorialText.FontScale = SkipTutorialTextFontScaleFirstValue * (1 - interpolationValue) + SkipTutorialTextFontScaleSecondValue * interpolationValue;
                }
                if (setSkipTutorialTextGreenFirstValue && setSkipTutorialTextGreenSecondValue)
                {
                    SkipTutorialText.Green = FlatRedBall.Math.MathFunctions.RoundToInt(SkipTutorialTextGreenFirstValue* (1 - interpolationValue) + SkipTutorialTextGreenSecondValue * interpolationValue);
                }
                if (setSkipTutorialTextHeightFirstValue && setSkipTutorialTextHeightSecondValue)
                {
                    SkipTutorialText.Height = SkipTutorialTextHeightFirstValue * (1 - interpolationValue) + SkipTutorialTextHeightSecondValue * interpolationValue;
                }
                if (setSkipTutorialTextWidthFirstValue && setSkipTutorialTextWidthSecondValue)
                {
                    SkipTutorialText.Width = SkipTutorialTextWidthFirstValue * (1 - interpolationValue) + SkipTutorialTextWidthSecondValue * interpolationValue;
                }
                if (setSkipTutorialTextXFirstValue && setSkipTutorialTextXSecondValue)
                {
                    SkipTutorialText.X = SkipTutorialTextXFirstValue * (1 - interpolationValue) + SkipTutorialTextXSecondValue * interpolationValue;
                }
                if (setSkipTutorialTextYFirstValue && setSkipTutorialTextYSecondValue)
                {
                    SkipTutorialText.Y = SkipTutorialTextYFirstValue * (1 - interpolationValue) + SkipTutorialTextYSecondValue * interpolationValue;
                }
                if (setTextInstanceFontScaleFirstValue && setTextInstanceFontScaleSecondValue)
                {
                    TextInstance.FontScale = TextInstanceFontScaleFirstValue * (1 - interpolationValue) + TextInstanceFontScaleSecondValue * interpolationValue;
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
            public void InterpolateBetween (Confirmation firstState, Confirmation secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                switch(firstState)
                {
                    case  Confirmation.Allow:
                        if (interpolationValue < 1)
                        {
                            this.ConfirmationButton.Visible = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ContinueText.Visible = true;
                        }
                        break;
                    case  Confirmation.Denied:
                        if (interpolationValue < 1)
                        {
                            this.ConfirmationButton.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ContinueText.Visible = false;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  Confirmation.Allow:
                        if (interpolationValue >= 1)
                        {
                            this.ConfirmationButton.Visible = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ContinueText.Visible = true;
                        }
                        break;
                    case  Confirmation.Denied:
                        if (interpolationValue >= 1)
                        {
                            this.ConfirmationButton.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ContinueText.Visible = false;
                        }
                        break;
                }
                if (interpolationValue < 1)
                {
                    mCurrentConfirmationState = firstState;
                }
                else
                {
                    mCurrentConfirmationState = secondState;
                }
            }
            public void InterpolateBetween (SkipTutorial firstState, SkipTutorial secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                switch(firstState)
                {
                    case  SkipTutorial.ShowSkip:
                        if (interpolationValue < 1)
                        {
                            this.SkipTutorialButton.Visible = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SkipTutorialText.Visible = true;
                        }
                        break;
                    case  SkipTutorial.DontShow:
                        if (interpolationValue < 1)
                        {
                            this.SkipTutorialButton.Visible = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SkipTutorialText.Visible = false;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  SkipTutorial.ShowSkip:
                        if (interpolationValue >= 1)
                        {
                            this.SkipTutorialButton.Visible = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SkipTutorialText.Visible = true;
                        }
                        break;
                    case  SkipTutorial.DontShow:
                        if (interpolationValue >= 1)
                        {
                            this.SkipTutorialButton.Visible = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SkipTutorialText.Visible = false;
                        }
                        break;
                }
                if (interpolationValue < 1)
                {
                    mCurrentSkipTutorialState = firstState;
                }
                else
                {
                    mCurrentSkipTutorialState = secondState;
                }
            }
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.TutorialTextRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.TutorialTextRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.TutorialTextRuntime.Confirmation fromState,AbbatoirIntergrade.GumRuntimes.TutorialTextRuntime.Confirmation toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Confirmation toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "Confirmation").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentConfirmationState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (Confirmation toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentConfirmationState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.TutorialTextRuntime.SkipTutorial fromState,AbbatoirIntergrade.GumRuntimes.TutorialTextRuntime.SkipTutorial toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (SkipTutorial toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "SkipTutorial").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentSkipTutorialState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (SkipTutorial toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentSkipTutorialState = toState;
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
                LargeInfoFrameInstance.StopAnimations();
                ConfirmationButton.StopAnimations();
                SkipTutorialButton.StopAnimations();
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
                            Name = "Width",
                            Type = "float",
                            Value = Width
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
                            Name = "TextInstance.CustomFontFile",
                            Type = "string",
                            Value = TextInstance.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Font Scale",
                            Type = "float",
                            Value = TextInstance.FontScale
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
                            Name = "TextInstance.Y",
                            Type = "float",
                            Value = TextInstance.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConfirmationButton.ButtonTypeState",
                            Type = "ButtonTypeState",
                            Value = ConfirmationButton.CurrentButtonTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConfirmationButton.X",
                            Type = "float",
                            Value = ConfirmationButton.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConfirmationButton.Y",
                            Type = "float",
                            Value = ConfirmationButton.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkipTutorialButton.ButtonTypeState",
                            Type = "ButtonTypeState",
                            Value = SkipTutorialButton.CurrentButtonTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkipTutorialButton.ColorsState",
                            Type = "ColorsState",
                            Value = SkipTutorialButton.CurrentColorsState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkipTutorialButton.X",
                            Type = "float",
                            Value = SkipTutorialButton.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkipTutorialButton.Y",
                            Type = "float",
                            Value = SkipTutorialButton.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkipTutorialText.Blue",
                            Type = "int",
                            Value = SkipTutorialText.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkipTutorialText.CustomFontFile",
                            Type = "string",
                            Value = SkipTutorialText.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkipTutorialText.Font Scale",
                            Type = "float",
                            Value = SkipTutorialText.FontScale
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkipTutorialText.Green",
                            Type = "int",
                            Value = SkipTutorialText.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkipTutorialText.Height",
                            Type = "float",
                            Value = SkipTutorialText.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkipTutorialText.Text",
                            Type = "string",
                            Value = SkipTutorialText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkipTutorialText.UseCustomFont",
                            Type = "bool",
                            Value = SkipTutorialText.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkipTutorialText.Width",
                            Type = "float",
                            Value = SkipTutorialText.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkipTutorialText.X",
                            Type = "float",
                            Value = SkipTutorialText.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkipTutorialText.Y",
                            Type = "float",
                            Value = SkipTutorialText.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContinueText.Blue",
                            Type = "int",
                            Value = ContinueText.Blue
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContinueText.CustomFontFile",
                            Type = "string",
                            Value = ContinueText.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContinueText.Font Scale",
                            Type = "float",
                            Value = ContinueText.FontScale
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContinueText.Green",
                            Type = "int",
                            Value = ContinueText.Green
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContinueText.Height",
                            Type = "float",
                            Value = ContinueText.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContinueText.Red",
                            Type = "int",
                            Value = ContinueText.Red
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContinueText.Text",
                            Type = "string",
                            Value = ContinueText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContinueText.UseCustomFont",
                            Type = "bool",
                            Value = ContinueText.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContinueText.Width",
                            Type = "float",
                            Value = ContinueText.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContinueText.X",
                            Type = "float",
                            Value = ContinueText.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContinueText.Y",
                            Type = "float",
                            Value = ContinueText.Y
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
                            Value = Height + 588f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "Width",
                            Type = "float",
                            Value = Width + 904f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LargeInfoFrameInstance.Height",
                            Type = "float",
                            Value = LargeInfoFrameInstance.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LargeInfoFrameInstance.Width",
                            Type = "float",
                            Value = LargeInfoFrameInstance.Width + 100f
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
                            Name = "TextInstance.Font Scale",
                            Type = "float",
                            Value = TextInstance.FontScale + 0.5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.Height",
                            Type = "float",
                            Value = TextInstance.Height + 502f
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
                            Value = TextInstance.Width + 620f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TextInstance.X",
                            Type = "float",
                            Value = TextInstance.X + 108f
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
                            Name = "ConfirmationButton.ButtonTypeState",
                            Type = "ButtonTypeState",
                            Value = ConfirmationButton.CurrentButtonTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConfirmationButton.X",
                            Type = "float",
                            Value = ConfirmationButton.X + 732f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConfirmationButton.Y",
                            Type = "float",
                            Value = ConfirmationButton.Y + 434f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkipTutorialButton.ButtonTypeState",
                            Type = "ButtonTypeState",
                            Value = SkipTutorialButton.CurrentButtonTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkipTutorialButton.ColorsState",
                            Type = "ColorsState",
                            Value = SkipTutorialButton.CurrentColorsState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkipTutorialButton.X",
                            Type = "float",
                            Value = SkipTutorialButton.X + 69f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkipTutorialButton.Y",
                            Type = "float",
                            Value = SkipTutorialButton.Y + 436f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkipTutorialText.Blue",
                            Type = "int",
                            Value = SkipTutorialText.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkipTutorialText.CustomFontFile",
                            Type = "string",
                            Value = SkipTutorialText.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkipTutorialText.Font Scale",
                            Type = "float",
                            Value = SkipTutorialText.FontScale + 0.5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkipTutorialText.Green",
                            Type = "int",
                            Value = SkipTutorialText.Green + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkipTutorialText.Height",
                            Type = "float",
                            Value = SkipTutorialText.Height + 97f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkipTutorialText.Text",
                            Type = "string",
                            Value = SkipTutorialText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkipTutorialText.UseCustomFont",
                            Type = "bool",
                            Value = SkipTutorialText.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkipTutorialText.Width",
                            Type = "float",
                            Value = SkipTutorialText.Width + 123f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkipTutorialText.X",
                            Type = "float",
                            Value = SkipTutorialText.X + 191f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkipTutorialText.Y",
                            Type = "float",
                            Value = SkipTutorialText.Y + 453f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContinueText.Blue",
                            Type = "int",
                            Value = ContinueText.Blue + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContinueText.CustomFontFile",
                            Type = "string",
                            Value = ContinueText.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContinueText.Font Scale",
                            Type = "float",
                            Value = ContinueText.FontScale + 0.5f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContinueText.Green",
                            Type = "int",
                            Value = ContinueText.Green + 255
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContinueText.Height",
                            Type = "float",
                            Value = ContinueText.Height + 97f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContinueText.Red",
                            Type = "int",
                            Value = ContinueText.Red + 0
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContinueText.Text",
                            Type = "string",
                            Value = ContinueText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContinueText.UseCustomFont",
                            Type = "bool",
                            Value = ContinueText.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContinueText.Width",
                            Type = "float",
                            Value = ContinueText.Width + 123f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContinueText.X",
                            Type = "float",
                            Value = ContinueText.X + 607f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContinueText.Y",
                            Type = "float",
                            Value = ContinueText.Y + 476f
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (Confirmation state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  Confirmation.Allow:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConfirmationButton.Visible",
                            Type = "bool",
                            Value = ConfirmationButton.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContinueText.Visible",
                            Type = "bool",
                            Value = ContinueText.Visible
                        }
                        );
                        break;
                    case  Confirmation.Denied:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConfirmationButton.Visible",
                            Type = "bool",
                            Value = ConfirmationButton.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContinueText.Visible",
                            Type = "bool",
                            Value = ContinueText.Visible
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (Confirmation state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  Confirmation.Allow:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConfirmationButton.Visible",
                            Type = "bool",
                            Value = ConfirmationButton.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContinueText.Visible",
                            Type = "bool",
                            Value = ContinueText.Visible
                        }
                        );
                        break;
                    case  Confirmation.Denied:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConfirmationButton.Visible",
                            Type = "bool",
                            Value = ConfirmationButton.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ContinueText.Visible",
                            Type = "bool",
                            Value = ContinueText.Visible
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (SkipTutorial state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  SkipTutorial.ShowSkip:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkipTutorialButton.Visible",
                            Type = "bool",
                            Value = SkipTutorialButton.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkipTutorialText.Visible",
                            Type = "bool",
                            Value = SkipTutorialText.Visible
                        }
                        );
                        break;
                    case  SkipTutorial.DontShow:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkipTutorialButton.Visible",
                            Type = "bool",
                            Value = SkipTutorialButton.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkipTutorialText.Visible",
                            Type = "bool",
                            Value = SkipTutorialText.Visible
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (SkipTutorial state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  SkipTutorial.ShowSkip:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkipTutorialButton.Visible",
                            Type = "bool",
                            Value = SkipTutorialButton.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkipTutorialText.Visible",
                            Type = "bool",
                            Value = SkipTutorialText.Visible
                        }
                        );
                        break;
                    case  SkipTutorial.DontShow:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkipTutorialButton.Visible",
                            Type = "bool",
                            Value = SkipTutorialButton.Visible
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SkipTutorialText.Visible",
                            Type = "bool",
                            Value = SkipTutorialText.Visible
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
                    else if (category.Name == "Confirmation")
                    {
                        if(state.Name == "Allow") this.mCurrentConfirmationState = Confirmation.Allow;
                        if(state.Name == "Denied") this.mCurrentConfirmationState = Confirmation.Denied;
                    }
                    else if (category.Name == "SkipTutorial")
                    {
                        if(state.Name == "ShowSkip") this.mCurrentSkipTutorialState = SkipTutorial.ShowSkip;
                        if(state.Name == "DontShow") this.mCurrentSkipTutorialState = SkipTutorial.DontShow;
                    }
                }
                base.ApplyState(state);
            }
            private AbbatoirIntergrade.GumRuntimes.LargeInfoFrameRuntime LargeInfoFrameInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime TextInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime ConfirmationButton { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime SkipTutorialButton { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime SkipTutorialText { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime ContinueText { get; set; }
            public TutorialTextRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                this.HasEvents = false;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "infodisplays/TutorialText");
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
                LargeInfoFrameInstance = this.GetGraphicalUiElementByName("LargeInfoFrameInstance") as AbbatoirIntergrade.GumRuntimes.LargeInfoFrameRuntime;
                TextInstance = this.GetGraphicalUiElementByName("TextInstance") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
                ConfirmationButton = this.GetGraphicalUiElementByName("ConfirmationButton") as AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime;
                SkipTutorialButton = this.GetGraphicalUiElementByName("SkipTutorialButton") as AbbatoirIntergrade.GumRuntimes.ButtonFrameRuntime;
                SkipTutorialText = this.GetGraphicalUiElementByName("SkipTutorialText") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
                ContinueText = this.GetGraphicalUiElementByName("ContinueText") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
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
