using System;

namespace Methods_Metodlar
{
    class Program
    {  
        static void Main(string[] args) // Static void method
        {
            Urun elma = new Urun();
            elma.urunAdi = "Elma";
            elma.urunFiyati = 9;
            elma.urunAciklamasi = "Amasya Elması Taze";
            elma.Id = 1;
            elma.stokAdedi = 20;

            Urun karpuz = new Urun();
            karpuz.urunAdi = "Karpuz";
            karpuz.urunFiyati = 15;
            karpuz.urunAciklamasi = "Adana Karbuzu";
            karpuz.Id = 2;
            karpuz.stokAdedi = 100;

            Urun[] urunler = new Urun[] { elma };

            foreach (var item in urunler)
            {
                Console.WriteLine(item.urunAdi);
            }

            Console.WriteLine("---------- METOTLAR -------------");

            //instance yani örneği
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(elma);
            sepetManager.Ekle(karpuz);

        }
    }
}


// DRY  - Do not repeat your self - CLEAN CODE - BEST PRACTICES