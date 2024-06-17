using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrushOptions
{
    class BrushSizeUp : CommandBase
    {
        private BrushMenu TheBrush;

        public BrushSizeUp(BrushMenu TheBrush)
        {
            this.TheBrush = TheBrush;
        }

        public void Execute()
        {
            TheBrush.IncreaseSize();
        }

        public void Undo()
        {
           // TheBrush.DecreaseSize();
        }
    }
}
