using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "1234";
            musteri1.Adi = "berfin";
            musteri1.Soyadi = "coban";
            musteri1.TcNo = "23456789";
            musteri1.Id = 1;
;

            TuzelMusteri musteri2 = new TuzelMusteri();

            musteri2.MusteriNo = "1313";
            musteri2.SirektAdi = "kodlama.io";
            musteri2.VergiNO = "12345678";
            musteri2.Id = 2;



            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customermanager = new CustomerManager();
            customermanager.Add(musteri1);
            customermanager.Add(musteri2);








        }
    }
}
