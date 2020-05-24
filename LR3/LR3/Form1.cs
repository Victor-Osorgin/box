using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR3
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        public void ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

                int a = Convert.ToInt32(cbox.Text);

                int y = (-8);
                int i = 9;
                int x = a; // Лет

                if (x == 1)
                {
                    int calc = 15;
                    string c = Convert.ToString(calc);
                    cat_year.Text = c;
                    

                }
                else
                {
                    int calc = (x * 12) + (i + (y * (x - 1)));
                    string c1 = Convert.ToString(calc);
                    cat_year.Text =   c1;
                    
                }

            
        }

        public void Cat_year_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
