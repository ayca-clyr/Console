using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayi;
            bool dongu = true;
            while (dongu)
            {
                Console.WriteLine(" Bir Tamsayı Giriniz!");
                string deger = Console.ReadLine();
                bool durum = int.TryParse(deger, out sayi);
                string tersi = "";

                if (deger == "Exit")
                    break;
                else
                {
                    if (!durum)
                    {
                        Console.WriteLine("Lütfen Doğru Formatta Bir Sayı Giriniz!");
                    }
                    else
                    {
                        for (int i = deger.Length - 1; i >= 0; i--)
                        {
                            tersi += deger[i];
                        }
                        if (deger == tersi)
                        {
                            Console.WriteLine("Girdiğiniz sayı bir palindromdur. ");
                        }
                        else
                        {
                            Console.WriteLine("Girdiğiniz sayı bir palindrom değildir. ");
                        }
                    }
                }
            }
        }
    }
}