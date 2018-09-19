using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _160901_T.C_numarası_Kontrolü
{
    class Program
    {
        static void Main(string[] args)
        {
            bool deger = false;
            long sayı;
            
            while (!deger)
            {
                Console.Write("Lütfen T.C kimlik numaranızı giriniz.");
                deger = long.TryParse(Console.ReadLine(), out sayı);
                if (!deger)
                {
                    Console.WriteLine("Yanlış giriş yaptınız, lütfen tekrar deneyiniz.");
                }
               
            }
            
        }
    }
}
