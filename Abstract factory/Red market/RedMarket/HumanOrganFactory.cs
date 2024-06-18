using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedMarket
{
    class HumanOrganFactory : OrganBank // CONCRETE FACTORY
    {
        public override IBrain GetBrain()
        {
            return new HumanBrain();
        }

        public override IHeart GetHeart()
        {
            return new HumanHeart();
        }
    }
}
