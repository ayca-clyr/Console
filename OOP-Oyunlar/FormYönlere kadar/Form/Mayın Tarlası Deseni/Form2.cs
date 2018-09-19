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

namespace Mayın_Tarlası_Deseni
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        /*
         * Şu vakte kadar gördüğün dizilerin kısıtlarından ikisi : Tip bağımlı olması ve kapasite sınırı.
         * Ancak ArrayList sayesinde bu kısıtlar ortadan kalkacak.
         * ArrayList verileri object olarak tutacağından dolayı, içindeki verileri çekerken unboxing(casting/convert) yapmak gerekir.
         * ArrayList'e erişmek için using System.Collections kütüphanesini eklemek gerekir.
         */
        ArrayList modernDizi = new ArrayList();
        Kayıtlar yeniKayit = new Kayıtlar();  // Kayıt kalıbıyle oluşturduğumuz yeniKayit nesnesi.
        string sehirAdi;
        int plakaKodu;
        private void button1_Click(object sender, EventArgs e)
        {
            /*           ARRAY YARDIMIYLA ITEM KAYDETME     */
            //modernDizi.Add(txtBxSehir.Text+ " "+txtBxPlaka.Text);
            //lstBxKayitlar.Items.Add(modernDizi[0]);
            //modernDizi.Clear();
            //txtBxPlaka.Text = "";
            //txtBxSehir.Text = "";

            yeniKayit.SehirAdi = txtBxSehir.Text;
            yeniKayit.PlakaKodu = txtBxPlaka.Text;
            lstBxKayitlar.Items.Add(yeniKayit.ToString());
            txtBxPlaka.Text = "";
            txtBxSehir.Text = "";
            // MessageBox.Show(yeniKayit.ToString());
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


    }

    public class Kayıtlar
    {
        public string PlakaKodu;
        public string SehirAdi;

        public override string ToString()
        {
            return PlakaKodu + " " + SehirAdi;
        }
    }
}
