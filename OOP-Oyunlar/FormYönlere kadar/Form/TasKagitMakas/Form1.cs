using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TasKagitMakas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }
        Random rnd = new Random();

        private void btnPlayer1_Click(object sender, EventArgs e)
        {
            switch (rnd.Next(1, 4))
            {
                case 1:
                    lbl1.Text = "Taş";
                    break;
                case 2:
                    lbl1.Text = "Makas";
                    break;
                case 3 :
                    lbl1.Text = "Kağıt";
                    break;
                default:
                    MessageBox.Show("Turgat ile Ferhat yanıldı!");
                    break;
            }
        }

        private void btnPlayer2_Click(object sender, EventArgs e)
        {
            switch (rnd.Next(1, 4))
            {
                case 1:
                    lbl2.Text = "Taş";
                    break;
                case 2:
                    lbl2.Text = "Makas";
                    break;
                case 3:
                    lbl2.Text = "Kağıt";
                    break;
                default:
                    MessageBox.Show("Turgat ile Ferhat yanıldı!");
                    break;
            }
            if (lbl1.Text == "Taş " && lbl2.Text == "Makas")
            {
              lblSonuc.Text = "Taş Makası kırar. Player1 kazandı.";
            }
            else if (lbl1.Text == "Taş" && lbl2.Text == "Kağıt")
            {
                lblSonuc.Text = "Kağıt Taşı Sarar.Player2 kazandı.";
            }
            else if (lbl1.Text == "Makas" && lbl2.Text == "Kağıt")
            {
                lblSonuc.Text = "Makas Kağıdı Keser.Player 1 kazandı.";
            }
            else if (lbl1.Text == "Makas" && lbl2.Text == "Taş")
            {
                lblSonuc.Text = "Taş makası kırar. Player2 kazandı.";
            }else if(lbl1.Text == "Kağıt" && lbl2.Text == "Taş"){
                lblSonuc.Text = "Kağıt Taşı Sarar.Player1 kazandı.";
            }else if(lbl1.Text == "Kağıt" && lbl2.Text == "Makas"){
                lblSonuc.Text = "Makas kağıdı keser.Player2 kazandı.";
            }else{
                lblSonuc.Text = "Berabere";
            }

        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            lbl1.Text = "";
            lbl2.Text = "";
            lblSonuc.Text = "";
        }


    }
}
