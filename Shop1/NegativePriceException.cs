using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop1
{
    public class NegativPriceException:Exception
    {
        public NegativPriceException() : base("Price must not be less then zero")
        {
        }
    }
}
