using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SElabProject.BL;
using SElabProject.DL;

namespace SElabProject
{
    class meal
    {
        private string mealname;
        private int price;
        public meal(string mealname,int price)
        {
            this.mealname = mealname;
            this.price = price;
        }
       
        public string getname()
        {
            return mealname;
        }
        public int getprice()
        {
            return price;
        }
        public override string ToString()
        {
            return "Name : " + mealname + " Price " + price + " City " ;
        }
    }
}
