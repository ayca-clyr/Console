using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Console_If_Else{
    class Program{
        static void Main(string[] args){

            //Karar Yapıları
            /*
             * if(-koşul-){
             *         // Yapılacak işlemler
             * }
             * else{
             *         // Yapılacak işlemler
             * }
             * */
            // Girilen sayının 10dan büyük olup olmadığını kontrol eden kodu yazınız.

            // PART 1
            //Console.WriteLine("Lütfen bir sayı giriniz :");
            //string input = Console.ReadLine();
            //int sayı = int.Parse(input);
            //if (sayı > 10)
            //{
            //    Console.WriteLine("Sayı 10 dan büyüktür.");
            //}else{
            //    Console.WriteLine("Sayı 10'dan küçüktür.");
            //}
        
            // PART 2
            // Console.WriteLine("Lütfen bir sayı giriniz :");
            //string input = Console.ReadLine();
            //int sayı = int.Parse(input);
            //if (sayı > 10){
            //    Console.WriteLine("Sayı 10 dan büyüktür.");
            //}
            //else{
            //    if (sayı == 10){
            //        Console.WriteLine("Sayı 10'a eşittir.");
            //    }
            //    else{
            //        Console.WriteLine("Sayı 10'dan küçüktür.");
            //    }
            //}
                
            // İki sınav notunun girilip ortalama nota göre 5 lik sistemden karne notunu belirleyen kodu yazınız.

            int sınavNotu1;
            int sınavNotu2;

            Console.WriteLine("Lütfen 1. sınav notunuzu giriniz :");          
            sınavNotu1 = int.Parse(Console.ReadLine()); 
            
            Console.WriteLine("Lütfen 2. sınav notunuzu giriniz :");
            sınavNotu2 = int.Parse(Console.ReadLine());

            // string not1 = Console.ReadLine();
            // string not2 = Console.ReadLine();
            // sınavNotu1 = int.Parse(not1);
            // sınavNotu2 = int.Parse(not2);

            int ortalama = (sınavNotu1 + sınavNotu2) / 2;

            //// PART 1
            //if (ortalama > 100 || ortalama < 0)
            //{
            //    Console.WriteLine("Girdiğiniz notlar yanlış!");
            //}
            //else
            //{
            //    if(ortalama <= 100 && ortalama >= 85){
            //        Console.WriteLine("Karne Notunuz : 5");
            //    }
            //    else
            //    {
            //        if (ortalama < 85 && ortalama >= 70)
            //        {
            //            Console.WriteLine("Karne Notunuz : 4");
            //        }
            //        else
            //        {
            //            if (ortalama < 70 && ortalama >= 55)
            //            {
            //                Console.WriteLine("Karne Notunuz : 3");

            //            }
            //            else
            //            {
            //                if (ortalama < 55 && ortalama >= 45)
            //                {
            //                    Console.WriteLine("Karne Notunuz : 2");
            //                }
            //                else
            //                {
            //                    if (ortalama < 45 && ortalama >= 25)
            //                    {
            //                        Console.WriteLine("Karne Notunuz : 1");

            //                    }
            //                    else
            //                    {
            //                        if (ortalama < 25 && ortalama > 0)
            //                        {
            //                            Console.WriteLine("Karne Notunuz : 0");
            //                        }
            //                    }
            //                }
                          
            //            }
            //        }
            //    }
            //}

//            // PART 2 
//            if (ortalama > 100 || ortalama < 0){
//                Console.WriteLine("Girdiğiniz notlar yanlış!");
//            }else if (ortalama <= 100 && ortalama >= 85){
//                Console.WriteLine("Karne Notunuz : 5");
//            }else if (ortalama < 85 && ortalama >= 70){
//                Console.WriteLine("Karne Notunuz : 4");
//            }else if (ortalama < 70 && ortalama >= 55){
//                Console.WriteLine("Karne Notunuz : 3");
//            }else if (ortalama < 55 && ortalama >= 45){
//                Console.WriteLine("Karne Notunuz : 2");
//            }else if (ortalama < 45 && ortalama >= 25){
//                Console.WriteLine("Karne Notunuz : 1");
//            }
//            else if (ortalama < 25 && ortalama > 0){
//                Console.WriteLine("Karne Notunuz : 0");

//            }
//        }
//    }
//}

            // PART 3

            if (ortalama > 100 || ortalama < 0)
            {
                Console.WriteLine("Girdiğiniz notlar yanlış!");
            } if (ortalama <= 100 && ortalama >= 85)
            {
                Console.WriteLine("Karne Notunuz : 5");
            } if (ortalama < 85 && ortalama >= 70)
            {
                Console.WriteLine("Karne Notunuz : 4");
            } if (ortalama < 70 && ortalama >= 55)
            {
                Console.WriteLine("Karne Notunuz : 3");
            } if (ortalama < 55 && ortalama >= 45)
            {
                Console.WriteLine("Karne Notunuz : 2");
            } if (ortalama < 45 && ortalama >= 25)
            {
                Console.WriteLine("Karne Notunuz : 1");
            }
            if (ortalama < 25 && ortalama > 0)
            {
                Console.WriteLine("Karne Notunuz : 0");

            }

           // PART 2'de ortalama < 45 dersek sadece düzgün çalışır. Sonuca ulaşınca diğerlerine bakmadan çıkıyor.
           // PART 3'de ortalama < 45 dersek düzgün çalışmaz.Hedefi bulduktan sonrası ve kalanları sıralar.

        }
    }
}
                    
                
            

       
