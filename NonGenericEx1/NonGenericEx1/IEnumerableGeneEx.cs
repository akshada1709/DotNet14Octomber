using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericEx1
{
    
    public class Product1 :IComparable<Product1>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price {  get; set; } 
    
        public Product1(int id, string name, double price) 
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
        }

        public override string ToString()
        {
            return $"Id={Id},Name={Name},Price={Price}";
        }

        public int CompareTo(Product1 other)
        {
            if(other== null) return 1 ;
            return this.Price.CompareTo(other.Price) ;
        }
    }
    public class IEnumerableGeneEx
    {
        //static void Main(string[] args)
        //{
        //    List<Product1> pd = new List<Product1>
        //    {
        //        new Product1(1, "Shirt", 850),
        //        new Product1(2, "Pant", 1000),
        //        new Product1(3, "Jacket", 1500),
        //        new Product1(4, "Belt", 400),
        //        new Product1(5, "Shoes", 1200)
        //    };

        //    pd.Sort();
        //    Console.WriteLine("After compare list");
        //    foreach (var product in pd)
        //    {
        //        Console.WriteLine(product);
        //    }
        //}
    }
}
