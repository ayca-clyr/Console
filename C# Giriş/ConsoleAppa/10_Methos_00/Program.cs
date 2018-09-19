using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
                                ----------PARAMETRE------------
 Değer döndürüyor mu döndürmüyor mu ona bakıyoruz. Döndürüyorsa return string,0 gibi ifadeler kullanıyoruz.
 Aynı işlemlerle (Ekrana bir şey yazdırmak) farklı tiplerle farklı sonuçlar üretmek. (Selam değilde Selam-Görüşürüz yazdırabiliyoruz.)

*/


namespace _10_Methos_00
{
    class Program
    {

        static void Main(string[] args)
        {

            //SayHello();                 //Console.WriteLine("Selam");

            //SayHello();                 //Console.WriteLine("Selam");

            string hello = GetHello();
            Console.WriteLine(hello);

           // Console.WriteLine(GetHello());
            


            // Console.ReadLine();  // Dersek değer döndürmez. Dönüştürmemiz lazım. Ama çalışır.
            // string input = Console.ReadLine();

            // Fonksiyon çağırmak
            HoldScreen();


           // Say("Selam");
            SayHello();

            HoldScreen();

            // Say("Görüşürüz");
            SayGoodBye();
        }

        
        static void SayHello()
        {
            Say("Selam");
            Console.WriteLine("Selam");
            Console.WriteLine("Selam");
        }
        static void SayGoodBye()
        {
            Say("Görüşürüz");
        }

        static void Say(string word)  // Parametredir. Parantez içinde yazılır. Tipi vardır.
        {
            Console.WriteLine(word);
            return;
        }

        static string GetHello()
        {
            return "Selam";
        }

        // Function implementation 
        static void HoldScreen()     // Bekletme fonksiyonu. Artık bu fonksiyon yerine HoldScreen kullanabiliriz.
        {
            Console.ReadLine();
        }



    }
}
