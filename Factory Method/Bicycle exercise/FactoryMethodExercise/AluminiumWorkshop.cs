using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodExercise
{
    class AluminiumWorkshop : BikeCo //concrete factory
    {
        private Frame _frame;
        public AluminiumWorkshop()
        {
            _frame = new AluminiumFrame();
        }
        public override Bike MakeBike(string BikeName) 
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
        public override Frame()
        {
            return new AluminiumFrame();
        }
    }
}
