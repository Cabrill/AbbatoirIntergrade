using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlatRedBall.Graphics;
using AbbatoirIntergrade.Entities.BaseEntities;
using AbbatoirIntergrade.Factories;
using AbbatoirIntergrade.GameClasses.Interfaces;
using AbbatoirIntergrade.GumRuntimes;
using AbbatoirIntergrade.StaticManagers;

namespace AbbatoirIntergrade.GameClasses.BaseClasses
{
    public abstract class BaseLevel
    {
        public abstract DateTime StartTime { get; }
        public abstract List<BaseWave> Waves { get; }

        public virtual int StartingLives { get; } = 1;

        public int RemainingLives { get; set; }

        private DateTime _lastEnemyWave;
        private Layer _layerForEnemies;
        private int _wavesSent;
        
        protected FlatRedBall.Math.PositionedObjectList<BaseEnemy> _enemyList;

        protected BaseLevel(FlatRedBall.Math.PositionedObjectList<BaseEnemy> enemyList, Layer layerForEnemies)
        {
            this._layerForEnemies = layerForEnemies;
            _wavesSent = 0;
            _enemyList = enemyList;
            _lastEnemyWave = DateTime.MinValue;
            RemainingLives = StartingLives;
        }
        
        /// <summary>
        /// Decides whether the player has been defeated.  All levels end when the house has been destroyed, but
        /// if there are additional defeat criteria then the derived Level should override this.
        /// </summary>
        /// <param name="currentDateTime">The current game time</param>
        /// <returns></returns>
        public bool HasReachedDefeat()
        {
            return RemainingLives <= 0;
        }

        /// <summary>
        /// Creates enemies equal to the energy amount
        /// </summary>
        /// <param name="energyAmount">Amount of energy to spend in creating enemies</param>
        private void CreateEnemiesForWave()
        {
            //if (EnergyToSpend < GameFormulas.Instance.MinimumEnergyCostForAnEnemy) return;

            //var leftRightToggle = 1;
            //while (EnergyToSpend >= GameFormulas.Instance.MinimumEnergyCostForAnEnemy)
            //{
            //    var newEnemy = GameFormulas.Instance.StrongestAffordableEnemy(ref EnergyToSpend, useBossMonster, _layerForEnemies);

            //    if (currentAlienSides == AlienSides.Right || (currentAlienSides == AlienSides.Both && leftRightToggle > 0))
            //    { 
            //        newEnemy?.PlaceOnRightSide();
            //    }
            //    else if (currentAlienSides == AlienSides.Left || (currentAlienSides == AlienSides.Both && leftRightToggle < 0))
            //    {
            //        newEnemy?.PlaceOnLeftSide();
            //    }
            //    if (useBossMonster) HasSentBoss = true;
            //    leftRightToggle *= -1;
            //}
        }

        public void Update(DateTime currentDateTime)
        {
            if (_lastEnemyWave == DateTime.MinValue)
            {
                _lastEnemyWave = currentDateTime;
            }

            //if (currentDateTime > _lastEnergyUpdate && (currentDateTime - _lastEnergyUpdate).Hours >= 1 && currentDateTime <= EndTime)
            //{
            //    var energyToSpend = 0f;

            //    var wavesModifier = 1f;
            //    if (_wavesSent < _wavesToEaseIntoDifficulty)
            //    {
            //        wavesModifier = (float) _wavesSent / _wavesToEaseIntoDifficulty;
            //    }

            //    energyToSpend = wavesModifier *
            //                    GameFormulas.Instance.HourlyEnergyUsageFromCurveAndAvgValue(currentDateTime.Hour,
            //                        AvgDailyEnergyUsage);

            //    EnergyToSpend += energyToSpend;
            //    _lastEnergyUpdate = currentDateTime;
            //}

            if (currentDateTime > _lastEnemyWave)
            {
                _lastEnemyWave = currentDateTime;
                _wavesSent++;
            }
        }
    }
}
