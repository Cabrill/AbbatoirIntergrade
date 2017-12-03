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
        private enum AlienSides { Left, Right, Both};

        protected int HoursBetweenWaves = 3;
        protected int _wavesToEaseIntoDifficulty = 48;

        private AlienSides currentAlienSides;

        public abstract DateTime StartTime { get; }
        public abstract DateTime EndTime { get; } 
        public abstract float AvgDailyEnergyUsage { get; }

        protected float EnergyToSpend;

        private bool sentShip = false;
        private DateTime _lastEnemyWave;
        private DateTime _lastEnergyUpdate;
        private Layer _layerForEnemies;
        private int _wavesSent;
        protected bool HasSentBoss = false;
        
        protected FlatRedBall.Math.PositionedObjectList<BaseEnemy> _enemyList;

        protected BaseLevel(FlatRedBall.Math.PositionedObjectList<BaseEnemy> enemyList, Layer layerForEnemies)
        {
            this._layerForEnemies = layerForEnemies;
            _wavesSent = 0;
            EnergyToSpend = 0;
            _enemyList = enemyList;
            _lastEnemyWave = DateTime.MinValue;
            _lastEnergyUpdate = DateTime.MinValue;
            currentAlienSides = AlienSides.Right;
        }

        /// <summary>
        /// Decides whether the player has achieved victory.  If there is an end time this method will return true
        /// if the player has passed the end time.  For other conditions, the derived Level should override this.
        /// </summary>
        /// <param name="currentDateTime"></param>
        /// <returns></returns>
        public bool HasReachedVictory(DateTime currentDateTime)
        {
            if (EndTime != DateTime.MaxValue)
            {
                return HasSentBoss && currentDateTime >= EndTime && _enemyList.Count == 0;
            }
            return false;
        }

        /// <summary>
        /// Decides whether the player has been defeated.  All levels end when the house has been destroyed, but
        /// if there are additional defeat criteria then the derived Level should override this.
        /// </summary>
        /// <param name="currentDateTime">The current game time</param>
        /// <returns></returns>
        public bool HasReachedDefeat(DateTime currentDateTime)
        {
            return false;
        }

        /// <summary>
        /// Creates enemies equal to the energy amount
        /// </summary>
        /// <param name="energyAmount">Amount of energy to spend in creating enemies</param>
        private void CreateEnemiesFromEnergy(bool useBossMonster)
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
                _lastEnergyUpdate = currentDateTime;
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

            if (currentDateTime > _lastEnemyWave && (currentDateTime - _lastEnemyWave).Hours >= HoursBetweenWaves)
            {
                _lastEnemyWave = currentDateTime;
                sentShip = false;
                _wavesSent++;
                CreateEnemiesFromEnergy(currentDateTime.AddHours(HoursBetweenWaves) > EndTime);
                UpdateAlienSides();
            }
        }

        private void UpdateAlienSides()
        {
            switch (currentAlienSides)
            {
                case AlienSides.Left:
                    currentAlienSides = _wavesSent % 5 == 0 ? AlienSides.Both : AlienSides.Right;
                    break;
                case AlienSides.Right:
                    currentAlienSides = _wavesSent % 5 == 0 ? AlienSides.Both : AlienSides.Left;
                    break;
                default:
                    currentAlienSides = _wavesSent % 2 == 0 ? AlienSides.Left : AlienSides.Right;
                    break;
            }
        }
    }
}
