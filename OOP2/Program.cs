using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri = new GercekMusteri();
            musteri.Id = 1;
            musteri.MusteriNo = "12345";
            musteri.Adi = "Onur";
            musteri.Soyadi = "Vuran";

            TuzelMusteri musteri1 = new TuzelMusteri();
            musteri1.Id = 1;
            musteri1.SirketAdi = "THY";
            musteri1.VergiNo = "1234567890";

            //SOLID

            Musteri musteri2 = new GercekMusteri();
            Musteri musteri3 = new TuzelMusteri();

            CustomerManeger customerManeger = new CustomerManeger();
            customerManeger.Ekle(musteri);
            customerManeger.Ekle(musteri3);

        }
    }
}
