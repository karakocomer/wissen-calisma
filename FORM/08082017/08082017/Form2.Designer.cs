namespace _08082017
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
            this.btnmasraf = new System.Windows.Forms.Button();
            this.btncari = new System.Windows.Forms.Button();
            this.btnstok = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnmasraf
            // 
            this.btnmasraf.Location = new System.Drawing.Point(438, 121);
            this.btnmasraf.Name = "btnmasraf";
            this.btnmasraf.Size = new System.Drawing.Size(97, 69);
            this.btnmasraf.TabIndex = 5;
            this.btnmasraf.Text = "masraf";
            this.btnmasraf.UseVisualStyleBackColor = true;
            // 
            // btncari
            // 
            this.btncari.Location = new System.Drawing.Point(265, 121);
            this.btncari.Name = "btncari";
            this.btncari.Size = new System.Drawing.Size(88, 69);
            this.btncari.TabIndex = 4;
            this.btncari.Text = "cari";
            this.btncari.UseVisualStyleBackColor = true;
            // 
            // btnstok
            // 
            this.btnstok.Location = new System.Drawing.Point(85, 121);
            this.btnstok.Name = "btnstok";
            this.btnstok.Size = new System.Drawing.Size(94, 69);
            this.btnstok.TabIndex = 3;
            this.btnstok.Text = "stok";
            this.btnstok.UseVisualStyleBackColor = true;
            this.btnstok.Click += new System.EventHandler(this.btnstok_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(51, 22);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 330);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnmasraf);
            this.Controls.Add(this.btncari);
            this.Controls.Add(this.btnstok);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnmasraf;
        private System.Windows.Forms.Button btncari;
        private System.Windows.Forms.Button btnstok;
        public System.Windows.Forms.TextBox textBox1;
    }
}