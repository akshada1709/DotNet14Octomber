using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesInitilize
{
    public class Book
    {
        private int bnum;
        private string bname;
        private double price;

        public int BookNum 
        {
            set { bnum = value; }
            get { return bnum; }
        }

        public double Price
        {
            set { price = value; }
            get { return price; }
        }

        public String Name { 
        
        }
    }
}
