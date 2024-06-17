using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrushOptions
{
    class BrushOpacityUp : CommandBase     
    {
        private BrushMenu TheBrush;
        
        public BrushOpacityUp(BrushMenu TheBrush)
        {
            this.TheBrush = TheBrush;
        }

        public void Execute()
        {
            TheBrush.IncreaseOpacity();
        }

        public void Undo()
        {
            TheBrush.DecreaseOpacity();
        }

    }
}
