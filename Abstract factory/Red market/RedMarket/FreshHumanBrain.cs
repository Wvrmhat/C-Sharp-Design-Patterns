using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedMarket
{
    class FreshHumanBrain : OrganHarvest
    {
        public FreshHumanBrain(OrganBank theBank) : base(theBank)
        {
            this.theBrain = this.TheBank.GetBrain();
        }
    }
}
