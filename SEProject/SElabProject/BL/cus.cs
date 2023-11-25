using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SElabProject.BL
{
    class cus
    {
        protected string name;
        protected string password;

        public cus(string name, string password)
        {
            this.name = name;
            this.password = password;
        }
        public virtual string getname()
        {
            return name;
        }
        public virtual string getpassword()
        {
            return password;
        }
        public virtual string ToString()
        {
            return "Name " + name + " password " + password;
        }
    }
}
