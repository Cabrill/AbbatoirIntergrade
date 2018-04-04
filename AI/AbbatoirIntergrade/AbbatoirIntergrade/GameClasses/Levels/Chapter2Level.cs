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
    class Chapter2Level : BaseLevel
    {
        public override int LevelNumber => 2;
        public override string MapName => "Chapter2";
        public override string LocationName => "Binedah Swamp";
        public override DateTime StartTime => new DateTime(2017, 10, 23, 12, 0, 0);
        public override int StartingLives => 35;
        public override int WavesToSurvive => 15;
        public override int StartingSatoshis => 15;
        public override HorizonBoxRuntime.Scenery Scenery => HorizonBoxRuntime.Scenery.Swamp;
        public override List<string> SongNameList => new List<string>() { nameof(GlobalContent.anttisinstrumentals_scrambledeggs), nameof(GlobalContent.anttisinstrumentals_sidish), nameof(GlobalContent.anttisinstrumentals_justafaceinthedarkinstrumental) };

        public override List<BaseWave> Waves => new List<BaseWave>() {
            new BaseWave(new EnemyList(EnemyTypes.Sheep1, 3)),
            new BaseWave(new List<SerializableTuple<int, EnemyTypes>>(){
                SerializableTuple<int, EnemyTypes>.Create(3, EnemyTypes.Rabbit1),
                SerializableTuple<int, EnemyTypes>.Create(3, EnemyTypes.Sheep1),
            }),
            new BaseWave(new EnemyList(EnemyTypes.Cow1, 4)
            ),
            new BaseWave(new List<SerializableTuple<int, EnemyTypes>>(){
                SerializableTuple<int, EnemyTypes>.Create(5, EnemyTypes.Rabbit1),
                SerializableTuple<int, EnemyTypes>.Create(3, EnemyTypes.Sheep1),
                SerializableTuple<int, EnemyTypes>.Create(3, EnemyTypes.Cow1),
            }),
            new BaseWave(new List<SerializableTuple<int, EnemyTypes>>(){
                SerializableTuple<int, EnemyTypes>.Create(6, EnemyTypes.Chicken1),
                SerializableTuple<int, EnemyTypes>.Create(6, EnemyTypes.Rabbit1),
                SerializableTuple<int, EnemyTypes>.Create(3, EnemyTypes.Sheep1),
                SerializableTuple<int, EnemyTypes>.Create(1, EnemyTypes.Cow1),
                SerializableTuple<int, EnemyTypes>.Create(2, EnemyTypes.Pig1)
            }),
            new BaseWave(new List<SerializableTuple<int, EnemyTypes>>(){
                SerializableTuple<int, EnemyTypes>.Create(8, EnemyTypes.Chicken1),
                SerializableTuple<int, EnemyTypes>.Create(8, EnemyTypes.Rabbit1),
                SerializableTuple<int, EnemyTypes>.Create(4, EnemyTypes.Sheep1),
                SerializableTuple<int, EnemyTypes>.Create(2, EnemyTypes.Cow1),
                SerializableTuple<int, EnemyTypes>.Create(1, EnemyTypes.Pig1)
            }),
        };
    }
}
