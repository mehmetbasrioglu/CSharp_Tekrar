using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Kalitim
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] person = new Person[3]
            {
                new Customer{ FirstName="Engin",LastName="Demiroğ" },
                new Student{ FirstName="Mehmet",LastName="Basrioğlu"},
                new Person{FirstName="Melisa",LastName="Hawk"}
            };

            foreach (var persons in person)
            {
                Console.WriteLine(persons.FirstName + " "+ persons.LastName );
            }
            Console.ReadLine();

        }

        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        class Customer : Person
        {
            public string City { get; set; }
        }
        class Student : Person
        {
            public string Department { get; set; }
        }
    }
}
