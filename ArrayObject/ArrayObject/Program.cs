using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] product = new Product[6]
            {
               new Product{id=1,name="shirt",price=500},
               new Product{id=2,name="Dress",price=1000},
               new Product{id=3,name="saree",price=600},
               new Product{id=4,name="one-peice",price=400},
               new Product{id=5,name="top",price=700},
               new Product{id=6,name="shoe",price=1500},

            };

            // Display all products - using for
            Console.WriteLine("Print using for loop");
            for (int i = 0; i < product.Length; i++) 
            {
                Console.WriteLine(product[i]);
            }
            Console.WriteLine();
            // & foreach
            Console.WriteLine("Print using foreach loop");
            foreach (Product pd in product)
            {
                Console.WriteLine(pd);
            }
            Console.WriteLine();

            // Display the products whose price is > 500 -foreach
            Console.WriteLine("Display the products whose price is > 500");
            foreach (Product pd in product)
            {
                if (pd.price > 500) 
                {
                    Console.WriteLine(pd);
                }
            }
        }
    }
}
