using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbbatoirIntergrade.Entities.BaseEntities;
using AbbatoirIntergrade.Factories;
using AbbatoirIntergrade.Performance;
using Accord.Genetic;
using FlatRedBall.Graphics;
using FlatRedBall.Math.Geometry;

namespace AbbatoirIntergrade.StaticManagers
{
    public static class EnemyFactories
    {
        private static Polygon _groundPathing;
        private static Polygon _airPathing;

        public static void SetGroundPathing(Polygon groundPath, Polygon airPath = null)
        {
            _groundPathing = groundPath;
            _airPathing = airPath ?? groundPath;
        }

        public static BaseEnemy CreateNew(EnemyTypes enemyType, ShortArrayChromosome chromosome = null)
        {
            BaseEnemy newEnemy = null;
            Polygon lineToFollow = _groundPathing;
            switch (enemyType)
            {
                case EnemyTypes.Chicken1: newEnemy = Chicken1EnemyFactory.CreateNew(); break;
                case EnemyTypes.Chicken2: newEnemy = Chicken2EnemyFactory.CreateNew(); break;
                case EnemyTypes.Chicken3: newEnemy = Chicken3EnemyFactory.CreateNew(); lineToFollow = _airPathing; break;

                case EnemyTypes.Rabbit1: newEnemy = Rabbit1EnemyFactory.CreateNew(); break;
                case EnemyTypes.Rabbit2: newEnemy = Rabbit2EnemyFactory.CreateNew(); break;
                case EnemyTypes.Rabbit3: newEnemy = Rabbit3EnemyFactory.CreateNew(); break;

                case EnemyTypes.Sheep1: newEnemy = Sheep1EnemyFactory.CreateNew(); break;
                case EnemyTypes.Sheep2: newEnemy = Sheep2EnemyFactory.CreateNew(); break;
                case EnemyTypes.Sheep3: newEnemy = Sheep3EnemyFactory.CreateNew(); break;

                case EnemyTypes.Cow1: newEnemy = Cow1EnemyFactory.CreateNew(); break;
                case EnemyTypes.Cow2: newEnemy = Cow2EnemyFactory.CreateNew(); break;
                case EnemyTypes.Cow3: newEnemy = Cow3EnemyFactory.CreateNew(); break;

                case EnemyTypes.Pig1: newEnemy = Pig1EnemyFactory.CreateNew(); break;
                case EnemyTypes.Pig2: newEnemy = Pig2EnemyFactory.CreateNew(); break;
                case EnemyTypes.Pig3: newEnemy = Pig3EnemyFactory.CreateNew(); break;
            }
            if (chromosome != null) newEnemy?.SetGenetics(chromosome);

            newEnemy?.FollowLine(lineToFollow);

            return newEnemy;
        }
    }
}
