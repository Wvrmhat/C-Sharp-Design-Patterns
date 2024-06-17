using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandExample
{
    class SetSourceCommand : CommandBase
    {
        private string TheSource = "";
        private Amplifier TheAmplifier;

        public SetSourceCommand(Amplifier TheAmplifier, string TheSource)
        {
            this.TheAmplifier = TheAmplifier;
            this.TheSource = TheSource;
        }

        public void Execute()
        {
            TheAmplifier.SetSource(TheSource);
        }

        public void Undo()
        {

        }
    }
}
