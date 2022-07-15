using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class MyList<T>
    {
        //string[] items; dogru degil
        T[] items;
        //normalde liste oluşturulduğunda
        //c# da bu listelerin bir uzunluğu oluyo
        //eger biz bu listeleri oluşturduğumuzda
        //bu listenin lengtini belirlemezsek
        //ve lengtini yazdırmak istersek
        //ekrana lengti 0 yazdırır.
        //eger bastan liste gibi bişey oluşturcaksak
        //class icinde bunu tanımlamalıyız 
        //T tipinde items adli array ollacak sekilde
        //0 elemanli bile olsa
        //*ctor tab tab yaparsak contructorlar olusur.*
        //kendimiz list gibi bişey yapcaksak bu şekilde
        //constructor kullanmalıyiz

        //constructor
        public MyList()
        {
            items = new T[0]; 
        }
        public void Add(T /*istenilen tip (str int void etc) */ item)
        {
            //list arka planda 1 arrayi yönetir
            //items[1] diyemeyiz bu syaiyiy 1 artirmak lazım
            T[] tempArray = items;
            //yalnzica as daki gibi yaparsak
            //yeni referans no alır
            //yeni referans no demek
            //önceki refdeki degerlerin 
            //ucmasi anlamina gelir
            //bu sebeple items gecici array olan
            //tempArray e emanet edilir
            items = new T[items.Length+1];
            //items el sayisi 2
            //temp arrayin eleman sayisi 1
            //burda temparraye emanet eden elemanları
            //geri istemek için ve almak için
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
                //diyelimki temp arrda
                //i d s n var
                //itemsa 1 ekleniyo yabi 5 el oluşuyo
                //fakat i d s n yok oluyo artı 1 boş kutucuk oluşuyo

            }
            items[items.Length - 1] = item; 

        }

        public int Length
            { get { return items.Length; } }
        
        //elemanlari görmek ıstersek
        public T[] Items
        { get { return items; } }
    }
}
