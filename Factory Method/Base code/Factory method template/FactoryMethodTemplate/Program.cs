using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryBase theFactory = new ConcreteFactoryA();
            ProductBase theProduct = theFactory.FactoryMethod();
            Console.WriteLine("Created " + theProduct.GetType().Name);
            theFactory = new ConcreteFactoryB();
            theProduct = theFactory.FactoryMethod();
            Console.WriteLine("Created " + theProduct.GetType().Name);
            Console.ReadLine();

        }
    }
}
