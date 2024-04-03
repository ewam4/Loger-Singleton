using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp6
{
    public class Logger
    {
        private static Logger _instance;
        private readonly string _logFilePath;
        private static readonly object _lock = new object();
        private Logger()

        {
           // string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Stwórz pełną ścieżkę pliku, łącząc ścieżkę do pulpitu z nazwą pliku
            //string filePath = Path.Combine(desktopPath, "logi.txt");
            _logFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "logi.txt");
            //@"C:\Users\Student\Desktop\logi.txt";
        }


        public static Logger Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Logger();
                }
                return _instance;
            }
        }
        public void Log(string message)
        {

            string logEntry = $"{DateTime.Now}: {message}\n";
            lock (_lock)
            {
                File.AppendAllText(_logFilePath, logEntry);
            }
        }
    }
}
