using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatabaseLoggerService : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database.");
        }
    }
}
