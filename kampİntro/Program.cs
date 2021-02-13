using System;

namespace kampİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string KategoriEtiketi = "kategoriler";
            int ogrenciSayısı = 32000;
            double faizOranı = 1.45;
            bool sistemeGirişYapmışMı =true;
            double dolarDun = 7.35;
            double dolarBugün = 7.45;

            if (dolarDun>dolarBugün)
            {
                Console.WriteLine("azalış butonu");

            }
            else  if (dolarDun<dolarBugün)
            {
                Console.WriteLine("artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu ");
            }









            if (sistemeGirişYapmışMı == true)
            {
                Console.WriteLine("kullanıcı ayarları butonu");

            }
            else
            {
                Console.WriteLine("sisteme giriş yap butonu");
            }
           





            Console.WriteLine(KategoriEtiketi);


        }
    }
}
