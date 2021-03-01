using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar
{
    class ArabaManager
    {
        public void Add(Araba araba) // Sadece Araba özelliklerini ekleyebilirsin
        {
            Console.WriteLine("Yeni Kiralik Araç Eklendi.");
            Console.WriteLine("ID:" + araba.Id);
            Console.WriteLine("Fotoğraf:"+araba.arabaninFotografi);
            Console.WriteLine("Araba Sahibi:" + araba.arabaninSahibi);
            Console.WriteLine("Araba Deposu:" + araba.arabaninBenzinDeposu);
            Console.WriteLine("Plaka:" + araba.arabaninPlakasi);
            Console.WriteLine("Yer:"+araba.arabaninYeri);

        }
        public void Update(Araba araba)
        {
            Console.WriteLine("Kiralik Araç Güncellendi.");
            Console.WriteLine("ID:" + araba.Id);
            Console.WriteLine("Fotoğraf:" + araba.arabaninFotografi);
            Console.WriteLine("Araba Sahibi:" + araba.arabaninSahibi);
            Console.WriteLine("Araba Deposu:" + araba.arabaninBenzinDeposu);
            Console.WriteLine("Plaka:" + araba.arabaninPlakasi);
            Console.WriteLine("Yer:" + araba.arabaninYeri);
        }
    }
}
