using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackSmithing
{
    class SmeltCommand : ICommandBase
    {
        private string Metal = "";
        private BlackSmith TheBlacksmith;

        public SmeltCommand(BlackSmith TheBlacksmith, string Metal)
        {
            this.Metal = Metal;
            this.TheBlacksmith = TheBlacksmith;
           
        }

        public void Execute()
        {
            TheBlacksmith.SmeltingSelected(Metal);
        }
        public void Undo()
        {
            TheBlacksmith.ShapingSelected();
        }
    }
}
