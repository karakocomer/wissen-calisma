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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                listBox1.Items.Add("ilkbajar");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("mevsimler");
            comboBox1.Items.Add("yaz");
            comboBox1.Items.Add("kış");
            comboBox1.Items.Add("ilkbahar");
            comboBox1.Items.Add("sonbahar");


            // selectedindex i kullanabiliyoruz yine dizi mantığıyla çalışıyor 0,eleman 1.eleman oluyor
        }
    }
}
