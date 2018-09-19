using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_5_d
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir açı değeri giriniz!");
            int a1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen bir açı değeri giriniz!");
            int a2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen bir açı değeri giriniz!");
            int a3 = int.Parse(Console.ReadLine());

            int icAcılarToplamı = a1 + a2 + a3;
            if (icAcılarToplamı == 180 && (a1 < 180 && a1 > 0) && (a2 < 180 && a2 > 0) && (a3 < 180 && a3 > 0))
            {
                Console.WriteLine("Böyle bir üçgen çizilebilir!");
            }
            else
            {
                Console.WriteLine("Yanlış değerler girdiniz!Böyle bir üçgen çizilemez.");
            }
        }
    }
}
