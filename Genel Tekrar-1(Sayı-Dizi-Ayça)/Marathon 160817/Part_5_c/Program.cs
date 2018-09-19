using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_5_c
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir kenar uzunluğu giriniz!");
            float k1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen bir kenar uzunluğu giriniz!");
            float k2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen bir kenar uzunluğu giriniz!");
            float k3 = float.Parse(Console.ReadLine());

            float birIki = k1 - k2;
            float ikiUc = k2 - k3;
            float birUc = k1 - k3;


            if (k1 - k2 < 0 || k2 - k3 < 0 || k1 - k3 < 0)
            {
                birIki = -birIki;
                birUc = -birUc;
                ikiUc = -ikiUc;
                if ((k1 < (k2 + k3) && k1 > (k2 - k3)) && (k2 < (k1 + k3) && k2 > (k1 - k3)) && (k3 < (k1 + k2) && k3 > (k1 - k2)))
                {
                    Console.WriteLine("Böyle bir üçgen çizilebilir!");
                }
            }
            else
            {
                Console.WriteLine("Yanlış değerler girdiniz!Böyle bir üçgen çizilemez.");
            }
        }
    }
}
