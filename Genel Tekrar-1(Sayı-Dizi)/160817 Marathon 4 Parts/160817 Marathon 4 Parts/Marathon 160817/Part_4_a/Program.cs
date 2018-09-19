using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_4_a
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.Write("Birinci sayıyı giriniz: ");
            int sayı = int.Parse(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz: ");
            int sayı2 = int.Parse(Console.ReadLine());
            Console.Write("üçüncü sayıyı giriniz: ");
            int sayı3 = int.Parse(Console.ReadLine());


            bool kontrol = sayı == sayı2 && sayı2 == sayı3;
            bool kontrol2 = sayı != sayı2 && sayı2 != sayı3;
            bool kontrol3 = sayı > sayı2 && sayı > sayı3;
            bool kontrol4 = sayı >= sayı2 && sayı >= sayı3;
            bool kontrol5 = sayı < sayı2 && sayı < sayı3;
            bool kontrol6 = sayı <= sayı2 && sayı2 <= sayı3;
            bool kontrol7 = sayı2 > sayı && sayı2 > sayı3;
            bool kontrol8 = sayı2 >= sayı && sayı2 >= sayı3;
            bool kontrol9 = sayı2 < sayı && sayı2 < sayı3;
            bool kontrol10 = sayı2 <= sayı && sayı2 <= sayı3;
            bool kontrol11 = sayı3 > sayı && sayı3 > sayı2;
            bool kontrol12 = sayı3 >= sayı && sayı3 >= sayı2;
            bool kontrol13 = sayı3 < sayı && sayı3 < sayı;
            bool kontrol14 = sayı3 <= sayı && sayı3 <= sayı2;

            Console.WriteLine(sayı + ", " + sayı2 + " ve " + sayı3 + " sayıları birbirine eşittir:" + kontrol);
            Console.WriteLine(sayı + ", " + sayı2 + " ve " + sayı3 + " sayıları birbirine eşit değildir:" + kontrol2);
            Console.WriteLine(sayı + "sayısı " + sayı2 + " ve " + sayı3 + " sayılarından büyüktür: " + kontrol3);
            Console.WriteLine(sayı + "sayısı " + sayı2 + " ve " + sayı3 + " sayılarından büyüktür veya sayılara eşittir: " + kontrol4);
            Console.WriteLine(sayı + "sayısı " + sayı2 + " ve " + sayı3 + " sayılarından küçüktür: " + kontrol5);
            Console.WriteLine(sayı + "sayısı " + sayı2 + " ve " + sayı3 + " sayılarından küçüktür veya sayılara eşittir: " + kontrol6);
            Console.WriteLine(sayı2 + " sayısı " + sayı + " ve " + sayı3 + " sayılarından büyüktür:" + kontrol7);
            Console.WriteLine(sayı2 + " sayısı " + sayı + " ve " + sayı3 + " sayılarından büyüktür veya sayılara eşittir:" + kontrol8);
            Console.WriteLine(sayı2 + " sayısı " + sayı + " ve " + sayı3 + " sayılarından küçüktür: " + kontrol9);
            Console.WriteLine(sayı2 + " sayısı " + sayı + " ve " + sayı3 + " sayılarından küçüktür veya sayılara eşittir: " + kontrol10);
            Console.WriteLine(sayı3 + " sayısı " + sayı + " ve " + sayı2 + " sayılarından büyüktür:" + kontrol11);
            Console.WriteLine(sayı3 + "sayısı " + sayı + " ve " + sayı2 + " sayılarından büyüktür veya sayılara eşittir: " + kontrol12);
            Console.WriteLine(sayı3 + "sayısı " + sayı + " ve " + sayı2 + " sayılarından küçüktür: " + kontrol13);
            Console.WriteLine(sayı3 + " sayısı " + sayı + " ve " + sayı2 + " sayılarından küçüktür veya sayılara eşittir: " + kontrol14);
            Console.Read();

        }
    }
}
