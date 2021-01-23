using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection
        public void BasvuruYap(IKrediManeger krediManager,List<ILoggerService> loggerService)
        {
            krediManager.Hesapla();
            foreach (var logger in loggerService)
            {
                logger.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManeger> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
