using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04082017
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int k = 100; k <= 0; k--)
            {
                listbox.Items.Add(k);
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                listbox.Items.Add(i);
            }
        }
    }
}
