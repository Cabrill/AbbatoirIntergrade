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
            var costs = new float[32];
            costs[(int)NodeType.Normal] = 2;
            costs[(int)NodeType.Path] = 1;

            const int gridWidth = 64;
            
            var network = new TileNodeNetwork(0,//GridWidth / 2f,
                -map.Height,// + GridWidth / 2f,
                gridWidth,
                MathFunctions.RoundToInt(map.Width / gridWidth),
                MathFunctions.RoundToInt(map.Height / gridWidth),
                DirectionalType.Eight);

            AddNodes(map, "Ground", NodeType.Normal, ref network, gridWidth);
            AddNodes(map, "Ground", NodeType.Path, ref network, gridWidth);
            
            network.SetCosts(costs);
            

            return network;
        }

        private static void AddNodes(LayeredTileMap map, string layerName, NodeType tileProperty, ref TileNodeNetwork network, int gridWidth)
        {
            var layer = map.MapLayers.FirstOrDefault(l => l.Name.Equals(layerName));
            var tileNamesForPath = map.TileProperties
                .Where(item => item.Value
                    .Any(customProperty => customProperty.Value.Equals(tileProperty.ToString())))
                .Select(item => item.Key)
                .ToArray();

            foreach (var tileName in tileNamesForPath)
            {
                var indexes = layer != null && layer.NamedTileOrderedIndexes.ContainsKey(tileName)
                    ? layer.NamedTileOrderedIndexes[tileName]
                    : null;

                if (indexes == null) continue;

                for (var i = indexes.Count - 1; i > -1; i--)
                {
                    var gridIncrement = map.WidthPerTile / gridWidth;

                    layer.GetBottomLeftWorldCoordinateForOrderedTile(indexes[i], out float x, out float y);

                    for (var j = 0; j < gridIncrement; j++)
                    {
                        for (var k = 0; k < gridIncrement; k++)
                        {
                            var node = network.AddAndLinkTiledNodeWorld(x + (gridWidth * j), y + (gridWidth * k));
                            node.PropertyField = (1 << (int) (tileProperty));
                        }
                    }
                }
            }
        }

        public static void RemoveNodesWithCollisions(ref TileNodeNetwork network, 
            PositionedObjectList<TileCollisionRectangle> rectangleCollision, 
            PositionedObjectList<TileCollisionCircle> circleCollision)
        {
            foreach (var tileCollisionRectangle in rectangleCollision)
            {
                tileCollisionRectangle.ForceUpdateDependenciesDeep();
            }

            foreach (var tileCollisionCircle in circleCollision)
            {
                tileCollisionCircle.ForceUpdateDependenciesDeep();
            }

            var nodeCircle = new Circle {Radius = 20f};

            for (var i = network.Nodes.Count - 1; i >= 0; i--)
            {
                var node = network.Nodes[i];
                var nodeRemoved = false;
                nodeCircle.Position = node.Position;

                if (rectangleCollision.Any(rect => rect.CollideAgainst(nodeCircle)))
                {
                    network.Remove(node);
                    nodeRemoved = true;
                }
                if (!nodeRemoved)
                {
                    if (circleCollision.Any(circle => circle.Altitude == 0 && circle.CollideAgainst(nodeCircle)))
                    {
                        network.Remove(node);
                        nodeRemoved = true;
                    }
                }
            }
        }

        public static void RemoveNodesForCollision(this NodeNetwork network, AxisAlignedRectangle collision)
        {
            var nodeCircle = new Circle { Radius = 20f };

            for (var i = network.Nodes.Count - 1; i >= 0; i--)
            {
                var node = network.Nodes[i];
                nodeCircle.Position = node.Position;

                if (collision.CollideAgainst(nodeCircle))
                {
                    network.Remove(node);
                }
            }
            network.UpdateShapes();
        }
    }
}
