using System;

namespace OOP2
{
    class Program
    {
        //inheritance neden yapılıyor ? 
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.CustomerNumber = "123456";
            musteri1.FirstName = "Mehmet";
            musteri1.LastName = "Basrioğlu";
            musteri1.TcNo = "12345678910";
            musteri1.Id = 1;

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.CompanyName = "Kodlama.io";
            musteri2.Id = 2;
            musteri2.CustomerNumber = "654321";
            musteri2.VergiNo = "1234567890";

            // Gercek Müşteri - Tüzel Müşteri İKİSİDE MÜŞTERİ
            // SO L ID

            Customer musteri3 = new GercekMusteri();// Müşteri(Customer) new GercekMüşteri var ise referans numarasını tutuyordur
            Customer musteri4 = new TuzelMusteri();

            CustomerManager musteriManager = new CustomerManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);
            musteriManager.Add(musteri4);





        }
    }
}
