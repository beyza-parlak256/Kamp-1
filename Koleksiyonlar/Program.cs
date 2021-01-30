using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // ctrl+k +ctrl+c -> toplu command alma
            //string[] isimler = new string[] {"Beyza", "Aslı", "Şevkiş", "Betül",
            //"M. Mustafa", "Mustafa" }; // 101.adreste
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[5]);

            //isimler = new string[7]; // isimlerin adresini 102. adrese eşitledik
            //isimler[7] = "X"; // isimlerin 7. elemanını X yaptık
            //Console.WriteLine(isimler[6]);
            //Console.WriteLine(isimler[4]);

            List<string> isimler2 = new List<string> { "Beyza", "Aslı", "Şevkiş", "Betül"
                , "M. Mustafa", "Mustafa" };

            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[5]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[6]);
            Console.WriteLine(isimler2[0]);
        }
    }
}
