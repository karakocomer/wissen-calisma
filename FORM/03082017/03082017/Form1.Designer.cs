namespace _03082017
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
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.btnbuton = new System.Windows.Forms.Button();
            this.lblSayi1 = new System.Windows.Forms.Label();
            this.lblSayi2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSayi1
            // 
            this.txtSayi1.Location = new System.Drawing.Point(69, 13);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(100, 20);
            this.txtSayi1.TabIndex = 0;
            // 
            // txtSayi2
            // 
            this.txtSayi2.Location = new System.Drawing.Point(69, 54);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(100, 20);
            this.txtSayi2.TabIndex = 1;
            // 
            // btnbuton
            // 
            this.btnbuton.Location = new System.Drawing.Point(137, 145);
            this.btnbuton.Name = "btnbuton";
            this.btnbuton.Size = new System.Drawing.Size(75, 23);
            this.btnbuton.TabIndex = 2;
            this.btnbuton.Text = "Hesapla";
            this.btnbuton.UseVisualStyleBackColor = true;
            this.btnbuton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblSayi1
            // 
            this.lblSayi1.AutoSize = true;
            this.lblSayi1.Location = new System.Drawing.Point(6, 16);
            this.lblSayi1.Name = "lblSayi1";
            this.lblSayi1.Size = new System.Drawing.Size(33, 13);
            this.lblSayi1.TabIndex = 3;
            this.lblSayi1.Text = "Sayı1";
            this.lblSayi1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSayi2
            // 
            this.lblSayi2.AutoSize = true;
            this.lblSayi2.Location = new System.Drawing.Point(6, 61);
            this.lblSayi2.Name = "lblSayi2";
            this.lblSayi2.Size = new System.Drawing.Size(33, 13);
            this.lblSayi2.TabIndex = 4;
            this.lblSayi2.Text = "Sayı2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSayi1);
            this.groupBox1.Controls.Add(this.lblSayi2);
            this.groupBox1.Controls.Add(this.txtSayi2);
            this.groupBox1.Controls.Add(this.txtSayi1);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 118);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "hebelehubele";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 189);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnbuton);
            this.Name = "Form1";
            this.Text = "Ortalama Hesaplama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.Button btnbuton;
        private System.Windows.Forms.Label lblSayi1;
        private System.Windows.Forms.Label lblSayi2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

