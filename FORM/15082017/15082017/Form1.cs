using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15082017
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] Sehirdizi = { "antalya","istanbul","izmir","muş","a" };

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string b = textBox1.Text.ToLower();
            int c = 0;

            foreach (var i in Sehirdizi)
            {
                if (i == b)
                {
                    MessageBox.Show("güzel tercih");
                    c = 1;
                    break;
                }      
            }
            if (c==0)
            {
                MessageBox.Show("kötü tercih");
            }
        }
    }
}
