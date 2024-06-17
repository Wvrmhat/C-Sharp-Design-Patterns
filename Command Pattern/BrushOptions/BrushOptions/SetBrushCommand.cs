using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrushOptions
{
    class SetBrushCommand : CommandBase
    {
        private string BrushName = "";
        private BrushMenu TheBrush;

        public SetBrushCommand(BrushMenu TheBrush, string BrushName)
        {
            this.TheBrush = TheBrush;
            this.BrushName = BrushName;

        }

        public void Execute()
        {
            TheBrush.SetBrush(BrushName);
        }

        public void Undo()
        {

        }


    }
}
