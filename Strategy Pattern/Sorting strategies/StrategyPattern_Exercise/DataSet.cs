using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern_Exercise
{
    abstract class DataSet
    {
        public abstract string Name { get; set; } //Have to declare get or set accessors to use as property in Dataset method
        public abstract List<int> Values { get; set; }

        public ISortStrategy SortStrategy;
        public IOutput Output;
        public abstract string OutputStrategy();

        public DataSet(string Name, List<int> list, ISortStrategy sort, IOutput output)
        {

            this.Name = Name;
            this.Values = list;
            this.SortStrategy = sort;
            this.Output = output;

        }
        public void Sort()
        {
            SortStrategy.Sort(Values);
        }

        public void DisplayList()
        {
            Output.Output(Values);
        }

    }
}
