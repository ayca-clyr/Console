using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayı giriniz :");
            string input = Console.ReadLine();

            // Stringden nümerik tipiğe dönüştürür.
            Int16 shortNumber = short.Parse(input);
            int intNumber = Int32.Parse(input);  
            double doubleNumber = Double.Parse(input);
            DateTime dateValue = DateTime.Parse(input);

            string numberAsString = intNumber.ToString(); // "35" İçinde olan değer neyse..
            string boolAsString = true.ToString();  // "True" yazacak.
            string intAsString = 100.ToString();   // "100"
         // string typeAsString = byte.ToString(); // Tanımın yanına ToString yazamayız. Değerin yanına (alacağı değerler) yazabiliriz.
            string dateAsString = DateTime.Today.ToString("dd/MM/YY"); // "01.01.1980"   MM/YY  MM/YYYY
            object anyThing = 2342343; 
            object anything2 = "Tsubasa Ozora";      
            string objectAsString = anyThing.ToString();
            string objectAsString2 = anything2.ToString();

            // CAST etme işlemi
            // Nümerik tipleri birbirine CAST ederek dönüştürebilirim
            // (TYPE) ifadesi ile dönüşüme EXPLICIT CAST (Açık Dönüşüm)            
            int integer32Number = 100000;
            short integer16Number =(short)integer32Number;
            
            decimal decimalNumber = 54585212164512;
            integer32Number =(int)decimalNumber;

            // IMPICIT CAST (Kapalı Dönüşüm)
            decimalNumber = integer32Number;        // decimalNumber =(decimal)integer32Number;  Yazsanda olur yazmasanda olur.

            // char tipini doğrudan short veya int gibi nümerik tipe KAPALI şekilde CAST edebiliriz.
            char aLetter = 'A';
            int aLetterCode = (int)aLetter;

            //Nümerik tipi char tipine AÇIK şekilde CAST edebiliyoruz
            aLetter = (char)aLetterCode;

            string name = "Muhittin";
            int nameAsInteger = int.Parse(name);   // int nameAsInteger =(int)name;   Bu olmaz!!!!

            // ConvertTo() : Tüm hepsini bir araya getiren bir sınıf.
            int integerNumber = 1000000;
            byte byteNumber = Convert.ToByte(integerNumber);

        }
    }
}
