using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            GunSlinger player = new GunSlinger();
            Gun actions = new Gun();
            int option;
            int[] choices = { 1, 2, 3, 4 };

            actions.Gun1Com = new SetGunCommand(player, "rifle");
            actions.Inspect = new InspectCommand(player);
            actions.Shoot = new ShootingCommand(player);
            actions.Aim = new AimingCommand(player);
            actions.Reload = new ReloadingCommand(player);



            actions.SetGun1();
            //actions.InspectCommand();
            //actions.shootCommand();
            //actions.AimCommand();
            //actions.ReloadCommand();

            for(int i = 0; i < 100; i++)
            {
                Console.WriteLine("1. Inspect\n2. Shoot\n3. Aim\n4. Reload");

                Console.WriteLine("------------------------------------------");

                try
                {
                    option = int.Parse(Console.ReadLine());
                    bool selection = choices.Contains(option);
                }

                catch
                {
                    option = 0;
                }

                switch(option)
                {
                    case 1:
                        actions.InspectCommand();
                        break;

                    case 2:
                        actions.shootCommand();
                        break;

                    case 3:
                        actions.AimCommand();
                        break;

                    case 4:
                        actions.ReloadCommand();
                        break;

                    default:
                        Console.Write("Invalid input.");

                        break;
                }

            }



            Console.ReadLine();
        }
    }
}
