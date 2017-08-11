namespace _11082017
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btntopla = new System.Windows.Forms.Button();
            this.btncikar = new System.Windows.Forms.Button();
            this.btncarp = new System.Windows.Forms.Button();
            this.btnbol = new System.Windows.Forms.Button();
            this.btnust = new System.Windows.Forms.Button();
            this.btnfaktoriyel = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(56, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btntopla
            // 
            this.btntopla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntopla.Location = new System.Drawing.Point(12, 34);
            this.btntopla.Name = "btntopla";
            this.btntopla.Size = new System.Drawing.Size(56, 23);
            this.btntopla.TabIndex = 1;
            this.btntopla.Text = "+";
            this.btntopla.UseVisualStyleBackColor = true;
            this.btntopla.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncikar
            // 
            this.btncikar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncikar.Location = new System.Drawing.Point(74, 34);
            this.btncikar.Name = "btncikar";
            this.btncikar.Size = new System.Drawing.Size(52, 23);
            this.btncikar.TabIndex = 2;
            this.btncikar.Text = "-";
            this.btncikar.UseVisualStyleBackColor = true;
            this.btncikar.Click += new System.EventHandler(this.btncikar_Click);
            // 
            // btncarp
            // 
            this.btncarp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncarp.Location = new System.Drawing.Point(12, 63);
            this.btncarp.Name = "btncarp";
            this.btncarp.Size = new System.Drawing.Size(56, 23);
            this.btncarp.TabIndex = 3;
            this.btncarp.Text = "x";
            this.btncarp.UseVisualStyleBackColor = true;
            this.btncarp.Click += new System.EventHandler(this.btncarp_Click);
            // 
            // btnbol
            // 
            this.btnbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbol.Location = new System.Drawing.Point(74, 63);
            this.btnbol.Name = "btnbol";
            this.btnbol.Size = new System.Drawing.Size(52, 23);
            this.btnbol.TabIndex = 4;
            this.btnbol.Text = "/";
            this.btnbol.UseVisualStyleBackColor = true;
            this.btnbol.Click += new System.EventHandler(this.btnbol_Click);
            // 
            // btnust
            // 
            this.btnust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnust.Location = new System.Drawing.Point(12, 92);
            this.btnust.Name = "btnust";
            this.btnust.Size = new System.Drawing.Size(56, 23);
            this.btnust.TabIndex = 5;
            this.btnust.Text = "^2";
            this.btnust.UseVisualStyleBackColor = true;
            this.btnust.Click += new System.EventHandler(this.btnust_Click);
            // 
            // btnfaktoriyel
            // 
            this.btnfaktoriyel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnfaktoriyel.Location = new System.Drawing.Point(74, 92);
            this.btnfaktoriyel.Name = "btnfaktoriyel";
            this.btnfaktoriyel.Size = new System.Drawing.Size(52, 23);
            this.btnfaktoriyel.TabIndex = 6;
            this.btnfaktoriyel.Text = "!";
            this.btnfaktoriyel.UseVisualStyleBackColor = true;
            this.btnfaktoriyel.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(74, 8);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(51, 20);
            this.textBox2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "                               ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(156, 150);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnfaktoriyel);
            this.Controls.Add(this.btnust);
            this.Controls.Add(this.btnbol);
            this.Controls.Add(this.btncarp);
            this.Controls.Add(this.btncikar);
            this.Controls.Add(this.btntopla);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btntopla;
        private System.Windows.Forms.Button btncikar;
        private System.Windows.Forms.Button btncarp;
        private System.Windows.Forms.Button btnbol;
        private System.Windows.Forms.Button btnust;
        private System.Windows.Forms.Button btnfaktoriyel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
    }
}

