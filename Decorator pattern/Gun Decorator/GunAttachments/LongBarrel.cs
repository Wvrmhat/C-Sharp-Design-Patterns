using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunAttachments
{
    class LongBarrel    : AttachmentBase
    {
        public LongBarrel(GunBase gun) : base(gun) { }

        public override void gunDetails()
        {
            base.gunDetails();
            Console.WriteLine($"Attached Long barrel to {base.specs()}: Increased damage falloff ranges");
        }
    }
}
