using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11082017
{
   
    public partial class Form1 : Form
    {
        public void sayi1()
        {
            double sayi1 = Convert.ToDouble(textBox1.Text);
           
    }
        public void sayi2()
        {
            double sayi2 = Convert.ToDouble(textBox2.Text);
        }
        public double  topla(double x, double y)
        { double toplam = x + y;
            return toplam;
        }
        public double carpim(double x, double y)
        {
            double carpim = x * y;
            return carpim;
        }
        public double bolum(double x, double y)
        {
            double bolum = x / y;
            return bolum;
        }
        public double fark(double x, double y)
        {
            double fark = x - y;
            return fark;
        }
        public double ustu(double x, double y)
        {
            double ustu = Math.Pow(x, y);
            return ustu;
        }
        public int faktoriyel(int x)
        {
            int fakt = 1;
            for (int i = 1; i <= x; i++)
            {
                fakt = fakt * i;
            }
            return fakt;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = topla(Convert.ToDouble(textBox1.Text),
              Convert.ToDouble(textBox2.Text)).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //double x = Convert.ToDouble(textBox1.Text);
            //double faktsonuc = faktoriyel(x);
            label1.Text = faktoriyel(Convert.ToInt32(textBox1.Text)).ToString();
        }

        private void btncikar_Click(object sender, EventArgs e)
        {
            label1.Text = fark(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)).ToString();
        }

        private void btncarp_Click(object sender, EventArgs e)
        {
            label1.Text = carpim(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)).ToString();
        }

        private void btnbol_Click(object sender, EventArgs e)
        {
            label1.Text = bolum(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)).ToString();
        }

        private void btnust_Click(object sender, EventArgs e)
        {

            label1.Text = ustu(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)).ToString();
        }
    }
}
