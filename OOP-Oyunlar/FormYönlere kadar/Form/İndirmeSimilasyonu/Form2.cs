using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İndirmeSimilasyonu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Zaman label'ına zamanı yazdırıyoruz.
            lblZaman1.Text = DateTime.Now.ToLongTimeString();
            // Seçilen değişken Form1'den gelecek
            lblYuzde.Text = Form1.secilen + " İndirilmektedir.";
            timer1.Enabled = true;

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            // Uygulamayı sonlandır.
            Application.Exit();
        }

        private void btnAnaDon_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show(); // Form1 ekranına dönüyoruz.
            this.Hide(); // Artık bu formu gizleyeceğiz.
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);  // ProgressBar'ın artış miktarı.
        }

        private void btnDuraklat_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;  // Timer'ı durdurur.
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            timer1.Stop(); // Timer'ı durdurur.
            progressBar1.Value = 0; // ProgressBar'ın değerini sıfırlıyoruz.
            MessageBox.Show(Form1.secilen + "indirme işlemi iptal edildi.");
        }



    }
}
