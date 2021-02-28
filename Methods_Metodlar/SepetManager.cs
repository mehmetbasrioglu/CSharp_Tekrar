using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_Metodlar
{
    class SepetManager
    {
        //name convention  isimlendirme kuralı
        public void Ekle(Urun urun) /// PARAMETRE TIPI ÜRÜN
        {
            Console.WriteLine("Sepete Eklendi : "+ urun.urunAdi );
        }
    }
}
