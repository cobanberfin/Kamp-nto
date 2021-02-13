using System;

namespace döngüler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım geliştirici kursu";
            string kurs2 = "programlamaya başlangıç için temel kurs";
            string kurs3 = " java";
            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);

            // array-dizi

            string[] kurslar = new string[] {
                "yazılım geliştirici kursu",
                "programlamaya başlangıç için temel kurs","java"
            };

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bıttı");

            foreach (string dillerde in kurslar)//kurssları tek tek dolas ın kurslar
            {
                Console.WriteLine(dillerde);
            }





        }
    }
}
