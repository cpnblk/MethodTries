using System;
using System.Collections.Generic; //for list

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        { //ctrl k ctrl c commend ctrlk ctrl u remove commend
            /*
            string[] isimler = new string[] { "isil", "damla", "semra", "nuri" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);
            isimler = new string[5];
            isimler[4] = "ilker";
            Console.WriteLine(isimler[4]);
            Console.WriteLine(isimler[0]);
            
             * calisir ama duzgun calismaz
             * bambaska bir adresti new string 
             * hop adresini degistirdik
            isimler = new string[5];
            isimler[4] = "ilker";
            Console.WriteLine(isimler[4]);
            Console.WriteLine(isimler[0]); --> ciktida var ama bosluk olusur cunku isimlerin adresi degisiyor
            bu sebeple kolleksiyonlar olustu
            arrayi kullanmıyoruz
            */
            List<string> isimler2 = new List<string> { "isil", "damla", "semra", "nuri" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("ilker"); //eleman sayısı bir artar ve ilker eklenmiş olur
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            //isimler2 list olduğundan dot tan sonra birsuru fonks cıkıyo
            //eger c# da list olmasaydı kendi collections larımzıı
            //nası yazardıık?
        }
    }
}
