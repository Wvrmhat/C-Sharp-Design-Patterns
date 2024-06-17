using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandExample
{
    class VolumeUpCommand : CommandBase
    {
        private Amplifier TheAmplifier;

        public VolumeUpCommand(Amplifier TheAmplifier)
        {
            this.TheAmplifier = TheAmplifier;
        }

        public void Execute()
        {
            TheAmplifier.IncreaseVolume();
        }

        public void Undo()
        {
            TheAmplifier.DecreaseVolume();
        }
    }
}
