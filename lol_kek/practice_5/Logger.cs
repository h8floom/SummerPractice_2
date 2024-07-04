using System;
using System.IO;

namespace lol_kek.practice_5
{
    public class SimpleLogger
    {
        private readonly string logFilePath;

        public SimpleLogger(string logFilePath)
        {
            this.logFilePath = logFilePath;
        }

        public void LogInfo(string message)
        {
            Log("INFO", message);
        }

        public void LogError(string message)
        {
            Log("ERROR", message);
        }

        private void Log(string level, string message)
        {
            using (StreamWriter log = new StreamWriter(logFilePath, true))
            {
                log.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} [{level}] {message}");
            }
        }
    }
}
