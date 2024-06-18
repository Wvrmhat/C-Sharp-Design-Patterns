using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodExercise
{
    abstract class BikeCo //factory base, template where factory method will be called
    {
        //public abstract Frame Frame();
        public Bike OrderBike(string BikeName) //method that returns Bike which will be the final product
        {
            Bike ReturnMe = MakeBike(BikeName);

            Console.WriteLine("Creating: " + ReturnMe.GetType().Name);
            ReturnMe.Frame();
            ReturnMe.Wheels();
            ReturnMe.Handles();
            ReturnMe.Pedals();
            ReturnMe.Seat();

            Console.WriteLine("-----------");

            return ReturnMe;
        }
        public abstract Bike MakeBike(string BikeName); // The factory method, derived classes implement it.
    }
}
