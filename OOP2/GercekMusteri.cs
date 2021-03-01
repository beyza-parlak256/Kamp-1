using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    // Individual
    // miras : müşterinin içinde olan tüm özellikler gerçekde de kabul edilir
    class GercekMusteri :Musteri // inheritance
    {
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
