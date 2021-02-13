using System;

namespace Class.İntro


{
    class Program
{
    static void Main(string[] args)
    {
        int yas = 21;


        kurs kurs1 = new kurs();
        kurs1.kursAdı = "c#";
        kurs1.eğitmen = "engin demiroğ";
        kurs1.izlenmeOranı = 68;

            kurs kurs2 = new kurs();
            kurs2.kursAdı = "java";
            kurs2.eğitmen = "kereme varış";
            kurs2.izlenmeOranı = 88;

            kurs kurs3 = new kurs();
            kurs3.kursAdı = "python";
            kurs3.eğitmen = "ilker varış";
            kurs3.izlenmeOranı = 78;

            //    Console.WriteLine(kurs1.kursAdı + " " + kurs2.eğitmen);


            kurs[] kurslar = new kurs[] { kurs1, kurs2, kurs3 };
            foreach (kurs yaz in kurslar)
            {
                Console.WriteLine(yaz.kursAdı);
            }




        }
}

       class kurs
{
    public string kursAdı  { get; set; }
    public string eğitmen { get; set; }
    public int izlenmeOranı { get; set; }

}






}
