using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08082017
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi1, sayi2;

                sayi1 = Convert.ToInt32(textBox1.Text);
                sayi2 = Convert.ToInt32(textBox2.Text);
                MessageBox.Show("sayıların toplamı = " + (sayi1 + sayi2));

            }
            catch (Exception hataTuru)
            {

                MessageBox.Show(" Lütfen sayı giriniz. " +hataTuru);
            } 
        }
    }
}
