using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark_Ücret_Hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            bool dongu = true;
            bool dongu4 = true;
            float tutar = 0;
            while (dongu)
            {

                int t;
               
                
                while (dongu4) { 
                Console.WriteLine("1. Otomobil için 1’e basın ");
                Console.WriteLine("2. Motosiklet için 2’ye basın");
                Console.WriteLine("3. Minibüs için 3’e basın");
                Console.WriteLine("4. Kamyon (ve diğer ticari araçlar) için 4’e basın");
                    dongu4 = false;
                }
                char tur = Console.ReadKey(true).KeyChar;
                bool durum1 = int.TryParse(tur.ToString(), out t);

                if (!durum1)
                {
                   
                }
                else
                {
                    bool dongu2 = true;
                    while (dongu2)
                    {
                        float s;
                        Console.WriteLine("Araç kaç saat boyunca park alanında kaldı?");
                        string saat = Console.ReadLine();
                        bool durum2 = float.TryParse(saat, out s);
                        if (!durum2)
                        {
                            Console.WriteLine("Lütfen Geçerli Bir Sayı Giriniz!");
                        }
                        else
                        {
                            if (tur == '1')
                            {
                                if (s > 0 && s <= 2)
                                {

                                    Console.WriteLine("Ödemeniz Gereken tutar : {0}", tutar + 5 + "Tl");
                                }
                                else if (s > 2 && s <= 6)
                                {
                                    Console.WriteLine("Ödemeniz Gereken tutar : {0}", tutar + 10 + "Tl");
                                }
                                else if (s > 6 && s <= 12)
                                {
                                    Console.WriteLine("Ödemeniz Gereken tutar : {0}", tutar + 20 + "Tl");
                                }
                                else if (s > 12 && s <= 24)
                                {
                                    Console.WriteLine("Ödemeniz Gereken tutar : {0}", tutar + 35 + "Tl");
                                }
                                else if (s > 24)
                                {
                                    s = s / 24;
                                    int sayac = 1;
                                    while (sayac < s)
                                    {
                                        tutar = tutar + 20;

                                        sayac++;
                                    }
                                    Console.WriteLine("Ödemeniz Gereken tutar : {0}", tutar + 35 + "Tl");
                                }
                                dongu = false;
                                break;
                                

                            }
                            else if (tur == '2')
                            {
                                if (s > 0 && s <= 2)
                                {

                                    Console.WriteLine("Ödemeniz Gereken tutar : "+  "Ücretsiz");
                                }
                                else if (s > 2 && s <= 6)
                                {
                                    Console.WriteLine("Ödemeniz Gereken tutar : {0}", tutar + 3 + "Tl");
                                }
                                else if (s > 6 && s <= 12)
                                {
                                    Console.WriteLine("Ödemeniz Gereken tutar : {0}", tutar + 6 + "Tl");
                                }
                                else if (s > 12 && s <= 18)
                                {
                                    Console.WriteLine("Ödemeniz Gereken tutar : {0}", tutar + 12 + "Tl");
                                }
                                else if (s > 18  && s <= 24)
                                {
                                    Console.WriteLine("Ödemeniz Gereken tutar : {0}", tutar + 20 + "Tl");
                                }
                                else if (s > 24)
                                {
                                    s = s / 24;
                                    int sayac = 1;
                                    while (sayac < s)
                                    {
                                        tutar = tutar + 10;

                                        sayac++;
                                    }
                                    Console.WriteLine("Ödemeniz Gereken tutar : {0}", tutar +10 + "Tl");
                                }
                                dongu = false;
                                break;
                            }
                           else if (tur == '3')
                            {
                                if (s > 0 && s <= 2)
                                {

                                    Console.WriteLine("Ödemeniz Gereken tutar : {0}", tutar + 8 + "Tl");
                                }
                                else if (s > 2 && s <= 6)
                                {
                                    Console.WriteLine("Ödemeniz Gereken tutar : {0}", tutar + 16 + "Tl");
                                }
                                else if (s > 6 && s <= 12)
                                {
                                    Console.WriteLine("Ödemeniz Gereken tutar : {0}", tutar + 32 + "Tl");
                                }
                                else if (s > 12 && s <= 24)
                                {
                                    Console.WriteLine("Ödemeniz Gereken tutar : {0}", tutar + 45 + "Tl");
                                }
                                else if (s > 24)
                                {
                                    s = s / 24;
                                    int sayac = 1;
                                    while (sayac < s)
                                    {
                                        tutar = tutar + 25;

                                        sayac++;
                                    }
                                    Console.WriteLine("Ödemeniz Gereken tutar : {0}", tutar + 45+ "Tl");
                                }
                                dongu = false;
                                break;
                            }
                           else if (tur == '4')
                            {
                                if (s > 0 && s <= 2)
                                {

                                    Console.WriteLine("Ödemeniz Gereken tutar : {0}", tutar + 15 + "Tl");
                                }
                                else if (s > 2 && s <= 6)
                                {
                                    Console.WriteLine("Ödemeniz Gereken tutar : {0}", tutar + 30 + "Tl");
                                }
                                else if (s > 6 && s <= 12)
                                {
                                    Console.WriteLine("Ödemeniz Gereken tutar : {0}", tutar + 60 + "Tl");
                                }
                                else if (s > 12 && s <= 24)
                                {
                                    Console.WriteLine("Ödemeniz Gereken tutar : {0}", tutar + 100 + "Tl");
                                }
                                else if (s > 24)
                                {
                                    s = s / 24;
                                    int sayac = 1;
                                    while (sayac < s)
                                    {
                                        tutar = tutar + 55;

                                        sayac++;
                                    }
                                    Console.WriteLine("Ödemeniz Gereken tutar : {0}", tutar +100 + "Tl");
                                }
                                dongu = false;
                                break;
                            }
                        }
                       
                    }
                }
            }
        }
    }
}
