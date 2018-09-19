using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Console_Conventions{
    class Program{
        static void Main(string[] args){


            // Convertion (Dönüşümler)

            // Implicit Convertion (Kapalı)
            /*
            int toplam;                        // Byte'ı int'a attık. Küçükten büyüğe atıldığı için kapalı. Data kaybıda yaşanmaz.
            byte sayi = 25;
            toplam = sayi;

            int num = int.MaxValue;
            long bigNum = num;

            // Explicit Convertion (Açık)

            // Tip dönüşümlerinde tip uyumsuzluğu durumunda atama işlemi yapabilmek için 'cast' işlemini kullanıyoruz.

            byte toplam2; // 0-255 arasında değer alır. Fakat int değerimiz ['6' değil] veritipi olarak.Int'ı byte'a atamayız.
            int sayi2 = 300;
            toplam2 =(byte)sayi2;
            
            long bigNum2 = 3000000000;  // 0 'dan başlıyor +2 milyara gidiyor. Sınır bitince - 2milyara dönüp 0'a doğru devam ediyor.
            int num2;
            num2 =(int)bigNum2;

            Console.WriteLine(num2);
            */
            // ---------------------------------------------------- 
            
            //Console.Write("Lütfen bir sayı yazınız :");

            //// Boxing / Kutulama
            //object input = Console.ReadLine();   // String değeri object'e çeviriyor.

            //object number = 100;
            
            //int bigNum =(int) number/*Unboxing*/ * 10;  // Unboxing verdiğim değer tipinde datayı çıkarmak.

            //// Unboxing

            //string yazıylaSayı =(string) number;      // Çeviriyor ama dönüştüremiyor yani sonuç NULL olarak döner.
 
            //---------------------------------------------------------------

            // String ifadeleri nümerik tiplere dönüştürürken Parse metotlarını kullanırız.

            int a = int.Parse("39");
            byte b = byte.Parse("95");
            double c = double.Parse("123.5");

            // Nümerik tipleri(hatta herhangi bir veri tipi için) string tiplere dönüştürürken ise ;

            string sonuc = a.ToString();
            string sonuc2 = b.ToString();
            string sonuc3 = c.ToString();

            //-----------------------------------------

            // Convert 

            int x = Convert.ToInt32("82974");

            //------------------------------------

           
            // string result = "45" + 5;                      // sonuc = 455  String daha baskındır. O yüzden int'a stringe atamayız.
            // string result = "45" + 5 + 9;                  // sonuc = 4559         
            // string resutl = "45" + (5 + 9);                // sonuc = 4514   
            // string result = 5 + 9 + "45";                  // sonuc = 1445
            // string result = 5 + "45" + 9;                  // sonuc = 5459
            // string result = 5 + 9 + "23" + 5 + 4 + "3";    // sonuc = 1423543
            // string result = 5 + (9 + "23") + 5 + 4 + "3";  // sonuc = 5923543












            Console.WriteLine();
            















        }
    }
}
