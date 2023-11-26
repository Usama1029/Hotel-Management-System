﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SElabProject
{
    public partial class adminmenu : Form
    {
        public adminmenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reservation2 f = new reservation2();
            this.Hide();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            roomassign f = new roomassign();
            this.Hide();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGrid f = new DataGrid();
            this.Hide();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MealOrder f = new MealOrder();
            this.Hide();
            f.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FeedBack f = new FeedBack();
            this.Hide();
            f.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            payment f = new payment();
            this.Hide();
            f.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
