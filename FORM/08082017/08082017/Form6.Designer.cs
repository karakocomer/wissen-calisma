namespace _08082017
{
    partial class Form6
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btntoplama = new System.Windows.Forms.Button();
            this.btncikartma = new System.Windows.Forms.Button();
            this.btnbolme = new System.Windows.Forms.Button();
            this.btncarpma = new System.Windows.Forms.Button();
            this.btnc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(51, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(51, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // btntoplama
            // 
            this.btntoplama.Location = new System.Drawing.Point(51, 96);
            this.btntoplama.Name = "btntoplama";
            this.btntoplama.Size = new System.Drawing.Size(45, 40);
            this.btntoplama.TabIndex = 2;
            this.btntoplama.Text = "+";
            this.btntoplama.UseVisualStyleBackColor = true;
            this.btntoplama.Click += new System.EventHandler(this.btntoplama_Click);
            // 
            // btncikartma
            // 
            this.btncikartma.Location = new System.Drawing.Point(106, 96);
            this.btncikartma.Name = "btncikartma";
            this.btncikartma.Size = new System.Drawing.Size(45, 40);
            this.btncikartma.TabIndex = 3;
            this.btncikartma.Text = "-";
            this.btncikartma.UseVisualStyleBackColor = true;
            this.btncikartma.Click += new System.EventHandler(this.btncikartma_Click);
            // 
            // btnbolme
            // 
            this.btnbolme.Location = new System.Drawing.Point(106, 142);
            this.btnbolme.Name = "btnbolme";
            this.btnbolme.Size = new System.Drawing.Size(45, 40);
            this.btnbolme.TabIndex = 4;
            this.btnbolme.Text = "/";
            this.btnbolme.UseVisualStyleBackColor = true;
            this.btnbolme.Click += new System.EventHandler(this.btnbolme_Click);
            // 
            // btncarpma
            // 
            this.btncarpma.Location = new System.Drawing.Point(51, 142);
            this.btncarpma.Name = "btncarpma";
            this.btncarpma.Size = new System.Drawing.Size(45, 40);
            this.btncarpma.TabIndex = 5;
            this.btncarpma.Text = "X";
            this.btncarpma.UseVisualStyleBackColor = true;
            this.btncarpma.Click += new System.EventHandler(this.btncarpma_Click);
            // 
            // btnc
            // 
            this.btnc.Location = new System.Drawing.Point(157, 15);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(45, 43);
            this.btnc.TabIndex = 6;
            this.btnc.Text = "C";
            this.btnc.UseVisualStyleBackColor = true;
            this.btnc.Click += new System.EventHandler(this.btnc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "sonuç";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 327);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnc);
            this.Controls.Add(this.btncarpma);
            this.Controls.Add(this.btnbolme);
            this.Controls.Add(this.btncikartma);
            this.Controls.Add(this.btntoplama);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btntoplama;
        private System.Windows.Forms.Button btncikartma;
        private System.Windows.Forms.Button btnbolme;
        private System.Windows.Forms.Button btncarpma;
        private System.Windows.Forms.Button btnc;
        private System.Windows.Forms.Label label1;
    }
}