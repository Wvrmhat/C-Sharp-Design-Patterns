using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_JavaCo
{
    class Toppings : Additives
    {
        int marshmallows;
   
        public Toppings(BeverageComponent DecorateMe, int marshmallows) : base(DecorateMe)
        {
            this.marshmallows = marshmallows;
        }

        public override string Details()
        {
            return string.Format("{0}with {1} marshmallows", base.Details(), this.marshmallows);
        }


    }
}
