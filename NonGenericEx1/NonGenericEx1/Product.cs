using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericEx1
{
    public class Product
    {
        private int id;
        private string name;
        private double price;

        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"Id ={Id} , Name= {Name} , Salary={Salary}";
        }

        //static void Main(string[] args)
        //{
        //    List<Product> list = new List<Product>();
        //    list.Add(new Product { id = 1, name = "Shirt" ,price=500});
        //    list.Add(new Product { id = 2, name = "pant", price = 2000 });
        //    list.Add(new Product { id = 3, name = "top", price = 550 });
        //    list.Add(new Product { id = 4, name = "belt", price = 1400 });
        //    list.Add(new Product { id = 5, name = "strug", price = 900 });

        //    foreach (var item in list)
        //    {
        //        Console.WriteLine(item);
                
        //    }
        //}
    }
}
