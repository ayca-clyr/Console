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
            Console.WriteLine("Kullanıcının girdiği iki sayı arasında bulunan sayıların kendisi,karesi ve kübünü bulan program");
            Console.WriteLine();
            Console.WriteLine();
            int min;
            int max;
            while (true)
            {

                int sayı1, sayı2;

                Console.WriteLine("Birinci sayıyı girin");
                string input1 = Console.ReadLine();
                bool basarılı1 = int.TryParse(input1, out sayı1);
                if (input1 == "exit")
                {
                    break;
                }

                Console.WriteLine("İkinci sayıyı girin");
                string input2 = Console.ReadLine();
                bool basarılı2 = int.TryParse(input2, out sayı2);

                if (input2 == "exit")
                {
                    break;
                }

                if (basarılı1 == true && basarılı2 == true)
                {

                    if (sayı1 > sayı2)
                    {
                        max = sayı1;
                        min = sayı2;
                    }
                    else
                    {
                        max = sayı2;
                        min = sayı1;
                    }


                    while (min < max - 1)
                    {
                        min++;
                        Console.WriteLine("{0} - {1} - {2} ", min, min * min, min * min * min);
                    }


                }
                else
                {
                    Console.WriteLine("Yanlış giriş yaptınız");
                }

            }

        }
    }
}
