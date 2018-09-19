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

            int i = 0;
            int[] dizi = { 1, 2, 3, 4, 5, 6, 7, 8 };
            while(i < dizi.Length){

                if (i % 2 == 0)
                {
                    Console.Write(dizi[i]+ "   " );
                }
                else
                {
                    Console.WriteLine(dizi[i]);
                }
                i++;
            }
            
        }
    }
}
