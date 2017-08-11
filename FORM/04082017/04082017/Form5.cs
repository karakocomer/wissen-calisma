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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        // ANLAMADIM (SIKINTI BÜYÜK)
        private void btndoldur_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int j = 0; j < this.Controls.Count; j++)//Listbox sayısını arıyorum.
            {
                if (this.Controls[j] is ListBox)//== eşitmidir 
                                                //is tip karşılaştırması yapıyor
                {
                    ListBox lst = (ListBox)this.Controls[j];
                    lst.Items.Clear();
                    for (int i = 1; i < 7;)
                    {
                        int sayi = rnd.Next(1, 50);
                        //Aynı sayıların gelmesi için engel
                        if (!lst.Items.Contains(sayi))
                        {
                            lst.Items.Add(sayi);
                            
                            i++;  
                        } 
                    }   
                }   
            }
        }
    }
}       

        
    

