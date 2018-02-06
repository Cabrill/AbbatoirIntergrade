using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using FlatRedBall.Graphics;
using AbbatoirIntergrade.Entities.BaseEntities;
using AbbatoirIntergrade.Factories;
using AbbatoirIntergrade.GameClasses.Interfaces;
using AbbatoirIntergrade.GumRuntimes;
using AbbatoirIntergrade.StaticManagers;
using FlatRedBall;
using FlatRedBall.Instructions;
using FlatRedBall.TileGraphics;

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
        public LevelResult LevelResults;

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
            LevelResults = CreateResults();
        }

        public void SetEnemiesAndLayer(FlatRedBall.Math.PositionedObjectList<BaseEnemy> enemyList)
        {
            _enemyList = enemyList;
        }
        
        public bool HasReachedDefeat()
        {
            return RemainingLives <= 0;
        }

        public void Update()
        {
            if (!_waveHasEnded && _enemyList.Count == 0)
            {
                _waveHasEnded = true;
                OnWaveEnd?.Invoke(this, null);
            }

            if (!IsReadyForNextWave) return;

            if (!_lastEnemyWaveTime.HasValue || (TimeManager.SecondsSince(_lastEnemyWaveTime.Value) >= SecondsBetweenWaves && _enemyList.Count == 0))
            {
                StartCreatingEnemiesForWave();
            }
        }

        private void InstructEnemiesToReportDeaths()
        {
            foreach (var enemy in _enemyList)
            {
                enemy.OnDeath += ReportDeath;
            }
        }

        private void ReportDeath(BaseEnemy enemy)
        {
            LevelResults.EnemiesDefeated.Add(enemy.GetEnemyType());
        }

        private void StartCreatingEnemiesForWave()
        {
            Action actionToRun = () =>
            {
                var currentWave = CurrentWaveNumber < Waves.Count ? Waves[CurrentWaveNumber] : GenerateWave();

                Action stuffToDoOnPrimaryThread = () => FinishCreatingEnemiesForWave(currentWave);
                InstructionManager.AddSafe(stuffToDoOnPrimaryThread);
            };

            var threadStart = new ThreadStart(actionToRun);
            var thread = new Thread(threadStart);
            thread.Start();
        }

        private void FinishCreatingEnemiesForWave(BaseWave currentWave)
        {
            currentWave.CreateEnemies();

            CurrentWaveNumber++;

            LastWave = currentWave;
            _lastEnemyWaveTime = TimeManager.CurrentTime;

            InstructEnemiesToReportDeaths();
            OnNewWaveStart?.Invoke(this, null);
            IsReadyForNextWave = false;
            _waveHasEnded = false;
        }

        private BaseWave GenerateWave()
        {
            var pointsAvailable = Waves.Last().PointValue + (CurrentWaveNumber - Waves.Count);
            var generatedWave = MachineLearningManager.GenerateWave(AvailableEnemyTypes, pointsAvailable);

            return generatedWave;
        }

        public LevelResult GetFinalResults()
        {
            LevelResults.DateTimeFinished = DateTime.Now;
            LevelResults.WavesCompleted = CurrentWaveNumber;
            return LevelResults;
        }

        private LevelResult CreateResults()
        {
            var levelNumberString = Regex.Replace(MapName, "[^0-9.]", "");
            int.TryParse(levelNumberString, out int levelNumber);
            var levelResult = new LevelResult
            {
                LevelName = MapName,
                LevelNumber = levelNumber,
                DateTimeStarted = DateTime.Now,
            };

            return levelResult;
        }
    }
}
