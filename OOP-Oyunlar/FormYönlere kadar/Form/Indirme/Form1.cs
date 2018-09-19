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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string secilen;
        // Tam erişime açık paylaşılmış bir değişken.

        Indirme frmIndirme = new Indirme();

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            secilen = radioButton1.Text;
            frmIndirme.Show();
            this.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            secilen = radioButton2.Text;
            frmIndirme.Show();
            this.Hide();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            secilen = radioButton3.Text;
            frmIndirme.Show();
            this.Hide();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            secilen = radioButton4.Text;
            frmIndirme.Show();
            this.Hide();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            secilen = radioButton5.Text;
            frmIndirme.Show();
            this.Hide();
        }
    }
}
