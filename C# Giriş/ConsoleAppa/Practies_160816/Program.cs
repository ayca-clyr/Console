using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practies_160816
{
    class Program
    {
        static void Main(string[] args)
        {

            // char[] dizi1 = {'A','y','ç','a'};
           

            // 1) Bir dizide istenen elemanın index değerini döndüren metodu yazın. IndexOf(array,item)
            // 2) Bir string içerisinde istenen karakterin index değerini döndüren metodu yazın.IndexOf()
            // 3) Bir string içerisinde karakterin son kez geçtiği yerin index değerini döndüren metodu yazın. LastIndexOf()

            string[] dizi = { "Ayça", "Calayır" };
            string kelime = "Ayça";
            int sonuc = IndexOf(dizi,kelime );
            Console.WriteLine(sonuc);

        
        }
        static int IndexOf(string[] dizi, string eleman)
        {
           int index = 0;
           while (index < dizi.Length)
            {
                if (dizi[index] == eleman)
                {
                   return index;
                }
                index++;
            }
           return -1;           
        }

        static int IndexOf(string kelime, char eleman)
        {
            int index = 0;
            while (index < kelime.Length)
            {
                if (kelime[index] == eleman)
                {
                    return index;
                }
                index++;
            }
            return -1;
        }

        static int LastIndexOf(string kelime, char eleman)
        {
            int index = kelime.Length - 1;
            while (index > 0)
            {
                if (kelime[index] == eleman)
                {
                    return index;
                }
                index--;
            }
            return -1;
        }


    }
}
