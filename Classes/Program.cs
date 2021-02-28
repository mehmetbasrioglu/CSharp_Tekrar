using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class Sınıf Örnekleri !");

            // Class Sınıfı Tanımlamak
            Kurs kurs = new Kurs();
            // Class sınıfın elemanları(değişkenleri propları yani property özellikleri)
            kurs.Egitmen = "Engin Demiroğ";
            kurs.KursAdi = "C#";
            kurs.IzlenmeOrani = 68;

            Console.WriteLine(kurs.Egitmen);
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
