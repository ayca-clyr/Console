using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_7_g
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen 1. Dizi Elemanını Giriniz");
            string eleman1 = Console.ReadLine();

            Console.WriteLine("Lütfen 2. Dizi Elemanını Giriniz");
            string eleman2 = Console.ReadLine();

            Console.WriteLine("Lütfen 3. Dizi Elemanını Giriniz");
            string eleman3 = Console.ReadLine();

            Console.WriteLine("Lütfen 4. Dizi Elemanını Giriniz");
            string eleman4 = Console.ReadLine();

            Console.WriteLine("Lütfen 5. Dizi Elemanını Giriniz");
            string eleman5 = Console.ReadLine();

            string[] dizi = new string[5];

            dizi[0] = eleman1;
            dizi[1] = eleman2;
            dizi[2] = eleman3;
            dizi[3] = eleman4;
            dizi[4] = eleman5;

        }
    }
}
