using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program 
    {
        static void Main(string[] args)
        {
            IKrediManeger ihtiyacKrediManeger = new IhtiyacKrediManeger();
            

            IKrediManeger tasitKrediManager = new TasitKrediManeger();
            IKrediManeger tasitKrediManeger = new KonutKrediManeger();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new CiftciKredisi(),
                new List<ILoggerService>() {new SmsLoggerMeneger(),new FileLoggerService() });

            List<IKrediManeger> x = new List<IKrediManeger>() {ihtiyacKrediManeger,tasitKrediManager};
            //basvuruManager.KrediOnBilgilendirmesiYap(x);
        }
    }
}
