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
    public partial class booking : Form
    {
        public booking()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerMenu f = new CustomerMenu();
            this.Hide();
            f.ShowDialog();
        }
        private void clearform()
        {
            txtname.Text = "";
            txtpass.Text = "";
            comboBox1.Text = "";
            txtdays.Text = "";
            txtbill.Text = "";
            textroom.Text = "";

        }

        private void add_Click(object sender, EventArgs e)
        {
            string path = "bill.txt";
            string name = txtname.Text;
            string pass = txtpass.Text;
            string room = comboBox1.Text;
            int roomnomber = int.Parse(textroom.Text);
            int days = int.Parse(txtdays.Text);
            int bill = int.Parse(txtbill.Text);
            MUSER user = new MUSER(name, pass);
            MUSER valid = MUSERDL.signin(user);
            if (valid == null)
            {
                MessageBox.Show("Invalid user ");
            }
            else
            {
                int payment;
                payment = bill * days;
                bill b = new bill(name, pass, payment, days, roomnomber);
                bool checkroom = customerDL.findroom(b, roomnomber);
                if (checkroom == true)
                {
                    MessageBox.Show("This room already assign choose another ");
                    textroom.Text = "";
                }
                else
                {
                    customerDL.addintobillList(b);
                    customerDL.storeintofilebill(path, b);
                    MessageBox.Show("Room Assigned");
                    clearform();
                }
            }
        }
    }
    }

