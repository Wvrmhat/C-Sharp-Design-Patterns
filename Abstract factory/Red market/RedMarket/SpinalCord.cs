using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedMarket
{
    class SpinalCord : OrganHarvest
    {
        public SpinalCord(OrganBank theBank) : base(theBank)
        {
            this.theBrain = this.TheBank.GetBrain();
        }
    }
}
