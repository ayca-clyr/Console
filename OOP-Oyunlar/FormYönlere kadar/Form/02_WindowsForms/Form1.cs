using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtBxUsername.Text == "bilgeadam" && txtBxPassword.Text == "123")
            {
                MessageBox.Show("Giriş Başarılı");
                Form frm = new Form();
                frm.Size = new Size(500,500);                
                //frm.Size.Height += 100;
                //frm.Size.Width -= 100;

                frm.BackColor = Color.Blue;
                
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Kullanıcı Adı ve Şifrenizi Yanlış Girdiniz!");
            }
        }
    }
}
