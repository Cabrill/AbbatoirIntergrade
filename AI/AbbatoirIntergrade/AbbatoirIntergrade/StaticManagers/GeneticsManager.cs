using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.Genetic;
using FlatRedBall;

namespace AbbatoirIntergrade.StaticManagers
{
    public static class GeneticsManager
    {
        private const int ChromosomeLength = 8;
        private const int PopulationSize = 50;
        private const int NumberOfChromosomesToSelect = 10;
        private const float PercentToCrossover= 0.5f;
        private const float PercentToMutate = 0.3f;
        
        private static ISelectionMethod SelectionMethod;
        private static FitnessFunction ChromosomeFitnessFunction;

        private static SerializableDictionary<EnemyTypes, List<IChromosome>> EnemyTypeChromosomes;

        public static void Initialize()
        {
            SelectionMethod = new RouletteWheelSelection();
            ChromosomeFitnessFunction = new FitnessFunction();

            if (EnemyTypeChromosomes == null)
            {
                EnemyTypeChromosomes = new SerializableDictionary<EnemyTypes, List<IChromosome>>();
                foreach (EnemyTypes enemyType in Enum.GetValues(typeof(EnemyTypes)))
                {
                    var chromosomeList = new List<IChromosome>();

                    for (var i = 0; i < PopulationSize; i++)
                    {
                        chromosomeList.Add(GenerateNewChromsome());
                    }

                    EnemyTypeChromosomes.Add(enemyType, chromosomeList);
                }
            }
        }

        public static void EvaluateAndGenerate()
        {
            RefreshAllFitnessEvaluations();

            var newDictionary = new SerializableDictionary<EnemyTypes, List<IChromosome>>();

            foreach (var enemyTypeAndChromosomeList in EnemyTypeChromosomes)
            {
                var enemyType = enemyTypeAndChromosomeList.Key;
                var currentList = enemyTypeAndChromosomeList.Value;

                SelectionMethod.ApplySelection(currentList, NumberOfChromosomesToSelect);

                currentList.Sort((c1, c2) => c2.Fitness.CompareTo(c1.Fitness));

                PerformCrossover(ref currentList);
                PerformMutation(ref currentList);
                PerformNewGeneration(ref currentList);

                newDictionary.Add(enemyType, currentList);
            }
            EnemyTypeChromosomes = newDictionary;

            RefreshAllFitnessEvaluations();
        }

        private static void PerformNewGeneration(ref List<IChromosome> currentList)
        {
            var numberToGenerate = PopulationSize - currentList.Count;

            for (var i = 0; i < numberToGenerate; i++)
            {
                currentList.Add(GenerateNewChromsome());
            }
        }

        private static void PerformMutation(ref List<IChromosome> currentList)
        {
            const int numberToMutate = (int)(PopulationSize * PercentToMutate);

            for (var i = 0; i < numberToMutate - 1; i++)
            {
                var randomChromosome = FlatRedBallServices.Random.In(currentList).Clone();

                randomChromosome.Mutate();
                currentList.Add(randomChromosome);
            }
        }

        private static void PerformCrossover(ref List<IChromosome> currentList)
        {
            const int numberToCrossover = (int)(PopulationSize * PercentToCrossover);

            var fittestChromosome = currentList[0];

            for (var i = 0; i < numberToCrossover-1; i++)
            {
                var randomChromosome = FlatRedBallServices.Random.In(currentList).Clone();
                    
                randomChromosome.Crossover(fittestChromosome);
                currentList.Add(randomChromosome);
            }
        }

        private static void RefreshAllFitnessEvaluations()
        {
            foreach (var enemyTypeAndChromosomeList in EnemyTypeChromosomes)
            {
                RankFitness(enemyTypeAndChromosomeList.Key, enemyTypeAndChromosomeList.Value);
            }
        }

        private static void RankFitness(EnemyTypes enemyType, List<IChromosome> chromosomes)
        {
            var partialInputList = MachineLearningManager.GetPathingAndTowersPartialInput();

            ChromosomeFitnessFunction.PartialInputList = partialInputList;
            ChromosomeFitnessFunction.EnemyType = enemyType;

            foreach (var chromosome in chromosomes)
            {
                chromosome.Evaluate(ChromosomeFitnessFunction);
            }
        }

        public static ShortArrayChromosome GenerateNewChromsome()
        {
            return new ShortArrayChromosome(ChromosomeLength);
        }

        private class FitnessFunction : IFitnessFunction
        {
            public EnemyTypes EnemyType;
            public List<double> PartialInputList;

            public double Evaluate(IChromosome chromosome)
            {
                return MachineLearningManager.Evaluate(new List<double>(PartialInputList), EnemyType, chromosome as ShortArrayChromosome);
            }
        }
    }
}
