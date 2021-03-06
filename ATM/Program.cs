using System;
using System.Collections.Generic;
using System.Linq;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {

            Corporate kurumsal = new Corporate();
            kurumsal.Id = 1;
            kurumsal.TaxNo = 123;
            kurumsal.CompanyName = "Kodlama.io";
            kurumsal.CustomerId = "KDLIO1";
            kurumsal.BankAmount = 99999999;


            Individual bireysel = new Individual();
            bireysel.Id = 2;
            bireysel.FirstName = "Engin";
            bireysel.LastName = "Demiroğ";
            bireysel.BankAmount = 30000;


            Console.Write("Kredi Kartı Numaranız ?:");
            string oku = Console.ReadLine();

            List<Customer> liste = new List<Customer>()
            {
                kurumsal,
                bireysel
            };
            ILoginService loginServis = new LoginManager();
            var bireyselDegisken = "Bireysel";
            if (loginServis.Login( liste,int.Parse(oku) ) == bireyselDegisken)
            {
                Console.WriteLine("Bireysel Giriş Yapıldı");
            }
            else if (loginServis.Login(liste, int.Parse(oku)) == "Şirket")
            {
                Console.WriteLine("Kurumsal Giriş Yapıldı");
            }
            else
            {
                Console.WriteLine("Kaydınız bulunamadı.");
            }
            Console.Write("Yapmak istediğiniz işlemi yazınız:");
            string islem = Console.ReadLine();

            if(islem == "çıkış")
            {
                //Console.WriteLine(oku);
                if(loginServis.KartiCikar(liste,int.Parse(oku)) == bireyselDegisken)
                {
                    Console.WriteLine("Bireysel Hesabınızdan Çıkış Yapıldı");
                }
                else if (loginServis.KartiCikar(liste, int.Parse(oku)) == "Şirket") 
                {
                    Console.WriteLine("Kurumsal Hesabınızdan Çıkış Yapıldı");
                }
            }
            else if(islem == "Para Çek")
            {
                Console.Write("Çekmek istediğiniz miktarı yazınız:");
                int miktar = Convert.ToInt32(Console.ReadLine());
                int gelenpara = loginServis.ParaCek(liste, int.Parse(oku),miktar);
                Console.WriteLine(gelenpara);
            }







        }
    }

}
