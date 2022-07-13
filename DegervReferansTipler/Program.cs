using System;

namespace DegervReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hi");

            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;
            sayi2 = 65;

            Console.WriteLine(sayi1); //20

            int[] sayilar1 = new int[] {10,20,30}; 
            int[] sayilar2 = new int[] {100,200,300};
            sayilar1 = sayilar2;
            sayilar2[0] = 999;

            Console.WriteLine(sayilar1[0]); //999

            //bellekte 2 tip var
            //1. seneryoda stack
            //sayı 1 sayı 2 olduğunda sayı 2 ile iş bitiyo 
            //2. seneryoda heap
            //

        }
    }
}