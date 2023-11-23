using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SElabProject.BL
{
    class MUSER
    {
        private string password;
        private string name;
        private string role;
        public MUSER(string name, string password)
        {
            this.name = name;
            this.password = password;
        }
        public MUSER(string name, string password, string role)
        {
            this.password = password;
            this.name = name;
            this.role = role;
        }
        public string getname()
        {
            return name;
        }
        public string getpassword()
        {
            return password;
        }
        public string getrole()
        {
            return role;
        }
        public bool isadmin()
        {
            if (role == "admin")
            {
                return true;

            }
            return false;
        }
    }
}

