using System;

namespace OOP3
{
    class FileLoggerService : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to File.");
        }
    }
}
