﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodExercise
{
    class SteelFrame : Bike
    {
        
        public override void Frame()
        {
            Console.WriteLine("Making Steel Frame");
        }
    }
}
