using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_5_c
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Girilen kenar uzunluklarıyla üçgen oluşturulup veya oluşturulamamasını bulan program");
            Console.WriteLine();
            Console.WriteLine(); 
            Console.Write("Üçgenin birinci kenarını giriniz:");
            double kenar = double.Parse(Console.ReadLine());

            Console.Write("Üçgenin ikinci kenarını giriniz:");
            double kenar2 = double.Parse(Console.ReadLine());

            Console.Write("Üçgenin üçüncü kenarını giriniz:");
            double kenar3 = double.Parse(Console.ReadLine());

            bool kontrol = ((kenar + kenar2) > kenar3) && ((kenar2 + kenar3) > kenar) && ((kenar + kenar3) > kenar2);
            double fark=kenar-kenar2;
            double fark2=kenar2-kenar3;
            double fark3=kenar-kenar3;
            if(kontrol){
                if ((fark <= 0)||(fark2<=0)||fark3<=0)
                {
                    fark = fark * (-1);
                    fark2 = fark2 * (-1);
                    fark3 = fark3 * (-1);
                    if ((fark < kenar3)||(fark2<kenar)||(fark3<kenar2))
                    {
                        Console.Write("Bu Üçgen çizilebilir.");
                    
                    }
                    else
                    {
                        Console.Write("Bu üçgen çizilemez.");
                    }                
                }
                else
                {
                    Console.Write("Bu üçgen çizilemez");
                }
            }
            else
            {
                Console.Write("Bu üçgen çizilemez");
            }
            Console.Read();
        }
    }
}
