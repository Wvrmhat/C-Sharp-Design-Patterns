using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrushOptions
{
    class Program
    {
        static void Main(string[] args)
        {
            BrushMenu TheBrush = new BrushMenu();           // Receiver (for context it is a toolbar of different brushes to choose from)
            /*BrushSelector Option = new BrushSelector();*/     // Invoker  (What the user will select)
            BrushSelector Option = BrushSelector.GetSelection();        // using singleton?????


            Option.BrushName1Com = new SetBrushCommand(TheBrush, "Graphite");      
            Option.DrawCom = new DrawSelected(TheBrush);
            Option.SizeDownCom = new BrushSizeDown(TheBrush);
            Option.OpacityDownCom = new BrushOpacityDown(TheBrush);

            Option.BrushName2Com = new SetBrushCommand(TheBrush, "Wet Bristles");
            Option.EraseCom = new EraseSelectedCommand(TheBrush);            // Access member named BrushName1Com, and creates a new instance (new instantiates objects)
                                                                             // of EraseSelectedCommand class, passing TheBrush as an argument to its contrsucter

         
            

            //for(int i = 50; i <= 100; i++)
            //{
            //    Option.SizeDown();
            //}

            Option.SetBrush1();
            Option.Draw();
            Option.SizeDown();
            Option.OpacityDown();

            Option.SetBrush2();
            Option.Erase();

            Console.ReadLine();


        }
    }
}
