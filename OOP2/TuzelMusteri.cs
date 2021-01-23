using System;
namespace OOP2
{
    //Corporate
    //miras inheritance. Tüzel müşteri bir müşteridir demektir bu.
    //tüzel müsterinin babası müsteridir.Ne varsa müşteride de vardır.
    //Musteri ebeveyndir ve ortak olanları barındırır.
    //Tüzel ve gerçekte ise sadece kendilerine ait olanlar vardır.

    public class TuzelMusteri:Musteri
    {
        

        public string SirketAdi { get; set; }

        public string VergiNo { get; set; }


    }
}
