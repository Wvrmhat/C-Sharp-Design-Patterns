using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootingTest
{
    class SetGunCommand: CommandBase
    {
        private GunSlinger gunSlinger;
        private string Gun = "";

        public SetGunCommand(GunSlinger gunSlinger, string name)
        {
            this.gunSlinger = gunSlinger;
            this.Gun = name;
        }

        public void Execute()
        {
            gunSlinger.SetGun(Gun);
        }

        public void Undo()
        {

        }

    }
}
