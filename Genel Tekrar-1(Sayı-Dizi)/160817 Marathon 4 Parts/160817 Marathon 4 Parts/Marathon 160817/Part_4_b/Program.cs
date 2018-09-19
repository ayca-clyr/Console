using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_4_b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Birinci ismi girin:");
            string isim = Console.ReadLine();

            Console.Write("Birinci ismin yaşını girin:");
            int yas = int.Parse(Console.ReadLine());

            Console.Write("İkinci isimi girin:");
            string isim2 = Console.ReadLine();

            Console.Write("İkinci ismin yaşını girin:");
            int yas2 = int.Parse(Console.ReadLine());

            Console.Write("Üçüncü ismi girin:");
            string isim3 = Console.ReadLine();

            Console.Write("Üçüncü ismin yaşını girin:");
            int yas3 = int.Parse(Console.ReadLine());

            bool kontrol = yas == yas2 && yas2 == yas3;
            bool kontrol2 = yas != yas2 && yas2 != yas3;
            bool kontrol3 = yas > yas2 && yas > yas3;
            bool kontrol4 = yas >= yas2 && yas >= yas3;
            bool kontrol5 = yas < yas2 && yas < yas3;
            bool kontrol6 = yas <= yas2 && yas2 <= yas3;
            bool kontrol7 = yas2 > yas && yas2 > yas3;
            bool kontrol8 = yas2 >= yas && yas2 >= yas3;
            bool kontrol9 = yas2 < yas && yas2 < yas3;
            bool kontrol10 = yas2 <= yas && yas2 <= yas3;
            bool kontrol11 = yas3 > yas && yas3 > yas2;
            bool kontrol12 = yas3 >= yas && yas3 >= yas2;
            bool kontrol13 = yas3 < yas && yas3 < yas;
            bool kontrol14 = yas3 <= yas && yas3 <= yas2;


            Console.WriteLine(isim + ", " + isim2 + " ve " + isim3 + " isimli kişilerin yaşları birbirine eşittir:" + kontrol);
            Console.WriteLine(isim + ", " + isim2 + " ve " + isim3 + " isimli kişilerin yaşları birbirine eşit değildir:" + kontrol2);
            Console.WriteLine(isim + " isimli kişinin yaşı " + isim2 + " ve " + isim3 + " isimli kişilerin yaşlarından büyüktür:" + kontrol3);
            Console.WriteLine(isim + " isimli kişinin yaşı " + isim2 + " ve " + isim3 + " isimli kişilerin yaşlarından büyüktür veya yaşlarına eşittir:" + kontrol4);
            Console.WriteLine(isim + " isimli kişinin yaşı " + isim2 + " ve " + isim3 + " isimli kişilerin yaşlarından küçüktür:" + kontrol5);
            Console.WriteLine(isim + " isimli kişinin yaşı " + isim2 + " ve " + isim3 + " isimli kişilerin yaşlarından küçüktür veya yaşlarına eşittir:" + kontrol6);
            Console.WriteLine(isim2 + " isimli kişinin yaşı " + isim + " ve " + isim3 + " isimli kişilerin yaşlarından büyüktür:" + kontrol7);
            Console.WriteLine(isim2 + " isimli kişinin yaşı " + isim + " ve " + isim3 + " isimli kişilerin yaşlarından büyüktür veya yaşlarına eşittir:" + kontrol8);
            Console.WriteLine(isim2 + " isimli kişinin yaşı " + isim + " ve " + isim3 + " isimli kişilerin yaşlarından küçüktür:" + kontrol9);
            Console.WriteLine(isim2 + " isimli kişinin yaşı " + isim + " ve " + isim3 + " isimli kişilerin yaşlarından küçüktür veya yaşlarına eşittir:" + kontrol10);
            Console.WriteLine(isim3 + " isimli kişinin yaşı " + isim + " ve " + isim2 + " isimli kişilerin yaşlarından büyüktür:" + kontrol11);
            Console.WriteLine(isim3 + " isimli kişinin yaşı " + isim + " ve " + isim2 + " isimli kişilerin yaşlarından büyüktür veya yaşlarına eşittir:" + kontrol12);
            Console.WriteLine(isim3 + " isimli kişinin yaşı " + isim + " ve " + isim2 + " isimli kişilerin yaşlarından küçüktür:" + kontrol13);
            Console.WriteLine(isim3 + " isimli kişinin yaşı " + isim + " ve " + isim2 + " isimli kişilerin yaşlarından küçüktür veya yaşlarına eşittir:" + kontrol14);
            Console.Read();
        }
    }
}
