using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlatRedBall.Graphics;
using AbbatoirIntergrade.Entities.BaseEntities;
using AbbatoirIntergrade.GameClasses.BaseClasses;
using AbbatoirIntergrade.GameClasses.Interfaces;
using AbbatoirIntergrade.GumRuntimes;

namespace AbbatoirIntergrade.GameClasses.Levels
{
    class HelsinkiLevel : BaseLevel
    {
        public override DateTime StartTime => new DateTime(2017, 10, 21, 23, 0, 0);
        public override DateTime EndTime => new DateTime(2017, 10, 24, 23, 0, 0);
        public override float AvgDailyEnergyUsage => 3.45f;

        public HelsinkiLevel(FlatRedBall.Math.PositionedObjectList<BaseEnemy> enemyList, Layer layerForEnemies) : base(enemyList, layerForEnemies)
        {
            
        }

    }
}
