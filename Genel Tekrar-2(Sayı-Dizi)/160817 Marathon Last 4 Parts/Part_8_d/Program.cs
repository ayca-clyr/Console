using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_8_d
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
        }
        static bool ReadInt32(int sayı)
        {
            bool durum=true;
            string giris=Console.ReadLine();
            int input;
            durum=int.TryParse(giris,out input);
            if(durum)
            {
               return true;
               Console.Write("Girdiğiniz değer bir sayıdır.");
               
            }

            else
            {
                return false;
                Console.Write("Girdiğiniz değer bir sayı değildir.");
            }
          
        }
    }
}
