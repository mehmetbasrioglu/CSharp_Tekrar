using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Polymorphism
             * Hangi Krediyi Çekmek istersiniz derken senin özelliklerini soruyor ve ihtiyaç da olur taşıt da olur diyor
             * ihtiyaç kredisi ne kadar öderim taşıt çekersem ne kadar öderim bankadaki personele sorulur ekrandan hesaplanır
             * 
             * 
             */



            ICreditBaseManager konutKredisi = new HouseCreditManager(); //Interfaceler referans numarasını tutabilir.
            ICreditBaseManager ihtiyacKredisi = new PersonelCreditManager();
            ICreditBaseManager esnafKredisi = new ArtisanCreditManagar();

            ILogger veritabani = new DatabaseLoggerService();
            ILogger fileLogger = new FileLoggerService();
            ILogger smsLogger = new SMSLogger();

            ApplicationManager basvuruFormu = new ApplicationManager();
            basvuruFormu.DoApplication(esnafKredisi,new List<ILogger> { veritabani, smsLogger }); // Hangi Krediyi Gönderirsem Onu Çalıştırır && Hangi Log Gönderirsem Onu Çalıştırır

            List<ICreditBaseManager> krediler = new List<ICreditBaseManager>() { konutKredisi, ihtiyacKredisi };
            //basvuruFormu.CreditFrontInfo(krediler); // Kredi Ön Bilgilendirmesi



            
        }
    }
}
