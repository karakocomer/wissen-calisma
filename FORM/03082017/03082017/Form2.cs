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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // öğrencilerve notlar diye 2 tane dizi oluşturuyorum
            // en buyuk ve en kucuk degerleri notların 0. sına eşitliyorum
            // en yuksek ve en dusuk alan kişileri stringolarak tanımlıyorum
            // for ile notların içrisinde dönüp 
            // if ile notların [i]. si en buyukle karsılastırıyorum
            // en kucuu karsılastırıyorum
            int[] notlar = {  96, 83, 74, 81 };
            string[] ogrenciler = { "Yakup", "Bekir", "Elsin", "Enes" };
            int enkucuk = notlar[0];
            int enbuyuk = notlar[0];
            string yuksekalan = ogrenciler[0];
            string dusukalan = ogrenciler[0];
            for (int i = 0; i <notlar.Length ; i++) // notların 0.elemanı en kucuk degere atayıp sonra dongu ile en buyuk degeri bulmaya çalışıyorum.
            {
                if (notlar[i]>enbuyuk)
                {
                    enbuyuk = notlar[i]; // en yuksek notu buldu
                    yuksekalan = ogrenciler[i]; // en yuksek notun kime ait oldugunu belirledi

                }
                if (notlar[i] <enkucuk) //burada en kucuk degeri bulmaya calısıyorum
                {
                    enkucuk = notlar[i]; // en kucuk notu buldu
                    dusukalan = ogrenciler[i]; // enkucuk notun kime ait oldugunu getirdi

                }
            }
            txteya.Text = yuksekalan.ToString();
            txteyn.Text = enbuyuk.ToString();
            txteda.Text = dusukalan.ToString();
            txtedn.Text = enkucuk.ToString();

         

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
