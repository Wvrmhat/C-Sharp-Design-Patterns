using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellAttacks
{
    class Mage      // Receiver
    {
        private bool Cast;
        private bool Charge;
        private bool Destruction;
        private bool Conjuration;
        private bool Illusion;
        private int Mana;
        private string SpellSet;

        private const int MANA_MAX = 1000;
        private const int MANA_MIN = 0;

        private int? PrevMana;

        public Mage()
        {
            this.Cast = false;
            this.Mana = 1000;
            this.SpellSet = "Destruction";
        }

        public void CastSpell()
        {
            this.Cast = true;

            this.Mana--;
            if(Mana < MANA_MIN)
            {
                Mana = MANA_MIN;    
            }
            

           // this.Mana = this.PrevMana == null ? 0 : (int)PrevMana;
            Console.WriteLine("Casting {0} spell", SpellSet);
            Console.WriteLine("Current Mana {0}\n", this.Mana);
        }

        public void DestructionSelected()
        {
            this.Destruction = true;
            Console.WriteLine("Using destruction stance.");
        }
        public void ConjurationSelected()
        {
            this.Conjuration = true;
            Console.WriteLine("Using conjuration stance.");
        }
        public void IllusionSelected()
        {
            this.Illusion = true;
            Console.WriteLine("Using illusion stance.");
        }

        public void Uncast()
        {
            this.Cast = false;
            Console.WriteLine("Retracting spell...");
        }

        public void IncreaseMana()
        {
            this.Charge = true;

            this.Mana++;
            if(Mana > MANA_MAX)
            {
                Mana = MANA_MAX;
            }
            Console.WriteLine("Mana increased by {0}", this.Mana);

        }

        public void SetSpell(string SpellSet)
        {
            this.SpellSet = SpellSet;
            Console.WriteLine("Using spell set {0}", this.SpellSet);
        }

        


    }
}
