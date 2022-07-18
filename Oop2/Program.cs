using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "isil";
            musteri1.Soyadi = "bardakci";
            musteri1.TcNo = "10012782900";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "12346";
            musteri2.SirketAdi = "abo.com";
            musteri2.VergiNo = "1234567890";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            
            
        }
    }
}

/*
 * gegrcek musteri - tuzel musteri tipi vardır
 * boyle tip gerektiren durumlarda
 * musteri tipi diyip = 1 2 seklinde oluşturmamamk gerek 
 * çünkü gercek musteri tuzel musteri gibi tuzel musteri 
 * ise gercek musteri gibi davranır.
 * 
 */
//today topic:
/*
 * 
 */