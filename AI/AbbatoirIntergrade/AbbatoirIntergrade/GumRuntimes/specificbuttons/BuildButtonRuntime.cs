using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbbatoirIntergrade.Entities.BaseEntities;
using AbbatoirIntergrade.GameClasses.Interfaces;
using AbbatoirIntergrade.Performance;
using FlatRedBall.Gui;
using Gum.DataTypes;

namespace AbbatoirIntergrade.GumRuntimes
{
    public partial class BuildButtonRuntime : IBuildButton
    {
        public IEntityFactory BuildingFactory { get; private set; }
        public Type BuildingType { get; private set; }
        public bool IsEnabled => Enabled;

        partial void CustomInitialize()
        {
            RollOff += CircleButtonInstanceOnRollOff;
            RollOver += OnRollOver;
        }

        private void OnRollOver(IWindow window)
        {
            CurrentHighlightState = HasCursorOver(GuiManager.Cursor) ? Highlight.Highlighted : Highlight.NotHighlighted;
        }

        private void CircleButtonInstanceOnRollOff(IWindow window)
        {
            CurrentHighlightState = Highlight.NotHighlighted;
        }

        public void UpdateFromStructure(BaseStructure structure, IEntityFactory factory)
        {
            BuildingFactory = factory;
            BuildingType = structure.GetType();

            StructureSprite.SourceFile = structure.SpriteInstance.Texture;

            var textureHeight = structure.SpriteInstance.BottomTexturePixel - structure.SpriteInstance.TopTexturePixel;
            var textureWidth = structure.SpriteInstance.RightTexturePixel - structure.SpriteInstance.LeftTexturePixel;

            StructureSprite.TextureHeight = (int)textureHeight;
            StructureSprite.TextureWidth = (int)textureWidth;
            StructureSprite.TextureLeft = (int)structure.SpriteInstance.LeftTexturePixel;
            StructureSprite.TextureTop = (int)structure.SpriteInstance.TopTexturePixel;

            if (textureWidth > textureHeight)
            {
                StructureSprite.WidthUnits = DimensionUnitType.Percentage;
                StructureSprite.HeightUnits = DimensionUnitType.PercentageOfOtherDimension;
                StructureSprite.Width = 100;
                StructureSprite.Height = textureHeight / textureWidth * 100;
            }
            else
            {
                StructureSprite.HeightUnits = DimensionUnitType.Percentage;
                StructureSprite.WidthUnits = DimensionUnitType.PercentageOfOtherDimension;
                StructureSprite.Height = 100;
                StructureSprite.Width = textureWidth / textureHeight * 100;
            }
        }
    }
}
