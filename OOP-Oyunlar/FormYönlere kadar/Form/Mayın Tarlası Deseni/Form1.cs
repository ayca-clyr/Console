using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mayın_Tarlası_Deseni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
         * for(int i = 0; i < length; i++){
         * Önce başlangıç noktası; sonrasında bitiş koşulu; indisin bu aralıkta nasıl edeceği
         * }
         * */
        int i, j = 0;
        private void btnEkle_Click(object sender, EventArgs e)
        {

            //int i, j = 1;
            for (i = 0; i < 5; i++)   // i=5 oldu en sonda!
            {

                //MessageBox.Show("Merhaba" + (i + 1));
                // MessageBox.Show("Mesaj Kutusunun Metni","Başlık",MessageBoxButtons.YesNo);
                // MessageBox.Show("Mesaj Kutusunun Metni", "Başlık", MessageBoxButtons.AbortRetryIgnore);
                //MessageBox.Show("Birinci Döngü " + i + ". kez çalışıyor.");

                for (j = 0; j < 5; j++) // j = j * 2;  // j=5 oldu en sonda!
                {
                    Button btn = new Button();
                    btn.Name = "btn" + i + j;
                    btn.Text = "Button" + i + " , " + j;
                    btn.Size = new Size(80, 60);
                    btn.Location = new Point(i * 80, j * 60);
                    btn.Tag = "GizliVeri";
                    btn.BackColor = Color.Yellow;
                    btn.Click += YeniOlusturulanButonunKliclOlayi;
                    pnlMayın.Controls.Add(btn);

                    //MessageBox.Show("İkinci Döngü " + j + ". kez çalışıyor.");

                }

            }
            //int toplam = (i-1) * (j-1);
            //MessageBox.Show(toplam.ToString());
        }
        void YeniOlusturulanButonunKliclOlayi(object sender, EventArgs e)
        {
            Button tiklananButonNesnesi = sender as Button;
            // Button tiklananButonNesnesi1 = (Button)sender;
            tiklananButonNesnesi.BackColor = Color.Red;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            pnlMayın.Controls.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Button denek = pnlMayın.Controls[0] as Button; ilk buton için
            // denek.BackColor = Color.Green; ilk buton için

            //for (int k = 0; k <= (i * j); k++) // Sonuç olarak temizle dedikten sonra işlemleri tekrarlayınca hata alıyoruz.
            //{
            //    if (pnlMayın.Controls[k] is Button) // Sen bir buton musun?
            //    {
            //        pnlMayın.Controls[k].BackColor = Color.Green;
            //    }

            //}

            foreach (var paneldekiler in pnlMayın.Controls)
            {
                // if(item is Button){
                //Button btn = (Button)item;
                //}
                if (paneldekiler is Button)
                {
                    Button btn = paneldekiler as Button;


                    // btn.BackColor = Color.Green;

                    btn.BackColor = Control.DefaultBackColor;
                }
                else
                {
                    Label lbl = paneldekiler as Label;
                    lbl.BackColor = Color.Wheat;
                }
            }
            int[] plaka = { 1, 2, 3, 4, 5 };
            string[] il = { "Adana", "Adıyaman", "Afyon", "Ağrı", "Amasya" };
            int i, j = 0;

            for (i = 0,j=0; i < plaka.Length && j < il.Length; i++,j++)
            {
                MessageBox.Show("" + plaka[i]+ " Plakalı İlimiz "+ il[j]);
            }
        }

    }
}
