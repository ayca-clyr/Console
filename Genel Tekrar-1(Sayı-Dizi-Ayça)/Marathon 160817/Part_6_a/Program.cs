using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_6_a
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayac = 0;
            int enBuyuk = int.MinValue;
            int enkücük = int.MaxValue;



            while (sayac < 10)
            {

                int i;
                Console.WriteLine("Lütfen Bir Sayı Giriniz :");
                string sayı = Console.ReadLine();
                bool durum = int.TryParse(sayı, out i);  // Sayı çıkış olarak int döndürmeli.

                if (durum) { 
                if (int.Parse(sayı) > enBuyuk)
                {
                    enBuyuk = int.Parse(sayı);
                }
                if (int.Parse(sayı) < enkücük)
                {
                    enkücük = int.Parse(sayı);
                }
                sayac++;

                }
                else
                {
                    Console.WriteLine("Yanlış değer girdiniz!");
                }
            }
            Console.WriteLine("Girilen Sayıların En Büyüğü : {0} ", enBuyuk);
            Console.WriteLine("Girilen Sayıların En Küçüğü : {0}", enkücük);




        }
    }
}
