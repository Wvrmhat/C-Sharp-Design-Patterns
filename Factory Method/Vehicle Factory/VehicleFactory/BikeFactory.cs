using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleFactory
{
    class BikeFactory : VehicleFactory      // Concrete Factory
    {
        public override IVehicle CreateVehicle()            // overrides method in factory base
        {
            // Console.WriteLine("Creating bike");
            string name;
            Console.Write("Enter name of bike: ");
            name = Console.ReadLine();

            return new Bike(name);
        }
    }
}
