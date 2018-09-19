namespace ArabaYarisi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pBx1 = new System.Windows.Forms.PictureBox();
            this.pBx2 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pBx3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBx3)).BeginInit();
            this.SuspendLayout();
            // 
            // pBx1
            // 
            this.pBx1.Image = ((System.Drawing.Image)(resources.GetObject("pBx1.Image")));
            this.pBx1.Location = new System.Drawing.Point(2, 123);
            this.pBx1.Name = "pBx1";
            this.pBx1.Size = new System.Drawing.Size(100, 50);
            this.pBx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBx1.TabIndex = 0;
            this.pBx1.TabStop = false;
            // 
            // pBx2
            // 
            this.pBx2.Image = ((System.Drawing.Image)(resources.GetObject("pBx2.Image")));
            this.pBx2.Location = new System.Drawing.Point(2, 217);
            this.pBx2.Name = "pBx2";
            this.pBx2.Size = new System.Drawing.Size(100, 50);
            this.pBx2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBx2.TabIndex = 1;
            this.pBx2.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(53, 323);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 37);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pBx3
            // 
            this.pBx3.Image = ((System.Drawing.Image)(resources.GetObject("pBx3.Image")));
            this.pBx3.Location = new System.Drawing.Point(734, 78);
            this.pBx3.Name = "pBx3";
            this.pBx3.Size = new System.Drawing.Size(94, 240);
            this.pBx3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBx3.TabIndex = 3;
            this.pBx3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 440);
            this.Controls.Add(this.pBx3);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pBx2);
            this.Controls.Add(this.pBx1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBx3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pBx1;
        private System.Windows.Forms.PictureBox pBx2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pBx3;
    }
}

