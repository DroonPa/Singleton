using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MySingletonLibrary
{
    public sealed class Logger
    {
        private static readonly Logger instance = new Logger();
        private readonly string logFilePath = "log.txt";

        public static Logger Instance => instance;

        private Logger() { }

        public void Log(string message)
        {
            File.AppendAllText(logFilePath, $"{DateTime.Now}: {message}{Environment.NewLine}");
        }
    }
}
