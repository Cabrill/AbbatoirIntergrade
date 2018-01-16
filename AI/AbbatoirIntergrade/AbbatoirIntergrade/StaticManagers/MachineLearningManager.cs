using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbbatoirIntergrade.Entities.BaseEntities;
using AbbatoirIntergrade.Entities.Enemies;
using AbbatoirIntergrade.GameClasses.BaseClasses;
using FlatRedBall.Math.Geometry;

namespace AbbatoirIntergrade.StaticManagers
{
    public static class MachineLearningManager
    {
        private static double _waveScore;

        private static Polygon _groundPathing;
        private static Polygon _airPathing;
        private static double _totalPathLength;
        private static double[] _segmentLengths;
        private static int _waveEnemyCount;


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
            if (sender is BaseLevel level) _waveEnemyCount = level.LastWave.Enemies.Sum(t => t.Item1);
        }

        public static void UpdateWaveScore(BaseEnemy enemy)
        {
            var enemyScore = CalculateScoreFor(enemy);

            _waveScore += (enemyScore / _waveEnemyCount);    
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
    }
}
