using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackSmithing
{
    class QuenchSelected : ICommandBase
    {
        private BlackSmith TheBlacksmith;

        public QuenchSelected(BlackSmith TheBlacksmith)
        {
            this.TheBlacksmith = TheBlacksmith;
        }

        public void Execute()
        {
            TheBlacksmith.QuenchSelected();
        }

       public void Undo()
        {
           
        }
    }
}
