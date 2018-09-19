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
            int[] dizi = new int[5];
            int i, j, k, l, m;
            bool deger = true;

            while (true)
            { 
                Console.WriteLine("Lütfen 1.Sayıyı giriniz : ");          
                string sayı1 = Console.ReadLine();          
                bool durum1 = int.TryParse(sayı1, out i);

           
                if (durum1)
                {

                    Console.WriteLine("Lütfen 2.Sayıyı giriniz : ");
                    string sayı2 = Console.ReadLine();
                    bool durum2 = int.TryParse(sayı2, out j);

                    if (durum2)
                    {
                        Console.WriteLine("Lütfen 3.Sayıyı giriniz : ");
                        string sayı3 = Console.ReadLine();
                        bool durum3 = int.TryParse(sayı3, out k);

                        if (durum3)
                        {
                            Console.WriteLine("Lütfen 4.Sayıyı giriniz : ");
                            string sayı4 = Console.ReadLine();
                            bool durum4 = int.TryParse(sayı4, out l);

                            if (durum4)
                            {

                                Console.WriteLine("Lütfen 5.Sayıyı giriniz : ");
                                string sayı5 = Console.ReadLine();
                                bool durum5 = int.TryParse(sayı5, out m);
                                if (durum5)
                                {
                                    dizi[0] = i;
                                    dizi[1] = j;
                                    dizi[2] = k;
                                    dizi[3] = l;
                                    dizi[4] = m;

                                }
                                else
                                {
                                    Console.WriteLine("Yanlış Değer Girdiniz!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Yanlış Girdiniz!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Yanlış Girdiniz!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Girdiniz!");
                    }
                }
                else
                {
                    Console.WriteLine("Yanlış Girdiniz!");
                }

            }





        }
    }
}
