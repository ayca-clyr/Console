using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionControlStruıctures
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lütfen bir sayı giriniz : ");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            int result = number % 2;

            bool isEven = result == 0;

            // if - else

            if (isEven /*result == 0*/)
            {   
                  Console.WriteLine("Girdiğiniz Sayı Çifttir.");
            }
            else
            {
                Console.WriteLine("Girdiğiniz Sayı Tektir.");
            }

            #region !sEven
            if (!isEven)
            {
                Console.WriteLine("Girdiğiniz Sayı Tektir.");
            }
            else
            {
                Console.WriteLine("Girdiğiniz Sayı Çifttir.");
            } 
            #endregion
        }
    }
}
