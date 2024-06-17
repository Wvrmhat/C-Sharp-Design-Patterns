using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_JavaCo
{
    class Sweetener : Additives
    {
        int sweet;

        public Sweetener(BeverageComponent DecorateMe, int sweet) :base(DecorateMe)
        {
            this.sweet = sweet;
        }

        public override string Details()
        {
                return string.Format("{0} {1} sweetener added",base.Details(), this.sweet);

        }
    }
}
