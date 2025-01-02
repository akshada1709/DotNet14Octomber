using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo2
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayList productIds = new ArrayList();

            // Boxing: Adding product IDs (int, a value type) into the ArrayList
            productIds.Add(101); // Boxing happens here
            productIds.Add(102); // Boxing happens here
            productIds.Add(103); // Boxing happens here

            Console.WriteLine("Product IDs in the ArrayList:");
            foreach (object id in productIds)
            {
                Console.WriteLine(id); // Stored as object
            }

            // Unboxing: Retrieving and converting back to int
            Console.WriteLine("\nRetrieving Product IDs after unboxing:");
            foreach (object id in productIds)
            {
                int productId = (int)id; // Explicitly cast back to int
                Console.WriteLine(productId);
            }

            // Adding another value type for demonstration
            productIds.Add(104); // Boxing
            int lastProductId = (int)productIds[3]; // Unboxing
            Console.WriteLine($"\nLast Product ID retrieved: {lastProductId}");
        }
    }
    
}
