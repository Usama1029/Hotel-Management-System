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
    public partial class signin : Form
    {
        public signin()
        {
            InitializeComponent();
        }
        private void clearform()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
        }

        private void signup_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string password = textBox2.Text;
            string role = comboBox1.Text;
            string path = @"login.txt";
            MUSER user = new MUSER(name, password, role);
            MUSERDL.addintolist(user);
            MUSERDL.storedataintofile(user, path);
            MessageBox.Show("user added successfully ");
            clearform();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form moreform = new Form1();
            this.Hide();
            moreform.Show();
        }
    }
}
