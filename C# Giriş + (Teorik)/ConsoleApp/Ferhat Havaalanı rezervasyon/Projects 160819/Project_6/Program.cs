using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("//////////////\\\\\\\\\\\\\\");
            Console.WriteLine("|| Lorem Ipsum CRM System ||");
            Console.WriteLine("\\\\\\\\\\\\\\//////////////");
            Console.WriteLine("Lütfen kullanıcı adınızı ve parolanızı giriniz.");
            Console.Write("Kullanıcı Adı: ");
            string userName = Console.ReadLine();
            Console.Write("Parola: ");
            string password = string.Empty;
            while (true)
            {
                ConsoleKeyInfo key= Console.ReadKey(true);
                if (key.Key==ConsoleKey.Enter)
                {
                    break;
                }
                Console.Write("*");
                password += key.KeyChar;
            }
            Console.WriteLine("\n----------------");
            Console.WriteLine("\nPAROLA TEST: {0}",password);
        }
    }
}
