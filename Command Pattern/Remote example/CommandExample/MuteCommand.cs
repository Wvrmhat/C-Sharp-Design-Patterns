using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandExample
{
    class MuteCommand : CommandBase
    {
        private Amplifier TheAmplifier;

        public MuteCommand(Amplifier TheAmplifier)
        {
            this.TheAmplifier = TheAmplifier;
        }

        public void Execute()
        {
            TheAmplifier.Mute();
        }

        public void Undo()
        {
            TheAmplifier.Unmute();
        }
    }
}
