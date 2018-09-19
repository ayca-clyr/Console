using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_4_b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen İlk isimi giriniz :");
            string isim1 = Console.ReadLine();

            Console.WriteLine("Girilen ilk ismin yaşını giriniz :");
            int sayı1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen İkinci isimi giriniz :");
            string isim2 = Console.ReadLine();

            Console.WriteLine("Girilen ikinci ismin yaşını giriniz :");
            int sayı2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen Üçüncü isimi giriniz :");
            string isim3 = Console.ReadLine();

            Console.WriteLine("Girilen üçüncü ismin yaşını giriniz :");
            int sayı3 = int.Parse(Console.ReadLine());

            bool deger0 = sayı1 != sayı2 && sayı1 != sayı3;
            Console.WriteLine("{0},{1} ve {2} sayıları birbirine eşit değildir : {3}", isim1, isim2,isim3, deger0);
            Console.WriteLine();

            bool deger1 = sayı1 == sayı2 && sayı1 == sayı3;
            Console.WriteLine("{0},{1} ve {2} sayıları birbirine eşittir: {3}", isim1, isim2, isim3, !deger1);

            bool deger2 = (sayı1 > sayı2) && (sayı1 > sayı3);
            Console.WriteLine("{0},{1} ve {2} sayılarından büyüktür: {3}", isim1, isim2, isim3, !deger2);

            bool deger3 = ((sayı1 > sayı2) && (sayı1 > sayı3)) || ((sayı1 == sayı2) && (sayı1 == sayı3));
            Console.WriteLine("{0},{1} ve {2} sayılarından büyüktür veya sayılara eşittir: {3}", isim1, isim2, isim3, !deger3);

            bool deger4 = (sayı1 < sayı2) && (sayı1 < sayı3);
            Console.WriteLine("{0},{1} ve {2} sayılarından küçüktür: {3}", isim1, isim2, isim3, !deger4);

            bool deger5 = ((sayı1 < sayı2) && (sayı1 < sayı3)) || ((sayı1 == sayı2) && (sayı1 == sayı3));
            Console.WriteLine("{0},{1} ve {2} sayılarından küçüktür veya sayılara eşittir: {3}", isim1, isim2, isim3, !deger5);

            bool deger6 = (sayı2 > sayı1) && (sayı2 > sayı3);
            Console.WriteLine("{1},{0} ve {2} sayılarından büyüktür: {3}", isim1, isim2, isim3, !deger6);

            bool deger7 = ((sayı2 > sayı1) && (sayı2 > sayı3)) || ((sayı2 == sayı1) && (sayı2 == sayı3));
            Console.WriteLine("{1},{0} ve {2} sayılarından büyüktür veya sayılara eşittir: {3}", isim1, isim2, isim3, !deger7);

            bool deger8 = (sayı2 < sayı1) && (sayı2 < sayı3);
            Console.WriteLine("{1},{0} ve {2} sayılarından küçüktür: {3}", isim1, isim2, isim3, !deger8);

            bool deger9 = ((sayı2 < sayı1) && (sayı2 < sayı3)) || ((sayı2 == sayı1) && (sayı2 == sayı3));
            Console.WriteLine("{1},{0} ve {2} sayılarından küçüktür veya sayılara eşittir: {3}", isim1, isim2, isim3, !deger9);

            bool deger10 = (sayı3 > sayı1) && (sayı3 > sayı2);
            Console.WriteLine("{2},{1} ve {0} sayılarından büyüktür.: {3}", isim1, isim2, isim3, !deger10);

            bool deger11 = ((sayı3 > sayı1) && (sayı3 > sayı2)) || ((sayı3 == sayı1) && (sayı3 == sayı2));
            Console.WriteLine("{2},{1} ve {0} sayılarından büyüktür veya sayılara eşittir: {3}", isim1, isim2, isim3, !deger11);

            bool deger12 = (sayı3 < sayı1) && (sayı3 < sayı2);
            Console.WriteLine("{2},{1} ve {0} sayılarından kçüçüktür: {3}.", isim1, isim2, isim3, !deger12);

            bool deger13 = ((sayı3 < sayı1) && (sayı3 < sayı2)) || ((sayı3 == sayı1) && (sayı3 == sayı2));
            Console.WriteLine("{2},{1} ve {0} sayılarından küçüktür veya sayılara eşittirr: {3}", isim1, isim2, isim3, !deger13);


        }
    }
}
