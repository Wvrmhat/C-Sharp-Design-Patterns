using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodExercise
{
    abstract class Bike //product base
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }

        public virtual void Frame()
        {
            Console.WriteLine("Making frame");
        }

        public virtual void Wheels()
        {
            Console.WriteLine("Making wheels");
        }
        public virtual void Handles() 
        {
            Console.WriteLine("Making handles");
        }
        public virtual void Brakes()
        {
            Console.WriteLine("Making brkes");
        }
        public virtual void Pedals()
        {
            Console.WriteLine("Making pedals");
        }
        public virtual void Seat()
        {
            Console.WriteLine("Making seat");
        }



    }
}
