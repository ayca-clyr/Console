using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_8_a
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrintDateTime();
            //PrintStar();
            //PrintStar(5);
            //NewLine();
            //NewLine(5);
            //int []dizi={5,68,985,48};
            //PrintArray(dizi);
            //PrintArray(dizi, 'v');
            Console.Read();
        }
        static void PrintDateTime() {
            Console.WriteLine("Ekrana tarih bilgisi yazdırma");
            Console.Write("Şuanki tarih:"+DateTime.Now);
        }
        static void PrintStar() {
            Console.WriteLine("Ekrana yıldız yazdıran metot");
            Console.Write("*");
        }
        static void PrintStar(int starCount) {
            Console.WriteLine("Ekrana istenen sayıda yıldız yazdıran metot");
           int counter=0;
            while (counter < starCount)
            {
                Console.Write("*");
                counter++;
            }
        }
        static void NewLine() 
        {
            Console.WriteLine("Ekranda yeni boş satır oluşturan metot");
            Console.Write("\n");
        }
        static void NewLine(int lineCount) 
        {
            Console.WriteLine("Ekranda istenen sayıda yeni boş satır oluşturan metot");
            int counter = 0;
            while (counter < lineCount)
            {
                Console.Write("\n");
                counter++;
            }
        
        }
        static void PrintArray(int[] numbers) 
        {
            Console.WriteLine("Bir diziyi ekrana alt alta yazdırma");
            int counter = 0;
            while (counter < numbers.Length)
            {
                Console.WriteLine(numbers[counter]);
                counter++;
            }
        }
        static void PrintArray(int[] numbers, char direction)
        {
            Console.WriteLine("Bir diziyi ekrana farklı diziliş yönlerinde yazdırma");
            int counter = 0;
            if (direction == 'v')
            {
                while (counter < numbers.Length)
                {
                    Console.WriteLine(numbers[counter]);
                    counter++;
                }

            }
            else if (direction == 'h')
            {
                while (counter < numbers.Length)
                {
                    Console.Write(numbers[counter] + " ");
                    counter++;
                }
            }
            
            else
            {
                while (counter < numbers.Length)
                {
                    Console.Write(numbers[counter] + " ");
                    counter++;
                }
            }
        }
    }
}
