using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodTemplate
{
    abstract class FactoryBase
    {
        public abstract ProductBase FactoryMethod();
    }
}
