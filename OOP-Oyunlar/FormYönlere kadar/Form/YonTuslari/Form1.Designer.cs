namespace YonTuslari
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
            this.btnX = new System.Windows.Forms.Button();
            this.btnKuzey = new System.Windows.Forms.Button();
            this.btnKuzeyDogu = new System.Windows.Forms.Button();
            this.btnDogu = new System.Windows.Forms.Button();
            this.btnGuneyDogu = new System.Windows.Forms.Button();
            this.btnGuney = new System.Windows.Forms.Button();
            this.btnGuneyBati = new System.Windows.Forms.Button();
            this.btnBati = new System.Windows.Forms.Button();
            this.btnKuzeyBati = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnX.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnX.Location = new System.Drawing.Point(12, 32);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(54, 48);
            this.btnX.TabIndex = 0;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = false;
            // 
            // btnKuzey
            // 
            this.btnKuzey.Location = new System.Drawing.Point(385, 239);
            this.btnKuzey.Name = "btnKuzey";
            this.btnKuzey.Size = new System.Drawing.Size(46, 49);
            this.btnKuzey.TabIndex = 1;
            this.btnKuzey.Text = "Kuzey";
            this.btnKuzey.UseVisualStyleBackColor = true;
            this.btnKuzey.Click += new System.EventHandler(this.btnKuzey_Click);
            // 
            // btnKuzeyDogu
            // 
            this.btnKuzeyDogu.Location = new System.Drawing.Point(437, 239);
            this.btnKuzeyDogu.Name = "btnKuzeyDogu";
            this.btnKuzeyDogu.Size = new System.Drawing.Size(47, 49);
            this.btnKuzeyDogu.TabIndex = 2;
            this.btnKuzeyDogu.Text = "Kuzey Doğu";
            this.btnKuzeyDogu.UseVisualStyleBackColor = true;
            this.btnKuzeyDogu.Click += new System.EventHandler(this.btnKuzeyDogu_Click);
            // 
            // btnDogu
            // 
            this.btnDogu.Location = new System.Drawing.Point(437, 294);
            this.btnDogu.Name = "btnDogu";
            this.btnDogu.Size = new System.Drawing.Size(47, 49);
            this.btnDogu.TabIndex = 3;
            this.btnDogu.Text = "Doğu";
            this.btnDogu.UseVisualStyleBackColor = true;
            this.btnDogu.Click += new System.EventHandler(this.btnDogu_Click);
            // 
            // btnGuneyDogu
            // 
            this.btnGuneyDogu.Location = new System.Drawing.Point(437, 349);
            this.btnGuneyDogu.Name = "btnGuneyDogu";
            this.btnGuneyDogu.Size = new System.Drawing.Size(47, 45);
            this.btnGuneyDogu.TabIndex = 4;
            this.btnGuneyDogu.Text = "Güney Doğu";
            this.btnGuneyDogu.UseVisualStyleBackColor = true;
            this.btnGuneyDogu.Click += new System.EventHandler(this.btnGuneyDogu_Click);
            // 
            // btnGuney
            // 
            this.btnGuney.Location = new System.Drawing.Point(385, 349);
            this.btnGuney.Name = "btnGuney";
            this.btnGuney.Size = new System.Drawing.Size(46, 45);
            this.btnGuney.TabIndex = 5;
            this.btnGuney.Text = "Güney";
            this.btnGuney.UseVisualStyleBackColor = true;
            this.btnGuney.Click += new System.EventHandler(this.btnGuney_Click);
            // 
            // btnGuneyBati
            // 
            this.btnGuneyBati.Location = new System.Drawing.Point(332, 349);
            this.btnGuneyBati.Name = "btnGuneyBati";
            this.btnGuneyBati.Size = new System.Drawing.Size(47, 45);
            this.btnGuneyBati.TabIndex = 6;
            this.btnGuneyBati.Text = "Günay Batı";
            this.btnGuneyBati.UseVisualStyleBackColor = true;
            this.btnGuneyBati.Click += new System.EventHandler(this.btnGuneyBati_Click);
            // 
            // btnBati
            // 
            this.btnBati.Location = new System.Drawing.Point(332, 294);
            this.btnBati.Name = "btnBati";
            this.btnBati.Size = new System.Drawing.Size(46, 49);
            this.btnBati.TabIndex = 7;
            this.btnBati.Text = "Batı";
            this.btnBati.UseVisualStyleBackColor = true;
            this.btnBati.Click += new System.EventHandler(this.btnBati_Click);
            // 
            // btnKuzeyBati
            // 
            this.btnKuzeyBati.Location = new System.Drawing.Point(331, 239);
            this.btnKuzeyBati.Name = "btnKuzeyBati";
            this.btnKuzeyBati.Size = new System.Drawing.Size(47, 49);
            this.btnKuzeyBati.TabIndex = 8;
            this.btnKuzeyBati.Text = "Kuzey Batı";
            this.btnKuzeyBati.UseVisualStyleBackColor = true;
            this.btnKuzeyBati.Click += new System.EventHandler(this.btnKuzeyBati_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Dur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 442);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnKuzeyBati);
            this.Controls.Add(this.btnBati);
            this.Controls.Add(this.btnGuneyBati);
            this.Controls.Add(this.btnGuney);
            this.Controls.Add(this.btnGuneyDogu);
            this.Controls.Add(this.btnDogu);
            this.Controls.Add(this.btnKuzeyDogu);
            this.Controls.Add(this.btnKuzey);
            this.Controls.Add(this.btnX);
            this.ForeColor = System.Drawing.Color.Crimson;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnKuzey;
        private System.Windows.Forms.Button btnKuzeyDogu;
        private System.Windows.Forms.Button btnDogu;
        private System.Windows.Forms.Button btnGuneyDogu;
        private System.Windows.Forms.Button btnGuney;
        private System.Windows.Forms.Button btnGuneyBati;
        private System.Windows.Forms.Button btnBati;
        private System.Windows.Forms.Button btnKuzeyBati;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}

