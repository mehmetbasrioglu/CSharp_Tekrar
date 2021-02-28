using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            //DersleriListeleyi cağır
            DersleriListele();

            //Foreach Nedir ?
            ForeachIleListele();

        }


        public static void ForeachIleListele()
        {
            string[] dersler = new string[]
            {
                "REACT.JS",
                "VUE.JS",
                "NODE JS",
                "EXPRESS JS"
            };

            //Dizi Array yapılı olanları dönmeye yarıyor
            foreach (var item in dersler)
            {
                Console.WriteLine(item);
            }
        }

        public static void DersleriListele()
        {
            // DERSLER ARRAY DERSLER DIZISI
            string[] dersler = new string[]
            {
                "C#",
                "PHP",
                "3D MODELLEME",
                "VERI TABANI"
            };
            for (int i = 0; i < dersler.Length; i++)
            {
                Console.WriteLine(dersler[i]);
            }
        }
    }
}
