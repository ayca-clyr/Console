using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2_c
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen 1. sayıyı giriniz :");
            int intSayı1 = int.Parse(Console.ReadLine());
            long longSayı1 = long.Parse(Console.ReadLine());
            short shortSayı1 = short.Parse(Console.ReadLine());
            byte byteSayı1 = byte.Parse(Console.ReadLine());


            Console.WriteLine("Lütfen ikinci sayıyı giriniz :");
            int intSayı2 = int.Parse(Console.ReadLine());
            long longSayı2 = long.Parse(Console.ReadLine());
            short shortSayı2 = short.Parse(Console.ReadLine());
            byte byteSayı2 = byte.Parse(Console.ReadLine());

            int intÇarpımı = intSayı1 * intSayı2;
            long longÇarpımı = longSayı1 * longSayı2;
            short shortÇarpımı = (short)(shortSayı1 * shortSayı2);
            byte byteÇarpımı = (byte)(byteSayı1 * byteSayı2);

            Console.WriteLine("  {0} * {1} = {2}", intSayı1, intSayı2, intÇarpımı);
            Console.WriteLine("  {0} * {1} = {2}", longSayı1, longSayı2, longÇarpımı);
            Console.WriteLine("  {0} * {1} = {2}", shortSayı1, shortSayı2, shortÇarpımı);
            Console.WriteLine("  {0} * {1} = {2}", byteSayı1, byteSayı2, byteÇarpımı);
        }
    }
}

