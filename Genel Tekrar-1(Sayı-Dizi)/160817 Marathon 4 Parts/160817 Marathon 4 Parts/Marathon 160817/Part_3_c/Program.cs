using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_3_c
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Birinci karakteri girin:");
            char sayı = char.Parse(Console.ReadLine());
            Console.Write("İkinci karakteri girin:");
            char sayı2 = char.Parse(Console.ReadLine());

            bool kontrol = sayı == sayı2;
            bool kontrol2 = sayı != sayı2;
            bool kontrol3 = sayı > sayı2;
            bool kontrol4 = sayı < sayı2;
            bool kontrol5 = sayı >= sayı2;
            bool kontrol6 = sayı <= sayı2;

            Console.WriteLine(sayı + " ile " + sayı2 + " karakterleri birbirine eşittir: " + kontrol);
            Console.WriteLine(sayı + " ile " + sayı2 + " karakterleri birbirine eşittir: " + kontrol2);
            Console.WriteLine(sayı + " karakteri " + sayı2 + " karakterinden büyüktür: " + kontrol3);
            Console.WriteLine(sayı + " karakteri " + sayı2 + " karakterinden büyüktür: " + kontrol4);
            Console.WriteLine(sayı + " karakteri ile " + sayı2 + " karakterinden büyüktür veya eşittir: " + kontrol5);
            Console.WriteLine(sayı + " karakteri ile " + sayı2 + " karakterinden büyüktür veya eşittir: " + kontrol6);

            Console.Read();
        }
    }
}
