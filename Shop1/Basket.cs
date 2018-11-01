using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop1
{
    class Basket
    {
        private Dictionary<Product, decimal> contents = new Dictionary<Product, decimal>();

        public void Add(Product p, decimal amount)
        {
           contents.Add(p, amount);
        }

        public override string ToString()
        {
            string str = "";
            foreach(var pair in contents)
            {
                Product prod = pair.Key;
                decimal amount = pair.Value;
                str += prod.Name + ' ' + amount + ' ' + prod.Price * amount + '\n';
            }
            return str;
        }
    }
}
