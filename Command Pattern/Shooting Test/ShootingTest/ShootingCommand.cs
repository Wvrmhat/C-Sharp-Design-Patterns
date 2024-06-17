using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootingTest
{
    class ShootingCommand : CommandBase
    {
        private GunSlinger gunSlinger;

        public ShootingCommand(GunSlinger gunSlinger)
        {
            this.gunSlinger = gunSlinger;
        }

        public void Execute()
        {
            gunSlinger.ShootingCommand();
        }

        public void Undo()
        {

        }
    }
}
