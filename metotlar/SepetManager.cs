using System;
using System.Collections.Generic;
using System.Text;

namespace metotlar
{
    class SepetManager
    {




        public void Ekle(product urun)
        { //parantez varsa bılkı metot var orda

            Console.WriteLine("sepete eklendi : " + urun.Adi);


        }
        public void Ekle2( string urunAdi,string Acıklama,double Fiyat)
        {
            Console.WriteLine("tebrıkler sepete eklendı :" + urunAdi);
        }
    }
}