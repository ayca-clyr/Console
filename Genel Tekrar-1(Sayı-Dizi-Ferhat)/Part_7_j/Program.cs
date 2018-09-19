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
            bool deger = true;
            string kova = "";

            while (deger)
            {
                int i;
                Console.WriteLine("Lütfen Dizi Boyutu Giriniz :");
                string diziBoyutu = Console.ReadLine();
                bool durum = int.TryParse(diziBoyutu, out i);

                int[] dizi = new int[i];
                int sayac = 0;

                if (i != 0 && durum)
                {

                    while (sayac < dizi.Length)
                    {
                        Console.WriteLine("Dizi Elemanlarını Giriniz : ");
                        string elemanlar =Console.ReadLine();

                        kova = kova + " ,"+ elemanlar;

                        sayac++;

                    }



                }
                else
                {
                    Console.WriteLine("Yanlış Değer Girdiniz!");

                }

                deger = false;

            }

            Console.WriteLine(kova);
        }
    }
}
