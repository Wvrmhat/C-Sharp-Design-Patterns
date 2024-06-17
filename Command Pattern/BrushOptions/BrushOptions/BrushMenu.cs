using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrushOptions
{
    class BrushMenu      //Receiver
    {
        private bool Draw;
        private bool Erase;
        private int Opacity;
        private int size;
        private string BrushName;


        private const int OPACITY_MAX = 100;
        private const int OPACITY_MIN = 0;
        private int? PreviousOpacity;

        private const int SIZE_MAX = 100;
        private const int SIZE_MIN = 0;
        private int? PreviousSize;

        public BrushMenu()
        {
            this.Draw = false;
            this.Opacity = 100;
            this.size = 10;
            this.BrushName = "Graphite";
        }

        public void DrawSelected()
        {
            this.Draw = true;
            //this.size = this.PreviousSize == null ? 0 : (int)PreviousSize;   // Gets brush size from before erase was selected
            Console.WriteLine("Draw mode selected");

           
        }

        public void EraseSelected()
        {
            this.Erase = true;
            Console.WriteLine("Erase mode selected");
        }

        public void IncreaseOpacity()
        {
            this.Opacity++;

            if(Opacity > OPACITY_MAX)
            {
                Opacity = OPACITY_MAX;
            }
            Console.WriteLine("Opacity {0}%", this.Opacity);
        }

        public void DecreaseOpacity()
        {
            this.Opacity--;
            
            if(Opacity < OPACITY_MIN)
            {
                Opacity = OPACITY_MIN;
            }
            Console.WriteLine("Opacity {0}%", this.Opacity);
        }

        public void IncreaseSize()
        {
            this.size++;
            if (size > SIZE_MAX)
            {
                size = SIZE_MAX;
            }
            Console.WriteLine("Size {0}px", this.size);
        }

        public void DecreaseSize()
        {
            this.size--;
            if(size < SIZE_MIN)
            {
                size = SIZE_MIN;
            }
            Console.WriteLine("Size {0}px", this.size);
        }



        public void SetBrush(string BrushName)
        {
            this.BrushName = BrushName;
            Console.WriteLine("{0} brush selected", this.BrushName);
        }
    }
}
