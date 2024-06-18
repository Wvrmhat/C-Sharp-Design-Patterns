using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory carfactory = new CarFactory();
            IVehicle car = carfactory.CreateVehicle();
            car.AddFrame();
            car.AddWheels();
            car.Mirrors();
            car.Engine();
            Console.WriteLine("----------------------------");

            VehicleFactory bikeFactory = new BikeFactory();
            IVehicle bike = bikeFactory.CreateVehicle();
            bike.AddFrame();
            bike.AddWheels();
            bike.Mirrors();
            bike.Engine();
            Console.WriteLine("------------------------------");

            Console.ReadLine();
        }
    }
}
