using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ondalıklı_Roma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programdan Çıkmak İsterseniz Exit Yazınız!");
            
            bool durum = true;
            while (durum)
            {
                Console.WriteLine("\n" + "Lütfen Bir Sayı Giriniz.");
                string girilenSayı = Console.ReadLine();
                int sayi;
                bool durum2 = int.TryParse(girilenSayı, out sayi);
                if (girilenSayı == "Exit")
                {
                    break;
                }
                if (!durum2)
                {
                    Console.WriteLine("Yanlış Değer Girdiniz!");
                }
                else
                {


                    if (sayi == 0)
                    {
                        Console.WriteLine("Lütfen 0'dan Büyük Sayı Giriniz!");
                    }



                    int birlerBasamagi = sayi % 10;   // Birler basamağı için.           
                    sayi = sayi / 10;

                    int onlarBasamagi = sayi % 10;

                    sayi = sayi / 10;     // Yüzler basamağı için.
                    int yuzlerBasamagi = sayi % 10;

                    sayi = sayi / 10;   // Binler basamağı için.
                    int binlerBasamagi = sayi % 10;

                    if (girilenSayı.Length > 4)
                    {
                        Console.WriteLine("Lütfen Sayıyı 1 ile 4999 arasında Giriniz!");
                    }
                    else
                    {
                        if (binlerBasamagi == 1)
                        {
                            Console.Write("M");
                        }
                        else if (binlerBasamagi == 2)
                        {
                            Console.Write("MM");
                        }
                        else if (binlerBasamagi == 3)
                        {
                            Console.Write("MMM");
                        }
                        else if (binlerBasamagi == 4)
                        {
                            Console.Write("MV_");
                        }
                        else if (binlerBasamagi == 5)
                        {
                            Console.Write("V_");
                        }
                        else if (binlerBasamagi == 6)
                        {
                            Console.Write("V_M");
                        }
                        else if (binlerBasamagi == 7)
                        {
                            Console.Write("V_MM");
                        }
                        else if (binlerBasamagi == 8)
                        {
                            Console.Write("V_MMM");
                        }
                        else if (binlerBasamagi == 9)
                        {
                            Console.Write("MX_");
                        }

                        if (yuzlerBasamagi == 1)
                        {
                            Console.Write("C");
                        }
                        else if (yuzlerBasamagi == 2)
                        {
                            Console.Write("CC");
                        }
                        else if (yuzlerBasamagi == 3)
                        {
                            Console.Write("CCC");
                        }
                        else if (yuzlerBasamagi == 4)
                        {
                            Console.Write("CD");
                        }
                        else if (yuzlerBasamagi == 5)
                        {
                            Console.Write("D");
                        }
                        else if (yuzlerBasamagi == 6)
                        {
                            Console.Write("DC");
                        }
                        else if (yuzlerBasamagi == 7)
                        {
                            Console.Write("DCC");
                        }
                        else if (yuzlerBasamagi == 8)
                        {
                            Console.Write("DCCC");
                        }
                        else if (yuzlerBasamagi == 9)
                        {
                            Console.Write("CM");
                        }

                        if (onlarBasamagi == 1)
                        {
                            Console.Write("X");
                        }
                        else if (onlarBasamagi == 2)
                        {
                            Console.Write("XX");
                        }
                        else if (onlarBasamagi == 3)
                        {
                            Console.Write("XXX");
                        }
                        else if (onlarBasamagi == 4)
                        {
                            Console.Write("XL");
                        }
                        else if (onlarBasamagi == 5)
                        {
                            Console.Write("L");
                        }
                        else if (onlarBasamagi == 6)
                        {
                            Console.Write("LX");
                        }
                        else if (onlarBasamagi == 7)
                        {
                            Console.Write("LLX");
                        }
                        else if (onlarBasamagi == 8)
                        {
                            Console.Write("LXXX");
                        }
                        else if (onlarBasamagi == 9)
                        {
                            Console.Write("XC");
                        }

                        if (birlerBasamagi == 1)
                        {
                            Console.Write("I");
                        }
                        else if (birlerBasamagi == 2)
                        {
                            Console.Write("II");
                        }
                        else if (birlerBasamagi == 3)
                        {
                            Console.Write("III");
                        }
                        else if (birlerBasamagi == 4)
                        {
                            Console.Write("IV");
                        }
                        else if (birlerBasamagi == 5)
                        {
                            Console.Write("V");
                        }
                        else if (birlerBasamagi == 6)
                        {
                            Console.Write("VI");
                        }
                        else if (birlerBasamagi == 7)
                        {
                            Console.Write("VII");
                        }
                        else if (birlerBasamagi == 8)
                        {
                            Console.Write("VIII");
                        }
                        else if (birlerBasamagi == 9)
                        {
                            Console.Write("IX");
                        }
                    }

                }
            }
        }
    }
}

