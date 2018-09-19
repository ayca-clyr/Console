using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork__Bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "   tsubasa   ozora   ";
            //string trimmedValue = Trim(name);
            //Console.WriteLine(trimmedValue);
            //Console.ReadLine();
            string name = "   tsubasa   ozora   golcudür";
            string trimmedValue = FullTrim(name);
            Console.WriteLine(trimmedValue);
            Console.ReadLine();
        }

      
        static string Trim(string value)
        {   
            // SOL'daki boşlukları goz ardı etmek
            //1. AŞAMA    
            // Sol taraftaki boşluklardan sonra ilk normal(boşluktan farklı) karakterin
            // indexini buluyoruz
            // boşluk silmek diye birşey yok göz ardı edilebilir.
            int index = 0;

            while (index < value.Length)
            {
                char letter = value[index];

                if (letter != ' ') //string bir değer döndürseydi ("") olurdu.
                                   //tek tırnak(' ') cünkü char donduruyor.Bir karakter olduğu için Char.
                    break;             

                index++;
            }
           //Bu aşamada index değerini bulduk.

            //2. AŞAMA
            //İlk karakterden itibaren geriye kalan tüm karakterleri
            //yeni string değişkende (leftTrimmed) topladık.
            string leftTrimmed = string.Empty;

            int counter = index;

            while (counter < value.Length)
            {
                leftTrimmed += value[counter];  //leftTrimmed = leftTrimmed + value[counter]; 

                counter++; //counter += 1; yada counter = conuter + 1;
            }


            //3. AŞAMA
            //Sondan itibaren boşluk karakterini atladık,ilk normal (boşluktan farklı)
            //karakteri bulduğumuzda döngüyü sonlandırdık.index değeri o harfin kaçıncı indexte olduğunu söyler.

            index = leftTrimmed.Length - 1;

            while (index >= 0)
            {
                if (leftTrimmed[index] != ' ')
                    break;

                index--;
            }

            //4. AŞAMA
            // Baştan başalayarak sağ taraftaki boşluklara kadar olan kısmı 
            //yeni bir string değişkende(trimmed) topladık.

            string trimmed = string.Empty;
                counter = 0;

                while (counter <= index)
	{
        trimmed += leftTrimmed[counter];
                   counter ++;
	}
            // trimmed değişkeni,elde etmek istediğimiz değerdir.
                return trimmed;

        }

        static string FullTrim(string value)
        {
            int index = 0;
            string fullTrimmed = string.Empty;
            int spaceCounter = 0;
            while (index < value.Length)
            {
                if (value[index] != ' ')
                {
                    if (spaceCounter > 0 )
                    {
                        spaceCounter = 0;
                        if (fullTrimmed.Length > 0)
                        {
                            fullTrimmed = fullTrimmed + ' ';
                        }
                        
                    }
                    fullTrimmed = fullTrimmed + value[index];
                }
                else
                {
                    spaceCounter++;
                }
                    
                index++;
               
            }
            return fullTrimmed;
        }
    }

}

