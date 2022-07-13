using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodTries
{
    internal class SepetManager
    {
        //naming convention
        //syntax
        public void Ekle(Products urun)
        { 
        Console.WriteLine("Sepete Eklendi: " + urun.Adi);
        }
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokadedi)
        {
            Console.WriteLine("Sepete Eklendi: " + urunAdi);
        }
    }
}
