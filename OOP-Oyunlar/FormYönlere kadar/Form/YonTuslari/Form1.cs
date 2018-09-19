using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YonTuslari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        byte direction = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnKuzey_Click(object sender, EventArgs e)
        {
            btnX.Top += -10;
            direction = 1;
        }

        private void btnKuzeyDogu_Click(object sender, EventArgs e)
        {
            btnX.Top += -10;
            btnX.Left += +10;
            direction = 2;
        }

        private void btnDogu_Click(object sender, EventArgs e)
        {
            btnX.Left += +10;
            direction = 3;
        }

        private void btnGuney_Click(object sender, EventArgs e)
        {
            btnX.Top += +10;
            direction = 4;
        }

        private void btnGuneyDogu_Click(object sender, EventArgs e)
        {
            btnX.Left += +10;
            btnX.Top += +10;
            direction = 5;
        }

        private void btnGuneyBati_Click(object sender, EventArgs e)
        {
            btnX.Top += +10;
            btnX.Left += -10;
            direction = 6;
        }

        private void btnBati_Click(object sender, EventArgs e)
        {
            btnX.Left += -10;
            direction = 7;
        }

        private void btnKuzeyBati_Click(object sender, EventArgs e)
        {
            btnX.Top += -10;
            btnX.Left += -10;
            direction = 8;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Move();
        }

        void Move()
        {
            switch (direction)
            {
                case 1:
                    btnX.Top += -5;
                    break;
                case 2:
                    btnX.Top += -5;
                    btnX.Left += +5;
                    break;
                case 3:
                    btnX.Left += +5;
                    break;
                case 4:
                    btnX.Top += +5;
                    break;
                case 5:
                    btnX.Left += +5;
                    btnX.Top += +5;
                    break;
                case 6:
                    btnX.Top += +5;
                    btnX.Left += -5;
                    break;
                case 7:
                    btnX.Left += -5;
                    break;
                case 8:
                    btnX.Top += -5;
                    btnX.Left += -5;
                    break;

            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Butonları silersek bunlar yön tuşlarıdır. Sağ-sol-yukarı-aşağı hareketini klavyeden sağlamış oluruz.
            if (e.KeyCode ==Keys.W)  // Up
            {
                direction = 1;
            }
            else if (e.KeyCode == Keys.D) // Right
            {
                direction = 3;
            }
            else if (e.KeyCode == Keys.S) // Down
            {
                direction =4;
            }
            else if (e.KeyCode == Keys.A) // Left
            {
                direction = 7;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btnX.Left = 0;
            btnX.Top = 0;
        }

      

    }
}
