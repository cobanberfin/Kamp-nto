using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {

        T[]items;
        //constructor
        public MyList() //classı nwe lersen otomatık calısır
        {
            items = new T[0];
        }


       public void Add(T item)
        {
            T[] tempArry = items;                  //gecıcı dızı 
            items = new T[items.Length + 1];     //eleman 1 artırdık

            for (int i = 0; i < tempArry.Length; i++)
            {
                items[i] = tempArry[i]; // tem araydekını uzerıme gerı alıorum.

            }
            items[items.Length - 1] = item;  //yeni elemanı ekledık.
        }








    }
}
