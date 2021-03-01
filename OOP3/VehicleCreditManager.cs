using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class VehicleCreditManager : ICreditBaseManager
    {
        public void Calculate()
        {
            Console.WriteLine("Taşıt Kredisi Ödeme Planı Hesaplandı.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
