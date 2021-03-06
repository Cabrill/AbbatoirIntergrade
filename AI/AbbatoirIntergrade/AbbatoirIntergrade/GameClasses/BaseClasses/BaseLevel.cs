﻿using System;
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
using Accord.IO;
using FlatRedBall;
using FlatRedBall.Instructions;
using FlatRedBall.TileGraphics;

namespace AbbatoirIntergrade.GameClasses.BaseClasses
{
    public abstract class BaseLevel
    {
        public abstract int LevelNumber { get; }
        public abstract string MapName { get; }
        public abstract string LocationName { get; }
        public abstract DateTime StartTime { get; }
        public abstract List<BaseWave> Waves { get; }
        public abstract List<string> SongNameList { get;  }
        private List<BaseWave> _waves;
        public BaseWave LastWave;
        public abstract int WavesToSurvive { get; }
        public int CurrentWaveNumber { get; private set; } = 0;
        public LevelResult LevelResults;

        public virtual int StartingLives { get; } = 1;
        public virtual int StartingSatoshis { get; } = 10;
        
        public abstract HorizonBoxRuntime.Scenery Scenery { get; }

        private double SecondsBetweenWaves = 0;

        public virtual string StartingDialogueDisplayName => MapName + "Start";

        private List<EnemyTypes> _availableEnemyTypes;

        public List<EnemyTypes> AvailableEnemyTypes
        {
            get
            {
                if (_availableEnemyTypes == null)
                {
                    if (PlayerDataManager.PlayerHasBeatGame)
                    {
                        _availableEnemyTypes = new List<EnemyTypes>();
                        var allenemyTypes = Enum.GetValues(typeof(EnemyTypes)).Cast<EnemyTypes>().ToList();
                        for (var i = 0; i < 5; i++)
                        {
                            var randomEnemy = FlatRedBallServices.Random.In(allenemyTypes);
                            _availableEnemyTypes.Add(randomEnemy);
                            allenemyTypes.Remove(randomEnemy);
                        }
                    }
                    else
                    {
                        _availableEnemyTypes = Waves.SelectMany(w => w.EnemyTypes).Distinct().ToList();
                    }
                }

                return _availableEnemyTypes;
            }
        }

        public int RemainingLives { get; set; }

        public EventHandler OnNewWaveStart;
        public EventHandler OnWaveEnd;
        private bool _currentlyGeneratingNewWave = false;
        private bool _waveHasEnded = false;
        public bool IsReadyForNextWave { get; set; } = false;

        private double? _lastEnemyWaveTime;

        private FlatRedBall.Math.PositionedObjectList<BaseEnemy> _enemyList;

        protected BaseLevel()
        {
            RemainingLives = StartingLives;
            _waveHasEnded = true;
            CurrentWaveNumber = 0;
            LevelResults = CreateResults();
        }

        public void Reset()
        {
            RemainingLives = StartingLives;
            CurrentWaveNumber = 0;
            _lastEnemyWaveTime = 0;
            _waveHasEnded = true;
            _currentlyGeneratingNewWave = false;
            LastWave = null;
            IsReadyForNextWave = false;
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

        public bool HasReachedVictory()
        {
            return CurrentWaveNumber > WavesToSurvive || (_waveHasEnded && CurrentWaveNumber == WavesToSurvive);
        }

        public void Update()
        {
            if (!_waveHasEnded && _enemyList.Count == 0)
            {
                _waveHasEnded = true;
                OnWaveEnd?.Invoke(this, null);
            }

            if (!IsReadyForNextWave || _currentlyGeneratingNewWave) return;

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
            _currentlyGeneratingNewWave = true;
            void GenerateWaveIfNecessary()
            {
                var currentWave = CurrentWaveNumber < Waves.Count  && !PlayerDataManager.PlayerHasBeatGame ? Waves[CurrentWaveNumber] : GenerateWave();
                if (currentWave.EnemyCounts.TotalEnemies == 0)
                {
                    var doh = 1;
                }
                Action stuffToDoOnPrimaryThread = () => FinishCreatingEnemiesForWave(currentWave);
                InstructionManager.AddSafe(stuffToDoOnPrimaryThread);
            }

            Task.Run((Action) GenerateWaveIfNecessary);
        }

        private void FinishCreatingEnemiesForWave(BaseWave currentWave)
        {
            currentWave.CreateEnemies();
            if (currentWave.CreatedEnemies.Count == 0)
            {
                var doh = 1;
            }

            CurrentWaveNumber++;

            LastWave = currentWave;
            _lastEnemyWaveTime = TimeManager.CurrentTime;

            InstructEnemiesToReportDeaths();
            OnNewWaveStart?.Invoke(this, null);
            IsReadyForNextWave = false;
            _waveHasEnded = false;
            _currentlyGeneratingNewWave = false;
        }

        private BaseWave GenerateWave()
        {
            var pointsAvailable = 0.0;
            if (PlayerDataManager.PlayerHasBeatGame)
            {
                _availableEnemyTypes = null;

                var minPoints = AvailableEnemyTypes.Min(t => t.PointValue());
                var addPoints = StartingSatoshis * CurrentWaveNumber * (CurrentWaveNumber/15f);
                pointsAvailable = minPoints + addPoints;
            }
            else
            {
                pointsAvailable = LastWave.PointValue + (StartingSatoshis * CurrentWaveNumber * (CurrentWaveNumber / 30));
            }
            
            var generatedWave = MachineLearningManager.GenerateWave(AvailableEnemyTypes, pointsAvailable);

            if (generatedWave.EnemyTypes.Count == 0 || generatedWave.EnemyCounts.TotalEnemies == 0)
            {
                var doh = 1;
            }
            return generatedWave;
        }

        public LevelResult GetFinalResults(DateTime currentGameDateTime)
        {
            LevelResults.DateTimeFinished = DateTime.Now;
            LevelResults.InGameDateTime = currentGameDateTime;
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
                WasVictorious =  HasReachedVictory(),
            };

            return levelResult;
        }
    }
}
