using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Otomobil için 1’e basın\n2. Motosiklet için 2’ye basın\n3. Minibüs için 3’e basın\n4. Kamyon (ve diğer ticari araçlar) için 4’e basın");
            double money = 0;
            bool exit = true;
            while (exit)
            {
                char key = Console.ReadKey(true).KeyChar;
                switch (key)
                {
                    case '1':
                        money = Parking(1);
                        exit = false;
                        break;
                    case '2':
                        money = Parking(2);
                        exit = false;
                        break;
                    case '3':
                        money = Parking(3);
                        exit = false;
                        break;
                    case '4':
                        money = Parking(4);
                        exit = false;
                        break;
                }
            }
            Console.WriteLine("Ödenmesi gereken tutar {0} TL", money);
        }
        static double Parking(int key)
        {
            decimal hour = 0;
            double money = 0;   
            bool success = true;
            do
            {
                if (!success)
                {
                    Console.WriteLine("Lütfen geçerli bir sayı yazınız!");
                }
                Console.Write("Araç kaç saat boyunca park alanında kaldı? ");
                success = decimal.TryParse(Console.ReadLine(), NumberStyles.Any, new CultureInfo("Tr"), out hour);
            } while (!success);
            switch (key)
            {
                case 1:
                    if (hour > 0 && hour <= 2)
                        money = 5;
                    else if (hour > 2 && hour <= 6)
                        money = 10;
                    else if (hour > 6 && hour <= 12)
                        money = 20;
                    else if (hour > 12 && hour <= 24)
                        money = 35;
                    else
                    { money = 35; hour -= 24; money += (int)(hour / 24) * 20; if (hour % 24 > 0) money += 20; }
                    break;
                case 2:
                    if (hour > 0 && hour <= 2)
                        money = 0;
                    else if (hour > 2 && hour <= 6)
                        money = 3;
                    else if (hour > 6 && hour <= 12)
                        money = 6;
                    else if (hour > 12 && hour <= 24)
                        money = 12;
                    else
                    { money = 12; hour -= 24; money += (int)(hour / 24) * 10; if (hour % 24 > 0) money += 10; }
                    break;
                case 3:
                    if (hour > 0 && hour <= 2)
                        money = 8;
                    else if (hour > 2 && hour <= 6)
                        money = 16;
                    else if (hour > 6 && hour <= 12)
                        money = 32;
                    else if (hour > 12 && hour <= 24)
                        money = 45;
                    else
                    { money = 45; hour -= 24; money += (int)(hour / 24) * 25; if (hour % 24 > 0) money += 25; }
                    break;
                case 4:
                    if (hour > 0 && hour <= 2)
                        money = 15;
                    else if (hour > 2 && hour <= 6)
                        money = 30;
                    else if (hour > 6 && hour <= 12)
                        money = 60;
                    else if (hour > 12 && hour <= 24)
                        money = 100;
                    else
                    { money = 100; hour -= 24; money += (int)(hour / 24) * 55; if (hour % 24 > 0) money += 55; }
                    break;
            }
            return money;
        }
    }
}