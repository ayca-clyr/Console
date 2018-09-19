using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Giris{
    class Program{
        static void Main(string[] args){
            //Console.WriteLine("(Merhaba Dünya) Serkan çok güldü. Başımıza birşey gelmez inşallah (Amin) "); ctrl + k + c Yorum
            //Console.WriteLine("(Merhaba Dünya) Serkan çok güldü. Başımıza birşey gelmez inşallah (Amin) ");
            //Console.WriteLine("(Merhaba Dünya) Serkan çok güldü. Başımıza birşey gelmez inşallah (Amin) ");

            //Console.Write("(Merhaba Dünya) Serkan çok güldü. Başımıza birşey gelmez inşallah (Amin) ");
            //Console.Write("(Merhaba Dünya) Serkan çok güldü. Başımıza birşey gelmez inşallah (Amin) ");
            //Console.Write("(Merhaba Dünya) Serkan çok güldü. Başımıza birşey gelmez inşallah (Amin) ");

            string[] dizi = {"Ayça"};
           string eleman = "a";
            int index = 0;
           while (index < dizi.Length)
            {
                if (dizi[index] == eleman)
                {
                    Console.WriteLine(index);
                }
                index++;
            }
        



        }
    }
}
