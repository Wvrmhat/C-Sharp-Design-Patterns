using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_JavaCo
{
    class Milk : Additives
    {
        int milk;

        public Milk(BeverageComponent DecorateMe, int milk) :base(DecorateMe)
        {
            this.milk = milk;
        }

        public override string Details()
        {
            if (milk == 0)
            {
                return string.Format("{0}with no milk and", base.Details());
            }
            else
                if (milk == 1)
            {
                return string.Format("{0}with froth and", base.Details());
            }
            return string.Format("{0}with milk and", base.Details());


        }
    }
}
