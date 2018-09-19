using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_7_f
{
    class Program
    {
        static void Main(string[] args)
        {

            
            int[] dizi = { 1, 2, 3, 4, 5, 6, 7, 8, 9 ,10};
            int i = 0;

                while (i < dizi.Length)
            {
                if (i % 3 == 1)
                {
                    Console.WriteLine(dizi[i]);
                }
                else if (i % 3 == 0)
                {
                    Console.Write(dizi[i] + "  ");
                }
                else
                {
                    Console.Write(dizi[i]+ "   ");
                }
                i++;
            }
               
        }
    }
}
