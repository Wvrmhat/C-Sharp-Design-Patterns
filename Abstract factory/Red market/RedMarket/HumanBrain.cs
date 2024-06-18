using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedMarket
{
    class HumanBrain : IBrain
    {
        public override string ToString()
        {
            return string.Format("Ordering human brain.");
        }
    }
}
