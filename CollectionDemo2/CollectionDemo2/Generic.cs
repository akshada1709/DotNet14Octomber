using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo2
{
    public class Generic
    {
        static void Main(string[] args)
        {
            List<int> productIds = new List<int>();

            // Directly adding integers (no boxing)
            productIds.Add(101);
            productIds.Add(102);
            productIds.Add(103);

            Console.WriteLine("Product IDs in the List:");
            foreach (int id in productIds)
            {
                Console.WriteLine(id); // No boxing/unboxing
            }

            // Directly accessing a value
            int lastProductId = productIds[2];
            Console.WriteLine($"\nLast Product ID retrieved: {lastProductId}");
        }
    }
}
