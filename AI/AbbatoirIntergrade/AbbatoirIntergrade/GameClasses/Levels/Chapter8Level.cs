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
    class Chapter8Level : BaseLevel
    {
        public override int LevelNumber => 8;
        public override string MapName => "Chapter8";
        public override string LocationName => "Overton Keep";
        public override DateTime StartTime => new DateTime(2017, 10, 28, 15, 0, 0);
        public override int StartingLives => 40;
        public override int WavesToSurvive => 20;
        public override int StartingSatoshis => 40;
        public override HorizonBoxRuntime.Scenery Scenery => HorizonBoxRuntime.Scenery.SparseTrees;
        public override List<string> SongNameList => new List<string>() { nameof(GlobalContent.anttisinstrumentals_digitalconcertoremake), nameof(GlobalContent.anttisinstrumentals_inmymindiamabigstar), nameof(GlobalContent.anttisinstrumentals_melancholysound) };

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
            new BaseWave(new EnemyList(EnemyTypes.Pig3, 1)
            ),
            new BaseWave(new List<SerializableTuple<int, EnemyTypes>>(){
                SerializableTuple<int, EnemyTypes>.Create(2, EnemyTypes.Rabbit3),
                SerializableTuple<int, EnemyTypes>.Create(1, EnemyTypes.Chicken2)
            }),
            new BaseWave(new List<SerializableTuple<int, EnemyTypes>>(){
                SerializableTuple<int, EnemyTypes>.Create(2, EnemyTypes.Chicken2),
                SerializableTuple<int, EnemyTypes>.Create(2, EnemyTypes.Sheep3)
            }),
            new BaseWave(new List<SerializableTuple<int, EnemyTypes>>(){
                SerializableTuple<int, EnemyTypes>.Create(3, EnemyTypes.Chicken2),
                SerializableTuple<int, EnemyTypes>.Create(3, EnemyTypes.Cow3)
            }),
            new BaseWave(new EnemyList(EnemyTypes.Rabbit3,4)),
            new BaseWave(new List<SerializableTuple<int, EnemyTypes>>(){
                SerializableTuple<int, EnemyTypes>.Create(5, EnemyTypes.Chicken2),
                SerializableTuple<int, EnemyTypes>.Create(2, EnemyTypes.Rabbit3),
                SerializableTuple<int, EnemyTypes>.Create(2, EnemyTypes.Sheep3),
                SerializableTuple<int, EnemyTypes>.Create(1, EnemyTypes.Cow3)
            }),
            new BaseWave(new List<SerializableTuple<int, EnemyTypes>>(){
                SerializableTuple<int, EnemyTypes>.Create(6, EnemyTypes.Chicken2),
                SerializableTuple<int, EnemyTypes>.Create(3, EnemyTypes.Rabbit3),
                SerializableTuple<int, EnemyTypes>.Create(2, EnemyTypes.Sheep3),
                SerializableTuple<int, EnemyTypes>.Create(2, EnemyTypes.Cow3),
                SerializableTuple<int, EnemyTypes>.Create(2, EnemyTypes.Pig2)
            }),
        };
    }
}
