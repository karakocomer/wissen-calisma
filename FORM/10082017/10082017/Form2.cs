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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }/*int a, b,sonuc;*/
        public void Hesapla()
        {
            int a, b, sonuc;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            sonuc = a * b;
            label1.Text = sonuc.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             Hesapla();
            //a = Convert.ToInt32(textBox1.Text);
            //b = Convert.ToInt32(textBox2.Text);
            //sonuc = a * b;
            //label1.Text = sonuc.ToString();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
