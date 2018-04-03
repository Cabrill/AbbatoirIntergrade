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
            //if (_hudLayer != null)
            //{ 
            //    _hudLayer.Remove(SpriteInstance);
            //     SpriteManager.AddToLayer(SpriteInstance, LayerProvidedByContainer);

            //    _hudLayer.Remove(AimSpriteInstance);
            //    SpriteManager.AddToLayer(AimSpriteInstance, LayerProvidedByContainer);
            //}
        }

        void OnAfterIsValidLocationSet (object sender, EventArgs e)
        {
            //if (CurrentState != VariableState.CantAfford)
            //{
            //    CurrentState = VariableState.ValidLocation;
            //}
            //else
            //{
            //    CurrentState = VariableState.InvalidLocation;
            //}
        }
	}
}
