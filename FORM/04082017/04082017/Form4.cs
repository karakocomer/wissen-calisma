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
    public partial class Form4 : Form
    {
        public Form4()
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
            listsag.Items.Clear();
        }

        private void soldansaga_Click(object sender, EventArgs e)
        {
            //listsag.Items.Add(listli.SelectedItem);
            //listli.Items.Remove(listli.SelectedItem);
            for (int i = listli.SelectedIndices.Count-1; i>=0 ; i--)
            {
                listsag.Items.Add(listli.SelectedItems[i]);
                listli.Items.RemoveAt(listli.SelectedIndices[i]);
                listsag.Sorted = true; // soldan saga aktarırken ters çevirip atmsını engelliyor.
            }

        }

        private void sagdansola_Click(object sender, EventArgs e)
        {
            for (int k = listsag.SelectedIndices.Count-1; k>=0 ; k--)
            {
                listli.Items.Add(listsag.SelectedItems[k]);
                listsag.Items.RemoveAt(listsag.SelectedIndices[k]); // indis oldugu için remove değil removeAT olacak
                listli.Sorted = true;
            }
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
