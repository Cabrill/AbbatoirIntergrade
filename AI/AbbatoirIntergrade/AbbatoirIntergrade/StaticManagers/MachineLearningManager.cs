using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbbatoirIntergrade.Entities.BaseEntities;
using AbbatoirIntergrade.Entities.Enemies;
using AbbatoirIntergrade.GameClasses.BaseClasses;
using FlatRedBall;
using FlatRedBall.Math.Geometry;

namespace AbbatoirIntergrade.StaticManagers
{
    public static class MachineLearningManager
    {
        private static double _waveScore;

        private static FlatRedBall.Math.PositionedObjectList<BaseStructure> _allTowers;
        private static Polygon _groundPathing;
        private static Polygon _airPathing;
        private static double _totalPathLength;
        private static double[] _segmentLengths;
        private static int _waveEnemyCount;

        //Max paramters for towers
        private static double MaxDamage = 0;
        private static double MaxRange = 0;
        private static double MaxSecondsBetweenFiring = 0;
        private static double MaxProjectileSpeed = 0;

        //Max parameters for model input
        private const int MaxPathingPoints = 20;
        private const int MaxTowers = 10;
        private const int MaxEnemies = 30;

        public static void LoadModel()
        {
            
        }

        public static void SaveModel()
        {
            
        }


        public static void SetPathing(Polygon gp, Polygon ap = null)
        {
            _groundPathing = gp;
            _airPathing = ap;

            UpdatePathingValues();
        }

        public static void SetTowerList(FlatRedBall.Math.PositionedObjectList<BaseStructure> allTowers)
        {
            _allTowers = allTowers;
        }

        private static void UpdatePathingValues()
        {
            _totalPathLength = 0;
            _segmentLengths = new double[_groundPathing.Points.Count - 1];

            for (var i = 0; i < _groundPathing.Points.Count - 2; i++)
            {
                var point1 = _groundPathing.AbsolutePointPosition(i);
                var point2 = _groundPathing.AbsolutePointPosition(i + 1);
                var segmentValue = (point1 - point2).Length();
                _totalPathLength += segmentValue;

                _segmentLengths[i] = segmentValue;
            }
        }

        public static void NotifyOfWaveStart(object sender, EventArgs eventArgs)
        {
            if (sender is BaseLevel level)
            {
                var newWaveEnemies = level.LastWave.CreatedEnemies;
                _waveEnemyCount = newWaveEnemies.Count;
                CurrentWaveToInput(newWaveEnemies);
            }
        }

        public static void UpdateWaveScore(BaseEnemy enemy)
        {
            var enemyScore = CalculateScoreFor(enemy);

            _waveScore += (enemyScore / _waveEnemyCount);    
        }

        private static void CurrentWaveToInput(List<BaseEnemy> newWaveEnemies)
        {
            var inputList = new List<double>();

            for (var i = 0; i < MaxPathingPoints; i++)
            {
                if (i < _groundPathing.Points.Count - 1)
                {
                    var pathingPoint = _groundPathing.Points[i];
                    inputList.AddRange(PathingPointToInput(pathingPoint));
                }
                else
                {
                    inputList.Add(0.0);
                    inputList.Add(0.0);
                }
            }
            for (var i = 0; i < MaxTowers; i++)
            {
                var potentialTower = _allTowers.FirstOrDefault(t => t.PlacementOrder == i + 1);
                inputList.AddRange(TowerToInput(potentialTower));
            }
            for (var i = 0; i < MaxEnemies; i++)
            {
                BaseEnemy enemy = null;
                if (i < newWaveEnemies.Count - 1)
                {
                    enemy = newWaveEnemies[i];
                }
                inputList.AddRange(EnemyToInput(enemy));
            }
        }

        private static IEnumerable<double> PathingPointToInput(Point point)
        {
            var pathingPointList = new List<double> {point.X, point.Y};
            return pathingPointList;
        }

        private static IEnumerable<double> TowerToInput(BaseStructure tower)
        {
            if (tower != null)
            {
                var relativeTowerDamage = tower.AttackDamage / MaxDamage;

                return new List<double>
                {
                    AbsoluteXCoordinateToRelative(tower.X),
                    AbsoluteYCoordinateToRelative(tower.Y),
                    (tower.IsPiercing ? 0 : 1) * relativeTowerDamage,
                    (tower.IsBombarding ? 0 : 1) * relativeTowerDamage,
                    (tower.IsChemical ? 0 : 1) * relativeTowerDamage,
                    (tower.IsFrost ? 0 : 1) * relativeTowerDamage,
                    (tower.IsFire ? 0 : 1) * relativeTowerDamage,
                    (tower.IsElectrical ? 0 : 1) * relativeTowerDamage,
                    tower.RangedRadius / MaxRange,
                    tower.SecondsBetweenFiring / MaxSecondsBetweenFiring,
                    tower.ProjectileSpeed / MaxProjectileSpeed,
                    tower.HasSplashDamage ? 1.0 : 0.0,
                    tower.SlowsEnemies ? 1.0 : 0.0,
                    tower.StunsEnemies ? 1.0 : 0.0
                };
            }
            else
            {
                //Empty valued list
                return new List<double>
                {
                    0.0,
                    0.0,
                    0.0,
                    0.0,
                    0.0,
                    0.0,
                    0.0,
                    0.0,
                    0.0,
                    0.0,
                    0.0,
                    0.0,
                    0.0,
                    0.0,
                };
            }
        }

        private static IEnumerable<double> EnemyToInput(BaseEnemy enemy)
        {
            if (enemy != null)
            {
                return new List<double>
                {
                    enemy.MaximumHealth,
                    enemy.Speed,
                    enemy.EffectivePiercingResist,
                    enemy.EffectiveBombardResist,
                    enemy.EffectiveChemicalResist,
                    enemy.EffectiveFrostResist,
                    enemy.EffectiveFireResist,
                    enemy.EffectiveElectricResist,
                    enemy.IsFlying ? 1.0 : 0.0,
                };
            }
            else
            {
                return new List<double>
                {
                    0.0,
                    0.0,
                    0.0,
                    0.0,
                    0.0,
                    0.0,
                    0.0,
                    0.0,
                    0.0,
                };
            }
        }

        private static double CalculateScoreFor(BaseEnemy enemy)
        {
            if (enemy.HasReachedGoal) return 1.0;

            var score = 0.0;

            if (enemy.IsFlying)
            {
                var firstPoint = _airPathing.AbsolutePointPosition(0);
                var secondPoint = _airPathing.AbsolutePointPosition(1);

                var distanceBetweenPoints = (firstPoint - secondPoint).Length();

                var enemyDistanceToSecondPoint = (enemy.Position - secondPoint).Length();

                if (enemyDistanceToSecondPoint < distanceBetweenPoints)
                {
                    var pointProgress = distanceBetweenPoints - enemyDistanceToSecondPoint;

                    score += pointProgress / distanceBetweenPoints;
                }
            }
            else
            {
                var pathingPointIndex = enemy.PathingPointIndex;

                for (var i = 0; i < pathingPointIndex-1; i++)
                {
                    score += _segmentLengths[i] / _totalPathLength;
                }

                var firstPoint = _groundPathing.AbsolutePointPosition(pathingPointIndex - 1);
                var secondPoint = _groundPathing.AbsolutePointPosition(pathingPointIndex);

                var distanceBetweenPoints = (firstPoint - secondPoint).Length();

                var enemyDistanceToSecondPoint = (enemy.Position - secondPoint).Length();

                if (enemyDistanceToSecondPoint < distanceBetweenPoints)
                {
                    var pointProgress = distanceBetweenPoints - enemyDistanceToSecondPoint;

                    score += pointProgress / _totalPathLength;
                }
            }

            score *= 0.01f;

            return score;
        }

        public static void LearnMaxTowerValues(BaseStructure tower)
        {
            //These are multiplied by two to account for upgrades
            MaxDamage = Math.Max(MaxDamage, tower.AttackDamage*2);
            MaxRange = Math.Max(MaxRange, tower.RangedRadius*2);
            MaxProjectileSpeed = Math.Max(MaxProjectileSpeed, tower.ProjectileSpeed);

            MaxSecondsBetweenFiring = Math.Max(MaxSecondsBetweenFiring, tower.SecondsBetweenFiring);
            
        }

        private static double AbsoluteXCoordinateToRelative(float xcoord)
        {
            return (xcoord + Camera.Main.OrthogonalWidth / 2) / Camera.Main.OrthogonalWidth;
        }

        private static double AbsoluteYCoordinateToRelative(float ycoord)
        {
            return (ycoord + Camera.Main.OrthogonalHeight / 2) / Camera.Main.OrthogonalHeight;
        }
    }
}
