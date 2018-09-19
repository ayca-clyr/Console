using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_3_a
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lütfen Bir şey Yazınız : ");
            string girilenIlkYazı = Console.ReadLine();

            Console.WriteLine("Lütfen bir Şey Yazınız :");
            string girilenIkıncıYazı = Console.ReadLine();

            bool sonuc1 = girilenIlkYazı == girilenIkıncıYazı;
            Console.WriteLine(!sonuc1);

            bool sonuc2 = girilenIkıncıYazı != girilenIlkYazı;
            Console.WriteLine(sonuc2);
           

           
        }
    }
}
