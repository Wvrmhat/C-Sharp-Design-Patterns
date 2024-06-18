using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            BikeCo bike = new AluminiumWorkshop();
            Bike theBike = bike.OrderBike("Mountain Bike"); //Use OrderBike method since that is the full final product
            theBike = bike.OrderBike("Racing Bike");
            theBike = bike.OrderBike("Tricycle");

           // Console.WriteLine("Bike created: ", theBike.GetType().Name);

            bike = new SteelWorkshop();
            theBike = bike.OrderBike("Mountain Bike");
            theBike = bike.OrderBike("Racing Bike");
            theBike = bike.OrderBike("Tricycle");
          
            //Console.WriteLine("Bike created: ", theBike.GetType().Name);

            Console.ReadLine();
        }
    }
}
