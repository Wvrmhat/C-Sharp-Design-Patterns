using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootingTest
{
    class Gun   
    {
        public CommandBase Shoot { get; set; }
        public CommandBase Reload { get; set; }
        public CommandBase Inspect { get; set; }
        public CommandBase Aim { get; set; }

        public CommandBase Gun1Com { get; set; }
        public CommandBase Gun2Com { get; set; }

        bool bAim = false;
        bool bReload = false;
        bool bShoot = false;
        int bullets = 20;

        public void shootCommand()
        {
            if (!bShoot)
            {
                Shoot.Execute();
                bullets--;
            }

        }

        public void ReloadCommand()
        {
            if(!bReload)
            {
                Reload.Execute();
                bullets = 20;
            }
            //else
            //{
            //    Shoot.Undo();
            //}

        }

        public void InspectCommand()
        {
            Inspect.Execute();
           
        }

        public void AimCommand()
        {
            if(!bAim)
            {
                Aim.Execute();
            }
            else
            {
                Aim.Undo();
            }
            bAim = !bAim;
        }

        public void SetGun1()
        {
            Gun1Com.Execute();
        }

        public void SetGun2()
        {
            Gun2Com.Execute();
        }

       

    }
}
