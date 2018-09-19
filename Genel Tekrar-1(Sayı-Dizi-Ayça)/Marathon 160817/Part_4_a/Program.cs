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
            Console.WriteLine("Lütfen 1. sayıyı giriniz : ");
            int sayı1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen 2. sayıyı giriniz : ");
            int sayı2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen 3. sayıyı giriniz : ");
            int sayı3 = int.Parse(Console.ReadLine());

            bool deger0 = sayı1 != sayı2 && sayı1 != sayı3;
            Console.WriteLine("{0},{1} ve {2} sayıları birbirine eşit değildir: {3}", sayı1, sayı2,sayı3, deger0);
            Console.WriteLine();

            bool deger1 = sayı1 == sayı2 && sayı1 == sayı3;
            Console.WriteLine("{0},{1} ve {2} sayıları birbirine eşittir: {3}", sayı1, sayı2, sayı3, !deger1);

            bool deger2 = (sayı1 > sayı2) && (sayı1 > sayı3);
            Console.WriteLine("{0},{1} ve {2} sayılarından büyüktür: {3}", sayı1, sayı2, sayı3, !deger2);

            bool deger3 = ((sayı1 > sayı2) && (sayı1 > sayı3)) || ((sayı1 == sayı2) && (sayı1 == sayı3));
            Console.WriteLine("{0},{1} ve {2} sayılarından büyüktür veya sayılara eşittir: {3}", sayı1, sayı2, sayı3, !deger3);

            bool deger4 = (sayı1 < sayı2) && (sayı1 < sayı3);
            Console.WriteLine("{0},{1} ve {2} sayılarından küçüktür: {3}", sayı1, sayı2, sayı3, !deger4);

            bool deger5 = ((sayı1 < sayı2) && (sayı1 < sayı3)) || ((sayı1 == sayı2) && (sayı1 == sayı3));
            Console.WriteLine("{0},{1} ve {2} sayılarından küçüktür veya sayılara eşittir: {3}", sayı1, sayı2, sayı3, !deger5);

            bool deger6 = (sayı2 > sayı1) && (sayı2 > sayı3);
            Console.WriteLine("{1},{0} ve {2} sayılarından büyüktür: {3}", sayı1, sayı2, sayı3, !deger6);

            bool deger7 = ((sayı2 > sayı1) && (sayı2 > sayı3)) || ((sayı2 == sayı1) && (sayı2 == sayı3));
            Console.WriteLine("{1},{0} ve {2} sayılarından büyüktür veya sayılara eşittir: {3}", sayı1, sayı2, sayı3, !deger7);

            bool deger8 = (sayı2 < sayı1) && (sayı2 < sayı3);
            Console.WriteLine("{1},{0} ve {2} sayılarından küçüktür: {3}", sayı1, sayı2, sayı3, !deger8);

            bool deger9 = ((sayı2 < sayı1) && (sayı2 < sayı3)) || ((sayı2 == sayı1) && (sayı2 == sayı3));
            Console.WriteLine("{1},{0} ve {2} sayılarından küçüktür veya sayılara eşittir: {3}", sayı1, sayı2, sayı3, !deger9);

            bool deger10 = (sayı3 > sayı1) && (sayı3 > sayı2);
            Console.WriteLine("{2},{1} ve {0} sayılarından büyüktür.: {3}", sayı1, sayı2, sayı3, !deger10);

            bool deger11 = ((sayı3 > sayı1) && (sayı3 > sayı2)) || ((sayı3 == sayı1) && (sayı3 == sayı2));
            Console.WriteLine("{2},{1} ve {0} sayılarından büyüktür veya sayılara eşittir: {3}", sayı1, sayı2, sayı3, !deger11);

            bool deger12 = (sayı3 < sayı1) && (sayı3 < sayı2);
            Console.WriteLine("{2},{1} ve {0} sayılarından kçüçüktür.: {3}", sayı1, sayı2, sayı3, !deger12);

            bool deger13 = ((sayı3 < sayı1) && (sayı3 < sayı2)) || ((sayı3 == sayı1) && (sayı3 == sayı2));
            Console.WriteLine("{2},{1} ve {0} sayılarından küçüktür veya sayılara eşittirr: {3}", sayı1, sayı2, sayı3, !deger13);

        }
    }
}
