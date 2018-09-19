using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_DataTypes{
    class Program{
        static void Main(string[] args){
            //Yorum Satırı        CTRL + K + D = HİZALAMA
            /* 
                Çoklu
                Yorum
                Satırı
           */

            //Değişken Tanımlama
            //[Veri_Tipi] (Değişken Adı)

            int sayi;
            int sayi1 = 5;
            int sayi2 = 4, sayi3 = 13, sayi4= 123123;

            var x = 4;
            var y = "Ahmet";
            var z = 'C';

            ///////////////////
            //----- Değişken isimlendirme kuralları
            // Sayı ve Özel karakterlerle başlayamaz. ('_' ve '@' hariç)
            // Değişkne isimleri '!', '?', '(', ')', '{', '}', '[', ']' içeremez.
            // Değişken isimleri büyük/küçük harfe duyarlıdır.
            // Birden fazla kelimeli değişkenler için araya boşluk konulamaz. '_' ile ayrılabilir.
            // Genel kabul görmüş bazı değişken isimlendirme standartları vardır.
                // Camel Case  : dogumTarihi,adSoyad,degiskeninIlkDegeri
                // Pascal Case : DogumTarihi,AdSoyad,DegiskeninIlkDegeri
            // Değişken isimleri anlamlı ve tuttuğu değeri tarif eder.
            
            // Reserved Keywords : C# için anlamlı olan kelimelerdir.Değişken isimlendirmelerinde reserved keyword'ler kullanılmaz.(var,int..)
            // NOT : İlle de kullanmak istiyorsanız reserved keywordler başına '_' ve '@' ekleyebilirsiniz.

            /* 
             * int      : Tam sayı değer. Sınır 2 milyar, -2 milyar 
             * string   : Metinsel ifade tutar. En fazla kaç karakter? (boyutsuz)
             * bool     : TRUE ve FALSE değerlerini alırlar. (1 Bit (0-1))
             * char     : Tek bir karakter tutar. (1 Byte = 8 Bit)
             * byte     : Tam sayı değeri tutar. (0 - 255 (1 Byte))
             * double, float, decimal : Ondalıklı sayı tutar.
             * long     : Tamsayı tutar. (2 üzeri 64)
             * object   : Her türden veri tutabilir.
             * short(2 üzeri 16), uint(2 üzeri 32), ulong(2 üzeri 32) , sbyte(-128, 127) ... 
              */

            int deger = 540;
            string metin = "Serkan Soydam";
            char harf = 'A';
            bool durum = true;
            double ondalıklı = 5.01;
            byte kucukSayı = 125;
            decimal ondalıklı2 = 0.16M;
            float ondalıklı3 = 3.14F;
            long cokBuyukSayi = 1234089230;

            object herHangiBirSey = "Test";
            object baskaBirSey = 324;
            object digerBirSey = true;
            object farklıBirSey = 'x';
            object birsey = 5.19;          // bisey = "Ayça"  Sonradan değiştirebiliyoruz. Kapalı kutu. İçinde ne olduğunu göremeyiz.
            object a;
     
            var x1 = 4;                    //x1 = "Mehmet"   Değer atadıktan sonra o veritipine dönüşüyor.Sonradan da değişmez.
            var y1 = "Ahmet";
            var z1 = 'c';
            var t1 = 0.34M;
            // var z1; diye tanımlama yapamıyoruz. İçine değer ataması yapman gerekiyor. 

            //cw tab      Console.WriteLine();    Otomatik olarak geliyor.

            int boyut = sizeof(int);
            Console.WriteLine("Int veri tipinin boyutu : " + boyut + " Byte " );

            Console.WriteLine("Int veri tipinin Max Değeri : " + int.MaxValue);
            Console.WriteLine("Int veri tipinin Min Değeri : " + int.MinValue);

            Console.WriteLine("Size of long : "+ sizeof(long) + "byte yer kaplar. Max : "+ long.MaxValue + " Min : "+ long.MinValue);

            Console.WriteLine("Size of long : " + sizeof(short) + "byte yer kaplar. Max : " + short.MaxValue + " Min : " + short.MinValue);

            Console.WriteLine("Size of long : " + sizeof(uint) + "byte yer kaplar. Max : " + uint.MaxValue + " Min : " + uint.MinValue);

            Console.Beep(660, 125);    // frekans, süresi(milisaniye)

        }
    }
}
