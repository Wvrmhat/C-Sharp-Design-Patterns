using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakerySystem
{
    class ChocolateSauceDecorator : AdditionsBase
    {
        public ChocolateSauceDecorator(CakeBase Decorate) : base(Decorate)
        {

        }

        public override string Details()
        {
            return string.Format("{0} and extra chocolate sauce", base.Details());
        }

        public override double Cost()
        {
            return base.Cost() + 17.50;
        }
    }
}
