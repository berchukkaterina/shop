using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop1
{
    public class ProductNotFoundException : Exception
    {
        public ProductNotFoundException() : base ("Product is out of stock!")
        {

        }
    }
}
