using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14082017
{
    public partial class Form1 : Form
    {
        Form2 frm = new Form2();
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text.ToLower();
            if (textBox1.Text=="omerkarakoc")
            {
                MessageBox.Show("Giriş Başarılı");
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlış giriş denemesi");
            }
        }
    }
}
