using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackSmithing
{
    class ShapingCommand : ICommandBase
    {
        private string Metal = "";
        private BlackSmith TheBlacksmith;

        public ShapingCommand(BlackSmith TheBlacksmith)
        {
            this.TheBlacksmith = TheBlacksmith;
        }

        public void Execute()
        {
            TheBlacksmith.ShapingSelected();
        }

        public void Undo()
        {
            TheBlacksmith.SmeltingSelected(Metal);
        }
    }
}
