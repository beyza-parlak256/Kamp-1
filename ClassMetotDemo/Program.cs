using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri() { Id = 001, AdSoyad = "Beyza Parlak", MusteriAdresi = "Hatay", HesapNo = 309653214, TcNo = "10000000000" };
            Musteri musteri2 = new Musteri() { Id = 002, AdSoyad = "Ahmet Yılmaz", MusteriAdresi = "İstanbul", HesapNo = 309659842, TcNo = "20000000000" };
            Musteri musteri3 = new Musteri() { Id = 003, AdSoyad = "Mehmet Taş", MusteriAdresi = "Ankara", HesapNo = 309653214, TcNo = "30000000000" };
            Musteri musteri4 = new Musteri() { Id = 004, AdSoyad = "Beyza Güneş", MusteriAdresi = "Erzurum", HesapNo = 309694258, TcNo = "40000000000" };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);
            musteriManager.Add(musteri4);
            Console.WriteLine("*******************************");

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.AdSoyad + " " + musteri.TcNo);
            }
            MusteriManager.List();
        }
    }
}
