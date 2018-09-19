using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_5_f
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir kenar uzunluğu giriniz!");
            int a1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen bir kenar uzunluğu giriniz!");
            int a2= int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen bir kenar uzunluğu giriniz!");
            int a3 = int.Parse(Console.ReadLine());

            if ((a1 == 90 && (a2 + a3) == 90) || (a2 == 90 && (a1 + a3) == 90) || (a3 == 90 && (a1 + a2) == 90))
            {
                // if içine a1 a2 a3 ün > 0'dan büyük olma koşullarıda eklenebilir.
                Console.WriteLine("Bu Üçgen Dik Üçgendir!");
            }
            else
            {
                Console.WriteLine("Bu üçgen Dik üçgen Değildir!");
            }
        }
    }
}
