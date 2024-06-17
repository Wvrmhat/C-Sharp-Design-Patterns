using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootingTest
{
    class GunSlinger
    {
        private bool Shooting;
        private bool Reloading;
        private bool Aiming;
        private bool Inspecting;
        private int Bullets;

       // private string Gun;
        private string GunSet;

        private const int B_MAX = 20;
        private const int B_MIN = 0;

        private int? PrevB;

        public GunSlinger()
        {
            this.Shooting = false;
            this.Bullets = 20;
            this.GunSet = "M14 Rifle";
        }

        public void ShootingCommand()
        {
            string[] choice = { "R"};
            string reload;

            this.Reloading = false;
            this.Shooting = false;
            Bullets--;

            Random rn = new Random();
            int accuracy = rn.Next(40, 100);

            Console.WriteLine($"You shot with {accuracy} accuracy\n Amount of bullets left are {Bullets}");

            if(Bullets < B_MIN)
            {
                Bullets = B_MIN;

                Console.WriteLine("Out of ammo, press R to reload");

                try
                {
                    reload = Console.ReadLine();
                    Reloading = choice.Contains(reload);
                    this.Reloading = true;

                    Console.WriteLine("Reloaded successfully");

                    Bullets = B_MAX;

                }
                catch
                {
                    Console.WriteLine("Press R to reload.");
                }

            }



            
        }

        public void ReloadingSelected()
        {
            this.Reloading = true;

            string[] choice = { "Y", "N" };

            string reload;


            do
            {
                Console.WriteLine("Would you like to reload? Y | N");
                reload = Console.ReadLine().ToUpper();

                Reloading = choice.Contains(reload);

                if(reload == "N")
                {
                    Console.WriteLine("You decided to not reload and die");

                }
                else
                {
                    if (Reloading == true && reload == "Y")
                    {
                        Console.WriteLine("Reloading your weapon");

                    }

                    if (Bullets > B_MAX)
                    {
                        Bullets = B_MAX;
                    }
                }

            } while (!Reloading);  

        }

        public void AimingSelected()
        {
            this.Aiming = true;

            Random rn = new Random();

            int accuracy = rn.Next(75, 100);

            Console.WriteLine("Aiming down your sights and increased accuracy");

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Would you like to shoot? Y | N");

            string[] choices = { "Y", "N" };
            string shoot;

            do
            {
                this.Shooting = false;
                shoot = Console.ReadLine().ToUpper();
                Shooting = choices.Contains(shoot);

                if (shoot == "Y")
                {
                    ShootingCommand();
                }
                else
                {
                    Console.WriteLine("You decided to not shoot.");
                }
            } while (!Aiming);


        }



        public void InspectCommand()
        {
            this.Inspecting = true;

            Console.WriteLine("Inspecting {0}", GunSet);
            Console.WriteLine($"You have {Bullets} in mag");
        }

        public void SetGun(string GunSet)
        {
            this.GunSet = GunSet;
            Console.WriteLine("Using {0}", this.GunSet);
        }



    }
}
