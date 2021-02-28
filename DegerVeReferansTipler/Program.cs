using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        //Değer Type(Tip) int float double decimal boolean(boolean 0 false 1 true)

        //Referance Type( Referans Tip ) array class interface
            
        // Steak ve Heap Bellekte yer alır 
        // Değer Type sadece steak de gerçekleşir.
        // Steak sayi1 değişkenin değeri = 10 olsun sayi2 değişkenin değeri = 30 olsun sayi1 = sayi2 dediğimizde sayi1 = 30 olur.
        

        static void Main(string[] args)
        {
            int sayi1, sayi2;
            sayi1 = 10;
            sayi2 = 30;
            sayi1 = sayi2;
            // Ekran Çıktısı ne olur ?? Sonuç == sayi1 değişkeni yani değeri 10 iken sayi 2 nin değerini alır 30 olur

            // Referance - Referanslar
            int[] sayilar = new int[] { 10, 20, 30, 40 }; // Array diziler bir referanstır.
            sayilar[0] = 100; // Sayilar referansının 0. elemanının değerini 100 olarak değiştir.


        }
    }
}
