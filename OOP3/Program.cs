using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Interfacelerde o  interfaceyi implemente eden classın referance numarasını tutar
            // yani baştaki IhtiyacKrediManager yerine IKrediManager yazarsak da aynı çıktıyı alırız
            
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager(); // ÖNEMLİ !!! hangisini seçersek o hesaplanır
            basvuruManager.BasvuruYap(new EsnafKrediManager(), new SmsLoggerService());
            

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager, konutKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
