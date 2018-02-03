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
using FlatRedBall;

namespace AbbatoirIntergrade.GameClasses.BaseClasses
{
    public abstract class BaseLevel
    {
        public abstract string MapName { get; }
        public abstract DateTime StartTime { get; }
        public abstract List<BaseWave> Waves { get; }
        public abstract List<string> SongNameList { get;  }
        private List<BaseWave> _waves;
        public BaseWave LastWave;
        public int CurrentWaveNumber { get; private set; } = 0;

        public virtual int StartingLives { get; } = 1;

        protected double SecondsBetweenWaves = 0;

        private List<EnemyTypes> _availableEnemyTypes;

        public virtual List<EnemyTypes> AvailableEnemyTypes
        {
            get
            {
                if (_availableEnemyTypes == null)
                {
                    _availableEnemyTypes = Waves.SelectMany(w => w.EnemyTypes).Distinct().ToList();
                }
                return _availableEnemyTypes;
            }
        }

        public int RemainingLives { get; set; }

        public EventHandler OnNewWaveStart;
        public EventHandler OnWaveEnd;
        private bool _waveHasEnded = false;
        public bool IsReadyForNextWave { get; set; } = false;

        private double? _lastEnemyWaveTime;

        protected FlatRedBall.Math.PositionedObjectList<BaseEnemy> _enemyList;

        protected BaseLevel()
        {
            RemainingLives = StartingLives;
            _waveHasEnded = true;
        }

        public void SetEnemiesAndLayer(FlatRedBall.Math.PositionedObjectList<BaseEnemy> enemyList)
        {
            _enemyList = enemyList;
        }
        
        public bool HasReachedDefeat()
        {
            return RemainingLives <= 0;
        }

        private void CreateEnemiesForWave()
        {
            var currentWave = CurrentWaveNumber < Waves.Count ? Waves[CurrentWaveNumber] : GenerateWave();
            currentWave.CreateEnemies();
            
            CurrentWaveNumber++;

            LastWave = currentWave;
            _lastEnemyWaveTime = TimeManager.CurrentTime;
        }

        public void Update()
        {
            if (!_waveHasEnded && _enemyList.Count == 0)
            {
                _waveHasEnded = true;
                OnWaveEnd?.Invoke(this, null);
            }

            if (IsReadyForNextWave)
            {
                if (!_lastEnemyWaveTime.HasValue)
                {
                    CreateEnemiesForWave();
                }
                else if (TimeManager.SecondsSince(_lastEnemyWaveTime.Value) >= SecondsBetweenWaves &&
                         _enemyList.Count == 0)
                {
                    CreateEnemiesForWave();
                }
                OnNewWaveStart?.Invoke(this, null);
                IsReadyForNextWave = false;
                _waveHasEnded = false;
            }
        }

        private BaseWave GenerateWave()
        {
            //TODO:  AI generates wave using point system
            var pointsAvailable = Waves.Last().PointValue + (CurrentWaveNumber - Waves.Count);
            var generatedWave = MachineLearningManager.GenerateWave(AvailableEnemyTypes, pointsAvailable);

            return generatedWave;
        }
    }
}
