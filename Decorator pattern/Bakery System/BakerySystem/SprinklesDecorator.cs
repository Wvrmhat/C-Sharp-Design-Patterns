using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakerySystem
{
    class SprinklesDecorator : AdditionsBase
    {
        int Sprinkles;

        public SprinklesDecorator(CakeBase Decorate) : base(Decorate)           // Using component base in the constructor
        {
            //this.Sprinkles = Sprinkles;
        }

        public override string Details()
        {
            return string.Format("{0} added with sprinkles", base.Details());
        }

        public override double Cost()
        {
            return 15 + base.Cost();
        }
    }
}
