using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2_i
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("birinci sayıyı giriniz:");
            double sayi = double.Parse(Console.ReadLine());
            Console.Write("ikinci sayıyı giriniz:");
            int sayi2 = int.Parse(Console.ReadLine());
            double sonuc = sayi + sayi2;
            Console.Write("{0} sayısıyla {1} sayısının toplamı: {2}", sayi, sayi2, sonuc);
            Console.Read();
        }
    }
}
