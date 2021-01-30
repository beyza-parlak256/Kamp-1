using System;
class MainClass
{
    public static void Main(string[] args)
    {

        string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
        string kurs2 = "Programlamaya başlamak için temel kurs";
        string kurs3 = "Java";

        // array -> dizi
        string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya başlamak için temel kurs", "Java", "Python" };

        for (int i = 0; i < kurslar.Length; i++)
        {
            Console.WriteLine(kurslar[i]);
        }

        Console.WriteLine("for bitti...");

        // foreach dizileri kolay dolaşmaya yarar
        foreach (string kurs in kurslar)
        {
            Console.WriteLine(kurslar);
        }

        Console.WriteLine("sayfa sonu - footer");
    }
}