﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager //ürünle ilgili opersayon var içinde CRUD
    {
        public void Add (Product product)
        {

            Console.WriteLine(product.productName + " eklendi.");
        }

        public void Update (Product product)
        {
            Console.WriteLine(product.productName + "güncellendi.");
        }


        public int Topla(int sayi1 ,int sayi2)
        {
            return sayi1 + sayi2;
        }



        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1+sayi2); 
        }






    }
}