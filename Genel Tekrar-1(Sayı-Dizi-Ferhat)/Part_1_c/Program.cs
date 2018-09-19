using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_c
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lütfen bir sayı giriniz : ");
            string girilenSayı = Console.ReadLine();
            float sayı1 = float.Parse(girilenSayı);
            double sayı2 = double.Parse(girilenSayı);
            decimal sayı3 = decimal.Parse(girilenSayı);

        }
    }
}
