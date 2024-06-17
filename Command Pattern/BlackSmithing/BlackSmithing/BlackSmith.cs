using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackSmithing
{
    class BlackSmith        // Receiver
    {
        private bool Hammering;
        private bool Quench;
        private bool Smelting;
        private string Metal;
        private string ForgingSet;
        private int Stamina;
        public bool Eat;
        private const int SP_MAX = 50;
        private const int SP_MIN = 0;

        private int? PrevSP;

        public BlackSmith()
        {
            this.Hammering = false;
            this.Stamina = 50;
            this.ForgingSet = "Sword";
        }

        public void ShapingSelected()
        {
            this.Hammering = true;
            Stamina -= 5;
            //this.Stamina--;
            if(Stamina < SP_MIN)
            {
                Stamina = SP_MIN;
            }
            Console.WriteLine("Shaping {0} {1} weapon", Metal, ForgingSet);
            Console.WriteLine("Current Stamina {0}", this.Stamina);
        }

        public void QuenchSelected()
        {
            this.Quench = true;
            Console.WriteLine("Quenching the {0} {1} blade in water", Metal, ForgingSet);
        }

       

        public void SmeltingSelected(string Metal)
        {
            this.Smelting = true;
            this.Metal = Metal;
            Console.WriteLine("Smelting {0}", this.Metal);
        }

        public void RegainStamina()
        {
            this.Eat = true;
            this.Stamina += 3;

            if(Stamina > SP_MAX)
            {
                Stamina = SP_MAX;
            }
            Console.WriteLine("Enjoying a succulent meal.");
            Console.WriteLine("Current Stamina {0}", this.Stamina);
        }

        public void SetForge(string ForgeSet)
        {
            this.ForgingSet = ForgeSet;
            Console.WriteLine("Forging {0}", this.ForgingSet);
        }

    }
}
