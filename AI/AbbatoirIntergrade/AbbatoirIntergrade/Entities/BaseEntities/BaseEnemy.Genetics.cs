using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbbatoirIntergrade.StaticManagers;
using Accord.Genetic;

namespace AbbatoirIntergrade.Entities.BaseEntities
{
    public partial class BaseEnemy
    {
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
            public bool IsFlying;
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
            public bool IsFlying;
        }

        public static GeneticAttributes GetGeneticAttributes(BaseAttributes attributes, ShortArrayChromosome chromosome)
        {
            var effectiveAttributes = new GeneticAttributes
            {
                MaximumHealth = CalculateMaximumHealth(attributes.Health, chromosome),
                EffectiveSpeed = CalculateSpeed(attributes.Speed, chromosome),
                EffectivePiercingResist = CalculateResistance(attributes.PiercingResist, 0, chromosome),
                EffectiveBombardResist = CalculateResistance(attributes.BombardResist, 1, chromosome),
                EffectiveChemicalResist = CalculateResistance(attributes.ChemicalResist, 2, chromosome),
                EffectiveFireResist = CalculateResistance(attributes.FireResist, 3, chromosome),
                EffectiveFrostResist = CalculateResistance(attributes.FrostResist, 4, chromosome),
                EffectiveElectricResist = CalculateResistance(attributes.ElectricResist, 5, chromosome),
                IsFlying = attributes.IsFlying,
            };

            return effectiveAttributes;
        }


        public void SetGenetics(ShortArrayChromosome chromosome = null)
        {
            Chromosome = chromosome ?? GeneticsManager.GenerateNewChromsome();

            var baseAttributes = GetBaseAttributes();
            var effectiveAttributes = GetGeneticAttributes(baseAttributes, Chromosome);

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
                ElectricResist = BaseElectricResist,
                IsFlying =  IsFlying
            };
        }

        private static float CalculateMaximumHealth(float baseHealth, ShortArrayChromosome chromosome)
        {
            var effectiveHealth = baseHealth;
            
            var healthModifier = (SumChromsomeValues(new List<int>{0, 2, 4}, chromosome) - SumChromsomeValues(new List<int>{1, 3, 5}, chromosome)) / (3 * ushort.MaxValue);
            healthModifier *= 1-Math.Abs(chromosome.Value[6]- halfwayMax) / halfwayMax;

            effectiveHealth += (healthModifier/2 * maxBonus * baseHealth);

            if (effectiveHealth/ baseHealth > 1.1 || effectiveHealth / baseHealth < 0.9)
            {
                var doh = 1;
            }

            return effectiveHealth;
        }

        private static float CalculateSpeed(float baseSpeed, ShortArrayChromosome chromosome)
        {
            var effectiveSpeed = baseSpeed;

            var speedModifier = (-SumChromsomeValues(new List<int> { 0, 2, 4 }, chromosome) + SumChromsomeValues(new List<int> { 1, 3, 5 }, chromosome)) / (3 * ushort.MaxValue);
            speedModifier *= 1-Math.Abs(chromosome.Value[7] - halfwayMax) / halfwayMax;

            effectiveSpeed += (speedModifier/4 * maxBonus * baseSpeed);

            if (effectiveSpeed / baseSpeed > 1.1 || effectiveSpeed / baseSpeed < 0.9)
            {
                var doh = 1;
            }

            return effectiveSpeed;
        }

        private static float CalculateResistance(float baseResist, int resistIndex, ShortArrayChromosome chromosome)
        {
            var effectiveResist = baseResist;

            var resistNegatives = new List<int> {0, 1, 2, 3, 4, 5};
            resistNegatives.Remove(resistIndex);

            var resistModifier = (chromosome.Value[resistIndex] - AverageChromosomeValues(resistNegatives, chromosome)) / ushort.MaxValue;
            resistModifier *= 1-Math.Abs(AverageChromosomeValues(new List<int>() {6, 7}, chromosome) - halfwayMax) / halfwayMax;

            effectiveResist += resistModifier * maxBonus * baseResist;

            if (effectiveResist > 0.991 || effectiveResist < 0)
            {
                var doh = 1;
            }
            return effectiveResist;
        }

        private static float AverageChromosomeValues(IEnumerable<int> values, ShortArrayChromosome chromosome)
        {
            return (float)values.Average((index) => chromosome.Value[index]);
        }

        private static float SumChromsomeValues(IEnumerable<int> values, ShortArrayChromosome chromosome)
        {
            return values.Aggregate(0f, (current, index) => current + chromosome.Value[index]);
        }
    }
}
