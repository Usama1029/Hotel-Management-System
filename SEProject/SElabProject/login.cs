using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SElabProject.DL;
using SElabProject.BL;


namespace SElabProject
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        private void clearform()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string password = textBox2.Text;
            MUSER user = new MUSER(name, password);
              MUSER valid = MUSERDL.signin(user);
           // string valid = MUSERDL.signin(user);
             
            // MessageBox.Show(valid);
            if (valid != null)
            {
                MessageBox.Show("valid user");
            }
            else if(valid == null)
            {
                MessageBox.Show("invalid user");
            }
           // clearform();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form moreform = new Form1();
            this.Hide();
            moreform.Show();
        }
    }
}
