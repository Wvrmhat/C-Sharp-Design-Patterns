using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_JavaCo
{
    class Additives : BeverageComponent // Decorator Base
    {
        BeverageComponent DecorateMe = null;

        public Additives(BeverageComponent DecorateMe)
        {
            this.DecorateMe = DecorateMe;
        }

        public override string Details()
        {
            return DecorateMe.Details();
        }
        
    }
}
