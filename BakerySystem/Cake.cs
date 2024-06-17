using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakerySystem
{
    class Cake : CakeBase            //concrete component
    {
        string Name;
       // double price = 20;

        public Cake(string Name)
        {
            this.Name = Name;
           // this.price = Price;

        }

        public override string Details()
        {
            return "Cake: " + this.Name;
           
        }

        public override double Cost()       
        {
            Console.Write("R");
            return 20;
        }
    }
}
