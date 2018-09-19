using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Aşağıdaki kişi bilgilerini giriniz : ");
            Console.Write("Kişinin sirasini Giriniz");
            int kisiSirasi = int. Parse(Console.ReadLine());
            
            Console.Write("isim :");
            string ad = Console.ReadLine();

            Console.Write("Soyad :");
            string soyad = Console.ReadLine();

            Console.Write("Doğum Yeri : ");
            string dogumYeri = Console.ReadLine();

            Console.Write("Telefon : ");
            string telefon = Console.ReadLine();

        }


        static void KisiBilgileriniYazdir(string isim, string soyisim, string dogumYeri, string telefon)
        {
            Console.WriteLine("Yazdırmak istediğiniz sayinin sırasını giriniz: ");
            Console.ReadLine();
            
            Console.WriteLine("Ad : {0}",isim);
            Console.WriteLine("Soyad : {0}", soyisim);
            Console.WriteLine("Doğum Yeri : {0}", dogumYeri);
            Console.WriteLine("Telefon : {0}", telefon);

        }
    }
}
