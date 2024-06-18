using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleFactory
{
    class Car : IVehicle                // conk crete product
    {
        //public string Name { get; set; }
        //public string Description { get; set; }
        //public string Price { get; set; }

        public Car(string name)
        {
            Console.WriteLine($"Creating {name} car");          
        }

        public void AddWheels()
        {
            Console.WriteLine("Adding racing wheels to car");
        }

        public void AddFrame()
        {
            Console.WriteLine("Fitting a titanium frame");
        }

        public void Mirrors()
        {
            Console.WriteLine("Dynamic side-mirrors");
        }

        public void Engine()
        {
            Console.WriteLine("V9 engine installed");
        }
    }
}
