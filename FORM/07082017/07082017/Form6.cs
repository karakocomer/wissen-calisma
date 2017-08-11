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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int maxYatay = this.Width - button1.Width-10;
            button1.Left = rnd.Next(0, maxYatay);
            int maxDikey = this.Height - button1.Height-20;
            button1.Left = rnd.Next(0, maxDikey);
            button1.Top = rnd.Next(0, maxDikey);
        }
    }
}
