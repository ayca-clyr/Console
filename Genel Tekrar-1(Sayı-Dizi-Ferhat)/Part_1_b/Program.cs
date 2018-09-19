using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_b
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lütfen bir değer giriniz :");
            string girilenDeger = Console.ReadLine();
            int deger1 = int.Parse(girilenDeger);
            short deger2 = short.Parse(girilenDeger);
            byte deger3 = byte.Parse(girilenDeger);
            long deger4 = long.Parse(girilenDeger);
        }
    }
}
