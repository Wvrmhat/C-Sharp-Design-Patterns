using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodExercise
{
    class MountainBike : Bike //concrete product
    {
        public MountainBike()
        {
            this.Name = "Mountain Bike";
            this.Description = "Bike used for traversing hills";
            this.Price = "3000";
        }
    }
}
