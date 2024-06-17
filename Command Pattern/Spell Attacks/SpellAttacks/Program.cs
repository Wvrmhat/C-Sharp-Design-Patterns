using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellAttacks
{
    class Program
    {
        static void Main(string[] args)
        {   
            Mage TheMage = new Mage();              // Receiver
            Spells TheSpell = new Spells();         // Invoker 

            TheSpell.Spell1Com = new SetSpellCommand(TheMage, "Destruction");
            TheSpell.DestrucCom = new DestructionCommand(TheMage, TheSpell, "Inferno");
          
            TheSpell.Spell2Com = new SetSpellCommand(TheMage, "Conjuration");
            TheSpell.ConjurCom = new ConjurationCommand(TheMage,"Summon undead");

            TheSpell.Spell3Com = new SetSpellCommand(TheMage, "Illusion");
            TheSpell.IlluCom = new IllusionCommand(TheMage, "Mass Hysteria");

            CommandBase _decorate = new DestructionCommand();
            TheSpell.DestrucCom(new FlameStatusDecorator(new SetSpellCommand(TheMage, "burn")));


            flameStatus.Execute();


            // TheSpell.SetSpell1();

            TheSpell.Destruction();     //Calls destruction method from INVOKER class
            Console.WriteLine("-------------------------------------------------------");
            TheSpell.Conjuration();
            Console.WriteLine("-------------------------------------------------------");
            TheSpell.Illusion();
            



            //
            

            Console.ReadLine();


        }
    }
}
