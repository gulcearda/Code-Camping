using System;
namespace OOP1
{
    public class Product //Entity(varlık gibi isimler verilir) Bu tarz classlarda sadece özellikler olur.
    {
        public int Id { get; set; }
        //ana anahtar deniyor bu id ye
        public int CategoryId { get; set; }
        //referans anahtar

        public string ProductName { get; set; }

        public double UnitPrice { get; set; }

        public int UnitInStock { get; set; }


    }
}
