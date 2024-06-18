using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodExercise
{
    class Tricycle : Bike //concrete product
    {
        public Tricycle()
        {
            this.Name = "Tricycle";
            this.Description = "Bike for praticing";
            this.Price = "1000";
        }
    }
}
