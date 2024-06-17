using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandExample
{
    class PowerOnCommand : CommandBase      //Concrete Command
    {
        private Amplifier TheAmplifier;

       public PowerOnCommand(Amplifier TheAmplifier)
        {
            this.TheAmplifier = TheAmplifier;
        }

        public void Execute()
        {
            TheAmplifier.TurnPowerOn();
        }
        public void Undo()
        {
            TheAmplifier.TurnPowerOff();
        }
    }
}
