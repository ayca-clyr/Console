using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
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
                        int kalan = 0, sayininTersi = 0;
                        int gecisken = sayi;
                        while (gecisken > 0)
                        {
                            kalan = gecisken % 10;
                            sayininTersi = sayininTersi * 10 + kalan;
                            gecisken = gecisken / 10;
                        }
                        if (sayi == sayininTersi)
                        {
                            Console.WriteLine("Girdiğiniz Sayı Bir Palindromedir.");
                        }
                        else
                        {
                            Console.WriteLine("Girdiğiniz Sayı Bir Panlidrome Değildir.");
                        }
                    }
                }
            }
        }
    }
}
