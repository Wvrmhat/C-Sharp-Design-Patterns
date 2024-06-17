using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StategyBasicCode
{
    class ConcreteStrategyB : StrategyBase
    {
        public override string Algorithm()
        {
            return "Concrete Strategy B";
        }
    }

}
