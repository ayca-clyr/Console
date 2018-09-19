using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Console_Operators{
    class Program{
        static void Main(string[] args)
        {
            #region Region ismi
             //sdflk
             //    sdlşfkseğ
            //    sekfseğ
            #endregion
#region Aritmetik İşlemler
            /*
            // Aritmetiksel Operatörler
            // +, -, *, /, %

            //int a = 8;
            //int b = 20;
            //double c;

            //Console.WriteLine("a = " + a + "; b =" + b);

            //c = a + b;   // Sağda işlem yapılır. Sol tarafa atılır.
            //Console.WriteLine("a + b = "+c);

            //c = a - b;
            //Console.WriteLine("a - b ="+c);

            //c = a * b;
            //Console.WriteLine("a * b ="+c);

            //c = a / b;
            //Console.WriteLine("a / b = "+c);
            //Console.WriteLine("a / b = " +(a/b));

            //a = a + 1;
            //a++;
            //Console.WriteLine("a = "+a);

            //c = a++ + b;                                //Önce işlemi yap sonra artır.
            //Console.WriteLine("a++ + b ="+c);
            
            //c = ++a + b;                                //Önce artırt sonra işleme sok.
            //Console.WriteLine("++a + b = "+c);

            //a = 10, b = 20
            //c = --a + b++;   // a = 9, b = 21
            //Console.WriteLine("--a + b++ ="+c);

           // c = a++ + b;
                // a = a + 1;
                // c = a + b;
          //...........

          // c = ++a + b;
                // a = a + 1;
                // c = a + b;

            
             Aklından 1 ile 100 arasında bir sayı tut
             2 ile çarp
             8 ekle
             yarısını bul
             aklınızdan tuttuğunuz sayıyı bu sayıdan çıkartın
             sonuç ?
             4 çıktı, tebrikler
             

            Console.WriteLine("Aklından 1 ile 100 arasında bir sayı tut");
            
            Console.WriteLine("Tuttuğunuz sayıyı giriniz :");

            string input =  Console.ReadLine();  // Klavyeden girdiklerimi okur. Enter basana kadar bu metodun çıktısı inputa aktarılır.

            int sayı = int.Parse(input);        // Yukarde string metinsel ifadeydi bizim istediğimiz int olduğu için çevirme işlemi yaptık.

            Console.WriteLine("Şimdi sayıyı 2 ile çarp (devam etmek için ENTER'a basın)");

            //Ekrandan bir satır okumak için kullanmıyoruz.
            //Enter tuşunu algılamak için kullanıyoruz.
            Console.ReadLine();

            int sonuc = sayı * 2;

            Console.WriteLine(sayı+" x 2 = "+sonuc);

            Console.WriteLine("Şimdi sonuca 8 ekle (devam etmek için ENTER'a basın.)");

            //Ekrandan bir satır okumak için kullanmıyoruz.
            //Enter tuşunu algılamak için kullanıyoruz.
            Console.ReadLine();

            int sonuc2 = sonuc + 8;

            Console.WriteLine(sonuc+" + 8 ="+ sonuc2);

            Console.WriteLine("Çıkan sonucun yarısını bul ( Devam etmek için ENTER'a basınız.");

            //Ekrandan bir satır okumak için kullanmıyoruz.
            //Enter tuşunu algılamak için kullanıyoruz.
            Console.ReadLine();

            int sonuc3 = sonuc2 / 2;

            Console.WriteLine(sonuc2+ " / 2 "+ sonuc3);

            Console.WriteLine("Son çıkan sayıdan tuttuğunuz sayıyı çıkartın ( Devam etmek için ENTER'a basınız.)");

            //Ekrandan bir satır okumak için kullanmıyoruz.
            //Enter tuşunu algılamak için kullanıyoruz.
            Console.ReadLine();

            int sonuc4 = sonuc3 - sayı;

            Console.WriteLine("Sonuc 4 mü çıktı ? Şaşılacak hadise!! ");

            Console.WriteLine(sonuc3 + " - "+sayı+ " = "+sonuc4);

            

            */
#endregion
            #region Mantıksal İşlemler
/*
            // Mantıksal Operatörler
            // ==, !=, >, <, >=, <=

            int a = 21;
            int b = 10;
            bool c;

            Console.WriteLine("a = {0}, b = {1}",a,b);

            Console.WriteLine(" a ve b eşit midir?");
            Console.WriteLine(a == b);

            Console.WriteLine(" a ve b eşit değil midir?");
            Console.WriteLine(a != b);

            Console.WriteLine("a, b'den küçük müdür?");
            c = a < b;
            Console.WriteLine(c);

            Console.Write("a, b'den büyük müdür? \n");
            c = a > b;
            Console.Write(c+ "\n");

            Console.WriteLine("a, b'den küçük eşit midir?");
            Console.WriteLine(a <= b);

            Console.WriteLine("a, b'den büyük eşit midir?");
            Console.WriteLine(a >= b);

            bool sonuc;
            // Veya (OR) Operatörü
            sonuc = false || false;   // sonuc : false
            sonuc = false || true;    // sonuc : true
            sonuc = true || false;    // sonuc : true
            sonuc = true || true;     // sonuc : true

            // Ve (AND) Operatörü
            sonuc = false && false;   // sonuc : false
            sonuc = false && true;    // sonuc : false
            sonuc = true && false;    // sonuc : false
            sonuc = true && true;     // sonuc : true

            sonuc = 5 > 4 && 3 > 4 || true && 6 < 2;    // sonuc : false

            sonuc = (6 > 2 || 5 > 9) && 5 == 5;         // sonuc : true

            sonuc = 3 < 5 || 4 != 4 && (2 >= 2 || 3 < 3) || false;  // sonuc : true

            sonuc = 3 < 5 || 4 != 4 && 2 >= 2 || (3 < 3 || false);  // sonuc : true

  */
            #endregion
            #region Atama İşlemleri (Operatörleri)
            // Atama işlemleri (Operatörleri)
            // =, +=, -=, *=, /=, %=
/*
            int a = 7;
            int c;

            Console.WriteLine("a = {0}",a);

            c = a;
            Console.WriteLine("c = a 'nın sonucunda c : {0}",c);   // 0, 1 ler adedi ifade eder ona göre virgülle ayırırız. Eğer + dersek birleştirmiş oluruz. 0 yerine 2 desek 2 tane değer girmemiz gerekirdi.
            //Console.WriteLine("c = a 'nın sonucunda c : "+ c);

            c += a; // c = c + a
            Console.WriteLine("c += a nın sonucunda c : {0}",c);

            c -= a; // c = c - a
            Console.WriteLine("c -= nin sonucunda c : {0}",c);

            c *= a; // c = c * a
            Console.WriteLine("c *= a nın sonucunda c : {0}",c);

            c /= a; // c = c / a
            Console.WriteLine("c /= a nın sonucunda c : {0}",c);

            c %= a;
            Console.WriteLine("c %a 'nın sonucunda c : {0}",c);




*/

            #endregion

            Console.ReadKey();                   // Klavyeden yazdığın 1 değeri okur. 1 Tuş. 

        }
    }
}


