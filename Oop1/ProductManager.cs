using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//crud oplarini iceren class
namespace Oop1
{
    internal class ProductManager
    {
        //encapsulation Product product product dot atrr1 attr2 yazabilmek icin
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");

        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " guncellendi.");

        }


        /*
         //neden void ve return var
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;

        }
        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);

        }

        */
        /* public void BiseyYap(int sayi)
         {
             sayi = 99;
         }*/


        /*
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;

        }
        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);

        } */
    }
}
