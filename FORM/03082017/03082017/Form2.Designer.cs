namespace _03082017
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtedn = new System.Windows.Forms.TextBox();
            this.txteda = new System.Windows.Forms.TextBox();
            this.txteyn = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txteya = new System.Windows.Forms.TextBox();
            this.enyuksekalan = new System.Windows.Forms.Label();
            this.lblenyukseknot = new System.Windows.Forms.Label();
            this.lblendusukalan = new System.Windows.Forms.Label();
            this.txtendusuk = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtedn
            // 
            this.txtedn.Location = new System.Drawing.Point(172, 166);
            this.txtedn.Name = "txtedn";
            this.txtedn.Size = new System.Drawing.Size(100, 20);
            this.txtedn.TabIndex = 1;
            this.txtedn.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txteda
            // 
            this.txteda.Location = new System.Drawing.Point(172, 118);
            this.txteda.Name = "txteda";
            this.txteda.Size = new System.Drawing.Size(100, 20);
            this.txteda.TabIndex = 2;
            this.txteda.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txteyn
            // 
            this.txteyn.Location = new System.Drawing.Point(172, 80);
            this.txteyn.Name = "txteyn";
            this.txteyn.Size = new System.Drawing.Size(100, 20);
            this.txteyn.TabIndex = 3;
            this.txteyn.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(172, 38);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 0;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txteya
            // 
            this.txteya.Location = new System.Drawing.Point(172, 38);
            this.txteya.Name = "txteya";
            this.txteya.Size = new System.Drawing.Size(100, 20);
            this.txteya.TabIndex = 0;
            this.txteya.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // enyuksekalan
            // 
            this.enyuksekalan.AutoSize = true;
            this.enyuksekalan.Location = new System.Drawing.Point(12, 45);
            this.enyuksekalan.Name = "enyuksekalan";
            this.enyuksekalan.Size = new System.Drawing.Size(80, 13);
            this.enyuksekalan.TabIndex = 4;
            this.enyuksekalan.Text = "En yüksek alan";
            // 
            // lblenyukseknot
            // 
            this.lblenyukseknot.AutoSize = true;
            this.lblenyukseknot.Location = new System.Drawing.Point(12, 87);
            this.lblenyukseknot.Name = "lblenyukseknot";
            this.lblenyukseknot.Size = new System.Drawing.Size(75, 13);
            this.lblenyukseknot.TabIndex = 5;
            this.lblenyukseknot.Text = "En yüksek not";
            // 
            // lblendusukalan
            // 
            this.lblendusukalan.AutoSize = true;
            this.lblendusukalan.Location = new System.Drawing.Point(12, 125);
            this.lblendusukalan.Name = "lblendusukalan";
            this.lblendusukalan.Size = new System.Drawing.Size(75, 13);
            this.lblendusukalan.TabIndex = 6;
            this.lblendusukalan.Text = "En düşük alan";
            // 
            // txtendusuk
            // 
            this.txtendusuk.AutoSize = true;
            this.txtendusuk.Location = new System.Drawing.Point(12, 173);
            this.txtendusuk.Name = "txtendusuk";
            this.txtendusuk.Size = new System.Drawing.Size(70, 13);
            this.txtendusuk.TabIndex = 7;
            this.txtendusuk.Text = "En düşük not";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtendusuk);
            this.Controls.Add(this.lblendusukalan);
            this.Controls.Add(this.lblenyukseknot);
            this.Controls.Add(this.enyuksekalan);
            this.Controls.Add(this.txteyn);
            this.Controls.Add(this.txteda);
            this.Controls.Add(this.txtedn);
            this.Controls.Add(this.txteya);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtedn;
        private System.Windows.Forms.TextBox txteda;
        private System.Windows.Forms.TextBox txteyn;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txteya;
        private System.Windows.Forms.Label enyuksekalan;
        private System.Windows.Forms.Label lblenyukseknot;
        private System.Windows.Forms.Label lblendusukalan;
        private System.Windows.Forms.Label txtendusuk;
    }
}