using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunAttachments
{
    class ReflexSight : AttachmentBase  // Concrete Decorator
    {
        public ReflexSight(GunBase gun) : base(gun) { }

        public override void gunDetails()
        {
            base.gunDetails();
            Console.WriteLine($"Attaching a reflex sight to {base.specs()}");      // same as {0} with base.details()

        }

        public override string specs()
        {
            return base.specs();
        }
    }
}
