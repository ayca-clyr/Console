namespace Part2
{
    partial class İndirmeEkrani
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnİndirmeyidurdur = new System.Windows.Forms.Button();
            this.btnUygulamayıKapat = new System.Windows.Forms.Button();
            this.btnAnasayfaDön = new System.Windows.Forms.Button();
            this.lblİndirilmeYüzdesi = new System.Windows.Forms.Label();
            this.lblSuankiZaman = new System.Windows.Forms.Label();
            this.lblZaman = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnİndirmeyiiptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnİndirmeyidurdur
            // 
            this.btnİndirmeyidurdur.Location = new System.Drawing.Point(23, 236);
            this.btnİndirmeyidurdur.Name = "btnİndirmeyidurdur";
            this.btnİndirmeyidurdur.Size = new System.Drawing.Size(75, 53);
            this.btnİndirmeyidurdur.TabIndex = 0;
            this.btnİndirmeyidurdur.Text = "İndirmeyi Duraklat";
            this.btnİndirmeyidurdur.UseVisualStyleBackColor = true;
            this.btnİndirmeyidurdur.Click += new System.EventHandler(this.btnİndirmeyidurdur_Click);
            // 
            // btnUygulamayıKapat
            // 
            this.btnUygulamayıKapat.Location = new System.Drawing.Point(241, 237);
            this.btnUygulamayıKapat.Name = "btnUygulamayıKapat";
            this.btnUygulamayıKapat.Size = new System.Drawing.Size(75, 52);
            this.btnUygulamayıKapat.TabIndex = 1;
            this.btnUygulamayıKapat.Text = "Uygulamayı Kapat";
            this.btnUygulamayıKapat.UseVisualStyleBackColor = true;
            this.btnUygulamayıKapat.Click += new System.EventHandler(this.btnUygulamayıKapat_Click);
            // 
            // btnAnasayfaDön
            // 
            this.btnAnasayfaDön.Location = new System.Drawing.Point(363, 236);
            this.btnAnasayfaDön.Name = "btnAnasayfaDön";
            this.btnAnasayfaDön.Size = new System.Drawing.Size(75, 52);
            this.btnAnasayfaDön.TabIndex = 2;
            this.btnAnasayfaDön.Text = "Anasayfa Dön";
            this.btnAnasayfaDön.UseVisualStyleBackColor = true;
            this.btnAnasayfaDön.Click += new System.EventHandler(this.btnAnasayfaDön_Click);
            // 
            // lblİndirilmeYüzdesi
            // 
            this.lblİndirilmeYüzdesi.AutoSize = true;
            this.lblİndirilmeYüzdesi.Location = new System.Drawing.Point(23, 27);
            this.lblİndirilmeYüzdesi.Name = "lblİndirilmeYüzdesi";
            this.lblİndirilmeYüzdesi.Size = new System.Drawing.Size(85, 13);
            this.lblİndirilmeYüzdesi.TabIndex = 3;
            this.lblİndirilmeYüzdesi.Text = "İndirilme Yüzdesi";
            this.lblİndirilmeYüzdesi.Click += new System.EventHandler(this.lblİndirilmeYüzdesi_Click);
            // 
            // lblSuankiZaman
            // 
            this.lblSuankiZaman.AutoSize = true;
            this.lblSuankiZaman.Location = new System.Drawing.Point(20, 309);
            this.lblSuankiZaman.Name = "lblSuankiZaman";
            this.lblSuankiZaman.Size = new System.Drawing.Size(76, 13);
            this.lblSuankiZaman.TabIndex = 4;
            this.lblSuankiZaman.Text = "Şuanki Zaman";
            this.lblSuankiZaman.Click += new System.EventHandler(this.lblSuankiZaman_Click);
            // 
            // lblZaman
            // 
            this.lblZaman.AutoSize = true;
            this.lblZaman.Location = new System.Drawing.Point(23, 338);
            this.lblZaman.Name = "lblZaman";
            this.lblZaman.Size = new System.Drawing.Size(40, 13);
            this.lblZaman.TabIndex = 5;
            this.lblZaman.Text = "Zaman";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(26, 95);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(412, 64);
            this.progressBar1.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnİndirmeyiiptal
            // 
            this.btnİndirmeyiiptal.Location = new System.Drawing.Point(127, 237);
            this.btnİndirmeyiiptal.Name = "btnİndirmeyiiptal";
            this.btnİndirmeyiiptal.Size = new System.Drawing.Size(75, 51);
            this.btnİndirmeyiiptal.TabIndex = 7;
            this.btnİndirmeyiiptal.Text = "İndirmeyi İptal";
            this.btnİndirmeyiiptal.UseVisualStyleBackColor = true;
            this.btnİndirmeyiiptal.Click += new System.EventHandler(this.btnİndirmeyiiptal_Click);
            // 
            // İndirmeEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 375);
            this.Controls.Add(this.btnİndirmeyiiptal);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblZaman);
            this.Controls.Add(this.lblSuankiZaman);
            this.Controls.Add(this.lblİndirilmeYüzdesi);
            this.Controls.Add(this.btnAnasayfaDön);
            this.Controls.Add(this.btnUygulamayıKapat);
            this.Controls.Add(this.btnİndirmeyidurdur);
            this.Name = "İndirmeEkrani";
            this.Text = "İndirmeEkrani";
            this.Load += new System.EventHandler(this.İndirmeEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnİndirmeyidurdur;
        private System.Windows.Forms.Button btnUygulamayıKapat;
        private System.Windows.Forms.Button btnAnasayfaDön;
        private System.Windows.Forms.Label lblİndirilmeYüzdesi;
        private System.Windows.Forms.Label lblSuankiZaman;
        private System.Windows.Forms.Label lblZaman;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnİndirmeyiiptal;
    }
}