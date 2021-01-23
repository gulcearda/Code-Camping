using System;
using System.Collections.Generic;


namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {

            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            //TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            IloggerService databaseLoggerService = new DataBaseLoggerService();
            IloggerService fileLoggerService = new FileLoggerService();
            //33. satırı 25. satırla birleştirdik. Bu yazılımda süreklilik sağlar.
            //yukarı da 2 tane loglama servisimiz var

            List<IloggerService> loggers = new List<IloggerService> { new FileLoggerService(), new DataBaseLoggerService() };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager, new List<IloggerService>
            {new DataBaseLoggerService(), new FileLoggerService()});

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager};

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);


            //Interfacelerde onu implemente eden classların referanslarını tutabilir.

        }
    }
}
