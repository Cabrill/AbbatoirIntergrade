using System;
using FlatRedBall;
using FlatRedBall.Input;
using FlatRedBall.Instructions;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Specialized;
using FlatRedBall.Audio;
using FlatRedBall.Screens;
using AbbatoirIntergrade.Entities.BaseEntities;
using AbbatoirIntergrade.Entities;
using AbbatoirIntergrade.Entities.Enemies;
using AbbatoirIntergrade.Entities.GraphicalElements;
namespace AbbatoirIntergrade.Entities.BaseEntities
{
	public partial class BaseStructure
	{
        void OnAfterIsBeingPlacedSet (object sender, EventArgs e)
        {
            CheckmarkInstance.Visible = IsBeingPlaced;
            XCancelInstance.Visible = IsBeingPlaced;

            if (_hudLayer != null)
            { 
                _hudLayer.Remove(SpriteInstance);
                 SpriteManager.AddToLayer(SpriteInstance, LayerProvidedByContainer);
            }
        }

        void OnAfterIsValidLocationSet (object sender, EventArgs e)
        {
            if (CurrentState != VariableState.CantAfford)
            {
                CurrentState = VariableState.ValidLocation;
                CheckmarkInstance.CurrentState = Checkmark.VariableState.Enabled;
            }
            else
            {
                CurrentState = VariableState.InvalidLocation;
                CheckmarkInstance.CurrentState = Checkmark.VariableState.Disabled;
            }
        }
	}
}
