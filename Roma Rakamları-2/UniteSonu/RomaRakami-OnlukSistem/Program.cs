using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomaRakami_OnlukSistem
{
    class Program
    {
        static void Main(string[] args)
        {

            bool durum = true;

           
                string romaRakamai = Console.ReadLine();
                string[] karakterler = new string[20];
                string[] yenidizi = new string[20];
                int sonuc = 0, i = 0;
                foreach (char karakter in romaRakamai)
                {
                    karakterler[i] = karakter.ToString();
                    i++;
                }

                int y = 0;
                int dongu = romaRakamai.Length;
                for (int x = 0; x <= dongu; x++)
                {
                    string ikili = karakterler[x] + karakterler[x + 1];

                    if (ikili == "IV" || ikili == "IX" || ikili == "XL" || ikili == "CD" || ikili == "CM" || ikili == "XC")
                    {
                        karakterler[x] = ikili;
                        yenidizi[y] = karakterler[x];
                        romaRakamai = y + "." + yenidizi[y];
                        y++;
                        dongu--;
                    }
                    else
                    {
                     
                       
                        yenidizi[y] = karakterler[x];
                        romaRakamai = y + "." + yenidizi[y];
                        y++;
                    }
                }

                for (int x = 0; x < yenidizi.Length; x++)
                {
                    switch (yenidizi[x])
                    {
                        case "I":
                            sonuc += 1;
                            break;
                        case "IV":
                            sonuc += 4;
                            break;
                        case "V":
                            sonuc += 5;
                            break;
                        case "IX":
                            sonuc += 9;
                            break;
                        case "X":
                            sonuc += 10;
                            break;
                        case "XL":
                            sonuc += 40;
                            break;
                        case "L":
                            sonuc += 50;
                            break;
                        case "C":
                            sonuc += 100;
                            break;
                        case "CD":
                            sonuc += 400;
                            break;
                        case "D":
                            sonuc += 500;
                            break;
                        case "CM":
                            sonuc += 900;
                            break;
                        case "M":
                            sonuc += 1000;
                            break;
                    }
                } Console.WriteLine(sonuc);
            
           
        }
    }
}
