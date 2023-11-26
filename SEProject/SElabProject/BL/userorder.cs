using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SElabProject.BL
{
    class userorder
    {
        private string mealname;
        private int price;
        private string name;
        private string password;
        private int quantity;
        public userorder(string name, string password, string mealname, int price, int quantity)
        {
           
            this.name = name;
            this.password = password;
            this.mealname = mealname;
            this.price = price;
            this.quantity = quantity;
        }

        public string getname()
        {
            return name;
        }
        public string getpass()
        {
            return password;
        }
        public int getquantity()
        {
            return quantity;
        }

        public string getmealname()
        {
            return mealname;
        }
        public int getprice()
        {
            return price;
        }
        public override string ToString()
        {
            return "Name : " + name + " Password " + password +"Meal name"+mealname+"Price"+price+"Quantity"+quantity;
        }
    }
}
