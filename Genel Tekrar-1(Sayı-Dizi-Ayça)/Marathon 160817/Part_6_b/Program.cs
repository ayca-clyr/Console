using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_6_b
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayac = 0;
            int enBuyuk = int.MinValue;
            int enkücük = int.MaxValue;
            string kelime = "end";
            bool dongu = true;
            string çıkış = "exit";

            while (dongu)
            {
                int i;
                Console.WriteLine("Lütfen Bir Sayı Giriniz :");
                string sayı = Console.ReadLine();
                bool durum = int.TryParse(sayı, out i);  // Sayı çıkış olarak int döndürmeli.

                if (sayı != çıkış)
                {

                    if (sayı != kelime)
                    {

                        if (durum)
                        {

                            if (int.Parse(sayı) > enBuyuk)
                            {
                                enBuyuk = i;
                            }
                            if (int.Parse(sayı) < enkücük)
                            {
                                enkücük = i;
                            }
                            sayac++;
                        }
                        else
                        {
                            Console.WriteLine("Yanlış değer girdiniz!");
                        }
                    }
                    else
                    {
                        if (sayac <= 1)
                        {
                            Console.WriteLine("Lütfen en az 2 sayı giriniz!");
                        }
                        else
                        {
                            Console.WriteLine("Sayı Girdirmeyi Durdurdunuz!");
                            Console.WriteLine("Girilen Sayıların En Büyüğü : {0} ", enBuyuk);
                            Console.WriteLine("Girilen Sayıların En Küçüğü : {0}", enkücük);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Programdan başarılı bir şekilde çıktınız!");
                    break;
                }
            }
            Console.WriteLine("Girilen Sayıların En Büyüğü : {0} ", enBuyuk);
            Console.WriteLine("Girilen Sayıların En Küçüğü : {0}", enkücük);






        }

    }
}

