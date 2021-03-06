﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AbbatoirIntergrade.Entities.BaseEntities;
using AbbatoirIntergrade.UtilityClasses;
using FlatRedBall;

namespace AbbatoirIntergrade
{
    public enum EndingTypes
    {
        None,
        Positive,
        Neutral,
        Negative,
        Silent
    };

    public enum DamageTypes
    {
        Piercing,
        Bombarding,
        Fire,
        Frost,
        Electrical,
        Chemical
    };

    public enum EnemyTypes
    {
        Rabbit1,
        Rabbit2,
        Rabbit3,
        Sheep1,
        Sheep2,
        Sheep3,
        Cow1,
        Cow2,
        Cow3,
        Chicken1,
        Chicken2,
        Chicken3,
        Pig1,
        Pig2,
        Pig3
    };

    public enum UpgradeTypes
    {
        Range,
        Speed,
        Damage
    }

    public static class EnumExtensions
    {
        private static readonly Dictionary<EnemyTypes, double> PointValues = new Dictionary<EnemyTypes, double>();
        private static readonly Dictionary<EnemyTypes, BaseEnemy.BaseAttributes> EnemyAttributes = new Dictionary<EnemyTypes, BaseEnemy.BaseAttributes>();

        private static bool HasCalculatedMinimums;
        private static float minHealth = float.MaxValue;
        private static float minSpeed = float.MaxValue;
        private static float minPierce = float.MaxValue;
        private static float minBombard = float.MaxValue;
        private static float minChemical = float.MaxValue;
        private static float minFrost = float.MaxValue;
        private static float minFire = float.MaxValue;
        private static float minElectric = float.MaxValue;

        public static double PointValue(this EnemyTypes enemyType)
        {
            if (PointValues.ContainsKey(enemyType)) return PointValues[enemyType];
            if (!HasCalculatedMinimums) CalculateMinimums();

            var enemyAttributes = enemyType.Attributes();

            var healthPoints = enemyAttributes.Health / minHealth;
            var speedPoints = enemyAttributes.Speed / minSpeed;
            var flyingPoints = enemyAttributes.IsFlying ? 1.5 : 1;

            

            var piercePoints = enemyAttributes.PiercingResist - minPierce;
            var bombardPoints = enemyAttributes.BombardResist - minBombard;
            var chemicalPoints = enemyAttributes.ChemicalResist - minChemical;
            var frostPoints = enemyAttributes.FrostResist - minFrost;
            var firePoints = enemyAttributes.FireResist - minFire;
            var electricPoints = enemyAttributes.ElectricResist - minElectric;
            
            var resistPoints = piercePoints + bombardPoints + chemicalPoints + frostPoints + firePoints +
                                electricPoints;

            var survivalPoints = healthPoints * resistPoints;
            var movePoints = speedPoints * flyingPoints;

            var pointValue = survivalPoints * movePoints;

            PointValues.Add(enemyType, pointValue);

            return pointValue;
        }

        public static double PointValue(this EnemyTypes enemyType, SerializableChromosome chromosome)
        {
            if (!HasCalculatedMinimums) CalculateMinimums();

            var enemyAttributes = BaseEnemy.GetGeneticAttributes(enemyType.Attributes(), chromosome);

            var healthPoints = enemyAttributes.MaximumHealth / minHealth;
            var speedPoints = enemyAttributes.EffectiveSpeed / minSpeed;
            var flyingPoints = enemyAttributes.IsFlying ? 1.5 : 1;

            var piercePoints = enemyAttributes.EffectivePiercingResist - minPierce;
            var bombardPoints = enemyAttributes.EffectiveBombardResist - minBombard;
            var chemicalPoints = enemyAttributes.EffectiveChemicalResist - minChemical;
            var frostPoints = enemyAttributes.EffectiveFrostResist - minFrost;
            var firePoints = enemyAttributes.EffectiveFireResist - minFire;
            var electricPoints = enemyAttributes.EffectiveElectricResist - minElectric;

            var resistPoints = piercePoints + bombardPoints + chemicalPoints + frostPoints + firePoints +
                               electricPoints;

            var survivalPoints = healthPoints * resistPoints;
            var movePoints = speedPoints * flyingPoints;

            var pointValue = survivalPoints * movePoints;

            return pointValue;
        }

        public static double PointValue(this BaseEnemy enemy)
        {
            if (!HasCalculatedMinimums) CalculateMinimums();

            var enemyAttributes = BaseEnemy.GetGeneticAttributes(enemy.GetBaseAttributes(), enemy.Chromosome);

            var healthPoints = enemyAttributes.MaximumHealth / minHealth;
            var speedPoints = enemyAttributes.EffectiveSpeed / minSpeed;
            var flyingPoints = enemyAttributes.IsFlying ? 1.5 : 1;

            var piercePoints = enemyAttributes.EffectivePiercingResist - minPierce;
            var bombardPoints = enemyAttributes.EffectiveBombardResist - minBombard;
            var chemicalPoints = enemyAttributes.EffectiveChemicalResist - minChemical;
            var frostPoints = enemyAttributes.EffectiveFrostResist - minFrost;
            var firePoints = enemyAttributes.EffectiveFireResist - minFire;
            var electricPoints = enemyAttributes.EffectiveElectricResist - minElectric;

            var resistPoints = piercePoints + bombardPoints + chemicalPoints + frostPoints + firePoints +
                               electricPoints;

            var survivalPoints = healthPoints * resistPoints;
            var movePoints = speedPoints * flyingPoints;

            var pointValue = survivalPoints * movePoints;

            return pointValue;
        }

        private static void CalculateMinimums()
        {
            foreach (var enemyAttributes in GlobalContent.Enemy_Attributes.Values)
            {
                minHealth = (enemyAttributes.Health < minHealth ? enemyAttributes.Health : minHealth);
                minSpeed = (enemyAttributes.Speed < minSpeed ? enemyAttributes.Speed : minSpeed);
                minPierce = (enemyAttributes.PiercingResist < minPierce ? enemyAttributes.PiercingResist : minPierce);
                minBombard = (enemyAttributes.BombardResist < minBombard ? enemyAttributes.BombardResist : minBombard);
                minChemical = (enemyAttributes.ChemicalResist < minChemical ? enemyAttributes.ChemicalResist : minChemical);
                minFrost = (enemyAttributes.FrostResist < minFrost ? enemyAttributes.FrostResist : minFrost);
                minFire = (enemyAttributes.FireResist < minFire ? enemyAttributes.FireResist : minFire);
                minElectric = (enemyAttributes.ElectricResist < minElectric ? enemyAttributes.ElectricResist : minElectric);
            }

            HasCalculatedMinimums = true;
        }

        public static BaseEnemy.BaseAttributes Attributes(this EnemyTypes enemyType)
        {
            if (EnemyAttributes.ContainsKey(enemyType)) return EnemyAttributes[enemyType];

            var enemyName = enemyType.ToString();
            var csvEntry = GlobalContent.Enemy_Attributes[enemyName];

            var enemyAttributes = new BaseEnemy.BaseAttributes()
            {
                Health = csvEntry.Health,
                Speed = csvEntry.Speed,

                BombardResist = csvEntry.BombardResist,
                PiercingResist = csvEntry.PiercingResist,
                ChemicalResist = csvEntry.ChemicalResist,
                FrostResist = csvEntry.FrostResist,
                FireResist = csvEntry.FireResist,
                ElectricResist = csvEntry.ElectricResist,
            };

            EnemyAttributes[enemyType] = enemyAttributes;

            return enemyAttributes;
        }

        public static void Shuffle<T>(this IList<T> list)
        {
            var n = list.Count;
            while (n > 1)
            {
                n--;
                var k = FlatRedBallServices.Random.Next(n + 1);
                var value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
