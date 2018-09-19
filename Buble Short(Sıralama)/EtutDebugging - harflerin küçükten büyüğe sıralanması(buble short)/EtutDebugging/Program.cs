using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtutDebugging
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Bir Kelime Giriniz = ");

            string isim = Console.ReadLine();

            int uzunluk = isim.Length;

            char[] dizi = new char[uzunluk];
            
            int k=0;
            while (k < uzunluk)
            {
                dizi[k] = isim[k];
                k++;
            }

            string sirali = "Alfebetik Sıra İle Dizilişi = ";

            //Array.Sort(dizi); 

            int sayac = 0;
            int sayac2 = 0;
            char tutucu;
            
                while (sayac < dizi.Length)
                {
                    sayac2 = 0;
                    while (sayac2 < dizi.Length-1)
                    {
                        if (dizi[sayac2] > dizi[sayac2 + 1])
                        {
                            tutucu = dizi[sayac2];
                            dizi[sayac2] = dizi[sayac2 + 1];
                            dizi[sayac2 + 1] = tutucu;

                        }
                        sayac2++;
                    }
                    sayac++;
                }

                int m = 0;
                while (m < uzunluk)
                {
                    sirali += dizi[m];
                    m++;
                }
            Console.WriteLine(sirali);
            Console.ReadLine();
        }
    }
}

