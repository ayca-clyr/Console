using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_7_j
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
                Console.Write("Yanlış değer girdiniz");
                deger2 = (Console.ReadLine());
                deger = int.TryParse(deger2, out diziBoyut);
            }
            int[] dizi = new int[diziBoyut];
            int index = 1;
            bool durum = true;
            while (durum)
            {
                Console.Write(index + ".Sayıyı girin:");
                string giris = Console.ReadLine();
                int sayi;
                bool basarılı = int.TryParse(giris, out sayi);
                if (basarılı)
                {
                    if (index < dizi.Length)
                    {
                        index++;
                    }
                    else
                    {
                        durum = false;
                    }
                }
                else
                {
                    Console.WriteLine("Yanlış giriş yaptınız.");
                }
            }
            Console.Write("Programı sonlandırmak için lütfen bir tuşa basınız!");
            Console.Read();
        }
    }
}