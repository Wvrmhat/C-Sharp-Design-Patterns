using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackSmithing
{
    interface IForge  // Component base??
    {
         void Invoke(ICommandBase command);
       // void Details(string details);
    }
}
