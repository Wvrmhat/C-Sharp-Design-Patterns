using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellAttacks
{
    class ConjurationCommand : CommandBase
    {
        private string SpellName = "";
        private Mage TheMage;

        public ConjurationCommand(Mage TheMage, string SpellName)
        {
            this.SpellName = SpellName;
            this.TheMage = TheMage;
        }

        public void Execute()
        {
            TheMage.ConjurationSelected();
            TheMage.SetSpell(SpellName);
            TheMage.CastSpell();
        }

        public void Undo()
        {
            TheMage.Uncast();
        }


    }
}
