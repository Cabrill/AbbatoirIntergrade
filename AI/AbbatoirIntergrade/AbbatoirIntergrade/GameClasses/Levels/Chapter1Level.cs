﻿using System;
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

namespace AbbatoirIntergrade.GameClasses.Levels
{
    class Chapter1Level : BaseLevel
    {
        public override string MapName => "Chapter1";
        public override DateTime StartTime => new DateTime(2017, 10, 21, 6, 0, 0);
        public override int StartingLives => 30;
        public override List<BaseWave> Waves { get; }

        public override List<EnemyTypes> AvailableEnemyTypes => new List<EnemyTypes>() { EnemyTypes.Rabbit1 };
    }
}
