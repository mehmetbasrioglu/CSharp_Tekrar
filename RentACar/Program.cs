using System;

namespace RentACar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Araba Manager instance yani örneği
            ArabaManager arabaManager = new ArabaManager();
            arabaManager.Add(new Araba
            { 
                Id = 1,
                arabaninSahibi = "Mehmet Basrioğlu",
                arabaninPlakasi = "34 IST 3434",
                arabaninBenzinDeposu = 100 ,
                arabaninFotografi = "wwww.google.com",
                arabaninYeri = "Istanbul"
            });

            arabaManager.Add(new Araba
            {
                Id = 2,
                arabaninSahibi = "Mehmet Basrioğlu",
                arabaninPlakasi = "34 IST 3406",
                arabaninBenzinDeposu = 80,
                arabaninFotografi = "www.website.com/blabalba",
                arabaninYeri = "Ankara"
            });


        }
    }
}
