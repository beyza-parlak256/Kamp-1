using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad = "Beyza";
            int yas = 21;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmeni = "Beyza Parlak";
            kurs1.IzlenmeOranı = 50;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C";
            kurs2.Egitmeni = "Ahmet A";
            kurs2.IzlenmeOranı = 40;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmeni = "Mehmet M";
            kurs3.IzlenmeOranı = 100;

            // Console.WriteLine(kurs1.Egitmeni + " : " + kurs1.KursAdi);
            // Console.WriteLine(kurs2.Egitmeni + " : " + kurs2.KursAdi);
            // Console.WriteLine(kurs3.Egitmeni + " : " + kurs3.KursAdi);
            // böyle yazmak yerine kurs array inde yazacağız

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            // array içinde geziniyoruz
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.Egitmeni + " : " + kurs.KursAdi);
            }

        }
    }
    class Kurs
    {
        // prop -> özellik
        // Bu kursun 3 özelliği vardır
        public string KursAdi { get; set; }
        public string Egitmeni { get; set; }
        public int IzlenmeOranı { get; set; }
    }
}
