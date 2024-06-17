using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern_Exercise
{
    class HorizontalOutput : IOutput
    {
        
        public void Output(List<int> list)
        {
            for(int i = 0; i < list.Count; i++)
            {
                Console.Write("{0}, ", i);
                Console.WriteLine();
            }
        }
    }
}
