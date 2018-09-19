using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_5_e
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir kenar uzunluğu giriniz!");
            int k1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen bir kenar uzunluğu giriniz!");
            int k2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen bir kenar uzunluğu giriniz!");
            int k3 = int.Parse(Console.ReadLine());

            if ((k1 > k2 && k1 > k3 && k1* k1 == (k2* k2) + (k3 *k3)) || (k2 > k1 && k2 > k3 && k2 * k2 == (k1 * k1) + (k3 * k3)) || (k3 > k2 && k3 > k1 && k3 * k3 == (k2 * k2) + (k1 * k1)))
            {
                Console.WriteLine("Bu Üçgen Dik Üçgendir!");
            }
            else
            {
                Console.WriteLine("Bu üçgen Dik üçgen Değildir!");
            }
        }
    }
}
