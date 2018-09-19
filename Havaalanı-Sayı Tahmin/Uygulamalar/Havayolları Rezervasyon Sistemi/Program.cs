using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Havayolları_Rezervasyon_Sistemi
{
    class Program
    {
        static void Main(string[] args)
        {
            int s;
            bool durum3 = true;
            bool dongu = true;
            while (durum3)
            {
                while (dongu)
                {
                    Console.WriteLine("1. Business Class bölümü için 1 tuşuna basın");
                    Console.WriteLine("2. Economy Class bölümü için 2 tuşuna basın");
                    dongu = false;
                }
                char sinif = Console.ReadKey(true).KeyChar;
                bool sinifTuru = int.TryParse(sinif.ToString(), out s);

                if (!sinifTuru)
                {

                }
                else
                {
                    bool durum1 = true;
                    while (durum1)
                    {
                        int kD;

                        int i = 0;
                        while (i < 5)
                        {
                            string[] isimler = { "Ayça", "Fidan", "Ferhat", "Burak", "Bilal", "Turgay", "Mehmet", "Can", null, "Raif", "Serkan", null, null, "Ozan", "Doğan", "Toni", "Hasan", "Hüseyin", null, null };
                            
                            int[] cN = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };


                            Console.WriteLine("\n");

                            if (isimler[8] == null) { 
                            Console.WriteLine("Boş Koltuk Numaraları {0} ", cN[8]);
                            }
                            if (isimler[11] == null)
                            {
                                Console.WriteLine("Boş Koltuk Numaraları {0} ", cN[11]);
                            }
                            if (isimler[12] == null)
                            {
                                Console.WriteLine("Boş Koltuk Numaraları {0} ", cN[12]);
                            }
                            if (isimler[18] == null)
                            {
                                Console.WriteLine("Boş Koltuk Numaraları {0} ", cN[18]);
                            }
                            if (isimler[19] == null)
                            {
                                Console.WriteLine("Boş Koltuk Numaraları {0} ", cN[19]);
                            }
                           
                            string koltuk = Console.ReadLine();
                            bool koltukDegeri = int.TryParse(koltuk, out kD);
                 
                            bool durum2 = true;
                            while (durum2)
                            {
                                if (!koltukDegeri)
                                {
                                    Console.WriteLine("Yanlış Değer Girdiniz!");
                                    break;
                                }
                                else
                                {
                                    
                                    if (isimler[kD - 1] != null)
                                    {
                                        Console.WriteLine("{0} Numaralı koltuk daha önce {1} isimli yolcuya rezerve edilmiştir.", kD, isimler[kD + 1]);
                                        Console.WriteLine("Lütfen Boş Koltuklardan Birini Seçiniz!");
                                        durum2 = false;
                                    }
                                    else 
                                    {
                                        Console.WriteLine("Seçilen Koltuk Numarası : {0}", kD);
                                        Console.WriteLine("Lütfen Yolcunun Adını ve Soyadını Yazınız : ");
                                        string adSoyad = Console.ReadLine();
                                      
                                        isimler[kD] = adSoyad;
                                        

                                        Console.WriteLine("Economy Class bölümündeki {0} Numaralı koltuğu {1} isimli yolcuya rezerve ettiniz.", kD, isimler[kD]);
                                        Console.Write("Devam Etmek için Bir Tuşa Basınız.");
                                        Console.ReadKey();
                                        
                                    }
                                }
                                durum2 = false;
                                
                            }
                            i++;
                        }
                    }
                }
                Console.WriteLine("Seçtiğiniz Business Class bölümünde boş koltuk kalmamıştır.");
            }
        }
    }
}

/* NOT : String dizisine atadığım değerler üstte 0'lanıyor. O yüzden koltukları dolduramıyorum.Buraya kadar gelebildim anca. Bu işlemi yapamadığım için devamını getiremedim. */