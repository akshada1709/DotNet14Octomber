using System;
using System.Collections;
using System.Collections.Generic;

namespace Collection
{
    public class Product1
    {
        private string name;
        private double price;

        public Product1(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public double Price
        {
            get { return price; }
        }

        public override string ToString()
        {
            return $"{name} (Price: {price})";
        }
    }

    public class ProductCollection : IEnumerable
    {
        private List<Product1> products = new List<Product1>();

        public void AddProduct(Product1 product)
        {
            products.Add(product);
        }

        // Implementing the IEnumerable interface
        public IEnumerator GetEnumerator()
        {
            return products.GetEnumerator();
        }
    }

    public class IEnumerableDemo
    {
        static void Main(string[] args)
        {
            // Create a collection of products
            ProductCollection productCollection = new ProductCollection();

            // Add products to the collection
            productCollection.AddProduct(new Product1("Shirt", 850));
            productCollection.AddProduct(new Product1("Pant", 1000));
            productCollection.AddProduct(new Product1("Jacket", 1500));

            // Use foreach to iterate through the collection
            Console.WriteLine("Product Collection:");
            foreach (Product1 product in productCollection)
            {
                Console.WriteLine(product);
            }
        }
    }
}
