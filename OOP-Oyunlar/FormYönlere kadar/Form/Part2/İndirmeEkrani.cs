using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part2
{
    public partial class İndirmeEkrani : Form
    {
        public İndirmeEkrani()
        {
            InitializeComponent();
        }

        private void İndirmeEkrani_Load(object sender, EventArgs e)
        {
            lblSuankiZaman.Text = DateTime.Now.ToLongTimeString();
            //Suanki zaman labelına zamanı yazdırıyoruz.
            lblİndirilmeYüzdesi.Text =Form1.secilen + " İndirilmektedir.";
            ////seçilen değişken gelecek, form1'den.
            timer1.Enabled = true;
        }

        private void lblSuankiZaman_Click(object sender, EventArgs e)
        {
           
        }

        private void lblİndirilmeYüzdesi_Click(object sender, EventArgs e)
        {

        }

        private void btnUygulamayıKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //Uygulamayı sonlandırır.
        }

        private void btnAnasayfaDön_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();//Form1 ekranına donuyoruz.
            this.Hide();//Artık bu formu gizleyeceğiz.
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1); //ProgressBar'ın artış miktarı.
        }

        private void btnİndirmeyidurdur_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false; // Timer'ı durdurur.
            btnİndirmeyidurdur.Text = "İndirmeyi Başlat";
        }

        private void btnİndirmeyiiptal_Click(object sender, EventArgs e)
        {
            timer1.Stop();//Timer'ı durdurur.
            progressBar1.Value = 0; //ProgressBar'ın değerini sıfırlıyoruz'
            MessageBox.Show(Form1.secilen + " indirme işlemi iptal edildi.");
        }
    }
}
