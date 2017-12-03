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
using AbbatoirIntergrade.Screens;
namespace AbbatoirIntergrade.Entities.BaseEntities
{
	public partial class BaseEnemy
	{
        void OnAfterSpriteInstanceCurrentChainNameSet (object sender, EventArgs e)
        {
            SpriteInstance.FlipHorizontal = CurrentDirectionState == Direction.MovingLeft;
            SpriteInstance.IgnoreAnimationChainTextureFlip = SpriteInstance.FlipHorizontal;
        }
		
	}
}
