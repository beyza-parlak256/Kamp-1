using System;
using System.Collections.Generic;
using System.Text;

// Bu class da ürünle ilgili operasyonlar bulunmaktadır.
// Ekleme, silme, listeleme, arama, filtreleme vb.

namespace OOP1
{
    class ProductManager
    {
        // encapsulation
        // void -> yap ve bitir
        public void Add(Product product) // Product türünde product ver demek
        {
            Console.WriteLine(product.ProductName + " eklendi");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi");
        }

        public int topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public void topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1+sayi2);
        }

    }
}
 