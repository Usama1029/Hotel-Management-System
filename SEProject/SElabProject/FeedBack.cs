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
    public partial class FeedBack : Form
    {
        public FeedBack()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminmenu f = new adminmenu();
            this.Hide();
            f.ShowDialog();
        }


        private void add_Click(object sender, EventArgs e)
        {
            string path = "feedback.txt";
            string name = txtname.Text;
            string pass = textBox1.Text;
            string feedback = textBox2.Text;
            MUSER user = new MUSER(name, pass);
           MUSER valid =  MUSERDL.signin(user);
            if(valid == null)
            {
                MessageBox.Show("Such user cannot exist");
            }
            else
            {
                FeedbackDL.AddFeedback(feedback);
                FeedbackDL.StoreFeedbackToFile(path, feedback);
                MessageBox.Show("Feedback Captured");
                txtname.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
            }
           
        }
    }
}
