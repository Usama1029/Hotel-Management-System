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
    public partial class reservation2 : Form
    {
        public reservation2()
        {
            InitializeComponent();
        }
        private void clearform()
        {
            txtname.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            

        }
       
           
        

        private void reservation2_Load(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            string path = "customer.txt";
            string name = txtname.Text;
            string password = textBox1.Text;
            string email = textBox3.Text;
            string city = textBox5.Text;
            string cnic = textBox2.Text;
            string mobile = textBox4.Text;
            int count = 0;
            int n = cnic.Length;
            int n2 = mobile.Length;
            if (n2 != 11)
            {
                MessageBox.Show("invalid mobile 11 Digits ");
                clearform();
            }
            if (n != 13)
            {
                MessageBox.Show("invalid cnic enter 13  Digits ");
                clearform();
            }
            foreach (char cc in email)
            {
                if (cc == '@')
                {
                    count++;
                    break;
                }
            }
            if (n == 13)

                if (count == 0)
                {
                    MessageBox.Show("Invalid email please enter correct email");
                    clearform();
                }
            if (n == 13)
            {
                if (n2 == 11)
                {
                    if (count == 1)
                    {
                        customer c = new customer(name, password, email, city, cnic, mobile);
                        customerDL.addintolist(c);
                        customerDL.storeintofile(path, c);

                        MessageBox.Show("Successfully added.");
                       
                    }
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminmenu f = new adminmenu();
            this.Hide();
            f.ShowDialog();
        }
    }
}

