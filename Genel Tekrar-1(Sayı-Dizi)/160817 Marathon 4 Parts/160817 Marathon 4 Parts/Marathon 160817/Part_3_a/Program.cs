using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_3_a
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Birinci ismi girin:");
            string isim = Console.ReadLine();
            Console.Write("ikinci ismi girin:");
            string isim2 = Console.ReadLine();
            bool kontrol=isim==isim2;
            bool kontrol2 = isim != isim2;

            Console.WriteLine(isim + " ile " + isim2 +" değerleri birbirine eşittir: " + kontrol);
            Console.Write(isim + " ile " + isim2 +" değerleri birbirine eşit değildir: " + kontrol2);
            Console.Read();

            
           
           
        }
    }
}
