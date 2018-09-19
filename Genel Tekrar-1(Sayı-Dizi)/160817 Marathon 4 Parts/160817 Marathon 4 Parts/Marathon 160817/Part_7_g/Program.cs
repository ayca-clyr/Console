using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_7_g
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Belirli kapasitede yeni bir string dizisi oluşturma");
            Console.WriteLine();
            string[] dizi = new string[5];
            
            Console.Write("dizinin 1.değerini girin:");
            dizi[0] = Console.ReadLine();
            Console.Write("dizinin 2.değerini girin:");
            dizi[1] = Console.ReadLine();
            Console.Write("dizinin 3.değerini girin:");
            dizi[2] = Console.ReadLine();
            Console.Write("dizinin 4.değerini girin:");
            dizi[3] = Console.ReadLine();
            Console.Write("dizinin 5.değerini girin:");
            dizi[4] = Console.ReadLine();
            Console.Read();
        }
    }
}
