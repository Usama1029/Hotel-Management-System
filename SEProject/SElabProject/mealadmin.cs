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
    public partial class MealOrder : Form
    {
        public MealOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminmenu f = new adminmenu();
            this.Hide();
            f.Show();
        }

        private void add_Click(object sender, EventArgs e)
        {
            string path2 = "meal.txt";
            string name = txtname.Text;
            int price = int.Parse(textBox1.Text);
            meal m = new meal(name, price);
            MealDL.addintomealList(m);
            MealDL.storeintofile(path2, m);
            MessageBox.Show("Item added successfully");
        }

        private void MealOrder_Load(object sender, EventArgs e)
        {

        }
    }
}
