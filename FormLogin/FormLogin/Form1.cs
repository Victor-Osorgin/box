using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLogin
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

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
       
        int x = 0;
        private void Button2_Click(object sender, EventArgs e)
        {
            if (Login.Text == "user" && Pass.Text == "010100")
            {
                Form2 s = new Form2();
                s.Show();

                this.Hide();
            }
            else
            {
                Login.Text = "";
                Pass.Text = "";
                x++;
                MessageBox.Show("Неверное Имя Пользователя или Пароль");
            }

            if (x == 3)
            {
                timer1.Enabled = true;
                Login.ReadOnly = !Login.ReadOnly;
                Pass.ReadOnly = !Pass.ReadOnly;
                label4.Visible = true;
                label3.Visible = true;
            }
            else
            {
               int  x = 0;
                
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int i = 60;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (i == 0)
            {
                Login.ReadOnly = !Login.ReadOnly;
                Pass.ReadOnly = !Pass.ReadOnly;
                timer1.Enabled = false;
                label4.Visible = false;
                label3.Visible = false;

                i = 60;
                x = 0;
            }
            else
            {
                i--;
                
            }
            label3.Text = i.ToString();
            
        }

        private void Login_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
