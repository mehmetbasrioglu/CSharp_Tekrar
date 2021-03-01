using System;

namespace OOP3
{
    class SMSLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to sms.");
        }
    }
}
