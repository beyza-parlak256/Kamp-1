﻿using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Beyza Parlak
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 2;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Beyza";
            musteri1.Soyadi = "Parlak";
            musteri1.TcNo = "123456789";

            //Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new GercekMusteri();


            // Gerçek Müşteri - Tüzel Müşteri bunlar birbirinin yerine kullanılamaz
            // SOLID




        }
    }
}
