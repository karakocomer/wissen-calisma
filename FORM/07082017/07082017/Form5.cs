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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        Random rnd = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += rnd.Next(1, 15);
            pictureBox2.Left += rnd.Next(1, 15);
            pictureBox3.Left += rnd.Next(1, 15);
            if (pictureBox1.Right >= pictureBox4.Left)
            {
                timer1.Stop();
                DialogResult sonuc = MessageBox.Show("Şahbatur isimli at jokeyi yakup ile yarışı kazandı. Yeniden oynamak istermisiniz", "oyun bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (sonuc == System.Windows.Forms.DialogResult.Yes)
                {
                    pictureBox1.Left = pictureBox2.Left = pictureBox3.Left = 0;
                }
                else
                {
                    this.Close();
                }


            }
            else if (pictureBox2.Right >= pictureBox4.Left)
            {
                timer1.Stop();

                //MessageBox.Show("Gülbatur isimli at jokeyi Enes ile yarışı Kazandı");
                DialogResult sonuc = MessageBox.Show("Gülbatur isimli at jokeyi Enes ile yarışı Kazandı. Yeniden oynamak istermisiniz", "oyun bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (sonuc == System.Windows.Forms.DialogResult.Yes)
                {
                    pictureBox1.Left = pictureBox2.Left = pictureBox3.Left = 0;
                }
                else
                {
                    this.Close();
                }

            }
            else if (pictureBox3.Right >= pictureBox4.Left)
            {
                timer1.Stop();
                DialogResult sonuc = MessageBox.Show("Sütçü Beygiri isimli At jokeyi Oğuz ile yarışı Kazandı. Yeniden oynamak istermisiniz", "oyun bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (sonuc == System.Windows.Forms.DialogResult.Yes)
                {
                    pictureBox1.Left = pictureBox2.Left = pictureBox3.Left = 0;
                }
                else
                {
                    this.Close();
                }

                //    MessageBox.Show("Sütçü Beygiri isimli At jokeyi Oğuzile yarışı Kazandı");

            }
        }
      }
    }
