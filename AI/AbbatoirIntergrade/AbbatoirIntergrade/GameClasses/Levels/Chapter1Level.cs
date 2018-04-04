using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlatRedBall.Graphics;
using AbbatoirIntergrade.Entities.BaseEntities;
using AbbatoirIntergrade.Entities.Enemies;
using AbbatoirIntergrade.GameClasses.BaseClasses;
using AbbatoirIntergrade.GameClasses.Interfaces;
using AbbatoirIntergrade.GumRuntimes;
using AbbatoirIntergrade.UtilityClasses;

namespace AbbatoirIntergrade.GameClasses.Levels
{
    class Chapter1Level : BaseLevel
    {
        public override int LevelNumber => 1;
        public override string MapName => "Chapter1";
        public override string LocationName => "Nixeuy Farm";
        public override DateTime StartTime => new DateTime(2238, 10, 21, 4, 11, 0);
        public override int StartingLives => 20;
        public override int StartingSatoshis => 15;
        public override HorizonBoxRuntime.Scenery Scenery => HorizonBoxRuntime.Scenery.SparseTrees;
        public override List<string> SongNameList => new List<string>() {nameof(GlobalContent.Zach_Darshon_Sea_of_Dead_Thoughts), nameof(GlobalContent.anttisinstrumentals_badmorning), nameof(GlobalContent.anttisinstrumentals_woman), nameof(GlobalContent.anttisinstrumentals_sidish) };
        public override int WavesToSurvive => 10;

        public override List<BaseWave> Waves => new List<BaseWave>() { 
            new BaseWave(new EnemyList(EnemyTypes.Chicken1, 2)),
            new BaseWave(new EnemyList(EnemyTypes.Rabbit1, 2)),
            new BaseWave(new List<SerializableTuple<int, EnemyTypes>>(){
                SerializableTuple<int, EnemyTypes>.Create(1, EnemyTypes.Rabbit1),
                SerializableTuple<int, EnemyTypes>.Create(2, EnemyTypes.Chicken1)
            }),
            new BaseWave(new EnemyList(EnemyTypes.Rabbit1, 4)),
            new BaseWave(new List<SerializableTuple<int, EnemyTypes>>(){
                SerializableTuple<int, EnemyTypes>.Create(3, EnemyTypes.Rabbit1),
                SerializableTuple<int, EnemyTypes>.Create(3, EnemyTypes.Chicken1)
            }),
            new BaseWave(new List<SerializableTuple<int, EnemyTypes>>(){
                SerializableTuple<int, EnemyTypes>.Create(4, EnemyTypes.Chicken1),
                SerializableTuple<int, EnemyTypes>.Create(2, EnemyTypes.Sheep1)
            }),
            new BaseWave(new List<SerializableTuple<int, EnemyTypes>>(){
                SerializableTuple<int, EnemyTypes>.Create(4, EnemyTypes.Rabbit1),
                SerializableTuple<int, EnemyTypes>.Create(4, EnemyTypes.Sheep1)
            }),
            new BaseWave(new List<SerializableTuple<int, EnemyTypes>>(){
                SerializableTuple<int, EnemyTypes>.Create(4, EnemyTypes.Chicken1),
                SerializableTuple<int, EnemyTypes>.Create(5, EnemyTypes.Sheep1),
                SerializableTuple<int, EnemyTypes>.Create(4, EnemyTypes.Rabbit1)
            }),
            new BaseWave(new List<SerializableTuple<int, EnemyTypes>>(){
                SerializableTuple<int, EnemyTypes>.Create(5, EnemyTypes.Chicken1),
                SerializableTuple<int, EnemyTypes>.Create(8, EnemyTypes.Sheep1),
                SerializableTuple<int, EnemyTypes>.Create(5, EnemyTypes.Rabbit1)
            }),
            new BaseWave(new List<SerializableTuple<int, EnemyTypes>>(){
                SerializableTuple<int, EnemyTypes>.Create(8, EnemyTypes.Chicken1),
                SerializableTuple<int, EnemyTypes>.Create(8, EnemyTypes.Sheep1),
                SerializableTuple<int, EnemyTypes>.Create(8, EnemyTypes.Rabbit1)
            }),
            new BaseWave(new List<SerializableTuple<int, EnemyTypes>>(){
                SerializableTuple<int, EnemyTypes>.Create(8, EnemyTypes.Chicken1),
                SerializableTuple<int, EnemyTypes>.Create(10, EnemyTypes.Sheep1),
                SerializableTuple<int, EnemyTypes>.Create(8, EnemyTypes.Rabbit1)
            }),
            new BaseWave(new List<SerializableTuple<int, EnemyTypes>>(){
                SerializableTuple<int, EnemyTypes>.Create(12, EnemyTypes.Chicken1),
                SerializableTuple<int, EnemyTypes>.Create(12, EnemyTypes.Sheep1),
            }),
        };
    }
}
