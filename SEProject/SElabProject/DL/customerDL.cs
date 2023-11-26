using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SElabProject.DL;
using SElabProject.BL;
using System.IO;

namespace SElabProject.DL
{
    class customerDL
    {
        private static List<customer> studentlist = new List<customer>();
        private static List<bill> paymentlist = new List<bill>();
        public static void addintobillList(bill b)
        {
            paymentlist.Add(b);
        }
        public static List<bill> getlistpayment()
        {
            return paymentlist;
        }
        public static void addintolist(customer s)
        {
            studentlist.Add(s);
        }
        public static List<customer> getlist()
        {
            return studentlist;
        }
        public static void storeintofile(string path2, customer c)
        {
            StreamWriter f = new StreamWriter(path2, true);
            f.WriteLine(c.getname() + "," + c.getpassword() + "," + c.getemail() + "," + c.getcnic() + "," + c.getcity() + "," + c.getmobile());
            f.Flush();
            f.Close();
        }
        public static void storeintofilebill(string path3, bill b)
        {
            StreamWriter f = new StreamWriter(path3, true);
            f.WriteLine(b.getname() + "," + b.getpassword() + "," + b.getdays() + "," + b.getbill()+","+b.getroom());
            f.Flush();
            f.Close();
        }
        public static bool readfromfileforbill(string path2)
        {
            StreamReader f = new StreamReader(path2);
            string record;
            if (File.Exists(path2))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedrecord = record.Split(',');

                    // Check if the array has enough elements before accessing them
                    if (splittedrecord.Length >= 5)
                    {
                        string name = splittedrecord[0];
                        string password = splittedrecord[1];
                        int days = ConvertStringToInt(splittedrecord[2]);
                        int bill = ConvertStringToInt(splittedrecord[3]);
                        int roomnu = ConvertStringToInt(splittedrecord[4]);

                        bill c = new bill(name,password,bill,days,roomnu);
                        paymentlist.Add(c);
                    }
                    else
                    {
                        Console.WriteLine($"Error: Insufficient elements in the record '{record}'. Skipping this record.");
                    }
                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static int ConvertStringToInt(string value)
        {
            if (int.TryParse(value, out int result))
            {
                return result;
            }
            else
            {
                // Handle parsing error, log, or return a default value
                Console.WriteLine($"Error converting '{value}' to an integer. Using default value (e.g., 0).");
                return 0; // You can change this default value as needed
            }
        }

        public static void editfromlist(customer previous, customer updated)
        {
            foreach (customer c in studentlist)
            {
                if (c.getname() == previous.getname() && c.getpassword() == previous.getpassword())
                {
                    c.setname(updated.getname());
                    c.setpassword(updated.getpassword());
                    c.setemail(updated.getemail());
                    c.setcnic(updated.getcnic());
                    c.setcity(updated.getcity());
                    c.setmobile(updated.getmobile());
                }
            }

            // After editing, update the file
            
        }

        public static void store(string path)
        {
            StreamWriter f2 = new StreamWriter(path, false);
            foreach (customer c in studentlist)
            {
                f2.WriteLine(c.getname() + "," + c.getpassword() + "," + c.getemail() + "," + c.getcnic() + "," + c.getcity() + "," + c.getmobile());


            }
        }
        public static void file(string path)
        {
            StreamWriter f = new StreamWriter(path, false);
            foreach (cus p in studentlist)
            {
                if (p is customer)
                {
                    customer p2 = (customer)p;
                    f.WriteLine(p2.getname() + "," + p2.getpassword() + "," + p2.getemail() + "," + p2.getcnic() + "," + p2.getcity() + "," + p2.getmobile());
                }
            }
            f.Flush();
            f.Close();
        }
        public static void delete_customer(string n, string path)
        {
            bool flag = false;
            for (int i = 0; i < studentlist.Count; i++)
            {
                if (studentlist[i].getname() == n)
                {
                    flag = true;
                    studentlist.RemoveAt(i);
                    file(path);
                    Console.WriteLine("Customer delete successfully : ");
                    Console.ReadKey();
                }
            }
            if (flag == false)
            {
                Console.WriteLine("such customer not exist please enter correct name of customer : ");
                Console.ReadKey();
            }
        }
        public static void removecustomer(int idx)
        {
            studentlist.RemoveAt(idx);
        }
        public static bool findroom(bill b,int roomnu)
        {
            for(int i = 0;i<paymentlist.Count;i++)
            {
                if(paymentlist[i].getroom()== roomnu)
                {
                    return true;
                }
            }
            return false;
        }
        public static void delete(customer c)
        {

            for (int i = 0; i < studentlist.Count; i++)
            {

                if (studentlist[i].getname() == c.getname())
                {
                    studentlist.RemoveAt(i);
                }

            }
        }
        public static void data(string n)
        {
            bool flag = false;
            for (int i = 0; i < studentlist.Count; i++)
            {
                if (studentlist[i].getname() == n)
                {
                    flag = true;
                    Console.WriteLine("Name         Password        CNIC       CITY      GMAIL       MOBILE  ");
                    string name = studentlist[i].getname();
                    string password = studentlist[i].getpassword();
                    string cnic = studentlist[i].getcnic();
                    string city = studentlist[i].getcity();
                    string email = studentlist[i].getemail();
                    string mobile = studentlist[i].getmobile();
                    Console.WriteLine(name + "      " + password + "        " + cnic + "        " + city + "       " + email + "     " + mobile);
                }
            }
            if (flag == false)
            {
                Console.WriteLine("such customer not exist enter correct name ");
            }
        }
        public static bool exist(string name, string password)
        {

            bool flag = false;
            for (int i = 0; i < studentlist.Count; i++)
            {
                if (studentlist[i].getname() == name && studentlist[i].getpassword() == password)
                {
                    flag = true;

                }

            }
            if (flag == true)
            {
                return true;
            }
            else
            {

                return false;
            }
        }
        public static bool readfromfile(string path2)
        {
            StreamReader f = new StreamReader(path2);
            string record;
            if (File.Exists(path2))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedrecord = record.Split(',');
                    string name = splittedrecord[0];
                    string password = splittedrecord[1];
                    string email = splittedrecord[2];
                    string cnic = splittedrecord[3];
                    string city = splittedrecord[4];

                    string mobile = splittedrecord[5];
                    customer c = new customer(name, password, email, city, cnic, mobile);
                    studentlist.Add(c);

                }
                f.Close();
                return true;

            }
            else
            {
                return false;
            }
        }

    }
}


