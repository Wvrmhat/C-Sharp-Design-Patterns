using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunAttachments
{
    class LaserSight : AttachmentBase
    {
        public LaserSight(GunBase gun) : base(gun) { }

        public override void gunDetails()
        {
            base.gunDetails();
            Console.WriteLine($"Laser sight fitted on {base.specs()}: improved hip-fire accuracy");
        }
    }
}
