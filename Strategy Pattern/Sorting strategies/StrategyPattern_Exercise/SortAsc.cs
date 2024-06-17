using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern_Exercise
{
    class SortAsc : ISortStrategy
    {
        public void Sort(List<int> list)
        {
            int value;
            for(int i = 1; (i <= list.Count -1); i++)
            {
                if(list[i] > list[i + 1])
                {
                    value = list[i + 1];
                    list[i + 1] = list[i];
                    list[i] = value;

                }
            }    
        }
    }
}
