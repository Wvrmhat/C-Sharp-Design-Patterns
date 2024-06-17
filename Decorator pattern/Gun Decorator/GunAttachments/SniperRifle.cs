using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunAttachments
{
    class SniperRifle : GunBase
    {
        string Name;

        public SniperRifle(string name)
        {
            this.Name = name;
        }


        public override void gunDetails()
        {
            Console.WriteLine("Sniper rifle, for firing from a long-range");
        }

        public override string specs()
        {
            return "Sniper rifle: " + this.Name;
        }
    }
}
