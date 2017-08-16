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
    public partial class Form2 : Form
    {
        public double FiyatHesapla() 
        {
            double fiyat = 0;

            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    fiyat = fiyat + 300;
                    int adet1 = 20;
                    label10.Text = adet1.ToString();
                    textBox1.Text = fiyat.ToString();
                   
                    break;
                case 1:
                    fiyat = fiyat + 500;
                    int adet2 = 15;
                   
                    label10.Text = adet2.ToString();
                    textBox1.Text = fiyat.ToString();
                    break;
                case 2:
                    fiyat = fiyat + 700;
                    int adet3 = 10;
                    label10.Text = adet3.ToString();

                    textBox1.Text = fiyat.ToString();
                    break;
            }
            return fiyat;
            double pesinat=0;
            pesinat = Convert.ToDouble(textBox3.Text.ToString());
            textBox5.Text = (fiyat-pesinat).ToString();
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        
            FiyatHesapla();
      
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                comboBox2.Items.Add("ÜRÜN 1 A");
                comboBox2.Items.Add("ÜRÜN 1 B");
                comboBox2.Items.Add("ÜRÜN 1 C");
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                comboBox2.Items.Add("ÜRÜN 2 A");
                comboBox2.Items.Add("ÜRÜN 2 B");
                comboBox2.Items.Add("ÜRÜN 2 C");
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                comboBox2.Items.Add("ÜRÜN 3 A");
                comboBox2.Items.Add("ÜRÜN 3 B");
                comboBox2.Items.Add("ÜRÜN 3 C");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FiyatHesapla();
            int a, b, c;
            
            a = Convert.ToInt32(textBox1.Text.ToString());
            b = Convert.ToInt32(textBox3.Text.ToString());
            c = a - b;
            double taksit = Convert.ToDouble(comboBox3.Text);
            textBox4.Text = (c / taksit).ToString();
            textBox5.Text = c.ToString();
           
     
            label11.Text = textBox2.Text.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int k, m,n;
            k = Convert.ToInt32(textBox2.Text);
            m = Convert.ToInt32(label10.Text);
            n = m - k;
            label10.Text = n.ToString();
        }
    }
}
