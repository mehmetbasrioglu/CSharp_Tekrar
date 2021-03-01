using System;

namespace OOP3
{
    class ArtisanCreditManagar : ICreditBaseManager// ESNAF KREDİSİ
    {
        public void Calculate()
        {
            Console.WriteLine("Esnaf Kredisi Ödeme Planı Hesaplandı.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
