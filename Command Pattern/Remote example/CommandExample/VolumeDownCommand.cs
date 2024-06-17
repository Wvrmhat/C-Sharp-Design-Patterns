using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandExample
{
    class VolumeDownCommand : CommandBase
    {
        private Amplifier TheAmplifier;

        public VolumeDownCommand(Amplifier TheAmplifier)
        {
            this.TheAmplifier = TheAmplifier;
        }

        public void Execute()
        {
            TheAmplifier.DecreaseVolume();
        }

        public void Undo()
        {
            TheAmplifier.IncreaseVolume();
        }
    }
}
