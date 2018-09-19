using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _160822_RomaNumerals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Onluk sistemdeki sayıyı Roman rakamlarıyla ifade eden program");
            string I = "I";
            string V = "V";
            string X = "X";
            string L = "L";
            string C = "C";
            string D = "D";
            string M = "M";
            int sayac = 0;
            int mod;
            Console.WriteLine("Onluk sayı sisteminden bir değer giriniz");
            string giris = Console.ReadLine();
            int sayı = int.Parse(giris);
            while (sayac < giris.Length)
            {
                if (sayı >= 1000)
                {
                    mod = sayı / 1000;
                    if (mod == 1)
                    {
                        Console.Write(M);
                    }
                    else if (mod == 2)
                    {
                        Console.Write(M+M);
                    }
                    else if (mod == 3)
                    {
                        Console.Write(M+M+M);
                    }
                    sayı = sayı % 1000;
                   
                }
                else if (sayı >= 100 && sayı < 1000) 
                {

                    mod = sayı / 100;
                    if (mod == 1) 
                    {
                        Console.Write(C);
                    }
                    else if (mod == 2)
                    {
                        Console.Write(C+C);
                    }
                    else if (mod == 3)
                    {
                        Console.Write(C+C+C);
                    }
                    
                    else if (mod == 4)
                    {
                        Console.Write(C + D);
                    }
                    else if (mod == 5)
                    {
                        Console.Write(D);
                    }
                    else if (mod == 6)
                    {
                        Console.Write(D+C);
                    }
                    else if (mod == 7)
                    {
                        Console.Write(D + C+C);
                    }
                    else if (mod == 8)
                    {
                        Console.Write(D + C+C+C);
                    }
                    else if (mod == 9)
                    {
                        Console.Write(C+M);
                    }

                    sayı = sayı % 100;

                    }
                else if (sayı >= 10 && sayı < 100)
                {
                    mod = sayı / 10;
                    if (mod == 1)
                    {
                        Console.Write(X);
                    }
                    else if (mod == 2)
                    {
                        Console.Write(X + X);
                    }
                    else if (mod == 3)
                    {
                        Console.Write(X + X + X);
                    }
                   
                    else if (mod == 4)
                    {
                        Console.Write(X + L);
                    }
                    else if (mod == 5)
                    {
                        Console.Write(L);
                    }
                    else if (mod == 6)
                    {
                        Console.Write(L + X);
                    }
                    else if (mod == 7)
                    {
                        Console.Write(L + X + X);
                    }
                    else if (mod == 8)
                    {
                        Console.Write(L + X + X + X);
                    }
                    else if (mod == 9)
                    {
                        Console.Write(X + C);
                    }
                    sayı = sayı % 10;

                }
                else if (sayı >= 1 && sayı < 10)
                {
                    mod = sayı % 10;
                    if (mod == 1)
                    {
                        Console.Write(I);
                    }
                    else if (mod == 2)
                    {
                        Console.Write(I + I);
                    }
                    else if (mod == 3)
                    {
                        Console.Write(I + I + I);
                    }

                    else if (mod == 4)
                    {
                        Console.Write(I + V);
                    }
                    else if (mod == 5)
                    {
                        Console.Write(V);
                    }
                    else if (mod == 6)
                    {
                        Console.Write(V + I);
                    }
                    else if (mod == 7)
                    {
                        Console.Write(V + I + I);
                    }
                    else if (mod == 8)
                    {
                        Console.Write(V + I + I + I);
                    }
                    else if (mod == 9)
                    {
                        Console.Write(I + X);
                    }
                    break;
                }
                sayac++;
            }
            Console.ReadLine();
            
        }
    }
}
