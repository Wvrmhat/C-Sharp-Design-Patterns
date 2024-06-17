using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakerySystem
{
    class AdditionsBase : CakeBase     // Decorator base
    {
        CakeBase Decorate = null;

        public AdditionsBase(CakeBase Decorate)
        {
            this.Decorate = Decorate;
        }

        public override string Details()
        {
            return Decorate.Details();
        }

        public override double Cost()
        {
            
            return Decorate.Cost();
           
           // return Cost();
        }

    }
}
