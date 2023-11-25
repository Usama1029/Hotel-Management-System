using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SElabProject.BL
{
    class bill : cus
    {
   
            private int payment;
            private int days;
            private int room;
            public bill(string name, string password, int payment, int days,int room) : base(name, password)
            {
            this.room = room;
                this.payment = payment;
                this.days = days;
                this.name = name;
                this.password = password;
                

            }
            public override string  getname()
            {
                return name;
            }
            public override string getpassword()
            {
                return password;
            }
            public int getdays()
            {
                return days;
            }
            public int getbill()
            {
                return payment;
            }
        public int getroom()
        {
            return room;
        }

        public override string ToString()
            {
                return "Name : " + name + " Passwors " + password + " Days Stay " + days+ " Total Bill " + payment+ "Room No."+room ;
            }
        }
    }

