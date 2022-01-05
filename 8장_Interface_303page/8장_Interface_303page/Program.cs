using System;
using System.IO;
using Interface;

namespace Interface
{
    interface ILogger
    {
        void WriteLog(string message);
    }

    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine(
                "{0} {1}",
                DateTime.Now.ToLocalTime(), message);
        }
    }

    class FileLogger : ILogger
    {
        private StreamWriter writer;

        public FileLogger(string path)
        {
            writer = File.CreateText(path);
            writer.AutoFlush = true;
        }

        public void WriteLog(string message)
        {
            writer.WriteLine("{0} {1}", DateTime.Now.ToShortTimeString(), message);
        }
    }

    class ClimateMoniter
    {
        private ILogger logger;
        public ClimateMoniter(ILogger logger)
        {
            this.logger = logger;
        }

        public void start()
        {
            while(true)
            {
                Console.Write("온도를 입력해주세요: ");
                string temperature = Console.ReadLine();
                if (temperature == "")
                    break;
                logger.WriteLog("현재 온도: " + temperature);
            }
        }
    }
}

namespace _8장_Interface_303page
{
    class Program
    {
        static void Main(string[] args)
        {
            ClimateMoniter monitor = new ClimateMoniter(new ConsoleLogger());

            monitor.start();
        }
    }
}