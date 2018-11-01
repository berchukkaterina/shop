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
            Product First = new Product("Apple", -15);
            Product Second = new Product("Pear", 5);
            Product Thirt = new Product("Banana", 15);
            products.Add( First);
            products.Add(Second);
            products.Add(Thirt);

            Console.WriteLine("Fruits:");

            foreach (Product p in products)
            {
                Console.WriteLine(p.Name + ' ' + p.Price + ' ' + "uah");
            }



            Console.WriteLine("What do you want to buy?");
            string product;
            product = Console.ReadLine();
            if (Program.SearchProduct(product, products))
            {
                Console.WriteLine("How much?(kg)");
                int amount = Int32.Parse(Console.ReadLine());


            }
            else
            {
                throw new ProductException("Product is out of stock");
            }
        }

        public int SearchProduct(string _name, List<Product> list)
        {
            foreach (Product p in list)
            {
                String.Equals(p.Name, _name);
                if (String.Equals(p.Name, _name))
                {
                    return 1;
                }
            }

            return 0;
        }

    
        }
    }
