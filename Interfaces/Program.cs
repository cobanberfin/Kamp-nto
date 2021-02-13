using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //  IPersonManager Customermanager = new CustomerManager();
            // Customermanager.Add();

            // EmployeeManager employeeManager = new EmployeeManager();
            //employeeManager.Add();

            ProjectManager projectmanager = new ProjectManager();
            projectmanager.Add(new EmployeeManager());
            projectmanager.Update(new EmployeeManager());


        }
    }


    interface IPersonManager
    {
        void Add();
        void Update();
    }

    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine(" customer eklendi");
        }

        public void Update()
        {
            Console.WriteLine("güncellendi");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine(" person eklendı");
        }

        public void Update()
        {
            Console.WriteLine(" employee güncellendi");
        }
    }

           
    //class ProjectManager
    //{
    //    public void AddCustomer(CustomerManager Customermanager )
    //    {
    //        Customermanager.Add();
    //}

    //    public void AddEmployee(EmployeeManager Employeemanager)
    //    {
    //        Employeemanager.Add();
    //    }


    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add(); 

        }

         public void Update(IPersonManager personManager)
        {
            personManager.Update();
        }



    }



    }
























