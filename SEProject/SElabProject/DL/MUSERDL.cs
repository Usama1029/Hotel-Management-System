using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SElabProject.BL;
using SElabProject.DL;

namespace SElabProject.DL
{
    class MUSERDL
    {
        private static List<MUSER> userlist = new List<MUSER>();
        
        public static void addintolist(MUSER users)
        {
            userlist.Add(users);
        }
        public static List<MUSER> getlist()
        {
            return userlist;
        }
        public static MUSER signin(MUSER user)
        {

            foreach (MUSER storeuser in userlist)
            {


                if (storeuser.getname() == user.getname() && storeuser.getpassword() == user.getpassword())
                {
                   // return storeuser.getname();
                    return storeuser;
                }



            }
            return null;

        }
        public static string parsedata(string record, int field)
        {
            int commacount = 1;
            string item = "";

            for (int i = 0; i < record.Length; i++)
            {
                if (record[i] == ',')
                {
                    commacount++;
                }
                else if (commacount == field)
                {
                    item = item + record[i];
                }
            }
            return item;
        }

        public static bool readDATA(string path)
        {


            if (File.Exists(path))
            {
                StreamReader f = new StreamReader(path);
                string record;
                while ((record = f.ReadLine()) != null)
                {

                    string name = parsedata(record, 1);
                    string password = parsedata(record, 2);
                    string role = parsedata(record, 3);
                    MUSER m = new MUSER(name, password, role);
                    addintolist(m);

                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }

        }
        public static void storedataintofile(MUSER user, string path)
        {
            StreamWriter f = new StreamWriter(path, true);
            f.WriteLine(user.getname() + "," + user.getpassword() + "," + user.getrole());
            f.Flush();
            f.Close();
        }
    }
}
