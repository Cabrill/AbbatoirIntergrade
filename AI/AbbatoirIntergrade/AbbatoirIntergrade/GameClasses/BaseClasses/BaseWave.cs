using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbbatoirIntergrade.Entities.BaseEntities;
using AbbatoirIntergrade.StaticManagers;

namespace AbbatoirIntergrade.GameClasses.BaseClasses
{
    public class BaseWave
    {
        public readonly List<Tuple<int, EnemyTypes>> EnemyCounts;
        public readonly List<EnemyTypes> EnemyTypes;

        public List<BaseEnemy> CreatedEnemies;

        public BaseWave(List<Tuple<int, EnemyTypes>> enemyCounts)
        {
            EnemyCounts = enemyCounts;
            EnemyTypes = EnemyCounts.Select(t => t.Item2).Distinct().ToList();
            CreatedEnemies = new List<BaseEnemy>();
        }

        public void CreateEnemies()
        {
            foreach (var pair in EnemyCounts)
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

            foreach (var tuple in EnemyCounts)
            {
                points += tuple.Item1 * tuple.Item2.PointValue();
            }

            _pointValue = points;
        }
    }
}
