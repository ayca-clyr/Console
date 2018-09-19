using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_5_d
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Girilen açı değerleriyle üçgen oluşturulup veya oluşturulamamasını bulan program");
            Console.WriteLine();
            Console.WriteLine();
            
            Console.Write("Üçgenin birinci açı değerini giriniz:");
            int acı = int.Parse(Console.ReadLine());

            Console.Write("Üçgenin ikinci açı değerini giriniz:");
            int acı2 = int.Parse(Console.ReadLine());

            Console.Write("Üçgenin üçüncü açı değerini giriniz:");
            int acı3 = int.Parse(Console.ReadLine());

            int sonuc=acı+acı2+acı3;
            bool acıKontrol = (acı > 0 && acı < 180) && (acı2 > 0 && acı2 < 180) && (acı3 > 0 && acı3 < 180);
            if (acıKontrol)
            {
                if(sonuc==180)
                {
                    Console.Write("Girdiğiniz açı değerleriyle üçgen oluşturalabilir.");
                }
                else
                {
                    Console.Write("Girdiğiniz açı değerleriyle üçgen oluşturulamaz.");
                }
            }
            else
            {
                Console.Write("Yanlış giriş yaptınız. Lütfen açı değerlerini 0 ile 180 sayıları arasında giriniz.");
            }
            Console.Read();
        }
    }
}
