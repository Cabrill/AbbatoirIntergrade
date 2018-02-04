using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbbatoirIntergrade.UtilityClasses;
using Accord.Genetic;
using FlatRedBall;
using FlatRedBall.IO;

namespace AbbatoirIntergrade.StaticManagers
{
    public static class GeneticsManager
    {
        private const int ChromosomeLength = 8;
        private const int PopulationSize = 50;
        private const int NumberOfChromosomesToSelect = 10;
        private const float PercentToCrossover= 0.5f;
        private const float PercentToMutate = 0.3f;
        
        private static FitnessFunction ChromosomeFitnessFunction;

        private static SerializableDictionary<EnemyTypes, List<SerializableChromosome>> EnemyTypeChromosomes;

        public static void Initialize()
        {
            ChromosomeFitnessFunction = new FitnessFunction();

            if (EnemyTypeChromosomes == null)
            {
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
        }

        public static bool Load(string fileName)
        {
            var fileExists = FileManager.FileExists(fileName);
            if (!fileExists) return false;
            try
            {
                EnemyTypeChromosomes = FileManager.XmlDeserialize(typeof(SerializableDictionary<EnemyTypes, List<SerializableChromosome>>), fileName) as SerializableDictionary<EnemyTypes, List<SerializableChromosome>>;
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public static bool Save(string fileName)
        {
            try
            {
                FileManager.XmlSerialize(EnemyTypeChromosomes, fileName);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public static List<SerializableChromosome> GetChromosomesForEnemyType(EnemyTypes enemyType, int numberToReturn = 1)
        {
            var chromosomeList = EnemyTypeChromosomes[enemyType];
            ApplySelection(chromosomeList, numberToReturn);

            return chromosomeList;
        }

        public static void EvaluateAndGenerate()
        {
            if (!MachineLearningManager.IsReadyToEvaluate) return;

            RefreshAllFitnessEvaluations();

            var newDictionary = new SerializableDictionary<EnemyTypes, List<SerializableChromosome>>();

            foreach (var enemyTypeAndChromosomeList in EnemyTypeChromosomes)
            {
                var enemyType = enemyTypeAndChromosomeList.Key;
                var currentList = enemyTypeAndChromosomeList.Value;

                ApplySelection(currentList, NumberOfChromosomesToSelect);

                currentList.Sort((c1, c2) => c2.Fitness.CompareTo(c1.Fitness));

                PerformCrossover(ref currentList);
                PerformMutation(ref currentList);
                PerformNewGeneration(ref currentList);

                newDictionary.Add(enemyType, currentList);
            }
            EnemyTypeChromosomes = newDictionary;

            RefreshAllFitnessEvaluations();
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
            var num1 = chromosomes.Sum(chromosome => chromosome.Fitness);
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
