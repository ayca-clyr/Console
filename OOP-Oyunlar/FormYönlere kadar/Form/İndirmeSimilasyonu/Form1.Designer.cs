namespace İndirmeSimilasyonu
{
    partial class Form1
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
            this.rBtn1 = new System.Windows.Forms.RadioButton();
            this.rBtn2 = new System.Windows.Forms.RadioButton();
            this.rBtn3 = new System.Windows.Forms.RadioButton();
            this.rBtn4 = new System.Windows.Forms.RadioButton();
            this.rBtn5 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(175, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "İndirmek İstediğiniz Programı Seçiniz...";
            // 
            // rBtn1
            // 
            this.rBtn1.AutoSize = true;
            this.rBtn1.Location = new System.Drawing.Point(31, 85);
            this.rBtn1.Name = "rBtn1";
            this.rBtn1.Size = new System.Drawing.Size(113, 17);
            this.rBtn1.TabIndex = 1;
            this.rBtn1.Text = "Visual Studio 2015";
            this.rBtn1.UseVisualStyleBackColor = true;
            this.rBtn1.CheckedChanged += new System.EventHandler(this.rBtn1_CheckedChanged);
            // 
            // rBtn2
            // 
            this.rBtn2.AutoSize = true;
            this.rBtn2.Location = new System.Drawing.Point(31, 108);
            this.rBtn2.Name = "rBtn2";
            this.rBtn2.Size = new System.Drawing.Size(171, 17);
            this.rBtn2.TabIndex = 2;
            this.rBtn2.Text = "SQL Management Studio 2014";
            this.rBtn2.UseVisualStyleBackColor = true;
            this.rBtn2.CheckedChanged += new System.EventHandler(this.rBtn2_CheckedChanged);
            // 
            // rBtn3
            // 
            this.rBtn3.AutoSize = true;
            this.rBtn3.Location = new System.Drawing.Point(31, 131);
            this.rBtn3.Name = "rBtn3";
            this.rBtn3.Size = new System.Drawing.Size(99, 17);
            this.rBtn3.TabIndex = 3;
            this.rBtn3.Text = "Photoshop CS6";
            this.rBtn3.UseVisualStyleBackColor = true;
            this.rBtn3.CheckedChanged += new System.EventHandler(this.rBtn3_CheckedChanged);
            // 
            // rBtn4
            // 
            this.rBtn4.AutoSize = true;
            this.rBtn4.Location = new System.Drawing.Point(31, 154);
            this.rBtn4.Name = "rBtn4";
            this.rBtn4.Size = new System.Drawing.Size(56, 17);
            this.rBtn4.TabIndex = 4;
            this.rBtn4.Text = "GTA 5";
            this.rBtn4.UseVisualStyleBackColor = true;
            this.rBtn4.CheckedChanged += new System.EventHandler(this.rBtn4_CheckedChanged);
            // 
            // rBtn5
            // 
            this.rBtn5.AutoSize = true;
            this.rBtn5.Location = new System.Drawing.Point(31, 177);
            this.rBtn5.Name = "rBtn5";
            this.rBtn5.Size = new System.Drawing.Size(57, 17);
            this.rBtn5.TabIndex = 5;
            this.rBtn5.Text = "Titanik";
            this.rBtn5.UseVisualStyleBackColor = true;
            this.rBtn5.CheckedChanged += new System.EventHandler(this.rBtn5_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 434);
            this.Controls.Add(this.rBtn5);
            this.Controls.Add(this.rBtn4);
            this.Controls.Add(this.rBtn3);
            this.Controls.Add(this.rBtn2);
            this.Controls.Add(this.rBtn1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rBtn1;
        private System.Windows.Forms.RadioButton rBtn2;
        private System.Windows.Forms.RadioButton rBtn3;
        private System.Windows.Forms.RadioButton rBtn4;
        private System.Windows.Forms.RadioButton rBtn5;
    }
}

