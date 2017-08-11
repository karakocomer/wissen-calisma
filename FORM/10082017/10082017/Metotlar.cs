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
    public partial class Metotlar : Form
    {
        public Metotlar()
        {
            InitializeComponent();
        }

        private void Metotlar_Load(object sender, EventArgs e)
        {
            
        }
        static void MerhabaYaz()
        {
            MessageBox.Show("Merhabaaa");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MerhabaYaz();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MerhabaYaz();
        }
    }
}
