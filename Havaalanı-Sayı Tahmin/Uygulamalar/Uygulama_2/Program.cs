using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Uygulama_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac = 1;
            bool durum = true;
            int puan = 1000;

            
            while (durum)
            {
                Console.WriteLine("Lütfen Aşağıdaki Zorluk Derecelerinden Birini Seçiniz!");
                Console.WriteLine("1. Kolay Seviye için 1'i tuşlayın");
                Console.WriteLine("2. Orta Seviye için 2'i tuşlayın");
                Console.WriteLine("3. Zor Seviye için 3'ü tuşlayın");
                int i;
                string seviye = Console.ReadLine();
                bool seviyeSayisi = int.TryParse(seviye, out i);

                if (!seviyeSayisi)
                {
                    Console.WriteLine("Yanlış Bir Giriş Yaptınız!");
                }
                else
                {
                    Random rnd1 = new Random();
                    int number1 = rnd1.Next(1, 10);
                    Random rnd2 = new Random();
                    int number2 = rnd2.Next(1, 100);
                    Random rnd3 = new Random();
                    int number3 = rnd3.Next(1, 1000);

                    bool durum2 = true;
                    while (durum2)
                    {
                        if (seviye == "1")
                        {

                            int tahmin1;
                            Console.WriteLine("Lütfen  1 ile 10 Arasında Tahmini Bir Sayı Giriniz!");
                            string t1 = Console.ReadLine();
                            bool tah1 = int.TryParse(t1, out tahmin1);
                            if (!tah1)
                            {
                                Console.WriteLine("Yanlış Değer Girdiniz!");
                            }
                            else
                            {
                                if (tahmin1 == number1)
                                {
                                    Console.WriteLine("Tebrikler {0} doğru tahmin", tahmin1);
                                    Console.WriteLine("Oyunu {0} Tahminde Bitirdiniz!", sayac);
                                    puan = puan - (sayac * 1) + 1;
                                    Console.WriteLine("Puanınız : {0}", puan);
                                    Console.WriteLine("Oyunu Tekrar Oynamak İstiyor musunuz?  E/H ");
                                    string devam = Console.ReadLine();
                                    durum2 = true;
                                    while (durum2)
                                    {

                                        if (devam == "H")
                                        {
                                            durum2 = false;
                                            durum = false;
                                        }
                                        else if (devam == "E")
                                        {
                                            Console.WriteLine("Hadi Başlayalım O Zaman :) ");
                                            durum2 = false;
                                        }
                                    }
                                }
                                else
                                {
                                    if ((tahmin1 - number1 >= 6 )|| (number1 - tahmin1 >= 6))
                                    {
                                        Console.WriteLine("Soğuk!");
                                    }
                                    else if ((number1 - tahmin1 >= 4) || (tahmin1 - number1 >= 4))
                                    {
                                        Console.WriteLine("Ilık!");
                                    }

                                    else if((number1 - tahmin1 >= 0) ||(tahmin1- number1 >= 0 ))
                                    {
                                        Console.WriteLine("Sıcak!");
                                    }
                                    sayac++;
                                }
                            }
                        }

                        else if (seviye == "2")
                        {

                            int tahmin2;
                            Console.WriteLine("Lütfen  1 ile 100 Arasında Tahmini Bir Sayı Giriniz!");
                            string t2 = Console.ReadLine();
                            bool tah2 = int.TryParse(t2, out tahmin2);
                            if (!tah2)
                            {
                                Console.WriteLine("Yanlış Değer Girdiniz!");
                            }
                            else
                            {
                                if (tahmin2 == number2)
                                {
                                    Console.WriteLine("Tebrikler {0} doğru tahmin", tahmin2);
                                    Console.WriteLine("Oyunu {0} Tahminde Bitirdiniz!", sayac);
                                    puan = puan - (sayac * 1) + 1;
                                    Console.WriteLine("Puanınız : {0}", puan);
                                    Console.WriteLine("Oyunu Tekrar Oynamak İstiyor musunuz?  E/H ");
                                    string devam = Console.ReadLine();
                                    durum2 = true;
                                    while (durum2)
                                    {

                                        if (devam == "H")
                                        {
                                            durum2 = false;
                                            durum = false;
                                        }
                                        else if (devam == "E")
                                        {
                                            Console.WriteLine("Hadi Başlayalım O Zaman :) ");
                                            durum2 = false;
                                        }
                                    }
                                }
                                else
                                {
                                    if ((tahmin2 - number2 >= 25) || (number2 - tahmin2 >= 25))
                                    {
                                        Console.WriteLine("Soğuk!");
                                    }
                                    else if ((number2 - tahmin2 >= 10) || (tahmin2 - number2 >= 10))
                                    {
                                        Console.WriteLine("Ilık!");
                                    }

                                    else if ((number2 - tahmin2 >= 0) || (tahmin2 - number2 >= 0))
                                    {
                                        Console.WriteLine("Sıcak!");
                                    }
                                    sayac++;
                                }
                            }
                        }
                        if (seviye == "3")
                        {

                            int tahmin3;
                            Console.WriteLine("Lütfen  1 ile 1000 Arasında Tahmini Bir Sayı Giriniz!");
                            string t3 = Console.ReadLine();
                            bool tah3 = int.TryParse(t3, out tahmin3);
                            if (!tah3)
                            {
                                Console.WriteLine("Yanlış Değer Girdiniz!");
                            }
                            else
                            {
                                if (tahmin3 == number3)
                                {
                                    Console.WriteLine("Tebrikler {0} doğru tahmin", tahmin3);
                                    Console.WriteLine("Oyunu {0} Tahminde Bitirdiniz!", sayac);
                                    puan = puan - (sayac * 1) + 1;
                                    Console.WriteLine("Puanınız : {0}", puan);
                                    Console.WriteLine("Oyunu Tekrar Oynamak İstiyor musunuz?  E/H ");
                                    string devam = Console.ReadLine();
                                    durum2 = true;
                                    while (durum2)
                                    {

                                        if (devam == "H")
                                        {
                                            durum2 = false;
                                            durum = false;
                                        }
                                        else if (devam == "E")
                                        {
                                            Console.WriteLine("Hadi Başlayalım O Zaman :) ");
                                            durum2 = false;
                                        }
                                    }
                                }
                                else
                                {
                                    if ((tahmin3 - number3 >= 250) || (number3 - tahmin3 >= 250))
                                    {
                                        Console.WriteLine("Soğuk!");
                                    }
                                    else if ((number3 - tahmin3 >= 100) || (tahmin3 - number3 >=100))
                                    {
                                        Console.WriteLine("Ilık!");
                                    }

                                    else if ((number3 - tahmin3 >= 0) || (tahmin3 - number3 >= 0))
                                    {
                                        Console.WriteLine("Sıcak!");
                                    }
                                    sayac++;
                                }
                            }
                        }
                  }
                }

            }
        }
    }

}