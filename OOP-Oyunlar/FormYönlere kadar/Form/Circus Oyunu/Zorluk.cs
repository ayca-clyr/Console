using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circus_Oyunu
{
    public partial class Zorluk : Form
    {
        public Zorluk()
        {
            InitializeComponent();
        }
        public static string secilen;
        // Tam erişime açık paylaşılmış bir değişken.

        Zorluk frmIndirme = new Zorluk();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rBtnKolay_CheckedChanged(object sender, EventArgs e)
        {
            secilen = rBtnKolay.Text;
            frmIndirme.Show();
            this.Hide();
        }

        private void rBtnOrta_CheckedChanged(object sender, EventArgs e)
        {
            secilen = rBtnOrta.Text;
            frmIndirme.Show();
            this.Hide();
        }

        private void rBtnZor_CheckedChanged(object sender, EventArgs e)
        {
            secilen = rBtnZor.Text;
            frmIndirme.Show();
            this.Hide();
        }
    }
}
