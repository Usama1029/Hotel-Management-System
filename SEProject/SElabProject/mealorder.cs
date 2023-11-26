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
    public partial class Ordercustomer : Form
    {
        public Ordercustomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void add_Click(object sender, EventArgs e)
        {
            string path = "order.txt";
            string name = txtname.Text;
            string pass = txtpass.Text;
            string meal = txtmeal.Text;
            int price = int.Parse(txtPrice.Text);
            int quantity = int.Parse(txtqua.Text);
            userorder c = new userorder(name, pass, meal, price, quantity);
            MealorderDL.addintobillList(c);
            MealorderDL.storeintofile(path, c);
            MessageBox.Show("Order Placed");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CustomerMenu f = new CustomerMenu();
            this.Hide();
            f.ShowDialog();
        }

        private void Ordercustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
