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
    class Chapter6Level : BaseLevel
    {
        public override string MapName => "Chapter6";
        public override DateTime StartTime => new DateTime(2017, 10, 26, 21, 0, 0);
        public override int StartingLives => 30;
        public override HorizonBoxRuntime.Scenery Scenery => HorizonBoxRuntime.Scenery.RedMountains;
        public override List<string> SongNameList => new List<string>() { nameof(GlobalContent.anttisinstrumentals_alittlebell), nameof(GlobalContent.anttisinstrumentals_brokentimesiqnatureinaminor), nameof(GlobalContent.anttisinstrumentals_irememberyou) };

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
            new BaseWave(new EnemyList(EnemyTypes.Sheep2)
            ),
            new BaseWave(new EnemyList(EnemyTypes.Rabbit2, 2)),
            new BaseWave(new EnemyList(EnemyTypes.Pig2, 3)),
            new BaseWave(new List<SerializableTuple<int, EnemyTypes>>(){
                SerializableTuple<int, EnemyTypes>.Create(3, EnemyTypes.Cow2),
                SerializableTuple<int, EnemyTypes>.Create(2, EnemyTypes.Chicken2)
            }),
            new BaseWave(new List<SerializableTuple<int, EnemyTypes>>(){
                SerializableTuple<int, EnemyTypes>.Create(6, EnemyTypes.Rabbit2),
                SerializableTuple<int, EnemyTypes>.Create(3, EnemyTypes.Pig2)
            }),
            new BaseWave(new List<SerializableTuple<int, EnemyTypes>>(){
                SerializableTuple<int, EnemyTypes>.Create(6, EnemyTypes.Chicken2),
                SerializableTuple<int, EnemyTypes>.Create(2, EnemyTypes.Rabbit2),
                SerializableTuple<int, EnemyTypes>.Create(2, EnemyTypes.Sheep2),
                SerializableTuple<int, EnemyTypes>.Create(2, EnemyTypes.Pig2),
                SerializableTuple<int, EnemyTypes>.Create(1, EnemyTypes.Cow2),
            }),
        };
    }
}
