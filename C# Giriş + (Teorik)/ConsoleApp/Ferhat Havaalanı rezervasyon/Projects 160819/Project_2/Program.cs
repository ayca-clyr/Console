using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********* SAYI ÇÖZÜMLEME **********");
            Console.WriteLine("***********************************\n\n");
            while (true)
            {
                string input = string.Empty;
                int number, step = 1, numeral;
                bool success = true;
                do
                {
                    if (!success)
                        Console.WriteLine("Doğru formatta bir sayı girmediniz!\n************************\n\n");
                    Console.Write("Lütfen bir sayı giriniz: ");
                    input = Console.ReadLine();
                    success = int.TryParse(input, out number);
                } while (!success && input != "exit");
                if (input == "exit")
                    break;
                Console.WriteLine("************************\n");
                while (number / (int)Math.Pow(10, step - 1) != 0)
                {
                    numeral = (number % (int)Math.Pow(10, step))
                        / (int)Math.Pow(10, step - 1);
                    Console.WriteLine("{0} x {1} = {2}", numeral, Math.Pow(10, step - 1), (int)numeral * Math.Pow(10, step - 1));
                    step++;
                }
                Console.WriteLine("\n\n");
            }
        }
    }
}
