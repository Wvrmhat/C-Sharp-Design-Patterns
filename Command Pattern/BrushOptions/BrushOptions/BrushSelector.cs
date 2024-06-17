using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrushOptions
{
    sealed class BrushSelector         // Invoker
    {
        public CommandBase DrawCom { get; set; }
        public CommandBase EraseCom { get; set; }
        public CommandBase OpacityUpCom { get; set; }
        public CommandBase OpacityDownCom { get; set; }                      
        public CommandBase SizeUpCom { get; set; }
        public CommandBase SizeDownCom { get; set; }

        public CommandBase BrushName1Com { get; set; }
        public CommandBase BrushName2Com { get; set; }
        public CommandBase BrushName3Com { get; set; }

        public CommandBase MacroCom { get; set; }

        private static BrushSelector _Selection;


        bool bDraw = false;
        bool bErase = false;
        public void Draw()
        {
            if (bDraw)
            {
                DrawCom.Undo();
            }
            else
            {
                DrawCom.Execute();
            }
            bDraw = !bDraw;     // toggles value of bDraw, if it were true then it becomes false.
        }

        public void Erase()
        {
            if(bErase)
            {
                EraseCom.Undo();
            }
            else
            {
                EraseCom.Execute();
            }
            bErase = !bErase;
        }

        public void OpacityUp()
        {
            OpacityUpCom.Execute();
        }
        public void OpacityDown()
        {
            OpacityDownCom.Execute();
        }
        public void SizeUp()
        {
            SizeUpCom.Execute();
        }
        public void SizeDown()
        {
            SizeDownCom.Execute();
        }

        public void SetBrush1()
        {
            BrushName1Com.Execute();
        }
        public void SetBrush2()
        {
            BrushName2Com.Execute();
        }

        public void SetBrush3()
        {
            BrushName3Com.Execute();
        }

        public void Macro()
        {
            MacroCom.Execute();
        }


        public static BrushSelector GetSelection()      // trying to implement singleton 
        {
            if(_Selection == null)
            {
                _Selection = new BrushSelector();
            }
            return _Selection;
        }
    }
}
