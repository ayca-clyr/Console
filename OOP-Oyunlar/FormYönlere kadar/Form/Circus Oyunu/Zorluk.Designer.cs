namespace Circus_Oyunu
{
    partial class Zorluk
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rBtnKolay = new System.Windows.Forms.RadioButton();
            this.rBtnOrta = new System.Windows.Forms.RadioButton();
            this.rBtnZor = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "!HOŞGELDİNİZ!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(913, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "!HOŞGELDİNİZ!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(232, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(582, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "LÜTFEN ZORLUK SEVİYESİNİ SEÇİNİZ...";
            // 
            // rBtnKolay
            // 
            this.rBtnKolay.AutoSize = true;
            this.rBtnKolay.Location = new System.Drawing.Point(255, 201);
            this.rBtnKolay.Name = "rBtnKolay";
            this.rBtnKolay.Size = new System.Drawing.Size(75, 21);
            this.rBtnKolay.TabIndex = 3;
            this.rBtnKolay.TabStop = true;
            this.rBtnKolay.Text = "KOLAY";
            this.rBtnKolay.UseVisualStyleBackColor = true;
            this.rBtnKolay.CheckedChanged += new System.EventHandler(this.rBtnKolay_CheckedChanged);
            // 
            // rBtnOrta
            // 
            this.rBtnOrta.AutoSize = true;
            this.rBtnOrta.Location = new System.Drawing.Point(255, 260);
            this.rBtnOrta.Name = "rBtnOrta";
            this.rBtnOrta.Size = new System.Drawing.Size(68, 21);
            this.rBtnOrta.TabIndex = 4;
            this.rBtnOrta.TabStop = true;
            this.rBtnOrta.Text = "ORTA";
            this.rBtnOrta.UseVisualStyleBackColor = true;
            this.rBtnOrta.CheckedChanged += new System.EventHandler(this.rBtnOrta_CheckedChanged);
            // 
            // rBtnZor
            // 
            this.rBtnZor.AutoSize = true;
            this.rBtnZor.Location = new System.Drawing.Point(255, 324);
            this.rBtnZor.Name = "rBtnZor";
            this.rBtnZor.Size = new System.Drawing.Size(59, 21);
            this.rBtnZor.TabIndex = 5;
            this.rBtnZor.TabStop = true;
            this.rBtnZor.Text = "ZOR";
            this.rBtnZor.UseVisualStyleBackColor = true;
            this.rBtnZor.CheckedChanged += new System.EventHandler(this.rBtnZor_CheckedChanged);
            // 
            // Zorluk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 528);
            this.Controls.Add(this.rBtnZor);
            this.Controls.Add(this.rBtnOrta);
            this.Controls.Add(this.rBtnKolay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Zorluk";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rBtnKolay;
        private System.Windows.Forms.RadioButton rBtnOrta;
        private System.Windows.Forms.RadioButton rBtnZor;
    }
}

