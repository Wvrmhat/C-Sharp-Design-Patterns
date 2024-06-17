using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakerySystem
{
    class FrostingDecorator : AdditionsBase
    {
        int Frosting;
        
        public FrostingDecorator(CakeBase Decorate) : base(Decorate)            //Make use of the COMPONENT BASE!!!
        {
          //  this.Frosting = Frosting;
        }

        public override string Details()
        {
            return string.Format("{0} with frosting", base.Details(), this.Cost());
            
        }

        public override double Cost()
        {
            return base.Cost() + 22;
        }

    }
}
