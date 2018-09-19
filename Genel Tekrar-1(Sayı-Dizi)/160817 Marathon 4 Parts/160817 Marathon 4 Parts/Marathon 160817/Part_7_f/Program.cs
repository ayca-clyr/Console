using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_7_f
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Dizi elemanlarını üç kolonda ters sırada yazdırma");
            Console.WriteLine();
            int[] dizi = { 17, 30, 15, 85, 93, 18, 69, 6815,10 };
            int index = 0;
            while (index < dizi.Length)
            {
                Console.Write("{0}\t {1}\t {2}",dizi[index+2],dizi[index+1] , dizi[index]);
                
                index++;
            }
            Console.ReadLine();
        }
    }
}
