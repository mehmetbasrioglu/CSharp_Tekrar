using System;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Manager with Array");

            Console.WriteLine("\n");

            Employee[] personeller = new Employee[]
            {
                new Employee{FirstName="Abdül",LastName="Rezak",Id=2,Location="Istanbul",Parmak_izi_numarasi=2517271,TCKimlik=1234567891},
                new Employee{FirstName="Abdül 2",LastName="Rezak",Id=2,Location="Istanbul",Parmak_izi_numarasi=2517271,TCKimlik=1234567891},
                new Employee{FirstName="Abdül 3",LastName="Rezak",Id=2,Location="Istanbul",Parmak_izi_numarasi=2517271,TCKimlik=1234567891}

            };

            foreach (var item in personeller)
            {
                Console.WriteLine(item.FirstName);
            }

        }
    }
}
