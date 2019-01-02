using System;
using System.Collections.Generic;
using System.IO;
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
using MoreLinq;
using Point = FlatRedBall.Math.Geometry.Point;
using Vector3 = Microsoft.Xna.Framework.Vector3;

namespace AbbatoirIntergrade.StaticManagers
{
    public static class MachineLearningManager
    {
        public static bool IsReadyToEvaluate => _machineLearningModel.IsReady;
        public static double CurrentMeanSquaredError => _machineLearningModel.LastMSE;
        public static double AverageValueMSE => _machineLearningModel.AVMMSE;
        public static int SampleSize => _machineLearningModel.LastSampleSize;
        public static double CurrentPrediction => _machineLearningModel.LastPrediction;
        public static bool CurrentlyLearning => _machineLearningModel.IsCurrentlyLearning;
        public static long CurrentLearnTime => _machineLearningModel.LearningStopwatch.ElapsedMilliseconds;
        public static long LastLearnTime => _machineLearningModel.LastLearnTime;
        public static double CurrentScore => _waveScore;
        public static double LastWaveScore;
       
        private static double _waveScore = 0;
        private static WaveData _waveData;
        private static List<double> _levelPartialInput;
        private static List<double> _fitnessRankingPartialInput;
        private static double[] _currentWaveInput;

        private static DeepBeliefNetworkModel _machineLearningModel;

        private static FlatRedBall.Math.PositionedObjectList<BaseStructure> _allTowers;
        private static Polygon _groundPathing;
        private static List<Polygon> _waterShapes;
        private static int _waveEnemyCount;

        //Max paramters for towers
        private static double _maxDamage = 0;
        private static double _maxRange = 0;
        private static double _maxMinRange = 0;
        private static double _maxSecondsBetweenFiring = 0;
        private static double _maxProjectileSpeed = 0;
        

        //Max parameters for model input
        private const int MaxPathingPoints = 1;
        private const int MaxWaterPoints = 1;
        public const int MaxTowers = 15;
        public const int MaxEnemies = 30;

        //Calculation of data points per object
        private const int CountPerPathing = 1;
        private const int CountPerWater = 1;
        private const int CountPerEnemy = 9;
        private const int CountPerTower = 11;

        private static int InputCount;

        private static string _modelFileName;
        private static string _waveDataFileName;
        private static object FileLocker= new object();

        public static void LoadData(string modelFileName, string waveDataFileName)
        {
            LocalLogManager.AddLine("Machine Learning manager initialization");

            _modelFileName = modelFileName;
            _waveDataFileName = waveDataFileName;
            InputCount = (MaxPathingPoints * CountPerPathing) + 
                            (MaxWaterPoints * CountPerWater) +
                            (MaxTowers * CountPerTower) + 
                            (MaxEnemies * CountPerEnemy);

            _machineLearningModel = new DeepBeliefNetworkModel();
            lock (FileLocker)
            {
                var canLoadExistingModel = _machineLearningModel.Load(_modelFileName);
            
                if (!canLoadExistingModel)
                {
                    _machineLearningModel.Initialize(InputCount, (int)(InputCount * 0.8));
                }
            }

            var waveDataExists = FileManager.FileExists(_waveDataFileName);
            if (waveDataExists) _waveData = FileManager.BinaryDeserialize(typeof(WaveData), _waveDataFileName) as WaveData;
            _waveData = _waveData ?? new WaveData
            {
                WaveInputs = new List<double[]>(),
                WaveScores = new List<double>(),
            };
        }

        private static void SaveData()
        {
            lock (FileLocker)
            {
                FileManager.BinarySerialize(_waveData, _waveDataFileName);
                _machineLearningModel.Save(_modelFileName);
            }
        }

        public static BaseWave GenerateWave(List<EnemyTypes> availableEnemyTypes, double pointsAvailable)
        {
            var inputList = GetCurrentPartialInputList();

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
                var bestEnemyType = availableEnemyTypes.MinBy(e => e.PointValue());
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


        public static void SetPathingAndWater(Polygon groundPathing, List<Polygon> waterShapes)
        {
            _groundPathing = groundPathing;
            _waterShapes = waterShapes;
            CreatePartialInput();
        }

        private static void CreatePartialInput()
        {
            _levelPartialInput = new List<double>();
            CurrentPathingToInput(ref _levelPartialInput);
            CurrentWaterToInput(ref _levelPartialInput);
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
                _waveScore = 0;
                _waveEnemyCount = newWaveEnemies.Count;
                _currentWaveInput = CurrentWaveToInput(newWaveEnemies);
                _machineLearningModel.Predict(_currentWaveInput);
            }
        }

        public static void NotifyOfWaveEnd(bool shouldLearnFromWave)
        {
            LastWaveScore = _waveScore;
            var willLearnFromWave = shouldLearnFromWave && _waveScore > 0 && _waveScore <= 1;

            if (willLearnFromWave)
            {
                _waveData.WaveInputs.Add(_currentWaveInput);
                _waveData.WaveScores.Add(_waveScore);

                var waveDataResults = new
                {
                    RawWaveData = _waveScore + "," + string.Join(",", _currentWaveInput),
                };

                AnalyticsManager.SendEventImmediately("WaveData", waveDataResults);
            }
#if DEBUG
            else
            {
                var doh = 1;
            }
#endif
            _waveScore = 0;
            

            if (_machineLearningModel.IsCurrentlyLearning || !willLearnFromWave) return;

            void LearnTask()
            {
                _machineLearningModel.LearnAll(_waveData);
                SaveData();
            }

            var lowestPriorityThread = new Thread(LearnTask)
            {
                Priority = ThreadPriority.Lowest
            };
            lowestPriorityThread.Start();


            var lowPriorityThread = new Thread(GeneticsManager.EvaluateAndGenerate)
            {
                Priority = ThreadPriority.BelowNormal
            };
            lowPriorityThread.Start();

        }

        public static void UpdateWaveScore(BaseEnemy enemy)
        {
            var enemyScore = CalculateScoreFor(enemy);

            _waveScore += (enemyScore / _waveEnemyCount);

            if (_waveEnemyCount == 0 || enemyScore > 1|| double.IsInfinity(_waveScore) || double.IsNaN(_waveScore))
            {
                var doh = 1;
            }

            if (_waveScore > 1 && _waveScore - 1 < 0.05)
            {
                _waveScore = 1;
            }
            else if (_waveScore > 1)
            {
                var doh = 1;
            }
        }

        public static void LearnMaxTowerValues(BaseStructure tower)
        {
            //These are factored to account for tower upgrades
            _maxDamage = Math.Max(_maxDamage, tower.AttackDamage * 1.5);
            _maxRange = Math.Max(_maxRange, tower.RangedRadius * 1.5);
            _maxProjectileSpeed = Math.Max(_maxProjectileSpeed, tower.ProjectileSpeed * 1.5);

            //These are left unaltered because the values can only go down
            _maxMinRange = Math.Max(_maxMinRange, tower.MinimumRangeRadius);
            _maxSecondsBetweenFiring = Math.Max(_maxSecondsBetweenFiring, tower.SecondsBetweenFiring);
        }

        private static double[] CurrentWaveToInput(List<BaseEnemy> newWaveEnemies)
        {
            var inputList = _levelPartialInput.ToList();

            CurrentTowersToInput(ref inputList);
            CurrentEnemiesToInput(ref inputList, newWaveEnemies);
            
            return inputList.ToArray();
        }

        private static void CurrentPathingToInput(ref List<double> inputList)
        {
            inputList.AddRange(new[] {_groundPathing.Points.Count/10.0});

            //for (var i = 0; i < MaxPathingPoints; i++)
            //{
            //    if (i < _groundPathing.Points.Count - 1)
            //    {
            //        var pathingPoint = _groundPathing.Points[i];
            //        inputList.AddRange(LocationVectorToInput(pathingPoint));
            //    }
            //    else
            //    {
            //        inputList.Add(0.0);
            //        inputList.Add(0.0);
            //    }
            //}
        }

        private static void CurrentWaterToInput(ref List<double> inputList)
        {
            inputList.AddRange(new[] { _waterShapes?.Count / 3.0 ?? 0 });

            //var waterPointCount = 0;

            //if (_waterShapes != null)
            //{
            //    waterPointCount += _waterShapes.Sum(shape => shape.Points.Count);
            //}

            //var currentWaterShapeIndex = 0;
            //var currentShapePointIndex = 0;
            //for (var i = 0; i < MaxWaterPoints; i++)
            //{
            //    if (i < waterPointCount - 1)
            //    {
            //        if (currentShapePointIndex >= _waterShapes[currentWaterShapeIndex].Points.Count)
            //        {
            //            currentWaterShapeIndex += 1;
            //            currentShapePointIndex = 0;
            //        }

            //        var waterPoint = _waterShapes[currentWaterShapeIndex].Points[currentShapePointIndex++];
            //        inputList.AddRange(LocationVectorToInput(waterPoint));
            //    }
            //    else
            //    {
            //        inputList.Add(0.0);
            //        inputList.Add(0.0);
            //    }
            //}
        }

        private static void CurrentTowersToInput(ref List<double> inputList)
        {
            for (var i = 0; i < MaxTowers; i++)
            {
                BaseStructure tower = null;
                if (i < _allTowers.Count - 1)
                {
                    tower = _allTowers[i];
                }
                inputList.AddRange(TowerToInput(tower));
            }
        }

        private static void CurrentTowersToInput(ref List<double> inputList, List<BaseStructure> towerList)
        {
            for (var i = 0; i < MaxTowers; i++)
            {
                BaseStructure tower = null;
                if (i < towerList.Count - 1)
                {
                    tower = towerList[i];
                }
                inputList.AddRange(TowerToInput(tower));
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

        private static IEnumerable<double> LocationVectorToInput(Point point)
        {
            var pathingPointList = new List<double> { AbsoluteXCoordinateToRelative((float)point.X), AbsoluteXCoordinateToRelative((float)point.Y)};
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
                    //AbsoluteYCoordinateToRelative(tower.Y),
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
                    //tower.HasSplashDamage ? 1.0 : 0.0,
                    //tower.SlowsEnemies ? 1.0 : 0.0,
                    //tower.StunsEnemies ? 1.0 : 0.0
                };
            }
            else
            {
                //Empty valued list
                return new List<double>
                {
                    //0.0,
                    //0.0,
                    //0.0,
                    //0.0,
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
                    enemy.MaximumHealth / 1000,
                    enemy.EffectiveSpeed / 1000,
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
                attributes.MaximumHealth / 1000,
                attributes.EffectiveSpeed / 1000,
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
            return enemy.GetProgress();
        }

        private static double AbsoluteXCoordinateToRelative(float xcoord)
        {
            return MathHelper.Clamp((xcoord + Camera.Main.OrthogonalWidth / 2) / Camera.Main.OrthogonalWidth, 0, 1);
        }

        private static double AbsoluteYCoordinateToRelative(float ycoord)
        {
            return MathHelper.Clamp((ycoord + Camera.Main.OrthogonalHeight / 2) / Camera.Main.OrthogonalHeight,0,1);
        }

        public static List<double> GetCurrentPartialInputList()
        {
            var partialInput = _levelPartialInput.ToList();
            CurrentTowersToInput(ref partialInput);

            return partialInput;
        }

        public static List<double> GetFitnessRankingInput()
        {
            return _fitnessRankingPartialInput;
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

        private static StringBuilder CSV;

        public static void Test()
        {
            //IncrementalTest();
            //LoadTestData();
            //SearchTest();
            TestGenetics();
        }

        private static void TestGenetics()
        {
            GameStateManager.LoadIfNecessary();
            var slr = 0.8;
            var sm = 0.8;
            var uslr = 0.9;
            var usm = 0.2;
            var usd = 0.21;

            InputCount = (MaxPathingPoints * CountPerPathing) +
                         (MaxWaterPoints * CountPerWater) +
                         (MaxTowers * CountPerTower) +
                         (MaxEnemies * CountPerEnemy);

            var listOfAllTowerTypes = GameStateManager.GetAllTowers();
            var towerList = new List<BaseStructure>();
            foreach (var towerType in listOfAllTowerTypes)
            {
                var towerInstantiation = StructureFactories.GetNewObject(towerType) as BaseStructure;
                LearnMaxTowerValues(towerInstantiation);
                towerList.Add(towerInstantiation);
            }
            CreateFitnessRankingInput(towerList);
            for (var i = towerList.Count - 1; i >= 0; i--)
            {
                towerList[i].Destroy();
            }

            var outputList = new List<double>();
            var inputList = new List<double[]>();

            using (var reader = new StreamReader(@"wavedata.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split('\t');

                    var output = double.Parse(values[0]);
                    outputList.Add(output);

                    var inputCount = values.Length - 1;

                    var inputArray = new double[inputCount];

                    for (var i = 1; i < inputCount; i++)
                    {
                        inputArray[i - 1] = double.Parse(values[i]);
                    }
                    inputList.Add(inputArray);
                }
            }

            var fileName = $"BootstrappedGeneticData.csv";
            CSV = new StringBuilder();

            

            //_machineLearningModel = new DeepBeliefNetworkModel();
            _machineLearningModel.Initialize(InputCount, (int)(InputCount * 0.8), uslr, usm, usd, slr, sm);
            GameStateManager.LoadIfNecessary();

            CSV.Clear();
            //CSV.Append($"SampleSize, AvgFitness, Chicken1, Chicken2, Chicken3, Cow1, Cow2, Cow3, Sheep1, Sheep2, Sheep3, Rabbit1, Rabbit2, Rabbit3, Pig1, Pig2, Pig3");
            //CSV.Append(Environment.NewLine);
            //File.WriteAllText(fileName, CSV.ToString());

            var partialOutput = new List<double>();
            var partialInput = new List<double[]>();

            //_waveData = new WaveData
            //{
            //    WaveInputs = partialInput,
            //    WaveScores = partialOutput,
            //};

            var sampleSize = int.MaxValue;

            for (var i = 0; i <= sampleSize; i++)
            {
                CSV.Clear();
                var randomIndex = FlatRedBallServices.Random.Next(0, outputList.Count - 1);
                _waveData.WaveInputs.Add(inputList[randomIndex]);
                _waveData.WaveScores.Add(outputList[randomIndex]);

                _machineLearningModel.LearnAll(_waveData);
                GeneticsManager.EvaluateAndGenerate();
                var currentFitness = GeneticsManager.GetAverageFitness();
                CSV.Append($"{i + 1},{currentFitness}, " +
                    $"{GeneticsManager.GetBestChromsomeForEnemyType(EnemyTypes.Chicken1).Fitness}, { GeneticsManager.GetBestChromsomeForEnemyType(EnemyTypes.Chicken2).Fitness}, { GeneticsManager.GetBestChromsomeForEnemyType(EnemyTypes.Chicken3).Fitness}, "+
                    $"{GeneticsManager.GetBestChromsomeForEnemyType(EnemyTypes.Cow1).Fitness}, { GeneticsManager.GetBestChromsomeForEnemyType(EnemyTypes.Cow2).Fitness}, { GeneticsManager.GetBestChromsomeForEnemyType(EnemyTypes.Cow3).Fitness}, " +
                    $"{GeneticsManager.GetBestChromsomeForEnemyType(EnemyTypes.Sheep1).Fitness}, {GeneticsManager.GetBestChromsomeForEnemyType(EnemyTypes.Sheep2).Fitness}, {GeneticsManager.GetBestChromsomeForEnemyType(EnemyTypes.Sheep3).Fitness}, " +
                    $"{GeneticsManager.GetBestChromsomeForEnemyType(EnemyTypes.Rabbit1).Fitness}, {GeneticsManager.GetBestChromsomeForEnemyType(EnemyTypes.Rabbit2).Fitness}, {GeneticsManager.GetBestChromsomeForEnemyType(EnemyTypes.Rabbit3).Fitness}, " +
                    $"{GeneticsManager.GetBestChromsomeForEnemyType(EnemyTypes.Pig1).Fitness}, {GeneticsManager.GetBestChromsomeForEnemyType(EnemyTypes.Pig2).Fitness}, {GeneticsManager.GetBestChromsomeForEnemyType(EnemyTypes.Pig3).Fitness}"
                    );
                CSV.Append(Environment.NewLine);
                File.AppendAllText(fileName, CSV.ToString());
                SaveData();
                //GeneticsManager.Save("Genetics.xml");
            }   
        }

        private static void CreateFitnessRankingInput(List<BaseStructure> towerList)
        {
            var inputList = new List<double>();
            inputList.AddRange(new[] { 5 / 10.0 });//Pathing
            inputList.AddRange(new[] { 0.0 });//Water shapes
            CurrentTowersToInput(ref inputList, towerList);

            _fitnessRankingPartialInput = inputList;
        }

        private static void SearchTest()
        {
            var fileName = "CollectedData.csv";
            InputCount = (MaxPathingPoints * CountPerPathing) +
                            (MaxWaterPoints * CountPerWater) +
                            (MaxTowers * CountPerTower) +
                            (MaxEnemies * CountPerEnemy);

            var slrList = new List<double>();
            var smList = new List<double>();
            var uslrList = new List<double>();
            var usmList = new List<double>();
            var usdList = new List<double>();

            CSV = new StringBuilder();
            File.WriteAllText(fileName, CSV.ToString());

            for (var slr = 0.0; slr <= 1; slr += 0.1)
            {
                slrList.Add(slr);
            }
            for (var sm = 0.0; sm <= 1; sm += 0.1)
            {
                smList.Add(sm);
            }
            for (var uslr = 0.0; uslr <= 1; uslr += 0.1)
            {
                uslrList.Add(uslr);
            }
            for (var usm = 0.0; usm <= 1; usm += 0.1)
            {
                usmList.Add(usm);
            }
            for (var usd = 0.01; usd <= 0.3; usd += 0.025)
            {
                usdList.Add(usd);
            }

            var triedCombos = new List<string>();
            var outputList = new List<double>();
            var inputList = new List<double[]>();
            _waveData = new WaveData
            {
                WaveInputs = inputList,
                WaveScores = outputList,
            };

            using (var reader = new StreamReader(@"wavedata.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split('\t');

                    var output = double.Parse(values[0]);
                    outputList.Add(output);

                    var inputCount = values.Length - 1;

                    var inputArray = new double[inputCount];

                    for (var i = 1; i < inputCount; i++)
                    {
                        inputArray[i - 1] = double.Parse(values[i]);
                    }
                    inputList.Add(inputArray);
                }
            }

            DeepBeliefNetworkModel baseModel = new DeepBeliefNetworkModel();
            baseModel.Initialize(InputCount, (int) (InputCount * 0.8), 0,0,0,0,0);
            baseModel.Save("BaseModel.model");
            DeepBeliefNetworkModel newModel = baseModel;

            while (true)
            {
                var slr = FlatRedBallServices.Random.In(slrList);
                var sm = FlatRedBallServices.Random.In(smList);
                var uslr = FlatRedBallServices.Random.In(uslrList);
                var usm = FlatRedBallServices.Random.In(usmList);
                var usd = FlatRedBallServices.Random.In(usdList);

                var combo = $"{slr}{sm}{uslr}{usm}{usd}";

                if (triedCombos.Contains(combo)) continue;

                triedCombos.Add(combo);

                CSV.Clear();

                newModel.Initialize(InputCount, (int)(InputCount * 0.8), uslr, usm, usd, slr, sm);
                newModel.Load("BaseModel.model");

                CSV.Append($"{slr},{sm},{uslr},{usm},{usd},");

                newModel.LearnAll(_waveData);

                CSV.Append(newModel.LastMSE);
                CSV.Append(Environment.NewLine);
                File.AppendAllText(fileName, CSV.ToString());
                CSV.Clear();

                if (newModel.LastMSE < 0.03)
                {
                    newModel.Save("BESTMODEL" + newModel.LastMSE + "SAVE.model");
                }
            }
        }

        private static void IncrementalTest()
        {
            var slr = 0.8;
            var sm = 0.8;
            var uslr = 0.9;
            var usm = 0.2;
            var usd = 0.21;

            InputCount = (MaxPathingPoints * CountPerPathing) +
                         (MaxWaterPoints * CountPerWater) +
                         (MaxTowers * CountPerTower) +
                         (MaxEnemies * CountPerEnemy);

            var outputList = new List<double>();
            var inputList = new List<double[]>();

            using (var reader = new StreamReader(@"wavedata.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split('\t');

                    var output = double.Parse(values[0]);
                    outputList.Add(output);

                    var inputCount = values.Length - 1;

                    var inputArray = new double[inputCount];

                    for (var i = 1; i < inputCount; i++)
                    {
                        inputArray[i - 1] = double.Parse(values[i]);
                    }
                    inputList.Add(inputArray);
                }
            }

            for (var modelTest = 5; modelTest <= 9; modelTest++)
            {
                _machineLearningModel = new DeepBeliefNetworkModel();
                _machineLearningModel.Initialize(InputCount, (int)(InputCount * 0.8), uslr, usm, usd, slr, sm);

                CSV = new StringBuilder();
                CSV.Append("SampleSize, AVMMSE, MSE, LearnTime");
                CSV.Append(Environment.NewLine);

                var partialOutput = new List<double>();
                var partialInput = new List<double[]>();

                _waveData = new WaveData
                {
                    WaveInputs = partialInput,
                    WaveScores = partialOutput,
                };

                var sampleSize = FlatRedBallServices.Random.Next(150, 630);

                for (var i = 0; i <= sampleSize; i++)
                {
                    var randomIndex = FlatRedBallServices.Random.Next(0, outputList.Count - 1);
                    partialInput.Add(inputList[randomIndex]);
                    partialOutput.Add(outputList[randomIndex]);

                    _machineLearningModel.LearnAll(_waveData);
                    CSV.Append($"{i + 1}, {_machineLearningModel.AVMMSE}, {_machineLearningModel.LastMSE}, {_machineLearningModel.LastLearnTime}");
                    CSV.Append(Environment.NewLine);
                }

                var fileName = $"Player{modelTest}Data.csv";
                File.WriteAllText(fileName, CSV.ToString());
            }
        }

        private static void LoadTestData()
        {
            CSV = new StringBuilder();
            CSV.Append("SampleSize, AVMMSE, MSE");
            CSV.Append(Environment.NewLine);

            var slr = 0.8;
            var sm = 0.8;
            var uslr = 0.9;
            var usm = 0.2;
            var usd = 0.21;

            InputCount = (MaxPathingPoints * CountPerPathing) +
                         (MaxWaterPoints * CountPerWater) +
                         (MaxTowers * CountPerTower) +
                         (MaxEnemies * CountPerEnemy);

            _machineLearningModel = new DeepBeliefNetworkModel();
            _machineLearningModel.Initialize(InputCount, (int)(InputCount * 0.8), uslr, usm, usd, slr, sm);

            var outputList = new List<double>();
            var inputList = new List<double[]>();

            _waveData = new WaveData
            {
                WaveInputs = inputList,
                WaveScores = outputList,
            };

            var priorMSE = 0.0;

            using (var reader = new StreamReader(@"wavedata.csv"))
            {
                var sampleSize = 0;
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split('\t');

                    var output = double.Parse(values[0]);
                    outputList.Add(output);

                    var inputCount = values.Length - 1;

                    var inputArray = new double[inputCount];

                    for (var i = 1; i < inputCount; i++)
                    {
                        inputArray[i - 1] = double.Parse(values[i]);
                    }
                    inputList.Add(inputArray);

                    _machineLearningModel.LearnAll(_waveData);

                    CSV.Append($"{++sampleSize}, {_machineLearningModel.AVMMSE}, {_machineLearningModel.LastMSE}");
                    CSV.Append(Environment.NewLine);
                    if ((sampleSize / 50 >= 1 && sampleSize % 50 == 0) || (sampleSize > 20 && Math.Abs(priorMSE - _machineLearningModel.LastMSE) > 0.05))
                    {
                        var wait = _machineLearningModel.LastMSE;
                    }

                    priorMSE = _machineLearningModel.LastMSE;
                }
            }

            var fileName = "ModelData.csv";
            File.WriteAllText(fileName, CSV.ToString());
        }
    }
}
