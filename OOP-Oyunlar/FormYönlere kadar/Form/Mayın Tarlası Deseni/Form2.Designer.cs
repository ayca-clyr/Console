namespace Mayın_Tarlası_Deseni
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblSehirİsmi = new System.Windows.Forms.Label();
            this.lblPlakaKodu = new System.Windows.Forms.Label();
            this.txtBxSehir = new System.Windows.Forms.TextBox();
            this.txtBxPlaka = new System.Windows.Forms.TextBox();
            this.lstBxKayitlar = new System.Windows.Forms.ListBox();
            this.lblSehirler = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSehirİsmi
            // 
            this.lblSehirİsmi.AutoSize = true;
            this.lblSehirİsmi.Location = new System.Drawing.Point(27, 189);
            this.lblSehirİsmi.Name = "lblSehirİsmi";
            this.lblSehirİsmi.Size = new System.Drawing.Size(52, 13);
            this.lblSehirİsmi.TabIndex = 1;
            this.lblSehirİsmi.Text = "Şehir İsmi";
            // 
            // lblPlakaKodu
            // 
            this.lblPlakaKodu.AutoSize = true;
            this.lblPlakaKodu.Location = new System.Drawing.Point(27, 235);
            this.lblPlakaKodu.Name = "lblPlakaKodu";
            this.lblPlakaKodu.Size = new System.Drawing.Size(62, 13);
            this.lblPlakaKodu.TabIndex = 2;
            this.lblPlakaKodu.Text = "Plaka Kodu";
            // 
            // txtBxSehir
            // 
            this.txtBxSehir.Location = new System.Drawing.Point(107, 182);
            this.txtBxSehir.Name = "txtBxSehir";
            this.txtBxSehir.Size = new System.Drawing.Size(100, 20);
            this.txtBxSehir.TabIndex = 3;
            // 
            // txtBxPlaka
            // 
            this.txtBxPlaka.Location = new System.Drawing.Point(107, 228);
            this.txtBxPlaka.Name = "txtBxPlaka";
            this.txtBxPlaka.Size = new System.Drawing.Size(100, 20);
            this.txtBxPlaka.TabIndex = 4;
            // 
            // lstBxKayitlar
            // 
            this.lstBxKayitlar.FormattingEnabled = true;
            this.lstBxKayitlar.Location = new System.Drawing.Point(380, 50);
            this.lstBxKayitlar.Name = "lstBxKayitlar";
            this.lstBxKayitlar.Size = new System.Drawing.Size(354, 277);
            this.lstBxKayitlar.TabIndex = 5;
            // 
            // lblSehirler
            // 
            this.lblSehirler.AutoSize = true;
            this.lblSehirler.Location = new System.Drawing.Point(405, 13);
            this.lblSehirler.Name = "lblSehirler";
            this.lblSehirler.Size = new System.Drawing.Size(41, 13);
            this.lblSehirler.TabIndex = 7;
            this.lblSehirler.Text = "Kayıtlat";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 442);
            this.Controls.Add(this.lblSehirler);
            this.Controls.Add(this.lstBxKayitlar);
            this.Controls.Add(this.txtBxPlaka);
            this.Controls.Add(this.txtBxSehir);
            this.Controls.Add(this.lblPlakaKodu);
            this.Controls.Add(this.lblSehirİsmi);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSehirİsmi;
        private System.Windows.Forms.Label lblPlakaKodu;
        private System.Windows.Forms.TextBox txtBxSehir;
        private System.Windows.Forms.TextBox txtBxPlaka;
        private System.Windows.Forms.ListBox lstBxKayitlar;
        private System.Windows.Forms.Label lblSehirler;
    }
}