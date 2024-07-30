using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Start
{
    internal class LogMessage
    {
        public string Message { get; set; } = string.Empty;
        public LogType logType { get; set; }
        public DateTime createAt { get; set; }

        public override string ToString()
        {
            var timeSamp = createAt.ToString("yyyy-mm-dd hh-mm");
            return $"{logType.ToString().PadLeft(7,' ')} [{timeSamp}] {Message}";
        }

    }
}
