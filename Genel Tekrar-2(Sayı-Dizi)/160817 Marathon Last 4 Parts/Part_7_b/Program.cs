using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_7_b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dizi elemanlarını alt alta tersten yazdırma");
            Console.WriteLine();
            int[] dizi = { 1, 2, 3 ,4};
            int index = dizi.Length-1;
            while (index >= 0)
            {
                Console.WriteLine(dizi[index]);
                index--;
            }
            Console.Read();
        }
    }
}
