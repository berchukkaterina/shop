using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop1
{
    public class Product
    {
        public string Name { get; set; }
        private decimal price;

        public Product(string _name, decimal _price)
        {
            Name = _name;
            if (_price < 0)
            {
                throw new NegativPriceException();
            }
            price = _price;
        }

        

        public decimal Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    throw new NegativPriceException();
                }
                else
                {
                    price = value;
                }
                
            }
        }
        
    }
}
