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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form2 frmIndirme = new Form2();

        // Seçilen değişkeni : Tam erişime açık paylaşılmış bir değişken
        public static string secilen;

        private void rBtn1_CheckedChanged(object sender, EventArgs e)
        {
            secilen = rBtn1.Text;

            frmIndirme.Show();
            this.Hide();
        }
        private void rBtn4_CheckedChanged(object sender, EventArgs e)
        {
            secilen = rBtn4.Text;

            frmIndirme.Show();
            this.Hide();



        }

        private void rBtn2_CheckedChanged(object sender, EventArgs e)
        {
            secilen = rBtn2.Text;

            frmIndirme.Show();
            this.Hide();
        }

        private void rBtn3_CheckedChanged(object sender, EventArgs e)
        {
            secilen = rBtn3.Text;

            frmIndirme.Show();
            this.Hide();
        }

      

        private void rBtn5_CheckedChanged(object sender, EventArgs e)
        {
            secilen = rBtn5.Text;

            frmIndirme.Show();
            this.Hide();
        }
    }
}
