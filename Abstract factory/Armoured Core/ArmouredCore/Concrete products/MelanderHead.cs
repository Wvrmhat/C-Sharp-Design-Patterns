using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmouredCore
{
    class MelanderHead : IHead          // Concrete product
    {
        public void Head()
        {
            Console.WriteLine("Fitting HD-011 Melander head on");
        }
    }
}
