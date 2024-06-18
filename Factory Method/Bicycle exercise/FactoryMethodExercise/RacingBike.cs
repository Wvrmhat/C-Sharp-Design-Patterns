using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodExercise
{
    class RacingBike : Bike //concrete product
    {
        public RacingBike()
        {
            this.Name = "Racing Bike";
            this.Description = "Bike for going fast";
            this.Price = "2500";
        }
    }
}
