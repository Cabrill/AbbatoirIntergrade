using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbbatoirIntergrade.Entities.BaseEntities;
using AbbatoirIntergrade.StaticManagers;
using AbbatoirIntergrade.UtilityClasses;


namespace AbbatoirIntergrade.GameClasses.BaseClasses
{
    public class BaseWave
    {
        public readonly EnemyList EnemyCounts;
        public List<EnemyTypes> EnemyTypes => EnemyCounts.EnemyTypesInList;

        public readonly List<BaseEnemy> CreatedEnemies;

        public BaseWave(List<SerializableTuple<int, EnemyTypes>> enemyCounts)
        {
            EnemyCounts = new EnemyList(enemyCounts);
            CreatedEnemies = new List<BaseEnemy>();
        }

        public BaseWave(EnemyList enemyList)
        {
            EnemyCounts = enemyList;
            CreatedEnemies = new List<BaseEnemy>();
        }

        public void CreateEnemies()
        {
            foreach (var pair in EnemyCounts.EnemyCountTuples)
            {
                for (var i = 0; i < pair.Item1; i++)
                {
                    CreatedEnemies.Add(EnemyFactories.CreateNew(pair.Item2));
                }
            }
        }

        private int _pointValue = 0;
        public int PointValue
        {
            get
            {
                if (_pointValue == 0)
                {
                    CalculatePointValue();
                }
                return _pointValue;
            }
        }

        private void CalculatePointValue()
        {
            var points = 0;

            foreach (var tuple in EnemyCounts.EnemyCountTuples)
            {
                points += tuple.Item1 * tuple.Item2.PointValue();
            }

            _pointValue = points;
        }
    }
}
