using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class SmsLoggerMeneger : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Sms Olarak log gönderildi.");
        }
    }
}
