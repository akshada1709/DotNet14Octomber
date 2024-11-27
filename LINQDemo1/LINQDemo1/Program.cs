using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Products> products = new List<Products>()
            {
                new Products{Id=1,Name="Mouse",Price=799,CompanyName="Dell"},
                new Products{Id=2,Name="Mouse",Price=699,CompanyName="Lenovo"},
                new Products{Id=3,Name="Laptop",Price=34799,CompanyName="Dell"},
                new Products{Id=4,Name="Laptop",Price=45799,CompanyName="Sony"},
                new Products{Id=5,Name="Laptop",Price=38799,CompanyName="Lenovo"},
                new Products{Id=6,Name="Keyboard",Price=599,CompanyName="Dell"},
                new Products{Id=7,Name="Keyboard",Price=999,CompanyName="Microsoft"},
                new Products{Id=8,Name="RAM 4GB",Price=2799,CompanyName="Corsair"},
                new Products{Id=9,Name="Speaker",Price=5799,CompanyName="Sony"},
                new Products{Id=10,Name="USB Mouse",Price=1299,CompanyName="Microsoft"},
            };

            // Using LINQ query

            //Display all products using LINQ query
            var result1=from p in products
                        select p;
            foreach (Products product in result1)
            {
                Console.WriteLine(product);
            }

            //Display products whose price is greater than 1500
            var result2 = from p2 in products
                          where p2.Price > 1500
                          select p2;
            foreach (Products product in result2)
            {
                Console.WriteLine(product);
            }

            //Display products whose price is in between 10000 to 40000
            var result3 = from p3 in products
                          where p3.Price >= 10000 && p3.Price <= 40000
                          select p3;
            foreach (Products product in result3)
            {
                Console.WriteLine(product);
            }

            //Display products of Dell company
            var result4 = from p4 in products
                          where p4.CompanyName == "Dell"
                          select p4;
            foreach (Products product in result4)
            {
                Console.WriteLine(product);
            }

            //Display all company laptops
            var result5 = from p5 in products
                          where p5.Name.Contains("Laptops")
                          select p5;
                         
            foreach (Products product in result5)
            {
                Console.WriteLine(product);
            }

            //Display products whose company name start with ‘M’
            var result6 = from p6 in products
                          where p6.CompanyName.StartsWith("M")
                          select p6;
            foreach (Products product in result6)
            {
                Console.WriteLine(product);
            }


            // Display all company mouse whose price is less than 1000
            var result7 = from p7 in products
                          where p7.Name.Contains("Mouse") && p7.Price < 1000
                          select p7;
            foreach (Products product in result7)
            {
                Console.WriteLine(product);
            }

            //Display all products descending order by their price
            var result8 = from p8 in products
                          orderby p8.Price descending
                          select p8;

            foreach (Products product in result8)
            {
                Console.WriteLine(product);
            }

            // Display all products accessing order by their company name
            var result9 = from p9 in products
                          orderby p9.CompanyName
                          select p9;
            foreach (Products product in result9)
            {
                Console.WriteLine(product);
            }


            //Display all keyboards accessing order by their price

            var result10 = from p10 in products
                           where p10.Name=="Keyboard"
                           orderby p10.Price
                           select p10;

            foreach (Products product in result9)
            {
                Console.WriteLine(product);
            }



            //Using Lambda Expressions

            //Display all products descending order by their price
            var result11 = products.OrderByDescending(p=>p.Price).ToList();
            foreach (Products product in result11)
            {
                Console.WriteLine(product);
            }

            //Display product whose Id is 5
            var result12 =products.Where(p=>p.Id==5).ToList();
            foreach (Products product in result12)
            {
                Console.WriteLine(product);
            }

            //Display all products whose price less than 5000
            var result13 =products.Where(p=>p.Price < 5000).ToList();
            foreach (Products product in result13)
            {
                Console.WriteLine(product);
            }

            //Display 3 products which have maximum price
            var r = products.OrderByDescending(x => x.Price).Take(3);
            foreach (Products item in r)
            {
                Console.WriteLine(item);
            }

            //without orderby
            //var maxPrice = products.Max(p => p.Price);
            //var result14 = products.Where(p => p.Price == maxPrice).Take(3).ToList();
            //foreach (Products product in result14)
            //{
            //    Console.WriteLine(product);
            //}

            //Display 5 products which have minimum price
            var r1 = products.OrderBy(x => x.Price).Take(5);
            foreach (Products item in r1)
            {
                Console.WriteLine(item);
            }

            var minPrice = products.Min(p => p.Price);
            var result15 = products.Where(p => p.Price == minPrice).Take(5).ToList();
            foreach (Products product in result15)
            {
                Console.WriteLine(product);
            }

        }
    }
}
