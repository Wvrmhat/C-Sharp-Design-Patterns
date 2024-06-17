using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellAttacks
{
    class SetSpellCommand : CommandBase
    {
        private string TheSpell = "";
        private Mage TheMage;
     //   private Spells Spell;

        public SetSpellCommand(Mage TheMage, string TheSpell)
        {
            this.TheMage = TheMage;
            this.TheSpell = TheSpell;
    
        }

        public void Execute()
        {
            TheMage.SetSpell(TheSpell); // Sets the spell being used by the mage

            
        }

        public void Undo()
        {

        }
    }
}
