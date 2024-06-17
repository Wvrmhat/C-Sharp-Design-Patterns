using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunAttachments
{
    class Program
    {
        static void Main(string[] args)
        {
            GunBase pistol = new Pistol("USP.45");
            pistol = new ReflexSight(pistol);
            pistol = new ExtendedMag(pistol);

            GunBase sniper = new SniperRifle("Dragunov");
            sniper = new LongBarrel(sniper);
            sniper = new LaserSight(sniper);
            sniper = new ExtendedMag(sniper);

            GunBase rifle = new Rifle("M4 Carbine");
            rifle = new Grip(rifle);
            rifle = new ReflexSight(rifle);

            Console.WriteLine(pistol.specs());
            pistol.gunDetails();

            Console.WriteLine("------------------------------------");

            Console.WriteLine(sniper.specs());
           
            sniper.gunDetails();

            Console.ReadLine();

        }
    }
}
