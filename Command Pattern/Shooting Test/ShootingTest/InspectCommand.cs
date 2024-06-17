using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootingTest
{
    class InspectCommand : CommandBase
    {
        private GunSlinger gunSlinger;

        public InspectCommand(GunSlinger gunSlinger)
        {
            this.gunSlinger = gunSlinger;
        }

        public void Execute()
        {
            gunSlinger.InspectCommand();
        }

        public void Undo()
        {

        }
    }
}
