using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class HouseCreditManager : ICreditBaseManager
    {
        public void Calculate()
        {
            Console.WriteLine("Konuk Kredisi Ödeme Planı Hesaplandı.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
