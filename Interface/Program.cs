using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        // interface new olamaz mesela : IPersonManager personManager = new IPersonManager(); !
        static void Main(string[] args)
        {
            //IPersonManager customerManager = new CustomerManager(); // Customer Manager Referans
            //customerManager.Add();

            //IPersonManager employeeManager = new EmployeeManager(); // Employee Manager Referans
            //employeeManager.Add();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new InternManager());

            Console.ReadLine();


        }
    }
  
    interface IPersonManager
    {
        // unimplemented operation - içi dolu olmayan
        void Add();

    }
    //inherits -- Class için  --------implements interface için
    class CustomerManager : IPersonManager //
    {
        public void Add()
        {
            Console.WriteLine("Müşteri Eklendi");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Personel Eklendi");
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer Eklendi");
        }
    }

    // Yöbetim kolaylığı & değişikliği kolay sağlar
    class ProjectManager
    {
        public void Add(IPersonManager personManager) // New Sadece IPersonManager olmak zorunda
        {
            personManager.Add();
        }
    }


}
