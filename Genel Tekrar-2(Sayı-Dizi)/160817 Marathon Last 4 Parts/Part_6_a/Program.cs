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

            Console.WriteLine("Girilen 10 tane sayı arasında en büyük ve en küçük sayıyı bulan program");
            Console.WriteLine();
            Console.WriteLine();
            int index = 0;
            int buyuk = 0;
            int kucuk = int.MaxValue;
            Console.Write(index+1+".Sayıyı girin:");
            string giris = Console.ReadLine();
            int sayı;
            bool basarılı = int.TryParse(giris, out sayı);
            if (basarılı)
            {
                kucuk = sayı;
            }
            else
            {
                Console.WriteLine("Yanlış giriş yapıldı");
            }
            while (index < 9)
            {

                Console.Write(index+2+".Sayıyı girin:");
                 giris = Console.ReadLine();
                basarılı = int.TryParse(giris, out sayı);
                if (basarılı)
                {
                    if (sayı < kucuk)
                    {
                        kucuk = sayı;
                    }
                    else if (sayı > buyuk)
                    {
                        buyuk = sayı;
                    }
                    index++;
                }
                else
                {
                    Console.WriteLine("Yanlış giriş yapıldı");
                }
                
            }
            Console.WriteLine("En büyük sayı: " + buyuk);
            Console.WriteLine("En küçük sayı: " + kucuk);
            Console.Read();
        }
    }
}