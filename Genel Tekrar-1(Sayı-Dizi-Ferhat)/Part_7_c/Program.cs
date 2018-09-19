using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_7_c
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] dizi = {45 , 928 , 78 , 4 , 1007 , 83  };

            int i = 0;
            while (i < dizi.Length)
            {
                if (i > 0 && i < dizi.Length )
                {
                    Console.Write("-" +dizi[i]);
                    i++;
                }
                else
                {
                    Console.Write(dizi[i]);
                    i++;
                }
            }




        }
    }
}
