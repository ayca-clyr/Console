using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Değişken :
             * Bilgisayarın RAM'ınde tutulan, içerisinde nümerik veya metinsel değerleri alabilen, programlamanın en temel yapı taşıdır.
             * Adı üzerinde, değişkenin değeri sonradan değiştirilebilir
             * ANCAK
             * Değişkenin tipi sonradan değiştirelemez
             * ÇÜNKÜ
             * C# programlama dili STRONGLY TYPED (kesin tipli,tip güvenli) bir programlama dilidir.
             */
            // 1. NÜMERİK TİPLER
            
            // 1.0 Bit Tipi
            
            //SQL'deki adı => bit
            // 0 / 1
            // 1 bitlik değer
            bool boolValue = false;
            Boolean boolValuesDotNet = true;
            
            // 1.1 Tamsayı Tipler

            // 0-255
            // 8 Bitlik tam sayı
            // SQL'deki adı => tinyint
            byte byteNumber = 10;
            Byte byteNumberDotNet = 10;

            // Eksi 30bin küsür - Artı 30bin küsür
            // 16 bitlik tam sayı
            // SQL'daki adı => smallint
            short shortNumber = 100;
            Int16 shortNumberDotNet = 100;

            // Eksi 2milyar küsür - Artı 2milyar küsür
            // 32 bitlik tam sayı
            //SQL'deki adı => int
            int intNumber = 10000;
            Int32 intNumberDotNet = 10000;

            //Eksi çoktan - Artı çoka kadar
            // 64 bitlik tam sayı
            // SQL'deki adı => bigint
            long longNumber = 1000000;
           Int64 longNumberDotNet = 1000000;

           char letter = 'A';
           Char letterDotNet = 'A';

           int letterCode = (int)letter;
 
            // 1.2 Ondalıklı sayılar

            // 32 bitlik ondalıklı sayı
            // SQL'deki adı float
            float floatNumber = 1.34893f;
            Single floatNumberDonNet = 1.24334f;

            // 64 bitlik ondalıklı sayı
            // SQL'deki adı float
            double doubleNumber = 1.234234d;
            Double doubleNumberDotNet = 1.34523;

            // SQL'deki adı decimal, money,smallmoney
            // 128 bitlik ondalıklı sayı
            decimal decimalNumber = 1.2342345m;
            Decimal decimalNumberDotNet = 12342424326.23234234m;

            // 1.3 Metin Veri Tİpler

            // string dediğimiz tip özünde char[] dizisidir.
            string name = "Tsubasa";
         
            // 1.4 Tarih Veri Tipi

            // SQL'deki adı datetime, datetime2, smalldatetime
            DateTime dateTimeValue = DateTime.Parse("01.09.1984");
            DateTime today = DateTime.Today;
            DateTime now = DateTime.Now; // Saat + saniyede vardır.

            // 1.5 Object

            object object1 = 234234;
            object object2 = "Tsubasa Ozara";
            object object3 = DateTime.Today;

            int total = 5 *(int)object1;

            var number1 = 10000;
            var name1 = "Tsubasa";

        }
    }
}
