using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> sehirler = new List<string>();
            sehirler.Add("ankara");
            Console.WriteLine(sehirler.Count);

            MyList<string> sehirler2= new MyList<string>();
            Console.WriteLine(sehirler2.count);
            
            sehirler2.Add("ankara");


        }
    }


  class MyList <T> //generic class
    {
        T[] _array;
        T[] _temparray;

        public MyList()
        {
            _array = new T[0];


        }
        public void Add(T item )
        {
            _temparray = _array;
            _array = new T[_array.Length + 1]; 

        }

        private int _count;

        public int count
        {
            get { return _array.Length; }
           
        }

    }









}



