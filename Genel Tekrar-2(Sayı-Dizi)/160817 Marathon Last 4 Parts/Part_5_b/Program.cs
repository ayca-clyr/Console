using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_5_b
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Girdiğiniz 3 adet sayıdan en büyük sayıyı bulan program");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Birinci sayıyı giriniz:");
            int sayı = int.Parse(Console.ReadLine());

            Console.Write("İkinci sayıyı giriniz:");
            int sayı2 = int.Parse(Console.ReadLine());

            Console.Write("Üçüncü sayıyı giriniz:");
            int sayı3 = int.Parse(Console.ReadLine());

            if (sayı >= sayı2 && sayı >= sayı3)
            {
                Console.Write("En büyük sayı: " + sayı+" sayısıdır.");
            }
            else if (sayı2 >= sayı && sayı2 >= sayı3)
            {
                Console.Write("En büyük sayı: " + sayı2 + " sayısıdır.");
            }
            else if (sayı3 >= sayı && sayı3 >= sayı2)
            {
                Console.Write("En büyük sayı: " + sayı3 + " sayısıdır.");
            }
            Console.Read();
        }
    }
}
