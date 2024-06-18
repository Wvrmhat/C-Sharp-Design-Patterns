using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmouredCore
{
    class MelanderFactory : ArmouredCoreFactory
    {
        public IHead  CreateHead()
        {
            return new MelanderHead();
        }

        public IArms CreateArms()
        {
            return new EphemeraArms();
        }

        public ICore CreateCore()
        {
            return new FirmezaCore();
        }
    
    }
}
