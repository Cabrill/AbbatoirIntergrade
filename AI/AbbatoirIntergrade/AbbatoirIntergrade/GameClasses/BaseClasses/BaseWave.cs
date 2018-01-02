using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbbatoirIntergrade.StaticManagers;

namespace AbbatoirIntergrade.GameClasses.BaseClasses
{
    public class BaseWave
    {
        public readonly List<Tuple<int, EnemyTypes>> Enemies;
        public readonly List<EnemyTypes> EnemyTypes;

        public BaseWave(List<Tuple<int, EnemyTypes>> enemies)
        {
            Enemies = enemies;
            EnemyTypes = Enemies.Select(t => t.Item2).Distinct().ToList();
        }

        public void CreateEnemies()
        {
            foreach (var pair in Enemies)
            {
                for (int i = 0; i < pair.Item1; i++)
                {
                    EnemyFactories.CreateNew(pair.Item2);
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

            foreach (var tuple in Enemies)
            {
                points += tuple.Item1 * tuple.Item2.PointValue();
            }

            _pointValue = points;
        }
    }
}
