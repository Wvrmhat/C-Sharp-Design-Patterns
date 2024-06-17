using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakerySystem
{
    class StrawberryDecorator : AdditionsBase
    {
        public StrawberryDecorator(CakeBase Decorate) : base(Decorate)
        {

        }

        public override string Details()
        {
            return string.Format("{0} and strawberries on top.", base.Details());
        }

        public override double Cost()
        {
            return base.Cost() + 18;
        }
    }
}
