using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodExercise
{
    class AluminiumFrame : Frame
    {
        public override void Frame()
        {
            Console.WriteLine("Making aluminium frame");
        }
    }
}
