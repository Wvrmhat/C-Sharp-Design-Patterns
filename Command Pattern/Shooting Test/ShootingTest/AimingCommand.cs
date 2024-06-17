using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootingTest
{
    class AimingCommand : CommandBase
    {
        public GunSlinger gunSlinger;

        public AimingCommand(GunSlinger gunSlinger)
        {
            this.gunSlinger = gunSlinger;
        }

        public void Execute()
        {
            gunSlinger.AimingSelected();
        }

        public void Undo()
        {

        }
    }
}
