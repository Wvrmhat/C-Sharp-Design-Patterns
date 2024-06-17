using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellAttacks
{
    class IllusionCommand : CommandBase
    {
        private string SpellName = "";
        private Mage TheMage;

        public IllusionCommand(Mage TheMage, string SpellName)
        {
            this.SpellName = SpellName;
            this.TheMage = TheMage;
        }

        public void Execute()
        {
            TheMage.IllusionSelected();
            TheMage.SetSpell(SpellName);
            TheMage.CastSpell();
        }

        public void Undo()
        {
            TheMage.Uncast();
        }


    }
}
