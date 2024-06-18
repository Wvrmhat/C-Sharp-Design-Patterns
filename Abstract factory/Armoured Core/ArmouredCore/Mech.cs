using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmouredCore
{
    class Mech      // client base class
    {
        public ArmouredCoreFactory factorybase { get; set; }
       
        public Mech(ArmouredCoreFactory FactoryBase)
        {
            this.factorybase = FactoryBase;
        }

        public void parts()
        {
            factorybase.CreateHead().Head();
            factorybase.CreateCore().Core();
            factorybase.CreateArms().Arms();
        }
    }
}
