using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AbbatoirIntergrade.UtilityClasses;
using Accord.Genetic;
using Accord.IO;
using FlatRedBall;
using FlatRedBall.Instructions;
using FlatRedBall.IO;
using MoreLinq;

namespace AbbatoirIntergrade.StaticManagers
{
    public static class GeneticsManager
    {
        private static StringBuilder CSV;
        public static void PerformTest(int iteration)
        {
            ChromosomeFitnessFunction = new FitnessFunction();
            CreateNewGeneticPool();

            var generations = 638;

            CSV = new StringBuilder();
            CSV.Append("GenerationNumber, " +
                       "Chicken1Fitness, Chicken2Fitness, Chicken3Fitness, " +
                       "Pig1Fitness, Pig2Fitness, Pig3Fitness, " +
                       "Rabbit1Fitness, Rabbit2Fitness, Rabbit3Fitness, " +
                       "Cow1Fitness, Cow2Fitness, Cow3Fitness, " +
                       "Sheep1Fitness, Sheep2Fitness, Sheep3Fitness, AverageFitness");
            CSV.Append(Environment.NewLine);
            CSV.Append("0, " +
                       $"{GetBestChromsomeForEnemyType(EnemyTypes.Chicken1).Fitness}, {GetBestChromsomeForEnemyType(EnemyTypes.Chicken2).Fitness}, {GetBestChromsomeForEnemyType(EnemyTypes.Chicken3).Fitness}, " +
                       $"{GetBestChromsomeForEnemyType(EnemyTypes.Pig1).Fitness}, {GetBestChromsomeForEnemyType(EnemyTypes.Pig2).Fitness}, {GetBestChromsomeForEnemyType(EnemyTypes.Pig3).Fitness}, " +
                       $"{GetBestChromsomeForEnemyType(EnemyTypes.Rabbit1).Fitness}, {GetBestChromsomeForEnemyType(EnemyTypes.Rabbit2).Fitness}, {GetBestChromsomeForEnemyType(EnemyTypes.Rabbit3).Fitness}, " +
                       $"{GetBestChromsomeForEnemyType(EnemyTypes.Cow1).Fitness}, {GetBestChromsomeForEnemyType(EnemyTypes.Cow2).Fitness}, {GetBestChromsomeForEnemyType(EnemyTypes.Cow3).Fitness}, " +
                       $"{GetBestChromsomeForEnemyType(EnemyTypes.Sheep1).Fitness}, {GetBestChromsomeForEnemyType(EnemyTypes.Sheep2).Fitness}, {GetBestChromsomeForEnemyType(EnemyTypes.Sheep3).Fitness}");
            CSV.Append(Environment.NewLine);
            for (var i = 1; i < generations; i++)
            {
                EvaluateAndGenerate();
                CSV.Append($"{i}, " +
                           $"{GetBestChromsomeForEnemyType(EnemyTypes.Chicken1).Fitness}, {GetBestChromsomeForEnemyType(EnemyTypes.Chicken2).Fitness}, {GetBestChromsomeForEnemyType(EnemyTypes.Chicken3).Fitness}, " +
                           $"{GetBestChromsomeForEnemyType(EnemyTypes.Pig1).Fitness}, {GetBestChromsomeForEnemyType(EnemyTypes.Pig2).Fitness}, {GetBestChromsomeForEnemyType(EnemyTypes.Pig3).Fitness}, " +
                           $"{GetBestChromsomeForEnemyType(EnemyTypes.Rabbit1).Fitness}, {GetBestChromsomeForEnemyType(EnemyTypes.Rabbit2).Fitness}, {GetBestChromsomeForEnemyType(EnemyTypes.Rabbit3).Fitness}, " +
                           $"{GetBestChromsomeForEnemyType(EnemyTypes.Cow1).Fitness}, {GetBestChromsomeForEnemyType(EnemyTypes.Cow2).Fitness}, {GetBestChromsomeForEnemyType(EnemyTypes.Cow3).Fitness}, " +
                           $"{GetBestChromsomeForEnemyType(EnemyTypes.Sheep1).Fitness}, {GetBestChromsomeForEnemyType(EnemyTypes.Sheep2).Fitness}, {GetBestChromsomeForEnemyType(EnemyTypes.Sheep3).Fitness}");
                CSV.Append(Environment.NewLine);
            }

            File.WriteAllText($"GenerationData{iteration}.csv", CSV.ToString());
        }

        private const string TempGeneticsFileName = "Genetics.xml";

        private const int ChromosomeLength = 8;
        private const int PopulationSize = 100;
        private const int NumberOfChromosomesToSelect = 15;
        private const float PercentToCrossover= 0.1f;
        private const float PercentToMutate = 0.15f;
        private static int? GenerationCount;
        
        private static FitnessFunction ChromosomeFitnessFunction;

        private static SerializableDictionary<EnemyTypes, List<SerializableChromosome>> EnemyTypeChromosomes;

        private static string _geneticsFileName;

        private static bool _CurrentlyRefreshingOrSaving = false;
        private static Mutex _geneticsMutex = new Mutex();

        public static void Initialize()
        {
            LocalLogManager.AddLine("Genetics manager initialization");
            ChromosomeFitnessFunction = new FitnessFunction();

            if (EnemyTypeChromosomes == null)
            {
                var loadWasSuccessful = Load(TempGeneticsFileName);
                if (!loadWasSuccessful) CreateNewGeneticPool();
            }
        }

        public static void CreateNewGeneticPool()
        {
            GenerationCount = 0;

            EnemyTypeChromosomes = new SerializableDictionary<EnemyTypes, List<SerializableChromosome>>();

            foreach (EnemyTypes enemyType in Enum.GetValues(typeof(EnemyTypes)))
            {
                var chromosomeList = new List<SerializableChromosome>();

                for (var i = 0; i < PopulationSize; i++)
                {
                    chromosomeList.Add(GenerateNewChromsome());
                }

                EnemyTypeChromosomes.Add(enemyType, chromosomeList);
            }
        }

        public static bool Load(string fileName)
        {
            _geneticsMutex.WaitOne();
            _geneticsFileName = fileName;
            var _generationCountFileName = "Count" + fileName;

            var fileExists = FileManager.FileExists(_geneticsFileName);
            if (!fileExists)
            {
                _geneticsMutex.ReleaseMutex();
                return false;
            }
            try
            {
                EnemyTypeChromosomes = FileManager.XmlDeserialize(typeof(SerializableDictionary<EnemyTypes, List<SerializableChromosome>>), _geneticsFileName) as SerializableDictionary<EnemyTypes, List<SerializableChromosome>>;
                GenerationCount = FileManager.XmlDeserialize(typeof(int?), _generationCountFileName) as int?;
                _geneticsMutex.ReleaseMutex();
            }
            catch (Exception ex)
            {
                _geneticsMutex.ReleaseMutex();
                return false;
            }

            return true;
        }

        public static bool Save(string fileName)
        {
            _geneticsFileName = fileName;
            var _generationCountFileName = "Count" + fileName;

            try
            {
                _geneticsMutex.WaitOne();
                FileManager.XmlSerialize(EnemyTypeChromosomes, _geneticsFileName);
                FileManager.XmlSerialize(GenerationCount, _generationCountFileName);
                _geneticsMutex.ReleaseMutex();
            }
            catch (Exception ex)
            {
                _geneticsMutex.ReleaseMutex();
                _CurrentlyRefreshingOrSaving = false;
                return false;
            }
            _CurrentlyRefreshingOrSaving = false;
            return true;
        }

        public static List<SerializableChromosome> GetChromosomesForEnemyType(EnemyTypes enemyType, int numberToReturn = 1)
        {
            List<SerializableChromosome> chromosomeList;

            if (!EnemyTypeChromosomes[enemyType].Any(c => c.Fitness > 0))
            {
                RefreshAllFitnessEvaluations();
            }

            _geneticsMutex.WaitOne();
            chromosomeList = EnemyTypeChromosomes[enemyType].ToList();
            ApplySelection(chromosomeList, numberToReturn);
            _geneticsMutex.ReleaseMutex();

            return chromosomeList;
        }

        public static SerializableChromosome GetBestChromsomeForEnemyType(EnemyTypes enemyType)
        {
            if (!EnemyTypeChromosomes[enemyType].Any(c => c.Fitness > 0))
            {
                RefreshAllFitnessEvaluations();
            }

            try
            {
                _geneticsMutex.WaitOne();
                var chromsome = EnemyTypeChromosomes[enemyType].MaxBy(e => e.Fitness);
                _geneticsMutex.ReleaseMutex();

                return chromsome;
            }
            catch (Exception e)
            {
#if DEBUG
                throw;
#else
                return null;
#endif
            }
        }

        public static void EvaluateAndGenerate()
        {
            if (!MachineLearningManager.IsReadyToEvaluate) return;
            //if (_CurrentlyRefreshingOrSaving) return;
            //_CurrentlyRefreshingOrSaving = true;
            //void RefreshAndGenerateTask()
            //{
                var newDictionary = new SerializableDictionary<EnemyTypes, List<SerializableChromosome>>();
                foreach (var enemyTypeAndChromosomeList in EnemyTypeChromosomes)
                {
                    var enemyType = enemyTypeAndChromosomeList.Key;
                    var currentList = CloneList(enemyTypeAndChromosomeList.Value);

                    if (currentList.Count > 0)
                    {
                        ApplySelection(currentList, NumberOfChromosomesToSelect);

                        if (currentList.Count > 0)
                        {
                            currentList.Sort((c1, c2) => c2.Fitness.CompareTo(c1.Fitness));

                            PerformCrossover(ref currentList);
                            PerformMutation(ref currentList);

                            //PerformCrossover(ref currentList, true);
                            //PerformMutation(ref currentList, true);

                            PerformNewGeneration(ref currentList);
                        }
                        else
                        {
#if DEBUG
                            var x = "uhoh";
#endif
                        }
                        newDictionary.Add(enemyType, currentList);
                    }
                }
                _geneticsMutex.WaitOne();
                EnemyTypeChromosomes = newDictionary;
                _geneticsMutex.ReleaseMutex();

                RefreshAllFitnessEvaluations();
                //AnalyticsManager.SendEventImmediately("GeneticGeneration", CreateEventObject());

                GenerationCount++;

            //    Action UpdateAction = () => Save(_geneticsFileName);
            //    InstructionManager.AddSafe(UpdateAction);
            //}

            //var lowPriorityThread = new Thread(RefreshAndGenerateTask) { Priority = ThreadPriority.BelowNormal };
            //lowPriorityThread.Start();
            //Task.Run((Action)RefreshAndGenerateTask);
        }

        public static double GetAverageFitness()
        {

            var Chicken2Current = GetBestChromsomeForEnemyType(EnemyTypes.Chicken2)?.Fitness ?? 0;
            var Chicken3Current = GetBestChromsomeForEnemyType(EnemyTypes.Chicken3)?.Fitness ?? 0;
            var Chicken1Current = GetBestChromsomeForEnemyType(EnemyTypes.Chicken1)?.Fitness ?? 0;

            var averageChicken = (Chicken1Current + Chicken2Current + Chicken3Current) / 3;
            
            var Pig1Current = GetBestChromsomeForEnemyType(EnemyTypes.Pig1)?.Fitness ?? 0;
            var Pig2Current = GetBestChromsomeForEnemyType(EnemyTypes.Pig2)?.Fitness ?? 0;
            var Pig3Current = GetBestChromsomeForEnemyType(EnemyTypes.Pig3)?.Fitness ?? 0;

            var averagePig = (Pig1Current + Pig2Current + Pig3Current) / 3;
            
            var Cow1Current = GetBestChromsomeForEnemyType(EnemyTypes.Cow1)?.Fitness ?? 0;
            var Cow2Current = GetBestChromsomeForEnemyType(EnemyTypes.Cow2)?.Fitness ?? 0;
            var Cow3Current = GetBestChromsomeForEnemyType(EnemyTypes.Cow3)?.Fitness ?? 0;

            var averageCow = (Cow1Current + Cow2Current + Cow3Current) / 3;
            
            var Rabbit1Current = GetBestChromsomeForEnemyType(EnemyTypes.Rabbit1)?.Fitness ?? 0;
            var Rabbit2Current = GetBestChromsomeForEnemyType(EnemyTypes.Rabbit2)?.Fitness ?? 0;
            var Rabbit3Current = GetBestChromsomeForEnemyType(EnemyTypes.Rabbit3)?.Fitness ?? 0;

            var averageRabbit = (Rabbit1Current + Rabbit2Current + Rabbit3Current) / 3;
             
            var Sheep1Current = GetBestChromsomeForEnemyType(EnemyTypes.Sheep1)?.Fitness ?? 0;
            var Sheep2Current = GetBestChromsomeForEnemyType(EnemyTypes.Sheep2)?.Fitness ?? 0;
            var Sheep3Current = GetBestChromsomeForEnemyType(EnemyTypes.Sheep3)?.Fitness ?? 0;

            var averageSheep = (Sheep1Current + Sheep2Current + Sheep3Current) / 3;

            var totalAverage = (averageChicken + averagePig + averageCow + averageRabbit + averageSheep) / 5;

            return totalAverage;
        }

        private static object CreateEventObject()
        {
            var eventObject = new
            {
                GenerationNumber = GenerationCount,

                Chicken1Current = GetBestChromsomeForEnemyType(EnemyTypes.Chicken1)?.Fitness,
                Chicken2Current = GetBestChromsomeForEnemyType(EnemyTypes.Chicken2)?.Fitness,
                Chicken3Current = GetBestChromsomeForEnemyType(EnemyTypes.Chicken3)?.Fitness,

                Pig1Current = GetBestChromsomeForEnemyType(EnemyTypes.Pig1)?.Fitness,
                Pig2Current = GetBestChromsomeForEnemyType(EnemyTypes.Pig2)?.Fitness,
                Pig3Current = GetBestChromsomeForEnemyType(EnemyTypes.Pig3)?.Fitness,

                Cow1Current = GetBestChromsomeForEnemyType(EnemyTypes.Cow1)?.Fitness,
                Cow2Current = GetBestChromsomeForEnemyType(EnemyTypes.Cow2)?.Fitness,
                Cow3Current = GetBestChromsomeForEnemyType(EnemyTypes.Cow3)?.Fitness,

                Rabbit1Current = GetBestChromsomeForEnemyType(EnemyTypes.Rabbit1)?.Fitness,
                Rabbit2Current = GetBestChromsomeForEnemyType(EnemyTypes.Rabbit2)?.Fitness,
                Rabbit3Current = GetBestChromsomeForEnemyType(EnemyTypes.Rabbit3)?.Fitness,

                Sheep1Current = GetBestChromsomeForEnemyType(EnemyTypes.Sheep1)?.Fitness,
                Sheep2Current = GetBestChromsomeForEnemyType(EnemyTypes.Sheep2)?.Fitness,
                Sheep3Current = GetBestChromsomeForEnemyType(EnemyTypes.Sheep3)?.Fitness,
            };

            return eventObject;
        }

        private static List<SerializableChromosome> CloneList(List<SerializableChromosome> originalList)
        {
            List<SerializableChromosome> newList = new List<SerializableChromosome>();

            for (var i = originalList.Count-1; i >= 0; i--)
            {
                if (originalList[i] != null) newList.Add(originalList[i].Clone() as SerializableChromosome);
            }

            return newList;
        }

        private static void PerformNewGeneration(ref List<SerializableChromosome> currentList)
        {
            var numberToGenerate = PopulationSize - currentList.Count;

            for (var i = 0; i < numberToGenerate; i++)
            {
                currentList.Add(GenerateNewChromsome());
            }
        }

        private static void PerformMutation(ref List<SerializableChromosome> currentList, bool modifyExisting = false)
        {
            const int numberToMutate = (int)(PopulationSize * PercentToMutate);

            for (var i = 0; i < numberToMutate - 1; i++)
            {
                SerializableChromosome randomChromosome;

                if (modifyExisting)
                {
                    randomChromosome = FlatRedBallServices.Random.In(currentList);
                    currentList.Remove(randomChromosome);
                }
                else
                {
                    randomChromosome = FlatRedBallServices.Random.In(currentList).Clone() as SerializableChromosome;
                }

                randomChromosome.Mutate();
                currentList.Add(randomChromosome);
            }
        }

        private static void PerformCrossover(ref List<SerializableChromosome> currentList, bool modifyExisting = false)
        {
            const int numberToCrossover = (int)(PopulationSize * PercentToCrossover);

            for (var i = 0; i < numberToCrossover-1; i++)
            {
                SerializableChromosome randomChromosome;

                var sourceChromosome = FlatRedBallServices.Random.In(currentList);

                if (modifyExisting)
                {
                    randomChromosome = FlatRedBallServices.Random.In(currentList);
                    currentList.Remove(randomChromosome);
                }
                else
                {
                    randomChromosome = FlatRedBallServices.Random.In(currentList).Clone() as SerializableChromosome;
                }
                randomChromosome.Crossover(sourceChromosome);

                currentList.Add(randomChromosome);
            }
        }

        private static void RefreshAllFitnessEvaluations()
        {
            _geneticsMutex.WaitOne();
            foreach (var enemyTypeAndChromosomeList in EnemyTypeChromosomes)
            {
                RankFitness(enemyTypeAndChromosomeList.Key, enemyTypeAndChromosomeList.Value);
            }
            _geneticsMutex.ReleaseMutex();
        }

        private static void RankFitness(EnemyTypes enemyType, List<SerializableChromosome> chromosomes)
        {
            ChromosomeFitnessFunction.EnemyType = enemyType;
            ChromosomeFitnessFunction.PartialInputList = MachineLearningManager.GetFitnessRankingInput();

            foreach (var chromosome in chromosomes)
            {
                chromosome.Evaluate(ChromosomeFitnessFunction);
            }
        }

        public static SerializableChromosome GenerateNewChromsome()
        {
            return new SerializableChromosome(ChromosomeLength);
        }

        private static void ApplySelection(List<SerializableChromosome> chromosomes, int size)
        {
            var chromosomeList = new List<SerializableChromosome>();
            //var random = FlatRedBallServices.Random;
            //var count = chromosomes.Count;
            //var num1 = chromosomes.Sum(chromosome => Double.IsNaN(chromosome.Fitness) || Double.IsInfinity(chromosome.Fitness) ? 0 : chromosome.Fitness);
            //var numArray = new double[count];
            //var num2 = 0.0;
            //var num3 = 0;
            //foreach (var chromosome in chromosomes)
            //{
            //    num2 += chromosome.Fitness / num1;
            //    numArray[num3++] = num2;
            //}
            //for (var index1 = 0; index1 < size; ++index1)
            //{
            //    var num4 = random.NextDouble();
            //    for (var index2 = 0; index2 < count; ++index2)
            //    {
            //        if (!(num4 <= numArray[index2])) continue;
            //        chromosomeList.Add(chromosomes[index2].Clone() as SerializableChromosome);
            //        break;
            //    }
            //}
            chromosomeList.AddRange(chromosomes.OrderBy(c => -c.Fitness).Take(size));
            chromosomes.Clear();
            chromosomes.AddRange(chromosomeList);
        }

        private class FitnessFunction : IFitnessFunction
        {
            public EnemyTypes EnemyType;
            public List<double> PartialInputList;

            public double Evaluate(IChromosome chromosome)
            {
                //var baseFitness = EnemyType.PointValue();
                //var geneticEvaluation = ((EnemyType.PointValue(chromosome as SerializableChromosome) / baseFitness) - 1)/0.1;

                var machinelearningEvaluation = 0.0;

                if (MachineLearningManager.IsReadyToEvaluate)
                {
                    machinelearningEvaluation = MachineLearningManager.Evaluate(new List<double>(PartialInputList),
                        EnemyType, chromosome as SerializableChromosome);
                }

                return machinelearningEvaluation;
            }
        }
    }
}
