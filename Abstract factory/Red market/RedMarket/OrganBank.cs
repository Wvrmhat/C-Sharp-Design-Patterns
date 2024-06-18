using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedMarket
{
    abstract class OrganBank
    {
        public abstract IBrain GetBrain();
        public abstract IHeart GetHeart();

    }
}
