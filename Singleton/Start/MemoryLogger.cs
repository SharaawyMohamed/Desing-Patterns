using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Start
{
    internal class MemoryLogger
    {
        private int _InfoCount;
        private int _WarningCount;
        private int _ErrorCount;
        private static readonly MemoryLogger _instance = new MemoryLogger();
        private List<LogMessage> _logs = new List<LogMessage>();
        private MemoryLogger()
        {

        }
        public static MemoryLogger Instance
        {
            get
            {
                return _instance;
            }

        }
        public IReadOnlyCollection<LogMessage> logs => _logs;
        private void Log(string message, LogType logtype)
        {
            _logs.Add(new LogMessage()
            {
                Message = message,
                createAt = DateTime.Now,
                logType = logtype,
            });
        }

        public void LogInfo(string message)
        {
            _InfoCount++;
            Log(message, LogType.INFO);
        }
        public void LogError(string message)
        {
            _ErrorCount++;
            Log(message, LogType.ERROR);
        }
        public void LogWarning(string message)
        {
            _WarningCount++;
            Log(message, LogType.WARNIN);
        }
        public void ShowLog()
        {
            _logs.ForEach(x => Console.WriteLine(x));
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"Info : {_InfoCount}, Warning : {_WarningCount}, Error : {_ErrorCount}");
        }

    }
}
