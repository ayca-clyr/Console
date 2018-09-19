using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********** PALİNDROME **********");
            Console.WriteLine("********************************\n");
            while (true)
            {
                string input = string.Empty;
                int number, step = 1, newNumber=0;
                int[] numberArray = new int[0];
                bool success = true;
                do
                {
                    if (!success)
                        Console.WriteLine("Lütfen doğru formatta bir sayı yazınız!\n");
                    Console.Write("Bir tamsayı giriniz: ");
                    input = Console.ReadLine();
                    success = int.TryParse(input, out number);
                } while (!success || input == "exit");
                if (input == "exit")
                    break;
                while (number / (int)Math.Pow(10, step - 1) != 0)
                {
                    Array.Resize(ref numberArray, numberArray.Length + 1);
                    numberArray[step - 1] = (number % (int)Math.Pow(10, step))
                        / (int)Math.Pow(10, step - 1);
                    step++;
                }
                step = 0;
                while (step<numberArray.Length)
                {
                    newNumber +=numberArray[step] * (int)Math.Pow(10,numberArray.Length-step-1);
                    step++;
                }
                if (number==newNumber)
                    Console.WriteLine("Girdiğiniz sayı bir palindromdur.\n");
                else
                    Console.WriteLine("Girdiğiniz sayı bir palindrom değildir.\n");
            }
        }
    }
}