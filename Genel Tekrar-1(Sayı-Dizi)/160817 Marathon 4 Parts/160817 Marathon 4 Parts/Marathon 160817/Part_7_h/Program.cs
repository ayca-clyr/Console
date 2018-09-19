using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_7_h
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Belirli kapasitede yeni bir int dizisi oluşturma");
            Console.WriteLine();
            int[] dizi = new int[5];
            bool deger = false;


            while (!deger)
            {
                Console.Write("Dizinin 1. elemanını giriniz:");
                deger = int.TryParse(Console.ReadLine(), out dizi[0]);
                if (!deger)
                    Console.WriteLine("Hatalı giriş yaptınız, tekrar giriniz!");
            }
            deger = false;
            while (!deger)
            {
                Console.Write("Dizinin 2. elemanını giriniz:");
                deger = int.TryParse(Console.ReadLine(), out dizi[1]);
                if (!deger)
                    Console.WriteLine("Hatalı giriş yaptınız, tekrar giriniz!");
            }
            deger = false;
            while (!deger)
            {
                Console.Write("Dizinin 3. elemanını giriniz:");
                deger = int.TryParse(Console.ReadLine(), out dizi[2]);
                if (!deger)
                    Console.WriteLine("Hatalı giriş yaptınız, tekrar giriniz!");
            }
            deger = false;
            while (!deger)
            {
                Console.Write("Dizinin 4. elemanını giriniz:");
                deger = int.TryParse(Console.ReadLine(), out dizi[3]);
                if (!deger)
                    Console.WriteLine("Hatalı giriş yaptınız, tekrar giriniz!");
            }
            deger = false;
            while (!deger)
            {
                Console.Write("Dizinin 5. elemanını giriniz:");
                deger = int.TryParse(Console.ReadLine(), out dizi[4]);
                if (!deger)
                    Console.WriteLine("Hatalı giriş yaptınız, tekrar giriniz!");
            }
            deger = false;
            Console.Read();
        }
    }
}
