using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakerySystem
{
    class Cheesecake : CakeBase
    {
        string Name;

        public Cheesecake(string Name)
        {
            this.Name = Name;
        }

        public override string Details()
        {
            return string.Format("Cheesecake: {0}", this.Name);
        }

        public override double Cost()
        {
            Console.Write("R");
            return 44.73;
        }

 
    }
}
