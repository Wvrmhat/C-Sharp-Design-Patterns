using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmouredCore
{
    class Program
    {
        static void Main(string[] args)
        {
            ArmouredCoreFactory alpha = new AlphaFactory();        // We instantiate AlphaFactory (meaning it is created from a class/interface), which implements the factory needed to create the components.
            Mech AlphaRobot = new Mech(alpha);                     // An instance of the Mech is created by passing the "alphafactory" into its constructor
            Console.WriteLine("Assembling alpha robot: ");
            AlphaRobot.parts();                                   // Parts are called on the AlphaRobot. this method invokes allll the methods which are used to assemble the robot

            Console.WriteLine("---------------------------");

            ArmouredCoreFactory chonker = new MelanderFactory();
            Mech GundamRobot = new Mech(chonker);
            Console.WriteLine("Assembling the player's robot: ");
            GundamRobot.parts();


            Console.WriteLine("---------------------------");

            Console.ReadLine();


        }
    }
}
