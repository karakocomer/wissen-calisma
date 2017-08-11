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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        double Hesapla(double x, double y, string islem)
        {

            double sonuc = 0;
            switch (islem)
            {
                case "+":
                    sonuc = x + y;
                    break;
                case "-":
                    sonuc = x - y;
                    break;
                case "/":
                    sonuc = x / y;
                    break;
                case "*":
                    sonuc = x * y;
                    break;
                default:
                    MessageBox.Show("dogru işlem girilemedi");
                    break;
            }
            return sonuc;
        }
        double KareAl(double x, double y)
        {
            double sonuc = Math.Pow(x, y);
            return sonuc;
        }
        double Fakt(double x)
        {
            double sonuc = 1;
            for (int i = 1; i <= x; i++)
            {
                sonuc = sonuc * i;
            }
            return sonuc;
        }

        private void btntopla_Click(object sender, EventArgs e)
        {
            double x = Convert.ToInt32(textBox1.Text);
            double y = Convert.ToInt32(textBox2.Text);
            textBox3.Text = Hesapla(x, y, "+").ToString();
        }

        private void btncikar_Click(object sender, EventArgs e)
        {
            double x = Convert.ToInt32(textBox1.Text);
            double y = Convert.ToInt32(textBox2.Text);
            textBox3.Text = Hesapla(x, y, "-").ToString();
        }

        private void btnbol_Click(object sender, EventArgs e)
        {
            double x = Convert.ToInt32(textBox1.Text);
            double y = Convert.ToInt32(textBox2.Text);
            textBox3.Text = Hesapla(x, y, "/").ToString();
        }

        private void btncarp_Click(object sender, EventArgs e)
        {
            double x = Convert.ToInt32(textBox1.Text);
            double y = Convert.ToInt32(textBox2.Text);
            textBox3.Text = Hesapla(x, y, "*").ToString();
        }

        private void btnust_Click(object sender, EventArgs e)
        {

            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            textBox3.Text = KareAl(a, b).ToString();
        }

        private void btnfaktoriyel_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            textBox3.Text = Fakt(a).ToString();
        }
    }
        }
    

