using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbbatoirIntergrade.Entities.BaseEntities;

namespace AbbatoirIntergrade
{
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

    public static class EnumExtensions
    {
        public static int PointValue(this EnemyTypes enemyType)
        {
            var pointValue = 0;
            int.TryParse(enemyType.ToString(), out pointValue);

            return pointValue;
        }
    }
}
