﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    // Coorporate
    // miras : müşterinin içinde olan tüm özellikler tüzelde de kabul edilir
    class TuzelMusteri:Musteri //miras inheritance
    {
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
        
    }
}
