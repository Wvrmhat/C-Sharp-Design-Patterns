using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_JavaCo
{
    class Drink : BeverageComponent
    {
        string Name;
        int count = 1;
    
        
        
        public Drink(string Name)
        {
            this.Name = Name;
        }

        public override string Details()
        {
            return "Drink: " + this.Name;
        }
    }
}
