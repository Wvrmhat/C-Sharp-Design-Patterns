using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackSmithing
{
    class SetForgeCommand : ICommandBase
    {
        private string TheWeapon = "";
        private BlackSmith TheBlacksmith;

        public SetForgeCommand(BlackSmith TheBlacksmith, string TheWeapon)
        {
            this.TheBlacksmith = TheBlacksmith;
            this.TheWeapon = TheWeapon;
        }

        public void Execute()
        {
            TheBlacksmith.SetForge(TheWeapon);
        }

        public void Undo()
        {

        }
    }
}
