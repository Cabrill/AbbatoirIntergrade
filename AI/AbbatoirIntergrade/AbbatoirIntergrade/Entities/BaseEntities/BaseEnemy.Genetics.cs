using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.Genetic;

namespace AbbatoirIntergrade.Entities.BaseEntities
{
    public partial class BaseEnemy
    {
        private const int ChromosomeLength = 8;
        const int halfwayMax = ushort.MaxValue / 2;

        private void SetGenetics(ShortArrayChromosome chromosome = null)
        {
            Chromosome = chromosome ?? new ShortArrayChromosome(ChromosomeLength);

            MaximumHealth = CalculateMaximumHealth();
            HealthRemaining = MaximumHealth;

            Speed = CalculateSpeed();

            EffectivePiercingResist = CalculateResistance(BasePiercingResist, 0);
            EffectiveBombardResist = CalculateResistance(BaseBombardResist, 1);
            EffectiveChemicalResist = CalculateResistance(BaseChemicalResist, 2);
            EffectiveFireResist = CalculateResistance(BaseFireResist, 3);
            EffectiveFrostResist = CalculateResistance(BaseFrostResist, 4);
            EffectiveElectricResist = CalculateResistance(BaseElectricResist, 5);
        }

        private float CalculateMaximumHealth()
        {
            var effectiveHealth = BaseHealth;
            

            var healthModifier = (SumChromsomeValues(new List<int>(){0, 2, 4}) - SumChromsomeValues(new List<int>{1, 3, 5})) / 3;
            healthModifier *= (Chromosome.Value[6]- halfwayMax) / halfwayMax;

            effectiveHealth += (healthModifier/2 * BaseHealth);

            return effectiveHealth;
        }

        private float CalculateSpeed()
        {
            var effectiveSpeed = BaseSpeed;

            var speedModifier = (-SumChromsomeValues(new List<int>() { 0, 2, 4 }) + SumChromsomeValues(new List<int> { 1, 3, 5 })) / 3;
            speedModifier *= (Chromosome.Value[7] - halfwayMax) / halfwayMax;

            effectiveSpeed += (speedModifier/4 * BaseSpeed);

            return effectiveSpeed;
        }

        private float CalculateResistance(float baseResist, int resistIndex)
        {
            var effectiveResist = baseResist;

            var resistNegatives = new List<int>() {0, 1, 2, 3, 4, 5};
            resistNegatives.Remove(resistIndex);

            var resistModifier = (Chromosome.Value[resistIndex] - AverageChromosomeValues(resistNegatives)) / ushort.MaxValue;
            resistModifier /= AverageChromosomeValues(new List<int>() {6, 7}) / ushort.MaxValue;

            effectiveResist += resistModifier * baseResist;

            return effectiveResist;
        }

        private float AverageChromosomeValues(IEnumerable<int> values)
        {
            return (float)values.Average((index) => Chromosome.Value[index]);
        }

        private float SumChromsomeValues(IEnumerable<int> values)
        {
            return values.Aggregate(0f, (current, index) => current + Chromosome.Value[index]);
        }
    }
}
