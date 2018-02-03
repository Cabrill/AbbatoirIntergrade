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
        private const float maxBonus = 0.1f;

        public struct GeneticAttributes
        {
            public float MaximumHealth;
            public float EffectiveSpeed;

            public float EffectivePiercingResist;
            public float EffectiveBombardResist;
            public float EffectiveChemicalResist;
            public float EffectiveFireResist;
            public float EffectiveFrostResist;
            public float EffectiveElectricResist;
        }

        public struct BaseAttributes
        {
            public float Health;
            public float Speed;

            public float PiercingResist;
            public float BombardResist;
            public float ChemicalResist;
            public float FireResist;
            public float FrostResist;
            public float ElectricResist;
        }

        public GeneticAttributes GetGeneticAttributes(BaseAttributes attributes, ShortArrayChromosome chromosome)
        {
            var effectiveAttributes = new GeneticAttributes
            {
                MaximumHealth = CalculateMaximumHealth(attributes.Health),
                EffectiveSpeed = CalculateSpeed(attributes.Speed),
                EffectivePiercingResist = CalculateResistance(attributes.PiercingResist, 0),
                EffectiveBombardResist = CalculateResistance(attributes.BombardResist, 1),
                EffectiveChemicalResist = CalculateResistance(attributes.ChemicalResist, 2),
                EffectiveFireResist = CalculateResistance(attributes.FireResist, 3),
                EffectiveFrostResist = CalculateResistance(attributes.FrostResist, 4),
                EffectiveElectricResist = CalculateResistance(attributes.ElectricResist, 5)
            };

            return effectiveAttributes;
        }


        public void SetGenetics(ShortArrayChromosome chromosome = null)
        {
            Chromosome = chromosome ?? new ShortArrayChromosome(ChromosomeLength);

            var baseAttributes = GetBaseAttributes();
            var effectiveAttributes = GetGeneticAttributes(baseAttributes, chromosome);

            MaximumHealth = effectiveAttributes.MaximumHealth;
            HealthRemaining = MaximumHealth;

            EffectiveSpeed = effectiveAttributes.EffectiveSpeed;

            EffectivePiercingResist = effectiveAttributes.EffectivePiercingResist;
            EffectiveBombardResist = effectiveAttributes.EffectiveBombardResist;
            EffectiveChemicalResist = effectiveAttributes.EffectiveChemicalResist;
            EffectiveFireResist = effectiveAttributes.EffectiveFireResist;
            EffectiveFrostResist = effectiveAttributes.EffectiveFrostResist;
            EffectiveElectricResist = effectiveAttributes.EffectiveElectricResist;
        }

        protected BaseAttributes GetBaseAttributes()
        {
            return new BaseAttributes()
            {
                Health = BaseHealth,
                Speed = BaseSpeed,

                PiercingResist = BasePiercingResist,
                BombardResist = BaseBombardResist,
                ChemicalResist = BaseChemicalResist,
                FireResist = BaseFireResist,
                FrostResist = BaseFrostResist,
                ElectricResist = BaseElectricResist
            };
        }

        private float CalculateMaximumHealth(float baseHealth)
        {
            var effectiveHealth = baseHealth;
            
            var healthModifier = (SumChromsomeValues(new List<int>(){0, 2, 4}) - SumChromsomeValues(new List<int>{1, 3, 5})) / (3 * ushort.MaxValue);
            healthModifier *= 1-Math.Abs(Chromosome.Value[6]- halfwayMax) / halfwayMax;

            effectiveHealth += (healthModifier/2 * maxBonus * baseHealth);

            if (effectiveHealth/ baseHealth > 1.1 || effectiveHealth / baseHealth < 0.9)
            {
                var doh = 1;
            }

            return effectiveHealth;
        }

        private float CalculateSpeed(float baseSpeed)
        {
            var effectiveSpeed = baseSpeed;

            var speedModifier = (-SumChromsomeValues(new List<int>() { 0, 2, 4 }) + SumChromsomeValues(new List<int> { 1, 3, 5 })) / (3 * ushort.MaxValue);
            speedModifier *= 1-Math.Abs(Chromosome.Value[7] - halfwayMax) / halfwayMax;

            effectiveSpeed += (speedModifier/4 * maxBonus * baseSpeed);

            if (effectiveSpeed / baseSpeed > 1.1 || effectiveSpeed / baseSpeed < 0.9)
            {
                var doh = 1;
            }

            return effectiveSpeed;
        }

        private float CalculateResistance(float baseResist, int resistIndex)
        {
            var effectiveResist = baseResist;

            var resistNegatives = new List<int>() {0, 1, 2, 3, 4, 5};
            resistNegatives.Remove(resistIndex);

            var resistModifier = (Chromosome.Value[resistIndex] - AverageChromosomeValues(resistNegatives)) / ushort.MaxValue;
            resistModifier *= 1-Math.Abs(AverageChromosomeValues(new List<int>() {6, 7}) - halfwayMax) / halfwayMax;

            effectiveResist += resistModifier * maxBonus * baseResist;

            if (effectiveResist > 0.95 || effectiveResist < 0)
            {
                var doh = 1;
            }
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
