using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _160822_RomaNumerals___Roma___10
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 0;
            int toplam = 0;
            Console.Write("Roma rakamını giriniz:");
            string giris = Console.ReadLine();
            while (index < giris.Length)
            {
                if (giris[index] == 'I')
                {
                    
                    if (index <= giris.Length - 1)
                    {

                        if (giris[index ] == 'V' || giris[index] == 'X')
                        {
                            toplam = toplam - 1;
                        }

                        else
                        {
                            toplam = toplam + 1;
                        }
                    }


                }
                else if (giris[index] == 'V')
                {
                    if (index <= giris.Length - 1) { 
                    if (giris[index] == 'I')
                    {
                        toplam = toplam + 1;
                    }
                    else
                    {
                        toplam = toplam + 5;
                    }
                    }
                }
                else if (giris[index] == 'X')
                {
                    if (index <= giris.Length - 1)
                    {
                        if (giris[index] == 'I')
                        {
                            toplam = toplam + 1;
                        }
                        else if (giris[index] == 'V')
                        {
                            toplam = toplam + 5;
                        }
                        else if (giris[index] == 'L' || giris[index] == 'C')
                        {
                            toplam = toplam - 10;
                        }
                    }
                    toplam = toplam + 10;
                }
                index++;

            }
            Console.Write(toplam);
            Console.ReadLine();
        }
    }
}
