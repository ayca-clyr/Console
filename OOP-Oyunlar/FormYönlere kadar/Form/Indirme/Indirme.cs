using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Indirme
{
    public partial class Indirme : Form
    {
        public Indirme()
        {
            InitializeComponent();
        }

        private void Indirme_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongDateString();
            // Şuanki zaman label'ına zamanı yazdırıyoruz.
            label1.Text = Form1.secilen + " İndirilmektedir.";
            timer1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
            // Uygulamayı Sonlandırır.
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show(); // Form1 Ekranına DÖnüyoruz.
            this.Hide(); // Artık Bu Formu Gizleyeceğiz.
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Increment(1); // ProgessBar'ın artış mikarı
                // progressBar1.Value = 1;
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("İndirme İşleminiz Sona Erdi.");
                // timer1.Enabled = false;
                        

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false; // Timer'ı durdurur.
            button1.Text = "İndirmeyi Başlat";
                 


        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop(); // Timer'ı durdurur.
            progressBar1.Value = 0; // ProgressBar'ın değerini sıfırlıyoruz.
            MessageBox.Show(Form1.secilen + " İndirme İşlemi İptal Edildi.");

        }

    }
}
