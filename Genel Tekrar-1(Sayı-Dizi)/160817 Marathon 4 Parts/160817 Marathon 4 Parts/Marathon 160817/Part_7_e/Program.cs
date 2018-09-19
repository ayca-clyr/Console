using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_7_e
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dizi elemanlarını iki kolonda yazdırma");
            Console.WriteLine();
            int[] dizi = { 17,30,15,85,93,18,69,6815 };
            int index = 0;
            while (index < dizi.Length)
            {
                if (index % 2 == 0)
                {
                    Console.Write(dizi[index] + " ");
                }
                else
                {
                    Console.WriteLine(dizi[index]);
                }
                index++;
            }
            Console.ReadLine();
        }
    }
}
