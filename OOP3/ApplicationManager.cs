using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager // Başvuru Yönetimi
    {
        // Burada yaptığımız şey method injections 
        public void DoApplication(ICreditBaseManager creditBaseManager,List<ILogger> loggerService) // Başvuru Yap 
        {
            creditBaseManager.Calculate();
            foreach (var item in loggerService)
            {
                item.Log(); // Hangi LOGLAYICI secilmiş ise onu logla
            }


        }

        public void CreditFrontInfo(List<ICreditBaseManager> krediler) // Kredi Ön Bilgilendirmesi // Birden Fazla Kredinin Hesabı için List Yani Collections Kullanılır. Bu Listenin Türü Tipi ICreditBaseManager olsun.
        {
            foreach (var item in krediler) // Her bir kredinin bir operasyonunu yap hesapla
            {
                item.Calculate();
            }
        }
    }
}
