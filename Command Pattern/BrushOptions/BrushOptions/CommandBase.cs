using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrushOptions
{
     interface CommandBase            // Command interface
    {
        void Execute(); 
        void Undo(); 
    }
}
