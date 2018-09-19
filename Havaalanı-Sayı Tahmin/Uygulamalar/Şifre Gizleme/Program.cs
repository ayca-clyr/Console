using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Şifre_Gizleme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Kullanıcı Adınızı ve Şifrenizi Giriniz!");

            ConsoleKeyInfo kullaniciAdi;
            string kullaniciSifresi = Console.ReadLine();

            int i = 0;

            while (i < kullaniciSifresi.Length)
            {
                kullaniciAdi = Console.ReadKey(true);

                if (kullaniciAdi.Key != ConsoleKey.Backspace)
                {
                    if (kullaniciAdi.Key == ConsoleKey.Enter)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("\nPAROLA TEST :" + kullaniciSifresi);
                        break;
                    }
                    kullaniciSifresi += kullaniciAdi.KeyChar;
                    Console.Write('*');
                }
                i++;
            }

            Console.ReadLine();


        }
    }
}
