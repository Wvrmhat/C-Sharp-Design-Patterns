using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackSmithing
{
    class SharpeningForge : Forge //Decorator
    {
       // BaseForge Decorate = null;

       
        public SharpeningForge(IForge Decorate) : base(Decorate)
        {

        }

       //public SharpeningForge(BaseForge Decorate)
       // {
       //     this.Decorate = Decorate;
       // }

        public new void Invoke(ICommandBase command)
        {
            Console.WriteLine("Sharpening blade");
          //  Decorate.Invoke(command);
        }

    
    }
}
