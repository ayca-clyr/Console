using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_5_e
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Girilen kenar uzunluklarıyla Dik üçgen oluşturulup veya oluşturulamamasını bulan program");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Üçgenin birinci kenarını giriniz:");
            int kenar = int.Parse(Console.ReadLine());

            Console.Write("Üçgenin ikinci kenarını giriniz:");
            int kenar2 = int.Parse(Console.ReadLine());

            Console.Write("Üçgenin üçüncü kenarını giriniz:");
            int kenar3 = int.Parse(Console.ReadLine());

            bool sıfırdanBüyükKontrol = (kenar > 0) && (kenar2 > 0) && (kenar3 > 0);

            bool dikKontrol = (kenar * kenar) + (kenar2 * kenar2) == (kenar3 * kenar3);
            bool dikKontrol2 = (kenar * kenar) + (kenar3 * kenar3) == (kenar2 * kenar2);
            bool dikKontrol3 = (kenar2 * kenar2) + (kenar3 * kenar3) == (kenar * kenar);

            if (sıfırdanBüyükKontrol)
            {
                if (kenar > kenar2 && kenar > kenar3)
                {
                    if (dikKontrol3)
                    {
                        Console.WriteLine("Girdiğiniz kenar uzunluklarıyla dik üçgen oluşturulabilir.");
                    }
                    else
                    {
                        Console.Write("Girdiğiniz kenar uzunluklarıyla dik üçgen oluşturulamaz");
                    }
                    
                }
                else if (kenar2 > kenar && kenar2 > kenar3)
                {
                    if (dikKontrol2)
                    {
                        Console.WriteLine("Girdiğiniz kenar uzunluklarıyla dik üçgen oluşturulabilir.");
                    }
                    else
                    {
                        Console.Write("Girdiğiniz kenar uzunluklarıyla dik üçgen oluşturulamaz");
                    }
                }
                else if (kenar3 > kenar && kenar3 > kenar2)
                {
                    if (dikKontrol)
                    {
                        Console.WriteLine("Girdiğiniz kenar uzunluklarıyla dik üçgen oluşturulabilir.");
                    }
                    else
                    {
                        Console.Write("Girdiğiniz kenar uzunluklarıyla dik üçgen oluşturulamaz");
                    }
                }
                
            }
            else
            {
                Console.Write("Yanlış giriş yaptınız. Girdiğiniz kenar uzunluklarını lütfen 0'dan büyük olacak şekilde girin.");
            }
            Console.Read();
        }
    }
}
