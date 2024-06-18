using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleFactory
{
    interface IVehicle                   // Product base class
    {
        //public string Name { get; set; }
        //public string Description { get; set; }
        //public string Price { get; set; }

        void AddWheels();
        void AddFrame();
        void Mirrors();
        void Engine();


    }
}
