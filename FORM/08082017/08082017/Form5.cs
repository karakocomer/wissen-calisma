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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        string kullaniciadi,tckno,okulno;
        int not1, not2;
        double sonuc;
        private void button1_Click(object sender, EventArgs e)
        {
            kullaniciadi = Convert.ToString(textBox1.Text);
            tckno = Convert.ToString(textBox2.Text);
            okulno = Convert.ToString(textBox3.Text);
            sonuc = Convert.ToDouble(textBox6.Text);
            not1 = Convert.ToInt32(textBox4.Text);
            not2 = Convert.ToInt32(textBox5.Text);
            if ((tckno.Length<11) || (tckno.Length>11))
            {
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    MessageBox.Show("T.C. Kimlik Numarası 11 Haneden Küçük veya Büyük Olamaz", "Dikkat");
                }

            }
            if (tckno == " ")
            {
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    MessageBox.Show("T.C. Kimlik Numarası Girilmelidir", "Dikkat");
                }

            }
            if (kullaniciadi==" ")
            {
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {

                    MessageBox.Show("Ad,Soyad Alanı Girilmelidir", "Dikkat");
                }

            }
            //if ((okulno)) // devam et tamamla slack te kod var
            //{

            //}
     
            }
        }
    }

