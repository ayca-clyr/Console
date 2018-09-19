using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_5_b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen 1. Sayıyı Giriniz :");
            int sayı1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen 2. Sayıyı Giriniz :");
            int sayı2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen 3. Sayıyı Giriniz :");
            int sayı3 = int.Parse(Console.ReadLine());

            if((sayı1 > sayı2) && (sayı1 > sayı3))
            {
                Console.WriteLine("En büyük sayı: {0}",sayı1);
            }else if((sayı2 > sayı1) && (sayı2 > sayı3))
            {
                Console.WriteLine("En büyük sayı: {0}", sayı2);

            }else
            {
                Console.WriteLine("En büyük sayı: {0}", sayı3);
            }

        }
    }
}
