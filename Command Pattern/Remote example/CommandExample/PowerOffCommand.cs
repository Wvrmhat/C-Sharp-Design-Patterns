using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandExample
{
    class PowerOffCommand : CommandBase     //Concrete Command
    {
        private Amplifier TheAmplifier;

        public PowerOffCommand(Amplifier TheAmplifier)
        {
            this.TheAmplifier = TheAmplifier;
        }

        public void Execute()
        {
            TheAmplifier.TurnPowerOff();
        }

        public void Undo()
        {
            TheAmplifier.TurnPowerOn();
        }
    }
}
