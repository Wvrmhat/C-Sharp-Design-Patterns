using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleFactory
{
    abstract class VehicleFactory           // Factory base 
    {
      
        public abstract IVehicle CreateVehicle();    // factory method defined as abstract method, derived classes (those that inherit this current class), may be overrided to provide their own implementation.
    }
}
