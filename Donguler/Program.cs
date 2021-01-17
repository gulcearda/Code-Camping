using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Kampı";
            string kurs2 = "Programlamaya başlangıç için Temel kurs";
            string kurs3 = "Java";

            //array = dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Kampı",
                "Programlamaya başlangıç için Temel kurs" , "Java", "Phyton", "C#"};



            for (int i = 0; i < kurslar.Length ; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");

            foreach (string X in kurslar)
            {
                Console.WriteLine(X);
            }

            Console.WriteLine("Sayfa sonu- footer");
        }
    }
}
