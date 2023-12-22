using System;
using System.Collections.Generic;
using System.Linq;

namespace P_04._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var products = new Dictionary<Product, int>();

            string input = Console.ReadLine();
            while (input != "buy")
            {
                string[] productParams = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string name = productParams[0];
                double price = double.Parse(productParams[1]);
                int quantity = int.Parse(productParams[2]);

                Product currentProduct = products.Keys.FirstOrDefault(p => p.Name == name);

                if (currentProduct == null)
                {
                    products.Add(new Product(name, price), quantity);
                }
                else
                {
                    if (currentProduct.Price != price)
                    {
                        currentProduct.Price = price;
                    }
                    products[currentProduct] += quantity;
                }

                input = Console.ReadLine();
            }

            foreach (var product in products)
            {
                Console.WriteLine($"{product.Key.Name} -> {product.Key.Price * product.Value:F2}");
            }
        }
    }
}

class Product
{
    public Product(string name, double price)
    {
        this.Name = name;
        this.Price = price;
    }

    public string Name { get; set; }

    public double Price { get; set; }
}
