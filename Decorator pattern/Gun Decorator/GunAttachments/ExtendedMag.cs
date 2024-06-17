using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunAttachments
{
    class ExtendedMag : AttachmentBase
    {
        public ExtendedMag(GunBase gun) : base(gun) { }

        public override void gunDetails()
        {
            base.gunDetails();
            Console.WriteLine($"{base.specs()} now has extended mag: Increased ammo capacity");
        }

        public override string specs()
        {
            return base.specs();
        }
    }
}
