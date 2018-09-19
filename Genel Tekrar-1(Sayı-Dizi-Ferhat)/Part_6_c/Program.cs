using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_6_c
{
    class Program
    {
        static void Main(string[] args)
        {
            bool deger = true;
            while (deger)
            {
                int i, j;

                Console.WriteLine("Lütfen ilk sayıyı giriniz :");
                string sayı1 = Console.ReadLine();
                bool durum1 = int.TryParse(sayı1, out i);
                if (sayı1 == "exit")
                {
                    deger = false;
                }
                else
                {
                    if (durum1)
                    {
                        Console.WriteLine("Lütfen ikinci sayıyı giriniz :");
                        string sayı2 = Console.ReadLine();
                        bool durum2 = int.TryParse(sayı2, out j);

                        Console.WriteLine("Sayı     Karesi     Küpü");

                        if (sayı2 == "exit")
                        {
                            deger = false;
                        }
                        else
                        {
                            if (durum2)
                            {
                                if (i < j -1 )
                                {
                                    while (i < j - 1)
                                    {
                                        i++;
                                        Console.WriteLine(" {0}     {1}    {2}",i,i*i,i*i*i);
                                        
                                    }
                                }
                                else
                                {
                                    while (j < i - 1)
                                    {

                                        j++;
                                        Console.WriteLine(" {0}     {1}    {2}", j, j * j, j * j * j);
                                        
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Yanlış değer girdiniz ");
                    }
                }

            }

        }
    }
}
