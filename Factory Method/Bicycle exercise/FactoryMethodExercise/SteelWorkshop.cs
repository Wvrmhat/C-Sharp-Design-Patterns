using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodExercise
{
    class SteelWorkshop : BikeCo //Concrete factory
    {

        public override Bike MakeBike(string BikeName) //deriving the factory method
        {
            Bike theBike = null;

        

            if (BikeName == "Mountain Bike")
                theBike = new MountainBike();
            if (BikeName == "Racing Bike")
                theBike = new RacingBike();
            if (BikeName == "Tricycle")
                theBike = new Tricycle();

            return theBike;
        }
        class SteelFrame : Bike 
        {
            public override void Frame() 
            {       
                Console.WriteLine("Using Steel frame");
            }

        }

    }
}
