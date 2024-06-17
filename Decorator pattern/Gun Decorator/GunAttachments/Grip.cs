using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunAttachments
{
    class Grip : AttachmentBase
    {
        public Grip(GunBase gun) : base(gun) { }

        public override void gunDetails()
        {
            base.gunDetails();
            Console.WriteLine($"Additional grip attached to {gun.GetType().Name}: reduced recoil when aiming down the sight");
        }
    }
}
