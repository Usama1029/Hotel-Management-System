using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SElabProject.BL;
using System.IO;
using SElabProject.DL;


namespace SElabProject.DL
{
    class MealorderDL
    {
      
        private static List<userorder> orderlist = new List<userorder>();
        public static void addintobillList(userorder b)
        {
            orderlist.Add(b);
        }
        public static List<userorder> getlistpayment()
        {
            return orderlist;
        }
        public static void storeintofile(string path2, userorder m)
        {
            StreamWriter f = new StreamWriter(path2, true);
            f.WriteLine(m.getname() + "," + m.getpass() + "," + m.getmealname() + "," + m.getprice() + "," + m.getquantity());
            f.Flush();
            f.Close();
        }
        public static void setamount(int b)
        {
            int num = 0;
            num = b;
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

        public static bool readfromfile(string path2)
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
                        string meal = splittedrecord[2];
                        int price = ConvertStringToInt(splittedrecord[3]);
                        int quantity = ConvertStringToInt(splittedrecord[4]);

                        userorder c = new userorder(name, password, meal, price, quantity);
                        orderlist.Add(c);
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

    }
}
