using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            //namespace >>>class>>>method

            Kisi kisi1 = new Kisi();
            kisi1.ad = "Ali Ozan";
            kisi1.soyad = "Pişkin";
            kisi1.dogumYeri = "Istanbul";


            Kisi kisi2 = new Kisi();
            kisi2.ad = "Serkan";
            kisi2.soyad = "Soydam";
            kisi2.dogumYeri = "Istanbul";

            Kisi kisi3 = new Kisi();
            kisi3.ad = "Toni";
            kisi3.soyad = "Demirci";
            kisi3.dogumYeri = "Istanbul";

            Kisi kisi4 = new Kisi();
            kisi4.ad = "Doğan";
            kisi4.soyad = "Kahveci";
            kisi4.dogumYeri = "Trabzon";

            Kisi[] KisilerDizisi = new Kisi[4];

            KisilerDizisi[0] = kisi1;
            KisilerDizisi[1] = kisi2;
            KisilerDizisi[2] = kisi3;
            KisilerDizisi[3] = kisi4;

            //KisiBilgileriniYazdir(kisi1);
            //KisiBilgileriniYazdir(kisi2);

            TumKisileriYazdir(KisilerDizisi);


            // Console.WriteLine(kisi1.ad + " " + kisi1.soyad);   // -->  Console.WriteLine(kisi1.ToString()); 


        }

        private static void KisiBilgileriniYazdir(Kisi yeniKisi)
        {
            Console.WriteLine("Kisinin Adı : {0} ",yeniKisi.ad);
            Console.WriteLine("Kisinin Soyadı : {0} ",yeniKisi.soyad);
            Console.WriteLine("Kisinin Doğum Yeri : {0} ", yeniKisi.dogumYeri);
        }

        static void TumKisileriYazdir(Kisi [] tumKisiler)
        {
            int i = 0;
            while(i < tumKisiler.Length){

                Console.WriteLine("Kisinin Adı : {0} ", tumKisiler[i].ad);
                Console.WriteLine("Kisinin Soyadı : {0} ", tumKisiler[i].soyad);
                Console.WriteLine("Kisinin Doğum Yeri : {0} ", tumKisiler[i].dogumYeri);
                i++;
            }

        }

    }
    class Kisi
    {

        public string ad;
        public string soyad;
        public string dogumYeri;
        private string telefon;   // Başka kişilerin erişimini engellemek istersen --> private string telefon;

        // Field : Class'ın (nesnenin) özellikler.

        // Public : Her yerden erişebilir.                                  
        // Private : Sadece bulunduğu class scopeları arasından erişebilir.

        public void SayHello()
        {
            Console.WriteLine("Hello World");
        }
        //public override string ToString() // ToString'in normal yaptığı işlemi vardır. Biz bunu return'de değiştirerek istediğimiz şeyi yazdırmayı sağlıyoruz.
        //{
        //    return "Hello World";
        //}
        //public override string ToString(){
        //    return ad +" "+ soyad;
        //}
    }
}
