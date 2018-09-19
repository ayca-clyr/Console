using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Console_RefOutKeywords
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Lütfen bir sayı yazınız :");
            string input = Console.ReadLine();
            Console.Write('\n');    // Console.Write('\t');   Tab karakteri. 6-8 karakter boşluk.        

            // int number = int.Parse(input);

            int number;
            bool isSuccess = int.TryParse(input,out number);            
            
            if (isSuccess)
            {
                int square = number * number;
                Console.WriteLine(square);
            }
            else
            {
                Console.Write("Yanlış bir yazı yazdınız.");
            }
            */
            Console.WriteLine("Lütfen bölünen sayıyı yazın.");
            string input1 = Console.ReadLine();
            Console.Write('\n');

            Console.WriteLine("Lütfen bölen sayıyı yazınız :");
            string input2 = Console.ReadLine();
            Console.WriteLine('\n');

            int number = int.Parse(input1);
            int divisor = int.Parse(input2);

            //int division = Divide(number, divisor); 
            //Console.WriteLine("{0} sayısının {1} sayısına bölümü : {2}",number,divisor,division);

            int division;
            bool isSafe = TryDivide(number, divisor, out division);

            if (isSafe) { 
                Console.WriteLine("{0} sayısının {1} sayısına bölümü : {2}", number, divisor, division);
            }
            else
            {
                Console.WriteLine("Bu bölme işlemi güvenli değildir.");
            }   
            Console.ReadLine();         
        }

        static int Divide(int number, int divisor)
        {
            int result = number / divisor;

            return result;
        }
       
        // Out'un yeri önemli değil.
        static bool TryDivide(int number, int divisor,out int result)
        {
            if (divisor == 0)
            {
                result = 0;
                return false;
            }
              result = number / divisor;
                return true;           
        }

        static int TryDivide(int number, int divisor, out bool isSuccess)
        {
            if (divisor == 0)
            {
                isSuccess = false;
                return 0;
            }
            
            int result = number / divisor;
            isSuccess = true;
            return result;
        }


    }
}
