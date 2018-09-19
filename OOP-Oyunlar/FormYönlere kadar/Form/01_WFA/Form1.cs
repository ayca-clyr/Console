using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                
        }

     
        private void btnGiris_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("Hello World");
            if (txtBxKullaniciAdi.Text == "bilgeadam" && txtBxSifre.Text == "123")
            {
                MessageBox.Show("Giriş Baraşılı...");
                Form frm = new Form();
                // frm.Show();  Giriş baraşılıysa 2. panele geçer. Arkadaki form'a tıklayabilirsin.
                // frm.ShowDialog(); Giriş başarılıysa 2. panele geçer. Arkadaki form'a tıklayamazsın.
            }else{
                MessageBox.Show("Yanlış Kullanıcı Adı veya Şifre Girdiniz!");
            }
        }
    }
}
