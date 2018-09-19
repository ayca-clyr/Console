using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Console_ParamsKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            // int result = Sum("Ayça",'Ş',22, 3456, 657, 6, 34, 68, 09, 34);
            
       // Voidse başına bir şey tanımadan direk fonksiyonu çağrıp, yazabiliriz. Ama bool,int,stringse başına tanımlamanız gerekiyor.
         bool result1 = SaveStudent("Tsubasa", "Ozara", DateTime.Parse("1.1.1998"), "İşletme", "Fizik", "Bilgisayar Mühendisi");
         if (result1 == true)
         {
             Console.WriteLine("Kaydetme işlemi başarılı");
         }
         else
         {
             Console.WriteLine("Hata meydana geldi!");
         }
        
        }


        // Params ile birlikte başka tipte parametreler de fonksiyona alınabilir.
        // Params ifadesi, parametre tanımlarının mutlaka sonuncusu olmalıdır.
        // Bir fonksiyonda en fazla 1 adet params kullanılabilir.
        // Params argüman almak zorunda değildir.   (Argüman : Değer)  int = 3  "int = Parametre"  "3 : Argüman";
        static int Sum(params int[] numbers)
        {
            int total = 0;
            int index = 0;

            while (index < numbers.Length)
            {
                total += numbers[index];
                index++;
            }

            return total;
        }

        static int Sum(string name, char letter, params int[] numbers)
        {
            int total = 0;
            int index = 0;

            while (index < numbers.Length)
            {
                total += numbers[index];
                index++;
            }

            return total;
        }
        /*
        static void SaveStudent(string firstName, string lastName, DateTime dateOfBirth,params string[] scholl)
        {

        }
         */
        static bool SaveStudent(string firstName, string lastName, DateTime dateOfBirth, params string[] scholl)
        {
           
            if (4 == 4)
            {
                return true;

            }
            else
            {
                return false;
            }

          

        }
    }
}
