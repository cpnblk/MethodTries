using System;

namespace GenericsIntro
{
    class Program
    { 
        static void Main(string[] args)
        {
            MyList<string>/*string, int, Product classlari turunde yazilabilir*/ isimler = new MyList<string>();
            isimler.Add("isil");

            /*List<string> liste = new List<string>();
            Console.WriteLine(liste.Count);*/
            Console.WriteLine(isimler.Length);
            isimler.Add("Kerem");
            Console.WriteLine(isimler.Length);

            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }

            Console.WriteLine("hi");
        }
    }
        
}