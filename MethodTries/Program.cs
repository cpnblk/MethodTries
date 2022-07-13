using System;

namespace MethodTries
{
    class Program
    {
        static void Main(string[] args)
        {

            Products urun1 = new Products();
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "yesil elma";

            Products urun2 = new Products();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "yesil karpuz";

            Products[] urunler = new Products[] { urun1, urun2 };

            //type-safe -- tip güvenli
            foreach (var urun in urunler) //urun yerine x de yazsan olur
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------");
            }

            Console.WriteLine("hi methodlar");
            Console.WriteLine("---------------");

            //instance örnek
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
             
            //product.cs ye ekstra colmn eklemeye encapsulation 
            //deniyo ürünAdi + fiati + stok adedi + aciklaması + üretim yili

            sepetManager.Ekle2("armut", "yesil armut", 12, 10);
            sepetManager.Ekle2("kiraz", "yesil kiraz", 9, 12);
            sepetManager.Ekle2("ananas", "yesil ananas", 23, 8);

        }
    }
}
