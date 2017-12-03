	using System.Linq;
	namespace GBC2017.GumRuntimes
	{
		public partial class WindDisplayRuntime : GBC2017.GumRuntimes.ContainerRuntime
		{
			#region State Enums
			public enum VariableState
			{
				Default
			}
			public enum WindLevel
			{
				Level1,
				Level2,
				Level3,
				Level4
			}
			#endregion
			#region State Fields
			VariableState mCurrentVariableState;
			WindLevel mCurrentWindLevelState;
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
							ClipsChildren = false;
							Height = 100f;
							HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
							Visible = true;
							Width = 100f;
							WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
							WindSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
							SetProperty("WindSprite.SourceFile", "../globalcontent/AllAssetsSheet.png");
							WindSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
							WindSprite.TextureHeight = 64;
							WindSprite.TextureLeft = 423;
							WindSprite.TextureTop = 93;
							WindSprite.TextureWidth = 64;
							WindSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
							WrapsChildren = false;
							XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
							XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
							YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
							YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
							break;
					}
				}
			}
			public WindLevel CurrentWindLevelState
			{
				get
				{
					return mCurrentWindLevelState;
				}
				set
				{
					mCurrentWindLevelState = value;
					switch(mCurrentWindLevelState)
					{
						case  WindLevel.Level1:
							WindSprite.TextureLeft = 423;
							break;
						case  WindLevel.Level2:
							WindSprite.TextureLeft = 488;
							break;
						case  WindLevel.Level3:
							WindSprite.TextureLeft = 553;
							break;
						case  WindLevel.Level4:
							WindSprite.TextureLeft = 618;
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
				bool setWidthFirstValue = false;
				bool setWidthSecondValue = false;
				float WidthFirstValue= 0;
				float WidthSecondValue= 0;
				bool setWindSpriteTextureHeightFirstValue = false;
				bool setWindSpriteTextureHeightSecondValue = false;
				int WindSpriteTextureHeightFirstValue= 0;
				int WindSpriteTextureHeightSecondValue= 0;
				bool setWindSpriteTextureLeftFirstValue = false;
				bool setWindSpriteTextureLeftSecondValue = false;
				int WindSpriteTextureLeftFirstValue= 0;
				int WindSpriteTextureLeftSecondValue= 0;
				bool setWindSpriteTextureTopFirstValue = false;
				bool setWindSpriteTextureTopSecondValue = false;
				int WindSpriteTextureTopFirstValue= 0;
				int WindSpriteTextureTopSecondValue= 0;
				bool setWindSpriteTextureWidthFirstValue = false;
				bool setWindSpriteTextureWidthSecondValue = false;
				int WindSpriteTextureWidthFirstValue= 0;
				int WindSpriteTextureWidthSecondValue= 0;
				switch(firstState)
				{
					case  VariableState.Default:
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
						if (interpolationValue < 1)
						{
							this.Visible = true;
						}
						setWidthFirstValue = true;
						WidthFirstValue = 100f;
						if (interpolationValue < 1)
						{
							this.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
						}
						if (interpolationValue < 1)
						{
							this.WindSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
						}
						if (interpolationValue < 1)
						{
							SetProperty("WindSprite.SourceFile", "../globalcontent/AllAssetsSheet.png");
						}
						if (interpolationValue < 1)
						{
							this.WindSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
						}
						setWindSpriteTextureHeightFirstValue = true;
						WindSpriteTextureHeightFirstValue = 64;
						setWindSpriteTextureLeftFirstValue = true;
						WindSpriteTextureLeftFirstValue = 423;
						setWindSpriteTextureTopFirstValue = true;
						WindSpriteTextureTopFirstValue = 93;
						setWindSpriteTextureWidthFirstValue = true;
						WindSpriteTextureWidthFirstValue = 64;
						if (interpolationValue < 1)
						{
							this.WindSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
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
						if (interpolationValue >= 1)
						{
							this.Visible = true;
						}
						setWidthSecondValue = true;
						WidthSecondValue = 100f;
						if (interpolationValue >= 1)
						{
							this.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
						}
						if (interpolationValue >= 1)
						{
							this.WindSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
						}
						if (interpolationValue >= 1)
						{
							SetProperty("WindSprite.SourceFile", "../globalcontent/AllAssetsSheet.png");
						}
						if (interpolationValue >= 1)
						{
							this.WindSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
						}
						setWindSpriteTextureHeightSecondValue = true;
						WindSpriteTextureHeightSecondValue = 64;
						setWindSpriteTextureLeftSecondValue = true;
						WindSpriteTextureLeftSecondValue = 423;
						setWindSpriteTextureTopSecondValue = true;
						WindSpriteTextureTopSecondValue = 93;
						setWindSpriteTextureWidthSecondValue = true;
						WindSpriteTextureWidthSecondValue = 64;
						if (interpolationValue >= 1)
						{
							this.WindSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
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
				if (setHeightFirstValue && setHeightSecondValue)
				{
					Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
				}
				if (setWidthFirstValue && setWidthSecondValue)
				{
					Width = WidthFirstValue * (1 - interpolationValue) + WidthSecondValue * interpolationValue;
				}
				if (setWindSpriteTextureHeightFirstValue && setWindSpriteTextureHeightSecondValue)
				{
					WindSprite.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(WindSpriteTextureHeightFirstValue* (1 - interpolationValue) + WindSpriteTextureHeightSecondValue * interpolationValue);
				}
				if (setWindSpriteTextureLeftFirstValue && setWindSpriteTextureLeftSecondValue)
				{
					WindSprite.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(WindSpriteTextureLeftFirstValue* (1 - interpolationValue) + WindSpriteTextureLeftSecondValue * interpolationValue);
				}
				if (setWindSpriteTextureTopFirstValue && setWindSpriteTextureTopSecondValue)
				{
					WindSprite.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(WindSpriteTextureTopFirstValue* (1 - interpolationValue) + WindSpriteTextureTopSecondValue * interpolationValue);
				}
				if (setWindSpriteTextureWidthFirstValue && setWindSpriteTextureWidthSecondValue)
				{
					WindSprite.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(WindSpriteTextureWidthFirstValue* (1 - interpolationValue) + WindSpriteTextureWidthSecondValue * interpolationValue);
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
			public void InterpolateBetween (WindLevel firstState, WindLevel secondState, float interpolationValue)
			{
				#if DEBUG
				if (float.IsNaN(interpolationValue))
				{
					throw new System.Exception("interpolationValue cannot be NaN");
				}
				#endif
				bool setWindSpriteTextureLeftFirstValue = false;
				bool setWindSpriteTextureLeftSecondValue = false;
				int WindSpriteTextureLeftFirstValue= 0;
				int WindSpriteTextureLeftSecondValue= 0;
				switch(firstState)
				{
					case  WindLevel.Level1:
						setWindSpriteTextureLeftFirstValue = true;
						WindSpriteTextureLeftFirstValue = 423;
						break;
					case  WindLevel.Level2:
						setWindSpriteTextureLeftFirstValue = true;
						WindSpriteTextureLeftFirstValue = 488;
						break;
					case  WindLevel.Level3:
						setWindSpriteTextureLeftFirstValue = true;
						WindSpriteTextureLeftFirstValue = 553;
						break;
					case  WindLevel.Level4:
						setWindSpriteTextureLeftFirstValue = true;
						WindSpriteTextureLeftFirstValue = 618;
						break;
				}
				switch(secondState)
				{
					case  WindLevel.Level1:
						setWindSpriteTextureLeftSecondValue = true;
						WindSpriteTextureLeftSecondValue = 423;
						break;
					case  WindLevel.Level2:
						setWindSpriteTextureLeftSecondValue = true;
						WindSpriteTextureLeftSecondValue = 488;
						break;
					case  WindLevel.Level3:
						setWindSpriteTextureLeftSecondValue = true;
						WindSpriteTextureLeftSecondValue = 553;
						break;
					case  WindLevel.Level4:
						setWindSpriteTextureLeftSecondValue = true;
						WindSpriteTextureLeftSecondValue = 618;
						break;
				}
				if (setWindSpriteTextureLeftFirstValue && setWindSpriteTextureLeftSecondValue)
				{
					WindSprite.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(WindSpriteTextureLeftFirstValue* (1 - interpolationValue) + WindSpriteTextureLeftSecondValue * interpolationValue);
				}
				if (interpolationValue < 1)
				{
					mCurrentWindLevelState = firstState;
				}
				else
				{
					mCurrentWindLevelState = secondState;
				}
			}
			#endregion
			#region State Interpolate To
			public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (GBC2017.GumRuntimes.WindDisplayRuntime.VariableState fromState,GBC2017.GumRuntimes.WindDisplayRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null)
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
			public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (GBC2017.GumRuntimes.WindDisplayRuntime.WindLevel fromState,GBC2017.GumRuntimes.WindDisplayRuntime.WindLevel toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null)
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
			public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (WindLevel toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null )
			{
				Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
				Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "WindLevel").States.First(item => item.Name == toState.ToString());
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
				tweener.Ended += ()=> this.CurrentWindLevelState = toState;
				tweener.Start();
				StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
				return tweener;
			}
			public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (WindLevel toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null )
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
				tweener.Ended += ()=> this.CurrentWindLevelState = toState;
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
							Name = "WindSprite.Height Units",
							Type = "DimensionUnitType",
							Value = WindSprite.HeightUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "WindSprite.SourceFile",
							Type = "string",
							Value = WindSprite.SourceFile
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "WindSprite.Texture Address",
							Type = "TextureAddress",
							Value = WindSprite.TextureAddress
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "WindSprite.Texture Height",
							Type = "int",
							Value = WindSprite.TextureHeight
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "WindSprite.Texture Left",
							Type = "int",
							Value = WindSprite.TextureLeft
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "WindSprite.Texture Top",
							Type = "int",
							Value = WindSprite.TextureTop
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "WindSprite.Texture Width",
							Type = "int",
							Value = WindSprite.TextureWidth
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "WindSprite.Width Units",
							Type = "DimensionUnitType",
							Value = WindSprite.WidthUnits
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
							Name = "WindSprite.Height Units",
							Type = "DimensionUnitType",
							Value = WindSprite.HeightUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "WindSprite.SourceFile",
							Type = "string",
							Value = WindSprite.SourceFile
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "WindSprite.Texture Address",
							Type = "TextureAddress",
							Value = WindSprite.TextureAddress
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "WindSprite.Texture Height",
							Type = "int",
							Value = WindSprite.TextureHeight + 64
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "WindSprite.Texture Left",
							Type = "int",
							Value = WindSprite.TextureLeft + 423
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "WindSprite.Texture Top",
							Type = "int",
							Value = WindSprite.TextureTop + 93
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "WindSprite.Texture Width",
							Type = "int",
							Value = WindSprite.TextureWidth + 64
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "WindSprite.Width Units",
							Type = "DimensionUnitType",
							Value = WindSprite.WidthUnits
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
			private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (WindLevel state)
			{
				Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
				switch(state)
				{
					case  WindLevel.Level1:
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "WindSprite.Texture Left",
							Type = "int",
							Value = WindSprite.TextureLeft
						}
						);
						break;
					case  WindLevel.Level2:
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "WindSprite.Texture Left",
							Type = "int",
							Value = WindSprite.TextureLeft
						}
						);
						break;
					case  WindLevel.Level3:
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "WindSprite.Texture Left",
							Type = "int",
							Value = WindSprite.TextureLeft
						}
						);
						break;
					case  WindLevel.Level4:
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "WindSprite.Texture Left",
							Type = "int",
							Value = WindSprite.TextureLeft
						}
						);
						break;
				}
				return newState;
			}
			private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (WindLevel state)
			{
				Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
				switch(state)
				{
					case  WindLevel.Level1:
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "WindSprite.Texture Left",
							Type = "int",
							Value = WindSprite.TextureLeft + 423
						}
						);
						break;
					case  WindLevel.Level2:
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "WindSprite.Texture Left",
							Type = "int",
							Value = WindSprite.TextureLeft + 488
						}
						);
						break;
					case  WindLevel.Level3:
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "WindSprite.Texture Left",
							Type = "int",
							Value = WindSprite.TextureLeft + 553
						}
						);
						break;
					case  WindLevel.Level4:
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "WindSprite.Texture Left",
							Type = "int",
							Value = WindSprite.TextureLeft + 618
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
					else if (category.Name == "WindLevel")
					{
						if(state.Name == "Level1") this.mCurrentWindLevelState = WindLevel.Level1;
						if(state.Name == "Level2") this.mCurrentWindLevelState = WindLevel.Level2;
						if(state.Name == "Level3") this.mCurrentWindLevelState = WindLevel.Level3;
						if(state.Name == "Level4") this.mCurrentWindLevelState = WindLevel.Level4;
					}
				}
				base.ApplyState(state);
			}
			private GBC2017.GumRuntimes.SpriteRuntime WindSprite { get; set; }
			public WindDisplayRuntime (bool fullInstantiation = true, bool callAssignReferences = true)
				: base(fullInstantiation, false)
			{
				this.HasEvents = true;
				this.ExposeChildrenEvents = true;
				if (fullInstantiation)
				{
					Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "infodisplays/WindDisplay");
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
				WindSprite = this.GetGraphicalUiElementByName("WindSprite") as GBC2017.GumRuntimes.SpriteRuntime;
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
