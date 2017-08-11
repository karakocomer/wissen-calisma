using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03082017
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //char[] soyaddizi = { 'k', 'a', 'r', 'a', 'k', 'o', 'ç' };
            //string[] isimler = { "omer", "elsin","yakup","bekir","enes","oğuz" };
            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    MessageBox.Show(isimler[i].ToString());
            //}
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] gunler = { "pazartesi", "salı", "çarşamba", "perşembe", "cuma", "cumartesi", "pazar" };
            int girilensayi = Convert.ToInt32(txtsayi.Text);
            if (girilensayi>0 && girilensayi<8)
            {
                for (int i = 0; i < gunler.Length; i++)
                {
                    txtgun.Text = gunler[girilensayi-1].ToString();
                }
            }
            else
            {
                MessageBox.Show("1-7 arasında sayı giriniz!!");
            }
            button1.Text = "girilen gün";
        }

        private void chcbox_CheckedChanged(object sender, EventArgs e)
        {

            if (chcbox.Checked == true)
            {
                chcbox.Text = "Aktif";
                button1.Enabled = true;
            }
            else if (chcbox.Checked==false)
                    {
                chcbox.Text = "Aktif Değil";
                button1.Enabled = false;
            }
            
            button1.Text = "Girilen sayı şu gündür.";
        }
    }
}
