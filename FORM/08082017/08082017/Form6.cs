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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
      

        private void btntoplama_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi1, sayi2;
              
                
                sayi1 = Convert.ToInt32(textBox1.Text);
                sayi2 = Convert.ToInt32(textBox2.Text);
                int sonuc = sayi1 + sayi2;
                label1.Text = sonuc.ToString();
                label1.Text = Convert.ToString(sonuc);

            }
            catch (Exception)
            {

                MessageBox.Show("hatalı sayı girdin yea");
            }
          
        }

        private void btncarpma_Click(object sender, EventArgs e)
        {
            try
            {
                double  sayi1, sayi2;


                sayi1 = Convert.ToDouble(textBox1.Text);
                sayi2 = Convert.ToDouble(textBox2.Text);
                double sonuc = sayi1 * sayi2;
                label1.Text = sonuc.ToString();
                label1.Text = Convert.ToString(sonuc);
            }
            catch (Exception)
            {

                MessageBox.Show("hatalı sayı girdin yea");
            }

        }

        private void btnbolme_Click(object sender, EventArgs e)
        {
            try
            {
                double sayi1, sayi2;


                sayi1 = Convert.ToDouble(textBox1.Text);
                sayi2 = Convert.ToDouble(textBox2.Text);
                double sonuc = sayi1 / sayi2;
                label1.Text = sonuc.ToString();
                label1.Text = Convert.ToString(sonuc);
            }
            catch (Exception)
            {

                MessageBox.Show("hatalı sayı girdin yea");
            }
        }

        private void btncikartma_Click(object sender, EventArgs e)
        {
            try
            {
                double sayi1, sayi2;
                sayi1 = Convert.ToDouble(textBox1.Text);
                sayi2 = Convert.ToDouble(textBox2.Text);
                if (sayi1 > sayi2)
                {
                    double sonuc = sayi1 - sayi2;
                    label1.Text = sonuc.ToString();
                    label1.Text = Convert.ToString(sonuc);
                }
                else
                {
                    double sonuc = sayi2 - sayi1;
                    label1.Text = sonuc.ToString();
                    label1.Text = Convert.ToString(sonuc);
                }
               
            }
           
            catch (FormatException ex)//format hatasi
            {
                MessageBox.Show("Lutfen dogru formatta sayi giriniz.");
            }
            catch (OverflowException ex)//sinir disina cikilma hatasi
            {
                MessageBox.Show("Lutfen int sayi sinirlari icerisinde kaliniz.");
            }
            catch (DivideByZeroException ex)//0a bolunme hatasi
            {
                MessageBox.Show("Bir sayiyi 0'a bolemezsiniz.");
            }
            catch (Exception ex)//Geri kalan hatalar icin(en son catchte olmali!!!)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
        }
   

