using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.Genetic;
using Accord.Math.Random;

namespace AbbatoirIntergrade.UtilityClasses
{
    [Serializable]
    public class SerializableChromosome : SerializableChromosomeBase
    {
        /// <summary>Chromosome's length in number of elements.</summary>
        protected int length;

        /// <summary>Maximum value of chromosome's gene (element).</summary>
        protected int maxValue;

        /// <summary>Chromosome's value.</summary>
        protected ushort[] val;

        /// <summary>Chromosome's maximum length.</summary>
        /// <remarks><para>Maxim chromosome's length in array elements.</para></remarks>
        public const int MaxLength = 65536;

        /// <summary>Chromosome's length.</summary>
        /// <remarks><para>Length of the chromosome in array elements.</para></remarks>
        public int Length
        {
            get { return this.length; }
        }

        /// <summary>Chromosome's value.</summary>
        /// <remarks><para>Current value of the chromosome.</para></remarks>
        public ushort[] Value
        {
            get { return this.val; }
        }

        /// <summary>
        /// Max possible value of single chromosomes element - gene.
        /// </summary>
        /// <remarks><para>Maximum possible numerical value, which may be represented
        /// by single chromosome's gene (array element).</para></remarks>
        public int MaxValue
        {
            get { return this.maxValue; }
        }

        public SerializableChromosome() : this(8, (int) ushort.MaxValue)
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Accord.Genetic.ShortArrayChromosome" /> class.
        /// </summary>
        /// <param name="length">Chromosome's length in array elements, [2, <see cref="F:Accord.Genetic.ShortArrayChromosome.MaxLength" />].</param>
        /// <remarks>This constructor initializes chromosome setting genes' maximum value to
        /// maximum posible value of <see langword="ushort" /> type.</remarks>
        public SerializableChromosome(int length)
            : this(length, (int) ushort.MaxValue)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Accord.Genetic.ShortArrayChromosome" /> class.
        /// </summary>
        /// <param name="length">Chromosome's length in array elements, [2, <see cref="F:Accord.Genetic.ShortArrayChromosome.MaxLength" />].</param>
        /// <param name="maxValue">Maximum value of chromosome's gene (array element).</param>
        public SerializableChromosome(int length, int maxValue)
        {
            this.length = System.Math.Max(2, System.Math.Min(65536, length));
            this.maxValue = System.Math.Max(1, System.Math.Min((int) ushort.MaxValue, maxValue));
            this.val = new ushort[this.length];
            this.Generate();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Accord.Genetic.ShortArrayChromosome" /> class.
        /// </summary>
        /// <param name="source">Source chromosome to copy.</param>
        /// <remarks><para>This is a copy constructor, which creates the exact copy
        /// of specified chromosome.</para></remarks>
        protected SerializableChromosome(SerializableChromosome source)
        {
            this.length = source.length;
            this.maxValue = source.maxValue;
            this.val = (ushort[]) source.val.Clone();
            this.fitness = source.fitness;
        }

        /// <summary>Get string representation of the chromosome.</summary>
        /// <returns>Returns string representation of the chromosome.</returns>
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(this.val[0]);
            for (int index = 1; index < this.length; ++index)
            {
                stringBuilder.Append(' ');
                stringBuilder.Append(this.val[index]);
            }
            return stringBuilder.ToString();
        }

        /// <summary>Generate random chromosome value.</summary>
        /// <remarks><para>Regenerates chromosome's value using random number generator.</para>
        /// </remarks>
        public override void Generate()
        {
            int maxValue = this.maxValue + 1;
            for (int index = 0; index < this.length; ++index)
                this.val[index] = (ushort) Generator.Random.Next(maxValue);
        }

        /// <summary>
        /// Create new random chromosome with same parameters (factory method).
        /// </summary>
        /// <remarks><para>The method creates new chromosome of the same type, but randomly
        /// initialized. The method is useful as factory method for those classes, which work
        /// with chromosome's interface, but not with particular chromosome type.</para></remarks>
        public override IChromosome CreateNew()
        {
            return (IChromosome) new ShortArrayChromosome(this.length, this.maxValue);
        }

        /// <summary>Clone the chromosome.</summary>
        /// <returns>Return's clone of the chromosome.</returns>
        /// <remarks><para>The method clones the chromosome returning the exact copy of it.</para>
        /// </remarks>
        public override IChromosome Clone()
        {
            return (IChromosome) new SerializableChromosome(this);
        }

        /// <summary>Mutation operator.</summary>
        /// <remarks><para>The method performs chromosome's mutation, changing randomly
        /// one of its genes (array elements).</para></remarks>
        public override void Mutate()
        {
            this.val[Generator.Random.Next(this.length)] = (ushort) Generator.Random.Next(this.maxValue + 1);
        }

        /// <summary>Crossover operator.</summary>
        /// <param name="pair">Pair chromosome to crossover with.</param>
        /// <remarks><para>The method performs crossover between two chromosomes – interchanging
        /// range of genes (array elements) between these chromosomes.</para></remarks>
        public override void Crossover(IChromosome pair)
        {
            SerializableChromosome shortArrayChromosome = (SerializableChromosome) pair;
            if (shortArrayChromosome == null || shortArrayChromosome.length != this.length)
                return;
            int num = Generator.Random.Next(this.length - 1) + 1;
            int length = this.length - num;
            ushort[] numArray = new ushort[length];
            Array.Copy((Array) this.val, num, (Array) numArray, 0, length);
            Array.Copy((Array) shortArrayChromosome.val, num, (Array) this.val, num, length);
            Array.Copy((Array) numArray, 0, (Array) shortArrayChromosome.val, num, length);
        }
    }
}
