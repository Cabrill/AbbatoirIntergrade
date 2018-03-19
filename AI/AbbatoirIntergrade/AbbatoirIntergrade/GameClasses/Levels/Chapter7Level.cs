using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbbatoirIntergrade.GameClasses.BaseClasses;
using AbbatoirIntergrade.GumRuntimes;
using AbbatoirIntergrade.StaticManagers;
using AbbatoirIntergrade.UtilityClasses;

namespace AbbatoirIntergrade.GameClasses.Levels
{
    class Chapter7Level : BaseLevel
    {
        public override string MapName => "Chapter7";
        public override DateTime StartTime => new DateTime(2017, 10, 26, 3, 0, 0);
        public override int StartingLives => 30;
        public override HorizonBoxRuntime.Scenery Scenery => HorizonBoxRuntime.Scenery.Swamp;
        public override List<string> SongNameList => new List<string>() { nameof(GlobalContent.anttisinstrumentals_superiorblandcrap), nameof(GlobalContent.anttisinstrumentals_irememberyou), nameof(GlobalContent.anttisinstrumentals_inmymindiamabigstar) };

        public override string StartingDialogueDisplayName
        {
            get
            {
                var baseDialogueName = MapName + "Start";
                if (PlayerDataManager.PositiveDialoguePercent >= 0.5) baseDialogueName += "Positive";
                else if (PlayerDataManager.NegativeDialoguePercent >= 0.5) baseDialogueName += "Negative";

                return baseDialogueName;
            }
        }

        public override List<BaseWave> Waves => new List<BaseWave>() {
            new BaseWave(new EnemyList(EnemyTypes.Pig2)
            ),
            new BaseWave(new EnemyList(EnemyTypes.Sheep2, 2)),
            new BaseWave(new EnemyList(EnemyTypes.Rabbit2, 4)),
            new BaseWave(new List<SerializableTuple<int, EnemyTypes>>(){
                SerializableTuple<int, EnemyTypes>.Create(2, EnemyTypes.Pig2),
                SerializableTuple<int, EnemyTypes>.Create(4, EnemyTypes.Chicken2)
            }),
            new BaseWave(new List<SerializableTuple<int, EnemyTypes>>(){
                SerializableTuple<int, EnemyTypes>.Create(2, EnemyTypes.Cow2),
                SerializableTuple<int, EnemyTypes>.Create(4, EnemyTypes.Sheep2)
            }),
            new BaseWave(new List<SerializableTuple<int, EnemyTypes>>(){
                SerializableTuple<int, EnemyTypes>.Create(5, EnemyTypes.Chicken2),
                SerializableTuple<int, EnemyTypes>.Create(7, EnemyTypes.Sheep2)
            }),
            new BaseWave(new List<SerializableTuple<int, EnemyTypes>>(){
                SerializableTuple<int, EnemyTypes>.Create(5, EnemyTypes.Chicken2),
                SerializableTuple<int, EnemyTypes>.Create(3, EnemyTypes.Sheep2),
                SerializableTuple<int, EnemyTypes>.Create(3, EnemyTypes.Pig2)
            }),
            new BaseWave(new List<SerializableTuple<int, EnemyTypes>>(){
                SerializableTuple<int, EnemyTypes>.Create(8, EnemyTypes.Rabbit3),
            }),
        };
    }
}
