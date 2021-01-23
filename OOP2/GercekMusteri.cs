using System;
namespace OOP2
{
    //varlık, entity
    //musteri de olan özellikler artık gerçek müsteride de vardır gibi yorumlanır ortak olanlar için.
    public class GercekMusteri:Musteri
    {
        //Individual

        public string TcNo { get; set; }

        public string Adi { get; set; }

        public string Soyadi { get; set; }


    }
}
