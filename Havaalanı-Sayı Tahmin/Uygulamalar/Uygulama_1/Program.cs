using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool dongu = true;
            while (dongu)
            {
                int i;
                Console.WriteLine("Lütfen bir sayı giriniz.");
               
                string girilenSayı = Console.ReadLine();

                bool durum = int.TryParse(girilenSayı, out i);
                int basamakSayısı = 1;
                int rakam;
                if (girilenSayı == "Exit")
                {
                    break;
                }
                else
                {
                    if (!durum)
                    {
                        Console.WriteLine("Doğru Formatta Bir Sayı Girmediniz!");
                        
                        Console.WriteLine("\n");
                    }
                    else
                    {
                        while (i / Convert.ToInt32(Math.Pow(10, (basamakSayısı - 1))) != 0)
                        {
                            rakam = Convert.ToInt32(i % Math.Pow(10, basamakSayısı)) / Convert.ToInt32(Math.Pow(10, (basamakSayısı - 1)));
                            Console.WriteLine("{0} x {1} = {2}", rakam, Math.Pow(10, (basamakSayısı - 1)), rakam * Math.Pow(10, (basamakSayısı - 1)));
                            
                            basamakSayısı++;
                        }
                    }
                }
            }
        }
    }
}
