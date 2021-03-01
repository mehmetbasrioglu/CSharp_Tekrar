using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> myList = new MyList<string>();
            myList.Add("Mehmet");
            myList.Add("Engin");

            foreach (var item in myList.Items)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(myList.Count);

            Console.WriteLine("Hello World!");
        }
    }
}
