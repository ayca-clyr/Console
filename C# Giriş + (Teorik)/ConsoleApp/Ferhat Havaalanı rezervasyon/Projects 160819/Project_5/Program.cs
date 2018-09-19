using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_5
{
    class Program
    {
        static void Main(string[] args)
        {
            char key;
            string[] armchair = new string[20];
            bool success = true, armchairControl = true;
            int seat = 0,capacity;
            while (true)
            {
                success = true;
                Console.WriteLine("1. Business Class bölümü için 1 tuşuna basın\n2. Economy Class bölümü için 2 tuşuna basın");
                while (success)
                {
                    key = Console.ReadKey(true).KeyChar;
                    switch (key)
                    {
                        case '1':
                            Console.WriteLine("\n\nBusiness Class bölümünde kalan boş koltuklar: ");
                            capacity = ArmchairList(armchair, key);
                            if (capacity>0)
                            {
                                do
                                {
                                    if (!armchairControl)
                                    {
                                        Console.WriteLine("{0} Numaralı koltuğu daha önce \" {1} \" isimli yolcuya rezerve ettiniz!", seat, armchair[seat - 1]);
                                        Console.WriteLine("Lütfen boş koltuklardan birisini seçiniz.\n\n");
                                        Console.WriteLine("\n\nBusiness Class bölümünde kalan boş koltuklar: ");
                                        capacity = ArmchairList(armchair, key);
                                    }
                                    Console.Write("Seçilen koltuk numarası: ");
                                    seat = int.Parse(Console.ReadLine());
                                    armchairControl = SeatControl(armchair, seat);
                                } while (!armchairControl);
                                Console.Write("Lütfen yolcunun Adı ve Soyadını yazın: ");
                                armchair[seat - 1] = Console.ReadLine();
                                Console.WriteLine("Business Class Bölümündeki {0} numaralı koltuğu {1} yolcuya rezerve ettiniz", seat, armchair[seat - 1]); 
                            }
                            else
                            {
                                key = '2';
                                Console.WriteLine("Seçtiğiniz Business Class bölümünde boş koltuk kalmamıştır.");
                                Console.WriteLine("Economy Class bölümündeki boş koltukları görmek ister misiniz? E/H");
                                char query = Console.ReadKey(true).KeyChar;
                                if (query == 'E' || query == 'e')
                                    continue;
                                else if (query=='H' || query=='h')
                                    Console.WriteLine("Bir sonraki uçuş kayıtları 4 saat sonradır.");
                            }
                            success = false;
                            break;
                        case '2':
                            Console.WriteLine("\n\nEconomy Class bölümünde kalan boş koltuklar: ");
                            capacity = ArmchairList(armchair, key);
                            if (capacity>0)
                            {
                                do
                                {
                                    if (!armchairControl)
                                    {
                                        Console.WriteLine("{0} Numaralı koltuğu daha önce \" {1} \" isimli yolcuya rezerve ettiniz!", seat, armchair[seat - 1]);
                                        Console.WriteLine("Lütfen boş koltuklardan birisini seçiniz.\n\n");
                                        Console.WriteLine("\n\nEconomy Class bölümünde kalan boş koltuklar: ");
                                        capacity = ArmchairList(armchair, key);
                                    }
                                    Console.Write("Seçilen koltuk numarası: ");
                                    seat = int.Parse(Console.ReadLine());
                                    armchairControl = SeatControl(armchair, seat);
                                } while (!armchairControl);
                                Console.Write("Lütfen yolcunun Adı ve Soyadını yazın: ");
                                armchair[seat - 1] = Console.ReadLine();
                                Console.WriteLine("Economy Class Bölümündeki {0} numaralı koltuğu {1} yolcuya rezerve ettiniz", seat, armchair[seat - 1]); 
                            }
                            else
                            {
                                key = '1';
                                Console.WriteLine("Seçtiğiniz Economy Class bölümünde boş koltuk kalmamıştır.");
                                Console.WriteLine("Business Class bölümündeki boş koltukları görmek ister misiniz? E/H");
                                char query = Console.ReadKey(true).KeyChar;
                                if (query == 'E' || query == 'e')
                                    continue;
                                else if (query == 'H' || query == 'h')
                                    Console.WriteLine("Bir sonraki uçuş kayıtları 4 saat sonradır.");
                            }
                            success = false;
                            break;
                    }
                }
            }
        }
        static bool SeatControl(string[] armchair, int seat)
        {
            if (armchair[seat - 1] == null)
                return true;
            else
                return false;
        }

        static int ArmchairList(string[] armchair, char key)
        {
            int index,capacity=0;
            if (key == '1')
            {
                index = 0;
                while (index < 8)
                {
                    if (armchair[index] == null)
                    {
                        capacity++;
                        Console.WriteLine(index + 1);
                    }
                    index++;
                }
            }
            else
            {
                index = 8;
                while (index < armchair.Length)
                {
                    if (armchair[index] == null)
                    {
                        capacity++;
                        Console.WriteLine(index + 1);
                    }
                    index++;
                }
            }
            return capacity;
        }
    }
}