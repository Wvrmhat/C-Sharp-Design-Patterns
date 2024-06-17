using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StategyBasicCode
{
    class Client
    {
        public StrategyBase Strategy;
        public Client(StrategyBase Strategy)
        {
            this.Strategy = Strategy;
        }
        public void CallAlgorithm()
        {
            Console.WriteLine(Strategy.Algorithm());
        }
    }

}
