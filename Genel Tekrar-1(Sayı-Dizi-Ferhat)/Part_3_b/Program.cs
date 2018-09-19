using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_3_b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen 1. tam sayı değerini giriniz :");
            int sayı1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen 2. tam sayı değerini giriniz :");
            int sayı2 = int.Parse(Console.ReadLine());

            bool deger1 = sayı1 == sayı2;
            Console.WriteLine(!deger1);

            bool deger2 = sayı1 != sayı2;
            Console.WriteLine(deger2);

            bool deger3 = sayı1 < sayı2;
            Console.WriteLine(!deger3);

            bool deger4 = sayı1 > sayı2;
            Console.WriteLine(!deger4);

            bool deger5 = sayı1 < sayı2;
            Console.WriteLine(!deger5);

            bool deger6 = sayı1 <= sayı2;
            Console.WriteLine(!deger6);

            bool deger7 = sayı1 >= sayı2;
            Console.WriteLine(!deger7);

            




        }
    }
}
