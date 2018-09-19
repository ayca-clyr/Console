using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Console_While
{
    class Program
    {
        static void Main(string[] args)
        {

            //---------Döngüler(While)-------------

            // If ve While arasındaki tek fark : If koşul doğruysa 1 kere çalışır. While koşul doğru olduğu sürece işlemleri tekrarlar.

            /* 
             while(-koşul-){
               //işlemler;
             } 
            */

            // 1'den 20'ye kadarki sayıları alt alt yazdıran programı yazınız.
            /*
            int sayı = 1;

            while (sayı <= 20)
            {
                Console.WriteLine(sayı);
                sayı++;
            }
            */

            // PART 1
            // 100'e kadar olan çift sayıların toplamı kaçtır ?

            //int sayılar = 0;
            //int toplam = 0;

            //while (sayılar < 100)
            //{
            //     toplam = toplam + sayılar;
            //     sayılar = sayılar + 2; 
            //   

            //}
            //Console.WriteLine("Toplam : " + toplam);

            // PART 2
            /*
            int sayılar = 1;
            int toplam = 0;
            while (sayılar < 100){
                if (sayılar % 2 == 0)
                {
                    toplam = toplam + sayılar;
                }
                sayılar++;
            }
            Console.WriteLine("Toplam : " + toplam);
             */

            // PART 3  ÖNERİLMEZ!
            //int sayılar = 1;
            //int toplam = 0;

            //while (true)
            //{
            //    if (sayılar % 2 == 0)
            //    {
            //        toplam = toplam + sayılar;
            //    }

            //    sayılar++;
            //    if (sayılar > 99)
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine("Toplam : " + toplam);

            //------Do-While-------- Do-While ve While arasındaki fark : Do-While 1 kezde olsa işlemi 1 kez yapıyor. While'de ise koşul yanlışsa hiçbir işlem yapmaz.

            /*
             * do{
             *      //Yapılacak işlemler
             * }while(-koşul-);
             */

            // Girilen şifrenin doğru olup olmadığını kontrol eden kodu yazınız. Doğru değilse yeniden girilmesini isteyiniz.
            // PART 1
            /*
            string dogruSifre ="Burak123";
            string istenilenSifre = null;
            Console.WriteLine("Selam kullanıcı. Lütfen şifreyi giriniz :");
            do
            {             
                istenilenSifre = Console.ReadLine();
            } while (dogruSifre != istenilenSifre);  // Eşit değilse kısmı döngü tekrar çalışsın diye.Eşitse döngüden çıkar, yazdırır.

            Console.WriteLine("Kullanıcı Girişi Başarılı");
            */

            // PART 2
            /*
            string dogruSifre = "Burak123";
            string istenilenSifre = null;
            Console.WriteLine("Selam kullanıcı. Lütfen şifreyi giriniz :");
            do
            {
                if(istenilenSifre != null)

              
                    Console.WriteLine("Tekrar giriniz :");
                    istenilenSifre = Console.ReadLine();
                  
                
            } while (dogruSifre != istenilenSifre);  

            Console.WriteLine("Kullanıcı Girişi Başarılı");
            */

            // Kullanıcıdan sınıf mevcudu alıp, sınıftakilerin isimlerini tek tek isteyip, isim girişi bittikten sonra sınıftakilerin adını aralarına virgül koyarak yazdırınız. (VERSION 1).       

            // PART 1
            /*
            Console.WriteLine("Lütfen Sınıf mevcudunuz giriniz :");
            int sınıfMevcudu = int.Parse(Console.ReadLine());           
            int sayı = 0;
            string kisiIsımleri = null;   // string kisiIsımleri = "";

           do{
               if (sınıfMevcudu - sayı == 1)
               {
                   kisiIsımleri = kisiIsımleri + Console.ReadLine();
               }
               else
               {                  
                   kisiIsımleri = kisiIsımleri + Console.ReadLine() + ", ";      //   ", ve boşluk"         
               }
               sayı++;
           } while (sayı < sınıfMevcudu);

           Console.WriteLine(kisiIsımleri);
            */

            // PART 2

            /*
           Console.WriteLine("Lütfen Sınıf mevcudunuz giriniz :");
           int sınıfMevcudu = int.Parse(Console.ReadLine());
           int sayı = 0;
           string kisiIsımleri = null;   // string kisiIsımleri = "";

           while (sayı < sınıfMevcudu)
           {
               if (sınıfMevcudu - sayı == 1)
               {
                   kisiIsımleri = kisiIsımleri + Console.ReadLine();
               }
               else
               {
                   kisiIsımleri = kisiIsımleri + Console.ReadLine() + ", ";      //   ", ve boşluk"         
               }
               //kisiIsımleri = kisiIsımleri + Console.ReadLine() + ", ";
               sayı++;
           } 
            
           Console.WriteLine(kisiIsımleri);
              */
            // Kullanıcıdan sınıf mevcudu ALMADAN, sınıftakilerin isimlerini tek tek isteyip, isim girişi bittikten sonra sınıftakilerin adını aralarına virgül koyarak yazdırınız. (VERSION 2)

            /*
            Console.WriteLine("Lütfen İsim giriniz :");
            Console.WriteLine("Bitmesini istiyorsanız (-) tuşuna basınız.");
            string kisiIsımleri = null;
            string sınıf = null;


            while (kisiIsımleri != "0")
            {

                Console.Write("Ad Soyad : ");
                kisiIsımleri = Console.ReadLine();
                if (kisiIsımleri != "0")
                {
                    sınıf = sınıf + kisiIsımleri + ", ";
                }
            }
            
            Console.WriteLine(sınıf);  
            */






            //  1) 
            /*
            int satır = 0;

            while (satır < 5)
            {
                int sutun = 0;
                while (sutun < 5)
                {
                    Console.Write("*");
                    sutun++;
                }
                Console.WriteLine("\n");
                satır++;
            }
            */

            // 2)

            /* 
             
            int satır = 0;

            while (satır < 5)
            {
                int sütun = 0;
                while (sütun < 5)
                {
                    if (satır == 0 || satır == 4)
                    {
                        Console.Write("*");
                        sütun++;
                    }
                    else
                    {
                        if (sütun == 0 || sütun == 4)
                        {
                            Console.Write("*");
                            sütun++;
                        }
                        else
                        {
                            Console.Write(" ");
                            sütun++;
                        }
                    }

                }            
              /*
              int satır = 0;

            while (satır < 5)
            {
                int sütun = 0;
                while (sütun < 5)
                {
                    if (satır == 0 || satır == 4 || sütun == 0 || sütun == 4)
                    {
                        Console.Write("*");
                        sütun++;
                    }
                    else
                    {
                        Console.Write(" ");
                            sütun++; 
               
                    }

                }

                Console.Write("\n");
                satır++;
            }

                Console.Write("\n");
                satır++;
            }
              
              */
            // 3)

            /*
            int sayac = 1;
            int satır = 0;

            while (satır < 5)
            {
                int sutun = 0;
                while (sutun < sayac)
                {
                    
                    Console.Write("*");
                    sutun++;
                    
                }
                Console.WriteLine("\n");
                satır++;
                sayac++;

            } 
           */

            /*
            
             int satır = 0;

            while (satır < 5)
            {
                int sutun = 0;
                while (sutun <= satır)
                {
                    Console.Write("*");
                    sutun++;
                }
                Console.WriteLine("\n");
                satır++;
            }
              
              */
            // 4)

            /*
             int satır = 0;

            while (satır < 5)
            {
                int sütun = 0;
                while (sütun < 5)
                {
                    if (sütun == 0 ||  satır == 4 || satır == sütun)
                    {
                        Console.Write("*");
                        
                    }
                    else
                    {
                        Console.Write(" ");
                            
               
                    }
                    sütun++;

                }

                Console.Write("\n");
                satır++;
            }

                Console.Write("\n");
                satır++;
            }
   

    }

*/

            // 5) 1 ve 3 basamak arasında girdiği sayıyı basamaklarına aşağıdaki gibi ayırınız.
            // 345 =   5x1 = 5     4x10 = 40  3x100 = 300

            /*
                Console.WriteLine("1 ve 3 basamak arasında bir sayı giriniz.");            
                int sayı =int.Parse (Console.ReadLine());

                int birler = sayı % 10;
                sayı = sayı / 10;
                int onlar = sayı % 10;
                sayı = sayı / 10;
                int yüzler = sayı % 10;
                sayı = sayı / 10;
                int birlerDegeri = birler * 1;
                int onlarDegeri = onlar * 10 ;
                int yuzlerDegeri = yüzler * 100;

                Console.WriteLine(birler+" x 1 = {0} ",birlerDegeri);
                Console.WriteLine(onlar+" x 10 = {0} ",onlarDegeri);
                Console.WriteLine(yüzler+" x 100 = {0}",  yuzlerDegeri);

              */

            /*

            Console.WriteLine("1 ve 3 basamak arasında bir sayı giriniz.");
            string girilenSayı = Console.ReadLine();

            int sayıUzunlugu = girilenSayı.Length;
            int basamakSayısı = 1;
            int rakam;

            int sayı = int.Parse(girilenSayı);

            while(basamakSayısı <= girilenSayı.Length){
                rakam = Convert.ToInt32(sayı % Math.Pow(10,basamakSayısı)) / Convert.ToInt32(Math.Pow(10,(basamakSayısı-1)));
                Console.WriteLine("{0} x {1} = {2}", rakam, Math.Pow(10, (basamakSayısı - 1)), rakam * Math.Pow(10, (basamakSayısı - 1)));
                basamakSayısı++;

            }

              */

            Console.WriteLine("1 ve 3 basamak arasında bir sayı giriniz.");
            string girilenSayı = Console.ReadLine();

           // int sayıUzunlugu = girilenSayı.Length;
            int basamakSayısı = 1;
            int rakam;

            int sayı = int.Parse(girilenSayı);

            while (sayı / Convert.ToInt32(Math.Pow(10, (basamakSayısı - 1))) != 0 )
            {
                rakam = Convert.ToInt32(sayı % Math.Pow(10, basamakSayısı)) / Convert.ToInt32(Math.Pow(10, (basamakSayısı - 1)));
                Console.WriteLine("{0} x {1} = {2}", rakam, Math.Pow(10, (basamakSayısı - 1)), rakam * Math.Pow(10, (basamakSayısı - 1)));
                basamakSayısı++;

            }







        }
    }
}
    
