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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public void Hesapla()
        {
            int a, b, sonuc;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            sonuc = a * b;
            label1.Text = sonuc.ToString();
            listBox1.Items.Add(sonuc);
            
            Temizle();
            checkBox1.Checked = true;

        }
        public void Temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            listBox1.Items.Clear();
            checkBox1.Checked = false;
            


        }


        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hesapla();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
