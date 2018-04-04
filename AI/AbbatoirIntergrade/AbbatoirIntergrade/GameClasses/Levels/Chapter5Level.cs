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
    class Chapter5Level : BaseLevel
    {
        public override int LevelNumber => 5;
        public override string MapName => "Chapter5";
        public override string LocationName => "Highpass Outpost";
        public override DateTime StartTime => new DateTime(2017, 10, 25, 21, 0, 0);
        public override int StartingLives => 30;
        public override int WavesToSurvive => 15;
        public override int StartingSatoshis => 30;
        public override HorizonBoxRuntime.Scenery Scenery => HorizonBoxRuntime.Scenery.Desert;
        public override List<string> SongNameList => new List<string>() { nameof(GlobalContent.anttisinstrumentals_quietlyintothenight), nameof(GlobalContent.anttisinstrumentals_fiveminutesofwhy), nameof(GlobalContent.anttisinstrumentals_brokentimesiqnatureinaminor) };

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
            new BaseWave(new EnemyList(EnemyTypes.Pig2, 3)
            ),
            new BaseWave(new List<SerializableTuple<int, EnemyTypes>>(){
                SerializableTuple<int, EnemyTypes>.Create(3, EnemyTypes.Pig2),
                SerializableTuple<int, EnemyTypes>.Create(2, EnemyTypes.Chicken2)
            }),
            new BaseWave(new List<SerializableTuple<int, EnemyTypes>>(){
                SerializableTuple<int, EnemyTypes>.Create(3, EnemyTypes.Chicken2),
                SerializableTuple<int, EnemyTypes>.Create(4, EnemyTypes.Rabbit2)
            }),
            new BaseWave(new EnemyList(EnemyTypes.Rabbit2, 6)),
            new BaseWave(new List<SerializableTuple<int, EnemyTypes>>(){
                SerializableTuple<int, EnemyTypes>.Create(4, EnemyTypes.Rabbit2),
                SerializableTuple<int, EnemyTypes>.Create(5, EnemyTypes.Chicken2)
            }),
            new BaseWave(new EnemyList(EnemyTypes.Sheep2, 8)),
            new BaseWave(new List<SerializableTuple<int, EnemyTypes>>(){
                SerializableTuple<int, EnemyTypes>.Create(5, EnemyTypes.Rabbit2),
                SerializableTuple<int, EnemyTypes>.Create(5, EnemyTypes.Sheep2)
            }),
            new BaseWave(new List<SerializableTuple<int, EnemyTypes>>(){
                SerializableTuple<int, EnemyTypes>.Create(3, EnemyTypes.Rabbit2),
                SerializableTuple<int, EnemyTypes>.Create(5, EnemyTypes.Sheep2),
                SerializableTuple<int, EnemyTypes>.Create(5, EnemyTypes.Pig2)
            }),
        };
    }
}
