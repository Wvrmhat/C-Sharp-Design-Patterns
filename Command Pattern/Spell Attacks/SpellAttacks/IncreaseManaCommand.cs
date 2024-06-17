using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellAttacks
{
    class IncreaseManaCommand : CommandBase
    {
        private Mage TheMage;

        public IncreaseManaCommand(Mage TheMage)
        {
            this.TheMage = TheMage;
        }

        public void Execute()
        {
            TheMage.IncreaseMana();
        }

        public void Undo()
        {

        }
    }
}
