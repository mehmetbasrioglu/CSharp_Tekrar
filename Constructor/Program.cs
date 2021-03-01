using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Customer customer2 = new Customer(2, "Mehmet", "Basrioğlu","1234651241");
            Console.WriteLine(customer2.FirstName + " " +customer.LastName);

            Console.ReadLine();
        }
    }


    class Customer
    {
        //Default Constructor
        public Customer()
        {

        }
        public Customer(int id,string firstname,string lastname)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            
            //Console.WriteLine("Default Constructor");
        }

        public Customer(int id, string firstname, string lastname,string tckimlik)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            TcKimlik = tckimlik;

            //Console.WriteLine("Default Constructor");
        }



        //Prop types
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TcKimlik { get; set; }

    }
}
