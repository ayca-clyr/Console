using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworkk
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            string takım1, takım2, takım3, takım4;
            int s1 = 0;
            int s2 = 0;
            string tarih1 = DateTime.Now.Date.ToShortDateString();
            string tarih2 = DateTime.Now.Date.ToShortDateString();
            string f1 = "";
            string f2 = "";
            string yf1 = "";
            string yf2 = "";
            Console.WriteLine("1. takımın adını girin..");
            takım1 = Console.ReadLine();
            Console.WriteLine("Takım1 = " + " " + takım1);
            //--------------------------------------------------------------
            Console.WriteLine("2. takımın adını girin..");
            takım2 = Console.ReadLine();
            Console.WriteLine("Takım2 = " + " " + takım2);
            //--------------------------------------------------------------
            Console.WriteLine("3. takımın adını girin..");
            takım3 = Console.ReadLine();
            Console.WriteLine("Takım3 = " + " " + takım3);
            //--------------------------------------------------------------
            Console.WriteLine("4. takımın adını girin..");
            takım4 = Console.ReadLine();
            Console.WriteLine("Takım4 = " + " " + takım4);
            while (s1 == s2)
            {
                s1 = r.Next(0, 5);
                s2 = r.Next(0, 5);
                if (s1 != s2)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("İlk Maç : " + " " + takım1 + " vs " + takım2);
                    Console.WriteLine("Maçı başlatmak için bir tuşa basınız..");
                    Console.ReadKey();
                    Console.WriteLine("\n");
                    Console.WriteLine(takım1 + " " + s1 + " - " + s2 + " " + takım2);
                    if (s1 > s2)
                    {
                        Console.WriteLine(tarih1 + " tarihli maçı " + takım1 + " Kazandı");
                        f1 = takım1;
                    }
                    else if (s1 < s2)
                    {
                        Console.WriteLine(tarih1 + " tarihli maçı " + takım2 + " Kazandı");
                        f1 = takım2;
                    }
                }
                f1 = (s1 > s2) ? takım1 : takım2;
                yf1 = (s1 > s2) ? takım2 : takım1;
            }
            s1 = 0;
            s2 = 0;
            Console.Write("\n");

            while (s1 == s2)
            {
                s1 = r.Next(0, 5);
                s2 = r.Next(0, 5);
                if (s1 != s2)
                {
                    Console.WriteLine("ikinci Maç : " + " " + takım3 + " vs " + takım4);
                    Console.WriteLine("Maçı başlatmak için bir tuşa basınız..");
                    Console.ReadKey();
                    Console.WriteLine();
                    Console.WriteLine(takım3 + " " + s1 + " - " + s2 + " " + takım4);
                    if (s1 > s2)
                    {
                        Console.WriteLine(tarih2 + " tarihli maçı " + takım3 + " Kazandı");
                    }
                    else if (s1 < s2)
                    {
                        Console.WriteLine(tarih2 + " tarihli maçı " + takım4 + " Kazandı");
                    }
                }
                f2 = (s1 > s2) ? takım3 : takım4;
                yf2 = (s1 > s2) ? takım4 : takım3;
            }
            Console.WriteLine("\n\n");
            //3.LUK MACI
            s1 = 0;
            s2 = 0;
            while (s1 == s2)
            {
                s1 = r.Next(0, 5);
                s2 = r.Next(0, 5);
                if (s1 != s2)
                {
                    Console.WriteLine("3.LUK MACI ==> " + yf1 + " - " + yf2);
                    Console.WriteLine("Maçı başlatmak için bir tuşa basınız..");
                    Console.ReadKey();
                    Console.WriteLine();
                    Console.WriteLine(yf1 + " " + s1 + " - " + s2 + " " + yf2);
                    if (s1 > s2)
                    {
                        Console.WriteLine(yf1.ToUpper() + " 3.Oldu..\n-------------------------------");
                    }
                    else if (s1 < s2)
                    {
                        Console.WriteLine(yf2.ToUpper() + " 3.Oldu..\n-------------------------------");
                    }
                }
            }
            //FINAL
            s1 = 0;
            s2 = 0;
            while (s1 == s2)
            {
                s1 = r.Next(0, 5);
                s2 = r.Next(0, 5);

                if (s1 != s2)
                {
                    Console.WriteLine("BUYUK FINAL !!! " + f1 + " - " + f2);
                    Console.WriteLine("Maçı başlatmak için bir tuşa basınız..");
                    Console.ReadKey();
                    Console.WriteLine();
                    Console.WriteLine(f1 + " " + s1 + " - " + s2 + " " + f2);
                    if (s1 > s2)
                    {
                        Console.WriteLine(f1.ToUpper() + " ŞAMPIYON !!!");
                    }
                    else if (s1 < s2)
                    {
                        Console.WriteLine(f2.ToUpper() + " ŞAMPIYON !!!");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
