using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackSmithing
{
    class BaseForge : IForge        //ComponentBASE
    {
        public void Invoke(ICommandBase command)
        {
            command.Execute();
        }

        public virtual string Details()
        {
            return "Weapon: ";
        }
    }
}
