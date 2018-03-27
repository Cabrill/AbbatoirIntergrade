using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbatoirIntergrade.StaticManagers
{
    public static class LocalLogManager
    {
        private const string _logName = "DebugLog.txt";

        public static void StartLog()
        {
            File.WriteAllText(_logName, DateTime.UtcNow.ToString() + ": Start game" + Environment.NewLine);
        }

        public static void AddLine(string logLine)
        {
            File.AppendAllText(_logName, DateTime.UtcNow.ToString() + ": " + logLine + Environment.NewLine);
        }

        public static void UncaughtExceptionLogger(object sender, UnhandledExceptionEventArgs args)
        {
            Exception e = (Exception)args.ExceptionObject;
            AddLine(e.Message);
            AddLine(e.StackTrace);

            var errorDetails = new
            {
                Message = e.Message,
                StackTrace = e.StackTrace
            };
            AnalyticsManager.SendEventImmediately("UncaughtException", errorDetails);
        }
    }
}
