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
    public partial class payment : Form
    {
        public payment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerMenu f = new CustomerMenu();
            this.Hide();
            f.ShowDialog();
        }
        //  Room Booking Bill
        //Resturant Bill
        //Both
        private void add_Click(object sender, EventArgs e)
        {
            string path2 = "bill.txt";
            customerDL.readfromfileforbill(path2);
            string path = "order.txt";
            MealorderDL.readfromfile(path);
            string name = txtname.Text;
            string pass = textpass.Text;
            string type = comboBox1.Text;

            if (type == "Room Booking Bill")
            {
                bool customerFound = false;

                foreach (bill b in customerDL.getlistpayment())
                {
                    if (b.getname() == name && b.getpassword() == pass)
                    {
                        int billroom = b.getbill() * b.getdays();
                        MessageBox.Show("Bill is: " + billroom);
                        MealorderDL.setamount(billroom);
                        customerFound = true;
                        break; // Break out of the loop once a match is found
                    }
                }

                if (!customerFound)
                {
                    MessageBox.Show("Customer not found or does not have a Room Booking Bill.");
                }
            }
            else if(type == "Resturant Bill")
            {
                bool customerfound2 = false;
                foreach(userorder m in MealorderDL.getlistpayment())
                {
                    if(m.getname() == name && m.getpass() == pass)
                    {
                        int billmeal = m.getprice() * m.getquantity();
                        MessageBox.Show("Bill is : " + billmeal);
                        MealorderDL.setamount(billmeal);
                        customerfound2 = true;
                        break;
                    }
                }
                if (!customerfound2)
                {
                    MessageBox.Show("Customer not found or does not have a Room Booking Bill.");
                }
            }
            else if(type == "Both")
            {
                bool customerff = false;
                foreach(userorder m in MealorderDL.getlistpayment())
                {
                    foreach(bill b in customerDL.getlistpayment())
                    {
                        if (m.getname() == name && m.getpass() == pass)
                        {
                            int billmeal = m.getprice() * m.getquantity();
                            int billroom = b.getbill() * b.getdays();
                            int bill = billmeal + billroom;
                            MessageBox.Show("Bill is :" + bill);
                            MealorderDL.setamount(bill);
                            customerff = true;
                            break;
                        }
                           
                    }
                }
                if (!customerff)
                {
                    MessageBox.Show("Customer not found or does not have a Room Booking Bill.");
                }
            }
            Billpayment f = new Billpayment();
            this.Hide();
            f.ShowDialog();
        }


        private void payment_Load(object sender, EventArgs e)
        {

        }
    }
}
