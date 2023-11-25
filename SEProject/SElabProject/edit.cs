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
    public partial class edit : Form
    {
        private customer previous;

        public edit()
        {
            InitializeComponent();
           // this.previous = previous;
        }

        private void add_Click(object sender, EventArgs e)
        {
            string path2 = "customer";
            string name = txtname.Text;
            string password = textBox1.Text;
            string email = textBox3.Text;
            string city = textBox5.Text;
            string cnic = textBox2.Text;
            string mobile = textBox4.Text;
            customer c = new customer(name, password, email, city, cnic, mobile);
            customerDL.editfromlist(previous, c);
            customerDL.addintolist(c);
            customerDL.storeintofile(path2, c);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGrid f = new DataGrid();
            this.Hide();
            f.ShowDialog();
        }
    }
}