using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi: " + musteri.AdSoyad);
        }
        public void Remove(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi: " + musteri.AdSoyad);
        }
        public void Update(Musteri musteri)
        {
            Console.WriteLine("Müşteri güncellendi: " + musteri.AdSoyad);
        }
        public void List(Musteri[] musteris)
        {
            Console.WriteLine("Müşteri listelendi: ");
        }

        internal static void List()
        {
            throw new NotImplementedException();
        }
    }
}
