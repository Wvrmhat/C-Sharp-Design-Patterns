using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrushOptions
{
    class BrushOpacityDown : CommandBase
    {
        private BrushMenu TheBrush;

        public BrushOpacityDown(BrushMenu TheBrush)
        {
            this.TheBrush = TheBrush;
        }

        public void Execute()
        {
            TheBrush.DecreaseOpacity();
        }

        public void Undo()
        {
            TheBrush.IncreaseOpacity();
        }
    }
}
