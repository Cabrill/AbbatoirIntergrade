using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using AbbatoirIntergrade.GameClasses;
using Keen.Core;
using Keen.DataEnrichment;

namespace AbbatoirIntergrade.StaticManagers
{
    public static class AnalyticsManager
    {
        private const string KeenProjectID = "5aaaa790c9e77c000169280d";
        private const string KeenWriteKey = "1ADD2D7BBD696531CC88F5C762ABEA5EDA8A01342063C85B9B0C85E620A48CB5C27C1290B11F883DDB81CF099565A390677D5C147140FF482BDDA2038830F07D990FE5B7B93CCC9F31A73296E23C9D6E013C44EE20CB6F2F022FFC67BE3BA6E9";

        private static KeenClient Client;
        private static KeenClient DeferredClient;

        public static void Initialize()
        {
            var projectSettings = new ProjectSettingsProvider(KeenProjectID, writeKey: KeenWriteKey);
            Client = new KeenClient(projectSettings);
            DeferredClient = new KeenClient(projectSettings, new EventCacheMemory());

            var playerId = PlayerDataManager.CurrentPlayerId;

            Client.AddGlobalProperty("PlayerID", playerId);
            Client.AddGlobalProperty("IPAddress", GetLocalIPAddress());

            DeferredClient.AddGlobalProperty("PlayerID", playerId);
            DeferredClient.AddGlobalProperty("IPAddress", GetLocalIPAddress());
        }

        public static void SendEventImmediately(string eventName, object eventData)
        {
            var addons = new[]
            {
                AddOn.IpToGeo("IPAddress", "Location")
            };
            Client.AddEventAsync(eventName, eventData, addons);
        }

        public static void AddDeferredEvent(string eventName, object eventData)
        {
            var addons = new[]
            {
                AddOn.IpToGeo("IPAddress", "Location")
            };
            DeferredClient.AddEventAsync(eventName, eventData, addons);
        }

        public static void SendDeferredEvents()
        {
            DeferredClient.SendCachedEventsAsync();
        }

        public static void FlushDeferredEvents()
        {
            DeferredClient.EventCache.ClearAsync();
        }

        public static void SendLevelCompleteEvent(LevelResult results)
        {
            var eventResults = new
            {
                LevelNumber = results.LevelNumber,
                LevelName = results.LevelName,
                LevelStarted = results.DateTimeStarted,
                LevelFinished = results.DateTimeFinished,
                TimePlayed = results.TimePlayed,
                EnemiesDefeated = results.EnemiesDefeated,
                WavesCompleted = results.WavesCompleted,
                ModelMSE = MachineLearningManager.CurrentMeanSquaredError,
                ModelSampleSize = MachineLearningManager.SampleSize,
            };

            AddDeferredEvent("LevelComplete", eventResults);
        }

        public static void SendGameCompleteEvent(int endingResult)
        {
            var gameResults = new
            {
                EndingType = endingResult < 0 ? "Negative" : endingResult > 0 ? "Positive" : "Neutral",
                TotalPlayTimeInSeconds = PlayerDataManager.TotalPlayTimeInSeconds,
                TotalWavesSent = PlayerDataManager.TotalWavesSent,
                TotalEnemiesKilled = PlayerDataManager.TotalEnemiesKilled,
                GameLaunchCount = PlayerDataManager.GameLaunchCount,
                DialogueResponseCount = PlayerDataManager.TotalResponseCount,
                PositiveResponsePercent = PlayerDataManager.PositiveDialoguePercent,
                NegativeResponsePercent = PlayerDataManager.NegativeDialoguePercent,
                NeutralResponsePercent = PlayerDataManager.NeutralDialoguePercent,
                SilenceResponsePercent = PlayerDataManager.SilentDialoguePercent,
            };

            AddDeferredEvent("GameCompleted", gameResults);
        }

        private static string GetLocalIPAddress()
        {
            try
            {
                string localIp;
                using (var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
                {
                    socket.Connect("8.8.8.8", 65530);
                    var endPoint = socket.LocalEndPoint as IPEndPoint;
                    localIp = endPoint?.Address.ToString();
                }
                return localIp;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
    }
}
