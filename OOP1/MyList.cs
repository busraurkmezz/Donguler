using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{

    class MyList<T>
    {
        T[] items;                      //arka planda yöneteceğim şey
        public MyList()
        {
            items = new T[0];
        }


        public int Count
        {
            get { return items.Length; }
        }

        public void Add(T item)
        {
            T[] tempArray = items;              //elemanlar kaybolmayacak burda tutulacak
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
    }
}
