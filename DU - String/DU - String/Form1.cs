using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DU___String
{
    public partial class Form1 : Form
    {
        string samohlasky = "aeiouyáéěíóúůý";
        string souhlasky = "bcčdďfghjklmnpqrřsštťvwxzž";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string vstup = textBox1.Text;
            int sam = 0, sou = 0, nep = 0;

            vstup = vstup.ToLower();

            foreach(char c in vstup)
            {
                if(samohlasky.Contains(c))
                {
                    sam++;
                } else if(souhlasky.Contains(c))
                {
                    sou++;
                }
                else
                {
                    nep++;
                }
            }
            label2.Text = "Samohlásek: " + sam;
            label3.Text = "Souhlásek: " + sou;
            label4.Text = "Nepísmen: " + nep;
        }
    }
}
