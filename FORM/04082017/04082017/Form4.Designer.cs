namespace _04082017
{
    partial class Form4
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
            this.button1 = new System.Windows.Forms.Button();
            this.btntemiz = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.listli = new System.Windows.Forms.ListBox();
            this.txtli = new System.Windows.Forms.TextBox();
            this.soldansaga = new System.Windows.Forms.Button();
            this.sagdansola = new System.Windows.Forms.Button();
            this.listsag = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 53);
            this.button1.TabIndex = 9;
            this.button1.Text = "TÜMÜNÜ TEMİZLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btntemiz
            // 
            this.btntemiz.Location = new System.Drawing.Point(15, 97);
            this.btntemiz.Name = "btntemiz";
            this.btntemiz.Size = new System.Drawing.Size(99, 28);
            this.btntemiz.TabIndex = 8;
            this.btntemiz.Text = "ÇIKAR";
            this.btntemiz.UseVisualStyleBackColor = true;
            this.btntemiz.Click += new System.EventHandler(this.btntemiz_Click);
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(14, 67);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(100, 23);
            this.btnekle.TabIndex = 7;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // listli
            // 
            this.listli.FormattingEnabled = true;
            this.listli.Location = new System.Drawing.Point(154, 28);
            this.listli.Name = "listli";
            this.listli.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listli.Size = new System.Drawing.Size(120, 238);
            this.listli.TabIndex = 6;
            // 
            // txtli
            // 
            this.txtli.Location = new System.Drawing.Point(14, 41);
            this.txtli.Name = "txtli";
            this.txtli.Size = new System.Drawing.Size(100, 20);
            this.txtli.TabIndex = 5;
            // 
            // soldansaga
            // 
            this.soldansaga.Location = new System.Drawing.Point(338, 67);
            this.soldansaga.Name = "soldansaga";
            this.soldansaga.Size = new System.Drawing.Size(75, 23);
            this.soldansaga.TabIndex = 10;
            this.soldansaga.Text = ">>>";
            this.soldansaga.UseVisualStyleBackColor = true;
            this.soldansaga.Click += new System.EventHandler(this.soldansaga_Click);
            // 
            // sagdansola
            // 
            this.sagdansola.Location = new System.Drawing.Point(338, 161);
            this.sagdansola.Name = "sagdansola";
            this.sagdansola.Size = new System.Drawing.Size(75, 23);
            this.sagdansola.TabIndex = 11;
            this.sagdansola.Text = "<<<";
            this.sagdansola.UseVisualStyleBackColor = true;
            this.sagdansola.Click += new System.EventHandler(this.sagdansola_Click);
            // 
            // listsag
            // 
            this.listsag.FormattingEnabled = true;
            this.listsag.Location = new System.Drawing.Point(471, 28);
            this.listsag.Name = "listsag";
            this.listsag.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listsag.Size = new System.Drawing.Size(120, 238);
            this.listsag.TabIndex = 12;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 329);
            this.Controls.Add(this.listsag);
            this.Controls.Add(this.sagdansola);
            this.Controls.Add(this.soldansaga);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btntemiz);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.listli);
            this.Controls.Add(this.txtli);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btntemiz;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.ListBox listli;
        private System.Windows.Forms.TextBox txtli;
        private System.Windows.Forms.Button soldansaga;
        private System.Windows.Forms.Button sagdansola;
        private System.Windows.Forms.ListBox listsag;
    }
}