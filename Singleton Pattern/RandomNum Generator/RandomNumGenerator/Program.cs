using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomGenerator first = RandomGenerator.GetGenerator();
            Console.WriteLine(first.Generate(1, 5000));

            RandomGenerator second = RandomGenerator.GetGenerator();

            for(int i = 0; i < 1000; i++)
            {
                Console.WriteLine(second.Generate(1, 1000));
            }

            Console.ReadLine();
        }
    }
}
