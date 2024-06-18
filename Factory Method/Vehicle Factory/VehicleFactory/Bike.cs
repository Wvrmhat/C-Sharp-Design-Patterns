using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleFactory
{
    class Bike : IVehicle       // concrete product
    {
        public Bike(string name)
        {
            Console.WriteLine($"Creating {name} bike");
        }

        public void AddFrame()
        {
            Console.WriteLine("Adding steel bike frame");
        }

        public void AddWheels()
        {
            Console.WriteLine("Both wheels fitted");
        }

        public void Engine()
        {
            Console.WriteLine("Kawasaki engine installed blah blah blah");
        }

        public void Mirrors()
        {
            Console.WriteLine("Side-mirros installed and checked");
        }
    }
}
