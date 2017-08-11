using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09082017
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (comboBox1.SelectedIndex == 0)
            {
                listBox1.Items.Add("Pilav");
                listBox1.Items.Add("Kuru");
                listBox1.Items.Add("Patlıcan");
                listBox1.Items.Add("Mantı");
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                listBox1.Items.Add("Arasıcak1");
                listBox1.Items.Add("Arasıcak2");
                listBox1.Items.Add("Arasıcak3");
                listBox1.Items.Add("Arasıcak4");
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                listBox1.Items.Add("Kola");
                listBox1.Items.Add("Fanta");
                listBox1.Items.Add("Gazoz");
                listBox1.Items.Add("Soda");
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                listBox1.Items.Add("Yulaf");
                listBox1.Items.Add("Tonbalıklı salata");
                listBox1.Items.Add("Brokoli haşlama");
                listBox1.Items.Add("Protein tozu");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
            label4.Text = (listBox2.Items.Count).ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Add(listBox2.SelectedItem);
            listBox2.Items.Remove(listBox2.SelectedItem); // sadece seçili olanı kaldırmak için remove kllan ve parantez içine de seçili olanı kaldırmasını istediğimizden dolayı seçtiğimizi kaldırmasını belirtiyoruz.
            label4.Text = (listBox2.Items.Count).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string musteriadi;
            musteriadi = textBox1.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
                if (radioButton1.Checked == true)
                {
                    listBox3.Items.Add(textBox1.Text + "  " + radioButton1.Text + " indirim ile  " + label4.Text + " ürün seçti ");
                    //throw new Exception();
                }

                else if (radioButton2.Checked == true)
                {
                    listBox3.Items.Add(textBox1.Text + "  " + radioButton2.Text + " indirim ile  " + label4.Text + " ürün seçti ");

                }
                else if (radioButton3.Checked == true)
                {
                    listBox3.Items.Add(textBox1.Text + "  " + radioButton3.Text + " indirim ile  " + label4.Text + " ürün seçti ");
                }
                else
                {
                    MessageBox.Show("Lütfen indirim miktarı seçiniz");
                }
            
            //catch (Exception)
            //{  
            //}
            //if (radioButton1.Checked == true)
            //{
            //    listBox3.Items.Add(textBox1.Text+"  " +radioButton1.Text+" indirim ile  " +label4.Text+" ürün seçti ");
            //}
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (string item in listBox1.Items)
            {
                listBox2.Items.Add(item);    // tüm seçilenleri ekle.
                label4.Text = (listBox2.Items.Count).ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int index = 0 ;                     // tüm seçimleri kaldır.
            while (listBox2.Items.Count > 0)
            {
                listBox2.Items.RemoveAt(index);
                label4.Text = (listBox2.Items.Count).ToString();
            }
        }
    }
}
