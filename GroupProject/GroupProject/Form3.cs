using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GroupProject
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            String line;
           
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("F:\\GroupProject\\Sample.txt");

                //Read the first line of text
                line = sr.ReadLine();

                //Continue to read until you reach end of file
                while (line != null)
                {
                    
                    label1.Text = line;
                    
                    line = sr.ReadLine();
                }

                //close the file
                sr.Close();
            
             
        
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

            this.Hide();
        }
    }
}
