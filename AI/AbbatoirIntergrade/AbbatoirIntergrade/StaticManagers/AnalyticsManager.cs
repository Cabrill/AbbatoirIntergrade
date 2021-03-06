﻿using System;
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
#if DEBUG
        private const string KeenProjectID = "5aaaa790c9e77c000169280d";
        private const string KeenWriteKey = "1ADD2D7BBD696531CC88F5C762ABEA5EDA8A01342063C85B9B0C85E620A48CB5C27C1290B11F883DDB81CF099565A390677D5C147140FF482BDDA2038830F07D990FE5B7B93CCC9F31A73296E23C9D6E013C44EE20CB6F2F022FFC67BE3BA6E9";
#else
        private const string KeenProjectID = "5aad7501c9e77c0001692a0c";
        private const string KeenWriteKey = "D8D05A344E3F085F6EEF4F30F401E6B1FD712F1A7F4B108D57AA32278A6EE522D782D67BB6FE3DE92C40752E5015AC4E8228CF9DA59C41706C31A93D885CEA9DF82DE069811AB307962EFAF784B5889A42E9C8CB310DABE3CD2F95F846493234 ";
#endif

        private static KeenClient Client;
        private static KeenClient DeferredClient;

        public static void Initialize()
        {
            LocalLogManager.AddLine("Analytics manager initialization");
            var projectSettings = new ProjectSettingsProvider(KeenProjectID, writeKey: KeenWriteKey);
            Client = new KeenClient(projectSettings);
            DeferredClient = new KeenClient(projectSettings, new EventCacheMemory());

            var playerId = PlayerDataManager.CurrentPlayerId;

            Client.AddGlobalProperty("PlayerID", playerId);

            DeferredClient.AddGlobalProperty("PlayerID", playerId);
        }

        public static void SendEventImmediately(string eventName, object eventData)
        {
            //var addons = new[]
            //{
            //    AddOn.IpToGeo("IPAddress", "Location")
            //};
            Client.AddEventAsync(eventName, eventData);
        }

        public static void AddDeferredEvent(string eventName, object eventData)
        {
            //var addons = new[]
            //{
            //    AddOn.IpToGeo("IPAddress", "Location")
            //};
            DeferredClient.AddEventAsync(eventName, eventData);
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
                InGameTime = results.InGameDateTime,
                TimePlayed = results.TimePlayed,
                EnemiesDefeated = results.EnemiesDefeated,
                WavesCompleted = results.WavesCompleted,
            };

            AddDeferredEvent("LevelComplete", eventResults);
        }

        public static void SendGameCompleteEvent(EndingTypes endingResult)
        {
            var gameResults = new
            {
                EndingType = endingResult.ToString(),
                TimesGameCompleted = PlayerDataManager.TilesGameCompleted,
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

        //private static string GetLocalIPAddress()
        //{
        //    try
        //    {
        //        string localIp;
        //        using (var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
        //        {
        //            socket.Connect("8.8.8.8", 65530);
        //            var endPoint = socket.LocalEndPoint as IPEndPoint;
        //            localIp = endPoint?.Address.ToString();
        //        }
        //        return localIp;
        //    }
        //    catch (Exception)
        //    {
        //        return string.Empty;
        //    }
        //}
    }
}
