using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmouredCore
{
    interface ArmouredCoreFactory              //      ABSTRACT factory
    {
        IHead CreateHead();
        ICore CreateCore();
        IArms CreateArms();

        
       
    }
}
