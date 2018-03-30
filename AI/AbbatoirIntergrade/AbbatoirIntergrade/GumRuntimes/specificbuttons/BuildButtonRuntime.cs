using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbbatoirIntergrade.Entities.BaseEntities;
using AbbatoirIntergrade.GameClasses.Interfaces;
using AbbatoirIntergrade.Performance;
using FlatRedBall;
using FlatRedBall.Graphics;
using FlatRedBall.Graphics.Texture;
using FlatRedBall.Gui;
using Gum.DataTypes;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AbbatoirIntergrade.GumRuntimes
{
    public partial class BuildButtonRuntime : IBuildButton
    {
        public IEntityFactory BuildingFactory { get; private set; }
        public Type BuildingType { get; private set; }
        public bool IsEnabled => Enabled;
        public Action<Tuple<int, int>, float, float> RangeDisplayAction;
        public Action<StructureInfoRuntime.StructureInfoSaveState> InfoDisplayAction;
        public Action HideRangePreviewAction;
        public Action HideStructurePreviewAction;

        private StructureInfoRuntime.StructureInfoSaveState structureInfo;
        private Tuple<int, int> RangeTuple;
        private float RangeXOffset;
        private float RangeYOffset;

        public bool CanAfford { get; private set; }

        partial void CustomInitialize()
        {
            RollOff += CircleButtonInstanceOnRollOff;
            RollOver += OnRollOver;
        }

        private void OnRollOver(IWindow window)
        {
            if (Enabled)
            {
                CurrentHighlightState = HasCursorOver(GuiManager.Cursor) 
                    ? (CanAfford ? Highlight.Highlighted : Highlight.HighlightedCantAfford)
                    : (CanAfford ? Highlight.NotHighlighted : Highlight.NotHighlightedCantAfford);

                StructureSprite.Alpha = (CanAfford ? 255 : 75);
                RangeDisplayAction(RangeTuple, RangeXOffset, RangeYOffset);
                InfoDisplayAction(structureInfo);
            }
        }

        private void CircleButtonInstanceOnRollOff(IWindow window)
        {
            if (Enabled)
            {
                CurrentHighlightState = (CanAfford ? Highlight.NotHighlighted : Highlight.NotHighlightedCantAfford);
                StructureSprite.Alpha = (CanAfford ? 255 : 75);
                HideRangePreviewAction?.Invoke();
                HideStructurePreviewAction?.Invoke();
            }
        }

        public void UpdateFromStructure(BaseStructure structure, IEntityFactory factory, int currentSatoshis)
        {
            BuildingFactory = factory;
            RangeTuple = new Tuple<int, int>((int)structure.RangedRadius, (int)structure.MinimumRangeRadius);
            RangeXOffset = structure.PivotPoint.RelativeX;
            RangeYOffset = structure.SpriteInstance.RelativeY;
            BuildingType = structure.GetType();
            structureInfo = new StructureInfoRuntime.StructureInfoSaveState(structure);
            UpdateAffordability(currentSatoshis);

            RenderTarget2D renderTarget = null;
            var renderName = BuildingType.FullName + ".png";
            var contentManagerName = FlatRedBallServices.GlobalContentManager;

            if (FlatRedBallServices
                .GetContentManagerByName(contentManagerName)
                .IsAssetLoadedByName<RenderTarget2D>(renderName))
            {
                renderTarget = FlatRedBallServices
                    .GetContentManagerByName(contentManagerName)
                    .GetDisposable<RenderTarget2D>(renderName);
            }

            var baseHeight = structure.SpriteInstance.Height;
            var baseWidth = structure.SpriteInstance.Width;

            if (renderTarget == null)
            {
                structure.AimSpriteInstance.RelativeRotationZ = MathHelper.ToRadians(0);
                structure.Collision.Visible = false;
                structure.LightSpriteInstance.Visible = false;
                var relativeY = structure.SpriteInstance.RelativeY;
                structure.SpriteInstance.RelativeY = 0;

                relativeY = structure.SpriteInstance.RelativeY - relativeY;

                structure.PivotPoint.RelativeY += relativeY;
                structure.ForceUpdateDependenciesDeep();

                var aimHeight = structure.AimSpriteInstance.Height;
                var aimWidth = structure.AimSpriteInstance.Width;

                var aimRelativeX = structure.PivotPoint.RelativeX + structure.AimSpriteInstance.RelativeX;
                var aimRelativeY = structure.PivotPoint.RelativeY + structure.AimSpriteInstance.RelativeY;

                var structureTop = Math.Min(-baseHeight / 2,
                    -aimRelativeY - aimHeight / 2);
                var structureBottom = Math.Max(baseHeight / 2,
                    -aimRelativeY + aimHeight / 2);

                var structureLeft = Math.Min(-baseWidth / 2,
                    aimRelativeX - aimWidth / 2);
                var structureRight = Math.Max((baseWidth / 2),
                    aimRelativeX + aimWidth / 2);

                var structureHeight = (int)Math.Abs(structureTop - structureBottom);
                var structureWidth = (int)Math.Abs(structureRight - structureLeft);

                // This layer holds whatever we want drawn
                var temporaryLayer = new Layer();

                // Define the layer. This uses the current game's resolution, but it could be any size
                renderTarget = new RenderTarget2D(
                    FlatRedBallServices.GraphicsDevice,
                    structureWidth,
                    structureHeight);
                temporaryLayer.RenderTarget = renderTarget;
                structure.MoveToLayer(temporaryLayer);
                structure.Y = -structureHeight / 2 + structure.SpriteInstance.Height / 2;
                structure.ForceUpdateDependenciesDeep();

                // Rendering requires a camera. We'll create a temporary one (don't add it to the SpriteManager)
                var temporaryCamera = new Camera(null, structureWidth, structureHeight) { DrawsWorld = false, Z = 40 };
                // We only want the camera to draw the layer
                temporaryCamera.UsePixelCoordinates();
                temporaryCamera.AddLayer(temporaryLayer);

                Renderer.DrawCamera(temporaryCamera, null);

                //using (var fileStream = File.Create("test.png"))
                //{
                //    structureTexture.SaveAsPng(fileStream, structureTexture.Width, structureTexture.Height);
                //}

                FlatRedBallServices.AddDisposable(
                    renderName,
                    renderTarget,
                    contentManagerName);
            }

            StructureSprite.SourceFile = renderTarget;

            StructureSprite.TextureHeight = renderTarget.Height;
            StructureSprite.TextureWidth = renderTarget.Width;
            StructureSprite.TextureLeft = 0;
            StructureSprite.TextureTop = 0;

            if (renderTarget.Width > renderTarget.Height)
            {
                StructureSprite.WidthUnits = DimensionUnitType.Percentage;
                StructureSprite.HeightUnits = DimensionUnitType.PercentageOfOtherDimension;
                StructureSprite.Width = 100;
                StructureSprite.Height = baseHeight / baseWidth * 100;
            }
            else
            {
                StructureSprite.HeightUnits = DimensionUnitType.Percentage;
                StructureSprite.WidthUnits = DimensionUnitType.PercentageOfOtherDimension;
                StructureSprite.Height = 100;
                StructureSprite.Width = baseWidth / baseHeight * 100;
            }
        }

        public void UpdateAffordability(int availableSatoshis)
        {
            if (structureInfo == null) return;

            CanAfford = availableSatoshis >= structureInfo.SatoshiCost;
            
            if (CanAfford)
            {
                CurrentHighlightState = CurrentHighlightState == Highlight.HighlightedCantAfford ? Highlight.Highlighted : Highlight.NotHighlighted;
            }
            else
            {
                CurrentHighlightState = CurrentHighlightState == Highlight.Highlighted ? Highlight.HighlightedCantAfford : Highlight.NotHighlightedCantAfford;
            }

            StructureSprite.Alpha = (CanAfford ? 255 : 75);
        }

        public void Disable()
        {
            BuildingFactory = null;
            BuildingType = null;
            Enabled = false;
        }
    }
}
