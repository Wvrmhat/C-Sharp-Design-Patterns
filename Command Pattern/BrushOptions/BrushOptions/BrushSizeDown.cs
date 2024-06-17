using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrushOptions
{
    class BrushSizeDown : CommandBase
    {
        private BrushMenu TheBrush;

        public BrushSizeDown(BrushMenu TheBrush)
        {
            this.TheBrush = TheBrush;
        }

        public void Execute()
        {
            TheBrush.DecreaseSize();
        }

        public void Undo()              // No need to revert to previous size
        {
           // TheBrush.IncreaseSize();
        }
    }
}
