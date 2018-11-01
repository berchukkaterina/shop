using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop1
{
    class Shop
    {
        public static Product SearchProduct(string _name, List<Product> list)
        {
            foreach (Product p in list)
            {
                if (p.Name.ToLower() == _name.ToLower())
                {
                    return p;
                }
            }

            throw new ProductNotFoundException(); ;
        }

       
    }
}
