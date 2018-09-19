using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Console_Switch_Case{
    class Program{
        static void Main(string[] args){

            // Switch - Case

            /*
             * switch(değişken){
             *  case durum :
             *      //işlemler
             *      break;
             *  case durum2 :
             *      //işlemler
             *      break;
             *   default :
             *      //işlemler
             *}
             **/
                
            // Kullanıcının girdiği 1-7 arasındaki değere göre haftanın günü karşılığını veren programı yazınız.
            /*
            Console.WriteLine("Lütfen 1 ve 7 arasında bir sayı giriniz :");
            int sayı = int.Parse(Console.ReadLine());

            switch (sayı)
            {
                case 1 :
                    Console.WriteLine("Bugun günlerden Pazartesi");
                    break;
                case 2:
                    Console.WriteLine("Bugun günlerden Salı");
                    break;
                case 3:
                    Console.WriteLine("Bugun günlerden Çarşamba");
                    break;
                case 4:
                    Console.WriteLine("Bugun günlerden Perşembe");
                    break;
                case 5:
                    Console.WriteLine("Bugun günlerden Cuma");
                    break;
                case 6:
                    Console.WriteLine("Bugun günlerden Cumartesi");
                    break;
                case 7:
                    Console.WriteLine("Bugun günlerden Pazar");
                    break;
                default :
                    Console.WriteLine("Yanlış değer girdiniz!");
                    break;
            }
            */
            // Kullanıcıya kaçıncı ayda olduğunu sorarak hangi mevsimde bulunduğunu gösteren kodu yazınız.

            Console.WriteLine("Kaçıncı ayda olduğunuzu giriniz: ");
            int ay = int.Parse(Console.ReadLine());

            switch(ay){
                case 12 :
                case 1 :
                case 2 :
                     Console.WriteLine("Kış");
                     break;
                case 3 :
                case 4 :
                case 5 :
                      Console.WriteLine("İlkbahar");
                     break;
                case 6 :
                case 7 :
                case 8 :
                    Console.WriteLine("Yaz");
                    break;
                case 9 :
                case 10 :
                case 11 :
                     Console.WriteLine("Sonbahar");
                     break;
                default :
                     Console.WriteLine("Yanlış girdiniz!");
                     break;
            }












        }
    }
}
