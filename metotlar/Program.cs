using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            int Id = 123;
            string Adi = "elma";
            double Fiati =45.9;
            string aciklama = " kıpkırmızı elmalar";

            string[] meyveler = new string[] {"elma","armut" };


            product urun1 = new product();
            urun1.Adi = "elma";
            urun1.Id = 123;
            urun1.Fiyati = 45.9;
            urun1.Aciklama = "amasya elması";


            product urun2 = new product();
            urun2.Adi = "çilek";
            urun2.Id = 553;
            urun2.Fiyati =50;
            urun2.Aciklama = "dağ çileği";

            //dizi oluşturalım cunku ne kadar data eklersem hepsini tutsun diye

            product[] urunler = new product[] {urun1,urun2, };//bu urunler genellıkle bır verı kaynagndan gelir.

            foreach (product meyve in urunler)                //type-safe urun tıpı belirle
            {
                Console.WriteLine(meyve.Adi);
                Console.WriteLine(meyve.Fiyati);
                Console.WriteLine(meyve.Aciklama);
                Console.WriteLine(meyve.Id);
                Console.WriteLine("----------------------");
                    

            }




            Console.WriteLine("---------------metotlar----------");

            //encapsulation

            SepetManager sepetManager = new SepetManager();

            sepetManager.Ekle( urun1);
            sepetManager.Ekle(urun2);



            sepetManager.Ekle2("armut", "yesil armut", 12);
            sepetManager.Ekle2("elma", "yesil armut", 12);
            sepetManager.Ekle2("elma", "yesil armut", 12);






        }
    }
}






// metotlar  kodları tekrar tekrar yazmamak ıcın kullanlır.
// dry -clean- best practıce