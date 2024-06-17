using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrushOptions
{
    class DrawSelected : CommandBase
    {
        private BrushMenu TheBrush;

        public DrawSelected(BrushMenu TheBrush)
        {
            this.TheBrush = TheBrush;
        }

        public void Execute()
        {
            TheBrush.DrawSelected();
        }

        public void Undo()
        {

        }

    }
}
