using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SElabProject.BL;
using SElabProject.DL;
using System.IO;

namespace SElabProject.DL
{
    class MealDL
    {
        private static List<meal> mealList = new List<meal>();
        public static void addintomealList(meal m)
        {
            mealList.Add(m);
        }
        public static List<meal> getlistmeal()
        {
            return mealList;
        }
        public static void storeintofile(string path2, meal m)
        {
            StreamWriter f = new StreamWriter(path2, true);
            f.WriteLine(m.getname() + "," + m.getprice());
            f.Flush();
            f.Close();
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
                    if (splittedrecord.Length >= 2)
                    {
                        string name = splittedrecord[0];
                        int price = ConvertStringToInt(splittedrecord[1]);

                        meal m = new meal(name, price);
                        mealList.Add(m);
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

