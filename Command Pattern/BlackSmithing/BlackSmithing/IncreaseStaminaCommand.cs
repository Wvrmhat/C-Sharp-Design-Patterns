using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackSmithing
{
    class IncreaseStaminaCommand : ICommandBase
    {
        private BlackSmith TheBlackSmith;

        public IncreaseStaminaCommand(BlackSmith blackSmith)
        {
            this.TheBlackSmith = blackSmith;
        }

        public void Execute()
        {
            TheBlackSmith.RegainStamina();
        }
        public void Undo()
        {

        }
    }
}
