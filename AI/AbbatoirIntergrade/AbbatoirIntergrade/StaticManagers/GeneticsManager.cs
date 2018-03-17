using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        private const string TempGeneticsFileName = "Genetics.xml";

        private const int ChromosomeLength = 8;
        private const int PopulationSize = 50;
        private const int NumberOfChromosomesToSelect = 10;
        private const float PercentToCrossover= 0.5f;
        private const float PercentToMutate = 0.3f;
        private static int? GenerationCount;
        
        private static FitnessFunction ChromosomeFitnessFunction;

        private static SerializableDictionary<EnemyTypes, List<SerializableChromosome>> EnemyTypeChromosomes;
        private static SerializableDictionary<EnemyTypes, List<SerializableChromosome>> LegacyChromosomes;

        private static string _geneticsFileName;

        private static bool _CurrentlyRefreshingOrSaving = false;

        public static void Initialize()
        {
            ChromosomeFitnessFunction = new FitnessFunction();

            if (EnemyTypeChromosomes == null)
            {
                var loadWasSuccessful = Load(TempGeneticsFileName);
                if (!loadWasSuccessful) CreateNewGeneticPool();
            }
        }

        private static void CreateNewGeneticPool()
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
            _geneticsFileName = fileName;
            var _legacyGeneticsFileName = "Legacy" + fileName;
            var _generationCountFileName = "Count" + fileName;

            var fileExists = FileManager.FileExists(_geneticsFileName);
            if (!fileExists) return false;
            try
            {
                EnemyTypeChromosomes = FileManager.XmlDeserialize(typeof(SerializableDictionary<EnemyTypes, List<SerializableChromosome>>), _geneticsFileName) as SerializableDictionary<EnemyTypes, List<SerializableChromosome>>;
                LegacyChromosomes = FileManager.XmlDeserialize(typeof(SerializableDictionary<EnemyTypes, List<SerializableChromosome>>), _legacyGeneticsFileName) as SerializableDictionary<EnemyTypes, List<SerializableChromosome>>;
                GenerationCount = FileManager.XmlDeserialize(typeof(int?), _generationCountFileName) as int?;
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public static bool Save(string fileName)
        {
            _geneticsFileName = fileName;
            var _legacyGeneticsFileName = "Legacy" + fileName;
            var _generationCountFileName = "Count" + fileName;

            try
            {
                FileManager.XmlSerialize(EnemyTypeChromosomes, _geneticsFileName);
                FileManager.XmlSerialize(LegacyChromosomes, _legacyGeneticsFileName);
                FileManager.XmlSerialize(GenerationCount, _generationCountFileName);
            }
            catch (Exception ex)
            {
                _CurrentlyRefreshingOrSaving = false;
                return false;
            }
            _CurrentlyRefreshingOrSaving = false;
            return true;
        }

        public static List<SerializableChromosome> GetChromosomesForEnemyType(EnemyTypes enemyType, int numberToReturn = 1)
        {
            List<SerializableChromosome> chromosomeList;

            if (EnemyTypeChromosomes[enemyType].Any(c => c.Fitness > 0))
            {
                chromosomeList = EnemyTypeChromosomes[enemyType].ToList();
                ApplySelection(chromosomeList, numberToReturn);
            }
            else
            {
                chromosomeList = new List<SerializableChromosome>();
                for (var i = 0; i < numberToReturn; i++)
                {
                    chromosomeList.Add(FlatRedBallServices.Random.In(EnemyTypeChromosomes[enemyType]));
                }
            }

            return chromosomeList;
        }

        public static SerializableChromosome GetBestChromsomeForEnemyType(EnemyTypes enemyType)
        {
            try
            {
                RankFitness(enemyType, EnemyTypeChromosomes[enemyType]);

                return EnemyTypeChromosomes[enemyType].MaxBy(e => e.Fitness);
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

        public static SerializableChromosome GetBestLegacyChromosomeForEnemyType(EnemyTypes enemyType)
        {
            try
            {
                RankFitness(enemyType, LegacyChromosomes[enemyType]);

                return LegacyChromosomes[enemyType].MaxBy(e => e.Fitness);
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
            _CurrentlyRefreshingOrSaving = true;
            void RefreshAndGenerateTask()
            {
                RefreshAllFitnessEvaluations();

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
                EnemyTypeChromosomes = newDictionary;
                GenerationCount++;

                RefreshAllFitnessEvaluations();
                
                AnalyticsManager.SendEventImmediately("GeneticGeneration", CreateEventObject());

                Action UpdateAction = () => Save(_geneticsFileName); 
                InstructionManager.AddSafe(UpdateAction);
            }

            Task.Run((Action)RefreshAndGenerateTask);
        }

        private static object CreateEventObject()
        {
            var eventObject = new
            {
                GenerationNumber = GenerationCount ?? 0,

                Chicken1Legacy = GetBestLegacyChromosomeForEnemyType(EnemyTypes.Chicken1)?.Fitness,
                Chicken1Current = GetBestChromsomeForEnemyType(EnemyTypes.Chicken1)?.Fitness,
                Chicken2Legacy = GetBestLegacyChromosomeForEnemyType(EnemyTypes.Chicken2)?.Fitness,
                Chicken2Current = GetBestChromsomeForEnemyType(EnemyTypes.Chicken2)?.Fitness,
                Chicken3Legacy = GetBestLegacyChromosomeForEnemyType(EnemyTypes.Chicken3)?.Fitness,
                Chicken3Current = GetBestChromsomeForEnemyType(EnemyTypes.Chicken3)?.Fitness,

                Pig1Legacy = GetBestLegacyChromosomeForEnemyType(EnemyTypes.Pig1)?.Fitness,
                Pig1Current = GetBestChromsomeForEnemyType(EnemyTypes.Pig1)?.Fitness,
                Pig2Legacy = GetBestLegacyChromosomeForEnemyType(EnemyTypes.Pig2)?.Fitness,
                Pig2Current = GetBestChromsomeForEnemyType(EnemyTypes.Pig2)?.Fitness,
                Pig3Legacy = GetBestLegacyChromosomeForEnemyType(EnemyTypes.Pig3)?.Fitness,
                Pig3Current = GetBestChromsomeForEnemyType(EnemyTypes.Pig3)?.Fitness,

                Cow1Legacy = GetBestLegacyChromosomeForEnemyType(EnemyTypes.Cow1)?.Fitness,
                Cow1Current = GetBestChromsomeForEnemyType(EnemyTypes.Cow1)?.Fitness,
                Cow2Legacy = GetBestLegacyChromosomeForEnemyType(EnemyTypes.Cow2)?.Fitness,
                Cow2Current = GetBestChromsomeForEnemyType(EnemyTypes.Cow2)?.Fitness,
                Cow3Legacy = GetBestLegacyChromosomeForEnemyType(EnemyTypes.Cow3)?.Fitness,
                Cow3Current = GetBestChromsomeForEnemyType(EnemyTypes.Cow3)?.Fitness,

                Rabbit1Legacy = GetBestLegacyChromosomeForEnemyType(EnemyTypes.Rabbit1)?.Fitness,
                Rabbit1Current = GetBestChromsomeForEnemyType(EnemyTypes.Rabbit1)?.Fitness,
                Rabbit2Legacy = GetBestLegacyChromosomeForEnemyType(EnemyTypes.Rabbit2)?.Fitness,
                Rabbit2Current = GetBestChromsomeForEnemyType(EnemyTypes.Rabbit2)?.Fitness,
                Rabbit3Legacy = GetBestLegacyChromosomeForEnemyType(EnemyTypes.Rabbit3)?.Fitness,
                Rabbit3Current = GetBestChromsomeForEnemyType(EnemyTypes.Rabbit3)?.Fitness,

                Sheep1Legacy = GetBestLegacyChromosomeForEnemyType(EnemyTypes.Sheep1)?.Fitness,
                Sheep1Current = GetBestChromsomeForEnemyType(EnemyTypes.Sheep1)?.Fitness,
                Sheep2Legacy = GetBestLegacyChromosomeForEnemyType(EnemyTypes.Sheep2)?.Fitness,
                Sheep2Current = GetBestChromsomeForEnemyType(EnemyTypes.Sheep2)?.Fitness,
                Sheep3Legacy = GetBestLegacyChromosomeForEnemyType(EnemyTypes.Sheep3)?.Fitness,
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

        private static void PerformMutation(ref List<SerializableChromosome> currentList)
        {
            const int numberToMutate = (int)(PopulationSize * PercentToMutate);

            for (var i = 0; i < numberToMutate - 1; i++)
            {
                var randomChromosome = FlatRedBallServices.Random.In(currentList).Clone();

                randomChromosome.Mutate();
                currentList.Add(randomChromosome as SerializableChromosome);
            }
        }

        private static void PerformCrossover(ref List<SerializableChromosome> currentList)
        {
            const int numberToCrossover = (int)(PopulationSize * PercentToCrossover);

            var fittestChromosome = currentList[0];

            for (var i = 0; i < numberToCrossover-1; i++)
            {
                var randomChromosome = FlatRedBallServices.Random.In(currentList).Clone();
                    
                randomChromosome.Crossover(fittestChromosome);
                currentList.Add(randomChromosome as SerializableChromosome);
            }
        }

        private static void RefreshAllFitnessEvaluations()
        {
            foreach (var enemyTypeAndChromosomeList in EnemyTypeChromosomes)
            {
                RankFitness(enemyTypeAndChromosomeList.Key, enemyTypeAndChromosomeList.Value);
            }
        }

        private static void RankFitness(EnemyTypes enemyType, List<SerializableChromosome> chromosomes)
        {
            var partialInputList = MachineLearningManager.GetPathingAndTowersPartialInput();

            ChromosomeFitnessFunction.PartialInputList = partialInputList;
            ChromosomeFitnessFunction.EnemyType = enemyType;

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
            var random = FlatRedBallServices.Random;
            var chromosomeList = new List<SerializableChromosome>();
            var count = chromosomes.Count;
            var num1 = chromosomes.Sum(chromosome => Double.IsNaN(chromosome.Fitness) || Double.IsInfinity(chromosome.Fitness) ? 0 : chromosome.Fitness);
            var numArray = new double[count];
            var num2 = 0.0;
            var num3 = 0;
            foreach (var chromosome in chromosomes)
            {
                num2 += chromosome.Fitness / num1;
                numArray[num3++] = num2;
            }
            for (var index1 = 0; index1 < size; ++index1)
            {
                var num4 = random.NextDouble();
                for (var index2 = 0; index2 < count; ++index2)
                {
                    if (!(num4 <= numArray[index2])) continue;

                    chromosomeList.Add(chromosomes[index2].Clone() as SerializableChromosome);
                    break;
                }
            }
            chromosomes.Clear();
            chromosomes.AddRange(chromosomeList);
        }

        private class FitnessFunction : IFitnessFunction
        {
            public EnemyTypes EnemyType;
            public List<double> PartialInputList;

            public double Evaluate(IChromosome chromosome)
            {
                return MachineLearningManager.Evaluate(new List<double>(PartialInputList), EnemyType, chromosome as SerializableChromosome);
            }
        }
    }
}
