using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrushOptions
{
    class EraseSelectedCommand : CommandBase
    {
        private BrushMenu TheBrush;

        public EraseSelectedCommand(BrushMenu TheBrush)
        {
            this.TheBrush = TheBrush;
        }

        public void Execute()
        {
            TheBrush.EraseSelected();
        }

        public void Undo()
        {

        }
    }
}
