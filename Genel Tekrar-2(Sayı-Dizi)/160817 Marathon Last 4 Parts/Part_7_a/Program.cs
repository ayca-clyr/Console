using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_7_a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dizi elemanlarını alt alta yazdırma");
            Console.WriteLine();
            int []dizi ={1,2,3};
            int index = 0;
            while (index < dizi.Length)
            {

                Console.WriteLine(dizi[index]);
                index++;
            }
            Console.ReadLine();
        }
    }
}
