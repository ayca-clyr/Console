﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2_f
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen 1. sayıyı giriniz :");

            float floatSayı1 = float.Parse(Console.ReadLine());
            double doubleSayı1 = double.Parse(Console.ReadLine());
            decimal decimalSayı1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen 2. sayıyı giriniz :");
            float floatSayı2 = float.Parse(Console.ReadLine());
            double doubleSayı2 = double.Parse(Console.ReadLine());
            decimal decimalSayı2 = decimal.Parse(Console.ReadLine());

            float floatFarkı = floatSayı1 - floatSayı2;
            double doubleFarkı = doubleSayı1 - doubleSayı2;
            decimal decimalFarkı = decimalSayı1 - decimalSayı2;

            Console.WriteLine("{0} - {1} = {2}", floatSayı1, floatSayı2, floatFarkı);
            Console.WriteLine("{0} - {1} = {2}", doubleSayı1, doubleSayı2, doubleFarkı);
            Console.WriteLine("{0} - {1} = {2}", decimalSayı1, decimalSayı2, decimalFarkı);
        }
    }
}
