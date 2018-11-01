using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Basket basket = new Basket();

            Product First = new Product("Apple", 15);
            Product Second = new Product("Pear", 5);
            Product Third = new Product("Banana", 15);

            products.Add(First);
            products.Add(Second);
            products.Add(Third);

            Console.WriteLine("Fruits:");

            foreach (Product p in products)
            {
                Console.WriteLine(p.Name + ' ' + p.Price + ' ' + "uah");
            }



            Console.WriteLine("What do you want to buy?");
            string productName = "";
            bool productNotFound = true;
            while (productNotFound) {
                productNotFound = false;
                productName = Console.ReadLine();
                try
                {
                    Shop.SearchProduct(productName, products);
                }
                catch (ProductNotFoundException) {
                    productNotFound = true;
                    Console.WriteLine("Product not found!");
                    Console.WriteLine("Try again");
                }
            }
            

            Console.WriteLine("How much?(kg)");
            decimal amount = Int32.Parse(Console.ReadLine());
            basket.Add(Shop.SearchProduct(productName, products), amount);
            Console.WriteLine(basket.ToString());
        }

        
    }
}
