using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunAttachments
{
    class AttachmentBase : GunBase      // Decorator Base
    {
        public GunBase gun;

        public AttachmentBase(GunBase gun)
        {
            this.gun = gun;
        }

        public override void gunDetails()
        {
            gun.gunDetails();
        }

        public override string specs()
        {
            return gun.specs();
        }

    }
}
