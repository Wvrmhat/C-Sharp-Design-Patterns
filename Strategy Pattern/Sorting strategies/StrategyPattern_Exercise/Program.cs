using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Horizontal = new List<int>();
            Horizontal.Add(2);
            Horizontal.Add(4);
            Horizontal.Add(1);
            Horizontal.Add(3);
            Horizontal.Add(6);
            Horizontal.Add(5);

            List<int> Vertical = new List<int>();
            Vertical.Add(2);
            Vertical.Add(4);
            Vertical.Add(1);
            Vertical.Add(3);
            Vertical.Add(6);
            Vertical.Add(5);

            DataSet First = new DataSet("Horizontal: ", Horizontal, new SortAsc(), new HorizontalOutput());
            DataSet Second = new DataSet("Reverse Vertical: ", Vertical, new VerticalOutput(), new VerticalOutput());

            First.Sort();
            Second.Sort();
            First.DisplayList();
            Second.DisplayList();

            Second.Output = new HorizontalOutput();
            Second.DisplayList();

            Console.ReadLine();


        }
    }
}
