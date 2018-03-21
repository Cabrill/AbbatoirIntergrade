using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbbatoirIntergrade.Entities.GraphicalElements;
using FlatRedBall.AI.Pathfinding;
using FlatRedBall.Math;
using FlatRedBall.Math.Geometry;
using FlatRedBall.TileGraphics;
using Microsoft.Xna.Framework;

namespace AbbatoirIntergrade.StaticManagers
{
    public static class NodeNetworkGenerator
    {
        private enum NodeType
        {
            Normal,
            Path
        };

        public static TileNodeNetwork CreateFromTiledMap(LayeredTileMap map)
        {
            float[] costs = new float[32];
            costs[(int)NodeType.Normal] = 2;
            costs[(int)NodeType.Path] = 1;

            var GridWidth = 64;
            
            var network = new TileNodeNetwork(0,//GridWidth / 2f,
                -map.Height,// + GridWidth / 2f,
                GridWidth,
                MathFunctions.RoundToInt(map.Width / GridWidth),
                MathFunctions.RoundToInt(map.Height / GridWidth),
                DirectionalType.Eight);
            
            var groundLayer = map.MapLayers.FirstOrDefault(l => l.Name == "Ground");

            var tileNamesForPath = map.TileProperties
                .Where(item => item.Value
                    .Any(customProperty => customProperty.Value.Equals("Normal")))
                .Select(item => item.Key)
                .ToArray();


            foreach (var tileName in tileNamesForPath)
            {
                var indexes = groundLayer.NamedTileOrderedIndexes.ContainsKey(tileName)
                    ? groundLayer.NamedTileOrderedIndexes[tileName]
                    : null;

                if (indexes != null)
                {
                    var count = indexes.Count;
                    for (var i = count - 1; i > -1; i--)
                    {
                        var gridWidthAdjust = GridWidth;
                        groundLayer.GetBottomLeftWorldCoordinateForOrderedTile(indexes[i], out float x, out float y);
                        
                        network.AddAndLinkTiledNodeWorld(x, y).PropertyField = (1 << (int)(NodeType.Normal)); 
                        network.AddAndLinkTiledNodeWorld(x+ gridWidthAdjust, y).PropertyField = (1 << (int)(NodeType.Normal));
                        network.AddAndLinkTiledNodeWorld(x, y+ gridWidthAdjust).PropertyField = (1 << (int)(NodeType.Normal));
                        network.AddAndLinkTiledNodeWorld(x+gridWidthAdjust, y+gridWidthAdjust).PropertyField = (1 << (int)(NodeType.Normal));
                    }
                }
            }

            tileNamesForPath = map.TileProperties
                .Where(item => item.Value
                    .Any(customProperty => customProperty.Value.Equals("Path")))
                .Select(item => item.Key)
                .ToArray();

            foreach (var tileName in tileNamesForPath)
            {
                var indexes = groundLayer.NamedTileOrderedIndexes.ContainsKey(tileName)
                    ? groundLayer.NamedTileOrderedIndexes[tileName]
                    : null;

                if (indexes != null)
                {
                    var count = indexes.Count;
                    for (var i = count - 1; i > -1; i--)
                    {
                        var gridWidthAdjust = GridWidth;
                        groundLayer.GetBottomLeftWorldCoordinateForOrderedTile(indexes[i], out float x, out float y);

                        network.AddAndLinkTiledNodeWorld(x, y).PropertyField = (1 << (int)(NodeType.Path));
                        network.AddAndLinkTiledNodeWorld(x + gridWidthAdjust, y).PropertyField = (1 << (int)(NodeType.Path));
                        network.AddAndLinkTiledNodeWorld(x, y + gridWidthAdjust).PropertyField = (1 << (int)(NodeType.Path));
                        network.AddAndLinkTiledNodeWorld(x + gridWidthAdjust, y + gridWidthAdjust).PropertyField = (1 << (int)(NodeType.Path));
                    }
                }
            }
            network.SetCosts(costs);
            

            return network;
        }

        public static void RemoveNodesWithCollisions(ref TileNodeNetwork network, 
            PositionedObjectList<TileCollisionRectangle> rectangleCollision, 
            PositionedObjectList<TileCollisionCircle> circleCollision, 
            PositionedObjectList<StructurePlacement> structurePlacementList)
        {
            foreach (var tileCollisionRectangle in rectangleCollision)
            {
                tileCollisionRectangle.ForceUpdateDependenciesDeep();
            }

            foreach (var tileCollisionCircle in circleCollision)
            {
                tileCollisionCircle.ForceUpdateDependenciesDeep();
            }

            for (var i = network.Nodes.Count - 1; i >= 0; i--)
            {
                var node = network.Nodes[i];
                var nodeRemoved = false;

                if (rectangleCollision.Any(rect => rect.IsPointInsideCollision(node.X, node.Y)))
                {
                    network.Remove(node);
                    nodeRemoved = true;
                }
                if (!nodeRemoved)
                {
                    if (circleCollision.Any(circle => circle.Altitude == 0 && circle.IsPointInsideCollision(node.X, node.Y)))
                    {
                        network.Remove(node);
                        nodeRemoved = true;
                    }
                }
                if (!nodeRemoved)
                {
                    if (structurePlacementList.Any(placement => placement.Collision.IsPointInside(node.X, node.Y)))
                    {
                        network.Remove(node);
                        nodeRemoved = true;
                    }
                }
            }
        }
    }
}
