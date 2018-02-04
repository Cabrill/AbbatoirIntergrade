using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.Genetic;

namespace AbbatoirIntergrade.UtilityClasses
{
    [Serializable]
    public abstract class SerializableChromosomeBase : IChromosome, IComparable
    {
        /// <summary>Chromosome's fitness value.</summary>
        protected double fitness;

        /// <summary>Chromosome's fitness value.</summary>
        /// <remarks><para>Fitness value (usefulness) of the chromosome calculate by calling
        /// <see cref="M:Accord.Genetic.ChromosomeBase.Evaluate(Accord.Genetic.IFitnessFunction)" /> method. The greater the value, the more useful the chromosome.
        /// </para></remarks>
        public double Fitness
        {
            get
            {
                return this.fitness;
            }
        }

        /// <summary>Generate random chromosome value.</summary>
        /// <remarks><para>Regenerates chromosome's value using random number generator.</para>
        /// </remarks>
        public abstract void Generate();

        /// <summary>
        /// Create new random chromosome with same parameters (factory method).
        /// </summary>
        /// <remarks><para>The method creates new chromosome of the same type, but randomly
        /// initialized. The method is useful as factory method for those classes, which work
        /// with chromosome's interface, but not with particular chromosome class.</para></remarks>
        public abstract IChromosome CreateNew();

        /// <summary>Clone the chromosome.</summary>
        /// <remarks><para>The method clones the chromosome returning the exact copy of it.</para>
        /// </remarks>
        public abstract IChromosome Clone();

        /// <summary>Mutation operator.</summary>
        /// <remarks><para>The method performs chromosome's mutation, changing its part randomly.</para></remarks>
        public abstract void Mutate();

        /// <summary>Crossover operator.</summary>
        /// <param name="pair">Pair chromosome to crossover with.</param>
        /// <remarks><para>The method performs crossover between two chromosomes – interchanging some parts of chromosomes.</para></remarks>
        public abstract void Crossover(IChromosome pair);

        /// <summary>
        /// Evaluate chromosome with specified fitness function.
        /// </summary>
        /// <param name="function">Fitness function to use for evaluation of the chromosome.</param>
        /// <remarks><para>Calculates chromosome's fitness using the specifed fitness function.</para></remarks>
        public void Evaluate(IFitnessFunction function)
        {
            this.fitness = function.Evaluate((IChromosome)this);
        }

        /// <summary>Compare two chromosomes.</summary>
        /// <param name="o">Binary chromosome to compare to.</param>
        /// <returns>Returns comparison result, which equals to 0 if fitness values
        /// of both chromosomes are equal, 1 if fitness value of this chromosome
        /// is less than fitness value of the specified chromosome, -1 otherwise.</returns>
        public int CompareTo(object o)
        {
            double fitness = ((SerializableChromosomeBase)o).fitness;
            if (this.fitness == fitness)
                return 0;
            return this.fitness >= fitness ? -1 : 1;
        }
    }
}
