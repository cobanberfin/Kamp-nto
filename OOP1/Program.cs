using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product();

            product1.Id = 1;
            product1.CategoryId = 2;
            product1.productName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            //bu yoolada oluşturabılırız.

      //PascalCase //
           Product product2= new Product { Id =2, CategoryId=5,
            UnitInStock =5 ,UnitPrice =35 ,productName ="Kalem"};



            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.productName);














            //productManager.Topla(3, 6); //void

            //int toplamaSonucu = productManager.Topla(3, 6); //int li 

            //Console.WriteLine(toplamaSonucu*2);
        }
    }
}
