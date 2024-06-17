using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunAttachments
{
    class Pistol : GunBase          // Concrete component
    {
        string Name;

        public Pistol(string name)
        {
            this.Name = name;
        }

        public override void gunDetails()
        {
            Console.WriteLine("Base pistol, single-fire");
        }

        public override string specs()
        {
            return "Pistol: " + this.Name;
        }
    }
}
