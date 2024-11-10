using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayObject
{
    public class Product
    {
        //Create an array of 5 products contains id,name & price & display the products
       // Display all products - using for & foreach
       // Display the products whose price is > 500 -foreach

        public int id {  get; set; }
        public string name { get; set; }
        public double price { get; set; }

        public override string ToString()
        {
            return $"Id={id},Name={name},Price={price}";
        }
    }
}
