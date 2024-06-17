using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunAttachments
{
    class Rifle : GunBase       // inherits or has dependency on the Gunbase
    {
        string Name;

        public Rifle(string name)
        {
            this.Name = name;

        }

        public override void gunDetails()
        {
            Console.WriteLine("Base rifle, fires automatically");
        }

        public override string specs()
        {
            return "Rife: " + this.Name;
        }
    }
}
