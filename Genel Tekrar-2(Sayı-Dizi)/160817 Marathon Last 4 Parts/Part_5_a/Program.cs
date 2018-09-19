using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_5_a
{
    class Program
    {
        static void Main(string[] args)
        {
          

            Console.WriteLine("Girilen 2 sayıdan ikinci girilen değerin birinci girilen değerin tam katı olup olmadığını bulan program. ");
            Console.WriteLine("Not:İlk girdiğiniz sayı ikinci girdiğiniz sayıdan küçük olmalı");
            Console.WriteLine();
            Console.Write("Birinci sayıyı giriniz:");
            int sayi = int.Parse(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz:");
            int sayi2 = int.Parse(Console.ReadLine());
            int result = sayi2 % sayi;
            if (sayi < sayi2)
            {
                if (result == 0)
                {
                    Console.WriteLine("{0} sayısı {1} sayısının tam katıdır.", sayi2, sayi);
                }
                else
                {
                    Console.WriteLine("{0} sayısı {1} sayısının tam katı değildir.", sayi2, sayi);
                }

            }
            else
            {
                Console.Write("Yanlış giriş yaptınız.");
            }
            Console.Read();
        }
    }
}
