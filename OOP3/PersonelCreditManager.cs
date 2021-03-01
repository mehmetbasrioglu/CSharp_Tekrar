using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class PersonelCreditManager : ICreditBaseManager // Interface tutması için kullandık
    {
        public void Calculate()
        {
            Console.WriteLine("İhtiyaç Kredisi Ödeme Planı Hesaplandı.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
