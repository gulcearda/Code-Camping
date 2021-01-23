using System;
namespace OOP3
{
    class DataBaseLoggerService: IloggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı");
        }


    }
}
