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

            int[] dizi = { 1, 2, 3, 4, 5, 6 };

            int i = dizi.Length - 1;
            while (i >= 0)
            {
                Console.WriteLine(dizi[i]);
                i--;
            }

        }
    }
}
