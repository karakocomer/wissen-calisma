using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07082017
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
      double sayi1, sayi2;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);
            if (comboBox1.SelectedIndex == 0)
            {
                lblsonuc.Text = (sayi1 + sayi2).ToString();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                if (sayi1 > sayi2)
                {
                    lblsonuc.Text = (sayi1 - sayi2).ToString();
                }
                else
	{
                    lblsonuc.Text = (sayi2 - sayi1).ToString();
                }
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                lblsonuc.Text = (sayi1 * sayi2).ToString();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                lblsonuc.Text = (sayi1 / sayi2).ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
