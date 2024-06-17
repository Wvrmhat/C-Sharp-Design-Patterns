using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootingTest
{
    class ReloadingCommand : CommandBase
    {
        private GunSlinger gunSlinger;

        public ReloadingCommand(GunSlinger gunSlinger)
        {
            this.gunSlinger = gunSlinger;
        }

        public void Execute()
        {
            gunSlinger.ReloadingSelected();
        }

        public void Undo()
        {

        }
    }
}
