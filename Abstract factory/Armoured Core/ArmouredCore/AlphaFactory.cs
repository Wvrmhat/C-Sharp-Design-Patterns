using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmouredCore
{
    class AlphaFactory  : ArmouredCoreFactory            // CONKCRETEE FACTORY
    {
        public IHead CreateHead()
        {
            return new AlphaHead();
        }

        public IArms CreateArms()
        {
            return new AlphaArms();
        }

        public ICore CreateCore()
        {
            return new AlphaCore();
        }
    }
}
