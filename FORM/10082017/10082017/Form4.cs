using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10082017
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public void AlanHesapla(int a, int b)
        {
            int sonuc = a * b;
            MessageBox.Show(sonuc.ToString());

        }
        private void button1_Click(object sender, EventArgs e)
        {
           int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            AlanHesapla(a,b);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
