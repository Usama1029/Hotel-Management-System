using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SElabProject.BL;
using SElabProject.DL;

namespace SElabProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string path = @"D:\5Th Semester\SE LAB\SEProject\SElabProject\bin\Debug\login.txt";

            if(MUSERDL.readDATA(path))
            {
               // MessageBox.Show("Data is loaded");
            }
            else
            {
                MessageBox.Show("Data is not loaded");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Form moreform = new login();
                this.Hide();
                moreform.Show();
                checkBox1.Checked = false;
            }
            else if (checkBox2.Checked)
            {
                Form moreform = new signin();
                this.Hide();
                moreform.Show();
                checkBox2.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
