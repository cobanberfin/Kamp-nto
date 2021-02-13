using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            IWorker[] workers = new IWorker[3]
               { new Manager();
            new Worker();
            new Robot();
        };


        foreach (var worker in workers)
	{
            workers.Work();
	}

        }
    }
            



        

    


    interface IWorker
    {
        void Work();
      

    }

    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary();
    }


    class Manager : IWorker, ISalary, IEat
    {
        public void Work()
        {
            Console.WriteLine();
        }

        public void Eat()
        {
            Console.WriteLine();
        }


        public void GetSalary()
        {
            Console.WriteLine();
        }


    }

    class Worker : IWorker, IEat, ISalary
    {
        public void Work()
        {
            Console.WriteLine();
        }

        public void Eat()
        {
            Console.WriteLine();
        }


        public void GetSalary()
        {
            Console.WriteLine();
        }

    }

            class Robot : IWorker
            {
                public void Work()
                {
                    Console.WriteLine();
                }

                    
                


            }









}
