using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakerySystem
{
    class ChocGanacheDecorator : AdditionsBase
    {
        int ChocGanache;

        public ChocGanacheDecorator(CakeBase Decorate) : base(Decorate)
        {
           // this.ChocGanache = ChocGanache;
        }

        public override string Details()
        {
            return string.Format("{0} with chocolate ganache", base.Details());
        }

        public override double Cost()
        {
            return 55 + base.Cost();

        }
    }
}
