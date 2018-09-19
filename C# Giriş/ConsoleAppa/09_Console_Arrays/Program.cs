using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Console_Arrays{
    class Program{
        static void Main(string[] args){


            // Arrays (Diziler)

            int sayi = 6;
            string metin = "diziler";

            // Bir sınıfa ait kişilerin isimleri :
                //string adSoyad1, adSoyad2, adSoyad3, ...  adSoyadN

            // Bir sınıftaki kişilerin not oralamaları :

            // int sayı;  cw'de yazdırsak ,ilk değer 0 değildir. Bunun nedeni RAM'de adres tutar ama yer ayırmaz. Dizilerde ise RAM'de yeni bir dizi oluştur ve RAM'de yer ayır. Ayırdığı içinde her değerin ilk değeri 0'dır.
            /*
            int[] sınıfNotları = new int[15];
            sınıfNotları[0] = 30;
            sınıfNotları[1] = 29;
            sınıfNotları[2] = 79;
            sınıfNotları[3] = 11;
            sınıfNotları[4] = 100;
            sınıfNotları[14] = 1;
            sınıfNotları[5] = 12;
            sınıfNotları[6] = 123;
            sınıfNotları[7] = 14;
            */
            //Console.WriteLine(sınıfNotları[0]);
            //Console.WriteLine(sınıfNotları[2]);
            //Console.WriteLine(sınıfNotları[3]);
            //Console.WriteLine(sınıfNotları[4]);
            //Console.WriteLine(sınıfNotları[12]);
            //Console.WriteLine(sınıfNotları[9]);

            /*
            int index = 0;

            while (index < 15)
            {
                if(sınıfNotları[index] != 0)
                Console.WriteLine(sınıfNotları[index]);  // [] içinde index ile ilgili işlem bile yapabiliriz.
                index++;
                //index += 2;
            }

            */


            /* 
            int a = new int();     // a'nın ilk değeri 0 olur. Çünkü new diyerek yeni bir int değer oluştur ve RAM'de yer tuttu.
            Console.WriteLine(a);
            */

            // int[] sınıfNotları = new int[15];
            /*
            int[] sınıfNotları2 = new int[10] {2,5,9,0,11,23,44,53,100,10};
            int[] sınıfNotları3 = new[] { 2, 5, 9, 0, 11, 23, 44, 53, 100, 10 };
            int[] sınıfNotları4 = { 2, 5, 9, 0, 11, 23, 44, 53, 100, 10 };

            string[] mevsimler = new string[4] { "ilkbahar", "yaz", "sonbahar", "kış" };

            int index = 0;
            while (index < mevsimler.Length)
            {
                Console.WriteLine(mevsimler[index]);
                index++;
            }
            */
            // 1) 10 elemanlı bir sayı dizinin ortalamasını hesaplayınız.  

            /*
            int[] sayılar = new int[10] { 2, 5, 9, 0, 11, 23, 44, 53, 100, 10 };
            int i = 0;
            int toplam = 0;
            int ortalama = 0;
            while (i < 10)
            {
                toplam = toplam + sayılar[i];
                 
                    i++;
            }
            ortalama = toplam / sayılar.Length;
            Console.WriteLine(ortalama);
            */

            // 2) 5 elemanlı bir sayı dizisini büyükten küçüğe sıralayınız.

            int[] diziElemanları = new int[5] { 23, 5, 78, 20, 1 };
            int i = 0;
            bool durum = true;
            int kova;

            while (durum) {
                durum = false;
            while(i < diziElemanları.Length - 1){
                
                if (diziElemanları[i] > diziElemanları[i + 1])    // < dersek küçükten büyüğe sıralama yapmış oluruz.


































































































































































































































































































































































































                {
                    kova = diziElemanları[i];
                    diziElemanları[i] = diziElemanları[i + 1];
                    diziElemanları[i + 1] = kova;
                    durum = true;
                }
 
                i++;
               
                
            }

            i = 0;
            }

            int index = 0;
            while (index < diziElemanları.Length)
            {
                Console.WriteLine(diziElemanları[index] + ", ");
                index++;
            }
           
            
        }
    }
}
