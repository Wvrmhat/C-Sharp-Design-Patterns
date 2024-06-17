using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern_Exercise
{
    class VerticalOutput : IOutput
    {
        public void Output(List<int> list)
        {
            foreach (int value in list)
                Console.WriteLine(value);
        }
    }
}
