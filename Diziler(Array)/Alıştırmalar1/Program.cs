using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alıştırmalar1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //  Array.Copy = Kaynak dizinin adı,kaynağın başlangıç indisi, hedef dizinin adı, hedefin başlangıç indisi,kaç tane kopyalasın  
            int[] dizi1 = { 1, 2, 3, 4 };
            int[] dizi2 = new int[3];


            Array.Copy(dizi1, 1, dizi2, 0, 2);

    
            Console.WriteLine(dizi2[0]);
            Console.WriteLine(dizi2[1]);
            Console.WriteLine(dizi2[2]);
            */

            /*
            // Array.Reverse = Dizinin elemanları sondan başa doğru yazdırır da diyebiliriz.
            string[] dizi = new string[3];
            dizi[0] = "Ali";
            dizi[1] = "Veli";
            dizi[2] = "Ayşe";
            Array.Reverse(dizi);  
            Console.WriteLine(dizi[0]);
            Console.WriteLine(dizi[1]);
            Console.WriteLine(dizi[2]);             // Ayşe Veli  Ali,
            */
            /*
            // Array.Clear = Dizinin kaçıncı indisinden başlayıp kaç tane sileceğimizi belirliyoruz.
            string[] iller = { "Bursa", "Kayseri", "İzmir", "Ankara" };
            Array.Clear(iller, 1, 1);
            Console.WriteLine(iller[0]);
            Console.WriteLine(iller[1]);
            Console.WriteLine(iller[2]);
            Console.WriteLine(iller[3]);


            int[] sayilar = new int[3];
            sayilar[0] = 100;
            sayilar[1] = 1000;
            sayilar[2] = 10000;
            Array.Clear(sayilar, 0, 2);
            Console.WriteLine(sayilar[0]);
            Console.WriteLine(sayilar[1]);
            Console.WriteLine(sayilar[2]);
            */
            /*
            // Array.CopyTo = Hedef dizimiz ve kaçıncı sıradan itibaren kopyalamamız gerektiğini belirtiriz.
            string[] iller = { "Bursa", "Kayseri", "İzmir", "Ankara" };
            string[] dizi = new string[iller.Length];
           iller.CopyTo = (dizi,0);

            */

            // IndexOf = Aranan kelimeyi, harfi, sayıyı kontrol ediyor.
            /*
            string[] dizi = new string[3];
            dizi[0] = "Ali";
            dizi[1] = "Veli";
            dizi[2] = "Ayşe";
            string aranan_deger = "Ayşe";
            int sirasi = Array.IndexOf(dizi, aranan_deger);
            if (sirasi > 0)
                Console.WriteLine("Aranan eleman var.");
            else
                Console.WriteLine( "Aranan eleman yok.");

            string kelime = "Ayça.Calayır";
            Console.WriteLine(kelime.IndexOf('.')); //4.indisteki .   Tek tırnak harf, Çift tırnak kelimeyi getiriyor.
            */
            /*
            // LastIndexOf = Aynı harf ya da kelime varsa en sonuncusunu getiriyor. 

            string kelime = "Ayça.Calayır.";
            Console.WriteLine (kelime.LastIndexOf('.')) // 12

                */
            /*
        // Array.Resize = Dizi artırma ya da azaltma için kullanılır.  (Dizimiz 3 elemanlıydı biz 6 elaman yapmak istedik ve ekledik.)

        string[] dizi = { "kartal", "kanarya", "serçe" };
        Array.Resize(ref dizi, 6);
        dizi[3] = "doğan";
        dizi[4] = "şahin";
        dizi[5] = "baykuş";

        int i = 0;
        while (i < 6)
        {
            Console.WriteLine(dizi[i]);
            i++;
        }
              */

            /*
             // ToString = Girilen sayıyı string türünden algılatıyor.
            
            Object obj = 13;
            Console.WriteLine(obj.ToString());

            */
        }
}

}
