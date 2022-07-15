using System;

namespace Oop1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitInStock = 5, ProductName = "Kalem", UnitPrice = 35 };
            //PascalCase   //camelCase
            //stack        //heap
            //&1->sayilar1     //[1, 2, 3]
            //&2->sayilar2     //[100,200,30]
            //sayilar1         //[1, 2, 3] -> goes 2 garbage
            //sayilar2         //[999,200,30]
            //&2->sayilar1     //[999, 200, 30]
            //&2->sayilar2     //[999,200,30]
            //case sensitive
            //heapte oluşabilmesi için böle yazıyoz
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);//kamera

            /*  int sayi = 100;
              productManager.BiseyYap(sayi);
              Console.WriteLine(sayi); //100

              //int, double, bool .. deger tip
              //dizi, class, abstract class, interface ... referance type
              //ref out keywordleri
             */

            /*
            productManager.Topla2(3, 6);
            //son satırda cikan toplami baska biyerde daha 
            //kullanmak istedigimiz icin return ü kullaniyoruz
            //baska biyerde kullanmak istemezssek voidli yazabiliriz
            //bankacilik islemlerinde bu isimize yarıyo
            //total miktar üzerinden islem yapabilmek önemli

            int toplamaSonucu = productManager.Topla(3, 2);
            Console.WriteLine(toplamaSonucu*2);
            Console.WriteLine(productManager.Topla(3,7)*2);
          */
        }
    }
}