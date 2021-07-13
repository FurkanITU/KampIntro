using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class Mydict<T>
    {
        T[] items;
        public Mydict()
        {
            items = new T[0];
        }
        public void Add(T item) 
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];

            for (int i = 0; i < items.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
        }
    }
}
