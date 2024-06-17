using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellAttacks
{
    class DestructionCommand : CommandBase
    {
        private string SpellName = "";
        private Mage TheMage;           // Calls the Mage Receiver.
        private Spells SpellAttack;         // Implement separate spells???

        public DestructionCommand(Mage TheMage, Spells SpellAttack, string SpellName)
        {
            this.TheMage = TheMage;
            this.SpellAttack = SpellAttack;
            this.SpellName = SpellName;

            //if (SpellName == "Destruction")
            //{
            //    SpellAttack.SetSpell1();

            //    Console.WriteLine("Used fireball");


            //    SpellAttack.SetSpell2();
            //    {
            //        Console.WriteLine("Used inferno");
            //    }
            //}
        }

        public void Execute()       // Executes the metbhods from the RECEIVER Mage class.
        {
            TheMage.DestructionSelected();
            TheMage.SetSpell(SpellName);
            TheMage.CastSpell();
            
        }

        public void Undo()
        {
           TheMage.Uncast();    //Option to retract spell 
        }

    }
}
