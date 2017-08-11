using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10082017
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
      

        private void Form5_Load(object sender, EventArgs e)
        {
            int sayikare = Karehesapla(7);
            MessageBox.Show(sayikare.ToString());
        }
        public int Karehesapla(int a )
        {
            int sonuc = a * a;
            return sonuc;
        }
    }
}
