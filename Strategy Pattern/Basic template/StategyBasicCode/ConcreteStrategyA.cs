using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StategyBasicCode
{
    class ConcreteStrategyA : StrategyBase
    {
        public override String Algorithm()
        {
            return "Concrete Strategy A";
        }
    }

}
