	using System.Linq;
	namespace GBC2017.GumRuntimes
	{
		public partial class SunlightDisplayRuntime : GBC2017.GumRuntimes.ContainerRuntime
		{
			#region State Enums
			public enum VariableState
			{
				Default
			}
			public enum SunLevel
			{
				Level1,
				Level2,
				Level3,
				Level4
			}
			#endregion
			#region State Fields
			VariableState mCurrentVariableState;
			SunLevel mCurrentSunLevelState;
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
							SpriteInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
							SetProperty("SpriteInstance.SourceFile", "../globalcontent/AllAssetsSheet.png");
							SpriteInstance.TextureAddress = Gum.Managers.TextureAddress.Custom;
							SpriteInstance.TextureHeight = 64;
							SpriteInstance.TextureLeft = 164;
							SpriteInstance.TextureTop = 93;
							SpriteInstance.TextureWidth = 64;
							SpriteInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
							Visible = true;
							Width = 100f;
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
			public SunLevel CurrentSunLevelState
			{
				get
				{
					return mCurrentSunLevelState;
				}
				set
				{
					mCurrentSunLevelState = value;
					switch(mCurrentSunLevelState)
					{
						case  SunLevel.Level1:
							SpriteInstance.TextureLeft = 164;
							break;
						case  SunLevel.Level2:
							SpriteInstance.TextureLeft = 229;
							break;
						case  SunLevel.Level3:
							SpriteInstance.TextureLeft = 294;
							break;
						case  SunLevel.Level4:
							SpriteInstance.TextureLeft = 359;
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
				bool setSpriteInstanceTextureHeightFirstValue = false;
				bool setSpriteInstanceTextureHeightSecondValue = false;
				int SpriteInstanceTextureHeightFirstValue= 0;
				int SpriteInstanceTextureHeightSecondValue= 0;
				bool setSpriteInstanceTextureLeftFirstValue = false;
				bool setSpriteInstanceTextureLeftSecondValue = false;
				int SpriteInstanceTextureLeftFirstValue= 0;
				int SpriteInstanceTextureLeftSecondValue= 0;
				bool setSpriteInstanceTextureTopFirstValue = false;
				bool setSpriteInstanceTextureTopSecondValue = false;
				int SpriteInstanceTextureTopFirstValue= 0;
				int SpriteInstanceTextureTopSecondValue= 0;
				bool setSpriteInstanceTextureWidthFirstValue = false;
				bool setSpriteInstanceTextureWidthSecondValue = false;
				int SpriteInstanceTextureWidthFirstValue= 0;
				int SpriteInstanceTextureWidthSecondValue= 0;
				bool setWidthFirstValue = false;
				bool setWidthSecondValue = false;
				float WidthFirstValue= 0;
				float WidthSecondValue= 0;
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
							this.SpriteInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
						}
						if (interpolationValue < 1)
						{
							SetProperty("SpriteInstance.SourceFile", "../globalcontent/AllAssetsSheet.png");
						}
						if (interpolationValue < 1)
						{
							this.SpriteInstance.TextureAddress = Gum.Managers.TextureAddress.Custom;
						}
						setSpriteInstanceTextureHeightFirstValue = true;
						SpriteInstanceTextureHeightFirstValue = 64;
						setSpriteInstanceTextureLeftFirstValue = true;
						SpriteInstanceTextureLeftFirstValue = 164;
						setSpriteInstanceTextureTopFirstValue = true;
						SpriteInstanceTextureTopFirstValue = 93;
						setSpriteInstanceTextureWidthFirstValue = true;
						SpriteInstanceTextureWidthFirstValue = 64;
						if (interpolationValue < 1)
						{
							this.SpriteInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
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
							this.SpriteInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
						}
						if (interpolationValue >= 1)
						{
							SetProperty("SpriteInstance.SourceFile", "../globalcontent/AllAssetsSheet.png");
						}
						if (interpolationValue >= 1)
						{
							this.SpriteInstance.TextureAddress = Gum.Managers.TextureAddress.Custom;
						}
						setSpriteInstanceTextureHeightSecondValue = true;
						SpriteInstanceTextureHeightSecondValue = 64;
						setSpriteInstanceTextureLeftSecondValue = true;
						SpriteInstanceTextureLeftSecondValue = 164;
						setSpriteInstanceTextureTopSecondValue = true;
						SpriteInstanceTextureTopSecondValue = 93;
						setSpriteInstanceTextureWidthSecondValue = true;
						SpriteInstanceTextureWidthSecondValue = 64;
						if (interpolationValue >= 1)
						{
							this.SpriteInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
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
				if (setSpriteInstanceTextureHeightFirstValue && setSpriteInstanceTextureHeightSecondValue)
				{
					SpriteInstance.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(SpriteInstanceTextureHeightFirstValue* (1 - interpolationValue) + SpriteInstanceTextureHeightSecondValue * interpolationValue);
				}
				if (setSpriteInstanceTextureLeftFirstValue && setSpriteInstanceTextureLeftSecondValue)
				{
					SpriteInstance.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(SpriteInstanceTextureLeftFirstValue* (1 - interpolationValue) + SpriteInstanceTextureLeftSecondValue * interpolationValue);
				}
				if (setSpriteInstanceTextureTopFirstValue && setSpriteInstanceTextureTopSecondValue)
				{
					SpriteInstance.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(SpriteInstanceTextureTopFirstValue* (1 - interpolationValue) + SpriteInstanceTextureTopSecondValue * interpolationValue);
				}
				if (setSpriteInstanceTextureWidthFirstValue && setSpriteInstanceTextureWidthSecondValue)
				{
					SpriteInstance.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(SpriteInstanceTextureWidthFirstValue* (1 - interpolationValue) + SpriteInstanceTextureWidthSecondValue * interpolationValue);
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
			public void InterpolateBetween (SunLevel firstState, SunLevel secondState, float interpolationValue)
			{
				#if DEBUG
				if (float.IsNaN(interpolationValue))
				{
					throw new System.Exception("interpolationValue cannot be NaN");
				}
				#endif
				bool setSpriteInstanceTextureLeftFirstValue = false;
				bool setSpriteInstanceTextureLeftSecondValue = false;
				int SpriteInstanceTextureLeftFirstValue= 0;
				int SpriteInstanceTextureLeftSecondValue= 0;
				switch(firstState)
				{
					case  SunLevel.Level1:
						setSpriteInstanceTextureLeftFirstValue = true;
						SpriteInstanceTextureLeftFirstValue = 164;
						break;
					case  SunLevel.Level2:
						setSpriteInstanceTextureLeftFirstValue = true;
						SpriteInstanceTextureLeftFirstValue = 229;
						break;
					case  SunLevel.Level3:
						setSpriteInstanceTextureLeftFirstValue = true;
						SpriteInstanceTextureLeftFirstValue = 294;
						break;
					case  SunLevel.Level4:
						setSpriteInstanceTextureLeftFirstValue = true;
						SpriteInstanceTextureLeftFirstValue = 359;
						break;
				}
				switch(secondState)
				{
					case  SunLevel.Level1:
						setSpriteInstanceTextureLeftSecondValue = true;
						SpriteInstanceTextureLeftSecondValue = 164;
						break;
					case  SunLevel.Level2:
						setSpriteInstanceTextureLeftSecondValue = true;
						SpriteInstanceTextureLeftSecondValue = 229;
						break;
					case  SunLevel.Level3:
						setSpriteInstanceTextureLeftSecondValue = true;
						SpriteInstanceTextureLeftSecondValue = 294;
						break;
					case  SunLevel.Level4:
						setSpriteInstanceTextureLeftSecondValue = true;
						SpriteInstanceTextureLeftSecondValue = 359;
						break;
				}
				if (setSpriteInstanceTextureLeftFirstValue && setSpriteInstanceTextureLeftSecondValue)
				{
					SpriteInstance.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(SpriteInstanceTextureLeftFirstValue* (1 - interpolationValue) + SpriteInstanceTextureLeftSecondValue * interpolationValue);
				}
				if (interpolationValue < 1)
				{
					mCurrentSunLevelState = firstState;
				}
				else
				{
					mCurrentSunLevelState = secondState;
				}
			}
			#endregion
			#region State Interpolate To
			public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (GBC2017.GumRuntimes.SunlightDisplayRuntime.VariableState fromState,GBC2017.GumRuntimes.SunlightDisplayRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null)
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
			public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (GBC2017.GumRuntimes.SunlightDisplayRuntime.SunLevel fromState,GBC2017.GumRuntimes.SunlightDisplayRuntime.SunLevel toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null)
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
			public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (SunLevel toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null )
			{
				Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
				Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "SunLevel").States.First(item => item.Name == toState.ToString());
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
				tweener.Ended += ()=> this.CurrentSunLevelState = toState;
				tweener.Start();
				StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
				return tweener;
			}
			public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (SunLevel toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null )
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
				tweener.Ended += ()=> this.CurrentSunLevelState = toState;
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
							Name = "SpriteInstance.Height Units",
							Type = "DimensionUnitType",
							Value = SpriteInstance.HeightUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "SpriteInstance.SourceFile",
							Type = "string",
							Value = SpriteInstance.SourceFile
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "SpriteInstance.Texture Address",
							Type = "TextureAddress",
							Value = SpriteInstance.TextureAddress
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "SpriteInstance.Texture Height",
							Type = "int",
							Value = SpriteInstance.TextureHeight
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "SpriteInstance.Texture Left",
							Type = "int",
							Value = SpriteInstance.TextureLeft
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "SpriteInstance.Texture Top",
							Type = "int",
							Value = SpriteInstance.TextureTop
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "SpriteInstance.Texture Width",
							Type = "int",
							Value = SpriteInstance.TextureWidth
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "SpriteInstance.Width Units",
							Type = "DimensionUnitType",
							Value = SpriteInstance.WidthUnits
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
							Name = "SpriteInstance.Height Units",
							Type = "DimensionUnitType",
							Value = SpriteInstance.HeightUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "SpriteInstance.SourceFile",
							Type = "string",
							Value = SpriteInstance.SourceFile
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "SpriteInstance.Texture Address",
							Type = "TextureAddress",
							Value = SpriteInstance.TextureAddress
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "SpriteInstance.Texture Height",
							Type = "int",
							Value = SpriteInstance.TextureHeight + 64
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "SpriteInstance.Texture Left",
							Type = "int",
							Value = SpriteInstance.TextureLeft + 164
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "SpriteInstance.Texture Top",
							Type = "int",
							Value = SpriteInstance.TextureTop + 93
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "SpriteInstance.Texture Width",
							Type = "int",
							Value = SpriteInstance.TextureWidth + 64
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "SpriteInstance.Width Units",
							Type = "DimensionUnitType",
							Value = SpriteInstance.WidthUnits
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
			private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (SunLevel state)
			{
				Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
				switch(state)
				{
					case  SunLevel.Level1:
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "SpriteInstance.Texture Left",
							Type = "int",
							Value = SpriteInstance.TextureLeft
						}
						);
						break;
					case  SunLevel.Level2:
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "SpriteInstance.Texture Left",
							Type = "int",
							Value = SpriteInstance.TextureLeft
						}
						);
						break;
					case  SunLevel.Level3:
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "SpriteInstance.Texture Left",
							Type = "int",
							Value = SpriteInstance.TextureLeft
						}
						);
						break;
					case  SunLevel.Level4:
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "SpriteInstance.Texture Left",
							Type = "int",
							Value = SpriteInstance.TextureLeft
						}
						);
						break;
				}
				return newState;
			}
			private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (SunLevel state)
			{
				Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
				switch(state)
				{
					case  SunLevel.Level1:
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "SpriteInstance.Texture Left",
							Type = "int",
							Value = SpriteInstance.TextureLeft + 164
						}
						);
						break;
					case  SunLevel.Level2:
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "SpriteInstance.Texture Left",
							Type = "int",
							Value = SpriteInstance.TextureLeft + 229
						}
						);
						break;
					case  SunLevel.Level3:
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "SpriteInstance.Texture Left",
							Type = "int",
							Value = SpriteInstance.TextureLeft + 294
						}
						);
						break;
					case  SunLevel.Level4:
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "SpriteInstance.Texture Left",
							Type = "int",
							Value = SpriteInstance.TextureLeft + 359
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
					else if (category.Name == "SunLevel")
					{
						if(state.Name == "Level1") this.mCurrentSunLevelState = SunLevel.Level1;
						if(state.Name == "Level2") this.mCurrentSunLevelState = SunLevel.Level2;
						if(state.Name == "Level3") this.mCurrentSunLevelState = SunLevel.Level3;
						if(state.Name == "Level4") this.mCurrentSunLevelState = SunLevel.Level4;
					}
				}
				base.ApplyState(state);
			}
			private GBC2017.GumRuntimes.SpriteRuntime SpriteInstance { get; set; }
			public SunlightDisplayRuntime (bool fullInstantiation = true, bool callAssignReferences = true)
				: base(fullInstantiation, false)
			{
				this.HasEvents = true;
				this.ExposeChildrenEvents = true;
				if (fullInstantiation)
				{
					Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "infodisplays/SunlightDisplay");
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
				SpriteInstance = this.GetGraphicalUiElementByName("SpriteInstance") as GBC2017.GumRuntimes.SpriteRuntime;
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
