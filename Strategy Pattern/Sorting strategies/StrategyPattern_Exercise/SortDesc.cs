using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern_Exercise
{
    class SortDesc : ISortStrategy
    {
        public void Sort(List<int> list)
        {
            int value;
            for(int i = 0; i < (list.Count - 1); i++)
            {
                int MaxValue = i;
                for(int x = i+1; x < (list.Count); x++)
                {
                    if (list[x] > list[MaxValue])
                        MaxValue = x;
                }

                value = list[MaxValue];
                list[MaxValue] = list[i];
                list[i] = value;
            }
        }
    }
}
