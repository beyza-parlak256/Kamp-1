using System;
class MainClass
{
    public static void Main(string[] args)
    {

        // type safety -> tip güvenliği 
        // Do not repeat yourself -> Kendini tekrarlama !!!

        string kategoriEtiketi = "Kategori";
        int ogrenciSayisi = 32000;
        double faizOrani = 1.45;
        bool sistemeGirisYapmisMi = false;

        double dolarBugun = 7.35;
        double dolarDun = 7.25;

        if (dolarDun > dolarBugun)
        {
            Console.WriteLine("Azalış butonu");
        }
        else if (dolarDun < dolarBugun)
        {
            Console.WriteLine("Artış butonu");
        }
        else
        {
            Console.WriteLine("Değişmedi butonu");
        }

        /*
        if(sistemeGirisYapmisMi == true)
        {
          Console.WriteLine("Kullanıcı ayarları butonu");
        } 
        else
        {
          Console.WriteLine("Giriş yap butonu");
        }
        */


    }
}