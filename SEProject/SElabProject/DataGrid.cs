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
    public partial class DataGrid : Form
    {
        public DataGrid()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            customerDL.getlist().Clear();

            string path = "customer.txt";
            DataTable d = new DataTable();
            d.Columns.Add("Name", typeof(string));
            d.Columns.Add("Password", typeof(string));
            d.Columns.Add("Email", typeof(string));
            d.Columns.Add("CNIC", typeof(string));
            d.Columns.Add("City", typeof(string));
            d.Columns.Add("Contact", typeof(string));
            dataGridView1.ReadOnly = true;
            customerDL.readfromfile(path);
            foreach (customer c in customerDL.getlist())
            {
                d.Rows.Add(c.getname(), c.getpassword(), c.getcity(), c.getemail(), c.getcnic(), c.getmobile());
            }
            dataGridView1.DataSource = d;

            // Set the text of the button in each cell of the first column to "Delete"
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)row.Cells[0];
                buttonCell.Value = "Delete";
            }
        }

        public void dataBind()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = customerDL.getlist();
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int column = e.ColumnIndex;
            int row = e.RowIndex;
            if (column == 0)
            {
                string path = "customer.txt";
                customerDL.removecustomer(row);
                customerDL.store(path);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = customerDL.getlist();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminmenu f = new adminmenu();
            this.Hide();
            f.ShowDialog();
        }
    }
}
