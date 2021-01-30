using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // amacımız kendi listemizi yazmak... generics
            MyList<string> isimler = new MyList();
            isimler.Add("Engin");


        }
    }
}
