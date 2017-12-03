	using System.Linq;
	namespace GBC2017.GumRuntimes
	{
		public partial class ButtonBarRuntime : GBC2017.GumRuntimes.ContainerRuntime
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
							BottomButtons.Height = 50f;
							BottomButtons.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
							BottomButtons.Width = 100f;
							BottomButtons.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
							BottomButtons.WrapsChildren = true;
							ButtonInstance.ButtonText = "Wind";
							ButtonInstance1.ButtonText = "Solar";
							ButtonInstance2.ButtonText = "Hydro";
							ButtonInstance3.ButtonText = "Thermal";
							ClipsChildren = false;
							CombatStructureButton.ButtonText = "Combat";
							CombatStructureButton.Width = 33.33f;
							EnergyStructureButton.ButtonText = "Energy";
							EnergyStructureButton.Width = 33.33f;
							Height = 14.5f;
							HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
							TopButtons.Height = 50f;
							TopButtons.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
							TopButtons.Width = 100f;
							TopButtons.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
							TopButtons.WrapsChildren = true;
							UtilityStructureButton.ButtonText = "Utility";
							UtilityStructureButton.Width = 33.34f;
							Visible = true;
							Width = 100f;
							WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
							WrapsChildren = true;
							XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
							XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
							YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
							YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
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
				bool setBottomButtonsHeightFirstValue = false;
				bool setBottomButtonsHeightSecondValue = false;
				float BottomButtonsHeightFirstValue= 0;
				float BottomButtonsHeightSecondValue= 0;
				bool setBottomButtonsWidthFirstValue = false;
				bool setBottomButtonsWidthSecondValue = false;
				float BottomButtonsWidthFirstValue= 0;
				float BottomButtonsWidthSecondValue= 0;
				bool setCombatStructureButtonWidthFirstValue = false;
				bool setCombatStructureButtonWidthSecondValue = false;
				float CombatStructureButtonWidthFirstValue= 0;
				float CombatStructureButtonWidthSecondValue= 0;
				bool setEnergyStructureButtonWidthFirstValue = false;
				bool setEnergyStructureButtonWidthSecondValue = false;
				float EnergyStructureButtonWidthFirstValue= 0;
				float EnergyStructureButtonWidthSecondValue= 0;
				bool setHeightFirstValue = false;
				bool setHeightSecondValue = false;
				float HeightFirstValue= 0;
				float HeightSecondValue= 0;
				bool setTopButtonsHeightFirstValue = false;
				bool setTopButtonsHeightSecondValue = false;
				float TopButtonsHeightFirstValue= 0;
				float TopButtonsHeightSecondValue= 0;
				bool setTopButtonsWidthFirstValue = false;
				bool setTopButtonsWidthSecondValue = false;
				float TopButtonsWidthFirstValue= 0;
				float TopButtonsWidthSecondValue= 0;
				bool setUtilityStructureButtonWidthFirstValue = false;
				bool setUtilityStructureButtonWidthSecondValue = false;
				float UtilityStructureButtonWidthFirstValue= 0;
				float UtilityStructureButtonWidthSecondValue= 0;
				bool setWidthFirstValue = false;
				bool setWidthSecondValue = false;
				float WidthFirstValue= 0;
				float WidthSecondValue= 0;
				switch(firstState)
				{
					case  VariableState.Default:
						setBottomButtonsHeightFirstValue = true;
						BottomButtonsHeightFirstValue = 50f;
						if (interpolationValue < 1)
						{
							this.BottomButtons.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
						}
						setBottomButtonsWidthFirstValue = true;
						BottomButtonsWidthFirstValue = 100f;
						if (interpolationValue < 1)
						{
							this.BottomButtons.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
						}
						if (interpolationValue < 1)
						{
							this.BottomButtons.WrapsChildren = true;
						}
						if (interpolationValue < 1)
						{
							this.ButtonInstance.ButtonText = "Wind";
						}
						if (interpolationValue < 1)
						{
							this.ButtonInstance1.ButtonText = "Solar";
						}
						if (interpolationValue < 1)
						{
							this.ButtonInstance2.ButtonText = "Hydro";
						}
						if (interpolationValue < 1)
						{
							this.ButtonInstance3.ButtonText = "Thermal";
						}
						if (interpolationValue < 1)
						{
							this.ClipsChildren = false;
						}
						if (interpolationValue < 1)
						{
							this.CombatStructureButton.ButtonText = "Combat";
						}
						setCombatStructureButtonWidthFirstValue = true;
						CombatStructureButtonWidthFirstValue = 33.33f;
						if (interpolationValue < 1)
						{
							this.EnergyStructureButton.ButtonText = "Energy";
						}
						setEnergyStructureButtonWidthFirstValue = true;
						EnergyStructureButtonWidthFirstValue = 33.33f;
						setHeightFirstValue = true;
						HeightFirstValue = 14.5f;
						if (interpolationValue < 1)
						{
							this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
						}
						setTopButtonsHeightFirstValue = true;
						TopButtonsHeightFirstValue = 50f;
						if (interpolationValue < 1)
						{
							this.TopButtons.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
						}
						setTopButtonsWidthFirstValue = true;
						TopButtonsWidthFirstValue = 100f;
						if (interpolationValue < 1)
						{
							this.TopButtons.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
						}
						if (interpolationValue < 1)
						{
							this.TopButtons.WrapsChildren = true;
						}
						if (interpolationValue < 1)
						{
							this.UtilityStructureButton.ButtonText = "Utility";
						}
						setUtilityStructureButtonWidthFirstValue = true;
						UtilityStructureButtonWidthFirstValue = 33.34f;
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
							this.WrapsChildren = true;
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
							this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
						}
						if (interpolationValue < 1)
						{
							this.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
						}
						break;
				}
				switch(secondState)
				{
					case  VariableState.Default:
						setBottomButtonsHeightSecondValue = true;
						BottomButtonsHeightSecondValue = 50f;
						if (interpolationValue >= 1)
						{
							this.BottomButtons.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
						}
						setBottomButtonsWidthSecondValue = true;
						BottomButtonsWidthSecondValue = 100f;
						if (interpolationValue >= 1)
						{
							this.BottomButtons.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
						}
						if (interpolationValue >= 1)
						{
							this.BottomButtons.WrapsChildren = true;
						}
						if (interpolationValue >= 1)
						{
							this.ButtonInstance.ButtonText = "Wind";
						}
						if (interpolationValue >= 1)
						{
							this.ButtonInstance1.ButtonText = "Solar";
						}
						if (interpolationValue >= 1)
						{
							this.ButtonInstance2.ButtonText = "Hydro";
						}
						if (interpolationValue >= 1)
						{
							this.ButtonInstance3.ButtonText = "Thermal";
						}
						if (interpolationValue >= 1)
						{
							this.ClipsChildren = false;
						}
						if (interpolationValue >= 1)
						{
							this.CombatStructureButton.ButtonText = "Combat";
						}
						setCombatStructureButtonWidthSecondValue = true;
						CombatStructureButtonWidthSecondValue = 33.33f;
						if (interpolationValue >= 1)
						{
							this.EnergyStructureButton.ButtonText = "Energy";
						}
						setEnergyStructureButtonWidthSecondValue = true;
						EnergyStructureButtonWidthSecondValue = 33.33f;
						setHeightSecondValue = true;
						HeightSecondValue = 14.5f;
						if (interpolationValue >= 1)
						{
							this.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
						}
						setTopButtonsHeightSecondValue = true;
						TopButtonsHeightSecondValue = 50f;
						if (interpolationValue >= 1)
						{
							this.TopButtons.HeightUnits = Gum.DataTypes.DimensionUnitType.Percentage;
						}
						setTopButtonsWidthSecondValue = true;
						TopButtonsWidthSecondValue = 100f;
						if (interpolationValue >= 1)
						{
							this.TopButtons.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
						}
						if (interpolationValue >= 1)
						{
							this.TopButtons.WrapsChildren = true;
						}
						if (interpolationValue >= 1)
						{
							this.UtilityStructureButton.ButtonText = "Utility";
						}
						setUtilityStructureButtonWidthSecondValue = true;
						UtilityStructureButtonWidthSecondValue = 33.34f;
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
							this.WrapsChildren = true;
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
							this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
						}
						if (interpolationValue >= 1)
						{
							this.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
						}
						break;
				}
				if (setBottomButtonsHeightFirstValue && setBottomButtonsHeightSecondValue)
				{
					BottomButtons.Height = BottomButtonsHeightFirstValue * (1 - interpolationValue) + BottomButtonsHeightSecondValue * interpolationValue;
				}
				if (setBottomButtonsWidthFirstValue && setBottomButtonsWidthSecondValue)
				{
					BottomButtons.Width = BottomButtonsWidthFirstValue * (1 - interpolationValue) + BottomButtonsWidthSecondValue * interpolationValue;
				}
				if (setCombatStructureButtonWidthFirstValue && setCombatStructureButtonWidthSecondValue)
				{
					CombatStructureButton.Width = CombatStructureButtonWidthFirstValue * (1 - interpolationValue) + CombatStructureButtonWidthSecondValue * interpolationValue;
				}
				if (setEnergyStructureButtonWidthFirstValue && setEnergyStructureButtonWidthSecondValue)
				{
					EnergyStructureButton.Width = EnergyStructureButtonWidthFirstValue * (1 - interpolationValue) + EnergyStructureButtonWidthSecondValue * interpolationValue;
				}
				if (setHeightFirstValue && setHeightSecondValue)
				{
					Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
				}
				if (setTopButtonsHeightFirstValue && setTopButtonsHeightSecondValue)
				{
					TopButtons.Height = TopButtonsHeightFirstValue * (1 - interpolationValue) + TopButtonsHeightSecondValue * interpolationValue;
				}
				if (setTopButtonsWidthFirstValue && setTopButtonsWidthSecondValue)
				{
					TopButtons.Width = TopButtonsWidthFirstValue * (1 - interpolationValue) + TopButtonsWidthSecondValue * interpolationValue;
				}
				if (setUtilityStructureButtonWidthFirstValue && setUtilityStructureButtonWidthSecondValue)
				{
					UtilityStructureButton.Width = UtilityStructureButtonWidthFirstValue * (1 - interpolationValue) + UtilityStructureButtonWidthSecondValue * interpolationValue;
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
			public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (GBC2017.GumRuntimes.ButtonBarRuntime.VariableState fromState,GBC2017.GumRuntimes.ButtonBarRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null)
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
				EnergyStructureButton.StopAnimations();
				CombatStructureButton.StopAnimations();
				UtilityStructureButton.StopAnimations();
				ButtonInstance.StopAnimations();
				ButtonInstance1.StopAnimations();
				ButtonInstance2.StopAnimations();
				ButtonInstance3.StopAnimations();
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
							Name = "BottomButtons.Height",
							Type = "float",
							Value = BottomButtons.Height
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "BottomButtons.Height Units",
							Type = "DimensionUnitType",
							Value = BottomButtons.HeightUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "BottomButtons.Width",
							Type = "float",
							Value = BottomButtons.Width
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "BottomButtons.Width Units",
							Type = "DimensionUnitType",
							Value = BottomButtons.WidthUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "BottomButtons.Wraps Children",
							Type = "bool",
							Value = BottomButtons.WrapsChildren
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "ButtonInstance.ButtonText",
							Type = "string",
							Value = ButtonInstance.ButtonText
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "ButtonInstance1.ButtonText",
							Type = "string",
							Value = ButtonInstance1.ButtonText
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "ButtonInstance2.ButtonText",
							Type = "string",
							Value = ButtonInstance2.ButtonText
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "ButtonInstance3.ButtonText",
							Type = "string",
							Value = ButtonInstance3.ButtonText
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
							Name = "CombatStructureButton.ButtonText",
							Type = "string",
							Value = CombatStructureButton.ButtonText
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CombatStructureButton.Width",
							Type = "float",
							Value = CombatStructureButton.Width
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "EnergyStructureButton.ButtonText",
							Type = "string",
							Value = EnergyStructureButton.ButtonText
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "EnergyStructureButton.Width",
							Type = "float",
							Value = EnergyStructureButton.Width
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
							Name = "TopButtons.Height",
							Type = "float",
							Value = TopButtons.Height
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "TopButtons.Height Units",
							Type = "DimensionUnitType",
							Value = TopButtons.HeightUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "TopButtons.Width",
							Type = "float",
							Value = TopButtons.Width
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "TopButtons.Width Units",
							Type = "DimensionUnitType",
							Value = TopButtons.WidthUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "TopButtons.Wraps Children",
							Type = "bool",
							Value = TopButtons.WrapsChildren
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "UtilityStructureButton.ButtonText",
							Type = "string",
							Value = UtilityStructureButton.ButtonText
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "UtilityStructureButton.Width",
							Type = "float",
							Value = UtilityStructureButton.Width
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
							Name = "BottomButtons.Height",
							Type = "float",
							Value = BottomButtons.Height + 50f
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "BottomButtons.Height Units",
							Type = "DimensionUnitType",
							Value = BottomButtons.HeightUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "BottomButtons.Width",
							Type = "float",
							Value = BottomButtons.Width + 100f
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "BottomButtons.Width Units",
							Type = "DimensionUnitType",
							Value = BottomButtons.WidthUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "BottomButtons.Wraps Children",
							Type = "bool",
							Value = BottomButtons.WrapsChildren
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "ButtonInstance.ButtonText",
							Type = "string",
							Value = ButtonInstance.ButtonText
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "ButtonInstance1.ButtonText",
							Type = "string",
							Value = ButtonInstance1.ButtonText
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "ButtonInstance2.ButtonText",
							Type = "string",
							Value = ButtonInstance2.ButtonText
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "ButtonInstance3.ButtonText",
							Type = "string",
							Value = ButtonInstance3.ButtonText
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
							Name = "CombatStructureButton.ButtonText",
							Type = "string",
							Value = CombatStructureButton.ButtonText
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "CombatStructureButton.Width",
							Type = "float",
							Value = CombatStructureButton.Width + 33.33f
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "EnergyStructureButton.ButtonText",
							Type = "string",
							Value = EnergyStructureButton.ButtonText
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "EnergyStructureButton.Width",
							Type = "float",
							Value = EnergyStructureButton.Width + 33.33f
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "Height",
							Type = "float",
							Value = Height + 14.5f
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
							Name = "TopButtons.Height",
							Type = "float",
							Value = TopButtons.Height + 50f
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "TopButtons.Height Units",
							Type = "DimensionUnitType",
							Value = TopButtons.HeightUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "TopButtons.Width",
							Type = "float",
							Value = TopButtons.Width + 100f
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "TopButtons.Width Units",
							Type = "DimensionUnitType",
							Value = TopButtons.WidthUnits
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "TopButtons.Wraps Children",
							Type = "bool",
							Value = TopButtons.WrapsChildren
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "UtilityStructureButton.ButtonText",
							Type = "string",
							Value = UtilityStructureButton.ButtonText
						}
						);
						newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
						{
							SetsValue = true,
							Name = "UtilityStructureButton.Width",
							Type = "float",
							Value = UtilityStructureButton.Width + 33.34f
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
			private GBC2017.GumRuntimes.ButtonRuntime EnergyStructureButton { get; set; }
			private GBC2017.GumRuntimes.ButtonRuntime CombatStructureButton { get; set; }
			private GBC2017.GumRuntimes.ButtonRuntime UtilityStructureButton { get; set; }
			private GBC2017.GumRuntimes.ContainerRuntime TopButtons { get; set; }
			private GBC2017.GumRuntimes.ContainerRuntime BottomButtons { get; set; }
			private GBC2017.GumRuntimes.ButtonRuntime ButtonInstance { get; set; }
			private GBC2017.GumRuntimes.ButtonRuntime ButtonInstance1 { get; set; }
			private GBC2017.GumRuntimes.ButtonRuntime ButtonInstance2 { get; set; }
			private GBC2017.GumRuntimes.ButtonRuntime ButtonInstance3 { get; set; }
			public event FlatRedBall.Gui.WindowEvent EnergyStructureButtonClick;
			public event FlatRedBall.Gui.WindowEvent CombatStructureButtonClick;
			public event FlatRedBall.Gui.WindowEvent UtilityStructureButtonClick;
			public event FlatRedBall.Gui.WindowEvent TopButtonsClick;
			public event FlatRedBall.Gui.WindowEvent BottomButtonsClick;
			public event FlatRedBall.Gui.WindowEvent ButtonInstanceClick;
			public event FlatRedBall.Gui.WindowEvent ButtonInstance1Click;
			public event FlatRedBall.Gui.WindowEvent ButtonInstance2Click;
			public event FlatRedBall.Gui.WindowEvent ButtonInstance3Click;
			public ButtonBarRuntime (bool fullInstantiation = true, bool callAssignReferences = true)
				: base(fullInstantiation, false)
			{
				this.HasEvents = true;
				this.ExposeChildrenEvents = true;
				if (fullInstantiation)
				{
					Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "ButtonBar");
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
				EnergyStructureButton = this.GetGraphicalUiElementByName("EnergyStructureButton") as GBC2017.GumRuntimes.ButtonRuntime;
				EnergyStructureButton.AssignReferences();
				CombatStructureButton = this.GetGraphicalUiElementByName("CombatStructureButton") as GBC2017.GumRuntimes.ButtonRuntime;
				CombatStructureButton.AssignReferences();
				UtilityStructureButton = this.GetGraphicalUiElementByName("UtilityStructureButton") as GBC2017.GumRuntimes.ButtonRuntime;
				UtilityStructureButton.AssignReferences();
				TopButtons = this.GetGraphicalUiElementByName("TopButtons") as GBC2017.GumRuntimes.ContainerRuntime;
				BottomButtons = this.GetGraphicalUiElementByName("BottomButtons") as GBC2017.GumRuntimes.ContainerRuntime;
				ButtonInstance = this.GetGraphicalUiElementByName("ButtonInstance") as GBC2017.GumRuntimes.ButtonRuntime;
				ButtonInstance.AssignReferences();
				ButtonInstance1 = this.GetGraphicalUiElementByName("ButtonInstance1") as GBC2017.GumRuntimes.ButtonRuntime;
				ButtonInstance1.AssignReferences();
				ButtonInstance2 = this.GetGraphicalUiElementByName("ButtonInstance2") as GBC2017.GumRuntimes.ButtonRuntime;
				ButtonInstance2.AssignReferences();
				ButtonInstance3 = this.GetGraphicalUiElementByName("ButtonInstance3") as GBC2017.GumRuntimes.ButtonRuntime;
				ButtonInstance3.AssignReferences();
				EnergyStructureButton.Click += (unused) => EnergyStructureButtonClick?.Invoke(this);
				CombatStructureButton.Click += (unused) => CombatStructureButtonClick?.Invoke(this);
				UtilityStructureButton.Click += (unused) => UtilityStructureButtonClick?.Invoke(this);
				TopButtons.Click += (unused) => TopButtonsClick?.Invoke(this);
				BottomButtons.Click += (unused) => BottomButtonsClick?.Invoke(this);
				ButtonInstance.Click += (unused) => ButtonInstanceClick?.Invoke(this);
				ButtonInstance1.Click += (unused) => ButtonInstance1Click?.Invoke(this);
				ButtonInstance2.Click += (unused) => ButtonInstance2Click?.Invoke(this);
				ButtonInstance3.Click += (unused) => ButtonInstance3Click?.Invoke(this);
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
