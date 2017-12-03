	using System.Linq;
	namespace GBC2017.GumRuntimes
	{
		public partial class CarbonDisplayRuntime : GBC2017.GumRuntimes.ContainerRuntime
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
							CarbonDecreaseText.Blue = 0;
							CarbonDecreaseText.Green = 0;
							CarbonDecreaseText.Height = 100f;
							CarbonDecreaseText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
							CarbonDecreaseText.Red = 255;
							CarbonDecreaseText.Text = "- 0";
							CarbonDecreaseText.Width = 33f;
							CarbonDecreaseText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
							CarbonEqualsText.Blue = 255;
							CarbonEqualsText.Green = 255;
							CarbonEqualsText.Height = 100f;
							CarbonEqualsText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
							CarbonEqualsText.Red = 255;
							CarbonEqualsText.Text = "=";
							CarbonEqualsText.Width = 1f;
							CarbonEqualsText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
							CarbonIncreaseText.Blue = 0;
							CarbonIncreaseText.Green = 252;
							CarbonIncreaseText.Height = 100f;
							CarbonIncreaseText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
							CarbonIncreaseText.Red = 124;
							CarbonIncreaseText.Text = "+ 0";
							CarbonIncreaseText.Width = 33f;
							CarbonIncreaseText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
							CarbonNetText.Blue = 255;
							CarbonNetText.Green = 255;
							CarbonNetText.Height = 100f;
							CarbonNetText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
							CarbonNetText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Right;
							CarbonNetText.Red = 255;
							CarbonNetText.Text = "0";
							CarbonNetText.Width = 30f;
							CarbonNetText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
							CarbonSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
							SetProperty("CarbonSprite.SourceFile", "GumContent/images.jpg");
							CarbonSprite.Width = 10f;
							CarbonSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
							CarbonTextBackground.Alpha = 150;
							CarbonTextBackground.Blue = 0;
							CarbonTextBackground.Green = 0;
							CarbonTextBackground.Height = 100f;
							CarbonTextBackground.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
							CarbonTextBackground.Red = 0;
							CarbonTextBackground.Width = 100f;
							CarbonTextBackground.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
							CarbonTextContainer.Height = 100f;
							CarbonTextContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
							CarbonTextContainer.Width = 100f;
							CarbonTextContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
							ChangeContainer.Height = 40f;
							ChangeContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
							ChangeContainer.Width = 100f;
							ChangeContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
							ChangeContainer.WrapsChildren = false;
							ClipsChildren = false;
							Height = 100f;
							HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
							StorageContainer.Height = 60f;
							StorageContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
							StorageContainer.Width = 100f;
							StorageContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
							Visible = true;
							Width = 30f;
							WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
							WrapsChildren = false;
							XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
							XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
							YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
							YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
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
				bool setCarbonDecreaseTextBlueFirstValue = false;
				bool setCarbonDecreaseTextBlueSecondValue = false;
				int CarbonDecreaseTextBlueFirstValue= 0;
				int CarbonDecreaseTextBlueSecondValue= 0;
				bool setCarbonDecreaseTextGreenFirstValue = false;
				bool setCarbonDecreaseTextGreenSecondValue = false;
				int CarbonDecreaseTextGreenFirstValue= 0;
				int CarbonDecreaseTextGreenSecondValue= 0;
				bool setCarbonDecreaseTextHeightFirstValue = false;
				bool setCarbonDecreaseTextHeightSecondValue = false;
				float CarbonDecreaseTextHeightFirstValue= 0;
				float CarbonDecreaseTextHeightSecondValue= 0;
				bool setCarbonDecreaseTextRedFirstValue = false;
				bool setCarbonDecreaseTextRedSecondValue = false;
				int CarbonDecreaseTextRedFirstValue= 0;
				int CarbonDecreaseTextRedSecondValue= 0;
				bool setCarbonDecreaseTextWidthFirstValue = false;
				bool setCarbonDecreaseTextWidthSecondValue = false;
				float CarbonDecreaseTextWidthFirstValue= 0;
				float CarbonDecreaseTextWidthSecondValue= 0;
				bool setCarbonEqualsTextBlueFirstValue = false;
				bool setCarbonEqualsTextBlueSecondValue = false;
				int CarbonEqualsTextBlueFirstValue= 0;
				int CarbonEqualsTextBlueSecondValue= 0;
				bool setCarbonEqualsTextGreenFirstValue = false;
				bool setCarbonEqualsTextGreenSecondValue = false;
				int CarbonEqualsTextGreenFirstValue= 0;
				int CarbonEqualsTextGreenSecondValue= 0;
				bool setCarbonEqualsTextHeightFirstValue = false;
				bool setCarbonEqualsTextHeightSecondValue = false;
				float CarbonEqualsTextHeightFirstValue= 0;
				float CarbonEqualsTextHeightSecondValue= 0;
				bool setCarbonEqualsTextRedFirstValue = false;
				bool setCarbonEqualsTextRedSecondValue = false;
				int CarbonEqualsTextRedFirstValue= 0;
				int CarbonEqualsTextRedSecondValue= 0;
				bool setCarbonEqualsTextWidthFirstValue = false;
				bool setCarbonEqualsTextWidthSecondValue = false;
				float CarbonEqualsTextWidthFirstValue= 0;
				float CarbonEqualsTextWidthSecondValue= 0;
				bool setCarbonIncreaseTextBlueFirstValue = false;
				bool setCarbonIncreaseTextBlueSecondValue = false;
				int CarbonIncreaseTextBlueFirstValue= 0;
				int CarbonIncreaseTextBlueSecondValue= 0;
				bool setCarbonIncreaseTextGreenFirstValue = false;
				bool setCarbonIncreaseTextGreenSecondValue = false;
				int CarbonIncreaseTextGreenFirstValue= 0;
				int CarbonIncreaseTextGreenSecondValue= 0;
				bool setCarbonIncreaseTextHeightFirstValue = false;
				bool setCarbonIncreaseTextHeightSecondValue = false;
				float CarbonIncreaseTextHeightFirstValue= 0;
				float CarbonIncreaseTextHeightSecondValue= 0;
				bool setCarbonIncreaseTextRedFirstValue = false;
				bool setCarbonIncreaseTextRedSecondValue = false;
				int CarbonIncreaseTextRedFirstValue= 0;
				int CarbonIncreaseTextRedSecondValue= 0;
				bool setCarbonIncreaseTextWidthFirstValue = false;
				bool setCarbonIncreaseTextWidthSecondValue = false;
				float CarbonIncreaseTextWidthFirstValue= 0;
				float CarbonIncreaseTextWidthSecondValue= 0;
				bool setCarbonNetTextBlueFirstValue = false;
				bool setCarbonNetTextBlueSecondValue = false;
				int CarbonNetTextBlueFirstValue= 0;
				int CarbonNetTextBlueSecondValue= 0;
				bool setCarbonNetTextGreenFirstValue = false;
				bool setCarbonNetTextGreenSecondValue = false;
				int CarbonNetTextGreenFirstValue= 0;
				int CarbonNetTextGreenSecondValue= 0;
				bool setCarbonNetTextHeightFirstValue = false;
				bool setCarbonNetTextHeightSecondValue = false;
				float CarbonNetTextHeightFirstValue= 0;
				float CarbonNetTextHeightSecondValue= 0;
				bool setCarbonNetTextRedFirstValue = false;
				bool setCarbonNetTextRedSecondValue = false;
				int CarbonNetTextRedFirstValue= 0;
				int CarbonNetTextRedSecondValue= 0;
				bool setCarbonNetTextWidthFirstValue = false;
				bool setCarbonNetTextWidthSecondValue = false;
				float CarbonNetTextWidthFirstValue= 0;
				float CarbonNetTextWidthSecondValue= 0;
				bool setCarbonSpriteWidthFirstValue = false;
				bool setCarbonSpriteWidthSecondValue = false;
				float CarbonSpriteWidthFirstValue= 0;
				float CarbonSpriteWidthSecondValue= 0;
				bool setCarbonTextBackgroundAlphaFirstValue = false;
				bool setCarbonTextBackgroundAlphaSecondValue = false;
				int CarbonTextBackgroundAlphaFirstValue= 0;
				int CarbonTextBackgroundAlphaSecondValue= 0;
				bool setCarbonTextBackgroundBlueFirstValue = false;
				bool setCarbonTextBackgroundBlueSecondValue = false;
				int CarbonTextBackgroundBlueFirstValue= 0;
				int CarbonTextBackgroundBlueSecondValue= 0;
				bool setCarbonTextBackgroundGreenFirstValue = false;
				bool setCarbonTextBackgroundGreenSecondValue = false;
				int CarbonTextBackgroundGreenFirstValue= 0;
				int CarbonTextBackgroundGreenSecondValue= 0;
				bool setCarbonTextBackgroundHeightFirstValue = false;
				bool setCarbonTextBackgroundHeightSecondValue = false;
				float CarbonTextBackgroundHeightFirstValue= 0;
				float CarbonTextBackgroundHeightSecondValue= 0;
				bool setCarbonTextBackgroundRedFirstValue = false;
				bool setCarbonTextBackgroundRedSecondValue = false;
				int CarbonTextBackgroundRedFirstValue= 0;
				int CarbonTextBackgroundRedSecondValue= 0;
				bool setCarbonTextBackgroundWidthFirstValue = false;
				bool setCarbonTextBackgroundWidthSecondValue = false;
				float CarbonTextBackgroundWidthFirstValue= 0;
				float CarbonTextBackgroundWidthSecondValue= 0;
				bool setCarbonTextContainerHeightFirstValue = false;
				bool setCarbonTextContainerHeightSecondValue = false;
				float CarbonTextContainerHeightFirstValue= 0;
				float CarbonTextContainerHeightSecondValue= 0;
				bool setCarbonTextContainerWidthFirstValue = false;
				bool setCarbonTextContainerWidthSecondValue = false;
				float CarbonTextContainerWidthFirstValue= 0;
				float CarbonTextContainerWidthSecondValue= 0;
				bool setChangeContainerHeightFirstValue = false;
				bool setChangeContainerHeightSecondValue = false;
				float ChangeContainerHeightFirstValue= 0;
				float ChangeContainerHeightSecondValue= 0;
				bool setChangeContainerWidthFirstValue = false;
				bool setChangeContainerWidthSecondValue = false;
				float ChangeContainerWidthFirstValue= 0;
				float ChangeContainerWidthSecondValue= 0;
				bool setHeightFirstValue = false;
				bool setHeightSecondValue = false;
				float HeightFirstValue= 0;
				float HeightSecondValue= 0;
				bool setStorageContainerHeightFirstValue = false;
				bool setStorageContainerHeightSecondValue = false;
				float StorageContainerHeightFirstValue= 0;
				float StorageContainerHeightSecondValue= 0;
				bool setStorageContainerWidthFirstValue = false;
				bool setStorageContainerWidthSecondValue = false;
				float StorageContainerWidthFirstValue= 0;
				float StorageContainerWidthSecondValue= 0;
				bool setWidthFirstValue = false;
				bool setWidthSecondValue = false;
				float WidthFirstValue= 0;
				float WidthSecondValue= 0;
				switch(firstState)
				{
					case  VariableState.Default:
						setCarbonDecreaseTextBlueFirstValue = true;
						CarbonDecreaseTextBlueFirstValue = 0;
						setCarbonDecreaseTextGreenFirstValue = true;
						CarbonDecreaseTextGreenFirstValue = 0;
						setCarbonDecreaseTextHeightFirstValue = true;
						CarbonDecreaseTextHeightFirstValue = 100f;
						if (interpolationValue < 1)
						{
							this.CarbonDecreaseText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
						}
						setCarbonDecreaseTextRedFirstValue = true;
						CarbonDecreaseTextRedFirstValue = 255;
						if (interpolationValue < 1)
						{
							this.CarbonDecreaseText.Text = "- 0";
						}
						setCarbonDecreaseTextWidthFirstValue = true;
						CarbonDecreaseTextWidthFirstValue = 33f;
						if (interpolationValue < 1)
						{
							this.CarbonDecreaseText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
						}
						setCarbonEqualsTextBlueFirstValue = true;
						CarbonEqualsTextBlueFirstValue = 255;
						setCarbonEqualsTextGreenFirstValue = true;
						CarbonEqualsTextGreenFirstValue = 255;
						setCarbonEqualsTextHeightFirstValue = true;
						CarbonEqualsTextHeightFirstValue = 100f;
						if (interpolationValue < 1)
						{
							this.CarbonEqualsText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
						}
						setCarbonEqualsTextRedFirstValue = true;
						CarbonEqualsTextRedFirstValue = 255;
						if (interpolationValue < 1)
						{
							this.CarbonEqualsText.Text = "=";
						}
						setCarbonEqualsTextWidthFirstValue = true;
						CarbonEqualsTextWidthFirstValue = 1f;
						if (interpolationValue < 1)
						{
							this.CarbonEqualsText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
						}
						setCarbonIncreaseTextBlueFirstValue = true;
						CarbonIncreaseTextBlueFirstValue = 0;
						setCarbonIncreaseTextGreenFirstValue = true;
						CarbonIncreaseTextGreenFirstValue = 252;
						setCarbonIncreaseTextHeightFirstValue = true;
						CarbonIncreaseTextHeightFirstValue = 100f;
						if (interpolationValue < 1)
						{
							this.CarbonIncreaseText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
						}
						setCarbonIncreaseTextRedFirstValue = true;
						CarbonIncreaseTextRedFirstValue = 124;
						if (interpolationValue < 1)
						{
							this.CarbonIncreaseText.Text = "+ 0";
						}
						setCarbonIncreaseTextWidthFirstValue = true;
						CarbonIncreaseTextWidthFirstValue = 33f;
						if (interpolationValue < 1)
						{
							this.CarbonIncreaseText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
						}
						setCarbonNetTextBlueFirstValue = true;
						CarbonNetTextBlueFirstValue = 255;
						setCarbonNetTextGreenFirstValue = true;
						CarbonNetTextGreenFirstValue = 255;
						setCarbonNetTextHeightFirstValue = true;
						CarbonNetTextHeightFirstValue = 100f;
						if (interpolationValue < 1)
						{
							this.CarbonNetText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
						}
						if (interpolationValue < 1)
						{
							this.CarbonNetText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Right;
						}
						setCarbonNetTextRedFirstValue = true;
						CarbonNetTextRedFirstValue = 255;
						if (interpolationValue < 1)
						{
							this.CarbonNetText.Text = "0";
						}
						setCarbonNetTextWidthFirstValue = true;
						CarbonNetTextWidthFirstValue = 30f;
						if (interpolationValue < 1)
						{
							this.CarbonNetText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
						}
						if (interpolationValue < 1)
						{
							this.CarbonSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
						}
						if (interpolationValue < 1)
						{
							SetProperty("CarbonSprite.SourceFile", "GumContent/images.jpg");
						}
						setCarbonSpriteWidthFirstValue = true;
						CarbonSpriteWidthFirstValue = 10f;
						if (interpolationValue < 1)
						{
							this.CarbonSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
						}
						setCarbonTextBackgroundAlphaFirstValue = true;
						CarbonTextBackgroundAlphaFirstValue = 150;
						setCarbonTextBackgroundBlueFirstValue = true;
						CarbonTextBackgroundBlueFirstValue = 0;
						setCarbonTextBackgroundGreenFirstValue = true;
						CarbonTextBackgroundGreenFirstValue = 0;
						setCarbonTextBackgroundHeightFirstValue = true;
						CarbonTextBackgroundHeightFirstValue = 100f;
						if (interpolationValue < 1)
						{
							this.CarbonTextBackground.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
						}
						setCarbonTextBackgroundRedFirstValue = true;
						CarbonTextBackgroundRedFirstValue = 0;
						setCarbonTextBackgroundWidthFirstValue = true;
						CarbonTextBackgroundWidthFirstValue = 100f;
						if (interpolationValue < 1)
						{
							this.CarbonTextBackground.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
						}
						setCarbonTextContainerHeightFirstValue = true;
						CarbonTextContainerHeightFirstValue = 100f;
						if (interpolationValue < 1)
						{
							this.CarbonTextContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
						}
						setCarbonTextContainerWidthFirstValue = true;
						CarbonTextContainerWidthFirstValue = 100f;
						if (interpolationValue < 1)
						{
							this.CarbonTextContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
						}
						setChangeContainerHeightFirstValue = true;
						ChangeContainerHeightFirstValue = 40f;
						if (interpolationValue < 1)
						{
							this.ChangeContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
						}
						setChangeContainerWidthFirstValue = true;
						ChangeContainerWidthFirstValue = 100f;
						if (interpolationValue < 1)
						{
							this.ChangeContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
						}
						if (interpolationValue < 1)
						{
							this.ChangeContainer.WrapsChildren = false;
						}
						if (interpolationValue < 1)
						{
							this.ClipsChildren = false;
						}
						setHeightFirstValue = true;
						HeightFirstValue = 100f;
						if (interpolationValue < 1)
						{
							this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
						}
						setStorageContainerHeightFirstValue = true;
						StorageContainerHeightFirstValue = 60f;
						if (interpolationValue < 1)
						{
							this.StorageContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
						}
						setStorageContainerWidthFirstValue = true;
						StorageContainerWidthFirstValue = 100f;
						if (interpolationValue < 1)
						{
							this.StorageContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
						}
						if (interpolationValue < 1)
						{
							this.Visible = true;
						}
						setWidthFirstValue = true;
						WidthFirstValue = 30f;
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
							this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
						}
						if (interpolationValue < 1)
						{
							this.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
						}
						if (interpolationValue < 1)
						{
							this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
						}
						if (interpolationValue < 1)
						{
							this.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
						}
						break;
				}
				switch(secondState)
				{
					case  VariableState.Default:
						setCarbonDecreaseTextBlueSecondValue = true;
						CarbonDecreaseTextBlueSecondValue = 0;
						setCarbonDecreaseTextGreenSecondValue = true;
						CarbonDecreaseTextGreenSecondValue = 0;
						setCarbonDecreaseTextHeightSecondValue = true;
						CarbonDecreaseTextHeightSecondValue = 100f;
						if (interpolationValue >= 1)
						{
							this.CarbonDecreaseText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
						}
						setCarbonDecreaseTextRedSecondValue = true;
						CarbonDecreaseTextRedSecondValue = 255;
						if (interpolationValue >= 1)
						{
							this.CarbonDecreaseText.Text = "- 0";
						}
						setCarbonDecreaseTextWidthSecondValue = true;
						CarbonDecreaseTextWidthSecondValue = 33f;
						if (interpolationValue >= 1)
						{
							this.CarbonDecreaseText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
						}
						setCarbonEqualsTextBlueSecondValue = true;
						CarbonEqualsTextBlueSecondValue = 255;
						setCarbonEqualsTextGreenSecondValue = true;
						CarbonEqualsTextGreenSecondValue = 255;
						setCarbonEqualsTextHeightSecondValue = true;
						CarbonEqualsTextHeightSecondValue = 100f;
						if (interpolationValue >= 1)
						{
							this.CarbonEqualsText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
						}
						setCarbonEqualsTextRedSecondValue = true;
						CarbonEqualsTextRedSecondValue = 255;
						if (interpolationValue >= 1)
						{
							this.CarbonEqualsText.Text = "=";
						}
						setCarbonEqualsTextWidthSecondValue = true;
						CarbonEqualsTextWidthSecondValue = 1f;
						if (interpolationValue >= 1)
						{
							this.CarbonEqualsText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
						}
						setCarbonIncreaseTextBlueSecondValue = true;
						CarbonIncreaseTextBlueSecondValue = 0;
						setCarbonIncreaseTextGreenSecondValue = true;
						CarbonIncreaseTextGreenSecondValue = 252;
						setCarbonIncreaseTextHeightSecondValue = true;
						CarbonIncreaseTextHeightSecondValue = 100f;
						if (interpolationValue >= 1)
						{
							this.CarbonIncreaseText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
						}
						setCarbonIncreaseTextRedSecondValue = true;
						CarbonIncreaseTextRedSecondValue = 124;
						if (interpolationValue >= 1)
						{
							this.CarbonIncreaseText.Text = "+ 0";
						}
						setCarbonIncreaseTextWidthSecondValue = true;
						CarbonIncreaseTextWidthSecondValue = 33f;
						if (interpolationValue >= 1)
						{
							this.CarbonIncreaseText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
						}
						setCarbonNetTextBlueSecondValue = true;
						CarbonNetTextBlueSecondValue = 255;
						setCarbonNetTextGreenSecondValue = true;
						CarbonNetTextGreenSecondValue = 255;
						setCarbonNetTextHeightSecondValue = true;
						CarbonNetTextHeightSecondValue = 100f;
						if (interpolationValue >= 1)
						{
							this.CarbonNetText.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
						}
						if (interpolationValue >= 1)
						{
							this.CarbonNetText.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Right;
						}
						setCarbonNetTextRedSecondValue = true;
						CarbonNetTextRedSecondValue = 255;
						if (interpolationValue >= 1)
						{
							this.CarbonNetText.Text = "0";
						}
						setCarbonNetTextWidthSecondValue = true;
						CarbonNetTextWidthSecondValue = 30f;
						if (interpolationValue >= 1)
						{
							this.CarbonNetText.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
						}
						if (interpolationValue >= 1)
						{
							this.CarbonSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
						}
						if (interpolationValue >= 1)
						{
							SetProperty("CarbonSprite.SourceFile", "GumContent/images.jpg");
						}
						setCarbonSpriteWidthSecondValue = true;
						CarbonSpriteWidthSecondValue = 10f;
						if (interpolationValue >= 1)
						{
							this.CarbonSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
						}
						setCarbonTextBackgroundAlphaSecondValue = true;
						CarbonTextBackgroundAlphaSecondValue = 150;
						setCarbonTextBackgroundBlueSecondValue = true;
						CarbonTextBackgroundBlueSecondValue = 0;
						setCarbonTextBackgroundGreenSecondValue = true;
						CarbonTextBackgroundGreenSecondValue = 0;
						setCarbonTextBackgroundHeightSecondValue = true;
						CarbonTextBackgroundHeightSecondValue = 100f;
						if (interpolationValue >= 1)
						{
							this.CarbonTextBackground.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
						}
						setCarbonTextBackgroundRedSecondValue = true;
						CarbonTextBackgroundRedSecondValue = 0;
						setCarbonTextBackgroundWidthSecondValue = true;
						CarbonTextBackgroundWidthSecondValue = 100f;
						if (interpolationValue >= 1)
						{
							this.CarbonTextBackground.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
						}
						setCarbonTextContainerHeightSecondValue = true;
						CarbonTextContainerHeightSecondValue = 100f;
						if (interpolationValue >= 1)
						{
							this.CarbonTextContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
						}
						setCarbonTextContainerWidthSecondValue = true;
						CarbonTextContainerWidthSecondValue = 100f;
						if (interpolationValue >= 1)
						{
							this.CarbonTextContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
						}
						setChangeContainerHeightSecondValue = true;
						ChangeContainerHeightSecondValue = 40f;
						if (interpolationValue >= 1)
						{
							this.ChangeContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
						}
						setChangeContainerWidthSecondValue = true;
						ChangeContainerWidthSecondValue = 100f;
						if (interpolationValue >= 1)
						{
							this.ChangeContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
						}
						if (interpolationValue >= 1)
						{
							this.ChangeContainer.WrapsChildren = false;
						}
						if (interpolationValue >= 1)
						{
							this.ClipsChildren = false;
						}
						setHeightSecondValue = true;
						HeightSecondValue = 100f;
						if (interpolationValue >= 1)
						{
							this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
						}
						setStorageContainerHeightSecondValue = true;
						StorageContainerHeightSecondValue = 60f;
						if (interpolationValue >= 1)
						{
							this.StorageContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
						}
						setStorageContainerWidthSecondValue = true;
						StorageContainerWidthSecondValue = 100f;
						if (interpolationValue >= 1)
						{
							this.StorageContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
						}
						if (interpolationValue >= 1)
						{
							this.Visible = true;
						}
						setWidthSecondValue = true;
						WidthSecondValue = 30f;
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
							this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
						}
						if (interpolationValue >= 1)
						{
							this.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
						}
						if (interpolationValue >= 1)
						{
							this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
						}
						if (interpolationValue >= 1)
						{
							this.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
						}
						break;
				}
				if (setCarbonDecreaseTextBlueFirstValue && setCarbonDecreaseTextBlueSecondValue)
				{
					CarbonDecreaseText.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(CarbonDecreaseTextBlueFirstValue* (1 - interpolationValue) + CarbonDecreaseTextBlueSecondValue * interpolationValue);
				}
				if (setCarbonDecreaseTextGreenFirstValue && setCarbonDecreaseTextGreenSecondValue)
				{
					CarbonDecreaseText.Green = FlatRedBall.Math.MathFunctions.RoundToInt(CarbonDecreaseTextGreenFirstValue* (1 - interpolationValue) + CarbonDecreaseTextGreenSecondValue * interpolationValue);
				}
				if (setCarbonDecreaseTextHeightFirstValue && setCarbonDecreaseTextHeightSecondValue)
				{
					CarbonDecreaseText.Height = CarbonDecreaseTextHeightFirstValue * (1 - interpolationValue) + CarbonDecreaseTextHeightSecondValue * interpolationValue;
				}
				if (setCarbonDecreaseTextRedFirstValue && setCarbonDecreaseTextRedSecondValue)
				{
					CarbonDecreaseText.Red = FlatRedBall.Math.MathFunctions.RoundToInt(CarbonDecreaseTextRedFirstValue* (1 - interpolationValue) + CarbonDecreaseTextRedSecondValue * interpolationValue);
				}
				if (setCarbonDecreaseTextWidthFirstValue && setCarbonDecreaseTextWidthSecondValue)
				{
					CarbonDecreaseText.Width = CarbonDecreaseTextWidthFirstValue * (1 - interpolationValue) + CarbonDecreaseTextWidthSecondValue * interpolationValue;
				}
				if (setCarbonEqualsTextBlueFirstValue && setCarbonEqualsTextBlueSecondValue)
				{
					CarbonEqualsText.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(CarbonEqualsTextBlueFirstValue* (1 - interpolationValue) + CarbonEqualsTextBlueSecondValue * interpolationValue);
				}
				if (setCarbonEqualsTextGreenFirstValue && setCarbonEqualsTextGreenSecondValue)
				{
					CarbonEqualsText.Green = FlatRedBall.Math.MathFunctions.RoundToInt(CarbonEqualsTextGreenFirstValue* (1 - interpolationValue) + CarbonEqualsTextGreenSecondValue * interpolationValue);
				}
				if (setCarbonEqualsTextHeightFirstValue && setCarbonEqualsTextHeightSecondValue)
				{
					CarbonEqualsText.Height = CarbonEqualsTextHeightFirstValue * (1 - interpolationValue) + CarbonEqualsTextHeightSecondValue * interpolationValue;
				}
				if (setCarbonEqualsTextRedFirstValue && setCarbonEqualsTextRedSecondValue)
				{
					CarbonEqualsText.Red = FlatRedBall.Math.MathFunctions.RoundToInt(CarbonEqualsTextRedFirstValue* (1 - interpolationValue) + CarbonEqualsTextRedSecondValue * interpolationValue);
				}
				if (setCarbonEqualsTextWidthFirstValue && setCarbonEqualsTextWidthSecondValue)
				{
					CarbonEqualsText.Width = CarbonEqualsTextWidthFirstValue * (1 - interpolationValue) + CarbonEqualsTextWidthSecondValue * interpolationValue;
				}
				if (setCarbonIncreaseTextBlueFirstValue && setCarbonIncreaseTextBlueSecondValue)
				{
					CarbonIncreaseText.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(CarbonIncreaseTextBlueFirstValue* (1 - interpolationValue) + CarbonIncreaseTextBlueSecondValue * interpolationValue);
				}
				if (setCarbonIncreaseTextGreenFirstValue && setCarbonIncreaseTextGreenSecondValue)
				{
					CarbonIncreaseText.Green = FlatRedBall.Math.MathFunctions.RoundToInt(CarbonIncreaseTextGreenFirstValue* (1 - interpolationValue) + CarbonIncreaseTextGreenSecondValue * interpolationValue);
				}
				if (setCarbonIncreaseTextHeightFirstValue && setCarbonIncreaseTextHeightSecondValue)
				{
					CarbonIncreaseText.Height = CarbonIncreaseTextHeightFirstValue * (1 - interpolationValue) + CarbonIncreaseTextHeightSecondValue * interpolationValue;
				}
				if (setCarbonIncreaseTextRedFirstValue && setCarbonIncreaseTextRedSecondValue)
				{
					CarbonIncreaseText.Red = FlatRedBall.Math.MathFunctions.RoundToInt(CarbonIncreaseTextRedFirstValue* (1 - interpolationValue) + CarbonIncreaseTextRedSecondValue * interpolationValue);
				}
				if (setCarbonIncreaseTextWidthFirstValue && setCarbonIncreaseTextWidthSecondValue)
				{
					CarbonIncreaseText.Width = CarbonIncreaseTextWidthFirstValue * (1 - interpolationValue) + CarbonIncreaseTextWidthSecondValue * interpolationValue;
				}
				if (setCarbonNetTextBlueFirstValue && setCarbonNetTextBlueSecondValue)
				{
					CarbonNetText.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(CarbonNetTextBlueFirstValue* (1 - interpolationValue) + CarbonNetTextBlueSecondValue * interpolationValue);
				}
				if (setCarbonNetTextGreenFirstValue && setCarbonNetTextGreenSecondValue)
				{
					CarbonNetText.Green = FlatRedBall.Math.MathFunctions.RoundToInt(CarbonNetTextGreenFirstValue* (1 - interpolationValue) + CarbonNetTextGreenSecondValue * interpolationValue);
				}
				if (setCarbonNetTextHeightFirstValue && setCarbonNetTextHeightSecondValue)
				{
					CarbonNetText.Height = CarbonNetTextHeightFirstValue * (1 - interpolationValue) + CarbonNetTextHeightSecondValue * interpolationValue;
				}
				if (setCarbonNetTextRedFirstValue && setCarbonNetTextRedSecondValue)
				{
					CarbonNetText.Red = FlatRedBall.Math.MathFunctions.RoundToInt(CarbonNetTextRedFirstValue* (1 - interpolationValue) + CarbonNetTextRedSecondValue * interpolationValue);
				}
				if (setCarbonNetTextWidthFirstValue && setCarbonNetTextWidthSecondValue)
				{
					CarbonNetText.Width = CarbonNetTextWidthFirstValue * (1 - interpolationValue) + CarbonNetTextWidthSecondValue * interpolationValue;
				}
				if (setCarbonSpriteWidthFirstValue && setCarbonSpriteWidthSecondValue)
				{
					CarbonSprite.Width = CarbonSpriteWidthFirstValue * (1 - interpolationValue) + CarbonSpriteWidthSecondValue * interpolationValue;
				}
				if (setCarbonTextBackgroundAlphaFirstValue && setCarbonTextBackgroundAlphaSecondValue)
				{
					CarbonTextBackground.Alpha = FlatRedBall.Math.MathFunctions.RoundToInt(CarbonTextBackgroundAlphaFirstValue* (1 - interpolationValue) + CarbonTextBackgroundAlphaSecondValue * interpolationValue);
				}
				if (setCarbonTextBackgroundBlueFirstValue && setCarbonTextBackgroundBlueSecondValue)
				{
					CarbonTextBackground.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(CarbonTextBackgroundBlueFirstValue* (1 - interpolationValue) + CarbonTextBackgroundBlueSecondValue * interpolationValue);
				}
				if (setCarbonTextBackgroundGreenFirstValue && setCarbonTextBackgroundGreenSecondValue)
				{
					CarbonTextBackground.Green = FlatRedBall.Math.MathFunctions.RoundToInt(CarbonTextBackgroundGreenFirstValue* (1 - interpolationValue) + CarbonTextBackgroundGreenSecondValue * interpolationValue);
				}
				if (setCarbonTextBackgroundHeightFirstValue && setCarbonTextBackgroundHeightSecondValue)
				{
					CarbonTextBackground.Height = CarbonTextBackgroundHeightFirstValue * (1 - interpolationValue) + CarbonTextBackgroundHeightSecondValue * interpolationValue;
				}
				if (setCarbonTextBackgroundRedFirstValue && setCarbonTextBackgroundRedSecondValue)
				{
					CarbonTextBackground.Red = FlatRedBall.Math.MathFunctions.RoundToInt(CarbonTextBackgroundRedFirstValue* (1 - interpolationValue) + CarbonTextBackgroundRedSecondValue * interpolationValue);
				}
				if (setCarbonTextBackgroundWidthFirstValue && setCarbonTextBackgroundWidthSecondValue)
				{
					CarbonTextBackground.Width = CarbonTextBackgroundWidthFirstValue * (1 - interpolationValue) + CarbonTextBackgroundWidthSecondValue * interpolationValue;
				}
				if (setCarbonTextContainerHeightFirstValue && setCarbonTextContainerHeightSecondValue)
				{
					CarbonTextContainer.Height = CarbonTextContainerHeightFirstValue * (1 - interpolationValue) + CarbonTextContainerHeightSecondValue * interpolationValue;
				}
				if (setCarbonTextContainerWidthFirstValue && setCarbonTextContainerWidthSecondValue)
				{
					CarbonTextContainer.Width = CarbonTextContainerWidthFirstValue * (1 - interpolationValue) + CarbonTextContainerWidthSecondValue * interpolationValue;
				}
				if (setChangeContainerHeightFirstValue && setChangeContainerHeightSecondValue)
				{
					ChangeContainer.Height = ChangeContainerHeightFirstValue * (1 - interpolationValue) + ChangeContainerHeightSecondValue * interpolationValue;
				}
				if (setChangeContainerWidthFirstValue && setChangeContainerWidthSecondValue)
				{
					ChangeContainer.Width = ChangeContainerWidthFirstValue * (1 - interpolationValue) + ChangeContainerWidthSecondValue * interpolationValue;
				}
				if (setHeightFirstValue && setHeightSecondValue)
				{
					Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
				}
				if (setStorageContainerHeightFirstValue && setStorageContainerHeightSecondValue)
				{
					StorageContainer.Height = StorageContainerHeightFirstValue * (1 - interpolationValue) + StorageContainerHeightSecondValue * interpolationValue;
				}
				if (setStorageContainerWidthFirstValue && setStorageContainerWidthSecondValue)
				{
					StorageContainer.Width = StorageContainerWidthFirstValue * (1 - interpolationValue) + StorageContainerWidthSecondValue * interpolationValue;
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
			public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (GBC2017.GumRuntimes.CarbonDisplayRuntime.VariableState fromState,GBC2017.GumRuntimes.CarbonDisplayRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null)
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
							Name = "CarbonDecreaseText.Blue",
							Type = "int",
							Value = CarbonDecreaseText.Blue
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonDecreaseText.Green",
							Type = "int",
							Value = CarbonDecreaseText.Green
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonDecreaseText.Height",
							Type = "float",
							Value = CarbonDecreaseText.Height
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonDecreaseText.Height Units",
							Type = "DimensionUnitType",
							Value = CarbonDecreaseText.HeightUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonDecreaseText.Red",
							Type = "int",
							Value = CarbonDecreaseText.Red
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonDecreaseText.Text",
							Type = "string",
							Value = CarbonDecreaseText.Text
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonDecreaseText.Width",
							Type = "float",
							Value = CarbonDecreaseText.Width
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonDecreaseText.Width Units",
							Type = "DimensionUnitType",
							Value = CarbonDecreaseText.WidthUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonEqualsText.Blue",
							Type = "int",
							Value = CarbonEqualsText.Blue
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonEqualsText.Green",
							Type = "int",
							Value = CarbonEqualsText.Green
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonEqualsText.Height",
							Type = "float",
							Value = CarbonEqualsText.Height
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonEqualsText.Height Units",
							Type = "DimensionUnitType",
							Value = CarbonEqualsText.HeightUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonEqualsText.Red",
							Type = "int",
							Value = CarbonEqualsText.Red
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonEqualsText.Text",
							Type = "string",
							Value = CarbonEqualsText.Text
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonEqualsText.Width",
							Type = "float",
							Value = CarbonEqualsText.Width
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonEqualsText.Width Units",
							Type = "DimensionUnitType",
							Value = CarbonEqualsText.WidthUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonIncreaseText.Blue",
							Type = "int",
							Value = CarbonIncreaseText.Blue
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonIncreaseText.Green",
							Type = "int",
							Value = CarbonIncreaseText.Green
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonIncreaseText.Height",
							Type = "float",
							Value = CarbonIncreaseText.Height
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonIncreaseText.Height Units",
							Type = "DimensionUnitType",
							Value = CarbonIncreaseText.HeightUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonIncreaseText.Red",
							Type = "int",
							Value = CarbonIncreaseText.Red
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonIncreaseText.Text",
							Type = "string",
							Value = CarbonIncreaseText.Text
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonIncreaseText.Width",
							Type = "float",
							Value = CarbonIncreaseText.Width
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonIncreaseText.Width Units",
							Type = "DimensionUnitType",
							Value = CarbonIncreaseText.WidthUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonNetText.Blue",
							Type = "int",
							Value = CarbonNetText.Blue
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonNetText.Green",
							Type = "int",
							Value = CarbonNetText.Green
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonNetText.Height",
							Type = "float",
							Value = CarbonNetText.Height
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonNetText.Height Units",
							Type = "DimensionUnitType",
							Value = CarbonNetText.HeightUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonNetText.HorizontalAlignment",
							Type = "HorizontalAlignment",
							Value = CarbonNetText.HorizontalAlignment
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonNetText.Red",
							Type = "int",
							Value = CarbonNetText.Red
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonNetText.Text",
							Type = "string",
							Value = CarbonNetText.Text
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonNetText.Width",
							Type = "float",
							Value = CarbonNetText.Width
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonNetText.Width Units",
							Type = "DimensionUnitType",
							Value = CarbonNetText.WidthUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonSprite.Height Units",
							Type = "DimensionUnitType",
							Value = CarbonSprite.HeightUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonSprite.SourceFile",
							Type = "string",
							Value = CarbonSprite.SourceFile
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonSprite.Width",
							Type = "float",
							Value = CarbonSprite.Width
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonSprite.Width Units",
							Type = "DimensionUnitType",
							Value = CarbonSprite.WidthUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonTextBackground.Alpha",
							Type = "int",
							Value = CarbonTextBackground.Alpha
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonTextBackground.Blue",
							Type = "int",
							Value = CarbonTextBackground.Blue
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonTextBackground.Green",
							Type = "int",
							Value = CarbonTextBackground.Green
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonTextBackground.Height",
							Type = "float",
							Value = CarbonTextBackground.Height
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonTextBackground.Height Units",
							Type = "DimensionUnitType",
							Value = CarbonTextBackground.HeightUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonTextBackground.Red",
							Type = "int",
							Value = CarbonTextBackground.Red
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonTextBackground.Width",
							Type = "float",
							Value = CarbonTextBackground.Width
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonTextBackground.Width Units",
							Type = "DimensionUnitType",
							Value = CarbonTextBackground.WidthUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonTextContainer.Height",
							Type = "float",
							Value = CarbonTextContainer.Height
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonTextContainer.Height Units",
							Type = "DimensionUnitType",
							Value = CarbonTextContainer.HeightUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonTextContainer.Width",
							Type = "float",
							Value = CarbonTextContainer.Width
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonTextContainer.Width Units",
							Type = "DimensionUnitType",
							Value = CarbonTextContainer.WidthUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "ChangeContainer.Height",
							Type = "float",
							Value = ChangeContainer.Height
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "ChangeContainer.Height Units",
							Type = "DimensionUnitType",
							Value = ChangeContainer.HeightUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "ChangeContainer.Width",
							Type = "float",
							Value = ChangeContainer.Width
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "ChangeContainer.Width Units",
							Type = "DimensionUnitType",
							Value = ChangeContainer.WidthUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "ChangeContainer.Wraps Children",
							Type = "bool",
							Value = ChangeContainer.WrapsChildren
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
							Name = "StorageContainer.Height",
							Type = "float",
							Value = StorageContainer.Height
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "StorageContainer.Height Units",
							Type = "DimensionUnitType",
							Value = StorageContainer.HeightUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "StorageContainer.Width",
							Type = "float",
							Value = StorageContainer.Width
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "StorageContainer.Width Units",
							Type = "DimensionUnitType",
							Value = StorageContainer.WidthUnits
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
							Name = "CarbonDecreaseText.Blue",
							Type = "int",
							Value = CarbonDecreaseText.Blue + 0
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonDecreaseText.Green",
							Type = "int",
							Value = CarbonDecreaseText.Green + 0
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonDecreaseText.Height",
							Type = "float",
							Value = CarbonDecreaseText.Height + 100f
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonDecreaseText.Height Units",
							Type = "DimensionUnitType",
							Value = CarbonDecreaseText.HeightUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonDecreaseText.Red",
							Type = "int",
							Value = CarbonDecreaseText.Red + 255
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonDecreaseText.Text",
							Type = "string",
							Value = CarbonDecreaseText.Text
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonDecreaseText.Width",
							Type = "float",
							Value = CarbonDecreaseText.Width + 33f
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonDecreaseText.Width Units",
							Type = "DimensionUnitType",
							Value = CarbonDecreaseText.WidthUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonEqualsText.Blue",
							Type = "int",
							Value = CarbonEqualsText.Blue + 255
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonEqualsText.Green",
							Type = "int",
							Value = CarbonEqualsText.Green + 255
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonEqualsText.Height",
							Type = "float",
							Value = CarbonEqualsText.Height + 100f
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonEqualsText.Height Units",
							Type = "DimensionUnitType",
							Value = CarbonEqualsText.HeightUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonEqualsText.Red",
							Type = "int",
							Value = CarbonEqualsText.Red + 255
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonEqualsText.Text",
							Type = "string",
							Value = CarbonEqualsText.Text
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonEqualsText.Width",
							Type = "float",
							Value = CarbonEqualsText.Width + 1f
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonEqualsText.Width Units",
							Type = "DimensionUnitType",
							Value = CarbonEqualsText.WidthUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonIncreaseText.Blue",
							Type = "int",
							Value = CarbonIncreaseText.Blue + 0
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonIncreaseText.Green",
							Type = "int",
							Value = CarbonIncreaseText.Green + 252
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonIncreaseText.Height",
							Type = "float",
							Value = CarbonIncreaseText.Height + 100f
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonIncreaseText.Height Units",
							Type = "DimensionUnitType",
							Value = CarbonIncreaseText.HeightUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonIncreaseText.Red",
							Type = "int",
							Value = CarbonIncreaseText.Red + 124
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonIncreaseText.Text",
							Type = "string",
							Value = CarbonIncreaseText.Text
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonIncreaseText.Width",
							Type = "float",
							Value = CarbonIncreaseText.Width + 33f
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonIncreaseText.Width Units",
							Type = "DimensionUnitType",
							Value = CarbonIncreaseText.WidthUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonNetText.Blue",
							Type = "int",
							Value = CarbonNetText.Blue + 255
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonNetText.Green",
							Type = "int",
							Value = CarbonNetText.Green + 255
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonNetText.Height",
							Type = "float",
							Value = CarbonNetText.Height + 100f
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonNetText.Height Units",
							Type = "DimensionUnitType",
							Value = CarbonNetText.HeightUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonNetText.HorizontalAlignment",
							Type = "HorizontalAlignment",
							Value = CarbonNetText.HorizontalAlignment
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonNetText.Red",
							Type = "int",
							Value = CarbonNetText.Red + 255
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonNetText.Text",
							Type = "string",
							Value = CarbonNetText.Text
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonNetText.Width",
							Type = "float",
							Value = CarbonNetText.Width + 30f
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonNetText.Width Units",
							Type = "DimensionUnitType",
							Value = CarbonNetText.WidthUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonSprite.Height Units",
							Type = "DimensionUnitType",
							Value = CarbonSprite.HeightUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonSprite.SourceFile",
							Type = "string",
							Value = CarbonSprite.SourceFile
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonSprite.Width",
							Type = "float",
							Value = CarbonSprite.Width + 10f
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonSprite.Width Units",
							Type = "DimensionUnitType",
							Value = CarbonSprite.WidthUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonTextBackground.Alpha",
							Type = "int",
							Value = CarbonTextBackground.Alpha + 150
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonTextBackground.Blue",
							Type = "int",
							Value = CarbonTextBackground.Blue + 0
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonTextBackground.Green",
							Type = "int",
							Value = CarbonTextBackground.Green + 0
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonTextBackground.Height",
							Type = "float",
							Value = CarbonTextBackground.Height + 100f
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonTextBackground.Height Units",
							Type = "DimensionUnitType",
							Value = CarbonTextBackground.HeightUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonTextBackground.Red",
							Type = "int",
							Value = CarbonTextBackground.Red + 0
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonTextBackground.Width",
							Type = "float",
							Value = CarbonTextBackground.Width + 100f
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonTextBackground.Width Units",
							Type = "DimensionUnitType",
							Value = CarbonTextBackground.WidthUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonTextContainer.Height",
							Type = "float",
							Value = CarbonTextContainer.Height + 100f
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonTextContainer.Height Units",
							Type = "DimensionUnitType",
							Value = CarbonTextContainer.HeightUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonTextContainer.Width",
							Type = "float",
							Value = CarbonTextContainer.Width + 100f
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CarbonTextContainer.Width Units",
							Type = "DimensionUnitType",
							Value = CarbonTextContainer.WidthUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "ChangeContainer.Height",
							Type = "float",
							Value = ChangeContainer.Height + 40f
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "ChangeContainer.Height Units",
							Type = "DimensionUnitType",
							Value = ChangeContainer.HeightUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "ChangeContainer.Width",
							Type = "float",
							Value = ChangeContainer.Width + 100f
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "ChangeContainer.Width Units",
							Type = "DimensionUnitType",
							Value = ChangeContainer.WidthUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "ChangeContainer.Wraps Children",
							Type = "bool",
							Value = ChangeContainer.WrapsChildren
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
							Name = "StorageContainer.Height",
							Type = "float",
							Value = StorageContainer.Height + 60f
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "StorageContainer.Height Units",
							Type = "DimensionUnitType",
							Value = StorageContainer.HeightUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "StorageContainer.Width",
							Type = "float",
							Value = StorageContainer.Width + 100f
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "StorageContainer.Width Units",
							Type = "DimensionUnitType",
							Value = StorageContainer.WidthUnits
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
							Value = Width + 30f
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
			private GBC2017.GumRuntimes.ColoredRectangleRuntime CarbonTextBackground { get; set; }
			private GBC2017.GumRuntimes.ContainerRuntime StorageContainer { get; set; }
			private GBC2017.GumRuntimes.ContainerRuntime ChangeContainer { get; set; }
			private GBC2017.GumRuntimes.SpriteRuntime CarbonSprite { get; set; }
			private GBC2017.GumRuntimes.TextRuntime CarbonIncreaseText { get; set; }
			private GBC2017.GumRuntimes.TextRuntime CarbonDecreaseText { get; set; }
			private GBC2017.GumRuntimes.TextRuntime CarbonEqualsText { get; set; }
			private GBC2017.GumRuntimes.TextRuntime CarbonNetText { get; set; }
			private GBC2017.GumRuntimes.ContainerRuntime CarbonTextContainer { get; set; }
			public event FlatRedBall.Gui.WindowEvent StorageContainerClick;
			public event FlatRedBall.Gui.WindowEvent ChangeContainerClick;
			public event FlatRedBall.Gui.WindowEvent CarbonTextContainerClick;
			public CarbonDisplayRuntime (bool fullInstantiation = true, bool callAssignReferences = true)
				: base(fullInstantiation, false)
			{
				this.HasEvents = true;
				this.ExposeChildrenEvents = true;
				if (fullInstantiation)
				{
					Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "infodisplays/CarbonDisplay");
					this.ElementSave = elementSave;
					string oldDirectory = FlatRedBall.IO.FileManager.RelativeDirectory;
					FlatRedBall.IO.FileManager.RelativeDirectory = FlatRedBall.IO.FileManager.GetDirectory(Gum.Managers.ObjectFinder.Self.GumProjectSave.FullFileName);
					GumRuntime.ElementSaveExtensions.SetGraphicalUiElement(elementSave, this, RenderingLibrary.SystemManagers.Default);
					FlatRedBall.IO.FileManager.RelativeDirectory = oldDirectory;
					if (callAssignReferences)
					{
						this.AssignReferences();
					}
				}
			}
			public override void AssignReferences ()
			{
				base.AssignReferences();
				CarbonTextBackground = this.GetGraphicalUiElementByName("CarbonTextBackground") as GBC2017.GumRuntimes.ColoredRectangleRuntime;
				StorageContainer = this.GetGraphicalUiElementByName("StorageContainer") as GBC2017.GumRuntimes.ContainerRuntime;
				ChangeContainer = this.GetGraphicalUiElementByName("ChangeContainer") as GBC2017.GumRuntimes.ContainerRuntime;
				CarbonSprite = this.GetGraphicalUiElementByName("CarbonSprite") as GBC2017.GumRuntimes.SpriteRuntime;
				CarbonIncreaseText = this.GetGraphicalUiElementByName("CarbonIncreaseText") as GBC2017.GumRuntimes.TextRuntime;
				CarbonDecreaseText = this.GetGraphicalUiElementByName("CarbonDecreaseText") as GBC2017.GumRuntimes.TextRuntime;
				CarbonEqualsText = this.GetGraphicalUiElementByName("CarbonEqualsText") as GBC2017.GumRuntimes.TextRuntime;
				CarbonNetText = this.GetGraphicalUiElementByName("CarbonNetText") as GBC2017.GumRuntimes.TextRuntime;
				CarbonTextContainer = this.GetGraphicalUiElementByName("CarbonTextContainer") as GBC2017.GumRuntimes.ContainerRuntime;
				StorageContainer.Click += (unused) => StorageContainerClick?.Invoke(this);
				ChangeContainer.Click += (unused) => ChangeContainerClick?.Invoke(this);
				CarbonTextContainer.Click += (unused) => CarbonTextContainerClick?.Invoke(this);
				CallCustomInitialize();
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
