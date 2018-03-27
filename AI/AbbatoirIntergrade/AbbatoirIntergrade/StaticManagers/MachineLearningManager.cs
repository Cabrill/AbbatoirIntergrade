using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AbbatoirIntergrade.Entities.BaseEntities;
using AbbatoirIntergrade.Entities.Enemies;
using AbbatoirIntergrade.GameClasses;
using AbbatoirIntergrade.GameClasses.BaseClasses;
using AbbatoirIntergrade.MachineLearning;
using AbbatoirIntergrade.MachineLearning.Models;
using AbbatoirIntergrade.UtilityClasses;
using Accord.Genetic;
using Accord.IO;
using Accord.Math;
using FlatRedBall;
using FlatRedBall.Instructions;
using FlatRedBall.IO;
using FlatRedBall.Math.Geometry;
using Microsoft.Xna.Framework;
using Point = FlatRedBall.Math.Geometry.Point;

namespace AbbatoirIntergrade.StaticManagers
{
    public static class MachineLearningManager
    {
        public static bool IsReadyToEvaluate => _machineLearningModel.IsReady;
        public static double CurrentMeanSquaredError => _machineLearningModel.LastMSE;
        public static int SampleSize => _machineLearningModel.LastSampleSize;
        
        private static double _waveScore = 0;
        private static WaveData _waveData;
        private static double[] _currentWaveInput;

        private static IModel _machineLearningModel;
        private static bool IsLearningTaskRunning = false;

        private static FlatRedBall.Math.PositionedObjectList<BaseStructure> _allTowers;
        private static Polygon _groundPathing;
        private static double _totalPathLength;
        private static double[] _segmentLengths;
        private static int _waveEnemyCount;

        //Max paramters for towers
        private static double _maxDamage = 0;
        private static double _maxRange = 0;
        private static double _maxMinRange = 0;
        private static double _maxSecondsBetweenFiring = 0;
        private static double _maxProjectileSpeed = 0;
        

        //Max parameters for model input
        private const int MaxPathingPoints = 20;
        private const int MaxTowers = 10;
        private const int MaxEnemies = 30;

        private static string _modelFileName;
        private static string _waveDataFileName;

        public static void LoadData(string modelFileName, string waveDataFileName)
        {
            LocalLogManager.AddLine("Machine Learning manager initialization");

            _modelFileName = modelFileName;
            _waveDataFileName = waveDataFileName;

            _machineLearningModel = new DeepBeliefNetworkModel();
            var canLoadExistingModel =  _machineLearningModel.Load(_modelFileName);

            if (!canLoadExistingModel)
            {
                _machineLearningModel.Initialize();
            }

            var waveDataExists = FileManager.FileExists(_waveDataFileName);
            if (waveDataExists) _waveData = FileManager.BinaryDeserialize(typeof(WaveData), _waveDataFileName) as WaveData;
            _waveData = _waveData ?? new WaveData
            {
                WaveInputs = new List<double[]>(),
                WaveScores = new List<double>()
            };
        }

        public static void SaveData()
        {
            FileManager.BinarySerialize(_waveData, _waveDataFileName);
            _machineLearningModel.Save(_modelFileName);
        }

        public static BaseWave GenerateWave(List<EnemyTypes> availableEnemyTypes, double pointsAvailable)
        {
            var inputList = new List<double>();

            CurrentPathingToInput(ref inputList);
            CurrentTowersToInput(ref inputList);

            //RecursionCount = 0;
            //RecordedFitness = new Dictionary<EnemyList, double>();
            //var startingCounts = new EnemyList();
            //var enemyList = RecursivelyFindBestEnemyCombination(availableEnemyTypes, inputList, startingCounts, pointsAvailable);
            var enemyList = GreedilyFindBestEnemyCombination(availableEnemyTypes, inputList, pointsAvailable);

            return new BaseWave(enemyList);
        }

        private static EnemyList GreedilyFindBestEnemyCombination(List<EnemyTypes> availableEnemyTypes,
            List<double> partialInput, double pointsAvailable)
        {
            var enemyList = new EnemyList();
            var minPointValue = availableEnemyTypes.Min(e => e.PointValue());

            while (pointsAvailable >= minPointValue && enemyList.TotalEnemies < MaxEnemies)
            {
                var bestFitnessImprovement = 0.0;
                var bestEnemyType = availableEnemyTypes[0];
                var currentFitness = enemyList.TotalEnemies == 0 ? 0 : ScoreEnemyList(enemyList, partialInput);

                foreach (var enemyType in availableEnemyTypes)
                {
                    var enemyPointValue = enemyType.PointValue();
                    if (enemyPointValue > pointsAvailable) continue;

                    var tempEnemyList = enemyList.DeepClone();
                    tempEnemyList.Add(enemyType);

                    var fitnessOfList = ScoreEnemyList(tempEnemyList, partialInput);

                    var enemyFitnessImprovement = fitnessOfList - currentFitness;
                    enemyFitnessImprovement /= enemyPointValue;

                    if (enemyFitnessImprovement < bestFitnessImprovement) continue;

                    bestEnemyType = enemyType;
                    bestFitnessImprovement = enemyFitnessImprovement;
                }

                pointsAvailable -= bestEnemyType.PointValue();
                enemyList.Add(bestEnemyType);
            }
            return enemyList;
        }

        private static double ScoreEnemyList(EnemyList enemyList, List<double> partialInput)
        {
            var completedInput = partialInput.DeepClone();
            for (var j = 0; j < MaxEnemies; j++)
            {
                if (j < enemyList.EnemyCountTuples.Count)
                {
                    var currentEnemyType = enemyList.EnemyCountTuples[j].Item2;
                    var chromosome = GeneticsManager.GetChromosomesForEnemyType(currentEnemyType).FirstOrDefault();
                    var enemyAttributes = currentEnemyType.Attributes();
                    var effectiveAttributes = BaseEnemy.GetGeneticAttributes(enemyAttributes, chromosome);

                    completedInput.AddRange(EnemyAttributesToInput(effectiveAttributes));
                }
                else
                {
                    completedInput.AddRange(EnemyToInput(null));
                }
            }

            return _machineLearningModel.Predict(completedInput.ToArray());
        }

        private static Dictionary<EnemyList, double> RecordedFitness;
        private static int RecursionCount;
        private static EnemyList RecursivelyFindBestEnemyCombination(List<EnemyTypes> availableEnemyTypes, List<double> partialInput, EnemyList existingList, double pointsRemaining)
        {
            if (pointsRemaining == 0 || existingList.TotalEnemies >= MaxEnemies) return existingList;

            var bestFitness = 0.0;
            EnemyList bestList = null;

            foreach (var enemyType in availableEnemyTypes)
            {
                var currentPoints = pointsRemaining;
                var currentList = existingList.DeepClone();
                var enemyPointValue = enemyType.PointValue();

                if (enemyPointValue > currentPoints) continue;

                currentPoints -= enemyPointValue;
                currentList.Add(enemyType);

                if (currentPoints > 0 && currentList.TotalEnemies < MaxEnemies)
                {
                    currentList =  RecursivelyFindBestEnemyCombination(availableEnemyTypes, partialInput, currentList, currentPoints);
                    RecursionCount++;
                }

                double fitnessOfList;

                if (RecordedFitness.ContainsKey(currentList))
                {
                    fitnessOfList = RecordedFitness[currentList];
                }
                else
                {
                    fitnessOfList = ScoreEnemyList(currentList, partialInput);
                    RecordedFitness.Add(currentList, fitnessOfList);
                }

                if (fitnessOfList < bestFitness) continue;

                bestFitness = fitnessOfList;
                bestList = currentList;
            }

            return bestList;
        }


        public static void SetPathing(Polygon gp)
        {
            _groundPathing = gp;

            UpdatePathingValues();
        }

        public static void SetTowerList(FlatRedBall.Math.PositionedObjectList<BaseStructure> allTowers)
        {
            _allTowers = allTowers;
        }

        public static void NotifyOfWaveStart(object sender, EventArgs eventArgs)
        {
            if (sender is BaseLevel level)
            {
                var newWaveEnemies = level.LastWave.CreatedEnemies;
                _waveEnemyCount = newWaveEnemies.Count;
                _currentWaveInput = CurrentWaveToInput(newWaveEnemies);
            }
        }

        public static void NotifyOfWaveEnd()
        {
            _waveData.WaveInputs.Add(_currentWaveInput);
            _waveData.WaveScores.Add(_waveScore);

            _waveScore = 0;
            if (!IsLearningTaskRunning)
            {
                _machineLearningModel.LearnAll(_waveData);
            }
            GeneticsManager.EvaluateAndGenerate();
            SaveData();
        }

        public static void UpdateWaveScore(BaseEnemy enemy)
        {
            var enemyScore = CalculateScoreFor(enemy);

            _waveScore += (enemyScore / _waveEnemyCount);    
        }

        public static void LearnMaxTowerValues(BaseStructure tower)
        {
            //These are multiplied by two to account for upgrades
            _maxDamage = Math.Max(_maxDamage, tower.AttackDamage * 2);
            _maxRange = Math.Max(_maxRange, tower.RangedRadius * 2);
            _maxMinRange = Math.Max(_maxMinRange, tower.MinimumRangeRadius * 2);
            _maxProjectileSpeed = Math.Max(_maxProjectileSpeed, tower.ProjectileSpeed);

            _maxSecondsBetweenFiring = Math.Max(_maxSecondsBetweenFiring, tower.SecondsBetweenFiring);
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

        private static double[] CurrentWaveToInput(List<BaseEnemy> newWaveEnemies)
        {
            var inputList = new List<double>();

            CurrentPathingToInput(ref inputList);
            CurrentTowersToInput(ref inputList);
            CurrentEnemiesToInput(ref inputList, newWaveEnemies);
            
            return inputList.ToArray();
        }

        private static void CurrentPathingToInput(ref List<double> inputList)
        {
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
        }

        private static void CurrentTowersToInput(ref List<double> inputList)
        {
            for (var i = 0; i < MaxTowers; i++)
            {
                var potentialTower = _allTowers.FirstOrDefault(t => t.PlacementOrder == i + 1);
                inputList.AddRange(TowerToInput(potentialTower));
            }
        }

        private static void CurrentEnemiesToInput(ref List<double> inputList, List<BaseEnemy> enemies)
        {
            for (var i = 0; i < MaxEnemies; i++)
            {
                BaseEnemy enemy = null;
                if (i < enemies.Count - 1)
                {
                    enemy = enemies[i];
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
                var relativeTowerDamage = tower.AttackDamage / _maxDamage;

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
                    tower.RangedRadius / _maxRange,
                    tower.MinimumRangeRadius / _maxMinRange,
                    tower.SecondsBetweenFiring / _maxSecondsBetweenFiring,
                    tower.ProjectileSpeed / _maxProjectileSpeed,
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
                    enemy.EffectiveSpeed,
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

        private static IEnumerable<double> EnemyAttributesToInput(BaseEnemy.GeneticAttributes attributes)
        {
            return new List<double>
            {
                attributes.MaximumHealth,
                attributes.EffectiveSpeed,
                attributes.EffectivePiercingResist,
                attributes.EffectiveBombardResist,
                attributes.EffectiveChemicalResist,
                attributes.EffectiveFrostResist,
                attributes.EffectiveFireResist,
                attributes.EffectiveElectricResist,
                attributes.IsFlying ? 1.0 : 0.0,
            };
        }

        private static double CalculateScoreFor(BaseEnemy enemy)
        {
            if (enemy.HasReachedGoal) return 1.0;

            var score = 0.0;

            if (enemy.IsFlying)
            {
                var firstPoint = _groundPathing.AbsolutePointPosition(0);
                var secondPoint = _groundPathing.AbsolutePointPosition(_groundPathing.Points.Count-1);

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

        private static double AbsoluteXCoordinateToRelative(float xcoord)
        {
            return MathHelper.Clamp((xcoord + Camera.Main.OrthogonalWidth / 2) / Camera.Main.OrthogonalWidth, 0, 1);
        }

        private static double AbsoluteYCoordinateToRelative(float ycoord)
        {
            return MathHelper.Clamp((ycoord + Camera.Main.OrthogonalHeight / 2) / Camera.Main.OrthogonalHeight,0,1);
        }

        public static List<double> GetPathingAndTowersPartialInput()
        {
            var inputList = new List<double>();

            CurrentPathingToInput(ref inputList);
            CurrentTowersToInput(ref inputList);

            return inputList;
        }

        public static double Evaluate(List<double> inputList, EnemyTypes enemyType, SerializableChromosome chromosome)
        {
            var enemyAttributes = enemyType.Attributes();
            var effectiveAttributes = BaseEnemy.GetGeneticAttributes(enemyAttributes, chromosome);

            var attributesAsInput = Enumerable.ToArray(EnemyAttributesToInput(effectiveAttributes));

            for (var i = 0; i < MaxEnemies; i++)
            {
                inputList.AddRange(attributesAsInput);
            }

            var score = _machineLearningModel.Predict(inputList.ToArray());

            return score;
        }
    }
}
