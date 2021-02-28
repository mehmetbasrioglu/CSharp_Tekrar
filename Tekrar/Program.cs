using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekrar
{
    class Program
    {
        static void Main(string[] args)
        {
            // CustomerManager Örneği Oluştur

            CustomerManager customermanager = new CustomerManager();
            customermanager.Add(new SqlServerCustomerDal());
            
            Console.ReadLine();
        }

    }


}
