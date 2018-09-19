using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2_l
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen ondalıklı bir sayı giriniz :");
            float ondalıklıSayı = float.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen tam bir sayı giriniz : ");
            int tamSayı = int.Parse(Console.ReadLine());
            if (tamSayı == 0)
            {
                Console.WriteLine("Yanlış Değer Girdiniz!");
            }
            else
            {
                float bölüm = ondalıklıSayı / (float)tamSayı;

                Console.WriteLine(bölüm);
            }
        }
    }
}
