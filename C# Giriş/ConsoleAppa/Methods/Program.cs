using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello();

            DateTime today = GetDate();
            Console.WriteLine(today);

            long result = Square(10);
            // int resutl = (int)Square(10);
            Console.WriteLine(result);

            int day, month, year;

            GetDateParts(out day, out month, out year);  // Out parametrelerinde sadece değişken yazılır. Argüman (değer) yazılmaz.
            Console.WriteLine("Bugun {0} yılının {1}. ayının {2}. günüdür.",year,month,day);
        }
        static void SayHello(){
        
            Console.WriteLine("Hello World");
        }
        static DateTime GetDate(){
            return DateTime.Today;
            
        }
        static long Square(int number)
        {
            long result = number * number;
            return result;
        }
        static void GetDateParts(out int day, out int month, out int year)
        {
            day = DateTime.Today.Day;
            month = DateTime.Today.Month;
            year = DateTime.Today.Year;
                
        }
    }
}
