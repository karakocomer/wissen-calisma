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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label5.Text = comboBox1.SelectedItem.ToString() +  comboBox2.SelectedItem.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            if (comboBox1.SelectedIndex == 0)
            {
                comboBox2.Items.Add("A1 modeli");
                comboBox2.Items.Add("A2 modeli");
                comboBox2.Items.Add("A3 modeli");
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                comboBox2.Items.Add("B1 modeli");
                comboBox2.Items.Add("B2 modeli");
                comboBox2.Items.Add("B3 modeli");
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                comboBox2.Items.Add("C1 modeli");
                comboBox2.Items.Add("C2 modeli");
                comboBox2.Items.Add("C3 modeli");
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                comboBox2.Items.Add("D1 modeli");
                comboBox2.Items.Add("D2 modeli");
                comboBox2.Items.Add("D3 modeli");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
    }
