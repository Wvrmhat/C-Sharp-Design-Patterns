using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackSmithing
{
    interface ICommandBase
    {
        void Execute();
        void Undo();
    }
}
