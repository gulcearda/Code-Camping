using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "123";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "123456556";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "4321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "758585858";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);


            //Musteri musteri1 = new Musteri();
            //musteri1.Adi = "Engin";
            //musteri1.Soyadi = "Demiroğ";
            //musteri1.Id = 1;
            //musteri1.TcNo = "2222222";
            //musteri1.MusteriNo = "123";
            //musteri1.SirketAdi = "?";

            //Gerçek - Tüzel sadece birbirine benziyor diye beraber kullanılamaz.
            //Bu nedenle ayrı olarak tanılanmalı çünkü 2 farklı müşteri tipidir.
            //Bunları ayrı yazmamaızın sebebi ileride dataları yanlış yorumlar
            //SOLID (solidin l harfi söylüyormuş bunu)
        }
    }
}
