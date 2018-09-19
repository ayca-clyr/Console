using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1 Dizi elemanlarını yan yana yazma : Dizi içerisindeki elemanlar 45 – 928 – 78 – 4 – 1007 – 83 şeklinde yan yana yazdırılır. Elemanlar arasında mutlaka bir ayraç karakter olmalıdır.İlk elemandan önce veya son elemandan sonra ekranda – (veya diğer bir ayraç) karakterinin olmaması gerekiyor.
            /*
            int[] yanyana = { 45, 928, 78, 4, 1007, 8 };
            int i = 0;
            while (i < yanyana.Length)
            {
                if( i != yanyana.Length - 1)
                {
                    Console.Write(yanyana[i] + " - ");
                

                }else
                    Console.Write(yanyana[i]);
                i++;
            }
            */

            // 2.Dizi elemanlarını iki kolonda yazdırma : Dördüncü uygulamada dizi elemanları her satırda iki eleman, arada bir sekme boşluk olacak şekilde ekrana yazdırılır.
            /*ÖRNEK:
            **1 * ***2 * *
            dizi[0]    dizi[1]
            dizi[2]    dizi[3]
            */

            /*
            int[] ikiKolon = { 45, 928, 78, 4, 1007, 8 };
            int j = 0;
            while(j < ikiKolon.Length)
            {
                if(j % 2 == 0) { 
                      Console.Write(ikiKolon[j]+ " " );
                j++;
                }
                else
                {
                    Console.WriteLine(ikiKolon[j]+ " " );
                        j++;
                }
            }
            */

            // 3.Dizi elemanlarını ikinci bir dizi yardımıyla ters sıralayan bir algoritma geliştiriniz.

            /*
            int[] dizi1 = {1, 2, 3,23,45};
            int[] dizi2 = new int[dizi1.Length];
            int sayac = 0;
            while (sayac < dizi1.Length)
            {
                
                    dizi2[sayac] = dizi1[dizi1.Length- 1- sayac];
                   
                        
                Console.WriteLine(dizi2[sayac]);
                sayac++;
            }
            */

            // 4.Dizi elemanlarını ikinci bir dizi olmadan kendi üzerine ters sıralayan bir algoritma geliştiriniz.
            /*
            int[] dizi1 = { 1, 2, 3, 23, 45 };
            
            int sayac = dizi1.Length-1;
            while (sayac < dizi1.Length && sayac >= 0)
            {
                Console.WriteLine(dizi1[sayac]);
                sayac--;
            }
            */
                /*
            int[] dizi1 = {1, 2, 3, 23, 45};

            int sayac = 0;
            while (sayac < dizi1.Length )
            {
                dizi1[sayac] = dizi1[4 - sayac];
                Console.WriteLine(dizi1[sayac]);
                sayac++;
            }

    */     // Ekran görüntüsü 45 23 3 23 45 şeklinde neden 0 ve 1. indisteki değerleri almıyor çözemedim.
        }
    }
}
