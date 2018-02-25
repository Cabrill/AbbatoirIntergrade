using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbbatoirIntergrade.GameClasses.BaseClasses;
using AbbatoirIntergrade.GumRuntimes;
using AbbatoirIntergrade.UtilityClasses;

namespace AbbatoirIntergrade.GameClasses.Levels
{
    class Chapter4Level : BaseLevel
    {
        public override string MapName => "Chapter4";
        public override DateTime StartTime => new DateTime(2017, 10, 24, 5, 0, 0);
        public override int StartingLives => 30;
        public override HorizonBoxRuntime.Scenery Scenery => HorizonBoxRuntime.Scenery.ForestedHills;
        public override List<string> SongNameList => new List<string>() { nameof(GlobalContent.anttisinstrumentals_badmorning), nameof(GlobalContent.anttisinstrumentals_woman) };

        public override List<BaseWave> Waves => new List<BaseWave>() {
            new BaseWave(new EnemyList(EnemyTypes.Pig1)
            ),
            new BaseWave(new EnemyList(EnemyTypes.Sheep1, 3)),
            new BaseWave(new EnemyList(EnemyTypes.Rabbit1, 5)),
            new BaseWave(new List<SerializableTuple<int, EnemyTypes>>(){
                SerializableTuple<int, EnemyTypes>.Create(4, EnemyTypes.Pig1),
                SerializableTuple<int, EnemyTypes>.Create(4, EnemyTypes.Chicken1)
            }),
            new BaseWave(new List<SerializableTuple<int, EnemyTypes>>(){
                SerializableTuple<int, EnemyTypes>.Create(3, EnemyTypes.Rabbit1),
                SerializableTuple<int, EnemyTypes>.Create(8, EnemyTypes.Sheep1)
            }),
            new BaseWave(new List<SerializableTuple<int, EnemyTypes>>(){
                SerializableTuple<int, EnemyTypes>.Create(5, EnemyTypes.Chicken1),
                SerializableTuple<int, EnemyTypes>.Create(7, EnemyTypes.Sheep1)
            }),
            new BaseWave(new List<SerializableTuple<int, EnemyTypes>>(){
                SerializableTuple<int, EnemyTypes>.Create(5, EnemyTypes.Chicken1),
                SerializableTuple<int, EnemyTypes>.Create(7, EnemyTypes.Sheep1),
                SerializableTuple<int, EnemyTypes>.Create(3, EnemyTypes.Pig1)
            }),
            new BaseWave(new List<SerializableTuple<int, EnemyTypes>>(){
                SerializableTuple<int, EnemyTypes>.Create(5, EnemyTypes.Chicken1),
                SerializableTuple<int, EnemyTypes>.Create(5, EnemyTypes.Rabbit1),
                SerializableTuple<int, EnemyTypes>.Create(3, EnemyTypes.Sheep1),
                SerializableTuple<int, EnemyTypes>.Create(1, EnemyTypes.Cow1)
            }),
            new BaseWave(new List<SerializableTuple<int, EnemyTypes>>(){
                SerializableTuple<int, EnemyTypes>.Create(6, EnemyTypes.Chicken1),
                SerializableTuple<int, EnemyTypes>.Create(6, EnemyTypes.Rabbit1),
                SerializableTuple<int, EnemyTypes>.Create(3, EnemyTypes.Sheep1),
                SerializableTuple<int, EnemyTypes>.Create(1, EnemyTypes.Cow1),
                SerializableTuple<int, EnemyTypes>.Create(2, EnemyTypes.Pig1)
            }),
        };
    }
}
