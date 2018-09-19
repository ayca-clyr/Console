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
            Console.WriteLine("Lütfen bir şeyler yazınız : ");
            char yazı1 = char.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen bir şeyler yazınız :");
            char yazı2 = char.Parse(Console.ReadLine());

            bool deger1 = yazı1 == yazı2;
            Console.WriteLine(!deger1);

            bool deger2 = yazı1 != yazı2;
            Console.WriteLine(deger2);

            bool deger3 = yazı1 < yazı2;
            Console.WriteLine(!deger3);

            bool deger4 = yazı1 > yazı2;
            Console.WriteLine(!deger4);

            bool deger5 = yazı1 < yazı2;
            Console.WriteLine(!deger5);

            bool deger6 = yazı1 <= yazı2;
            Console.WriteLine(!deger6);

            bool deger7 = yazı1 >= yazı2;
            Console.WriteLine(!deger7);

            

        }
    }
}
