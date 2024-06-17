using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandExample
{
    class Amplifier     // Reciever
    {
        private bool PowerOn;
        private int Volume;
        private string TheSource;

        private const int VOLUME_MAX = 100;
        private const int VOLUME_MIN = 0;
        private int? PreviousVolume;        //question mark means nullable type

        public Amplifier()
        {
            this.PowerOn = false;
            this.Volume = 0;
            this.TheSource = "DSTV";
        }

        public void TurnPowerOn()
        {
            this.PowerOn = true;
            this.Volume = this.PreviousVolume == null ? 0 : (int)PreviousVolume; //if previous volume = null, if true set volume to 0, else set to previous volum
            Console.Write("Turned power on");
            Console.WriteLine("Set volume to {0}", this.Volume);
        }

        public void TurnPowerOff()
        {
            this.PreviousVolume = Volume;
            this.PowerOn = false;
            Console.WriteLine("Turned power off");
        }
        
        public void Mute()
        {
            this.PreviousVolume = Volume;
            this.Volume = 0;
            Console.WriteLine("Muted volume to {0}", this.Volume);
        }

        public void Unmute()
        {
            this.PreviousVolume = Volume;
            Console.WriteLine("Unmuted to {0}", this.Volume);
        }

        public void IncreaseVolume()
        {
            this.Volume++;

            if (Volume > VOLUME_MAX)
                Volume = VOLUME_MAX;

            Console.WriteLine("Increased volume to {0}", this.Volume);
        }

        public void DecreaseVolume()
        {
            this.Volume--;

            if (Volume < VOLUME_MIN)
                Volume = VOLUME_MIN;

            Console.WriteLine("Decreased volume to {0}", this.Volume);
        }

        public void SetSource(string TheSource)
        {
            this.TheSource = TheSource;
            Console.WriteLine("Set source to {0}", this.TheSource);
        }

    }
}
