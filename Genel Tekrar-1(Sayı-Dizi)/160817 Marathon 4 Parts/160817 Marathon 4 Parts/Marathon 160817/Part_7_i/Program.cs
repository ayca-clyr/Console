using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_7_i
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kullanıcının belirlediği kapasitede yeni bir string dizisi oluşturma");
            Console.WriteLine();
            int diziBoyut;
            Console.Write("Oluşturmak istediğiniz dizinin boyutunu giriniz:");
            string deger2 = (Console.ReadLine());
            bool deger = int.TryParse(deger2, out diziBoyut);
            while (!deger || diziBoyut == 0)
            {
                Console.Write("Yanlış değer girdiniz, lütfen dizi boyutunu metinsel bir ifadeden ve 0 sayısından farklı olarak sayısal bir değer girin:");
                deger2 = (Console.ReadLine());
                deger = int.TryParse(deger2, out diziBoyut);
            }
            string[] dizi = new string[diziBoyut];
            int index = 0;
            while (index<dizi.Length)
            {
                Console.Write("Dizinin "+(index+1)+".değerini giriniz:");
                dizi[index] = Console.ReadLine();
                index++;
            }
            Console.Read();
        }
    }
}
