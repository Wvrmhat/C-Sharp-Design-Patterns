using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_JavaCo
{
    class Lemon : Additives
    {


        public Lemon(BeverageComponent DecorateMe) :base(DecorateMe)
        {

        }

        public override string Details()
        {
            return string.Format("{0}with lemon", base.Details());
        }
    }
}
