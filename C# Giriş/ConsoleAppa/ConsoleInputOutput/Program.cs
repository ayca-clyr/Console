using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            // Output

            Console.Write("Satıra çıktı üretir. Alt satıra atlamak için \\n karakteri kullanılır.");
            Console.WriteLine("Ekrana istenen ifadeyi yazdırır. İfade bittikten sonra otomatik alt satıra geçer");

            // Input

            /*
             * ReadLine()
             * Kullanıcıdan giriş beklenir.Kullanıcı istediği ifadeyi yazdıktan sonra ENTER tuşuna basar ve ReadLine metodu ENTER tuşu ile birlikte çalışır.
             * ReadLine metodu string dönüş tipine sahiptir.
             */
            string input1 = Console.ReadLine();
          
            /*
             * Console.Read();
             * Kullanıcının ekrana yazdığı ifadeyi karakter karakter okur.
             * Her bir karakterin ASCII değerini int olarak döndürür.
             * ENTER tuşuna basıldığında Read() metotları çalışmaya başlar.
             * Okunan karakteri char tipinde ele almak istiyorsak (char) ifadesiyle int değeri char tipine cast etmeniz gerekir.
             */
             int input2 = Console.Read();      
            char character = (char)input2;
            /*
                        * Console.ReadKey()
                        * Klavyeden herhangi bir tuşa basıldığı anda, basılan tuşu
                        * ConsoleKeyInfo tipinde döndüren metottur. Enter tuşuna basmaya
                        * gerek kalmaz
                        */

            ConsoleKeyInfo keyInfo = Console.ReadKey();

            char keyChar = keyInfo.KeyChar;

            if (keyChar == 'A')
            {

            }

        }
    }
}
