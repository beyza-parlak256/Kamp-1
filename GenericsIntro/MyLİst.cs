using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    // <T> genelde tek değer aldığı için yazılır ama herhangi bir harf olabilir
    class MyList<T> 
    {
        T[] items;
        // constructor
        public MyList() 
        {
            items = new T[0];
        }
        // item genel olarak yazıldı istediğini yazabilirsin
        public void Add(T item) 
        {
            // geçici dizinin referansı, items ın referansıdır
            T[] tempArray = items;
            // dizinin eleman  sayısını 1 arttırıyoruz
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                // tempArray e verdiğimiz değeri items a geri veriyoruz
                items[i] = tempArray[i]; 
            }
            // aslında istenen elemanı bu kod ile ekleyebildik
            items[items.Length - 1] = item;
        }
    }
}
