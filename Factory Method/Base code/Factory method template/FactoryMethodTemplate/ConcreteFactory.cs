using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodTemplate
{
    class ConcreteFactoryA:FactoryBase
    {
        public override ProductBase FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }

    class ConcreteFactoryB : FactoryBase
    {
        public override ProductBase FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }
}
