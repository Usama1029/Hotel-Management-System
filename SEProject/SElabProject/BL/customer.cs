using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SElabProject.BL
{
    
        class customer : cus
        {
            private string email;
            private string city;
            private string cnic;
            private string mobile;
            public customer(string name, string password, string email, string city, string cnic, string mobile) : base(name, password)
            {
                this.name = name;
                this.password = password;
                this.email = email;
                this.city = city;
                this.cnic = cnic;
                this.mobile = mobile;

            }
            public override string getname()
            {
                return name;
            }
            public override string getpassword()
            {
                return password;
            }
        public void setname(string newName)
        {
            name = newName;
        }

        public void setpassword(string newPassword)
        {
            password = newPassword;
        }
        public void setemail(string newName)
        {
            email = newName;
        }

        public void setcnic(string newPassword)
        {
            cnic = newPassword;
        }
        public void setcity(string newName)
        {
            city = newName;
        }

        public void setmobile(string newPassword)
        {
            mobile = newPassword;
        }
        public string getcnic()
            {
                return cnic;
            }
            public string getcity()
            {
                return city;
            }
            public string getmobile()
            {
                return mobile;
            }
            public string getemail()
            {
                return email;
            }
            public override string ToString()
            {
                return "Name : " + name + " email " + email + " City " + city + " CNIC " + cnic + " Mobile " + mobile + " Password " + password;
            }
        }
    }

