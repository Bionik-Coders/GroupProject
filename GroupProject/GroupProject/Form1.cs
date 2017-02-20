using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (Username_input.Text == "Admin" && Password_input.Text == "Pass")
            {
                    Form3 form3 = new Form3();
                    form3.Show();

                    this.Hide();
                
            }

            if (Username_input.Text == "St&Lo" && Password_input.Text == "Pass")
            {
                Form2 form2 = new Form2();
                form2.Show();

                this.Hide();
            }

            if (Username_input.Text == "P&F" && Password_input.Text == "Pass")
            {
                Form4 form4 = new Form4();
                form4.Show();

                this.Hide();
            }

            if (Username_input.Text == "Fs" && Password_input.Text == "Pass")
            {
                Form5 form5 = new Form5();
                form5.Show();

                this.Hide();
            }

            else
            {
                Username_input.Text = "";
                Password_input.Text = "";

                WrongLogin.Text = "Incorrect Login";
            }
        }
    }
}
