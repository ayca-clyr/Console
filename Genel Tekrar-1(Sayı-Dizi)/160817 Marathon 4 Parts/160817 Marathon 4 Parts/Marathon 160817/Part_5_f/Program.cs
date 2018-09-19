using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_5_f
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Girilen açı değerleriyle dik üçgen oluşturulup veya oluşturulamamasını bulan program");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Üçgenin birinci açı değerini giriniz:");
            int acı = int.Parse(Console.ReadLine());

            Console.Write("Üçgenin ikinci açı değerini giriniz:");
            int acı2 = int.Parse(Console.ReadLine());

            Console.Write("Üçgenin üçüncü açı değerini giriniz:");
            int acı3 = int.Parse(Console.ReadLine());

            bool acıKontrol = (acı > 0 && acı < 180) && (acı2 > 0 && acı2 < 180) && (acı3 > 0 && acı3 < 180);
            bool dikAcıKontrol = (acı + acı2) == acı3 && acı + acı2 + acı3 == 180;
            bool dikAcıKontrol2 = (acı + acı3) == acı2 && acı + acı2 + acı3 == 180;
            bool dikAcıKontrol3 = (acı2 + acı3) == acı && acı + acı2 + acı3 == 180;
            if (acıKontrol)
            {
                if (acı == 90)
                {
                    if (dikAcıKontrol3)
                    {
                        Console.Write("Girdiğiniz açı değerleri ile dik üçgen oluşturulabilir.");
                    }
                    else
                    {
                        Console.Write("Girdiğiniz açı değerleri ile dik üçgen oluşturulamaz");
                    }
                }
                else if (acı2 == 90)
                {
                    if (dikAcıKontrol2)
                    {

                        Console.Write("Girdiğiniz açı değerleri ile dik üçgen oluşturulabilir.");
                    }
                    else
                    {
                        Console.Write("Girdiğiniz açı değerleri ile dik üçgen oluşturulamaz");
                    }
                }
                else if (acı3 == 90)
                {
                    if (dikAcıKontrol)
                    {

                        Console.Write("Girdiğiniz açı değerleri ile dik üçgen oluşturulabilir.");
                    }
                    else
                    {
                        Console.Write("Girdiğiniz açı değerleri ile dik üçgen oluşturulamaz");
                    }
                }
                else
                {
                    Console.Write("Girdiğiniz açı değerleri ile dik üçgen oluşturulamaz");
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
