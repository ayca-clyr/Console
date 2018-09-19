using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_7_d
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] dizi = { 45, 928, 78, 4, 1007, 83 };

            int i = dizi.Length - 1;
            while (i >= 0)
            {
                if (i > 0 && i < dizi.Length)
                {
                    Console.Write( dizi[i] + "-");
                    i--;
                }
                else
                {
                    Console.Write(dizi[i]);
                    i--;
                }
            }
        }
    }
}
