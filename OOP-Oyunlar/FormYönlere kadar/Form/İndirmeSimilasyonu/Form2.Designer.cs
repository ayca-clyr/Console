namespace İndirmeSimilasyonu
{
    partial class Form2
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
            this.lblYuzde = new System.Windows.Forms.Label();
            this.btnDuraklat = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnAnaDon = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblZaman1 = new System.Windows.Forms.Label();
            this.lblZaman2 = new System.Windows.Forms.Label();
            this.btnIptal = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblYuzde
            // 
            this.lblYuzde.AutoSize = true;
            this.lblYuzde.Location = new System.Drawing.Point(13, 22);
            this.lblYuzde.Name = "lblYuzde";
            this.lblYuzde.Size = new System.Drawing.Size(85, 13);
            this.lblYuzde.TabIndex = 0;
            this.lblYuzde.Text = "Indirilme Yüzdesi";
            // 
            // btnDuraklat
            // 
            this.btnDuraklat.Location = new System.Drawing.Point(12, 158);
            this.btnDuraklat.Name = "btnDuraklat";
            this.btnDuraklat.Size = new System.Drawing.Size(110, 50);
            this.btnDuraklat.TabIndex = 1;
            this.btnDuraklat.Text = "Indirmeyi Durdur";
            this.btnDuraklat.UseVisualStyleBackColor = true;
            this.btnDuraklat.Click += new System.EventHandler(this.btnDuraklat_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(209, 158);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(113, 50);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Uygulamayı Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnAnaDon
            // 
            this.btnAnaDon.Location = new System.Drawing.Point(328, 158);
            this.btnAnaDon.Name = "btnAnaDon";
            this.btnAnaDon.Size = new System.Drawing.Size(112, 50);
            this.btnAnaDon.TabIndex = 3;
            this.btnAnaDon.Text = "Anasayfaya Döm>>";
            this.btnAnaDon.UseVisualStyleBackColor = true;
            this.btnAnaDon.Click += new System.EventHandler(this.btnAnaDon_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 84);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(419, 49);
            this.progressBar1.TabIndex = 4;
            // 
            // lblZaman1
            // 
            this.lblZaman1.AutoSize = true;
            this.lblZaman1.Location = new System.Drawing.Point(22, 309);
            this.lblZaman1.Name = "lblZaman1";
            this.lblZaman1.Size = new System.Drawing.Size(76, 13);
            this.lblZaman1.TabIndex = 5;
            this.lblZaman1.Text = "Şuanki Zaman";
            // 
            // lblZaman2
            // 
            this.lblZaman2.AutoSize = true;
            this.lblZaman2.Location = new System.Drawing.Point(22, 347);
            this.lblZaman2.Name = "lblZaman2";
            this.lblZaman2.Size = new System.Drawing.Size(40, 13);
            this.lblZaman2.TabIndex = 6;
            this.lblZaman2.Text = "Zaman";
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(128, 158);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(75, 50);
            this.btnIptal.TabIndex = 7;
            this.btnIptal.Text = "Indirme İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 369);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.lblZaman2);
            this.Controls.Add(this.lblZaman1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnAnaDon);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnDuraklat);
            this.Controls.Add(this.lblYuzde);
            this.Name = "Form2";
            this.Text = "Indirme Ekranı";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYuzde;
        private System.Windows.Forms.Button btnDuraklat;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnAnaDon;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblZaman1;
        private System.Windows.Forms.Label lblZaman2;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Timer timer1;
    }
}