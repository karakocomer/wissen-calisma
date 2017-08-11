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
    public partial class hesapmakinesimetod : Form
    {
        public hesapmakinesimetod()
        {
            InitializeComponent();
        }
        public void Toplam()
        {
            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);
            int sonuc = x + y;
            label4.Text = sonuc.ToString();
        }
        public void Fark()
        {
            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);
            int sonuc = x - y;
            label4.Text = sonuc.ToString();
        }
        public void Carpim()
        {
            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);
            int sonuc = x * y;
            label4.Text = sonuc.ToString();

        }
        public void Bolum()
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            double sonuc = x / y;
            label4.Text = sonuc.ToString();
        }
        public void Temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            label4.Text = "";
        }
       
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void hesapmakinesimetod_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Toplam();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fark();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Carpim();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bolum();
        }
    }
}
