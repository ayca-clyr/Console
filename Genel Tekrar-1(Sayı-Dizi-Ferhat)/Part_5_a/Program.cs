using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_5_a
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lütfen 1.sayıyı giriniz :");
            int sayı1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen 2.sayıyı giriniz :");
            int sayı2 = int.Parse(Console.ReadLine());

            int sonuc = sayı2 % sayı1;
            int degeri = sayı2 / sayı1;

            if(sayı1 < sayı2 && sonuc == 0)
            {                          
                    Console.WriteLine("{0} sayısı {1} sayısının tam katıdır ve sonucu : {2}",sayı2,sayı1,degeri);                  
            }
            else
            {
                Console.WriteLine("Yanlış değer girdiniz! Lütfen ilk sayıyı ikinci sayıdan küçük giriniz!");
            }
            Console.WriteLine("2. Sayının 1.Sayının katını bulduran program!");
        }
    }
}
