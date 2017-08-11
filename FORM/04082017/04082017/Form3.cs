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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            listli.Items.Add(txtli.Text);
            txtli.Clear();
        }

        private void btntemiz_Click(object sender, EventArgs e)
        {
            listli.Items.Remove(listli.SelectedItem);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listli.Items.Clear();
        }

        private void listli_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtli_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
