using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_3_b
{
    class Program
    {
        static void Main(string[] args)
        {
            // b. Ekrandan giriş yapılan iki tam sayı değeri, kullanılabilecek tüm karşılaştırma operatörlerini kullanarak değerlendirmesini yapın. 
            //Sonucu bool tipinde bir değişkene atayın ve örnekte olduğu gibi alt alta sonuçları yazdırın.(<, >, <=, >=, ==, !=)
            Console.Write("Birinci sayıyı girin:");
            int sayı = int.Parse(Console.ReadLine());
            Console.Write("İkinci sayıyı girin:");
            int sayı2 = int.Parse(Console.ReadLine());

            bool kontrol = sayı == sayı2;
            bool kontrol2 = sayı != sayı2;
            bool kontrol3 = sayı > sayı2;
            bool kontrol4 = sayı < sayı2;
            bool kontrol5 = sayı >= sayı2;
            bool kontrol6 = sayı <= sayı2;

            Console.WriteLine(sayı + " ile " + sayı2 + " değerleri birbirine eşittir: " + kontrol);
            Console.WriteLine(sayı + " ile " + sayı2 + " değerleri birbirine eşittir: " + kontrol2);
            Console.WriteLine(sayı + "değeri " + sayı2 + " değerinden büyüktür: " + kontrol3);
            Console.WriteLine(sayı + "değeri " + sayı2 + " değerinden büyüktür: " + kontrol4);
            Console.WriteLine(sayı + " değeri ile " + sayı2 + " değerinden büyüktür veya eşittir: " + kontrol5);
            Console.WriteLine(sayı + " değeri ile " + sayı2 + " değerinden büyüktür veya eşittir: " + kontrol6);

            Console.Read();

        }
    }
}
