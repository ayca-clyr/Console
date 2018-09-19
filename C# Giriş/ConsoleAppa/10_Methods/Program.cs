using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Methods
{
    class Program
    {
        static void Main(string[] args)   // Bu bir fonksiyondur.
        {
            Console.WriteLine("Lütfen sırayla iki sayı yazınız");
            Console.Write("Sayı 1 : ");
            int sayı1 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Sayı 2 : ");
            int sayı2 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // int total = sayı1 + sayı2;
            int result = Sum(sayı1, sayı2); // Tip ve sıralama önemli sadece. İçine ne yazdığının önemi yok. Sonuçda isim olarak uyuşmak zorunda değil.

            Console.WriteLine("İki sayının toplamı : {0}", result);



            Console.ReadLine();
        }

        // Fonksiyon (metot) tanımları, Main (veya diğer) fonksiyonun dışında yapılmalıdır.
        // 1) Fonksiyonun dönüş tipi yazılır.  (Olabilirde, olmayabilirde.)
        // 2) Fonksiyonlar Pascal Case ile yazılır. (Harfleri büyük harflerle yazmaya başla.)
        // 3) Fonksion parantezleri 
        // 4) Eğerki varsa parametreler
        // 5) Scope parantezleri   {}
        // 6) Eğer dönüş tipi varsa return ifadesini belirtmek.

        // Metot imzası
        // 1. Metodun ismi
        // 2. Parametre sırası, sayısı
        // 3. Parametrelerin sıralı olarak tipleri

        // Method Overloading : Aynı İSİMDE ancak FARKLI iMZADA (Tür ve ya tür adedi) metodu tekrar tanımlamakdır.

        // Metod Overloading (Birbirinin aşırı yüklemesi) 
        static int Sum(int num1, int num2)
        {
            int total = num1 + num2;

            return total;
        }
        // Metod Overloading (Birbirinin aşırı yüklemesi)
        static double Sum(double num1, double num2)
        {
            double toplam = num1 + num2;
            return toplam;
        }
        // Metod Overloading (Birbirinin aşırı yüklemesi)
        static int Sum(int num1, int num2, int num3)
        {
            int total = num1 + num2 + num3;

            return total;
        }

        // Bu metot Sum metodunun overload'u değildir.
        static int GetTotal(int num1, int num2)
        {
            int total = num1 + num2;

            return total;
        }


    }
}
