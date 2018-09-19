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

            /*
            Console.WriteLine("Lütfen bir sayı Giriniz : ");
            Console.WriteLine("Sayı1 : ");

            int sayı1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Sayı2 : ");

            int sayı2 = int.Parse(Console.ReadLine());

            int sonuc = SquareOf(sayı1);
            */
            /*
            string name = "    Ayça     Calayır    ";
            string trimmedValue = Trim(name);
            Console.WriteLine(trimmedValue);
            */

            string name = "    Tsubasa     Ozara   Golcüdür   ";
            string trimmedValue = FullTrim(name);
            Console.WriteLine(trimmedValue);

        }

        static int SquareOf(int sayı)
        {
            sayı = sayı * sayı;

            return sayı;
        } // 1

        static double SquareOf(double sayı)
        {
            double karesi = sayı * sayı;
            return karesi;
        } // 2

        static int CureOf(int sayı) // 3
        {
            sayı = sayı * sayı * sayı;
            return sayı;
        }

        static double CareOf(double sayı) // 4
        {
            sayı = sayı * sayı * sayı;
            return sayı;
        }
        static int PowerOf(int sayı1, int sayı2) // 5
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

        static int Absolute(int sayı) // 6
        {
            if (sayı < 0)
            {
                sayı = -sayı;
            }
            return sayı;
        }

        static double Absolute(double sayı)  // 7
        {
            if (sayı < 0)
            {
                sayı = -sayı;
            }
            return sayı;
        }

        static bool IsPositive(int sayı) // 8
        {
            //return sayı > 0;
            if (sayı > 0)
            {
                return true;
            }
            return false;

        }
        static bool IsNegative(int sayı) // 9
        {
            // return sayı < 0
            if (sayı < 0)
            {
               return true;
            }

            return false;
        }

        static int ReverseArray(int[] dizi1, int[] dizi2) // 10_1
        {
            int sayac = 0;
            while (sayac < 0)
            {

                dizi2[sayac] = dizi1[dizi1.Length - 1 - sayac];
                sayac++;
            }
            return dizi2[sayac];

        }
        static string ReverseArray(string[] dizi1, string[] dizi2) // 10_2
        {
            int sayac = 0;
            while (sayac < 0)
            {

                dizi2[sayac] = dizi1[dizi1.Length - 1 - sayac];
                sayac++;
            }
            return dizi2[sayac];

        }

        static char ReverseString(string kelime) // 11
        {
            int i = 0;
            char[] ters = new char[kelime.Length];
            while (i < kelime.Length)
            {
                ters[i] = kelime[kelime.Length - i - 1];
                i++;
            }


            return kelime[i];
        }

        // Sol taraftaki boşluklardan sonra ilk normal (Boşluktan farklı) karakterin indexini buluyoruz.
        static string Trim(string kelime) // 12-Stringde bir dizi olarak index kullandığımızda onu char olarak çağırmamız gerekiyor.
        {
            int index = 0;
            while (index < kelime.Length)
            {
                if (kelime[index] != ' ')
                    break;
                index++;
            }
            // Bu aşamada index değerini bulduk.

            // İlk karakterden itibaren geriye kalan tüm karakterleri yeni bir string değişkende (leftTrimmed) topladık.
            string leftTrimmed = string.Empty;
            int counter = index;
            while (counter < kelime.Length)
            {
                leftTrimmed += kelime[counter];
                counter++;
                // counter += 1;
            }
            // leftTrimmed hazır.

            //Sağdan başlayarak boşluk karakterlerini atladık,ilk normal(Boşluktan farklı) karakteri bulduğumuzda döngüyü sonlandırdık.
            index = leftTrimmed.Length - 1;
            while (index >= 0)
            {
                if (leftTrimmed[index] != ' ')
                    break;
                index--;
            }
            // İndex değerini elde ettik.

            // Baştan başlayarak sağ taraftaki boşluklara kadar olan kısmı yeni bir string değişkende (trimmed) topladık.
            string trimmed = string.Empty;
            counter = 0;
            while (counter <= index)
            {
                trimmed += leftTrimmed[counter];
                counter++;
            }
            // trimmed değişkeni, elde etmek istediğimiz değerdir.

            return trimmed;
        }

        static string FullTrim(string value) // 13
        {
            int index = 0;
            string fullTrimmed = string.Empty;   // ""; demekle aynıdır.
            int spaceCounter = 0;
            while (index < value.Length)
            {
                if (value[index] != ' ')
                {
                    if (spaceCounter > 0)
                    {
                        spaceCounter = 0;
                        if (fullTrimmed.Length > 0)
                        {
                            fullTrimmed += ' ';
                        }
                    }
                    fullTrimmed += value[index];
                }
                else
                {
                    spaceCounter++;
                }

                index++;
            }
            return fullTrimmed;
        }



    }

}

