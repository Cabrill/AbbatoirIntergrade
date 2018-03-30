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
    class Chapter10Level : BaseLevel
    {
        public override string MapName => "Chapter10";
        public override string LocationName => "Pilgrim Point";
        public override DateTime StartTime => new DateTime(2017, 10, 30, 5, 0, 0);
        public override int StartingLives => 982;
        public override int WavesToSurvive => 999;
        public override HorizonBoxRuntime.Scenery Scenery => HorizonBoxRuntime.Scenery.City;
        public override List<string> SongNameList => new List<string>() { nameof(GlobalContent.anttisinstrumentals_alieninhochiminh), nameof(GlobalContent.anttisinstrumentals_marchoftheages) };

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
            new BaseWave(new EnemyList(EnemyTypes.Cow3,3)
            ),
            new BaseWave(new List<SerializableTuple<int, EnemyTypes>>(){
                SerializableTuple<int, EnemyTypes>.Create(4, EnemyTypes.Pig3),
                SerializableTuple<int, EnemyTypes>.Create(2, EnemyTypes.Chicken3)
            }),
            new BaseWave(new List<SerializableTuple<int, EnemyTypes>>(){
                SerializableTuple<int, EnemyTypes>.Create(3, EnemyTypes.Chicken3),
                SerializableTuple<int, EnemyTypes>.Create(2, EnemyTypes.Rabbit3),
                SerializableTuple<int, EnemyTypes>.Create(2, EnemyTypes.Sheep3),
                SerializableTuple<int, EnemyTypes>.Create(1, EnemyTypes.Cow3)
            }),
            new BaseWave(new List<SerializableTuple<int, EnemyTypes>>(){
                SerializableTuple<int, EnemyTypes>.Create(4, EnemyTypes.Chicken3),
                SerializableTuple<int, EnemyTypes>.Create(3, EnemyTypes.Rabbit3),
                SerializableTuple<int, EnemyTypes>.Create(3, EnemyTypes.Sheep3),
                SerializableTuple<int, EnemyTypes>.Create(3, EnemyTypes.Cow3),
                SerializableTuple<int, EnemyTypes>.Create(2, EnemyTypes.Pig3)
            }),
        };
    }
}
