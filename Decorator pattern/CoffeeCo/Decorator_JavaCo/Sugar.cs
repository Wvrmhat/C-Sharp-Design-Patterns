using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_JavaCo
{
    class Sugar : Additives
    {
        int sugar;

        public Sugar(BeverageComponent DecorateMe, int sugar) :base(DecorateMe)
        {
            this.sugar = sugar;
        }

        public override string Details()
        {
            if (sugar == 1)
                return string.Format("{0} {1} sugar",base.Details(), this.sugar);
            else
                return string.Format("{0} {1} sugars", base.Details(), this.sugar);
        }
    }
}
