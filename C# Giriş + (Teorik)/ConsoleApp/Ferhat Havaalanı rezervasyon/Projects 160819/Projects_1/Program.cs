using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Projects_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0, prediction = 0, rndNumber = 0;
            bool success = true;
            Console.WriteLine("************** SAYI TAHMİN OYUNU ****************\n");
            Console.WriteLine("*************************************************");
            while (success)
            {
                Console.WriteLine("Lütfen aşağıdaki zorluk seviyelerinden birisini seçiniz: \n1. Kolay seviye için 1'i tuşlayın\n2. Orta seviye için 2'i tuşlayın\n3. Zor seviye için 3'i tuşlayın");
                char level = char.Parse(Console.ReadLine());
                Random rnd = new Random();
                switch (level)
                {
                    case '1':
                        rndNumber = rnd.Next(1, 10);
                        max = 10;
                        prediction = Game(rndNumber, max);
                        break;
                    case '2':
                        rndNumber = rnd.Next(1, 100);
                        max = 100;
                        prediction = Game(rndNumber, max);
                        break;
                    case '3':
                        rndNumber = rnd.Next(1, 1000);
                        max = 1000;
                        prediction = Game(rndNumber, max);
                        break;
                    default:
                        Console.WriteLine("Yanlış bir giriş yaptınız!\n");
                        break;
                }
                Console.WriteLine("Tebrikler {0} doğru tahmin ", rndNumber);
                Console.WriteLine("Oyunu {0} tahminde bitirdiniz ", prediction);
                if (max == 1000)
                    Console.WriteLine("PUANINIZ : {0}", 1000 - (prediction - 1));
                else if (max == 100)
                    Console.WriteLine("PUANINIZ : {0}", 1000 - ((prediction - 1) * 10));
                else
                    Console.WriteLine("PUANINIZ : {0}", 1000 - ((prediction - 1) * 100));
                do
                {
                    Console.Write("TEKRAR OYNAMAK İSTERMİSİNİZ (E/H) : ");
                    char key =char.Parse(Console.ReadLine());
                    if (key == 'E' || key == 'e')
                        break;
                    else if (key == 'H' || key == 'h')
                    { success = false; break; }
                } while (true);
            }
        }
        static int Game(int rndNumber, int max)
        {
            int prediction = 0;
            while (true)
            {
                Console.Write("Tahmininizi yazınız : ");
                int inputNumber;
                bool success = true;
                do
                {
                    if (!success)
                        Console.Write("Yanlış giriş lütfen sadece rakam girişi yapınız : ");
                    success = int.TryParse(Console.ReadLine(), out inputNumber);
                } while (!success);
                prediction++;
                if (rndNumber != inputNumber)
                {
                    int interval;
                    if (inputNumber > rndNumber)
                    {
                        interval = (max - rndNumber) / 3;
                        if (max > inputNumber && inputNumber >= rndNumber + interval * 2)
                            Console.WriteLine("*** SOĞUK ***");
                        else if (rndNumber + interval*2 > inputNumber && inputNumber >= rndNumber + interval)
                            Console.WriteLine("*** ILIK ***");
                        else if (rndNumber  < inputNumber && inputNumber <= rndNumber+interval)
                            Console.WriteLine("*** SICAK ***");
                    }
                    else
                    {
                        interval = rndNumber / 3;
                        if (rndNumber > inputNumber && inputNumber > interval * 2)
                            Console.WriteLine("*** SICAK ***");
                        else if (interval * 2 >= inputNumber && inputNumber > interval)
                            Console.WriteLine("*** ILIK ***");
                        else if (interval >= inputNumber && inputNumber > 0)
                            Console.WriteLine("*** SOĞUK ***");
                    }
                }
                else
                    break;
            }
            return prediction;
        }
    }
}