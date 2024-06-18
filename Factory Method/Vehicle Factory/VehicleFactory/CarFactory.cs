using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleFactory
{
    class CarFactory : VehicleFactory           // CONK CRETE Factory
    {
        public override IVehicle CreateVehicle()
        {
            string name;
            Console.Write("Enter name of car: ");
            name = Console.ReadLine();
            return new Car(name);
        }
    }
}
