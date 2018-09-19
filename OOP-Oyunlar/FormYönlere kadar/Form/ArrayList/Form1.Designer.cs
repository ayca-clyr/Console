namespace ArrayListt
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnIsFixedSize = new System.Windows.Forms.Button();
            this.btnInser = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnContains = new System.Windows.Forms.Button();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtBxAd = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(27, 55);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 32);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(27, 96);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 31);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(27, 136);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 34);
            this.btnCount.TabIndex = 2;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnIsFixedSize
            // 
            this.btnIsFixedSize.Location = new System.Drawing.Point(27, 179);
            this.btnIsFixedSize.Name = "btnIsFixedSize";
            this.btnIsFixedSize.Size = new System.Drawing.Size(75, 34);
            this.btnIsFixedSize.TabIndex = 3;
            this.btnIsFixedSize.Text = "IsFixedSize";
            this.btnIsFixedSize.UseVisualStyleBackColor = true;
            this.btnIsFixedSize.Click += new System.EventHandler(this.btnIsFixedSize_Click);
            // 
            // btnInser
            // 
            this.btnInser.Location = new System.Drawing.Point(27, 264);
            this.btnInser.Name = "btnInser";
            this.btnInser.Size = new System.Drawing.Size(75, 28);
            this.btnInser.TabIndex = 4;
            this.btnInser.Text = "Insert";
            this.btnInser.UseVisualStyleBackColor = true;
            this.btnInser.Click += new System.EventHandler(this.btnInser_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(27, 301);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 31);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(27, 222);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 33);
            this.btnSort.TabIndex = 6;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnContains
            // 
            this.btnContains.Location = new System.Drawing.Point(27, 341);
            this.btnContains.Name = "btnContains";
            this.btnContains.Size = new System.Drawing.Size(75, 31);
            this.btnContains.TabIndex = 7;
            this.btnContains.Text = "Contains";
            this.btnContains.UseVisualStyleBackColor = true;
            this.btnContains.Click += new System.EventHandler(this.btnContains_Click);
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(24, 26);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(20, 13);
            this.lblAd.TabIndex = 8;
            this.lblAd.Text = "Ad";
            // 
            // txtBxAd
            // 
            this.txtBxAd.Location = new System.Drawing.Point(73, 19);
            this.txtBxAd.Name = "txtBxAd";
            this.txtBxAd.Size = new System.Drawing.Size(100, 20);
            this.txtBxAd.TabIndex = 9;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(436, 55);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(288, 316);
            this.listBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 442);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtBxAd);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.btnContains);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnInser);
            this.Controls.Add(this.btnIsFixedSize);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnIsFixedSize;
        private System.Windows.Forms.Button btnInser;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnContains;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtBxAd;
        private System.Windows.Forms.ListBox listBox1;
    }
}

