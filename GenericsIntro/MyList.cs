using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> // Type'dan geliyor generics istediğimizi yazabiliriz. bu şu demek my listimde T ile çalışıcam  
    {
        T[] items;
        public MyList()
        {
            //Constructor
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items; // Eski veriyi tut
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
        }
        public int Count
        {
            get { return items.Length; } // Uzunluğunu Alır
        }

        public T[] Items
        {
            get { return items; } // T Elemanları Okur
        }
 
    }
}
