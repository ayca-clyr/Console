using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_8_b
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Güvenli bölme işlemi yapan program");
            //Console.WriteLine();

            //Console.Write("Bölünen sayıyı yazınız:");
            //int number = int.Parse(Console.ReadLine());

            //Console.Write("Bölen sayıyı yazınız:");
            //int divisor = int.Parse(Console.ReadLine());


            //int result;

            //bool isItSafe = TryDivide(number, divisor, out result);

            //if (isItSafe)
            //{
            //    Console.WriteLine("{0} sayısının {1} sayısına bölümü : {2} Güvenli mi?: {3}", number, divisor, result, isItSafe);
            //}
            //else
            //{
            //    Console.WriteLine("Bu bölme işlemi güvenli değil:" + isItSafe);
            //}


            Console.WriteLine("Güvenli ve kalanlı bölme işlemi yapan program");
            //console.writeline();
            //console.write("bölünen sayıyı yazınız :");
            //int number = int.parse(console.readline());

            //console.write("bölen sayıyı yazınız:");
            //int divisor = int.parse(console.readline());
            //int remainder;
            //int result;
            //bool isıtsafe = trydivide(number, divisor, out result, out remainder);
            //if (isıtsafe)
            //{
            //    console.writeline("{0} sayısının {1} sayısına bölümü : {2} kalan: {3} güvenli mi?:{4}", number, divisor, result, remainder, isıtsafe);

            //}
            //else
            //{
            //    console.writeline("bu bölme işlemi güvenli mi?: {0}", isıtsafe);
            //}
            //console.read();
        }
        static bool TryDivide(int number, int divisor, out int result)
        {
            if (divisor == 0)
            {
                result = 0;

                return false;
            }
            else
            {
                result = number / divisor;
                return true;
            }
        }
        static bool TryDivide(int number, int divisor, out int result, out int remainder)
        {
            if (divisor == 0)
            {
                result = 0;
                remainder = 0;
                return false;

            }
            else
            {
                result = number / divisor;
                remainder = number % divisor;
                return true;
            }
        }
    }
}
