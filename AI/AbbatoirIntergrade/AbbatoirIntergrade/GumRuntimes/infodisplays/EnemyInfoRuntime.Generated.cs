    using System.Linq;
    namespace AbbatoirIntergrade.GumRuntimes.infodisplays
    {
        public partial class EnemyInfoRuntime : AbbatoirIntergrade.GumRuntimes.ContainerRuntime
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            public enum HasMelee
            {
                True,
                False
            }
            public enum HasRanged
            {
                True,
                False
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            HasMelee? mCurrentHasMeleeState;
            HasRanged? mCurrentHasRangedState;
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
                            Height = 35.55556f;
                            HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            Visible = true;
                            Width = 20f;
                            WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            WrapsChildren = false;
                            XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                            YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddleInverted;
                            StatsContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                            StatsContainer.Height = 88.80209f;
                            StatsContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            StatsContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "TallInfoFrameInstance") ?? this;
                            StatsContainer.Width = 67.44791f;
                            StatsContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            StatsContainer.WrapsChildren = true;
                            StatsContainer.X = 83f;
                            StatsContainer.Y = 29f;
                            NameContainer.Height = 19f;
                            NameContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            NameContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "StatsContainer") ?? this;
                            NameContainer.Width = 100f;
                            NameContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            SetProperty("NameText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                            NameText.Font = "Moire ExtraBold";
                            NameText.FontScale = 0.8f;
                            NameText.FontSize = 50;
                            NameText.Height = 100f;
                            NameText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            NameText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            NameText.OutlineThickness = 2;
                            NameText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "NameContainer") ?? this;
                            NameText.Text = "Enemy";
                            NameText.UseCustomFont = true;
                            NameText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            NameText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            NameText.X = 0f;
                            NameText.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                            NameText.Y = 0f;
                            NameText.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                            TallInfoFrameInstance.Height = 100f;
                            TallInfoFrameInstance.Width = 100f;
                            HealthDisplay.AttributeIconTypeState = AbbatoirIntergrade.GumRuntimes.infodisplays.AttributeIconRuntime.AttributeType.Health;
                            HealthDisplay.AttributeText = "5";
                            HealthDisplay.Height = 20f;
                            HealthDisplay.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            HealthDisplay.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "StatsContainer") ?? this;
                            HealthDisplay.Width = 100f;
                            HealthDisplay.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            SpeedDisplay.AttributeIconTypeState = AbbatoirIntergrade.GumRuntimes.infodisplays.AttributeIconRuntime.AttributeType.MoveSpeed;
                            SpeedDisplay.AttributeText = "200";
                            SpeedDisplay.Height = 20f;
                            SpeedDisplay.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            SpeedDisplay.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "StatsContainer") ?? this;
                            SpeedDisplay.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ResistanceContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                            ResistanceContainer.Height = 40f;
                            ResistanceContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ResistanceContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "StatsContainer") ?? this;
                            ResistanceContainer.Width = 100f;
                            ResistanceContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            LeftResistances.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                            LeftResistances.Height = 100f;
                            LeftResistances.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            LeftResistances.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ResistanceContainer") ?? this;
                            LeftResistances.Width = 50f;
                            LeftResistances.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            RightResistances.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                            RightResistances.Height = 100f;
                            RightResistances.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            RightResistances.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ResistanceContainer") ?? this;
                            RightResistances.Width = 50f;
                            RightResistances.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            PiercingResist.DamageTypeIconState = AbbatoirIntergrade.GumRuntimes.infodisplays.DamageTypeIconRuntime.DamageType.Piercing;
                            PiercingResist.Height = 33.3f;
                            PiercingResist.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            PiercingResist.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "LeftResistances") ?? this;
                            PiercingResist.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ChemicalResist.DamageTypeIconState = AbbatoirIntergrade.GumRuntimes.infodisplays.DamageTypeIconRuntime.DamageType.Chemical;
                            ChemicalResist.Height = 33.3f;
                            ChemicalResist.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ChemicalResist.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "LeftResistances") ?? this;
                            ChemicalResist.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            FrostResist.DamageTypeIconState = AbbatoirIntergrade.GumRuntimes.infodisplays.DamageTypeIconRuntime.DamageType.Frost;
                            FrostResist.Height = 33.3f;
                            FrostResist.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            FrostResist.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "LeftResistances") ?? this;
                            FrostResist.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            BombardResist.DamageTypeIconState = AbbatoirIntergrade.GumRuntimes.infodisplays.DamageTypeIconRuntime.DamageType.Bombarding;
                            BombardResist.Height = 33.3f;
                            BombardResist.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            BombardResist.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "RightResistances") ?? this;
                            BombardResist.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ElectricResist.DamageTypeIconState = AbbatoirIntergrade.GumRuntimes.infodisplays.DamageTypeIconRuntime.DamageType.Electric;
                            ElectricResist.Height = 33.3f;
                            ElectricResist.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            ElectricResist.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "RightResistances") ?? this;
                            ElectricResist.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            FireResist.DamageTypeIconState = AbbatoirIntergrade.GumRuntimes.infodisplays.DamageTypeIconRuntime.DamageType.Fire;
                            FireResist.Height = 33.3f;
                            FireResist.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            FireResist.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "RightResistances") ?? this;
                            FireResist.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                            break;
                    }
                }
            }
            public HasMelee? CurrentHasMeleeState
            {
                get
                {
                    return mCurrentHasMeleeState;
                }
                set
                {
                    if (value != null)
                    {
                        mCurrentHasMeleeState = value;
                        switch(mCurrentHasMeleeState)
                        {
                            case  HasMelee.True:
                                break;
                            case  HasMelee.False:
                                break;
                        }
                    }
                }
            }
            public HasRanged? CurrentHasRangedState
            {
                get
                {
                    return mCurrentHasRangedState;
                }
                set
                {
                    if (value != null)
                    {
                        mCurrentHasRangedState = value;
                        switch(mCurrentHasRangedState)
                        {
                            case  HasRanged.True:
                                break;
                            case  HasRanged.False:
                                break;
                        }
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
                bool setBombardResistHeightFirstValue = false;
                bool setBombardResistHeightSecondValue = false;
                float BombardResistHeightFirstValue= 0;
                float BombardResistHeightSecondValue= 0;
                bool setChemicalResistHeightFirstValue = false;
                bool setChemicalResistHeightSecondValue = false;
                float ChemicalResistHeightFirstValue= 0;
                float ChemicalResistHeightSecondValue= 0;
                bool setElectricResistHeightFirstValue = false;
                bool setElectricResistHeightSecondValue = false;
                float ElectricResistHeightFirstValue= 0;
                float ElectricResistHeightSecondValue= 0;
                bool setFireResistHeightFirstValue = false;
                bool setFireResistHeightSecondValue = false;
                float FireResistHeightFirstValue= 0;
                float FireResistHeightSecondValue= 0;
                bool setFrostResistHeightFirstValue = false;
                bool setFrostResistHeightSecondValue = false;
                float FrostResistHeightFirstValue= 0;
                float FrostResistHeightSecondValue= 0;
                bool setHealthDisplayHeightFirstValue = false;
                bool setHealthDisplayHeightSecondValue = false;
                float HealthDisplayHeightFirstValue= 0;
                float HealthDisplayHeightSecondValue= 0;
                bool setHealthDisplayWidthFirstValue = false;
                bool setHealthDisplayWidthSecondValue = false;
                float HealthDisplayWidthFirstValue= 0;
                float HealthDisplayWidthSecondValue= 0;
                bool setHeightFirstValue = false;
                bool setHeightSecondValue = false;
                float HeightFirstValue= 0;
                float HeightSecondValue= 0;
                bool setLeftResistancesHeightFirstValue = false;
                bool setLeftResistancesHeightSecondValue = false;
                float LeftResistancesHeightFirstValue= 0;
                float LeftResistancesHeightSecondValue= 0;
                bool setLeftResistancesWidthFirstValue = false;
                bool setLeftResistancesWidthSecondValue = false;
                float LeftResistancesWidthFirstValue= 0;
                float LeftResistancesWidthSecondValue= 0;
                bool setNameContainerHeightFirstValue = false;
                bool setNameContainerHeightSecondValue = false;
                float NameContainerHeightFirstValue= 0;
                float NameContainerHeightSecondValue= 0;
                bool setNameContainerWidthFirstValue = false;
                bool setNameContainerWidthSecondValue = false;
                float NameContainerWidthFirstValue= 0;
                float NameContainerWidthSecondValue= 0;
                bool setNameTextFontScaleFirstValue = false;
                bool setNameTextFontScaleSecondValue = false;
                float NameTextFontScaleFirstValue= 0;
                float NameTextFontScaleSecondValue= 0;
                bool setNameTextFontSizeFirstValue = false;
                bool setNameTextFontSizeSecondValue = false;
                int NameTextFontSizeFirstValue= 0;
                int NameTextFontSizeSecondValue= 0;
                bool setNameTextHeightFirstValue = false;
                bool setNameTextHeightSecondValue = false;
                float NameTextHeightFirstValue= 0;
                float NameTextHeightSecondValue= 0;
                bool setNameTextOutlineThicknessFirstValue = false;
                bool setNameTextOutlineThicknessSecondValue = false;
                int NameTextOutlineThicknessFirstValue= 0;
                int NameTextOutlineThicknessSecondValue= 0;
                bool setNameTextXFirstValue = false;
                bool setNameTextXSecondValue = false;
                float NameTextXFirstValue= 0;
                float NameTextXSecondValue= 0;
                bool setNameTextYFirstValue = false;
                bool setNameTextYSecondValue = false;
                float NameTextYFirstValue= 0;
                float NameTextYSecondValue= 0;
                bool setPiercingResistHeightFirstValue = false;
                bool setPiercingResistHeightSecondValue = false;
                float PiercingResistHeightFirstValue= 0;
                float PiercingResistHeightSecondValue= 0;
                bool setResistanceContainerHeightFirstValue = false;
                bool setResistanceContainerHeightSecondValue = false;
                float ResistanceContainerHeightFirstValue= 0;
                float ResistanceContainerHeightSecondValue= 0;
                bool setResistanceContainerWidthFirstValue = false;
                bool setResistanceContainerWidthSecondValue = false;
                float ResistanceContainerWidthFirstValue= 0;
                float ResistanceContainerWidthSecondValue= 0;
                bool setRightResistancesHeightFirstValue = false;
                bool setRightResistancesHeightSecondValue = false;
                float RightResistancesHeightFirstValue= 0;
                float RightResistancesHeightSecondValue= 0;
                bool setRightResistancesWidthFirstValue = false;
                bool setRightResistancesWidthSecondValue = false;
                float RightResistancesWidthFirstValue= 0;
                float RightResistancesWidthSecondValue= 0;
                bool setSpeedDisplayHeightFirstValue = false;
                bool setSpeedDisplayHeightSecondValue = false;
                float SpeedDisplayHeightFirstValue= 0;
                float SpeedDisplayHeightSecondValue= 0;
                bool setStatsContainerHeightFirstValue = false;
                bool setStatsContainerHeightSecondValue = false;
                float StatsContainerHeightFirstValue= 0;
                float StatsContainerHeightSecondValue= 0;
                bool setStatsContainerWidthFirstValue = false;
                bool setStatsContainerWidthSecondValue = false;
                float StatsContainerWidthFirstValue= 0;
                float StatsContainerWidthSecondValue= 0;
                bool setStatsContainerXFirstValue = false;
                bool setStatsContainerXSecondValue = false;
                float StatsContainerXFirstValue= 0;
                float StatsContainerXSecondValue= 0;
                bool setStatsContainerYFirstValue = false;
                bool setStatsContainerYSecondValue = false;
                float StatsContainerYFirstValue= 0;
                float StatsContainerYSecondValue= 0;
                bool setTallInfoFrameInstanceHeightFirstValue = false;
                bool setTallInfoFrameInstanceHeightSecondValue = false;
                float TallInfoFrameInstanceHeightFirstValue= 0;
                float TallInfoFrameInstanceHeightSecondValue= 0;
                bool setTallInfoFrameInstanceWidthFirstValue = false;
                bool setTallInfoFrameInstanceWidthSecondValue = false;
                float TallInfoFrameInstanceWidthFirstValue= 0;
                float TallInfoFrameInstanceWidthSecondValue= 0;
                bool setWidthFirstValue = false;
                bool setWidthSecondValue = false;
                float WidthFirstValue= 0;
                float WidthSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        if (interpolationValue < 1)
                        {
                            this.BombardResist.DamageTypeIconState = AbbatoirIntergrade.GumRuntimes.infodisplays.DamageTypeIconRuntime.DamageType.Bombarding;
                        }
                        setBombardResistHeightFirstValue = true;
                        BombardResistHeightFirstValue = 33.3f;
                        if (interpolationValue < 1)
                        {
                            this.BombardResist.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.BombardResist.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "RightResistances") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.BombardResist.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ChemicalResist.DamageTypeIconState = AbbatoirIntergrade.GumRuntimes.infodisplays.DamageTypeIconRuntime.DamageType.Chemical;
                        }
                        setChemicalResistHeightFirstValue = true;
                        ChemicalResistHeightFirstValue = 33.3f;
                        if (interpolationValue < 1)
                        {
                            this.ChemicalResist.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ChemicalResist.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "LeftResistances") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ChemicalResist.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ChildrenLayout = Gum.Managers.ChildrenLayout.Regular;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ClipsChildren = false;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ElectricResist.DamageTypeIconState = AbbatoirIntergrade.GumRuntimes.infodisplays.DamageTypeIconRuntime.DamageType.Electric;
                        }
                        setElectricResistHeightFirstValue = true;
                        ElectricResistHeightFirstValue = 33.3f;
                        if (interpolationValue < 1)
                        {
                            this.ElectricResist.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ElectricResist.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "RightResistances") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ElectricResist.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.FireResist.DamageTypeIconState = AbbatoirIntergrade.GumRuntimes.infodisplays.DamageTypeIconRuntime.DamageType.Fire;
                        }
                        setFireResistHeightFirstValue = true;
                        FireResistHeightFirstValue = 33.3f;
                        if (interpolationValue < 1)
                        {
                            this.FireResist.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.FireResist.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "RightResistances") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.FireResist.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.FrostResist.DamageTypeIconState = AbbatoirIntergrade.GumRuntimes.infodisplays.DamageTypeIconRuntime.DamageType.Frost;
                        }
                        setFrostResistHeightFirstValue = true;
                        FrostResistHeightFirstValue = 33.3f;
                        if (interpolationValue < 1)
                        {
                            this.FrostResist.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.FrostResist.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "LeftResistances") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.FrostResist.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.HealthDisplay.AttributeIconTypeState = AbbatoirIntergrade.GumRuntimes.infodisplays.AttributeIconRuntime.AttributeType.Health;
                        }
                        if (interpolationValue < 1)
                        {
                            this.HealthDisplay.AttributeText = "5";
                        }
                        setHealthDisplayHeightFirstValue = true;
                        HealthDisplayHeightFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.HealthDisplay.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.HealthDisplay.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "StatsContainer") ?? this;
                        }
                        setHealthDisplayWidthFirstValue = true;
                        HealthDisplayWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.HealthDisplay.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setHeightFirstValue = true;
                        HeightFirstValue = 35.55556f;
                        if (interpolationValue < 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.LeftResistances.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setLeftResistancesHeightFirstValue = true;
                        LeftResistancesHeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.LeftResistances.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.LeftResistances.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ResistanceContainer") ?? this;
                        }
                        setLeftResistancesWidthFirstValue = true;
                        LeftResistancesWidthFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.LeftResistances.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setNameContainerHeightFirstValue = true;
                        NameContainerHeightFirstValue = 19f;
                        if (interpolationValue < 1)
                        {
                            this.NameContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.NameContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "StatsContainer") ?? this;
                        }
                        setNameContainerWidthFirstValue = true;
                        NameContainerWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.NameContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("NameText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        if (interpolationValue < 1)
                        {
                            this.NameText.Font = "Moire ExtraBold";
                        }
                        setNameTextFontScaleFirstValue = true;
                        NameTextFontScaleFirstValue = 0.8f;
                        setNameTextFontSizeFirstValue = true;
                        NameTextFontSizeFirstValue = 50;
                        setNameTextHeightFirstValue = true;
                        NameTextHeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.NameText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.NameText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setNameTextOutlineThicknessFirstValue = true;
                        NameTextOutlineThicknessFirstValue = 2;
                        if (interpolationValue < 1)
                        {
                            this.NameText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "NameContainer") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.NameText.Text = "Enemy";
                        }
                        if (interpolationValue < 1)
                        {
                            this.NameText.UseCustomFont = true;
                        }
                        if (interpolationValue < 1)
                        {
                            this.NameText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue < 1)
                        {
                            this.NameText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setNameTextXFirstValue = true;
                        NameTextXFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.NameText.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setNameTextYFirstValue = true;
                        NameTextYFirstValue = 0f;
                        if (interpolationValue < 1)
                        {
                            this.NameText.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.PiercingResist.DamageTypeIconState = AbbatoirIntergrade.GumRuntimes.infodisplays.DamageTypeIconRuntime.DamageType.Piercing;
                        }
                        setPiercingResistHeightFirstValue = true;
                        PiercingResistHeightFirstValue = 33.3f;
                        if (interpolationValue < 1)
                        {
                            this.PiercingResist.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.PiercingResist.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "LeftResistances") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.PiercingResist.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ResistanceContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setResistanceContainerHeightFirstValue = true;
                        ResistanceContainerHeightFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.ResistanceContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ResistanceContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "StatsContainer") ?? this;
                        }
                        setResistanceContainerWidthFirstValue = true;
                        ResistanceContainerWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.ResistanceContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.RightResistances.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setRightResistancesHeightFirstValue = true;
                        RightResistancesHeightFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.RightResistances.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.RightResistances.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ResistanceContainer") ?? this;
                        }
                        setRightResistancesWidthFirstValue = true;
                        RightResistancesWidthFirstValue = 50f;
                        if (interpolationValue < 1)
                        {
                            this.RightResistances.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SpeedDisplay.AttributeIconTypeState = AbbatoirIntergrade.GumRuntimes.infodisplays.AttributeIconRuntime.AttributeType.MoveSpeed;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SpeedDisplay.AttributeText = "200";
                        }
                        setSpeedDisplayHeightFirstValue = true;
                        SpeedDisplayHeightFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.SpeedDisplay.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SpeedDisplay.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "StatsContainer") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SpeedDisplay.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.StatsContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setStatsContainerHeightFirstValue = true;
                        StatsContainerHeightFirstValue = 88.80209f;
                        if (interpolationValue < 1)
                        {
                            this.StatsContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.StatsContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "TallInfoFrameInstance") ?? this;
                        }
                        setStatsContainerWidthFirstValue = true;
                        StatsContainerWidthFirstValue = 67.44791f;
                        if (interpolationValue < 1)
                        {
                            this.StatsContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue < 1)
                        {
                            this.StatsContainer.WrapsChildren = true;
                        }
                        setStatsContainerXFirstValue = true;
                        StatsContainerXFirstValue = 83f;
                        setStatsContainerYFirstValue = true;
                        StatsContainerYFirstValue = 29f;
                        setTallInfoFrameInstanceHeightFirstValue = true;
                        TallInfoFrameInstanceHeightFirstValue = 100f;
                        setTallInfoFrameInstanceWidthFirstValue = true;
                        TallInfoFrameInstanceWidthFirstValue = 100f;
                        if (interpolationValue < 1)
                        {
                            this.Visible = true;
                        }
                        setWidthFirstValue = true;
                        WidthFirstValue = 20f;
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
                            this.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddleInverted;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        if (interpolationValue >= 1)
                        {
                            this.BombardResist.DamageTypeIconState = AbbatoirIntergrade.GumRuntimes.infodisplays.DamageTypeIconRuntime.DamageType.Bombarding;
                        }
                        setBombardResistHeightSecondValue = true;
                        BombardResistHeightSecondValue = 33.3f;
                        if (interpolationValue >= 1)
                        {
                            this.BombardResist.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.BombardResist.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "RightResistances") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.BombardResist.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ChemicalResist.DamageTypeIconState = AbbatoirIntergrade.GumRuntimes.infodisplays.DamageTypeIconRuntime.DamageType.Chemical;
                        }
                        setChemicalResistHeightSecondValue = true;
                        ChemicalResistHeightSecondValue = 33.3f;
                        if (interpolationValue >= 1)
                        {
                            this.ChemicalResist.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ChemicalResist.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "LeftResistances") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ChemicalResist.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ChildrenLayout = Gum.Managers.ChildrenLayout.Regular;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ClipsChildren = false;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ElectricResist.DamageTypeIconState = AbbatoirIntergrade.GumRuntimes.infodisplays.DamageTypeIconRuntime.DamageType.Electric;
                        }
                        setElectricResistHeightSecondValue = true;
                        ElectricResistHeightSecondValue = 33.3f;
                        if (interpolationValue >= 1)
                        {
                            this.ElectricResist.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ElectricResist.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "RightResistances") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ElectricResist.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.FireResist.DamageTypeIconState = AbbatoirIntergrade.GumRuntimes.infodisplays.DamageTypeIconRuntime.DamageType.Fire;
                        }
                        setFireResistHeightSecondValue = true;
                        FireResistHeightSecondValue = 33.3f;
                        if (interpolationValue >= 1)
                        {
                            this.FireResist.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.FireResist.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "RightResistances") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.FireResist.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.FrostResist.DamageTypeIconState = AbbatoirIntergrade.GumRuntimes.infodisplays.DamageTypeIconRuntime.DamageType.Frost;
                        }
                        setFrostResistHeightSecondValue = true;
                        FrostResistHeightSecondValue = 33.3f;
                        if (interpolationValue >= 1)
                        {
                            this.FrostResist.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.FrostResist.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "LeftResistances") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.FrostResist.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HealthDisplay.AttributeIconTypeState = AbbatoirIntergrade.GumRuntimes.infodisplays.AttributeIconRuntime.AttributeType.Health;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HealthDisplay.AttributeText = "5";
                        }
                        setHealthDisplayHeightSecondValue = true;
                        HealthDisplayHeightSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.HealthDisplay.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.HealthDisplay.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "StatsContainer") ?? this;
                        }
                        setHealthDisplayWidthSecondValue = true;
                        HealthDisplayWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.HealthDisplay.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setHeightSecondValue = true;
                        HeightSecondValue = 35.55556f;
                        if (interpolationValue >= 1)
                        {
                            this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.LeftResistances.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setLeftResistancesHeightSecondValue = true;
                        LeftResistancesHeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.LeftResistances.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.LeftResistances.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ResistanceContainer") ?? this;
                        }
                        setLeftResistancesWidthSecondValue = true;
                        LeftResistancesWidthSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.LeftResistances.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setNameContainerHeightSecondValue = true;
                        NameContainerHeightSecondValue = 19f;
                        if (interpolationValue >= 1)
                        {
                            this.NameContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.NameContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "StatsContainer") ?? this;
                        }
                        setNameContainerWidthSecondValue = true;
                        NameContainerWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.NameContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("NameText.CustomFontFile", "../globalcontent/Font50MoireExtraBold.fnt");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.NameText.Font = "Moire ExtraBold";
                        }
                        setNameTextFontScaleSecondValue = true;
                        NameTextFontScaleSecondValue = 0.8f;
                        setNameTextFontSizeSecondValue = true;
                        NameTextFontSizeSecondValue = 50;
                        setNameTextHeightSecondValue = true;
                        NameTextHeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.NameText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.NameText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setNameTextOutlineThicknessSecondValue = true;
                        NameTextOutlineThicknessSecondValue = 2;
                        if (interpolationValue >= 1)
                        {
                            this.NameText.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "NameContainer") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.NameText.Text = "Enemy";
                        }
                        if (interpolationValue >= 1)
                        {
                            this.NameText.UseCustomFont = true;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.NameText.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.NameText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        setNameTextXSecondValue = true;
                        NameTextXSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.NameText.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        setNameTextYSecondValue = true;
                        NameTextYSecondValue = 0f;
                        if (interpolationValue >= 1)
                        {
                            this.NameText.YUnits = Gum.Converters.GeneralUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PiercingResist.DamageTypeIconState = AbbatoirIntergrade.GumRuntimes.infodisplays.DamageTypeIconRuntime.DamageType.Piercing;
                        }
                        setPiercingResistHeightSecondValue = true;
                        PiercingResistHeightSecondValue = 33.3f;
                        if (interpolationValue >= 1)
                        {
                            this.PiercingResist.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PiercingResist.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "LeftResistances") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PiercingResist.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ResistanceContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.LeftToRightStack;
                        }
                        setResistanceContainerHeightSecondValue = true;
                        ResistanceContainerHeightSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.ResistanceContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ResistanceContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "StatsContainer") ?? this;
                        }
                        setResistanceContainerWidthSecondValue = true;
                        ResistanceContainerWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.ResistanceContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.RightResistances.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setRightResistancesHeightSecondValue = true;
                        RightResistancesHeightSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.RightResistances.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.RightResistances.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "ResistanceContainer") ?? this;
                        }
                        setRightResistancesWidthSecondValue = true;
                        RightResistancesWidthSecondValue = 50f;
                        if (interpolationValue >= 1)
                        {
                            this.RightResistances.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SpeedDisplay.AttributeIconTypeState = AbbatoirIntergrade.GumRuntimes.infodisplays.AttributeIconRuntime.AttributeType.MoveSpeed;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SpeedDisplay.AttributeText = "200";
                        }
                        setSpeedDisplayHeightSecondValue = true;
                        SpeedDisplayHeightSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.SpeedDisplay.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SpeedDisplay.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "StatsContainer") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SpeedDisplay.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.StatsContainer.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        }
                        setStatsContainerHeightSecondValue = true;
                        StatsContainerHeightSecondValue = 88.80209f;
                        if (interpolationValue >= 1)
                        {
                            this.StatsContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.StatsContainer.Parent = this.ContainedElements.FirstOrDefault(item =>item.Name == "TallInfoFrameInstance") ?? this;
                        }
                        setStatsContainerWidthSecondValue = true;
                        StatsContainerWidthSecondValue = 67.44791f;
                        if (interpolationValue >= 1)
                        {
                            this.StatsContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.StatsContainer.WrapsChildren = true;
                        }
                        setStatsContainerXSecondValue = true;
                        StatsContainerXSecondValue = 83f;
                        setStatsContainerYSecondValue = true;
                        StatsContainerYSecondValue = 29f;
                        setTallInfoFrameInstanceHeightSecondValue = true;
                        TallInfoFrameInstanceHeightSecondValue = 100f;
                        setTallInfoFrameInstanceWidthSecondValue = true;
                        TallInfoFrameInstanceWidthSecondValue = 100f;
                        if (interpolationValue >= 1)
                        {
                            this.Visible = true;
                        }
                        setWidthSecondValue = true;
                        WidthSecondValue = 20f;
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
                            this.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddleInverted;
                        }
                        break;
                }
                if (setBombardResistHeightFirstValue && setBombardResistHeightSecondValue)
                {
                    BombardResist.Height = BombardResistHeightFirstValue * (1 - interpolationValue) + BombardResistHeightSecondValue * interpolationValue;
                }
                if (setChemicalResistHeightFirstValue && setChemicalResistHeightSecondValue)
                {
                    ChemicalResist.Height = ChemicalResistHeightFirstValue * (1 - interpolationValue) + ChemicalResistHeightSecondValue * interpolationValue;
                }
                if (setElectricResistHeightFirstValue && setElectricResistHeightSecondValue)
                {
                    ElectricResist.Height = ElectricResistHeightFirstValue * (1 - interpolationValue) + ElectricResistHeightSecondValue * interpolationValue;
                }
                if (setFireResistHeightFirstValue && setFireResistHeightSecondValue)
                {
                    FireResist.Height = FireResistHeightFirstValue * (1 - interpolationValue) + FireResistHeightSecondValue * interpolationValue;
                }
                if (setFrostResistHeightFirstValue && setFrostResistHeightSecondValue)
                {
                    FrostResist.Height = FrostResistHeightFirstValue * (1 - interpolationValue) + FrostResistHeightSecondValue * interpolationValue;
                }
                if (setHealthDisplayHeightFirstValue && setHealthDisplayHeightSecondValue)
                {
                    HealthDisplay.Height = HealthDisplayHeightFirstValue * (1 - interpolationValue) + HealthDisplayHeightSecondValue * interpolationValue;
                }
                if (setHealthDisplayWidthFirstValue && setHealthDisplayWidthSecondValue)
                {
                    HealthDisplay.Width = HealthDisplayWidthFirstValue * (1 - interpolationValue) + HealthDisplayWidthSecondValue * interpolationValue;
                }
                if (setHeightFirstValue && setHeightSecondValue)
                {
                    Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
                }
                if (setLeftResistancesHeightFirstValue && setLeftResistancesHeightSecondValue)
                {
                    LeftResistances.Height = LeftResistancesHeightFirstValue * (1 - interpolationValue) + LeftResistancesHeightSecondValue * interpolationValue;
                }
                if (setLeftResistancesWidthFirstValue && setLeftResistancesWidthSecondValue)
                {
                    LeftResistances.Width = LeftResistancesWidthFirstValue * (1 - interpolationValue) + LeftResistancesWidthSecondValue * interpolationValue;
                }
                if (setNameContainerHeightFirstValue && setNameContainerHeightSecondValue)
                {
                    NameContainer.Height = NameContainerHeightFirstValue * (1 - interpolationValue) + NameContainerHeightSecondValue * interpolationValue;
                }
                if (setNameContainerWidthFirstValue && setNameContainerWidthSecondValue)
                {
                    NameContainer.Width = NameContainerWidthFirstValue * (1 - interpolationValue) + NameContainerWidthSecondValue * interpolationValue;
                }
                if (setNameTextFontScaleFirstValue && setNameTextFontScaleSecondValue)
                {
                    NameText.FontScale = NameTextFontScaleFirstValue * (1 - interpolationValue) + NameTextFontScaleSecondValue * interpolationValue;
                }
                if (setNameTextFontSizeFirstValue && setNameTextFontSizeSecondValue)
                {
                    NameText.FontSize = FlatRedBall.Math.MathFunctions.RoundToInt(NameTextFontSizeFirstValue* (1 - interpolationValue) + NameTextFontSizeSecondValue * interpolationValue);
                }
                if (setNameTextHeightFirstValue && setNameTextHeightSecondValue)
                {
                    NameText.Height = NameTextHeightFirstValue * (1 - interpolationValue) + NameTextHeightSecondValue * interpolationValue;
                }
                if (setNameTextOutlineThicknessFirstValue && setNameTextOutlineThicknessSecondValue)
                {
                    NameText.OutlineThickness = FlatRedBall.Math.MathFunctions.RoundToInt(NameTextOutlineThicknessFirstValue* (1 - interpolationValue) + NameTextOutlineThicknessSecondValue * interpolationValue);
                }
                if (setNameTextXFirstValue && setNameTextXSecondValue)
                {
                    NameText.X = NameTextXFirstValue * (1 - interpolationValue) + NameTextXSecondValue * interpolationValue;
                }
                if (setNameTextYFirstValue && setNameTextYSecondValue)
                {
                    NameText.Y = NameTextYFirstValue * (1 - interpolationValue) + NameTextYSecondValue * interpolationValue;
                }
                if (setPiercingResistHeightFirstValue && setPiercingResistHeightSecondValue)
                {
                    PiercingResist.Height = PiercingResistHeightFirstValue * (1 - interpolationValue) + PiercingResistHeightSecondValue * interpolationValue;
                }
                if (setResistanceContainerHeightFirstValue && setResistanceContainerHeightSecondValue)
                {
                    ResistanceContainer.Height = ResistanceContainerHeightFirstValue * (1 - interpolationValue) + ResistanceContainerHeightSecondValue * interpolationValue;
                }
                if (setResistanceContainerWidthFirstValue && setResistanceContainerWidthSecondValue)
                {
                    ResistanceContainer.Width = ResistanceContainerWidthFirstValue * (1 - interpolationValue) + ResistanceContainerWidthSecondValue * interpolationValue;
                }
                if (setRightResistancesHeightFirstValue && setRightResistancesHeightSecondValue)
                {
                    RightResistances.Height = RightResistancesHeightFirstValue * (1 - interpolationValue) + RightResistancesHeightSecondValue * interpolationValue;
                }
                if (setRightResistancesWidthFirstValue && setRightResistancesWidthSecondValue)
                {
                    RightResistances.Width = RightResistancesWidthFirstValue * (1 - interpolationValue) + RightResistancesWidthSecondValue * interpolationValue;
                }
                if (setSpeedDisplayHeightFirstValue && setSpeedDisplayHeightSecondValue)
                {
                    SpeedDisplay.Height = SpeedDisplayHeightFirstValue * (1 - interpolationValue) + SpeedDisplayHeightSecondValue * interpolationValue;
                }
                if (setStatsContainerHeightFirstValue && setStatsContainerHeightSecondValue)
                {
                    StatsContainer.Height = StatsContainerHeightFirstValue * (1 - interpolationValue) + StatsContainerHeightSecondValue * interpolationValue;
                }
                if (setStatsContainerWidthFirstValue && setStatsContainerWidthSecondValue)
                {
                    StatsContainer.Width = StatsContainerWidthFirstValue * (1 - interpolationValue) + StatsContainerWidthSecondValue * interpolationValue;
                }
                if (setStatsContainerXFirstValue && setStatsContainerXSecondValue)
                {
                    StatsContainer.X = StatsContainerXFirstValue * (1 - interpolationValue) + StatsContainerXSecondValue * interpolationValue;
                }
                if (setStatsContainerYFirstValue && setStatsContainerYSecondValue)
                {
                    StatsContainer.Y = StatsContainerYFirstValue * (1 - interpolationValue) + StatsContainerYSecondValue * interpolationValue;
                }
                if (setTallInfoFrameInstanceHeightFirstValue && setTallInfoFrameInstanceHeightSecondValue)
                {
                    TallInfoFrameInstance.Height = TallInfoFrameInstanceHeightFirstValue * (1 - interpolationValue) + TallInfoFrameInstanceHeightSecondValue * interpolationValue;
                }
                if (setTallInfoFrameInstanceWidthFirstValue && setTallInfoFrameInstanceWidthSecondValue)
                {
                    TallInfoFrameInstance.Width = TallInfoFrameInstanceWidthFirstValue * (1 - interpolationValue) + TallInfoFrameInstanceWidthSecondValue * interpolationValue;
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
            public void InterpolateBetween (HasMelee firstState, HasMelee secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                switch(firstState)
                {
                    case  HasMelee.True:
                        break;
                    case  HasMelee.False:
                        break;
                }
                switch(secondState)
                {
                    case  HasMelee.True:
                        break;
                    case  HasMelee.False:
                        break;
                }
                if (interpolationValue < 1)
                {
                    mCurrentHasMeleeState = firstState;
                }
                else
                {
                    mCurrentHasMeleeState = secondState;
                }
            }
            public void InterpolateBetween (HasRanged firstState, HasRanged secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                switch(firstState)
                {
                    case  HasRanged.True:
                        break;
                    case  HasRanged.False:
                        break;
                }
                switch(secondState)
                {
                    case  HasRanged.True:
                        break;
                    case  HasRanged.False:
                        break;
                }
                if (interpolationValue < 1)
                {
                    mCurrentHasRangedState = firstState;
                }
                else
                {
                    mCurrentHasRangedState = secondState;
                }
            }
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.infodisplays.EnemyInfoRuntime.VariableState fromState,AbbatoirIntergrade.GumRuntimes.infodisplays.EnemyInfoRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.infodisplays.EnemyInfoRuntime.HasMelee fromState,AbbatoirIntergrade.GumRuntimes.infodisplays.EnemyInfoRuntime.HasMelee toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (HasMelee toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "HasMelee").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentHasMeleeState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (HasMelee toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentHasMeleeState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (AbbatoirIntergrade.GumRuntimes.infodisplays.EnemyInfoRuntime.HasRanged fromState,AbbatoirIntergrade.GumRuntimes.infodisplays.EnemyInfoRuntime.HasRanged toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (HasRanged toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "HasRanged").States.First(item => item.Name == toState.ToString());
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
                tweener.Ended += ()=> this.CurrentHasRangedState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (HasRanged toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
                tweener.Ended += ()=> this.CurrentHasRangedState = toState;
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
                TallInfoFrameInstance.StopAnimations();
                HealthDisplay.StopAnimations();
                SpeedDisplay.StopAnimations();
                PiercingResist.StopAnimations();
                ChemicalResist.StopAnimations();
                FrostResist.StopAnimations();
                BombardResist.StopAnimations();
                ElectricResist.StopAnimations();
                FireResist.StopAnimations();
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
                            Name = "StatsContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = StatsContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StatsContainer.Height",
                            Type = "float",
                            Value = StatsContainer.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StatsContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = StatsContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StatsContainer.Parent",
                            Type = "string",
                            Value = StatsContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StatsContainer.Width",
                            Type = "float",
                            Value = StatsContainer.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StatsContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = StatsContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StatsContainer.Wraps Children",
                            Type = "bool",
                            Value = StatsContainer.WrapsChildren
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StatsContainer.X",
                            Type = "float",
                            Value = StatsContainer.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StatsContainer.Y",
                            Type = "float",
                            Value = StatsContainer.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameContainer.Height",
                            Type = "float",
                            Value = NameContainer.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = NameContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameContainer.Parent",
                            Type = "string",
                            Value = NameContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameContainer.Width",
                            Type = "float",
                            Value = NameContainer.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = NameContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.CustomFontFile",
                            Type = "string",
                            Value = NameText.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Font",
                            Type = "string",
                            Value = NameText.Font
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Font Scale",
                            Type = "float",
                            Value = NameText.FontScale
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.FontSize",
                            Type = "int",
                            Value = NameText.FontSize
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Height",
                            Type = "float",
                            Value = NameText.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Height Units",
                            Type = "DimensionUnitType",
                            Value = NameText.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = NameText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.OutlineThickness",
                            Type = "int",
                            Value = NameText.OutlineThickness
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Parent",
                            Type = "string",
                            Value = NameText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Text",
                            Type = "string",
                            Value = NameText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.UseCustomFont",
                            Type = "bool",
                            Value = NameText.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = NameText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Width Units",
                            Type = "DimensionUnitType",
                            Value = NameText.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.X",
                            Type = "float",
                            Value = NameText.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.X Units",
                            Type = "PositionUnitType",
                            Value = NameText.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Y",
                            Type = "float",
                            Value = NameText.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Y Units",
                            Type = "PositionUnitType",
                            Value = NameText.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TallInfoFrameInstance.Height",
                            Type = "float",
                            Value = TallInfoFrameInstance.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TallInfoFrameInstance.Width",
                            Type = "float",
                            Value = TallInfoFrameInstance.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthDisplay.AttributeIconTypeState",
                            Type = "AttributeTypeState",
                            Value = HealthDisplay.AttributeIconTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthDisplay.AttributeText",
                            Type = "string",
                            Value = HealthDisplay.AttributeText
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthDisplay.Height",
                            Type = "float",
                            Value = HealthDisplay.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthDisplay.Height Units",
                            Type = "DimensionUnitType",
                            Value = HealthDisplay.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthDisplay.Parent",
                            Type = "string",
                            Value = HealthDisplay.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthDisplay.Width",
                            Type = "float",
                            Value = HealthDisplay.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthDisplay.Width Units",
                            Type = "DimensionUnitType",
                            Value = HealthDisplay.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpeedDisplay.AttributeIconTypeState",
                            Type = "AttributeTypeState",
                            Value = SpeedDisplay.AttributeIconTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpeedDisplay.AttributeText",
                            Type = "string",
                            Value = SpeedDisplay.AttributeText
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpeedDisplay.Height",
                            Type = "float",
                            Value = SpeedDisplay.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpeedDisplay.Height Units",
                            Type = "DimensionUnitType",
                            Value = SpeedDisplay.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpeedDisplay.Parent",
                            Type = "string",
                            Value = SpeedDisplay.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpeedDisplay.Width Units",
                            Type = "DimensionUnitType",
                            Value = SpeedDisplay.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = ResistanceContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceContainer.Height",
                            Type = "float",
                            Value = ResistanceContainer.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = ResistanceContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceContainer.Parent",
                            Type = "string",
                            Value = ResistanceContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceContainer.Width",
                            Type = "float",
                            Value = ResistanceContainer.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = ResistanceContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LeftResistances.Children Layout",
                            Type = "ChildrenLayout",
                            Value = LeftResistances.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LeftResistances.Height",
                            Type = "float",
                            Value = LeftResistances.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LeftResistances.Height Units",
                            Type = "DimensionUnitType",
                            Value = LeftResistances.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LeftResistances.Parent",
                            Type = "string",
                            Value = LeftResistances.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LeftResistances.Width",
                            Type = "float",
                            Value = LeftResistances.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LeftResistances.Width Units",
                            Type = "DimensionUnitType",
                            Value = LeftResistances.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RightResistances.Children Layout",
                            Type = "ChildrenLayout",
                            Value = RightResistances.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RightResistances.Height",
                            Type = "float",
                            Value = RightResistances.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RightResistances.Height Units",
                            Type = "DimensionUnitType",
                            Value = RightResistances.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RightResistances.Parent",
                            Type = "string",
                            Value = RightResistances.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RightResistances.Width",
                            Type = "float",
                            Value = RightResistances.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RightResistances.Width Units",
                            Type = "DimensionUnitType",
                            Value = RightResistances.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PiercingResist.DamageTypeIconState",
                            Type = "DamageTypeState",
                            Value = PiercingResist.DamageTypeIconState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PiercingResist.Height",
                            Type = "float",
                            Value = PiercingResist.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PiercingResist.Height Units",
                            Type = "DimensionUnitType",
                            Value = PiercingResist.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PiercingResist.Parent",
                            Type = "string",
                            Value = PiercingResist.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PiercingResist.Width Units",
                            Type = "DimensionUnitType",
                            Value = PiercingResist.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChemicalResist.DamageTypeIconState",
                            Type = "DamageTypeState",
                            Value = ChemicalResist.DamageTypeIconState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChemicalResist.Height",
                            Type = "float",
                            Value = ChemicalResist.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChemicalResist.Height Units",
                            Type = "DimensionUnitType",
                            Value = ChemicalResist.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChemicalResist.Parent",
                            Type = "string",
                            Value = ChemicalResist.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChemicalResist.Width Units",
                            Type = "DimensionUnitType",
                            Value = ChemicalResist.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FrostResist.DamageTypeIconState",
                            Type = "DamageTypeState",
                            Value = FrostResist.DamageTypeIconState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FrostResist.Height",
                            Type = "float",
                            Value = FrostResist.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FrostResist.Height Units",
                            Type = "DimensionUnitType",
                            Value = FrostResist.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FrostResist.Parent",
                            Type = "string",
                            Value = FrostResist.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FrostResist.Width Units",
                            Type = "DimensionUnitType",
                            Value = FrostResist.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BombardResist.DamageTypeIconState",
                            Type = "DamageTypeState",
                            Value = BombardResist.DamageTypeIconState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BombardResist.Height",
                            Type = "float",
                            Value = BombardResist.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BombardResist.Height Units",
                            Type = "DimensionUnitType",
                            Value = BombardResist.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BombardResist.Parent",
                            Type = "string",
                            Value = BombardResist.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BombardResist.Width Units",
                            Type = "DimensionUnitType",
                            Value = BombardResist.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ElectricResist.DamageTypeIconState",
                            Type = "DamageTypeState",
                            Value = ElectricResist.DamageTypeIconState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ElectricResist.Height",
                            Type = "float",
                            Value = ElectricResist.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ElectricResist.Height Units",
                            Type = "DimensionUnitType",
                            Value = ElectricResist.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ElectricResist.Parent",
                            Type = "string",
                            Value = ElectricResist.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ElectricResist.Width Units",
                            Type = "DimensionUnitType",
                            Value = ElectricResist.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FireResist.DamageTypeIconState",
                            Type = "DamageTypeState",
                            Value = FireResist.DamageTypeIconState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FireResist.Height",
                            Type = "float",
                            Value = FireResist.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FireResist.Height Units",
                            Type = "DimensionUnitType",
                            Value = FireResist.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FireResist.Parent",
                            Type = "string",
                            Value = FireResist.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FireResist.Width Units",
                            Type = "DimensionUnitType",
                            Value = FireResist.WidthUnits
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
                            Value = Height + 35.55556f
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
                            Value = Width + 20f
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
                            Name = "StatsContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = StatsContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StatsContainer.Height",
                            Type = "float",
                            Value = StatsContainer.Height + 88.80209f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StatsContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = StatsContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StatsContainer.Parent",
                            Type = "string",
                            Value = StatsContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StatsContainer.Width",
                            Type = "float",
                            Value = StatsContainer.Width + 67.44791f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StatsContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = StatsContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StatsContainer.Wraps Children",
                            Type = "bool",
                            Value = StatsContainer.WrapsChildren
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StatsContainer.X",
                            Type = "float",
                            Value = StatsContainer.X + 83f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StatsContainer.Y",
                            Type = "float",
                            Value = StatsContainer.Y + 29f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameContainer.Height",
                            Type = "float",
                            Value = NameContainer.Height + 19f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = NameContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameContainer.Parent",
                            Type = "string",
                            Value = NameContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameContainer.Width",
                            Type = "float",
                            Value = NameContainer.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = NameContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.CustomFontFile",
                            Type = "string",
                            Value = NameText.CustomFontFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Font",
                            Type = "string",
                            Value = NameText.Font
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Font Scale",
                            Type = "float",
                            Value = NameText.FontScale + 0.8f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.FontSize",
                            Type = "int",
                            Value = NameText.FontSize + 50
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Height",
                            Type = "float",
                            Value = NameText.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Height Units",
                            Type = "DimensionUnitType",
                            Value = NameText.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.HorizontalAlignment",
                            Type = "HorizontalAlignment",
                            Value = NameText.HorizontalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.OutlineThickness",
                            Type = "int",
                            Value = NameText.OutlineThickness + 2
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Parent",
                            Type = "string",
                            Value = NameText.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Text",
                            Type = "string",
                            Value = NameText.Text
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.UseCustomFont",
                            Type = "bool",
                            Value = NameText.UseCustomFont
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.VerticalAlignment",
                            Type = "VerticalAlignment",
                            Value = NameText.VerticalAlignment
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Width Units",
                            Type = "DimensionUnitType",
                            Value = NameText.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.X",
                            Type = "float",
                            Value = NameText.X + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.X Units",
                            Type = "PositionUnitType",
                            Value = NameText.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Y",
                            Type = "float",
                            Value = NameText.Y + 0f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "NameText.Y Units",
                            Type = "PositionUnitType",
                            Value = NameText.YUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TallInfoFrameInstance.Height",
                            Type = "float",
                            Value = TallInfoFrameInstance.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "TallInfoFrameInstance.Width",
                            Type = "float",
                            Value = TallInfoFrameInstance.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthDisplay.AttributeIconTypeState",
                            Type = "AttributeTypeState",
                            Value = HealthDisplay.AttributeIconTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthDisplay.AttributeText",
                            Type = "string",
                            Value = HealthDisplay.AttributeText
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthDisplay.Height",
                            Type = "float",
                            Value = HealthDisplay.Height + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthDisplay.Height Units",
                            Type = "DimensionUnitType",
                            Value = HealthDisplay.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthDisplay.Parent",
                            Type = "string",
                            Value = HealthDisplay.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthDisplay.Width",
                            Type = "float",
                            Value = HealthDisplay.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "HealthDisplay.Width Units",
                            Type = "DimensionUnitType",
                            Value = HealthDisplay.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpeedDisplay.AttributeIconTypeState",
                            Type = "AttributeTypeState",
                            Value = SpeedDisplay.AttributeIconTypeState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpeedDisplay.AttributeText",
                            Type = "string",
                            Value = SpeedDisplay.AttributeText
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpeedDisplay.Height",
                            Type = "float",
                            Value = SpeedDisplay.Height + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpeedDisplay.Height Units",
                            Type = "DimensionUnitType",
                            Value = SpeedDisplay.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpeedDisplay.Parent",
                            Type = "string",
                            Value = SpeedDisplay.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SpeedDisplay.Width Units",
                            Type = "DimensionUnitType",
                            Value = SpeedDisplay.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceContainer.Children Layout",
                            Type = "ChildrenLayout",
                            Value = ResistanceContainer.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceContainer.Height",
                            Type = "float",
                            Value = ResistanceContainer.Height + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceContainer.Height Units",
                            Type = "DimensionUnitType",
                            Value = ResistanceContainer.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceContainer.Parent",
                            Type = "string",
                            Value = ResistanceContainer.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceContainer.Width",
                            Type = "float",
                            Value = ResistanceContainer.Width + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ResistanceContainer.Width Units",
                            Type = "DimensionUnitType",
                            Value = ResistanceContainer.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LeftResistances.Children Layout",
                            Type = "ChildrenLayout",
                            Value = LeftResistances.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LeftResistances.Height",
                            Type = "float",
                            Value = LeftResistances.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LeftResistances.Height Units",
                            Type = "DimensionUnitType",
                            Value = LeftResistances.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LeftResistances.Parent",
                            Type = "string",
                            Value = LeftResistances.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LeftResistances.Width",
                            Type = "float",
                            Value = LeftResistances.Width + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LeftResistances.Width Units",
                            Type = "DimensionUnitType",
                            Value = LeftResistances.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RightResistances.Children Layout",
                            Type = "ChildrenLayout",
                            Value = RightResistances.ChildrenLayout
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RightResistances.Height",
                            Type = "float",
                            Value = RightResistances.Height + 100f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RightResistances.Height Units",
                            Type = "DimensionUnitType",
                            Value = RightResistances.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RightResistances.Parent",
                            Type = "string",
                            Value = RightResistances.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RightResistances.Width",
                            Type = "float",
                            Value = RightResistances.Width + 50f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "RightResistances.Width Units",
                            Type = "DimensionUnitType",
                            Value = RightResistances.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PiercingResist.DamageTypeIconState",
                            Type = "DamageTypeState",
                            Value = PiercingResist.DamageTypeIconState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PiercingResist.Height",
                            Type = "float",
                            Value = PiercingResist.Height + 33.3f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PiercingResist.Height Units",
                            Type = "DimensionUnitType",
                            Value = PiercingResist.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PiercingResist.Parent",
                            Type = "string",
                            Value = PiercingResist.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PiercingResist.Width Units",
                            Type = "DimensionUnitType",
                            Value = PiercingResist.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChemicalResist.DamageTypeIconState",
                            Type = "DamageTypeState",
                            Value = ChemicalResist.DamageTypeIconState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChemicalResist.Height",
                            Type = "float",
                            Value = ChemicalResist.Height + 33.3f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChemicalResist.Height Units",
                            Type = "DimensionUnitType",
                            Value = ChemicalResist.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChemicalResist.Parent",
                            Type = "string",
                            Value = ChemicalResist.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChemicalResist.Width Units",
                            Type = "DimensionUnitType",
                            Value = ChemicalResist.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FrostResist.DamageTypeIconState",
                            Type = "DamageTypeState",
                            Value = FrostResist.DamageTypeIconState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FrostResist.Height",
                            Type = "float",
                            Value = FrostResist.Height + 33.3f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FrostResist.Height Units",
                            Type = "DimensionUnitType",
                            Value = FrostResist.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FrostResist.Parent",
                            Type = "string",
                            Value = FrostResist.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FrostResist.Width Units",
                            Type = "DimensionUnitType",
                            Value = FrostResist.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BombardResist.DamageTypeIconState",
                            Type = "DamageTypeState",
                            Value = BombardResist.DamageTypeIconState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BombardResist.Height",
                            Type = "float",
                            Value = BombardResist.Height + 33.3f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BombardResist.Height Units",
                            Type = "DimensionUnitType",
                            Value = BombardResist.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BombardResist.Parent",
                            Type = "string",
                            Value = BombardResist.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BombardResist.Width Units",
                            Type = "DimensionUnitType",
                            Value = BombardResist.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ElectricResist.DamageTypeIconState",
                            Type = "DamageTypeState",
                            Value = ElectricResist.DamageTypeIconState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ElectricResist.Height",
                            Type = "float",
                            Value = ElectricResist.Height + 33.3f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ElectricResist.Height Units",
                            Type = "DimensionUnitType",
                            Value = ElectricResist.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ElectricResist.Parent",
                            Type = "string",
                            Value = ElectricResist.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ElectricResist.Width Units",
                            Type = "DimensionUnitType",
                            Value = ElectricResist.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FireResist.DamageTypeIconState",
                            Type = "DamageTypeState",
                            Value = FireResist.DamageTypeIconState
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FireResist.Height",
                            Type = "float",
                            Value = FireResist.Height + 33.3f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FireResist.Height Units",
                            Type = "DimensionUnitType",
                            Value = FireResist.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FireResist.Parent",
                            Type = "string",
                            Value = FireResist.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FireResist.Width Units",
                            Type = "DimensionUnitType",
                            Value = FireResist.WidthUnits
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (HasMelee state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  HasMelee.True:
                        break;
                    case  HasMelee.False:
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (HasMelee state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  HasMelee.True:
                        break;
                    case  HasMelee.False:
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (HasRanged state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  HasRanged.True:
                        break;
                    case  HasRanged.False:
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (HasRanged state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  HasRanged.True:
                        break;
                    case  HasRanged.False:
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
                    else if (category.Name == "HasMelee")
                    {
                        if(state.Name == "True") this.mCurrentHasMeleeState = HasMelee.True;
                        if(state.Name == "False") this.mCurrentHasMeleeState = HasMelee.False;
                    }
                    else if (category.Name == "HasRanged")
                    {
                        if(state.Name == "True") this.mCurrentHasRangedState = HasRanged.True;
                        if(state.Name == "False") this.mCurrentHasRangedState = HasRanged.False;
                    }
                }
                base.ApplyState(state);
            }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime StatsContainer { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime NameContainer { get; set; }
            private AbbatoirIntergrade.GumRuntimes.TextRuntime NameText { get; set; }
            private AbbatoirIntergrade.GumRuntimes.frames.TallInfoFrameRuntime TallInfoFrameInstance { get; set; }
            private AbbatoirIntergrade.GumRuntimes.infodisplays.AttributeDisplayRuntime HealthDisplay { get; set; }
            private AbbatoirIntergrade.GumRuntimes.infodisplays.AttributeDisplayRuntime SpeedDisplay { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime ResistanceContainer { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime LeftResistances { get; set; }
            private AbbatoirIntergrade.GumRuntimes.ContainerRuntime RightResistances { get; set; }
            private AbbatoirIntergrade.GumRuntimes.infodisplays.ResistanceDisplayRuntime PiercingResist { get; set; }
            private AbbatoirIntergrade.GumRuntimes.infodisplays.ResistanceDisplayRuntime ChemicalResist { get; set; }
            private AbbatoirIntergrade.GumRuntimes.infodisplays.ResistanceDisplayRuntime FrostResist { get; set; }
            private AbbatoirIntergrade.GumRuntimes.infodisplays.ResistanceDisplayRuntime BombardResist { get; set; }
            private AbbatoirIntergrade.GumRuntimes.infodisplays.ResistanceDisplayRuntime ElectricResist { get; set; }
            private AbbatoirIntergrade.GumRuntimes.infodisplays.ResistanceDisplayRuntime FireResist { get; set; }
            public string EnemyName
            {
                get
                {
                    return NameText.Text;
                }
                set
                {
                    if (NameText.Text != value)
                    {
                        NameText.Text = value;
                        EnemyNameChanged?.Invoke(this, null);
                    }
                }
            }
            public event FlatRedBall.Gui.WindowEvent StatsContainerClick;
            public event FlatRedBall.Gui.WindowEvent NameContainerClick;
            public event FlatRedBall.Gui.WindowEvent TallInfoFrameInstanceClick;
            public event FlatRedBall.Gui.WindowEvent ResistanceContainerClick;
            public event FlatRedBall.Gui.WindowEvent LeftResistancesClick;
            public event FlatRedBall.Gui.WindowEvent RightResistancesClick;
            public event System.EventHandler EnemyNameChanged;
            public EnemyInfoRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                this.HasEvents = false;
                this.ExposeChildrenEvents = true;
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "infodisplays/EnemyInfo");
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
                StatsContainer = this.GetGraphicalUiElementByName("StatsContainer") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
                NameContainer = this.GetGraphicalUiElementByName("NameContainer") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
                NameText = this.GetGraphicalUiElementByName("NameText") as AbbatoirIntergrade.GumRuntimes.TextRuntime;
                TallInfoFrameInstance = this.GetGraphicalUiElementByName("TallInfoFrameInstance") as AbbatoirIntergrade.GumRuntimes.frames.TallInfoFrameRuntime;
                HealthDisplay = this.GetGraphicalUiElementByName("HealthDisplay") as AbbatoirIntergrade.GumRuntimes.infodisplays.AttributeDisplayRuntime;
                SpeedDisplay = this.GetGraphicalUiElementByName("SpeedDisplay") as AbbatoirIntergrade.GumRuntimes.infodisplays.AttributeDisplayRuntime;
                ResistanceContainer = this.GetGraphicalUiElementByName("ResistanceContainer") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
                LeftResistances = this.GetGraphicalUiElementByName("LeftResistances") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
                RightResistances = this.GetGraphicalUiElementByName("RightResistances") as AbbatoirIntergrade.GumRuntimes.ContainerRuntime;
                PiercingResist = this.GetGraphicalUiElementByName("PiercingResist") as AbbatoirIntergrade.GumRuntimes.infodisplays.ResistanceDisplayRuntime;
                ChemicalResist = this.GetGraphicalUiElementByName("ChemicalResist") as AbbatoirIntergrade.GumRuntimes.infodisplays.ResistanceDisplayRuntime;
                FrostResist = this.GetGraphicalUiElementByName("FrostResist") as AbbatoirIntergrade.GumRuntimes.infodisplays.ResistanceDisplayRuntime;
                BombardResist = this.GetGraphicalUiElementByName("BombardResist") as AbbatoirIntergrade.GumRuntimes.infodisplays.ResistanceDisplayRuntime;
                ElectricResist = this.GetGraphicalUiElementByName("ElectricResist") as AbbatoirIntergrade.GumRuntimes.infodisplays.ResistanceDisplayRuntime;
                FireResist = this.GetGraphicalUiElementByName("FireResist") as AbbatoirIntergrade.GumRuntimes.infodisplays.ResistanceDisplayRuntime;
                StatsContainer.Click += (unused) => StatsContainerClick?.Invoke(this);
                NameContainer.Click += (unused) => NameContainerClick?.Invoke(this);
                TallInfoFrameInstance.Click += (unused) => TallInfoFrameInstanceClick?.Invoke(this);
                ResistanceContainer.Click += (unused) => ResistanceContainerClick?.Invoke(this);
                LeftResistances.Click += (unused) => LeftResistancesClick?.Invoke(this);
                RightResistances.Click += (unused) => RightResistancesClick?.Invoke(this);
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
