namespace _04082017
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
            this.txtli = new System.Windows.Forms.TextBox();
            this.listli = new System.Windows.Forms.ListBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.btntemiz = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtli
            // 
            this.txtli.Location = new System.Drawing.Point(12, 24);
            this.txtli.Name = "txtli";
            this.txtli.Size = new System.Drawing.Size(100, 20);
            this.txtli.TabIndex = 0;
            this.txtli.TextChanged += new System.EventHandler(this.txtli_TextChanged);
            // 
            // listli
            // 
            this.listli.FormattingEnabled = true;
            this.listli.Location = new System.Drawing.Point(152, 11);
            this.listli.Name = "listli";
            this.listli.Size = new System.Drawing.Size(120, 238);
            this.listli.TabIndex = 1;
            this.listli.SelectedIndexChanged += new System.EventHandler(this.listli_SelectedIndexChanged);
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(12, 50);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(100, 23);
            this.btnekle.TabIndex = 2;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btntemiz
            // 
            this.btntemiz.Location = new System.Drawing.Point(13, 80);
            this.btntemiz.Name = "btntemiz";
            this.btntemiz.Size = new System.Drawing.Size(99, 28);
            this.btntemiz.TabIndex = 3;
            this.btntemiz.Text = "ÇIKAR";
            this.btntemiz.UseVisualStyleBackColor = true;
            this.btntemiz.Click += new System.EventHandler(this.btntemiz_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 53);
            this.button1.TabIndex = 4;
            this.button1.Text = "TÜMÜNÜ TEMİZLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btntemiz);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.listli);
            this.Controls.Add(this.txtli);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtli;
        private System.Windows.Forms.ListBox listli;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btntemiz;
        private System.Windows.Forms.Button button1;
    }
}