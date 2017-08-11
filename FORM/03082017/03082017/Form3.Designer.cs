namespace _03082017
{
    partial class Form3
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
            this.txtgun = new System.Windows.Forms.TextBox();
            this.txtsayi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblsayi = new System.Windows.Forms.Label();
            this.lblgun = new System.Windows.Forms.Label();
            this.chcbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtgun
            // 
            this.txtgun.Location = new System.Drawing.Point(172, 61);
            this.txtgun.Name = "txtgun";
            this.txtgun.ReadOnly = true;
            this.txtgun.Size = new System.Drawing.Size(100, 20);
            this.txtgun.TabIndex = 0;
            // 
            // txtsayi
            // 
            this.txtsayi.Location = new System.Drawing.Point(12, 61);
            this.txtsayi.Name = "txtsayi";
            this.txtsayi.Size = new System.Drawing.Size(100, 20);
            this.txtsayi.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Kaçıncı Gün";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblsayi
            // 
            this.lblsayi.AutoSize = true;
            this.lblsayi.Location = new System.Drawing.Point(46, 45);
            this.lblsayi.Name = "lblsayi";
            this.lblsayi.Size = new System.Drawing.Size(27, 13);
            this.lblsayi.TabIndex = 3;
            this.lblsayi.Text = "Sayı";
            // 
            // lblgun
            // 
            this.lblgun.AutoSize = true;
            this.lblgun.Location = new System.Drawing.Point(204, 45);
            this.lblgun.Name = "lblgun";
            this.lblgun.Size = new System.Drawing.Size(27, 13);
            this.lblgun.TabIndex = 4;
            this.lblgun.Text = "Gün";
            // 
            // chcbox
            // 
            this.chcbox.AutoSize = true;
            this.chcbox.Location = new System.Drawing.Point(97, 183);
            this.chcbox.Name = "chcbox";
            this.chcbox.Size = new System.Drawing.Size(72, 17);
            this.chcbox.TabIndex = 5;
            this.chcbox.Text = "tıkla bana";
            this.chcbox.UseVisualStyleBackColor = true;
            this.chcbox.CheckedChanged += new System.EventHandler(this.chcbox_CheckedChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.chcbox);
            this.Controls.Add(this.lblgun);
            this.Controls.Add(this.lblsayi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtsayi);
            this.Controls.Add(this.txtgun);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtgun;
        private System.Windows.Forms.TextBox txtsayi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblsayi;
        private System.Windows.Forms.Label lblgun;
        private System.Windows.Forms.CheckBox chcbox;
    }
}