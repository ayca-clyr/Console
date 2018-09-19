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

            Console.WriteLine("Sonsuz sayıda girilen sayılardan en büyük ve en küçüğü sayıyı bulan ve kullanıcının anahtar kelimeleri kullanması halinde sonlandırılacak program");
            Console.WriteLine();
            Console.WriteLine();
            int index = 0;
            int buyuk = 0;
            int kucuk = int.MaxValue;
            bool durum = true;

            while (durum)
            {
                Console.Write(index + 1 + ".Sayıyı girin:");
                string giris = Console.ReadLine();
                int sayi;
                bool basarılı = int.TryParse(giris, out sayi);
                if (giris != "exit")
                {
                    if (giris != "end")
                    {
                        if (basarılı)
                        {
                            if (index == 0)
                            {
                                buyuk = sayi;
                                kucuk = sayi;
                            }
                            else
                            {
                                if (sayi > buyuk)
                                {
                                    buyuk = sayi;
                                }
                                else if (sayi < kucuk)
                                {
                                    kucuk = sayi;
                                }
                            }
                            index++;
                        }
                        else
                        {
                            Console.Write("Yanlış değer girdiniz");
                        }
                    }
                    else if ((index < 2) && giris == "end")
                    {
                        Console.WriteLine("2 sayıdan az değer girdiniz");
                    }
                    else if (index >= 2 && giris == "end")
                    {

                        Console.WriteLine("Kıyaslanacak sayıların girişini durdurdunuz.");
                        Console.WriteLine("Girdiğiniz sayıların en büyüğü:" + buyuk);
                        Console.WriteLine("Girdiğiniz sayıların en küçüğü:" + kucuk);
                    }
                }
                else
                {
                    Console.WriteLine("Kıyaslanacak sayıların girişini durdurdunuz.");
                    Console.WriteLine("Girdiğiniz sayıların en büyüğü:" + buyuk);
                    Console.WriteLine("Girdiğiniz sayıların en küçüğü:" + kucuk);
                    durum = false;
                }

            }
        }
    }
}

