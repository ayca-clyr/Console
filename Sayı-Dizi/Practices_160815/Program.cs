using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices_160815
{
    class Program
    {
        static void Main(string[] args)
        {
    // 1) Bir tamsayının karesini bulan metodu yazın : SquareOf()
    // 2) Bir ondalıklı sayının karesini bulan metodu yazınız. SquareOf()
    // 3) Bir tamsayının küpünü bulan metodu yazın : CubeOf()
    // 4) Bir ondalıklık sayının küpünü bulan metodu yazın : CubeOf()
    // 5) Bir tamsayının, tamsayı olarak verilen kuvvetini bulan ve sonucu tamsayı olarak döndüren metodu yazın: PowerOf()
    // 6) Bir tamsayının mutlak değerini hesap eden ve sonucu tamsayı olarak döndüren metodu yazın: Absolute()
    // 7) Bir ondalıklı sayının mutlak değerini hesaplayan ve sonucu yine ondalıklı sayı olarak döndüren metodu yazın: Absolute()
    // 8) Bir sayının pozitif olup olmadığını kontrol eden, eğer ki pozitif ise true değerini döndüren metodu yazın: IsPositive()
    // 9) Bir sayının negatif olup olmadığını kontrol eden, eğer ki sayı negatif ise true değerini döndüren metodu yazın: IsNegative()
    // 10) Bir dizinin elemanlarını ters çeviren ve sonucu yeni bir dizi olarak döndüren metodu yazın: ReverseArray()
    // 11) Bir string değerinin karakterlerini ters çeviren ve sonucu yeni bir string olarak döndüren metodu yazın: ReverseString()
   
    // 12) Bir string ifadede yer alabilecek sağ ve sol boşlukları silip, yeni string ifadeyi döndüren Metodu yazınız: Trim()
    /*Örnek: "   Tsubasa     Ozora     " gibi bir ifadenin çıktısı "Tsubasa     Ozora" olacak */
    // 13) Bir string ifadede yer alabilecek sağ, sol ve orta kısımdaki gereksiz boşlukları silip yeni string ifadeyi döndürecek metodu yazınız: FullTrim()
    /*Örnek: "   Tsubasa     Ozora     " gibi bir ifadenin çıktısı "Tsubasa Ozora" olarak. Sağ ve sol boşluklar tamamen silinecek, ortadaki fazlalık boşluklar tek boşluk karakterine dönüştürülecek. */
    // 14) Bir string ifadeyi aradaki boşluklara ve/veya noktalama işaretlerine göre bölen ve kelimeleri bir string dizisi olarak döndüren metodu yazınız: GetWords()
    /* Örnek: "C# güçlü, modern ve nesne yönelimli bir programlama dilidir" cümlesinin çıktısı: { "C#", "güçlü", "modern", "ve", "nesne", "yönelimli", "bir", "programlama", "dilidir" } elemanlarına sahip bir dizi olacaktır.*/

            Console.WriteLine("Lütfen bir sayı Giriniz : ");
            Console.WriteLine("Sayı1 : ");

            int sayı1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Sayı2 : ");

            int sayı2 = int.Parse(Console.ReadLine());

            int sonuc = SquareOf(sayı1);

        }

        static int SquareOf(int sayı)
        {
           sayı = sayı * sayı;
            
            return sayı;
        }

        static double SquareOf(double sayı)
        {
            double karesi = sayı * sayı;
            return karesi;
        }

        static int CureOf(int sayı)
        {
            sayı = sayı * sayı * sayı;
            return sayı;
        }

        static double CareOf(double sayı)
        {
            sayı = sayı * sayı * sayı;
            return sayı;
        }
        static int PowerOf(int sayı1, int sayı2)
        {
            int i = 0;
            int sonuc = 1;
            while (i < sayı2)
            {
                sonuc = sonuc * sayı1;
               i++;
            }


            return sonuc;

            
            
        }

        static int Absolute(int sayı)
        {
            if(sayı < 0){
                sayı = -sayı;
            }
            return sayı;
        }

        static double Absolute(double sayı)
        {
            if (sayı < 0)
            {
                sayı = -sayı;
            }
            return sayı;
        }

        static bool IsPositive(int sayı)
        {
            bool deger = false;
            if (sayı > 0)
            {
                deger = true;
            }
            return deger;

            }
        static bool IsNegative(int sayı){
            bool deger = false;
            if(sayı < 0){
                deger = true;
            }

            return deger;
        }

        static int ReverseArray(int[] dizi1, int[] dizi2)
        {
            int sayac = 0;
            while (sayac < 0) {

            dizi2[sayac] = dizi1[dizi1.Length - 1 - sayac];
            sayac++;
            }
            return dizi2[sayac];

        }
        static string ReverseArray(string[] dizi1, string[] dizi2)
        {
            int sayac = 0;
            while (sayac < 0)
            {

                dizi2[sayac] = dizi1[dizi1.Length - 1 - sayac];
                sayac++;
            }
            return dizi2[sayac];

        }

        static char ReverseString(string kelime)
        {
            int i = 0;
            char[] ters = new char[kelime.Length];
            while(i < kelime.Length)
            {
                ters[i] = kelime[kelime.Length - i - 1];
                i++;
            }
           

            return kelime[i];
        }





        }

    }

