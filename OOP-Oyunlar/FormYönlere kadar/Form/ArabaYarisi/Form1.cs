using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArabaYarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Start();
        }

        Random rnd1 = new Random();

        bool pembeArama = true;
        bool eflatunArama = true;

  

        private void timer1_Tick(object sender, EventArgs e)
        {
            int kaymaMiktari1 = rnd1.Next(1, 10);
            int kaymaMiktari2 = rnd1.Next(1, 10);

            if (pBx1.Right <= pBx3.Left && pembeArama == true)
            {
                pBx1.Left += kaymaMiktari1;
            }else
            {
                timer1.Stop();
                MessageBox.Show("Pembe Araba Kazandı.");
            }
            if(pBx2.Right <= pBx3.Left && eflatunArama == true)
            {
                pBx2.Left += kaymaMiktari2;
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Eflatun Araba Kazandı.");
            }
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }


    }
}
