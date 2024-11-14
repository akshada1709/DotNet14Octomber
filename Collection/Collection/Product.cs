using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    public class Product: IComparable
    {
        private string name;
        private double price;

        public Product(string name,double price)
        {
            this.name = name;   
            this.price = price;
            
        }

        public double Price 
        {
            get { return price; }
        }

        public int CompareTo(object obj)
        {
            Product p = (Product)obj; 
            if (this.price > p.price)
            {
                return 1;
            }
            else if (this.price < p.price)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        public override string ToString() 
        {
            return $"{name} (Price: {price})";
        }
    }
    
}
