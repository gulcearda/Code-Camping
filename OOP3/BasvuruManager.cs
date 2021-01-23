using System;
using System.Collections.Generic;

namespace OOP3
{
     class BasvuruManager
    {

        //Method injetction yapıyoruz.
        //Hangi method, hangi log olduğuna dair bir fikri yok burada.
        //soyut halde varlar sonra biz somut hale getiriyoruz. Program.cs de
        public void BasvuruYap(IKrediManager krediManager, List<IloggerService> loggerService)
        {
            //bunun sayesinde her krediyi buraya gönderebiliriz.
            //bu kısma ihtiyaç konut ne gönderirsek bellekte o çalışır.
            //Başvuru bilgilerini değerlendirme
            //birden fazla logger yollayacaksam list şeklinde loggerı yazarız.
            krediManager.Hesapla();
            //loggerService.Log();
            //hangi kullanıcı servis seçildiyse onu logla demek
            foreach (var logService in loggerService)
            {
                logService.Log();
            }
        }

       
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            //liste yolladık başka bir fark yok ve listedeki her birini hesapladık
            //bunu yapma sebebimiz müşterinin hangi krediyi çekeceğine karar vermesine yardım etmek için
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
