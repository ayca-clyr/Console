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
            Console.WriteLine("Dizi elemanlarını yan yana yazma");
            Console.WriteLine();

            int[] dizi = {  45,928 , 78 , 4 , 1007 , 83 };
            int index = 0;
            while (index < dizi.Length)
            {
                if (index != dizi.Length - 1)
                {
                    Console.Write(dizi[index] + "-");
                }
                else
                {
                    Console.Write(dizi[index]);
                }
                index++;
            }
            Console.ReadLine();
        }
    }
}
