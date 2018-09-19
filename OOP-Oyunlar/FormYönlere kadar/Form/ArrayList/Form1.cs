using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ArrayListt
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

        ArrayList kisiListesi = new ArrayList();
        string[] stringDizisi = new string[5];
        private void Yenile()
        {
            txtBxAd.Clear();
            foreach(var item in kisiListesi){
                listBox1.Items.Add(item);
            }
            kisiListesi.Clear();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBxAd.Text != "" && txtBxAd.Text != null)
            {
                kisiListesi.Add(txtBxAd.Text);
                // txtBxAd.Text = "";
                // kisiListesi.Clear();
                Yenile();
            }
            else
            {
                MessageBox.Show("Lütfen Geçerli Bir Değer Giriniz.");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Remove(listBox1.SelectedItem);

        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            string mesaj = listBox1.Items.Count.ToString();
            MessageBox.Show(mesaj); 
        }

        private void btnIsFixedSize_Click(object sender, EventArgs e)
        {
            
            
            if (kisiListesi.IsFixedSize)
            {
                MessageBox.Show("ArrayList'in Geçerli Bir Sınır Değeri Vardır.");
            }
            else
            {
                MessageBox.Show("ArrayList'in Geçerli Bir Sınır Değeri Yoktur!");
            }
            if (stringDizisi.IsFixedSize)
            {
                MessageBox.Show("StringDizisi'nin Geçerli Bir Sınır Değeri Vardır.");
            }
            else
            {
                MessageBox.Show("StringDizisi'nin Geçerli Bir Sınır Değeri Yoktur!");
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            kisiListesi.Clear();
            kisiListesi.AddRange(listBox1.Items);
            listBox1.Items.Clear();
            kisiListesi.Sort();
            
            foreach (var item in kisiListesi)
            {
                listBox1.Items.Add(item);   
            }           
            kisiListesi.Clear();
            
        }

        private void btnInser_Click(object sender, EventArgs e)
        {
            kisiListesi.AddRange(listBox1.Items);
            listBox1.Items.Clear();

            if (txtBxAd.Text != "" && txtBxAd.Text != null)
            {
                kisiListesi.Add(txtBxAd.Text);
                // txtBxAd.Text = "";
                // kisiListesi.Clear();
                Yenile();
            }
            else
            {
                MessageBox.Show("Lütfen Geçerli Bir Değer Giriniz.");
            }




            kisiListesi.Insert(2,txtBxAd.Text);  // 0-1-2 indis ona göre koysun 2 ise 

            //foreach (var item in kisiListesi)
            //{
            //    listBox1.Items.Add(item);
            //}
            //kisiListesi.Clear();
            //txtBxAd.Text = "";

            Yenile();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Yenile();
        }

        private void btnContains_Click(object sender, EventArgs e)
        {

        }
        
 

    }
}
