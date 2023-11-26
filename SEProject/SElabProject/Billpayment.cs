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
    public partial class Billpayment : Form
    {
        public Billpayment()
        {
            InitializeComponent();
        }

        private void Billpayment_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerMenu f = new CustomerMenu();
            this.Hide();
            f.ShowDialog();
        }

        private void add_Click(object sender, EventArgs e)
        {
            int amount = int.Parse(txtname.Text);
            MessageBox.Show("Bill paid");

        }
    }
}
